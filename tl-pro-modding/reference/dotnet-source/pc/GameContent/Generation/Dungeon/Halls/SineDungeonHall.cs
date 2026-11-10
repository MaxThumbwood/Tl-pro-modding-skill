// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Halls.SineDungeonHall
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using System;
using System.Collections.Generic;
using Terraria.GameContent.Generation.Dungeon.Rooms;
using Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Halls;

public class SineDungeonHall(DungeonHallSettings settings) : DungeonHall(settings)
{
  public List<Tuple<Vector2D, Vector2D>> PotentialPlatformPoints = new List<Tuple<Vector2D, Vector2D>>();

  public override void CalculatePlatformsAndDoors(DungeonData data)
  {
    if (!this.Processed)
      return;
    DungeonUtils.CalculatePlatformAndDoorsOnHallway(data, this.StartPosition, this.StartDirection.Y, this.settings.ForceStyleForDoorsAndPlatforms ? this.settings.StyleData : (DungeonGenerationStyleData) null);
    DungeonUtils.CalculatePlatformAndDoorsOnHallway(data, this.EndPosition, this.EndDirection.Y, this.settings.ForceStyleForDoorsAndPlatforms ? this.settings.StyleData : (DungeonGenerationStyleData) null);
    float num = 0.65f;
    for (int index = 0; index < this.PotentialPlatformPoints.Count; ++index)
    {
      Tuple<Vector2D, Vector2D> potentialPlatformPoint = this.PotentialPlatformPoints[index];
      Vector2D hallwayPoint = potentialPlatformPoint.Item1;
      Vector2D vector2D = potentialPlatformPoint.Item2;
      if (vector2D.Y >= (double) num || vector2D.Y <= -(double) num)
        DungeonUtils.CalculatePlatformAndDoorsOnHallway(data, hallwayPoint, vector2D.Y, this.settings.ForceStyleForDoorsAndPlatforms ? this.settings.StyleData : (DungeonGenerationStyleData) null);
    }
  }

  public override void CalculateHall(DungeonData data, Vector2D startPoint, Vector2D endPoint)
  {
    this.calculated = false;
    this.SineHall(data, startPoint, endPoint);
    this.calculated = true;
  }

  public override void GenerateHall(DungeonData data)
  {
    this.generated = false;
    this.SineHall(data, this.StartPosition, this.EndPosition, true);
    this.generated = true;
  }

  public void SineHall(DungeonData data, Vector2D startPoint, Vector2D endPoint, bool generating = false)
  {
    SineDungeonHallSettings settings1 = (SineDungeonHallSettings) this.settings;
    UnifiedRandom unifiedRandom = new UnifiedRandom(settings1.RandomSeed);
    ushort brickTileType = this.settings.StyleData.BrickTileType;
    ushort brickCrackedTileType = this.settings.StyleData.BrickCrackedTileType;
    ushort brickWallType = this.settings.StyleData.BrickWallType;
    Vector2D vector2D1 = startPoint;
    bool crackedBricks = false;
    if (settings1.CrackedBrickChance > 0.0)
      crackedBricks = unifiedRandom.NextDouble() <= settings1.CrackedBrickChance;
    int innerBoundsSize = 3;
    int outerBoundsSize = 8;
    int num1 = innerBoundsSize + outerBoundsSize;
    Vector2D v1 = Vector2D.op_Subtraction(endPoint, startPoint);
    Vector2D vector2D2 = v1.SafeNormalize(Vector2D.UnitX);
    int num2 = (int) Math.Ceiling(((Vector2D) ref v1).Length() / ((Vector2D) ref vector2D2).Length());
    int num3 = num2;
    this.Bounds.SetBounds((int) startPoint.X, (int) startPoint.Y, (int) startPoint.X, (int) startPoint.Y);
    Vector2D startPos = startPoint;
    Vector2D endPos = endPoint;
    DungeonRoomSearchSettings settings2 = new DungeonRoomSearchSettings()
    {
      Fluff = (int) ((double) innerBoundsSize * (double) settings1.Magnitude) + outerBoundsSize
    };
    List<DungeonRoom> allRoomsInSpots = DungeonUtils.GetAllRoomsInSpots(data.dungeonRooms, startPos, endPos, settings2);
    Vector2D v2 = vector2D2;
    Vector2D vector2D3 = (Vector2.UnitY * settings1.Magnitude).ToVector2D().ToVector2().RotatedBy(v2.ToRotation(), Vector2.Zero).ToVector2D();
    float num4 = 0.0f;
    float a = 0.0f;
    float num5 = (float) ((double) settings1.Iterations / (double) num3 * 6.2831854820251465);
    for (; num2 > 0; --num2)
    {
      Vector2D vector2D4 = Vector2D.op_Multiply(vector2D3, Math.Sin((double) a));
      Vector2D currentPoint = settings1.FlipSine ? Vector2D.op_Subtraction(vector2D1, vector2D4) : Vector2D.op_Addition(vector2D1, vector2D4);
      if (WorldGen.InWorld((int) (currentPoint.X + vector2D2.X), (int) (currentPoint.Y + vector2D2.Y), 10))
      {
        if (!this.Processed)
        {
          data.dungeonBounds.UpdateBounds((int) currentPoint.X - num1, (int) currentPoint.Y - num1, (int) currentPoint.Y + num1, (int) currentPoint.Y + num1);
          this.Bounds.UpdateBounds((int) currentPoint.X - num1, (int) currentPoint.Y - num1, (int) currentPoint.Y + num1, (int) currentPoint.Y + num1);
        }
        if (generating)
          this.GenerateDungeonSquareHall(data, allRoomsInSpots, currentPoint, brickTileType, brickCrackedTileType, brickWallType, innerBoundsSize, outerBoundsSize, settings1.PlaceOverProtectedBricks, crackedBricks);
        vector2D1 = Vector2D.op_Addition(vector2D1, vector2D2);
        num4 += num5;
        a += num5;
        if ((double) num4 >= 0.5)
        {
          num4 = 0.0f;
          this.PotentialPlatformPoints.Add(new Tuple<Vector2D, Vector2D>(vector2D1, vector2D4));
        }
      }
      else
        break;
    }
    data.genVars.generatingDungeonPositionX = (int) endPoint.X;
    data.genVars.generatingDungeonPositionY = (int) endPoint.Y;
    this.StartPosition = startPoint;
    this.EndPosition = endPoint;
    this.StartDirection = new Vector2D(v2.X, v2.Y);
    this.EndDirection = new Vector2D(vector2D2.X, vector2D2.Y);
    this.CrackedBrick = crackedBricks;
    this.Bounds.CalculateHitbox();
  }
}
