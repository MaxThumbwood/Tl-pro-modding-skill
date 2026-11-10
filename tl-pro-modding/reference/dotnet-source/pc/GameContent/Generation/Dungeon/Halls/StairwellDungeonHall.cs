// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Halls.StairwellDungeonHall
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

public class StairwellDungeonHall(StairwellDungeonHallSettings settings) : DungeonHall((DungeonHallSettings) settings)
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
    this.Stairwell(data, startPoint, endPoint);
    this.calculated = true;
  }

  public override void GenerateHall(DungeonData data)
  {
    this.generated = false;
    this.Stairwell(data, this.StartPosition, this.EndPosition, true);
    this.generated = true;
  }

  public void Stairwell(DungeonData data, Vector2D startPoint, Vector2D endPoint, bool generating = false)
  {
    StairwellDungeonHallSettings settings = (StairwellDungeonHallSettings) this.settings;
    UnifiedRandom r = new UnifiedRandom(settings.RandomSeed);
    this.Bounds.SetBounds((int) startPoint.X, (int) startPoint.Y, (int) startPoint.X, (int) startPoint.Y);
    bool crackedBricks = false;
    if (settings.CrackedBrickChance > 0.0)
      crackedBricks = r.NextDouble() <= settings.CrackedBrickChance;
    int num1 = settings.InnerBoundsSize + settings.OuterBoundsSize;
    List<DungeonRoom> allRoomsInSpots = DungeonUtils.GetAllRoomsInSpots(data.dungeonRooms, startPoint, endPoint, new DungeonRoomSearchSettings()
    {
      Fluff = num1 + settings.MaxDistFromLine
    });
    Vector2D v1 = Vector2D.op_Subtraction(endPoint, startPoint);
    Vector2D zigZagSlope = this.CalculateZigZagSlope(startPoint, endPoint, settings.Gradient);
    double num2 = Math.Ceiling(Math.Abs(Vector2D.Cross(zigZagSlope, v1.SafeNormalize(new Vector2D()))) / (double) settings.MaxDistFromLine);
    Vector2D v2 = Vector2D.op_Division(zigZagSlope, num2);
    Vector2D startPoint1 = startPoint;
    for (int index = 0; (double) index < num2; ++index)
    {
      Vector2D vector2D1 = Vector2D.op_Addition(startPoint, Vector2D.op_Division(Vector2D.op_Multiply(v1, (double) index), num2));
      Vector2D vector2D2 = Vector2D.op_Addition(startPoint, Vector2D.op_Division(Vector2D.op_Multiply(v1, (double) (index + 1)), num2));
      Vector2D vector2D3 = v2;
      Vector2D vector2D4 = Vector2D.op_Addition(Vector2D.op_Addition(vector2D1, vector2D3), r.NextVector2DCircular((double) settings.PointVariance, (double) settings.PointVariance));
      Vector2D endPoint1 = Vector2D.op_Addition(Vector2D.op_Subtraction(vector2D2, v2), r.NextVector2DCircular((double) settings.PointVariance, (double) settings.PointVariance));
      this.GenerateHallway(data, startPoint1, vector2D4, allRoomsInSpots, crackedBricks, generating);
      this.GenerateHallway(data, vector2D4, endPoint1, allRoomsInSpots, crackedBricks, generating);
      startPoint1 = endPoint1;
    }
    this.GenerateHallway(data, startPoint1, endPoint, allRoomsInSpots, crackedBricks, generating);
    data.genVars.generatingDungeonPositionX = (int) endPoint.X;
    data.genVars.generatingDungeonPositionY = (int) endPoint.Y;
    this.StartPosition = startPoint;
    this.EndPosition = endPoint;
    this.StartDirection = this.EndDirection = v2.SafeNormalize(new Vector2D());
    this.CrackedBrick = crackedBricks;
    this.Bounds.CalculateHitbox();
  }

  private Vector2D CalculateZigZagSlope(Vector2D startPoint, Vector2D endPoint, double gradient)
  {
    Vector2D vector2D1 = Vector2D.op_Subtraction(endPoint, startPoint).SafeNormalize(Vector2D.UnitY);
    Vector2D vector2D2 = new Vector2D(vector2D1.X > 0.0 ? 1.0 : -1.0, gradient).SafeNormalize(new Vector2D());
    double num = Vector2D.Distance(startPoint, endPoint) * (vector2D1.X / vector2D2.X + vector2D1.Y / vector2D2.Y) / 4.0;
    return Vector2D.op_Multiply(vector2D2, num);
  }

  private void GenerateHallway(
    DungeonData data,
    Vector2D startPoint,
    Vector2D endPoint,
    List<DungeonRoom> roomsInArea,
    bool crackedBricks,
    bool generating)
  {
    ushort brickTileType = this.settings.StyleData.BrickTileType;
    ushort brickCrackedTileType = this.settings.StyleData.BrickCrackedTileType;
    ushort brickWallType = this.settings.StyleData.BrickWallType;
    StairwellDungeonHallSettings settings = (StairwellDungeonHallSettings) this.settings;
    int innerBoundsSize = settings.InnerBoundsSize;
    int outerBoundsSize = settings.OuterBoundsSize;
    int num1 = innerBoundsSize + outerBoundsSize;
    Vector2D vector2D = Vector2D.op_Subtraction(endPoint, startPoint);
    double num2 = Math.Ceiling(Math.Max(Math.Abs(vector2D.X), Math.Abs(vector2D.Y)));
    for (int index = 0; (double) index < num2; ++index)
    {
      Vector2D currentPoint = Vector2D.op_Addition(startPoint, Vector2D.op_Multiply(vector2D, (double) index / num2));
      if (!this.Processed)
      {
        data.dungeonBounds.UpdateBounds((int) currentPoint.X - num1, (int) currentPoint.Y - num1, (int) currentPoint.Y + num1, (int) currentPoint.Y + num1);
        this.Bounds.UpdateBounds((int) currentPoint.X - num1, (int) currentPoint.Y - num1, (int) currentPoint.Y + num1, (int) currentPoint.Y + num1);
      }
      if (generating)
        this.GenerateDungeonSquareHall(data, roomsInArea, currentPoint, brickTileType, brickCrackedTileType, brickWallType, innerBoundsSize, outerBoundsSize, settings.PlaceOverProtectedBricks, crackedBricks, settings.IsEntranceHall);
    }
  }

  public override bool CanPlaceTileAt(
    DungeonData data,
    Tile tile,
    int tileType,
    int tileCrackedType)
  {
    return (!((StairwellDungeonHallSettings) this.settings).IsEntranceHall || (!tile.active() || !Main.tileDungeon[(int) tile.type]) && !Main.wallDungeon[(int) tile.wall]) && base.CanPlaceTileAt(data, tile, tileType, tileCrackedType);
  }
}
