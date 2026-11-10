// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Rooms.DungeonRoom
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using System;
using Terraria.GameContent.Generation.Dungeon.Features;
using Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Rooms;

public abstract class DungeonRoom
{
  public DungeonRoomSettings settings;
  public bool calculated;
  public bool generated;
  public DungeonBounds InnerBounds = new DungeonBounds();
  public DungeonBounds OuterBounds = new DungeonBounds();

  public bool Processed => this.calculated || this.generated;

  public Point Center => this.InnerBounds.Center;

  public DungeonRoom(DungeonRoomSettings settings) => this.settings = settings;

  public virtual bool CanGenerateFeatureAt(
    DungeonData data,
    IDungeonFeature feature,
    int x,
    int y)
  {
    return (!(feature is DungeonWindow) || data.Type == DungeonType.DualDungeon) && (!(feature is DungeonPitTrap) || ((DungeonPitTrapSettings) ((DungeonFeature) feature).settings).ConnectedRoom == this) && this.settings.StyleData.CanGenerateFeatureAt(data, this, feature, x, y);
  }

  public virtual void GeneratePreHallwaysDungeonFeaturesInRoom(DungeonData data)
  {
    if (this.settings.StyleData.Style != (byte) 4 && this.settings.StyleData.Style != (byte) 5 || this.InnerBounds.Width <= 10 || this.InnerBounds.Height <= 10)
      return;
    DungeonUtils.GenerateSpeleothemsInArea(data, this.settings.StyleData, this.InnerBounds.Left, this.InnerBounds.Top, this.InnerBounds.Width, this.InnerBounds.Height, Math.Max(3, this.InnerBounds.Width / 3), this.settings.StyleData.BrickTileType, this.settings.OverridePaintTile);
  }

  public virtual void GenerateEarlyDungeonFeaturesInRoom(DungeonData data)
  {
    UnifiedRandom unifiedRandom = new UnifiedRandom(this.settings.RandomSeed);
    if (data.Type != DungeonType.DualDungeon)
      return;
    if (unifiedRandom.Next(3) == 0)
    {
      DungeonWindowBasicSettings windowBasicSettings = new DungeonWindowBasicSettings();
      windowBasicSettings.Style = this.settings.StyleData;
      windowBasicSettings.Closed = (double) this.InnerBounds.Bottom > Main.worldSurface;
      DungeonWindowBasicSettings settings = windowBasicSettings;
      int width = this.InnerBounds.Width;
      int height = this.InnerBounds.Height;
      bool flag = true;
      int num = unifiedRandom.Next(3);
      if (num >= 1 && num <= 2 && (width <= 36 || height <= 15))
        num = 0;
      if (num == 0 && (width <= 14 || height <= 10))
        flag = false;
      if (flag)
      {
        Point center = this.InnerBounds.Center;
        switch (num)
        {
          case 1:
          case 2:
            int val2_1 = Math.Min(7, Math.Max(3, this.InnerBounds.Width / 5));
            if (val2_1 % 2 == 0)
              ++val2_1;
            settings.Width = Math.Max(3, val2_1);
            settings.Height = Math.Max(5, this.InnerBounds.Height / 3);
            DungeonWindow feature1 = (DungeonWindow) new DungeonWindowBasic((DungeonFeatureSettings) settings);
            Point forDungeonFeature1 = this.GetRoomCenterForDungeonFeature(data, (DungeonFeature) feature1);
            if (this.CanGenerateFeatureAt(data, (IDungeonFeature) feature1, forDungeonFeature1.X, forDungeonFeature1.Y))
              feature1.GenerateFeature(data, forDungeonFeature1.X, forDungeonFeature1.Y);
            settings.Height -= 2;
            DungeonWindow feature2 = (DungeonWindow) new DungeonWindowBasic((DungeonFeatureSettings) settings);
            if (this.CanGenerateFeatureAt(data, (IDungeonFeature) feature2, forDungeonFeature1.X - val2_1 - 2, forDungeonFeature1.Y))
              feature2.GenerateFeature(data, forDungeonFeature1.X - val2_1 - 2, forDungeonFeature1.Y);
            DungeonWindow feature3 = (DungeonWindow) new DungeonWindowBasic((DungeonFeatureSettings) settings);
            if (this.CanGenerateFeatureAt(data, (IDungeonFeature) feature3, forDungeonFeature1.X + val2_1 + 2, forDungeonFeature1.Y))
            {
              feature3.GenerateFeature(data, forDungeonFeature1.X + val2_1 + 2, forDungeonFeature1.Y);
              break;
            }
            break;
          default:
            int val2_2 = Math.Max(3, this.InnerBounds.Width / 3);
            if (val2_2 % 2 == 0)
              ++val2_2;
            settings.Width = Math.Max(3, val2_2);
            settings.Height = Math.Max(5, this.InnerBounds.Height / 3);
            DungeonWindow feature4 = (DungeonWindow) new DungeonWindowBasic((DungeonFeatureSettings) settings);
            Point forDungeonFeature2 = this.GetRoomCenterForDungeonFeature(data, (DungeonFeature) feature4);
            if (this.CanGenerateFeatureAt(data, (IDungeonFeature) feature4, forDungeonFeature2.X, forDungeonFeature2.Y))
            {
              feature4.GenerateFeature(data, forDungeonFeature2.X, forDungeonFeature2.Y);
              break;
            }
            break;
        }
      }
    }
    int liquidType = this.settings.StyleData.LiquidType;
    if (liquidType < 0)
      return;
    this.FloodRoom((byte) liquidType);
  }

  public virtual void GenerateLateDungeonFeaturesInRoom(DungeonData data)
  {
  }

  public virtual Point GetRoomCenterForDungeonFeature(DungeonData data, DungeonFeature feature)
  {
    return this.Center;
  }

  public virtual Point GetRoomCenterForHallway(Vector2D otherRoomPos) => this.Center;

  public abstract void CalculateRoom(DungeonData data);

  public virtual void CalculatePlatformsAndDoors(DungeonData data)
  {
    DungeonUtils.CalculatePlatformsAndDoorsOnEdgesOfRoom(data, this.InnerBounds, this.settings.ForceStyleForDoorsAndPlatforms ? this.settings.StyleData : (DungeonGenerationStyleData) null, new int?(3), new int?(3));
  }

  public virtual ConnectionPointQuality GetHallwayConnectionPoint(
    Vector2D otherRoomPos,
    out Vector2D connectionPoint)
  {
    if (this.settings.HallwayConnectionPointOverride != null)
    {
      int hallwayConnectionPoint = (int) this.settings.HallwayConnectionPointOverride(this, otherRoomPos, out connectionPoint);
      if (!this.settings.HallwayPointAdjuster.HasValue)
        return (ConnectionPointQuality) hallwayConnectionPoint;
      Vector2D vector2D = Vector2D.op_Subtraction(otherRoomPos, connectionPoint).SafeNormalize(Vector2D.UnitX);
      connectionPoint = Vector2D.op_Subtraction(connectionPoint, Vector2D.op_Multiply(vector2D, (double) this.settings.HallwayPointAdjuster.Value));
      return (ConnectionPointQuality) hallwayConnectionPoint;
    }
    connectionPoint = Vector2D.op_Implicit(this.GetRoomCenterForHallway(otherRoomPos));
    Vector2D vector2D1 = Vector2D.op_Subtraction(otherRoomPos, connectionPoint).SafeNormalize(Vector2D.UnitX);
    if (-0.5 < vector2D1.Y && vector2D1.Y < 0.7 && WorldGen.genRand.Next(2) == 0)
    {
      while (this.IsInsideRoom(connectionPoint.ToPoint()))
        ++connectionPoint.Y;
      connectionPoint.Y -= 3.0;
    }
    else if (-0.7 < vector2D1.Y && vector2D1.Y < 0.5 && WorldGen.genRand.Next(3) == 0)
    {
      while (this.IsInsideRoom(connectionPoint.ToPoint()))
        --connectionPoint.Y;
      connectionPoint.Y += 3.0;
    }
    else
      connectionPoint = Vector2D.op_Addition(connectionPoint, WorldGen.genRand.NextVector2DCircularEdge(4.0, 4.0));
    Vector2D vector2D2 = Vector2D.op_Subtraction(otherRoomPos, connectionPoint).SafeNormalize(Vector2D.UnitX);
    while (this.IsInsideRoom(connectionPoint.ToPoint()))
      connectionPoint = Vector2D.op_Addition(connectionPoint, vector2D2);
    if (this.settings.HallwayPointAdjuster.HasValue)
      connectionPoint = Vector2D.op_Subtraction(connectionPoint, Vector2D.op_Multiply(vector2D2, (double) this.settings.HallwayPointAdjuster.Value));
    return ConnectionPointQuality.Good;
  }

  public abstract bool GenerateRoom(DungeonData data);

  public virtual bool TryGenerateChestInRoom(DungeonData data, DungeonGlobalBasicChests feature)
  {
    return DungeonUtils.GenerateDungeonRegularChest(data, feature, this.settings.StyleData, this.InnerBounds);
  }

  public virtual bool DualDungeons_TryGenerateBiomeChestInRoom(
    DungeonData data,
    DungeonGlobalBiomeChests feature)
  {
    return DungeonUtils.GenerateDungeonBiomeChest(data, feature, this.settings.StyleData, this.InnerBounds);
  }

  public virtual ProtectionType GetProtectionTypeFromPoint(int x, int y)
  {
    return !this.OuterBounds.Contains(x, y) ? ProtectionType.None : ProtectionType.Walls;
  }

  public bool IsInsideRoom(Point point) => this.IsInsideRoom(point.X, point.Y);

  public virtual bool IsInsideRoom(int x, int y) => this.InnerBounds.Contains(x, y);

  public virtual int GetFloodedRoomTileCount() => this.InnerBounds.Width * this.InnerBounds.Height;

  public virtual void FloodRoom(byte liquidType)
  {
    for (int left = this.InnerBounds.Left; left <= this.InnerBounds.Right; ++left)
    {
      for (int y = this.InnerBounds.Center.Y; y <= this.InnerBounds.Bottom; ++y)
      {
        Tile tile = Main.tile[left, y];
        if (!tile.active())
        {
          tile.liquid = byte.MaxValue;
          tile.liquidType((int) liquidType);
        }
      }
    }
  }

  public virtual int GetFurnitureCount(int defaultCount) => defaultCount;

  public void GenerateDungeonSquareRoom(
    DungeonData data,
    DungeonBounds innerBounds,
    DungeonBounds outerBounds,
    Vector2D currentPoint,
    ushort tileType,
    ushort wallType,
    int innerBoundsSize,
    int totalBoundsSize,
    bool genTiles = true,
    bool genWalls = true)
  {
    for (int index1 = -totalBoundsSize; index1 <= totalBoundsSize; ++index1)
    {
      int x = (int) currentPoint.X + index1;
      for (int index2 = -totalBoundsSize; index2 <= totalBoundsSize; ++index2)
      {
        int y = (int) currentPoint.Y + index2;
        Tile tile = Main.tile[x, y];
        if (Math.Abs(index1) <= innerBoundsSize && Math.Abs(index2) <= innerBoundsSize)
        {
          innerBounds.UpdateBounds(x, y);
          if (genWalls)
            DungeonUtils.ChangeWallType(tile, wallType, true, this.settings.OverridePaintWall);
        }
        else if (!DungeonUtils.IsHigherOrEqualTieredDungeonWall(data, (int) tile.wall, (int) wallType))
        {
          outerBounds.UpdateBounds(x, y);
          if (genTiles)
            DungeonUtils.ChangeTileType(tile, tileType, true, this.settings.OverridePaintTile);
          if (genWalls && index1 > -totalBoundsSize && index1 < totalBoundsSize && index2 > -totalBoundsSize && index2 < totalBoundsSize)
            DungeonUtils.ChangeWallType(tile, wallType, false, this.settings.OverridePaintWall);
        }
      }
    }
  }

  public void GenerateDungeonSquareRoom(
    DungeonData data,
    Vector2D currentPoint,
    ushort tileType,
    ushort tileCrackedType,
    ushort wallType,
    int innerBoundsSize,
    int outerBoundsSize,
    bool crackedBricks = false)
  {
    int num = innerBoundsSize + outerBoundsSize;
    for (int index1 = -num; index1 <= num; ++index1)
    {
      int index2 = (int) currentPoint.X + index1;
      for (int index3 = -num; index3 <= num; ++index3)
      {
        int index4 = (int) currentPoint.Y + index3;
        Tile tile = Main.tile[index2, index4];
        if (Math.Abs(index1) <= innerBoundsSize && Math.Abs(index3) <= innerBoundsSize)
        {
          if (crackedBricks)
          {
            if ((tile.active() ? 0 : (DungeonUtils.IsConsideredDungeonWall((int) tile.wall) ? 1 : 0)) == 0 && index4 < Main.UnderworldLayer)
            {
              tile.ClearTile();
              tile.wall = (ushort) 0;
              DungeonUtils.ChangeWallType(tile, wallType, false, this.settings.OverridePaintWall);
              DungeonUtils.ChangeTileType(tile, tileCrackedType, false, this.settings.OverridePaintTile);
            }
          }
          else
          {
            tile.ClearTile();
            DungeonUtils.ChangeWallType(tile, wallType, false, this.settings.OverridePaintWall);
          }
        }
        else if (tile.active() && !DungeonUtils.IsHigherOrEqualTieredDungeonTile(data, (int) tile.type, (int) tileType) || !DungeonUtils.IsConsideredDungeonWall((int) tile.wall))
        {
          tile.ClearTile();
          tile.wall = (ushort) 0;
          DungeonUtils.ChangeTileType(tile, tileType, false, this.settings.OverridePaintTile);
          if (index1 > -num && index1 < num && index3 > -num && index3 < num)
            DungeonUtils.ChangeWallType(tile, wallType, false, this.settings.OverridePaintWall);
        }
        tile.liquid = (byte) 0;
      }
    }
  }
}
