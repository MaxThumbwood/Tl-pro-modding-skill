// Decompiled with JetBrains decompiler
// Type: Terraria.Physics.BallCollisionEvent
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.Physics;

public struct BallCollisionEvent(
  float timeScale,
  Vector2 normal,
  Vector2 impactPoint,
  Tile tile,
  Entity entity)
{
  public readonly Vector2 Normal = normal;
  public readonly Vector2 ImpactPoint = impactPoint;
  public readonly Tile Tile = tile;
  public readonly Entity Entity = entity;
  public readonly float TimeScale = timeScale;
}
