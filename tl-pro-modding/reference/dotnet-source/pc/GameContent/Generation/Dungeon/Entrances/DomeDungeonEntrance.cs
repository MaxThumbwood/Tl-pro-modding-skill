// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Entrances.DomeDungeonEntrance
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.GameContent.Generation.Dungeon.Features;
using Terraria.Utilities;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Entrances;

public class DomeDungeonEntrance(DungeonEntranceSettings settings) : DungeonEntrance(settings)
{
  public override void CalculateEntrance(DungeonData data, int x, int y)
  {
    this.calculated = false;
    this.DomeEntrance(data, x, y, false);
    this.calculated = true;
  }

  public override bool GenerateEntrance(DungeonData data, int x, int y)
  {
    this.generated = false;
    this.DomeEntrance(data, x, y, true);
    this.generated = true;
    return true;
  }

  public override bool CanGenerateFeatureAt(
    DungeonData data,
    IDungeonFeature feature,
    int x,
    int y)
  {
    switch (feature)
    {
      case DungeonGlobalBookshelves _:
      case DungeonGlobalPaintings _:
      case DungeonGlobalSpikes _:
        return false;
      default:
        return base.CanGenerateFeatureAt(data, feature, x, y);
    }
  }

  public void DomeEntrance(DungeonData data, int i, int j, bool generating)
  {
    UnifiedRandom genRand = new UnifiedRandom(this.settings.RandomSeed);
    ushort brickTileType = this.settings.StyleData.BrickTileType;
    ushort brickWallType = this.settings.StyleData.BrickWallType;
    bool entranceIsBuried = SpecialSeedFeatures.DungeonEntranceIsBuried;
    bool entranceIsUnderground = SpecialSeedFeatures.DungeonEntranceIsUnderground;
    bool leftDungeonDoor = data.genVars.dungeonSide == (int) DungeonSide.Left;
    if (Main.drunkWorld)
      leftDungeonDoor = !leftDungeonDoor;
    bool flag1 = genRand.Next(4) != 0;
    WindowType windowType;
    switch (genRand.Next(3))
    {
      case 1:
        windowType = WindowType.SkeletronMosaic;
        break;
      case 2:
        windowType = WindowType.MoonLordMosaic;
        break;
      default:
        windowType = WindowType.RegularWindows;
        break;
    }
    this.Bounds.SetBounds(i, j, i, j);
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
    int num1 = 5;
    int num2 = 35;
    int num3 = num2 + num1;
    int depth = 100;
    int num4 = 30;
    int num5 = j - num4;
    int num6 = 10;
    int num7 = 50;
    if (data.Type == DungeonType.DualDungeon)
      depth = DungeonUtils.GetDualDungeonBrickSupportCutoffY(data) - num5;
    else if (entranceIsUnderground)
      depth = num7 - num6 + 5;
    if (generating && !entranceIsBuried && !entranceIsUnderground)
    {
      int x = i - num3 + 1;
      if (leftDungeonDoor)
        x = i + num3 - 1;
      int num8 = 20;
      WorldUtils.Gen(new Point(x, num5 - num8), (GenShape) new Shapes.Circle(num8, num8), Terraria.WorldBuilding.Actions.Chain((GenAction) new Terraria.WorldBuilding.Actions.Clear()));
    }
    this.Bounds.UpdateBounds(i - num3, num5 - num3, i + num3 + 1, num5 + 10);
    if (generating)
    {
      int num9 = -5;
      int num10 = depth;
      for (int index1 = -num3; index1 <= num3; ++index1)
      {
        for (int index2 = num9; index2 < num10; ++index2)
        {
          int x = i + index1;
          int y = num5 + index2;
          if (WorldGen.InWorld(x, y))
          {
            Tile tile = Main.tile[x, y];
            bool flag2 = tile.active() && !this.settings.StyleData.TileIsInStyle((int) tile.type);
            bool flag3 = !this.settings.StyleData.WallIsInStyle((int) tile.wall);
            bool flag4 = DungeonUtils.IsConsideredDungeonWall((int) tile.wall);
            if (index2 < 0)
              tile.ClearEverything();
            else if (index2 >= 0 && index2 < 5)
            {
              if (index1 >= -num2 + num1 && index1 <= -num2 + num1 * 2 || index1 >= num2 - num1 * 2 && index1 <= num2 - num1)
              {
                tile.ClearEverything();
                if (!flag4)
                  tile.wall = brickWallType;
              }
              else if (!flag4)
              {
                tile.liquid = (byte) 0;
                tile.active(true);
                tile.type = brickTileType;
                if (index1 != -num3 && index1 != num3)
                  tile.wall = brickWallType;
              }
            }
            else if (index2 >= 5 && index2 < 10)
            {
              if (index1 >= -num2 + num1 && index1 <= num2 - num1)
              {
                tile.ClearEverything();
                tile.wall = brickWallType;
              }
              else if (!flag4)
              {
                tile.liquid = (byte) 0;
                tile.active(true);
                tile.type = brickTileType;
                if (index1 != -num3 && index1 != num3)
                  tile.wall = brickWallType;
              }
            }
            else if (tile.active() & flag2 || !flag4)
            {
              tile.liquid = (byte) 0;
              tile.active(true);
              tile.type = brickTileType;
              if (index1 != -num3 && index1 != num3)
                tile.wall = brickWallType;
            }
            else if (flag3)
            {
              tile.liquid = (byte) 0;
              if (index1 != -num3 && index1 != num3)
                tile.wall = brickWallType;
            }
            if (index2 == 1 && (index1 == -num2 + num1 || index1 == num2 - num1 * 2))
            {
              DungeonPlatformData dungeonPlatformData = new DungeonPlatformData()
              {
                Position = new Point(x, y),
                OverrideHeightFluff = new int?(0),
                ForcePlacement = true,
                PlacePotsChance = 0.33000001311302185
              };
              data.dungeonPlatformData.Add(dungeonPlatformData);
            }
            if (index2 == 10 && index1 == 0)
            {
              DungeonPlatformData dungeonPlatformData = new DungeonPlatformData()
              {
                Position = new Point(x, y),
                OverrideHeightFluff = new int?(0),
                ForcePlacement = true,
                PlacePotsChance = 0.33000001311302185
              };
              data.dungeonPlatformData.Add(dungeonPlatformData);
            }
          }
        }
      }
      int num11 = -1;
      int num12 = 6;
      for (; num6 < num7; ++num6)
      {
        Tile tile1 = Main.tile[i, num5 + num6];
        if (num11 == -1 && !tile1.active())
          num11 = 15;
        if (num11 > 0)
        {
          --num11;
          if (num11 > 0)
          {
            if (num11 <= 5)
              --num12;
          }
          else
            break;
        }
        for (int index = -num12; index <= num12; ++index)
        {
          Tile tile2 = Main.tile[i + index, num5 + num6];
          tile2.ClearEverything();
          if (!DungeonUtils.IsConsideredDungeonWall((int) tile2.wall))
            tile2.wall = brickWallType;
        }
      }
    }
    int y1 = num5 + 1;
    if (generating)
    {
      WorldUtils.Gen(new Point(i, num5), (GenShape) new Shapes.Slime(num3, 1.0, 1.0), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.IsAboveHeight(y1), (GenAction) new Modifiers.SkipWalls(new ushort[1]
      {
        brickWallType
      }), (GenAction) new Terraria.WorldBuilding.Actions.UpdateBounds(data.dungeonBounds), (GenAction) new Terraria.WorldBuilding.Actions.Clear(), (GenAction) new Terraria.WorldBuilding.Actions.SetTile(brickTileType, setNeighborFrames: false, clearTile: false)));
      WorldUtils.Gen(new Point(i, num5), (GenShape) new Shapes.Slime(num3 - 2, 1.0, 1.0), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.IsAboveHeight(y1 + 1), (GenAction) new Terraria.WorldBuilding.Actions.SetWall(brickWallType, setNeighborFrames: false, clearTile: false)));
    }
    if (generating)
    {
      ushort type1 = 0;
      int type2 = 2;
      if (WorldGen.SecretSeed.surfaceIsDesert.Enabled)
      {
        type1 = (ushort) 53;
        type2 = -1;
      }
      WorldUtils.Gen(new Point(i, num5 - num1 + 1), (GenShape) new Shapes.Slime(num3, 0.89999997615814209, 1.1000000238418579), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.IsAboveHeight(y1 - 2), (GenAction) new Modifiers.SkipTiles(new ushort[1]
      {
        brickTileType
      }), (GenAction) new Modifiers.SkipWalls(new ushort[1]
      {
        brickWallType
      }), (GenAction) new Terraria.WorldBuilding.Actions.Clear(), (GenAction) new Terraria.WorldBuilding.Actions.SetTile(type1, setNeighborFrames: false, clearTile: false)));
      if (!entranceIsUnderground && type2 > -1)
        WorldUtils.Gen(new Point(i, num5 - num1 + 1), (GenShape) new Shapes.Slime(num3, 0.89999997615814209, 1.1000000238418579), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.IsAboveHeight(y1 - 2), (GenAction) new Modifiers.OnlyTiles(new ushort[1]
        {
          type1
        }), (GenAction) new Modifiers.IsTouchingAir(true), (GenAction) new Terraria.WorldBuilding.Actions.SetTile((ushort) type2, setNeighborFrames: false, clearTile: false)));
    }
    if (generating)
      WorldUtils.Gen(new Point(i, num5), (GenShape) new Shapes.Slime(num2, 1.0, 1.0), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.IsAboveHeight(y1), (GenAction) new Terraria.WorldBuilding.Actions.ClearTile()));
    if (generating)
    {
      this.DomeEntrance_Door(data, i, num5, num3, num2, leftDungeonDoor, entranceIsBuried);
      if (entranceIsBuried | entranceIsUnderground)
        this.DomeEntrance_Door(data, i, num5, num3, num2, !leftDungeonDoor, entranceIsBuried);
    }
    if (generating)
    {
      DungeonWindowBasicSettings windowBasicSettings = new DungeonWindowBasicSettings();
      windowBasicSettings.Style = this.settings.StyleData;
      windowBasicSettings.Width = 5;
      windowBasicSettings.Height = 24;
      windowBasicSettings.Closed = entranceIsUnderground;
      DungeonWindowBasicSettings settings1 = windowBasicSettings;
      DungeonWindowMosaicSettings windowMosaicSettings = new DungeonWindowMosaicSettings();
      windowMosaicSettings.Style = this.settings.StyleData;
      windowMosaicSettings.Closed = entranceIsUnderground;
      windowMosaicSettings.MosaicType = windowType;
      DungeonWindowMosaicSettings settings2 = windowMosaicSettings;
      switch (windowType)
      {
        case WindowType.RegularWindows:
          new DungeonWindowBasic((DungeonFeatureSettings) settings1).GenerateFeature(data, i - 8, num5 - 16 /*0x10*/);
          new DungeonWindowBasic((DungeonFeatureSettings) settings1).GenerateFeature(data, i + 8, num5 - 16 /*0x10*/);
          settings1.Height = 28;
          new DungeonWindowBasic((DungeonFeatureSettings) settings1).GenerateFeature(data, i, num5 - 17);
          settings1.Height = 10;
          new DungeonWindowBasic((DungeonFeatureSettings) settings1).GenerateFeature(data, i - num2 + 6, num5 - 8);
          new DungeonWindowBasic((DungeonFeatureSettings) settings1).GenerateFeature(data, i + num2 - 6, num5 - 8);
          settings1.Height = 11;
          new DungeonWindowBasic((DungeonFeatureSettings) settings1).GenerateFeature(data, i - num2 + 15, num5 - 11);
          new DungeonWindowBasic((DungeonFeatureSettings) settings1).GenerateFeature(data, i + num2 - 15, num5 - 11);
          break;
        case WindowType.SkeletronMosaic:
          if (!entranceIsUnderground)
            settings2.OverrideGlassType = 89;
          settings2.OverrideGlassPaint = 26;
          new DungeonWindowMosaic((DungeonFeatureSettings) settings2).GenerateFeature(data, i, num5 - 19);
          settings1.OverrideGlassPaint = 26;
          settings1.Height = 10;
          new DungeonWindowBasic((DungeonFeatureSettings) settings1).GenerateFeature(data, i - num2 + 6, num5 - 8);
          new DungeonWindowBasic((DungeonFeatureSettings) settings1).GenerateFeature(data, i + num2 - 6, num5 - 8);
          settings1.Height = 11;
          new DungeonWindowBasic((DungeonFeatureSettings) settings1).GenerateFeature(data, i - num2 + 15, num5 - 11);
          new DungeonWindowBasic((DungeonFeatureSettings) settings1).GenerateFeature(data, i + num2 - 15, num5 - 11);
          break;
        case WindowType.MoonLordMosaic:
          if (!entranceIsUnderground)
            settings2.OverrideGlassType = 91;
          new DungeonWindowMosaic((DungeonFeatureSettings) settings2).GenerateFeature(data, i, num5 - 17);
          settings1.Height = 10;
          if (!entranceIsUnderground)
            settings1.OverrideGlassType = 241;
          new DungeonWindowBasic((DungeonFeatureSettings) settings1).GenerateFeature(data, i - num2 + 6, num5 - 8);
          settings1.OverrideGlassType = 91;
          new DungeonWindowBasic((DungeonFeatureSettings) settings1).GenerateFeature(data, i + num2 - 6, num5 - 8);
          settings1.Height = 11;
          if (!entranceIsUnderground)
            settings1.OverrideGlassType = 90;
          new DungeonWindowBasic((DungeonFeatureSettings) settings1).GenerateFeature(data, i - num2 + 15, num5 - 11);
          if (!entranceIsUnderground)
            settings1.OverrideGlassType = 88;
          new DungeonWindowBasic((DungeonFeatureSettings) settings1).GenerateFeature(data, i + num2 - 15, num5 - 11);
          break;
      }
    }
    DungeonPillarSettings settings = new DungeonPillarSettings()
    {
      Style = this.settings.StyleData,
      PillarType = PillarType.BlockActuated,
      Width = 3,
      Height = 0,
      CrowningOnTop = true,
      CrowningOnBottom = true,
      CrowningStopsAtPillar = false,
      AlwaysPlaceEntirePillar = true
    };
    if (generating)
    {
      new DungeonPillar((DungeonFeatureSettings) settings).GenerateFeature(data, i - num2 + 21, num5);
      new DungeonPillar((DungeonFeatureSettings) settings).GenerateFeature(data, i + num2 - 21, num5);
      DungeonPlatformData dungeonPlatformData1 = new DungeonPlatformData();
      dungeonPlatformData1.Position = new Point(i - num2 + 15, num5 - 25);
      dungeonPlatformData1.OverrideHeightFluff = new int?(0);
      dungeonPlatformData1.ForcePlacement = true;
      dungeonPlatformData1.PlacePotsChance = 0.33000001311302185;
      dungeonPlatformData1.PlaceBooksChance = 0.75;
      dungeonPlatformData1.PlacePotionBottlesChance = 0.10000000149011612;
      dungeonPlatformData1.NoWaterbolt = true;
      DungeonPlatformData dungeonPlatformData2 = dungeonPlatformData1;
      data.dungeonPlatformData.Add(dungeonPlatformData2);
      dungeonPlatformData1 = new DungeonPlatformData();
      dungeonPlatformData1.Position = new Point(i + num2 - 15, num5 - 25);
      dungeonPlatformData1.OverrideHeightFluff = new int?(0);
      dungeonPlatformData1.ForcePlacement = true;
      dungeonPlatformData1.PlacePotsChance = 0.33000001311302185;
      dungeonPlatformData1.PlaceBooksChance = 0.75;
      dungeonPlatformData1.PlacePotionBottlesChance = 0.10000000149011612;
      dungeonPlatformData1.NoWaterbolt = true;
      DungeonPlatformData dungeonPlatformData3 = dungeonPlatformData1;
      data.dungeonPlatformData.Add(dungeonPlatformData3);
      dungeonPlatformData1 = new DungeonPlatformData();
      dungeonPlatformData1.Position = new Point(i - num2 + 15, num5 - 20);
      dungeonPlatformData1.OverrideHeightFluff = new int?(0);
      dungeonPlatformData1.ForcePlacement = true;
      dungeonPlatformData1.PlacePotsChance = 0.33000001311302185;
      dungeonPlatformData1.PlaceBooksChance = 0.75;
      dungeonPlatformData1.PlacePotionBottlesChance = 0.10000000149011612;
      DungeonPlatformData dungeonPlatformData4 = dungeonPlatformData1;
      data.dungeonPlatformData.Add(dungeonPlatformData4);
      dungeonPlatformData1 = new DungeonPlatformData();
      dungeonPlatformData1.Position = new Point(i + num2 - 15, num5 - 20);
      dungeonPlatformData1.OverrideHeightFluff = new int?(0);
      dungeonPlatformData1.ForcePlacement = true;
      dungeonPlatformData1.PlacePotsChance = 0.33000001311302185;
      dungeonPlatformData1.PlaceBooksChance = 0.75;
      dungeonPlatformData1.PlacePotionBottlesChance = 0.10000000149011612;
      DungeonPlatformData dungeonPlatformData5 = dungeonPlatformData1;
      data.dungeonPlatformData.Add(dungeonPlatformData5);
    }
    if (generating)
    {
      int num13 = 16 /*0x10*/;
      settings.PillarType = PillarType.Block;
      settings.CrowningOnTop = false;
      settings.CrowningOnBottom = false;
      settings.Width = 5;
      settings.Height = num13;
      new DungeonPillar((DungeonFeatureSettings) settings).GenerateFeature(data, i - num3 + 2, num5 - 10);
      new DungeonPillar((DungeonFeatureSettings) settings).GenerateFeature(data, i + num3 - 2, num5 - 10);
      settings.Width = 4;
      settings.Height = num13 - 2;
      new DungeonPillar((DungeonFeatureSettings) settings).GenerateFeature(data, i - num2 + 8, num5 - 28);
      new DungeonPillar((DungeonFeatureSettings) settings).GenerateFeature(data, i + num2 - 8, num5 - 28);
      settings.Width = 3;
      settings.Height = num13 - 3;
      new DungeonPillar((DungeonFeatureSettings) settings).GenerateFeature(data, i - num2 + 21, num5 - 37);
      new DungeonPillar((DungeonFeatureSettings) settings).GenerateFeature(data, i + num2 - 21, num5 - 37);
      if (flag1)
      {
        this.DomeEntrance_TreeOnPillar(genRand, i - num3 + 2, num5 - 10 - num13 + 1);
        this.DomeEntrance_TreeOnPillar(genRand, i - num2 + 8, num5 - 28 - num13 + 2 + 1);
        this.DomeEntrance_TreeOnPillar(genRand, i - num2 + 21, num5 - 37 - num13 + 3 + 1);
        this.DomeEntrance_TreeOnPillar(genRand, i + num3 - 2, num5 - 10 - num13 + 1);
        this.DomeEntrance_TreeOnPillar(genRand, i + num2 - 8, num5 - 28 - num13 + 2 + 1);
        this.DomeEntrance_TreeOnPillar(genRand, i + num2 - 21, num5 - 37 - num13 + 3 + 1);
      }
    }
    this.OldManSpawn = DungeonUtils.SetOldManSpawnAndSpawnOldManIfDefaultDungeon(i, num5, generating);
    if (generating && SpecialSeedFeatures.DungeonEntranceHasATree)
      DungeonUtils.GenerateDungeonTree(data, i, (int) Main.worldSurface, num5 - num2 + 5, false);
    if (generating && SpecialSeedFeatures.DungeonEntranceHasStairs)
    {
      int i1 = leftDungeonDoor ? i + num3 : i - num3;
      DungeonUtils.GenerateDungeonStairs(data, i1, num5, leftDungeonDoor ? 1 : -1, brickTileType, brickWallType, depth);
    }
    this.Bounds.CalculateHitbox();
  }

  public void DomeEntrance_Door(
    DungeonData data,
    int i,
    int entranceFloor,
    int outerSize,
    int innerSize,
    bool leftDungeonDoor,
    bool buried)
  {
    int num1 = leftDungeonDoor ? innerSize - 1 : -outerSize - 2;
    int num2 = leftDungeonDoor ? outerSize + 2 : -innerSize + 1;
    if (buried)
    {
      num1 += 2 * (leftDungeonDoor ? 0 : 1);
      num2 += 2 * (leftDungeonDoor ? -1 : 0);
    }
    Point point1 = new Point(i + (leftDungeonDoor ? outerSize - 1 : -outerSize + 1), entranceFloor);
    Point point2 = new Point(i + (leftDungeonDoor ? innerSize + 1 : -innerSize - 1), entranceFloor);
    for (int index1 = num1; index1 <= num2; ++index1)
    {
      for (int index2 = -3; index2 <= 1; ++index2)
      {
        int index3 = index1 + i;
        int index4 = index2 + entranceFloor;
        Tile tile = Main.tile[index3, index4];
        if (!buried && (leftDungeonDoor && index3 >= point1.X || !leftDungeonDoor && index3 <= point1.X))
          tile.wall = (ushort) 0;
        if (index2 >= -2 && index2 <= 0)
          tile.ClearTile();
      }
    }
    WorldGen.PlaceTile(point1.X, point1.Y, 10, true, true, style: 13);
    WorldGen.PlaceTile(point2.X, point2.Y, 10, true, true, style: 13);
  }

  public void DomeEntrance_TreeOnPillar(UnifiedRandom genRand, int pillarX, int pillarY)
  {
    if (!WorldGen.InWorld(pillarX, pillarY, 5) || Main.tile[pillarX, pillarY - 1].active())
      return;
    ushort num1 = 0;
    int num2 = 2;
    if (WorldGen.SecretSeed.surfaceIsDesert.Enabled)
    {
      num1 = (ushort) 53;
      num2 = -1;
    }
    int num3 = 5;
    int num4 = num3 / 2;
    for (int index1 = 0; index1 < num3; ++index1)
    {
      int x = pillarX + index1 - num4;
      for (int index2 = 0; index2 <= 3; ++index2)
      {
        int y = pillarY + index2;
        Tile tile = Main.tile[x, y];
        if ((int) tile.wall != (int) this.settings.StyleData.BrickWallType)
          tile.wall = (ushort) 0;
        if ((index2 != 1 || genRand.Next(2) != 0) && (index2 != 2 || genRand.Next(3) == 0) && (index2 != 3 || genRand.Next(4) == 0))
          tile.type = num2 <= -1 || !WorldGen.TileIsExposedToAir(x, y) ? num1 : (ushort) num2;
      }
    }
    if (num1 == (ushort) 53)
      WorldGen.TryGrowingTreeByType(323, pillarX, pillarY, ignoreWalls: true);
    else
      WorldGen.TryGrowingTreeByType(5, pillarX, pillarY, ignoreWalls: true);
  }
}
