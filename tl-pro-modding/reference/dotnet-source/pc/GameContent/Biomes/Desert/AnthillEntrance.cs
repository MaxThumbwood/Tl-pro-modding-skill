// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Biomes.Desert.AnthillEntrance
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.Biomes.Desert;

public static class AnthillEntrance
{
  public static void Place(
    DesertDescription description,
    GenerationProgress progress,
    float progressMin,
    float progressMax)
  {
    int num1 = WorldGen.genRand.Next(2, 4);
    for (int index = 0; index < num1; ++index)
    {
      progress.Set((double) index / (double) num1, (double) progressMin, (double) progressMax);
      int holeRadius = WorldGen.genRand.Next(15, 18);
      int num2 = (int) ((double) (index + 1) / (double) (num1 + 1) * (double) description.Surface.Width) + description.Desert.Left;
      int y = (int) description.Surface[num2];
      AnthillEntrance.PlaceAt(description, new Point(num2, y), holeRadius);
    }
  }

  private static void PlaceAt(DesertDescription description, Point position, int holeRadius)
  {
    ShapeData data = new ShapeData();
    Point origin = new Point(position.X, position.Y + 6);
    WorldUtils.Gen(origin, (GenShape) new Shapes.Tail((double) (holeRadius * 2), new Vector2D(0.0, (double) -holeRadius * 1.5)), Terraria.WorldBuilding.Actions.Chain(new Terraria.WorldBuilding.Actions.SetTile((ushort) 53).Output(data)));
    GenShapeActionPair pair1 = new GenShapeActionPair((GenShape) new Shapes.Rectangle(1, 1), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.Blotches(), (GenAction) new Modifiers.IsSolid(), (GenAction) new Terraria.WorldBuilding.Actions.Clear(), (GenAction) new Terraria.WorldBuilding.Actions.PlaceWall((ushort) 187)));
    GenShapeActionPair genShapeActionPair = new GenShapeActionPair((GenShape) new Shapes.Rectangle(1, 1), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.IsSolid(), (GenAction) new Terraria.WorldBuilding.Actions.Clear(), (GenAction) new Terraria.WorldBuilding.Actions.PlaceWall((ushort) 187)));
    GenShapeActionPair pair2 = new GenShapeActionPair((GenShape) new Shapes.Circle(2, 3), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.IsSolid(), (GenAction) new Terraria.WorldBuilding.Actions.SetTile((ushort) 397), (GenAction) new Terraria.WorldBuilding.Actions.PlaceWall((ushort) 187)));
    GenShapeActionPair pair3 = new GenShapeActionPair((GenShape) new Shapes.Circle(holeRadius, 3), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.SkipWalls(new ushort[1]
    {
      (ushort) 187
    }), (GenAction) new Terraria.WorldBuilding.Actions.SetTile((ushort) 53)));
    GenShapeActionPair pair4 = new GenShapeActionPair((GenShape) new Shapes.Circle(holeRadius - 2, 3), Terraria.WorldBuilding.Actions.Chain((GenAction) new Terraria.WorldBuilding.Actions.PlaceWall((ushort) 187)));
    int x = position.X;
    int y1 = position.Y - holeRadius - 3;
    while (true)
    {
      int num1 = y1;
      Microsoft.Xna.Framework.Rectangle rectangle = description.Hive;
      int top1 = rectangle.Top;
      int y2 = position.Y;
      rectangle = description.Desert;
      int top2 = rectangle.Top;
      int num2 = (y2 - top2) * 2;
      int num3 = top1 + num2 + 12;
      if (num1 < num3)
      {
        WorldUtils.Gen(new Point(x, y1), y1 < position.Y ? genShapeActionPair : pair1);
        WorldUtils.Gen(new Point(x, y1), pair2);
        if (y1 % 3 == 0 && y1 >= position.Y)
        {
          x += WorldGen.genRand.Next(-1, 2);
          WorldUtils.Gen(new Point(x, y1), pair1);
          if (y1 >= position.Y + 5)
          {
            WorldUtils.Gen(new Point(x, y1), pair3);
            WorldUtils.Gen(new Point(x, y1), pair4);
          }
          WorldUtils.Gen(new Point(x, y1), pair2);
        }
        ++y1;
      }
      else
        break;
    }
    WorldUtils.Gen(new Point(origin.X, origin.Y - (int) ((double) holeRadius * 1.5) + 3), (GenShape) new Shapes.Circle(holeRadius / 2, holeRadius / 3), Terraria.WorldBuilding.Actions.Chain(Terraria.WorldBuilding.Actions.Chain((GenAction) new Terraria.WorldBuilding.Actions.ClearTile(), (GenAction) new Modifiers.Expand(1), (GenAction) new Terraria.WorldBuilding.Actions.PlaceWall((ushort) 0))));
    WorldUtils.Gen(origin, (GenShape) new ModShapes.All(data), (GenAction) new Terraria.WorldBuilding.Actions.Smooth());
  }
}
