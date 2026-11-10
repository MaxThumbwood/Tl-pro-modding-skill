// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.Renderers.FadingPlayerShaderParticle
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;

#nullable disable
namespace Terraria.Graphics.Renderers;

public class FadingPlayerShaderParticle : FadingParticle
{
  private Player _player;
  private int _shader;

  public override void FetchFromPool()
  {
    base.FetchFromPool();
    this._player = (Player) null;
    this._shader = 0;
  }

  public void SetTypeInfo(float timeToLive, Player player, int shader, bool fullbright = true)
  {
    this.SetTypeInfo(timeToLive, fullbright);
    this._player = player;
    this._shader = shader;
  }

  public override void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
  {
    if (this._player == null || this._shader == 0)
    {
      base.Draw(ref settings, spritebatch);
    }
    else
    {
      Effect pixelShader = Main.pixelShader;
      Color color = (this.fullbright ? this.ColorTint : this.ColorTint.MultiplyRGB(Lighting.GetColor(this.LocalPosition.ToTileCoordinates()))) * Utils.GetLerpValue(0.0f, this.FadeInNormalizedTime, this.timeSinceSpawn / this.timeTolive, true) * Utils.GetLerpValue(1f, this.FadeOutNormalizedTime, this.timeSinceSpawn / this.timeTolive, true);
      PlayerDrawHelper.SetShaderForData(this._player, this._shader, ref new DrawData()
      {
        texture = this._texture.Value,
        sourceRect = new Rectangle?(this._texture.Frame()),
        shader = this._shader
      });
      spritebatch.Draw(this._texture.Value, settings.AnchorPosition + this.LocalPosition, new Rectangle?(this._frame), color, this.Rotation, this._origin, this.Scale, SpriteEffects.None, 0.0f);
      pixelShader.CurrentTechnique.Passes[0].Apply();
    }
  }
}
