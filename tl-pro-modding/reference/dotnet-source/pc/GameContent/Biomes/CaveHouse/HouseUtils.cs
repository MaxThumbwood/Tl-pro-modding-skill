// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Biomes.CaveHouse.HouseUtils
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.Biomes.CaveHouse;

public static class HouseUtils
{
  private static readonly bool[] BlacklistedTiles = TileID.Sets.Factory.CreateBoolSet(true, 225, 41, 43, 44, 226, 203, 112 /*0x70*/, 25, 151, 21, 467);
  private static readonly bool[] BeelistedTiles = TileID.Sets.Factory.CreateBoolSet(true, 41, 43, 44, 226, 203, 112 /*0x70*/, 25, 151, 21, 467);

  public static HouseBuilder CreateBuilder(Point origin, StructureMap structures)
  {
    List<Microsoft.Xna.Framework.Rectangle> rooms = HouseUtils.CreateRooms(origin);
    if (rooms.Count == 0 || !HouseUtils.AreRoomLocationsValid((IEnumerable<Microsoft.Xna.Framework.Rectangle>) rooms))
      return HouseBuilder.Invalid;
    HouseType houseType = HouseUtils.GetHouseType((IEnumerable<Microsoft.Xna.Framework.Rectangle>) rooms);
    if (!HouseUtils.AreRoomsValid((IEnumerable<Microsoft.Xna.Framework.Rectangle>) rooms, structures, houseType))
      return HouseBuilder.Invalid;
    switch (houseType)
    {
      case HouseType.Wood:
        return (HouseBuilder) new WoodHouseBuilder((IEnumerable<Microsoft.Xna.Framework.Rectangle>) rooms);
      case HouseType.Ice:
        return (HouseBuilder) new IceHouseBuilder((IEnumerable<Microsoft.Xna.Framework.Rectangle>) rooms);
      case HouseType.Desert:
        return (HouseBuilder) new DesertHouseBuilder((IEnumerable<Microsoft.Xna.Framework.Rectangle>) rooms);
      case HouseType.Jungle:
        return (HouseBuilder) new JungleHouseBuilder((IEnumerable<Microsoft.Xna.Framework.Rectangle>) rooms);
      case HouseType.Mushroom:
        return (HouseBuilder) new MushroomHouseBuilder((IEnumerable<Microsoft.Xna.Framework.Rectangle>) rooms);
      case HouseType.Granite:
        return (HouseBuilder) new GraniteHouseBuilder((IEnumerable<Microsoft.Xna.Framework.Rectangle>) rooms);
      case HouseType.Marble:
        return (HouseBuilder) new MarbleHouseBuilder((IEnumerable<Microsoft.Xna.Framework.Rectangle>) rooms);
      default:
        return (HouseBuilder) new WoodHouseBuilder((IEnumerable<Microsoft.Xna.Framework.Rectangle>) rooms);
    }
  }

  public static int GetMaxPossibleRoomsInABigAbandonedHouse()
  {
    return WorldGen.SecretSeed.errorWorld.Enabled ? 30 : 7;
  }

  public static int GetRandomizedRoomCountInABigAbandonedHouse()
  {
    int num = 7;
    if (WorldGen.SecretSeed.errorWorld.Enabled)
      num = WorldGen.genRand.Next(7, 31 /*0x1F*/);
    return Math.Max(0, num - WorldGen.genRand.Next(4));
  }

  private static List<Microsoft.Xna.Framework.Rectangle> CreateRooms_BigAbandonedHouses(Point origin)
  {
    List<Microsoft.Xna.Framework.Rectangle> bigAbandonedHouses1 = new List<Microsoft.Xna.Framework.Rectangle>();
    Point result;
    if (!WorldUtils.Find(origin, Searches.Chain((GenSearch) new Searches.Down(200), (GenCondition) new Conditions.IsSolid()), out result) || result == origin)
      return new List<Microsoft.Xna.Framework.Rectangle>();
    Microsoft.Xna.Framework.Rectangle lastRoom = HouseUtils.FindRoom(result);
    int abigAbandonedHouse = HouseUtils.GetRandomizedRoomCountInABigAbandonedHouse();
    if (abigAbandonedHouse == 0)
      return bigAbandonedHouses1;
    for (int index = 0; index < abigAbandonedHouse; ++index)
    {
      Microsoft.Xna.Framework.Rectangle bigAbandonedHouses2 = HouseUtils.FindRoom_BigAbandonedHouses(new Point(lastRoom.Center.X, lastRoom.Y + 1), lastRoom);
      bigAbandonedHouses1.Add(bigAbandonedHouses2);
      lastRoom = bigAbandonedHouses2;
    }
    for (int index = 0; index < bigAbandonedHouses1.Count; ++index)
      bigAbandonedHouses1[index].Y += 3;
    return bigAbandonedHouses1;
  }

  private static List<Microsoft.Xna.Framework.Rectangle> CreateRooms(Point origin)
  {
    if (WorldGen.SecretSeed.GenerateBiggerAbandonedHouses)
      return HouseUtils.CreateRooms_BigAbandonedHouses(origin);
    Point result;
    if (!WorldUtils.Find(origin, Searches.Chain((GenSearch) new Searches.Down(200), (GenCondition) new Conditions.IsSolid()), out result) || result == origin)
      return new List<Microsoft.Xna.Framework.Rectangle>();
    Microsoft.Xna.Framework.Rectangle room1 = HouseUtils.FindRoom(result);
    Microsoft.Xna.Framework.Rectangle room2 = HouseUtils.FindRoom(new Point(room1.Center.X, room1.Y + 1));
    Microsoft.Xna.Framework.Rectangle room3 = HouseUtils.FindRoom(new Point(room1.Center.X, room1.Y + room1.Height + 10)) with
    {
      Y = room1.Y + room1.Height - 1
    };
    double roomSolidPrecentage1 = HouseUtils.GetRoomSolidPrecentage(room2);
    double roomSolidPrecentage2 = HouseUtils.GetRoomSolidPrecentage(room3);
    room1.Y += 3;
    room2.Y += 3;
    room3.Y += 3;
    List<Microsoft.Xna.Framework.Rectangle> rooms = new List<Microsoft.Xna.Framework.Rectangle>();
    if (WorldGen.genRand.NextDouble() > roomSolidPrecentage1 + 0.2)
      rooms.Add(room2);
    rooms.Add(room1);
    if (WorldGen.genRand.NextDouble() > roomSolidPrecentage2 + 0.2)
      rooms.Add(room3);
    return rooms;
  }

  private static Microsoft.Xna.Framework.Rectangle FindRoom(Point origin)
  {
    Point result1;
    bool flag1 = WorldUtils.Find(origin, Searches.Chain((GenSearch) new Searches.Left(25), (GenCondition) new Conditions.IsSolid()), out result1);
    Point result2;
    int num1 = WorldUtils.Find(origin, Searches.Chain((GenSearch) new Searches.Right(25), (GenCondition) new Conditions.IsSolid()), out result2) ? 1 : 0;
    if (!flag1)
      result1 = new Point(origin.X - 25, origin.Y);
    if (num1 == 0)
      result2 = new Point(origin.X + 25, origin.Y);
    Microsoft.Xna.Framework.Rectangle room = new Microsoft.Xna.Framework.Rectangle(origin.X, origin.Y, 0, 0);
    if (origin.X - result1.X > result2.X - origin.X)
    {
      room.X = result1.X;
      room.Width = Utils.Clamp<int>(result2.X - result1.X, 15, 30);
    }
    else
    {
      room.Width = Utils.Clamp<int>(result2.X - result1.X, 15, 30);
      room.X = result2.X - room.Width;
    }
    Point result3;
    bool flag2 = WorldUtils.Find(result1, Searches.Chain((GenSearch) new Searches.Up(10), (GenCondition) new Conditions.IsSolid()), out result3);
    Point result4;
    int num2 = WorldUtils.Find(result2, Searches.Chain((GenSearch) new Searches.Up(10), (GenCondition) new Conditions.IsSolid()), out result4) ? 1 : 0;
    if (!flag2)
      result3 = new Point(origin.X, origin.Y - 10);
    if (num2 == 0)
      result4 = new Point(origin.X, origin.Y - 10);
    room.Height = Utils.Clamp<int>(Math.Max(origin.Y - result3.Y, origin.Y - result4.Y), 8, 12);
    room.Y -= room.Height;
    return room;
  }

  private static Microsoft.Xna.Framework.Rectangle FindRoom_BigAbandonedHouses(
    Point origin,
    Microsoft.Xna.Framework.Rectangle lastRoom)
  {
    int minValue1 = 15;
    int num1 = 30;
    int minValue2 = 8;
    int num2 = 12;
    Point result1;
    bool flag = WorldUtils.Find(origin, Searches.Chain((GenSearch) new Searches.Left(25), (GenCondition) new Conditions.IsSolid()), out result1);
    Point result2;
    int num3 = WorldUtils.Find(origin, Searches.Chain((GenSearch) new Searches.Right(25), (GenCondition) new Conditions.IsSolid()), out result2) ? 1 : 0;
    if (!flag)
      result1 = new Point(origin.X - 25, origin.Y);
    if (num3 == 0)
      result2 = new Point(origin.X + 25, origin.Y);
    Microsoft.Xna.Framework.Rectangle bigAbandonedHouses = new Microsoft.Xna.Framework.Rectangle(origin.X, origin.Y, 0, 0);
    if (WorldGen.genRand.Next(2) == 0)
    {
      if (result1.X < lastRoom.Left)
        result1.X = lastRoom.Left;
      bigAbandonedHouses.X = result1.X;
      bigAbandonedHouses.Width = WorldGen.genRand.Next(minValue1, num1 + 1);
      if (bigAbandonedHouses.Left <= 10)
        bigAbandonedHouses.X = 10;
      if (bigAbandonedHouses.Right >= Main.maxTilesX - 10)
        bigAbandonedHouses.X = Main.maxTilesX - 10 - bigAbandonedHouses.Width;
    }
    else
    {
      if (result2.X > lastRoom.Right)
        result2.X = lastRoom.Right;
      bigAbandonedHouses.Width = WorldGen.genRand.Next(minValue1, num1 + 1);
      bigAbandonedHouses.X = result2.X - bigAbandonedHouses.Width;
      if (bigAbandonedHouses.Left <= 10)
        bigAbandonedHouses.X = 10;
      if (bigAbandonedHouses.Right >= Main.maxTilesX - 10)
        bigAbandonedHouses.X = Main.maxTilesX - 10 - bigAbandonedHouses.Width;
    }
    bigAbandonedHouses.Height = WorldGen.genRand.Next(minValue2, num2 + 1);
    bigAbandonedHouses.Y -= bigAbandonedHouses.Height;
    return bigAbandonedHouses;
  }

  private static double GetRoomSolidPrecentage(Microsoft.Xna.Framework.Rectangle room)
  {
    double num = (double) (room.Width * room.Height);
    Ref<int> count = new Ref<int>(0);
    WorldUtils.Gen(new Point(room.X, room.Y), (GenShape) new Shapes.Rectangle(room.Width, room.Height), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.IsSolid(), (GenAction) new Terraria.WorldBuilding.Actions.Count(count)));
    return (double) count.Value / num;
  }

  private static bool AreRoomLocationsValid(IEnumerable<Microsoft.Xna.Framework.Rectangle> rooms)
  {
    foreach (Microsoft.Xna.Framework.Rectangle room in rooms)
    {
      if (!WorldGen.InWorld(room, 10) || room.Y + room.Height > Main.maxTilesY - 220)
        return false;
    }
    return true;
  }

  private static HouseType GetHouseType(IEnumerable<Microsoft.Xna.Framework.Rectangle> rooms)
  {
    Dictionary<ushort, int> resultsOutput = new Dictionary<ushort, int>();
    foreach (Microsoft.Xna.Framework.Rectangle room in rooms)
      WorldUtils.Gen(new Point(room.X - 10, room.Y - 10), (GenShape) new Shapes.Rectangle(room.Width + 20, room.Height + 20), (GenAction) new Terraria.WorldBuilding.Actions.TileScanner(new ushort[12]
      {
        (ushort) 0,
        (ushort) 59,
        (ushort) 147,
        (ushort) 1,
        (ushort) 161,
        (ushort) 53,
        (ushort) 396,
        (ushort) 397,
        (ushort) 368,
        (ushort) 367,
        (ushort) 60,
        (ushort) 70
      }).Output(resultsOutput));
    List<Tuple<HouseType, int>> tupleList = new List<Tuple<HouseType, int>>()
    {
      Tuple.Create<HouseType, int>(HouseType.Wood, resultsOutput[(ushort) 0] + resultsOutput[(ushort) 1]),
      Tuple.Create<HouseType, int>(HouseType.Jungle, resultsOutput[(ushort) 59] + resultsOutput[(ushort) 60] * 10),
      Tuple.Create<HouseType, int>(HouseType.Mushroom, resultsOutput[(ushort) 59] + resultsOutput[(ushort) 70] * 10),
      Tuple.Create<HouseType, int>(HouseType.Ice, resultsOutput[(ushort) 147] + resultsOutput[(ushort) 161]),
      Tuple.Create<HouseType, int>(HouseType.Desert, resultsOutput[(ushort) 397] + resultsOutput[(ushort) 396] + resultsOutput[(ushort) 53]),
      Tuple.Create<HouseType, int>(HouseType.Granite, resultsOutput[(ushort) 368]),
      Tuple.Create<HouseType, int>(HouseType.Marble, resultsOutput[(ushort) 367])
    };
    Tuple<HouseType, int> tuple = tupleList[0];
    for (int index = 1; index < tupleList.Count; ++index)
    {
      if (tuple.Item2 < tupleList[index].Item2)
        tuple = tupleList[index];
    }
    return tuple.Item1;
  }

  private static bool AreRoomsValid(
    IEnumerable<Microsoft.Xna.Framework.Rectangle> rooms,
    StructureMap structures,
    HouseType style)
  {
    foreach (Microsoft.Xna.Framework.Rectangle room in rooms)
    {
      if (style != HouseType.Granite)
      {
        if (WorldUtils.Find(new Point(room.X - 2, room.Y - 2), Searches.Chain(new Searches.Rectangle(room.Width + 4, room.Height + 4).RequireAll(false), (GenCondition) new Conditions.HasLava()), out Point _))
          return false;
      }
      if (WorldGen.notTheBees)
      {
        if (!structures.CanPlace(room, HouseUtils.BeelistedTiles, 5))
          return false;
      }
      else if (!structures.CanPlace(room, HouseUtils.BlacklistedTiles, 5))
        return false;
    }
    return true;
  }
}
