// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.SpecialSeedFeatures
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent;

public class SpecialSeedFeatures
{
  public static bool ShouldDropExtraGel
  {
    get
    {
      return Main.tenthAnniversaryWorld && Main.drunkWorld && !Main.remixWorld && !Main.notTheBeesWorld;
    }
  }

  public static bool ShouldDropExtraWood
  {
    get
    {
      return Main.tenthAnniversaryWorld && Main.drunkWorld && !Main.remixWorld && !Main.notTheBeesWorld;
    }
  }

  public static bool DungeonEntranceHasATree
  {
    get => Main.drunkWorld && !SpecialSeedFeatures.NoDungeonGuardian;
  }

  public static bool DungeonEntranceHasStairs
  {
    get
    {
      return !SpecialSeedFeatures.DungeonEntranceIsUnderground && !WorldGen.SecretSeed.roundLandmasses.Enabled;
    }
  }

  public static bool DungeonEntranceIsBuried
  {
    get
    {
      return WorldGen.SecretSeed.surfaceIsDesert.Enabled && !SpecialSeedFeatures.DungeonEntranceIsUnderground;
    }
  }

  public static bool DungeonEntranceIsUnderground
  {
    get => Main.drunkWorld || WorldGen.SecretSeed.noSurface.Enabled;
  }

  public static bool NoDungeonGuardian => Main.onlyShimmerOceanWorlds;

  public static bool BossesKeepSpawning
  {
    get => Main.getGoodWorld && Main.dontStarveWorld && !Main.tenthAnniversaryWorld;
  }

  public static bool ShimmerSpawnHalfOfWorld => Main.onlyShimmerOceanWorlds;

  public static bool RainbowSandAndBlackSandWalls => Main.onlyShimmerOceanWorlds;

  public static bool SpawnOnBeach
  {
    get => Main.tenthAnniversaryWorld && !Main.remixWorld && !Main.dontStarveWorld;
  }

  public static bool SpawnOnBeachOnDungeonSide
  {
    get => SpecialSeedFeatures.SpawnOnBeach && Main.onlyShimmerOceanWorlds;
  }

  public static bool Mechdusa => Main.remixWorld && Main.getGoodWorld;
}
