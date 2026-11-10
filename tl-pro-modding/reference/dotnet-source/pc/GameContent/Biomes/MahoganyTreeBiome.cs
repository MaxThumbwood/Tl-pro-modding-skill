// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Biomes.MahoganyTreeBiome
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria.GameContent.Generation;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.Biomes;

public class MahoganyTreeBiome : MicroBiome
{
  public override bool Place(Point origin, StructureMap structures, GenerationProgress progress)
  {
    Point result1;
    if (!WorldUtils.Find(new Point(origin.X - 3, origin.Y), Searches.Chain((GenSearch) new Searches.Down(200), new Conditions.IsSolid().AreaAnd(6, 1)), out result1))
      return false;
    Point result2;
    if (!WorldUtils.Find(new Point(result1.X, result1.Y - 5), Searches.Chain((GenSearch) new Searches.Up(120), new Conditions.IsSolid().AreaOr(6, 1)), out result2) || result1.Y - 5 - result2.Y > 60 || result1.Y - result2.Y < 30 || !structures.CanPlace(new Microsoft.Xna.Framework.Rectangle(result1.X - 30, result1.Y - 60, 60, 90)))
      return false;
    if (!WorldGen.drunkWorldGen || WorldGen.genRand.Next(50) > 0)
    {
      Dictionary<ushort, int> resultsOutput = new Dictionary<ushort, int>();
      WorldUtils.Gen(new Point(result1.X - 25, result1.Y - 25), (GenShape) new Shapes.Rectangle(50, 50), (GenAction) new Terraria.WorldBuilding.Actions.TileScanner(new ushort[12]
      {
        (ushort) 0,
        (ushort) 59,
        (ushort) 60,
        (ushort) 147,
        (ushort) 161,
        (ushort) 163,
        (ushort) 200,
        (ushort) 164,
        (ushort) 1,
        (ushort) 25,
        (ushort) 203,
        (ushort) 117
      }).Output(resultsOutput));
      int num1 = resultsOutput[(ushort) 1] + resultsOutput[(ushort) 25] + resultsOutput[(ushort) 203] + resultsOutput[(ushort) 117];
      int num2 = resultsOutput[(ushort) 0] + num1;
      int num3 = resultsOutput[(ushort) 59] + resultsOutput[(ushort) 60];
      int num4 = resultsOutput[(ushort) 161] + resultsOutput[(ushort) 163] + resultsOutput[(ushort) 200] + resultsOutput[(ushort) 164];
      if (resultsOutput[(ushort) 147] + num4 > num3 || num2 > num3 || num3 < 50)
        return false;
    }
    int num5 = (result1.Y - result2.Y - 9) / 5;
    int num6 = num5 * 5;
    int num7 = 0;
    double num8 = GenBase._random.NextDouble() + 1.0;
    double num9 = GenBase._random.NextDouble() + 2.0;
    if (GenBase._random.Next(2) == 0)
      num9 = -num9;
    for (int index = 0; index < num5; ++index)
    {
      int num10 = (int) (Math.Sin((double) (index + 1) / 12.0 * num8 * 3.1415927410125732) * num9);
      int num11 = num10 < num7 ? num10 - num7 : 0;
      WorldUtils.Gen(new Point(result1.X + num7 + num11, result1.Y - (index + 1) * 5), (GenShape) new Shapes.Rectangle(6 + Math.Abs(num10 - num7), 7), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.SkipTiles(new ushort[4]
      {
        (ushort) 21,
        (ushort) 467,
        (ushort) 226,
        (ushort) 237
      }), (GenAction) new Modifiers.SkipWalls(new ushort[1]
      {
        (ushort) 87
      }), (GenAction) new Terraria.WorldBuilding.Actions.RemoveWall(), (GenAction) new Terraria.WorldBuilding.Actions.SetTile((ushort) 383), (GenAction) new Terraria.WorldBuilding.Actions.SetFrames()));
      WorldUtils.Gen(new Point(result1.X + num7 + num11 + 2, result1.Y - (index + 1) * 5), (GenShape) new Shapes.Rectangle(2 + Math.Abs(num10 - num7), 5), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.SkipTiles(new ushort[4]
      {
        (ushort) 21,
        (ushort) 467,
        (ushort) 226,
        (ushort) 237
      }), (GenAction) new Modifiers.SkipWalls(new ushort[1]
      {
        (ushort) 87
      }), (GenAction) new Terraria.WorldBuilding.Actions.ClearTile(true), (GenAction) new Terraria.WorldBuilding.Actions.PlaceWall((ushort) 78)));
      WorldUtils.Gen(new Point(result1.X + num7 + 2, result1.Y - index * 5), (GenShape) new Shapes.Rectangle(2, 2), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.SkipTiles(new ushort[4]
      {
        (ushort) 21,
        (ushort) 467,
        (ushort) 226,
        (ushort) 237
      }), (GenAction) new Modifiers.SkipWalls(new ushort[1]
      {
        (ushort) 87
      }), (GenAction) new Terraria.WorldBuilding.Actions.ClearTile(true), (GenAction) new Terraria.WorldBuilding.Actions.PlaceWall((ushort) 78)));
      num7 = num10;
    }
    int num12 = 6;
    if (num9 < 0.0)
      num12 = 0;
    List<Point> endpoints = new List<Point>();
    for (int index = 0; index < 2; ++index)
    {
      double num13 = ((double) index + 1.0) / 3.0;
      int num14 = num12 + (int) (Math.Sin((double) num5 * num13 / 12.0 * num8 * 3.1415927410125732) * num9);
      double angle = GenBase._random.NextDouble() * 0.78539818525314331 - 0.78539818525314331 - 0.2;
      if (num12 == 0)
        angle -= 1.5707963705062866;
      WorldUtils.Gen(new Point(result1.X + num14, result1.Y - (int) ((double) (num5 * 5) * num13)), (GenShape) new ShapeBranch(angle, (double) GenBase._random.Next(12, 16 /*0x10*/)).OutputEndpoints(endpoints), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.SkipTiles(new ushort[4]
      {
        (ushort) 21,
        (ushort) 467,
        (ushort) 226,
        (ushort) 237
      }), (GenAction) new Modifiers.SkipWalls(new ushort[1]
      {
        (ushort) 87
      }), (GenAction) new Terraria.WorldBuilding.Actions.SetTile((ushort) 383), (GenAction) new Terraria.WorldBuilding.Actions.SetFrames(true)));
      num12 = 6 - num12;
    }
    int num15 = (int) (Math.Sin((double) num5 / 12.0 * num8 * 3.1415927410125732) * num9);
    WorldUtils.Gen(new Point(result1.X + 6 + num15, result1.Y - num6), (GenShape) new ShapeBranch(-0.68539818525314333, (double) GenBase._random.Next(16 /*0x10*/, 22)).OutputEndpoints(endpoints), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.SkipTiles(new ushort[4]
    {
      (ushort) 21,
      (ushort) 467,
      (ushort) 226,
      (ushort) 237
    }), (GenAction) new Modifiers.SkipWalls(new ushort[1]
    {
      (ushort) 87
    }), (GenAction) new Terraria.WorldBuilding.Actions.SetTile((ushort) 383), (GenAction) new Terraria.WorldBuilding.Actions.SetFrames(true)));
    WorldUtils.Gen(new Point(result1.X + num15, result1.Y - num6), (GenShape) new ShapeBranch(-2.45619455575943, (double) GenBase._random.Next(16 /*0x10*/, 22)).OutputEndpoints(endpoints), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.SkipTiles(new ushort[4]
    {
      (ushort) 21,
      (ushort) 467,
      (ushort) 226,
      (ushort) 237
    }), (GenAction) new Modifiers.SkipWalls(new ushort[1]
    {
      (ushort) 87
    }), (GenAction) new Terraria.WorldBuilding.Actions.SetTile((ushort) 383), (GenAction) new Terraria.WorldBuilding.Actions.SetFrames(true)));
    foreach (Point origin1 in endpoints)
    {
      Shapes.Circle shape = new Shapes.Circle(4);
      GenAction action = Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.Blotches(4, 2), (GenAction) new Modifiers.SkipTiles(new ushort[5]
      {
        (ushort) 383,
        (ushort) 21,
        (ushort) 467,
        (ushort) 226,
        (ushort) 237
      }), (GenAction) new Modifiers.SkipWalls(new ushort[2]
      {
        (ushort) 78,
        (ushort) 87
      }), (GenAction) new Terraria.WorldBuilding.Actions.SetTile((ushort) 384), (GenAction) new Terraria.WorldBuilding.Actions.SetFrames(true));
      WorldUtils.Gen(origin1, (GenShape) shape, action);
    }
    for (int index = 0; index < 4; ++index)
    {
      double angle = (double) index / 3.0 * 2.0 + 0.57075;
      WorldUtils.Gen(result1, (GenShape) new ShapeRoot(angle, (double) GenBase._random.Next(40, 60)), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.SkipTiles(new ushort[4]
      {
        (ushort) 21,
        (ushort) 467,
        (ushort) 226,
        (ushort) 237
      }), (GenAction) new Modifiers.SkipWalls(new ushort[1]
      {
        (ushort) 87
      }), (GenAction) new Terraria.WorldBuilding.Actions.SetTile((ushort) 383, true)));
    }
    WorldGen.AddBuriedChest(result1.X + 3, result1.Y - 1, WorldGen.GetNextJungleChestItem(), chestStyle: 10);
    structures.AddProtectedStructure(new Microsoft.Xna.Framework.Rectangle(result1.X - 30, result1.Y - 30, 60, 60));
    return true;
  }
}
