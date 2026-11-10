// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Entrances.LegacyDungeonEntrance
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using System;
using Terraria.DataStructures;
using Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Entrances;

public class LegacyDungeonEntrance(DungeonEntranceSettings settings) : DungeonEntrance(settings)
{
  public override void CalculateEntrance(DungeonData data, int x, int y)
  {
    this.calculated = false;
    this.LegacyEntrance(data, x, y, false);
    this.calculated = true;
  }

  public override bool GenerateEntrance(DungeonData data, int x, int y)
  {
    this.generated = false;
    this.LegacyEntrance(data, x, y, true);
    this.generated = true;
    return true;
  }

  public void LegacyEntrance(DungeonData data, int i, int j, bool generating)
  {
    UnifiedRandom unifiedRandom = new UnifiedRandom(this.settings.RandomSeed);
    ushort brickTileType = this.settings.StyleData.BrickTileType;
    ushort brickWallType = this.settings.StyleData.BrickWallType;
    bool entranceIsBuried = SpecialSeedFeatures.DungeonEntranceIsBuried;
    bool entranceIsUnderground = SpecialSeedFeatures.DungeonEntranceIsUnderground;
    if (generating)
    {
      int num = 60;
      for (int x = i - num; x < i + num; ++x)
      {
        for (int y = j - num; y < j + num; ++y)
        {
          if (WorldGen.InWorld(x, y))
          {
            Main.tile[x, y].liquid = (byte) 0;
            Main.tile[x, y].lava(false);
            Main.tile[x, y].Clear(TileDataType.Slope);
          }
        }
      }
    }
    Vector2D zero = Vector2D.Zero;
    double entranceStrengthX = data.dungeonEntranceStrengthX;
    double entranceStrengthY = data.dungeonEntranceStrengthY;
    zero.X = (double) i;
    zero.Y = (double) j - entranceStrengthY / 2.0;
    data.dungeonBounds.Top = (int) zero.Y;
    int direction = 1;
    if (i > Main.maxTilesX / 2)
      direction = -1;
    if (WorldGen.drunkWorldGen || WorldGen.getGoodWorldGen)
      direction *= -1;
    this.Bounds.SetBounds((int) zero.X, (int) zero.Y, (int) zero.X, (int) zero.Y);
    int num1 = Math.Max(0, Math.Min(Main.maxTilesX - 1, (int) (zero.X - entranceStrengthX * 0.60000002384185791 - (double) unifiedRandom.Next(2, 5))));
    int num2 = Math.Max(0, Math.Min(Main.maxTilesX - 1, (int) (zero.X + entranceStrengthX * 0.60000002384185791 + (double) unifiedRandom.Next(2, 5))));
    int num3 = Math.Max(0, Math.Min(Main.maxTilesY - 1, (int) (zero.Y - entranceStrengthY * 0.60000002384185791 - (double) unifiedRandom.Next(2, 5))));
    int maxY1 = Math.Max(0, Math.Min(Main.maxTilesY - 1, (int) (zero.Y + entranceStrengthY * 0.60000002384185791 + (double) unifiedRandom.Next(8, 16 /*0x10*/))));
    this.Bounds.UpdateBounds(num1, num3, num2, maxY1);
    if (generating)
    {
      for (int index1 = num1; index1 < num2; ++index1)
      {
        for (int index2 = num3; index2 < maxY1; ++index2)
        {
          Main.tile[index1, index2].liquid = (byte) 0;
          if ((int) Main.tile[index1, index2].wall != (int) brickWallType)
          {
            Main.tile[index1, index2].wall = (ushort) 0;
            if (index1 > num1 + 1 && index1 < num2 - 2 && index2 > num3 + 1 && index2 < maxY1 - 2)
              Main.tile[index1, index2].wall = brickWallType;
            Main.tile[index1, index2].active(true);
            Main.tile[index1, index2].type = brickTileType;
            Main.tile[index1, index2].Clear(TileDataType.Slope);
          }
        }
      }
    }
    int minX1 = Math.Max(0, Math.Min(Main.maxTilesX - 1, num1));
    int maxX1 = Math.Max(0, Math.Min(Main.maxTilesX - 1, num1 + 5 + unifiedRandom.Next(4)));
    int minY1 = Math.Max(0, Math.Min(Main.maxTilesY - 1, num3 - 3 - unifiedRandom.Next(3)));
    int maxY2 = Math.Max(0, Math.Min(Main.maxTilesY - 1, num3));
    this.Bounds.UpdateBounds(minX1, minY1, maxX1, maxY2);
    if (generating)
    {
      for (int index3 = minX1; index3 < maxX1; ++index3)
      {
        for (int index4 = minY1; index4 < maxY2; ++index4)
        {
          Main.tile[index3, index4].liquid = (byte) 0;
          if ((int) Main.tile[index3, index4].wall != (int) brickWallType)
          {
            Main.tile[index3, index4].active(true);
            Main.tile[index3, index4].type = brickTileType;
            Main.tile[index3, index4].Clear(TileDataType.Slope);
          }
        }
      }
    }
    int minX2 = Math.Max(0, Math.Min(Main.maxTilesX - 1, num2 - 5 - unifiedRandom.Next(4)));
    int maxX2 = Math.Max(0, Math.Min(Main.maxTilesX - 1, num2));
    int minY2 = Math.Max(0, Math.Min(Main.maxTilesY - 1, num3 - 3 - unifiedRandom.Next(3)));
    int maxY3 = Math.Max(0, Math.Min(Main.maxTilesY - 1, num3));
    this.Bounds.UpdateBounds(minX2, minY2, maxX2, maxY3);
    if (generating)
    {
      for (int index5 = minX2; index5 < maxX2; ++index5)
      {
        for (int index6 = minY2; index6 < maxY3; ++index6)
        {
          Main.tile[index5, index6].liquid = (byte) 0;
          if ((int) Main.tile[index5, index6].wall != (int) brickWallType)
          {
            Main.tile[index5, index6].active(true);
            Main.tile[index5, index6].type = brickTileType;
            Main.tile[index5, index6].Clear(TileDataType.Slope);
          }
        }
      }
    }
    int num4 = 2 + unifiedRandom.Next(4);
    int num5 = 1 + unifiedRandom.Next(2);
    int num6 = 0;
    int minY3 = Math.Max(0, Math.Min(Main.maxTilesY - 1, num3 - num5));
    data.dungeonBounds.UpdateBounds(num1, minY3, num2, num3);
    if (generating)
    {
      for (int x = num1; x < num2; ++x)
      {
        for (int y = minY3; y < num3; ++y)
        {
          this.Bounds.UpdateBounds(x, y);
          Main.tile[x, y].liquid = (byte) 0;
          if ((int) Main.tile[x, y].wall != (int) brickWallType)
          {
            Main.tile[x, y].active(true);
            Main.tile[x, y].type = brickTileType;
            Main.tile[x, y].Clear(TileDataType.Slope);
          }
        }
        ++num6;
        if (num6 >= num4)
        {
          x += num4;
          num6 = 0;
        }
      }
    }
    if (generating)
    {
      double num7 = Main.worldSurface;
      if (data.Type == DungeonType.DualDungeon)
        num7 = (double) DungeonUtils.GetDualDungeonBrickSupportCutoffY(data);
      for (int x = num1; x < num2; ++x)
      {
        for (int index = num3; (double) index < num7; ++index)
        {
          Main.tile[x, index].liquid = (byte) 0;
          if (!DungeonUtils.InAnyPotentialDungeonBounds(x, index - 5))
          {
            Tile tile = Main.tile[x, index];
            bool flag1 = tile.active() && !this.settings.StyleData.TileIsInStyle((int) tile.type);
            bool flag2 = !this.settings.StyleData.WallIsInStyle((int) tile.wall);
            bool flag3 = DungeonUtils.IsConsideredDungeonWall((int) tile.wall);
            if (tile.active() & flag1 || !flag3)
            {
              Main.tile[x, index].active(true);
              Main.tile[x, index].type = brickTileType;
              if (x > num1 && x < num2 - 1)
                Main.tile[x, index].wall = brickWallType;
              Main.tile[x, index].Clear(TileDataType.Slope);
            }
            else if (flag2 && x > num1 && x < num2 - 1)
              Main.tile[x, index].wall = brickWallType;
          }
        }
      }
    }
    int minX3 = Math.Max(0, Math.Min(Main.maxTilesX - 1, (int) (zero.X - entranceStrengthX * 0.5)));
    int maxX3 = Math.Max(0, Math.Min(Main.maxTilesX - 1, (int) (zero.X + entranceStrengthX * 0.5)));
    int minY4 = Math.Max(0, Math.Min(Main.maxTilesY - 1, (int) (zero.Y - entranceStrengthY * 0.5)));
    int maxY4 = Math.Max(0, Math.Min(Main.maxTilesY - 1, (int) (zero.Y + entranceStrengthY * 0.5)));
    this.Bounds.UpdateBounds(minX3, minY4, maxX3, maxY4);
    if (generating)
    {
      for (int index7 = minX3; index7 < maxX3; ++index7)
      {
        for (int index8 = minY4; index8 < maxY4; ++index8)
        {
          Main.tile[index7, index8].liquid = (byte) 0;
          Main.tile[index7, index8].active(false);
          Main.tile[index7, index8].wall = brickWallType;
        }
      }
    }
    int x1 = (int) zero.X;
    int y1 = maxY4;
    for (int index = 0; index < 20; ++index)
    {
      int x2 = (int) zero.X - index;
      if (x2 > 0)
      {
        if (!Main.tile[x2, y1].active() && Main.wallDungeon[(int) Main.tile[x2, y1].wall])
        {
          DungeonPlatformData dungeonPlatformData = new DungeonPlatformData()
          {
            Position = new Point(x2, y1),
            InAHallway = false
          };
          data.dungeonPlatformData.Add(dungeonPlatformData);
          break;
        }
        int x3 = (int) zero.X + index;
        if (x3 < Main.maxTilesX)
        {
          if (!Main.tile[x3, y1].active() && Main.wallDungeon[(int) Main.tile[x3, y1].wall])
          {
            DungeonPlatformData dungeonPlatformData = new DungeonPlatformData()
            {
              Position = new Point(x3, y1),
              InAHallway = false
            };
            data.dungeonPlatformData.Add(dungeonPlatformData);
            break;
          }
        }
        else
          break;
      }
      else
        break;
    }
    zero.X += entranceStrengthX * 0.60000002384185791 * (double) direction;
    zero.Y += entranceStrengthY * 0.5;
    double entranceStrengthX2 = data.dungeonEntranceStrengthX2;
    double entranceStrengthY2 = data.dungeonEntranceStrengthY2;
    zero.X += entranceStrengthX2 * 0.550000011920929 * (double) direction;
    zero.Y -= entranceStrengthY2 * 0.5;
    int minX4 = Math.Max(0, Math.Min(Main.maxTilesX - 1, (int) (zero.X - entranceStrengthX2 * 0.60000002384185791 - (double) unifiedRandom.Next(1, 3))));
    int maxX4 = Math.Max(0, Math.Min(Main.maxTilesX - 1, (int) (zero.X + entranceStrengthX2 * 0.60000002384185791 + (double) unifiedRandom.Next(1, 3))));
    int num8 = Math.Max(0, Math.Min(Main.maxTilesY - 1, (int) (zero.Y - entranceStrengthY2 * 0.60000002384185791 - (double) unifiedRandom.Next(1, 3))));
    int maxY5 = Math.Max(0, Math.Min(Main.maxTilesY - 1, (int) (zero.Y + entranceStrengthY2 * 0.60000002384185791 + (double) unifiedRandom.Next(6, 16 /*0x10*/))));
    this.Bounds.UpdateBounds(minX4, num8, maxX4, maxY5);
    if (generating)
    {
      for (int index9 = minX4; index9 < maxX4; ++index9)
      {
        for (int index10 = num8; index10 < maxY5; ++index10)
        {
          Tile tile = Main.tile[index9, index10];
          if (!tile.active() || (int) tile.type != (int) brickTileType)
          {
            tile.liquid = (byte) 0;
            bool flag = true;
            if (direction < 0)
            {
              if ((double) index9 < zero.X - entranceStrengthX2 * 0.5)
                flag = false;
            }
            else if ((double) index9 > zero.X + entranceStrengthX2 * 0.5 - 1.0)
              flag = false;
            if (flag)
            {
              tile.wall = (ushort) 0;
              tile.active(true);
              tile.type = brickTileType;
              tile.Clear(TileDataType.Slope);
            }
          }
        }
      }
    }
    this.Bounds.UpdateBounds(minX4, num8, maxX4, (int) Main.worldSurface);
    if (generating)
    {
      double num9 = Main.worldSurface;
      if (data.Type == DungeonType.DualDungeon)
        num9 = (double) (DungeonCrawler.CurrentDungeonData.genVars.outerPotentialDungeonBounds.Top - 5);
      for (int x4 = minX4; x4 < maxX4; ++x4)
      {
        for (int index = maxY5; (double) index < num9; ++index)
        {
          Main.tile[x4, index].liquid = (byte) 0;
          if (!DungeonUtils.InAnyPotentialDungeonBounds(x4, index - 5))
          {
            Tile tile = Main.tile[x4, index];
            bool flag4 = tile.active() && !this.settings.StyleData.TileIsInStyle((int) tile.type);
            bool flag5 = !this.settings.StyleData.WallIsInStyle((int) tile.wall);
            bool flag6 = DungeonUtils.IsConsideredDungeonWall((int) tile.wall);
            if (tile.active() & flag4 || !flag6)
            {
              Main.tile[x4, index].active(true);
              Main.tile[x4, index].type = brickTileType;
              if (x4 > minX4 && x4 < maxX4 - 1)
                Main.tile[x4, index].wall = brickWallType;
              Main.tile[x4, index].Clear(TileDataType.Slope);
            }
            else if (flag5 && x4 > minX4 && x4 < maxX4 - 1)
              Main.tile[x4, index].wall = brickWallType;
          }
        }
      }
    }
    int num10 = Math.Max(0, Math.Min(Main.maxTilesX - 1, (int) (zero.X - entranceStrengthX2 * 0.5)));
    int val2_1 = Math.Max(0, Math.Min(Main.maxTilesX - 1, (int) (zero.X + entranceStrengthX2 * 0.5)));
    int minX5 = num10;
    if (direction < 0)
      Math.Max(0, Math.Min(Main.maxTilesX - 1, minX5++));
    int maxX5 = Math.Max(0, Math.Min(Main.maxTilesX - 1, minX5 + 5 + unifiedRandom.Next(4)));
    int minY5 = Math.Max(0, Math.Min(Main.maxTilesY - 1, num8 - 3 - unifiedRandom.Next(3)));
    int maxY6 = Math.Max(0, Math.Min(Main.maxTilesY - 1, num8));
    this.Bounds.UpdateBounds(minX5, minY5, maxX5, maxY6);
    if (generating)
    {
      for (int index11 = minX5; index11 < maxX5; ++index11)
      {
        for (int index12 = minY5; index12 < maxY6; ++index12)
        {
          Main.tile[index11, index12].liquid = (byte) 0;
          if ((int) Main.tile[index11, index12].wall != (int) brickWallType)
          {
            Main.tile[index11, index12].active(true);
            Main.tile[index11, index12].type = brickTileType;
            Main.tile[index11, index12].Clear(TileDataType.Slope);
          }
        }
      }
    }
    int minX6 = Math.Max(0, Math.Min(Main.maxTilesX - 1, val2_1 - 5 - unifiedRandom.Next(4)));
    int maxX6 = Math.Max(0, Math.Min(Main.maxTilesX - 1, val2_1));
    int minY6 = Math.Max(0, Math.Min(Main.maxTilesY - 1, num8 - 3 - unifiedRandom.Next(3)));
    int maxY7 = Math.Max(0, Math.Min(Main.maxTilesY - 1, num8));
    this.Bounds.UpdateBounds(minX6, minY6, maxX6, maxY7);
    if (generating)
    {
      for (int index13 = minX6; index13 < maxX6; ++index13)
      {
        for (int index14 = minY6; index14 < maxY7; ++index14)
        {
          Main.tile[index13, index14].liquid = (byte) 0;
          if ((int) Main.tile[index13, index14].wall != (int) brickWallType)
          {
            Main.tile[index13, index14].active(true);
            Main.tile[index13, index14].type = brickTileType;
            Main.tile[index13, index14].Clear(TileDataType.Slope);
          }
        }
      }
    }
    if (direction < 0)
      ++val2_1;
    int num11 = 1 + unifiedRandom.Next(2);
    int num12 = 2 + unifiedRandom.Next(4);
    int num13 = 0;
    int num14 = Math.Max(0, Math.Min(Main.maxTilesY - 1, num8 - num11));
    if (generating)
    {
      for (int index15 = num10 + 1; index15 < val2_1 - 1; ++index15)
      {
        for (int index16 = num14; index16 < num8; ++index16)
        {
          Main.tile[index15, index16].liquid = (byte) 0;
          if ((int) Main.tile[index15, index16].wall != (int) brickWallType)
          {
            Main.tile[index15, index16].active(true);
            Main.tile[index15, index16].type = brickTileType;
            Main.tile[index15, index16].Clear(TileDataType.Slope);
          }
        }
        ++num13;
        if (num13 >= num12)
        {
          index15 += num12;
          num13 = 0;
        }
      }
    }
    if (!entranceIsUnderground && !entranceIsBuried)
    {
      int minX7 = Math.Max(0, Math.Min(Main.maxTilesX - 1, (int) (zero.X - entranceStrengthX2 * 0.6)));
      int maxX7 = Math.Max(0, Math.Min(Main.maxTilesX - 1, (int) (zero.X + entranceStrengthX2 * 0.6)));
      int minY7 = Math.Max(0, Math.Min(Main.maxTilesX - 1, (int) (zero.Y - entranceStrengthY2 * 0.6)));
      int maxY8 = Math.Max(0, Math.Min(Main.maxTilesX - 1, (int) (zero.Y + entranceStrengthY2 * 0.6)));
      this.Bounds.UpdateBounds(minX7, minY7, maxX7, maxY8);
      if (generating)
      {
        for (int index17 = minX7; index17 < maxX7; ++index17)
        {
          for (int index18 = minY7; index18 < maxY8; ++index18)
          {
            Main.tile[index17, index18].liquid = (byte) 0;
            Main.tile[index17, index18].wall = (ushort) 0;
          }
        }
      }
    }
    int minX8 = Math.Max(0, Math.Min(Main.maxTilesX - 1, (int) (zero.X - entranceStrengthX2 * 0.5)));
    int maxX8 = Math.Max(0, Math.Min(Main.maxTilesX - 1, (int) (zero.X + entranceStrengthX2 * 0.5)));
    int minY8 = Math.Max(0, Math.Min(Main.maxTilesY - 1, (int) (zero.Y - entranceStrengthY2 * 0.5)));
    int num15 = Math.Max(0, Math.Min(Main.maxTilesY - 1, (int) (zero.Y + entranceStrengthY2 * 0.5)));
    if (entranceIsUnderground | entranceIsBuried && direction == -1)
    {
      minX8 = Math.Max(0, Math.Min(Main.maxTilesX - 1, minX8 + 1));
      maxX8 = Math.Max(0, Math.Min(Main.maxTilesX - 1, maxX8 + 1));
    }
    this.Bounds.UpdateBounds(minX8, minY8, maxX8, num15);
    if (generating)
    {
      for (int index19 = minX8; index19 < maxX8; ++index19)
      {
        for (int index20 = minY8; index20 < num15; ++index20)
        {
          Main.tile[index19, index20].liquid = (byte) 0;
          Main.tile[index19, index20].active(false);
          Main.tile[index19, index20].wall = (ushort) 0;
        }
      }
    }
    this.OldManSpawn = DungeonUtils.SetOldManSpawnAndSpawnOldManIfDefaultDungeon((int) zero.X, num15, generating);
    if (generating && SpecialSeedFeatures.DungeonEntranceHasATree)
      DungeonUtils.GenerateDungeonTree(data, data.genVars.generatingDungeonPositionX, (int) Main.worldSurface, data.genVars.generatingDungeonPositionY);
    if (generating && SpecialSeedFeatures.DungeonEntranceHasStairs)
    {
      int i1 = direction == 1 ? maxX8 : minX8;
      int depth = DungeonUtils.GetDualDungeonBrickSupportCutoffY(data) - num15 + 5;
      DungeonUtils.GenerateDungeonStairs(data, i1, num15, direction, brickTileType, brickWallType, depth);
    }
    int num16 = 1 + unifiedRandom.Next(2);
    int num17 = 2 + unifiedRandom.Next(4);
    int num18 = 0;
    int val2_2 = (int) (zero.X - entranceStrengthX2 * 0.5);
    int val2_3 = (int) (zero.X + entranceStrengthX2 * 0.5);
    if (entranceIsUnderground | entranceIsBuried)
    {
      if (direction == -1)
      {
        ++val2_2;
        ++val2_3;
      }
    }
    else
    {
      val2_2 += 2;
      val2_3 -= 2;
    }
    int num19 = Math.Max(0, Math.Min(Main.maxTilesX - 1, val2_2));
    int num20 = Math.Max(0, Math.Min(Main.maxTilesX - 1, val2_3));
    if (generating)
    {
      for (int i2 = num19; i2 < num20; ++i2)
      {
        for (int j1 = minY8; j1 < num15 + 1; ++j1)
          WorldGen.PlaceWall(i2, j1, (int) brickWallType, true);
        if (!entranceIsUnderground && !entranceIsBuried)
        {
          ++num18;
          if (num18 >= num17)
          {
            i2 += num17 * 2;
            num18 = 0;
          }
        }
      }
    }
    if (WorldGen.drunkWorldGen && !WorldGen.SecretSeed.noSurface.Enabled)
    {
      int val2_4 = (int) (zero.X - entranceStrengthX2 * 0.5);
      int val2_5 = (int) (zero.X + entranceStrengthX2 * 0.5);
      if (direction == 1)
        val2_4 = val2_5 - 3;
      else
        val2_5 = val2_4 + 3;
      int minX9 = Math.Max(0, Math.Min(Main.maxTilesX - 1, val2_4));
      int maxX9 = Math.Max(0, Math.Min(Main.maxTilesX - 1, val2_5));
      this.Bounds.UpdateBounds(minX9, minY8, maxX9, num15);
      if (generating)
      {
        for (int index21 = minX9; index21 < maxX9; ++index21)
        {
          for (int index22 = minY8; index22 < num15 + 1; ++index22)
          {
            Main.tile[index21, index22].active(true);
            Main.tile[index21, index22].type = brickTileType;
            Main.tile[index21, index22].Clear(TileDataType.Slope);
          }
        }
      }
    }
    zero.X -= entranceStrengthX2 * 0.60000002384185791 * (double) direction;
    zero.Y += entranceStrengthY2 * 0.5;
    double num21 = 15.0;
    double num22 = 3.0;
    zero.Y -= num22 * 0.5;
    int minX10 = Math.Max(0, Math.Min(Main.maxTilesX - 1, (int) (zero.X - num21 * 0.5)));
    int maxX10 = Math.Max(0, Math.Min(Main.maxTilesX - 1, (int) (zero.X + num21 * 0.5)));
    int minY9 = Math.Max(0, Math.Min(Main.maxTilesY - 1, (int) (zero.Y - num22 * 0.5)));
    int maxY9 = Math.Max(0, Math.Min(Main.maxTilesY - 1, (int) (zero.Y + num22 * 0.5)));
    this.Bounds.UpdateBounds(minX10, minY9, maxX10, maxY9);
    if (direction < 0)
      --zero.X;
    Vector2D vector2D = zero;
    ++vector2D.Y;
    if (generating)
    {
      for (int index23 = minX10; index23 < maxX10; ++index23)
      {
        for (int index24 = minY9; index24 < maxY9; ++index24)
        {
          Main.tile[index23, index24].active(false);
          if (direction > 0 && (double) index23 < vector2D.X || direction < 0 && (double) index23 > vector2D.X || entranceIsUnderground | entranceIsBuried)
            Main.tile[index23, index24].wall = brickWallType;
        }
      }
    }
    if (generating)
      WorldGen.PlaceTile((int) vector2D.X, (int) vector2D.Y, 10, true, style: 13);
    this.Bounds.CalculateHitbox();
  }
}
