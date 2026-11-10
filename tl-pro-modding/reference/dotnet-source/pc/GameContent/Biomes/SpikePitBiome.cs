// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Biomes.SpikePitBiome
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.Biomes;

public class SpikePitBiome : MicroBiome
{
  public override bool Place(Point origin, StructureMap structures, GenerationProgress progress)
  {
    if (WorldGen.SolidTile(origin.X, origin.Y) && GenBase._tiles[origin.X, origin.Y].wall == (ushort) 3)
      return false;
    if (!WorldUtils.Find(origin, Searches.Chain((GenSearch) new Searches.Down(100), (GenCondition) new Conditions.IsSolid()), out origin))
      return false;
    ushort type = 1;
    if (WorldGen.notTheBees)
      type = (ushort) 225;
    if (!WorldUtils.Find(new Point(origin.X - 4, origin.Y), Searches.Chain((GenSearch) new Searches.Down(5), new Conditions.IsTile(new ushort[1]
    {
      type
    }).AreaAnd(8, 1)), out Point _))
      return false;
    ShapeData data1 = new ShapeData();
    ShapeData shapeData1 = new ShapeData();
    ShapeData shapeData2 = new ShapeData();
    for (int index = 0; index < 4; ++index)
      WorldUtils.Gen(origin, (GenShape) new Shapes.Circle(GenBase._random.Next(8, 10) + index), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.Offset(0, 5 * index + 5), new Modifiers.Blotches(3).Output(data1)));
    for (int index = 0; index < 4; ++index)
      WorldUtils.Gen(origin, (GenShape) new Shapes.Circle(GenBase._random.Next(6, 7) + index), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.Offset(0, 2 * index + 12), new Modifiers.Blotches(3).Output(shapeData1)));
    for (int index = 0; index < 4; ++index)
      WorldUtils.Gen(origin, (GenShape) new Shapes.Circle(GenBase._random.Next(4, 5) + index / 2), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.Offset(0, (int) (7.5 * (double) index) - 10), new Modifiers.Blotches(3).Output(shapeData2)));
    ShapeData data2 = new ShapeData(shapeData1);
    shapeData1.Subtract(shapeData2, origin, origin);
    data2.Subtract(shapeData1, origin, origin);
    Microsoft.Xna.Framework.Rectangle bounds = ShapeData.GetBounds(origin, data1, shapeData2);
    if (!structures.CanPlace(bounds, 2))
      return false;
    WorldUtils.Gen(origin, (GenShape) new ModShapes.All(data1), Terraria.WorldBuilding.Actions.Chain((GenAction) new Terraria.WorldBuilding.Actions.SetTile(type, true)));
    WorldUtils.Gen(origin, (GenShape) new ModShapes.All(shapeData2), (GenAction) new Terraria.WorldBuilding.Actions.ClearTile(true));
    WorldUtils.Gen(origin, (GenShape) new ModShapes.All(data2), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.IsTouchingAir(true), (GenAction) new Modifiers.IsTouching(true, new ushort[1]
    {
      type
    }), (GenAction) new Terraria.WorldBuilding.Actions.SetTile((ushort) 48 /*0x30*/, true)));
    WorldUtils.Gen(origin, (GenShape) new ModShapes.All(data2), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.Checkerboard(2), (GenAction) new Modifiers.IsTouchingAir(true), (GenAction) new Modifiers.IsTouching(false, new ushort[1]
    {
      (ushort) 48 /*0x30*/
    }), (GenAction) new Terraria.WorldBuilding.Actions.SetTile((ushort) 48 /*0x30*/, true)));
    structures.AddProtectedStructure(bounds, 2);
    return true;
  }
}
