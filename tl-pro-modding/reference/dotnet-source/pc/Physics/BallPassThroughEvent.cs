// Decompiled with JetBrains decompiler
// Type: Terraria.Physics.BallPassThroughEvent
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.Physics;

public struct BallPassThroughEvent(
  float timeScale,
  Tile tile,
  Entity entity,
  BallPassThroughType type)
{
  public readonly Tile Tile = tile;
  public readonly Entity Entity = entity;
  public readonly BallPassThroughType Type = type;
  public readonly float TimeScale = timeScale;
}
