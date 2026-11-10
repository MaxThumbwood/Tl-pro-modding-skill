// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Rooms.LivingTreeDungeonRoom
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.Utilities;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Rooms;

public class LivingTreeDungeonRoom(DungeonRoomSettings settings) : DungeonRoom(settings)
{
  private ShapeData _innerShapeData = new ShapeData();
  private ShapeData _outerShapeData = new ShapeData();
  private int _floodedTileCount;
  private Point BasePosition;

  public override void CalculateRoom(DungeonData data)
  {
    this.calculated = false;
    int x = this.settings.RoomPosition.X;
    int y = this.settings.RoomPosition.Y;
    this.LivingTreeRoom(data, x, y, false);
    this.calculated = true;
  }

  public override bool GenerateRoom(DungeonData data)
  {
    this.generated = false;
    int x = this.settings.RoomPosition.X;
    int y = this.settings.RoomPosition.Y;
    this.LivingTreeRoom(data, x, y, true);
    this.generated = true;
    return true;
  }

  public override int GetFloodedRoomTileCount() => this._floodedTileCount;

  public override void FloodRoom(byte liquidType)
  {
    if (this._innerShapeData == null)
    {
      base.FloodRoom(liquidType);
    }
    else
    {
      WormlikeDungeonRoomSettings settings = (WormlikeDungeonRoomSettings) this.settings;
      WorldUtils.Gen(this.BasePosition, (GenShape) new ModShapes.All(this._innerShapeData), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.IsBelowHeight(this.Center.Y, true), (GenAction) new Modifiers.IsNotSolid(), (GenAction) new Terraria.WorldBuilding.Actions.SetLiquid((int) liquidType)));
    }
  }

  public override ProtectionType GetProtectionTypeFromPoint(int x, int y)
  {
    if (this._innerShapeData == null || this._outerShapeData == null || this.calculated && !this.OuterBounds.Contains(x, y))
      return base.GetProtectionTypeFromPoint(x, y);
    Point basePosition = this.BasePosition;
    return !this._outerShapeData.Contains(x - basePosition.X, y - basePosition.Y) ? ProtectionType.None : ProtectionType.Walls;
  }

  public override bool IsInsideRoom(int x, int y)
  {
    Point basePosition = this.BasePosition;
    return base.IsInsideRoom(x, y) && this._innerShapeData.Contains(x - basePosition.X, y - basePosition.Y);
  }

  public override void GenerateEarlyDungeonFeaturesInRoom(DungeonData data)
  {
    UnifiedRandom genRand = new UnifiedRandom(this.settings.RandomSeed);
    ushort brickTileType = this.settings.StyleData.BrickTileType;
    ushort brickCrackedTileType = this.settings.StyleData.BrickCrackedTileType;
    int growthLength1 = (int) ((double) this.InnerBounds.Height * 0.10000000149011612) + genRand.Next(4);
    int branchDensity1 = 2 + genRand.Next(2);
    int leafDensity1 = 3 + genRand.Next(4);
    Point startPoint = new Point(this.InnerBounds.Center.X, this.InnerBounds.Top);
    DungeonUtils.GenerateHangingLeafCluster(data, genRand, this.OuterBounds, startPoint, growthLength1, branchDensity1, leafDensity1, brickCrackedTileType, brickTileType, this.settings.OverridePaintTile, this.settings.OverridePaintTile);
    int growthLength2 = (int) ((double) this.InnerBounds.Height * 0.15000000596046448) + genRand.Next(5);
    int branchDensity2 = 3 + genRand.Next(2);
    int leafDensity2 = 4 + genRand.Next(4);
    startPoint = new Point(this.InnerBounds.Left + 2 + genRand.Next(3), this.InnerBounds.Top);
    DungeonUtils.GenerateHangingLeafCluster(data, genRand, this.OuterBounds, startPoint, growthLength2, branchDensity2, leafDensity2, brickCrackedTileType, brickTileType, this.settings.OverridePaintTile, this.settings.OverridePaintTile);
    int growthLength3 = (int) ((double) this.InnerBounds.Height * 0.15000000596046448) + genRand.Next(5);
    int branchDensity3 = 3 + genRand.Next(2);
    int leafDensity3 = 4 + genRand.Next(4);
    startPoint = new Point(this.InnerBounds.Right - 2 - genRand.Next(3), this.InnerBounds.Top);
    DungeonUtils.GenerateHangingLeafCluster(data, genRand, this.OuterBounds, startPoint, growthLength3, branchDensity3, leafDensity3, brickCrackedTileType, brickTileType, this.settings.OverridePaintTile, this.settings.OverridePaintTile);
    base.GenerateEarlyDungeonFeaturesInRoom(data);
  }

  public override void GenerateLateDungeonFeaturesInRoom(DungeonData data)
  {
    UnifiedRandom unifiedRandom = new UnifiedRandom(this.settings.RandomSeed);
    LivingTreeDungeonRoomSettings settings = (LivingTreeDungeonRoomSettings) this.settings;
    ushort brickTileType = this.settings.StyleData.BrickTileType;
    ushort brickCrackedTileType = this.settings.StyleData.BrickCrackedTileType;
    ushort brickWallType = this.settings.StyleData.BrickWallType;
    for (int index = 0; index < 50; ++index)
    {
      Point point = DungeonUtils.FirstSolid(false, new Point(unifiedRandom.Next(this.InnerBounds.Left + 1, this.InnerBounds.Right), unifiedRandom.Next(this.InnerBounds.Top + 1, this.InnerBounds.Bottom)), this.InnerBounds);
      int x = point.X;
      int j = point.Y - 1;
      Tile tile = Main.tile[x, j];
      if (!tile.active() && (int) tile.wall == (int) brickWallType)
      {
        if (unifiedRandom.Next(2) == 0)
        {
          WorldGen.PlaceTile(x, j, 187, true, style: unifiedRandom.Next(47, 50));
        }
        else
        {
          int pileSize = unifiedRandom.Next(2);
          int pileStyle = 72;
          if (pileSize == 1)
            pileStyle = unifiedRandom.Next(59, 62);
          WorldGen.PlaceSmallPile(x, j, pileStyle, pileSize);
        }
      }
    }
    for (int index1 = 0; index1 < 10; ++index1)
    {
      Point point = DungeonUtils.FirstSolid(true, new Point(unifiedRandom.Next(this.InnerBounds.Left + 1, this.InnerBounds.Right), unifiedRandom.Next(this.InnerBounds.Top + 1, this.InnerBounds.Bottom)), this.InnerBounds);
      int x = point.X;
      int y = point.Y + 1;
      Tile tile1 = Main.tile[x, y];
      Tile tile2 = Main.tile[x, y - 1];
      if (!tile1.active() && (int) tile1.wall == (int) brickWallType && tile2.active() && (int) tile2.type == (int) brickCrackedTileType)
      {
        ushort num = 52;
        if (brickTileType == (ushort) 383)
          num = (ushort) 62;
        for (int index2 = unifiedRandom.Next(3, 12); index2 > 0; --index2)
        {
          Tile tile3 = Main.tile[x, y];
          if (!tile3.active())
          {
            tile3.ClearTile();
            tile3.active(true);
            tile3.type = num;
            if (settings.OverridePaintTile > -1)
              WorldGen.paintTile(x, y, (byte) settings.OverridePaintTile, paintEffects: false);
            ++y;
          }
          else
            break;
        }
      }
    }
  }

  public void LivingTreeRoom(DungeonData data, int i, int j, bool generating)
  {
    UnifiedRandom unifiedRandom = new UnifiedRandom(this.settings.RandomSeed);
    LivingTreeDungeonRoomSettings settings = (LivingTreeDungeonRoomSettings) this.settings;
    ushort brickTileType = this.settings.StyleData.BrickTileType;
    ushort brickCrackedTileType = this.settings.StyleData.BrickCrackedTileType;
    ushort brickWallType = this.settings.StyleData.BrickWallType;
    Point point1 = new Point(i, j);
    if (this.calculated)
      point1 = this.BasePosition;
    Point point2 = new Point(point1.X, point1.Y + settings.InnerHeight / 2);
    int num1 = point2.Y - settings.InnerHeight;
    int innerWidth = settings.InnerWidth;
    int depth = settings.Depth;
    int num2 = innerWidth;
    int num3 = num2 + depth;
    this.OuterBounds.SetBounds(point1.X, point1.Y, point1.X, point1.Y);
    this.InnerBounds.SetBounds(point1.X, point1.Y, point1.X, point1.Y);
    for (; point2.Y > num1; --point2.Y)
    {
      this.OuterBounds.UpdateBounds(point2.X - num3, point2.Y - num3, point2.X + num3, point2.Y + num3);
      this.InnerBounds.UpdateBounds(point2.X - num2, point2.Y - num2, point2.X + num2, point2.Y + num2);
      this._outerShapeData.AddBounds(point2.X - num3 - point1.X, point2.Y - num3 - point1.Y, point2.X + num3 - point1.X, point2.Y + num3 - point1.Y);
      this._innerShapeData.AddBounds(point2.X - num2 - point1.X, point2.Y - num2 - point1.Y, point2.X + num2 - point1.X, point2.Y + num2 - point1.Y);
      if (generating)
        this.GenerateDungeonSquareRoom(data, Vector2D.op_Implicit(point2), brickTileType, brickCrackedTileType, brickWallType, settings.InnerWidth, settings.Depth);
      if (point2.Y % 4 == 0)
        point2.X += unifiedRandom.Next(2) == 0 ? -1 : 1;
    }
    this.InnerBounds.CalculateHitbox();
    this.OuterBounds.CalculateHitbox();
    this.BasePosition = point1;
    this._floodedTileCount = DungeonUtils.CalculateFloodedTileCountFromShapeData(this.InnerBounds, this._innerShapeData);
  }
}
