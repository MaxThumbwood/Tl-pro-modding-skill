// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.DungeonCrawler
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using System;
using System.Collections.Generic;
using Terraria.GameContent.Biomes;
using Terraria.GameContent.Generation.Dungeon.Entrances;
using Terraria.GameContent.Generation.Dungeon.Features;
using Terraria.GameContent.Generation.Dungeon.Halls;
using Terraria.GameContent.Generation.Dungeon.LayoutProviders;
using Terraria.GameContent.Generation.Dungeon.Rooms;
using Terraria.ID;
using Terraria.Localization;
using Terraria.Utilities;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon;

public static class DungeonCrawler
{
  public static List<DungeonData> dungeonData = new List<DungeonData>();

  public static DungeonData CurrentDungeonData
  {
    get => DungeonCrawler.dungeonData[GenVars.CurrentDungeon];
    set => DungeonCrawler.dungeonData[GenVars.CurrentDungeon] = value;
  }

  public static void SetupDungeonData(int currentDungeon, bool clearOld = false)
  {
    if (clearOld)
      DungeonCrawler.dungeonData.Clear();
    GenVars.CurrentDungeon = currentDungeon;
    DungeonType dungeonType = DungeonType.Default;
    if (WorldGen.SecretSeed.dualDungeons.Enabled)
      dungeonType = DungeonType.DualDungeon;
    DungeonData dungeonData = new DungeonData()
    {
      Type = dungeonType,
      Iteration = currentDungeon
    };
    DungeonCrawler.dungeonData.Add(dungeonData);
  }

  public static void SetupDungeonGenVarVariables(DungeonGenVars genVars, UnifiedRandom genRand)
  {
    int num1 = genRand.Next(3);
    if (WorldGen.remixWorldGen)
      num1 = !WorldGen.crimson ? 0 : 2;
    switch (num1)
    {
      case 0:
        genVars.dungeonColor = DungeonColor.Blue;
        genVars.brickTileType = (ushort) 41;
        genVars.brickWallType = (ushort) 7;
        genVars.brickCrackedTileType = (ushort) 481;
        genVars.windowGlassWallType = (ushort) 91;
        genVars.windowClosedGlassWallType = (ushort) 96 /*0x60*/;
        genVars.windowEdgeWallType = (ushort) 8;
        genVars.windowPlatformItemTypes = new int[1]{ 1386 };
        break;
      case 1:
        genVars.dungeonColor = DungeonColor.Green;
        genVars.brickTileType = (ushort) 43;
        genVars.brickWallType = (ushort) 8;
        genVars.brickCrackedTileType = (ushort) 482;
        genVars.windowGlassWallType = (ushort) 92;
        genVars.windowClosedGlassWallType = (ushort) 94;
        genVars.windowEdgeWallType = (ushort) 9;
        genVars.windowPlatformItemTypes = new int[1]{ 1385 };
        break;
      default:
        genVars.dungeonColor = DungeonColor.Pink;
        genVars.brickTileType = (ushort) 44;
        genVars.brickWallType = (ushort) 9;
        genVars.brickCrackedTileType = (ushort) 483;
        genVars.windowGlassWallType = (ushort) 90;
        genVars.windowClosedGlassWallType = (ushort) 98;
        genVars.windowEdgeWallType = (ushort) 7;
        genVars.windowPlatformItemTypes = new int[1]{ 1384 };
        break;
    }
    if (WorldGen.drunkWorldGen)
    {
      switch (genRand.Next(3))
      {
        case 0:
          genVars.brickWallType = (ushort) 7;
          break;
        case 1:
          genVars.brickWallType = (ushort) 8;
          break;
        default:
          genVars.brickWallType = (ushort) 9;
          break;
      }
    }
    DungeonUtils.CreatePotentialDungeonBounds(out genVars.innerPotentialDungeonBounds, out genVars.outerPotentialDungeonBounds, genVars.dungeonSide == (int) DungeonSide.Left, 0.10000000149011612, 0.05000000074505806);
    genVars.dungeonStyle = DungeonGenerationStyles.GetCurrentDungeonStyle();
    if (WorldGen.SecretSeed.dualDungeons.Enabled)
    {
      switch (GenVars.CurrentDungeon % 2)
      {
        case 1:
          genVars.dungeonGenerationStyles.Add(DungeonGenerationStyles.Snow);
          genVars.dungeonGenerationStyles.Add(DungeonGenerationStyles.Desert);
          genVars.dungeonGenerationStyles.Add(DungeonGenerationStyles.Hallow);
          genVars.dungeonGenerationStyles.Add(DungeonGenerationStyles.Temple);
          break;
        default:
          genVars.dungeonGenerationStyles.Add(DungeonGenerationStyles.Cavern);
          genVars.dungeonGenerationStyles.Add(WorldGen.crimson ? DungeonGenerationStyles.Crimson : DungeonGenerationStyles.Corruption);
          genVars.dungeonGenerationStyles.Add(DungeonGenerationStyles.Jungle);
          genVars.dungeonGenerationStyles.Add(genVars.dungeonStyle);
          break;
      }
    }
    else
      genVars.dungeonGenerationStyles.Add(genVars.dungeonStyle);
    genVars.isDungeonTile = Main.tileDungeon;
    genVars.isCrackedBrick = TileID.Sets.CrackedBricks;
    genVars.isPitTrapTile = TileID.Sets.CrackedBricks;
    genVars.isDungeonWall = Main.wallDungeon;
    genVars.isDungeonWallGlass = WallID.Sets.Glass;
    if (WorldGen.SecretSeed.dualDungeons.Enabled)
    {
      genVars.isDungeonTile = (bool[]) genVars.isDungeonTile.Clone();
      genVars.isCrackedBrick = (bool[]) genVars.isCrackedBrick.Clone();
      genVars.isPitTrapTile = (bool[]) genVars.isPitTrapTile.Clone();
      genVars.isDungeonWall = (bool[]) genVars.isDungeonWall.Clone();
      genVars.isDungeonWallGlass = (bool[]) genVars.isDungeonWallGlass.Clone();
      List<DungeonGenerationStyleData> generationStyleDataList = new List<DungeonGenerationStyleData>((IEnumerable<DungeonGenerationStyleData>) genVars.dungeonGenerationStyles);
      foreach (DungeonGenerationStyleData dungeonGenerationStyle in genVars.dungeonGenerationStyles)
      {
        if (dungeonGenerationStyle.SubStyles != null)
          generationStyleDataList.AddRange((IEnumerable<DungeonGenerationStyleData>) dungeonGenerationStyle.SubStyles);
      }
      foreach (DungeonGenerationStyleData generationStyleData in generationStyleDataList)
      {
        genVars.isDungeonTile[(int) generationStyleData.BrickTileType] = true;
        if (generationStyleData.BrickGrassTileType.HasValue)
          genVars.isDungeonTile[(int) generationStyleData.BrickGrassTileType.Value] = true;
        genVars.isCrackedBrick[(int) generationStyleData.BrickCrackedTileType] = true;
        genVars.isPitTrapTile[(int) generationStyleData.PitTrapTileType] = true;
        genVars.isDungeonWall[(int) generationStyleData.BrickWallType] = true;
        genVars.isDungeonWallGlass[(int) generationStyleData.WindowGlassWallType] = true;
        genVars.isDungeonWallGlass[(int) generationStyleData.WindowClosedGlassWallType] = true;
      }
    }
    DungeonEntranceType entranceType = DungeonEntranceType.Legacy;
    bool flag = false;
    int num2 = 50;
    while (!flag)
    {
      --num2;
      if (num2 <= 0)
      {
        entranceType = DungeonEntranceType.Legacy;
        break;
      }
      entranceType = DungeonEntranceType.Legacy;
      if (genRand.Next(3) == 0)
        entranceType = DungeonEntranceType.Dome;
      if (genRand.Next(3) == 0)
        entranceType = DungeonEntranceType.Tower;
      flag = true;
      if (WorldGen.SecretSeed.surfaceIsInSpace.Enabled && entranceType == DungeonEntranceType.Tower)
        flag = false;
    }
    genVars.preGenDungeonEntranceSettings = (PreGenDungeonEntranceSettings) DungeonCrawler.MakeDungeon_GetEntranceSettings(entranceType, genVars.dungeonStyle, (DungeonData) null);
  }

  public static void SetupDungeonDataVariables(int iteration, UnifiedRandom genRand)
  {
    DungeonData dungeonData = DungeonCrawler.dungeonData[iteration];
    dungeonData.wallVariants = new int[3];
    switch (dungeonData.genVars.brickWallType)
    {
      case 8:
        dungeonData.wallVariants[0] = 8;
        dungeonData.wallVariants[1] = 98;
        dungeonData.wallVariants[2] = 99;
        break;
      case 9:
        dungeonData.wallVariants[0] = 9;
        dungeonData.wallVariants[1] = 96 /*0x60*/;
        dungeonData.wallVariants[2] = 97;
        break;
      default:
        dungeonData.wallVariants[0] = 7;
        dungeonData.wallVariants[1] = 94;
        dungeonData.wallVariants[2] = 95;
        break;
    }
    dungeonData.platformItemType = 1384;
    dungeonData.chandelierItemType = 2652;
    dungeonData.doorItemType = 1411;
    switch (dungeonData.genVars.dungeonColor)
    {
      case DungeonColor.Green:
        dungeonData.platformItemType = 1386;
        dungeonData.chandelierItemType = 2653;
        dungeonData.doorItemType = 1412;
        break;
      case DungeonColor.Pink:
        dungeonData.platformItemType = 1385;
        dungeonData.chandelierItemType = 2654;
        dungeonData.doorItemType = 1413;
        break;
      default:
        dungeonData.platformItemType = 1384;
        dungeonData.chandelierItemType = 2652;
        dungeonData.doorItemType = 1411;
        break;
    }
    dungeonData.shelfStyles = new int[3];
    dungeonData.shelfStyles[0] = genRand.Next(9, 13);
    dungeonData.shelfStyles[1] = genRand.Next(9, 13);
    while (dungeonData.shelfStyles[1] == dungeonData.shelfStyles[0])
      dungeonData.shelfStyles[1] = genRand.Next(9, 13);
    dungeonData.shelfStyles[2] = genRand.Next(9, 13);
    while (dungeonData.shelfStyles[2] == dungeonData.shelfStyles[0] || dungeonData.shelfStyles[2] == dungeonData.shelfStyles[1])
      dungeonData.shelfStyles[2] = genRand.Next(9, 13);
    dungeonData.lanternStyles = new int[3];
    dungeonData.lanternStyles[0] = genRand.Next(7);
    dungeonData.lanternStyles[1] = genRand.Next(7);
    while (dungeonData.lanternStyles[1] == dungeonData.lanternStyles[0])
      dungeonData.lanternStyles[1] = genRand.Next(7);
    dungeonData.lanternStyles[2] = genRand.Next(7);
    while (dungeonData.lanternStyles[2] == dungeonData.lanternStyles[0] || dungeonData.lanternStyles[2] == dungeonData.lanternStyles[1])
      dungeonData.lanternStyles[2] = genRand.Next(7);
    dungeonData.bannerStyles = new int[6];
    dungeonData.bannerStyles[0] = 10;
    dungeonData.bannerStyles[1] = 11;
    dungeonData.bannerStyles[2] = 12;
    dungeonData.bannerStyles[3] = 13;
    dungeonData.bannerStyles[4] = 14;
    dungeonData.bannerStyles[5] = 15;
    dungeonData.useSkewedDungeonEntranceHalls = genRand.Next(4) == 0;
    if (!dungeonData.genVars.preGenDungeonEntranceSettings.PrecalculateEntrancePosition)
      return;
    int x = dungeonData.genVars.dungeonLocation;
    int y = 0;
    bool flag = false;
    int num1 = 100;
    int num2 = 3000;
    while (!flag)
    {
      --num2;
      if (num2 > 0)
      {
        x = dungeonData.genVars.dungeonLocation - num1 + genRand.Next(num1 * 2);
        if (x > WorldGen.beachDistance && x < Main.maxTilesX - WorldGen.beachDistance)
        {
          y = 10;
          if (SpecialSeedFeatures.DungeonEntranceIsBuried)
            y = (int) Main.worldSurface - 10 + GenVars.CurrentDungeonGenVars.preGenDungeonEntranceSettings.BuriedEntranceYOffset;
          if (SpecialSeedFeatures.DungeonEntranceIsUnderground)
            y = !SpecialSeedFeatures.DungeonEntranceHasATree ? (dungeonData.Type != DungeonType.DualDungeon ? (int) GenVars.rockLayer - 20 : (int) GenVars.worldSurfaceHigh - 20) : (int) GenVars.rockLayer - 20;
          for (Tile tile = Main.tile[x, y]; tile != null && !tile.active() && tile.liquid <= (byte) 0 && tile.wall <= (ushort) 0; tile = Main.tile[x, y])
            ++y;
          if (!WorldGen.AreAnyTilesInSetNearby(x, y, TileID.Sets.Clouds, 15) && !WorldGen.AreAnyTilesInSetNearby(x, Math.Max(50, y - 50), TileID.Sets.Clouds, 50) && y - 40 - dungeonData.genVars.preGenDungeonEntranceSettings.RoughHeight > 0)
            flag = true;
        }
      }
      else
        break;
    }
    if (flag)
    {
      dungeonData.genVars.dungeonLocation = x + 25 - genRand.Next(50);
      dungeonData.genVars.dungeonEntrancePosition = new Vector2D((double) x, (double) y);
    }
    else
    {
      dungeonData.genVars.preGenDungeonEntranceSettings = (PreGenDungeonEntranceSettings) DungeonCrawler.MakeDungeon_GetEntranceSettings(DungeonEntranceType.Legacy, dungeonData.genVars.preGenDungeonEntranceSettings.StyleData, (DungeonData) null);
      dungeonData.genVars.dungeonEntrancePosition = Vector2D.Zero;
    }
  }

  public static void MakeDungeon(int x, int y, GenerationProgress progress = null)
  {
    UnifiedRandom genRand = WorldGen.genRand;
    DungeonData currentDungeonData = DungeonCrawler.CurrentDungeonData;
    DungeonFeatureSettings settings1 = new DungeonFeatureSettings();
    currentDungeonData.genVars.GeneratingDungeon = true;
    DungeonUtils.UpdateDungeonProgress(progress, 0.0f, Language.GetTextValue("WorldGeneration.DungeonVariableSetup"));
    int brickTileType = (int) currentDungeonData.genVars.brickTileType;
    int brickCrackedTileType = (int) currentDungeonData.genVars.brickCrackedTileType;
    int brickWallType = (int) currentDungeonData.genVars.brickWallType;
    WorldGen.SetCrackedBrickSolidity(false);
    currentDungeonData.makeNextPitTrapFlooded = true;
    currentDungeonData.genVars.generatingDungeonPositionX = x;
    currentDungeonData.genVars.generatingDungeonPositionY = y;
    currentDungeonData.dungeonBounds.SetBounds(x, y, x, y);
    currentDungeonData.dungeonEntranceStrengthX = (double) genRand.Next(25, 30);
    currentDungeonData.dungeonEntranceStrengthY = (double) genRand.Next(20, 25);
    currentDungeonData.dungeonEntranceStrengthX2 = (double) genRand.Next(35, 50);
    currentDungeonData.dungeonEntranceStrengthY2 = (double) genRand.Next(10, 15);
    int num1 = Main.maxTilesX / 60;
    int num2 = (int) ((double) (num1 + genRand.Next(0, num1 / 3)) * currentDungeonData.dungeonStepScalar);
    int num3 = num2;
    int roomDelay = 5;
    currentDungeonData.globalFeatureScalar = 1.0;
    if (currentDungeonData.Type == DungeonType.DualDungeon)
    {
      DualDungeonLayoutProviderSettings settings2 = new DualDungeonLayoutProviderSettings();
      settings2.StyleData = currentDungeonData.genVars.dungeonStyle;
      new DualDungeonLayoutProvider((DungeonLayoutProviderSettings) settings2).ProvideLayout(currentDungeonData, progress, genRand, ref roomDelay);
      currentDungeonData.globalFeatureScalar = Math.Max(1.0, (double) currentDungeonData.dungeonRooms.Count / 20.0);
    }
    else
    {
      LegacyDungeonLayoutProviderSettings settings3 = new LegacyDungeonLayoutProviderSettings();
      settings3.StyleData = currentDungeonData.genVars.dungeonStyle;
      settings3.Steps = num2;
      settings3.MaxSteps = num3;
      new LegacyDungeonLayoutProvider((DungeonLayoutProviderSettings) settings3).ProvideLayout(currentDungeonData, progress, genRand, ref roomDelay);
    }
    DungeonBounds innerBounds1 = currentDungeonData.dungeonRooms[0].InnerBounds;
    Vector2 vector2 = new Vector2((float) innerBounds1.Center.X, (float) innerBounds1.Top);
    float x1 = vector2.X;
    float y1 = vector2.Y;
    if (currentDungeonData.Type == DungeonType.Default)
    {
      for (int index = 1; index < currentDungeonData.dungeonRooms.Count; ++index)
      {
        if (currentDungeonData.dungeonRooms[index].generated)
        {
          DungeonBounds innerBounds2 = currentDungeonData.dungeonRooms[index].InnerBounds;
          vector2 = new Vector2((float) innerBounds2.Center.X, (float) innerBounds2.Top);
          if ((double) vector2.Y < (double) y1)
          {
            x1 = vector2.X;
            y1 = vector2.Y;
          }
        }
      }
    }
    currentDungeonData.genVars.generatingDungeonPositionX = (int) x1;
    currentDungeonData.genVars.generatingDungeonPositionY = (int) y1;
    currentDungeonData.genVars.generatingDungeonTopX = (int) x1;
    DungeonUtils.UpdateDungeonProgress(progress, 0.65f, Language.GetTextValue("WorldGeneration.DungeonEntranceHallway"));
    currentDungeonData.createdDungeonEntranceOnSurface = false;
    roomDelay = 5;
    Vector2D entrancePosition = currentDungeonData.genVars.dungeonEntrancePosition;
    bool flag = Vector2D.op_Inequality(entrancePosition, Vector2D.Zero);
    if (flag && WorldGen.SecretSeed.surfaceIsDesert.Enabled && currentDungeonData.Type == DungeonType.DualDungeon)
      currentDungeonData.createdDungeonEntranceOnSurface = true;
    if (WorldGen.drunkWorldGen || WorldGen.SecretSeed.noSurface.Enabled)
      currentDungeonData.createdDungeonEntranceOnSurface = true;
    Vector2D currentPos;
    // ISSUE: explicit constructor call
    ((Vector2D) ref currentPos).\u002Ector((double) currentDungeonData.genVars.generatingDungeonPositionX, (double) currentDungeonData.genVars.generatingDungeonPositionY);
    double dist = flag ? entrancePosition.Distance(currentPos) : 0.0;
    int amountPassed = (int) dist;
    int num4 = 100;
    while (!currentDungeonData.createdDungeonEntranceOnSurface)
    {
      --num4;
      if (num4 > 0)
      {
        if (roomDelay > 0)
          --roomDelay;
        if (roomDelay == 0 && genRand.Next(5) == 0 && (double) currentDungeonData.genVars.generatingDungeonPositionY > Main.worldSurface + 100.0)
        {
          roomDelay = 10;
          int dungeonPositionX = currentDungeonData.genVars.generatingDungeonPositionX;
          int dungeonPositionY = currentDungeonData.genVars.generatingDungeonPositionY;
          DungeonCrawler.MakeDungeon_GetHall_Legacy((LegacyDungeonHallSettings) DungeonCrawler.MakeDungeon_GetHallSettings(DungeonHallType.Legacy, currentDungeonData, Vector2.Zero, Vector2.Zero, currentDungeonData.genVars.dungeonStyle)).GenerateHall(currentDungeonData, currentDungeonData.genVars.generatingDungeonPositionX, currentDungeonData.genVars.generatingDungeonPositionY);
          LegacyDungeonRoomSettings settings4 = new LegacyDungeonRoomSettings();
          settings4.RoomPosition = new Point(currentDungeonData.genVars.generatingDungeonPositionX, currentDungeonData.genVars.generatingDungeonPositionY);
          settings4.RandomSeed = genRand.Next();
          settings4.StyleData = currentDungeonData.genVars.dungeonStyle;
          DungeonCrawler.MakeDungeon_GetRoom((DungeonRoomSettings) settings4).GenerateRoom(currentDungeonData);
          currentDungeonData.genVars.generatingDungeonPositionX = dungeonPositionX;
          currentDungeonData.genVars.generatingDungeonPositionY = dungeonPositionY;
        }
        if (flag)
          DungeonCrawler.MakeDungeon_GenerateNextEntranceHall_Precalculated(currentDungeonData, genRand, dist, entrancePosition, ref amountPassed, ref currentPos);
        else
          DungeonCrawler.MakeDungeon_GenerateNextEntranceHall_Legacy(currentDungeonData, currentDungeonData.genVars.generatingDungeonPositionX, currentDungeonData.genVars.generatingDungeonPositionY);
      }
      else
        break;
    }
    DungeonCrawler.MakeDungeon_GetEntrance(DungeonCrawler.MakeDungeon_GetEntranceSettings(currentDungeonData.genVars.preGenDungeonEntranceSettings, currentDungeonData)).GenerateEntrance(currentDungeonData, currentDungeonData.genVars.generatingDungeonPositionX, currentDungeonData.genVars.generatingDungeonPositionY);
    if (WorldGen.SecretSeed.surfaceIsInSpace.Enabled)
      currentDungeonData.dungeonBounds.Top = 25;
    DungeonUtils.UpdateDungeonProgress(progress, 0.675f, Language.GetTextValue("WorldGeneration.DungeonFindingDoorsAndPlatforms"));
    for (int index = 0; index < currentDungeonData.dungeonRooms.Count; ++index)
    {
      DungeonRoom dungeonRoom = currentDungeonData.dungeonRooms[index];
      if (dungeonRoom.Processed)
        dungeonRoom.CalculatePlatformsAndDoors(currentDungeonData);
    }
    for (int index = 0; index < currentDungeonData.dungeonHalls.Count; ++index)
    {
      DungeonHall dungeonHall = currentDungeonData.dungeonHalls[index];
      if (dungeonHall.Processed)
        dungeonHall.CalculatePlatformsAndDoors(currentDungeonData);
    }
    DungeonUtils.UpdateDungeonProgress(progress, 0.7f, Language.GetTextValue("WorldGeneration.DungeonEarly"));
    new DungeonGlobalEarlyDualDungeonFeatures(settings1).GenerateFeature(currentDungeonData);
    DungeonUtils.UpdateDungeonProgress(progress, 0.75f, Language.GetTextValue("WorldGeneration.DungeonSpikes"));
    new DungeonGlobalSpikes(settings1).GenerateFeature(currentDungeonData);
    DungeonUtils.UpdateDungeonProgress(progress, 0.8f, Language.GetTextValue("WorldGeneration.DungeonDoors"));
    new DungeonGlobalDoors(settings1).GenerateFeature(currentDungeonData);
    DungeonUtils.UpdateDungeonProgress(progress, 0.825f, Language.GetTextValue("WorldGeneration.DungeonWallVariants"));
    new DungeonGlobalWallVariants(settings1).GenerateFeature(currentDungeonData);
    DungeonUtils.UpdateDungeonProgress(progress, 0.85f, Language.GetTextValue("WorldGeneration.DungeonPlatforms"));
    new DungeonGlobalPlatforms(settings1).GenerateFeature(currentDungeonData);
    DungeonUtils.UpdateDungeonProgress(progress, 0.875f, Language.GetTextValue("WorldGeneration.DungeonBiomeChests"));
    new DungeonGlobalBiomeChests(settings1).GenerateFeature(currentDungeonData);
    DungeonUtils.UpdateDungeonProgress(progress, 0.9f, Language.GetTextValue("WorldGeneration.DungeonBookshelves"));
    new DungeonGlobalBookshelves(settings1).GenerateFeature(currentDungeonData);
    DungeonUtils.UpdateDungeonProgress(progress, 0.92f, Language.GetTextValue("WorldGeneration.DungeonChests"));
    new DungeonGlobalBasicChests(settings1).GenerateFeature(currentDungeonData);
    DungeonUtils.UpdateDungeonProgress(progress, 0.935f, Language.GetTextValue("WorldGeneration.DungeonArea"));
    int amount = 25;
    currentDungeonData.dungeonBounds.Inflate(amount);
    DungeonUtils.UpdateDungeonProgress(progress, 0.94f, Language.GetTextValue("WorldGeneration.DungeonLights"));
    new DungeonGlobalLights(settings1).GenerateFeature(currentDungeonData);
    DungeonUtils.UpdateDungeonProgress(progress, 0.95f, Language.GetTextValue("WorldGeneration.DungeonTraps"));
    new DungeonGlobalTraps(settings1).GenerateFeature(currentDungeonData);
    DungeonUtils.UpdateDungeonProgress(progress, 0.96f, Language.GetTextValue("WorldGeneration.DungeonFurniture"));
    new DungeonGlobalGroundFurniture(settings1).GenerateFeature(currentDungeonData);
    DungeonUtils.UpdateDungeonProgress(progress, 0.97f, Language.GetTextValue("WorldGeneration.DungeonPictures"));
    new DungeonGlobalPaintings(settings1).GenerateFeature(currentDungeonData);
    DungeonUtils.UpdateDungeonProgress(progress, 0.98f, Language.GetTextValue("WorldGeneration.DungeonBanners"));
    new DungeonGlobalBanners(settings1).GenerateFeature(currentDungeonData);
    DungeonUtils.UpdateDungeonProgress(progress, 0.99f, Language.GetTextValue("WorldGeneration.DungeonLate"));
    new DungeonGlobalLateDualDungeonFeatures(settings1).GenerateFeature(currentDungeonData);
    DungeonUtils.UpdateDungeonProgress(progress, 1f, Language.GetTextValue("WorldGeneration.DungeonComplete"));
    currentDungeonData.genVars.GeneratingDungeon = false;
  }

  public static void MakeDungeon_GenerateNextEntranceHall_Legacy(DungeonData data, int x, int y)
  {
    LegacyEntranceDungeonHallSettings settings = new LegacyEntranceDungeonHallSettings();
    settings.HallType = DungeonHallType.LegacyEntrance;
    settings.StyleData = data.genVars.dungeonStyle;
    settings.RandomSeed = WorldGen.genRand.Next();
    ((LegacyDungeonHall) DungeonCrawler.MakeDungeon_GetHall((DungeonHallSettings) settings)).GenerateHall(data, x, y);
  }

  public static void MakeDungeon_GenerateNextEntranceHall_Precalculated(
    DungeonData data,
    UnifiedRandom genRand,
    double dist,
    Vector2D entrancePos,
    ref int amountPassed,
    ref Vector2D currentPos)
  {
    int num = genRand.Next(10, 30);
    if ((double) num > dist - (double) amountPassed)
      num = Math.Max(1, (int) dist - amountPassed);
    Vector2D endPoint = Vector2D.Lerp(currentPos, entrancePos, (double) amountPassed / dist);
    LegacyEntranceDungeonHallSettings settings = new LegacyEntranceDungeonHallSettings();
    settings.HallType = DungeonHallType.LegacyEntrance;
    settings.StyleData = data.genVars.dungeonStyle;
    settings.RandomSeed = WorldGen.genRand.Next();
    settings.OverrideSteps = num;
    settings.UsePrecalculatedEntrance = true;
    DungeonHall hall = DungeonCrawler.MakeDungeon_GetHall((DungeonHallSettings) settings);
    hall.CalculateHall(data, currentPos, endPoint);
    hall.GenerateHall(data);
    amountPassed -= num;
    currentPos = endPoint;
    if (amountPassed > 0)
      return;
    data.createdDungeonEntranceOnSurface = true;
  }

  public static DungeonRoomSettings MakeDungeon_GetRoomSettings(
    DungeonRoomType roomType,
    DungeonData data,
    DungeonControlLine line)
  {
    UnifiedRandom genRand = WorldGen.genRand;
    int progressionStage = line.ProgressionStage;
    DungeonGenerationStyleData style = line.Style;
    Vector2D normalizedLineDirection = line.NormalizedLineDirection;
    bool curveLine = line.CurveLine;
    int num1 = (int) (15.0 * data.roomStrengthScalar);
    int num2 = genRand.Next(13);
    int num3 = genRand.Next(13);
    int num4 = 6;
    int num5 = genRand.Next(12);
    int num6 = genRand.Next(12);
    float num7 = 1f;
    if (data.Type == DungeonType.DualDungeon)
      num7 = 1.25f;
    if (((roomType == DungeonRoomType.GenShapeDoughnut ? 1 : (roomType == DungeonRoomType.GenShapeQuadCircle ? 1 : 0)) & (curveLine ? 1 : 0)) != 0)
      roomType = DungeonRoomType.GenShapeCircle;
    DungeonRoomSettings roomSettings;
    switch (roomType)
    {
      case DungeonRoomType.Regular:
        int num8 = (int) ((double) num1 * 0.8);
        int num9 = (int) ((double) num2 * 0.8);
        roomSettings = (DungeonRoomSettings) new RegularDungeonRoomSettings()
        {
          OverrideOuterBoundsSize = 8,
          OverrideInnerBoundsSize = (num8 + num9)
        };
        break;
      case DungeonRoomType.Wormlike:
        int num10 = num4 * 3 + num5;
        int num11 = num4 * 3 + num6;
        roomSettings = (DungeonRoomSettings) new WormlikeDungeonRoomSettings()
        {
          FirstSideIterations = num10,
          SecondSideIterations = num11
        };
        break;
      case DungeonRoomType.LivingTree:
        int num12 = (int) ((double) num1 * 0.3) + (int) ((double) num2 * 0.5);
        int num13 = num4 * 6 + num5;
        int num14 = 4 + genRand.Next(3);
        int num15 = (num13 + num14 + num14) / 2;
        LivingTreeDungeonRoomSettings dungeonRoomSettings1 = new LivingTreeDungeonRoomSettings();
        dungeonRoomSettings1.InnerWidth = num12;
        dungeonRoomSettings1.InnerHeight = num13;
        dungeonRoomSettings1.Depth = num14;
        dungeonRoomSettings1.BoundingRadius = num15;
        dungeonRoomSettings1.ForceStyleForDoorsAndPlatforms = true;
        roomSettings = (DungeonRoomSettings) dungeonRoomSettings1;
        break;
      case DungeonRoomType.BiomeSquare:
      case DungeonRoomType.BiomeRugged:
      case DungeonRoomType.BiomeStructured:
        roomSettings = (DungeonRoomSettings) new BiomeDungeonRoomSettings();
        break;
      case DungeonRoomType.GenShapeCircle:
        int num16 = (int) ((double) num1 * 0.8);
        int num17 = (int) ((double) num2 * 0.8);
        if ((double) num7 != 1.0 && genRand.Next(3) == 0)
        {
          num16 = (int) ((double) num16 * (double) num7);
          num17 = (int) ((double) num17 * (double) num7);
        }
        int num18 = num16;
        int num19 = num18 + 8;
        DungeonShapes.CircleRoom circleRoom1 = new DungeonShapes.CircleRoom(num18 + num17);
        DungeonShapes.CircleRoom circleRoom2 = new DungeonShapes.CircleRoom(num19 + num17);
        GenShapeDungeonRoomSettings dungeonRoomSettings2 = new GenShapeDungeonRoomSettings();
        dungeonRoomSettings2.ShapeType = GenShapeType.Circle;
        dungeonRoomSettings2.InnerShape = (GenShape) circleRoom1;
        dungeonRoomSettings2.OuterShape = (GenShape) circleRoom2;
        dungeonRoomSettings2.BoundingRadius = num19 + num17;
        dungeonRoomSettings2.HallwayPointAdjuster = new int?(10);
        roomSettings = (DungeonRoomSettings) dungeonRoomSettings2;
        break;
      case DungeonRoomType.GenShapeMound:
        if ((double) num7 != 1.0 && genRand.Next(3) == 0)
        {
          num1 = (int) ((double) num1 * (double) num7);
          num2 = (int) ((double) num2 * (double) num7);
        }
        int halfWidth1 = num1 + num2;
        int halfWidth2 = halfWidth1 + 8;
        DungeonShapes.MoundRoom moundRoom1 = new DungeonShapes.MoundRoom(halfWidth1, (int) ((double) halfWidth1 * 1.5));
        DungeonShapes.MoundRoom moundRoom2 = new DungeonShapes.MoundRoom(halfWidth2, (int) ((double) halfWidth2 * 1.5));
        roomSettings = (DungeonRoomSettings) new GenShapeDungeonRoomSettings()
        {
          ShapeType = GenShapeType.Mound,
          InnerShape = (GenShape) moundRoom1,
          OuterShape = (GenShape) moundRoom2,
          BoundingRadius = (int) ((double) halfWidth2 * 1.2)
        };
        break;
      case DungeonRoomType.GenShapeHourglass:
        if ((double) num7 != 1.0 && genRand.Next(3) == 0)
        {
          num1 = (int) ((double) num1 * (double) num7);
          num2 = (int) ((double) num2 * (double) num7);
        }
        int width1 = num1 + num2 + 10;
        int height1 = num1 + num3 + 10;
        int width2 = width1 + 16 /*0x10*/;
        int height2 = height1 + 16 /*0x10*/;
        DungeonShapes.HourglassRoom hourglassRoom1 = new DungeonShapes.HourglassRoom(width1, height1, 0.0f);
        DungeonShapes.HourglassRoom hourglassRoom2 = new DungeonShapes.HourglassRoom(width2, height2, 0.4f);
        GenShapeDungeonRoomSettings dungeonRoomSettings3 = new GenShapeDungeonRoomSettings();
        dungeonRoomSettings3.ShapeType = GenShapeType.Hourglass;
        dungeonRoomSettings3.InnerShape = (GenShape) hourglassRoom1;
        dungeonRoomSettings3.OuterShape = (GenShape) hourglassRoom2;
        dungeonRoomSettings3.BoundingRadius = (width2 > height2 ? width2 / 2 : height2 / 2) + 5;
        dungeonRoomSettings3.HallwayPointAdjuster = new int?(5);
        roomSettings = (DungeonRoomSettings) dungeonRoomSettings3;
        break;
      case DungeonRoomType.GenShapeDoughnut:
        int num20 = (int) ((double) num1 * 0.8);
        int num21 = (int) ((double) num2 * 0.8);
        int horizontalRadius1 = num20 + num21;
        int verticalRadius1 = num20 + num3;
        int horizontalRadius2 = horizontalRadius1 + 8;
        int verticalRadius2 = verticalRadius1 + 8;
        DungeonShapes.CircleRoom circleRoom3 = new DungeonShapes.CircleRoom(horizontalRadius1, verticalRadius1);
        DungeonShapes.CircleRoom circleRoom4 = new DungeonShapes.CircleRoom(horizontalRadius2, verticalRadius2);
        GenShapeDungeonRoomSettings dungeonRoomSettings4 = new GenShapeDungeonRoomSettings();
        dungeonRoomSettings4.ShapeType = GenShapeType.Doughnut;
        dungeonRoomSettings4.InnerShape = (GenShape) circleRoom3;
        dungeonRoomSettings4.OuterShape = (GenShape) circleRoom4;
        dungeonRoomSettings4.BoundingRadius = (horizontalRadius2 > verticalRadius2 ? horizontalRadius2 : verticalRadius2) + 5;
        dungeonRoomSettings4.HallwayPointAdjuster = new int?(5);
        roomSettings = (DungeonRoomSettings) dungeonRoomSettings4;
        break;
      case DungeonRoomType.GenShapeQuadCircle:
        if ((double) num7 != 1.0 && genRand.Next(3) == 0)
        {
          num1 = (int) ((double) num1 * 1.5);
          num2 = (int) ((double) num2 * 1.5);
        }
        int radius1 = Math.Max(5, (int) ((double) (num1 + num2) * 0.5 * 0.75));
        int radius2 = radius1 + 8;
        int distanceBetweenSpheres = (int) ((double) radius1 * 1.5);
        DungeonShapes.QuadCircleRoom quadCircleRoom1 = new DungeonShapes.QuadCircleRoom(radius1, distanceBetweenSpheres);
        DungeonShapes.QuadCircleRoom quadCircleRoom2 = new DungeonShapes.QuadCircleRoom(radius2, distanceBetweenSpheres);
        GenShapeDungeonRoomSettings dungeonRoomSettings5 = new GenShapeDungeonRoomSettings();
        dungeonRoomSettings5.ShapeType = GenShapeType.QuadCircle;
        dungeonRoomSettings5.InnerShape = (GenShape) quadCircleRoom1;
        dungeonRoomSettings5.OuterShape = (GenShape) quadCircleRoom2;
        dungeonRoomSettings5.BoundingRadius = radius2 / 2 + distanceBetweenSpheres + 4;
        dungeonRoomSettings5.HallwayPointAdjuster = new int?(5);
        roomSettings = (DungeonRoomSettings) dungeonRoomSettings5;
        break;
      default:
        LegacyDungeonRoomSettings dungeonRoomSettings6 = new LegacyDungeonRoomSettings();
        dungeonRoomSettings6.OverrideStrength = num1 + num2;
        dungeonRoomSettings6.OverrideSteps = num4 + num5;
        dungeonRoomSettings6.OverrideVelocity = normalizedLineDirection.SafeNormalize(Vector2D.UnitY);
        roomSettings = (DungeonRoomSettings) dungeonRoomSettings6;
        break;
    }
    roomSettings.RandomSeed = genRand.Next();
    roomSettings.RoomType = roomType;
    roomSettings.ProgressionStage = progressionStage;
    roomSettings.StyleData = style;
    roomSettings.OnCurvedLine = curveLine;
    roomSettings.Orientation = SnakeOrientation.Unknown;
    roomSettings.ControlLine = line;
    return roomSettings;
  }

  public static DungeonHallSettings MakeDungeon_GetHallSettings(
    DungeonHallType hallType,
    DungeonData data,
    Vector2 hallStart,
    Vector2 hallEnd,
    DungeonGenerationStyleData style)
  {
    UnifiedRandom genRand = WorldGen.genRand;
    DungeonHallSettings hallSettings;
    switch (hallType)
    {
      case DungeonHallType.Regular:
        hallSettings = (DungeonHallSettings) new RegularDungeonHallSettings();
        break;
      case DungeonHallType.Stairwell:
        StairwellDungeonHallSettings dungeonHallSettings1 = new StairwellDungeonHallSettings();
        dungeonHallSettings1.CrackedBrickChance = 0.0;
        hallSettings = (DungeonHallSettings) dungeonHallSettings1;
        break;
      case DungeonHallType.Sine:
        int num1 = Math.Max(1, (int) ((double) (hallStart - hallEnd).Length() / 30.0));
        int num2 = num1 <= 1 ? 1 : 1 + genRand.Next(num1 - 1);
        float num3 = (float) (8.0 + (double) genRand.NextFloat() * 4.0);
        SineDungeonHallSettings dungeonHallSettings2 = new SineDungeonHallSettings();
        dungeonHallSettings2.CrackedBrickChance = 0.0;
        dungeonHallSettings2.Magnitude = num3;
        dungeonHallSettings2.Iterations = num2;
        dungeonHallSettings2.FlipSine = genRand.Next(2) == 0;
        hallSettings = (DungeonHallSettings) dungeonHallSettings2;
        break;
      default:
        hallSettings = (DungeonHallSettings) new LegacyDungeonHallSettings();
        break;
    }
    hallSettings.RandomSeed = genRand.Next();
    hallSettings.HallType = hallType;
    hallSettings.StyleData = style;
    return hallSettings;
  }

  public static DungeonEntranceSettings MakeDungeon_GetEntranceSettings(
    PreGenDungeonEntranceSettings preSettings,
    DungeonData data)
  {
    DungeonEntranceSettings entranceSettings = DungeonCrawler.MakeDungeon_GetEntranceSettings(preSettings.EntranceType, preSettings.StyleData, data);
    entranceSettings.RandomSeed = preSettings.RandomSeed;
    return entranceSettings;
  }

  public static DungeonEntranceSettings MakeDungeon_GetEntranceSettings(
    DungeonEntranceType entranceType,
    DungeonGenerationStyleData styleData,
    DungeonData data)
  {
    UnifiedRandom genRand = WorldGen.genRand;
    if (data == null)
    {
      PreGenDungeonEntranceSettings entranceSettings1 = new PreGenDungeonEntranceSettings();
      entranceSettings1.EntranceType = entranceType;
      entranceSettings1.StyleData = styleData;
      PreGenDungeonEntranceSettings entranceSettings2 = entranceSettings1;
      int num = 0;
      if (WorldGen.SecretSeed.dualDungeons.Enabled)
        num += 30;
      switch (entranceType)
      {
        case DungeonEntranceType.Dome:
          entranceSettings2.PrecalculateEntrancePosition = true;
          entranceSettings2.BuriedEntranceYOffset = 20 + num;
          entranceSettings2.BuriedEntranceSandDugoutYOffset = -num;
          entranceSettings2.RoughHeight = 55;
          break;
        case DungeonEntranceType.Tower:
          entranceSettings2.PrecalculateEntrancePosition = true;
          entranceSettings2.BuriedEntranceYOffset = 20 + num;
          entranceSettings2.BuriedEntranceSandDugoutYOffset = -num;
          entranceSettings2.RoughHeight = 120;
          break;
        default:
          entranceSettings2.BuriedEntranceYOffset = num;
          entranceSettings2.BuriedEntranceSandDugoutYOffset = -num;
          entranceSettings2.RoughHeight = 40;
          break;
      }
      entranceSettings2.RandomSeed = genRand.Next();
      return (DungeonEntranceSettings) entranceSettings2;
    }
    bool flag = false;
    DungeonEntranceSettings entranceSettings;
    switch (entranceType)
    {
      case DungeonEntranceType.Dome:
        entranceSettings = (DungeonEntranceSettings) new DomeDungeonEntranceSettings();
        entranceSettings.PrecalculateEntrancePosition = true;
        break;
      case DungeonEntranceType.Tower:
        entranceSettings = (DungeonEntranceSettings) new TowerDungeonEntranceSettings();
        entranceSettings.PrecalculateEntrancePosition = true;
        break;
      default:
        entranceSettings = (DungeonEntranceSettings) new LegacyDungeonEntranceSettings();
        break;
    }
    entranceSettings.RandomSeed = genRand.Next();
    entranceSettings.EntranceType = entranceType;
    if (!flag)
      entranceSettings.StyleData = styleData;
    return entranceSettings;
  }

  public static DungeonRoom MakeDungeon_TryRoom(
    DungeonData data,
    int i,
    int j,
    DungeonRoomSettings roomSettings,
    bool addToData = true,
    int fluff = 0,
    bool noRoomOverlap = true)
  {
    DungeonRoom roomFound = (DungeonRoom) null;
    return data.IsAnyRoomInSpot(out roomFound, i, j, new DungeonRoomSearchSettings()
    {
      Fluff = fluff
    }) ? (DungeonRoom) null : DungeonCrawler.MakeDungeon_GetRoom(roomSettings, addToData);
  }

  public static DungeonRoom MakeDungeon_GetRoom(DungeonRoomSettings settings, bool addToData = true)
  {
    DungeonRoom room;
    switch (settings.RoomType)
    {
      case DungeonRoomType.Regular:
        room = (DungeonRoom) new RegularDungeonRoom(settings);
        break;
      case DungeonRoomType.Wormlike:
        room = (DungeonRoom) new WormlikeDungeonRoom(settings);
        break;
      case DungeonRoomType.LivingTree:
        room = (DungeonRoom) new LivingTreeDungeonRoom(settings);
        break;
      case DungeonRoomType.BiomeSquare:
        room = (DungeonRoom) new BiomeSquareDungeonRoom(settings);
        break;
      case DungeonRoomType.BiomeRugged:
        room = (DungeonRoom) new BiomeRuggedDungeonRoom(settings);
        break;
      case DungeonRoomType.BiomeStructured:
        room = (DungeonRoom) new BiomeStructuredDungeonRoom(settings);
        break;
      case DungeonRoomType.GenShapeCircle:
      case DungeonRoomType.GenShapeMound:
      case DungeonRoomType.GenShapeHourglass:
      case DungeonRoomType.GenShapeDoughnut:
      case DungeonRoomType.GenShapeQuadCircle:
        room = (DungeonRoom) new GenShapeDungeonRoom(settings);
        break;
      default:
        room = (DungeonRoom) new LegacyDungeonRoom(settings);
        break;
    }
    if (addToData && room != null)
      DungeonCrawler.CurrentDungeonData.dungeonRooms.Add(room);
    return room;
  }

  public static LegacyDungeonHall MakeDungeon_GetHall_Legacy(LegacyDungeonHallSettings settings)
  {
    return (LegacyDungeonHall) DungeonCrawler.MakeDungeon_GetHall((DungeonHallSettings) settings);
  }

  public static DungeonHall MakeDungeon_GetHall(DungeonHallSettings settings, bool addToData = true)
  {
    DungeonHall hall;
    switch (settings.HallType)
    {
      case DungeonHallType.LegacyEntrance:
        hall = (DungeonHall) new LegacyEntranceDungeonHall(settings);
        break;
      case DungeonHallType.Regular:
        hall = (DungeonHall) new RegularDungeonHall(settings);
        break;
      case DungeonHallType.Stairwell:
        hall = (DungeonHall) new StairwellDungeonHall((StairwellDungeonHallSettings) settings);
        break;
      case DungeonHallType.Sine:
        hall = (DungeonHall) new SineDungeonHall(settings);
        break;
      default:
        hall = (DungeonHall) new LegacyDungeonHall(settings);
        break;
    }
    if (addToData && hall != null)
      DungeonCrawler.CurrentDungeonData.dungeonHalls.Add(hall);
    return hall;
  }

  public static DungeonEntrance MakeDungeon_GetEntrance(
    DungeonEntranceSettings settings,
    bool addToData = true)
  {
    DungeonEntrance entrance;
    switch (settings.EntranceType)
    {
      case DungeonEntranceType.Dome:
        entrance = (DungeonEntrance) new DomeDungeonEntrance(settings);
        break;
      case DungeonEntranceType.Tower:
        entrance = (DungeonEntrance) new TowerDungeonEntrance(settings);
        break;
      default:
        entrance = (DungeonEntrance) new LegacyDungeonEntrance(settings);
        break;
    }
    if (addToData && entrance != null)
      DungeonCrawler.CurrentDungeonData.dungeonEntrance = entrance;
    return entrance;
  }
}
