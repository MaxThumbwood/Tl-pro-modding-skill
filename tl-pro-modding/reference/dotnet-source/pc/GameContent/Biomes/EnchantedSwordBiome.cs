// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Biomes.EnchantedSwordBiome
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Newtonsoft.Json;
using System.Collections.Generic;
using Terraria.GameContent.Generation;
using Terraria.GameContent.Generation.Dungeon;
using Terraria.ID;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.Biomes;

public class EnchantedSwordBiome : MicroBiome
{
  [JsonProperty("ChanceOfEntrance")]
  private double _chanceOfEntrance;
  [JsonProperty("ChanceOfRealSword")]
  private double _chanceOfRealSword;

  public override bool Place(Point origin, StructureMap structures, GenerationProgress progress)
  {
    Dictionary<ushort, int> resultsOutput = new Dictionary<ushort, int>();
    WorldUtils.Gen(new Point(origin.X - 25, origin.Y - 25), (GenShape) new Shapes.Rectangle(50, 50), (GenAction) new Terraria.WorldBuilding.Actions.TileScanner(new ushort[2]
    {
      (ushort) 0,
      (ushort) 1
    }).Output(resultsOutput));
    int num1 = resultsOutput[(ushort) 0] + resultsOutput[(ushort) 1];
    if (WorldGen.SecretSeed.errorWorld.Enabled)
    {
      if (num1 < 625)
        return false;
    }
    else if (num1 < 1250)
      return false;
    int num2 = 55;
    if (WorldGen.SecretSeed.errorWorld.Enabled)
      num2 = 105;
    if (origin.Y <= num2)
      return false;
    int maxDistance = origin.Y - num2;
    int height = 50;
    if (maxDistance < height)
      height = maxDistance;
    Point result;
    if (!WorldUtils.Find(origin, Searches.Chain((GenSearch) new Searches.Up(maxDistance), new Conditions.IsSolid().AreaOr(1, height).Not()), out result) || result.Y <= num2)
    {
      if (!WorldGen.SecretSeed.errorWorld.Enabled)
        return false;
      result.Y = origin.Y - 100;
    }
    if (WorldUtils.Find(origin, Searches.Chain((GenSearch) new Searches.Up(origin.Y - result.Y), (GenCondition) new Conditions.IsTile(new ushort[1]
    {
      (ushort) 53
    })), out Point _) && !WorldGen.SecretSeed.errorWorld.Enabled)
      return false;
    result.Y += 50;
    ShapeData data1 = new ShapeData();
    ShapeData shapeData = new ShapeData();
    Point point1 = new Point(origin.X, origin.Y + 20);
    Point point2 = new Point(origin.X, origin.Y + 30);
    bool[] validTiles = new bool[TileID.Sets.GeneralPlacementTiles.Length];
    for (int index = 0; index < validTiles.Length; ++index)
      validTiles[index] = TileID.Sets.GeneralPlacementTiles[index];
    validTiles[21] = false;
    validTiles[467] = false;
    double xScale = 0.8 + GenBase._random.NextDouble() * 0.5;
    Microsoft.Xna.Framework.Rectangle rectangle1 = new Microsoft.Xna.Framework.Rectangle(point1.X - (int) (20.0 * xScale), point1.Y - 20, (int) (40.0 * xScale), 40);
    if (!structures.CanPlace(rectangle1, validTiles))
      return false;
    Microsoft.Xna.Framework.Rectangle rectangle2 = new Microsoft.Xna.Framework.Rectangle(origin.X, result.Y + 10, 1, origin.Y - result.Y - 9);
    if (!structures.CanPlace(rectangle2, validTiles, 2) || WorldGen.SecretSeed.dualDungeons.Enabled && (DungeonUtils.IntersectsAnyPotentialDungeonBounds(rectangle1) || DungeonUtils.IntersectsAnyPotentialDungeonBounds(rectangle2)))
      return false;
    WorldUtils.Gen(point1, (GenShape) new Shapes.Slime(20, xScale, 1.0), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.Blotches(chance: 0.4), new Terraria.WorldBuilding.Actions.ClearTile(true).Output(data1)));
    WorldUtils.Gen(point2, (GenShape) new Shapes.Mound(14, 14), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.Blotches(2, 1, 0.8), (GenAction) new Terraria.WorldBuilding.Actions.SetTile((ushort) 0), new Terraria.WorldBuilding.Actions.SetFrames(true).Output(shapeData)));
    data1.Subtract(shapeData, point1, point2);
    WorldUtils.Gen(point1, (GenShape) new ModShapes.InnerOutline(data1), Terraria.WorldBuilding.Actions.Chain((GenAction) new Terraria.WorldBuilding.Actions.SetTile((ushort) 2), (GenAction) new Terraria.WorldBuilding.Actions.SetFrames(true)));
    WorldUtils.Gen(point1, (GenShape) new ModShapes.All(data1), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.RectangleMask(-40, 40, 0, 40), (GenAction) new Modifiers.IsEmpty(), (GenAction) new Terraria.WorldBuilding.Actions.SetLiquid()));
    WorldUtils.Gen(point1, (GenShape) new ModShapes.All(data1), Terraria.WorldBuilding.Actions.Chain((GenAction) new Terraria.WorldBuilding.Actions.PlaceWall((ushort) 68), (GenAction) new Modifiers.OnlyTiles(new ushort[1]
    {
      (ushort) 2
    }), (GenAction) new Modifiers.Offset(0, 1), (GenAction) new ActionVines(3, 5, 382)));
    if (GenBase._random.NextDouble() <= this._chanceOfEntrance || WorldGen.tenthAnniversaryWorldGen)
    {
      ShapeData data2 = new ShapeData();
      WorldUtils.Gen(new Point(origin.X, result.Y + 10), (GenShape) new Shapes.Rectangle(1, origin.Y - result.Y - 9), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.Blotches(chance: 0.2), (GenAction) new Modifiers.SkipTiles(new ushort[2]
      {
        (ushort) 191,
        (ushort) 192 /*0xC0*/
      }), new Terraria.WorldBuilding.Actions.ClearTile().Output(data2), (GenAction) new Modifiers.Expand(1), (GenAction) new Modifiers.OnlyTiles(new ushort[1]
      {
        (ushort) 53
      }), new Terraria.WorldBuilding.Actions.SetTile((ushort) 397).Output(data2)));
      WorldUtils.Gen(new Point(origin.X, result.Y + 10), (GenShape) new ModShapes.All(data2), (GenAction) new Terraria.WorldBuilding.Actions.SetFrames(true));
    }
    if (GenBase._random.NextDouble() <= this._chanceOfRealSword)
      WorldGen.PlaceTile(point2.X, point2.Y - 15, 187, true, style: 17);
    else
      WorldGen.PlaceTile(point2.X, point2.Y - 15, 186, true, style: 15);
    WorldUtils.Gen(point2, (GenShape) new ModShapes.All(shapeData), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.Offset(0, -1), (GenAction) new Modifiers.OnlyTiles(new ushort[1]
    {
      (ushort) 2
    }), (GenAction) new Modifiers.Offset(0, -1), (GenAction) new ActionGrass()));
    structures.AddProtectedStructure(new Microsoft.Xna.Framework.Rectangle(point1.X - (int) (20.0 * xScale), point1.Y - 20, (int) (40.0 * xScale), 40), 10);
    return true;
  }
}
