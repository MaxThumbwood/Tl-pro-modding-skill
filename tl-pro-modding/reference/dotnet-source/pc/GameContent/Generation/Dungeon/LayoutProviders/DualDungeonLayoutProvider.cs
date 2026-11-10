// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.LayoutProviders.DualDungeonLayoutProvider
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria.GameContent.Biomes;
using Terraria.GameContent.Generation.Dungeon.Halls;
using Terraria.GameContent.Generation.Dungeon.Rooms;
using Terraria.Localization;
using Terraria.Utilities;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.LayoutProviders;

public class DualDungeonLayoutProvider(DungeonLayoutProviderSettings settings) : 
  DungeonLayoutProvider(settings)
{
  public override void ProvideLayout(
    DungeonData data,
    GenerationProgress progress,
    UnifiedRandom genRand,
    ref int roomDelay)
  {
    DungeonRoom entranceRoom = DualDungeonLayoutProvider.CalculateEntranceRoom(data);
    DungeonRoom startingRoom = this.CalculateStartingRoom(data);
    this.CalculateEntranceHall(data, entranceRoom, startingRoom);
    List<DungeonRoom> biomeRooms = this.CalculateBiomeRooms(data);
    List<DungeonRoom> rooms = this.CalculateRooms(data);
    this.ConvertSpecializedRooms(data, rooms);
    List<DungeonHall> halls = new DualDungeonLayoutProvider.HallwayCalculator(data, biomeRooms.Concat<DungeonRoom>((IEnumerable<DungeonRoom>) rooms).Concat<DungeonRoom>((IEnumerable<DungeonRoom>) new DungeonRoom[1]
    {
      startingRoom
    }).ToList<DungeonRoom>()).Generate();
    this.ConvertSpecializedHalls(halls);
    DualDungeonLayoutProvider.CalculateDungeonBounds(data, rooms.Concat<DungeonRoom>((IEnumerable<DungeonRoom>) new DungeonRoom[1]
    {
      startingRoom
    }), (IEnumerable<DungeonHall>) halls);
    for (int index = 0; index < data.dungeonRooms.Count; ++index)
    {
      double num = Math.Round((double) (index + 1) / (double) data.dungeonRooms.Count * 100.0);
      DungeonUtils.UpdateDungeonProgress(progress, Utils.Remap((float) index, 0.0f, (float) data.dungeonRooms.Count, 0.35f, 0.4f), Language.GetTextValue("WorldGeneration.DungeonRooms", (object) num), true);
      data.dungeonRooms[index].GenerateRoom(data);
    }
    for (int index = 0; index < data.dungeonRooms.Count; ++index)
      data.dungeonRooms[index].GeneratePreHallwaysDungeonFeaturesInRoom(data);
    List<DungeonHall> all1 = data.dungeonHalls.FindAll(new Predicate<DungeonHall>(DualDungeonLayoutProvider.HallwayCheck_IsCrackedBrickHall));
    List<DungeonHall> all2 = data.dungeonHalls.FindAll(new Predicate<DungeonHall>(DualDungeonLayoutProvider.HallwayCheck_IsSpiderHall));
    int fromValue = 0;
    for (int index = 0; index < all1.Count; ++index)
    {
      DungeonHall dungeonHall = all1[index];
      double num = Math.Round((double) (fromValue + 1) / (double) data.dungeonHalls.Count * 100.0);
      DungeonUtils.UpdateDungeonProgress(progress, Utils.Remap((float) fromValue, 0.0f, (float) data.dungeonHalls.Count, 0.4f, 0.6f), Language.GetTextValue("WorldGeneration.DungeonHalls", (object) num), true);
      if (dungeonHall.calculated)
      {
        dungeonHall.GenerateHall(data);
        ++fromValue;
      }
    }
    for (int index = 0; index < all2.Count; ++index)
    {
      DungeonHall dungeonHall = all2[index];
      double num = Math.Round((double) (fromValue + 1) / (double) data.dungeonHalls.Count * 100.0);
      DungeonUtils.UpdateDungeonProgress(progress, Utils.Remap((float) fromValue, 0.0f, (float) data.dungeonHalls.Count, 0.4f, 0.6f), Language.GetTextValue("WorldGeneration.DungeonHalls", (object) num), true);
      if (dungeonHall.calculated)
      {
        dungeonHall.GenerateHall(data);
        ++fromValue;
      }
    }
    for (int index = 0; index < data.dungeonHalls.Count; ++index)
    {
      DungeonHall dungeonHall = data.dungeonHalls[index];
      if (!DualDungeonLayoutProvider.HallwayCheck_IsCrackedBrickHall(dungeonHall) && !DualDungeonLayoutProvider.HallwayCheck_IsSpiderHall(dungeonHall))
      {
        double num = Math.Round((double) (fromValue + 1) / (double) data.dungeonHalls.Count * 100.0);
        DungeonUtils.UpdateDungeonProgress(progress, Utils.Remap((float) fromValue, 0.0f, (float) data.dungeonHalls.Count, 0.4f, 0.6f), Language.GetTextValue("WorldGeneration.DungeonHalls", (object) num), true);
        if (dungeonHall.calculated)
        {
          dungeonHall.GenerateHall(data);
          ++fromValue;
        }
      }
    }
  }

  private static bool HallwayCheck_IsSpiderHall(DungeonHall hall)
  {
    return hall.settings.StyleData.Style == (byte) 12;
  }

  private static bool HallwayCheck_IsCrackedBrickHall(DungeonHall hall) => hall.CrackedBrick;

  private DungeonRoom CalculateStartingRoom(DungeonData data)
  {
    UnifiedRandom genRand = WorldGen.genRand;
    DungeonControlLine dungeonControlLine = data.genVars.dungeonDitherSnake[0];
    Vector2D start = dungeonControlLine.Start;
    RegularDungeonRoomSettings settings = new RegularDungeonRoomSettings();
    settings.RoomType = DungeonRoomType.Regular;
    settings.RoomPosition = new Point((int) start.X, (int) start.Y);
    settings.RandomSeed = genRand.Next();
    settings.ProgressionStage = dungeonControlLine.ProgressionStage;
    settings.StyleData = dungeonControlLine.Style;
    settings.OverrideOuterBoundsSize = 8;
    settings.OverrideInnerBoundsSize = (int) (20.0 * data.roomStrengthScalar);
    DungeonRoom room = DungeonCrawler.MakeDungeon_GetRoom((DungeonRoomSettings) settings);
    room.CalculateRoom(data);
    return room;
  }

  private DungeonHall CalculateEntranceHall(
    DungeonData data,
    DungeonRoom entranceRoom,
    DungeonRoom startingRoom)
  {
    StairwellDungeonHallSettings hallSettings = (StairwellDungeonHallSettings) DungeonCrawler.MakeDungeon_GetHallSettings(DungeonHallType.Stairwell, data, Vector2.Zero, Vector2.Zero, startingRoom.settings.StyleData);
    hallSettings.IsEntranceHall = true;
    DungeonHall hall = DungeonCrawler.MakeDungeon_GetHall((DungeonHallSettings) hallSettings);
    Vector2D point1;
    Vector2D point2;
    int connectionPoints = (int) DualDungeonLayoutProvider.GetHallwayConnectionPoints(entranceRoom, startingRoom, out point1, out point2);
    hall.CalculateHall(data, point1, point2);
    return hall;
  }

  private List<DungeonRoom> CalculateBiomeRooms(DungeonData data)
  {
    List<DungeonRoom> biomeRooms = new List<DungeonRoom>();
    foreach (DungeonControlLine line in (List<DungeonControlLine>) data.genVars.dungeonDitherSnake)
    {
      if (line.Next == null || line.Next.ProgressionStage != line.ProgressionStage)
      {
        Vector2D vector2D = line.Next != null ? line.Start : line.End;
        DungeonRoomSettings roomSettings = DungeonCrawler.MakeDungeon_GetRoomSettings(line.Style.BiomeRoomType, data, line);
        roomSettings.RoomPosition = new Point((int) vector2D.X, (int) vector2D.Y);
        DungeonRoom room = DungeonCrawler.MakeDungeon_GetRoom(roomSettings);
        room.CalculateRoom(data);
        biomeRooms.Add(room);
      }
    }
    return biomeRooms;
  }

  private List<DungeonRoom> CalculateRooms(DungeonData data)
  {
    UnifiedRandom genRand = WorldGen.genRand;
    DitherSnake dungeonDitherSnake = data.genVars.dungeonDitherSnake;
    List<DungeonRoom> rooms = new List<DungeonRoom>();
    DungeonRoom room;
    foreach (DungeonControlLine line in dungeonDitherSnake.Skip<DungeonControlLine>(1))
    {
      if (line.ProgressionStage != line.Prev.ProgressionStage)
      {
        if (this.TryMakeRegularRoomOnLine(data, line, 0.8, genRand.NextDouble() - 0.5, out room))
          rooms.Add(room);
      }
      else
      {
        for (int index = 0; index < 20; ++index)
        {
          double num = genRand.NextDouble() * 2.0 - 1.0;
          double normalizedDistanceFrom = (double) Math.Sign(num) * Math.Pow(Math.Abs(num), 0.5);
          if (this.TryMakeRegularRoomOnLine(data, line, genRand.NextDouble(), normalizedDistanceFrom, out room))
            rooms.Add(room);
        }
      }
    }
    return rooms;
  }

  private bool TryMakeRegularRoomOnLine(
    DungeonData data,
    DungeonControlLine line,
    double normalizedDistanceAlong,
    double normalizedDistanceFrom,
    out DungeonRoom room)
  {
    int num = 10;
    DungeonRoomSettings roomSettings = DungeonCrawler.MakeDungeon_GetRoomSettings(DualDungeonLayoutProvider.DualDungeonLayout_GetGeneralRoomType(WorldGen.genRand), data, line);
    int boundingRadius = roomSettings.GetBoundingRadius();
    SnakeOrientation orientation = roomSettings.Orientation;
    Point point = data.genVars.dungeonDitherSnake.GetRoomPositionInsideBorder(line, normalizedDistanceAlong, normalizedDistanceFrom, boundingRadius, out orientation).ToPoint();
    roomSettings.Orientation = orientation;
    roomSettings.RoomPosition = new Point(point.X, point.Y);
    room = DungeonCrawler.MakeDungeon_TryRoom(data, point.X, point.Y, roomSettings, fluff: boundingRadius + num);
    if (room == null)
      return false;
    room.CalculateRoom(data);
    return true;
  }

  private static void CalculateDungeonBounds(
    DungeonData data,
    IEnumerable<DungeonRoom> rooms,
    IEnumerable<DungeonHall> halls)
  {
    DungeonBounds potentialDungeonBounds = data.genVars.outerPotentialDungeonBounds;
    int count = data.genVars.dungeonGenerationStyles.Count;
    data.outerProgressionBounds = new DungeonBounds[count];
    for (int index = 0; index < count; ++index)
    {
      DungeonBounds dungeonBounds = data.outerProgressionBounds[index] = new DungeonBounds();
      foreach (DungeonRoom room in rooms)
        dungeonBounds.UpdateBounds(room.OuterBounds);
      foreach (DungeonHall hall in halls)
        dungeonBounds.UpdateBounds(hall.Bounds);
      if (dungeonBounds.Top < potentialDungeonBounds.Top)
        dungeonBounds.Top = potentialDungeonBounds.Top;
      if (dungeonBounds.Bottom > potentialDungeonBounds.Bottom)
        dungeonBounds.Bottom = potentialDungeonBounds.Bottom;
      dungeonBounds.CalculateHitbox();
    }
  }

  private static DungeonRoom CalculateEntranceRoom(DungeonData data)
  {
    DungeonBounds potentialDungeonBounds = data.genVars.outerPotentialDungeonBounds;
    if (data.genVars.generatingDungeonPositionY > potentialDungeonBounds.Top - 10)
      data.genVars.generatingDungeonPositionY = potentialDungeonBounds.Top - 10;
    if (data.genVars.preGenDungeonEntranceSettings.PrecalculateEntrancePosition)
    {
      data.genVars.generatingDungeonPositionX = (int) data.genVars.dungeonEntrancePosition.X - 10 + WorldGen.genRand.Next(20);
      data.genVars.generatingDungeonPositionY = (int) data.genVars.dungeonEntrancePosition.Y + 30;
    }
    if (SpecialSeedFeatures.DungeonEntranceIsBuried)
      data.genVars.generatingDungeonPositionY = (int) Main.worldSurface + 15;
    if (SpecialSeedFeatures.DungeonEntranceIsUnderground)
      data.genVars.generatingDungeonPositionY = (int) GenVars.worldSurfaceHigh + 15;
    LegacyDungeonRoomSettings settings = new LegacyDungeonRoomSettings();
    settings.StyleData = data.genVars.dungeonStyle;
    settings.RoomPosition = new Point(data.genVars.generatingDungeonPositionX, data.genVars.generatingDungeonPositionY);
    settings.IsEntranceRoom = true;
    DungeonRoom room = DungeonCrawler.MakeDungeon_GetRoom((DungeonRoomSettings) settings);
    room.CalculateRoom(data);
    return room;
  }

  public static DungeonRoomType DualDungeonLayout_GetGeneralRoomType(UnifiedRandom genRand)
  {
    switch (genRand.Next(8))
    {
      case 1:
        return DungeonRoomType.Regular;
      case 2:
        return DungeonRoomType.Wormlike;
      case 3:
        return DungeonRoomType.GenShapeCircle;
      case 4:
        return DungeonRoomType.GenShapeMound;
      case 5:
        return DungeonRoomType.GenShapeHourglass;
      case 6:
        return DungeonRoomType.GenShapeDoughnut;
      case 7:
        return DungeonRoomType.GenShapeQuadCircle;
      default:
        return DungeonRoomType.Legacy;
    }
  }

  public static DungeonHallType DualDungeonLayout_GetGeneralHallType(UnifiedRandom genRand)
  {
    switch (genRand.Next(3))
    {
      case 1:
        return DungeonHallType.Regular;
      case 2:
        return DungeonHallType.Sine;
      default:
        return DungeonHallType.Legacy;
    }
  }

  public void ConvertSpecializedRooms(DungeonData data, List<DungeonRoom> rooms)
  {
    UnifiedRandom genRand = WorldGen.genRand;
    DitherSnake dungeonDitherSnake = data.genVars.dungeonDitherSnake;
    int num1 = 2;
    int num2 = 2;
    int num3 = 2;
    int num4 = 2;
    int num5 = 5;
    int num6 = 6;
    switch (WorldGen.GetWorldSize())
    {
      case 0:
        num1 = 2;
        num2 = 2;
        num3 = 2;
        num4 = 2;
        num5 = 5;
        num6 = 6;
        break;
      case 1:
        num1 = 4;
        num2 = 6;
        num3 = 6;
        num4 = 6;
        num5 = 8;
        num6 = 10;
        break;
      case 2:
        num1 = 6;
        num2 = 10;
        num3 = 10;
        num4 = 8;
        num5 = 11;
        num6 = 14;
        break;
    }
    List<DungeonRoom> source1 = new List<DungeonRoom>();
    List<DungeonRoom> source2 = new List<DungeonRoom>();
    List<DungeonRoom> source3 = new List<DungeonRoom>();
    foreach (DungeonRoom room in rooms)
    {
      switch (room.settings.StyleData.Style)
      {
        case 1:
          source1.Add(room);
          continue;
        case 6:
          source3.Add(room);
          continue;
        case 8:
          source2.Add(room);
          continue;
        default:
          continue;
      }
    }
    List<DungeonRoom> list1 = source1.ToList<DungeonRoom>();
    int count1 = list1.Count;
    int num7 = 2000;
    while (num7 > 0 && list1.Count > 0 && num1 > 0)
    {
      --num7;
      if (num7 > 0)
      {
        DungeonRoom dungeonRoom = list1[genRand.Next(list1.Count)];
        if (dungeonRoom.settings.OnCurvedLine || dungeonRoom.settings.Orientation != SnakeOrientation.Bottom)
          list1.Remove(dungeonRoom);
        else if (dungeonRoom.settings is GenShapeDungeonRoomSettings && ((GenShapeDungeonRoomSettings) dungeonRoom.settings).ShapeType == GenShapeType.Doughnut)
          list1.Remove(dungeonRoom);
        else if (dungeonRoom.GetFloodedRoomTileCount() < SceneMetrics.ShimmerTileThreshold)
        {
          list1.Remove(dungeonRoom);
        }
        else
        {
          dungeonRoom.settings.StyleData = DungeonGenerationStyles.Shimmer;
          dungeonRoom.settings.HallwayConnectionPointOverride = new DungeonUtils.GetHallwayConnectionPoint(DualDungeonLayoutProvider.ConnectToTopOfRoomOnly);
          --num1;
          source1.Remove(dungeonRoom);
          list1.Remove(dungeonRoom);
        }
      }
      else
        break;
    }
    if (num1 > 0)
    {
      List<DungeonRoom> list2 = source1.ToList<DungeonRoom>();
      int count2 = list2.Count;
      int num8 = 2000;
      while (num8 > 0 && list2.Count > 0 && num1 > 0)
      {
        --num8;
        if (num8 > 0)
        {
          DungeonRoom dungeonRoom = list2[genRand.Next(list2.Count)];
          if (dungeonRoom.settings.OnCurvedLine || dungeonRoom.settings.Orientation != SnakeOrientation.Bottom)
            list2.Remove(dungeonRoom);
          else if (dungeonRoom.settings is GenShapeDungeonRoomSettings && ((GenShapeDungeonRoomSettings) dungeonRoom.settings).ShapeType == GenShapeType.Doughnut)
          {
            list2.Remove(dungeonRoom);
          }
          else
          {
            dungeonRoom.settings.StyleData = DungeonGenerationStyles.Shimmer;
            dungeonRoom.settings.HallwayConnectionPointOverride = new DungeonUtils.GetHallwayConnectionPoint(DualDungeonLayoutProvider.ConnectToTopOfRoomOnly);
            --num1;
            source1.Remove(dungeonRoom);
            list2.Remove(dungeonRoom);
          }
        }
        else
          break;
      }
    }
    List<DungeonRoom> list3 = source1.ToList<DungeonRoom>();
    int num9 = 2000;
    while (num9 > 0 && list3.Count > 0 && num2 > 0)
    {
      --num9;
      if (num9 > 0)
      {
        DungeonRoom dungeonRoom = list3[genRand.Next(list3.Count)];
        if (dungeonRoom.settings.OnCurvedLine)
        {
          list3.Remove(dungeonRoom);
        }
        else
        {
          DungeonControlLine controlLine = dungeonRoom.settings.ControlLine;
          DungeonRoomSettings roomSettings = DungeonCrawler.MakeDungeon_GetRoomSettings(DungeonRoomType.LivingTree, data, controlLine);
          roomSettings.RoomPosition = new Point(dungeonRoom.settings.RoomPosition.X, dungeonRoom.settings.RoomPosition.Y);
          if (dungeonDitherSnake.IsCircleInsideBorderWithMatchingStyle(controlLine, Vector2D.op_Implicit(roomSettings.RoomPosition), roomSettings.GetBoundingRadius()))
          {
            int index1 = data.dungeonRooms.IndexOf(dungeonRoom);
            int index2 = rooms.IndexOf(dungeonRoom);
            source1.Remove(dungeonRoom);
            list3.Remove(dungeonRoom);
            rooms.Remove(dungeonRoom);
            data.dungeonRooms.Remove(dungeonRoom);
            DungeonRoom room = DungeonCrawler.MakeDungeon_GetRoom(roomSettings, false);
            room.CalculateRoom(data);
            if (index1 > -1)
              data.dungeonRooms.Insert(index1, room);
            else
              data.dungeonRooms.Add(room);
            if (index2 > -1)
              rooms.Insert(index2, room);
            else
              rooms.Add(room);
            room.settings.StyleData = DungeonGenerationStyles.LivingWood;
            room.settings.HallwayConnectionPointOverride = new DungeonUtils.GetHallwayConnectionPoint(DualDungeonLayoutProvider.ConnectToBottomOfRoomOnly);
            --num2;
          }
        }
      }
      else
        break;
    }
    List<DungeonRoom> list4 = source1.ToList<DungeonRoom>();
    int num10 = 2000;
    while (num10 > 0 && list4.Count > 0 && num4 > 0)
    {
      --num10;
      if (num10 > 0)
      {
        DungeonRoom dungeonRoom = list4[genRand.Next(list4.Count)];
        if (dungeonRoom.settings.OnCurvedLine)
        {
          list4.Remove(dungeonRoom);
        }
        else
        {
          dungeonRoom.settings.StyleData = DungeonGenerationStyles.Spider;
          --num4;
          source1.Remove(dungeonRoom);
          list4.Remove(dungeonRoom);
        }
      }
      else
        break;
    }
    List<DungeonRoom> list5 = source2.ToList<DungeonRoom>();
    int num11 = 2000;
    while (num11 > 0 && list5.Count > 0 && num5 > 0)
    {
      --num11;
      if (num11 > 0)
      {
        DungeonRoom dungeonRoom = list5[genRand.Next(list5.Count)];
        if (dungeonRoom.settings.OnCurvedLine || dungeonRoom.settings.Orientation != SnakeOrientation.Bottom)
          list5.Remove(dungeonRoom);
        else if (dungeonRoom.settings is GenShapeDungeonRoomSettings && ((GenShapeDungeonRoomSettings) dungeonRoom.settings).ShapeType == GenShapeType.Doughnut)
        {
          list5.Remove(dungeonRoom);
        }
        else
        {
          dungeonRoom.settings.StyleData = DungeonGenerationStyles.Beehive;
          dungeonRoom.settings.HallwayConnectionPointOverride = new DungeonUtils.GetHallwayConnectionPoint(DualDungeonLayoutProvider.ConnectToTopOfRoomOnly);
          --num5;
          source2.Remove(dungeonRoom);
          list5.Remove(dungeonRoom);
        }
      }
      else
        break;
    }
    List<DungeonRoom> list6 = source2.ToList<DungeonRoom>();
    int num12 = 2000;
    while (num12 > 0 && list6.Count > 0 && num3 > 0)
    {
      --num12;
      if (num12 > 0)
      {
        DungeonRoom dungeonRoom = list6[genRand.Next(list6.Count)];
        if (dungeonRoom.settings.OnCurvedLine)
        {
          list6.Remove(dungeonRoom);
        }
        else
        {
          DungeonControlLine controlLine = dungeonRoom.settings.ControlLine;
          DungeonRoomSettings roomSettings = DungeonCrawler.MakeDungeon_GetRoomSettings(DungeonRoomType.LivingTree, data, controlLine);
          roomSettings.RoomPosition = new Point(dungeonRoom.settings.RoomPosition.X, dungeonRoom.settings.RoomPosition.Y);
          if (dungeonDitherSnake.IsCircleInsideBorderWithMatchingStyle(controlLine, Vector2D.op_Implicit(roomSettings.RoomPosition), roomSettings.GetBoundingRadius()))
          {
            int index3 = data.dungeonRooms.IndexOf(dungeonRoom);
            int index4 = rooms.IndexOf(dungeonRoom);
            source1.Remove(dungeonRoom);
            list6.Remove(dungeonRoom);
            rooms.Remove(dungeonRoom);
            data.dungeonRooms.Remove(dungeonRoom);
            DungeonRoom room = DungeonCrawler.MakeDungeon_GetRoom(roomSettings, false);
            room.CalculateRoom(data);
            if (index3 > -1)
              data.dungeonRooms.Insert(index3, room);
            else
              data.dungeonRooms.Add(room);
            if (index4 > -1)
              rooms.Insert(index4, room);
            else
              rooms.Add(room);
            room.settings.StyleData = DungeonGenerationStyles.LivingMahogany;
            room.settings.HallwayConnectionPointOverride = new DungeonUtils.GetHallwayConnectionPoint(DualDungeonLayoutProvider.ConnectToBottomOfRoomOnly);
            --num3;
          }
        }
      }
      else
        break;
    }
    List<DungeonRoom> list7 = source3.ToList<DungeonRoom>();
    int num13 = 2000;
    while (num13 > 0 && list7.Count > 0 && num6 > 0)
    {
      --num13;
      if (num13 <= 0)
        break;
      DungeonRoom dungeonRoom = list7[genRand.Next(list7.Count)];
      if (dungeonRoom.settings.OnCurvedLine)
      {
        list7.Remove(dungeonRoom);
      }
      else
      {
        dungeonRoom.settings.StyleData = DungeonGenerationStyles.Crystal;
        --num6;
        source3.Remove(dungeonRoom);
        list7.Remove(dungeonRoom);
      }
    }
  }

  public void ConvertSpecializedHalls(List<DungeonHall> halls)
  {
    UnifiedRandom genRand = WorldGen.genRand;
    int num1 = 3;
    switch (WorldGen.GetWorldSize())
    {
      case 0:
        num1 = 3;
        break;
      case 1:
        num1 = 4;
        break;
      case 2:
        num1 = 5;
        break;
    }
    List<DungeonHall> source = new List<DungeonHall>();
    foreach (DungeonHall hall in halls)
    {
      if (hall.settings.StyleData.Style == (byte) 1)
        source.Add(hall);
    }
    List<DungeonHall> list = source.ToList<DungeonHall>();
    int num2 = 2000;
    while (num2 > 0 && list.Count > 0 && num1 > 0)
    {
      --num2;
      if (num2 <= 0)
        break;
      DungeonHall dungeonHall = list[genRand.Next(list.Count)];
      if (dungeonHall.CrackedBrick)
      {
        list.Remove(dungeonHall);
      }
      else
      {
        dungeonHall.settings.StyleData = DungeonGenerationStyles.Spider;
        --num1;
        source.Remove(dungeonHall);
        list.Remove(dungeonHall);
      }
    }
  }

  public static ConnectionPointQuality ConnectToTopOfRoomOnly(
    DungeonRoom room,
    Vector2D otherRoomPos,
    out Vector2D connectionPoint)
  {
    connectionPoint = Vector2D.op_Implicit(room.GetRoomCenterForHallway(otherRoomPos));
    while (room.IsInsideRoom(connectionPoint.ToPoint()))
      --connectionPoint.Y;
    connectionPoint.Y += 3.0;
    Vector2D vector2D = Vector2D.op_Subtraction(otherRoomPos, connectionPoint).SafeNormalize(new Vector2D());
    if (vector2D.Y < 0.0)
      return ConnectionPointQuality.Good;
    return vector2D.Y >= 0.3 ? ConnectionPointQuality.Bad : ConnectionPointQuality.Okay;
  }

  public static ConnectionPointQuality ConnectToBottomOfRoomOnly(
    DungeonRoom room,
    Vector2D otherRoomPos,
    out Vector2D connectionPoint)
  {
    connectionPoint = Vector2D.op_Implicit(room.GetRoomCenterForHallway(otherRoomPos));
    while (room.IsInsideRoom(connectionPoint.ToPoint()))
      ++connectionPoint.Y;
    connectionPoint.Y -= 3.0;
    Vector2D vector2D = Vector2D.op_Subtraction(otherRoomPos, connectionPoint).SafeNormalize(new Vector2D());
    if (vector2D.Y > 0.3)
      return ConnectionPointQuality.Bad;
    return vector2D.Y <= 0.0 ? ConnectionPointQuality.Good : ConnectionPointQuality.Okay;
  }

  public static ConnectionPointQuality GetHallwayConnectionPoints(
    DungeonRoom room1,
    DungeonRoom room2,
    out Vector2D point1,
    out Vector2D point2)
  {
    return (ConnectionPointQuality) Math.Max((int) room1.GetHallwayConnectionPoint(Vector2D.op_Implicit(room2.Center), out point1), (int) room2.GetHallwayConnectionPoint(Vector2D.op_Implicit(room1.Center), out point2));
  }

  private class HallwayCalculator
  {
    private readonly DungeonData data;
    private readonly List<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry> rooms;
    private readonly List<DungeonHall> halls = new List<DungeonHall>();
    private readonly List<DualDungeonLayoutProvider.HallwayCalculator.HallLine> stairwells = new List<DualDungeonLayoutProvider.HallwayCalculator.HallLine>();
    private readonly DitherSnake controlLines;
    private readonly double maxProgressDelta;
    private readonly double avgLineLength;
    private readonly double extraNearbyRoomSearchRadius = 50.0;

    public HallwayCalculator(DungeonData data, List<DungeonRoom> rooms)
    {
      this.data = data;
      this.rooms = rooms.Select<DungeonRoom, DualDungeonLayoutProvider.HallwayCalculator.RoomEntry>((Func<DungeonRoom, DualDungeonLayoutProvider.HallwayCalculator.RoomEntry>) (r => new DualDungeonLayoutProvider.HallwayCalculator.RoomEntry()
      {
        room = r,
        progressAlongSnake = data.genVars.dungeonDitherSnake.GetPositionAlongSnake(Vector2D.op_Implicit(r.Center))
      })).OrderBy<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry, double>((Func<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry, double>) (r => r.progressAlongSnake)).ToList<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry>();
      this.controlLines = data.genVars.dungeonDitherSnake;
      this.avgLineLength = this.controlLines.Average<DungeonControlLine>((Func<DungeonControlLine, double>) (l => l.LineLength));
      this.maxProgressDelta = 300.0 / this.avgLineLength;
    }

    public List<DungeonHall> Generate()
    {
      int hallRadius1 = 25;
      int hallRadius2 = 8;
      foreach (DualDungeonLayoutProvider.HallwayCalculator.RoomEntry source in this.rooms.Skip<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry>(2))
      {
        if (WorldGen.genRand.Next(2) == 0)
        {
          double bestScore;
          DualDungeonLayoutProvider.HallwayCalculator.HallLine line = this.SelectGoodRoomForHallway(source, out bestScore, new Func<DualDungeonLayoutProvider.HallwayCalculator.HallLine, double>(this.ScoreStairwell), hallRadius1);
          if (line != null && bestScore > 0.0)
            this.MakeHall(line, DungeonHallType.Stairwell);
        }
      }
      foreach (DualDungeonLayoutProvider.HallwayCalculator.RoomEntry source in this.rooms.Skip<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry>(1))
      {
        if (!source.backLinks.Any<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry>())
        {
          int num = 0;
          DualDungeonLayoutProvider.HallwayCalculator.HallLine line;
          while (true)
          {
            line = this.SelectGoodRoomForHallway(source, out double _, new Func<DualDungeonLayoutProvider.HallwayCalculator.HallLine, double>(this.ScoreHallway), hallRadius2);
            if (line == null)
            {
              if (num != 1000)
                ++num;
              else
                goto label_17;
            }
            else
              break;
          }
          this.MakeHall(line, DualDungeonLayoutProvider.DualDungeonLayout_GetGeneralHallType(WorldGen.genRand));
        }
label_17:
        if (WorldGen.genRand.Next(2) == 0)
        {
          double bestScore;
          DualDungeonLayoutProvider.HallwayCalculator.HallLine line = this.SelectGoodRoomForHallway(source, out bestScore, new Func<DualDungeonLayoutProvider.HallwayCalculator.HallLine, double>(this.ScoreHallway), hallRadius2);
          if (line != null && bestScore > -2.0)
            this.MakeHall(line, DualDungeonLayoutProvider.DualDungeonLayout_GetGeneralHallType(WorldGen.genRand));
        }
      }
      return this.halls;
    }

    private void MakeHall(
      DualDungeonLayoutProvider.HallwayCalculator.HallLine line,
      DungeonHallType hallType)
    {
      DungeonGenerationStyleData style = this.data.genVars.dungeonDitherSnake.GetLineContaining(line.sourcePoint).Style;
      DungeonHallSettings hallSettings = DungeonCrawler.MakeDungeon_GetHallSettings(hallType, this.data, line.sourcePoint.ToVector2(), line.targetPoint.ToVector2(), style);
      if (DualDungeonLayoutProvider.HallwayCalculator.IsBiomeRoom(line.target))
        hallSettings.CarveOnly = true;
      DungeonHall hall = DungeonCrawler.MakeDungeon_GetHall(hallSettings);
      hall.CalculateHall(this.data, line.sourcePoint, line.targetPoint);
      this.halls.Add(hall);
      line.source.backLinks.Add(line.target);
      line.target.forwardLinks.Add(line.source);
      if (hallType != DungeonHallType.Stairwell)
        return;
      this.stairwells.Add(line);
    }

    private double ScoreHallway(
      DualDungeonLayoutProvider.HallwayCalculator.HallLine line)
    {
      double num1 = 0.0;
      double fromMin = Math.Sin(7.0 * Math.PI / 36.0);
      Vector2D v = Vector2D.op_Subtraction(line.targetPoint, line.sourcePoint);
      Vector2D vector2D = v.SafeNormalize(Vector2D.UnitX);
      double num2 = num1 - Utils.Remap(Math.Abs(vector2D.Y), fromMin, 0.0, 0.0, 1.0) - Utils.Remap(Math.Abs(vector2D.Y), fromMin, 1.0, 0.0, 5.0) - Utils.Remap(((Vector2D) ref v).Length(), this.avgLineLength * 1.5, this.avgLineLength * 3.0, 0.0, 3.0) - (double) Utils.Remap((float) line.target.forwardLinks.Count, 1f, 3f, 0.0f, 2f) - (double) Utils.Remap((float) line.source.backLinks.Count, 1f, 3f, 0.0f, 2f) + (double) Utils.Remap((float) this.DistanceFromCommonAncestor(line.source, line.target), 3f, 6f, 0.0f, 1f);
      if (DualDungeonLayoutProvider.HallwayCalculator.IsBiomeRoom(line.target) && line.target.forwardLinks.Any<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry>() || DualDungeonLayoutProvider.HallwayCalculator.IsBiomeRoom(line.source) && line.source.backLinks.Any<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry>())
        num2 -= 5.0;
      if (DualDungeonLayoutProvider.HallwayCalculator.IsBiomeRoom(line.target) || DualDungeonLayoutProvider.HallwayCalculator.IsBiomeRoom(line.source))
        num2 -= Utils.Remap(Math.Abs(vector2D.Y), 0.6, 0.8, 0.0, 5.0);
      return num2;
    }

    private double ScoreStairwell(
      DualDungeonLayoutProvider.HallwayCalculator.HallLine line)
    {
      Vector2D v = Vector2D.op_Subtraction(line.targetPoint, line.sourcePoint);
      double num = 0.0 - Utils.Remap(Math.Abs(v.SafeNormalize(Vector2D.UnitX).Y), 0.6, 1.0, 1.0, 0.0) - Utils.Remap(((Vector2D) ref v).Length(), this.avgLineLength * 0.5, this.avgLineLength * 1.5, 1.0, 0.0);
      if (line.target.backLinks.Any<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry>() || line.target.forwardLinks.Any<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry>())
        num -= 5.0;
      if (DualDungeonLayoutProvider.HallwayCalculator.IsBiomeRoom(line.source) || DualDungeonLayoutProvider.HallwayCalculator.IsBiomeRoom(line.target))
        num -= 5.0;
      return num;
    }

    private DualDungeonLayoutProvider.HallwayCalculator.HallLine SelectGoodRoomForHallway(
      DualDungeonLayoutProvider.HallwayCalculator.RoomEntry source,
      out double bestScore,
      Func<DualDungeonLayoutProvider.HallwayCalculator.HallLine, double> scoreFunc,
      int hallRadius)
    {
      UnifiedRandom genRand = WorldGen.genRand;
      IEnumerable<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry> source1 = this.rooms.Skip<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry>(Math.Min(this.rooms.FindIndex((Predicate<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry>) (r => r.progressAlongSnake >= source.progressAlongSnake - this.maxProgressDelta)), Math.Max(0, this.rooms.IndexOf(source) - 2))).TakeWhile<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry>((Func<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry, bool>) (r => r != source));
      double nearbyRoomSearchRadius = source1.Select<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry, double>((Func<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry, double>) (r => Vector2D.Distance(Vector2D.op_Implicit(r.Center), Vector2D.op_Implicit(source.Center)))).Max() + this.extraNearbyRoomSearchRadius;
      List<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry> list = this.rooms.Where<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry>((Func<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry, bool>) (r => r != source && Vector2D.Distance(Vector2D.op_Implicit(r.Center), Vector2D.op_Implicit(source.Center)) <= nearbyRoomSearchRadius)).ToList<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry>();
      DualDungeonLayoutProvider.HallwayCalculator.HallLine hallLine1 = (DualDungeonLayoutProvider.HallwayCalculator.HallLine) null;
      bestScore = double.MinValue;
      foreach (DualDungeonLayoutProvider.HallwayCalculator.RoomEntry b in source1)
      {
        if (this.CanConnect(source, b))
        {
          double num1 = genRand.NextDouble();
          DualDungeonLayoutProvider.HallwayCalculator.HallLine hallLine2 = new DualDungeonLayoutProvider.HallwayCalculator.HallLine()
          {
            source = source,
            target = b
          };
          ConnectionPointQuality connectionPoints = DualDungeonLayoutProvider.GetHallwayConnectionPoints(source.room, b.room, out hallLine2.sourcePoint, out hallLine2.targetPoint);
          double num2 = num1;
          int num3;
          switch (connectionPoints)
          {
            case ConnectionPointQuality.Okay:
              num3 = 2;
              break;
            case ConnectionPointQuality.Bad:
              num3 = 10;
              break;
            default:
              num3 = 0;
              break;
          }
          double num4 = (double) num3;
          double num5 = num2 - num4 + scoreFunc(hallLine2);
          if (num5 > bestScore)
          {
            foreach (DualDungeonLayoutProvider.HallwayCalculator.RoomEntry roomEntry in list)
            {
              if (roomEntry != b)
              {
                Vector2D vector2D = Vector2D.op_Implicit(roomEntry.Center).ClosestPointOnLine(hallLine2.sourcePoint, hallLine2.targetPoint);
                double num6 = vector2D.Distance(Vector2D.op_Implicit(roomEntry.Center)) - (double) roomEntry.room.settings.GetBoundingRadius() - (double) hallRadius;
                if (num6 < 0.0)
                  num5 += num6 / 4.0 - 3.0;
                if (roomEntry.room.OuterBounds.Contains(vector2D))
                  num5 -= 1000.0;
              }
            }
            foreach (DualDungeonLayoutProvider.HallwayCalculator.HallLine stairwell in this.stairwells)
            {
              if (Utils.LineSegmentsIntersect(hallLine2.sourcePoint, hallLine2.targetPoint, stairwell.sourcePoint, stairwell.targetPoint))
                num5 -= 3.0;
            }
            if (num5 > bestScore && this.controlLines.IsLineInsideBorder(hallLine2.sourcePoint, hallLine2.targetPoint, hallRadius))
            {
              hallLine1 = hallLine2;
              bestScore = num5;
            }
          }
        }
      }
      return hallLine1;
    }

    private int DistanceFromCommonAncestor(
      DualDungeonLayoutProvider.HallwayCalculator.RoomEntry a,
      DualDungeonLayoutProvider.HallwayCalculator.RoomEntry b)
    {
      HashSet<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry> source1 = new HashSet<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry>()
      {
        a
      };
      HashSet<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry> roomEntrySet = new HashSet<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry>()
      {
        b
      };
      HashSet<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry> source2 = new HashSet<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry>()
      {
        a
      };
      HashSet<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry> source3 = new HashSet<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry>()
      {
        b
      };
      for (int index = 0; index < 8; ++index)
      {
        if (source1.Any<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry>(new Func<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry, bool>(roomEntrySet.Contains)))
          return index;
        source2 = new HashSet<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry>(source2.SelectMany<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry, DualDungeonLayoutProvider.HallwayCalculator.RoomEntry>((Func<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry, IEnumerable<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry>>) (e => (IEnumerable<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry>) e.backLinks)));
        foreach (DualDungeonLayoutProvider.HallwayCalculator.RoomEntry roomEntry in source2)
          source1.Add(roomEntry);
        source3 = new HashSet<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry>(source3.SelectMany<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry, DualDungeonLayoutProvider.HallwayCalculator.RoomEntry>((Func<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry, IEnumerable<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry>>) (e => (IEnumerable<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry>) e.backLinks)));
        foreach (DualDungeonLayoutProvider.HallwayCalculator.RoomEntry roomEntry in source3)
          roomEntrySet.Add(roomEntry);
      }
      return 8;
    }

    private bool CanConnect(
      DualDungeonLayoutProvider.HallwayCalculator.RoomEntry a,
      DualDungeonLayoutProvider.HallwayCalculator.RoomEntry b)
    {
      if (a.backLinks.Contains(b) || b.backLinks.Contains(a))
        return false;
      return a.room.settings.ProgressionStage == b.room.settings.ProgressionStage || DualDungeonLayoutProvider.HallwayCalculator.IsBiomeRoom(a) || DualDungeonLayoutProvider.HallwayCalculator.IsBiomeRoom(b);
    }

    private static bool IsBiomeRoom(
      DualDungeonLayoutProvider.HallwayCalculator.RoomEntry entry)
    {
      return DualDungeonLayoutProvider.HallwayCalculator.IsBiomeRoom(entry.room.settings.RoomType);
    }

    private static bool IsBiomeRoom(DungeonRoomType roomType)
    {
      switch (roomType)
      {
        case DungeonRoomType.BiomeSquare:
        case DungeonRoomType.BiomeRugged:
        case DungeonRoomType.BiomeStructured:
          return true;
        default:
          return false;
      }
    }

    private class RoomEntry
    {
      public DungeonRoom room;
      public double progressAlongSnake;
      public List<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry> backLinks = new List<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry>();
      public List<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry> forwardLinks = new List<DualDungeonLayoutProvider.HallwayCalculator.RoomEntry>();

      public Point Center => this.room.Center;
    }

    private class HallLine
    {
      public DualDungeonLayoutProvider.HallwayCalculator.RoomEntry source;
      public DualDungeonLayoutProvider.HallwayCalculator.RoomEntry target;
      public Vector2D sourcePoint;
      public Vector2D targetPoint;
    }
  }
}
