// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Generation.Dungeon.Rooms.StepBasedDungeonRoomSettings
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using ReLogic.Utilities;

#nullable disable
namespace Terraria.GameContent.Generation.Dungeon.Rooms;

public abstract class StepBasedDungeonRoomSettings : DungeonRoomSettings
{
  public int OverrideStrength;
  public int OverrideSteps;
  public Vector2D OverrideStartPosition;
  public Vector2D OverrideEndPosition;
  public Vector2D OverrideVelocity;
  public double OverrideInteriorToExteriorRatio;

  public override int GetBoundingRadius()
  {
    return (int) ((double) this.OverrideStrength * 0.8 + 5.0 + (double) this.OverrideSteps * 0.5 * 1.4);
  }
}
