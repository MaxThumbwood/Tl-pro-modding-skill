// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.Renderers.LittleFlyingCritterParticle
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria.GameContent;

#nullable disable
namespace Terraria.Graphics.Renderers;

public class LittleFlyingCritterParticle : IPooledParticle, IParticle, IParticleRepel
{
  private int _lifeTimeCounted;
  private int _lifeTimeTotal;
  private Vector2 _spawnPosition;
  private Vector2 _localPosition;
  private Vector2 _velocity;
  private float _neverGoBelowThis;
  private Vector2 _addedVelocity;
  private int _repelLifetimeDecay;
  private Color _overrideColor;
  private LittleFlyingCritterParticle.FlyType _type;
  private int _variantRow;
  private int _variantColumn;

  public bool IsRestingInPool { get; private set; }

  public bool ShouldBeRemovedFromRenderer { get; private set; }

  public void Prepare(
    LittleFlyingCritterParticle.FlyType type,
    Vector2 position,
    int duration,
    Color overrideColor = default (Color),
    int repelLifetimeDecay = 0)
  {
    this._type = type;
    this._variantRow = Main.rand.Next(8);
    this._variantColumn = Main.rand.Next(5) == 0 ? 1 : 0;
    this._spawnPosition = position;
    this._localPosition = position + Main.rand.NextVector2Circular(4f, 8f);
    this._neverGoBelowThis = position.Y + 8f;
    this.RandomizeVelocity();
    this._lifeTimeCounted = 0;
    this._lifeTimeTotal = 300 + Main.rand.Next(6) * 60;
    this._overrideColor = overrideColor;
    this._repelLifetimeDecay = repelLifetimeDecay;
  }

  private void RandomizeVelocity() => this._velocity = Main.rand.NextVector2Circular(1f, 1f);

  public void RestInPool() => this.IsRestingInPool = true;

  public virtual void FetchFromPool()
  {
    this.IsRestingInPool = false;
    this.ShouldBeRemovedFromRenderer = false;
    this._addedVelocity = Vector2.Zero;
  }

  public void Update(ref ParticleRendererSettings settings)
  {
    if (++this._lifeTimeCounted >= this._lifeTimeTotal)
      this.ShouldBeRemovedFromRenderer = true;
    float num1 = 0.02f;
    int num2 = 30;
    if (this._type == LittleFlyingCritterParticle.FlyType.ButterFly)
    {
      num1 = 0.01f;
      num2 = 600;
    }
    this._velocity += new Vector2((float) Math.Sign(this._spawnPosition.X - this._localPosition.X) * num1, (float) Math.Sign(this._spawnPosition.Y - this._localPosition.Y) * num1);
    if (this._lifeTimeCounted % num2 == 0 && Main.rand.Next(2) == 0)
    {
      this.RandomizeVelocity();
      if (Main.rand.Next(2) == 0)
        this._velocity /= 2f;
    }
    this._addedVelocity *= 0.98f;
    if ((double) this._addedVelocity.Length() < 0.0099999997764825821)
      this._addedVelocity = new Vector2(0.0f, 0.0f);
    this._localPosition += this._velocity + this._addedVelocity;
    if ((double) this._localPosition.Y <= (double) this._neverGoBelowThis)
      return;
    this._localPosition.Y = this._neverGoBelowThis;
    if ((double) this._velocity.Y > 0.0)
      this._velocity.Y *= -1f;
    if ((double) this._addedVelocity.Y <= 0.0)
      return;
    this._addedVelocity.Y *= -1f;
  }

  public void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
  {
    Vector2 vector2 = settings.AnchorPosition + this._localPosition;
    if ((double) vector2.X < -10.0 || (double) vector2.X > (double) (Main.screenWidth + 10) || (double) vector2.Y < -10.0 || (double) vector2.Y > (double) (Main.screenHeight + 10))
    {
      this.ShouldBeRemovedFromRenderer = true;
    }
    else
    {
      switch (this._type)
      {
        case LittleFlyingCritterParticle.FlyType.RegularFly:
          this.Draw_Fly(ref settings, spritebatch);
          break;
        case LittleFlyingCritterParticle.FlyType.ButterFly:
          this.Draw_ButterFly(ref settings, spritebatch);
          break;
      }
    }
  }

  private void Draw_ButterFly(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
  {
    Vector2 vector2 = this._velocity + this._addedVelocity;
    Texture2D texture = TextureAssets.Extra[281].Value;
    int num1 = this._lifeTimeCounted % 10 / 5;
    int variantRow = this._variantRow;
    bool flag = this._variantColumn == 1;
    Rectangle r = new Rectangle(flag ? 10 : 0, (variantRow * 2 + num1) * 10, flag ? 14 : 8, 8);
    Vector2 origin = r.Size() / 2f;
    float num2 = Utils.Remap((float) this._lifeTimeCounted, 0.0f, 90f, 0.0f, 1f) * Utils.Remap((float) this._lifeTimeCounted, (float) (this._lifeTimeTotal - 90), (float) this._lifeTimeTotal, 1f, 0.0f);
    Color color1 = Lighting.GetColor(this._localPosition.ToTileCoordinates());
    this._overrideColor = Color.White;
    Color color2 = new Color(this._overrideColor.ToVector4() * color1.ToVector4());
    float scale = 0.75f;
    spritebatch.Draw(texture, settings.AnchorPosition + this._localPosition, new Rectangle?(r), color2 * num2, 0.0f, origin, scale, (double) vector2.X < 0.0 ? SpriteEffects.FlipHorizontally : SpriteEffects.None, 0.0f);
  }

  private void Draw_Fly(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
  {
    Vector2 vector2 = this._velocity + this._addedVelocity;
    Texture2D texture2D = TextureAssets.Extra[262].Value;
    int frameY = this._lifeTimeCounted % 6 / 3;
    Rectangle rectangle = texture2D.Frame(verticalFrames: 6, frameY: frameY);
    Vector2 origin = new Vector2((double) vector2.X > 0.0 ? 3f : 1f, 3f);
    float num = Utils.Remap((float) this._lifeTimeCounted, 0.0f, 90f, 0.0f, 1f) * Utils.Remap((float) this._lifeTimeCounted, (float) (this._lifeTimeTotal - 90), (float) this._lifeTimeTotal, 1f, 0.0f);
    Color color1 = Lighting.GetColor(this._localPosition.ToTileCoordinates());
    if (this._overrideColor == new Color())
    {
      spritebatch.Draw(texture2D, settings.AnchorPosition + this._localPosition, new Rectangle?(rectangle), color1 * num, 0.0f, origin, 1f, (double) vector2.X > 0.0 ? SpriteEffects.FlipHorizontally : SpriteEffects.None, 0.0f);
    }
    else
    {
      Color color2 = new Color(this._overrideColor.ToVector4() * color1.ToVector4());
      rectangle.Offset(0, 12);
      spritebatch.Draw(texture2D, settings.AnchorPosition + this._localPosition, new Rectangle?(rectangle), color2 * num, 0.0f, origin, 1f, (double) vector2.X > 0.0 ? SpriteEffects.FlipHorizontally : SpriteEffects.None, 0.0f);
      rectangle.Offset(0, 12);
      spritebatch.Draw(texture2D, settings.AnchorPosition + this._localPosition, new Rectangle?(rectangle), color1 * num, 0.0f, origin, 1f, (double) vector2.X > 0.0 ? SpriteEffects.FlipHorizontally : SpriteEffects.None, 0.0f);
    }
  }

  public void BeRepelled(ref ParticleRepelDetails details)
  {
    float num = Utils.Remap(this._localPosition.Distance(details.SourcePosition) - details.Radius, 0.0f, 100f, 1f, 0.0f);
    if ((double) num <= 0.0)
      return;
    this._addedVelocity = this._localPosition.DirectionFrom(details.SourcePosition).SafeNormalize(-Vector2.UnitY).RotatedByRandom(0.52359879016876221) * 3.5f * num;
    this._lifeTimeCounted += this._repelLifetimeDecay;
  }

  public enum FlyType
  {
    RegularFly,
    ButterFly,
  }
}
