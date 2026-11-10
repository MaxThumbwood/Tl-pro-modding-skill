// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Rooms.BiomeDungeonRoom
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using System.Collections.Generic;
using Terraria.GameContent.Generation.Dungeon.Features;
using Terraria.Utilities;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Rooms;

public abstract class BiomeDungeonRoom : DungeonRoom
{
  protected const int BIOMEROOM_INNER_SIZE_BASE = 32 /*0x20*/;
  protected const int BIOMEROOM_INNER_SIZE_BASE_TEMPLE = 50;
  protected const int BIOMEROOM_WALL_DEPTH = 8;
  protected ShapeData _innerShapeData;
  protected ShapeData _outerShapeData;

  public BiomeDungeonRoom(DungeonRoomSettings settings)
    : base(settings)
  {
  }

  public override bool CanGenerateFeatureAt(
    DungeonData data,
    IDungeonFeature feature,
    int x,
    int y)
  {
    switch (feature)
    {
      case DungeonDropTrap _:
      case DungeonPitTrap _:
      case DungeonGlobalSpikes _:
      case DungeonGlobalTraps _:
      case DungeonGlobalBookshelves _:
        return false;
      default:
        return base.CanGenerateFeatureAt(data, feature, x, y);
    }
  }

  public override void GeneratePreHallwaysDungeonFeaturesInRoom(DungeonData data)
  {
  }

  public override void GenerateEarlyDungeonFeaturesInRoom(DungeonData data)
  {
  }

  public override void CalculatePlatformsAndDoors(DungeonData data)
  {
    DungeonUtils.CalculatePlatformsAndDoorsOnEdgesOfRoom(data, this.InnerBounds, this.settings.ForceStyleForDoorsAndPlatforms ? this.settings.StyleData : (DungeonGenerationStyleData) null, new int?(0), new int?(0));
  }

  public override ConnectionPointQuality GetHallwayConnectionPoint(
    Vector2D otherRoomPos,
    out Vector2D connectionPoint)
  {
    connectionPoint = Vector2D.op_Implicit(this.Center);
    int num = Vector2D.op_Subtraction(otherRoomPos, connectionPoint).SafeNormalize(Vector2D.UnitX).X < 0.0 ? -1 : 1;
    while (this.IsInsideRoom(connectionPoint.ToPoint()))
      connectionPoint.X += (double) num;
    return ConnectionPointQuality.Good;
  }

  public override ProtectionType GetProtectionTypeFromPoint(int x, int y)
  {
    if (this.settings.StyleData.Style == (byte) 0 || this.settings.StyleData.Style == (byte) 10)
      return ProtectionType.None;
    if (this._innerShapeData != null && this._outerShapeData != null)
    {
      if (!this._outerShapeData.Contains(x - this.Center.X, y - this.Center.Y))
        return ProtectionType.None;
      return !this._innerShapeData.Contains(x - this.Center.X, y - this.Center.Y) ? ProtectionType.Walls : ProtectionType.TilesAndWalls;
    }
    if (!this.OuterBounds.Contains(x, y))
      return ProtectionType.None;
    return !this.InnerBounds.Contains(x, y) ? ProtectionType.Walls : ProtectionType.TilesAndWalls;
  }

  public override bool IsInsideRoom(int x, int y)
  {
    if (!base.IsInsideRoom(x, y))
      return false;
    return this._innerShapeData == null || this._innerShapeData.Contains(x - this.Center.X, y - this.Center.Y);
  }

  public static int GetBiomeRoomInnerSize(DungeonGenerationStyleData styleData)
  {
    float num = (float) Main.maxTilesX / 4200f;
    return styleData.Style == (byte) 10 ? (int) (50.0 * (double) num) : (int) (32.0 * (double) num);
  }

  public static int GetBiomeRoomOuterSize(DungeonGenerationStyleData styleData)
  {
    return BiomeDungeonRoom.GetBiomeRoomInnerSize(styleData) + 8;
  }

  public void BiomeRoom_AddHallwaySpace(
    Vector2 position,
    int edgeLeft,
    int edgeRight,
    int edgeTop,
    int edgeBottom,
    int shapeOffset,
    ushort wallType,
    int wallPaint,
    bool generating)
  {
    int num1 = (edgeTop + edgeBottom) / 2 - 3;
    int num2 = (edgeTop + edgeBottom) / 2 + 3;
    for (int index1 = edgeLeft; index1 < edgeRight; ++index1)
    {
      int index2 = index1;
      for (int index3 = num1; index3 < num2; ++index3)
      {
        int index4 = index3;
        Tile tile = Main.tile[index2, index4];
        if (!generating && this._innerShapeData != null)
        {
          this._innerShapeData.Add(index2 - (int) position.X + shapeOffset, index4 - (int) position.Y + shapeOffset);
          this._outerShapeData.Add(index2 - (int) position.X + shapeOffset, index4 - (int) position.Y + shapeOffset);
        }
        else
        {
          tile.active(false);
          if ((int) tile.wall != (int) wallType)
            DungeonUtils.ChangeWallType(tile, wallType, false, wallPaint);
        }
      }
    }
  }

  public void BiomeRoom_FinishRoom(
    UnifiedRandom genRand,
    int outerRoomLeft,
    int outerRoomRight,
    int outerRoomTop,
    int outerRoomBottom,
    bool treatAsSurface = false)
  {
    List<int> heightsToSkip = new List<int>();
    for (int index1 = outerRoomLeft; index1 < outerRoomRight; ++index1)
    {
      heightsToSkip.Clear();
      int index2 = index1;
      for (int index3 = outerRoomTop; index3 < outerRoomBottom; ++index3)
      {
        int index4 = index3;
        Tile tile = Main.tile[index2, index4];
        if (heightsToSkip.Contains(index4))
          heightsToSkip.Remove(index4);
        else if (this.InnerBounds.Contains(index2, index4))
        {
          switch (this.settings.StyleData.Style)
          {
            case 2:
              if (treatAsSurface)
                this.BiomeRoom_SnowySurface(genRand, ref heightsToSkip, index2, index4, tile);
              if (tile.liquid > (byte) 0)
              {
                tile.liquidType(0);
                continue;
              }
              continue;
            case 3:
              if (treatAsSurface)
                this.BiomeRoom_SandySurface(genRand, ref heightsToSkip, index2, index4, tile);
              if (tile.liquid > (byte) 0)
              {
                tile.liquidType(1);
                continue;
              }
              continue;
            case 4:
              if (treatAsSurface)
                this.BiomeRoom_GrassySurface(genRand, ref heightsToSkip, index2, index4, tile, (ushort) 25, (ushort) 23);
              if (tile.liquid > (byte) 0)
              {
                tile.liquidType(0);
                continue;
              }
              continue;
            case 5:
              if (treatAsSurface)
                this.BiomeRoom_GrassySurface(genRand, ref heightsToSkip, index2, index4, tile, (ushort) 203, (ushort) 199);
              if (tile.liquid > (byte) 0)
              {
                tile.liquidType(0);
                continue;
              }
              continue;
            case 6:
              if (treatAsSurface)
                this.BiomeRoom_GrassySurface(genRand, ref heightsToSkip, index2, index4, tile, (ushort) 117, (ushort) 109);
              if (tile.liquid > (byte) 0)
              {
                tile.liquidType(0);
                continue;
              }
              continue;
            default:
              if (tile.liquid > (byte) 0)
              {
                tile.liquidType(0);
                continue;
              }
              continue;
          }
        }
      }
    }
  }

  public void BiomeRoom_GrassySurface(
    UnifiedRandom genRand,
    ref List<int> heightsToSkip,
    int tileX,
    int tileY,
    Tile tile,
    ushort tileTypeToReplace,
    ushort grassTileType)
  {
    if (Main.tile[tileX, tileY - 1].active() || !tile.active() || (int) tile.type != (int) tileTypeToReplace)
      return;
    if (WorldGen.TileIsExposedToAir(tileX, tileY))
      DungeonUtils.ChangeTileType(tile, grassTileType, false);
    else
      DungeonUtils.ChangeTileType(tile, (ushort) 0, false);
    for (int index = 0; index < 5 + genRand.Next(4); ++index)
    {
      int y = tileY + index;
      Tile tile1 = Main.tile[tileX, y];
      if (tile1.active() && (int) tile1.type == (int) tileTypeToReplace)
      {
        heightsToSkip.Add(y);
        tile1.liquid = (byte) 0;
        if (WorldGen.TileIsExposedToAir(tileX, y))
          DungeonUtils.ChangeTileType(tile1, grassTileType, false);
        else
          DungeonUtils.ChangeTileType(tile1, (ushort) 0, false);
      }
    }
  }

  public void BiomeRoom_SandySurface(
    UnifiedRandom genRand,
    ref List<int> heightsToSkip,
    int tileX,
    int tileY,
    Tile tile)
  {
    if (Main.tile[tileX, tileY - 1].active() || !tile.active() || tile.type != (ushort) 396)
      return;
    if (WorldGen.BlockBelowMakesSandConvertIntoHardenedSand(tileX, tileY))
      DungeonUtils.ChangeTileType(tile, (ushort) 397, false);
    else
      DungeonUtils.ChangeTileType(tile, (ushort) 53, false);
    for (int index = 0; index < 5 + genRand.Next(4); ++index)
    {
      int j = tileY + index;
      Tile tile1 = Main.tile[tileX, j];
      if (tile1.active() && tile1.type == (ushort) 396)
      {
        heightsToSkip.Add(j);
        tile1.liquid = (byte) 0;
        if (WorldGen.BlockBelowMakesSandConvertIntoHardenedSand(tileX, j))
          DungeonUtils.ChangeTileType(tile1, (ushort) 397, false);
        else
          DungeonUtils.ChangeTileType(tile1, (ushort) 53, false);
      }
    }
  }

  public void BiomeRoom_SnowySurface(
    UnifiedRandom genRand,
    ref List<int> heightsToSkip,
    int tileX,
    int tileY,
    Tile tile)
  {
    if (Main.tile[tileX, tileY - 1].active() || !tile.active() || tile.type != (ushort) 161)
      return;
    DungeonUtils.ChangeTileType(tile, (ushort) 147, false);
    for (int index1 = 0; index1 < 5 + genRand.Next(4); ++index1)
    {
      int index2 = tileY + index1;
      Tile tile1 = Main.tile[tileX, index2];
      if (tile1.active() && tile1.type == (ushort) 161)
      {
        heightsToSkip.Add(index2);
        tile1.liquid = (byte) 0;
        DungeonUtils.ChangeTileType(tile1, (ushort) 147, false);
      }
    }
  }
}
