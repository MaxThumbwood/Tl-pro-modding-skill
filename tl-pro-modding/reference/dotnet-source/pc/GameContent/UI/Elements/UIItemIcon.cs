// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.Elements.UIItemIcon
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

#nullable disable
namespace Terraria.GameContent.UI.Elements;

public class UIItemIcon : UIElement
{
  private Item _item;
  private bool _blackedOut;

  public UIItemIcon(Item item, bool blackedOut)
  {
    this._item = item;
    this.Width.Set(32f, 0.0f);
    this.Height.Set(32f, 0.0f);
    this._blackedOut = blackedOut;
  }

  protected override void DrawSelf(SpriteBatch spriteBatch)
  {
    CalculatedStyle dimensions = this.GetDimensions();
    double num = (double) ItemSlot.DrawItemIcon(this._item, 31 /*0x1F*/, spriteBatch, dimensions.Center(), this._item.scale, 32f, this._blackedOut ? Color.Black : Color.White);
  }
}
