// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Biomes.CaveHouse.WoodHouseBuilder
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.Biomes.CaveHouse;

public class WoodHouseBuilder : HouseBuilder
{
  public WoodHouseBuilder(IEnumerable<Microsoft.Xna.Framework.Rectangle> rooms)
    : base(HouseType.Wood, rooms)
  {
    this.TileType = (ushort) 30;
    this.WallType = (ushort) 27;
    this.BeamType = (ushort) 124;
    this.PlatformStyle = 0;
    this.DoorStyle = 0;
    this.TableStyle = 0;
    this.WorkbenchStyle = 0;
    this.PianoStyle = 0;
    this.BookcaseStyle = 0;
    this.ChairStyle = 0;
    this.ChestStyle = 1;
    this.PotentiallyConvertToSeedHouse();
    this.PotentiallyConvertToRainbowBrick();
    this.PotentiallyConvertToRainbowMossBlock();
  }

  protected override void AgeRoom(Microsoft.Xna.Framework.Rectangle room)
  {
    for (int index = 0; index < room.Width * room.Height / 16 /*0x10*/; ++index)
      WorldUtils.Gen(new Point(WorldGen.genRand.Next(1, room.Width - 1) + room.X, WorldGen.genRand.Next(1, room.Height - 1) + room.Y), (GenShape) new Shapes.Rectangle(2, 2), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.Dither(), (GenAction) new Modifiers.Blotches(2, 2), (GenAction) new Modifiers.IsEmpty(), (GenAction) new Terraria.WorldBuilding.Actions.SetTile((ushort) 51, true)));
    WorldUtils.Gen(new Point(room.X, room.Y), (GenShape) new Shapes.Rectangle(room.Width, room.Height), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.Dither(0.85), (GenAction) new Modifiers.Blotches(), (GenAction) new Modifiers.OnlyWalls(new ushort[1]
    {
      this.WallType
    }), (GenAction) new Modifiers.SkipTiles(this.SkipTilesDuringWallAging), (double) room.Y > Main.worldSurface ? (GenAction) new Terraria.WorldBuilding.Actions.ClearWall(true) : (GenAction) new Terraria.WorldBuilding.Actions.PlaceWall((ushort) 2)));
    WorldUtils.Gen(new Point(room.X, room.Y), (GenShape) new Shapes.Rectangle(room.Width, room.Height), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.Dither(0.95), (GenAction) new Modifiers.OnlyTiles(new ushort[3]
    {
      (ushort) 30,
      (ushort) 321,
      (ushort) 158
    }), (GenAction) new Terraria.WorldBuilding.Actions.ClearTile(true)));
  }

  public override void Place(HouseBuilderContext context, StructureMap structures)
  {
    base.Place(context, structures);
    this.RainbowifyOnTenthAnniversaryWorlds();
  }
}
