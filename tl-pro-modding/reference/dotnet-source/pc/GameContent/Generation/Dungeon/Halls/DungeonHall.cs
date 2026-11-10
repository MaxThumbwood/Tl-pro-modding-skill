// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Halls.DungeonHall
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using ReLogic.Utilities;
using System;
using System.Collections.Generic;
using Terraria.GameContent.Generation.Dungeon.Rooms;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Halls;

public abstract class DungeonHall
{
  public DungeonHallSettings settings;
  public bool calculated;
  public bool generated;
  public DungeonBounds Bounds = new DungeonBounds();
  public Vector2D StartPosition;
  public Vector2D EndPosition;
  public Vector2D StartDirection;
  public Vector2D EndDirection;
  public bool CrackedBrick;

  public bool Processed => this.calculated || this.generated;

  public Vector2D CenterPosition
  {
    get => Vector2D.op_Division(Vector2D.op_Addition(this.StartPosition, this.EndPosition), 2.0);
  }

  public DungeonHall(DungeonHallSettings settings) => this.settings = settings;

  public abstract void CalculateHall(DungeonData data, Vector2D startPoint, Vector2D endPoint);

  public abstract void CalculatePlatformsAndDoors(DungeonData data);

  public abstract void GenerateHall(DungeonData data);

  public virtual int GetFurnitureCount(int defaultCount) => defaultCount;

  public void GenerateDungeonSquareHall(
    DungeonData data,
    List<DungeonRoom> roomsInArea,
    Vector2D currentPoint,
    ushort tileType,
    ushort tileCrackedType,
    ushort wallType,
    int innerBoundsSize,
    int outerBoundsSize,
    bool placeOverProtectedBricks = false,
    bool crackedBricks = false,
    bool clearPaintFirst = false)
  {
    int num = innerBoundsSize + outerBoundsSize;
    for (int index1 = -num; index1 <= num; ++index1)
    {
      int index2 = (int) currentPoint.X + index1;
      for (int index3 = -num; index3 <= num; ++index3)
      {
        int index4 = (int) currentPoint.Y + index3;
        bool flag1 = true;
        bool flag2 = true;
        ProtectionType protectionTypeFromPoint = DungeonUtils.GetHighestProtectionTypeFromPoint(index2, index4, roomsInArea);
        switch (protectionTypeFromPoint)
        {
          case ProtectionType.Tiles:
            flag1 = false;
            break;
          case ProtectionType.TilesAndWalls:
            continue;
        }
        if (protectionTypeFromPoint == ProtectionType.Walls && DungeonUtils.IsConsideredDungeonWall((int) Main.tile[index2, index4].wall))
          flag2 = false;
        Tile tile = Main.tile[index2, index4];
        if (Math.Abs(index1) <= innerBoundsSize && Math.Abs(index3) <= innerBoundsSize)
        {
          if (this.CanRemoveTileAt(data, tile, (int) tileCrackedType))
          {
            if (crackedBricks)
            {
              if ((tile.active() ? 0 : (DungeonUtils.IsConsideredDungeonWall((int) tile.wall) ? 1 : 0)) == 0 && index4 < Main.UnderworldLayer)
              {
                if (this.settings.CarveOnly)
                {
                  tile.ClearTile();
                }
                else
                {
                  if (flag1)
                    tile.ClearTile();
                  if (flag2)
                    tile.wall = (ushort) 0;
                  if (flag2)
                  {
                    if (clearPaintFirst)
                      WorldGen.paintWall(index2, index4, (byte) 0, paintEffects: false);
                    DungeonUtils.ChangeWallType(tile, wallType, false, this.settings.OverridePaintWall);
                  }
                  if (flag1)
                  {
                    if (clearPaintFirst)
                      WorldGen.paintTile(index2, index4, (byte) 0, paintEffects: false);
                    DungeonUtils.ChangeTileType(tile, tileCrackedType, false, this.settings.OverridePaintTile);
                  }
                }
              }
            }
            else
            {
              tile.ClearTile();
              if (!this.settings.CarveOnly & flag2)
              {
                if (clearPaintFirst)
                  WorldGen.paintWall(index2, index4, (byte) 0, paintEffects: false);
                DungeonUtils.ChangeWallType(tile, wallType, false, this.settings.OverridePaintWall);
              }
            }
          }
          else
            continue;
        }
        else if (this.CanPlaceTileAt(data, tile, (int) tileType, (int) tileCrackedType))
        {
          if (flag1)
            tile.ClearTile();
          if (flag2)
            tile.wall = (ushort) 0;
          if (flag1)
          {
            if (clearPaintFirst)
              WorldGen.paintTile(index2, index4, (byte) 0, paintEffects: false);
            DungeonUtils.ChangeTileType(tile, tileType, false, this.settings.OverridePaintTile);
          }
          if (flag2 && index1 > -num && index1 < num && index3 > -num && index3 < num)
          {
            if (clearPaintFirst)
              WorldGen.paintWall(index2, index4, (byte) 0, paintEffects: false);
            DungeonUtils.ChangeWallType(tile, wallType, false, this.settings.OverridePaintWall);
          }
        }
        tile.liquid = (byte) 0;
      }
    }
  }

  public virtual bool CanPlaceTileAt(
    DungeonData data,
    Tile tile,
    int tileType,
    int tileCrackedType)
  {
    if (this.settings.CarveOnly)
      return false;
    if (!DungeonUtils.IsConsideredDungeonWall((int) tile.wall))
      return true;
    return tile.active() && !DungeonUtils.IsHigherOrEqualTieredDungeonTile(data, (int) tile.type, tileType) && (int) tile.type != tileCrackedType;
  }

  public virtual bool CanRemoveTileAt(DungeonData data, Tile tile, int tileCrackedType)
  {
    return !tile.active() || data.Type != DungeonType.DualDungeon || (int) tile.type != tileCrackedType;
  }
}
