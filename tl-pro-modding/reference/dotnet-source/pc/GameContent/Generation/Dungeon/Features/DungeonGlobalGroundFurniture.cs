// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Features.DungeonGlobalGroundFurniture
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;
using Terraria.DataStructures;
using Terraria.GameContent.Generation.Dungeon.Halls;
using Terraria.GameContent.Generation.Dungeon.Rooms;
using Terraria.ID;
using Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Features;

public class DungeonGlobalGroundFurniture : GlobalDungeonFeature
{
  public DungeonGlobalGroundFurniture(DungeonFeatureSettings settings)
    : base(settings)
  {
    DungeonCrawler.CurrentDungeonData.dungeonFeatures.Add((IDungeonFeature) this);
  }

  public override bool GenerateFeature(DungeonData data)
  {
    this.generated = false;
    if (data.Type == DungeonType.DualDungeon)
      this.GroundFurniture_DualDungeons(data);
    else
      this.GroundFurniture(data);
    this.generated = true;
    return true;
  }

  public void GroundFurniture_DualDungeons(DungeonData data)
  {
    UnifiedRandom genRand = WorldGen.genRand;
    float num1 = (float) Main.maxTilesX / 4200f;
    int alchTableCount = (int) ((double) (1f + (float) (int) num1) * data.globalFeatureScalar);
    int bewitchTableCount = (int) ((double) (1f + (float) (int) num1) * data.globalFeatureScalar);
    bool flag1 = false;
    for (int index = 0; index < data.genVars.dungeonGenerationStyles.Count; ++index)
    {
      if (data.genVars.dungeonGenerationStyles[index].Style == (byte) 0)
      {
        flag1 = true;
        break;
      }
    }
    if (!flag1)
    {
      alchTableCount = 0;
      bewitchTableCount = 0;
    }
    int minimumWaterCandles = -1;
    if (data.Type == DungeonType.DualDungeon)
    {
      switch (WorldGen.GetWorldSize())
      {
        case 1:
          minimumWaterCandles = 10;
          break;
        case 2:
          minimumWaterCandles = 15;
          break;
        default:
          minimumWaterCandles = 5;
          break;
      }
    }
    int defaultCount1 = 4;
    int defaultCount2 = 6;
    int num2 = 0;
    for (int index = 0; index < data.dungeonRooms.Count; ++index)
    {
      DungeonRoom dungeonRoom = data.dungeonRooms[index];
      if (dungeonRoom.generated)
      {
        DungeonGenerationStyleData styleData = dungeonRoom.settings.StyleData;
        DungeonBounds innerBounds = dungeonRoom.InnerBounds;
        int furnitureCount = dungeonRoom.GetFurnitureCount(defaultCount1);
        bool flag2 = styleData.Style == (byte) 0 && (alchTableCount > 0 || bewitchTableCount > 0);
        int num3 = 50;
        while (furnitureCount > 0)
        {
          --num3;
          if (num3 > 0)
          {
            Point currentPoint = innerBounds.RandomPointInBounds(genRand);
            Tile tile1 = Main.tile[currentPoint.X, currentPoint.Y];
            if (DungeonUtils.IsConsideredDungeonWall((int) tile1.wall) && !tile1.active())
            {
              Point point = DungeonUtils.FirstSolid(false, currentPoint, (DungeonBounds) null);
              --point.Y;
              Tile tile2 = Main.tile[point.X, point.Y];
              int num4 = alchTableCount;
              int num5 = bewitchTableCount;
              int num6 = 0;
              bool furniture;
              if (flag2)
              {
                furniture = this.GroundFurniture_ActuallyGenerateFurniture(data, genRand, point.X, point.Y, tile2.wall, ref alchTableCount, ref bewitchTableCount, ref minimumWaterCandles);
                if (!furniture)
                  furniture = this.GroundFurniture_ActuallyGenerateFurniture(data, genRand, point.X, point.Y, tile2.wall, ref num6, ref num6, ref minimumWaterCandles, false, num3 > 25);
              }
              else
              {
                furniture = this.GroundFurniture_ActuallyGenerateFurniture(data, genRand, point.X, point.Y, tile2.wall, ref num6, ref num6, ref minimumWaterCandles, false, num3 > 25);
                if (!furniture)
                  furniture = this.GroundFurniture_ActuallyGenerateFurniture(data, genRand, point.X, point.Y, tile2.wall, ref num6, ref num6, ref minimumWaterCandles, false, num3 > 25);
              }
              if (flag2 && num4 != alchTableCount || num5 != bewitchTableCount)
                flag2 = false;
              if (furniture)
              {
                --furnitureCount;
                ++num2;
              }
            }
          }
          else
            break;
        }
      }
    }
    for (int index = 0; index < data.dungeonHalls.Count; ++index)
    {
      DungeonHall dungeonHall = data.dungeonHalls[index];
      if (dungeonHall.generated)
      {
        DungeonGenerationStyleData styleData = dungeonHall.settings.StyleData;
        DungeonBounds bounds = dungeonHall.Bounds;
        int furnitureCount = dungeonHall.GetFurnitureCount(defaultCount2);
        bool flag3 = styleData.Style == (byte) 0 && (alchTableCount > 0 || bewitchTableCount > 0);
        int num7 = 50;
        while (furnitureCount > 0)
        {
          --num7;
          if (num7 > 0)
          {
            Point currentPoint = bounds.RandomPointInBounds(genRand);
            Tile tile3 = Main.tile[currentPoint.X, currentPoint.Y];
            if (DungeonUtils.IsConsideredDungeonWall((int) tile3.wall) && !tile3.active())
            {
              Point point = DungeonUtils.FirstSolid(false, currentPoint, bounds);
              --point.Y;
              Tile tile4 = Main.tile[point.X, point.Y];
              int num8 = alchTableCount;
              int num9 = bewitchTableCount;
              int num10 = 0;
              bool furniture;
              if (flag3)
              {
                furniture = this.GroundFurniture_ActuallyGenerateFurniture(data, genRand, point.X, point.Y, tile4.wall, ref alchTableCount, ref bewitchTableCount, ref minimumWaterCandles);
                if (!furniture)
                  furniture = this.GroundFurniture_ActuallyGenerateFurniture(data, genRand, point.X, point.Y, tile4.wall, ref num10, ref num10, ref minimumWaterCandles, noRegularFurnitureAreaChecks: true);
              }
              else
              {
                furniture = this.GroundFurniture_ActuallyGenerateFurniture(data, genRand, point.X, point.Y, tile4.wall, ref num10, ref num10, ref minimumWaterCandles);
                if (!furniture)
                  furniture = this.GroundFurniture_ActuallyGenerateFurniture(data, genRand, point.X, point.Y, tile4.wall, ref num10, ref num10, ref minimumWaterCandles, noRegularFurnitureAreaChecks: true);
              }
              if (flag3 && num8 != alchTableCount || num9 != bewitchTableCount)
                flag3 = false;
              if (furniture)
              {
                --furnitureCount;
                ++num2;
              }
            }
          }
          else
            break;
        }
      }
    }
  }

  public void GroundFurniture(DungeonData data)
  {
    UnifiedRandom genRand = WorldGen.genRand;
    ushort wallVariant = (ushort) data.wallVariants[0];
    float num1 = (float) Main.maxTilesX / 4200f;
    int num2 = (int) (2000.0 * (double) num1 * data.globalFeatureScalar);
    int alchTableCount = (int) ((double) (1f + (float) (int) num1) * data.globalFeatureScalar);
    int bewitchTableCount = (int) ((double) (1f + (float) (int) num1) * data.globalFeatureScalar);
    bool flag = false;
    for (int index = 0; index < data.genVars.dungeonGenerationStyles.Count; ++index)
    {
      if (data.genVars.dungeonGenerationStyles[index].Style == (byte) 0)
      {
        flag = true;
        break;
      }
    }
    if (!flag)
    {
      alchTableCount = 0;
      bewitchTableCount = 0;
    }
    int minimumWaterCandles = -1;
    if (data.Type == DungeonType.DualDungeon)
    {
      switch (WorldGen.GetWorldSize())
      {
        case 1:
          minimumWaterCandles = 10;
          break;
        case 2:
          minimumWaterCandles = 15;
          break;
        default:
          minimumWaterCandles = 5;
          break;
      }
    }
    int num3 = 2000;
    for (int index = 0; index < num2; ++index)
    {
      if (alchTableCount > 0 || bewitchTableCount > 0)
      {
        --index;
        --num3;
        if (num3 <= 0)
          break;
      }
      int i = genRand.Next(data.dungeonBounds.Left, data.dungeonBounds.Right);
      int j1 = genRand.Next(Math.Max(data.dungeonBounds.Top, (int) Main.worldSurface + 10), data.dungeonBounds.Bottom);
      int num4 = 1000;
      for (; !DungeonUtils.IsConsideredDungeonWall((int) Main.tile[i, j1].wall) || Main.tile[i, j1].active(); j1 = genRand.Next(Math.Max(data.dungeonBounds.Top, (int) Main.worldSurface + 10), data.dungeonBounds.Bottom))
      {
        --num4;
        if (num4 > 0)
          i = genRand.Next(data.dungeonBounds.Left, data.dungeonBounds.Right);
        else
          break;
      }
      if (DungeonUtils.IsConsideredDungeonWall((int) Main.tile[i, j1].wall) && !Main.tile[i, j1].active())
      {
        while (!WorldGen.SolidTile(i, j1) && j1 < Main.UnderworldLayer)
          ++j1;
        int j2 = j1 - 1;
        this.GroundFurniture_ActuallyGenerateFurniture(data, genRand, i, j2, wallVariant, ref alchTableCount, ref bewitchTableCount, ref minimumWaterCandles, index < num2 / 2);
      }
    }
  }

  private bool GroundFurniture_ActuallyGenerateFurniture(
    DungeonData data,
    UnifiedRandom genRand,
    int i,
    int j,
    ushort wallType,
    ref int alchTableCount,
    ref int bewitchTableCount,
    ref int minimumWaterCandles,
    bool stricterSpecialCheck = true,
    bool noRegularFurnitureAreaChecks = false)
  {
    int i1 = i;
    int i2 = i;
    while (!Main.tile[i1, j].active() && WorldGen.SolidTile(i1, j + 1))
      --i1;
    int num1 = i1 + 1;
    while (!Main.tile[i2, j].active() && WorldGen.SolidTile(i2, j + 1))
      ++i2;
    int num2 = i2 - 1;
    int num3 = num2 - num1;
    int index = (num2 + num1) / 2;
    if (!data.CanGenerateFeatureAt((IDungeonFeature) this, index, j) || Main.tile[index, j].active() || !DungeonUtils.IsConsideredDungeonWall((int) Main.tile[index, j].wall) || !WorldGen.SolidTile(index, j + 1) || Main.tile[index, j + 1].type == (ushort) 48 /*0x30*/)
      return false;
    int defaultItem1 = 1396;
    int defaultItem2 = 1397;
    int defaultItem3 = 1398;
    int defaultItem4 = 1405;
    int defaultItem5 = 1408;
    int defaultItem6 = 1414;
    int defaultItem7 = 1470;
    int defaultItem8 = 2376;
    int defaultItem9 = 2386;
    int defaultItem10 = 2402;
    int defaultItem11 = 2658;
    int defaultItem12 = 2664;
    int defaultItem13 = 2645;
    int defaultItem14 = 3900;
    switch (wallType)
    {
      case 8:
        defaultItem1 = 1399;
        defaultItem2 = 1400;
        defaultItem3 = 1401;
        defaultItem4 = 1406;
        defaultItem5 = 1409;
        defaultItem6 = 1415;
        defaultItem7 = 1471;
        defaultItem8 = 2377;
        defaultItem9 = 2387;
        defaultItem10 = 2403;
        defaultItem11 = 2659;
        defaultItem12 = 2665;
        defaultItem13 = 2646;
        defaultItem14 = 3901;
        break;
      case 9:
        defaultItem1 = 1402;
        defaultItem2 = 1403;
        defaultItem3 = 1404;
        defaultItem4 = 1407;
        defaultItem5 = 1410;
        defaultItem6 = 1416;
        defaultItem7 = 1472;
        defaultItem8 = 2378;
        defaultItem9 = 2388;
        defaultItem10 = 2404;
        defaultItem11 = 2660;
        defaultItem12 = 2666;
        defaultItem13 = 2647;
        defaultItem14 = 3902;
        break;
    }
    if (Main.tile[index, j].wall >= (ushort) 94 && Main.tile[index, j].wall <= (ushort) 105)
    {
      defaultItem1 = 1509;
      defaultItem2 = 1510;
      defaultItem3 = 1511;
      defaultItem4 = 5743;
      defaultItem5 = -1;
      defaultItem6 = 1512;
      defaultItem7 = 5740;
      defaultItem8 = 5750;
      defaultItem9 = 5741;
      defaultItem10 = 5753;
      defaultItem11 = 5739;
      defaultItem12 = 5742;
      defaultItem13 = 5748;
      defaultItem14 = 5746;
    }
    bool flag1 = true;
    bool flag2 = true;
    DungeonGenerationStyleData styleForWall = DungeonGenerationStyles.GetStyleForWall(data.genVars.dungeonGenerationStyles, (int) Main.tile[index, j].wall);
    if (styleForWall != null)
    {
      flag1 = styleForWall.Style == (byte) 0;
      flag2 = flag1;
      defaultItem2 = this.GroundFurniture_GetFurnitureItem(styleForWall, genRand, defaultItem2, styleForWall.TableItemTypes);
      defaultItem3 = this.GroundFurniture_GetFurnitureItem(styleForWall, genRand, defaultItem3, styleForWall.WorkbenchItemTypes);
      defaultItem4 = this.GroundFurniture_GetFurnitureItem(styleForWall, genRand, defaultItem4, styleForWall.CandleItemTypes);
      defaultItem5 = this.GroundFurniture_GetFurnitureItem(styleForWall, genRand, defaultItem5, styleForWall.VaseOrStatueItemTypes);
      defaultItem6 = this.GroundFurniture_GetFurnitureItem(styleForWall, genRand, defaultItem6, styleForWall.BookcaseItemTypes);
      defaultItem1 = this.GroundFurniture_GetFurnitureItem(styleForWall, genRand, defaultItem1, styleForWall.ChairItemTypes);
      defaultItem7 = this.GroundFurniture_GetFurnitureItem(styleForWall, genRand, defaultItem7, styleForWall.BedItemTypes);
      defaultItem8 = this.GroundFurniture_GetFurnitureItem(styleForWall, genRand, defaultItem8, styleForWall.PianoItemTypes);
      defaultItem9 = this.GroundFurniture_GetFurnitureItem(styleForWall, genRand, defaultItem9, styleForWall.DresserItemTypes);
      defaultItem10 = this.GroundFurniture_GetFurnitureItem(styleForWall, genRand, defaultItem10, styleForWall.SofaItemTypes);
      defaultItem11 = this.GroundFurniture_GetFurnitureItem(styleForWall, genRand, defaultItem11, styleForWall.BathtubItemTypes);
      defaultItem13 = this.GroundFurniture_GetFurnitureItem(styleForWall, genRand, defaultItem13, styleForWall.LampItemTypes);
      defaultItem12 = this.GroundFurniture_GetFurnitureItem(styleForWall, genRand, defaultItem12, styleForWall.CandelabraItemTypes);
      defaultItem14 = this.GroundFurniture_GetFurnitureItem(styleForWall, genRand, defaultItem14, styleForWall.ClockItemTypes);
    }
    int num4 = genRand.Next(13);
    if ((num4 == 10 || num4 == 11 || num4 == 12) && genRand.Next(4) != 0)
      num4 = genRand.Next(13);
    while (num4 == 2 && defaultItem5 == -1 || num4 == 5 && defaultItem7 == -1 || num4 == 6 && defaultItem8 == -1 || num4 == 7 && defaultItem9 == -1 || num4 == 8 && defaultItem10 == -1 || num4 == 9 && defaultItem11 == -1 || num4 == 10 && defaultItem12 == -1 || num4 == 11 && defaultItem13 == -1 || num4 == 12 && defaultItem14 == -1)
      num4 = genRand.Next(13);
    int num5 = 0;
    int num6 = 0;
    if (num4 == 0)
    {
      num5 = 5;
      num6 = 4;
    }
    if (num4 == 1)
    {
      num5 = 4;
      num6 = 3;
    }
    if (num4 == 2)
    {
      num5 = 3;
      num6 = 5;
    }
    if (num4 == 3)
    {
      num5 = 4;
      num6 = 6;
    }
    if (num4 == 4)
    {
      num5 = 3;
      num6 = 3;
    }
    if (num4 == 5)
    {
      num5 = 5;
      num6 = 3;
    }
    if (num4 == 6)
    {
      num5 = 5;
      num6 = 4;
    }
    if (num4 == 7)
    {
      num5 = 5;
      num6 = 4;
    }
    if (num4 == 8)
    {
      num5 = 5;
      num6 = 4;
    }
    if (num4 == 9)
    {
      num5 = 5;
      num6 = 3;
    }
    if (num4 == 10)
    {
      num5 = 2;
      num6 = 4;
    }
    if (num4 == 11)
    {
      num5 = 3;
      num6 = 3;
    }
    if (num4 == 12)
    {
      num5 = 2;
      num6 = 5;
    }
    if (noRegularFurnitureAreaChecks)
    {
      if (num4 == 0)
      {
        num5 = 3;
        num6 = 4;
      }
      if (num4 == 1)
      {
        num5 = 2;
        num6 = 3;
      }
      if (num4 == 2)
      {
        num5 = 3;
        num6 = 5;
      }
      if (num4 == 3)
      {
        num5 = 3;
        num6 = 6;
      }
      if (num4 == 4)
      {
        num5 = 1;
        num6 = 3;
      }
      if (num4 == 5)
      {
        num5 = 4;
        num6 = 3;
      }
      if (num4 == 6)
      {
        num5 = 4;
        num6 = 4;
      }
      if (num4 == 7)
      {
        num5 = 4;
        num6 = 4;
      }
      if (num4 == 8)
      {
        num5 = 4;
        num6 = 4;
      }
      if (num4 == 9)
      {
        num5 = 4;
        num6 = 3;
      }
      if (num4 == 10)
      {
        num5 = 1;
        num6 = 4;
      }
      if (num4 == 11)
      {
        num5 = 2;
        num6 = 3;
      }
      if (num4 == 12)
      {
        num5 = 2;
        num6 = 5;
      }
    }
    bool flag3 = false;
    bool flag4 = false;
    int num7 = 0;
    if (alchTableCount > 0 || bewitchTableCount > 0)
      num7 = 15;
    for (int x = index - num5 - num7; x <= index + num5 + num7; ++x)
    {
      for (int y = j - num6 - num7; y <= j + num7; ++y)
      {
        if (WorldGen.InWorld(x, y))
        {
          Tile tile = Main.tile[x, y];
          if (x >= index - num5 && x <= index + num5 && y >= j - num6 && y <= j)
          {
            if (!data.CanGenerateFeatureAt((IDungeonFeature) this, x, y))
            {
              flag3 = true;
              break;
            }
            if (!noRegularFurnitureAreaChecks && tile.active())
            {
              num4 = -1;
              break;
            }
          }
          if (stricterSpecialCheck && (alchTableCount > 0 || bewitchTableCount > 0) && tile.active() && (tile.type == (ushort) 355 || tile.type == (ushort) 354))
            flag4 = true;
        }
      }
    }
    if (flag3)
      return false;
    float num8 = (float) num5 * 1.75f;
    if (noRegularFurnitureAreaChecks)
      num8 = (float) num5;
    if ((double) num3 < (double) num8)
      num4 = -1;
    if (!flag4 & flag2 && (alchTableCount > 0 || bewitchTableCount > 0))
    {
      if (alchTableCount > 0)
      {
        WorldGen.PlaceTile(index, j, 355, true);
        if (Main.tile[index, j].active() && Main.tile[index, j].type == (ushort) 355)
        {
          --alchTableCount;
          return true;
        }
      }
      else if (bewitchTableCount > 0)
      {
        WorldGen.PlaceTile(index, j, 354, true);
        if (Main.tile[index, j].active() && Main.tile[index, j].type == (ushort) 354)
        {
          --bewitchTableCount;
          return true;
        }
      }
    }
    else if (defaultItem2 > -1 && num4 == 0)
    {
      PlacementDetails derivedPlacementDetail1 = ItemID.Sets.DerivedPlacementDetails[defaultItem2];
      WorldGen.PlaceTile(index, j, derivedPlacementDetail1.tileType, true, style: (int) derivedPlacementDetail1.tileStyle);
      if (Main.tile[index, j].active() && (int) Main.tile[index, j].type == derivedPlacementDetail1.tileType)
      {
        if (defaultItem1 > -1)
        {
          PlacementDetails derivedPlacementDetail2 = ItemID.Sets.DerivedPlacementDetails[defaultItem1];
          if (!Main.tile[index - 2, j].active())
          {
            WorldGen.PlaceTile(index - 2, j, derivedPlacementDetail2.tileType, true, style: (int) derivedPlacementDetail2.tileStyle);
            if (Main.tile[index - 2, j].active())
            {
              Main.tile[index - 2, j].frameX += (short) 18;
              Main.tile[index - 2, j - 1].frameX += (short) 18;
            }
          }
          if (!Main.tile[index + 2, j].active())
            WorldGen.PlaceTile(index + 2, j, derivedPlacementDetail2.tileType, true, style: (int) derivedPlacementDetail2.tileStyle);
        }
        for (int i3 = index - 1; i3 <= index + 1; ++i3)
        {
          if (genRand.Next(2) == 0 && !Main.tile[i3, j - 2].active())
          {
            if (flag1)
            {
              int num9 = genRand.Next(5);
              if (minimumWaterCandles > 0)
                num9 = 2;
              if (defaultItem4 > -1 && num9 <= 1 && !Main.tileLighted[(int) Main.tile[i3 - 1, j - 2].type])
              {
                PlacementDetails derivedPlacementDetail3 = ItemID.Sets.DerivedPlacementDetails[defaultItem4];
                WorldGen.PlaceTile(i3, j - 2, derivedPlacementDetail3.tileType, true, style: (int) derivedPlacementDetail3.tileStyle);
              }
              if (num9 == 2 && !Main.tileLighted[(int) Main.tile[i3 - 1, j - 2].type])
              {
                WorldGen.PlaceTile(i3, j - 2, 49, true);
                if (Main.tile[i3, j - 2].active() && Main.tile[i3, j - 2].type == (ushort) 49)
                  --minimumWaterCandles;
              }
              else
              {
                switch (num9)
                {
                  case 3:
                    WorldGen.PlaceTile(i3, j - 2, 50, true);
                    continue;
                  case 4:
                    WorldGen.PlaceTile(i3, j - 2, 103, true);
                    continue;
                  default:
                    continue;
                }
              }
            }
            else
            {
              int num10 = genRand.Next(3);
              if (defaultItem4 > -1 && num10 <= 1 && !Main.tileLighted[(int) Main.tile[i3 - 1, j - 2].type])
              {
                PlacementDetails derivedPlacementDetail4 = ItemID.Sets.DerivedPlacementDetails[defaultItem4];
                WorldGen.PlaceTile(i3, j - 2, derivedPlacementDetail4.tileType, true, style: (int) derivedPlacementDetail4.tileStyle);
              }
              else if (num10 == 2)
                WorldGen.PlaceTile(i3, j - 2, 103, true);
            }
          }
        }
        return true;
      }
    }
    else if (defaultItem3 > -1 && num4 == 1)
    {
      PlacementDetails derivedPlacementDetail5 = ItemID.Sets.DerivedPlacementDetails[defaultItem3];
      PlacementDetails derivedPlacementDetail6 = ItemID.Sets.DerivedPlacementDetails[defaultItem1];
      WorldGen.PlaceTile(index, j, derivedPlacementDetail5.tileType, true, style: (int) derivedPlacementDetail5.tileStyle);
      if (Main.tile[index, j].active() && (int) Main.tile[index, j].type == derivedPlacementDetail5.tileType)
      {
        if (defaultItem1 > -1)
        {
          if (genRand.Next(2) == 0)
          {
            if (!Main.tile[index - 1, j].active())
            {
              WorldGen.PlaceTile(index - 1, j, derivedPlacementDetail6.tileType, true, style: (int) derivedPlacementDetail6.tileStyle);
              if (Main.tile[index - 1, j].active())
              {
                Main.tile[index - 1, j].frameX += (short) 18;
                Main.tile[index - 1, j - 1].frameX += (short) 18;
              }
            }
          }
          else if (!Main.tile[index + 2, j].active())
            WorldGen.PlaceTile(index + 2, j, derivedPlacementDetail6.tileType, true, style: (int) derivedPlacementDetail6.tileStyle);
        }
        for (int i4 = index; i4 <= index + 1; ++i4)
        {
          if (genRand.Next(2) == 0 && !Main.tile[i4, j - 1].active())
          {
            if (flag1)
            {
              int num11 = genRand.Next(5);
              if (minimumWaterCandles > 0)
                num11 = 2;
              if (defaultItem4 != -1 && num11 <= 1 && !Main.tileLighted[(int) Main.tile[i4 - 1, j - 1].type])
              {
                PlacementDetails derivedPlacementDetail7 = ItemID.Sets.DerivedPlacementDetails[defaultItem4];
                WorldGen.PlaceTile(i4, j - 1, derivedPlacementDetail7.tileType, true, style: (int) derivedPlacementDetail7.tileStyle);
              }
              else if (num11 == 2 && !Main.tileLighted[(int) Main.tile[i4 - 1, j - 1].type])
              {
                WorldGen.PlaceTile(i4, j - 1, 49, true);
                if (Main.tile[i4, j - 1].active() && Main.tile[i4, j - 1].type == (ushort) 49)
                  --minimumWaterCandles;
              }
              else
              {
                switch (num11)
                {
                  case 3:
                    WorldGen.PlaceTile(i4, j - 1, 50, true);
                    continue;
                  case 4:
                    WorldGen.PlaceTile(i4, j - 1, 103, true);
                    continue;
                  default:
                    continue;
                }
              }
            }
            else
            {
              int num12 = genRand.Next(3);
              if (defaultItem4 != -1 && num12 <= 1 && !Main.tileLighted[(int) Main.tile[i4 - 1, j - 1].type])
              {
                PlacementDetails derivedPlacementDetail8 = ItemID.Sets.DerivedPlacementDetails[defaultItem4];
                WorldGen.PlaceTile(i4, j - 1, derivedPlacementDetail8.tileType, true, style: (int) derivedPlacementDetail8.tileStyle);
              }
              else if (num12 == 2)
                WorldGen.PlaceTile(i4, j - 1, 103, true);
            }
          }
        }
        return true;
      }
    }
    else if (defaultItem5 > -1 && num4 == 2)
    {
      PlacementDetails derivedPlacementDetail = ItemID.Sets.DerivedPlacementDetails[defaultItem5];
      WorldGen.PlaceTile(index, j, derivedPlacementDetail.tileType, true, style: (int) derivedPlacementDetail.tileStyle);
      if (Main.tile[index, j].active() && (int) Main.tile[index, j].type == derivedPlacementDetail.tileType)
        return true;
    }
    else if (defaultItem6 > -1 && num4 == 3)
    {
      PlacementDetails derivedPlacementDetail = ItemID.Sets.DerivedPlacementDetails[defaultItem6];
      WorldGen.PlaceTile(index, j, derivedPlacementDetail.tileType, true, style: (int) derivedPlacementDetail.tileStyle);
    }
    else if (defaultItem1 > -1 && num4 == 4)
    {
      PlacementDetails derivedPlacementDetail = ItemID.Sets.DerivedPlacementDetails[defaultItem1];
      if (genRand.Next(2) == 0)
      {
        WorldGen.PlaceTile(index, j, derivedPlacementDetail.tileType, true, style: (int) derivedPlacementDetail.tileStyle);
        Main.tile[index, j].frameX += (short) 18;
        Main.tile[index, j - 1].frameX += (short) 18;
      }
      else
        WorldGen.PlaceTile(index, j, derivedPlacementDetail.tileType, true, style: (int) derivedPlacementDetail.tileStyle);
      if (Main.tile[index, j].active() && (int) Main.tile[index, j].type == derivedPlacementDetail.tileType)
        return true;
    }
    else if (defaultItem7 > -1 && num4 == 5)
    {
      PlacementDetails derivedPlacementDetail = ItemID.Sets.DerivedPlacementDetails[defaultItem7];
      if (derivedPlacementDetail.tileType >= 0)
      {
        if (genRand.Next(2) == 0)
          WorldGen.Place4x2(index, j, (ushort) derivedPlacementDetail.tileType, 1, (int) derivedPlacementDetail.tileStyle);
        else
          WorldGen.Place4x2(index, j, (ushort) derivedPlacementDetail.tileType, style: (int) derivedPlacementDetail.tileStyle);
        if (Main.tile[index, j].active() && (int) Main.tile[index, j].type == derivedPlacementDetail.tileType)
          return true;
      }
    }
    else if (defaultItem8 > -1 && num4 == 6)
    {
      PlacementDetails derivedPlacementDetail = ItemID.Sets.DerivedPlacementDetails[defaultItem8];
      WorldGen.PlaceTile(index, j, derivedPlacementDetail.tileType, true, style: (int) derivedPlacementDetail.tileStyle);
      if (Main.tile[index, j].active() && (int) Main.tile[index, j].type == derivedPlacementDetail.tileType)
        return true;
    }
    else if (defaultItem9 > -1 && num4 == 7)
    {
      PlacementDetails derivedPlacementDetail = ItemID.Sets.DerivedPlacementDetails[defaultItem9];
      WorldGen.PlaceTile(index, j, derivedPlacementDetail.tileType, true, style: (int) derivedPlacementDetail.tileStyle);
      if (Main.tile[index, j].active() && (int) Main.tile[index, j].type == derivedPlacementDetail.tileType)
        return true;
    }
    else if (defaultItem10 > -1 && num4 == 8)
    {
      PlacementDetails derivedPlacementDetail = ItemID.Sets.DerivedPlacementDetails[defaultItem10];
      WorldGen.PlaceTile(index, j, derivedPlacementDetail.tileType, true, style: (int) derivedPlacementDetail.tileStyle);
      if (Main.tile[index, j].active() && (int) Main.tile[index, j].type == derivedPlacementDetail.tileType)
        return true;
    }
    else if (defaultItem11 > -1 && num4 == 9)
    {
      PlacementDetails derivedPlacementDetail = ItemID.Sets.DerivedPlacementDetails[defaultItem11];
      if (derivedPlacementDetail.tileType >= 0)
      {
        if (genRand.Next(2) == 0)
          WorldGen.Place4x2(index, j, (ushort) derivedPlacementDetail.tileType, 1, (int) derivedPlacementDetail.tileStyle);
        else
          WorldGen.Place4x2(index, j, (ushort) derivedPlacementDetail.tileType, style: (int) derivedPlacementDetail.tileStyle);
        if (Main.tile[index, j].active() && (int) Main.tile[index, j].type == derivedPlacementDetail.tileType)
          return true;
      }
    }
    else if (defaultItem13 > -1 && num4 == 10)
    {
      PlacementDetails derivedPlacementDetail = ItemID.Sets.DerivedPlacementDetails[defaultItem13];
      WorldGen.PlaceTile(index, j, derivedPlacementDetail.tileType, true, style: (int) derivedPlacementDetail.tileStyle);
      if (Main.tile[index, j].active() && (int) Main.tile[index, j].type == derivedPlacementDetail.tileType)
        return true;
    }
    else if (defaultItem12 > -1 && num4 == 11)
    {
      PlacementDetails derivedPlacementDetail = ItemID.Sets.DerivedPlacementDetails[defaultItem12];
      WorldGen.PlaceTile(index, j, derivedPlacementDetail.tileType, true, style: (int) derivedPlacementDetail.tileStyle);
      if (Main.tile[index, j].active() && (int) Main.tile[index, j].type == derivedPlacementDetail.tileType)
        return true;
    }
    else if (defaultItem14 > -1 && num4 == 12)
    {
      PlacementDetails derivedPlacementDetail = ItemID.Sets.DerivedPlacementDetails[defaultItem14];
      WorldGen.PlaceTile(index, j, derivedPlacementDetail.tileType, true, style: (int) derivedPlacementDetail.tileStyle);
      if (Main.tile[index, j].active() && (int) Main.tile[index, j].type == derivedPlacementDetail.tileType)
        return true;
    }
    return false;
  }

  private int GroundFurniture_GetFurnitureItem(
    DungeonGenerationStyleData styleData,
    UnifiedRandom genRand,
    int defaultItem,
    int[] items)
  {
    if (items == null)
      return -1;
    return items.Length == 0 || styleData.Style == (byte) 0 ? defaultItem : items[genRand.Next(items.Length)];
  }
}
