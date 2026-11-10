// Decompiled with JetBrains decompiler
// Type: Terraria.WorldBuilding.WorldUtils
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;
using Terraria.Testing;

#nullable disable
namespace Terraria.WorldBuilding;

public static class WorldUtils
{
  public static Microsoft.Xna.Framework.Rectangle ClampToWorld(Microsoft.Xna.Framework.Rectangle tileRectangle, int fluff = 0)
  {
    int x = Math.Max(fluff, Math.Min(tileRectangle.Left, Main.maxTilesX - fluff));
    int y = Math.Max(fluff, Math.Min(tileRectangle.Top, Main.maxTilesY - fluff));
    int num1 = Math.Max(fluff, Math.Min(tileRectangle.Right, Main.maxTilesX - fluff));
    int num2 = Math.Max(fluff, Math.Min(tileRectangle.Bottom, Main.maxTilesY - fluff));
    return new Microsoft.Xna.Framework.Rectangle(x, y, num1 - x, num2 - y);
  }

  public static Microsoft.Xna.Framework.Rectangle GetWorldPlayArea()
  {
    int num = 640;
    Point point1 = new Point((int) Main.leftWorld + num, (int) Main.topWorld + num);
    Point point2 = new Point((int) Main.rightWorld - num, (int) Main.bottomWorld - num);
    return new Microsoft.Xna.Framework.Rectangle(point1.X, point1.Y, point2.X - point1.X, point2.Y - point1.Y);
  }

  public static Microsoft.Xna.Framework.Rectangle ClampToWorldBorders(Microsoft.Xna.Framework.Rectangle worldRect)
  {
    return DebugOptions.noLimits ? worldRect : Utils.Clamp(worldRect, WorldUtils.GetWorldPlayArea());
  }

  public static bool Gen(Point origin, GenShape shape, GenAction action)
  {
    return shape.Perform(origin, action);
  }

  public static bool Gen(Point origin, GenShapeActionPair pair)
  {
    return pair.Shape.Perform(origin, pair.Action);
  }

  public static bool Find(Point origin, GenSearch search, out Point result)
  {
    result = search.Find(origin);
    return !(result == GenSearch.NOT_FOUND);
  }

  public static void ClearTile(int x, int y, bool frameNeighbors = false)
  {
    Main.tile[x, y].ClearTile();
    if (!frameNeighbors)
      return;
    WorldGen.TileFrame(x + 1, y);
    WorldGen.TileFrame(x - 1, y);
    WorldGen.TileFrame(x, y + 1);
    WorldGen.TileFrame(x, y - 1);
  }

  public static void ClearWall(int x, int y, bool frameNeighbors = false)
  {
    Main.tile[x, y].wall = (ushort) 0;
    if (!frameNeighbors)
      return;
    WorldGen.SquareWallFrame(x + 1, y);
    WorldGen.SquareWallFrame(x - 1, y);
    WorldGen.SquareWallFrame(x, y + 1);
    WorldGen.SquareWallFrame(x, y - 1);
  }

  public static void TileFrame(int x, int y, bool frameNeighbors = false)
  {
    WorldGen.TileFrame(x, y, true);
    if (!frameNeighbors)
      return;
    WorldGen.TileFrame(x + 1, y, true);
    WorldGen.TileFrame(x - 1, y, true);
    WorldGen.TileFrame(x, y + 1, true);
    WorldGen.TileFrame(x, y - 1, true);
  }

  public static void WallFrame(int x, int y, bool frameNeighbors = false)
  {
    Framing.WallFrame(x, y, true);
    if (!frameNeighbors)
      return;
    Framing.WallFrame(x + 1, y, true);
    Framing.WallFrame(x - 1, y, true);
    Framing.WallFrame(x, y + 1, true);
    Framing.WallFrame(x, y - 1, true);
  }

  public static void ClearChestLocation(int x, int y)
  {
    WorldUtils.ClearTile(x, y, true);
    WorldUtils.ClearTile(x - 1, y, true);
    WorldUtils.ClearTile(x, y - 1, true);
    WorldUtils.ClearTile(x - 1, y - 1, true);
  }

  public static void WireLine(Point start, Point end)
  {
    Point point1 = start;
    Point point2 = end;
    if (end.X < start.X)
      Utils.Swap<int>(ref end.X, ref start.X);
    if (end.Y < start.Y)
      Utils.Swap<int>(ref end.Y, ref start.Y);
    for (int x = start.X; x <= end.X; ++x)
      WorldGen.PlaceWire(x, point1.Y);
    for (int y = start.Y; y <= end.Y; ++y)
      WorldGen.PlaceWire(point2.X, y);
  }

  public static void DebugRegen()
  {
    WorldGen.GenerateWorld();
    Main.NewText("World Regen Complete.");
  }

  public static void DebugRotate()
  {
    int num1 = 0;
    int num2 = 0;
    int maxTilesY = Main.maxTilesY;
    for (int index1 = 0; index1 < Main.maxTilesX / Main.maxTilesY; ++index1)
    {
      for (int index2 = 0; index2 < maxTilesY / 2; ++index2)
      {
        for (int index3 = index2; index3 < maxTilesY - index2; ++index3)
        {
          Tile tile = Main.tile[index3 + num1, index2 + num2];
          Main.tile[index3 + num1, index2 + num2] = Main.tile[index2 + num1, maxTilesY - index3 + num2];
          Main.tile[index2 + num1, maxTilesY - index3 + num2] = Main.tile[maxTilesY - index3 + num1, maxTilesY - index2 + num2];
          Main.tile[maxTilesY - index3 + num1, maxTilesY - index2 + num2] = Main.tile[maxTilesY - index2 + num1, index3 + num2];
          Main.tile[maxTilesY - index2 + num1, index3 + num2] = tile;
        }
      }
      num1 += maxTilesY;
    }
  }
}
