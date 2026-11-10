// Decompiled with JetBrains decompiler
// Type: Terraria.SceneMetrics
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;
using Terraria.GameContent;
using Terraria.GameContent.Events;
using Terraria.ID;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria;

public class SceneMetrics
{
  private static readonly Point AssumedConstantScreenSize = new Point(1920, 1200);
  private static readonly int ZoneScanPadding = 25;
  public static readonly Point ZoneScanSize = new Point(SceneMetrics.AssumedConstantScreenSize.X / 16 /*0x10*/ + SceneMetrics.ZoneScanPadding * 2 - 1, SceneMetrics.AssumedConstantScreenSize.Y / 16 /*0x10*/ + SceneMetrics.ZoneScanPadding * 2 - 1);
  public static readonly Vector2 TownNPCRectSize = SceneMetrics.AssumedConstantScreenSize.ToVector2() * 2f;
  private int _bestOreDistSq;
  public int BestOreType;
  public static int ShimmerTileThreshold = 300;
  public static int CorruptionTileThreshold = 300;
  public static int CorruptionTileMax = 1000;
  public static int CrimsonTileThreshold = 300;
  public static int CrimsonTileMax = 1000;
  public static int HallowTileThreshold = 125;
  public static int HallowTileMax = 600;
  public static int JungleTileThreshold = 140;
  public static int JungleTileMax = 700;
  public static int SnowTileNormalThreshold = 1500;
  public static int SnowTileSkyblockThreshold = 300;
  public static int SnowTileMax = 6000;
  public static int DesertTileNormalThreshold = 1500;
  public static int DesertTileSkyblockThreshold = 300;
  public static int MushroomTileThreshold = 100;
  public static int MushroomTileMax = 160 /*0xA0*/;
  public static int MeteorTileThreshold = 75;
  public static int DungeonTileThreshold = 250;
  public static int GraveyardTileMax = 36;
  public static int GraveyardTileMin = 16 /*0x10*/;
  public static int GraveyardTileThreshold = 28;
  public bool BelowSurface;
  public bool ZoneSkyHeight;
  public bool ZoneOverworldHeight;
  public bool ZoneDirtLayerHeight;
  public bool ZoneRockLayerHeight;
  public bool ZoneUnderworldHeight;
  public bool ZoneCorrupt;
  public bool ZoneCrimson;
  public bool ZoneHallow;
  public bool ZoneJungle;
  public bool ZoneSnow;
  public bool ZoneDesert;
  public bool ZoneGlowshroom;
  public bool ZoneMeteor;
  public bool ZoneGraveyard;
  public bool ZoneDungeon;
  public bool ZoneLihzhardTemple;
  public bool ZoneGranite;
  public bool ZoneMarble;
  public bool ZoneHive;
  public bool ZoneGemCave;
  public bool ZoneBeach;
  public bool ZoneUndergroundDesert;
  public bool ZoneRain;
  public bool ZoneSandstorm;
  public bool SurfaceAtmospherics;
  public bool UndergroundForShimmering;
  public bool ZoneShimmer;
  public bool ZoneWaterCandle;
  public bool ZonePeaceCandle;
  public bool ZoneShadowCandle;
  public bool InTorchGodMinigame;
  public static int NPCEventZoneRadius = 4000;
  public bool CanPlayCreditsRoll;
  public bool[] NPCBannerBuff = new bool[BannerSystem.MaxBannerTypes];
  public bool hasBanner;
  public Vector2[] ClosestNPCPosition = new Vector2[(int) NPCID.Count];
  private static Player _dummyPlayer = new Player();
  private readonly int[] _tileCounts = new int[(int) TileID.Count];
  private readonly int[] _liquidCounts = new int[(int) LiquidID.Count];

  public uint LastScanTime { get; private set; }

  public Vector2 Center { get; private set; }

  public Point TileCenter { get; private set; }

  public Point BestOrePosition { get; private set; }

  public static int SnowTileThreshold
  {
    get
    {
      return WorldGen.Skyblock.lowTiles ? SceneMetrics.SnowTileSkyblockThreshold : SceneMetrics.SnowTileNormalThreshold;
    }
  }

  public static int DesertTileThreshold
  {
    get
    {
      return WorldGen.Skyblock.lowTiles ? SceneMetrics.DesertTileSkyblockThreshold : SceneMetrics.DesertTileNormalThreshold;
    }
  }

  public int ShimmerTileCount { get; set; }

  public int EvilTileCount { get; set; }

  public int HolyTileCount { get; set; }

  public int HoneyBlockCount { get; set; }

  public int ActiveMusicBox { get; set; }

  public int SandTileCount { get; private set; }

  public int MushroomTileCount { get; private set; }

  public int SnowTileCount { get; private set; }

  public int WaterCandleCount { get; private set; }

  public int PeaceCandleCount { get; private set; }

  public int ShadowCandleCount { get; private set; }

  public int PartyMonolithCount { get; private set; }

  public int MeteorTileCount { get; private set; }

  public int BloodTileCount { get; private set; }

  public int JungleTileCount { get; private set; }

  public int DungeonTileCount { get; private set; }

  public bool HasSunflower { get; private set; }

  public bool HasGardenGnome { get; private set; }

  public bool HasClock { get; private set; }

  public bool HasCampfire { get; private set; }

  public bool HasStarInBottle { get; private set; }

  public bool HasHeartLantern { get; private set; }

  public int ActiveFountainColor { get; private set; }

  public int ActiveMonolithType { get; private set; }

  public bool BloodMoonMonolith { get; private set; }

  public bool MoonLordMonolith { get; private set; }

  public bool EchoMonolith { get; private set; }

  public int ShimmerMonolithState { get; private set; }

  public bool CRTMonolith { get; private set; }

  public bool RetroMonolith { get; private set; }

  public bool NoirMonolith { get; private set; }

  public bool RadioThingMonolith { get; private set; }

  public bool HasCatBast { get; private set; }

  public int GraveyardTileCount { get; private set; }

  public int DesertSandTileCount { get; private set; }

  public int OceanSandTileCount { get; private set; }

  public bool EnoughTilesForShimmer => this.ShimmerTileCount >= SceneMetrics.ShimmerTileThreshold;

  public bool EnoughTilesForJungle => this.JungleTileCount >= SceneMetrics.JungleTileThreshold;

  public bool EnoughTilesForHallow => this.HolyTileCount >= SceneMetrics.HallowTileThreshold;

  public bool EnoughTilesForSnow => this.SnowTileCount >= SceneMetrics.SnowTileThreshold;

  public bool EnoughTilesForGlowingMushroom
  {
    get => this.MushroomTileCount >= SceneMetrics.MushroomTileThreshold;
  }

  public bool EnoughTilesForDesert => this.DesertSandTileCount >= SceneMetrics.DesertTileThreshold;

  public bool EnoughTilesForCorruption
  {
    get => this.EvilTileCount >= SceneMetrics.CorruptionTileThreshold;
  }

  public bool EnoughTilesForCrimson => this.BloodTileCount >= SceneMetrics.CrimsonTileThreshold;

  public bool EnoughTilesForMeteor => this.MeteorTileCount >= SceneMetrics.MeteorTileThreshold;

  public bool EnoughTilesForDungeon => this.DungeonTileCount >= SceneMetrics.DungeonTileThreshold;

  public bool EnoughTilesForGraveyard
  {
    get => this.GraveyardTileCount >= SceneMetrics.GraveyardTileThreshold;
  }

  public bool BehindBackwall { get; private set; }

  public bool CloseEnoughToSolarTower
  {
    get => this.WithinRangeOfNPC(517, (double) SceneMetrics.NPCEventZoneRadius);
  }

  public bool CloseEnoughToVortexTower
  {
    get => this.WithinRangeOfNPC(422, (double) SceneMetrics.NPCEventZoneRadius);
  }

  public bool CloseEnoughToNebulaTower
  {
    get => this.WithinRangeOfNPC(507, (double) SceneMetrics.NPCEventZoneRadius);
  }

  public bool CloseEnoughToStardustTower
  {
    get => this.WithinRangeOfNPC(493, (double) SceneMetrics.NPCEventZoneRadius);
  }

  public bool CloseEnoughToDD2LanePortal
  {
    get => this.WithinRangeOfNPC(549, (double) SceneMetrics.NPCEventZoneRadius);
  }

  public float? DistanceToMoonLord
  {
    get
    {
      Vector2 vector2 = this.ClosestNPCPosition[398];
      return vector2 == Vector2.Zero ? new float?() : new float?(Vector2.Distance(this.Center, vector2));
    }
  }

  public float? MoonLordSkyIntensity
  {
    get
    {
      float? distanceToMoonLord = Main.SceneMetrics.DistanceToMoonLord;
      return distanceToMoonLord.HasValue ? new float?(1f - Utils.SmoothStep(3000f, 6000f, distanceToMoonLord.Value)) : new float?();
    }
  }

  public bool AnyNPCs(int type) => this.ClosestNPCPosition[type] != Vector2.Zero;

  public int TownNPCCount { get; private set; }

  public Player PerspectivePlayer { get; private set; }

  public SceneMetrics() => this.Reset();

  public void Scan(SceneMetricsScanSettings settings)
  {
    if ((int) this.LastScanTime == (int) Main.GameUpdateCount && this.Center == settings.BiomeScanCenterPositionInWorld)
      return;
    this.Reset();
    this.LastScanTime = Main.GameUpdateCount;
    this.Center = settings.BiomeScanCenterPositionInWorld;
    this.TileCenter = this.Center.ToTileCoordinates().ClampedInWorld();
    this.ScanTiles();
    if (settings.VisualScanArea.HasValue)
      this.ScanOnScreenTiles(settings.VisualScanArea.Value);
    if (settings.ScanNPCPositions)
      this.ScanNPCPositions();
    this.AggregateTileCounts();
    this.CalculateZones();
    if (settings.PerspectivePlayer != null)
      this.AddPlayerEffects(settings.PerspectivePlayer);
    this.CanPlayCreditsRoll = this.ActiveMusicBox == 85;
  }

  private void ScanTiles()
  {
    Microsoft.Xna.Framework.Rectangle world = WorldUtils.ClampToWorld(Utils.CenteredRectangle(this.TileCenter, SceneMetrics.ZoneScanSize));
    for (int left = world.Left; left < world.Right; ++left)
    {
      for (int top = world.Top; top < world.Bottom; ++top)
      {
        Tile tile = Main.tile[left, top];
        if (tile != null)
        {
          if (!tile.active())
          {
            if (tile.liquid > (byte) 0)
              ++this._liquidCounts[(int) tile.liquidType()];
          }
          else
          {
            ++this._tileCounts[(int) tile.type];
            if (TileID.Sets.isDesertBiomeSand[(int) tile.type] && WorldGen.oceanDepths(left, top))
              ++this.OceanSandTileCount;
            if (TileID.Sets.Campfires[(int) tile.type] && tile.frameY < (short) 36)
              this.HasCampfire = true;
            if (tile.type == (ushort) 49 && tile.frameX < (short) 18)
              ++this.WaterCandleCount;
            if (tile.type == (ushort) 372 && tile.frameX < (short) 18)
              ++this.PeaceCandleCount;
            if (tile.type == (ushort) 646 && tile.frameX < (short) 18)
              ++this.ShadowCandleCount;
            if (tile.type == (ushort) 405 && tile.frameX < (short) 54)
              this.HasCampfire = true;
            if (tile.type == (ushort) 506 && tile.frameX < (short) 72)
              this.HasCatBast = true;
            if (tile.type == (ushort) 42 && tile.frameY >= (short) 324 && tile.frameY <= (short) 358)
              this.HasHeartLantern = true;
            if (tile.type == (ushort) 42 && tile.frameY >= (short) 252 && tile.frameY <= (short) 286)
              this.HasStarInBottle = true;
            if (tile.type == (ushort) 91)
            {
              int num = (int) tile.frameX / 18;
              for (short frameY = tile.frameY; frameY >= (short) 54; frameY -= (short) 54)
                num += 111;
              bool flag = false;
              if (tile.frameX < (short) 396 && tile.frameY < (short) 54 || num == 311 || num == 312)
                flag = true;
              if (!flag)
              {
                int banner = (int) tile.frameX / 18 - 21;
                for (int frameY = (int) tile.frameY; frameY >= 54; frameY -= 54)
                  banner = banner + 90 + 21;
                if (num >= 311)
                  --banner;
                if (num >= 312)
                  --banner;
                int index = BannerSystem.BannerToItem(banner);
                if (ItemID.Sets.BannerStrength.IndexInRange<ItemID.BannerEffect>(index) && ItemID.Sets.BannerStrength[index].Enabled)
                {
                  this.NPCBannerBuff[banner] = true;
                  this.hasBanner = true;
                }
              }
            }
            this.UpdateOreFinder(new Point(left, top), tile);
          }
        }
      }
    }
  }

  private void ScanOnScreenTiles(Microsoft.Xna.Framework.Rectangle visualScanArea)
  {
    visualScanArea = WorldUtils.ClampToWorld(visualScanArea);
    for (int left = visualScanArea.Left; left < visualScanArea.Right; ++left)
    {
      for (int top = visualScanArea.Top; top < visualScanArea.Bottom; ++top)
      {
        Tile tile = Main.tile[left, top];
        if (tile != null && tile.active())
        {
          if (tile.type == (ushort) 104)
            this.HasClock = true;
          switch (tile.type)
          {
            case 139:
              if (tile.frameX >= (short) 36)
              {
                this.ActiveMusicBox = (int) tile.frameY / 36;
                continue;
              }
              continue;
            case 207:
              if (tile.frameY >= (short) 72)
              {
                switch ((int) tile.frameX / 36)
                {
                  case 0:
                    this.ActiveFountainColor = 0;
                    continue;
                  case 1:
                    this.ActiveFountainColor = 12;
                    continue;
                  case 2:
                    this.ActiveFountainColor = 3;
                    continue;
                  case 3:
                    this.ActiveFountainColor = 5;
                    continue;
                  case 4:
                    this.ActiveFountainColor = 2;
                    continue;
                  case 5:
                    this.ActiveFountainColor = 10;
                    continue;
                  case 6:
                    this.ActiveFountainColor = 4;
                    continue;
                  case 7:
                    this.ActiveFountainColor = 9;
                    continue;
                  case 8:
                    this.ActiveFountainColor = 8;
                    continue;
                  case 9:
                    this.ActiveFountainColor = 6;
                    continue;
                  default:
                    this.ActiveFountainColor = -1;
                    continue;
                }
              }
              else
                continue;
            case 410:
              if (tile.frameY >= (short) 56)
              {
                this.ActiveMonolithType = (int) tile.frameX / 36;
                continue;
              }
              continue;
            case 480:
              if (tile.frameY >= (short) 54)
              {
                this.BloodMoonMonolith = true;
                continue;
              }
              continue;
            case 509:
              if (tile.frameY >= (short) 56)
              {
                this.ActiveMonolithType = 4;
                continue;
              }
              continue;
            case 657:
              if (tile.frameY >= (short) 54)
              {
                this.EchoMonolith = true;
                continue;
              }
              continue;
            case 658:
              this.ShimmerMonolithState = (int) tile.frameY / 54;
              continue;
            case 720:
              if (tile.frameY >= (short) 54)
              {
                this.CRTMonolith = true;
                continue;
              }
              continue;
            case 721:
              if (tile.frameY >= (short) 54)
              {
                this.RetroMonolith = true;
                continue;
              }
              continue;
            case 725:
              if (tile.frameY >= (short) 54)
              {
                this.NoirMonolith = true;
                continue;
              }
              continue;
            case 733:
              if (tile.frameY >= (short) 54)
              {
                this.RadioThingMonolith = true;
                continue;
              }
              continue;
            default:
              continue;
          }
        }
      }
    }
  }

  private void AggregateTileCounts()
  {
    int num = -10;
    if (Main.infectedSeed)
      num *= 3;
    if (this._tileCounts[27] > 0)
      this.HasSunflower = true;
    if (this._tileCounts[567] > 0)
      this.HasGardenGnome = true;
    this.ShimmerTileCount = this._liquidCounts[3];
    this.HoneyBlockCount = this._tileCounts[229];
    this.HolyTileCount = this._tileCounts[109] + this._tileCounts[492] + this._tileCounts[110] + this._tileCounts[113] + this._tileCounts[117] + this._tileCounts[116] + this._tileCounts[164] + this._tileCounts[403] + this._tileCounts[402];
    this.SnowTileCount = this._tileCounts[147] + this._tileCounts[148] + this._tileCounts[161] + this._tileCounts[162] + this._tileCounts[164] + this._tileCounts[163] + this._tileCounts[200];
    if (Main.remixWorld)
    {
      this.JungleTileCount = this._tileCounts[60] + this._tileCounts[61] + this._tileCounts[62] + this._tileCounts[74] + this._tileCounts[225];
      this.EvilTileCount = this._tileCounts[23] + this._tileCounts[661] + this._tileCounts[24] + this._tileCounts[25] + this._tileCounts[32 /*0x20*/] + this._tileCounts[112 /*0x70*/] + this._tileCounts[163] + this._tileCounts[400] + this._tileCounts[398] + this._tileCounts[27] * num + this._tileCounts[474];
      this.BloodTileCount = this._tileCounts[199] + this._tileCounts[662] + this._tileCounts[201] + this._tileCounts[203] + this._tileCounts[200] + this._tileCounts[401] + this._tileCounts[399] + this._tileCounts[234] + this._tileCounts[352] + this._tileCounts[27] * num + this._tileCounts[195];
    }
    else
    {
      this.JungleTileCount = this._tileCounts[60] + this._tileCounts[61] + this._tileCounts[62] + this._tileCounts[74] + this._tileCounts[226] + this._tileCounts[225];
      this.EvilTileCount = this._tileCounts[23] + this._tileCounts[661] + this._tileCounts[24] + this._tileCounts[25] + this._tileCounts[32 /*0x20*/] + this._tileCounts[112 /*0x70*/] + this._tileCounts[163] + this._tileCounts[400] + this._tileCounts[398] + this._tileCounts[27] * num;
      this.BloodTileCount = this._tileCounts[199] + this._tileCounts[662] + this._tileCounts[201] + this._tileCounts[203] + this._tileCounts[200] + this._tileCounts[401] + this._tileCounts[399] + this._tileCounts[234] + this._tileCounts[352] + this._tileCounts[27] * num;
    }
    this.MushroomTileCount = this._tileCounts[70] + this._tileCounts[71] + this._tileCounts[72] + this._tileCounts[528];
    this.MeteorTileCount = this._tileCounts[37];
    this.DungeonTileCount = this._tileCounts[41] + this._tileCounts[43] + this._tileCounts[44] + this._tileCounts[481] + this._tileCounts[482] + this._tileCounts[483];
    this.SandTileCount = this._tileCounts[53] + this._tileCounts[112 /*0x70*/] + this._tileCounts[116] + this._tileCounts[234] + this._tileCounts[397] + this._tileCounts[398] + this._tileCounts[402] + this._tileCounts[399] + this._tileCounts[396] + this._tileCounts[400] + this._tileCounts[403] + this._tileCounts[401];
    this.PartyMonolithCount = this._tileCounts[455];
    this.GraveyardTileCount = this._tileCounts[85];
    this.GraveyardTileCount -= this._tileCounts[27] / 2;
    if (this._tileCounts[27] > 0)
      this.HasSunflower = true;
    if (this.GraveyardTileCount > SceneMetrics.GraveyardTileMin)
      this.HasSunflower = false;
    if (this.GraveyardTileCount < 0)
      this.GraveyardTileCount = 0;
    if (this.HolyTileCount < 0)
      this.HolyTileCount = 0;
    if (this.EvilTileCount < 0)
      this.EvilTileCount = 0;
    if (this.BloodTileCount < 0)
      this.BloodTileCount = 0;
    int holyTileCount = this.HolyTileCount;
    this.HolyTileCount -= this.EvilTileCount;
    this.HolyTileCount -= this.BloodTileCount;
    this.EvilTileCount -= holyTileCount;
    this.BloodTileCount -= holyTileCount;
    if (this.HolyTileCount < 0)
      this.HolyTileCount = 0;
    if (this.EvilTileCount < 0)
      this.EvilTileCount = 0;
    if (this.BloodTileCount < 0)
      this.BloodTileCount = 0;
    this.DesertSandTileCount = Math.Max(0, this.SandTileCount - this.OceanSandTileCount);
  }

  private void CalculateZones()
  {
    Tile tileSafely1 = Framing.GetTileSafely(this.TileCenter);
    this.BehindBackwall = tileSafely1.wall > (ushort) 0;
    this.ZoneSkyHeight = (double) this.TileCenter.Y <= Main.worldSurface * 0.34999999403953552;
    this.ZoneOverworldHeight = (double) this.TileCenter.Y <= Main.worldSurface && (double) this.TileCenter.Y > Main.worldSurface * 0.34999999403953552;
    this.BelowSurface = (double) this.TileCenter.Y > Main.worldSurface;
    this.ZoneDirtLayerHeight = (double) this.TileCenter.Y <= Main.rockLayer && (double) this.TileCenter.Y > Main.worldSurface;
    this.ZoneRockLayerHeight = this.TileCenter.Y <= Main.UnderworldLayer && (double) this.TileCenter.Y > Main.rockLayer;
    this.ZoneUnderworldHeight = this.TileCenter.Y > Main.UnderworldLayer;
    this.ZoneCorrupt = this.EnoughTilesForCorruption;
    this.ZoneCrimson = this.EnoughTilesForCrimson;
    this.ZoneHallow = this.EnoughTilesForHallow;
    this.ZoneJungle = this.EnoughTilesForJungle && !this.ZoneUnderworldHeight;
    this.ZoneSnow = this.EnoughTilesForSnow;
    this.ZoneDesert = this.EnoughTilesForDesert;
    this.ZoneGlowshroom = this.EnoughTilesForGlowingMushroom;
    this.ZoneMeteor = this.EnoughTilesForMeteor;
    this.ZoneGraveyard = this.EnoughTilesForGraveyard;
    this.ZoneDungeon = this.EnoughTilesForDungeon && this.BelowSurface && Main.wallDungeon[(int) tileSafely1.wall];
    this.ZoneLihzhardTemple = tileSafely1.wall == (ushort) 87;
    this.ZoneGranite = tileSafely1.wall == (ushort) 184 || tileSafely1.wall == (ushort) 180;
    this.ZoneMarble = tileSafely1.wall == (ushort) 183 || tileSafely1.wall == (ushort) 178;
    this.ZoneHive = tileSafely1.wall == (ushort) 108 || tileSafely1.wall == (ushort) 86;
    this.ZoneGemCave = tileSafely1.wall >= (ushort) 48 /*0x30*/ && tileSafely1.wall <= (ushort) 53;
    this.ZoneBeach = WorldGen.oceanDepths(this.TileCenter.X, this.TileCenter.Y);
    this.ZoneUndergroundDesert = this.ZoneDesert && this.BelowSurface && (WallID.Sets.Conversion.Sandstone[(int) tileSafely1.wall] || WallID.Sets.Conversion.HardenedSand[(int) tileSafely1.wall] || tileSafely1.wall == (ushort) 223) && !Main.wallHouse[(int) tileSafely1.wall];
    this.SurfaceAtmospherics = WorldGen.IsSurfaceForAtmospherics(this.TileCenter);
    if (Main.remixWorld && this.ZoneDungeon)
      this.SurfaceAtmospherics = false;
    this.ZoneRain = Main.raining && this.SurfaceAtmospherics;
    this.ZoneSandstorm = this.ZoneDesert && this.SurfaceAtmospherics && Sandstorm.Happening;
    if (this.ZoneSandstorm)
      this.ZoneRain = false;
    this.UndergroundForShimmering = (double) this.TileCenter.Y > Main.worldSurface + 84.0 && this.TileCenter.Y < Main.maxTilesY - 396;
    this.ZoneShimmer = this.EnoughTilesForShimmer && this.UndergroundForShimmering && !this.ZoneDungeon;
    this.ZoneWaterCandle = this.WaterCandleCount > 0;
    this.ZonePeaceCandle = this.PeaceCandleCount > 0;
    this.ZoneShadowCandle = this.ShadowCandleCount > 0;
    if (!Main.dualDungeonsSeed || !this.BelowSurface || this.ZoneUnderworldHeight)
      return;
    NPCSpawningFlagsForDualDungeons flagsForDualDungeons = new NPCSpawningFlagsForDualDungeons();
    Point pt = new Point(this.TileCenter.X, this.TileCenter.Y);
    int spawnTileType = 0;
    int spawnWallType = 0;
    for (int index = 0; index < 300; ++index)
    {
      Tile tileSafely2 = Framing.GetTileSafely(pt);
      if (flagsForDualDungeons.CanScan(tileSafely2) && flagsForDualDungeons.ScanZonesFor(true, pt.X, pt.Y, (int) tileSafely2.type, (int) tileSafely2.wall, true))
      {
        Tile tileSafely3 = Framing.GetTileSafely(new Point(pt.X, pt.Y - 1));
        spawnTileType = (int) tileSafely2.type;
        spawnWallType = (int) tileSafely3.wall;
        break;
      }
      ++pt.Y;
    }
    flagsForDualDungeons.ScanZonesFor(false, pt.X, pt.Y, spawnTileType, spawnWallType, true);
    this.ZoneDungeon = flagsForDualDungeons.ZoneDungeon;
    this.ZoneSnow = flagsForDualDungeons.ZoneSnow;
    this.ZoneGlowshroom = flagsForDualDungeons.ZoneGlowshroom;
    this.ZoneCorrupt = flagsForDualDungeons.ZoneCorrupt;
    this.ZoneCrimson = flagsForDualDungeons.ZoneCrimson;
    this.ZoneJungle = flagsForDualDungeons.ZoneJungle;
    this.ZoneHallow = flagsForDualDungeons.ZoneHallow;
    this.ZoneLihzhardTemple = flagsForDualDungeons.ZoneLihzhardTemple;
    this.ZoneUndergroundDesert = flagsForDualDungeons.ZoneUndergroundDesert;
  }

  private void ScanNPCPositions()
  {
    for (int index = 0; index < Main.maxNPCs; ++index)
    {
      NPC npc = Main.npc[index];
      if (npc.active)
      {
        Vector2 vector2 = this.ClosestNPCPosition[npc.type];
        if (vector2 == Vector2.Zero || (double) Vector2.DistanceSquared(this.Center, npc.Center) < (double) Vector2.DistanceSquared(this.Center, vector2))
          this.ClosestNPCPosition[npc.type] = npc.Center;
        if (npc.townNPC && Utils.CenteredRectangle(this.Center, SceneMetrics.TownNPCRectSize).Contains(npc.Center.ToPoint()))
          ++this.TownNPCCount;
      }
    }
  }

  private void AddPlayerEffects(Player player)
  {
    this.PerspectivePlayer = player;
    if (player.inventory[player.selectedItem].type == 148)
      this.ZoneWaterCandle = true;
    if (player.inventory[player.selectedItem].type == 3117)
      this.ZonePeaceCandle = true;
    if (player.inventory[player.selectedItem].type == 5322)
      this.ZoneShadowCandle = true;
    if (player.musicBox >= 0)
      this.ActiveMusicBox = player.musicBox;
    if (!player.happyFunTorchTime)
      return;
    this.InTorchGodMinigame = true;
  }

  public int GetTileCount(ushort tileId) => this._tileCounts[(int) tileId];

  public void Reset()
  {
    this.LastScanTime = uint.MaxValue;
    Array.Clear((Array) this._tileCounts, 0, this._tileCounts.Length);
    Array.Clear((Array) this._liquidCounts, 0, this._liquidCounts.Length);
    Array.Clear((Array) this.ClosestNPCPosition, 0, this.ClosestNPCPosition.Length);
    this.SandTileCount = 0;
    this.EvilTileCount = 0;
    this.BloodTileCount = 0;
    this.GraveyardTileCount = 0;
    this.DesertSandTileCount = 0;
    this.MushroomTileCount = 0;
    this.SnowTileCount = 0;
    this.HolyTileCount = 0;
    this.HoneyBlockCount = 0;
    this.ShimmerTileCount = 0;
    this.MeteorTileCount = 0;
    this.JungleTileCount = 0;
    this.DungeonTileCount = 0;
    this.OceanSandTileCount = 0;
    this.HasCampfire = false;
    this.HasSunflower = false;
    this.HasGardenGnome = false;
    this.HasStarInBottle = false;
    this.HasHeartLantern = false;
    this.HasClock = false;
    this.HasCatBast = false;
    this.ActiveMusicBox = -1;
    this.WaterCandleCount = 0;
    this.PeaceCandleCount = 0;
    this.ShadowCandleCount = 0;
    this.ActiveFountainColor = -1;
    this.ActiveMonolithType = -1;
    this.PartyMonolithCount = 0;
    this.BloodMoonMonolith = false;
    this.MoonLordMonolith = false;
    this.EchoMonolith = false;
    this.ShimmerMonolithState = 0;
    this.CRTMonolith = false;
    this.RetroMonolith = false;
    this.NoirMonolith = false;
    this.RadioThingMonolith = false;
    this.BehindBackwall = false;
    this.BelowSurface = false;
    this.ZoneSkyHeight = false;
    this.ZoneOverworldHeight = false;
    this.ZoneDirtLayerHeight = false;
    this.ZoneRockLayerHeight = false;
    this.ZoneUnderworldHeight = false;
    this.ZoneCorrupt = false;
    this.ZoneCrimson = false;
    this.ZoneHallow = false;
    this.ZoneJungle = false;
    this.ZoneSnow = false;
    this.ZoneDesert = false;
    this.ZoneGlowshroom = false;
    this.ZoneMeteor = false;
    this.ZoneGraveyard = false;
    this.ZoneDungeon = false;
    this.ZoneLihzhardTemple = false;
    this.ZoneGranite = false;
    this.ZoneMarble = false;
    this.ZoneHive = false;
    this.ZoneGemCave = false;
    this.ZoneBeach = false;
    this.ZoneUndergroundDesert = false;
    this.SurfaceAtmospherics = false;
    this.ZoneRain = false;
    this.ZoneSandstorm = false;
    this.UndergroundForShimmering = false;
    this.ZoneShimmer = false;
    this.ZoneWaterCandle = false;
    this.ZonePeaceCandle = false;
    this.ZoneShadowCandle = false;
    this.InTorchGodMinigame = false;
    Array.Clear((Array) this.NPCBannerBuff, 0, this.NPCBannerBuff.Length);
    this.hasBanner = false;
    this.CanPlayCreditsRoll = false;
    this.BestOreType = -1;
    this.BestOrePosition = new Point();
    this._bestOreDistSq = int.MaxValue;
    this.TownNPCCount = 0;
    this.PerspectivePlayer = SceneMetrics._dummyPlayer;
  }

  private void UpdateOreFinder(Point pos, Tile tile)
  {
    int num1 = (int) Main.tileOreFinderPriority[(int) tile.type];
    if (num1 <= 0)
      return;
    int num2 = this.BestOreType < 0 ? -1 : (int) Main.tileOreFinderPriority[this.BestOreType];
    if (num1 < num2 || !SceneMetrics.IsValidForOreFinder(tile))
      return;
    Point point = new Point(pos.X - this.TileCenter.X, pos.Y - this.TileCenter.Y);
    int num3 = point.X * point.X + point.Y * point.Y;
    if (num1 == num2 && num3 >= this._bestOreDistSq)
      return;
    this.BestOreType = (int) tile.type;
    this.BestOrePosition = pos;
    this._bestOreDistSq = num3;
  }

  public static bool IsValidForOreFinder(Tile t)
  {
    return t.type == (ushort) 227 ? t.frameX >= (short) 272 && t.frameX <= (short) 374 : t.type != (ushort) 129 || t.frameX >= (short) 324;
  }

  public bool WithinRangeOfNPC(int type, double range)
  {
    Vector2 vector2 = this.ClosestNPCPosition[type];
    return vector2 != Vector2.Zero && (double) Vector2.DistanceSquared(this.Center, vector2) <= range * range;
  }
}
