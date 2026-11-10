// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Tile_Entities.TEWeaponsRack
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.IO;
using Terraria.DataStructures;
using Terraria.ID;

#nullable disable
namespace Terraria.GameContent.Tile_Entities;

public class TEWeaponsRack : TileEntityType<TEWeaponsRack>, IFixLoadedData
{
  public Item item;
  private const int MyTileID = 471;

  public TEWeaponsRack() => this.item = new Item();

  public override void NetPlaceEntityAttempt(int x, int y) => TEWeaponsRack.NetPlaceEntity(x, y);

  public static void NetPlaceEntity(int x, int y)
  {
    NetMessage.SendData(86, number: TileEntityType<TEWeaponsRack>.Place(x, y), number2: (float) x, number3: (float) y);
  }

  public override bool IsTileValidForEntity(int x, int y) => TEWeaponsRack.ValidTile(x, y);

  public static bool ValidTile(int x, int y)
  {
    return Main.tile[x, y].active() && Main.tile[x, y].type == (ushort) 471 && Main.tile[x, y].frameY == (short) 0 && (int) Main.tile[x, y].frameX % 54 == 0;
  }

  public static int Hook_AfterPlacement(
    int x,
    int y,
    int type = 471,
    int style = 0,
    int direction = 1,
    int alternate = 0)
  {
    if (Main.netMode != 1)
      return TileEntityType<TEWeaponsRack>.Place(x, y);
    NetMessage.SendTileSquare(Main.myPlayer, x, y, 3, 3);
    NetMessage.SendData(87, number: x, number2: (float) y, number3: (float) TileEntityType<TEWeaponsRack>.EntityTypeID);
    return -1;
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

  public static void Framing_CheckTile(int callX, int callY)
  {
    int num1 = 3;
    int num2 = 3;
    if (WorldGen.destroyObject)
      return;
    int num3 = callX;
    int num4 = callY;
    Tile tileSafely = Framing.GetTileSafely(callX, callY);
    int num5 = num3 - (int) tileSafely.frameX / 18 % num1;
    int num6 = num4 - (int) tileSafely.frameY / 18 % num2;
    bool flag = false;
    for (int index1 = num5; index1 < num5 + num1; ++index1)
    {
      for (int index2 = num6; index2 < num6 + num2; ++index2)
      {
        Tile tile = Main.tile[index1, index2];
        if (!tile.active() || tile.type != (ushort) 471 || tile.wall == (ushort) 0)
          flag = true;
      }
    }
    if (!flag)
      return;
    TEWeaponsRack result;
    if (TileEntity.TryGetAt<TEWeaponsRack>(num5, num6, out result) && result.item.stack > 0)
    {
      result.DropItem();
      if (Main.netMode != 2)
        Main.LocalPlayer.InterruptItemUsageIfOverTile(471);
    }
    WorldGen.destroyObject = true;
    for (int i = num5; i < num5 + num1; ++i)
    {
      for (int j = num6; j < num6 + num2; ++j)
      {
        if (Main.tile[i, j].active() && Main.tile[i, j].type == (ushort) 471)
          WorldGen.KillTile(i, j);
      }
    }
    Item.NewItem((IEntitySource) new EntitySource_TileBreak(num5, num6), num5 * 16 /*0x10*/, num6 * 16 /*0x10*/, 48 /*0x30*/, 48 /*0x30*/, 2699);
    TileEntityType<TEWeaponsRack>.Kill(num5, num6);
    WorldGen.destroyObject = false;
  }

  public void DropItem()
  {
    if (Main.netMode != 1)
      Item.NewItem((IEntitySource) new EntitySource_TileBreak((int) this.Position.X, (int) this.Position.Y), (int) this.Position.X * 16 /*0x10*/, (int) this.Position.Y * 16 /*0x10*/, 32 /*0x20*/, 32 /*0x20*/, this.item.type, pfix: (int) this.item.prefix);
    this.item = new Item();
  }

  public static void TryPlacing(int x, int y, int type, int prefix, int stack)
  {
    WorldGen.RangeFrame(x, y, x + 3, y + 3);
    TEWeaponsRack result;
    if (!TileEntity.TryGetAt<TEWeaponsRack>(x, y, out result))
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
    if (TEWeaponsRack.FitsWeaponFrame(player.inventory[player.selectedItem]) && !player.inventory[player.selectedItem].favorited)
    {
      player.GamepadEnableGrappleCooldown();
      TEWeaponsRack.PlaceItemInFrame(player, clickX, clickY);
    }
    else
    {
      int index1 = clickX;
      int index2 = clickY;
      int index3 = index1 - (int) Main.tile[index1, index2].frameX % 54 / 18;
      int num = index2 - (int) Main.tile[index3, index2].frameY % 54 / 18;
      TEWeaponsRack result;
      if (!TileEntity.TryGetAt<TEWeaponsRack>(index3, num, out result) || result.item.stack <= 0)
        return;
      player.GamepadEnableGrappleCooldown();
      WorldGen.KillTile(index3, num, true);
      if (Main.netMode != 1)
        return;
      NetMessage.SendData(17, number2: (float) index3, number3: (float) num, number4: 1f);
    }
  }

  public static bool FitsWeaponFrame(Item i)
  {
    if (!i.IsAir && (i.fishingPole > 0 || ItemID.Sets.CanBePlacedOnWeaponRacks[i.type]))
      return true;
    return i.damage > 0 && i.useStyle != 0 && i.stack > 0;
  }

  private static void PlaceItemInFrame(Player player, int x, int y)
  {
    if (!player.ItemTimeIsZero)
      return;
    x -= (int) Main.tile[x, y].frameX % 54 / 18;
    y -= (int) Main.tile[x, y].frameY % 54 / 18;
    TEWeaponsRack result;
    if (!TileEntity.TryGetAt<TEWeaponsRack>(x, y, out result))
      return;
    if (result.item.stack > 0)
    {
      WorldGen.KillTile(x, y, true);
      if (Main.netMode == 1)
        NetMessage.SendData(17, number2: (float) Player.tileTargetX, number3: (float) y, number4: 1f);
    }
    if (Main.netMode == 1)
      NetMessage.SendData(123, number: x, number2: (float) y, number3: (float) player.selectedItem, number4: (float) player.whoAmI, number5: 1);
    else
      TEWeaponsRack.TryPlacing(x, y, player.inventory[player.selectedItem].type, (int) player.inventory[player.selectedItem].prefix, 1);
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
    WorldGen.RangeFrame(x, y, x + 3, y + 3);
  }

  public void FixLoadedData() => this.item.FixAgainstExploit();
}
