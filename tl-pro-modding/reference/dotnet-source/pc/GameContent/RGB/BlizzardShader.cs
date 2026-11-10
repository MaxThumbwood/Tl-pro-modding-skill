// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.RGB.BlizzardShader
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using ReLogic.Peripherals.RGB;

#nullable disable
namespace Terraria.GameContent.RGB;

public class BlizzardShader : ChromaShader
{
  private readonly Vector4 _backColor = new Vector4(0.1f, 0.1f, 0.3f, 1f);
  private readonly Vector4 _frontColor = new Vector4(1f, 1f, 1f, 1f);
  private readonly float _timeScaleX;
  private readonly float _timeScaleY;

  public BlizzardShader(Vector4 frontColor, Vector4 backColor, float panSpeedX, float panSpeedY)
  {
    this._frontColor = frontColor;
    this._backColor = backColor;
    this._timeScaleX = panSpeedX;
    this._timeScaleY = panSpeedY;
  }

  [RgbProcessor]
  private void ProcessHighDetail(
    RgbDevice device,
    Fragment fragment,
    EffectDetailLevel quality,
    float time)
  {
    if (quality == null)
      time *= 0.25f;
    for (int index = 0; index < fragment.Count; ++index)
    {
      float staticNoise = NoiseHelper.GetStaticNoise(fragment.GetCanvasPositionOfIndex(index) * new Vector2(0.2f, 0.4f) + new Vector2(time * this._timeScaleX, time * this._timeScaleY));
      Vector4 vector4 = Vector4.Lerp(this._backColor, this._frontColor, staticNoise * staticNoise);
      fragment.SetColor(index, vector4);
    }
  }
}
