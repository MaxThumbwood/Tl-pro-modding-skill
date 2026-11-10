// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.UIPopupTextManager
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;

#nullable disable
namespace Terraria.GameContent.UI;

public class UIPopupTextManager
{
  public const int maxItemText = 20;
  public UIPopupText[] popupText = new UIPopupText[20];
  public int numActive;

  public void ResetText(UIPopupText text)
  {
    text.scale = 0.0f;
    text.rotation = 0.0f;
    text.alpha = 1f;
    text.alphaDir = -1;
    text.framesSinceSpawn = 0;
  }

  public int NewText(UIAdvancedPopupRequest request)
  {
    if (!Main.showItemText || Main.netMode == 2)
      return -1;
    int nextItemTextSlot = this.FindNextItemTextSlot();
    if (nextItemTextSlot >= 0)
    {
      string text1 = request.Text;
      Vector2 vector2 = FontAssets.MouseText.Value.MeasureString(text1);
      UIPopupText text2 = this.popupText[nextItemTextSlot];
      this.ResetText(text2);
      text2.active = true;
      text2.position = request.Position;
      if (request.Alignment >= UIPopupTextAlignment.BottomLeft)
        text2.position.Y -= vector2.Y;
      else if (request.Alignment >= UIPopupTextAlignment.MidLeft)
        text2.position.Y -= vector2.Y / 2f;
      switch ((int) request.Alignment % 3)
      {
        case 1:
          text2.position.X -= vector2.X / 2f;
          break;
        case 2:
          text2.position.X -= vector2.X;
          break;
      }
      text2.name = text1;
      text2.velocity = request.Velocity;
      text2.lifeTime = request.DurationInFrames;
      text2.context = request.Context;
      text2.color = request.Color;
      text2.PrepareDisplayText();
    }
    return nextItemTextSlot;
  }

  private int FindNextItemTextSlot()
  {
    int nextItemTextSlot = -1;
    for (int index = 0; index < 20; ++index)
    {
      if (!this.popupText[index].active)
      {
        nextItemTextSlot = index;
        break;
      }
    }
    if (nextItemTextSlot == -1)
    {
      double num = (double) Main.bottomWorld;
      for (int index = 0; index < 20; ++index)
      {
        if (num > (double) this.popupText[index].position.Y)
        {
          nextItemTextSlot = index;
          num = (double) this.popupText[index].position.Y;
        }
      }
    }
    return nextItemTextSlot;
  }

  public void UpdateItemText()
  {
    int num = 0;
    for (int whoAmI = 0; whoAmI < 20; ++whoAmI)
    {
      if (this.popupText[whoAmI].active)
      {
        ++num;
        this.popupText[whoAmI].Update(whoAmI, this);
      }
    }
    this.numActive = num;
  }

  public void ClearAll()
  {
    for (int index = 0; index < 20; ++index)
      this.popupText[index] = new UIPopupText();
    this.numActive = 0;
  }

  public void DrawItemTextPopups(float scaleTarget)
  {
    SpriteBatch spriteBatch = Main.spriteBatch;
    for (int index1 = 0; index1 < 20; ++index1)
    {
      UIPopupText uiPopupText = this.popupText[index1];
      if (uiPopupText.active)
      {
        string displayText = uiPopupText.displayText;
        Vector2 vector2_1 = FontAssets.MouseText.Value.MeasureString(displayText);
        Vector2 vector2_2 = new Vector2(vector2_1.X * 0.5f, vector2_1.Y * 0.5f);
        float num1 = scaleTarget;
        float num2 = uiPopupText.scale / num1;
        int num3 = (int) ((double) byte.MaxValue - (double) byte.MaxValue * (double) num2);
        float r = (float) uiPopupText.color.R;
        double g = (double) uiPopupText.color.G;
        double b = (double) uiPopupText.color.B;
        float a = (float) uiPopupText.color.A;
        float num4 = r * (float) ((double) num2 * (double) uiPopupText.alpha * 0.30000001192092896);
        double alpha1 = (double) uiPopupText.alpha;
        double alpha2 = (double) uiPopupText.alpha;
        float num5 = a * (num2 * uiPopupText.alpha);
        Color color1 = Color.Black;
        float num6 = 1f;
        Texture2D texture2D = (Texture2D) null;
        if (uiPopupText.context == UIPopupTextContext.SpecialSeed)
        {
          color1 = Main.hslToRgb((float) ((double) Main.GlobalTimeWrappedHourly * 0.60000002384185791 % 1.0), 1f, 0.6f) * 0.6f;
          num1 *= 0.5f;
          num6 = 0.8f;
        }
        int fromMax = 40;
        Utils.EaseOutCirc((double) Utils.Remap((float) uiPopupText.framesSinceSpawn, 0.0f, (float) fromMax, 0.0f, 1f));
        float num7 = (float) num3 / (float) byte.MaxValue;
        for (int index2 = 0; index2 < 5; ++index2)
        {
          Color color2 = color1;
          float num8 = 0.0f;
          float num9 = 0.0f;
          if (index2 == 0)
            num8 -= num1 * 2f;
          else if (index2 == 1)
            num8 += num1 * 2f;
          else if (index2 == 2)
            num9 -= num1 * 2f;
          else if (index2 == 3)
            num9 += num1 * 2f;
          else
            color2 = uiPopupText.color * num2 * uiPopupText.alpha * num6;
          if (index2 < 4)
          {
            num5 = (float) uiPopupText.color.A * num2 * uiPopupText.alpha;
            color2 = new Color(0, 0, 0, (int) num5);
          }
          if (color1 != Color.Black && index2 < 4)
          {
            num8 *= (float) (1.2999999523162842 + 1.2999999523162842 * (double) num7);
            num9 *= (float) (1.2999999523162842 + 1.2999999523162842 * (double) num7);
          }
          float num10 = uiPopupText.position.X + num8;
          float num11 = uiPopupText.position.Y + num9;
          if (color1 != Color.Black && index2 < 4)
          {
            Color color3 = color1 with
            {
              A = (byte) MathHelper.Lerp(60f, (float) sbyte.MaxValue, Utils.GetLerpValue(0.0f, (float) byte.MaxValue, num5, true))
            };
            DynamicSpriteFontExtensionMethods.DrawString(spriteBatch, FontAssets.MouseText.Value, displayText, new Vector2(num10 + vector2_2.X, num11 + vector2_2.Y), Color.Lerp(color2, color3, 0.5f), uiPopupText.rotation, vector2_2, uiPopupText.scale, SpriteEffects.None, 0.0f, (Vector2[]) null, (Color[]) null);
            DynamicSpriteFontExtensionMethods.DrawString(spriteBatch, FontAssets.MouseText.Value, displayText, new Vector2(num10 + vector2_2.X, num11 + vector2_2.Y), color3, uiPopupText.rotation, vector2_2, uiPopupText.scale, SpriteEffects.None, 0.0f, (Vector2[]) null, (Color[]) null);
          }
          else
            DynamicSpriteFontExtensionMethods.DrawString(spriteBatch, FontAssets.MouseText.Value, displayText, new Vector2(num10 + vector2_2.X, num11 + vector2_2.Y), color2, uiPopupText.rotation, vector2_2, uiPopupText.scale, SpriteEffects.None, 0.0f, (Vector2[]) null, (Color[]) null);
          if (texture2D != null)
          {
            float scale = (float) ((1.2999999523162842 - (double) num7) * (double) uiPopupText.scale * 0.699999988079071);
            Vector2 vector2_3 = new Vector2(num10 + vector2_2.X, num11 + vector2_2.Y);
            Color color4 = color1 * 0.6f;
            if (index2 == 4)
              color4 = Color.White * 0.6f;
            color4.A = (byte) ((double) color4.A * 0.5);
            int num12 = 25;
            spriteBatch.Draw(texture2D, vector2_3 + new Vector2((float) ((double) vector2_2.X * -0.5 - (double) num12 - (double) texture2D.Size().X / 2.0), 0.0f), new Rectangle?(), color4 * uiPopupText.scale, 0.0f, texture2D.Size() / 2f, scale, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(texture2D, vector2_3 + new Vector2((float) ((double) vector2_2.X * 0.5 + (double) num12 + (double) texture2D.Size().X / 2.0), 0.0f), new Rectangle?(), color4 * uiPopupText.scale, 0.0f, texture2D.Size() / 2f, scale, SpriteEffects.None, 0.0f);
          }
        }
      }
    }
  }
}
