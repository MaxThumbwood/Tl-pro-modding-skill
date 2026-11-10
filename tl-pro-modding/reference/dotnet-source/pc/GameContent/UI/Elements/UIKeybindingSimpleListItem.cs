// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.Elements.UIKeybindingSimpleListItem
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria.UI;
using Terraria.UI.Chat;

#nullable disable
namespace Terraria.GameContent.UI.Elements;

public class UIKeybindingSimpleListItem : UIElement
{
  private Color _color;
  private Func<string> _GetTextFunction;

  public UIKeybindingSimpleListItem(Func<string> getText, Color color)
  {
    this._color = color;
    this._GetTextFunction = getText != null ? getText : (Func<string>) (() => "???");
  }

  protected override void DrawSelf(SpriteBatch spriteBatch)
  {
    float num1 = 6f;
    base.DrawSelf(spriteBatch);
    CalculatedStyle dimensions = this.GetDimensions();
    float num2 = dimensions.Width + 1f;
    Vector2 vector2_1 = new Vector2(dimensions.X, dimensions.Y);
    Vector2 vector2_2 = new Vector2(0.8f);
    Color baseColor = Color.Lerp(this.IsMouseHovering ? Color.White : Color.Silver, Color.White, this.IsMouseHovering ? 0.5f : 0.0f);
    Color color = this.IsMouseHovering ? this._color : this._color.MultiplyRGBA(new Color(180, 180, 180));
    Vector2 position = vector2_1;
    Utils.DrawSettings2Panel(spriteBatch, position, num2, color);
    position.X += 8f;
    position.Y += 2f + num1;
    string text = this._GetTextFunction();
    Vector2 stringSize = ChatManager.GetStringSize(FontAssets.ItemStack.Value, text, vector2_2);
    position.X = (float) ((double) dimensions.X + (double) dimensions.Width / 2.0 - (double) stringSize.X / 2.0);
    ChatManager.DrawColorCodedStringWithShadow(spriteBatch, FontAssets.ItemStack.Value, text, position, baseColor, 0.0f, Vector2.Zero, vector2_2, num2);
  }
}
