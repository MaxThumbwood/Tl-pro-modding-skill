// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.RGB.CommonConditions
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using ReLogic.Peripherals.RGB;
using System;

#nullable disable
namespace Terraria.GameContent.RGB;

public static class CommonConditions
{
  public static readonly ChromaCondition InMenu = (ChromaCondition) new CommonConditions.SimpleCondition((Func<bool>) (() => Main.gameMenu && !Main.drunkWorld));
  public static readonly ChromaCondition DrunkMenu = (ChromaCondition) new CommonConditions.SimpleCondition((Func<bool>) (() => Main.gameMenu && Main.drunkWorld));

  private class SimpleCondition : ChromaCondition
  {
    private Func<bool> _condition;

    public SimpleCondition(Func<bool> condition) => this._condition = condition;

    public virtual bool IsActive() => this._condition();
  }

  private class SceneCondition(Func<SceneMetrics, bool> condition) : CommonConditions.SimpleCondition((Func<bool>) (() => condition(Main.SceneMetrics)))
  {
  }

  private class PlayerCondition(Func<Player, bool> condition) : CommonConditions.SimpleCondition((Func<bool>) (() => condition(Main.LocalPlayer)))
  {
  }

  public static class SurfaceBiome
  {
    public static readonly ChromaCondition Ocean = (ChromaCondition) new CommonConditions.SurfaceBiome.SurfaceCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneBeach));
    public static readonly ChromaCondition Desert = (ChromaCondition) new CommonConditions.SurfaceBiome.SurfaceCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneDesert));
    public static readonly ChromaCondition Jungle = (ChromaCondition) new CommonConditions.SurfaceBiome.SurfaceCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneJungle));
    public static readonly ChromaCondition Snow = (ChromaCondition) new CommonConditions.SurfaceBiome.SurfaceCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneSnow));
    public static readonly ChromaCondition Mushroom = (ChromaCondition) new CommonConditions.SurfaceBiome.SurfaceCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneGlowshroom));
    public static readonly ChromaCondition Corruption = (ChromaCondition) new CommonConditions.SurfaceBiome.SurfaceCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneCorrupt));
    public static readonly ChromaCondition Hallow = (ChromaCondition) new CommonConditions.SurfaceBiome.SurfaceCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneHallow));
    public static readonly ChromaCondition Crimson = (ChromaCondition) new CommonConditions.SurfaceBiome.SurfaceCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneCrimson));

    private class SurfaceCondition(Func<SceneMetrics, bool> condition) : 
      CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneOverworldHeight && condition(scene)))
    {
    }
  }

  public static class MiscBiome
  {
    public static readonly ChromaCondition Meteorite = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneMeteor));
  }

  public static class UndergroundBiome
  {
    public static readonly ChromaCondition Hive = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneHive));
    public static readonly ChromaCondition Jungle = (ChromaCondition) new CommonConditions.UndergroundBiome.UndergroundCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneJungle));
    public static readonly ChromaCondition Mushroom = (ChromaCondition) new CommonConditions.UndergroundBiome.UndergroundCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneGlowshroom));
    public static readonly ChromaCondition Ice = (ChromaCondition) new CommonConditions.UndergroundBiome.UndergroundCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneSnow));
    public static readonly ChromaCondition HallowIce = (ChromaCondition) new CommonConditions.UndergroundBiome.UndergroundCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneSnow && scene.ZoneHallow));
    public static readonly ChromaCondition CrimsonIce = (ChromaCondition) new CommonConditions.UndergroundBiome.UndergroundCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneSnow && scene.ZoneCrimson));
    public static readonly ChromaCondition CorruptIce = (ChromaCondition) new CommonConditions.UndergroundBiome.UndergroundCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneSnow && scene.ZoneCorrupt));
    public static readonly ChromaCondition Hallow = (ChromaCondition) new CommonConditions.UndergroundBiome.UndergroundCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneHallow));
    public static readonly ChromaCondition Crimson = (ChromaCondition) new CommonConditions.UndergroundBiome.UndergroundCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneCrimson));
    public static readonly ChromaCondition Corrupt = (ChromaCondition) new CommonConditions.UndergroundBiome.UndergroundCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneCorrupt));
    public static readonly ChromaCondition Desert = (ChromaCondition) new CommonConditions.UndergroundBiome.UndergroundCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneDesert));
    public static readonly ChromaCondition HallowDesert = (ChromaCondition) new CommonConditions.UndergroundBiome.UndergroundCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneDesert && scene.ZoneHallow));
    public static readonly ChromaCondition CrimsonDesert = (ChromaCondition) new CommonConditions.UndergroundBiome.UndergroundCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneDesert && scene.ZoneCrimson));
    public static readonly ChromaCondition CorruptDesert = (ChromaCondition) new CommonConditions.UndergroundBiome.UndergroundCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneDesert && scene.ZoneCorrupt));
    public static readonly ChromaCondition Temple = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneLihzhardTemple));
    public static readonly ChromaCondition Dungeon = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneDungeon));
    public static readonly ChromaCondition Marble = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneMarble));
    public static readonly ChromaCondition Granite = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneGranite));
    public static readonly ChromaCondition GemCave = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneGemCave));
    public static readonly ChromaCondition Shimmer = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneShimmer));

    private class UndergroundCondition(Func<SceneMetrics, bool> condition) : 
      CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (scene => !scene.ZoneOverworldHeight && condition(scene)))
    {
    }
  }

  public static class Boss
  {
    public static int HighestTierBossOrEvent;
    public static readonly ChromaCondition EaterOfWorlds = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (_ => CommonConditions.Boss.HighestTierBossOrEvent == 13));
    public static readonly ChromaCondition Destroyer = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (_ => CommonConditions.Boss.HighestTierBossOrEvent == 134));
    public static readonly ChromaCondition KingSlime = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (_ => CommonConditions.Boss.HighestTierBossOrEvent == 50));
    public static readonly ChromaCondition QueenSlime = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (_ => CommonConditions.Boss.HighestTierBossOrEvent == 657));
    public static readonly ChromaCondition BrainOfCthulhu = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (_ => CommonConditions.Boss.HighestTierBossOrEvent == 266));
    public static readonly ChromaCondition DukeFishron = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (_ => CommonConditions.Boss.HighestTierBossOrEvent == 370));
    public static readonly ChromaCondition QueenBee = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (_ => CommonConditions.Boss.HighestTierBossOrEvent == 222));
    public static readonly ChromaCondition Plantera = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (_ => CommonConditions.Boss.HighestTierBossOrEvent == 262));
    public static readonly ChromaCondition Empress = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (_ => CommonConditions.Boss.HighestTierBossOrEvent == 636));
    public static readonly ChromaCondition EyeOfCthulhu = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (_ => CommonConditions.Boss.HighestTierBossOrEvent == 4));
    public static readonly ChromaCondition TheTwins = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (_ => CommonConditions.Boss.HighestTierBossOrEvent == 126));
    public static readonly ChromaCondition MoonLord = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (_ => CommonConditions.Boss.HighestTierBossOrEvent == 398));
    public static readonly ChromaCondition WallOfFlesh = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (_ => CommonConditions.Boss.HighestTierBossOrEvent == 113));
    public static readonly ChromaCondition Golem = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (_ => CommonConditions.Boss.HighestTierBossOrEvent == 245));
    public static readonly ChromaCondition Cultist = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (_ => CommonConditions.Boss.HighestTierBossOrEvent == 439));
    public static readonly ChromaCondition Skeletron = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (_ => CommonConditions.Boss.HighestTierBossOrEvent == 35));
    public static readonly ChromaCondition SkeletronPrime = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (_ => CommonConditions.Boss.HighestTierBossOrEvent == (int) sbyte.MaxValue));
    public static readonly ChromaCondition Deerclops = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (_ => CommonConditions.Boss.HighestTierBossOrEvent == 668));
  }

  public static class Weather
  {
    public static readonly ChromaCondition Rain = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneRain && !scene.ZoneSnow));
    public static readonly ChromaCondition Sandstorm = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneSandstorm));
    public static readonly ChromaCondition Blizzard = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneSnow && scene.ZoneRain));
    public static readonly ChromaCondition SlimeRain = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (scene => Main.slimeRain && scene.ZoneOverworldHeight));
  }

  public static class Depth
  {
    public static readonly ChromaCondition Sky = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneSkyHeight));
    public static readonly ChromaCondition Surface = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneOverworldHeight && !CommonConditions.Depth.IsInFrontOfDirtWall(scene.TileCenter)));
    public static readonly ChromaCondition Vines = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneOverworldHeight && CommonConditions.Depth.IsInFrontOfDirtWall(scene.TileCenter)));
    public static readonly ChromaCondition Underground = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneDirtLayerHeight));
    public static readonly ChromaCondition Caverns = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneRockLayerHeight && scene.TileCenter.Y <= Main.maxTilesY - 400));
    public static readonly ChromaCondition Magma = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneRockLayerHeight && scene.TileCenter.Y > Main.maxTilesY - 400));
    public static readonly ChromaCondition Underworld = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (scene => scene.ZoneUnderworldHeight));

    private static bool IsInFrontOfDirtWall(Point tilePosition)
    {
      if (!WorldGen.InWorld(tilePosition.X, tilePosition.Y) || Main.tile[tilePosition.X, tilePosition.Y] == null)
        return false;
      switch (Main.tile[tilePosition.X, tilePosition.Y].wall)
      {
        case 2:
        case 16 /*0x10*/:
        case 54:
        case 55:
        case 56:
        case 57:
        case 58:
        case 59:
        case 61:
        case 170:
        case 171:
        case 185:
        case 196:
        case 197:
        case 198:
        case 199:
        case 212:
        case 213:
        case 214:
        case 215:
          return true;
        default:
          return false;
      }
    }
  }

  public static class Events
  {
    public static readonly ChromaCondition BloodMoon = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (_ => Main.bloodMoon && !Main.snowMoon && !Main.pumpkinMoon));
    public static readonly ChromaCondition FrostMoon = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (_ => Main.snowMoon));
    public static readonly ChromaCondition PumpkinMoon = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (_ => Main.pumpkinMoon));
    public static readonly ChromaCondition SolarEclipse = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (_ => Main.eclipse));
    public static readonly ChromaCondition SolarPillar = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (scene => scene.CloseEnoughToSolarTower));
    public static readonly ChromaCondition NebulaPillar = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (scene => scene.CloseEnoughToNebulaTower));
    public static readonly ChromaCondition VortexPillar = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (scene => scene.CloseEnoughToVortexTower));
    public static readonly ChromaCondition StardustPillar = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (scene => scene.CloseEnoughToStardustTower));
    public static readonly ChromaCondition PirateInvasion = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (_ => CommonConditions.Boss.HighestTierBossOrEvent == -3));
    public static readonly ChromaCondition DD2Event = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (_ => CommonConditions.Boss.HighestTierBossOrEvent == -6));
    public static readonly ChromaCondition FrostLegion = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (_ => CommonConditions.Boss.HighestTierBossOrEvent == -2));
    public static readonly ChromaCondition MartianMadness = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (_ => CommonConditions.Boss.HighestTierBossOrEvent == -4));
    public static readonly ChromaCondition GoblinArmy = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (_ => CommonConditions.Boss.HighestTierBossOrEvent == -1));
  }

  public static class Alert
  {
    public static readonly ChromaCondition MoonlordComing = (ChromaCondition) new CommonConditions.SceneCondition((Func<SceneMetrics, bool>) (_ => NPC.MoonLordCountdown > 0));
    public static readonly ChromaCondition Keybinds = (ChromaCondition) new CommonConditions.SimpleCondition((Func<bool>) (() => Main.InGameUI.CurrentState == Main.ManageControlsMenu || Main.MenuUI.CurrentState == Main.ManageControlsMenu));
    public static readonly ChromaCondition Drowning = (ChromaCondition) new CommonConditions.PlayerCondition((Func<Player, bool>) (player => player.breath != player.breathMax));
    public static readonly ChromaCondition LavaIndicator = (ChromaCondition) new CommonConditions.PlayerCondition((Func<Player, bool>) (player => player.lavaWet));
  }

  public static class CriticalAlert
  {
    public static readonly ChromaCondition LowLife = (ChromaCondition) new CommonConditions.PlayerCondition((Func<Player, bool>) (player => Main.ChromaPainter.PotionAlert));
    public static readonly ChromaCondition Death = (ChromaCondition) new CommonConditions.PlayerCondition((Func<Player, bool>) (player => player.dead));
  }
}
