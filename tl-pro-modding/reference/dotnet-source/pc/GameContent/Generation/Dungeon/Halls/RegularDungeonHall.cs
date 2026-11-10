// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Halls.RegularDungeonHall
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using ReLogic.Utilities;
using System;
using System.Collections.Generic;
using Terraria.GameContent.Generation.Dungeon.Rooms;
using Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Halls;

public class RegularDungeonHall(DungeonHallSettings settings) : DungeonHall(settings)
{
  public override void CalculatePlatformsAndDoors(DungeonData data)
  {
    if (!this.Processed)
      return;
    DungeonUtils.CalculatePlatformAndDoorsOnHallway(data, this.StartPosition, this.StartDirection.Y, this.settings.ForceStyleForDoorsAndPlatforms ? this.settings.StyleData : (DungeonGenerationStyleData) null);
    DungeonUtils.CalculatePlatformAndDoorsOnHallway(data, this.EndPosition, this.EndDirection.Y, this.settings.ForceStyleForDoorsAndPlatforms ? this.settings.StyleData : (DungeonGenerationStyleData) null);
  }

  public override void CalculateHall(DungeonData data, Vector2D startPoint, Vector2D endPoint)
  {
    this.calculated = false;
    this.RegularHall(data, startPoint, endPoint);
    this.calculated = true;
  }

  public override void GenerateHall(DungeonData data)
  {
    this.generated = false;
    this.RegularHall(data, this.StartPosition, this.EndPosition, true);
    this.generated = true;
  }

  public void RegularHall(
    DungeonData data,
    Vector2D startPoint,
    Vector2D endPoint,
    bool generating = false)
  {
    RegularDungeonHallSettings settings1 = (RegularDungeonHallSettings) this.settings;
    UnifiedRandom unifiedRandom = new UnifiedRandom(settings1.RandomSeed);
    ushort brickTileType = this.settings.StyleData.BrickTileType;
    ushort brickCrackedTileType = this.settings.StyleData.BrickCrackedTileType;
    ushort brickWallType = this.settings.StyleData.BrickWallType;
    Vector2D currentPoint = startPoint;
    bool crackedBricks = false;
    if (settings1.CrackedBrickChance > 0.0)
      crackedBricks = unifiedRandom.NextDouble() <= settings1.CrackedBrickChance;
    int innerBoundsSize = 3;
    int outerBoundsSize = 8;
    if (settings1.OverrideInnerBoundsSize > 0)
      innerBoundsSize = settings1.OverrideInnerBoundsSize;
    if (settings1.OverrideOuterBoundsSize > 0)
      outerBoundsSize = settings1.OverrideOuterBoundsSize;
    int num1 = innerBoundsSize + outerBoundsSize;
    Vector2D v = Vector2D.op_Subtraction(endPoint, startPoint);
    Vector2D vector2D1 = v.SafeNormalize(Vector2D.UnitX);
    int num2 = (int) Math.Ceiling(((Vector2D) ref v).Length() / ((Vector2D) ref vector2D1).Length());
    this.Bounds.SetBounds((int) startPoint.X, (int) startPoint.Y, (int) startPoint.X, (int) startPoint.Y);
    Vector2D startPos = startPoint;
    Vector2D endPos = endPoint;
    DungeonRoomSearchSettings settings2 = new DungeonRoomSearchSettings()
    {
      Fluff = num1
    };
    List<DungeonRoom> allRoomsInSpots = DungeonUtils.GetAllRoomsInSpots(data.dungeonRooms, startPos, endPos, settings2);
    Vector2D vector2D2 = vector2D1;
    for (; num2 > 0 && WorldGen.InWorld((int) (currentPoint.X + vector2D1.X), (int) (currentPoint.Y + vector2D1.Y), 10); --num2)
    {
      if (!this.Processed)
      {
        data.dungeonBounds.UpdateBounds((int) currentPoint.X - num1, (int) currentPoint.Y - num1, (int) currentPoint.Y + num1, (int) currentPoint.Y + num1);
        this.Bounds.UpdateBounds((int) currentPoint.X - num1, (int) currentPoint.Y - num1, (int) currentPoint.Y + num1, (int) currentPoint.Y + num1);
      }
      if (generating)
        this.GenerateDungeonSquareHall(data, allRoomsInSpots, currentPoint, brickTileType, brickCrackedTileType, brickWallType, innerBoundsSize, outerBoundsSize, settings1.PlaceOverProtectedBricks, crackedBricks);
      currentPoint = Vector2D.op_Addition(currentPoint, vector2D1);
    }
    data.genVars.generatingDungeonPositionX = (int) endPoint.X;
    data.genVars.generatingDungeonPositionY = (int) endPoint.Y;
    this.StartPosition = startPoint;
    this.EndPosition = endPoint;
    this.StartDirection = new Vector2D(vector2D2.X, vector2D2.Y);
    this.EndDirection = new Vector2D(vector2D1.X, vector2D1.Y);
    this.CrackedBrick = crackedBricks;
    this.Bounds.CalculateHitbox();
  }
}
