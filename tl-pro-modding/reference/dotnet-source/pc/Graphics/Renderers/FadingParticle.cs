// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.Renderers.FadingParticle
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

#nullable disable
namespace Terraria.Graphics.Renderers;

public class FadingParticle : ABasicParticle
{
  public float FadeInNormalizedTime;
  public float FadeOutNormalizedTime = 1f;
  public Color ColorTint = Color.White;
  public int Delay;
  protected float timeTolive;
  protected float timeSinceSpawn;
  protected bool fullbright = true;
  public int followPlayerIndex = -1;

  public override void FetchFromPool()
  {
    base.FetchFromPool();
    this.FadeInNormalizedTime = 0.0f;
    this.FadeOutNormalizedTime = 1f;
    this.ColorTint = Color.White;
    this.timeTolive = 0.0f;
    this.timeSinceSpawn = 0.0f;
    this.followPlayerIndex = -1;
    this.Delay = 0;
  }

  public void SetTypeInfo(float timeToLive, bool fullbright = true)
  {
    this.timeTolive = timeToLive;
    this.fullbright = fullbright;
  }

  public override void Update(ref ParticleRendererSettings settings)
  {
    if (this.Delay > 0)
    {
      --this.Delay;
    }
    else
    {
      base.Update(ref settings);
      ++this.timeSinceSpawn;
      if ((double) this.timeSinceSpawn < (double) this.timeTolive)
        return;
      this.ShouldBeRemovedFromRenderer = true;
    }
  }

  public override void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
  {
    Vector2 position = settings.AnchorPosition + this.LocalPosition;
    if (this.followPlayerIndex != -1)
      position += Main.player[this.followPlayerIndex].MountedCenter;
    Color color = (this.fullbright ? this.ColorTint : this.ColorTint.MultiplyRGB(Lighting.GetColor(this.LocalPosition.ToTileCoordinates()))) * Utils.GetLerpValue(0.0f, this.FadeInNormalizedTime, this.timeSinceSpawn / this.timeTolive, true) * Utils.GetLerpValue(1f, this.FadeOutNormalizedTime, this.timeSinceSpawn / this.timeTolive, true);
    spritebatch.Draw(this._texture.Value, position, new Rectangle?(this._frame), color, this.Rotation, this._origin, this.Scale, SpriteEffects.None, 0.0f);
  }
}
