// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.Elements.UIItemSlot
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

#nullable disable
namespace Terraria.GameContent.UI.Elements;

public class UIItemSlot : UIElement
{
  private Item[] _itemArray;
  private int _itemIndex;
  private int _itemSlotContext;

  public UIItemSlot(Item[] itemArray, int itemIndex, int itemSlotContext)
  {
    this._itemArray = itemArray;
    this._itemIndex = itemIndex;
    this._itemSlotContext = itemSlotContext;
    this.Width = new StyleDimension(48f, 0.0f);
    this.Height = new StyleDimension(48f, 0.0f);
  }

  private void HandleItemSlotLogic()
  {
    if (!this.IsMouseHovering)
      return;
    Main.LocalPlayer.mouseInterface = true;
    ItemSlot.Handle(this._itemArray, this._itemSlotContext, this._itemIndex);
  }

  protected override void DrawSelf(SpriteBatch spriteBatch)
  {
    this.HandleItemSlotLogic();
    Item inv = this._itemArray[this._itemIndex];
    Vector2 position = this.GetDimensions().Center() + new Vector2(52f, 52f) * -0.5f * Main.inventoryScale;
    ItemSlot.Draw(spriteBatch, ref inv, this._itemSlotContext, position);
  }
}
