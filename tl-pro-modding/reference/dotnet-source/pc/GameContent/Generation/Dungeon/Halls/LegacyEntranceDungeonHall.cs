// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Halls.LegacyEntranceDungeonHall
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using System;
using System.Collections.Generic;
using Terraria.GameContent.Generation.Dungeon.Rooms;
using Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Halls;

public class LegacyEntranceDungeonHall(DungeonHallSettings settings) : LegacyDungeonHall(settings)
{
  public int Direction;

  public override void CalculatePlatformsAndDoors(DungeonData data)
  {
  }

  public override void LegacyHall(DungeonData dungeonData, int i, int j, bool generating = false)
  {
    LegacyEntranceDungeonHallSettings settings1 = (LegacyEntranceDungeonHallSettings) this.settings;
    UnifiedRandom unifiedRandom = new UnifiedRandom(settings1.RandomSeed);
    ushort brickTileType = this.settings.StyleData.BrickTileType;
    ushort brickCrackedTileType = this.settings.StyleData.BrickCrackedTileType;
    ushort brickWallType = this.settings.StyleData.BrickWallType;
    Vector2D vector2D1 = Vector2D.Zero;
    Vector2D vector2D2 = Vector2D.Zero;
    int num1 = Main.maxTilesX / 2;
    int maxValue = unifiedRandom.Next(5, 9);
    vector2D1.X = (double) i;
    vector2D1.Y = (double) j;
    Vector2D vector2D3 = vector2D1;
    int num2 = unifiedRandom.Next(10, 30);
    int num3 = i > dungeonData.genVars.generatingDungeonTopX ? -1 : 1;
    if (i > Main.maxTilesX - 400)
      num3 = -1;
    else if (i < 400)
      num3 = 1;
    vector2D2.Y = -1.0;
    vector2D2.X = (double) num3;
    if (unifiedRandom.Next(3) != 0)
      vector2D2.X *= 1.0 + (double) unifiedRandom.Next(0, 200) * 0.0099999997764825821;
    else if (unifiedRandom.Next(3) == 0)
      vector2D2.X *= (double) unifiedRandom.Next(50, 76) * 0.0099999997764825821;
    else if (unifiedRandom.Next(6) == 0)
      vector2D2.Y *= 2.0;
    if (dungeonData.useSkewedDungeonEntranceHalls)
    {
      if (dungeonData.genVars.generatingDungeonPositionX < num1 && vector2D2.X < 0.0 && vector2D2.X < -0.5)
        vector2D2.X = 0.5;
      if (dungeonData.genVars.generatingDungeonPositionX > num1 && vector2D2.X > 0.0 && vector2D2.X > 0.5)
        vector2D2.X = -0.5;
    }
    else
    {
      if (dungeonData.genVars.generatingDungeonPositionX < num1 && vector2D2.X < -0.5)
        vector2D2.X = -0.5;
      if (dungeonData.genVars.generatingDungeonPositionX > num1 && vector2D2.X > 0.5)
        vector2D2.X = 0.5;
    }
    if (WorldGen.drunkWorldGen || WorldGen.SecretSeed.noSurface.Enabled)
    {
      num3 *= -1;
      vector2D2.X *= -1.0;
    }
    if (this.calculated)
    {
      vector2D1 = vector2D3 = this.StartPosition;
      vector2D2 = Vector2D.op_Subtraction(this.EndPosition, this.StartPosition).SafeNormalize(Vector2D.UnitX);
      num3 = this.Direction;
      maxValue = this.Strength;
      num2 = this.Steps;
    }
    int num4 = maxValue;
    int num5 = num2;
    double interiorToExteriorRatio = dungeonData.hallInteriorToExteriorRatio;
    if ((double) settings1.OverrideStrength > 0.0)
      maxValue = num4 = settings1.OverrideStrength;
    if (settings1.OverrideSteps > 0)
      num2 = num5 = settings1.OverrideSteps;
    if (settings1.OverrideInteriorToExteriorRatio > 0.0)
      interiorToExteriorRatio = settings1.OverrideInteriorToExteriorRatio;
    bool flag1 = false;
    if (Vector2D.op_Inequality(this.OverrideStartPosition, new Vector2D()) && Vector2D.op_Inequality(this.OverrideEndPosition, new Vector2D()))
    {
      flag1 = true;
      Vector2D overrideStartPosition = this.OverrideStartPosition;
      Vector2D v = Vector2D.op_Subtraction(this.OverrideEndPosition, overrideStartPosition);
      Vector2D vector2D4 = v.SafeNormalize(Vector2D.UnitX);
      num2 = num5 = (int) Math.Ceiling(((Vector2D) ref v).Length() / ((Vector2D) ref vector2D4).Length());
      vector2D1 = vector2D3 = overrideStartPosition;
      vector2D2 = vector2D4;
      num3 = vector2D4.X > 0.0 ? 1 : -1;
    }
    this.Bounds.SetBounds((int) vector2D1.X, (int) vector2D1.Y, (int) vector2D1.X, (int) vector2D1.Y);
    Vector2D startPos = vector2D1;
    Vector2D endPos = Vector2D.op_Addition(vector2D1, Vector2D.op_Multiply(vector2D2, (double) num2));
    DungeonRoomSearchSettings settings2 = new DungeonRoomSearchSettings()
    {
      Fluff = num2 / 2 + maxValue
    };
    List<DungeonRoom> allRoomsInSpots = DungeonUtils.GetAllRoomsInSpots(dungeonData.dungeonRooms, startPos, endPos, settings2);
    Vector2D vector2D5 = vector2D2;
    int val1 = 30;
    int num6 = 10;
    int num7 = 0;
    while (num2 > 0)
    {
      --num2;
      if (WorldGen.InWorld((int) vector2D1.X, (int) vector2D1.Y, val1 + 5))
      {
        int minX = Math.Max(val1, Math.Min(Main.maxTilesX - val1 - 1, (int) (vector2D1.X - (double) maxValue - 4.0 - (double) unifiedRandom.Next(6))));
        int maxX = Math.Max(val1, Math.Min(Main.maxTilesX - val1 - 1, (int) (vector2D1.X + (double) maxValue + 4.0 + (double) unifiedRandom.Next(6))));
        int minY = Math.Max(val1, Math.Min(Main.maxTilesY - val1 - 1, (int) (vector2D1.Y - (double) maxValue - 4.0)));
        int maxY = Math.Max(val1, Math.Min(Main.maxTilesY - val1 - 1, (int) (vector2D1.Y + (double) maxValue + 4.0 + (double) unifiedRandom.Next(6))));
        if (!this.Processed)
        {
          dungeonData.dungeonBounds.UpdateBounds(minX, minY, maxX, maxY);
          this.Bounds.UpdateBounds(minX, minY, maxX, maxY);
        }
        int num8 = 1;
        if (vector2D1.X > (double) num1)
          num8 = -1;
        int i1 = (int) (vector2D1.X + dungeonData.dungeonEntranceStrengthX * 0.6 * (double) num8 + dungeonData.dungeonEntranceStrengthX2 * (double) num8);
        int num9 = (int) (dungeonData.dungeonEntranceStrengthY2 * 0.5);
        if (!settings1.UsePrecalculatedEntrance && vector2D1.Y < Main.worldSurface - 5.0 && (Main.tile[i1, (int) (vector2D1.Y - (double) maxValue - 6.0 + (double) num9)].wall == (ushort) 0 && Main.tile[i1, (int) (vector2D1.Y - (double) maxValue - 7.0 + (double) num9)].wall == (ushort) 0 && Main.tile[i1, (int) (vector2D1.Y - (double) maxValue - 8.0 + (double) num9)].wall == (ushort) 0 || WorldGen.SecretSeed.surfaceIsDesert.Enabled))
        {
          dungeonData.createdDungeonEntranceOnSurface = true;
          if (generating)
            WorldGen.TileRunner(i1, (int) (vector2D1.Y - (double) maxValue - 6.0 + (double) num9), (double) unifiedRandom.Next(25, 35), unifiedRandom.Next(10, 20), -1, speedY: -1.0);
        }
        if (generating && !this.settings.CarveOnly)
        {
          for (int index1 = minX; index1 < maxX; ++index1)
          {
            for (int index2 = minY; index2 < maxY; ++index2)
            {
              bool flag2 = true;
              switch (DungeonUtils.GetHighestProtectionTypeFromPoint(index1, index2, allRoomsInSpots))
              {
                case ProtectionType.Tiles:
                  flag2 = false;
                  break;
                case ProtectionType.TilesAndWalls:
                  continue;
              }
              Tile tile = Main.tile[index1, index2];
              tile.liquid = (byte) 0;
              if (flag2 && this.CanPlaceTileAt(dungeonData, tile, (int) brickTileType, (int) brickCrackedTileType))
              {
                WorldGen.paintTile(index1, index2, (byte) 0, paintEffects: false);
                DungeonUtils.ChangeTileType(Main.tile[index1, index2], brickTileType, true, settings1.OverridePaintTile);
              }
            }
          }
          for (int index3 = minX + 1; index3 < maxX - 1; ++index3)
          {
            for (int index4 = minY + 1; index4 < maxY - 1; ++index4)
            {
              bool flag3 = true;
              switch (DungeonUtils.GetHighestProtectionTypeFromPoint(index3, index4, allRoomsInSpots))
              {
                case ProtectionType.Walls:
                  if (DungeonUtils.IsConsideredDungeonWall((int) Main.tile[index3, index4].wall))
                  {
                    flag3 = false;
                    break;
                  }
                  break;
                case ProtectionType.TilesAndWalls:
                  continue;
              }
              if (flag3)
              {
                WorldGen.paintWall(index3, index4, (byte) 0, paintEffects: false);
                DungeonUtils.ChangeWallType(Main.tile[index3, index4], brickWallType, false, settings1.OverridePaintWall);
              }
            }
          }
        }
        int num10 = 0;
        if (unifiedRandom.Next(maxValue) == 0)
          num10 = unifiedRandom.Next(1, 3);
        int num11 = Math.Max(val1, Math.Min(Main.maxTilesX - val1 - 1, (int) (vector2D1.X - (double) maxValue * interiorToExteriorRatio - (double) num10)));
        int num12 = Math.Max(val1, Math.Min(Main.maxTilesX - val1 - 1, (int) (vector2D1.X + (double) maxValue * interiorToExteriorRatio + (double) num10)));
        int num13 = Math.Max(val1, Math.Min(Main.maxTilesY - val1 - 1, (int) (vector2D1.Y - (double) maxValue * interiorToExteriorRatio - (double) num10)));
        int num14 = Math.Max(val1, Math.Min(Main.maxTilesY - val1 - 1, (int) (vector2D1.Y + (double) maxValue * interiorToExteriorRatio + (double) num10)));
        if (generating)
        {
          if (flag1)
          {
            --num7;
            if (num7 <= 0)
            {
              num7 = num6;
              DungeonPlatformData dungeonPlatformData = new DungeonPlatformData()
              {
                Position = new Point((int) vector2D1.X, (int) vector2D1.Y),
                PlacePotsChance = 0.25,
                InAHallway = true
              };
              dungeonData.dungeonPlatformData.Add(dungeonPlatformData);
            }
          }
          for (int i2 = num11; i2 < num12; ++i2)
          {
            for (int j2 = num13; j2 < num14; ++j2)
            {
              bool flag4 = true;
              switch (DungeonUtils.GetHighestProtectionTypeFromPoint(i2, j2, allRoomsInSpots))
              {
                case ProtectionType.Walls:
                  if (DungeonUtils.IsConsideredDungeonWall((int) Main.tile[i2, j2].wall))
                  {
                    flag4 = false;
                    break;
                  }
                  break;
                case ProtectionType.TilesAndWalls:
                  continue;
              }
              Main.tile[i2, j2].ClearTile();
              if (flag4 && !this.settings.CarveOnly)
                DungeonUtils.ChangeWallType(Main.tile[i2, j2], brickWallType, false, settings1.OverridePaintWall);
            }
          }
        }
        if (!settings1.UsePrecalculatedEntrance && dungeonData.createdDungeonEntranceOnSurface)
          num2 = 0;
        vector2D1 = Vector2D.op_Addition(vector2D1, vector2D2);
        if (!flag1 && vector2D1.Y < Main.worldSurface)
          vector2D2.Y *= 0.98000001907348633;
      }
      else
        break;
    }
    dungeonData.genVars.generatingDungeonPositionX = (int) vector2D1.X;
    dungeonData.genVars.generatingDungeonPositionY = (int) vector2D1.Y;
    this.StartPosition = vector2D3;
    this.EndPosition = vector2D1;
    this.StartDirection = new Vector2D(vector2D5.X, vector2D5.Y);
    this.EndDirection = new Vector2D(vector2D2.X, vector2D2.Y);
    this.Strength = num4;
    this.Steps = num5;
    this.Direction = num3;
    if (this.Processed)
      return;
    this.Bounds.CalculateHitbox();
  }
}
