// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.DungeonUtils
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria.DataStructures;
using Terraria.GameContent.Generation.Dungeon.Features;
using Terraria.GameContent.Generation.Dungeon.Rooms;
using Terraria.ID;
using Terraria.Utilities;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon;

public class DungeonUtils
{
  public const int DOORSTYLE_WOODEN = 13;
  public const int DOORSTYLE_BLUEBRICK = 16 /*0x10*/;
  public const int DOORSTYLE_GREENBRICK = 17;
  public const int DOORSTYLE_PINKBRICK = 18;
  public const int POTSTYLE_NORMAL_1 = 0;
  public const int POTSTYLE_NORMAL_2 = 1;
  public const int POTSTYLE_NORMAL_3 = 2;
  public const int POTSTYLE_NORMAL_4 = 3;
  public const int POTSTYLE_SKULL_1 = 10;
  public const int POTSTYLE_SKULL_2 = 11;
  public const int POTSTYLE_SKULL_3 = 12;
  public const int CHANDELIERSTYLE_BLUEBRICK = 27;
  public const int CHANDELIERSTYLE_GREENBRICK = 28;
  public const int CHANDELIERSTYLE_PINKBRICK = 29;
  public const int PLATFORMSTYLE_BLUEBRICK = 6;
  public const int PLATFORMSTYLE_GREENBRICK = 8;
  public const int PLATFORMSTYLE_PINKBRICK = 7;
  public const int PLATFORMSTYLE_METALSHELF = 9;
  public const int PLATFORMSTYLE_BRASSSHELF = 10;
  public const int PLATFORMSTYLE_WOODSHELF = 11;
  public const int PLATFORMSTYLE_DUNGEONSHELF = 12;
  public const int BANNERSTYLE_BRICK_MARCHINGBONES = 10;
  public const int BANNERSTYLE_BRICK_NECROMANTICSIGN = 11;
  public const int BANNERSTYLE_SLAB_RUGGEDCOMPANY = 12;
  public const int BANNERSTYLE_SLAB_RAGGEDBROTHERHOOD = 13;
  public const int BANNERSTYLE_TILES_MOLTENLEGION = 14;
  public const int BANNERSTYLE_TILES_DIABOLICSIGIL = 15;
  public const int TRAPTYPE_DART = 0;
  public const double HALLWAY_DOOR_PLACEMENT_VARIANCE = 0.25;
  public const int DUNGEONHALL_DEFAULT_INNER_AREA_DEPTH = 3;
  public const int DUNGEONHALL_DEFAULT_OUTER_WALL_DEPTH = 8;
  public const int DUNGEONROOM_DEFAULT_INNER_AREA_DEPTH = 6;
  public const int DUNGEONROOM_DEFAULT_OUTER_WALL_DEPTH = 8;
  public const int MOSAIC_NONE = 0;
  public const int MOSAIC_SKELETRON = 1;
  public const int MOSAIC_MOONLORD = 2;

  public static void CalculatePlatformsAndDoorsOnEdgesOfRoom(
    DungeonData dungeonData,
    DungeonBounds innerBounds,
    DungeonGenerationStyleData styleData,
    int? doorFluff = null,
    int? platformFluff = null)
  {
    UnifiedRandom genRand = WorldGen.genRand;
    if (styleData == null)
    {
      if (!WorldGen.InWorld(innerBounds.Center.X, innerBounds.Center.Y, 5))
        return;
      Tile tile = Main.tile[innerBounds.Center.X, innerBounds.Center.Y];
      styleData = DungeonGenerationStyles.GetStyleForWall(dungeonData.genVars.dungeonGenerationStyles, (int) tile.wall);
      if (styleData == null && tile.active())
        styleData = DungeonGenerationStyles.GetStyleForTile(dungeonData.genVars.dungeonGenerationStyles, (int) tile.type);
      if (styleData == null)
        styleData = dungeonData.genVars.dungeonStyle;
    }
    bool flag1 = styleData.Style == (byte) 0;
    ushort brickTileType = styleData.BrickTileType;
    ushort brickWallType = styleData.BrickWallType;
    int num1 = Math.Max(5, innerBounds.Left);
    int num2 = Math.Min(Main.maxTilesX - 5, innerBounds.Right);
    int num3 = Math.Max(5, innerBounds.Top);
    int num4 = Math.Min(Main.maxTilesY - 5, innerBounds.Bottom);
    bool flag2 = false;
    bool flag3 = false;
    for (int x = num1; x <= num2; ++x)
    {
      DungeonPlatformData dungeonPlatformData1;
      if (!flag2 && !Main.tile[x, num3 - 1].active())
      {
        dungeonPlatformData1 = new DungeonPlatformData();
        dungeonPlatformData1.Position = new Point(x, num3 - 1);
        dungeonPlatformData1.InAHallway = false;
        dungeonPlatformData1.OverrideStyle = new int?(styleData.GetPlatformStyle(genRand));
        DungeonPlatformData dungeonPlatformData2 = dungeonPlatformData1;
        if (platformFluff.HasValue)
          dungeonPlatformData2.OverrideHeightFluff = new int?(platformFluff.Value);
        dungeonData.dungeonPlatformData.Add(dungeonPlatformData2);
        flag2 = true;
      }
      if (!flag3 && !Main.tile[x, num4 + 1].active())
      {
        dungeonPlatformData1 = new DungeonPlatformData();
        dungeonPlatformData1.Position = new Point(x, num4 + 1);
        dungeonPlatformData1.InAHallway = false;
        dungeonPlatformData1.OverrideStyle = new int?(styleData.GetPlatformStyle(genRand));
        DungeonPlatformData dungeonPlatformData3 = dungeonPlatformData1;
        if (platformFluff.HasValue)
          dungeonPlatformData3.OverrideHeightFluff = new int?(platformFluff.Value);
        dungeonData.dungeonPlatformData.Add(dungeonPlatformData3);
        flag3 = true;
      }
      if (flag2 & flag3)
        break;
    }
    if (styleData.DoorItemTypes == null)
      return;
    int index = flag1 || styleData.DoorItemTypes.Length == 0 ? -1 : styleData.DoorItemTypes[genRand.Next(styleData.DoorItemTypes.Length)];
    bool flag4 = false;
    bool flag5 = false;
    for (int y = num3; y <= num4; ++y)
    {
      DungeonDoorData dungeonDoorData1;
      if (!flag4 && !Main.tile[num1 - 1, y].active())
      {
        bool flag6 = doorFluff.HasValue && doorFluff.Value == 0;
        dungeonDoorData1 = new DungeonDoorData();
        dungeonDoorData1.OverrideBrickTileType = new ushort?(brickTileType);
        dungeonDoorData1.OverrideBrickWallType = new ushort?(brickWallType);
        dungeonDoorData1.Position = new Point(num1 - 1, y);
        dungeonDoorData1.Direction = -1;
        dungeonDoorData1.InAHallway = false;
        dungeonDoorData1.SkipOtherDoorsCheck = flag6;
        dungeonDoorData1.SkipSpaceCheck = flag6;
        dungeonDoorData1.AlwaysClearArea = true;
        DungeonDoorData dungeonDoorData2 = dungeonDoorData1;
        if (doorFluff.HasValue)
          dungeonDoorData2.OverrideWidthFluff = new int?(doorFluff.Value);
        if (index >= 0)
        {
          PlacementDetails derivedPlacementDetail = ItemID.Sets.DerivedPlacementDetails[index];
          dungeonDoorData2.OverrideStyle = new int?((int) derivedPlacementDetail.tileStyle);
        }
        dungeonData.dungeonDoorData.Add(dungeonDoorData2);
        flag4 = true;
      }
      if (!flag5 && !Main.tile[num2 + 1, y].active())
      {
        bool flag7 = doorFluff.HasValue && doorFluff.Value == 0;
        dungeonDoorData1 = new DungeonDoorData();
        dungeonDoorData1.OverrideBrickTileType = new ushort?(brickTileType);
        dungeonDoorData1.OverrideBrickWallType = new ushort?(brickWallType);
        dungeonDoorData1.Position = new Point(num2 + 1, y);
        dungeonDoorData1.Direction = 1;
        dungeonDoorData1.InAHallway = false;
        dungeonDoorData1.SkipOtherDoorsCheck = flag7;
        dungeonDoorData1.SkipSpaceCheck = flag7;
        dungeonDoorData1.AlwaysClearArea = true;
        DungeonDoorData dungeonDoorData3 = dungeonDoorData1;
        if (doorFluff.HasValue)
          dungeonDoorData3.OverrideWidthFluff = new int?(doorFluff.Value);
        if (index >= 0)
        {
          PlacementDetails derivedPlacementDetail = ItemID.Sets.DerivedPlacementDetails[index];
          dungeonDoorData3.OverrideStyle = new int?((int) derivedPlacementDetail.tileStyle);
        }
        dungeonData.dungeonDoorData.Add(dungeonDoorData3);
        flag5 = true;
      }
      if (flag4 & flag5)
        break;
    }
  }

  public static void CalculatePlatformAndDoorsOnHallway(
    DungeonData dungeonData,
    Vector2D hallwayPoint,
    double hallwayDirectionY,
    DungeonGenerationStyleData styleData,
    double doorVariance = 0.1)
  {
    UnifiedRandom genRand = WorldGen.genRand;
    if (styleData == null)
    {
      if (!WorldGen.InWorld((int) hallwayPoint.X, (int) hallwayPoint.Y, 5))
        return;
      Tile tile = Main.tile[(int) hallwayPoint.X, (int) hallwayPoint.Y];
      styleData = DungeonGenerationStyles.GetStyleForWall(dungeonData.genVars.dungeonGenerationStyles, (int) tile.wall);
      if (styleData == null && tile.active())
        styleData = DungeonGenerationStyles.GetStyleForTile(dungeonData.genVars.dungeonGenerationStyles, (int) tile.type);
      if (styleData == null)
        styleData = dungeonData.genVars.dungeonStyle;
    }
    bool flag = styleData.Style == (byte) 0;
    ushort brickTileType = styleData.BrickTileType;
    ushort brickWallType = styleData.BrickWallType;
    if (Math.Abs(hallwayDirectionY) <= doorVariance)
    {
      if (styleData.DoorItemTypes == null)
        return;
      int index = flag || styleData.DoorItemTypes.Length == 0 ? -1 : styleData.DoorItemTypes[genRand.Next(styleData.DoorItemTypes.Length)];
      DungeonDoorData dungeonDoorData = new DungeonDoorData()
      {
        OverrideBrickTileType = new ushort?(brickTileType),
        OverrideBrickWallType = new ushort?(brickWallType),
        Position = hallwayPoint.ToPoint(),
        Direction = 0,
        InAHallway = true,
        AlwaysClearArea = true
      };
      if (index >= 0)
      {
        PlacementDetails derivedPlacementDetail = ItemID.Sets.DerivedPlacementDetails[index];
        dungeonDoorData.OverrideStyle = new int?((int) derivedPlacementDetail.tileStyle);
      }
      dungeonData.dungeonDoorData.Add(dungeonDoorData);
    }
    else
    {
      DungeonPlatformData dungeonPlatformData = new DungeonPlatformData()
      {
        Position = hallwayPoint.ToPoint(),
        InAHallway = true,
        OverrideStyle = new int?(styleData.GetPlatformStyle(genRand))
      };
      dungeonData.dungeonPlatformData.Add(dungeonPlatformData);
    }
  }

  public static void GenerateShimmerPool(int x, int y, int outerShapeSize = 15)
  {
    int num = 5;
    int radius = Math.Max(1, outerShapeSize - num);
    Shapes.HalfCircle shape1 = new Shapes.HalfCircle(outerShapeSize, true);
    Shapes.HalfCircle shape2 = new Shapes.HalfCircle(radius, true);
    Point origin = new Point(x, y + radius);
    WorldUtils.Gen(origin, (GenShape) shape1, Terraria.WorldBuilding.Actions.Chain((GenAction) new Terraria.WorldBuilding.Actions.SetTile((ushort) 667, setNeighborFrames: false, clearTile: false)));
    WorldUtils.Gen(new Point(origin.X, origin.Y - num), (GenShape) shape2, Terraria.WorldBuilding.Actions.Chain((GenAction) new Terraria.WorldBuilding.Actions.ClearTile(), (GenAction) new Terraria.WorldBuilding.Actions.SetLiquid(3)));
  }

  public static bool GenerateDungeonBiomeChest(
    DungeonData data,
    DungeonGlobalBiomeChests feature,
    DungeonGenerationStyleData styleData,
    DungeonBounds innerBounds,
    bool locked = true)
  {
    int left = innerBounds.Left;
    int right = innerBounds.Right;
    int y = innerBounds.Center.Y;
    int bottom = innerBounds.Bottom;
    return DungeonUtils.GenerateDungeonBiomeChest(data, feature, styleData, left, y, right, bottom, locked);
  }

  public static bool GenerateDungeonBiomeChest(
    DungeonData data,
    DungeonGlobalBiomeChests feature,
    DungeonGenerationStyleData styleData,
    int minX,
    int minY,
    int maxX,
    int maxY,
    bool locked = true)
  {
    UnifiedRandom genRand = WorldGen.genRand;
    int num1 = (int) Utils.Lerp((double) minX, (double) maxX, genRand.NextDouble());
    int num2 = (int) Utils.Lerp((double) minY, (double) maxY, genRand.NextDouble());
    if (!data.CanGenerateFeatureInArea((IDungeonFeature) feature, num1, num2, 1))
      return false;
    int mainItemInChest = 0;
    ushort chestTileType = 21;
    int chestStyle = 2;
    if (styleData.BiomeChestLootItemType >= 0)
      mainItemInChest = styleData.BiomeChestLootItemType;
    if (styleData.BiomeChestItemType >= 0)
    {
      PlacementDetails derivedPlacementDetail = ItemID.Sets.DerivedPlacementDetails[styleData.BiomeChestItemType];
      chestTileType = (ushort) derivedPlacementDetail.tileType;
      chestStyle = (int) derivedPlacementDetail.tileStyle;
    }
    if (locked && styleData.LockedBiomeChestStyle >= 0)
      chestStyle = styleData.LockedBiomeChestStyle;
    if (mainItemInChest == 0)
      return false;
    Point chestLocation = Point.Zero;
    return WorldGen.AddBuriedChest(num1, num2, out chestLocation, mainItemInChest, chestStyle: chestStyle, chestTileType: chestTileType);
  }

  public static bool GenerateDungeonRegularChest(
    DungeonData data,
    DungeonGlobalBasicChests feature,
    DungeonGenerationStyleData styleData,
    DungeonBounds innerBounds)
  {
    int left = innerBounds.Left;
    int right = innerBounds.Right;
    int y = innerBounds.Center.Y;
    int bottom = innerBounds.Bottom;
    return DungeonUtils.GenerateDungeonRegularChest(data, feature, styleData, left, y, right, bottom);
  }

  public static bool GenerateDungeonRegularChest(
    DungeonData data,
    DungeonGlobalBasicChests feature,
    DungeonGenerationStyleData styleData,
    int minX,
    int minY,
    int maxX,
    int maxY)
  {
    UnifiedRandom genRand = WorldGen.genRand;
    int num1 = (int) Utils.Lerp((double) minX, (double) maxX, genRand.NextDouble());
    int num2 = (int) Utils.Lerp((double) minY, (double) maxY, genRand.NextDouble());
    if (!data.CanGenerateFeatureInArea((IDungeonFeature) feature, num1, num2, 1))
      return false;
    int itemType = -1;
    ushort chestTileType = 21;
    int chestStyle = 2;
    bool flag = false;
    switch (styleData.Style)
    {
      case 0:
        WorldGen.GetDungeonLootAndChestStyle(num1, num2, ref itemType, ref chestStyle);
        flag = true;
        break;
      case 8:
      case 9:
      case 14:
        itemType = WorldGen.GetNextJungleChestItem();
        break;
      case 10:
        itemType = 1293;
        break;
      case 13:
        itemType = 832;
        if (genRand.Next(3) == 0)
        {
          itemType = 4281;
          break;
        }
        break;
    }
    if (!flag && styleData.ChestItemTypes.Length != 0)
    {
      PlacementDetails derivedPlacementDetail = ItemID.Sets.DerivedPlacementDetails[styleData.ChestItemTypes[genRand.Next(styleData.ChestItemTypes.Length)]];
      chestTileType = (ushort) derivedPlacementDetail.tileType;
      chestStyle = (int) derivedPlacementDetail.tileStyle;
    }
    if (itemType == 0 && genRand.Next(2) == 0)
      return true;
    int num3 = WorldGen.AddBuriedChest(num1, num2, itemType, chestStyle: chestStyle, chestTileType: chestTileType) ? 1 : 0;
    if (num3 == 0)
      return num3 != 0;
    if (styleData.Style != (byte) 0)
      return num3 != 0;
    ++GenVars.CurrentDungeonGenVars.dungeonLootStyle;
    return num3 != 0;
  }

  public static void GenerateDungeonWaterCandle(int placeX, int placeY)
  {
    WorldGen.PlaceTile(placeX, placeY, 49, true);
  }

  public static void GenerateDungeonPotionBottle(int placeX, int placeY)
  {
    WorldGen.PlaceTile(placeX, placeY, 13, true);
    if (Main.tile[placeX, placeY].type != (ushort) 13)
      return;
    if (WorldGen.genRand.Next(2) == 0)
      Main.tile[placeX, placeY].frameX = (short) 18;
    else
      Main.tile[placeX, placeY].frameX = (short) 36;
  }

  public static void GenerateDungeonPot(int placeX, int placeY)
  {
    int style = WorldGen.genRand.Next(10, 13);
    WorldGen.PlacePot(placeX, placeY, style: style);
    WorldGen.SquareTileFrame(placeX, placeY);
  }

  public static void GenerateDungeonBook(int placeX, int placeY)
  {
    DungeonUtils.GenerateDungeonBook(placeX, placeY, WorldGen.genRand.Next(50) == 0);
  }

  public static void GenerateDungeonBook(int placeX, int placeY, bool waterbolt)
  {
    short num = 90;
    WorldGen.PlaceTile(placeX, placeY, 50, true);
    if (!waterbolt || (double) placeY <= (Main.worldSurface + Main.rockLayer) / 2.0 || Main.tile[placeY, placeY].type != (ushort) 50)
      return;
    Main.tile[placeX, placeY].frameX = num;
  }

  public static void GenerateBottomWedge(
    int placeX,
    int placeY,
    int pillarWidth,
    ushort pillarType,
    bool left = true,
    bool wall = false,
    bool actuated = false,
    bool crowningBottom = false,
    int paint = -1)
  {
    if (crowningBottom)
      pillarWidth += 2;
    int num1 = 0;
    for (int index = 0; index <= pillarWidth; ++index)
    {
      int placeX1 = placeX + index - pillarWidth / 2;
      int pillarHeight = left ? index + 1 : pillarWidth - (index - 1);
      DungeonUtils.GenerateTileStrip(false, out num1, out num1, placeX1, placeY, pillarHeight, pillarType, wall, actuated, paint);
    }
    for (int index = 0; index <= pillarWidth; ++index)
    {
      int num2 = pillarWidth / 2;
      int num3 = left ? index + 1 : pillarWidth - (index - 1);
      Tile.SmoothSlope(placeX, placeY + num3, false);
    }
  }

  private static void GenerateTileStrip(
    bool upwards,
    out int topY,
    out int bottomY,
    int placeX,
    int placeY,
    int pillarHeight,
    ushort pillarType,
    bool wall = false,
    bool actuated = false,
    int paint = -1,
    bool smoothTop = false,
    bool smoothBottom = false,
    bool solidTop = false)
  {
    topY = placeY;
    bottomY = placeY;
    int num1 = pillarHeight;
    if (num1 == -1)
    {
      int num2 = 0;
      if (upwards)
      {
        while (num2 > -100 && WorldGen.InWorld(placeX, placeY + num2, 10) && !Main.tile[placeX, placeY + num2].active())
          --num2;
        num1 = -num2;
      }
      else
      {
        while (num2 < 100 && WorldGen.InWorld(placeX, placeY + num2, 10) && !Main.tile[placeX, placeY + num2].active())
          ++num2;
        num1 = num2;
      }
    }
    if (num1 == 0)
      return;
    int num3 = -num1 + 1;
    int num4 = 0;
    if (!upwards)
    {
      num3 = 0;
      num4 = num1 - 1;
    }
    for (int index = num3; index <= num4; ++index)
    {
      int y = placeY + index;
      if (WorldGen.InWorld(placeX, y, 10))
      {
        Tile tile = Main.tile[placeX, y];
        if (wall)
        {
          tile.wall = pillarType;
          if (paint >= 0)
            tile.wallColor((byte) paint);
        }
        else
        {
          tile.ClearTile();
          tile.active(true);
          tile.type = pillarType;
          if (paint >= 0)
            tile.color((byte) paint);
          if (index == num3 & smoothTop || index == num4 & smoothBottom)
            Tile.SmoothSlope(placeX, y, false);
          if ((!solidTop || index >= num3 + 2) && actuated)
            tile.inActive(true);
        }
        if (y < topY)
          topY = y;
        if (y > bottomY)
          bottomY = y;
      }
    }
  }

  public static Point FirstSolid(bool ceiling, Point currentPoint, DungeonBounds bounds)
  {
    int num = Main.maxTilesX * 5;
    do
    {
      --num;
      if (num > 0 && (!ceiling || !WorldGen.SolidTileAllowTopSlope(currentPoint.X, currentPoint.Y)) && (ceiling || !WorldGen.SolidTileAllowBottomSlope(currentPoint.X, currentPoint.Y)))
      {
        if (ceiling)
          --currentPoint.Y;
        else
          ++currentPoint.Y;
      }
      else
        break;
    }
    while (currentPoint.Y > 10 && currentPoint.Y < Main.maxTilesY - 10 && (bounds == null || bounds.Contains(currentPoint)));
    return currentPoint;
  }

  public static void GenerateHangingLeafCluster(
    DungeonData data,
    UnifiedRandom genRand,
    DungeonBounds bounds,
    Point startPoint,
    int growthLength,
    int branchDensity,
    int leafDensity,
    ushort leafType,
    ushort woodType,
    int leafPaintColor = 0,
    int woodPaintColor = 0,
    bool goDown = true,
    bool includeVines = true)
  {
    Point currentPoint = new Point(startPoint.X, startPoint.Y);
    int num1 = goDown ? 1 : -1;
    Point point1 = DungeonUtils.FirstSolid(goDown, currentPoint, bounds);
    Point point2 = point1;
    Point? nullable = new Point?();
    int num2 = growthLength;
    for (; growthLength > 0; --growthLength)
    {
      int y = point1.Y;
      float amount = (float) growthLength / (float) num2;
      if (!nullable.HasValue && (double) amount > 0.64999997615814209)
        nullable = new Point?(point1);
      int num3 = (int) Utils.Lerp(0.0, (double) branchDensity, (double) amount);
      for (int index1 = -num3; index1 <= num3; ++index1)
      {
        int index2 = point1.X + index1;
        DungeonUtils.ChangeTileType(Main.tile[index2, y], woodType, false, woodPaintColor);
      }
      point1.Y += num1;
    }
    int num4 = genRand.Next(3);
    if (!goDown)
      num4 *= -1;
    point1 = !nullable.HasValue ? new Point(point2.X, point2.Y + (int) ((double) num2 * 0.64999997615814209) + num4) : new Point(nullable.Value.X, nullable.Value.Y + num4);
    int num5 = leafDensity * 2 + 3;
    int num6 = num5;
    for (; num5 > 0; --num5)
    {
      int y = point1.Y;
      float percent = (float) num5 / (float) num6;
      int num7 = (int) Utils.WrappedLerp(1f, (float) leafDensity, percent);
      for (int index3 = -num7; index3 <= num7; ++index3)
      {
        int index4 = point1.X + index3;
        Tile tile = Main.tile[index4, y];
        if (!tile.active())
          DungeonUtils.ChangeTileType(tile, leafType, false, leafPaintColor);
      }
      point1.Y += num1;
    }
  }

  public static void GenerateDungeonTree(
    DungeonData data,
    int x,
    int y,
    int attachmentY,
    bool generateRoots = true)
  {
    if (!WorldGen.InWorld(x, y, 20))
      return;
    int j = y;
    while (Main.tile[x, j].active() || Main.tile[x, j].wall > (ushort) 0 || Main.tile[x, j - 1].active() || Main.tile[x, j - 1].wall > (ushort) 0 || Main.tile[x, j - 2].active() || Main.tile[x, j - 2].wall > (ushort) 0 || Main.tile[x, j - 3].active() || Main.tile[x, j - 3].wall > (ushort) 0 || Main.tile[x, j - 4].active() || Main.tile[x, j - 4].wall > (ushort) 0)
    {
      --j;
      if (j < 50)
        break;
    }
    if (j <= 50)
      return;
    DungeonUtils.GrowDungeonTree(data, x, j, attachmentY, generateRoots: generateRoots);
  }

  private static bool GrowDungeonTree(
    DungeonData data,
    int i,
    int j,
    int attachmentY,
    bool patch = false,
    bool generateRoots = true)
  {
    byte color1 = 28;
    byte color2 = 28;
    if (WorldGen.notTheBees)
    {
      color1 = (byte) 0;
      color2 = (byte) 0;
    }
    UnifiedRandom genRand = WorldGen.genRand;
    int index1 = 0;
    int[] numArray1 = new int[1000];
    int[] numArray2 = new int[1000];
    int[] numArray3 = new int[1000];
    int[] numArray4 = new int[1000];
    int index2 = 0;
    int[] numArray5 = new int[2000];
    int[] numArray6 = new int[2000];
    bool[] flagArray = new bool[2000];
    int num1 = i - genRand.Next(2, 3);
    int num2 = i + genRand.Next(2, 3);
    if (genRand.Next(5) == 0)
    {
      if (genRand.Next(2) == 0)
        --num1;
      else
        ++num2;
    }
    int num3 = num2 - num1;
    int num4 = num1;
    int num5 = num2;
    int minimumLeft = num1;
    int minimumRight = num2;
    bool flag = true;
    int num6 = genRand.Next(-8, -4);
    int num7 = genRand.Next(2);
    int index3 = j;
    int num8 = genRand.Next(5, 15);
    Main.tileSolid[48 /*0x30*/] = false;
    while (flag)
    {
      ++num6;
      if (num6 > num8)
      {
        num8 = genRand.Next(5, 15);
        num6 = 0;
        numArray2[index1] = index3 + genRand.Next(5);
        if (genRand.Next(5) == 0)
          num7 = num7 != 0 ? 0 : 1;
        if (num7 == 0)
        {
          numArray3[index1] = -1;
          numArray1[index1] = num1;
          numArray4[index1] = num2 - num1;
          if (genRand.Next(2) == 0)
            ++num1;
          ++num4;
          num7 = 1;
        }
        else
        {
          numArray3[index1] = 1;
          numArray1[index1] = num2;
          numArray4[index1] = num2 - num1;
          if (genRand.Next(2) == 0)
            --num2;
          --num5;
          num7 = 0;
        }
        if (num4 == num5)
          flag = false;
        ++index1;
      }
      for (int index4 = num1; index4 <= num2; ++index4)
      {
        Main.tile[index4, index3].type = (ushort) 191;
        Main.tile[index4, index3].active(true);
        Main.tile[index4, index3].Clear(TileDataType.Slope);
        if (color1 != (byte) 0)
          Main.tile[index4, index3].color(color1);
      }
      --index3;
    }
    for (int index5 = 0; index5 < index1 - 1; ++index5)
    {
      int index6 = numArray1[index5] + numArray3[index5];
      int index7 = numArray2[index5];
      int num9 = (int) ((double) numArray4[index5] * (1.0 + (double) genRand.Next(20, 30) * 0.1));
      Main.tile[index6, index7 + 1].type = (ushort) 191;
      Main.tile[index6, index7 + 1].active(true);
      Main.tile[index6, index7 + 1].Clear(TileDataType.Slope);
      if (color1 != (byte) 0)
        Main.tile[index6, index7 + 1].color(color1);
      int num10 = genRand.Next(3, 5);
      while (num9 > 0)
      {
        --num9;
        Main.tile[index6, index7].type = (ushort) 191;
        Main.tile[index6, index7].active(true);
        Main.tile[index6, index7].Clear(TileDataType.Slope);
        if (color1 != (byte) 0)
          Main.tile[index6, index7].color(color1);
        if (genRand.Next(10) == 0)
        {
          if (genRand.Next(2) == 0)
            --index7;
          else
            ++index7;
        }
        else
          index6 += numArray3[index5];
        if (num10 > 0)
          --num10;
        else if (genRand.Next(2) == 0)
        {
          num10 = genRand.Next(2, 5);
          if (genRand.Next(2) == 0)
          {
            Main.tile[index6, index7].type = (ushort) 191;
            Main.tile[index6, index7].active(true);
            Main.tile[index6, index7].Clear(TileDataType.Slope);
            if (color1 != (byte) 0)
              Main.tile[index6, index7].color(color1);
            Main.tile[index6, index7 - 1].type = (ushort) 191;
            Main.tile[index6, index7 - 1].Clear(TileDataType.Slope);
            if (color1 != (byte) 0)
              Main.tile[index6, index7 - 1].color(color1);
            numArray5[index2] = index6;
            numArray6[index2] = index7;
            ++index2;
          }
          else
          {
            Main.tile[index6, index7].type = (ushort) 191;
            Main.tile[index6, index7].active(true);
            Main.tile[index6, index7].Clear(TileDataType.Slope);
            if (color1 != (byte) 0)
              Main.tile[index6, index7].color(color1);
            Main.tile[index6, index7 + 1].type = (ushort) 191;
            Main.tile[index6, index7 + 1].active(true);
            Main.tile[index6, index7 + 1].Clear(TileDataType.Slope);
            if (color1 != (byte) 0)
              Main.tile[index6, index7 + 1].color(color1);
            numArray5[index2] = index6;
            numArray6[index2] = index7;
            ++index2;
          }
        }
        if (num9 == 0)
        {
          numArray5[index2] = index6;
          numArray6[index2] = index7;
          ++index2;
        }
      }
    }
    int index8 = (num1 + num2) / 2;
    int index9 = index3;
    int num11 = genRand.Next(num3 * 3, num3 * 5);
    int num12 = 0;
    int num13 = 0;
    for (; num11 > 0; --num11)
    {
      Main.tile[index8, index9].type = (ushort) 191;
      Main.tile[index8, index9].active(true);
      Main.tile[index8, index9].Clear(TileDataType.Slope);
      if (color1 != (byte) 0)
        Main.tile[index8, index9].color(color1);
      if (num12 > 0)
        --num12;
      if (num13 > 0)
        --num13;
      for (int index10 = -1; index10 < 2; ++index10)
      {
        if (index10 != 0 && (index10 < 0 && num12 == 0 || index10 > 0 && num13 == 0) && genRand.Next(2) == 0)
        {
          int index11 = index8;
          int index12 = index9;
          int num14 = genRand.Next(num3, num3 * 3);
          if (index10 < 0)
            num12 = genRand.Next(3, 5);
          if (index10 > 0)
            num13 = genRand.Next(3, 5);
          int num15 = 0;
          while (num14 > 0)
          {
            --num14;
            index11 += index10;
            Main.tile[index11, index12].type = (ushort) 191;
            Main.tile[index11, index12].active(true);
            Main.tile[index11, index12].Clear(TileDataType.Slope);
            if (color1 != (byte) 0)
              Main.tile[index11, index12].color(color1);
            if (num14 == 0)
            {
              numArray5[index2] = index11;
              numArray6[index2] = index12;
              flagArray[index2] = true;
              ++index2;
            }
            if (genRand.Next(5) == 0)
            {
              if (genRand.Next(2) == 0)
                --index12;
              else
                ++index12;
              Main.tile[index11, index12].type = (ushort) 191;
              Main.tile[index11, index12].active(true);
              Main.tile[index11, index12].Clear(TileDataType.Slope);
              if (color1 != (byte) 0)
                Main.tile[index11, index12].color(color1);
            }
            if (num15 > 0)
              --num15;
            else if (genRand.Next(3) == 0)
            {
              num15 = genRand.Next(2, 4);
              int index13 = index11;
              int num16 = index12;
              int index14 = genRand.Next(2) != 0 ? num16 + 1 : num16 - 1;
              Main.tile[index13, index14].type = (ushort) 191;
              Main.tile[index13, index14].active(true);
              Main.tile[index13, index14].Clear(TileDataType.Slope);
              if (color1 != (byte) 0)
                Main.tile[index13, index14].color(color1);
              numArray5[index2] = index13;
              numArray6[index2] = index14;
              flagArray[index2] = true;
              int index15 = index2 + 1;
              numArray5[index15] = index13 + genRand.Next(-5, 6);
              numArray6[index15] = index14 + genRand.Next(-5, 6);
              flagArray[index15] = true;
              index2 = index15 + 1;
            }
          }
        }
      }
      numArray5[index2] = index8;
      numArray6[index2] = index9;
      ++index2;
      if (genRand.Next(4) == 0)
      {
        if (genRand.Next(2) == 0)
          --index8;
        else
          ++index8;
        Main.tile[index8, index9].type = (ushort) 191;
        Main.tile[index8, index9].active(true);
        Main.tile[index8, index9].Clear(TileDataType.Slope);
        if (color1 != (byte) 0)
          Main.tile[index8, index9].color(color1);
      }
      --index9;
    }
    if (generateRoots)
    {
      for (int i1 = minimumLeft; i1 <= minimumRight; ++i1)
      {
        int num17 = genRand.Next(1, 6);
        int j1 = j + 1;
        while (num17 > 0)
        {
          if (WorldGen.SolidTile(i1, j1))
            --num17;
          Main.tile[i1, j1].type = (ushort) 191;
          Main.tile[i1, j1].active(true);
          Main.tile[i1, j1].Clear(TileDataType.Slope);
          ++j1;
        }
        int num18 = j1;
        int num19 = genRand.Next(2, num3 + 1);
        for (int index16 = 0; index16 < num19; ++index16)
        {
          int index17 = num18;
          int num20 = (minimumLeft + minimumRight) / 2;
          int num21 = 1;
          int num22 = i1 >= num20 ? 1 : -1;
          if (i1 == num20 || num3 > 6 && (i1 == num20 - 1 || i1 == num20 + 1))
            num22 = 0;
          int num23 = num22;
          int index18 = i1;
          int num24 = genRand.Next((int) ((double) num3 * 3.5), num3 * 6);
          while (num24 > 0)
          {
            --num24;
            index18 += num22;
            if (Main.tile[index18, index17].wall != (ushort) 244)
            {
              Main.tile[index18, index17].type = (ushort) 191;
              Main.tile[index18, index17].active(true);
              Main.tile[index18, index17].Clear(TileDataType.Slope);
            }
            index17 += num21;
            if (Main.tile[index18, index17].wall != (ushort) 244)
            {
              Main.tile[index18, index17].type = (ushort) 191;
              Main.tile[index18, index17].active(true);
              Main.tile[index18, index17].Clear(TileDataType.Slope);
            }
            if (!Main.tile[index18, index17 + 1].active())
            {
              num22 = 0;
              num21 = 1;
            }
            if (genRand.Next(3) == 0)
              num22 = num23 >= 0 ? (num23 <= 0 ? genRand.Next(-1, 2) : (num22 != 0 ? 0 : 1)) : (num22 != 0 ? 0 : -1);
            if (genRand.Next(3) == 0)
              num21 = num21 != 0 ? 0 : 1;
          }
        }
      }
    }
    if (!WorldGen.remixWorldGen)
    {
      for (int index19 = 0; index19 < index2; ++index19)
      {
        int num25 = (int) ((double) genRand.Next(5, 8) * (1.0 + (double) num3 * 0.05));
        if (flagArray[index19])
          num25 = genRand.Next(6, 12) + num3;
        int num26 = numArray5[index19] - num25 * 2;
        int num27 = numArray5[index19] + num25 * 2;
        int num28 = numArray6[index19] - num25 * 2;
        int num29 = numArray6[index19] + num25 * 2;
        double num30 = 2.0 - (double) genRand.Next(5) * 0.1;
        for (int index20 = num26; index20 <= num27; ++index20)
        {
          for (int index21 = num28; index21 <= num29; ++index21)
          {
            if (Main.tile[index20, index21].type != (ushort) 191)
            {
              if (flagArray[index19])
              {
                Vector2D vector2D = Vector2D.op_Subtraction(new Vector2D((double) numArray5[index19], (double) numArray6[index19]), new Vector2D((double) index20, (double) index21));
                if (((Vector2D) ref vector2D).Length() < (double) num25 * 0.9)
                {
                  Main.tile[index20, index21].type = (ushort) 192 /*0xC0*/;
                  Main.tile[index20, index21].active(true);
                  Main.tile[index20, index21].Clear(TileDataType.Slope);
                  if (color2 != (byte) 0)
                    Main.tile[index20, index21].color(color2);
                }
              }
              else if ((double) Math.Abs(numArray5[index19] - index20) + (double) Math.Abs(numArray6[index19] - index21) * num30 < (double) num25)
              {
                Main.tile[index20, index21].type = (ushort) 192 /*0xC0*/;
                Main.tile[index20, index21].active(true);
                Main.tile[index20, index21].Clear(TileDataType.Slope);
                if (color2 != (byte) 0)
                  Main.tile[index20, index21].color(color2);
              }
            }
          }
        }
      }
    }
    DungeonUtils.GrowDungeonTree_MakePassage(data, j, attachmentY, num3, ref minimumLeft, ref minimumRight, patch);
    Main.tileSolid[48 /*0x30*/] = true;
    return true;
  }

  private static void GrowDungeonTree_MakePassage(
    DungeonData data,
    int j,
    int attachmentY,
    int width,
    ref int minimumLeft,
    ref int minimumRight,
    bool noSecretRoom = false)
  {
    UnifiedRandom genRand = WorldGen.genRand;
    int num1 = minimumLeft;
    int num2 = minimumRight;
    int num3 = (minimumLeft + minimumRight) / 2;
    int num4 = 5;
    int j1 = j - 6;
    int num5 = 0;
    bool flag1 = true;
    genRand.Next(5, 16 /*0x10*/);
    PlacementDetails derivedPlacementDetail = ItemID.Sets.DerivedPlacementDetails[data.platformItemType];
    int tileType = derivedPlacementDetail.tileType;
    short tileStyle = derivedPlacementDetail.tileStyle;
label_1:
    int num6;
    ushort Type;
    int style;
    while (true)
    {
      int num7;
      bool flag2;
      do
      {
        do
        {
          ++j1;
          if (j1 <= attachmentY)
          {
            num6 = (minimumLeft + minimumRight) / 2;
            int num8 = 1;
            if (j1 > j && width <= 4)
              ++num8;
            for (int i = minimumLeft - num8; i <= minimumRight + num8; ++i)
            {
              if (i > num6 - 2 && i <= num6 + 1)
              {
                if (j1 > j - 4)
                {
                  if (Main.tile[i, j1].type != (ushort) 19 && Main.tile[i, j1].type != (ushort) 15 && Main.tile[i, j1].type != (ushort) 304 && Main.tile[i, j1].type != (ushort) 21 && Main.tile[i, j1].type != (ushort) 10 && Main.tile[i, j1 - 1].type != (ushort) 15 && Main.tile[i, j1 - 1].type != (ushort) 304 && Main.tile[i, j1 - 1].type != (ushort) 21 && Main.tile[i, j1 - 1].type != (ushort) 10 && Main.tile[i, j1 + 1].type != (ushort) 10)
                    Main.tile[i, j1].ClearTileAndPaint();
                  if (!DungeonUtils.IsConsideredDungeonWall((int) Main.tile[i, j1].wall))
                    Main.tile[i, j1].wall = (ushort) 244;
                  if (!DungeonUtils.IsConsideredDungeonWall((int) Main.tile[i - 1, j1].wall) && (Main.tile[i - 1, j1].wall > (ushort) 0 || (double) j1 >= Main.worldSurface))
                    Main.tile[i - 1, j1].wall = (ushort) 244;
                  if (!DungeonUtils.IsConsideredDungeonWall((int) Main.tile[i + 1, j1].wall) && (Main.tile[i + 1, j1].wall > (ushort) 0 || (double) j1 >= Main.worldSurface))
                    Main.tile[i + 1, j1].wall = (ushort) 244;
                  if (j1 == j && i > num6 - 2 && i <= num6 + 1)
                  {
                    Main.tile[i, j1 + 1].ClearTileAndPaint();
                    WorldGen.PlaceTile(i, j1 + 1, 19, true, style: 23);
                  }
                }
              }
              else
              {
                if (Main.tile[i, j1].type != (ushort) 15 && Main.tile[i, j1].type != (ushort) 304 && Main.tile[i, j1].type != (ushort) 21 && Main.tile[i, j1].type != (ushort) 10 && Main.tile[i - 1, j1].type != (ushort) 10 && Main.tile[i + 1, j1].type != (ushort) 10)
                {
                  if (!DungeonUtils.IsConsideredDungeonWall((int) Main.tile[i, j1].wall))
                  {
                    Main.tile[i, j1].type = (ushort) 191;
                    Main.tile[i, j1].active(true);
                    Main.tile[i, j1].Clear(TileDataType.Slope);
                  }
                  if (Main.tile[i - 1, j1].type == (ushort) 40)
                    Main.tile[i - 1, j1].type = (ushort) 0;
                  if (Main.tile[i + 1, j1].type == (ushort) 40)
                    Main.tile[i + 1, j1].type = (ushort) 0;
                }
                if (j1 <= j && j1 > j - 4 && i > minimumLeft - num8 && i <= minimumRight + num8 - 1)
                  Main.tile[i, j1].wall = (ushort) 244;
              }
              if (!WorldGen.isGeneratingOrLoadingWorld)
              {
                WorldGen.SquareTileFrame(i, j1);
                WorldGen.SquareWallFrame(i, j1);
              }
            }
            ++num5;
          }
          else
            goto label_50;
        }
        while (num5 < 6);
        num5 = 0;
        num7 = genRand.Next(3);
        if (num7 == 0)
          num7 = -1;
        if (flag1)
          num7 = 2;
        if (num7 == -1 && Main.tile[minimumLeft - num4, j1].wall == (ushort) 244)
          num7 = 1;
        else if (num7 == 1 && Main.tile[minimumRight + num4, j1].wall == (ushort) 244)
          num7 = -1;
        if (num7 == 2)
        {
          flag1 = false;
          Type = (ushort) 19;
          style = 23;
          flag2 = false;
          if (DungeonUtils.IsConsideredDungeonWall((int) Main.tile[minimumLeft, j1 + 1].wall) || DungeonUtils.IsConsideredDungeonWall((int) Main.tile[minimumLeft + 1, j1 + 1].wall) || DungeonUtils.IsConsideredDungeonWall((int) Main.tile[minimumLeft + 2, j1 + 1].wall))
          {
            flag2 = true;
            Type = (ushort) tileType;
            style = (int) tileStyle;
          }
        }
        else
          goto label_49;
      }
      while (!WorldGen.SolidTile(minimumLeft - 1, j1 + 1) && !WorldGen.SolidTile(minimumRight + 1, j1 + 1) && flag2);
      break;
label_49:
      minimumLeft += num7;
      minimumRight += num7;
    }
    for (int i = minimumLeft; i <= minimumRight; ++i)
    {
      if (i > num6 - 2 && i <= num6 + 1)
      {
        Main.tile[i, j1 + 1].ClearTileAndPaint();
        WorldGen.PlaceTile(i, j1 + 1, (int) Type, true, style: style);
      }
    }
    goto label_1;
label_50:
    minimumLeft = num1;
    minimumRight = num2;
    for (int index1 = minimumLeft; index1 <= minimumRight; ++index1)
    {
      for (int index2 = j - 3; index2 <= j; ++index2)
      {
        Tile tile = Main.tile[index1, index2];
        tile.ClearTileAndPaint();
        if (!DungeonUtils.IsConsideredDungeonWall((int) tile.wall) && !DungeonUtils.IsConsideredDungeonWallGlass((int) tile.wall))
          tile.wall = (ushort) 244;
      }
    }
  }

  public static void GenerateDungeonStairs(
    DungeonData data,
    int i,
    int j,
    int direction,
    ushort tileType,
    ushort wallType,
    int depth = 100)
  {
    if (!WorldGen.InWorld(i, j, 20))
      return;
    int num1 = depth;
    int num2 = depth;
    int num3 = direction == 1 ? 1 : -1;
    int num4 = 0;
    for (int x = i; (direction == 1 ? (x < i + num2 ? 1 : 0) : (x > i - num2 ? 1 : 0)) != 0; x += num3)
    {
      ++num4;
      for (int y = j + num4; y < j + num1; ++y)
      {
        if (WorldGen.InWorld(x, y, 10) && !DungeonUtils.GenerateDungeonStairs_CanPlaceTile(x, y + 5) && num1 > y)
        {
          num1 = y;
          break;
        }
      }
    }
    int num5 = num1;
    depth = num1;
    int num6 = 0;
    for (int x = i; (direction == 1 ? (x < i + num5 ? 1 : 0) : (x > i - num5 ? 1 : 0)) != 0; x += num3)
    {
      ++num6;
      for (int y = j + num6; y < j + depth; ++y)
      {
        if (WorldGen.InWorld(x, y, 10) && y < DungeonCrawler.CurrentDungeonData.genVars.outerPotentialDungeonBounds.Top - 5)
        {
          Tile tile = Main.tile[x, y];
          tile.liquid = (byte) 0;
          Main.tile[x, y - 1].liquid = (byte) 0;
          Main.tile[x, y - 2].liquid = (byte) 0;
          Main.tile[x, y - 3].liquid = (byte) 0;
          if (DungeonUtils.GenerateDungeonStairs_CanPlaceTile(x, y))
          {
            bool flag = data.genVars.dungeonStyle.WallIsInStyle((int) tile.wall);
            if (!flag)
            {
              foreach (DungeonGenerationStyleData dungeonGenerationStyle in data.genVars.dungeonGenerationStyles)
              {
                if (dungeonGenerationStyle.WallIsInStyle((int) tile.wall))
                {
                  flag = true;
                  break;
                }
              }
            }
            if (flag)
            {
              if (tile.active())
              {
                tile.active(true);
                tile.type = tileType;
                tile.Clear(TileDataType.Slope);
              }
              tile.wall = wallType;
            }
            else
            {
              tile.active(true);
              tile.type = tileType;
              tile.Clear(TileDataType.Slope);
              if (y != j + num6)
                tile.wall = wallType;
            }
          }
        }
      }
    }
  }

  private static bool GenerateDungeonStairs_CanPlaceTile(int x, int y)
  {
    if (y >= DungeonCrawler.CurrentDungeonData.genVars.outerPotentialDungeonBounds.Top - 5)
      return false;
    Tile tile = Main.tile[x, y];
    return !tile.active() || WorldGen.CanKillTile(x, y) && (tile.type < (ushort) 0 || !Main.tileFrameImportant[(int) tile.type]);
  }

  public static void GenerateFloatingRocksInArea(
    DungeonData data,
    DungeonGenerationStyleData styleData,
    DungeonBounds bounds,
    ushort tileType,
    bool includePlatform = true,
    int paint = -1)
  {
    DungeonUtils.GenerateFloatingRocksInArea(data, styleData, bounds.Left, bounds.Top, bounds.Width, bounds.Height, tileType, includePlatform, paint);
  }

  public static void GenerateFloatingRocksInArea(
    DungeonData data,
    DungeonGenerationStyleData styleData,
    int x,
    int y,
    int width,
    int height,
    ushort tileType,
    bool includePlatform = true,
    int paint = -1)
  {
    int platformStyle = -1;
    if (includePlatform)
    {
      UnifiedRandom genRand = WorldGen.genRand;
      platformStyle = styleData.GetPlatformStyle(genRand);
    }
    DungeonUtils.GenerateFloatingRocksInArea(data, x, y, width, height, tileType, includePlatform, platformStyle, paint);
  }

  public static void GenerateFloatingRocksInArea(
    DungeonData data,
    DungeonBounds bounds,
    ushort tileType,
    bool includePlatform = true,
    int platformStyle = -1,
    int paint = -1,
    int platformDistance = 7)
  {
    DungeonUtils.GenerateFloatingRocksInArea(data, bounds.Left, bounds.Top, bounds.Width, bounds.Height, tileType, includePlatform, platformStyle, paint, platformDistance);
  }

  public static void GenerateFloatingRocksInArea(
    DungeonData data,
    int x,
    int y,
    int width,
    int height,
    ushort tileType,
    bool includePlatform = true,
    int platformStyle = -1,
    int paint = -1,
    int platformDistance = 7)
  {
    UnifiedRandom genRand = WorldGen.genRand;
    int num1 = Math.Max(2, (width + height) / 2 / platformDistance);
    int num2 = 0;
    int num3 = 100;
    int num4 = x + width / 2;
    int num5 = 8;
    bool flag = true;
    for (; num2 < num1; ++num2)
    {
      --num3;
      if (num3 <= 0)
        break;
      int width1 = 4 + genRand.Next(3);
      int num6 = x;
      int num7 = y;
      int x1;
      if (num2 % 2 == 0)
      {
        int num8 = width / 2;
        x1 = !flag ? x + num5 + num8 + genRand.Next(Math.Max(1, num8 - num5 * 2)) : x + num5 + genRand.Next(Math.Max(1, num8 - num5));
        flag = !flag;
      }
      else
        x1 = x + num5 + genRand.Next(width - num5 * 2);
      int y1 = y + num5 + (int) ((double) (height - num5 * 2) * ((double) num2 / (double) num1));
      DungeonUtils.GenerateRockPlatform(genRand, x1, y1, width1, tileType, paint);
      if (includePlatform)
      {
        int x2 = x1 < num4 ? x1 - 5 : x1 + 5;
        int num9 = x1 < num4 ? x1 - x : x + width - x1;
        DungeonPlatformData dungeonPlatformData = new DungeonPlatformData()
        {
          Position = new Point(x2, y1),
          InAHallway = false,
          OverrideHeightFluff = new int?(0),
          ForcePlacement = true,
          OverrideMaxLengthAllowed = 5 + num9,
          canPlaceHereCallback = (Func<DungeonData, int, int, bool>) ((dungeonData, platformX, platformY) => platformX >= x && platformX <= x + width && platformY >= y && platformY <= y + height)
        };
        if (platformStyle > -1)
          dungeonPlatformData.OverrideStyle = new int?(platformStyle);
        data.dungeonPlatformData.Add(dungeonPlatformData);
      }
    }
  }

  public static void GenerateRockPlatform(
    UnifiedRandom genRand,
    int x,
    int y,
    int width,
    ushort tileType,
    int paint = -1)
  {
    int num1 = width / 2;
    int num2 = Math.Max(2, num1 + genRand.Next(2));
    for (int index1 = 0; index1 < width; ++index1)
    {
      int index2 = x + index1 - num1;
      int num3 = num2;
      if (index1 == 0 || index1 == width - 1)
        num3 = Math.Max(1, num3 / 2);
      else if (index1 == 1 || index1 == width - 2)
        num3 = Math.Max(2, (int) ((double) num3 * 0.6600000262260437));
      for (int index3 = 0; index3 < num3; ++index3)
      {
        int index4 = y + index3;
        DungeonUtils.ChangeTileType(Main.tile[index2, index4], tileType, false, paint);
      }
    }
  }

  public static void GenerateSpeleothemsInArea(
    DungeonData data,
    DungeonGenerationStyleData styleData,
    DungeonBounds bounds,
    int maxSpeleothems,
    ushort tileType,
    int paint = -1,
    int speleothemWidth = -1,
    int speleothemHeight = -1)
  {
    DungeonUtils.GenerateSpeleothemsInArea(data, styleData, bounds.Left, bounds.Top, bounds.Width, bounds.Height, maxSpeleothems, tileType, paint);
  }

  public static void GenerateSpeleothemsInArea(
    DungeonData data,
    DungeonGenerationStyleData styleData,
    int x,
    int y,
    int width,
    int height,
    int maxSpeleothems,
    ushort tileType,
    int paint = -1,
    int speleothemWidth = -1,
    int speleothemHeight = -1)
  {
    DungeonUtils.GenerateSpeleothemsInArea(data, x, y, width, height, maxSpeleothems, tileType, paint);
  }

  public static void GenerateSpeleothemsInArea(
    DungeonData data,
    int x,
    int y,
    int width,
    int height,
    int maxSpeleothems,
    ushort tileType,
    int paint = -1,
    int speleothemWidth = -1,
    int speleothemHeight = -1)
  {
    UnifiedRandom genRand = WorldGen.genRand;
    int num1 = 1;
    int num2 = maxSpeleothems - 1;
    int num3 = 100;
    int num4 = width / 2;
    int num5 = y;
    int num6 = y + height;
    int num7 = y + height / 2;
    int num8 = genRand.Next(2);
    if (speleothemWidth <= -1)
      speleothemWidth = (int) Math.Max(5f, (float) width / (float) num2);
    if (speleothemHeight <= -1)
      speleothemHeight = height / 4;
    for (; num1 < num2; ++num1)
    {
      --num3;
      if (num3 <= 0)
        break;
      int width1 = speleothemWidth + genRand.Next(3);
      int x1 = x + (int) ((double) width * ((double) num1 / (double) (num2 - 1)));
      int y1 = num7;
      int num9 = x1;
      int num10 = y1;
      bool flag1 = (num1 + num8) % 2 == 0;
      if (genRand.Next(3) == 0)
        flag1 = !flag1;
      if (flag1)
      {
        Tile tile = Main.tile[x1, y1];
        int num11 = Math.Max((int) ((double) width * 1.5), (int) ((double) height * 1.5));
        for (; !tile.active() && y1 < num6; tile = Main.tile[x1, y1])
        {
          --num11;
          if (num11 > 0)
            ++y1;
          else
            break;
        }
      }
      else
      {
        Tile tile = Main.tile[x1, y1];
        int num12 = Math.Max((int) ((double) width * 1.5), (int) ((double) height * 1.5));
        for (; !tile.active() && y1 > num5; tile = Main.tile[x1, y1])
        {
          --num12;
          if (num12 > 0)
            --y1;
          else
            break;
        }
      }
      bool flag2 = true;
      if (flag2 && Math.Abs(num7 - y1) < 10)
        flag2 = false;
      if (flag2)
        DungeonUtils.GenerateSpeleothem(data, genRand, x1, y1, width1, speleothemHeight + genRand.Next(3), tileType, paint);
      if (genRand.Next(3) == 0)
      {
        int width2 = speleothemWidth + genRand.Next(3);
        int x2 = num9;
        int y2 = num10;
        if (!flag1)
        {
          Tile tile = Main.tile[x2, y2];
          int num13 = Math.Max((int) ((double) width * 1.5), (int) ((double) height * 1.5));
          for (; !tile.active() && y2 < num6; tile = Main.tile[x2, y2])
          {
            --num13;
            if (num13 > 0)
              ++y2;
            else
              break;
          }
        }
        else
        {
          Tile tile = Main.tile[x2, y2];
          int num14 = Math.Max((int) ((double) width * 1.5), (int) ((double) height * 1.5));
          for (; !tile.active() && y2 > num5; tile = Main.tile[x2, y2])
          {
            --num14;
            if (num14 > 0)
              --y2;
            else
              break;
          }
        }
        bool flag3 = true;
        if (flag3 && Math.Abs(num7 - y2) < 10)
          flag3 = false;
        if (flag3)
          DungeonUtils.GenerateSpeleothem(data, genRand, x2, y2, width2, speleothemHeight + genRand.Next(3), tileType, paint);
      }
    }
  }

  public static void GenerateSpeleothem(
    DungeonData data,
    UnifiedRandom genRand,
    int x,
    int y,
    int width,
    int height = -1,
    ushort tileType = 1,
    int paint = -1)
  {
    if (width % 2 == 1)
      ++width;
    int num1 = width / 2;
    if (height <= -1)
      height = width * 2 + genRand.Next(2);
    int num2 = height / 2;
    y -= num2;
    if (!Main.tile[x, y].active())
      ++y;
    for (int index = 0; index < data.dungeonDoorData.Count; ++index)
    {
      if ((double) data.dungeonDoorData[index].Position.ToVector2().Distance(new Vector2((float) x, (float) y)) <= 5.0)
        return;
    }
    for (int index1 = 0; index1 <= width; ++index1)
    {
      int index2 = x + index1 - num1;
      int num3 = (int) Utils.WrappedLerp(1f, (float) height, (float) index1 / (float) width);
      if (genRand.Next(2) == 0)
        num3 += 2;
      int num4 = (height - num3) / 2;
      for (int index3 = 0; index3 < num3; ++index3)
      {
        int index4 = y + index3 + num4;
        DungeonUtils.ChangeTileType(Main.tile[index2, index4], tileType, false, paint);
      }
    }
  }

  public static void ChangeTileType(Tile tile, ushort tileType, bool resetTile, int paint = -1)
  {
    if (resetTile)
      tile.ClearEverything();
    tile.active(true);
    tile.Clear(TileDataType.Slope);
    tile.type = tileType;
    if (paint <= -1)
      return;
    tile.color((byte) paint);
  }

  public static void ChangeWallType(Tile tile, ushort wallType, bool resetTile, int paint = -1)
  {
    if (resetTile)
      tile.ClearEverything();
    tile.wall = wallType;
    if (paint <= -1)
      return;
    tile.wallColor((byte) paint);
  }

  public static int GetDualDungeonBrickSupportCutoffY(DungeonData data)
  {
    return SpecialSeedFeatures.DungeonEntranceIsUnderground ? data.genVars.outerPotentialDungeonBounds.Top - 5 : data.genVars.outerPotentialDungeonBounds.Top - 10;
  }

  public static void UpdateDungeonProgress(
    GenerationProgress progress,
    float percentile,
    string debugString,
    bool noFormatting = false)
  {
    Main.statusText = debugString;
    if (progress == null)
      return;
    if (noFormatting)
      progress.MessageNoFormatting = debugString;
    else
      progress.Message = debugString;
    progress.Set((double) percentile);
  }

  public static Point SetOldManSpawnAndSpawnOldManIfDefaultDungeon(int x, int y, bool generating = false)
  {
    Point point = new Point(x, y);
    if (GenVars.CurrentDungeon == 0)
    {
      Main.dungeonX = point.X;
      Main.dungeonY = point.Y;
      if (generating)
      {
        int index = NPC.NewNPC((IEntitySource) new EntitySource_WorldGen(), Main.dungeonX * 16 /*0x10*/ + 8, Main.dungeonY * 16 /*0x10*/, 37);
        Main.npc[index].homeless = false;
        Main.npc[index].homeTileX = Main.dungeonX;
        Main.npc[index].homeTileY = Main.dungeonY;
        if (Main.onlyShimmerOceanWorldsGeneration)
          Main.npc[index].GivenName = "Old Man James";
      }
    }
    return point;
  }

  public static bool IsPointOfProtectionType(
    int i2,
    int j2,
    List<DungeonRoom> roomsInArea,
    ProtectionType protectionToCheck)
  {
    ProtectionType protectionTypeFromPoint = DungeonUtils.GetHighestProtectionTypeFromPoint(i2, j2, roomsInArea);
    switch (protectionToCheck)
    {
      case ProtectionType.Tiles:
      case ProtectionType.Walls:
        return protectionTypeFromPoint == protectionToCheck || protectionTypeFromPoint == ProtectionType.TilesAndWalls;
      case ProtectionType.TilesAndWalls:
        return protectionTypeFromPoint == protectionToCheck || protectionTypeFromPoint == ProtectionType.Tiles || protectionTypeFromPoint == ProtectionType.Walls;
      default:
        return protectionTypeFromPoint == protectionToCheck;
    }
  }

  public static ProtectionType GetHighestProtectionTypeFromPoint(
    int i2,
    int j2,
    List<DungeonRoom> roomsInArea)
  {
    ProtectionType protectionTypeFromPoint = ProtectionType.None;
    for (int index = 0; index < roomsInArea.Count; ++index)
    {
      switch (roomsInArea[index].GetProtectionTypeFromPoint(i2, j2))
      {
        case ProtectionType.Tiles:
          protectionTypeFromPoint = protectionTypeFromPoint != ProtectionType.Walls ? ProtectionType.Tiles : ProtectionType.TilesAndWalls;
          break;
        case ProtectionType.Walls:
          protectionTypeFromPoint = protectionTypeFromPoint != ProtectionType.Tiles ? ProtectionType.Walls : ProtectionType.TilesAndWalls;
          break;
        case ProtectionType.TilesAndWalls:
          protectionTypeFromPoint = ProtectionType.TilesAndWalls;
          break;
      }
      if (protectionTypeFromPoint == ProtectionType.TilesAndWalls)
        break;
    }
    return protectionTypeFromPoint;
  }

  public static DungeonRoom GetClosestRoomTo(
    List<DungeonRoom> roomsToCheck,
    Point point,
    DungeonRoomSearchSettings settings)
  {
    return DungeonUtils.GetClosestRoomTo(roomsToCheck, point.X, point.Y, settings);
  }

  public static DungeonRoom GetClosestRoomTo(
    List<DungeonRoom> roomsToCheck,
    int x,
    int y,
    DungeonRoomSearchSettings settings)
  {
    Vector2 vector2 = new Vector2((float) x, (float) y);
    DungeonRoom closestRoomTo = (DungeonRoom) null;
    float num1 = 999999f;
    for (int index = 0; index < roomsToCheck.Count; ++index)
    {
      DungeonRoom room = roomsToCheck[index];
      if (DungeonUtils.RoomCanBeChosen(room, settings))
      {
        if (room.OuterBounds.ContainsWithFluff(x, y, settings.Fluff))
          return room;
        float num2 = Vector2.Distance(vector2, room.Center.ToVector2());
        if ((double) num2 < (double) num1)
        {
          closestRoomTo = room;
          num1 = num2;
        }
      }
    }
    return closestRoomTo;
  }

  public static List<DungeonRoom> GetAllRoomsNearSpot(
    List<DungeonRoom> roomsToCheck,
    int x,
    int y,
    DungeonRoomSearchSettings settings)
  {
    List<DungeonRoom> allRoomsNearSpot = new List<DungeonRoom>();
    for (int index = 0; index < roomsToCheck.Count; ++index)
    {
      DungeonRoom room = roomsToCheck[index];
      if (DungeonUtils.RoomCanBeChosen(room, settings) && room.OuterBounds.ContainsWithFluff(x, y, settings.Fluff))
        allRoomsNearSpot.Add(room);
    }
    return allRoomsNearSpot;
  }

  public static List<DungeonRoom> GetAllRoomsInSpots(
    List<DungeonRoom> roomsToCheck,
    Vector2D startPos,
    Vector2D endPos,
    DungeonRoomSearchSettings settings)
  {
    Point point1 = startPos.ToPoint();
    Point point2 = Vector2D.op_Division(Vector2D.op_Subtraction(endPos, startPos), 2.0).ToPoint();
    Point point3 = endPos.ToPoint();
    List<DungeonRoom> allRoomsInSpots = new List<DungeonRoom>();
    for (int index = 0; index < roomsToCheck.Count; ++index)
    {
      DungeonRoom room = roomsToCheck[index];
      if (DungeonUtils.RoomCanBeChosen(room, settings) && (room.OuterBounds.ContainsWithFluff(point1, settings.Fluff) || room.OuterBounds.ContainsWithFluff(point2, settings.Fluff) || room.OuterBounds.ContainsWithFluff(point3, settings.Fluff)))
        allRoomsInSpots.Add(room);
    }
    return allRoomsInSpots;
  }

  public static bool RoomCanBeChosen(DungeonRoom room, DungeonRoomSearchSettings settings)
  {
    if (room == null)
      return false;
    if (settings.ProgressionStage.HasValue)
    {
      int progressionStage = room.settings.ProgressionStage;
      int num = settings.ProgressionStage.Value;
      switch (settings.ProgressionStageCheck)
      {
        case ProgressionStageCheck.Equals:
          if (progressionStage != num)
            return false;
          break;
        case ProgressionStageCheck.GreaterThenOrEqualTo:
          if (progressionStage < num)
            return false;
          break;
        case ProgressionStageCheck.LesserThenOrEqualTo:
          if (progressionStage > num)
            return false;
          break;
      }
    }
    DungeonRoom excludedRoom = settings.ExcludedRoom;
    return excludedRoom == null || excludedRoom != room && (!settings.MaximumDistance.HasValue || (double) room.Center.ToVector2().Distance(excludedRoom.Center.ToVector2()) < (double) settings.MaximumDistance.Value);
  }

  public static bool IsConsideredDungeonTile(int tileType, bool allDungeons = false)
  {
    if (tileType > 0 && Main.tileDungeon[tileType])
      return true;
    if (allDungeons)
    {
      for (int index = 0; index < GenVars.dungeonGenVars.Count; ++index)
      {
        if (GenVars.dungeonGenVars[index].isDungeonTile[tileType])
          return true;
      }
    }
    else if (GenVars.CurrentDungeonGenVars.isDungeonTile[tileType])
      return true;
    return false;
  }

  public static bool IsConsideredCrackedDungeonTile(int tileType, bool allDungeons = false)
  {
    if (allDungeons)
    {
      for (int index = 0; index < GenVars.dungeonGenVars.Count; ++index)
      {
        if (GenVars.dungeonGenVars[index].isCrackedBrick[tileType])
          return true;
      }
    }
    else if (GenVars.CurrentDungeonGenVars.isCrackedBrick[tileType])
      return true;
    return false;
  }

  public static bool IsConsideredPitTrapTile(int tileType, bool allDungeons = false)
  {
    if (allDungeons)
    {
      for (int index = 0; index < GenVars.dungeonGenVars.Count; ++index)
      {
        if (GenVars.dungeonGenVars[index].isPitTrapTile[tileType])
          return true;
      }
    }
    else if (GenVars.CurrentDungeonGenVars.isPitTrapTile[tileType])
      return true;
    return false;
  }

  public static bool IsConsideredDungeonWall(int wallType, bool allDungeons = false)
  {
    if (wallType > 0 && Main.wallDungeon[wallType])
      return true;
    if (allDungeons)
    {
      for (int index = 0; index < GenVars.dungeonGenVars.Count; ++index)
      {
        if (GenVars.dungeonGenVars[index].isDungeonWall[wallType])
          return true;
      }
    }
    else if (GenVars.CurrentDungeonGenVars.isDungeonWall[wallType])
      return true;
    return false;
  }

  public static bool IsConsideredDungeonWallGlass(int wallType, bool allDungeons = false)
  {
    if (allDungeons)
    {
      for (int index = 0; index < GenVars.dungeonGenVars.Count; ++index)
      {
        if (GenVars.dungeonGenVars[index].isDungeonWallGlass[wallType])
          return true;
      }
    }
    else if (GenVars.CurrentDungeonGenVars.isDungeonWallGlass[wallType])
      return true;
    return false;
  }

  public static bool IsHigherOrEqualTieredDungeonTile(
    DungeonData data,
    int currentTileType,
    int newTileType)
  {
    return DungeonUtils.GetTierForDungeonTile(data.genVars, currentTileType) >= DungeonUtils.GetTierForDungeonTile(data.genVars, newTileType);
  }

  public static bool IsHigherOrEqualTieredDungeonWall(
    DungeonData data,
    int currentWallType,
    int newWallType)
  {
    return DungeonUtils.GetTierForDungeonWall(data.genVars, currentWallType) >= DungeonUtils.GetTierForDungeonWall(data.genVars, newWallType);
  }

  public static double GetTierForDungeonTile(DungeonGenVars genVars, int tileType)
  {
    if (!WorldGen.SecretSeed.dualDungeons.Enabled)
      return tileType <= 0 || !Main.tileDungeon[tileType] ? -1.0 : 1.0;
    for (int index = 0; index < genVars.dungeonGenerationStyles.Count; ++index)
    {
      DungeonGenerationStyleData dungeonGenerationStyle = genVars.dungeonGenerationStyles[index];
      if (dungeonGenerationStyle.Style == (byte) 1 && DungeonGenerationStyles.Spider.TileIsInStyle(tileType))
        return (double) index + 0.25;
      if (dungeonGenerationStyle.Style == (byte) 1 && DungeonGenerationStyles.LivingWood.TileIsInStyle(tileType))
        return (double) index + 0.5;
      if (dungeonGenerationStyle.Style == (byte) 1 && DungeonGenerationStyles.Shimmer.TileIsInStyle(tileType))
        return (double) index + 0.75;
      if (dungeonGenerationStyle.Style == (byte) 8 && DungeonGenerationStyles.LivingMahogany.TileIsInStyle(tileType))
        return (double) index + 0.33;
      if (dungeonGenerationStyle.Style == (byte) 8 && DungeonGenerationStyles.Beehive.TileIsInStyle(tileType))
        return (double) index + 0.66;
      if (dungeonGenerationStyle.Style == (byte) 6 && DungeonGenerationStyles.Crystal.TileIsInStyle(tileType))
        return (double) index + 0.5;
      if (dungeonGenerationStyle.Style == (byte) 0 && Main.tileDungeon[tileType] || dungeonGenerationStyle.TileIsInStyle(tileType))
        return (double) index;
    }
    return Main.tileDungeon[tileType] ? -0.5 : -1.0;
  }

  public static double GetTierForDungeonWall(DungeonGenVars genVars, int wallType)
  {
    if (!WorldGen.SecretSeed.dualDungeons.Enabled)
      return wallType <= 0 || !Main.wallDungeon[wallType] ? -1.0 : 1.0;
    for (int index = 0; index < genVars.dungeonGenerationStyles.Count; ++index)
    {
      DungeonGenerationStyleData dungeonGenerationStyle = genVars.dungeonGenerationStyles[index];
      if (dungeonGenerationStyle.Style == (byte) 1 && DungeonGenerationStyles.Spider.WallIsInStyle(wallType))
        return (double) index + 0.25;
      if (dungeonGenerationStyle.Style == (byte) 1 && DungeonGenerationStyles.LivingWood.WallIsInStyle(wallType))
        return (double) index + 0.5;
      if (dungeonGenerationStyle.Style == (byte) 1 && DungeonGenerationStyles.Shimmer.WallIsInStyle(wallType))
        return (double) index + 0.75;
      if (dungeonGenerationStyle.Style == (byte) 8 && DungeonGenerationStyles.LivingMahogany.WallIsInStyle(wallType))
        return (double) index + 0.33;
      if (dungeonGenerationStyle.Style == (byte) 8 && DungeonGenerationStyles.Beehive.WallIsInStyle(wallType))
        return (double) index + 0.66;
      if (dungeonGenerationStyle.Style == (byte) 6 && DungeonGenerationStyles.Crystal.WallIsInStyle(wallType))
        return (double) index + 0.5;
      if (dungeonGenerationStyle.Style == (byte) 0 && Main.wallDungeon[wallType] || dungeonGenerationStyle.WallIsInStyle(wallType))
        return (double) index;
    }
    return Main.wallDungeon[wallType] ? -0.5 : -1.0;
  }

  public static void CreatePotentialDungeonBounds(
    out DungeonBounds innerBounds,
    out DungeonBounds outerBounds,
    bool leftDungeon,
    double percentInMiddle = 0.02,
    double percentOnEdges = 0.02,
    double percentOnTop = -1.0,
    double percentOnBottom = -1.0,
    int innerBuffer = 10)
  {
    if (percentOnTop == -1.0)
      percentOnTop = !SpecialSeedFeatures.DungeonEntranceIsUnderground ? (Main.worldSurface + 10.0) / (double) Main.maxTilesY : (GenVars.worldSurfaceHigh + 10.0) / (double) Main.maxTilesY;
    if (percentOnBottom == -1.0)
      percentOnBottom = ((double) Main.UnderworldLayer - 10.0) / (double) Main.maxTilesY;
    double num1 = percentInMiddle / 2.0;
    double num2 = (double) Main.maxTilesX / 4200.0;
    int minX = leftDungeon ? (int) ((double) Main.maxTilesX * percentOnEdges) : (int) ((double) Main.maxTilesX * (0.5 + num1));
    int maxX = leftDungeon ? (int) ((double) Main.maxTilesX * (0.5 - num1)) : Main.maxTilesX - (int) ((double) Main.maxTilesX * percentOnEdges);
    int minY = (int) ((double) Main.maxTilesY * percentOnTop);
    int maxY = (int) ((double) Main.maxTilesY * percentOnBottom);
    outerBounds = new DungeonBounds();
    outerBounds.SetBounds(minX, minY, maxX, maxY);
    innerBounds = new DungeonBounds();
    innerBounds.SetBounds(minX + innerBuffer, minY + innerBuffer, maxX - innerBuffer, maxY - innerBuffer);
  }

  public static bool InAnyPotentialDungeonBounds(int x, int y, int fluff = 0, bool inner = false)
  {
    return DungeonUtils.InAnyPotentialDungeonBounds(out int _, x, y, fluff, inner);
  }

  public static bool InAnyPotentialDungeonBounds(
    out int iteration,
    int x,
    int y,
    int fluff = 0,
    bool inner = false)
  {
    iteration = -1;
    for (int index = 0; index < GenVars.dungeonGenVars.Count; ++index)
    {
      DungeonGenVars dungeonGenVar = GenVars.dungeonGenVars[index];
      if (inner && dungeonGenVar.innerPotentialDungeonBounds.ContainsWithFluff(x, y, fluff) || !inner && dungeonGenVar.outerPotentialDungeonBounds.ContainsWithFluff(x, y, fluff))
      {
        iteration = index;
        return true;
      }
    }
    return false;
  }

  public static bool IntersectsAnyPotentialDungeonBounds(Microsoft.Xna.Framework.Rectangle rect, bool inner = false)
  {
    return DungeonUtils.IntersectsAnyPotentialDungeonBounds(out int _, rect, inner);
  }

  public static bool IntersectsAnyPotentialDungeonBounds(
    out int iteration,
    Microsoft.Xna.Framework.Rectangle rect,
    bool inner = false)
  {
    iteration = -1;
    for (int index = 0; index < GenVars.dungeonGenVars.Count; ++index)
    {
      DungeonGenVars dungeonGenVar = GenVars.dungeonGenVars[index];
      if (inner && dungeonGenVar.innerPotentialDungeonBounds.Intersects(rect) || !inner && dungeonGenVar.outerPotentialDungeonBounds.Intersects(rect))
      {
        iteration = index;
        return true;
      }
    }
    return false;
  }

  public static Microsoft.Xna.Framework.Rectangle GetExpandedDungeonAreaFromPoint(int x, int y)
  {
    for (int index1 = 0; index1 < 2; ++index1)
    {
      int index2 = x;
      int index3 = x;
      while (!Main.tile[index2, y].active() && DungeonUtils.IsConsideredDungeonWall((int) Main.tile[index2, y].wall))
        --index2;
      int num1 = index2 + 1;
      while (!Main.tile[index3, y].active() && DungeonUtils.IsConsideredDungeonWall((int) Main.tile[index3, y].wall))
        ++index3;
      int num2 = index3 - 1;
      x = (num1 + num2) / 2;
      int index4 = y;
      int index5 = y;
      while (!Main.tile[x, index4].active() && DungeonUtils.IsConsideredDungeonWall((int) Main.tile[x, index4].wall))
        --index4;
      int num3 = index4 + 1;
      while (!Main.tile[x, index5].active() && DungeonUtils.IsConsideredDungeonWall((int) Main.tile[x, index5].wall))
        ++index5;
      int num4 = index5 - 1;
      y = (num3 + num4) / 2;
    }
    int index6 = x;
    int index7 = x;
    while (!Main.tile[index6, y].active() && !Main.tile[index6, y - 1].active() && !Main.tile[index6, y + 1].active())
      --index6;
    int x1 = index6 + 1;
    while (!Main.tile[index7, y].active() && !Main.tile[index7, y - 1].active() && !Main.tile[index7, y + 1].active())
      ++index7;
    int num5 = index7 - 1;
    int index8 = y;
    int index9 = y;
    while (!Main.tile[x, index8].active() && !Main.tile[x - 1, index8].active() && !Main.tile[x + 1, index8].active())
      --index8;
    int y1 = index8 + 1;
    while (!Main.tile[x, index9].active() && !Main.tile[x - 1, index9].active() && !Main.tile[x + 1, index9].active())
      ++index9;
    int num6 = index9 - 1;
    return new Microsoft.Xna.Framework.Rectangle(x1, y1, num6 - y1, num5 - x1);
  }

  public static int CalculateFloodedTileCountFromShapeData(
    DungeonBounds innerBounds,
    ShapeData data)
  {
    Point16[] array = data.GetData().ToArray<Point16>();
    int countFromShapeData = 0;
    for (int index = 0; index < array.Length; ++index)
    {
      if ((int) array[index].Y > innerBounds.Center.Y)
        ++countFromShapeData;
    }
    return countFromShapeData;
  }

  public delegate ConnectionPointQuality GetHallwayConnectionPoint(
    DungeonRoom room,
    Vector2D otherRoomPos,
    out Vector2D connectionPoint);
}
