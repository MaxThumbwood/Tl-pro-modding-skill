// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.LeashedEntities.LeashedKite
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;
using System.IO;
using Terraria.DataStructures;
using Terraria.ID;

#nullable disable
namespace Terraria.GameContent.LeashedEntities;

public class LeashedKite : LeashedEntity
{
  public static LeashedKite Prototype;
  private static Projectile _dummy = new Projectile();
  public int projType;
  public int frame;
  public int frameCounter;
  public float rotation;
  public int spriteDirection = 1;
  public float kiteDistance = 250f;
  public float windTarget;
  public float windCurrent;
  public float timeCounter;
  public float cloudAlpha;
  public int timeWithoutWind;
  public float projectileLocalAI0;
  public float projectileLocalAI1;
  public Vector2[] oldPos;
  public float[] oldRot;
  public int[] oldSpriteDirection;
  public Vector2 netOffset;

  public void SetDefaults(int projType)
  {
    this.projType = projType;
    LeashedKite._dummy.SetDefaults(projType);
    this.Size = LeashedKite._dummy.Size;
  }

  public override void NetSend(BinaryWriter writer, bool full)
  {
    if (full)
      writer.Write7BitEncodedInt(this.projType);
    writer.WriteVector2(this.position);
    writer.WritePackedVector2(this.velocity);
    writer.Write((byte) ((double) this.rotation * 256.0 / (2.0 * Math.PI)));
    writer.Write(this.windTarget);
    writer.Write(this.cloudAlpha);
    writer.Write(this.timeCounter);
  }

  public override void NetReceive(BinaryReader reader, bool full)
  {
    if (full)
      this.SetDefaults(reader.Read7BitEncodedInt());
    Vector2 position = this.position;
    this.position = reader.ReadVector2();
    this.velocity = reader.ReadPackedVector2();
    this.rotation = (float) ((double) reader.ReadByte() * Math.PI * 2.0 / 256.0);
    this.windTarget = reader.ReadSingle();
    this.cloudAlpha = reader.ReadSingle();
    this.timeCounter = reader.ReadSingle();
    if (full)
      this.netOffset = Vector2.Zero;
    else
      this.netOffset += position - this.position;
    if (!full)
      return;
    this.Update();
  }

  private Vector2 AnchorWorldPosition => this.AnchorPosition.ToWorldCoordinates();

  public override void Draw()
  {
    Main.instance.LoadProjectile(this.projType);
    this.CopyToDummy();
    Projectile dummy = LeashedKite._dummy;
    dummy.position = dummy.position + this.netOffset;
    Main.DrawKite(LeashedKite._dummy, this.AnchorWorldPosition);
  }

  public override void Update() => this.Update(false);

  public void Update(bool fastForward)
  {
    if (this.oldPos == null)
    {
      int length = ProjectileID.Sets.TrailCacheLength[this.projType];
      this.oldPos = new Vector2[length];
      this.oldRot = new float[length];
      this.oldSpriteDirection = new int[length];
    }
    if (this.NearbySectionsMissing())
      return;
    if (fastForward || (double) Vector2.DistanceSquared(this.position, this.oldPos[0]) > 256.0)
    {
      for (int index = 0; index < this.oldPos.Length; ++index)
      {
        this.oldPos[index] = this.position;
        this.oldRot[index] = this.rotation;
        this.oldSpriteDirection[index] = this.spriteDirection;
      }
    }
    if (Main.netMode != 1)
    {
      this.windTarget = Main.WindForVisuals;
      this.cloudAlpha = Main.cloudAlpha;
    }
    this.windCurrent = fastForward ? this.windTarget : MathHelper.Lerp(this.windCurrent, this.windTarget, 0.05f);
    this.timeWithoutWind = (double) Math.Abs(this.windCurrent) >= 0.20000000298023224 ? 0 : (fastForward ? 3600 : this.timeWithoutWind + 1);
    this.kiteDistance = Utils.Remap((float) this.timeWithoutWind, 120f, 420f, 250f, 48f);
    this.MoveKite(fastForward);
    this.netOffset = this.netOffset.MoveTowards(Vector2.Zero, 2f);
  }

  private void MoveKite(bool fastForward = false)
  {
    this.CopyToDummy();
    LeashedKite._dummy.owner = (int) byte.MaxValue;
    Player player = Main.player[(int) byte.MaxValue];
    Vector2 anchorWorldPosition = this.AnchorWorldPosition;
    player.Center = anchorWorldPosition;
    if (this.timeWithoutWind == 0)
    {
      int num = (double) LeashedKite._dummy.Center.X - (double) anchorWorldPosition.X < 0.0 ? -1 : 1;
      LeashedKite._dummy.spriteDirection = num;
      player.direction = num;
    }
    this.timeCounter += 0.0166666675f;
    KiteFlyingInfo info = new KiteFlyingInfo()
    {
      BobOffset = (float) (((double) anchorWorldPosition.X + (double) anchorWorldPosition.Y * 0.92000001668930054) * (1.0 / 400.0)),
      WindInWorld = this.windCurrent,
      CloudAlpha = this.cloudAlpha,
      GlobalTime = this.timeCounter,
      CanReelThroughBlocks = false
    };
    if (fastForward)
    {
      LeashedKite._dummy.KiteLogic(anchorWorldPosition, info);
      this.timeCounter = 6f;
      Vector2 wetVelocity = new Vector2(info.WindInWorld, -2f).SafeNormalize(Vector2.Zero) * this.kiteDistance;
      Vector2 position = LeashedKite._dummy.position;
      LeashedKite._dummy.velocity = wetVelocity;
      LeashedKite._dummy.HandleMovement(wetVelocity);
      LeashedKite._dummy.position = LeashedKite._dummy.position.MoveTowards(position, 1f);
      if ((double) LeashedKite._dummy.velocity.Length() > 4.0)
        LeashedKite._dummy.velocity = LeashedKite._dummy.velocity.SafeNormalize(Vector2.Zero) * 4f;
      LeashedKite._dummy.KiteLogic(anchorWorldPosition, info);
      for (int index = this.oldPos.Length - 1; index >= 0; --index)
      {
        this.oldPos[index] = LeashedKite._dummy.position;
        this.oldRot[index] = LeashedKite._dummy.rotation;
        this.oldSpriteDirection[index] = LeashedKite._dummy.spriteDirection;
      }
    }
    else
    {
      Utils.Shift<Vector2>(this.oldPos, 1);
      Utils.Shift<float>(this.oldRot, 1);
      Utils.Shift<int>(this.oldSpriteDirection, 1);
      this.oldPos[0] = this.position;
      this.oldRot[0] = this.rotation;
      this.oldSpriteDirection[0] = this.spriteDirection;
      LeashedKite._dummy.KiteLogic(anchorWorldPosition, info);
      LeashedKite._dummy.HandleMovement(LeashedKite._dummy.velocity);
      Vector2 resizeAnchor;
      int colWidth;
      int colHeight;
      LeashedKite._dummy.GetCollisionParams(out resizeAnchor, out colWidth, out colHeight);
      if (Collision.SolidFullTiles(LeashedKite._dummy.position + LeashedKite._dummy.Size / 2f - new Vector2((float) colWidth, (float) colHeight) * resizeAnchor, new Vector2((float) colWidth, (float) colHeight)))
        LeashedKite._dummy.Bottom = LeashedKite._dummy.Bottom.MoveTowards(anchorWorldPosition, 2f);
    }
    this.CopyFromDummy();
  }

  public override void Spawn(bool newlyAdded)
  {
    this.Center = this.AnchorWorldPosition;
    this.velocity = new Vector2(0.0f, -5f);
    this.Update(!newlyAdded);
    this.windCurrent = this.windTarget = Main.WindForVisuals;
    this.cloudAlpha = Main.cloudAlpha;
  }

  private void CopyToDummy()
  {
    LeashedKite._dummy.type = this.projType;
    LeashedKite._dummy.Size = this.Size;
    LeashedKite._dummy.frame = this.frame;
    LeashedKite._dummy.frameCounter = this.frameCounter;
    LeashedKite._dummy.position = this.position;
    LeashedKite._dummy.velocity = this.velocity;
    LeashedKite._dummy.rotation = this.rotation;
    LeashedKite._dummy.spriteDirection = this.spriteDirection;
    LeashedKite._dummy.oldPos = this.oldPos;
    LeashedKite._dummy.oldRot = this.oldRot;
    LeashedKite._dummy.oldSpriteDirection = this.oldSpriteDirection;
    LeashedKite._dummy.scale = 1f;
    LeashedKite._dummy.ai[0] = this.kiteDistance;
    LeashedKite._dummy.localAI[0] = this.projectileLocalAI0;
    LeashedKite._dummy.localAI[1] = this.projectileLocalAI1;
    LeashedKite._dummy.extraUpdates = 0;
  }

  private void CopyFromDummy()
  {
    this.frame = LeashedKite._dummy.frame;
    this.frameCounter = LeashedKite._dummy.frameCounter;
    this.position = LeashedKite._dummy.position;
    this.velocity = LeashedKite._dummy.velocity;
    this.rotation = LeashedKite._dummy.rotation;
    this.spriteDirection = LeashedKite._dummy.spriteDirection;
    this.projectileLocalAI0 = LeashedKite._dummy.localAI[0];
    this.projectileLocalAI1 = LeashedKite._dummy.localAI[1];
  }
}
