// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Tile_Entities.TETeleportationPylon
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.DataStructures;

#nullable disable
namespace Terraria.GameContent.Tile_Entities;

public class TETeleportationPylon : TileEntityType<TETeleportationPylon>
{
  private const int MyTileID = 597;
  public const int entityTileWidth = 3;
  public const int entityTileHeight = 4;

  public override void NetPlaceEntityAttempt(int x, int y)
  {
    TeleportPylonType pylonType;
    if (!this.TryGetPylonTypeFromTileCoords(x, y, out pylonType))
      TETeleportationPylon.RejectPlacementFromNet(x, y);
    else if (Main.PylonSystem.HasPylonOfType(pylonType))
      TETeleportationPylon.RejectPlacementFromNet(x, y);
    else
      base.NetPlaceEntityAttempt(x, y);
  }

  public bool TryGetPylonType(out TeleportPylonType pylonType)
  {
    return this.TryGetPylonTypeFromTileCoords((int) this.Position.X, (int) this.Position.Y, out pylonType);
  }

  private static void RejectPlacementFromNet(int x, int y)
  {
    WorldGen.KillTile(x, y);
    if (Main.netMode != 2)
      return;
    NetMessage.SendData(17, number2: (float) x, number3: (float) y);
  }

  public override void OnPlaced() => Main.PylonSystem.RequestImmediateUpdate();

  public override void OnRemoved() => Main.PylonSystem.RequestImmediateUpdate();

  public override string ToString() => $"{(object) this.Position.X}x  {(object) this.Position.Y}y";

  public static void Framing_CheckTile(int callX, int callY)
  {
    if (WorldGen.destroyObject)
      return;
    int num1 = callX;
    int num2 = callY;
    Tile tileSafely = Framing.GetTileSafely(callX, callY);
    int num3 = num1 - (int) tileSafely.frameX / 18 % 3;
    int num4 = num2 - (int) tileSafely.frameY / 18 % 4;
    int pylonStyleFromTile = TETeleportationPylon.GetPylonStyleFromTile(tileSafely);
    bool flag = false;
    for (int index1 = num3; index1 < num3 + 3; ++index1)
    {
      for (int index2 = num4; index2 < num4 + 4; ++index2)
      {
        Tile tile = Main.tile[index1, index2];
        if (tile == null)
          return;
        if (!tile.active() || tile.type != (ushort) 597)
          flag = true;
      }
    }
    if (!WorldGen.SolidTileAllowBottomSlope(num3, num4 + 4) || !WorldGen.SolidTileAllowBottomSlope(num3 + 1, num4 + 4) || !WorldGen.SolidTileAllowBottomSlope(num3 + 2, num4 + 4))
      flag = true;
    if (!flag)
      return;
    TileEntityType<TETeleportationPylon>.Kill(num3, num4);
    int typeFromTileStyle = TETeleportationPylon.GetPylonItemTypeFromTileStyle(pylonStyleFromTile);
    Item.NewItem((IEntitySource) new EntitySource_TileBreak(num3, num4), num3 * 16 /*0x10*/, num4 * 16 /*0x10*/, 48 /*0x30*/, 64 /*0x40*/, typeFromTileStyle);
    WorldGen.destroyObject = true;
    for (int i = num3; i < num3 + 3; ++i)
    {
      for (int j = num4; j < num4 + 4; ++j)
      {
        if (Main.tile[i, j].active() && Main.tile[i, j].type == (ushort) 597)
          WorldGen.KillTile(i, j);
      }
    }
    WorldGen.destroyObject = false;
  }

  public static int GetPylonStyleFromTile(Tile tile) => (int) tile.frameX / 54;

  public static int GetPylonItemTypeFromTileStyle(int style)
  {
    switch (style)
    {
      case 1:
        return 4875;
      case 2:
        return 4916;
      case 3:
        return 4917;
      case 4:
        return 4918;
      case 5:
        return 4919;
      case 6:
        return 4920;
      case 7:
        return 4921;
      case 8:
        return 4951;
      case 9:
        return 5652;
      case 10:
        return 5653;
      default:
        return 4876;
    }
  }

  public override bool IsTileValidForEntity(int x, int y)
  {
    return Main.tile[x, y].active() && Main.tile[x, y].type == (ushort) 597 && Main.tile[x, y].frameY == (short) 0 && (int) Main.tile[x, y].frameX % 54 == 0;
  }

  public static int PlacementPreviewHook_AfterPlacement(
    int x,
    int y,
    int type = 597,
    int style = 0,
    int direction = 1,
    int alternate = 0)
  {
    if (Main.netMode != 1)
      return TileEntityType<TETeleportationPylon>.Place(x - 1, y - 3);
    NetMessage.SendTileSquare(Main.myPlayer, x - 1, y - 3, 3, 4);
    NetMessage.SendData(87, number: x - 1, number2: (float) (y - 3), number3: (float) TileEntityType<TETeleportationPylon>.EntityTypeID);
    return -1;
  }

  public static int PlacementPreviewHook_CheckIfCanPlace(
    int x,
    int y,
    int type = 597,
    int style = 0,
    int direction = 1,
    int alternate = 0)
  {
    TeleportPylonType fromPylonTileStyle = TETeleportationPylon.GetPylonTypeFromPylonTileStyle(style);
    return Main.PylonSystem.HasPylonOfType(fromPylonTileStyle) ? 1 : 0;
  }

  private bool TryGetPylonTypeFromTileCoords(int x, int y, out TeleportPylonType pylonType)
  {
    pylonType = TeleportPylonType.SurfacePurity;
    Tile tile = Main.tile[x, y];
    if (tile == null || !tile.active() || tile.type != (ushort) 597)
      return false;
    int pylonStyle = (int) tile.frameX / 54;
    pylonType = TETeleportationPylon.GetPylonTypeFromPylonTileStyle(pylonStyle);
    return true;
  }

  private static TeleportPylonType GetPylonTypeFromPylonTileStyle(int pylonStyle)
  {
    return (TeleportPylonType) pylonStyle;
  }
}
