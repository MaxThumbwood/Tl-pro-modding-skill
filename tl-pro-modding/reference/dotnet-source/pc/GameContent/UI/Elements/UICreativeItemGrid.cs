// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.Elements.UICreativeItemGrid
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Creative;
using Terraria.UI;
using Terraria.UI.Gamepad;

#nullable disable
namespace Terraria.GameContent.UI.Elements;

public class UICreativeItemGrid : UIDynamicItemCollection<Item>
{
  private Item _item = new Item();

  protected override Item GetItem(Item entry) => entry;

  protected override void DrawSlot(SpriteBatch spriteBatch, Item item, Vector2 pos, bool hovering)
  {
    ItemsSacrificedUnlocksTracker itemSacrifices = Main.LocalPlayerCreativeTracker.ItemSacrifices;
    int context = itemSacrifices.IsFullyResearched(item.type) ? 29 : 34;
    if (hovering)
    {
      this._item.SetDefaults(item.type);
      item = this._item;
      Main.LocalPlayer.mouseInterface = true;
      ItemSlot.Handle(ref item, context);
      itemSacrifices.ClearNewlyResearchedStatus(item.type);
    }
    UILinkPointNavigator.Shortcuts.ItemSlotShouldHighlightAsSelected = hovering;
    item.newAndShiny = itemSacrifices.IsNewlyResearched(item.type);
    ItemSlot.Draw(spriteBatch, ref item, context, pos);
    item.newAndShiny = false;
  }
}
