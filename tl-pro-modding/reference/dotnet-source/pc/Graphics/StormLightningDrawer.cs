// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.StormLightningDrawer
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;
using Terraria.Utilities.Terraria.Utilities;

#nullable disable
namespace Terraria.Graphics;

public struct StormLightningDrawer
{
  private static VertexStrip _vertexStrip = new VertexStrip();
  private float _width;
  private Color _color;
  private bool _isMainBolt;
  private float _progress;
  private FloatRange _progressRange;
  private bool _taperEnd;

  public void Draw(
    Vector2[] positions,
    float[] rotations,
    float width,
    Color color,
    float progress,
    bool isMainBolt,
    FloatRange progressRange,
    float intensity)
  {
    this._width = width;
    this._color = color;
    this._isMainBolt = isMainBolt;
    this._progress = progress;
    this._progressRange = progressRange;
    this._taperEnd = (double) this._progressRange.Maximum < 1.0;
    MiscShaderData miscShaderData = GameShaders.Misc["StormLightning"];
    miscShaderData.UseSaturation(intensity);
    miscShaderData.UseOpacity(Utils.Remap(this._progress, 0.1f, 0.25f, 0.5f, 1f) * Utils.Remap(this._progress, 0.25f, 0.75f, 1f, 0.0f));
    miscShaderData.Apply(new DrawData?());
    StormLightningDrawer._vertexStrip.PrepareStrip(positions, rotations, new VertexStrip.StripColorFunction(this.StripColors), new VertexStrip.StripHalfWidthFunction(this.StripWidth), -Main.screenPosition);
    StormLightningDrawer._vertexStrip.DrawTrail();
    Main.graphics.GraphicsDevice.SamplerStates[0] = SamplerState.PointClamp;
    Main.pixelShader.CurrentTechnique.Passes[0].Apply();
  }

  private static float WaveTransition(
    float progressOnStrip,
    float waveProgress,
    float transitionLength,
    float from,
    float to)
  {
    return Utils.Remap(progressOnStrip, MathHelper.Lerp(-transitionLength, 1f, waveProgress), MathHelper.Lerp(0.0f, 1f + transitionLength, waveProgress), to, from);
  }

  private Color StripColors(float progressOnStrip)
  {
    progressOnStrip = this._progressRange.Lerp(progressOnStrip);
    float waveProgress1 = Utils.Remap(this._progress, 0.0f, 0.15f, 0.0f, 1f);
    double num1 = (double) StormLightningDrawer.WaveTransition(progressOnStrip, waveProgress1, 0.5f, 0.0f, 1f);
    float waveProgress2 = Utils.Remap(this._progress, 0.25f, 1f, 0.0f, 1f);
    double num2 = (double) StormLightningDrawer.WaveTransition(progressOnStrip, waveProgress2, 0.5f, 1f, 0.0f);
    return this._color * (float) (num1 * num2);
  }

  private float StripWidth(float progressOnStrip)
  {
    progressOnStrip = this._progressRange.Lerp(progressOnStrip);
    float num = this._width * Utils.Remap(progressOnStrip, 0.5f, 1f, 1f, 0.5f) * Utils.Remap(this._progress, 0.5f, 1f, 1f, 0.5f);
    if (this._taperEnd)
      num *= Utils.Remap(this._progressRange.Maximum - progressOnStrip, 0.1f, 0.0f, 1f, this._isMainBolt ? 0.5f : 0.0f);
    return num;
  }
}
