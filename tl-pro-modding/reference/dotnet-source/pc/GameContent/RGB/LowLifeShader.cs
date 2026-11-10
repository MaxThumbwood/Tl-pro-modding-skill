// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.RGB.LowLifeShader
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using ReLogic.Peripherals.RGB;
using System;

#nullable disable
namespace Terraria.GameContent.RGB;

public class LowLifeShader : ChromaShader
{
  private static Vector4 _baseColor = new Color(40, 0, 8, (int) byte.MaxValue).ToVector4();

  [RgbProcessor]
  private void ProcessAnyDetail(
    RgbDevice device,
    Fragment fragment,
    EffectDetailLevel quality,
    float time)
  {
    float num = (float) (Math.Cos((double) time * 3.1415927410125732) * 0.30000001192092896 + 0.699999988079071);
    Vector4 vector4 = (LowLifeShader._baseColor * num) with
    {
      W = LowLifeShader._baseColor.W
    };
    for (int index = 0; index < fragment.Count; ++index)
      fragment.SetColor(index, vector4);
  }
}
