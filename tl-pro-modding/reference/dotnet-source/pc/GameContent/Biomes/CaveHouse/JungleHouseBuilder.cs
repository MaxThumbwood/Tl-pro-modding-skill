// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Biomes.CaveHouse.JungleHouseBuilder
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria.GameContent.Generation;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.Biomes.CaveHouse;

public class JungleHouseBuilder : HouseBuilder
{
  public JungleHouseBuilder(IEnumerable<Microsoft.Xna.Framework.Rectangle> rooms)
    : base(HouseType.Jungle, rooms)
  {
    this.TileType = (ushort) 158;
    this.WallType = (ushort) 42;
    this.BeamType = (ushort) 575;
    this.PlatformStyle = 2;
    this.DoorStyle = 2;
    this.TableStyle = 2;
    this.WorkbenchStyle = 2;
    this.PianoStyle = 2;
    this.BookcaseStyle = 12;
    this.ChairStyle = 3;
    this.ChestStyle = 8;
    this.PotentiallyConvertToSeedHouse();
  }

  protected override void AgeRoom(Microsoft.Xna.Framework.Rectangle room)
  {
    WorldUtils.Gen(new Point(room.X, room.Y), (GenShape) new Shapes.Rectangle(room.Width, room.Height), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.Dither(0.6), (GenAction) new Modifiers.Blotches(chance: 0.6), (GenAction) new Modifiers.OnlyTiles(new ushort[1]
    {
      this.TileType
    }), (GenAction) new Terraria.WorldBuilding.Actions.SetTileKeepWall((ushort) 60, true), (GenAction) new Modifiers.Dither(0.8), (GenAction) new Terraria.WorldBuilding.Actions.SetTileKeepWall((ushort) 59, true)));
    WorldUtils.Gen(new Point(room.X + 1, room.Y), (GenShape) new Shapes.Rectangle(room.Width - 2, 1), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.Dither(), (GenAction) new Modifiers.OnlyTiles(new ushort[1]
    {
      (ushort) 60
    }), (GenAction) new Modifiers.Offset(0, 1), (GenAction) new Modifiers.IsEmpty(), (GenAction) new ActionVines(3, room.Height, 62)));
    WorldUtils.Gen(new Point(room.X + 1, room.Y + room.Height - 1), (GenShape) new Shapes.Rectangle(room.Width - 2, 1), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.Dither(), (GenAction) new Modifiers.OnlyTiles(new ushort[1]
    {
      (ushort) 60
    }), (GenAction) new Modifiers.Offset(0, 1), (GenAction) new Modifiers.IsEmpty(), (GenAction) new ActionVines(3, room.Height, 62)));
    WorldUtils.Gen(new Point(room.X, room.Y), (GenShape) new Shapes.Rectangle(room.Width, room.Height), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.Dither(0.85), (GenAction) new Modifiers.Blotches(), (GenAction) new Terraria.WorldBuilding.Actions.PlaceWall((ushort) 64 /*0x40*/)));
  }
}
