// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.Effects.Filter
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Terraria.Graphics.Shaders;

#nullable disable
namespace Terraria.Graphics.Effects;

public class Filter : GameEffect
{
  public bool Active;
  private ScreenShaderData _shader;
  public bool IsHidden;

  public Filter(ScreenShaderData shader, EffectPriority priority = EffectPriority.VeryLow)
  {
    this._shader = shader;
    this._priority = priority;
  }

  public void Update(GameTime gameTime)
  {
    this._shader.UseGlobalOpacity(this.Opacity);
    this._shader.Update(gameTime);
  }

  public void Apply(Vector2 textureSize, Vector2 sceneSize, Vector2 sceneOffset)
  {
    this._shader.UseSceneSize(sceneSize).UseSceneOffset(sceneOffset).UseImageSize0(textureSize).Apply();
  }

  public ScreenShaderData GetShader() => this._shader;

  public override void Activate(Vector2 position, params object[] args)
  {
    this._shader.UseGlobalOpacity(this.Opacity);
    this._shader.UseTargetPosition(position);
    this.Active = true;
  }

  public override void Deactivate(params object[] args) => this.Active = false;

  public bool IsInUse() => this.Active || (double) this.Opacity > 0.0;

  public bool IsActive() => this.Active;

  public override bool IsVisible()
  {
    return (double) this.GetShader().CombinedOpacity > 0.0 && !this.IsHidden;
  }
}
