// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Tile_Entities.TEFoodPlatter
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.IO;
using Terraria.DataStructures;
using Terraria.ID;

#nullable disable
namespace Terraria.GameContent.Tile_Entities;

public class TEFoodPlatter : TileEntityType<TEFoodPlatter>, IFixLoadedData
{
  public Item item;

  public TEFoodPlatter() => this.item = new Item();

  public override bool IsTileValidForEntity(int x, int y) => TEFoodPlatter.ValidTile(x, y);

  public static int Hook_AfterPlacement(
    int x,
    int y,
    int type = 520,
    int style = 0,
    int direction = 1,
    int alternate = 0)
  {
    if (Main.netMode != 1)
      return TileEntityType<TEFoodPlatter>.Place(x, y);
    NetMessage.SendTileSquare(Main.myPlayer, x, y);
    NetMessage.SendData(87, number: x, number2: (float) y, number3: (float) TileEntityType<TEFoodPlatter>.EntityTypeID);
    return -1;
  }

  public static bool ValidTile(int x, int y)
  {
    return Main.tile[x, y].active() && Main.tile[x, y].type == (ushort) 520 && Main.tile[x, y].frameY == (short) 0;
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
      Item.NewItem((IEntitySource) new EntitySource_TileBreak((int) this.Position.X, (int) this.Position.Y), (int) this.Position.X * 16 /*0x10*/, (int) this.Position.Y * 16 /*0x10*/, 16 /*0x10*/, 16 /*0x10*/, this.item.type, pfix: (int) this.item.prefix);
    this.item = new Item();
  }

  public static void TryPlacing(int x, int y, int type, int prefix, int stack)
  {
    WorldGen.RangeFrame(x, y, x + 1, y + 1);
    TEFoodPlatter result;
    if (!TileEntity.TryGetAt<TEFoodPlatter>(x, y, out result))
    {
      int number = Item.NewItem((IEntitySource) new EntitySource_TileBreak(x, y), x * 16 /*0x10*/, y * 16 /*0x10*/, 16 /*0x10*/, 16 /*0x10*/, 1);
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
    if (TEFoodPlatter.FitsFoodPlatter(player.inventory[player.selectedItem]) && !player.inventory[player.selectedItem].favorited)
    {
      player.GamepadEnableGrappleCooldown();
      TEFoodPlatter.PlaceItemInFrame(player, clickX, clickY);
    }
    else
    {
      int num1 = clickX;
      int num2 = clickY;
      TEFoodPlatter result;
      if (!TileEntity.TryGetAt<TEFoodPlatter>(num1, num2, out result) || result.item.stack <= 0)
        return;
      player.GamepadEnableGrappleCooldown();
      WorldGen.KillTile(clickX, clickY, true);
      if (Main.netMode != 1)
        return;
      NetMessage.SendData(17, number2: (float) num1, number3: (float) num2, number4: 1f);
    }
  }

  public static bool FitsFoodPlatter(Item i) => i.stack > 0 && ItemID.Sets.IsFood[i.type];

  public static void PlaceItemInFrame(Player player, int x, int y)
  {
    TEFoodPlatter result;
    if (!player.ItemTimeIsZero || !TileEntity.TryGetAt<TEFoodPlatter>(x, y, out result))
      return;
    if (result.item.stack > 0)
    {
      WorldGen.KillTile(x, y, true);
      if (Main.netMode == 1)
        NetMessage.SendData(17, number2: (float) Player.tileTargetX, number3: (float) y, number4: 1f);
    }
    if (Main.netMode == 1)
      NetMessage.SendData(133, number: x, number2: (float) y, number3: (float) player.selectedItem, number4: (float) player.whoAmI, number5: 1);
    else
      TEFoodPlatter.TryPlacing(x, y, player.inventory[player.selectedItem].type, (int) player.inventory[player.selectedItem].prefix, 1);
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
    WorldGen.RangeFrame(x, y, x + 1, y + 1);
  }

  public void FixLoadedData() => this.item.FixAgainstExploit();
}
