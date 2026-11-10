// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Features.DungeonGlobalPaintings
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Features;

public class DungeonGlobalPaintings : GlobalDungeonFeature
{
  public static int lihzahrdPaintingsPlaced = 0;
  public static int lihzahrdPaintingsMax = 1;

  public DungeonGlobalPaintings(DungeonFeatureSettings settings)
    : base(settings)
  {
    DungeonCrawler.CurrentDungeonData.dungeonFeatures.Add((IDungeonFeature) this);
  }

  public override bool GenerateFeature(DungeonData data)
  {
    this.generated = false;
    this.Paintings(data);
    this.generated = true;
    return true;
  }

  public void Paintings(DungeonData data)
  {
    UnifiedRandom genRand = WorldGen.genRand;
    float num1 = (float) Main.maxTilesX / 4200f;
    DungeonGlobalPaintings.lihzahrdPaintingsPlaced = 0;
    switch (WorldGen.GetWorldSize())
    {
      case 1:
        DungeonGlobalPaintings.lihzahrdPaintingsMax = 2;
        break;
      case 2:
        DungeonGlobalPaintings.lihzahrdPaintingsMax = 2 + genRand.Next(2);
        break;
      default:
        DungeonGlobalPaintings.lihzahrdPaintingsMax = 1;
        break;
    }
    int wallVariant = data.wallVariants[0];
    double num2 = Math.Max(1.0, data.globalFeatureScalar * 0.75);
    int num3 = (int) (100.0 * (double) num1 * num2);
    int num4 = num3 * 3;
    for (int index1 = 0; index1 < num3; ++index1)
    {
      --num4;
      if (num4 <= 0)
        break;
      int x1 = genRand.Next(data.dungeonBounds.Left, data.dungeonBounds.Right);
      int y1 = genRand.Next((int) Main.worldSurface, data.dungeonBounds.Bottom);
      int num5 = 1000;
      for (; !DungeonUtils.IsConsideredDungeonWall((int) Main.tile[x1, y1].wall) || Main.tile[x1, y1].active(); y1 = genRand.Next((int) Main.worldSurface, data.dungeonBounds.Bottom))
      {
        --num5;
        if (num5 > 0)
          x1 = genRand.Next(data.dungeonBounds.Left, data.dungeonBounds.Right);
        else
          break;
      }
      if (WorldGen.InWorld(x1, y1, 5) && Main.tile[x1, y1] != null)
      {
        DungeonGenerationStyleData styleForWall = DungeonGenerationStyles.GetStyleForWall(data.genVars.dungeonGenerationStyles, (int) Main.tile[x1, y1].wall);
        if (styleForWall != null && styleForWall.Style == (byte) 10 && DungeonGlobalPaintings.lihzahrdPaintingsPlaced >= DungeonGlobalPaintings.lihzahrdPaintingsMax)
        {
          --index1;
          continue;
        }
      }
      for (int index2 = 0; index2 < 2; ++index2)
      {
        int index3 = x1;
        int index4 = x1;
        while (index3 > 20 && !Main.tile[index3, y1].active() && DungeonUtils.IsConsideredDungeonWall((int) Main.tile[index3, y1].wall))
          --index3;
        int num6 = index3 + 1;
        while (index4 < Main.maxTilesX - 20 && !Main.tile[index4, y1].active() && DungeonUtils.IsConsideredDungeonWall((int) Main.tile[index4, y1].wall))
          ++index4;
        int num7 = index4 - 1;
        x1 = (num6 + num7) / 2;
        int index5 = y1;
        int index6 = y1;
        while (index5 > 20 && !Main.tile[x1, index5].active() && DungeonUtils.IsConsideredDungeonWall((int) Main.tile[x1, index5].wall))
          --index5;
        int num8 = index5 + 1;
        while (index6 < Main.maxTilesY - 20 && !Main.tile[x1, index6].active() && DungeonUtils.IsConsideredDungeonWall((int) Main.tile[x1, index6].wall))
          ++index6;
        int num9 = index6 - 1;
        y1 = (num8 + num9) / 2;
      }
      int index7 = x1;
      int index8 = x1;
      while (index7 > 20 && !Main.tile[index7, y1].active() && !Main.tile[index7, y1 - 1].active() && !Main.tile[index7, y1 + 1].active())
        --index7;
      int num10 = index7 + 1;
      while (index8 < Main.maxTilesX - 20 && !Main.tile[index8, y1].active() && !Main.tile[index8, y1 - 1].active() && !Main.tile[index8, y1 + 1].active())
        ++index8;
      int num11 = index8 - 1;
      int index9 = y1;
      int index10 = y1;
      while (index9 > 20 && !Main.tile[x1, index9].active() && !Main.tile[x1 - 1, index9].active() && !Main.tile[x1 + 1, index9].active())
        --index9;
      int num12 = index9 + 1;
      while (index10 < Main.maxTilesY - 20 && !Main.tile[x1, index10].active() && !Main.tile[x1 - 1, index10].active() && !Main.tile[x1 + 1, index10].active())
        ++index10;
      int num13 = index10 - 1;
      int x2 = (num10 + num11) / 2;
      int y2 = (num12 + num13) / 2;
      int num14 = num11 - num10;
      int num15 = num13 - num12;
      if (num14 > 7 && num15 > 5)
      {
        bool[] flagArray = new bool[3]{ true, false, false };
        if (num14 > num15 * 3 && num14 > 21)
          flagArray[1] = true;
        if (num15 > num14 * 3 && num15 > 21)
          flagArray[2] = true;
        int index11 = genRand.Next(3);
        if ((int) Main.tile[x2, y2].wall == wallVariant)
          index11 = 0;
        while (!flagArray[index11])
          index11 = genRand.Next(3);
        if (WorldGen.nearPicture2(x2, y2))
          index11 = -1;
        switch (index11)
        {
          case 0:
            PaintingEntry paintingEntry1 = DungeonGlobalPaintings.Paintings_GetPaintingEntry(data, (int) Main.tile[x2, y2].wall);
            DungeonBounds dungeonBounds = new DungeonBounds();
            if (data.CanGenerateFeatureInArea((IDungeonFeature) this, x2, y2, 3) && !WorldGen.nearPicture(x2, y2))
            {
              DungeonGlobalPaintings.Paintings_PlacePainting(x2, y2, paintingEntry1);
              continue;
            }
            continue;
          case 1:
            PaintingEntry paintingEntry2 = DungeonGlobalPaintings.Paintings_GetPaintingEntry(data, (int) Main.tile[x2, y2].wall);
            if (data.CanGenerateFeatureInArea((IDungeonFeature) this, x2, y2, 3))
            {
              if (!Main.tile[x2, y2].active())
                DungeonGlobalPaintings.Paintings_PlacePainting(x2, y2, paintingEntry2);
              if (!Main.tile[x2, y2].active())
              {
                int num16 = x2;
                int num17 = y2;
                int y3 = y2;
                for (int index12 = 0; index12 < 2; ++index12)
                {
                  x2 += 7;
                  int index13 = y3;
                  int index14 = y3;
                  while (index13 > 0 && !Main.tile[x2, index13].active() && !Main.tile[x2 - 1, index13].active() && !Main.tile[x2 + 1, index13].active())
                    --index13;
                  int num18 = index13 + 1;
                  while (index14 < Main.maxTilesY - 1 && !Main.tile[x2, index14].active() && !Main.tile[x2 - 1, index14].active() && !Main.tile[x2 + 1, index14].active())
                    ++index14;
                  int num19 = index14 - 1;
                  y3 = (num18 + num19) / 2;
                  if (data.CanGenerateFeatureInArea((IDungeonFeature) this, x2, y3, 3))
                  {
                    PaintingEntry paintingEntry3 = DungeonGlobalPaintings.Paintings_GetPaintingEntry(data, (int) Main.tile[x2, y3].wall);
                    if (Math.Abs(num17 - y3) < 4 && !WorldGen.nearPicture(x2, y3))
                      DungeonGlobalPaintings.Paintings_PlacePainting(x2, y3, paintingEntry3);
                    else
                      break;
                  }
                }
                int y4 = y2;
                int x3 = num16;
                for (int index15 = 0; index15 < 2; ++index15)
                {
                  x3 -= 7;
                  int index16 = y4;
                  int index17 = y4;
                  while (index16 > 0 && !Main.tile[x3, index16].active() && !Main.tile[x3 - 1, index16].active() && !Main.tile[x3 + 1, index16].active())
                    --index16;
                  int num20 = index16 + 1;
                  while (index17 < Main.maxTilesY - 1 && !Main.tile[x3, index17].active() && !Main.tile[x3 - 1, index17].active() && !Main.tile[x3 + 1, index17].active())
                    ++index17;
                  int num21 = index17 - 1;
                  y4 = (num20 + num21) / 2;
                  if (data.CanGenerateFeatureInArea((IDungeonFeature) this, x3, y4, 3))
                  {
                    PaintingEntry paintingEntry4 = DungeonGlobalPaintings.Paintings_GetPaintingEntry(data, (int) Main.tile[x3, y4].wall);
                    if (Math.Abs(num17 - y4) < 4 && !WorldGen.nearPicture(x3, y4))
                      DungeonGlobalPaintings.Paintings_PlacePainting(x3, y4, paintingEntry4);
                    else
                      break;
                  }
                }
                continue;
              }
              continue;
            }
            continue;
          case 2:
            PaintingEntry paintingEntry5 = DungeonGlobalPaintings.Paintings_GetPaintingEntry(data, (int) Main.tile[x2, y2].wall);
            if (data.CanGenerateFeatureInArea((IDungeonFeature) this, x2, y2, 3))
            {
              if (!Main.tile[x2, y2].active())
                DungeonGlobalPaintings.Paintings_PlacePainting(x2, y2, paintingEntry5);
              if (!Main.tile[x2, y2].active())
              {
                int num22 = y2;
                int num23 = x2;
                int x4 = x2;
                for (int index18 = 0; index18 < 3; ++index18)
                {
                  y2 += 7;
                  int index19 = x4;
                  int index20 = x4;
                  while (index19 > 0 && !Main.tile[index19, y2].active() && !Main.tile[index19, y2 - 1].active() && !Main.tile[index19, y2 + 1].active())
                    --index19;
                  int num24 = index19 + 1;
                  while (index20 < Main.maxTilesX - 1 && !Main.tile[index20, y2].active() && !Main.tile[index20, y2 - 1].active() && !Main.tile[index20, y2 + 1].active())
                    ++index20;
                  int num25 = index20 - 1;
                  x4 = (num24 + num25) / 2;
                  if (data.CanGenerateFeatureInArea((IDungeonFeature) this, x4, y2, 3))
                  {
                    PaintingEntry paintingEntry6 = DungeonGlobalPaintings.Paintings_GetPaintingEntry(data, (int) Main.tile[x4, y2].wall);
                    if (Math.Abs(num23 - x4) < 4 && !WorldGen.nearPicture(x4, y2))
                      DungeonGlobalPaintings.Paintings_PlacePainting(x4, y2, paintingEntry6);
                    else
                      break;
                  }
                }
                int x5 = x2;
                int y5 = num22;
                for (int index21 = 0; index21 < 3; ++index21)
                {
                  y5 -= 7;
                  int index22 = x5;
                  int index23 = x5;
                  while (index22 > 0 && !Main.tile[index22, y5].active() && !Main.tile[index22, y5 - 1].active() && !Main.tile[index22, y5 + 1].active())
                    --index22;
                  int num26 = index22 + 1;
                  while (index23 < Main.maxTilesX - 1 && !Main.tile[index23, y5].active() && !Main.tile[index23, y5 - 1].active() && !Main.tile[index23, y5 + 1].active())
                    ++index23;
                  int num27 = index23 - 1;
                  x5 = (num26 + num27) / 2;
                  if (data.CanGenerateFeatureInArea((IDungeonFeature) this, x5, y5, 3))
                  {
                    PaintingEntry paintingEntry7 = DungeonGlobalPaintings.Paintings_GetPaintingEntry(data, (int) Main.tile[x5, y5].wall);
                    if (Math.Abs(num23 - x5) < 4 && !WorldGen.nearPicture(x5, y5))
                      DungeonGlobalPaintings.Paintings_PlacePainting(x5, y5, paintingEntry7);
                    else
                      break;
                  }
                }
                continue;
              }
              continue;
            }
            continue;
          default:
            continue;
        }
      }
    }
  }

  private static void Paintings_PlacePainting(int x, int y, PaintingEntry entry)
  {
    WorldGen.PlaceTile(x, y, entry.tileType, true, style: entry.style);
    if (Main.tile[x, y].wall != (ushort) 87)
      return;
    ++DungeonGlobalPaintings.lihzahrdPaintingsPlaced;
  }

  private static PaintingEntry Paintings_GetPaintingEntry(DungeonData data, int currentWall)
  {
    int wallVariant = data.wallVariants[0];
    DungeonGenerationStyleData styleForWall = DungeonGenerationStyles.GetStyleForWall(data.genVars.dungeonGenerationStyles, currentWall);
    switch (styleForWall == null ? 0 : (int) styleForWall.Style)
    {
      case 0:
        return currentWall != wallVariant ? DungeonGlobalPaintings.Paintings_RandomBonePainting() : DungeonGlobalPaintings.Paintings_RandomDungeonPainting();
      case 3:
        return WorldGen.RandHousePictureDesert();
      case 4:
      case 5:
        return DungeonGlobalPaintings.Paintings_RandomBonePainting();
      case 10:
        PlacementDetails derivedPlacementDetail = ItemID.Sets.DerivedPlacementDetails[5230];
        return new PaintingEntry()
        {
          tileType = derivedPlacementDetail.tileType,
          style = (int) derivedPlacementDetail.tileStyle
        };
      default:
        return WorldGen.RandHousePicture();
    }
  }

  private static PaintingEntry Paintings_RandomDungeonPainting()
  {
    UnifiedRandom genRand = WorldGen.genRand;
    int num1 = genRand.Next(3);
    int num2 = 0;
    if (num1 <= 1)
    {
      int maxValue = 7;
      num1 = 240 /*0xF0*/;
      num2 = genRand.Next(maxValue);
      if (num2 == 6)
        num2 = genRand.Next(maxValue);
      if (num2 == 0)
        num2 = 12;
      else if (num2 == 1)
        num2 = 13;
      else if (num2 == 2)
        num2 = 14;
      else if (num2 == 3)
        num2 = 15;
      else if (num2 == 4)
        num2 = 18;
      else if (num2 == 5)
        num2 = 19;
      else if (num2 == 6)
        num2 = 23;
    }
    else if (num1 == 2)
    {
      num1 = 242;
      int maxValue = 17;
      num2 = genRand.Next(maxValue);
      if (num2 > 13)
      {
        switch (num2)
        {
          case 14:
            num2 = 15;
            break;
          case 15:
            num2 = 16 /*0x10*/;
            break;
          case 16 /*0x10*/:
            num2 = 30;
            break;
        }
      }
    }
    return new PaintingEntry()
    {
      tileType = num1,
      style = num2
    };
  }

  private static PaintingEntry Paintings_RandomBonePainting()
  {
    UnifiedRandom genRand = WorldGen.genRand;
    int num1 = genRand.Next(2);
    int num2 = 0;
    switch (num1)
    {
      case 0:
        num1 = 240 /*0xF0*/;
        num2 = genRand.Next(2);
        switch (num2)
        {
          case 0:
            num2 = 16 /*0x10*/;
            break;
          case 1:
            num2 = 17;
            break;
        }
        break;
      case 1:
        num1 = 241;
        num2 = genRand.Next(9);
        break;
    }
    return new PaintingEntry()
    {
      tileType = num1,
      style = num2
    };
  }
}
