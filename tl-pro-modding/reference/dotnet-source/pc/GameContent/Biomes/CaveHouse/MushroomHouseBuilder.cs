// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Biomes.CaveHouse.MushroomHouseBuilder
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.Biomes.CaveHouse;

public class MushroomHouseBuilder : HouseBuilder
{
  public MushroomHouseBuilder(IEnumerable<Microsoft.Xna.Framework.Rectangle> rooms)
    : base(HouseType.Mushroom, rooms)
  {
    this.TileType = (ushort) 190;
    this.WallType = (ushort) 74;
    this.BeamType = (ushort) 578;
    this.PlatformStyle = 18;
    this.DoorStyle = 6;
    this.TableStyle = 27;
    this.WorkbenchStyle = 7;
    this.PianoStyle = 22;
    this.BookcaseStyle = 24;
    this.ChairStyle = 9;
    this.ChestStyle = 32 /*0x20*/;
  }

  protected override void AgeRoom(Microsoft.Xna.Framework.Rectangle room)
  {
    WorldUtils.Gen(new Point(room.X, room.Y), (GenShape) new Shapes.Rectangle(room.Width, room.Height), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.Dither(0.7), (GenAction) new Modifiers.Blotches(chance: 0.5), (GenAction) new Modifiers.OnlyTiles(new ushort[1]
    {
      this.TileType
    }), (GenAction) new Terraria.WorldBuilding.Actions.SetTileKeepWall((ushort) 70, true)));
    WorldUtils.Gen(new Point(room.X + 1, room.Y), (GenShape) new Shapes.Rectangle(room.Width - 2, 1), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.Dither(0.6), (GenAction) new Modifiers.OnlyTiles(new ushort[1]
    {
      (ushort) 70
    }), (GenAction) new Modifiers.Offset(0, -1), (GenAction) new Modifiers.IsEmpty(), (GenAction) new Terraria.WorldBuilding.Actions.SetTile((ushort) 71)));
    WorldUtils.Gen(new Point(room.X + 1, room.Y + room.Height - 1), (GenShape) new Shapes.Rectangle(room.Width - 2, 1), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.Dither(0.6), (GenAction) new Modifiers.OnlyTiles(new ushort[1]
    {
      (ushort) 70
    }), (GenAction) new Modifiers.Offset(0, -1), (GenAction) new Modifiers.IsEmpty(), (GenAction) new Terraria.WorldBuilding.Actions.SetTile((ushort) 71)));
    WorldUtils.Gen(new Point(room.X, room.Y), (GenShape) new Shapes.Rectangle(room.Width, room.Height), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.Dither(0.85), (GenAction) new Modifiers.Blotches(), (GenAction) new Terraria.WorldBuilding.Actions.ClearWall()));
  }
}
