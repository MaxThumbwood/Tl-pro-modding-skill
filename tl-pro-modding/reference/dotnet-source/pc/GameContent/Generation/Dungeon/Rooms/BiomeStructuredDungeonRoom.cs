// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Rooms.BiomeStructuredDungeonRoom
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

public class BiomeStructuredDungeonRoom : BiomeDungeonRoom
{
  public const int VARIANT_DOUBLEDIAMOND = 0;
  public const int VARIANT_ROUNDED = 1;
  public const int VARIANT_CANDY = 2;
  public const int VARIANT_WIGGLED = 3;
  public const int MAX_VARIANTS = 4;
  public Vector2 Position;
  public int RoomInnerSize;
  public int RoomOuterSize;
  public int WallDepth;

  public BiomeStructuredDungeonRoom(DungeonRoomSettings settings)
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

  public override void GenerateEarlyDungeonFeaturesInRoom(DungeonData data)
  {
    UnifiedRandom unifiedRandom = new UnifiedRandom(this.settings.RandomSeed);
    BiomeDungeonRoomSettings settings1 = (BiomeDungeonRoomSettings) this.settings;
    int style = (int) this.settings.StyleData.Style;
    int x = this.InnerBounds.Center.X;
    int y = this.InnerBounds.Center.Y;
    int width = this.InnerBounds.Width;
    int height = this.InnerBounds.Height;
    int bottom = this.InnerBounds.Bottom;
    int num1 = (int) ((double) width * 0.25);
    int num2 = unifiedRandom.Next(2);
    if (num2 == 1 && !settings1.StyleData.CanGenerateFeatureAt(data, (DungeonRoom) this, (IDungeonFeature) null, x, y))
      num2 = 0;
    if (num2 == 0 || num2 != 1)
    {
      DungeonWindowBasicSettings windowBasicSettings = new DungeonWindowBasicSettings();
      windowBasicSettings.Style = this.settings.StyleData;
      windowBasicSettings.Width = 9;
      windowBasicSettings.Height = height / 5;
      windowBasicSettings.Closed = unifiedRandom.Next(3) != 0;
      DungeonWindowBasicSettings settings2 = windowBasicSettings;
      new DungeonWindowBasic((DungeonFeatureSettings) settings2).GenerateFeature(data, x, y);
      settings2.Width = 7;
      settings2.Height = height / 5 - 4;
      new DungeonWindowBasic((DungeonFeatureSettings) settings2).GenerateFeature(data, x - num1, y + 3);
      new DungeonWindowBasic((DungeonFeatureSettings) settings2).GenerateFeature(data, x + num1, y + 3);
    }
    else
    {
      int num3 = 4;
      DungeonPillarSettings settings3 = new DungeonPillarSettings();
      settings3.Style = this.settings.StyleData;
      settings3.OverridePaintTile = this.settings.OverridePaintTile;
      settings3.OverridePaintWall = this.settings.OverridePaintWall;
      settings3.PillarType = PillarType.BlockActuatedSolidTop;
      settings3.Width = 10;
      settings3.Height = bottom - y + 5;
      settings3.CrowningOnTop = true;
      settings3.CrowningOnBottom = false;
      settings3.CrowningStopsAtPillar = true;
      settings3.AlwaysPlaceEntirePillar = false;
      new DungeonPillar((DungeonFeatureSettings) settings3).GenerateFeature(data, x + 1, bottom + num3);
      settings3.Width = 7;
      settings3.Height = bottom - y;
      new DungeonPillar((DungeonFeatureSettings) settings3).GenerateFeature(data, x - num1 + 1, bottom + num3);
      new DungeonPillar((DungeonFeatureSettings) settings3).GenerateFeature(data, x + num1, bottom + num3);
    }
  }

  public void BiomeRoom(DungeonData data, int i, int j, bool generating)
  {
    UnifiedRandom genRand = new UnifiedRandom(this.settings.RandomSeed);
    BiomeDungeonRoomSettings settings = (BiomeDungeonRoomSettings) this.settings;
    ushort brickTileType = this.settings.StyleData.BrickTileType;
    ushort brickWallType = this.settings.StyleData.BrickWallType;
    Vector2 position = new Vector2((float) i, (float) j);
    int num1 = BiomeDungeonRoom.GetBiomeRoomInnerSize(settings.StyleData);
    int num2 = 8;
    int num3 = BiomeDungeonRoom.GetBiomeRoomOuterSize(settings.StyleData);
    if (this.calculated)
    {
      position = this.Position;
      num1 = this.RoomInnerSize;
      num3 = this.RoomOuterSize;
      num2 = this.WallDepth;
    }
    int val1 = 20;
    int num4 = Math.Max(val1 + num2, Math.Min(Main.maxTilesX - val1 - num2, (int) position.X - num1));
    int edgeRight = Math.Max(val1 + num2, Math.Min(Main.maxTilesX - val1 - num2, (int) position.X + num1));
    int num5 = Math.Max(val1 + num2, Math.Min(Main.maxTilesY - val1 - num2, (int) position.Y - num1));
    int edgeBottom = Math.Max(val1 + num2, Math.Min(Main.maxTilesY - val1 - num2, (int) position.Y + num1));
    int num6 = Math.Max(val1, Math.Min(Main.maxTilesX - val1, (int) position.X - num3));
    int outerRoomRight = Math.Max(val1, Math.Min(Main.maxTilesX - val1, (int) position.X + num3));
    int num7 = Math.Max(val1, Math.Min(Main.maxTilesY - val1, (int) position.Y - num3));
    int outerRoomBottom = Math.Max(val1, Math.Min(Main.maxTilesY - val1, (int) position.Y + num3));
    this.InnerBounds.SetBounds(num4, num5, edgeRight - 1, edgeBottom - 1);
    this.OuterBounds.SetBounds(num6, num7, outerRoomRight - 1, outerRoomBottom - 1);
    data.dungeonBounds.UpdateBounds(num6, num7, outerRoomRight - 1, outerRoomBottom - 1);
    int num8 = outerRoomRight - num6;
    int num9 = outerRoomBottom - num7;
    Point center1 = this.OuterBounds.Center;
    Point center2 = this.OuterBounds.Center;
    int variant = genRand.Next(4);
    int shapeOffset = 1;
    for (int index1 = num6; index1 < outerRoomRight; ++index1)
    {
      int x = index1;
      float percentile1 = Math.Max(0.0f, Math.Min(1f, (float) (index1 - num6) / Math.Max(1f, (float) (outerRoomRight - 1 - num6))));
      float ypercent = this.BiomeRoom_GetYPercent(genRand, variant, percentile1);
      float num10 = (float) Math.Max(1, num9 / 16 /*0x10*/) + (float) Math.Max(1, num9 / 4) * ypercent;
      float num11 = (float) num5 + num10;
      float num12 = num11 - (float) num2;
      float num13 = (float) ((double) edgeBottom - (double) num10 - 1.0);
      float num14 = num13 + (float) num2;
      for (int index2 = num7; index2 < outerRoomBottom; ++index2)
      {
        int y = index2;
        float percentile2 = Math.Max(0.0f, Math.Min(1f, (float) (index2 - num7) / Math.Max(1f, (float) (outerRoomBottom - 1 - num7))));
        float xpercent = this.BiomeRoom_GetXPercent(genRand, variant, percentile2);
        float num15 = (float) Math.Max(1, num8 / 4) * xpercent;
        float num16 = (float) num4 + num15;
        float num17 = num16 - (float) num2;
        float num18 = (float) ((double) edgeRight - (double) num15 - 1.0);
        float num19 = num18 + (float) num2;
        Tile tile1 = Main.tile[x, y];
        Tile tile2 = Main.tile[x, y - 1];
        Tile tile3 = Main.tile[x, y + 1];
        Tile tile4 = Main.tile[x, y + 2];
        if (generating && (tile1.type == (ushort) 484 || tile1.type == (ushort) 485))
          tile1.active(false);
        if ((double) index2 >= (double) num12 && (double) index2 <= (double) num14 && (double) index1 >= (double) num17 && (double) index1 <= (double) num19)
        {
          if (index1 <= num6 + num2 - 1 || index1 >= outerRoomRight - num2 + 1 || (double) index2 >= (double) num12 && (double) index2 <= (double) num11 || (double) index2 >= (double) num13 && (double) index2 <= (double) num14 || (double) index1 >= (double) num17 && (double) index1 <= (double) num16 || (double) index1 >= (double) num18 && (double) index1 <= (double) num19)
          {
            if (!generating)
            {
              this._outerShapeData.Add(x - (int) position.X + shapeOffset, y - (int) position.Y + shapeOffset);
            }
            else
            {
              DungeonUtils.ChangeTileType(tile1, brickTileType, false, settings.OverridePaintTile);
              if (tile1.liquid > (byte) 0)
              {
                tile1.liquid = (byte) 0;
                tile1.liquidType(0);
              }
              DungeonUtils.ChangeWallType(tile1, brickWallType, false, settings.OverridePaintWall);
            }
          }
          else if (this.InnerBounds.Contains(x, y))
          {
            if (!generating)
            {
              this._innerShapeData.Add(x - (int) position.X + shapeOffset, y - (int) position.Y + shapeOffset);
              this._outerShapeData.Add(x - (int) position.X + shapeOffset, y - (int) position.Y + shapeOffset);
            }
            else
            {
              if (tile1.liquid > (byte) 0)
              {
                tile1.liquid = (byte) 0;
                tile1.liquidType(0);
              }
              DungeonUtils.ChangeWallType(tile1, brickWallType, false, settings.OverridePaintWall);
              tile1.active(false);
              tile1.ClearBlockPaintAndCoating();
            }
          }
          else if (!generating)
          {
            this._outerShapeData.Add(x - (int) position.X + shapeOffset, y - (int) position.Y + shapeOffset);
          }
          else
          {
            int num20 = index1 == num6 || index1 == outerRoomRight - 1 || index2 == num7 || index2 == outerRoomBottom - 1 || index1 == num4 - 1 || index1 == edgeRight || index2 == num5 - 1 ? 1 : (index2 == edgeBottom ? 1 : 0);
            if (tile1.liquid > (byte) 0)
            {
              tile1.liquid = (byte) 0;
              tile1.liquidType(0);
            }
            DungeonUtils.ChangeTileType(tile1, brickTileType, true, settings.OverridePaintTile);
            if (num20 == 0)
              DungeonUtils.ChangeWallType(tile1, brickWallType, false, settings.OverridePaintWall);
          }
        }
      }
    }
    this.BiomeRoom_AddHallwaySpace(position, num4, edgeRight, num5, edgeBottom, shapeOffset, brickWallType, this.settings.OverridePaintWall, generating);
    this.BiomeRoom_FinishRoom(genRand, num6, outerRoomRight, num7, outerRoomBottom);
    this.RoomInnerSize = num1;
    this.RoomOuterSize = num3;
    this.WallDepth = num2;
    this.Position = position;
    this.InnerBounds.CalculateHitbox();
    this.OuterBounds.CalculateHitbox();
  }

  public float BiomeRoom_GetXPercent(UnifiedRandom genRand, int variant, float percentile)
  {
    switch (variant)
    {
      case 1:
        return Utils.MultiLerp(Utils.WrappedLerp(0.0f, 1f, percentile), 0.0f, 0.9f, 0.25f, 0.0f);
      case 2:
        return 0.0f;
      case 3:
        return 0.0f;
      default:
        return Utils.MultiLerp(Utils.WrappedLerp(0.0f, 1f, percentile), 0.1f, 0.5f, 0.1f);
    }
  }

  public float BiomeRoom_GetYPercent(UnifiedRandom genRand, int variant, float percentile)
  {
    switch (variant)
    {
      case 1:
        return 0.0f;
      case 2:
        return Utils.MultiLerp(Utils.WrappedLerp(0.0f, 1f, percentile), 1f, 1f, 0.5f, 0.0f, 0.5f, 0.25f, 0.1f);
      case 3:
        return Utils.MultiLerp(Utils.WrappedLerp(0.0f, 1f, percentile), 0.0f, 0.25f, 0.6f, 0.25f, 0.0f, 0.0f, 0.3f, 0.4f, 0.3f, 0.0f, 0.0f);
      default:
        return Utils.MultiLerp(Utils.WrappedLerp(0.0f, 1f, percentile), 1f, 0.0f, 0.5f, 0.5f, 0.0f, 0.0f, 0.5f);
    }
  }
}
