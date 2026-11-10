// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Skies.MoonLordSky
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria.Graphics.Effects;
using Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent.Skies;

public class MoonLordSky : CustomSky
{
  private UnifiedRandom _random = new UnifiedRandom();
  private bool _isActive;
  private bool _forPlayer;
  private float _fadeOpacity;

  public MoonLordSky(bool forPlayer) => this._forPlayer = forPlayer;

  public override void OnLoad()
  {
  }

  public override void Update(GameTime gameTime)
  {
    if (!this._forPlayer)
      return;
    if (this._isActive)
      this._fadeOpacity = Math.Min(1f, 0.01f + this._fadeOpacity);
    else
      this._fadeOpacity = Math.Max(0.0f, this._fadeOpacity - 0.01f);
  }

  private float GetIntensity()
  {
    if (this._forPlayer)
      return this._fadeOpacity;
    float? lordSkyIntensity = Main.SceneMetrics.MoonLordSkyIntensity;
    return lordSkyIntensity.HasValue ? lordSkyIntensity.Value : 0.0f;
  }

  public override Color OnTileColor(Color inColor)
  {
    float intensity = this.GetIntensity();
    return new Color(Vector4.Lerp(new Vector4(0.5f, 0.8f, 1f, 1f), inColor.ToVector4(), 1f - intensity));
  }

  public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
  {
    if ((double) maxDepth < 0.0 || (double) minDepth >= 0.0)
      return;
    float intensity = this.GetIntensity();
    spriteBatch.Draw(TextureAssets.BlackTile.Value, new Rectangle(0, 0, Main.screenWidth, Main.screenHeight), Color.Black * intensity);
  }

  public override float GetCloudAlpha() => 1f - this._fadeOpacity;

  public override void Activate(Vector2 position, params object[] args)
  {
    this._isActive = true;
    if (this._forPlayer)
      this._fadeOpacity = 1f / 500f;
    else
      this._fadeOpacity = 1f;
  }

  public override void Deactivate(params object[] args)
  {
    this._isActive = false;
    if (this._forPlayer)
      return;
    this._fadeOpacity = 0.0f;
  }

  public override void Reset()
  {
    this._isActive = false;
    this._fadeOpacity = 0.0f;
  }

  public override bool IsActive() => this._isActive || (double) this._fadeOpacity > 1.0 / 1000.0;
}
