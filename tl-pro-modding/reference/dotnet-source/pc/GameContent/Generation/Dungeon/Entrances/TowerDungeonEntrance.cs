// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Entrances.TowerDungeonEntrance
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

public class TowerDungeonEntrance(DungeonEntranceSettings settings) : DungeonEntrance(settings)
{
  public override void CalculateEntrance(DungeonData data, int x, int y)
  {
    this.calculated = false;
    this.TowerEntrance(data, x, y, false);
    this.calculated = true;
  }

  public override bool GenerateEntrance(DungeonData data, int x, int y)
  {
    this.generated = false;
    this.TowerEntrance(data, x, y, true);
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

  public void TowerEntrance(DungeonData data, int i, int j, bool generating)
  {
    UnifiedRandom unifiedRandom = new UnifiedRandom(this.settings.RandomSeed);
    ushort brickTileType = this.settings.StyleData.BrickTileType;
    ushort brickWallType = this.settings.StyleData.BrickWallType;
    WindowType windowType;
    switch (unifiedRandom.Next(3))
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
    bool entranceIsBuried = SpecialSeedFeatures.DungeonEntranceIsBuried;
    bool entranceIsUnderground = SpecialSeedFeatures.DungeonEntranceIsUnderground;
    bool leftDungeonDoor = data.genVars.dungeonSide == (int) DungeonSide.Left;
    if (Main.drunkWorld)
      leftDungeonDoor = !leftDungeonDoor;
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
    int innerSize = 35;
    int outerSize = innerSize + num1;
    int depth = 100;
    int num2 = 30;
    int num3 = j - num2;
    int num4 = 30;
    int num5 = 25;
    int num6 = num5 + num1;
    int num7 = 20;
    int num8 = num4 + num7;
    int num9 = 15;
    int num10 = num9 + num1;
    int num11 = 40;
    int num12 = num4 + num7 + num11;
    int minY = num3 - num12;
    int maxY = num3 + 10;
    int num13 = 10;
    int num14 = 50;
    if (data.Type == DungeonType.DualDungeon)
      depth = DungeonUtils.GetDualDungeonBrickSupportCutoffY(data) - num3;
    else if (entranceIsUnderground)
      depth = num14 - num13 + 5;
    if (generating && !entranceIsBuried && !entranceIsUnderground)
    {
      int x = i - innerSize + 1;
      if (leftDungeonDoor)
        x = i + innerSize - 1;
      WorldUtils.Gen(new Point(x, num3 - 15), (GenShape) new Shapes.Circle(15, 15), Terraria.WorldBuilding.Actions.Chain((GenAction) new Terraria.WorldBuilding.Actions.Clear()));
    }
    this.Bounds.UpdateBounds(i - outerSize, minY, i + outerSize + 1, maxY);
    if (generating)
    {
      int num15 = -5;
      int num16 = depth;
      for (int index1 = -outerSize; index1 <= outerSize; ++index1)
      {
        for (int index2 = num15; index2 < num16; ++index2)
        {
          int x = i + index1;
          int y = num3 + index2;
          if (WorldGen.InWorld(x, y))
          {
            Tile tile = Main.tile[x, y];
            bool flag1 = tile.active() && !this.settings.StyleData.TileIsInStyle((int) tile.type);
            bool flag2 = !this.settings.StyleData.WallIsInStyle((int) tile.wall);
            bool flag3 = DungeonUtils.IsConsideredDungeonWall((int) tile.wall);
            if (index2 < 0)
              tile.ClearEverything();
            else if (index2 >= 0 && index2 < 5)
            {
              if (index1 >= -outerSize + num1 && index1 <= -outerSize + num1 * 2 - 1 || index1 >= outerSize - num1 * 2 + 1 && index1 <= outerSize - num1)
              {
                tile.ClearEverything();
                if (!flag3)
                  tile.wall = brickWallType;
              }
              else if (!flag3)
              {
                tile.liquid = (byte) 0;
                tile.active(true);
                tile.type = brickTileType;
                if (index1 != -outerSize && index1 != outerSize)
                  tile.wall = brickWallType;
              }
            }
            else if (index2 >= 5 && index2 < 10)
            {
              if (index1 >= -outerSize + num1 && index1 <= outerSize - num1)
              {
                tile.ClearEverything();
                tile.wall = brickWallType;
              }
              else if (!flag3)
              {
                tile.liquid = (byte) 0;
                tile.active(true);
                tile.type = brickTileType;
                if (index1 != -outerSize && index1 != outerSize)
                  tile.wall = brickWallType;
              }
            }
            else if (tile.active() & flag1 || !flag3)
            {
              tile.liquid = (byte) 0;
              tile.active(true);
              tile.type = brickTileType;
              if (index1 != -outerSize && index1 != outerSize)
                tile.wall = brickWallType;
            }
            else if (flag2)
            {
              tile.liquid = (byte) 0;
              if (index1 != -outerSize && index1 != outerSize)
                tile.wall = brickWallType;
            }
            if (index2 == 1 && (index1 == -outerSize + num1 || index1 == outerSize - num1 * 2))
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
      int num17 = -1;
      int num18 = 6;
      for (; num13 < num14; ++num13)
      {
        Tile tile1 = Main.tile[i, num3 + num13];
        if (num17 == -1 && !tile1.active())
          num17 = 15;
        if (num17 > 0)
        {
          --num17;
          if (num17 > 0)
          {
            if (num17 <= 5)
              --num18;
          }
          else
            break;
        }
        for (int index = -num18; index <= num18; ++index)
        {
          Tile tile2 = Main.tile[i + index, num3 + num13];
          tile2.ClearEverything();
          if (!DungeonUtils.IsConsideredDungeonWall((int) tile2.wall))
            tile2.wall = brickWallType;
        }
      }
    }
    if (generating)
    {
      for (int index3 = -outerSize; index3 <= outerSize; ++index3)
      {
        int x = i + index3;
        for (int index4 = 0; index4 <= num12; ++index4)
        {
          int y = num3 - index4;
          if (WorldGen.InWorld(x, y, 5))
          {
            Tile tile = Main.tile[x, y];
            if (index4 >= 0 && index4 <= num4)
            {
              if (index3 >= -innerSize && index3 <= innerSize)
              {
                DungeonUtils.ChangeWallType(tile, brickWallType, true);
              }
              else
              {
                if (index3 > -outerSize && index3 < outerSize)
                  DungeonUtils.ChangeWallType(tile, brickWallType, true);
                DungeonUtils.ChangeTileType(tile, brickTileType, false);
              }
              if (index4 >= num4 - num1 && (index3 < -num5 || index3 > num5))
                DungeonUtils.ChangeTileType(tile, brickTileType, false);
            }
            else if (index4 >= num4 - num1 && index4 <= num8 && index3 >= -num6 && index3 <= num6)
            {
              if (index3 >= -num5 && index3 <= num5)
              {
                DungeonUtils.ChangeWallType(tile, brickWallType, true);
              }
              else
              {
                if (index3 > -num6 && index3 < num6)
                  DungeonUtils.ChangeWallType(tile, brickWallType, true);
                DungeonUtils.ChangeTileType(tile, brickTileType, false);
              }
              if (index4 >= num8 - num1 && (index3 < -num9 || index3 > num9))
                DungeonUtils.ChangeTileType(tile, brickTileType, false);
            }
            else if (index4 >= num8 - num1 && index4 <= num12 && index3 >= -num10 && index3 <= num10)
            {
              if (index3 >= -num9 && index3 <= num9)
              {
                DungeonUtils.ChangeWallType(tile, brickWallType, true);
              }
              else
              {
                if (index3 > -num10 && index3 < num10)
                  DungeonUtils.ChangeWallType(tile, brickWallType, true);
                DungeonUtils.ChangeTileType(tile, brickTileType, false);
              }
              if (index4 >= num12 - num1)
                DungeonUtils.ChangeTileType(tile, brickTileType, false);
            }
          }
        }
      }
    }
    DungeonPillarSettings settings1 = new DungeonPillarSettings()
    {
      Style = this.settings.StyleData,
      PillarType = PillarType.Block,
      Width = 3,
      Height = 0,
      CrowningOnTop = true,
      CrowningOnBottom = true,
      CrowningStopsAtPillar = false,
      AlwaysPlaceEntirePillar = true
    };
    if (generating)
    {
      settings1.PillarType = PillarType.BlockActuated;
      new DungeonPillar((DungeonFeatureSettings) settings1).GenerateFeature(data, i - num5 - 3, num3);
      new DungeonPillar((DungeonFeatureSettings) settings1).GenerateFeature(data, i + num5 + 3, num3);
      new DungeonPillar((DungeonFeatureSettings) settings1).GenerateFeature(data, i - num9 - 3, num3);
      new DungeonPillar((DungeonFeatureSettings) settings1).GenerateFeature(data, i + num9 + 3, num3);
    }
    if (generating)
    {
      DungeonUtils.GenerateBottomWedge(i - outerSize - 4, num3 - num4, 5, brickTileType, crowningBottom: true);
      this.TowerEntrance_OuterPillar(data, i - outerSize - 4, num3 - num4, brickTileType);
      DungeonUtils.GenerateBottomWedge(i - num6 - 4, num3 - num8, 5, brickTileType, crowningBottom: true);
      this.TowerEntrance_OuterPillar(data, i - num6 - 4, num3 - num8, brickTileType);
      DungeonUtils.GenerateBottomWedge(i - num10 - 4, num3 - num12, 5, brickTileType, crowningBottom: true);
      this.TowerEntrance_OuterPillar(data, i - num10 - 4, num3 - num12, brickTileType);
      DungeonUtils.GenerateBottomWedge(i + outerSize + 3, num3 - num4, 5, brickTileType, false, crowningBottom: true);
      this.TowerEntrance_OuterPillar(data, i + outerSize + 4, num3 - num4, brickTileType);
      DungeonUtils.GenerateBottomWedge(i + num6 + 3, num3 - num8, 5, brickTileType, false, crowningBottom: true);
      this.TowerEntrance_OuterPillar(data, i + num6 + 4, num3 - num8, brickTileType);
      DungeonUtils.GenerateBottomWedge(i + num10 + 3, num3 - num12, 5, brickTileType, false, crowningBottom: true);
      this.TowerEntrance_OuterPillar(data, i + num10 + 4, num3 - num12, brickTileType);
    }
    if (generating)
    {
      settings1.PillarType = PillarType.Block;
      settings1.CrowningOnTop = false;
      settings1.CrowningOnBottom = false;
      settings1.Width = 5;
      settings1.Height = 2;
      new DungeonPillar((DungeonFeatureSettings) settings1).GenerateFeature(data, i - outerSize + 5, num3 - num4 - 1);
      this.TowerEntrance_LineOfFence(i - outerSize - 2, i - num6 + 1, num3 - num4 - 1);
      new DungeonPillar((DungeonFeatureSettings) settings1).GenerateFeature(data, i - num6 + 5, num3 - num8 - 1);
      this.TowerEntrance_LineOfFence(i - num6 - 2, i - num10 + 1, num3 - num8 - 1);
      new DungeonPillar((DungeonFeatureSettings) settings1).GenerateFeature(data, i - num10 + 5, num3 - num12 - 1);
      new DungeonPillar((DungeonFeatureSettings) settings1).GenerateFeature(data, i - num10 + 13, num3 - num12 - 1);
      new DungeonPillar((DungeonFeatureSettings) settings1).GenerateFeature(data, i + outerSize - 5, num3 - num4 - 1);
      this.TowerEntrance_LineOfFence(i + num6 - 1, i + outerSize + 2, num3 - num4 - 1);
      new DungeonPillar((DungeonFeatureSettings) settings1).GenerateFeature(data, i + num6 - 5, num3 - num8 - 1);
      this.TowerEntrance_LineOfFence(i + num10 - 1, i + num6 + 2, num3 - num8 - 1);
      new DungeonPillar((DungeonFeatureSettings) settings1).GenerateFeature(data, i + num10 - 5, num3 - num12 - 1);
      new DungeonPillar((DungeonFeatureSettings) settings1).GenerateFeature(data, i + num10 - 13, num3 - num12 - 1);
      this.TowerEntrance_LineOfFence(i - num10 - 2, i + num10 + 2, num3 - num12 - 1);
      DungeonUtils.GenerateBottomWedge(i - num9, num3 - num12 + num1, 3, brickTileType, false, crowningBottom: true);
      DungeonUtils.GenerateBottomWedge(i + num9 - 1, num3 - num12 + num1, 3, brickTileType, crowningBottom: true);
    }
    if (generating)
    {
      this.TowerEntrance_AddPlatform(data, new Point(i - num6 - 2, num3 - num4 + 15));
      this.TowerEntrance_AddPlatform(data, new Point(i - num6 - 2, num3 - num4 + 21));
      this.TowerEntrance_AddPlatform(data, new Point(i - num10 - 2, num3 - num8 + 15));
      this.TowerEntrance_AddPlatform(data, new Point(i - num10 - 2, num3 - num8 + 21));
      this.TowerEntrance_AddPlatform(data, new Point(i + num6 + 2, num3 - num4 + 15));
      this.TowerEntrance_AddPlatform(data, new Point(i + num6 + 2, num3 - num4 + 21));
      this.TowerEntrance_AddPlatform(data, new Point(i + num10 + 2, num3 - num8 + 15));
      this.TowerEntrance_AddPlatform(data, new Point(i + num10 + 2, num3 - num8 + 21));
      this.TowerEntrance_AddPlatform(data, new Point(i, num3 - num8 + num1 - 3));
    }
    if (generating)
    {
      int x = i;
      int num19 = num3 - num12 + 20;
      DungeonWindowBasicSettings windowBasicSettings = new DungeonWindowBasicSettings();
      windowBasicSettings.Style = this.settings.StyleData;
      windowBasicSettings.Width = 5;
      windowBasicSettings.Height = 24;
      windowBasicSettings.Closed = entranceIsUnderground;
      DungeonWindowBasicSettings settings2 = windowBasicSettings;
      DungeonWindowMosaicSettings windowMosaicSettings = new DungeonWindowMosaicSettings();
      windowMosaicSettings.Style = this.settings.StyleData;
      windowMosaicSettings.Closed = entranceIsUnderground;
      windowMosaicSettings.MosaicType = windowType;
      DungeonWindowMosaicSettings settings3 = windowMosaicSettings;
      switch (windowType)
      {
        case WindowType.RegularWindows:
          new DungeonWindowBasic((DungeonFeatureSettings) settings2).GenerateFeature(data, x - 9, num19 + 4);
          new DungeonWindowBasic((DungeonFeatureSettings) settings2).GenerateFeature(data, x + 9, num19 + 4);
          settings2.Height = 28;
          new DungeonWindowBasic((DungeonFeatureSettings) settings2).GenerateFeature(data, x, num19 + 3);
          break;
        case WindowType.SkeletronMosaic:
          if (!entranceIsUnderground)
            settings3.OverrideGlassType = 89;
          settings3.OverrideGlassPaint = 26;
          new DungeonWindowMosaic((DungeonFeatureSettings) settings3).GenerateFeature(data, x, num19 - 1);
          break;
        case WindowType.MoonLordMosaic:
          if (!entranceIsUnderground)
            settings3.OverrideGlassType = 91;
          new DungeonWindowMosaic((DungeonFeatureSettings) settings3).GenerateFeature(data, x, num19 + 5);
          break;
      }
      settings2.Width = 9;
      settings2.Height = 24;
      new DungeonWindowBasic((DungeonFeatureSettings) settings2).GenerateFeature(data, x - 8, num3 - 16 /*0x10*/);
      new DungeonWindowBasic((DungeonFeatureSettings) settings2).GenerateFeature(data, x + 8, num3 - 16 /*0x10*/);
      settings2.Width = 7;
      settings2.Height = 11;
      new DungeonWindowBasic((DungeonFeatureSettings) settings2).GenerateFeature(data, x - 10, num3 - 37);
      new DungeonWindowBasic((DungeonFeatureSettings) settings2).GenerateFeature(data, x + 10, num3 - 37);
      settings2.Height = 13;
      new DungeonWindowBasic((DungeonFeatureSettings) settings2).GenerateFeature(data, x, num3 - 39);
    }
    if (generating)
    {
      this.TowerEntrance_Door(data, i, num3, outerSize, innerSize, leftDungeonDoor, entranceIsBuried);
      this.TowerEntrance_Door(data, i, num3, outerSize, innerSize, !leftDungeonDoor, entranceIsBuried);
    }
    this.OldManSpawn = DungeonUtils.SetOldManSpawnAndSpawnOldManIfDefaultDungeon(i, num3, generating);
    if (generating && SpecialSeedFeatures.DungeonEntranceHasATree)
      DungeonUtils.GenerateDungeonTree(data, i, (int) Main.worldSurface, num3 - num12 + 8, false);
    if (generating && SpecialSeedFeatures.DungeonEntranceHasStairs)
    {
      int i1 = i + outerSize;
      DungeonUtils.GenerateDungeonStairs(data, i1, num3, 1, brickTileType, brickWallType, depth);
      int i2 = i - outerSize;
      DungeonUtils.GenerateDungeonStairs(data, i2, num3, -1, brickTileType, brickWallType, depth);
    }
    this.Bounds.CalculateHitbox();
  }

  public void TowerEntrance_Door(
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

  public void TowerEntrance_LineOfFence(int leftX, int rightX, int y)
  {
    if (y <= 10)
      return;
    for (int i = leftX; i <= rightX; ++i)
    {
      if (leftX >= 10 && rightX <= Main.maxTilesX - 10)
        WorldGen.PlaceWall(i, y, 245, true);
    }
  }

  public void TowerEntrance_OuterPillar(
    DungeonData data,
    int pillarX,
    int pillarY,
    ushort tileType)
  {
    DungeonPillarSettings settings = new DungeonPillarSettings();
    settings.Style = this.settings.StyleData;
    settings.PillarType = PillarType.Block;
    settings.Width = 7;
    settings.Height = 3;
    new DungeonPillar((DungeonFeatureSettings) settings).GenerateFeature(data, pillarX, pillarY - 1);
    settings.Width = 5;
    settings.Height = 7;
    new DungeonPillar((DungeonFeatureSettings) settings).GenerateFeature(data, pillarX, pillarY - 4);
    if (pillarY - 11 >= 10)
      WorldGen.PlaceTile(pillarX, pillarY - 11, 215, true);
    for (int index = 0; index < 5; ++index)
      WorldGen.PlaceWall(pillarX - 2 + index, pillarY - 11, 245, true);
    if (pillarY - 12 >= 10)
    {
      WorldGen.PlaceWall(pillarX - 2, pillarY - 12, 245, true);
      WorldGen.PlaceWall(pillarX + 2, pillarY - 12, 245, true);
    }
    if (pillarY - 10 < 10)
      return;
    WorldGen.PlaceWall(pillarX - 2, pillarY - 10, 245, true);
    WorldGen.PlaceWall(pillarX + 2, pillarY - 10, 245, true);
  }

  public void TowerEntrance_TreeOnPillar(UnifiedRandom genRand, int pillarX, int pillarY)
  {
    int num1 = 5;
    int num2 = num1 / 2;
    for (int index1 = 0; index1 < num1; ++index1)
    {
      int x = pillarX + index1 - num2;
      for (int index2 = 0; index2 <= 3; ++index2)
      {
        int y = pillarY + index2;
        if (y > 10)
        {
          if ((index2 != 1 || genRand.Next(2) != 0) && (index2 != 2 || genRand.Next(3) == 0) && (index2 != 3 || genRand.Next(4) == 0))
            Main.tile[x, y].type = !WorldGen.TileIsExposedToAir(x, y) ? (ushort) 0 : (ushort) 2;
        }
        else
          break;
      }
    }
    if (pillarY <= 10)
      return;
    WorldGen.TryGrowingTreeByType(5, pillarX, pillarY, ignoreWalls: true);
  }

  public void TowerEntrance_AddPlatform(DungeonData data, Point position)
  {
    DungeonPlatformData dungeonPlatformData = new DungeonPlatformData()
    {
      Position = position,
      OverrideHeightFluff = new int?(0),
      ForcePlacement = true,
      PlacePotsChance = 0.33000001311302185,
      PlaceBooksChance = 0.75,
      PlacePotionBottlesChance = 0.10000000149011612,
      NoWaterbolt = true
    };
    data.dungeonPlatformData.Add(dungeonPlatformData);
  }
}
