// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.DungeonGenerationStyles
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;
using Terraria.GameContent.Generation.Dungeon.Features;
using Terraria.GameContent.Generation.Dungeon.Rooms;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon;

public static class DungeonGenerationStyles
{
  public static DungeonGenerationStyleData Shimmer;
  public static DungeonGenerationStyleData Spider;
  public static DungeonGenerationStyleData LivingWood;
  public static DungeonGenerationStyleData Cavern;
  public static DungeonGenerationStyleData Snow;
  public static DungeonGenerationStyleData Desert;
  public static DungeonGenerationStyleData Corruption;
  public static DungeonGenerationStyleData Crimson;
  public static DungeonGenerationStyleData Crystal;
  public static DungeonGenerationStyleData Hallow;
  public static DungeonGenerationStyleData GlowingMushroom;
  public static DungeonGenerationStyleData Beehive;
  public static DungeonGenerationStyleData LivingMahogany;
  public static DungeonGenerationStyleData Jungle;
  public static DungeonGenerationStyleData Temple;

  public static DungeonGenerationStyleData GetCurrentDungeonStyle()
  {
    return new DungeonGenerationStyleData()
    {
      Style = 0,
      UnbreakableWallProgressionTier = DualDungeonUnbreakableWallTiers.Dungeon,
      BrickTileType = GenVars.CurrentDungeonGenVars.brickTileType,
      BrickCrackedTileType = GenVars.CurrentDungeonGenVars.brickCrackedTileType,
      BrickWallType = GenVars.CurrentDungeonGenVars.brickWallType,
      WindowGlassWallType = GenVars.CurrentDungeonGenVars.windowGlassWallType,
      WindowClosedGlassWallType = GenVars.CurrentDungeonGenVars.windowClosedGlassWallType,
      WindowEdgeWallType = GenVars.CurrentDungeonGenVars.windowEdgeWallType,
      WindowPlatformItemTypes = GenVars.CurrentDungeonGenVars.windowPlatformItemTypes,
      PitTrapTileType = GenVars.CurrentDungeonGenVars.brickCrackedTileType,
      LockedBiomeChestType = -1,
      LockedBiomeChestStyle = -1,
      BiomeChestItemType = -1,
      BiomeChestLootItemType = -1,
      ChestItemTypes = new int[0],
      DoorItemTypes = new int[0],
      PlatformItemTypes = new int[0],
      ChandelierItemTypes = new int[0],
      LanternItemTypes = new int[0],
      TableItemTypes = new int[0],
      WorkbenchItemTypes = new int[0],
      CandleItemTypes = new int[0],
      VaseOrStatueItemTypes = new int[0],
      BookcaseItemTypes = new int[0],
      ChairItemTypes = new int[0],
      BedItemTypes = new int[0],
      PianoItemTypes = new int[0],
      DresserItemTypes = new int[0],
      SofaItemTypes = new int[0],
      BathtubItemTypes = new int[0],
      LampItemTypes = new int[0],
      CandelabraItemTypes = new int[0],
      ClockItemTypes = new int[0],
      BannerItemTypes = new int[0],
      EdgeDither = false,
      BiomeRoomType = DungeonRoomType.BiomeStructured
    };
  }

  public static DungeonGenerationStyleData GetStyleForTile(
    List<DungeonGenerationStyleData> styles,
    int tileType)
  {
    foreach (DungeonGenerationStyleData style in styles)
    {
      if (style.TileIsInStyle(tileType))
        return style;
      if (style.SubStyles != null && style.SubStyles.Count > 0)
      {
        foreach (DungeonGenerationStyleData subStyle in style.SubStyles)
        {
          if (subStyle.TileIsInStyle(tileType))
            return subStyle;
        }
      }
    }
    return (DungeonGenerationStyleData) null;
  }

  public static DungeonGenerationStyleData GetStyleForWall(
    List<DungeonGenerationStyleData> styles,
    int wallType)
  {
    foreach (DungeonGenerationStyleData style in styles)
    {
      if (style.WallIsInStyle(wallType))
        return style;
      if (style.SubStyles != null && style.SubStyles.Count > 0)
      {
        foreach (DungeonGenerationStyleData subStyle in style.SubStyles)
        {
          if (subStyle.WallIsInStyle(wallType))
            return subStyle;
        }
      }
    }
    return (DungeonGenerationStyleData) null;
  }

  static DungeonGenerationStyles()
  {
    DungeonGenerationStyles.ShimmerStyleData shimmerStyleData1 = new DungeonGenerationStyles.ShimmerStyleData();
    shimmerStyleData1.Style = (byte) 11;
    shimmerStyleData1.UnbreakableWallProgressionTier = DualDungeonUnbreakableWallTiers.EarlyGame;
    shimmerStyleData1.BrickTileType = (ushort) 667;
    shimmerStyleData1.BrickCrackedTileType = (ushort) 123;
    shimmerStyleData1.BrickWallType = (ushort) 322;
    shimmerStyleData1.WindowGlassWallType = (ushort) 93;
    shimmerStyleData1.WindowClosedGlassWallType = (ushort) 149;
    shimmerStyleData1.WindowEdgeWallType = (ushort) 37;
    shimmerStyleData1.WindowPlatformItemTypes = new int[1]
    {
      94
    };
    shimmerStyleData1.PitTrapTileType = (ushort) 123;
    shimmerStyleData1.LiquidType = 3;
    shimmerStyleData1.LockedBiomeChestType = -1;
    shimmerStyleData1.LockedBiomeChestStyle = -1;
    shimmerStyleData1.BiomeChestItemType = -1;
    shimmerStyleData1.BiomeChestLootItemType = -1;
    shimmerStyleData1.ChestItemTypes = new int[1]{ 5556 };
    shimmerStyleData1.DoorItemTypes = new int[1]{ 5558 };
    shimmerStyleData1.PlatformItemTypes = new int[1]{ 5562 };
    shimmerStyleData1.ChandelierItemTypes = new int[1]
    {
      5555
    };
    shimmerStyleData1.LanternItemTypes = new int[1]{ 5560 };
    shimmerStyleData1.TableItemTypes = new int[1]{ 5565 };
    shimmerStyleData1.WorkbenchItemTypes = new int[1]
    {
      5566
    };
    shimmerStyleData1.CandleItemTypes = new int[1]{ 5553 };
    shimmerStyleData1.VaseOrStatueItemTypes = (int[]) null;
    shimmerStyleData1.BookcaseItemTypes = new int[1]{ 5550 };
    shimmerStyleData1.ChairItemTypes = new int[1]{ 5554 };
    shimmerStyleData1.BedItemTypes = new int[1]{ 5549 };
    shimmerStyleData1.PianoItemTypes = new int[1]{ 5561 };
    shimmerStyleData1.DresserItemTypes = new int[1]{ 5551 };
    shimmerStyleData1.SofaItemTypes = new int[1]{ 5564 };
    shimmerStyleData1.BathtubItemTypes = new int[1]{ 5548 };
    shimmerStyleData1.LampItemTypes = new int[1]{ 5559 };
    shimmerStyleData1.CandelabraItemTypes = new int[1]
    {
      5552
    };
    shimmerStyleData1.ClockItemTypes = new int[1]{ 5557 };
    shimmerStyleData1.BannerItemTypes = new int[6]
    {
      337,
      339,
      338,
      340,
      5497,
      5498
    };
    shimmerStyleData1.EdgeDither = true;
    shimmerStyleData1.BiomeRoomType = DungeonRoomType.BiomeRugged;
    DungeonGenerationStyles.Shimmer = (DungeonGenerationStyleData) shimmerStyleData1;
    DungeonGenerationStyles.Spider = new DungeonGenerationStyleData()
    {
      Style = (byte) 12,
      UnbreakableWallProgressionTier = DualDungeonUnbreakableWallTiers.EarlyGame,
      BrickTileType = (ushort) 156,
      BrickCrackedTileType = (ushort) 123,
      BrickWallType = (ushort) 62,
      WindowGlassWallType = (ushort) 21,
      WindowClosedGlassWallType = (ushort) 4,
      WindowEdgeWallType = (ushort) 36,
      WindowPlatformItemTypes = new int[1]{ 94 },
      PitTrapTileType = (ushort) 123,
      LockedBiomeChestType = -1,
      LockedBiomeChestStyle = -1,
      BiomeChestItemType = -1,
      BiomeChestLootItemType = -1,
      ChestItemTypes = new int[1]{ 952 },
      DoorItemTypes = new int[1]{ 4415 },
      PlatformItemTypes = new int[1]{ 4416 },
      ChandelierItemTypes = new int[6]
      {
        106,
        107,
        108,
        710,
        711,
        712
      },
      LanternItemTypes = new int[1]{ 2037 },
      TableItemTypes = new int[1]{ 32 /*0x20*/ },
      WorkbenchItemTypes = new int[1]{ 36 },
      CandleItemTypes = new int[2]{ 105, 713 },
      VaseOrStatueItemTypes = (int[]) null,
      BookcaseItemTypes = new int[1]{ 354 },
      ChairItemTypes = new int[1]{ 34 },
      BedItemTypes = new int[1]{ 224 /*0xE0*/ },
      PianoItemTypes = new int[1]{ 333 },
      DresserItemTypes = new int[1]{ 334 },
      SofaItemTypes = new int[1]{ 2397 },
      BathtubItemTypes = new int[1]{ 336 },
      LampItemTypes = new int[1]{ 342 },
      CandelabraItemTypes = new int[2]{ 349, 714 },
      ClockItemTypes = new int[1]{ 359 },
      BannerItemTypes = (int[]) null,
      EdgeDither = true,
      BiomeRoomType = DungeonRoomType.BiomeRugged
    };
    DungeonGenerationStyles.LivingWoodStyleData livingWoodStyleData1 = new DungeonGenerationStyles.LivingWoodStyleData();
    livingWoodStyleData1.Style = (byte) 13;
    livingWoodStyleData1.UnbreakableWallProgressionTier = DualDungeonUnbreakableWallTiers.EarlyGame;
    livingWoodStyleData1.BrickTileType = (ushort) 191;
    livingWoodStyleData1.BrickCrackedTileType = (ushort) 192 /*0xC0*/;
    livingWoodStyleData1.BrickWallType = (ushort) 244;
    livingWoodStyleData1.WindowGlassWallType = (ushort) 21;
    livingWoodStyleData1.WindowClosedGlassWallType = (ushort) 4;
    livingWoodStyleData1.WindowEdgeWallType = (ushort) 196;
    livingWoodStyleData1.WindowPlatformItemTypes = new int[1]
    {
      2629
    };
    livingWoodStyleData1.PitTrapTileType = (ushort) 123;
    livingWoodStyleData1.LockedBiomeChestType = -1;
    livingWoodStyleData1.LockedBiomeChestStyle = -1;
    livingWoodStyleData1.BiomeChestItemType = -1;
    livingWoodStyleData1.BiomeChestLootItemType = -1;
    livingWoodStyleData1.ChestItemTypes = new int[1]{ 831 };
    livingWoodStyleData1.DoorItemTypes = new int[1]{ 819 };
    livingWoodStyleData1.PlatformItemTypes = new int[1]
    {
      2629
    };
    livingWoodStyleData1.ChandelierItemTypes = new int[1]
    {
      2141
    };
    livingWoodStyleData1.LanternItemTypes = new int[1]
    {
      2145
    };
    livingWoodStyleData1.TableItemTypes = new int[1]{ 829 };
    livingWoodStyleData1.WorkbenchItemTypes = new int[1]
    {
      2633
    };
    livingWoodStyleData1.CandleItemTypes = new int[1]
    {
      2153
    };
    livingWoodStyleData1.VaseOrStatueItemTypes = (int[]) null;
    livingWoodStyleData1.BookcaseItemTypes = new int[1]
    {
      2135
    };
    livingWoodStyleData1.ChairItemTypes = new int[1]{ 806 };
    livingWoodStyleData1.BedItemTypes = new int[1]{ 2139 };
    livingWoodStyleData1.PianoItemTypes = new int[1]{ 2245 };
    livingWoodStyleData1.DresserItemTypes = new int[1]
    {
      3914
    };
    livingWoodStyleData1.SofaItemTypes = new int[1]{ 2636 };
    livingWoodStyleData1.BathtubItemTypes = new int[1]
    {
      2126
    };
    livingWoodStyleData1.LampItemTypes = new int[1]{ 2131 };
    livingWoodStyleData1.CandelabraItemTypes = new int[1]
    {
      2149
    };
    livingWoodStyleData1.ClockItemTypes = new int[1]{ 2596 };
    livingWoodStyleData1.BannerItemTypes = (int[]) null;
    livingWoodStyleData1.EdgeDither = true;
    livingWoodStyleData1.BiomeRoomType = DungeonRoomType.BiomeRugged;
    DungeonGenerationStyles.LivingWood = (DungeonGenerationStyleData) livingWoodStyleData1;
    DungeonGenerationStyles.Cavern = new DungeonGenerationStyleData()
    {
      Style = (byte) 1,
      UnbreakableWallProgressionTier = DualDungeonUnbreakableWallTiers.EarlyGame,
      BrickTileType = (ushort) 38,
      BrickCrackedTileType = (ushort) 123,
      BrickWallType = (ushort) 349,
      WindowGlassWallType = (ushort) 21,
      WindowClosedGlassWallType = (ushort) 4,
      WindowEdgeWallType = (ushort) 5,
      WindowPlatformItemTypes = new int[2]{ 94, 4416 },
      PitTrapTileType = (ushort) 123,
      LockedBiomeChestType = -1,
      LockedBiomeChestStyle = -1,
      BiomeChestItemType = -1,
      BiomeChestLootItemType = -1,
      ChestItemTypes = new int[2]{ 306, 5886 },
      DoorItemTypes = new int[2]{ 25, 4415 },
      PlatformItemTypes = new int[2]{ 94, 4416 },
      ChandelierItemTypes = new int[7]
      {
        106,
        107,
        108,
        710,
        711,
        712,
        5885
      },
      LanternItemTypes = new int[2]{ 2037, 5890 },
      TableItemTypes = new int[2]{ 32 /*0x20*/, 5894 },
      WorkbenchItemTypes = new int[2]{ 36, 5896 },
      CandleItemTypes = new int[3]{ 105, 713, 5883 },
      VaseOrStatueItemTypes = (int[]) null,
      BookcaseItemTypes = new int[2]{ 354, 5881 },
      ChairItemTypes = new int[2]{ 34, 5884 },
      BedItemTypes = new int[2]{ 224 /*0xE0*/, 5880 },
      PianoItemTypes = new int[2]{ 333, 5891 },
      DresserItemTypes = new int[2]{ 334, 5888 },
      SofaItemTypes = new int[2]{ 2397, 5893 },
      BathtubItemTypes = new int[2]{ 336, 5879 },
      LampItemTypes = new int[2]{ 342, 5889 },
      CandelabraItemTypes = new int[3]{ 349, 714, 5882 },
      ClockItemTypes = new int[2]{ 359, 5887 },
      BannerItemTypes = new int[6]
      {
        337,
        339,
        338,
        340,
        5497,
        5498
      },
      EdgeDither = true,
      BiomeRoomType = DungeonRoomType.BiomeStructured,
      SubStyles = new List<DungeonGenerationStyleData>()
      {
        DungeonGenerationStyles.Shimmer,
        DungeonGenerationStyles.Spider,
        DungeonGenerationStyles.LivingWood
      }
    };
    DungeonGenerationStyles.Snow = new DungeonGenerationStyleData()
    {
      Style = (byte) 2,
      UnbreakableWallProgressionTier = DualDungeonUnbreakableWallTiers.EarlyGame,
      BrickTileType = (ushort) 161,
      BrickCrackedTileType = (ushort) 224 /*0xE0*/,
      BrickWallType = (ushort) 71,
      WindowGlassWallType = (ushort) 90,
      WindowClosedGlassWallType = (ushort) 149,
      WindowEdgeWallType = (ushort) 31 /*0x1F*/,
      WindowPlatformItemTypes = new int[1]{ 3908 },
      PitTrapTileType = (ushort) 224 /*0xE0*/,
      LockedBiomeChestType = 21,
      LockedBiomeChestStyle = 27,
      BiomeChestItemType = 1532,
      BiomeChestLootItemType = 1572,
      ChestItemTypes = new int[2]{ 681, 5805 },
      DoorItemTypes = new int[2]{ 2044, 5807 },
      PlatformItemTypes = new int[2]{ 3908, 5812 },
      ChandelierItemTypes = new int[2]{ 2059, 5804 },
      LanternItemTypes = new int[2]{ 2040, 5810 },
      TableItemTypes = new int[2]{ 2248, 5815 },
      WorkbenchItemTypes = new int[2]{ 2252, 5817 },
      CandleItemTypes = new int[2]{ 2049, 5802 },
      VaseOrStatueItemTypes = (int[]) null,
      BookcaseItemTypes = new int[2]{ 2031, 5800 },
      ChairItemTypes = new int[2]{ 2288, 5803 },
      BedItemTypes = new int[2]{ 2068, 5799 },
      PianoItemTypes = new int[2]{ 2247, 5811 },
      DresserItemTypes = new int[2]{ 3913, 5808 },
      SofaItemTypes = new int[2]{ 2635, 5814 },
      BathtubItemTypes = new int[2]{ 2076, 5798 },
      LampItemTypes = new int[2]{ 2086, 5809 },
      CandelabraItemTypes = new int[2]{ 2100, 5801 },
      ClockItemTypes = new int[2]{ 2594, 5806 },
      BannerItemTypes = (int[]) null,
      EdgeDither = true,
      BiomeRoomType = DungeonRoomType.BiomeRugged
    };
    DungeonGenerationStyles.Desert = new DungeonGenerationStyleData()
    {
      Style = (byte) 3,
      UnbreakableWallProgressionTier = DualDungeonUnbreakableWallTiers.EarlyGame,
      BrickTileType = (ushort) 396,
      BrickCrackedTileType = (ushort) 53,
      BrickWallType = (ushort) 187,
      WindowGlassWallType = (ushort) 89,
      WindowClosedGlassWallType = (ushort) 151,
      WindowEdgeWallType = (ushort) 34,
      WindowPlatformItemTypes = new int[1]{ 4311 },
      PitTrapTileType = (ushort) 53,
      LockedBiomeChestType = 467,
      LockedBiomeChestStyle = 13,
      BiomeChestItemType = 4712,
      BiomeChestLootItemType = 4607,
      ChestItemTypes = new int[1]{ 4267 },
      DoorItemTypes = new int[1]{ 4307 },
      PlatformItemTypes = new int[1]{ 4311 },
      ChandelierItemTypes = new int[1]{ 4305 },
      LanternItemTypes = new int[1]{ 4309 },
      TableItemTypes = new int[1]{ 4314 },
      WorkbenchItemTypes = new int[1]{ 4315 },
      CandleItemTypes = new int[1]{ 4303 },
      VaseOrStatueItemTypes = (int[]) null,
      BookcaseItemTypes = new int[1]{ 4300 },
      ChairItemTypes = new int[1]{ 4304 },
      BedItemTypes = new int[1]{ 4299 },
      PianoItemTypes = new int[1]{ 4310 },
      DresserItemTypes = new int[1]{ 4301 },
      SofaItemTypes = new int[1]{ 4313 },
      BathtubItemTypes = new int[1]{ 4298 },
      LampItemTypes = new int[1]{ 4308 },
      CandelabraItemTypes = new int[1]{ 4302 },
      ClockItemTypes = new int[1]{ 4306 },
      BannerItemTypes = new int[3]{ 790, 791, 789 },
      EdgeDither = false,
      BiomeRoomType = DungeonRoomType.BiomeRugged
    };
    DungeonGenerationStyles.Corruption = new DungeonGenerationStyleData()
    {
      Style = (byte) 4,
      UnbreakableWallProgressionTier = DualDungeonUnbreakableWallTiers.EvilBoss,
      BrickTileType = (ushort) 25,
      BrickCrackedTileType = (ushort) 112 /*0x70*/,
      BrickWallType = (ushort) 3,
      WindowGlassWallType = (ushort) 88,
      WindowClosedGlassWallType = (ushort) 41,
      WindowEdgeWallType = (ushort) 33,
      WindowPlatformItemTypes = new int[1]{ 631 },
      PitTrapTileType = (ushort) 112 /*0x70*/,
      LockedBiomeChestType = 21,
      LockedBiomeChestStyle = 24,
      BiomeChestItemType = 1529,
      BiomeChestLootItemType = 1571,
      ChestItemTypes = new int[3]{ 625, 3965, 5763 },
      DoorItemTypes = new int[3]{ 650, 3967, 5765 },
      PlatformItemTypes = new int[3]{ 631, 3957, 5770 },
      ChandelierItemTypes = new int[3]{ 2056, 3964, 5762 },
      LanternItemTypes = new int[3]{ 2033, 3970, 5768 },
      TableItemTypes = new int[3]{ 638, 3974, 5773 },
      WorkbenchItemTypes = new int[3]{ 635, 3975, 5775 },
      CandleItemTypes = new int[3]{ 2046, 3962, 5760 },
      VaseOrStatueItemTypes = (int[]) null,
      BookcaseItemTypes = new int[3]{ 2021, 3960, 5758 },
      ChairItemTypes = new int[3]{ 628, 3963, 5761 },
      BedItemTypes = new int[3]{ 644, 3959, 5757 },
      PianoItemTypes = new int[3]{ 641, 3971, 5769 },
      DresserItemTypes = new int[3]{ 647, 3968, 5766 },
      SofaItemTypes = new int[3]{ 2398, 3973, 5772 },
      BathtubItemTypes = new int[3]{ 2073, 3958, 5756 },
      LampItemTypes = new int[3]{ 2083, 3969, 5767 },
      CandelabraItemTypes = new int[3]{ 2093, 3961, 5759 },
      ClockItemTypes = new int[3]{ 2593, 3966, 5764 },
      BannerItemTypes = (int[]) null,
      EdgeDither = true,
      BiomeRoomType = DungeonRoomType.BiomeRugged
    };
    DungeonGenerationStyles.Crimson = new DungeonGenerationStyleData()
    {
      Style = (byte) 5,
      UnbreakableWallProgressionTier = DualDungeonUnbreakableWallTiers.EvilBoss,
      BrickTileType = (ushort) 203,
      BrickCrackedTileType = (ushort) 234,
      BrickWallType = (ushort) 83,
      WindowGlassWallType = (ushort) 92,
      WindowClosedGlassWallType = (ushort) 85,
      WindowEdgeWallType = (ushort) 174,
      WindowPlatformItemTypes = new int[1]{ 913 },
      PitTrapTileType = (ushort) 234,
      LockedBiomeChestType = 21,
      LockedBiomeChestStyle = 25,
      BiomeChestItemType = 1530,
      BiomeChestLootItemType = 1569,
      ChestItemTypes = new int[3]{ 914, 2617, 5784 },
      DoorItemTypes = new int[3]{ 912, 817, 5786 },
      PlatformItemTypes = new int[3]{ 913, 3907, 5791 },
      ChandelierItemTypes = new int[3]{ 2142, 2057, 5783 },
      LanternItemTypes = new int[3]{ 2146, 2034, 5789 },
      TableItemTypes = new int[3]{ 917, 828, 5794 },
      WorkbenchItemTypes = new int[3]{ 916, 813, 5796 },
      CandleItemTypes = new int[3]
      {
        2154,
        2047 /*0x07FF*/,
        5781
      },
      VaseOrStatueItemTypes = (int[]) null,
      BookcaseItemTypes = new int[3]{ 2136, 2022, 5779 },
      ChairItemTypes = new int[3]{ 915, 809, 5782 },
      BedItemTypes = new int[3]{ 920, 2067, 5778 },
      PianoItemTypes = new int[3]{ 919, 2246, 5790 },
      DresserItemTypes = new int[3]{ 918, 2640, 5787 },
      SofaItemTypes = new int[3]{ 2401, 2634, 5793 },
      BathtubItemTypes = new int[3]{ 2127, 2074, 5777 },
      LampItemTypes = new int[3]{ 2132, 2084, 5788 },
      CandelabraItemTypes = new int[3]{ 2150, 2094, 5780 },
      ClockItemTypes = new int[3]{ 2604, 2598, 5785 },
      BannerItemTypes = (int[]) null,
      EdgeDither = true,
      BiomeRoomType = DungeonRoomType.BiomeRugged
    };
    DungeonGenerationStyles.ShimmerStyleData shimmerStyleData2 = new DungeonGenerationStyles.ShimmerStyleData();
    shimmerStyleData2.Style = (byte) 15;
    shimmerStyleData2.UnbreakableWallProgressionTier = DualDungeonUnbreakableWallTiers.Hallow;
    shimmerStyleData2.BrickTileType = (ushort) 385;
    shimmerStyleData2.BrickCrackedTileType = (ushort) 116;
    shimmerStyleData2.BrickWallType = (ushort) 186;
    shimmerStyleData2.WindowGlassWallType = (ushort) 88;
    shimmerStyleData2.WindowClosedGlassWallType = (ushort) 43;
    shimmerStyleData2.WindowEdgeWallType = (ushort) 22;
    shimmerStyleData2.WindowPlatformItemTypes = new int[1]
    {
      633
    };
    shimmerStyleData2.PitTrapTileType = (ushort) 116;
    shimmerStyleData2.LockedBiomeChestType = -1;
    shimmerStyleData2.LockedBiomeChestStyle = -1;
    shimmerStyleData2.BiomeChestItemType = -1;
    shimmerStyleData2.BiomeChestLootItemType = -1;
    shimmerStyleData2.ChestItemTypes = new int[1]{ 3884 };
    shimmerStyleData2.DoorItemTypes = new int[1]{ 3888 };
    shimmerStyleData2.PlatformItemTypes = new int[1]{ 3903 };
    shimmerStyleData2.ChandelierItemTypes = new int[1]
    {
      3894
    };
    shimmerStyleData2.LanternItemTypes = new int[1]{ 3891 };
    shimmerStyleData2.TableItemTypes = new int[1]{ 3920 };
    shimmerStyleData2.WorkbenchItemTypes = new int[1]
    {
      3909
    };
    shimmerStyleData2.CandleItemTypes = new int[1]{ 3890 };
    shimmerStyleData2.VaseOrStatueItemTypes = (int[]) null;
    shimmerStyleData2.BookcaseItemTypes = new int[1]{ 3917 };
    shimmerStyleData2.ChairItemTypes = new int[1]{ 3889 };
    shimmerStyleData2.BedItemTypes = new int[1]{ 3897 };
    shimmerStyleData2.PianoItemTypes = new int[1]{ 3915 };
    shimmerStyleData2.DresserItemTypes = new int[1]{ 3911 };
    shimmerStyleData2.SofaItemTypes = new int[1]{ 3918 };
    shimmerStyleData2.BathtubItemTypes = new int[1]{ 3895 };
    shimmerStyleData2.LampItemTypes = new int[1]{ 3892 };
    shimmerStyleData2.CandelabraItemTypes = new int[1]
    {
      3893
    };
    shimmerStyleData2.ClockItemTypes = new int[1]{ 3898 };
    shimmerStyleData2.BannerItemTypes = (int[]) null;
    shimmerStyleData2.EdgeDither = false;
    shimmerStyleData2.BiomeRoomType = DungeonRoomType.BiomeStructured;
    DungeonGenerationStyles.Crystal = (DungeonGenerationStyleData) shimmerStyleData2;
    DungeonGenerationStyles.Hallow = new DungeonGenerationStyleData()
    {
      Style = (byte) 6,
      UnbreakableWallProgressionTier = DualDungeonUnbreakableWallTiers.Hallow,
      BrickTileType = (ushort) 117,
      BrickCrackedTileType = (ushort) 116,
      BrickWallType = (ushort) 28,
      WindowGlassWallType = (ushort) 91,
      WindowClosedGlassWallType = (ushort) 43,
      WindowEdgeWallType = (ushort) 22,
      WindowPlatformItemTypes = new int[1]{ 633 },
      PitTrapTileType = (ushort) 116,
      LockedBiomeChestType = 21,
      LockedBiomeChestStyle = 26,
      BiomeChestItemType = 1531,
      BiomeChestLootItemType = 1260,
      ChestItemTypes = new int[2]{ 627, 3884 },
      DoorItemTypes = new int[2]{ 652, 3888 },
      PlatformItemTypes = new int[2]{ 633, 3903 },
      ChandelierItemTypes = new int[2]{ 2061, 3894 },
      LanternItemTypes = new int[2]{ 2039, 3891 },
      TableItemTypes = new int[2]{ 640, 3920 },
      WorkbenchItemTypes = new int[2]{ 637, 3909 },
      CandleItemTypes = new int[2]{ 2051, 3890 },
      VaseOrStatueItemTypes = (int[]) null,
      BookcaseItemTypes = new int[2]{ 2027, 3917 },
      ChairItemTypes = new int[2]{ 630, 3889 },
      BedItemTypes = new int[2]{ 646, 3897 },
      PianoItemTypes = new int[2]{ 643, 3915 },
      DresserItemTypes = new int[2]{ 649, 3911 },
      SofaItemTypes = new int[2]{ 2400, 3918 },
      BathtubItemTypes = new int[2]{ 2078, 3895 },
      LampItemTypes = new int[2]{ 2088, 3892 },
      CandelabraItemTypes = new int[2]{ 2099, 3893 },
      ClockItemTypes = new int[2]{ 2602, 3898 },
      BannerItemTypes = (int[]) null,
      EdgeDither = true,
      BiomeRoomType = DungeonRoomType.BiomeRugged,
      SubStyles = new List<DungeonGenerationStyleData>()
      {
        DungeonGenerationStyles.Crystal
      }
    };
    DungeonGenerationStyles.GlowingMushroom = new DungeonGenerationStyleData()
    {
      Style = (byte) 7,
      UnbreakableWallProgressionTier = DualDungeonUnbreakableWallTiers.JungleBoss,
      BrickTileType = (ushort) 59,
      BrickGrassTileType = new ushort?((ushort) 70),
      BrickCrackedTileType = (ushort) 123,
      BrickWallType = (ushort) 80 /*0x50*/,
      WindowGlassWallType = (ushort) 90,
      WindowClosedGlassWallType = (ushort) 60,
      WindowEdgeWallType = (ushort) 78,
      WindowPlatformItemTypes = new int[1]{ 2549 },
      PitTrapTileType = (ushort) 123,
      LockedBiomeChestType = -1,
      LockedBiomeChestStyle = -1,
      BiomeChestItemType = -1,
      BiomeChestLootItemType = -1,
      ChestItemTypes = new int[1]{ 2544 },
      DoorItemTypes = new int[1]{ 818 },
      PlatformItemTypes = new int[1]{ 2549 },
      ChandelierItemTypes = new int[1]{ 2543 },
      LanternItemTypes = new int[1]{ 2546 },
      TableItemTypes = new int[1]{ 2550 },
      WorkbenchItemTypes = new int[1]{ 814 },
      CandleItemTypes = new int[1]{ 2542 },
      VaseOrStatueItemTypes = (int[]) null,
      BookcaseItemTypes = new int[1]{ 2540 },
      ChairItemTypes = new int[1]{ 810 },
      BedItemTypes = new int[1]{ 2538 },
      PianoItemTypes = new int[1]{ 2548 },
      DresserItemTypes = new int[1]{ 2545 },
      SofaItemTypes = new int[1]{ 2413 },
      BathtubItemTypes = new int[1]{ 2537 },
      LampItemTypes = new int[1]{ 2547 },
      CandelabraItemTypes = new int[1]{ 2541 },
      ClockItemTypes = new int[1]{ 2599 },
      BannerItemTypes = (int[]) null,
      EdgeDither = true,
      BiomeRoomType = DungeonRoomType.BiomeRugged
    };
    DungeonGenerationStyles.BeehiveStyleData beehiveStyleData = new DungeonGenerationStyles.BeehiveStyleData();
    beehiveStyleData.Style = (byte) 9;
    beehiveStyleData.UnbreakableWallProgressionTier = DualDungeonUnbreakableWallTiers.JungleBoss;
    beehiveStyleData.BrickTileType = (ushort) 225;
    beehiveStyleData.BrickCrackedTileType = (ushort) 123;
    beehiveStyleData.BrickWallType = (ushort) 86;
    beehiveStyleData.WindowGlassWallType = (ushort) 89;
    beehiveStyleData.WindowClosedGlassWallType = (ushort) 172;
    beehiveStyleData.WindowEdgeWallType = (ushort) 151;
    beehiveStyleData.WindowPlatformItemTypes = new int[1]
    {
      2630
    };
    beehiveStyleData.PitTrapTileType = (ushort) 123;
    beehiveStyleData.LiquidType = 2;
    beehiveStyleData.LockedBiomeChestType = -1;
    beehiveStyleData.LockedBiomeChestStyle = -1;
    beehiveStyleData.BiomeChestItemType = -1;
    beehiveStyleData.BiomeChestLootItemType = -1;
    beehiveStyleData.ChestItemTypes = new int[1]{ 2249 };
    beehiveStyleData.DoorItemTypes = new int[1]{ 1711 };
    beehiveStyleData.PlatformItemTypes = new int[1]{ 2630 };
    beehiveStyleData.ChandelierItemTypes = new int[1]
    {
      2058
    };
    beehiveStyleData.LanternItemTypes = new int[1]{ 2035 };
    beehiveStyleData.TableItemTypes = new int[1]{ 1717 };
    beehiveStyleData.WorkbenchItemTypes = new int[1]{ 2251 };
    beehiveStyleData.CandleItemTypes = new int[1]{ 2648 };
    beehiveStyleData.VaseOrStatueItemTypes = (int[]) null;
    beehiveStyleData.BookcaseItemTypes = new int[1]{ 2023 };
    beehiveStyleData.ChairItemTypes = new int[1]{ 1707 };
    beehiveStyleData.BedItemTypes = new int[1]{ 1721 };
    beehiveStyleData.PianoItemTypes = new int[1]{ 2255 };
    beehiveStyleData.DresserItemTypes = new int[1]{ 2395 };
    beehiveStyleData.SofaItemTypes = new int[1]{ 2411 };
    beehiveStyleData.BathtubItemTypes = new int[1]{ 2124 };
    beehiveStyleData.LampItemTypes = new int[1]{ 2129 };
    beehiveStyleData.CandelabraItemTypes = new int[1]
    {
      2095
    };
    beehiveStyleData.ClockItemTypes = new int[1]{ 2240 };
    beehiveStyleData.BannerItemTypes = (int[]) null;
    beehiveStyleData.EdgeDither = true;
    beehiveStyleData.BiomeRoomType = DungeonRoomType.BiomeRugged;
    DungeonGenerationStyles.Beehive = (DungeonGenerationStyleData) beehiveStyleData;
    DungeonGenerationStyles.LivingWoodStyleData livingWoodStyleData2 = new DungeonGenerationStyles.LivingWoodStyleData();
    livingWoodStyleData2.Style = (byte) 14;
    livingWoodStyleData2.UnbreakableWallProgressionTier = DualDungeonUnbreakableWallTiers.JungleBoss;
    livingWoodStyleData2.BrickTileType = (ushort) 383;
    livingWoodStyleData2.BrickCrackedTileType = (ushort) 384;
    livingWoodStyleData2.BrickWallType = (ushort) 244;
    livingWoodStyleData2.WindowGlassWallType = (ushort) 21;
    livingWoodStyleData2.WindowClosedGlassWallType = (ushort) 42;
    livingWoodStyleData2.WindowEdgeWallType = (ushort) 196;
    livingWoodStyleData2.WindowPlatformItemTypes = new int[1]
    {
      2629
    };
    livingWoodStyleData2.PitTrapTileType = (ushort) 123;
    livingWoodStyleData2.LockedBiomeChestType = -1;
    livingWoodStyleData2.LockedBiomeChestStyle = -1;
    livingWoodStyleData2.BiomeChestItemType = -1;
    livingWoodStyleData2.BiomeChestLootItemType = -1;
    livingWoodStyleData2.ChestItemTypes = new int[1]{ 831 };
    livingWoodStyleData2.DoorItemTypes = new int[1]{ 819 };
    livingWoodStyleData2.PlatformItemTypes = new int[1]
    {
      2629
    };
    livingWoodStyleData2.ChandelierItemTypes = new int[1]
    {
      2141
    };
    livingWoodStyleData2.LanternItemTypes = new int[1]
    {
      2145
    };
    livingWoodStyleData2.TableItemTypes = new int[1]{ 829 };
    livingWoodStyleData2.WorkbenchItemTypes = new int[1]
    {
      2633
    };
    livingWoodStyleData2.CandleItemTypes = new int[1]
    {
      2153
    };
    livingWoodStyleData2.VaseOrStatueItemTypes = (int[]) null;
    livingWoodStyleData2.BookcaseItemTypes = new int[1]
    {
      2135
    };
    livingWoodStyleData2.ChairItemTypes = new int[1]{ 806 };
    livingWoodStyleData2.BedItemTypes = new int[1]{ 2139 };
    livingWoodStyleData2.PianoItemTypes = new int[1]{ 2245 };
    livingWoodStyleData2.DresserItemTypes = new int[1]
    {
      3914
    };
    livingWoodStyleData2.SofaItemTypes = new int[1]{ 2636 };
    livingWoodStyleData2.BathtubItemTypes = new int[1]
    {
      2126
    };
    livingWoodStyleData2.LampItemTypes = new int[1]{ 2131 };
    livingWoodStyleData2.CandelabraItemTypes = new int[1]
    {
      2149
    };
    livingWoodStyleData2.ClockItemTypes = new int[1]{ 2596 };
    livingWoodStyleData2.BannerItemTypes = (int[]) null;
    livingWoodStyleData2.EdgeDither = true;
    livingWoodStyleData2.BiomeRoomType = DungeonRoomType.BiomeRugged;
    DungeonGenerationStyles.LivingMahogany = (DungeonGenerationStyleData) livingWoodStyleData2;
    DungeonGenerationStyles.Jungle = new DungeonGenerationStyleData()
    {
      Style = (byte) 8,
      UnbreakableWallProgressionTier = DualDungeonUnbreakableWallTiers.JungleBoss,
      BrickTileType = (ushort) 59,
      BrickGrassTileType = new ushort?((ushort) 60),
      BrickCrackedTileType = (ushort) 123,
      BrickWallType = (ushort) 64 /*0x40*/,
      WindowGlassWallType = (ushort) 91,
      WindowClosedGlassWallType = (ushort) 42,
      WindowEdgeWallType = (ushort) 24,
      WindowPlatformItemTypes = new int[1]{ 632 },
      PitTrapTileType = (ushort) 123,
      LockedBiomeChestType = 21,
      LockedBiomeChestStyle = 23,
      BiomeChestItemType = 1528,
      BiomeChestLootItemType = 1156,
      ChestItemTypes = new int[2]{ 626, 680 },
      DoorItemTypes = new int[1]{ 651 },
      PlatformItemTypes = new int[1]{ 632 },
      ChandelierItemTypes = new int[1]{ 2060 },
      LanternItemTypes = new int[2]{ 2038, 4578 },
      TableItemTypes = new int[1]{ 639 },
      WorkbenchItemTypes = new int[1]{ 636 },
      CandleItemTypes = new int[1]{ 2050 },
      VaseOrStatueItemTypes = (int[]) null,
      BookcaseItemTypes = new int[1]{ 2026 },
      ChairItemTypes = new int[1]{ 629 },
      BedItemTypes = new int[1]{ 645 },
      PianoItemTypes = new int[1]{ 642 },
      DresserItemTypes = new int[1]{ 648 },
      SofaItemTypes = new int[1]{ 2399 },
      BathtubItemTypes = new int[1]{ 2077 },
      LampItemTypes = new int[1]{ 2087 },
      CandelabraItemTypes = new int[1]{ 2098 },
      ClockItemTypes = new int[1]{ 2597 },
      BannerItemTypes = (int[]) null,
      EdgeDither = true,
      BiomeRoomType = DungeonRoomType.BiomeRugged,
      SubStyles = new List<DungeonGenerationStyleData>()
      {
        DungeonGenerationStyles.Beehive,
        DungeonGenerationStyles.LivingMahogany
      }
    };
    DungeonGenerationStyles.TempleStyleData templeStyleData = new DungeonGenerationStyles.TempleStyleData();
    templeStyleData.Style = (byte) 10;
    templeStyleData.BrickTileType = (ushort) 226;
    templeStyleData.BrickCrackedTileType = (ushort) 123;
    templeStyleData.BrickWallType = (ushort) 87;
    templeStyleData.WindowGlassWallType = (ushort) 92;
    templeStyleData.WindowClosedGlassWallType = (ushort) 42;
    templeStyleData.WindowEdgeWallType = (ushort) 24;
    templeStyleData.WindowPlatformItemTypes = new int[1]
    {
      3906
    };
    templeStyleData.PitTrapTileType = (ushort) 123;
    templeStyleData.LockedBiomeChestType = -1;
    templeStyleData.LockedBiomeChestStyle = -1;
    templeStyleData.BiomeChestItemType = -1;
    templeStyleData.BiomeChestLootItemType = -1;
    templeStyleData.ChestItemTypes = new int[1]{ 1142 };
    templeStyleData.DoorItemTypes = new int[1]{ 1137 };
    templeStyleData.PlatformItemTypes = new int[1]{ 3906 };
    templeStyleData.ChandelierItemTypes = new int[1]{ 2062 };
    templeStyleData.LanternItemTypes = new int[1]{ 2041 };
    templeStyleData.TableItemTypes = new int[1]{ 1144 };
    templeStyleData.WorkbenchItemTypes = new int[1]{ 1145 };
    templeStyleData.CandleItemTypes = new int[1]{ 2052 };
    templeStyleData.VaseOrStatueItemTypes = new int[3]
    {
      1152,
      1153,
      1154
    };
    templeStyleData.BookcaseItemTypes = new int[1]{ 2030 };
    templeStyleData.ChairItemTypes = new int[1]{ 1143 };
    templeStyleData.BedItemTypes = new int[1]{ 2069 };
    templeStyleData.PianoItemTypes = new int[1]{ 2385 };
    templeStyleData.DresserItemTypes = new int[1]{ 2396 };
    templeStyleData.SofaItemTypes = new int[1]{ 2416 };
    templeStyleData.BathtubItemTypes = new int[1]{ 2079 };
    templeStyleData.LampItemTypes = new int[1]{ 2089 };
    templeStyleData.CandelabraItemTypes = new int[1]{ 2101 };
    templeStyleData.ClockItemTypes = new int[1]{ 2595 };
    templeStyleData.BannerItemTypes = (int[]) null;
    templeStyleData.EdgeDither = false;
    templeStyleData.BiomeRoomType = DungeonRoomType.BiomeStructured;
    DungeonGenerationStyles.Temple = (DungeonGenerationStyleData) templeStyleData;
  }

  private class ShimmerStyleData : DungeonGenerationStyleData
  {
    public override bool CanGenerateFeatureAt(
      DungeonData data,
      DungeonRoom room,
      IDungeonFeature feature,
      int x,
      int y)
    {
      return !(feature is DungeonPitTrap) && !(feature is DungeonWindow);
    }
  }

  private class LivingWoodStyleData : DungeonGenerationStyleData
  {
    public override bool CanGenerateFeatureAt(
      DungeonData data,
      DungeonRoom room,
      IDungeonFeature feature,
      int x,
      int y)
    {
      return !(feature is DungeonGlobalSpikes) && !(feature is DungeonPitTrap);
    }

    public override void GetBookshelfMinMaxSizes(
      int defaultMin,
      int defaultMax,
      out int min,
      out int max)
    {
      min = 3;
      max = 7;
    }
  }

  private class BeehiveStyleData : DungeonGenerationStyleData
  {
    public override bool CanGenerateFeatureAt(
      DungeonData data,
      DungeonRoom room,
      IDungeonFeature feature,
      int x,
      int y)
    {
      switch (feature)
      {
        case DungeonGlobalPaintings _:
        case DungeonGlobalSpikes _:
        case DungeonPitTrap _:
          return false;
        default:
          return !(feature is DungeonWindow);
      }
    }
  }

  private class TempleStyleData : DungeonGenerationStyleData
  {
    public override bool CanGenerateFeatureAt(
      DungeonData data,
      DungeonRoom room,
      IDungeonFeature feature,
      int x,
      int y)
    {
      return !(feature is DungeonPitTrap) && !(feature is DungeonPillar);
    }
  }
}
