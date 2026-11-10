// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Biomes.ThinIceBiome
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.Biomes;

public class ThinIceBiome : MicroBiome
{
  public override bool Place(Point origin, StructureMap structures, GenerationProgress progress)
  {
    Dictionary<ushort, int> resultsOutput = new Dictionary<ushort, int>();
    WorldUtils.Gen(new Point(origin.X - 25, origin.Y - 25), (GenShape) new Shapes.Rectangle(50, 50), (GenAction) new Terraria.WorldBuilding.Actions.TileScanner(new ushort[5]
    {
      (ushort) 0,
      (ushort) 59,
      (ushort) 147,
      (ushort) 1,
      (ushort) 225
    }).Output(resultsOutput));
    int num1 = resultsOutput[(ushort) 0] + resultsOutput[(ushort) 1];
    int num2 = resultsOutput[(ushort) 59];
    int num3 = resultsOutput[(ushort) 147];
    if (resultsOutput[(ushort) 225] > 0 || num3 <= num2 || num3 <= num1)
      return false;
    int num4 = 0;
    for (int radius = GenBase._random.Next(10, 15); radius > 5; --radius)
    {
      int num5 = GenBase._random.Next(-5, 5);
      WorldUtils.Gen(new Point(origin.X + num5, origin.Y + num4), (GenShape) new Shapes.Circle(radius), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.Blotches(4), (GenAction) new Modifiers.OnlyTiles(new ushort[5]
      {
        (ushort) 147,
        (ushort) 161,
        (ushort) 224 /*0xE0*/,
        (ushort) 0,
        (ushort) 1
      }), (GenAction) new Terraria.WorldBuilding.Actions.SetTile((ushort) 162, true)));
      WorldUtils.Gen(new Point(origin.X + num5, origin.Y + num4), (GenShape) new Shapes.Circle(radius), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.Blotches(4), (GenAction) new Modifiers.HasLiquid(), (GenAction) new Modifiers.SkipTiles(new ushort[4]
      {
        (ushort) 21,
        (ushort) 467,
        (ushort) 226,
        (ushort) 237
      }), (GenAction) new Terraria.WorldBuilding.Actions.SetTile((ushort) 162, true), (GenAction) new Terraria.WorldBuilding.Actions.SetLiquid(value: (byte) 0)));
      num4 += radius - 2;
    }
    structures.AddStructure(new Microsoft.Xna.Framework.Rectangle(origin.X - 25, origin.Y - 25, 50, 50), 8);
    return true;
  }
}
