// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.RGB.IceShader
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using ReLogic.Peripherals.RGB;
using System;

#nullable disable
namespace Terraria.GameContent.RGB;

public class IceShader : ChromaShader
{
  private readonly Vector4 _baseColor;
  private readonly Vector4 _iceColor;
  private readonly Vector4 _shineColor = new Vector4(1f, 1f, 0.7f, 1f);

  public IceShader(Color baseColor, Color iceColor)
  {
    this._baseColor = baseColor.ToVector4();
    this._iceColor = iceColor.ToVector4();
  }

  [RgbProcessor]
  private void ProcessHighDetail(
    RgbDevice device,
    Fragment fragment,
    EffectDetailLevel quality,
    float time)
  {
    for (int index = 0; index < fragment.Count; ++index)
    {
      Vector2 canvasPositionOfIndex = fragment.GetCanvasPositionOfIndex(index);
      float amount1 = Math.Max(0.0f, (float) (1.0 - (double) NoiseHelper.GetDynamicNoise(new Vector2((float) (((double) canvasPositionOfIndex.X - (double) canvasPositionOfIndex.Y) * 0.20000000298023224), 0.0f), time / 5f) * 1.5));
      float amount2 = Math.Max(0.0f, (float) (1.0 - (double) NoiseHelper.GetDynamicNoise(new Vector2((float) (((double) canvasPositionOfIndex.X - (double) canvasPositionOfIndex.Y) * 0.30000001192092896), 0.3f), time / 20f) * 5.0));
      Vector4 vector4 = Vector4.Lerp(Vector4.Lerp(this._baseColor, this._iceColor, amount1), this._shineColor, amount2);
      fragment.SetColor(index, vector4);
    }
  }
}
