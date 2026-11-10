// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Rooms.LegacyDungeonRoom
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using ReLogic.Utilities;
using System;
using Terraria.GameContent.Generation.Dungeon.Features;
using Terraria.Utilities;
using Terraria.WorldBuilding;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Rooms;

public class LegacyDungeonRoom(DungeonRoomSettings settings) : DungeonRoom(settings)
{
  private ShapeData _innerShapeData = new ShapeData();
  private ShapeData _outerShapeData = new ShapeData();
  private int _floodedTileCount;
  public Vector2D StartPosition;
  public Vector2D EndPosition;
  public int Strength;

  public override void CalculateRoom(DungeonData data)
  {
    this.calculated = false;
    int x = this.settings.RoomPosition.X;
    int y = this.settings.RoomPosition.Y;
    this.LegacyRoom(data, x, y, false);
    this.calculated = true;
  }

  public override bool GenerateRoom(DungeonData data)
  {
    this.generated = false;
    int x = this.settings.RoomPosition.X;
    int y = this.settings.RoomPosition.Y;
    this.LegacyRoom(data, x, y, true);
    this.generated = true;
    return true;
  }

  public override int GetFloodedRoomTileCount() => this._floodedTileCount;

  public override void FloodRoom(byte liquidType)
  {
    if (!this.generated || this._innerShapeData == null)
      return;
    WorldUtils.Gen(this.StartPosition.ToPoint(), (GenShape) new ModShapes.All(this._innerShapeData), Terraria.WorldBuilding.Actions.Chain((GenAction) new Modifiers.IsBelowHeight(this.InnerBounds.Center.Y, true), (GenAction) new Modifiers.IsNotSolid(), (GenAction) new Terraria.WorldBuilding.Actions.SetLiquid((int) liquidType)));
  }

  public override ProtectionType GetProtectionTypeFromPoint(int x, int y)
  {
    if (this._innerShapeData == null || this._outerShapeData == null || this.calculated && !this.OuterBounds.Contains(x, y))
      return base.GetProtectionTypeFromPoint(x, y);
    return !this._outerShapeData.Contains(x - (int) this.StartPosition.X, y - (int) this.StartPosition.Y) ? ProtectionType.None : ProtectionType.Walls;
  }

  public override bool IsInsideRoom(int x, int y)
  {
    return base.IsInsideRoom(x, y) && this._innerShapeData.Contains(x - (int) this.StartPosition.X, y - (int) this.StartPosition.Y);
  }

  public override bool TryGenerateChestInRoom(DungeonData data, DungeonGlobalBasicChests feature)
  {
    Vector2D endPosition = this.EndPosition;
    int num = (int) ((double) this.Strength * 0.40000000596046448);
    return DungeonUtils.GenerateDungeonRegularChest(data, feature, this.settings.StyleData, (int) endPosition.X - num, (int) endPosition.Y - num, (int) endPosition.X + num, (int) endPosition.Y + num);
  }

  public override bool DualDungeons_TryGenerateBiomeChestInRoom(
    DungeonData data,
    DungeonGlobalBiomeChests feature)
  {
    Vector2D endPosition = this.EndPosition;
    int num = (int) ((double) this.Strength * 0.40000000596046448);
    return DungeonUtils.GenerateDungeonBiomeChest(data, feature, this.settings.StyleData, (int) endPosition.X - num, (int) endPosition.Y - num, (int) endPosition.X + num, (int) endPosition.Y + num);
  }

  public void LegacyRoom(DungeonData data, int i, int j, bool generating)
  {
    LegacyDungeonRoomSettings settings = (LegacyDungeonRoomSettings) this.settings;
    UnifiedRandom unifiedRandom = new UnifiedRandom(settings.RandomSeed);
    ushort brickTileType = this.settings.StyleData.BrickTileType;
    ushort brickWallType = this.settings.StyleData.BrickWallType;
    double num1 = data.roomStrengthScalar;
    if (settings.StartingRoom)
      num1 = 1.0;
    double num2 = (double) ((int) (15.0 * num1) + unifiedRandom.Next(15));
    Vector2D vector2D1;
    vector2D1.X = (double) unifiedRandom.Next(-10, 11) * 0.10000000149011612 * data.roomSlantVariantScalar;
    vector2D1.Y = (double) unifiedRandom.Next(-10, 11) * 0.10000000149011612 * data.roomSlantVariantScalar;
    if (vector2D1.X == 0.0 && vector2D1.Y == 0.0)
    {
      if (unifiedRandom.Next(2) == 0)
        vector2D1.X = unifiedRandom.Next(2) == 0 ? -1.0 : 1.0;
      else
        vector2D1.Y = unifiedRandom.Next(2) == 0 ? -1.0 : 1.0;
    }
    Vector2D vector2D2;
    vector2D2.X = (double) i;
    vector2D2.Y = (double) j - num2 / 2.0;
    if (this.calculated)
      vector2D2 = this.StartPosition;
    Vector2D vector2D3 = vector2D2;
    double num3 = data.roomStepScalar;
    if (settings.StartingRoom)
      num3 = 1.0;
    int num4 = (int) (10.0 * num3) + unifiedRandom.Next(10);
    double num5 = num2;
    double interiorToExteriorRatio = data.roomInteriorToExteriorRatio;
    if (Vector2D.op_Inequality(settings.OverrideStartPosition, new Vector2D()) && Vector2D.op_Inequality(settings.OverrideEndPosition, new Vector2D()))
    {
      vector2D2 = vector2D3 = settings.OverrideStartPosition;
      Vector2D v = Vector2D.op_Subtraction(settings.OverrideEndPosition, vector2D2);
      vector2D1 = v.SafeNormalize(Vector2D.UnitX);
      num4 = (int) Math.Ceiling(((Vector2D) ref v).Length() / ((Vector2D) ref vector2D1).Length());
    }
    else if (Vector2D.op_Inequality(settings.OverrideVelocity, new Vector2D()))
      vector2D1 = settings.OverrideVelocity;
    if (settings.OverrideStrength > 0)
      num2 = num5 = (double) settings.OverrideStrength;
    if (settings.OverrideSteps > 0)
      num4 = settings.OverrideSteps;
    if (settings.OverrideInteriorToExteriorRatio > 0.0)
      interiorToExteriorRatio = settings.OverrideInteriorToExteriorRatio;
    this.InnerBounds.SetBounds((int) vector2D2.X, (int) vector2D2.Y, (int) vector2D2.X, (int) vector2D2.Y);
    this.OuterBounds.SetBounds((int) vector2D2.X, (int) vector2D2.Y, (int) vector2D2.X, (int) vector2D2.Y);
    while (num4 > 0)
    {
      --num4;
      int minX1 = Math.Max(0, Math.Min(Main.maxTilesX - 1, (int) (vector2D2.X - num2 * 0.800000011920929 - 5.0)));
      int num6 = Math.Max(0, Math.Min(Main.maxTilesX - 1, (int) (vector2D2.X + num2 * 0.800000011920929 + 5.0)));
      int minY1 = Math.Max(0, Math.Min(Main.maxTilesY - 1, (int) (vector2D2.Y - num2 * 0.800000011920929 - 5.0)));
      int val1 = Math.Max(0, Math.Min(Main.maxTilesY - 1, (int) (vector2D2.Y + num2 * 0.800000011920929 + 5.0)));
      if (settings.IsEntranceRoom && data.Type == DungeonType.DualDungeon)
        val1 = Math.Max(val1, DungeonUtils.GetDualDungeonBrickSupportCutoffY(data));
      data.dungeonBounds.UpdateBounds(minX1, minY1, num6 - 1, val1 - 1);
      this.OuterBounds.UpdateBounds(minX1, minY1, num6 - 1, val1 - 1);
      int minX2 = Math.Max(0, Math.Min(Main.maxTilesX - 1, (int) (vector2D2.X - num2 * interiorToExteriorRatio)));
      int num7 = Math.Max(0, Math.Min(Main.maxTilesX - 1, (int) (vector2D2.X + num2 * interiorToExteriorRatio)));
      int minY2 = Math.Max(0, Math.Min(Main.maxTilesY - 1, (int) (vector2D2.Y - num2 * interiorToExteriorRatio)));
      int num8 = Math.Max(0, Math.Min(Main.maxTilesY - 1, (int) (vector2D2.Y + num2 * interiorToExteriorRatio)));
      this.InnerBounds.UpdateBounds(minX2, minY2, num7 - 1, num8 - 1);
      for (int index1 = minX1; index1 < num6; ++index1)
      {
        for (int index2 = minY1; index2 < val1; ++index2)
        {
          if (!generating)
          {
            this._outerShapeData.Add(index1 - (int) vector2D3.X, index2 - (int) vector2D3.Y);
            if (index1 >= minX2 && index1 <= num7 && index2 >= minY2 && index2 <= num8)
              this._innerShapeData.Add(index1 - (int) vector2D3.X, index2 - (int) vector2D3.Y);
          }
          else
          {
            Main.tile[index1, index2].liquid = (byte) 0;
            if (!DungeonUtils.IsHigherOrEqualTieredDungeonWall(data, (int) Main.tile[index1, index2].wall, (int) brickWallType))
              DungeonUtils.ChangeTileType(Main.tile[index1, index2], brickTileType, true, settings.OverridePaintTile);
          }
        }
      }
      if (generating)
      {
        for (int index3 = minX1 + 1; index3 < num6 - 1; ++index3)
        {
          for (int index4 = minY1 + 1; index4 < val1 - 1; ++index4)
            DungeonUtils.ChangeWallType(Main.tile[index3, index4], brickWallType, false, settings.OverridePaintWall);
        }
      }
      int num9 = minX2;
      int num10 = num7;
      int num11 = minY2;
      int num12 = num8;
      if (generating)
      {
        for (int index5 = num9; index5 < num10; ++index5)
        {
          for (int index6 = num11; index6 < num12; ++index6)
            DungeonUtils.ChangeWallType(Main.tile[index5, index6], brickWallType, true, settings.OverridePaintWall);
        }
      }
      vector2D2 = Vector2D.op_Addition(vector2D2, vector2D1);
      vector2D1.X = Math.Max(-1.0, Math.Min(1.0, vector2D1.X + (double) unifiedRandom.Next(-10, 11) * 0.05000000074505806 * data.roomSlantVariantScalar));
      vector2D1.Y = Math.Max(-1.0, Math.Min(1.0, vector2D1.Y + (double) unifiedRandom.Next(-10, 11) * 0.05000000074505806 * data.roomSlantVariantScalar));
    }
    this.StartPosition = vector2D3;
    this.EndPosition = vector2D2;
    this.Strength = (int) num5;
    this.InnerBounds.CalculateHitbox();
    this.OuterBounds.CalculateHitbox();
    this._floodedTileCount = DungeonUtils.CalculateFloodedTileCountFromShapeData(this.InnerBounds, this._innerShapeData);
  }
}
