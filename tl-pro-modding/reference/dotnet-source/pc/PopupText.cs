// Decompiled with JetBrains decompiler
// Type: Terraria.PopupText
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using System;
using Terraria.GameContent;
using Terraria.Localization;

#nullable disable
namespace Terraria;

public class PopupText
{
  public const int maxItemText = 20;
  public static PopupText[] popupText = new PopupText[20];
  public Vector2 position;
  public Vector2 velocity;
  public float alpha;
  public int alphaDir = 1;
  public string name;
  public string displayText;
  public long stack;
  public float scale = 1f;
  public float rotation;
  public Color color;
  public bool active;
  public int lifeTime;
  public int framesSinceSpawn;
  public static int activeTime = 60;
  public static int numActive;
  public bool NoStack;
  public bool coinText;
  public long coinValue;
  public static int sonarText = -1;
  public bool expert;
  public bool master;
  public bool sonar;
  public PopupTextContext context;
  public int npcNetID;
  public bool freeAdvanced;
  public Vector2[] charOffsets;
  public Color[] charColors;
  public PopupEffectStyle effectStyle;
  public int effectIntensity;

  public bool AnyEffect => this.effectStyle != 0;

  public bool notActuallyAnItem => this.npcNetID != 0 || this.freeAdvanced;

  public static float TargetScale => Main.UIScale / Main.GameViewMatrix.RenderZoom.X;

  public static void ClearSonarText()
  {
    if (PopupText.sonarText < 0 || !PopupText.popupText[PopupText.sonarText].sonar)
      return;
    PopupText.popupText[PopupText.sonarText].active = false;
    PopupText.sonarText = -1;
  }

  public static void ResetText(PopupText text)
  {
    text.NoStack = false;
    text.coinText = false;
    text.coinValue = 0L;
    text.sonar = false;
    text.npcNetID = 0;
    text.expert = false;
    text.master = false;
    text.freeAdvanced = false;
    text.scale = 0.0f;
    text.rotation = 0.0f;
    text.alpha = 1f;
    text.alphaDir = -1;
    text.framesSinceSpawn = 0;
    text.effectStyle = PopupEffectStyle.None;
    text.effectIntensity = 0;
  }

  public static int NewText(AdvancedPopupRequest request, Vector2 position)
  {
    if (!Main.showItemText || Main.netMode == 2)
      return -1;
    int nextItemTextSlot = PopupText.FindNextItemTextSlot();
    if (nextItemTextSlot >= 0)
    {
      string text1 = request.Text;
      Vector2 vector2 = FontAssets.MouseText.Value.MeasureString(text1);
      PopupText text2 = PopupText.popupText[nextItemTextSlot];
      PopupText.ResetText(text2);
      text2.active = true;
      text2.position = position - vector2 / 2f;
      text2.name = text1;
      text2.stack = 1L;
      text2.velocity = request.Velocity;
      text2.lifeTime = request.DurationInFrames;
      text2.context = PopupTextContext.Advanced;
      text2.freeAdvanced = true;
      text2.color = request.Color;
      text2.PrepareDisplayText();
    }
    return nextItemTextSlot;
  }

  public static int NewText(
    PopupTextContext context,
    int npcNetID,
    Vector2 position,
    bool stay5TimesLonger)
  {
    if (!Main.showItemText || npcNetID == 0 || Main.netMode == 2)
      return -1;
    int nextItemTextSlot = PopupText.FindNextItemTextSlot();
    if (nextItemTextSlot >= 0)
    {
      NPC npc = new NPC();
      npc.SetDefaults(npcNetID);
      string typeName = npc.TypeName;
      Vector2 vector2 = FontAssets.MouseText.Value.MeasureString(typeName);
      PopupText text = PopupText.popupText[nextItemTextSlot];
      PopupText.ResetText(text);
      text.active = true;
      text.position = position - vector2 / 2f;
      text.name = typeName;
      text.stack = 1L;
      text.velocity.Y = -7f;
      text.lifeTime = 60;
      text.context = context;
      if (stay5TimesLonger)
        text.lifeTime *= 5;
      text.npcNetID = npcNetID;
      text.color = Color.White;
      if (context == PopupTextContext.SonarAlert)
        text.color = Color.Lerp(Color.White, Color.Crimson, 0.5f);
      text.PrepareDisplayText();
    }
    return nextItemTextSlot;
  }

  public static int NewText(
    PopupTextContext context,
    Item newItem,
    Vector2 position,
    int stack,
    bool noStack = false,
    bool longText = false)
  {
    if (!Main.showItemText || newItem.Name == null || Main.netMode == 2)
      return -1;
    bool flag = newItem.type >= 71 && newItem.type <= 74;
    for (int index = 0; index < 20; ++index)
    {
      PopupText somePopup = PopupText.popupText[index];
      if (somePopup.active && !somePopup.notActuallyAnItem && (somePopup.name == newItem.AffixName() || flag && somePopup.coinText) && !somePopup.NoStack && !noStack)
      {
        string str1 = $"{newItem.Name} ({(object) (somePopup.stack + (long) stack)})";
        string str2 = newItem.Name;
        if (somePopup.stack > 1L)
          str2 = $"{str2} ({(object) somePopup.stack})";
        FontAssets.MouseText.Value.MeasureString(str2);
        Vector2 vector2 = FontAssets.MouseText.Value.MeasureString(str1);
        if (somePopup.lifeTime < 0)
          somePopup.scale = 1f;
        if (somePopup.lifeTime < 60)
          somePopup.lifeTime = 60;
        if (flag && somePopup.coinText)
        {
          long addedValue = 0;
          if (newItem.type == 71)
            addedValue += (long) stack;
          else if (newItem.type == 72)
            addedValue += (long) (100 * stack);
          else if (newItem.type == 73)
            addedValue += (long) (10000 * stack);
          else if (newItem.type == 74)
            addedValue += (long) (1000000 * stack);
          somePopup.AddToCoinValue(addedValue);
          string name = PopupText.ValueToName(somePopup.coinValue);
          vector2 = FontAssets.MouseText.Value.MeasureString(name);
          somePopup.name = name;
          if (somePopup.coinValue >= 1000000L)
          {
            if (somePopup.lifeTime < 300)
              somePopup.lifeTime = 300;
            somePopup.color = new Color(220, 220, 198);
          }
          else if (somePopup.coinValue >= 10000L)
          {
            if (somePopup.lifeTime < 240 /*0xF0*/)
              somePopup.lifeTime = 240 /*0xF0*/;
            somePopup.color = new Color(224 /*0xE0*/, 201, 92);
          }
          else if (somePopup.coinValue >= 100L)
          {
            if (somePopup.lifeTime < 180)
              somePopup.lifeTime = 180;
            somePopup.color = new Color(181, 192 /*0xC0*/, 193);
          }
          else if (somePopup.coinValue >= 1L)
          {
            if (somePopup.lifeTime < 120)
              somePopup.lifeTime = 120;
            somePopup.color = new Color(246, 138, 96 /*0x60*/);
          }
        }
        somePopup.stack += (long) stack;
        somePopup.scale = 0.0f;
        somePopup.rotation = 0.0f;
        somePopup.position.X = (float) ((double) position.X + (double) newItem.width * 0.5 - (double) vector2.X * 0.5);
        somePopup.position.Y = (float) ((double) position.Y + (double) newItem.height * 0.25 - (double) vector2.Y * 0.5);
        somePopup.velocity.Y = -7f;
        somePopup.context = context;
        somePopup.npcNetID = 0;
        somePopup.effectStyle = PopupEffectStyle.None;
        if (somePopup.coinText)
          somePopup.stack = 1L;
        PopupText.PrepareEffects(context, newItem, somePopup);
        if (somePopup.AnyEffect)
          somePopup.framesSinceSpawn = 0;
        somePopup.PrepareDisplayText();
        return index;
      }
    }
    int nextItemTextSlot = PopupText.FindNextItemTextSlot();
    if (nextItemTextSlot >= 0)
    {
      string str = newItem.AffixName();
      if (stack > 1)
        str = $"{str} ({(object) stack})";
      Vector2 vector2 = FontAssets.MouseText.Value.MeasureString(str);
      PopupText popupText = PopupText.popupText[nextItemTextSlot];
      PopupText.ResetText(popupText);
      popupText.active = true;
      popupText.position.X = position.X - vector2.X * 0.5f;
      popupText.position.Y = position.Y - vector2.Y * 0.5f;
      popupText.name = newItem.AffixName();
      popupText.stack = (long) stack;
      popupText.velocity.Y = -7f;
      popupText.lifeTime = 60;
      popupText.context = context;
      if (longText)
        popupText.lifeTime *= 5;
      popupText.coinValue = 0L;
      popupText.coinText = newItem.type >= 71 && newItem.type <= 74;
      if (popupText.coinText)
      {
        long addedValue = 0;
        if (newItem.type == 71)
          addedValue += popupText.stack;
        else if (newItem.type == 72)
          addedValue += 100L * popupText.stack;
        else if (newItem.type == 73)
          addedValue += 10000L * popupText.stack;
        else if (newItem.type == 74)
          addedValue += 1000000L * popupText.stack;
        popupText.AddToCoinValue(addedValue);
        popupText.ValueToName();
        popupText.stack = 1L;
        if (popupText.coinValue >= 1000000L)
        {
          if (popupText.lifeTime < 300)
            popupText.lifeTime = 300;
          popupText.color = new Color(220, 220, 198);
        }
        else if (popupText.coinValue >= 10000L)
        {
          if (popupText.lifeTime < 240 /*0xF0*/)
            popupText.lifeTime = 240 /*0xF0*/;
          popupText.color = new Color(224 /*0xE0*/, 201, 92);
        }
        else if (popupText.coinValue >= 100L)
        {
          if (popupText.lifeTime < 180)
            popupText.lifeTime = 180;
          popupText.color = new Color(181, 192 /*0xC0*/, 193);
        }
        else if (popupText.coinValue >= 1L)
        {
          if (popupText.lifeTime < 120)
            popupText.lifeTime = 120;
          popupText.color = new Color(246, 138, 96 /*0x60*/);
        }
      }
      PopupText.PrepareEffects(context, newItem, popupText);
      popupText.PrepareDisplayText();
    }
    return nextItemTextSlot;
  }

  private static void PrepareEffects(PopupTextContext context, Item newItem, PopupText somePopup)
  {
    if (newItem.rare == -13)
      somePopup.master = true;
    somePopup.expert = newItem.expert;
    CraftingEffectDetails effectDetails = CraftingEffects.GetEffectDetails(newItem);
    if (!somePopup.coinText)
      somePopup.color = Item.GetPopupRarityColor(effectDetails.Rarity);
    if (context != PopupTextContext.ItemCraft)
      return;
    somePopup.effectIntensity = effectDetails.Intensity;
    somePopup.effectStyle = effectDetails.Style;
  }

  private void PrepareDisplayText()
  {
    this.displayText = this.name;
    if (this.stack > 1L)
      this.displayText = $"{this.displayText} ({(object) this.stack})";
    if (!this.AnyEffect)
      return;
    this.PrepareTextEffects();
  }

  private void PrepareTextEffects()
  {
    int length = this.displayText.Length;
    if (this.charOffsets == null)
      this.charOffsets = new Vector2[length];
    Array.Resize<Vector2>(ref this.charOffsets, length);
    if (this.charColors == null)
      this.charColors = new Color[length];
    Array.Resize<Color>(ref this.charColors, length);
  }

  private static void EmitFancyFlashDust(PopupText somePopup)
  {
    Vector2 vector2 = somePopup.GetTextHitbox() * (1f / somePopup.scale);
    int num1 = 6 + somePopup.effectIntensity / 2;
    int num2 = (somePopup.effectIntensity - 3) * 4;
    if (num2 < 0)
      num2 = 0;
    int num3 = num1 - num2;
    if (somePopup.effectStyle == PopupEffectStyle.Potion)
    {
      num3 = 0;
      num2 = 0;
    }
    for (int index = 0; index < num3; ++index)
    {
      float num4 = (float) (1.2000000476837158 * (double) Main.rand.NextFloat() - 0.10000000149011612);
      Dust rf = Dust.NewDustPerfect(new Vector2(somePopup.position.X + vector2.X * num4, somePopup.position.Y + vector2.Y * (float) (1.0 + 0.40000000596046448 * Math.Sin((double) num4 * 3.1415927410125732))), 306, new Vector2?(new Vector2(0.0f, Main.rand.NextFloatDirection())), newColor: somePopup.color, Scale: 2f);
      rf.noGravity = true;
      rf.noLight = true;
      rf.noLightEmittence = true;
      rf.velocity.Y += -2f;
      rf.fadeIn = (float) (1.3999999761581421 * (1.0 + 0.40000000596046448 * (double) Main.rand.NextFloat()));
      rf.scale = (float) (0.60000002384185791 + 0.40000000596046448 * (double) Main.rand.NextFloat());
      if ((double) rf.scale >= 0.89999997615814209)
      {
        Dust dust = Dust.CloneDust(rf);
        dust.color = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
        dust.scale *= 0.65f;
        dust.fadeIn = 1.1f;
      }
    }
    for (int index = 0; index < num2; ++index)
    {
      float num5 = (float) (1.2000000476837158 * (double) Main.rand.NextFloat() - 0.10000000149011612);
      Dust rf = Dust.NewDustPerfect(new Vector2(somePopup.position.X + vector2.X * num5, somePopup.position.Y + vector2.Y * (float) (0.60000002384185791 + 0.40000000596046448 * Math.Sin((double) num5 * 3.1415927410125732))), 306, new Vector2?(new Vector2(0.0f, Main.rand.NextFloatDirection())), newColor: somePopup.color, Scale: 2f);
      rf.noLight = true;
      rf.noLightEmittence = true;
      rf.velocity.X = rf.velocity.RotatedBy(6.2831854820251465 * (double) Main.rand.NextFloatDirection()).X;
      rf.velocity.Y += -2f;
      rf.fadeIn = (float) (2.4000000953674316 * (1.0 + 0.40000000596046448 * (double) Main.rand.NextFloat()));
      rf.scale = (float) (0.60000002384185791 + 0.40000000596046448 * (double) Main.rand.NextFloat());
      if ((double) rf.scale >= 0.89999997615814209)
      {
        Dust dust = Dust.CloneDust(rf);
        dust.color = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
        dust.scale *= 0.65f;
        dust.fadeIn = 1.1f;
      }
    }
  }

  private void AddToCoinValue(long addedValue)
  {
    this.coinValue = Math.Min(9999999999L, Math.Max(0L, this.coinValue + addedValue));
  }

  private static int FindNextItemTextSlot()
  {
    int nextItemTextSlot = -1;
    for (int index = 0; index < 20; ++index)
    {
      if (!PopupText.popupText[index].active)
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
        if (num > (double) PopupText.popupText[index].position.Y)
        {
          nextItemTextSlot = index;
          num = (double) PopupText.popupText[index].position.Y;
        }
      }
    }
    return nextItemTextSlot;
  }

  public static void AssignAsSonarText(int sonarTextIndex)
  {
    PopupText.sonarText = sonarTextIndex;
    if (PopupText.sonarText <= -1)
      return;
    PopupText.popupText[PopupText.sonarText].sonar = true;
  }

  public static string ValueToName(long coinValue)
  {
    int num1 = 0;
    int num2 = 0;
    int num3 = 0;
    int num4 = 0;
    long num5 = coinValue;
    while (num5 > 0L)
    {
      if (num5 >= 1000000L)
      {
        num5 -= 1000000L;
        ++num1;
      }
      else if (num5 >= 10000L)
      {
        num5 -= 10000L;
        ++num2;
      }
      else if (num5 >= 100L)
      {
        num5 -= 100L;
        ++num3;
      }
      else if (num5 >= 1L)
      {
        --num5;
        ++num4;
      }
    }
    string name = "";
    if (num1 > 0)
      name = name + (object) num1 + $" {Language.GetTextValue("Currency.Platinum")} ";
    if (num2 > 0)
      name = name + (object) num2 + $" {Language.GetTextValue("Currency.Gold")} ";
    if (num3 > 0)
      name = name + (object) num3 + $" {Language.GetTextValue("Currency.Silver")} ";
    if (num4 > 0)
      name = name + (object) num4 + $" {Language.GetTextValue("Currency.Copper")} ";
    if (name.Length > 1)
      name = name.Substring(0, name.Length - 1);
    return name;
  }

  private void ValueToName()
  {
    int num1 = 0;
    int num2 = 0;
    int num3 = 0;
    int num4 = 0;
    long coinValue = this.coinValue;
    while (coinValue > 0L)
    {
      if (coinValue >= 1000000L)
      {
        coinValue -= 1000000L;
        ++num1;
      }
      else if (coinValue >= 10000L)
      {
        coinValue -= 10000L;
        ++num2;
      }
      else if (coinValue >= 100L)
      {
        coinValue -= 100L;
        ++num3;
      }
      else if (coinValue >= 1L)
      {
        --coinValue;
        ++num4;
      }
    }
    this.name = "";
    if (num1 > 0)
      this.name = this.name + (object) num1 + $" {Language.GetTextValue("Currency.Platinum")} ";
    if (num2 > 0)
      this.name = this.name + (object) num2 + $" {Language.GetTextValue("Currency.Gold")} ";
    if (num3 > 0)
      this.name = this.name + (object) num3 + $" {Language.GetTextValue("Currency.Silver")} ";
    if (num4 > 0)
      this.name = this.name + (object) num4 + $" {Language.GetTextValue("Currency.Copper")} ";
    if (this.name.Length <= 1)
      return;
    this.name = this.name.Substring(0, this.name.Length - 1);
  }

  public void Update(int whoAmI)
  {
    if (!this.active)
      return;
    ++this.framesSinceSpawn;
    float targetScale = PopupText.TargetScale;
    this.alpha += (float) this.alphaDir * 0.01f;
    if ((double) this.alpha <= 0.7)
    {
      this.alpha = 0.7f;
      this.alphaDir = 1;
    }
    if ((double) this.alpha >= 1.0)
    {
      this.alpha = 1f;
      this.alphaDir = -1;
    }
    if (this.expert)
      this.color = new Color((int) (byte) Main.DiscoR, (int) (byte) Main.DiscoG, (int) (byte) Main.DiscoB, (int) Main.mouseTextColor);
    else if (this.master)
      this.color = new Color((int) byte.MaxValue, (int) (byte) ((double) Main.masterColor * 200.0), 0, (int) Main.mouseTextColor);
    bool flag = false;
    Vector2 textHitbox1 = this.GetTextHitbox();
    Rectangle rectangle1 = new Rectangle((int) ((double) this.position.X - (double) textHitbox1.X / 2.0), (int) ((double) this.position.Y - (double) textHitbox1.Y / 2.0), (int) textHitbox1.X, (int) textHitbox1.Y);
    if (this.AnyEffect && this.framesSinceSpawn == 8)
      PopupText.EmitFancyFlashDust(this);
    for (int index = 0; index < 20; ++index)
    {
      PopupText popupText = PopupText.popupText[index];
      if (popupText.active && index != whoAmI)
      {
        Vector2 textHitbox2 = popupText.GetTextHitbox();
        Rectangle rectangle2 = new Rectangle((int) ((double) popupText.position.X - (double) textHitbox2.X / 2.0), (int) ((double) popupText.position.Y - (double) textHitbox2.Y / 2.0), (int) textHitbox2.X, (int) textHitbox2.Y);
        if (rectangle1.Intersects(rectangle2) && ((double) this.position.Y < (double) popupText.position.Y || (double) this.position.Y == (double) popupText.position.Y && whoAmI < index))
        {
          flag = true;
          int num = PopupText.numActive;
          if (num > 3)
            num = 3;
          popupText.lifeTime = PopupText.activeTime + 15 * num;
          this.lifeTime = PopupText.activeTime + 15 * num;
        }
      }
    }
    if (!flag)
    {
      this.velocity.Y *= 0.86f;
      if ((double) this.scale == (double) targetScale)
        this.velocity.Y *= 0.4f;
    }
    else if ((double) this.velocity.Y > -6.0)
      this.velocity.Y -= 0.2f;
    else
      this.velocity.Y *= 0.86f;
    this.velocity.X *= 0.93f;
    this.position += this.velocity;
    --this.lifeTime;
    if (this.lifeTime <= 0)
    {
      this.scale -= 0.03f * targetScale;
      if ((double) this.scale < 0.1 * (double) targetScale)
      {
        this.active = false;
        if (PopupText.sonarText == whoAmI)
          PopupText.sonarText = -1;
      }
      this.lifeTime = 0;
    }
    else
    {
      if ((double) this.scale < (double) targetScale)
        this.scale += 0.1f * targetScale;
      if ((double) this.scale <= (double) targetScale)
        return;
      this.scale = targetScale;
    }
  }

  private Vector2 GetTextHitbox()
  {
    string displayText = this.displayText;
    Vector2 textHitbox = FontAssets.MouseText.Value.MeasureString(displayText) * this.scale;
    textHitbox.Y *= 0.8f;
    return textHitbox;
  }

  public static void UpdateItemText()
  {
    int num = 0;
    for (int whoAmI = 0; whoAmI < 20; ++whoAmI)
    {
      if (PopupText.popupText[whoAmI].active)
      {
        ++num;
        PopupText.popupText[whoAmI].Update(whoAmI);
      }
    }
    PopupText.numActive = num;
  }

  public static void ClearAll()
  {
    for (int index = 0; index < 20; ++index)
      PopupText.popupText[index] = new PopupText();
    PopupText.numActive = 0;
  }

  public static void DrawItemTextPopups(float scaleTarget)
  {
    SpriteBatch spriteBatch = Main.spriteBatch;
    Vector2 screenPosition = Main.screenPosition;
    int screenHeight = Main.screenHeight;
    for (int index1 = 0; index1 < 20; ++index1)
    {
      PopupText popupText = PopupText.popupText[index1];
      if (popupText.active)
      {
        string displayText = popupText.displayText;
        Vector2 vector2_1 = FontAssets.MouseText.Value.MeasureString(displayText);
        Vector2 vector2_2 = new Vector2(vector2_1.X * 0.5f, vector2_1.Y * 0.5f);
        float num1 = scaleTarget;
        float num2 = popupText.scale / num1;
        int num3 = (int) ((double) byte.MaxValue - (double) byte.MaxValue * (double) num2);
        float r = (float) popupText.color.R;
        double g = (double) popupText.color.G;
        double b = (double) popupText.color.B;
        float a = (float) popupText.color.A;
        float num4 = r * (float) ((double) num2 * (double) popupText.alpha * 0.30000001192092896);
        double alpha1 = (double) popupText.alpha;
        double alpha2 = (double) popupText.alpha;
        float num5 = a * (num2 * popupText.alpha);
        Color color1 = Color.Black;
        float num6 = 1f;
        Texture2D texture2D1 = (Texture2D) null;
        Vector2[] vector2Array = (Vector2[]) null;
        Color[] colorArray = (Color[]) null;
        switch (popupText.context)
        {
          case PopupTextContext.ItemPickupToVoidContainer:
            color1 = new Color((int) sbyte.MaxValue, 20, (int) byte.MaxValue) * 0.4f;
            num6 = 0.8f;
            break;
          case PopupTextContext.SonarAlert:
            color1 = Color.Blue * 0.4f;
            if (popupText.npcNetID != 0)
              color1 = Color.Red * 0.4f;
            num6 = 1f;
            break;
          case PopupTextContext.ItemReforge_Best:
            color1 = Main.hslToRgb((float) ((double) Main.GlobalTimeWrappedHourly * 0.60000002384185791 % 1.0), 1f, 0.6f) * 0.6f;
            num1 *= 0.5f;
            num6 = 0.8f;
            break;
        }
        int fromMax = 40;
        float num7 = Utils.Remap((float) popupText.framesSinceSpawn, 0.0f, (float) fromMax, 0.0f, 1f);
        float num8 = (float) Utils.EaseOutCirc((double) num7);
        if ((popupText.effectStyle == PopupEffectStyle.Metal || popupText.effectStyle == PopupEffectStyle.MagicWeapon || popupText.effectStyle == PopupEffectStyle.RangedWeapon || popupText.effectStyle == PopupEffectStyle.SummonWeapon ? 1 : (popupText.effectStyle == PopupEffectStyle.MeleeWeapon ? 1 : 0)) != 0)
        {
          Vector2 vector2_3 = new Vector2(0.0f, -4f);
          Vector2 vector2_4 = popupText.position - screenPosition + vector2_2;
          float scale1 = popupText.scale;
          num6 = (float) Utils.Lerp(0.60000002384185791, 1.0, (double) num7);
          Vector3 hsl = Main.rgbToHsl(popupText.color);
          color1 = Color.Lerp(Main.hslToRgb(hsl.X, hsl.Y, 1f - num7) with
          {
            A = (byte) 0
          }, Color.Black, (float) Utils.EaseInCirc((double) Utils.Clamp<float>(num7 * 1.25f, 0.0f, 1f)));
          float num9 = Utils.Remap(num7, 0.0f, 0.1f, 0.0f, 1f) * Utils.Remap(num7, 0.1f, 1f, 1f, 0.0f);
          float num10 = Utils.Remap(num7, 0.0f, 0.2f, 0.0f, 1f) * Utils.Remap(num7, 0.2f, 0.8f, 1f, 0.0f);
          Texture2D texture2D2 = TextureAssets.Extra[98].Value;
          Vector2 origin = texture2D2.Frame().Size() / 2f;
          Vector2 scale2 = new Vector2(1f, vector2_1.X / (float) texture2D2.Width);
          scale2 *= scale1;
          if ((double) num9 > 0.0)
          {
            Vector2 vector2_5 = (new Vector2(Utils.Remap(num8, 0.0f, 1f, -20f, 20f), 0.0f) + vector2_3) * scale1;
            for (Vector2 vector2_6 = new Vector2(-60f, 0.0f); (double) vector2_6.X <= 40.0; vector2_6.X += 40f)
              spriteBatch.Draw(texture2D2, vector2_4 + vector2_5 + vector2_6 * scale1, new Rectangle?(), popupText.color * num9, 1.57079637f, origin, scale2, SpriteEffects.None, 0.0f);
            for (Vector2 vector2_7 = new Vector2(-20f, 0.0f); (double) vector2_7.X <= 20.0; vector2_7.X += 20f)
              spriteBatch.Draw(texture2D2, vector2_4 + vector2_5 + vector2_7 * scale1, new Rectangle?(), new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0) * 0.5f * num10, 1.57079637f, origin, scale2 * 0.5f, SpriteEffects.None, 0.0f);
          }
          float num11 = 6.28318548f * num7;
          float fromValue = (float) Utils.EaseOutCirc((double) Utils.Clamp<float>(num7 * 2f, 0.0f, 1f));
          float num12 = Utils.Remap(num7, 0.1f, 0.3f, 0.0f, 1f) * Utils.Remap(num7, 0.3f, 0.6f, 1f, 0.0f);
          Vector2 vector2_8 = (new Vector2(vector2_1.X, 0.0f) * Utils.Remap(fromValue, 0.0f, 1f, -0.8f, 0.4f) + vector2_3) * scale1;
          spriteBatch.Draw(texture2D2, vector2_4 + vector2_8, new Rectangle?(), popupText.color * num12, 0.0f + num11, origin, scale1, SpriteEffects.None, 0.0f);
          spriteBatch.Draw(texture2D2, vector2_4 + vector2_8, new Rectangle?(), popupText.color * num12, 1.57079637f + num11, origin, scale1 * 1.3f, SpriteEffects.None, 0.0f);
          spriteBatch.Draw(texture2D2, vector2_4 + vector2_8, new Rectangle?(), new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0) * num12, 0.0f + num11, origin, new Vector2(0.5f, 0.5f) * scale1 * 1.3f, SpriteEffects.None, 0.0f);
          spriteBatch.Draw(texture2D2, vector2_4 + vector2_8, new Rectangle?(), new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0) * num12, 1.57079637f + num11, origin, new Vector2(0.5f, 0.5f) * scale1, SpriteEffects.None, 0.0f);
          float num13 = 0.0f;
          spriteBatch.Draw(texture2D2, vector2_4 + vector2_8, new Rectangle?(), popupText.color * num12, 0.0f + num13, origin, scale1, SpriteEffects.None, 0.0f);
          spriteBatch.Draw(texture2D2, vector2_4 + vector2_8, new Rectangle?(), popupText.color * num12, 1.57079637f + num13, origin, scale1 * 1.3f, SpriteEffects.None, 0.0f);
          spriteBatch.Draw(texture2D2, vector2_4 + vector2_8, new Rectangle?(), new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0) * num12, 0.0f + num13, origin, new Vector2(0.5f, 0.5f) * scale1 * 1.3f, SpriteEffects.None, 0.0f);
          spriteBatch.Draw(texture2D2, vector2_4 + vector2_8, new Rectangle?(), new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0) * num12, 1.57079637f + num13, origin, new Vector2(0.5f, 0.5f) * scale1, SpriteEffects.None, 0.0f);
          colorArray = popupText.charColors;
          float num14 = 1f / (float) displayText.Length;
          for (int index2 = 0; index2 < displayText.Length; ++index2)
          {
            float amount = Utils.Remap(num8, num14 * (float) index2, num14 * (float) (index2 + 1), 0.0f, 1f);
            colorArray[index2] = Color.Lerp(Color.White, popupText.color, amount);
          }
        }
        if (popupText.effectStyle == PopupEffectStyle.MagicWeapon)
        {
          vector2Array = popupText.charOffsets;
          float num15 = 1f / (float) displayText.Length;
          for (int index3 = 0; index3 < displayText.Length; ++index3)
          {
            double num16 = (double) Utils.Remap(num8 * 1.25f, num15 * (float) index3, num15 * (float) (index3 + 1), 0.0f, 1f);
            Vector2 vector2_9 = new Vector2((float) (-Math.Sin(6.2831854820251465 * ((double) (index3 * 31 /*0x1F*/) / 12.0)) * 144.0), 0.0f);
            vector2Array[index3] = Vector2.Lerp(vector2_9, Vector2.Zero, num8);
          }
        }
        if (popupText.effectStyle == PopupEffectStyle.RangedWeapon)
        {
          vector2Array = popupText.charOffsets;
          colorArray = popupText.charColors;
          color1 = Color.Transparent;
          float num17 = 1f / (float) displayText.Length;
          float num18 = Utils.Clamp<float>(num8 * 3f, 0.0f, 1f);
          float num19 = Utils.Clamp<float>(num8 * 1.5f, 0.0f, 1f);
          for (int index4 = 0; index4 < displayText.Length; ++index4)
          {
            float amount = Utils.Remap(num8, num17 * (float) index4, num17 * (float) (index4 + 1), 0.0f, 1f);
            colorArray[index4] = Color.Lerp(new Color(0, 0, 0, 1), popupText.color, amount);
            Vector2 vector2_10 = new Vector2((float) (60.0 * (double) amount - 120.0 * (double) num18), (float) ((Math.Sin(6.2831854820251465 * ((double) (index4 * 31 /*0x1F*/) / 12.0)) * 0.5 + 0.5) * -204.0 * (1.0 - (double) num19)));
            vector2Array[index4] = Vector2.Lerp(vector2_10, Vector2.Zero, num8);
          }
        }
        if (popupText.effectStyle == PopupEffectStyle.Potion)
        {
          vector2Array = popupText.charOffsets;
          float num20 = 1f / (float) displayText.Length;
          for (int index5 = 0; index5 < displayText.Length; ++index5)
          {
            double num21 = (double) Utils.Remap(num8 * 1.25f, num20 * (float) index5, num20 * (float) (index5 + 1), 0.0f, 1f);
            Vector2 vector2_11 = new Vector2(0.0f, (float) Math.Sin(6.2831854820251465 * ((double) index5 / 12.0)) * 20f);
            vector2Array[index5] = Vector2.Lerp(vector2_11, Vector2.Zero, num8);
          }
        }
        float num22 = (float) num3 / (float) byte.MaxValue;
        for (int index6 = 0; index6 < 5; ++index6)
        {
          Color color2 = color1;
          float num23 = 0.0f;
          float num24 = 0.0f;
          if (index6 == 0)
            num23 -= num1 * 2f;
          else if (index6 == 1)
            num23 += num1 * 2f;
          else if (index6 == 2)
            num24 -= num1 * 2f;
          else if (index6 == 3)
            num24 += num1 * 2f;
          else
            color2 = popupText.color * num2 * popupText.alpha * num6;
          if (index6 < 4)
          {
            num5 = (float) popupText.color.A * num2 * popupText.alpha;
            color2 = new Color(0, 0, 0, (int) num5);
          }
          if (color1 != Color.Black && index6 < 4)
          {
            num23 *= (float) (1.2999999523162842 + 1.2999999523162842 * (double) num22);
            num24 *= (float) (1.2999999523162842 + 1.2999999523162842 * (double) num22);
          }
          float num25 = popupText.position.Y - screenPosition.Y + num24;
          if ((double) Main.player[Main.myPlayer].gravDir == -1.0)
            num25 = (float) screenHeight - num25;
          if (color1 != Color.Black && index6 < 4)
          {
            Color color3 = color1 with
            {
              A = (byte) MathHelper.Lerp(60f, (float) sbyte.MaxValue, Utils.GetLerpValue(0.0f, (float) byte.MaxValue, num5, true))
            };
            DynamicSpriteFontExtensionMethods.DrawString(spriteBatch, FontAssets.MouseText.Value, displayText, new Vector2(popupText.position.X - screenPosition.X + num23 + vector2_2.X, num25 + vector2_2.Y), Color.Lerp(color2, color3, 0.5f), popupText.rotation, vector2_2, popupText.scale, SpriteEffects.None, 0.0f, vector2Array, (Color[]) null);
            DynamicSpriteFontExtensionMethods.DrawString(spriteBatch, FontAssets.MouseText.Value, displayText, new Vector2(popupText.position.X - screenPosition.X + num23 + vector2_2.X, num25 + vector2_2.Y), color3, popupText.rotation, vector2_2, popupText.scale, SpriteEffects.None, 0.0f, vector2Array, (Color[]) null);
          }
          else
            DynamicSpriteFontExtensionMethods.DrawString(spriteBatch, FontAssets.MouseText.Value, displayText, new Vector2(popupText.position.X - screenPosition.X + num23 + vector2_2.X, num25 + vector2_2.Y), color2, popupText.rotation, vector2_2, popupText.scale, SpriteEffects.None, 0.0f, vector2Array, index6 == 4 ? colorArray : (Color[]) null);
          if (texture2D1 != null)
          {
            float scale = (float) ((1.2999999523162842 - (double) num22) * (double) popupText.scale * 0.699999988079071);
            Vector2 vector2_12 = new Vector2(popupText.position.X - screenPosition.X + num23 + vector2_2.X, num25 + vector2_2.Y);
            Color color4 = color1 * 0.6f;
            if (index6 == 4)
              color4 = Color.White * 0.6f;
            color4.A = (byte) ((double) color4.A * 0.5);
            int num26 = 25;
            spriteBatch.Draw(texture2D1, vector2_12 + new Vector2((float) ((double) vector2_2.X * -0.5 - (double) num26 - (double) texture2D1.Size().X / 2.0), 0.0f), new Rectangle?(), color4 * popupText.scale, 0.0f, texture2D1.Size() / 2f, scale, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(texture2D1, vector2_12 + new Vector2((float) ((double) vector2_2.X * 0.5 + (double) num26 + (double) texture2D1.Size().X / 2.0), 0.0f), new Rectangle?(), color4 * popupText.scale, 0.0f, texture2D1.Size() / 2f, scale, SpriteEffects.None, 0.0f);
          }
        }
      }
    }
  }
}
