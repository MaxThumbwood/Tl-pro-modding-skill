// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.EntityShadowInfo
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.DataStructures;

public struct EntityShadowInfo
{
  public Vector2 Position;
  public float Rotation;
  public Vector2 Origin;
  public int Direction;
  public int GravityDirection;
  public int BodyFrameIndex;

  public void CopyPlayer(Player player)
  {
    this.Position = player.position;
    this.Rotation = player.fullRotation;
    this.Origin = player.fullRotationOrigin;
    this.Direction = player.direction;
    this.GravityDirection = (int) player.gravDir;
    this.BodyFrameIndex = player.bodyFrame.Y / player.bodyFrame.Height;
  }

  public Vector2 HeadgearOffset => Main.OffsetsPlayerHeadgear[this.BodyFrameIndex];
}
