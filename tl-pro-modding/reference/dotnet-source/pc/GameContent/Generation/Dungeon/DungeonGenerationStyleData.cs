// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.DungeonGenerationStyleData
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;
using Terraria.GameContent.Generation.Dungeon.Features;
using Terraria.GameContent.Generation.Dungeon.Rooms;
using Terraria.ID;
using Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon;

public class DungeonGenerationStyleData
{
  public byte Style;
  public int UnbreakableWallProgressionTier = -1;
  public ushort BrickTileType;
  public ushort? BrickGrassTileType;
  public ushort BrickCrackedTileType;
  public ushort BrickWallType;
  public ushort WindowGlassWallType;
  public ushort WindowClosedGlassWallType;
  public ushort WindowEdgeWallType;
  public int[] WindowPlatformItemTypes;
  public ushort PitTrapTileType;
  public int LiquidType = -1;
  public int LockedBiomeChestType;
  public int LockedBiomeChestStyle;
  public int BiomeChestItemType;
  public int BiomeChestLootItemType;
  public int[] ChestItemTypes;
  public int[] DoorItemTypes;
  public int[] PlatformItemTypes;
  public int[] ChandelierItemTypes;
  public int[] LanternItemTypes;
  public int[] TableItemTypes;
  public int[] WorkbenchItemTypes;
  public int[] CandleItemTypes;
  public int[] VaseOrStatueItemTypes;
  public int[] BookcaseItemTypes;
  public int[] ChairItemTypes;
  public int[] BedItemTypes;
  public int[] PianoItemTypes;
  public int[] DresserItemTypes;
  public int[] SofaItemTypes;
  public int[] BathtubItemTypes;
  public int[] LampItemTypes;
  public int[] CandelabraItemTypes;
  public int[] ClockItemTypes;
  public int[] BannerItemTypes;
  public bool EdgeDither;
  public DungeonRoomType BiomeRoomType;
  public List<DungeonGenerationStyleData> SubStyles;

  public virtual bool CanGenerateFeatureAt(
    DungeonData data,
    DungeonRoom room,
    IDungeonFeature feature,
    int x,
    int y)
  {
    return true;
  }

  public virtual void GetBookshelfMinMaxSizes(
    int defaultMin,
    int defaultMax,
    out int min,
    out int max)
  {
    min = defaultMin;
    max = defaultMax;
  }

  public bool TileIsInStyle(int tileType, bool includeCracked = true)
  {
    return this.BrickGrassTileType.HasValue && tileType == (int) this.BrickGrassTileType.Value || includeCracked && tileType == (int) this.BrickCrackedTileType || tileType == (int) this.BrickTileType;
  }

  public bool WallIsInStyle(int wallType, bool includeWindows = false)
  {
    return includeWindows && (wallType == (int) this.WindowGlassWallType || wallType == (int) this.WindowEdgeWallType || wallType == (int) this.WindowClosedGlassWallType) || wallType == (int) this.BrickWallType;
  }

  public int GetPlatformStyle(UnifiedRandom genRand)
  {
    int index = this.PlatformItemTypes == null || this.PlatformItemTypes.Length == 0 ? -1 : this.PlatformItemTypes[genRand.Next(this.PlatformItemTypes.Length)];
    return index >= 0 ? (int) ItemID.Sets.DerivedPlacementDetails[index].tileStyle : -1;
  }

  public int GetWindowPlatformStyle(UnifiedRandom genRand)
  {
    int index = this.WindowPlatformItemTypes == null || this.WindowPlatformItemTypes.Length == 0 ? -1 : this.WindowPlatformItemTypes[genRand.Next(this.WindowPlatformItemTypes.Length)];
    return index >= 0 ? (int) ItemID.Sets.DerivedPlacementDetails[index].tileStyle : -1;
  }
}
