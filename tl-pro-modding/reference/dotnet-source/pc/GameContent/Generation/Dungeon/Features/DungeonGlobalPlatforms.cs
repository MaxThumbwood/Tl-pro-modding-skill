// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Features.DungeonGlobalPlatforms
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Features;

public class DungeonGlobalPlatforms : GlobalDungeonFeature
{
  public DungeonGlobalPlatforms(DungeonFeatureSettings settings)
    : base(settings)
  {
    DungeonCrawler.CurrentDungeonData.dungeonFeatures.Add((IDungeonFeature) this);
  }

  public override bool GenerateFeature(DungeonData data)
  {
    this.generated = false;
    this.Platforms(data);
    this.generated = true;
    return true;
  }

  public void Platforms(DungeonData data)
  {
    UnifiedRandom genRand = WorldGen.genRand;
    PlacementDetails derivedPlacementDetail = ItemID.Sets.DerivedPlacementDetails[data.platformItemType];
    for (int index1 = 0; index1 < data.dungeonPlatformData.Count; ++index1)
    {
      DungeonPlatformData dungeonPlatformData = data.dungeonPlatformData[index1];
      if (WorldGen.InWorld(dungeonPlatformData.Position, 30))
      {
        int tileStyle = (int) derivedPlacementDetail.tileStyle;
        if (dungeonPlatformData.OverrideStyle.HasValue)
        {
          int? overrideStyle = dungeonPlatformData.OverrideStyle;
          int num = 0;
          if (overrideStyle.GetValueOrDefault() >= num & overrideStyle.HasValue)
            tileStyle = dungeonPlatformData.OverrideStyle.Value;
        }
        int x = dungeonPlatformData.Position.X;
        int y = dungeonPlatformData.Position.Y;
        int num1 = -1;
        bool forcePlacement = dungeonPlatformData.ForcePlacement;
        int num2 = 5;
        int num3 = 10;
        if ((double) y < Main.worldSurface + 50.0)
          num3 = 20;
        if (dungeonPlatformData.OverrideMaxLengthAllowed > 0)
          num3 = dungeonPlatformData.OverrideMaxLengthAllowed;
        if (dungeonPlatformData.OverrideHeightFluff.HasValue)
          num2 = dungeonPlatformData.OverrideHeightFluff.Value;
        double num4 = dungeonPlatformData.InAHallway ? data.HallSizeScalar : data.RoomSizeScalar;
        int num5 = (int) ((double) num3 * num4);
        for (int index2 = y - num2; index2 <= y + num2; ++index2)
        {
          int index3 = x;
          int index4 = x;
          bool flag1 = false;
          if (!forcePlacement && Main.tile[index3, index2].active())
          {
            flag1 = true;
          }
          else
          {
            while (!Main.tile[index3, index2].active())
            {
              --index3;
              if (!forcePlacement && (Main.tile[index3, index2].active() && !DungeonUtils.IsConsideredDungeonTile((int) Main.tile[index3, index2].type) || index3 == 0))
              {
                flag1 = true;
                break;
              }
              if (dungeonPlatformData.canPlaceHereCallback != null && !dungeonPlatformData.canPlaceHereCallback(data, index3, index2))
              {
                flag1 = true;
                break;
              }
              if (index3 <= 10)
                break;
            }
            while (!Main.tile[index4, index2].active())
            {
              ++index4;
              if (!forcePlacement && (Main.tile[index4, index2].active() && !DungeonUtils.IsConsideredDungeonTile((int) Main.tile[index4, index2].type) || index4 == Main.maxTilesX - 1))
              {
                flag1 = true;
                break;
              }
              if (dungeonPlatformData.canPlaceHereCallback != null && !dungeonPlatformData.canPlaceHereCallback(data, index4, index2))
              {
                flag1 = true;
                break;
              }
              if (index4 >= Main.maxTilesX - 10)
                break;
            }
          }
          if (!flag1 && (forcePlacement || index4 - index3 <= num5))
          {
            bool flag2 = true;
            int num6 = Math.Max(0, x - num5 / 2 - 2);
            int num7 = Math.Min(Main.maxTilesX - 1, x + num5 / 2 + 2);
            int num8 = index2 - num2;
            int num9 = index2 + num2;
            if (!forcePlacement)
            {
              if (!dungeonPlatformData.SkipOtherPlatformsCheck)
              {
                for (int index5 = num6; index5 <= num7; ++index5)
                {
                  for (int index6 = num8; index6 <= num9; ++index6)
                  {
                    if (Main.tile[index5, index6].active() && Main.tile[index5, index6].type == (ushort) 19)
                    {
                      flag2 = false;
                      break;
                    }
                  }
                }
              }
              if (!dungeonPlatformData.SkipSpaceCheck)
              {
                for (int index7 = index2 + 3; index7 >= index2 - 5; --index7)
                {
                  if (Main.tile[x, index7].active())
                  {
                    flag2 = false;
                    break;
                  }
                }
              }
            }
            if (flag2)
            {
              num1 = index2;
              break;
            }
          }
        }
        if (forcePlacement && num1 > 0 || num1 > y - num2 - 5 && num1 < y + num2 + 5)
        {
          int i1 = x;
          int j = num1;
          int i2 = x + 1;
          while (!Main.tile[i1, j].active())
          {
            Main.tile[i1, j].active(true);
            Main.tile[i1, j].type = (ushort) 19;
            Main.tile[i1, j].Clear(TileDataType.Slope);
            Main.tile[i1, j].frameY = (short) (18 * tileStyle);
            WorldGen.TileFrame(i1, j);
            --i1;
            if (i1 <= 10)
              break;
          }
          while (!Main.tile[i2, j].active())
          {
            Main.tile[i2, j].active(true);
            Main.tile[i2, j].type = (ushort) 19;
            Main.tile[i2, j].Clear(TileDataType.Slope);
            Main.tile[i2, j].frameY = (short) (18 * tileStyle);
            WorldGen.TileFrame(i2, j);
            ++i2;
            if (i2 >= Main.maxTilesX - 10)
              break;
          }
          if (dungeonPlatformData.IsAShelf)
          {
            for (int placeX = i1; placeX < i2; ++placeX)
            {
              if (dungeonPlatformData.PlaceWaterCandlesChance > 0.0 && genRand.NextDouble() < dungeonPlatformData.PlaceWaterCandlesChance)
                DungeonUtils.GenerateDungeonWaterCandle(placeX, j - 1);
              else if (dungeonPlatformData.PlacePotsChance > 0.0 && genRand.NextDouble() < dungeonPlatformData.PlacePotsChance)
                DungeonUtils.GenerateDungeonPot(placeX, j - 1);
              else if (dungeonPlatformData.PlacePotionBottlesChance > 0.0 && genRand.NextDouble() < dungeonPlatformData.PlacePotionBottlesChance)
                DungeonUtils.GenerateDungeonPotionBottle(placeX, j - 1);
              else if (dungeonPlatformData.PlaceBooksChance > 0.0 && genRand.NextDouble() < dungeonPlatformData.PlaceBooksChance)
              {
                if (dungeonPlatformData.NoWaterbolt)
                  DungeonUtils.GenerateDungeonBook(placeX, j - 1, false);
                else
                  DungeonUtils.GenerateDungeonBook(placeX, j - 1);
              }
            }
          }
        }
      }
    }
  }
}
