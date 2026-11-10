// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Rooms.WormlikeDungeonRoom
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria.Utilities;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Rooms;

public class WormlikeDungeonRoom(DungeonRoomSettings settings) : DungeonRoom(settings)
{
  private ShapeData _innerShapeData = new ShapeData();
  private ShapeData _outerShapeData = new ShapeData();
  private int _floodedTileCount;
  public int InnerBoundsSizeMin;
  public int InnerBoundsSizeMax;
  public Vector2[] Positions;

  public override void CalculateRoom(DungeonData data)
  {
    this.calculated = false;
    int x = this.settings.RoomPosition.X;
    int y = this.settings.RoomPosition.Y;
    this.WormlikeRoom(data, x, y, false);
    this.calculated = true;
  }

  public override bool GenerateRoom(DungeonData data)
  {
    this.generated = false;
    int x = this.settings.RoomPosition.X;
    int y = this.settings.RoomPosition.Y;
    this.WormlikeRoom(data, x, y, true);
    this.generated = true;
    return true;
  }

  public override int GetFloodedRoomTileCount() => this._floodedTileCount;

  public override void FloodRoom(byte liquidType)
  {
    if (this._innerShapeData == null || this.Positions == null)
    {
      base.FloodRoom(liquidType);
    }
    else
    {
      WormlikeDungeonRoomSettings settings = (WormlikeDungeonRoomSettings) this.settings;
      WorldUtils.Gen(this.Positions[0].ToPoint(), (GenShape) new ModShapes.All(this._innerShapeData), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.IsBelowHeight(this.Center.Y, true), (GenAction) new Modifiers.IsNotSolid(), (GenAction) new Terraria.WorldBuilding.Actions.SetLiquid((int) liquidType)));
    }
  }

  public override ProtectionType GetProtectionTypeFromPoint(int x, int y)
  {
    if (this._innerShapeData == null || this._outerShapeData == null || this.Positions == null || this.calculated && !this.OuterBounds.Contains(x, y))
      return base.GetProtectionTypeFromPoint(x, y);
    Point point = this.Positions[0].ToPoint();
    return !this._outerShapeData.Contains(x - point.X, y - point.Y) ? ProtectionType.None : ProtectionType.Walls;
  }

  public override bool IsInsideRoom(int x, int y)
  {
    if (this.Positions == null)
      return base.IsInsideRoom(x, y);
    Point point = this.Positions[0].ToPoint();
    return base.IsInsideRoom(x, y) && this._innerShapeData.Contains(x - point.X, y - point.Y);
  }

  public void WormlikeRoom(DungeonData data, int i, int j, bool generating)
  {
    UnifiedRandom r = new UnifiedRandom(this.settings.RandomSeed);
    WormlikeDungeonRoomSettings settings = (WormlikeDungeonRoomSettings) this.settings;
    ushort brickTileType = this.settings.StyleData.BrickTileType;
    ushort brickCrackedTileType = this.settings.StyleData.BrickCrackedTileType;
    ushort brickWallType = this.settings.StyleData.BrickWallType;
    Point p = new Point(i, j);
    if (this.Processed)
      p = this.Positions[0].ToPoint();
    int num1 = 9 + r.Next(3);
    int num2 = Math.Max(4, num1 / 5);
    if (this.Processed)
    {
      num1 = this.InnerBoundsSizeMax;
      num2 = this.InnerBoundsSizeMin;
    }
    int outerBoundsSize = 8;
    int num3 = num1 + outerBoundsSize;
    this.InnerBounds.SetBounds(p.X, p.Y, p.X, p.Y);
    this.OuterBounds.SetBounds(p.X, p.Y, p.X, p.Y);
    Vector2 vector2_1 = p.ToVector2();
    List<Vector2> source = new List<Vector2>();
    if (this.Processed)
      source.AddRange((IEnumerable<Vector2>) this.Positions);
    Vector2 v1 = vector2_1;
    Vector2 vector2_2 = r.NextVector2CircularEdge(1f, 1f);
    Vector2 spinningpoint1 = vector2_2;
    int firstSideIterations = settings.FirstSideIterations;
    int index1 = 0;
    for (int index2 = 0; index2 < firstSideIterations; ++index2)
    {
      float amount = (float) index2 / (float) firstSideIterations;
      int innerBoundsSize = (int) Utils.Lerp((double) num1, (double) num2, (double) amount);
      int num4 = innerBoundsSize + outerBoundsSize;
      Point point = v1.ToPoint();
      this.OuterBounds.UpdateBounds(point.X - num4, point.Y - num4, point.X + num4, point.Y + num4);
      this.InnerBounds.UpdateBounds(point.X - innerBoundsSize, point.Y - innerBoundsSize, point.X + innerBoundsSize, point.Y + innerBoundsSize);
      this._outerShapeData.AddBounds(point.X - num4 - (int) vector2_1.X, point.Y - num4 - (int) vector2_1.Y, point.X + num4 - (int) vector2_1.X, point.Y + num4 - (int) vector2_1.Y);
      this._innerShapeData.AddBounds(point.X - innerBoundsSize - (int) vector2_1.X, point.Y - innerBoundsSize - (int) vector2_1.Y, point.X + innerBoundsSize - (int) vector2_1.X, point.Y + innerBoundsSize - (int) vector2_1.Y);
      if (!this.Processed)
        source.Add(v1);
      if (generating)
        this.GenerateDungeonSquareRoom(data, Vector2D.op_Implicit(point), brickTileType, brickCrackedTileType, brickWallType, innerBoundsSize, outerBoundsSize);
      if (this.Processed)
      {
        ++index1;
        if (index1 < this.Positions.Length)
          v1 = this.Positions[index1];
      }
      else
      {
        v1 += vector2_2;
        vector2_2 = spinningpoint1.RotatedBy(Utils.Lerp(0.0, 1.5707963705062866, (double) amount));
      }
    }
    Vector2 v2 = vector2_1;
    Vector2 vector2_3 = spinningpoint1.RotatedBy(3.1415927410125732, Vector2.Zero).RotatedByRandom(0.78539818525314331);
    Vector2 spinningpoint2 = vector2_3;
    int secondSideIterations = settings.SecondSideIterations;
    for (int index3 = 0; index3 < secondSideIterations; ++index3)
    {
      float amount = (float) index3 / (float) secondSideIterations;
      int innerBoundsSize = (int) Utils.Lerp((double) num1, (double) num2, (double) amount);
      int num5 = innerBoundsSize + outerBoundsSize;
      Point point = v2.ToPoint();
      this.OuterBounds.UpdateBounds(point.X - num5, point.Y - num5, point.X + num5, point.Y + num5);
      this.InnerBounds.UpdateBounds(point.X - innerBoundsSize, point.Y - innerBoundsSize, point.X + innerBoundsSize, point.Y + innerBoundsSize);
      this._outerShapeData.AddBounds(point.X - num5 - (int) vector2_1.X, point.Y - num5 - (int) vector2_1.Y, point.X + num5 - (int) vector2_1.X, point.Y + num5 - (int) vector2_1.Y);
      this._innerShapeData.AddBounds(point.X - innerBoundsSize - (int) vector2_1.X, point.Y - innerBoundsSize - (int) vector2_1.Y, point.X + innerBoundsSize - (int) vector2_1.X, point.Y + innerBoundsSize - (int) vector2_1.Y);
      if (!this.Processed)
        source.Add(v2);
      if (generating)
        this.GenerateDungeonSquareRoom(data, Vector2D.op_Implicit(point), brickTileType, brickCrackedTileType, brickWallType, innerBoundsSize, outerBoundsSize);
      if (this.Processed)
      {
        ++index1;
        if (index1 < this.Positions.Length)
          v2 = this.Positions[index1];
      }
      else
      {
        v2 += vector2_3;
        vector2_3 = spinningpoint2.RotatedBy(Utils.Lerp(0.0, 1.5707963705062866, (double) amount));
      }
    }
    this.Positions = source.ToArray<Vector2>();
    this.InnerBoundsSizeMin = num2;
    this.InnerBoundsSizeMax = num1;
    this.InnerBounds.CalculateHitbox();
    this.OuterBounds.CalculateHitbox();
    this._floodedTileCount = DungeonUtils.CalculateFloodedTileCountFromShapeData(this.InnerBounds, this._innerShapeData);
  }
}
