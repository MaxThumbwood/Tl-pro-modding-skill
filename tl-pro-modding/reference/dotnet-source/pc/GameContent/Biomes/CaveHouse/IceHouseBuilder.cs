// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Biomes.CaveHouse.IceHouseBuilder
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria.GameContent.Generation;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.Biomes.CaveHouse;

public class IceHouseBuilder : HouseBuilder
{
  public IceHouseBuilder(IEnumerable<Microsoft.Xna.Framework.Rectangle> rooms)
    : base(HouseType.Ice, rooms)
  {
    this.TileType = (ushort) 321;
    this.WallType = (ushort) 149;
    this.BeamType = (ushort) 574;
    this.DoorStyle = 30;
    this.PlatformStyle = 19;
    this.TableStyle = 28;
    this.WorkbenchStyle = 23;
    this.PianoStyle = 23;
    this.BookcaseStyle = 25;
    this.ChairStyle = 30;
    this.ChestStyle = 11;
    this.PotentiallyConvertToSeedHouse();
  }

  protected override void AgeRoom(Microsoft.Xna.Framework.Rectangle room)
  {
    WorldUtils.Gen(new Point(room.X, room.Y), (GenShape) new Shapes.Rectangle(room.Width, room.Height), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.Dither(0.6), (GenAction) new Modifiers.Blotches(chance: 0.6), (GenAction) new Modifiers.OnlyTiles(new ushort[1]
    {
      this.TileType
    }), (GenAction) new Terraria.WorldBuilding.Actions.SetTileKeepWall((ushort) 161, true), (GenAction) new Modifiers.Dither(0.8), (GenAction) new Terraria.WorldBuilding.Actions.SetTileKeepWall((ushort) 147, true)));
    WorldUtils.Gen(new Point(room.X + 1, room.Y), (GenShape) new Shapes.Rectangle(room.Width - 2, 1), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.Dither(), (GenAction) new Modifiers.OnlyTiles(new ushort[1]
    {
      (ushort) 161
    }), (GenAction) new Modifiers.Offset(0, 1), (GenAction) new ActionStalagtite()));
    WorldUtils.Gen(new Point(room.X + 1, room.Y + room.Height - 1), (GenShape) new Shapes.Rectangle(room.Width - 2, 1), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.Dither(), (GenAction) new Modifiers.OnlyTiles(new ushort[1]
    {
      (ushort) 161
    }), (GenAction) new Modifiers.Offset(0, 1), (GenAction) new ActionStalagtite()));
    WorldUtils.Gen(new Point(room.X, room.Y), (GenShape) new Shapes.Rectangle(room.Width, room.Height), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.Dither(0.85), (GenAction) new Modifiers.Blotches(chance: 0.8), (GenAction) new Modifiers.SkipTiles(this.SkipTilesDuringWallAging), (double) room.Y > Main.worldSurface ? (GenAction) new Terraria.WorldBuilding.Actions.ClearWall(true) : (GenAction) new Terraria.WorldBuilding.Actions.PlaceWall((ushort) 40)));
  }
}
