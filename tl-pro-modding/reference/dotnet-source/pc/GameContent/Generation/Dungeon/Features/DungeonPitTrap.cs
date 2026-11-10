// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Features.DungeonPitTrap
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;
using Terraria.GameContent.Generation.Dungeon.Rooms;
using Terraria.ID;
using Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Features;

public class DungeonPitTrap : DungeonFeature
{
  public bool Flooded;

  public DungeonPitTrap(DungeonFeatureSettings settings, bool addToFeatures = true)
    : base(settings)
  {
    if (!addToFeatures)
      return;
    DungeonCrawler.CurrentDungeonData.dungeonFeatures.Add((IDungeonFeature) this);
  }

  public override bool GenerateFeature(DungeonData data, int x, int y)
  {
    this.generated = false;
    DungeonGenerationStyleData style = ((DungeonPitTrapSettings) this.settings).Style;
    if (!this.PitTrap(data, x, y, style.BrickTileType, style.PitTrapTileType, style.BrickWallType, true))
      return false;
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
      case DungeonGlobalPaintings _:
      case DungeonGlobalWallVariants _:
        return true;
      default:
        return false;
    }
  }

  public bool PitTrap(
    DungeonData data,
    int i,
    int j,
    ushort tileType,
    ushort pitTrapTileType,
    ushort wallType,
    bool generating = false)
  {
    UnifiedRandom genRand = WorldGen.genRand;
    DungeonPitTrapSettings settings = (DungeonPitTrapSettings) this.settings;
    bool flag1 = data.Type == DungeonType.DualDungeon;
    bool flag2 = TileID.Sets.Falling[(int) pitTrapTileType];
    bool crackedBrick = TileID.Sets.CrackedBricks[(int) pitTrapTileType];
    bool flag3 = !flag2 && !crackedBrick;
    int index1 = i;
    int y1 = j;
    int minY = y1;
    int width = settings.Width;
    int height = settings.Height;
    if (width < 1 || height < 1)
      return false;
    if (flag1 && (this.Flooded || settings.Flooded))
    {
      int num = 300;
      for (int index2 = width * Math.Max(1, height - settings.TopDensity); index2 < num; index2 = width * Math.Max(1, height - settings.TopDensity))
        ++height;
    }
    int outerWidth = width + settings.EdgeWidth;
    int num1 = height + settings.EdgeHeight;
    if (!WorldGen.InWorld(index1, y1, outerWidth > num1 ? outerWidth : num1) || !DungeonUtils.IsConsideredDungeonWall((int) Main.tile[index1, y1].wall) || Main.tile[index1, y1].active())
      return false;
    for (int j1 = y1; j1 < Main.maxTilesY; ++j1)
    {
      if (j1 > Main.UnderworldLayer)
        return false;
      if (Main.tile[index1, j1].active() && WorldGen.SolidTile(index1, j1))
      {
        if (Main.tile[index1, j1].type == (ushort) 48 /*0x30*/)
          return false;
        y1 = j1;
        minY = j1;
        break;
      }
    }
    if (!DungeonUtils.IsConsideredDungeonWall((int) Main.tile[index1 - width, y1].wall) || !DungeonUtils.IsConsideredDungeonWall((int) Main.tile[index1 + width, y1].wall))
      return false;
    if (data.Type == DungeonType.DualDungeon)
    {
      for (int index3 = index1 - outerWidth; index3 <= index1 + outerWidth; ++index3)
      {
        for (int index4 = y1; index4 < y1 + num1 + 2; ++index4)
        {
          Tile tile = Main.tile[index3, index4];
          if (tile.active() && (int) tile.type != (int) tileType || (int) tile.wall != (int) wallType)
            return false;
        }
      }
    }
    int num2 = 30;
    for (int index5 = y1; index5 < y1 + num2; ++index5)
    {
      bool flag4 = true;
      for (int index6 = index1 - width; index6 <= index1 + width; ++index6)
      {
        Tile tile = Main.tile[index6, index5];
        if (tile.active() && DungeonUtils.IsConsideredDungeonTile((int) tile.type))
        {
          flag4 = false;
          break;
        }
      }
      if (flag4)
      {
        y1 = index5;
        break;
      }
    }
    if (y1 + num1 >= Main.UnderworldLayer)
      return false;
    int[] heights = new int[outerWidth * 2 + 1];
    if (flag1)
    {
      for (int index7 = index1 - outerWidth; index7 <= index1 + outerWidth; ++index7)
      {
        int index8 = y1;
        for (Tile tile = Main.tile[index7, index8]; index8 > 10 && tile.active() && (DungeonUtils.IsConsideredDungeonTile((int) tile.type) || DungeonUtils.IsConsideredCrackedDungeonTile((int) tile.type) || DungeonUtils.IsConsideredPitTrapTile((int) tile.type)); tile = Main.tile[index7, index8])
          --index8;
        heights[index7 - (index1 - outerWidth)] = index8 + 1;
      }
    }
    this.Bounds.SetBounds(index1 - outerWidth, minY, index1 + outerWidth, y1 + num1);
    this.Bounds.CalculateHitbox();
    if (flag1)
    {
      if (!data.CanGenerateFeatureInArea((IDungeonFeature) this, this.Bounds))
        return false;
      if (settings.ConnectedRoom != null)
      {
        DungeonRoom connectedRoom = settings.ConnectedRoom;
        for (int x = index1 - outerWidth; x <= index1 + outerWidth; ++x)
        {
          for (int y2 = minY; y2 <= y1 + num1; ++y2)
          {
            if ((x < index1 - width || x > index1 + width || y2 < y1 || y2 > y1 + height) && !connectedRoom.OuterBounds.Contains(x, y2))
            {
              Tile tile = Main.tile[x, y2];
              if (!tile.active() && DungeonUtils.IsConsideredDungeonWall((int) tile.wall))
                return false;
            }
          }
        }
      }
    }
    else
    {
      for (int index9 = index1 - width; index9 <= index1 + width; ++index9)
      {
        for (int index10 = y1; index10 <= y1 + height; ++index10)
        {
          Tile tile = Main.tile[index9, index10];
          if (tile.active() && (DungeonUtils.IsConsideredDungeonTile((int) tile.type) || DungeonUtils.IsConsideredCrackedDungeonTile((int) tile.type) || DungeonUtils.IsConsideredPitTrapTile((int) tile.type)))
            return false;
        }
      }
    }
    if (generating && !flag1)
    {
      for (int index11 = index1 - width; index11 <= index1 + width; ++index11)
      {
        for (int index12 = minY; index12 <= y1 + height; ++index12)
        {
          Tile tile = Main.tile[index11, index12];
          if (tile.active() && DungeonUtils.IsConsideredDungeonTile((int) tile.type))
          {
            DungeonUtils.ChangeTileType(tile, pitTrapTileType, true);
            DungeonUtils.ChangeWallType(tile, wallType, false);
          }
        }
      }
    }
    if (generating)
    {
      for (int index13 = index1 - outerWidth; index13 <= index1 + outerWidth; ++index13)
      {
        int num3 = minY;
        if (flag1)
          num3 = this.GetHeight(heights, index1, index13 - (index1 - outerWidth), width, outerWidth, false);
        for (int index14 = num3; index14 <= y1 + num1; ++index14)
        {
          Tile tile = Main.tile[index13, index14];
          tile.liquidType(0);
          tile.liquid = (byte) 0;
          if (!DungeonUtils.IsConsideredDungeonWall((int) tile.wall))
          {
            if (index13 > index1 - outerWidth && index13 < index1 + outerWidth && index14 < y1 + num1)
            {
              ushort wall = tile.wall;
              DungeonUtils.ChangeTileType(tile, tileType, true);
              if (!DungeonUtils.IsConsideredDungeonWall((int) wall))
                DungeonUtils.ChangeWallType(tile, wallType, false);
            }
            else
              DungeonUtils.ChangeTileType(tile, tileType, false);
          }
        }
      }
    }
    if (generating)
    {
      for (int index15 = index1 - width; index15 <= index1 + width; ++index15)
      {
        int num4 = minY;
        if (flag1)
          num4 = this.GetHeight(heights, index1, index15 - (index1 - width), width, outerWidth, true);
        for (int index16 = num4; index16 <= y1 + height; ++index16)
        {
          bool flag5;
          if (flag1 && index16 <= minY + settings.TopDensity)
          {
            flag5 = false;
            if (Main.tile[index15, index16].active())
              DungeonUtils.ChangeTileType(Main.tile[index15, index16], pitTrapTileType, false);
            Main.tile[index15, index16].liquidType(0);
            Main.tile[index15, index16].liquid = (byte) 0;
          }
          else
            flag5 = (int) Main.tile[index15, index16].type != (int) pitTrapTileType;
          if (flag5)
          {
            if (settings.Flooded)
            {
              Main.tile[index15, index16].liquidType(0);
              Main.tile[index15, index16].liquid = byte.MaxValue;
            }
            else
            {
              Main.tile[index15, index16].liquidType(0);
              Main.tile[index15, index16].liquid = (byte) 0;
            }
            int num5 = index15 != index1 - width ? 0 : (Main.tile[index15 - 1, index16].active() ? 1 : 0);
            bool flag6 = index15 == index1 + width && Main.tile[index15 + 1, index16].active();
            bool flag7 = index16 == y1 + height && Main.tile[index15, index16 + 1].active();
            bool flag8 = index15 == index1 - width + 1 && index16 % 2 == 0 && Main.tile[index15 - 1, index16].active();
            bool flag9 = index15 == index1 + width - 1 && index16 % 2 == 0 && Main.tile[index15 + 1, index16].active();
            bool flag10 = index16 == y1 + height - 1 && index15 % 2 == 0 && Main.tile[index15, index16 + 1].active();
            int num6 = flag6 ? 1 : 0;
            if ((num5 | num6 | (flag7 ? 1 : 0)) != 0)
              DungeonUtils.ChangeTileType(Main.tile[index15, index16], (ushort) 48 /*0x30*/, false);
            else if (flag8 | flag9 | flag10)
              DungeonUtils.ChangeTileType(Main.tile[index15, index16], (ushort) 48 /*0x30*/, false);
            else if (flag2)
            {
              if (index15 <= index1 - width + 2 || index15 >= index1 + width - 2 || index16 >= y1 + height - 2)
              {
                DungeonUtils.ChangeTileType(Main.tile[index15, index16], tileType, false);
                Main.tile[index15, index16].inActive(true);
              }
              else
                Main.tile[index15, index16].active(false);
            }
            else
              Main.tile[index15, index16].active(false);
          }
        }
      }
    }
    if (generating && !crackedBrick)
    {
      Point point = Point.Zero;
      for (int index17 = index1 - outerWidth; index17 <= index1 + outerWidth; ++index17)
      {
        int num7 = index17 < index1 - width ? 0 : (index17 <= index1 + width ? 1 : 0);
        int num8 = minY;
        if (flag1)
          num8 = this.GetHeight(heights, index1, index17 - (index1 - outerWidth), width, outerWidth, false);
        for (int index18 = num8 - 1; index18 <= y1 + num1; ++index18)
        {
          Tile tile1 = Main.tile[index17, index18];
          if (tile1.active() && (int) tile1.type == (int) pitTrapTileType)
          {
            bool flag11 = false;
            bool flag12 = false;
            if (flag3)
              flag11 = flag12 = true;
            else if (flag2)
            {
              Tile tile2 = Main.tile[index17, index18 + 1];
              if (index17 == index1 - width)
                flag11 = true;
              if (!tile2.active() || (int) tile2.type != (int) pitTrapTileType)
              {
                flag11 = flag12 = true;
                tile1.type = tileType;
              }
            }
            if (flag11)
              tile1.wire(true);
            if (flag12)
              tile1.actuator(true);
            if (tile1.slope() == (byte) 0 && !tile1.halfBrick() && !Main.tile[index17, index18 - 1].active())
            {
              WorldGen.PlaceTile(index17, index18 - 1, 135, true, style: 7);
              Tile tile3 = Main.tile[index17, index18 - 1];
              if (tile3.active() && tile3.type == (ushort) 135)
              {
                tile3.wire(true);
                if (point != Point.Zero)
                  WorldGen.AddWireFromPointToPoint(index17, index18 - 1, point.X, point.Y);
                point = new Point(index17, index18 - 1);
              }
            }
          }
        }
      }
    }
    this.Flooded = settings.Flooded;
    return true;
  }

  public int GetHeight(
    int[] heights,
    int baseX,
    int x,
    int innerWidth,
    int outerWidth,
    bool inner)
  {
    if (inner)
      x += outerWidth - innerWidth;
    return heights[x];
  }
}
