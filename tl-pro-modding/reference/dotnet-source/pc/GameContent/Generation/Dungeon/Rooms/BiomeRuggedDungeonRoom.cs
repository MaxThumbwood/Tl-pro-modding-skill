// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Rooms.BiomeRuggedDungeonRoom
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;
using Terraria.GameContent.Generation.Dungeon.Features;
using Terraria.Utilities;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Rooms;

public class BiomeRuggedDungeonRoom : BiomeDungeonRoom
{
  public Vector2 Position;
  public int RoomInnerSize;
  public int RoomOuterSize;
  public int WallDepth;

  public BiomeRuggedDungeonRoom(DungeonRoomSettings settings)
    : base(settings)
  {
    this._innerShapeData = new ShapeData();
    this._outerShapeData = new ShapeData();
  }

  public override void CalculateRoom(DungeonData data)
  {
    this.calculated = false;
    int x = this.settings.RoomPosition.X;
    int y = this.settings.RoomPosition.Y;
    this.BiomeRoom(data, x, y, false);
    this.calculated = true;
  }

  public override bool GenerateRoom(DungeonData data)
  {
    this.generated = false;
    int x = this.settings.RoomPosition.X;
    int y = this.settings.RoomPosition.Y;
    this.BiomeRoom(data, x, y, true);
    this.generated = true;
    return true;
  }

  public override bool CanGenerateFeatureAt(
    DungeonData data,
    IDungeonFeature feature,
    int x,
    int y)
  {
    switch (feature)
    {
      case DungeonGlobalBanners _:
      case DungeonGlobalPaintings _:
        return false;
      default:
        return base.CanGenerateFeatureAt(data, feature, x, y);
    }
  }

  public override void GenerateEarlyDungeonFeaturesInRoom(DungeonData data)
  {
    UnifiedRandom unifiedRandom = new UnifiedRandom(this.settings.RandomSeed);
    BiomeDungeonRoomSettings settings = (BiomeDungeonRoomSettings) this.settings;
    int num = this.settings.StyleData.Style == (byte) 0 ? 1 : 0;
    ushort tileType = num != 0 ? data.genVars.brickTileType : this.settings.StyleData.BrickTileType;
    if (num == 0)
    {
      int brickWallType1 = (int) this.settings.StyleData.BrickWallType;
    }
    else
    {
      int brickWallType2 = (int) data.genVars.brickWallType;
    }
    DungeonUtils.GenerateSpeleothemsInArea(data, settings.StyleData, this.InnerBounds, this.InnerBounds.Width / 6, tileType, settings.OverridePaintTile);
    DungeonUtils.GenerateFloatingRocksInArea(data, settings.StyleData, this.InnerBounds, tileType, paint: settings.OverridePaintTile);
  }

  public void BiomeRoom(DungeonData data, int i, int j, bool generating)
  {
    UnifiedRandom genRand = new UnifiedRandom(this.settings.RandomSeed);
    BiomeDungeonRoomSettings settings = (BiomeDungeonRoomSettings) this.settings;
    ushort brickTileType = this.settings.StyleData.BrickTileType;
    ushort brickWallType = this.settings.StyleData.BrickWallType;
    Vector2 position = new Vector2((float) i, (float) j);
    int num1 = BiomeDungeonRoom.GetBiomeRoomInnerSize(settings.StyleData);
    int val2 = 8;
    int num2 = BiomeDungeonRoom.GetBiomeRoomOuterSize(settings.StyleData);
    if (this.calculated)
    {
      position = this.Position;
      num1 = this.RoomInnerSize;
      num2 = this.RoomOuterSize;
      val2 = this.WallDepth;
    }
    int val1 = 20;
    int num3 = Math.Max(val1 + val2, Math.Min(Main.maxTilesX - val1 - val2, (int) position.X - num1));
    int num4 = Math.Max(val1 + val2, Math.Min(Main.maxTilesX - val1 - val2, (int) position.X + num1));
    int num5 = Math.Max(val1 + val2, Math.Min(Main.maxTilesY - val1 - val2, (int) position.Y - num1));
    int num6 = Math.Max(val1 + val2, Math.Min(Main.maxTilesY - val1 - val2, (int) position.Y + num1));
    int num7 = Math.Max(val1, Math.Min(Main.maxTilesX - val1, (int) position.X - num2));
    int num8 = Math.Max(val1, Math.Min(Main.maxTilesX - val1, (int) position.X + num2));
    int num9 = Math.Max(val1, Math.Min(Main.maxTilesY - val1, (int) position.Y - num2));
    int num10 = Math.Max(val1, Math.Min(Main.maxTilesY - val1, (int) position.Y + num2));
    this.InnerBounds.SetBounds(num3, num5, num4, num6);
    this.OuterBounds.SetBounds(num7, num9, num8, num10);
    data.dungeonBounds.UpdateBounds(num7, num9, num8, num10);
    int num11 = num6 - num5;
    Point center = this.InnerBounds.Center;
    int num12 = Math.Max(8, val2);
    for (int index1 = num7; index1 < num8; ++index1)
    {
      int x = index1;
      float num13 = Utils.MultiLerp(Math.Max(0.0f, Math.Min(1f, (float) (index1 - num7) / Math.Max(1f, (float) (num8 - num7)))), 1f, 0.95f, 0.85f, 0.25f, 0.1f, 0.05f, 0.0f, 0.05f, 0.1f, 0.25f, 0.85f, 0.95f, 1f);
      float num14 = (float) Math.Max(1, num11 / 16 /*0x10*/) + (float) Math.Max(1, num11 / 4) * num13;
      float num15 = (float) num5 + num14 + (float) genRand.Next(3);
      float num16 = num15 - (float) num12;
      float num17 = (float) ((double) num6 - (double) num14 - 1.0) - (float) genRand.Next(3);
      float num18 = num17 + (float) num12;
      for (int index2 = num9; index2 < num10; ++index2)
      {
        bool flag1 = false;
        bool flag2 = false;
        int y = index2;
        Tile tile1 = Main.tile[x, y];
        Tile tile2 = Main.tile[x, y - 1];
        Tile tile3 = Main.tile[x, y + 1];
        Tile tile4 = Main.tile[x, y + 2];
        if (generating && (tile1.type == (ushort) 484 || tile1.type == (ushort) 485))
          tile1.active(false);
        if ((double) index2 >= (double) num16 && (double) index2 <= (double) num18)
        {
          if (index1 < num7 + val2 - 1 || index1 >= num8 - val2 + 1 || (double) index2 >= (double) num16 && (double) index2 <= (double) num15 || (double) index2 >= (double) num17 && (double) index2 <= (double) num18)
          {
            if (!generating)
            {
              this._outerShapeData.Add(x - (int) position.X, y - (int) position.Y);
            }
            else
            {
              DungeonUtils.ChangeTileType(tile1, brickTileType, false, settings.OverridePaintTile);
              if (tile1.liquid > (byte) 0)
              {
                if (flag2)
                  tile1.liquid = (byte) 0;
                tile1.liquidType(0);
              }
              if (flag1)
                DungeonUtils.ChangeWallType(tile1, (ushort) 0, false, settings.OverridePaintWall);
              else
                DungeonUtils.ChangeWallType(tile1, brickWallType, false, settings.OverridePaintWall);
            }
          }
          else if (this.InnerBounds.Contains(x, y))
          {
            if (!generating)
            {
              this._outerShapeData.Add(x - (int) position.X, y - (int) position.Y);
              this._innerShapeData.Add(x - (int) position.X, y - (int) position.Y);
            }
            else
            {
              if (tile1.liquid > (byte) 0)
              {
                if (flag2)
                  tile1.liquid = (byte) 0;
                tile1.liquidType(0);
              }
              if (flag1)
                DungeonUtils.ChangeWallType(tile1, (ushort) 0, false, settings.OverridePaintWall);
              else
                DungeonUtils.ChangeWallType(tile1, brickWallType, false, settings.OverridePaintWall);
              tile1.active(false);
              tile1.ClearBlockPaintAndCoating();
            }
          }
          else if (!generating)
          {
            this._outerShapeData.Add(x - (int) position.X, y - (int) position.Y);
          }
          else
          {
            int num19 = index1 == num7 || index1 == num8 - 1 || index2 == num9 || index2 == num10 - 1 || index1 == num3 - 1 || index1 == num4 || index2 == num5 - 1 ? 1 : (index2 == num6 ? 1 : 0);
            if (tile1.liquid > (byte) 0)
              tile1.liquid = (byte) 0;
            DungeonUtils.ChangeTileType(tile1, brickTileType, true, settings.OverridePaintTile);
            if (num19 == 0)
              DungeonUtils.ChangeWallType(tile1, brickWallType, false, settings.OverridePaintWall);
          }
        }
      }
    }
    this.BiomeRoom_AddHallwaySpace(position, num3, num4, num5, num6, 0, brickWallType, this.settings.OverridePaintWall, generating);
    this.BiomeRoom_FinishRoom(genRand, num7, num8, num9, num10);
    this.RoomInnerSize = num1;
    this.RoomOuterSize = num2;
    this.WallDepth = val2;
    this.Position = position;
    this.InnerBounds.CalculateHitbox();
    this.OuterBounds.CalculateHitbox();
  }
}
