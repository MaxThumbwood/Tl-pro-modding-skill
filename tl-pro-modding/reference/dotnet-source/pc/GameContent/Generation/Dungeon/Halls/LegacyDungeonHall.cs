// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Halls.LegacyDungeonHall
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using ReLogic.Utilities;
using System;
using System.Collections.Generic;
using Terraria.GameContent.Generation.Dungeon.Rooms;
using Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Halls;

public class LegacyDungeonHall(DungeonHallSettings settings) : DungeonHall(settings)
{
  public Vector2D LastHall;
  public int Strength;
  public int Steps;
  protected Vector2D OverrideStartPosition;
  protected Vector2D OverrideEndPosition;

  public override void CalculatePlatformsAndDoors(DungeonData data)
  {
    if (!this.Processed)
      return;
    DungeonUtils.CalculatePlatformAndDoorsOnHallway(data, this.StartPosition, this.StartDirection.Y, this.settings.ForceStyleForDoorsAndPlatforms ? this.settings.StyleData : (DungeonGenerationStyleData) null);
    DungeonUtils.CalculatePlatformAndDoorsOnHallway(data, this.EndPosition, this.EndDirection.Y, this.settings.ForceStyleForDoorsAndPlatforms ? this.settings.StyleData : (DungeonGenerationStyleData) null);
  }

  public override void CalculateHall(DungeonData data, Vector2D startPoint, Vector2D endPoint)
  {
    this.calculated = false;
    this.OverrideStartPosition = startPoint;
    this.OverrideEndPosition = endPoint;
    this.LegacyHall(data, 0, 0);
    this.calculated = true;
  }

  public override void GenerateHall(DungeonData data)
  {
    this.generated = false;
    this.LegacyHall(data, 0, 0, true);
    this.generated = true;
  }

  public bool GenerateHall(DungeonData data, int x, int y)
  {
    this.generated = false;
    this.LegacyHall(data, x, y, true);
    this.generated = true;
    return true;
  }

  public virtual void LegacyHall(DungeonData dungeonData, int i, int j, bool generating = false)
  {
    LegacyDungeonHallSettings settings1 = (LegacyDungeonHallSettings) this.settings;
    UnifiedRandom unifiedRandom = new UnifiedRandom(settings1.RandomSeed);
    ushort brickTileType = this.settings.StyleData.BrickTileType;
    ushort brickCrackedTileType = this.settings.StyleData.BrickCrackedTileType;
    ushort brickWallType = this.settings.StyleData.BrickWallType;
    Vector2D vector2D1;
    // ISSUE: explicit constructor call
    ((Vector2D) ref vector2D1).\u002Ector((double) i, (double) j);
    Vector2D vector2D2 = vector2D1;
    Vector2D vector2D3 = Vector2D.Zero;
    int num1 = (int) (4.0 * dungeonData.hallStrengthScalar) + unifiedRandom.Next(2);
    Vector2D zero1 = Vector2D.Zero;
    Vector2D zero2 = Vector2D.Zero;
    double hallStepScalar = dungeonData.hallStepScalar;
    int num2 = (int) (35.0 * hallStepScalar) + unifiedRandom.Next(45);
    bool flag1 = false;
    if (settings1.CrackedBrickChance > 0.0)
      flag1 = unifiedRandom.NextDouble() <= settings1.CrackedBrickChance;
    if (settings1.ForceHorizontal)
    {
      num2 += (int) (20.0 * hallStepScalar);
      dungeonData.lastDungeonHall = Vector2D.Zero;
    }
    else
    {
      if (unifiedRandom.Next(5) == 0)
      {
        num1 *= 2;
        num2 /= 2;
      }
      if (WorldGen.SecretSeed.errorWorld.Enabled && unifiedRandom.Next(2) == 0)
        num1 *= 2;
      if (WorldGen.SecretSeed.errorWorld.Enabled && unifiedRandom.Next(2) == 0)
        num2 *= 2;
    }
    Vector2D vector2D4 = dungeonData.lastDungeonHall;
    if (this.calculated)
    {
      vector2D1 = vector2D2 = this.StartPosition;
      vector2D3 = Vector2D.op_Subtraction(this.EndPosition, this.StartPosition).SafeNormalize(Vector2D.UnitX);
      num1 = this.Strength;
      num2 = this.Steps;
      vector2D4 = this.LastHall;
    }
    int num3 = num2;
    int num4 = num1;
    double interiorToExteriorRatio = dungeonData.hallInteriorToExteriorRatio;
    if ((double) settings1.OverrideStrength > 0.0)
      num1 = num4 = settings1.OverrideStrength;
    if (settings1.OverrideSteps > 0)
      num2 = num3 = settings1.OverrideSteps;
    if (settings1.OverrideInteriorToExteriorRatio > 0.0)
      interiorToExteriorRatio = settings1.OverrideInteriorToExteriorRatio;
    bool flag2 = false;
    int num5 = Main.UnderworldLayer - (int) (100.0 * (dungeonData.HallSizeScalar > dungeonData.RoomSizeScalar ? dungeonData.HallSizeScalar : dungeonData.RoomSizeScalar));
    bool flag3 = false;
    if (Vector2D.op_Inequality(this.OverrideStartPosition, new Vector2D()) && Vector2D.op_Inequality(this.OverrideEndPosition, new Vector2D()))
    {
      flag3 = true;
      Vector2D overrideStartPosition = this.OverrideStartPosition;
      Vector2D v = Vector2D.op_Subtraction(this.OverrideEndPosition, overrideStartPosition);
      Vector2D vector2D5 = v.SafeNormalize(Vector2D.UnitX);
      num2 = num3 = (int) Math.Ceiling(((Vector2D) ref v).Length() / ((Vector2D) ref vector2D5).Length());
      vector2D1 = overrideStartPosition;
      vector2D2 = vector2D1;
      zero1.X = vector2D5.X;
      zero1.Y = vector2D5.Y;
      zero2.X = -vector2D5.X;
      zero2.Y = -vector2D5.Y;
      vector2D3 = vector2D5;
    }
    else
    {
      bool flag4 = false;
      bool flag5 = true;
      while (!flag4)
      {
        bool flag6 = false;
        int num6;
        if (flag5 && !settings1.ForceHorizontal)
        {
          bool flag7 = true;
          bool flag8 = true;
          bool flag9 = true;
          bool flag10 = true;
          bool flag11 = false;
          int num7 = num2;
          bool flag12 = false;
          for (int y = j; y > j - num7; --y)
          {
            int x = i;
            if (!WorldGen.InWorld(x, y, 50))
            {
              flag7 = false;
              break;
            }
            if (DungeonUtils.IsConsideredDungeonWall((int) Main.tile[x, y].wall))
            {
              if (flag12)
              {
                flag7 = false;
                break;
              }
            }
            else
              flag12 = true;
          }
          bool flag13 = false;
          for (int y = j; y < j + num7; ++y)
          {
            int x = i;
            if (!WorldGen.InWorld(x, y, 50))
            {
              flag8 = false;
              break;
            }
            if (y >= num5)
            {
              flag11 = true;
              flag8 = false;
              break;
            }
            if (DungeonUtils.IsConsideredDungeonWall((int) Main.tile[x, y].wall))
            {
              if (flag13)
              {
                flag8 = false;
                break;
              }
            }
            else
              flag13 = true;
          }
          bool flag14 = false;
          for (int x = i; x > i - num7; --x)
          {
            int y = j;
            if (!WorldGen.InWorld(x, y, 50))
            {
              flag9 = false;
              break;
            }
            if (DungeonUtils.IsConsideredDungeonWall((int) Main.tile[x, y].wall))
            {
              if (flag14)
              {
                flag9 = false;
                break;
              }
            }
            else
              flag14 = true;
          }
          bool flag15 = false;
          for (int x = i; x < i + num7; ++x)
          {
            int y = j;
            if (!WorldGen.InWorld(x, y, 50))
            {
              flag10 = false;
              break;
            }
            if (DungeonUtils.IsConsideredDungeonWall((int) Main.tile[x, y].wall))
            {
              if (flag15)
              {
                flag10 = false;
                break;
              }
            }
            else
              flag15 = true;
          }
          if (!flag9 && !flag10 && !flag7 && !flag8)
          {
            num6 = unifiedRandom.Next(2) != 0 ? 1 : -1;
            if (unifiedRandom.Next(2) == 0)
              flag6 = true;
            if (((num6 != 1 ? 0 : (!flag6 ? 1 : 0)) & (flag11 ? 1 : 0)) != 0)
            {
              num6 = unifiedRandom.Next(2) == 0 ? 1 : -1;
              flag6 = true;
            }
          }
          else
          {
            int num8 = 100;
            int num9;
            do
            {
              --num8;
              if (num8 <= 0)
              {
                num9 = 0;
                break;
              }
              num9 = unifiedRandom.Next(4);
              if (num9 == 1 & flag11)
                num9 = unifiedRandom.Next(2) == 0 ? 2 : 3;
            }
            while (!(num9 == 0 & flag7) && !(num9 == 1 & flag8) && !(num9 == 2 & flag9) && !(num9 == 3 & flag10));
            switch (num9)
            {
              case 0:
                num6 = -1;
                break;
              case 1:
                num6 = 1;
                break;
              default:
                flag6 = true;
                num6 = num9 != 2 ? 1 : -1;
                break;
            }
          }
        }
        else
        {
          num6 = unifiedRandom.Next(2) != 0 ? 1 : -1;
          if (unifiedRandom.Next(2) == 0)
            flag6 = true;
          if (num6 == 1 && j + num2 >= num5)
          {
            num6 = unifiedRandom.Next(2) == 0 ? -1 : 1;
            flag6 = true;
          }
        }
        flag5 = false;
        if (settings1.ForceHorizontal)
          flag6 = true;
        if (flag6)
        {
          zero1.Y = 0.0;
          zero1.X = (double) num6;
          zero2.Y = 0.0;
          zero2.X = (double) -num6;
          vector2D3.Y = 0.0;
          vector2D3.X = (double) num6;
          if (unifiedRandom.Next(3) == 0)
            vector2D3.Y = unifiedRandom.Next(2) != 0 ? 0.20000000298023224 * dungeonData.hallSlantVariantScalar : -0.20000000298023224 * dungeonData.hallSlantVariantScalar;
        }
        else
        {
          ++num1;
          vector2D3.Y = (double) num6;
          vector2D3.X = 0.0;
          zero1.X = 0.0;
          zero1.Y = (double) num6;
          zero2.X = 0.0;
          zero2.Y = (double) -num6;
          if (settings1.ZigzagChance > 0.0 && unifiedRandom.NextDouble() <= settings1.ZigzagChance)
          {
            flag2 = true;
            vector2D3.X = unifiedRandom.Next(2) != 0 ? (double) -unifiedRandom.Next(10, 20) * 0.1 * dungeonData.hallSlantVariantScalar : (double) unifiedRandom.Next(10, 20) * 0.1 * dungeonData.hallSlantVariantScalar;
          }
          else if (unifiedRandom.Next(2) == 0)
            vector2D3.X = unifiedRandom.Next(2) != 0 ? (double) -unifiedRandom.Next(20, 40) * 0.01 * dungeonData.hallSlantVariantScalar : (double) unifiedRandom.Next(20, 40) * 0.01 * dungeonData.hallSlantVariantScalar;
          else
            num2 /= 2;
        }
        if (Vector2D.op_Inequality(dungeonData.lastDungeonHall, zero2))
          flag4 = true;
      }
    }
    int num10 = 0;
    float num11 = (float) Main.maxTilesX * 0.25f;
    float num12 = (float) Main.maxTilesX * 0.75f;
    if (WorldGen.SecretSeed.errorWorld.Enabled)
    {
      num11 = (float) Main.maxTilesX * 0.4f;
      num12 = (float) Main.maxTilesX * 0.6f;
    }
    bool flag16 = vector2D1.Y < Main.rockLayer + 100.0;
    if (WorldGen.remixWorldGen)
      flag16 = vector2D1.Y < Main.worldSurface + 100.0;
    bool flag17 = vector2D1.X < (double) (Main.maxTilesX / 2) && vector2D1.X > (double) num11;
    bool flag18 = vector2D1.X > (double) (Main.maxTilesX / 2) && vector2D1.X < (double) num12;
    if (!flag3 && !settings1.ForceHorizontal)
    {
      if (vector2D1.X > (double) (Main.maxTilesX - 200))
      {
        int num13 = -1;
        zero1.X = (double) num13;
        zero1.Y = 0.0;
        vector2D3.X = (double) num13;
        vector2D3.Y = 0.0;
        if (unifiedRandom.Next(3) == 0)
          vector2D3.Y = unifiedRandom.Next(2) != 0 ? 0.20000000298023224 * dungeonData.hallSlantVariantScalar : -0.20000000298023224 * dungeonData.hallSlantVariantScalar;
      }
      else if (vector2D1.X < 200.0)
      {
        int num14 = 1;
        zero1.X = (double) num14;
        zero1.Y = 0.0;
        vector2D3.X = (double) num14;
        vector2D3.Y = 0.0;
        if (unifiedRandom.Next(3) == 0)
          vector2D3.Y = unifiedRandom.Next(2) != 0 ? 0.20000000298023224 * dungeonData.hallSlantVariantScalar : -0.20000000298023224 * dungeonData.hallSlantVariantScalar;
      }
      else if (vector2D1.Y >= (double) num5)
      {
        int num15 = -1;
        ++num1;
        zero1.X = 0.0;
        zero1.Y = (double) num15;
        vector2D3.X = 0.0;
        vector2D3.Y = (double) num15;
        if (unifiedRandom.Next(2) == 0)
          vector2D3.X = unifiedRandom.Next(2) != 0 ? (double) -unifiedRandom.Next(20, 50) * 0.0099999997764825821 * dungeonData.hallSlantVariantScalar : (double) unifiedRandom.Next(20, 50) * 0.0099999997764825821 * dungeonData.hallSlantVariantScalar;
      }
      else if (vector2D1.Y < 200.0)
      {
        int num16 = 1;
        ++num1;
        zero1.X = 0.0;
        zero1.Y = (double) num16;
        vector2D3.X = 0.0;
        vector2D3.Y = (double) num16;
        if (unifiedRandom.Next(2) == 0)
          vector2D3.X = unifiedRandom.Next(2) != 0 ? (double) -unifiedRandom.Next(20, 50) * 0.0099999997764825821 * dungeonData.hallSlantVariantScalar : (double) unifiedRandom.Next(20, 50) * 0.0099999997764825821 * dungeonData.hallSlantVariantScalar;
      }
      else if (!flag3)
      {
        if (flag16)
        {
          int num17 = 1;
          ++num1;
          zero1.X = 0.0;
          zero1.Y = (double) num17;
          vector2D3.X = 0.0;
          vector2D3.Y = (double) num17;
          if (settings1.ZigzagChance > 0.0 && unifiedRandom.NextDouble() <= settings1.ZigzagChance)
          {
            flag2 = true;
            vector2D3.X = unifiedRandom.Next(2) != 0 ? (double) -unifiedRandom.Next(10, 20) * 0.1 * dungeonData.hallSlantVariantScalar : (double) unifiedRandom.Next(10, 20) * 0.1 * dungeonData.hallSlantVariantScalar;
          }
          else if (unifiedRandom.Next(2) == 0)
            vector2D3.X = unifiedRandom.Next(2) != 0 ? (double) unifiedRandom.Next(20, 50) * 0.01 * dungeonData.hallSlantVariantScalar : (double) unifiedRandom.Next(20, 50) * 0.01 * dungeonData.hallSlantVariantScalar;
        }
        else if (flag17)
        {
          int num18 = -1;
          zero1.Y = 0.0;
          zero1.X = (double) num18;
          vector2D3.Y = 0.0;
          vector2D3.X = (double) num18;
          if (unifiedRandom.Next(3) == 0)
            vector2D3.Y = unifiedRandom.Next(2) != 0 ? 0.20000000298023224 * dungeonData.hallSlantVariantScalar : -0.20000000298023224 * dungeonData.hallSlantVariantScalar;
        }
        else if (flag18)
        {
          int num19 = 1;
          zero1.Y = 0.0;
          zero1.X = (double) num19;
          vector2D3.Y = 0.0;
          vector2D3.X = (double) num19;
          if (unifiedRandom.Next(3) == 0)
            vector2D3.Y = unifiedRandom.Next(2) != 0 ? 0.20000000298023224 * dungeonData.hallSlantVariantScalar : -0.20000000298023224 * dungeonData.hallSlantVariantScalar;
        }
      }
    }
    Vector2D vector2D6 = zero1;
    dungeonData.lastDungeonHall = zero1;
    if (!this.calculated && !flag3 && Math.Abs(vector2D3.X) > Math.Abs(vector2D3.Y) && unifiedRandom.Next(3) != 0)
      num1 = (int) ((double) num4 * ((double) unifiedRandom.Next(110, 150) * 0.0099999997764825821));
    if (!this.Processed)
      this.Bounds.SetBounds((int) vector2D1.X, (int) vector2D1.Y, (int) vector2D1.X, (int) vector2D1.Y);
    Vector2D startPos = vector2D1;
    Vector2D endPos = Vector2D.op_Addition(vector2D1, Vector2D.op_Multiply(vector2D3, (double) num2));
    DungeonRoomSearchSettings settings2 = new DungeonRoomSearchSettings()
    {
      Fluff = num2 / 2 + num1
    };
    List<DungeonRoom> allRoomsInSpots = DungeonUtils.GetAllRoomsInSpots(dungeonData.dungeonRooms, startPos, endPos, settings2);
    while (num2 > 0)
    {
      ++num10;
      if (flag3)
      {
        if (!WorldGen.InWorld((int) (vector2D1.X + zero1.X), (int) (vector2D1.Y + zero1.Y), 10))
          num2 = 0;
      }
      else if (zero1.X > 0.0 && vector2D1.X > (double) (Main.maxTilesX - 100))
        num2 = 0;
      else if (zero1.X < 0.0 && vector2D1.X < 100.0)
        num2 = 0;
      else if (zero1.Y > 0.0 && vector2D1.Y >= (double) num5)
        num2 = 0;
      else if (zero1.Y < 0.0 && vector2D1.Y < 100.0)
        num2 = 0;
      else if (WorldGen.remixWorldGen && zero1.Y < 0.0 && vector2D1.Y < (Main.rockLayer + Main.worldSurface) / 2.0)
        num2 = 0;
      else if (!WorldGen.remixWorldGen && zero1.Y < 0.0 && vector2D1.Y < Main.rockLayer + 50.0)
        num2 = 0;
      --num2;
      int minX = Math.Max(0, Math.Min(Main.maxTilesX - 1, (int) (vector2D1.X - (double) num1 - 4.0 - (double) unifiedRandom.Next(6))));
      int maxX = Math.Max(0, Math.Min(Main.maxTilesX - 1, (int) (vector2D1.X + (double) num1 + 4.0 + (double) unifiedRandom.Next(6))));
      int minY = Math.Max(0, Math.Min(Main.maxTilesY - 1, (int) (vector2D1.Y - (double) num1 - 4.0 - (double) unifiedRandom.Next(6))));
      int maxY = Math.Max(0, Math.Min(Main.maxTilesY - 1, (int) (vector2D1.Y + (double) num1 + 4.0 + (double) unifiedRandom.Next(6))));
      if (!this.Processed)
      {
        dungeonData.dungeonBounds.UpdateBounds(minX, minY, maxX, maxY);
        this.Bounds.UpdateBounds(minX, minY, maxX, maxY);
      }
      if (generating && !this.settings.CarveOnly)
      {
        for (int i2 = minX; i2 < maxX; ++i2)
        {
          for (int j2 = minY; j2 < maxY; ++j2)
          {
            bool flag19 = true;
            switch (DungeonUtils.GetHighestProtectionTypeFromPoint(i2, j2, allRoomsInSpots))
            {
              case ProtectionType.Tiles:
                flag19 = false;
                break;
              case ProtectionType.TilesAndWalls:
                continue;
            }
            Tile tile = Main.tile[i2, j2];
            tile.liquid = (byte) 0;
            if (flag19 && j2 <= Main.UnderworldLayer + 7 && this.CanPlaceTileAt(dungeonData, tile, (int) brickTileType, (int) brickCrackedTileType))
              DungeonUtils.ChangeTileType(tile, brickTileType, true, this.settings.OverridePaintTile);
          }
        }
        for (int i2 = minX + 1; i2 < maxX - 1; ++i2)
        {
          for (int j2 = minY + 1; j2 < maxY - 1; ++j2)
          {
            if (j2 < Main.UnderworldLayer + 7)
            {
              bool flag20 = true;
              switch (DungeonUtils.GetHighestProtectionTypeFromPoint(i2, j2, allRoomsInSpots))
              {
                case ProtectionType.Walls:
                  if (DungeonUtils.IsConsideredDungeonWall((int) Main.tile[i2, j2].wall))
                  {
                    flag20 = false;
                    break;
                  }
                  break;
                case ProtectionType.TilesAndWalls:
                  continue;
              }
              if (flag20)
                DungeonUtils.ChangeWallType(Main.tile[i2, j2], brickWallType, false, this.settings.OverridePaintWall);
            }
          }
        }
      }
      if (generating)
      {
        int num20 = 0;
        if (vector2D3.Y == 0.0 && unifiedRandom.Next(num1 + 1) == 0)
          num20 = unifiedRandom.Next(1, 3);
        else if (vector2D3.X == 0.0 && unifiedRandom.Next(num1 - 1) == 0)
          num20 = unifiedRandom.Next(1, 3);
        else if (unifiedRandom.Next(num1 * 3) == 0)
          num20 = unifiedRandom.Next(1, 3);
        int num21 = Math.Max(0, Math.Min(Main.maxTilesX - 1, (int) (vector2D1.X - (double) num1 * interiorToExteriorRatio - (double) num20)));
        int num22 = Math.Max(0, Math.Min(Main.maxTilesX - 1, (int) (vector2D1.X + (double) num1 * interiorToExteriorRatio + (double) num20)));
        int num23 = Math.Max(0, Math.Min(Main.maxTilesY - 1, (int) (vector2D1.Y - (double) num1 * interiorToExteriorRatio - (double) num20)));
        int num24 = Math.Max(0, Math.Min(Main.maxTilesY - 1, (int) (vector2D1.Y + (double) num1 * interiorToExteriorRatio + (double) num20)));
        for (int i2 = num21; i2 < num22; ++i2)
        {
          for (int j2 = num23; j2 < num24; ++j2)
          {
            bool flag21 = true;
            bool flag22 = true;
            ProtectionType protectionTypeFromPoint = DungeonUtils.GetHighestProtectionTypeFromPoint(i2, j2, allRoomsInSpots);
            switch (protectionTypeFromPoint)
            {
              case ProtectionType.Tiles:
                flag21 = false;
                break;
              case ProtectionType.TilesAndWalls:
                continue;
            }
            if (protectionTypeFromPoint == ProtectionType.Walls && DungeonUtils.IsConsideredDungeonWall((int) Main.tile[i2, j2].wall))
              flag22 = false;
            if (this.CanRemoveTileAt(dungeonData, Main.tile[i2, j2], (int) brickCrackedTileType))
            {
              if (flag1)
              {
                if ((Main.tile[i2, j2].active() || !DungeonUtils.IsConsideredDungeonWall((int) Main.tile[i2, j2].wall)) && j2 < Main.UnderworldLayer)
                {
                  if (this.settings.CarveOnly)
                  {
                    Main.tile[i2, j2].ClearTile();
                  }
                  else
                  {
                    Main.tile[i2, j2].ClearTile();
                    if (flag21)
                      DungeonUtils.ChangeTileType(Main.tile[i2, j2], brickCrackedTileType, false, this.settings.OverridePaintTile);
                  }
                }
              }
              else
                Main.tile[i2, j2].ClearTile();
              if (flag22 && j2 < Main.UnderworldLayer && !this.settings.CarveOnly)
                DungeonUtils.ChangeWallType(Main.tile[i2, j2], brickWallType, false, this.settings.OverridePaintWall);
            }
          }
        }
      }
      vector2D1 = Vector2D.op_Addition(vector2D1, vector2D3);
      if (!flag3 & flag2 && num10 > unifiedRandom.Next(10, 20))
      {
        num10 = 0;
        vector2D3.X *= -1.0;
      }
    }
    dungeonData.genVars.generatingDungeonPositionX = (int) vector2D1.X;
    dungeonData.genVars.generatingDungeonPositionY = (int) vector2D1.Y;
    this.StartPosition = vector2D2;
    this.EndPosition = vector2D1;
    this.StartDirection = vector2D6;
    this.EndDirection = zero1;
    this.Strength = num4;
    this.Steps = num3;
    this.LastHall = vector2D4;
    this.CrackedBrick = flag1;
    if (this.Processed)
      return;
    this.Bounds.CalculateHitbox();
  }
}
