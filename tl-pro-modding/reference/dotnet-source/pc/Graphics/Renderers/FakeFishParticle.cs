// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.Renderers.FakeFishParticle
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria.Audio;
using Terraria.GameContent;
using Terraria.GameContent.Shaders;
using Terraria.Graphics.Effects;
using Terraria.ID;

#nullable disable
namespace Terraria.Graphics.Renderers;

public class FakeFishParticle : IPooledParticle, IParticle, IParticleRepel
{
  public Vector2 Position;
  public Vector2 Velocity;
  public float Rotation;
  private int _latchedProjectileType;
  private Projectile _latchedProjectile;
  private Item _itemInstance;
  private int _lifeTimeCounted;
  private int _lifeTimeTotal;
  private float _totalScale;
  private int _waitTime;
  private FakeFishParticle.State _state;
  private int _jumpTimeLeft;
  private bool _itemLooksDiagonal;
  private Vector2 _targetVelocity;
  private Vector2 _bobberLocation;
  private int _steerTime;
  private bool _isInanimate;
  private Color _sonarColor;
  private int _sonarTimeleft;
  private int _sonarStartTime;
  private bool _isSelectedSonarType;
  private bool _wasWet;
  private int _delayTime;
  private bool _gotRepelled;

  public bool ShouldBeRemovedFromRenderer { get; private set; }

  public FakeFishParticle() => this._itemInstance = new Item();

  public bool TryToMagnetizeTo(Projectile projectile, int requiredItemType = -1)
  {
    if (!this.CanHit(projectile, requiredItemType))
      return false;
    this._latchedProjectile = projectile;
    this._latchedProjectileType = projectile.type;
    this._state = FakeFishParticle.State.Latched;
    this.SetAndGetLatchDetails(out Vector2 _, out Vector2 _);
    this.Rotate(true);
    return true;
  }

  public bool TryToPushAway(Projectile projectile, int requiredItemType = -1)
  {
    if (this._state == FakeFishParticle.State.Jumping || requiredItemType == this._itemInstance.type || !this.CanHit(projectile, allowedRange: 160f))
      return false;
    this.Velocity += projectile.DirectionTo(this.Position).SafeNormalize(Vector2.UnitY) * (float) (1.0 + 1.0 * (double) Main.rand.NextFloat()) * 1f;
    return true;
  }

  public bool TryToBePinged(Projectile projectile, int requiredItemType = -1)
  {
    if (!this.CanHit(projectile, allowedRange: 1000f))
      return false;
    int num1 = (int) projectile.Center.Distance(this.Position) / 10;
    int num2 = 60;
    this._sonarStartTime = num2;
    this._sonarTimeleft = num2 + num1;
    this._isSelectedSonarType = requiredItemType == this._itemInstance.type;
    this._sonarColor = this._isSelectedSonarType ? new Color((int) byte.MaxValue, 220, 30, 0) : new Color(30, 200, (int) byte.MaxValue, 0) * 0.05f;
    return true;
  }

  public bool CanHit(Projectile projectile, int requiredItemType = -1, float allowedRange = 80f)
  {
    if (requiredItemType != -1 && this._itemInstance.type != requiredItemType)
      return false;
    Vector2 center = projectile.Center;
    int num = 80 /*0x50*/;
    return (double) center.Distance(this.Position) <= (double) num && Collision.CanHitLine(center, 0, 0, this.Position, 0, 0);
  }

  private void CheckLatch()
  {
    if (this._state != FakeFishParticle.State.Latched)
      return;
    int num = 80 /*0x50*/;
    if (!this._latchedProjectile.active || this._latchedProjectile.type != this._latchedProjectileType || (double) this.Position.Distance(this._latchedProjectile.Center) > (double) num)
      this.RemoveLatch();
    else if ((double) this._latchedProjectile.ai[0] == 0.0 && (double) this._latchedProjectile.ai[1] >= 0.0)
    {
      this.RemoveLatch();
    }
    else
    {
      if ((double) this._latchedProjectile.ai[0] != 1.0)
        return;
      this.RemoveLatch();
      if ((double) this._latchedProjectile.ai[1] != (double) this._itemInstance.type)
        return;
      this.ShouldBeRemovedFromRenderer = true;
    }
  }

  private void RemoveLatch()
  {
    this._state = FakeFishParticle.State.FreeRoaming;
    this.PickNewVelocity();
  }

  private void EmitWaterPulse()
  {
    if (Main.netMode == 2)
      return;
    Vector2 Position = this.Position - new Vector2(4f, 4f);
    int Width = 8;
    int Height = 8;
    bool lavaWet = Collision.LavaCollision(Position, Width, Height);
    Collision.WetCollision(Position, Width, Height);
    this.DoStandardWaterSplash(this.Position, Collision.shimmer, Collision.honey, lavaWet);
    WaterShaderData shader = (WaterShaderData) Filters.Scene["WaterDistortion"].GetShader();
    float num = 1.4f;
    Vector2 position = this.Position;
    Color waveData = new Color(0.5f, (float) (0.10000000149011612 * (double) Math.Sign(num) + 0.5), 0.0f, 1f) * Math.Abs(num);
    Vector2 size = new Vector2(4f, 4f);
    shader.QueueRipple(position, waveData, size, RippleShape.Circle);
  }

  private void DoStandardWaterSplash(
    Vector2 castPosition,
    bool shimmerWet,
    bool honeyWet,
    bool lavaWet)
  {
    Vector2 vector2 = castPosition - new Vector2(4f, 4f);
    int num1 = 8;
    int num2 = 8;
    if (shimmerWet)
    {
      for (int index1 = 0; index1 < 10; ++index1)
      {
        int index2 = Dust.NewDust(new Vector2(vector2.X - 6f, (float) ((double) vector2.Y + (double) (num2 / 2) - 8.0)), num1 + 12, 24, 308);
        Main.dust[index2].velocity.Y -= 4f;
        Main.dust[index2].velocity.X *= 2.5f;
        Main.dust[index2].scale = 1.3f;
        Main.dust[index2].noGravity = true;
        switch (Main.rand.Next(6))
        {
          case 0:
            Main.dust[index2].color = new Color((int) byte.MaxValue, (int) byte.MaxValue, 210);
            break;
          case 1:
            Main.dust[index2].color = new Color(190, 245, (int) byte.MaxValue);
            break;
          case 2:
            Main.dust[index2].color = new Color((int) byte.MaxValue, 150, (int) byte.MaxValue);
            break;
          default:
            Main.dust[index2].color = new Color(190, 175, (int) byte.MaxValue);
            break;
        }
        SoundEngine.PlaySound(SoundID.FishSplash, (int) vector2.X, (int) vector2.Y, 5f);
      }
    }
    else if (honeyWet)
    {
      for (int index3 = 0; index3 < 10; ++index3)
      {
        int index4 = Dust.NewDust(new Vector2(vector2.X - 6f, (float) ((double) vector2.Y + (double) (num2 / 2) - 8.0)), num1 + 12, 24, 152);
        --Main.dust[index4].velocity.Y;
        Main.dust[index4].velocity.X *= 2.5f;
        Main.dust[index4].scale = 1.3f;
        Main.dust[index4].alpha = 100;
        Main.dust[index4].noGravity = true;
      }
      SoundEngine.PlaySound(SoundID.FishSplash, (int) vector2.X, (int) vector2.Y, 1f);
    }
    else if (lavaWet)
    {
      for (int index5 = 0; index5 < 10; ++index5)
      {
        int index6 = Dust.NewDust(new Vector2(vector2.X - 6f, (float) ((double) vector2.Y + (double) (num2 / 2) - 8.0)), num1 + 12, 24, 35);
        Main.dust[index6].velocity.Y -= 1.5f;
        Main.dust[index6].velocity.X *= 2.5f;
        Main.dust[index6].scale = 1.3f;
        Main.dust[index6].alpha = 100;
        Main.dust[index6].noGravity = true;
      }
      SoundEngine.PlaySound(SoundID.FishSplash, (int) vector2.X, (int) vector2.Y, 1f);
    }
    else
    {
      for (int index7 = 0; index7 < 10; ++index7)
      {
        int index8 = Dust.NewDust(new Vector2(vector2.X - 6f, vector2.Y + (float) (num2 / 2)), num1 + 12, 24, Dust.dustWater());
        Main.dust[index8].velocity.Y -= 4f;
        Main.dust[index8].velocity.X *= 2.5f;
        Main.dust[index8].scale = 1.3f;
        Main.dust[index8].alpha = 100;
        Main.dust[index8].noGravity = true;
      }
      SoundEngine.PlaySound(SoundID.FishSplash, (int) vector2.X, (int) vector2.Y, 1f);
    }
  }

  public void Update(ref ParticleRendererSettings settings)
  {
    if (this._delayTime-- >= 0)
      return;
    if (++this._lifeTimeCounted >= this._lifeTimeTotal)
      this.ShouldBeRemovedFromRenderer = true;
    if (--this._sonarTimeleft < 0)
      this._sonarTimeleft = 0;
    bool flag = Collision.WetCollision(this.Position, 2, 2);
    if (flag != this._wasWet)
      this.EmitWaterPulse();
    this._wasWet = flag;
    if (this._state == FakeFishParticle.State.Jumping)
    {
      this.Velocity.Y += 0.2f;
      this.Rotation = this.Velocity.ToRotation();
      this.Position += this.Velocity;
      if (--this._jumpTimeLeft > 0)
        return;
      this._state = FakeFishParticle.State.FreeRoaming;
      this.PickNewVelocity();
      this.Velocity *= 0.15f;
    }
    if ((double) this._lifeTimeCounted / (double) this._lifeTimeTotal >= 0.15000000596046448 && (double) this.Velocity.Length() < 0.10000000149011612 && --this._waitTime <= 0)
    {
      this._waitTime = Main.rand.Next(30, 121);
      this.PickNewVelocity();
      this._steerTime = Main.rand.Next(30, 121);
    }
    if (--this._steerTime > 0)
    {
      this.Velocity = Vector2.Lerp(this.Velocity, this.Rotation.ToRotationVector2() * 1f, 0.0333333351f);
      this.Velocity = Vector2.Lerp(this.Velocity, this._targetVelocity, 0.05f);
    }
    else if ((double) this.Velocity.Length() > 0.30000001192092896)
      this.Velocity *= 0.975f;
    if (this._state == FakeFishParticle.State.InterestedInBobber && (double) this.Position.Distance(this._bobberLocation) < 16.0)
    {
      this.Velocity *= 0.9f;
      if ((double) this.Velocity.Length() < 0.019999999552965164)
      {
        float num = (float) (0.30000001192092896 + 1.3999999761581421 * (double) Main.rand.NextFloat());
        this.Velocity = (this._bobberLocation - this.Position).SafeNormalize(Vector2.Zero) * -num;
      }
    }
    this.CheckLatch();
    if (this._state == FakeFishParticle.State.Latched)
    {
      Vector2 idealBobberPosition;
      Vector2 idealOffset;
      this.SetAndGetLatchDetails(out idealBobberPosition, out idealOffset);
      this.Position = Vector2.Lerp(this.Position, idealBobberPosition - idealOffset, 0.05f);
    }
    this.Position += this.Velocity;
    this.Rotate();
    int num1 = 20;
    if (this._lifeTimeTotal - this._lifeTimeCounted > num1 && !flag)
      this._lifeTimeCounted = this._lifeTimeTotal - num1;
    if ((double) this.Velocity.Y < 0.0 && !Collision.WetCollision(this.Position + new Vector2(0.0f, -20f), 0, 0))
    {
      this._steerTime = 0;
      this.Velocity.Y *= 0.92f;
    }
    if (this.Velocity != Vector2.Zero && !Collision.WetCollision(this.Position + this.Velocity.SafeNormalize(Vector2.Zero) * 32f, 0, 0))
    {
      this._steerTime = 0;
      this.PickNewVelocity();
      this.Velocity *= 0.92f;
    }
    if (!(this.Velocity != Vector2.Zero))
      return;
    for (float num2 = 0.0f; (double) num2 < 1.0; num2 += 0.25f)
    {
      Vector2 vector2 = (6.28318548f * num2).ToRotationVector2() * 16f;
      if ((double) Vector2.Dot(vector2, this.Velocity.SafeNormalize(Vector2.UnitY)) >= 0.0 && !Collision.WetCollision(this.Position + vector2, 0, 0))
      {
        this._steerTime = 0;
        this.PickNewVelocity();
        this.Velocity *= 0.92f;
        break;
      }
    }
  }

  private void SetAndGetLatchDetails(out Vector2 idealBobberPosition, out Vector2 idealOffset)
  {
    idealBobberPosition = this._latchedProjectile.Center + new Vector2(0.0f, 8f) + new Vector2(8f, 5f);
    Vector2 v = idealBobberPosition - this.Position;
    idealOffset = v.SafeNormalize(-Vector2.UnitY) * 6f;
    if ((double) idealOffset.Y > 0.0)
      idealOffset.Y *= -1f;
    idealOffset.Y -= 3f;
    idealOffset += new Vector2((float) (Math.Sign(v.X) * -4), 0.0f);
    this._targetVelocity = idealOffset;
    this._bobberLocation = idealBobberPosition;
    int num = (int) ((double) this._lifeTimeTotal * 0.85000002384185791);
    if (this._lifeTimeCounted <= num)
      return;
    this._lifeTimeCounted = num;
  }

  private void Rotate(bool instant = false)
  {
    float maxChange = 0.1f;
    if (this._isInanimate)
      maxChange *= 0.05f;
    if (instant)
      maxChange = 6.28318548f;
    if (this._state == FakeFishParticle.State.InterestedInBobber || this._state == FakeFishParticle.State.Latched)
    {
      this.Rotation = Utils.rotateTowards(this.Position, this.Rotation.ToRotationVector2(), this._bobberLocation, maxChange).ToRotation();
    }
    else
    {
      if (!(this.Velocity != Vector2.Zero))
        return;
      this.Rotation = Utils.rotateTowards(Vector2.Zero, this.Rotation.ToRotationVector2(), this.Velocity, maxChange).ToRotation();
    }
  }

  private void PickNewVelocity()
  {
    this._targetVelocity = Main.rand.NextVector2Circular(1.5f, 0.6f);
    if (this._state == FakeFishParticle.State.InterestedInBobber)
      this._targetVelocity = (this._bobberLocation - this.Position).SafeNormalize(-Vector2.UnitY) * (float) (0.699999988079071 + 0.5 * (double) Main.rand.NextFloat());
    if (this._state != FakeFishParticle.State.Latched)
      return;
    this._targetVelocity = (this._latchedProjectile.Center - this.Position).SafeNormalize(-Vector2.UnitY) * 0.7f;
  }

  public void Prepare(int itemType, int lifeTimeTotal, Vector2 bobberLocation)
  {
    this._itemInstance.SetDefaults(itemType);
    this._totalScale = (float) (0.60000002384185791 + 0.15000000596046448 * (double) Main.rand.NextFloat());
    this._bobberLocation = bobberLocation + new Vector2(0.0f, 8f);
    this._isInanimate = false;
    this._lifeTimeTotal = lifeTimeTotal;
    this._state = Main.rand.Next(3) != 0 ? FakeFishParticle.State.InterestedInBobber : FakeFishParticle.State.FreeRoaming;
    this._itemLooksDiagonal = ItemID.Sets.ReceivesDiagonalCorrectionAsFakeFish[itemType];
    if (ItemID.Sets.IsFishingCrate[itemType] || ItemID.Sets.FakeFishInanimate[itemType])
    {
      this._state = FakeFishParticle.State.FreeRoaming;
      this._isInanimate = true;
      this._itemLooksDiagonal = false;
    }
    this.PickNewVelocity();
    this._steerTime = Main.rand.Next(30, 121);
    this._wasWet = true;
    this._delayTime = 0;
  }

  public void TryJumping()
  {
    if (this._isInanimate)
      return;
    this._jumpTimeLeft = (int) ((double) this.Velocity.Y / -0.20000000298023224) * 2;
    this._state = FakeFishParticle.State.Jumping;
    this._delayTime = Main.rand.Next(0, 11);
  }

  public void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
  {
    Main.instance.LoadItem(this._itemInstance.type);
    float fromValue1 = (float) this._lifeTimeCounted / (float) this._lifeTimeTotal;
    float toMin = Utils.Remap(fromValue1, 0.1f, 0.5f, 0.0f, 0.85f);
    Utils.Remap(fromValue1, 0.5f, 0.9f, toMin, 1f);
    Vector2 position = settings.AnchorPosition + this.Position;
    float num1 = Utils.Remap(fromValue1, 0.0f, 0.25f, 0.0f, 1f) * Utils.Remap(fromValue1, 0.85f, 1f, 1f, 0.0f);
    Vector2 scale = new Vector2(this._itemInstance.scale * this._totalScale);
    Vector2 rotationVector2 = ((float) (6.2831854820251465 * (double) fromValue1 * 6.0)).ToRotationVector2();
    scale.X += rotationVector2.Y * 0.014f;
    scale.Y += rotationVector2.X * 0.012f;
    float rotation = this.Rotation;
    if (this._itemLooksDiagonal)
      rotation += 0.7853982f;
    SpriteEffects effects = SpriteEffects.None;
    Vector2 vector2 = this.Velocity;
    if (this._itemLooksDiagonal)
    {
      if (this._state == FakeFishParticle.State.InterestedInBobber)
        vector2 = this._targetVelocity;
      else if (this._state == FakeFishParticle.State.Latched)
        vector2 = this._targetVelocity;
    }
    if ((double) vector2.X < 0.0)
    {
      effects = SpriteEffects.FlipVertically;
      if (this._itemLooksDiagonal)
        rotation -= 1.57079637f;
    }
    Texture2D texture;
    Rectangle frame;
    Rectangle glowmaskFrame;
    Main.instance.DrawItem_GetBasics(this._itemInstance, 0, out texture, out frame, out glowmaskFrame);
    Color color1 = Color.Lerp(Color.White, Color.Black, 0.8f) * 0.7f;
    if (this._sonarStartTime > 0 && this._sonarTimeleft <= this._sonarStartTime && this._sonarTimeleft > 0)
    {
      float fromValue2 = (float) (1.0 - (double) this._sonarTimeleft / (double) this._sonarStartTime);
      float num2 = Utils.Remap(fromValue2, 0.0f, 0.2f, 0.0f, 1f) * Utils.Remap(fromValue2, 0.2f, 1f, 1f, 0.0f);
      color1 = Color.Lerp(color1, Color.White, this._isSelectedSonarType ? num2 : num2 * 0.4f);
      Color color2 = this._sonarColor * num2 * num1;
      for (float num3 = 0.0f; (double) num3 < 6.2831854820251465; num3 += 1.57079637f)
        spritebatch.Draw(texture, position + (num3 + rotation).ToRotationVector2() * 2f * scale, new Rectangle?(frame), color2, rotation, frame.Size() / 2f, scale, effects, 0.0f);
    }
    spritebatch.Draw(texture, position, new Rectangle?(frame), color1 * num1, rotation, frame.Size() / 2f, scale, effects, 0.0f);
    if (this._itemInstance.glowMask == (short) -1)
      return;
    spritebatch.Draw(TextureAssets.GlowMask[(int) this._itemInstance.glowMask].Value, position, new Rectangle?(glowmaskFrame), Color.Lerp(Color.White, Color.Black, 0.8f) * num1 * 0.7f, rotation, glowmaskFrame.Size() / 2f, scale, effects, 0.0f);
  }

  public bool IsRestingInPool { get; private set; }

  public void RestInPool() => this.IsRestingInPool = true;

  public virtual void FetchFromPool()
  {
    this._lifeTimeCounted = 0;
    this._lifeTimeTotal = 0;
    this.IsRestingInPool = false;
    this.ShouldBeRemovedFromRenderer = false;
    this.Position = this.Velocity = Vector2.Zero;
    this.Rotation = 0.0f;
    this._gotRepelled = false;
  }

  public void BeRepelled(ref ParticleRepelDetails details)
  {
    if (this._isInanimate || this._gotRepelled || this._state == FakeFishParticle.State.Jumping || this._state == FakeFishParticle.State.Latched)
      return;
    float fromValue = this.Position.Distance(details.SourcePosition) - details.Radius;
    if ((double) fromValue >= 100.0)
      return;
    float toMin = 2f;
    if (!this._gotRepelled || Main.rand.Next(10) == 0)
    {
      float num = Utils.Remap(fromValue, 100f, 0.0f, toMin, 5f);
      this.Velocity = this.Position.DirectionFrom(details.SourcePosition).SafeNormalize(this.Velocity.ToRotation().ToRotationVector2()).RotatedByRandom(0.78539818525314331) * num;
      this.Rotation = this.Velocity.ToRotation();
      this.Position -= this.Velocity;
      this._targetVelocity = this.Velocity;
      if (this.Velocity != Vector2.Zero && !Collision.WetCollision(this.Position + this.Velocity.SafeNormalize(Vector2.Zero) * 32f, 0, 0))
      {
        this._steerTime = 0;
        this.PickNewVelocity();
        this.Velocity = this._targetVelocity * 0.1f;
      }
    }
    this._delayTime = -1;
    this._steerTime = Main.rand.Next(30, 121);
    this._state = FakeFishParticle.State.FreeRoaming;
    this._gotRepelled = true;
    if ((double) this._lifeTimeCounted >= (double) this._lifeTimeTotal * 0.699999988079071)
      return;
    float amount = Utils.Remap((float) this._lifeTimeCounted / (float) this._lifeTimeTotal, 0.0f, 0.25f, 0.0f, 1f);
    float num1 = MathHelper.Lerp(1f, 0.85f, amount);
    if ((double) amount == 1.0)
      num1 = 0.7f;
    this._lifeTimeCounted = (int) ((double) this._lifeTimeTotal * (double) num1);
  }

  private enum State
  {
    FreeRoaming,
    InterestedInBobber,
    Latched,
    Jumping,
  }
}
