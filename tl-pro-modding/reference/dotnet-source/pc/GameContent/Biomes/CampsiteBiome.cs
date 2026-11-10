// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Biomes.CampsiteBiome
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.Biomes;

public class CampsiteBiome : MicroBiome
{
  public override bool Place(Point origin, StructureMap structures, GenerationProgress progress)
  {
    Ref<int> count1 = new Ref<int>(0);
    Ref<int> count2 = new Ref<int>(0);
    WorldUtils.Gen(origin, (GenShape) new Shapes.Circle(10), Terraria.WorldBuilding.Actions.Chain((GenAction) new Terraria.WorldBuilding.Actions.Scanner(count2), (GenAction) new Modifiers.IsSolid(), (GenAction) new Terraria.WorldBuilding.Actions.Scanner(count1)));
    if (count1.Value < count2.Value - 5)
      return false;
    int radius = GenBase._random.Next(6, 10);
    int num1 = GenBase._random.Next(1, 5);
    if (!structures.CanPlace(new Microsoft.Xna.Framework.Rectangle(origin.X - radius, origin.Y - radius, radius * 2, radius * 2)))
      return false;
    int num2 = radius + 3;
    for (int index1 = origin.X - num2; index1 <= origin.X + num2; ++index1)
    {
      for (int index2 = origin.Y - num2; index2 <= origin.Y + num2; ++index2)
      {
        Tile tile = Main.tile[index1, index2];
        if (tile.active() && (Main.tileDungeon[(int) tile.type] || TileID.Sets.IsAContainer[(int) tile.type] || tile.type == (ushort) 226 || tile.type == (ushort) 237))
          return false;
      }
    }
    ushort type1 = (ushort) (byte) (196 + WorldGen.genRand.Next(4));
    for (int index3 = origin.X - radius; index3 <= origin.X + radius; ++index3)
    {
      for (int index4 = origin.Y - radius; index4 <= origin.Y + radius; ++index4)
      {
        if (Main.tile[index3, index4].active())
        {
          int type2 = (int) Main.tile[index3, index4].type;
          if (type2 == 53 || type2 == 396 || type2 == 397 || type2 == 404)
            type1 = (ushort) 171;
          if (type2 == 161 || type2 == 147)
            type1 = (ushort) 40;
          if (type2 == 60)
            type1 = (ushort) (byte) (204 + WorldGen.genRand.Next(4));
          if (type2 == 367)
            type1 = (ushort) 178;
          if (type2 == 368)
            type1 = (ushort) 180;
        }
      }
    }
    ShapeData data = new ShapeData();
    WorldUtils.Gen(origin, (GenShape) new Shapes.Slime(radius), Terraria.WorldBuilding.Actions.Chain(new Modifiers.Blotches(num1, num1, num1, 1, 1.0).Output(data), (GenAction) new Modifiers.Offset(0, -2), (GenAction) new Modifiers.OnlyTiles(new ushort[1]
    {
      (ushort) 53
    }), (GenAction) new Terraria.WorldBuilding.Actions.SetTile((ushort) 397, true), (GenAction) new Modifiers.OnlyWalls(new ushort[1]), (GenAction) new Terraria.WorldBuilding.Actions.PlaceWall(type1)));
    WorldUtils.Gen(origin, (GenShape) new ModShapes.All(data), Terraria.WorldBuilding.Actions.Chain((GenAction) new Terraria.WorldBuilding.Actions.ClearTile(), (GenAction) new Terraria.WorldBuilding.Actions.SetLiquid(value: (byte) 0), (GenAction) new Terraria.WorldBuilding.Actions.SetFrames(true), (GenAction) new Modifiers.OnlyWalls(new ushort[1]), (GenAction) new Terraria.WorldBuilding.Actions.PlaceWall(type1)));
    Point result;
    if (!WorldUtils.Find(origin, Searches.Chain((GenSearch) new Searches.Down(10), (GenCondition) new Conditions.IsSolid()), out result))
      return false;
    int j = result.Y - 1;
    bool flag = GenBase._random.Next() % 2 == 0;
    if (GenBase._random.Next() % 10 != 0)
    {
      int num3 = GenBase._random.Next(1, 4);
      int num4 = flag ? 4 : -(radius >> 1);
      for (int index5 = 0; index5 < num3; ++index5)
      {
        int num5 = GenBase._random.Next(1, 3);
        for (int index6 = 0; index6 < num5; ++index6)
          WorldGen.PlaceTile(origin.X + num4 - index5, j - index6, 332, true);
      }
    }
    int num6 = (radius - 3) * (flag ? -1 : 1);
    if (GenBase._random.Next() % 10 != 0)
      WorldGen.PlaceTile(origin.X + num6, j, 186);
    if (GenBase._random.Next() % 10 != 0)
    {
      if (WorldGen.SecretSeed.rainbowStuff.Enabled)
        WorldGen.PlaceTile(origin.X, j, 215, true, style: 5);
      else
        WorldGen.PlaceTile(origin.X, j, 215, true);
      if (GenBase._tiles[origin.X, j].active() && GenBase._tiles[origin.X, j].type == (ushort) 215)
      {
        GenBase._tiles[origin.X, j].frameY += (short) 36;
        GenBase._tiles[origin.X - 1, j].frameY += (short) 36;
        GenBase._tiles[origin.X + 1, j].frameY += (short) 36;
        GenBase._tiles[origin.X, j - 1].frameY += (short) 36;
        GenBase._tiles[origin.X - 1, j - 1].frameY += (short) 36;
        GenBase._tiles[origin.X + 1, j - 1].frameY += (short) 36;
      }
    }
    structures.AddProtectedStructure(new Microsoft.Xna.Framework.Rectangle(origin.X - radius, origin.Y - radius, radius * 2, radius * 2), 4);
    return true;
  }
}
