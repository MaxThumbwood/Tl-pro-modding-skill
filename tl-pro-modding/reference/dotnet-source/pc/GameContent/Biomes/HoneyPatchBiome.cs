// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Biomes.HoneyPatchBiome
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.Biomes;

public class HoneyPatchBiome : MicroBiome
{
  public override bool Place(Point origin, StructureMap structures, GenerationProgress progress)
  {
    if (GenBase._tiles[origin.X, origin.Y].active() && WorldGen.SolidTile(origin.X, origin.Y))
      return false;
    Point result;
    if (!WorldUtils.Find(origin, Searches.Chain((GenSearch) new Searches.Down(80 /*0x50*/), (GenCondition) new Conditions.IsSolid()), out result))
      return false;
    result.Y += 2;
    Ref<int> count1 = new Ref<int>(0);
    Ref<int> count2 = new Ref<int>(0);
    Ref<int> count3 = new Ref<int>(0);
    WorldUtils.Gen(result, (GenShape) new Shapes.Circle(15), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.IsSolid(), (GenAction) new Terraria.WorldBuilding.Actions.Scanner(count1), (GenAction) new Modifiers.OnlyTiles(new ushort[2]
    {
      (ushort) 60,
      (ushort) 59
    }), (GenAction) new Terraria.WorldBuilding.Actions.Scanner(count2), (GenAction) new Modifiers.OnlyTiles(new ushort[1]
    {
      (ushort) 60
    }), (GenAction) new Terraria.WorldBuilding.Actions.Scanner(count3)));
    if ((double) count2.Value / (double) count1.Value < 0.75 || count3.Value < 2)
      return false;
    Ref<int> count4 = new Ref<int>(0);
    WorldUtils.Gen(result, (GenShape) new Shapes.Circle(8), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.IsSolid(), (GenAction) new Terraria.WorldBuilding.Actions.Scanner(count4)));
    if (count4.Value < 20 || !structures.CanPlace(new Microsoft.Xna.Framework.Rectangle(result.X - 8, result.Y - 8, 16 /*0x10*/, 16 /*0x10*/)) || HoneyPatchBiome.TooCloseToImportantLocations(result))
      return false;
    WorldUtils.Gen(result, (GenShape) new Shapes.Circle(8), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.RadialDither(0.0, 10.0), (GenAction) new Modifiers.IsSolid(), (GenAction) new Terraria.WorldBuilding.Actions.SetTile((ushort) 229, true)));
    ShapeData data = new ShapeData();
    WorldUtils.Gen(result, (GenShape) new Shapes.Circle(4, 3), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.Blotches(), (GenAction) new Modifiers.IsSolid(), (GenAction) new Terraria.WorldBuilding.Actions.ClearTile(true), new Modifiers.RectangleMask(-6, 6, 0, 3).Output(data), (GenAction) new Terraria.WorldBuilding.Actions.SetLiquid(2)));
    WorldUtils.Gen(new Point(result.X, result.Y + 1), (GenShape) new ModShapes.InnerOutline(data), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.IsEmpty(), (GenAction) new Modifiers.RectangleMask(-6, 6, 1, 3), (GenAction) new Terraria.WorldBuilding.Actions.SetTile((ushort) 59, true)));
    WorldUtils.Gen(new Point(result.X, result.Y), (GenShape) new ModShapes.All(data), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.Expand(1), (GenAction) new Modifiers.IsBelowHeight(result.Y, true), (GenAction) new Modifiers.IsNotSolid(), (GenAction) new Modifiers.NoLiquid(2), (GenAction) new Terraria.WorldBuilding.Actions.SetTile((ushort) 229, true)));
    structures.AddProtectedStructure(new Microsoft.Xna.Framework.Rectangle(result.X - 8, result.Y - 8, 16 /*0x10*/, 16 /*0x10*/));
    return true;
  }

  private static bool TooCloseToImportantLocations(Point origin)
  {
    int x = origin.X;
    int y = origin.Y;
    if (y >= Main.UnderworldLayer - 30)
      return true;
    int num = 150;
    for (int index1 = x - num; index1 < x + num; index1 += 10)
    {
      if (index1 > 0 && index1 <= Main.maxTilesX - 1)
      {
        for (int index2 = y - num; index2 < y + num; index2 += 10)
        {
          if (index2 > 0 && index2 <= Main.maxTilesY - 1 && (Main.tile[index1, index2].active() && Main.tile[index1, index2].type == (ushort) 226 || Main.tile[index1, index2].wall == (ushort) 83 || Main.tile[index1, index2].wall == (ushort) 3 || Main.tile[index1, index2].wall == (ushort) 87))
            return true;
        }
      }
    }
    return false;
  }
}
