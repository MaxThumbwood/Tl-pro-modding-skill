// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Rooms.GenShapeDungeonRoom
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using System;
using Terraria.GameContent.Generation.Dungeon.Features;
using Terraria.Utilities;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Rooms;

public class GenShapeDungeonRoom(DungeonRoomSettings settings) : DungeonRoom(settings)
{
  private ShapeData _innerShapeData = new ShapeData();
  private ShapeData _outerShapeData = new ShapeData();
  private int _floodedTileCount;

  public override void CalculateRoom(DungeonData data)
  {
    this.calculated = false;
    int x = this.settings.RoomPosition.X;
    int y = this.settings.RoomPosition.Y;
    this.GenShapeRoom(data, x, y, false);
    this.calculated = true;
  }

  public override bool GenerateRoom(DungeonData data)
  {
    this.generated = false;
    int x = this.settings.RoomPosition.X;
    int y = this.settings.RoomPosition.Y;
    this.GenShapeRoom(data, x, y, true);
    this.generated = true;
    return true;
  }

  public override bool CanGenerateFeatureAt(
    DungeonData data,
    IDungeonFeature feature,
    int x,
    int y)
  {
    switch (((GenShapeDungeonRoomSettings) this.settings).ShapeType)
    {
      case GenShapeType.Hourglass:
      case GenShapeType.Doughnut:
        if (feature is DungeonWindow)
          return false;
        break;
    }
    return base.CanGenerateFeatureAt(data, feature, x, y);
  }

  public override void GenerateEarlyDungeonFeaturesInRoom(DungeonData data)
  {
    GenShapeDungeonRoomSettings settings = (GenShapeDungeonRoomSettings) this.settings;
    if (settings.ShapeType == GenShapeType.Doughnut)
    {
      DungeonShapes.CircleRoom innerShape = (DungeonShapes.CircleRoom) settings.InnerShape;
      GenAction genAction = (GenAction) new Terraria.WorldBuilding.Actions.Blank();
      if (settings.OverridePaintTile == 0)
        genAction = (GenAction) new Terraria.WorldBuilding.Actions.ClearTilePaint();
      else if (settings.OverridePaintTile > 0)
        genAction = (GenAction) new Terraria.WorldBuilding.Actions.SetTilePaint((byte) settings.OverridePaintTile);
      WorldUtils.Gen(this.InnerBounds.Center, (GenShape) new DungeonShapes.CircleRoom(Math.Max(1, innerShape.HorizontalRadius / 2), Math.Max(1, innerShape.VerticalRadius / 2)), Terraria.WorldBuilding.Actions.Chain((GenAction) new Terraria.WorldBuilding.Actions.ClearTile(), (GenAction) new Terraria.WorldBuilding.Actions.SetTile(settings.StyleData.BrickTileType, setNeighborFrames: false, clearTile: false), genAction));
    }
    base.GenerateEarlyDungeonFeaturesInRoom(data);
  }

  public override Point GetRoomCenterForDungeonFeature(DungeonData data, DungeonFeature feature)
  {
    GenShapeDungeonRoomSettings settings = (GenShapeDungeonRoomSettings) this.settings;
    Point forDungeonFeature = base.GetRoomCenterForDungeonFeature(data, feature);
    if (feature is DungeonWindow && settings.ShapeType == GenShapeType.Mound)
      forDungeonFeature.Y += this.InnerBounds.Height / 5;
    return forDungeonFeature;
  }

  public override Point GetRoomCenterForHallway(Vector2D otherRoomPos)
  {
    GenShapeDungeonRoomSettings settings = (GenShapeDungeonRoomSettings) this.settings;
    Vector2D vector2D1 = base.GetRoomCenterForHallway(otherRoomPos).ToVector2D();
    Vector2D unitX = Vector2D.UnitX;
    if (settings.RoomType != DungeonRoomType.GenShapeDoughnut)
      return vector2D1.ToPoint();
    Vector2D vector2D2 = Vector2D.op_Subtraction(otherRoomPos, vector2D1).SafeNormalize(Vector2D.UnitX);
    return Vector2D.op_Addition(vector2D1, Vector2D.op_Multiply(vector2D2, (double) (this.InnerBounds.Size / 2))).ToPoint() with
    {
      X = (int) (vector2D1.X + vector2D2.X * (double) (this.InnerBounds.Width / 2)),
      Y = (int) (vector2D1.Y + vector2D2.Y * (double) (this.InnerBounds.Height / 2))
    };
  }

  public override int GetFloodedRoomTileCount() => this._floodedTileCount;

  public override void FloodRoom(byte liquidType)
  {
    WorldUtils.Gen(this.InnerBounds.Center, ((GenShapeDungeonRoomSettings) this.settings).InnerShape, Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.IsBelowHeight(this.InnerBounds.Center.Y, true), (GenAction) new Modifiers.IsNotSolid(), (GenAction) new Terraria.WorldBuilding.Actions.SetLiquid((int) liquidType)));
  }

  public override ProtectionType GetProtectionTypeFromPoint(int x, int y)
  {
    if (this._innerShapeData == null || this._outerShapeData == null || this.calculated && !this.OuterBounds.Contains(x, y))
      return base.GetProtectionTypeFromPoint(x, y);
    return !this._outerShapeData.Contains(x - this.Center.X, y - this.Center.Y) ? ProtectionType.None : ProtectionType.Walls;
  }

  public override bool IsInsideRoom(int x, int y)
  {
    return base.IsInsideRoom(x, y) && this._innerShapeData.Contains(x - this.Center.X, y - this.Center.Y);
  }

  public void GenShapeRoom(DungeonData data, int i, int j, bool generating)
  {
    UnifiedRandom unifiedRandom = new UnifiedRandom(this.settings.RandomSeed);
    GenShapeDungeonRoomSettings settings = (GenShapeDungeonRoomSettings) this.settings;
    ushort brickTileType = this.settings.StyleData.BrickTileType;
    ushort brickWallType = this.settings.StyleData.BrickWallType;
    Vector2D v;
    // ISSUE: explicit constructor call
    ((Vector2D) ref v).\u002Ector((double) i, (double) j);
    if (this.Processed)
      v = Vector2D.op_Implicit(this.Center);
    this.InnerBounds.SetBounds((int) v.X, (int) v.Y, (int) v.X, (int) v.Y);
    this.OuterBounds.SetBounds((int) v.X, (int) v.Y, (int) v.X, (int) v.Y);
    GenAction genAction1 = (GenAction) new Terraria.WorldBuilding.Actions.Blank();
    if (settings.OverridePaintTile == 0)
      genAction1 = (GenAction) new Terraria.WorldBuilding.Actions.ClearTilePaint();
    else if (settings.OverridePaintTile > 0)
      genAction1 = (GenAction) new Terraria.WorldBuilding.Actions.SetTilePaint((byte) settings.OverridePaintTile);
    GenAction genAction2 = (GenAction) new Terraria.WorldBuilding.Actions.Blank();
    if (settings.OverridePaintWall == 0)
      genAction2 = (GenAction) new Terraria.WorldBuilding.Actions.ClearWallPaint();
    else if (settings.OverridePaintWall > 0)
      genAction2 = (GenAction) new Terraria.WorldBuilding.Actions.SetWallPaint((byte) settings.OverridePaintWall);
    WorldUtils.Gen(v.ToPoint(), settings.OuterShape, Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.Expand(1), new Terraria.WorldBuilding.Actions.UpdateBounds(data.dungeonBounds).Output(this._outerShapeData), (GenAction) new Terraria.WorldBuilding.Actions.UpdateBounds(this.OuterBounds), (GenAction) new Modifiers.Conditions(new GenCondition[1]
    {
      (GenCondition) new Conditions.BoolCheck(generating)
    }), (GenAction) new Terraria.WorldBuilding.Actions.ClearTile(), (GenAction) new Terraria.WorldBuilding.Actions.SetTile(brickTileType, setNeighborFrames: false, clearTile: false), genAction1));
    if (generating)
      WorldUtils.Gen(v.ToPoint(), settings.OuterShape, Terraria.WorldBuilding.Actions.Chain((GenAction) new Terraria.WorldBuilding.Actions.SetWall(brickWallType, setNeighborFrames: false, clearTile: false), genAction2));
    WorldUtils.Gen(v.ToPoint(), settings.InnerShape, Terraria.WorldBuilding.Actions.Chain(new Terraria.WorldBuilding.Actions.UpdateBounds(data.dungeonBounds).Output(this._innerShapeData), (GenAction) new Terraria.WorldBuilding.Actions.UpdateBounds(this.InnerBounds), (GenAction) new Modifiers.Conditions(new GenCondition[1]
    {
      (GenCondition) new Conditions.BoolCheck(generating)
    }), (GenAction) new Terraria.WorldBuilding.Actions.Clear(), (GenAction) new Terraria.WorldBuilding.Actions.SetWall(brickWallType, setNeighborFrames: false, clearTile: false), genAction2));
    this.InnerBounds.CalculateHitbox();
    this.OuterBounds.CalculateHitbox();
    this._floodedTileCount = DungeonUtils.CalculateFloodedTileCountFromShapeData(this.InnerBounds, this._innerShapeData);
  }
}
