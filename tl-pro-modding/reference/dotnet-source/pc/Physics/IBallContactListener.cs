// Decompiled with JetBrains decompiler
// Type: Terraria.Physics.IBallContactListener
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.Physics;

public interface IBallContactListener
{
  void OnCollision(
    PhysicsProperties properties,
    ref Vector2 position,
    ref Vector2 velocity,
    ref BallCollisionEvent collision);

  void OnPassThrough(
    PhysicsProperties properties,
    ref Vector2 position,
    ref Vector2 velocity,
    ref float angularVelocity,
    ref BallPassThroughEvent passThrough);
}
