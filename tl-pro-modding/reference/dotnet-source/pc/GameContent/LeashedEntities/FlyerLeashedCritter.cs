// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.LeashedEntities.FlyerLeashedCritter
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;
using Terraria.DataStructures;

#nullable disable
namespace Terraria.GameContent.LeashedEntities;

public class FlyerLeashedCritter : LeashedCritter
{
  public static FlyerLeashedCritter Prototype = new FlyerLeashedCritter();
  protected int minWaitTime;
  protected int maxWaitTime;
  protected float maxFlySpeed;
  protected float acceleration;
  protected int brakeDuration;
  protected float rotationScalar;
  protected float hoverAmplitude;
  protected float hoverPeriod;
  protected bool hasGroundBias;
  private const float HoverYVelocity = 0.0001f;

  public FlyerLeashedCritter()
  {
    this.anchorStyle = 4;
    this.strayingRangeInBlocks = 7;
    this.minWaitTime = 60;
    this.maxWaitTime = 300;
    this.maxFlySpeed = 1f;
    this.acceleration = 0.2f;
    this.brakeDuration = 10;
  }

  public override void Spawn(bool newlyAdded)
  {
    base.Spawn(newlyAdded);
    if (!WorldGen.SolidTile2((int) this.AnchorPosition.X, (int) this.AnchorPosition.Y + 1))
      this.velocity.Y = 0.0001f;
    this.PickNewTarget();
  }

  protected void PickNewTarget()
  {
    int num = !this.hasGroundBias || (int) this.AnchorPosition.Y != (int) this.TargetPosition.Y ? 0 : (this.rand.Next(4) != 0 ? 1 : 0);
    this.TargetPosition = new Point16((int) this.AnchorPosition.X + this.rand.Next(-this.strayingRangeInBlocks, this.strayingRangeInBlocks + 1), (int) this.AnchorPosition.Y + this.rand.Next(-this.strayingRangeInBlocks, 1));
    if (num == 0)
      return;
    this.TargetPosition.Y = this.AnchorPosition.Y;
  }

  protected override void CopyToDummy()
  {
    base.CopyToDummy();
    if ((double) this.velocity.Y == 0.0)
      return;
    LeashedCritter._dummy.rotation = this.velocity.X * this.rotationScalar;
  }

  public override void Update()
  {
    base.Update();
    --this.WaitTime;
    if (this.WaitTime <= (short) 0)
    {
      this.WaitTime = (short) this.rand.Next(this.minWaitTime, this.maxWaitTime + 1);
      this.PickNewTarget();
    }
    Vector2 worldCoordinates = this.TargetPosition.ToWorldCoordinates();
    Vector2 vector2 = worldCoordinates - this.Center;
    float num1 = vector2.Length();
    Vector2 vec = vector2 / num1;
    if (vec.HasNaNs())
      vec = Vector2.Zero;
    this.velocity = this.velocity + vec * this.acceleration;
    float num2 = this.velocity.Length();
    float num3 = this.maxFlySpeed * Math.Max(Math.Min(1f, num1 / ((float) this.brakeDuration * this.maxFlySpeed)), 0.25f);
    if ((double) num2 > (double) num3)
      this.velocity = this.velocity * (num3 / num2);
    bool flag1 = (double) num1 < (double) this.maxFlySpeed;
    bool flag2 = flag1;
    if (!flag2)
      flag2 = WorldGen.SolidTile2((this.Center + this.Size * 0.5f * vec + this.velocity).ToTileCoordinates());
    if (flag2)
    {
      if (flag1)
        this.Center = worldCoordinates;
      Point tileCoordinates = this.Center.ToTileCoordinates();
      this.velocity.X = 0.0f;
      this.velocity.Y = WorldGen.SolidTile2(tileCoordinates.X, tileCoordinates.Y + 1) ? 0.0f : 0.0001f;
    }
    else
    {
      this.Center = this.Center + this.velocity;
      Point tileCoordinates = this.Center.ToTileCoordinates();
      if ((double) this.velocity.Y == 0.0 && !WorldGen.SolidTile2(tileCoordinates.X, tileCoordinates.Y + 1))
        this.velocity.Y = 0.0001f;
    }
    int num4 = Math.Sign(this.velocity.X);
    if (num4 != 0 && num4 != this.direction)
    {
      this.direction = num4;
      this.spriteDirection = -this.direction;
    }
    if (Main.netMode != 2)
      this.VisualEffects();
    this.CopyToDummy();
    LeashedCritter._dummy.FindFrame();
    this.CopyFromDummy();
  }

  public override Vector2 GetDrawOffset()
  {
    if ((double) this.velocity.Y == 0.0)
    {
      Point16 tileCoordinates16 = this.Center.ToTileCoordinates16();
      return Framing.GetTileSafely((int) tileCoordinates16.X, (int) tileCoordinates16.Y + 1).halfBrick() ? new Vector2(0.0f, 8f) : Vector2.Zero;
    }
    return (double) this.hoverPeriod == 0.0 || (double) this.hoverAmplitude == 0.0 ? Vector2.Zero : this.GetBobbingOffset();
  }

  protected Vector2 GetBobbingOffset()
  {
    return new Vector2(0.0f, (float) Math.Sin((Main.timeForVisualEffects + (double) (this.whoAmI * this.npcType)) * ((double) this.hoverPeriod * 6.2831854820251465)) * this.hoverAmplitude);
  }
}
