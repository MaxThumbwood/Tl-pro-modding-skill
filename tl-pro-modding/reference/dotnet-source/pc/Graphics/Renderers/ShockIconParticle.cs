// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.Renderers.ShockIconParticle
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent;

#nullable disable
namespace Terraria.Graphics.Renderers;

public class ShockIconParticle : ABasicParticle
{
  public float FadeInNormalizedTime = 0.25f;
  public float FadeOutNormalizedTime = 0.75f;
  public float TimeToLive = 20f;
  public float Opacity;
  public float InitialScale = 1f;
  public Color ColorTint = Color.White;
  public int ParentProjectileID = -1;
  public Vector2 OffsetFromParent;
  private Vector2 initialPosition;
  private float _timeSinceSpawn;

  public override void FetchFromPool()
  {
    base.FetchFromPool();
    this._timeSinceSpawn = 0.0f;
    this.Opacity = 0.0f;
    this.FadeInNormalizedTime = 0.1f;
    this.FadeOutNormalizedTime = 0.9f;
    this.TimeToLive = 20f;
    this.InitialScale = 1f;
    this.ColorTint = Color.White;
  }

  public override void Update(ref ParticleRendererSettings settings)
  {
    if ((double) this._timeSinceSpawn == 0.0)
      this.initialPosition = this.LocalPosition;
    base.Update(ref settings);
    ++this._timeSinceSpawn;
    float num = this._timeSinceSpawn / this.TimeToLive;
    this.Scale = Vector2.One * this.InitialScale * Utils.MultiLerp(num, 0.2f, 0.9f, 1.3f, 0.9f);
    this.Opacity = MathHelper.Clamp(Utils.Remap(num, 0.0f, this.FadeInNormalizedTime, 0.0f, 1f) * Utils.Remap(num, this.FadeOutNormalizedTime, 1f, 1f, 0.0f), 0.0f, 1f) * 0.5f;
    if (this.ParentProjectileID != -1 && this.ParentProjectileID >= 0 && this.ParentProjectileID < 1000)
      this.LocalPosition = Main.projectile[this.ParentProjectileID].Top + num * this.OffsetFromParent;
    else
      this.LocalPosition = this.initialPosition + num * this.OffsetFromParent;
    if ((double) this._timeSinceSpawn < (double) this.TimeToLive)
      return;
    this.ShouldBeRemovedFromRenderer = true;
  }

  public override void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
  {
    Vector2 position = settings.AnchorPosition + this.LocalPosition;
    Texture2D texture2D = TextureAssets.Extra[268].Value;
    Vector2 origin = new Vector2((float) (texture2D.Width / 2), (float) (texture2D.Height / 2));
    Vector2 scale = this.Scale;
    Color color = Color.Lerp(Lighting.GetColor(this.LocalPosition.ToTileCoordinates()).MultiplyRGBA(this.ColorTint), this.ColorTint, 0.75f) * this.Opacity;
    spritebatch.Draw(texture2D, position, new Rectangle?(texture2D.Frame()), color, this.Rotation, origin, scale, SpriteEffects.None, 0.0f);
  }
}
