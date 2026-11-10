// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.RGB.SandstormShader
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using ReLogic.Peripherals.RGB;

#nullable disable
namespace Terraria.GameContent.RGB;

public class SandstormShader : ChromaShader
{
  private readonly Vector4 _backColor = new Vector4(0.2f, 0.0f, 0.0f, 1f);
  private readonly Vector4 _frontColor = new Vector4(1f, 0.5f, 0.0f, 1f);

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
      Vector4 vector4 = Vector4.Lerp(this._backColor, this._frontColor, NoiseHelper.GetStaticNoise(fragment.GetCanvasPositionOfIndex(index) * 0.3f + new Vector2(time, -time) * 0.5f));
      fragment.SetColor(index, vector4);
    }
  }
}
