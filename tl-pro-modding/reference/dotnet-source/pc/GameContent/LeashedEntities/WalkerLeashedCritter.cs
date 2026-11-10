// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.LeashedEntities.WalkerLeashedCritter
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;
using Terraria.DataStructures;

#nullable disable
namespace Terraria.GameContent.LeashedEntities;

public class WalkerLeashedCritter : LeashedCritter
{
  public static WalkerLeashedCritter Prototype = new WalkerLeashedCritter();
  private const int State_Standing = 0;
  private const int State_PickDirection = 1;
  private const int State_Walking = 2;
  private const int State_Falling = 3;
  private const int State_Recalling = 4;
  protected float walkingPace;

  public WalkerLeashedCritter()
  {
    this.walkingPace = 0.8f;
    this.strayingRangeInBlocks = 3;
  }

  protected bool AdvanceTargetPosition()
  {
    if (Math.Abs((int) this.TargetPosition.X - (int) this.AnchorPosition.X) >= this.strayingRangeInBlocks)
      this.direction = Math.Sign((int) this.AnchorPosition.X - (int) this.TargetPosition.X);
    if (!WorldGen.InWorld((int) this.TargetPosition.X + this.direction, (int) this.TargetPosition.Y))
      this.direction *= -1;
    this.spriteDirection = this.direction;
    int num1 = (int) this.TargetPosition.X + this.direction;
    short y = this.TargetPosition.Y;
    int num2 = !WorldGen.SolidTile2(num1, (int) y - 1) ? 1 : 0;
    bool flag1 = !WorldGen.SolidTile2(num1, (int) y);
    bool flag2 = !WorldGen.SolidTile2(num1, (int) y + 1);
    bool flag3 = WorldGen.AnyLiquidAt(num1, (int) y + 1);
    bool flag4 = !WorldGen.SolidTile2(num1, (int) y + 2);
    bool flag5 = num2 != 0 && !flag1;
    bool flag6 = flag1 & flag2 && !flag3 && !flag4;
    bool flag7 = flag1 && !flag2;
    if (flag5)
      this.TargetPosition = new Point16(num1, (int) y - 1);
    else if (flag6)
    {
      this.TargetPosition = new Point16(num1, (int) y + 1);
    }
    else
    {
      if (!flag7)
        return false;
      this.TargetPosition = new Point16(num1, (int) y);
    }
    return true;
  }

  public override void Update()
  {
    base.Update();
    Point16 tileCoordinates16 = this.Center.ToTileCoordinates16();
    this.HandleFalling(tileCoordinates16);
    --this.WaitTime;
    if (this.WaitTime <= (short) 0)
    {
      if (this.State == (byte) 4)
        this.Recall();
      this.WaitTime = (short) this.rand.Next(60, 61);
      this.State = (byte) this.rand.Next(2);
    }
    this.HandleWalking();
    int num1 = (int) this.TargetPosition.X - (int) tileCoordinates16.X;
    int num2 = (int) this.TargetPosition.Y - (int) tileCoordinates16.Y;
    if ((Math.Abs(num1) != 1 ? 0 : (Math.Abs(num2) == 1 ? 1 : 0)) != 0)
      this.velocity.Y = (float) (num2 * 2);
    float maxAmountAllowedToMove = this.velocity.Length();
    Vector2 worldCoordinates = this.TargetPosition.ToWorldCoordinates();
    this.Center = this.Center.MoveTowards(worldCoordinates, maxAmountAllowedToMove);
    if (this.Center == worldCoordinates && this.State == (byte) 0)
      this.velocity = Vector2.Zero;
    if (Main.netMode != 2)
      this.VisualEffects();
    this.CopyToDummy();
    LeashedCritter._dummy.FindFrame();
    this.CopyFromDummy();
  }

  private void HandleFalling(Point16 tilePosition)
  {
    if (WorldGen.SolidTile2((int) tilePosition.X, (int) tilePosition.Y + 1))
    {
      this.velocity.Y = 0.0f;
      if (this.State == (byte) 3 || this.State == (byte) 4)
        this.Center = this.TargetPosition.ToWorldCoordinates();
      if (this.State != (byte) 3)
        return;
      this.State = (byte) 0;
      this.WaitTime = (short) 0;
    }
    else
    {
      this.velocity.Y += LeashedCritter.gravity;
      if ((double) this.velocity.Y > (double) LeashedCritter.maxFallSpeed)
        this.velocity.Y = LeashedCritter.maxFallSpeed;
      this.TargetPosition.X = tilePosition.X;
      this.TargetPosition.Y = (short) Math.Min((int) tilePosition.Y + 1, Main.maxTilesY - 1);
      if (this.State == (byte) 4)
        return;
      if ((int) this.TargetPosition.Y - (int) this.AnchorPosition.Y > this.strayingRangeInBlocks)
      {
        this.State = (byte) 4;
        this.WaitTime = (short) 20;
      }
      else
        this.State = (byte) 3;
    }
  }

  private void HandleWalking()
  {
    if (this.State == (byte) 3 || this.State == (byte) 4)
      return;
    this.velocity.X = this.walkingPace * (float) this.direction;
    if (this.State == (byte) 0 || (double) this.Center.Distance(this.TargetPosition.ToWorldCoordinates()) >= 1.0)
      return;
    if (this.State == (byte) 1)
    {
      this.direction = this.rand.Next(2) * 2 - 1;
      this.State = (byte) 2;
    }
    if (this.AdvanceTargetPosition())
      return;
    this.WaitTime = (short) 30;
    this.State = (byte) 0;
  }

  protected override void CopyToDummy()
  {
    base.CopyToDummy();
    if (this.State != (byte) 4)
      return;
    LeashedCritter._dummy.Opacity = (float) this.WaitTime / 20f;
  }

  public override Vector2 GetDrawOffset()
  {
    Point16 tileCoordinates16 = this.Center.ToTileCoordinates16();
    return Framing.GetTileSafely((int) tileCoordinates16.X, (int) tileCoordinates16.Y + 1).halfBrick() ? new Vector2(0.0f, 8f) : base.GetDrawOffset();
  }
}
