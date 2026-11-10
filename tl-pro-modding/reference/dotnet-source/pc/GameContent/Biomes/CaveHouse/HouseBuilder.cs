// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Biomes.CaveHouse.HouseBuilder
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Terraria.GameContent.Generation;
using Terraria.Utilities;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.Biomes.CaveHouse;

public class HouseBuilder
{
  private const int VERTICAL_EXIT_WIDTH = 3;
  public static readonly HouseBuilder Invalid = new HouseBuilder();
  public readonly HouseType Type;
  public readonly bool IsValid;
  protected ushort[] SkipTilesDuringWallAging = new ushort[5]
  {
    (ushort) 245,
    (ushort) 246,
    (ushort) 240 /*0xF0*/,
    (ushort) 241,
    (ushort) 242
  };

  public double ChestChance { get; set; }

  public ushort TileType { get; protected set; }

  public ushort WallType { get; protected set; }

  public ushort BeamType { get; protected set; }

  public byte BeamPaint { get; protected set; }

  public int PlatformStyle { get; protected set; }

  public int DoorStyle { get; protected set; }

  public int TableStyle { get; protected set; }

  public bool UsesTables2 { get; protected set; }

  public int WorkbenchStyle { get; protected set; }

  public int PianoStyle { get; protected set; }

  public int BookcaseStyle { get; protected set; }

  public int ChairStyle { get; protected set; }

  public int ChestStyle { get; protected set; }

  public bool UsesContainers2 { get; protected set; }

  public ReadOnlyCollection<Microsoft.Xna.Framework.Rectangle> Rooms { get; private set; }

  public Microsoft.Xna.Framework.Rectangle TopRoom => this.Rooms.First<Microsoft.Xna.Framework.Rectangle>();

  public Microsoft.Xna.Framework.Rectangle BottomRoom => this.Rooms.Last<Microsoft.Xna.Framework.Rectangle>();

  private UnifiedRandom _random => WorldGen.genRand;

  private Tile[,] _tiles => Main.tile;

  private HouseBuilder() => this.IsValid = false;

  protected HouseBuilder(HouseType type, IEnumerable<Microsoft.Xna.Framework.Rectangle> rooms)
  {
    this.Type = type;
    this.IsValid = true;
    List<Microsoft.Xna.Framework.Rectangle> list = rooms.ToList<Microsoft.Xna.Framework.Rectangle>();
    list.Sort((Comparison<Microsoft.Xna.Framework.Rectangle>) ((lhs, rhs) => lhs.Top.CompareTo(rhs.Top)));
    this.Rooms = list.AsReadOnly();
  }

  protected virtual void AgeRoom(Microsoft.Xna.Framework.Rectangle room)
  {
  }

  public void PotentiallyConvertToRainbowMossBlock()
  {
    if (!WorldGen.SecretSeed.rainbowStuff.Enabled || WorldGen.genRand.Next(2) != 0)
      return;
    this.TileType = (ushort) 692;
    this.WallType = (ushort) 346;
    this.PlatformStyle = 43;
    this.DoorStyle = 44;
  }

  public void PotentiallyConvertToRainbowBrick()
  {
    if (!Main.tenthAnniversaryWorld)
      return;
    if (Main.getGoodWorld)
    {
      if (WorldGen.genRand.Next(7) != 0)
        return;
      this.TileType = (ushort) 160 /*0xA0*/;
      this.WallType = (ushort) 44;
    }
    else
    {
      if (WorldGen.genRand.Next(2) != 0)
        return;
      this.TileType = (ushort) 160 /*0xA0*/;
      this.WallType = (ushort) 44;
    }
  }

  public void RainbowifyOnTenthAnniversaryWorlds()
  {
    if (!Main.tenthAnniversaryWorld || this.TileType == (ushort) 160 /*0xA0*/ && WorldGen.genRand.Next(2) == 0)
      return;
    foreach (Microsoft.Xna.Framework.Rectangle room in this.Rooms)
      WorldUtils.Gen(new Point(room.X, room.Y), (GenShape) new Shapes.Rectangle(room.Width, room.Height), (GenAction) new Terraria.WorldBuilding.Actions.SetTileAndWallRainbowPaint());
  }

  public void PotentiallyConvertToSeedHouse()
  {
    if (WorldGen.SecretSeed.errorWorld.Enabled)
    {
      this.PlatformStyle = WorldGen.genRand.Next(49);
      this.DoorStyle = WorldGen.genRand.Next(49);
      this.TableStyle = WorldGen.genRand.Next(35);
      this.WorkbenchStyle = WorldGen.genRand.Next(44);
      this.PianoStyle = WorldGen.genRand.Next(39);
      this.BookcaseStyle = WorldGen.genRand.Next(40);
      this.ChairStyle = WorldGen.genRand.Next(44);
      switch (WorldGen.genRand.Next(20))
      {
        case 1:
          this.TileType = (ushort) 422;
          this.WallType = (ushort) 225;
          break;
        case 2:
          this.TileType = (ushort) 194;
          this.WallType = (ushort) 75;
          break;
        case 3:
          this.TileType = (ushort) 541;
          this.WallType = (ushort) 318;
          this.PlatformStyle = 48 /*0x30*/;
          break;
        case 4:
          this.TileType = (ushort) 137;
          this.WallType = (ushort) 147;
          break;
        case 5:
          this.TileType = (ushort) 48 /*0x30*/;
          this.WallType = (ushort) 245;
          break;
        case 6:
          this.TileType = (ushort) 370;
          this.WallType = (ushort) 182;
          break;
        case 7:
          this.TileType = (ushort) 140;
          this.WallType = (ushort) 33;
          break;
        case 8:
          this.TileType = (ushort) 347;
          this.WallType = (ushort) 174;
          break;
        case 9:
          this.TileType = (ushort) 508;
          this.WallType = (ushort) 243;
          break;
        case 10:
          this.TileType = (ushort) 507;
          this.WallType = (ushort) 242;
          break;
        case 11:
          this.TileType = (ushort) 546;
          this.WallType = (ushort) 167;
          break;
        case 12:
          this.TileType = (ushort) 329;
          this.WallType = (ushort) 169;
          break;
        case 13:
          this.TileType = (ushort) 326;
          this.WallType = (ushort) 136;
          break;
        case 14:
          this.TileType = (ushort) 327;
          this.WallType = (ushort) 137;
          break;
        case 15:
          this.TileType = (ushort) 345;
          this.WallType = (ushort) 172;
          break;
        case 16 /*0x10*/:
          this.TileType = (ushort) 708;
          this.WallType = (ushort) 347;
          break;
        case 17:
          this.TileType = (ushort) 501;
          this.WallType = (ushort) 238;
          break;
        case 18:
          this.TileType = (ushort) 272;
          this.WallType = (ushort) 225;
          break;
        case 19:
          this.TileType = (ushort) 421;
          this.WallType = (ushort) 225;
          break;
        default:
          this.TileType = (ushort) 159;
          this.WallType = (ushort) 43;
          break;
      }
    }
    else
    {
      if ((double) WorldGen.genRand.NextFloat() > 0.40000000596046448)
        return;
      int num1 = this.Type == HouseType.Wood ? 1 : 0;
      bool flag1 = this.Type == HouseType.Desert;
      int num2 = this.Type == HouseType.Jungle ? 1 : 0;
      bool flag2 = this.Type == HouseType.Ice;
      List<ushort> ushortList = new List<ushort>();
      if (num2 != 0 && Main.notTheBeesWorld && Main.tenthAnniversaryWorld)
      {
        ushortList.Add((ushort) 562);
        ushortList.Add((ushort) 563);
        ushortList.Add((ushort) 229);
      }
      int num3 = flag2 ? 1 : 0;
      if ((num1 | num3) != 0 && Main.drunkWorld && Main.tenthAnniversaryWorld)
      {
        if (flag2)
          ushortList.Add((ushort) 197);
        else
          ushortList.Add((ushort) 193);
      }
      if (flag2 && WorldGen.SecretSeed.worldIsFrozen.Enabled && WorldGen.genRand.Next(3) == 0)
      {
        ushortList.Add((ushort) 145);
        ushortList.Add((ushort) 146);
      }
      if (flag1 && Main.remixWorld && Main.getGoodWorld)
        ushortList.Add((ushort) 188);
      if (ushortList.Count <= 0)
        return;
      ushort num4 = ushortList[WorldGen.genRand.Next(ushortList.Count)];
      switch (num4)
      {
        case 145:
          this.TileType = num4;
          this.WallType = (ushort) 29;
          this.BeamType = (ushort) 574;
          this.BeamPaint = (byte) 26;
          break;
        case 146:
          this.TileType = num4;
          this.WallType = (ushort) 30;
          this.BeamType = (ushort) 574;
          this.BeamPaint = (byte) 26;
          break;
        case 188:
          this.TileType = num4;
          this.WallType = (ushort) 72;
          this.BeamType = (ushort) 124;
          this.BeamPaint = (byte) 17;
          this.PlatformStyle = 25;
          this.DoorStyle = 4;
          this.TableStyle = 30;
          this.UsesTables2 = false;
          this.WorkbenchStyle = 5;
          this.PianoStyle = 17;
          this.BookcaseStyle = 6;
          this.ChairStyle = 6;
          this.ChestStyle = 42;
          this.UsesContainers2 = false;
          break;
        case 193:
          this.TileType = num4;
          this.WallType = (ushort) 76;
          this.BeamType = (ushort) 124;
          this.BeamPaint = (byte) 19;
          this.PlatformStyle = 20;
          this.DoorStyle = 31 /*0x1F*/;
          this.TableStyle = 29;
          this.UsesTables2 = false;
          this.WorkbenchStyle = 8;
          this.PianoStyle = 24;
          this.BookcaseStyle = 26;
          this.ChairStyle = 31 /*0x1F*/;
          this.ChestStyle = 34;
          this.UsesContainers2 = false;
          break;
        case 197:
          this.TileType = num4;
          this.WallType = (ushort) 76;
          this.BeamType = (ushort) 574;
          this.BeamPaint = (byte) 26;
          this.PlatformStyle = 20;
          this.DoorStyle = 31 /*0x1F*/;
          this.TableStyle = 29;
          this.UsesTables2 = false;
          this.WorkbenchStyle = 8;
          this.PianoStyle = 24;
          this.BookcaseStyle = 26;
          this.ChairStyle = 31 /*0x1F*/;
          this.ChestStyle = 34;
          this.UsesContainers2 = false;
          break;
        case 229:
          this.TileType = num4;
          this.WallType = (ushort) 86;
          this.BeamType = (ushort) 575;
          this.BeamPaint = (byte) 15;
          this.PlatformStyle = 24;
          this.DoorStyle = 22;
          this.TableStyle = 19;
          this.UsesTables2 = false;
          this.WorkbenchStyle = 19;
          this.PianoStyle = 9;
          this.BookcaseStyle = 9;
          this.ChairStyle = 22;
          this.ChestStyle = 29;
          this.UsesContainers2 = false;
          break;
        case 562:
          this.TileType = num4;
          this.WallType = (ushort) 312;
          this.BeamType = (ushort) 575;
          this.BeamPaint = (byte) 16 /*0x10*/;
          this.PlatformStyle = 44;
          this.DoorStyle = 45;
          this.TableStyle = 8;
          this.UsesTables2 = true;
          this.WorkbenchStyle = 40;
          this.PianoStyle = 39;
          this.BookcaseStyle = 40;
          this.ChairStyle = 44;
          this.ChestStyle = 11;
          this.UsesContainers2 = true;
          break;
        case 563:
          this.TileType = num4;
          this.WallType = (ushort) 313;
          this.BeamType = (ushort) 575;
          this.BeamPaint = (byte) 16 /*0x10*/;
          this.PlatformStyle = 44;
          this.DoorStyle = 45;
          this.TableStyle = 8;
          this.UsesTables2 = true;
          this.WorkbenchStyle = 40;
          this.PianoStyle = 39;
          this.BookcaseStyle = 40;
          this.ChairStyle = 44;
          this.ChestStyle = 11;
          this.UsesContainers2 = true;
          break;
      }
    }
  }

  public void PaintSeedHouses()
  {
    if (this.TileType != (ushort) 197 || !Main.drunkWorld || !Main.tenthAnniversaryWorld)
      return;
    foreach (Microsoft.Xna.Framework.Rectangle room in this.Rooms)
    {
      WorldUtils.Gen(new Point(room.X, room.Y), (GenShape) new Shapes.Rectangle(room.Width, room.Height), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.OnlyTiles(new ushort[9]
      {
        (ushort) 19,
        (ushort) 10,
        (ushort) 11,
        (ushort) 14,
        (ushort) 18,
        (ushort) 87,
        (ushort) 101,
        (ushort) 15,
        (ushort) 21
      }), (GenAction) new Terraria.WorldBuilding.Actions.SetTilePaint((byte) 7)));
      WorldUtils.Gen(new Point(room.X, room.Y), (GenShape) new Shapes.Rectangle(room.Width, room.Height), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.OnlyWalls(new ushort[1]
      {
        this.WallType
      }), (GenAction) new Terraria.WorldBuilding.Actions.SetWallPaint((byte) 7)));
    }
  }

  public virtual void Place(HouseBuilderContext context, StructureMap structures)
  {
    this.PlaceEmptyRooms();
    foreach (Microsoft.Xna.Framework.Rectangle room in this.Rooms)
      structures.AddProtectedStructure(room, 8);
    this.PlaceStairs();
    this.PlaceDoors();
    this.PlacePlatforms();
    this.PlaceSupportBeams();
    this.PlaceBiomeSpecificPriorityTool(context);
    this.FillRooms();
    foreach (Microsoft.Xna.Framework.Rectangle room in this.Rooms)
      this.AgeRoom(room);
    this.PlaceChests();
    this.PlaceBiomeSpecificTool(context);
    this.PaintSeedHouses();
  }

  private void PlaceEmptyRooms()
  {
    foreach (Microsoft.Xna.Framework.Rectangle room in this.Rooms)
    {
      WorldUtils.Gen(new Point(room.X, room.Y), (GenShape) new Shapes.Rectangle(room.Width, room.Height), Terraria.WorldBuilding.Actions.Chain((GenAction) new Terraria.WorldBuilding.Actions.SetTileKeepWall(this.TileType), (GenAction) new Terraria.WorldBuilding.Actions.SetFrames(true)));
      WorldUtils.Gen(new Point(room.X + 1, room.Y + 1), (GenShape) new Shapes.Rectangle(room.Width - 2, room.Height - 2), Terraria.WorldBuilding.Actions.Chain((GenAction) new Terraria.WorldBuilding.Actions.ClearTile(true), (GenAction) new Terraria.WorldBuilding.Actions.PlaceWall(this.WallType)));
    }
  }

  private void FillRooms()
  {
    int x = 14;
    if (this.UsesTables2)
      x = 469;
    Point[] pointArray = new Point[7]
    {
      new Point(x, this.TableStyle),
      new Point(16 /*0x10*/, 0),
      new Point(18, this.WorkbenchStyle),
      new Point(86, 0),
      new Point(87, this.PianoStyle),
      new Point(94, 0),
      new Point(101, this.BookcaseStyle)
    };
    foreach (Microsoft.Xna.Framework.Rectangle room in this.Rooms)
    {
      int num1 = room.Width / 8;
      int num2 = room.Width / (num1 + 1);
      int num3 = this._random.Next(2);
      for (int index1 = 0; index1 < num1; ++index1)
      {
        int i = (index1 + 1) * num2 + room.X;
        switch (index1 + num3 % 2)
        {
          case 0:
            int j1 = room.Y + Math.Min(room.Height / 2, room.Height - 5);
            PaintingEntry paintingEntry = this.Type == HouseType.Desert ? WorldGen.RandHousePictureDesert() : WorldGen.RandHousePicture();
            WorldGen.PlaceTile(i, j1, paintingEntry.tileType, true, style: paintingEntry.style);
            break;
          case 1:
            int j2 = room.Y + 1;
            WorldGen.PlaceTile(i, j2, 34, true, style: this._random.Next(6));
            for (int index2 = -1; index2 < 2; ++index2)
            {
              for (int index3 = 0; index3 < 3; ++index3)
                this._tiles[index2 + i, index3 + j2].frameX += (short) 54;
            }
            break;
        }
      }
      int num4 = room.Width / 8 + 3;
      WorldGen.SetupStatueList();
      for (; num4 > 0; --num4)
      {
        int num5 = this._random.Next(room.Width - 3) + 1 + room.X;
        int num6 = room.Y + room.Height - 2;
        switch (this._random.Next(4))
        {
          case 0:
            WorldGen.PlaceSmallPile(num5, num6, this._random.Next(31 /*0x1F*/, 34), 1);
            break;
          case 1:
            WorldGen.PlaceTile(num5, num6, 186, true, style: this._random.Next(22, 26));
            break;
          case 2:
            int index = this._random.Next(2, GenVars.statueList.Length);
            WorldGen.PlaceTile(num5, num6, (int) GenVars.statueList[index].X, true, style: (int) GenVars.statueList[index].Y);
            if (GenVars.StatuesWithTraps.Contains(index))
            {
              WorldGen.PlaceStatueTrap(num5, num6);
              break;
            }
            break;
          case 3:
            Point point = Utils.SelectRandom<Point>(this._random, pointArray);
            WorldGen.PlaceTile(num5, num6, point.X, true, style: point.Y);
            break;
        }
      }
    }
  }

  private void PlaceStairs()
  {
    foreach (Tuple<Point, Point> stairs in this.CreateStairsList())
    {
      Point origin = stairs.Item1;
      Point point = stairs.Item2;
      int num = point.X > origin.X ? 1 : -1;
      ShapeData data = new ShapeData();
      for (int y = 0; y < point.Y - origin.Y; ++y)
        data.Add(num * (y + 1), y);
      WorldUtils.Gen(origin, (GenShape) new ModShapes.All(data), Terraria.WorldBuilding.Actions.Chain((GenAction) new Terraria.WorldBuilding.Actions.PlaceTile((ushort) 19, this.PlatformStyle), (GenAction) new Terraria.WorldBuilding.Actions.SetSlope(num == 1 ? 1 : 2), (GenAction) new Terraria.WorldBuilding.Actions.SetFrames(true)));
      WorldUtils.Gen(new Point(origin.X + (num == 1 ? 1 : -4), origin.Y - 1), (GenShape) new Shapes.Rectangle(4, 1), Terraria.WorldBuilding.Actions.Chain((GenAction) new Terraria.WorldBuilding.Actions.Clear(), (GenAction) new Terraria.WorldBuilding.Actions.PlaceWall(this.WallType), (GenAction) new Terraria.WorldBuilding.Actions.PlaceTile((ushort) 19, this.PlatformStyle), (GenAction) new Terraria.WorldBuilding.Actions.SetFrames(true)));
    }
  }

  private List<Tuple<Point, Point>> CreateStairsList()
  {
    List<Tuple<Point, Point>> stairsList = new List<Tuple<Point, Point>>();
    for (int index = 1; index < this.Rooms.Count; ++index)
    {
      Microsoft.Xna.Framework.Rectangle room1 = this.Rooms[index];
      Microsoft.Xna.Framework.Rectangle room2 = this.Rooms[index - 1];
      if (room2.X - room1.X > room1.X + room1.Width - (room2.X + room2.Width))
        stairsList.Add(new Tuple<Point, Point>(new Point(room1.X + room1.Width - 1, room1.Y + 1), new Point(room1.X + room1.Width - room1.Height + 1, room1.Y + room1.Height - 1)));
      else
        stairsList.Add(new Tuple<Point, Point>(new Point(room1.X, room1.Y + 1), new Point(room1.X + room1.Height - 1, room1.Y + room1.Height - 1)));
    }
    return stairsList;
  }

  private void PlaceDoors()
  {
    foreach (Point door in this.CreateDoorList())
    {
      WorldUtils.Gen(door, (GenShape) new Shapes.Rectangle(1, 3), (GenAction) new Terraria.WorldBuilding.Actions.ClearTile(true));
      WorldGen.PlaceTile(door.X, door.Y, 10, true, true, style: this.DoorStyle);
    }
  }

  private List<Point> CreateDoorList()
  {
    List<Point> doorList = new List<Point>();
    foreach (Microsoft.Xna.Framework.Rectangle room in this.Rooms)
    {
      int exitY;
      if (HouseBuilder.FindSideExit(new Microsoft.Xna.Framework.Rectangle(room.X + room.Width, room.Y + 1, 1, room.Height - 2), false, out exitY))
        doorList.Add(new Point(room.X + room.Width - 1, exitY));
      if (HouseBuilder.FindSideExit(new Microsoft.Xna.Framework.Rectangle(room.X, room.Y + 1, 1, room.Height - 2), true, out exitY))
        doorList.Add(new Point(room.X, exitY));
    }
    return doorList;
  }

  private void PlacePlatforms()
  {
    foreach (Point platforms in this.CreatePlatformsList())
      WorldUtils.Gen(platforms, (GenShape) new Shapes.Rectangle(3, 1), Terraria.WorldBuilding.Actions.Chain((GenAction) new Terraria.WorldBuilding.Actions.ClearMetadata(), (GenAction) new Terraria.WorldBuilding.Actions.PlaceTile((ushort) 19, this.PlatformStyle), (GenAction) new Terraria.WorldBuilding.Actions.SetFrames(true)));
  }

  private List<Point> CreatePlatformsList()
  {
    List<Point> platformsList = new List<Point>();
    Microsoft.Xna.Framework.Rectangle topRoom = this.TopRoom;
    Microsoft.Xna.Framework.Rectangle bottomRoom = this.BottomRoom;
    int exitX;
    if (HouseBuilder.FindVerticalExit(new Microsoft.Xna.Framework.Rectangle(topRoom.X + 2, topRoom.Y, topRoom.Width - 4, 1), true, out exitX))
      platformsList.Add(new Point(exitX, topRoom.Y));
    if (HouseBuilder.FindVerticalExit(new Microsoft.Xna.Framework.Rectangle(bottomRoom.X + 2, bottomRoom.Y + bottomRoom.Height - 1, bottomRoom.Width - 4, 1), false, out exitX))
      platformsList.Add(new Point(exitX, bottomRoom.Y + bottomRoom.Height - 1));
    return platformsList;
  }

  private void PlaceSupportBeams()
  {
    foreach (Microsoft.Xna.Framework.Rectangle supportBeam in this.CreateSupportBeamList())
    {
      if (supportBeam.Height > 1 && this._tiles[supportBeam.X, supportBeam.Y - 1].type != (ushort) 19)
      {
        WorldUtils.Gen(new Point(supportBeam.X, supportBeam.Y), (GenShape) new Shapes.Rectangle(supportBeam.Width, supportBeam.Height), Terraria.WorldBuilding.Actions.Chain((GenAction) new Terraria.WorldBuilding.Actions.SetTileKeepWall(this.BeamType), (GenAction) new Terraria.WorldBuilding.Actions.SetFrames(true), (GenAction) new Terraria.WorldBuilding.Actions.SetTilePaint(this.BeamPaint)));
        Tile tile = this._tiles[supportBeam.X, supportBeam.Y + supportBeam.Height];
        tile.slope((byte) 0);
        tile.halfBrick(false);
      }
    }
  }

  private List<Microsoft.Xna.Framework.Rectangle> CreateSupportBeamList()
  {
    List<Microsoft.Xna.Framework.Rectangle> supportBeamList = new List<Microsoft.Xna.Framework.Rectangle>();
    int num1 = this.Rooms.Min<Microsoft.Xna.Framework.Rectangle>((Func<Microsoft.Xna.Framework.Rectangle, int>) (room => room.Left));
    int num2 = this.Rooms.Max<Microsoft.Xna.Framework.Rectangle>((Func<Microsoft.Xna.Framework.Rectangle, int>) (room => room.Right)) - 1;
    int num3 = 6;
    while (num3 > 4 && (num2 - num1) % num3 != 0)
      --num3;
    for (int x = num1; x <= num2; x += num3)
    {
      for (int index1 = 0; index1 < this.Rooms.Count; ++index1)
      {
        Microsoft.Xna.Framework.Rectangle room = this.Rooms[index1];
        if (x >= room.X && x < room.X + room.Width)
        {
          int y = room.Y + room.Height;
          int num4 = 50;
          for (int index2 = index1 + 1; index2 < this.Rooms.Count; ++index2)
          {
            if (x >= this.Rooms[index2].X && x < this.Rooms[index2].X + this.Rooms[index2].Width)
              num4 = Math.Min(num4, this.Rooms[index2].Y - y);
          }
          if (num4 > 0)
          {
            Point result;
            bool flag = WorldUtils.Find(new Point(x, y), Searches.Chain((GenSearch) new Searches.Down(num4), (GenCondition) new Conditions.IsSolid()), out result);
            if (num4 < 50 && !WorldGen.SecretSeed.GenerateBiggerAbandonedHouses)
            {
              flag = true;
              result = new Point(x, y + num4);
            }
            if (flag)
              supportBeamList.Add(new Microsoft.Xna.Framework.Rectangle(x, y, 1, result.Y - y));
          }
        }
      }
    }
    return supportBeamList;
  }

  private static bool FindVerticalExit(Microsoft.Xna.Framework.Rectangle wall, bool isUp, out int exitX)
  {
    Point result;
    int num = WorldUtils.Find(new Point(wall.X + wall.Width - 3, wall.Y + (isUp ? -5 : 0)), Searches.Chain((GenSearch) new Searches.Left(wall.Width - 3), new Conditions.IsSolid().Not().AreaOr(3, 5)), out result) ? 1 : 0;
    exitX = result.X;
    return num != 0;
  }

  private static bool FindSideExit(Microsoft.Xna.Framework.Rectangle wall, bool isLeft, out int exitY)
  {
    Point result;
    int num = WorldUtils.Find(new Point(wall.X + (isLeft ? -4 : 0), wall.Y + wall.Height - 3), Searches.Chain((GenSearch) new Searches.Up(wall.Height - 3), new Conditions.IsSolid().Not().AreaOr(4, 3)), out result) ? 1 : 0;
    exitY = result.Y;
    return num != 0;
  }

  private void PlaceChests()
  {
    if (this._random.NextDouble() > this.ChestChance)
      return;
    bool flag = false;
    foreach (Microsoft.Xna.Framework.Rectangle room in this.Rooms)
    {
      int j = room.Height - 1 + room.Y;
      int num1 = j > (int) Main.worldSurface ? 1 : 0;
      ushort chestTileType = num1 == 0 || !this.UsesContainers2 ? (ushort) 21 : (ushort) 467;
      int chestStyle = num1 != 0 ? this.ChestStyle : 0;
      int num2 = 0;
      while (num2 < 10 && !(flag = WorldGen.AddBuriedChest(this._random.Next(2, room.Width - 2) + room.X, j, chestStyle: chestStyle, chestTileType: chestTileType)))
        ++num2;
      if (!flag)
      {
        int i = room.X + 2;
        while (i <= room.X + room.Width - 2 && !(flag = WorldGen.AddBuriedChest(i, j, chestStyle: chestStyle, chestTileType: chestTileType)))
          ++i;
        if (flag)
          break;
      }
      else
        break;
    }
    if (!flag)
    {
      foreach (Microsoft.Xna.Framework.Rectangle room in this.Rooms)
      {
        int j = room.Y - 1;
        int num3 = j > (int) Main.worldSurface ? 1 : 0;
        ushort chestTileType = num3 == 0 || !this.UsesContainers2 ? (ushort) 21 : (ushort) 467;
        int chestStyle = num3 != 0 ? this.ChestStyle : 0;
        int num4 = 0;
        while (num4 < 10 && !(flag = WorldGen.AddBuriedChest(this._random.Next(2, room.Width - 2) + room.X, j, chestStyle: chestStyle, chestTileType: chestTileType)))
          ++num4;
        if (!flag)
        {
          int i = room.X + 2;
          while (i <= room.X + room.Width - 2 && !(flag = WorldGen.AddBuriedChest(i, j, chestStyle: chestStyle, chestTileType: chestTileType)))
            ++i;
          if (flag)
            break;
        }
        else
          break;
      }
    }
    if (flag)
      return;
    for (int index = 0; index < 1000; ++index)
    {
      int i = this._random.Next(this.Rooms[0].X - 30, this.Rooms[0].X + 30);
      int num5 = this._random.Next(this.Rooms[0].Y - 30, this.Rooms[0].Y + 30);
      int num6 = num5 > (int) Main.worldSurface ? 1 : 0;
      ushort num7 = num6 == 0 || !this.UsesContainers2 ? (ushort) 21 : (ushort) 467;
      int chestStyle1 = num6 != 0 ? this.ChestStyle : 0;
      int j = num5;
      int chestStyle2 = chestStyle1;
      int chestTileType = (int) num7;
      if (WorldGen.AddBuriedChest(i, j, chestStyle: chestStyle2, chestTileType: (ushort) chestTileType))
        break;
    }
  }

  private void PlaceBiomeSpecificPriorityTool(HouseBuilderContext context)
  {
    if (this.Type != HouseType.Desert || GenVars.extraBastStatueCount >= GenVars.extraBastStatueCountMax)
      return;
    bool flag = false;
    foreach (Microsoft.Xna.Framework.Rectangle room in this.Rooms)
    {
      int j = room.Height - 2 + room.Y;
      if (WorldGen.remixWorldGen && (double) j > Main.rockLayer)
        return;
      for (int index = 0; index < 10; ++index)
      {
        int i = this._random.Next(2, room.Width - 2) + room.X;
        WorldGen.PlaceTile(i, j, 506, true, true);
        if (flag = this._tiles[i, j].active() && this._tiles[i, j].type == (ushort) 506)
          break;
      }
      if (!flag)
      {
        int i = room.X + 2;
        while (i <= room.X + room.Width - 2 && !(flag = WorldGen.PlaceTile(i, j, 506, true, true)))
          ++i;
        if (flag)
          break;
      }
      else
        break;
    }
    if (!flag)
    {
      foreach (Microsoft.Xna.Framework.Rectangle room in this.Rooms)
      {
        int j = room.Y - 1;
        for (int index = 0; index < 10; ++index)
        {
          int i = this._random.Next(2, room.Width - 2) + room.X;
          WorldGen.PlaceTile(i, j, 506, true, true);
          if (flag = this._tiles[i, j].active() && this._tiles[i, j].type == (ushort) 506)
            break;
        }
        if (!flag)
        {
          int i = room.X + 2;
          while (i <= room.X + room.Width - 2 && !(flag = WorldGen.PlaceTile(i, j, 506, true, true)))
            ++i;
          if (flag)
            break;
        }
        else
          break;
      }
    }
    if (!flag)
      return;
    ++GenVars.extraBastStatueCount;
  }

  private void PlaceBiomeSpecificTool(HouseBuilderContext context)
  {
    if (this.Type == HouseType.Jungle && context.SharpenerCount < this._random.Next(2, 5))
    {
      bool flag = false;
      foreach (Microsoft.Xna.Framework.Rectangle room in this.Rooms)
      {
        int j = room.Height - 2 + room.Y;
        for (int index = 0; index < 10; ++index)
        {
          int i = this._random.Next(2, room.Width - 2) + room.X;
          WorldGen.PlaceTile(i, j, 377, true, true);
          if (flag = this._tiles[i, j].active() && this._tiles[i, j].type == (ushort) 377)
            break;
        }
        if (!flag)
        {
          int i = room.X + 2;
          while (i <= room.X + room.Width - 2 && !(flag = WorldGen.PlaceTile(i, j, 377, true, true)))
            ++i;
          if (flag)
            break;
        }
        else
          break;
      }
      if (flag)
        ++context.SharpenerCount;
    }
    if (this.Type != HouseType.Desert || context.ExtractinatorCount >= this._random.Next(2, 5))
      return;
    ushort Type = 219;
    if (WorldGen.SecretSeed.errorWorld.Enabled)
      Type = (ushort) 642;
    bool flag1 = false;
    foreach (Microsoft.Xna.Framework.Rectangle room in this.Rooms)
    {
      int j = room.Height - 2 + room.Y;
      for (int index = 0; index < 10; ++index)
      {
        int i = this._random.Next(2, room.Width - 2) + room.X;
        WorldGen.PlaceTile(i, j, (int) Type, true, true);
        if (flag1 = this._tiles[i, j].active() && (int) this._tiles[i, j].type == (int) Type)
          break;
      }
      if (!flag1)
      {
        int i = room.X + 2;
        while (i <= room.X + room.Width - 2 && !(flag1 = WorldGen.PlaceTile(i, j, (int) Type, true, true)))
          ++i;
        if (flag1)
          break;
      }
      else
        break;
    }
    if (!flag1)
      return;
    ++context.ExtractinatorCount;
  }
}
