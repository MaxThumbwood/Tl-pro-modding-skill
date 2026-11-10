// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.RGB.WallOfFleshShader
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using ReLogic.Peripherals.RGB;
using System;

#nullable disable
namespace Terraria.GameContent.RGB;

public class WallOfFleshShader : ChromaShader
{
  private readonly Vector4 _primaryColor;
  private readonly Vector4 _secondaryColor;

  public WallOfFleshShader(Color primaryColor, Color secondaryColor)
  {
    this._primaryColor = primaryColor.ToVector4();
    this._secondaryColor = secondaryColor.ToVector4();
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
      Vector4 vector4 = Vector4.Lerp(this._secondaryColor, this._primaryColor, (float) Math.Sqrt((double) Math.Max(0.0f, (float) (1.0 - (double) NoiseHelper.GetDynamicNoise(fragment.GetCanvasPositionOfIndex(index) * 0.3f, time / 5f) * 2.0))) * 0.75f);
      fragment.SetColor(index, vector4);
    }
  }
}
