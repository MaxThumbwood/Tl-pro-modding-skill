// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.Renderers.BloodyExplosionParticle
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent;

#nullable disable
namespace Terraria.Graphics.Renderers;

public class BloodyExplosionParticle : ABasicParticle
{
  public float FadeInNormalizedTime = 0.25f;
  public float FadeOutNormalizedTime = 0.75f;
  public float TimeToLive = 20f;
  public float Opacity;
  public float InnerOpacity;
  public float InitialScale = 1f;
  public Color ColorTint = Color.White;
  public Color LightColorTint = Color.Transparent;
  private float _timeSinceSpawn;

  public override void FetchFromPool()
  {
    base.FetchFromPool();
    this._timeSinceSpawn = 0.0f;
    this.Opacity = 0.0f;
    this.InnerOpacity = 0.0f;
    this.FadeInNormalizedTime = 0.1f;
    this.FadeOutNormalizedTime = 0.9f;
    this.TimeToLive = 20f;
    this.InitialScale = 1f;
    this.ColorTint = Color.White;
    this.LightColorTint = Color.Transparent;
  }

  public override void Update(ref ParticleRendererSettings settings)
  {
    base.Update(ref settings);
    ++this._timeSinceSpawn;
    float fromValue = this._timeSinceSpawn / this.TimeToLive;
    this.Scale = Vector2.One * this.InitialScale * Utils.Remap(fromValue, 0.0f, 0.3f, 0.5f, 1f);
    float num = 0.4f;
    this.Opacity = MathHelper.Clamp(Utils.Remap(fromValue, 0.0f, this.FadeInNormalizedTime, 0.0f, 1f) * Utils.Remap(fromValue, this.FadeOutNormalizedTime, 1f, 1f, 0.0f), 0.0f, 1f) * num;
    this.InnerOpacity = MathHelper.Clamp(Utils.Remap(fromValue, 0.0f, this.FadeInNormalizedTime * 0.75f, 0.0f, 1f) * Utils.Remap(fromValue, 0.3f, 0.45f, 1f, 0.0f), 0.0f, 1f) * num;
    if ((double) this._timeSinceSpawn == 3.0)
    {
      Rectangle r = Utils.CenteredRectangle(this.LocalPosition, new Vector2(16f, 16f));
      for (int index = 0; index < 50; ++index)
      {
        Vector2 vector2 = Main.rand.NextVector2CircularEdge(4f, 4f);
        if (index % 2 == 0)
          vector2 *= 0.5f;
        Dust dust = Main.dust[Dust.NewDust(r.TopLeft(), r.Width, r.Height, 5, Alpha: 100, Scale: (float) (1.25 + (double) Main.rand.NextFloat() * 0.5))];
        dust.velocity = vector2;
        dust.noGravity = index % 3 == 0;
      }
    }
    if (this.LightColorTint != Color.Transparent)
    {
      Color color = this.LightColorTint * this.Opacity;
      Lighting.AddLight(this.LocalPosition, (float) color.R / (float) byte.MaxValue, (float) color.G / (float) byte.MaxValue, (float) color.B / (float) byte.MaxValue);
    }
    if ((double) this._timeSinceSpawn < (double) this.TimeToLive)
      return;
    this.ShouldBeRemovedFromRenderer = true;
  }

  public override void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
  {
    float num = this._timeSinceSpawn / this.TimeToLive;
    Vector2 position = settings.AnchorPosition + this.LocalPosition;
    Color color1 = Color.Lerp(Lighting.GetColor(this.LocalPosition.ToTileCoordinates()).MultiplyRGBA(this.ColorTint), this.ColorTint, 0.65f);
    Texture2D texture2D1 = TextureAssets.Extra[174].Value;
    Vector2 origin1 = new Vector2((float) (texture2D1.Width / 2), (float) (texture2D1.Height / 2));
    Vector2 scale1 = this.Scale * (float) (1.1000000238418579 + 0.15000000596046448 * (double) num);
    Color color2 = color1 * this.Opacity;
    Texture2D texture2D2 = TextureAssets.Extra[267].Value;
    Vector2 origin2 = new Vector2((float) (texture2D2.Width / 2), (float) (texture2D2.Height / 2));
    Vector2 scale2 = this.Scale * (float) (1.0 + 0.05000000074505806 * (double) num);
    Color color3 = color1 * this.InnerOpacity;
    spritebatch.Draw(texture2D1, position, new Rectangle?(texture2D1.Frame()), color2, this.Rotation, origin1, scale1, SpriteEffects.None, 0.0f);
    spritebatch.Draw(texture2D2, position, new Rectangle?(texture2D2.Frame()), color3, this.Rotation, origin2, scale2, SpriteEffects.None, 0.0f);
  }
}
