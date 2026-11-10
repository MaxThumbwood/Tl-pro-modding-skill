// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Features.DungeonGlobalWallVariants
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Features;

public class DungeonGlobalWallVariants : GlobalDungeonFeature
{
  public DungeonGlobalWallVariants(DungeonFeatureSettings settings)
    : base(settings)
  {
    DungeonCrawler.CurrentDungeonData.dungeonFeatures.Add((IDungeonFeature) this);
  }

  public override bool GenerateFeature(DungeonData data)
  {
    this.generated = false;
    this.WallVariants(data);
    this.generated = true;
    return true;
  }

  public void WallVariants(DungeonData data)
  {
    UnifiedRandom genRand = WorldGen.genRand;
    int[] wallVariants = data.wallVariants;
    int length = wallVariants.Length;
    for (int index1 = 0; index1 < 5; ++index1)
    {
      for (int index2 = 0; index2 < length; ++index2)
      {
        int num1 = genRand.Next(40, 240 /*0xF0*/);
        int num2 = genRand.Next(data.dungeonBounds.Left, data.dungeonBounds.Right);
        int num3 = genRand.Next(data.dungeonBounds.Top, data.dungeonBounds.Bottom);
        for (int x = num2 - num1; x < num2 + num1; ++x)
        {
          for (int y = num3 - num1; y < num3 + num1; ++y)
          {
            if ((double) y > Main.worldSurface && WorldGen.InWorld(x, y, 2))
            {
              int num4 = Math.Abs(num2 - x);
              int num5 = Math.Abs(num3 - y);
              if (Math.Sqrt((double) (num4 * num4 + num5 * num5)) < (double) num1 * 0.40000000596046448 && Main.wallDungeon[(int) Main.tile[x, y].wall])
                this.SpreadWallDungeon(data, x, y, (ushort) wallVariants[index2]);
            }
          }
        }
      }
    }
  }

  public void SpreadWallDungeon(
    DungeonData data,
    int x,
    int y,
    ushort wallType,
    bool dungeonWallOnly = true)
  {
    if (!WorldGen.InWorld(x, y))
      return;
    ushort num = wallType;
    List<Point> pointList = new List<Point>();
    List<Point> collection = new List<Point>();
    HashSet<Point> pointSet = new HashSet<Point>();
    collection.Add(new Point(x, y));
    while (collection.Count > 0)
    {
      pointList.Clear();
      pointList.AddRange((IEnumerable<Point>) collection);
      collection.Clear();
      while (pointList.Count > 0)
      {
        Point point1 = pointList[0];
        if (!WorldGen.InWorld(point1.X, point1.Y, 1))
        {
          pointList.Remove(point1);
        }
        else
        {
          pointSet.Add(point1);
          pointList.Remove(point1);
          Tile tile = Main.tile[point1.X, point1.Y];
          if (tile.wall != (ushort) 0 && (int) tile.wall != (int) num && tile.wall != (ushort) 244 && tile.wall != (ushort) 62 && data.CanGenerateFeatureAt((IDungeonFeature) this, point1.X, point1.Y))
          {
            if (data.dungeonEntrance.Bounds.Contains(point1.X, point1.Y))
            {
              if ((int) tile.wall != (int) data.dungeonEntrance.settings.StyleData.BrickWallType)
                continue;
            }
            else if (dungeonWallOnly && (int) tile.wall != (int) data.genVars.brickWallType)
              continue;
            if (!WorldGen.SolidTile(point1.X, point1.Y))
            {
              tile.wall = num;
              Point point2 = new Point(point1.X - 1, point1.Y);
              if (!pointSet.Contains(point2))
                collection.Add(point2);
              point2 = new Point(point1.X + 1, point1.Y);
              if (!pointSet.Contains(point2))
                collection.Add(point2);
              point2 = new Point(point1.X, point1.Y - 1);
              if (!pointSet.Contains(point2))
                collection.Add(point2);
              point2 = new Point(point1.X, point1.Y + 1);
              if (!pointSet.Contains(point2))
                collection.Add(point2);
            }
            else if (tile.active())
              tile.wall = num;
          }
        }
      }
    }
  }
}
