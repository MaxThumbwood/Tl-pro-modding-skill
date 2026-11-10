// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Tile_Entities.TEItemFrame
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.IO;
using Terraria.DataStructures;

#nullable disable
namespace Terraria.GameContent.Tile_Entities;

public class TEItemFrame : TileEntityType<TEItemFrame>, IFixLoadedData
{
  public Item item;

  public TEItemFrame() => this.item = new Item();

  public override bool IsTileValidForEntity(int x, int y) => TEItemFrame.ValidTile(x, y);

  public static int Hook_AfterPlacement(
    int x,
    int y,
    int type = 395,
    int style = 0,
    int direction = 1,
    int alternate = 0)
  {
    if (Main.netMode != 1)
      return TileEntityType<TEItemFrame>.Place(x, y);
    NetMessage.SendTileSquare(Main.myPlayer, x, y, 2, 2);
    NetMessage.SendData(87, number: x, number2: (float) y, number3: (float) TileEntityType<TEItemFrame>.EntityTypeID);
    return -1;
  }

  public static bool ValidTile(int x, int y)
  {
    return Main.tile[x, y].active() && Main.tile[x, y].type == (ushort) 395 && Main.tile[x, y].frameY == (short) 0 && (int) Main.tile[x, y].frameX % 36 == 0;
  }

  public override void WriteExtraData(BinaryWriter writer, bool networkSend)
  {
    writer.Write((short) this.item.type);
    writer.Write(this.item.prefix);
    writer.Write((short) this.item.stack);
  }

  public override void ReadExtraData(BinaryReader reader, int gameVersion, bool networkSend)
  {
    this.item = new Item();
    this.item.netDefaults((int) reader.ReadInt16());
    this.item.Prefix((int) reader.ReadByte());
    this.item.stack = (int) reader.ReadInt16();
  }

  public override string ToString()
  {
    return $"{(object) this.Position.X}x  {(object) this.Position.Y}y item: {(object) this.item}";
  }

  public void DropItem()
  {
    if (Main.netMode != 1)
      Item.NewItem((IEntitySource) new EntitySource_TileBreak((int) this.Position.X, (int) this.Position.Y), (int) this.Position.X * 16 /*0x10*/, (int) this.Position.Y * 16 /*0x10*/, 32 /*0x20*/, 32 /*0x20*/, this.item.type, pfix: (int) this.item.prefix);
    this.item = new Item();
  }

  public static void TryPlacing(int x, int y, int type, int prefix, int stack)
  {
    WorldGen.RangeFrame(x, y, x + 2, y + 2);
    TEItemFrame result;
    if (!TileEntity.TryGetAt<TEItemFrame>(x, y, out result))
    {
      int number = Item.NewItem((IEntitySource) new EntitySource_TileBreak(x, y), x * 16 /*0x10*/, y * 16 /*0x10*/, 32 /*0x20*/, 32 /*0x20*/, 1);
      Main.item[number].SetDefaults(type);
      Main.item[number].Prefix(prefix);
      Main.item[number].stack = stack;
      NetMessage.SendData(21, number: number);
    }
    else
    {
      if (result.item.stack > 0)
        result.DropItem();
      result.item = new Item();
      result.item.SetDefaults(type);
      result.item.Prefix(prefix);
      result.item.stack = stack;
      NetMessage.SendData(86, number: result.ID, number2: (float) x, number3: (float) y);
    }
  }

  public static void OnPlayerInteraction(Player player, int clickX, int clickY)
  {
    if (TEItemFrame.FitsItemFrame(player.inventory[player.selectedItem]) && !player.inventory[player.selectedItem].favorited)
    {
      player.GamepadEnableGrappleCooldown();
      TEItemFrame.PlaceItemInFrame(player, clickX, clickY);
    }
    else
    {
      int index1 = clickX;
      int index2 = clickY;
      if ((int) Main.tile[index1, index2].frameX % 36 != 0)
        --index1;
      if ((int) Main.tile[index1, index2].frameY % 36 != 0)
        --index2;
      TEItemFrame result;
      if (!TileEntity.TryGetAt<TEItemFrame>(index1, index2, out result) || result.item.stack <= 0)
        return;
      player.GamepadEnableGrappleCooldown();
      WorldGen.KillTile(clickX, clickY, true);
      if (Main.netMode != 1)
        return;
      NetMessage.SendData(17, number2: (float) index1, number3: (float) index2, number4: 1f);
    }
  }

  public static bool FitsItemFrame(Item i) => i.stack > 0;

  public static void PlaceItemInFrame(Player player, int x, int y)
  {
    if (!player.ItemTimeIsZero)
      return;
    if ((int) Main.tile[x, y].frameX % 36 != 0)
      --x;
    if ((int) Main.tile[x, y].frameY % 36 != 0)
      --y;
    TEItemFrame result;
    if (!TileEntity.TryGetAt<TEItemFrame>(x, y, out result))
      return;
    if (result.item.stack > 0)
    {
      WorldGen.KillTile(x, y, true);
      if (Main.netMode == 1)
        NetMessage.SendData(17, number2: (float) Player.tileTargetX, number3: (float) y, number4: 1f);
    }
    if (Main.netMode == 1)
      NetMessage.SendData(89, number: x, number2: (float) y, number3: (float) player.selectedItem, number4: (float) player.whoAmI, number5: 1);
    else
      TEItemFrame.TryPlacing(x, y, player.inventory[player.selectedItem].type, (int) player.inventory[player.selectedItem].prefix, 1);
    --player.inventory[player.selectedItem].stack;
    if (player.inventory[player.selectedItem].stack <= 0)
    {
      player.inventory[player.selectedItem].SetDefaults(0);
      Main.mouseItem.SetDefaults(0);
    }
    if (player.selectedItem == 58)
      Main.mouseItem = player.inventory[player.selectedItem].Clone();
    player.releaseUseItem = false;
    player.mouseInterface = true;
    player.PlayDroppedItemAnimation(20);
    WorldGen.RangeFrame(x, y, x + 2, y + 2);
  }

  public void FixLoadedData() => this.item.FixAgainstExploit();
}
