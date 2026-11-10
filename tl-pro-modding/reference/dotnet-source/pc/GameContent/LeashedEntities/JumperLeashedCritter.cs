// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.LeashedEntities.JumperLeashedCritter
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;
using Terraria.DataStructures;

#nullable disable
namespace Terraria.GameContent.LeashedEntities;

internal class JumperLeashedCritter : LeashedCritter
{
  public static JumperLeashedCritter Prototype = new JumperLeashedCritter();
  private const int State_Normal = 0;
  private const int State_Recalling = 1;
  protected int minWaitTime;
  protected int maxWaitTime;
  protected float maxJumpWidth;
  protected float minJumpWidth;
  protected float maxJumpHeight;
  protected float maxJumpDuration;
  protected int jumpCooldown;
  protected bool canStandOnWater;

  public JumperLeashedCritter()
  {
    this.strayingRangeInBlocks = 12;
    this.minWaitTime = 180;
    this.maxWaitTime = 300;
    this.maxJumpWidth = 112f;
    this.minJumpWidth = 48f;
    this.maxJumpHeight = 64f;
    this.maxJumpDuration = 30f;
    this.jumpCooldown = 60;
    this.canStandOnWater = false;
  }

  public override void Spawn(bool newlyAdded)
  {
    base.Spawn(newlyAdded);
    this.PickNewTarget();
  }

  public override void Update()
  {
    base.Update();
    --this.WaitTime;
    if (this.WaitTime <= (short) 0)
    {
      switch (this.State)
      {
        case 0:
          if (!this.TryStartJump())
          {
            this.PickNewTarget();
            this.SetJumpCooldown();
            break;
          }
          break;
        case 1:
          this.Recall();
          this.PickNewTarget();
          this.SetJumpCooldown();
          this.State = (byte) 0;
          break;
      }
    }
    bool hitSomething;
    this.Move(out hitSomething);
    if (hitSomething && this.State != (byte) 1)
    {
      this.PickNewTarget();
      this.SetJumpCooldown();
    }
    if ((double) (this.TargetPosition.ToWorldCoordinates() - this.Center).Length() < 8.0)
    {
      this.Center = this.TargetPosition.ToWorldCoordinates();
      this.velocity = Vector2.Zero;
      this.PickNewTarget();
      this.SetJumpCooldown();
    }
    this.spriteDirection = this.direction;
    if (Main.netMode != 2)
      this.VisualEffects();
    this.CopyToDummy();
    LeashedCritter._dummy.FindFrame();
    this.CopyFromDummy();
  }

  private void SetJumpCooldown()
  {
    this.WaitTime = (short) this.rand.Next(this.minWaitTime, this.maxWaitTime + 1);
  }

  private bool TryStartJump()
  {
    Vector2 vector2 = this.TargetPosition.ToWorldCoordinates() - this.Center;
    if ((double) vector2.Y * -1.0 > (double) this.maxJumpHeight)
      return false;
    float num1 = Math.Min(Math.Abs(vector2.X), this.maxJumpWidth);
    if ((double) num1 <= (double) this.minJumpWidth)
      return false;
    this.direction = Math.Sign(vector2.X);
    float num2 = num1 / this.maxJumpWidth;
    float num3 = this.maxJumpDuration * num2;
    this.velocity.X = num1 / num3 * (float) this.direction;
    this.velocity.Y = (float) ((double) vector2.Y * (double) num2 / (double) num3 - 0.5 * (double) LeashedCritter.gravity * (double) num3);
    if ((double) this.velocity.Y >= 0.0)
      return false;
    this.WaitTime = (short) ((double) num3 + (double) this.jumpCooldown);
    return true;
  }

  private void Move(out bool hitSomething)
  {
    hitSomething = false;
    Point tileCoordinates = this.Center.ToTileCoordinates();
    int x = Math.Sign((int) this.velocity.X);
    if (x != 0)
      this.direction = x;
    int y = Math.Sign((int) this.velocity.Y);
    Vector2 vec = this.Center + new Vector2((float) x, (float) y) * this.Size * 0.5f + this.velocity;
    if (!WorldGen.SolidTile2(vec.ToTileCoordinates()))
    {
      this.Move_NoObstruction(tileCoordinates, vec.Y);
    }
    else
    {
      hitSomething = true;
      bool flag1 = false;
      if (y != 0)
      {
        Point p = tileCoordinates;
        p.Y += y;
        flag1 = WorldGen.SolidTile2(p);
      }
      bool flag2 = false;
      if (x != 0)
      {
        Point p = tileCoordinates;
        p.X += x;
        flag2 = WorldGen.SolidTile2(p);
      }
      if (flag1)
        this.velocity.Y = 0.0f;
      if (flag2)
        this.velocity.X = 0.0f;
      if (flag1 || flag2)
        return;
      this.velocity = Vector2.Zero;
    }
  }

  private void Move_NoObstruction(Point currentTile, float nextY)
  {
    if ((double) this.velocity.Y >= 0.0 && (double) nextY % 16.0 >= 8.0)
    {
      Point p = currentTile;
      ++p.Y;
      if (WorldGen.SolidTile2(p) || this.canStandOnWater && WorldGen.AnyLiquidAt(p.X, p.Y, 0))
      {
        this.Center = currentTile.ToWorldCoordinates();
        this.velocity = Vector2.Zero;
        return;
      }
    }
    this.Center = this.Center + this.velocity;
    this.velocity.Y += LeashedCritter.gravity;
    if ((double) this.velocity.Y > (double) LeashedCritter.maxFallSpeed)
      this.velocity.Y = LeashedCritter.maxFallSpeed;
    if (this.State == (byte) 1 || currentTile.Y - (int) this.AnchorPosition.Y <= this.strayingRangeInBlocks)
      return;
    this.State = (byte) 1;
    this.WaitTime = (short) 20;
  }

  private void PickNewTarget()
  {
    int num1 = (int) ((double) this.maxJumpWidth / 16.0);
    int num2 = (int) ((double) this.minJumpWidth / 16.0);
    int num3 = (int) this.TargetPosition.X - ((int) this.AnchorPosition.X - this.strayingRangeInBlocks);
    int num4 = (int) this.AnchorPosition.X + this.strayingRangeInBlocks - (int) this.TargetPosition.X;
    bool flag1 = num3 >= num2;
    bool flag2 = num4 >= num2;
    if (!flag1 && !flag2)
      return;
    int num5 = !(flag1 & flag2) ? (flag1 ? -1 : 1) : this.rand.Next(2) * 2 - 1;
    int num6 = num5 < 1 ? num3 : num4;
    int num7 = this.rand.Next(1, num6 / num1 + 1);
    int num8 = num6 % num1;
    if (num8 < num2)
      num8 = 0;
    Point16 tile;
    if (!this.TryGetReachableTile((int) this.TargetPosition.X + (num7 * num1 + num8) * num5, out tile))
      return;
    this.TargetPosition = tile;
  }

  private bool TryGetReachableTile(int startX, out Point16 tile)
  {
    tile = Point16.Zero;
    int num1 = Math.Sign((int) this.AnchorPosition.X - startX);
    if (num1 == 0)
      return false;
    for (int X = startX; X != (int) this.AnchorPosition.X; X += num1)
    {
      tile = new Point16(X, (int) this.AnchorPosition.Y);
      if (WorldGen.SolidTile2((Point) tile))
      {
        float num2 = this.maxJumpHeight / 16f;
        for (int index = 0; (double) index < (double) num2; ++index)
        {
          --tile.Y;
          if (!WorldGen.SolidTile2((Point) tile))
            return true;
        }
      }
      else
      {
        for (int index = 0; index < this.strayingRangeInBlocks; ++index)
        {
          ++tile.Y;
          if (WorldGen.SolidTile2((Point) tile) || this.canStandOnWater && WorldGen.AnyLiquidAt((int) tile.X, (int) tile.Y, 0))
          {
            --tile.Y;
            return true;
          }
        }
      }
    }
    return false;
  }

  protected override void CopyToDummy()
  {
    base.CopyToDummy();
    if (this.State != (byte) 1)
      return;
    LeashedCritter._dummy.Opacity = (float) this.WaitTime / 20f;
  }

  public override Vector2 GetDrawOffset()
  {
    Point16 tileCoordinates16 = this.Center.ToTileCoordinates16();
    return Framing.GetTileSafely((int) tileCoordinates16.X, (int) tileCoordinates16.Y + 1).halfBrick() ? new Vector2(0.0f, this.Center.Y % 16f) : base.GetDrawOffset();
  }
}
