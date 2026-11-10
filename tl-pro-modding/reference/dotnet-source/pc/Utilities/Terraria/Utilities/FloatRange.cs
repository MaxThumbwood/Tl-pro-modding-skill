// Decompiled with JetBrains decompiler
// Type: Terraria.Utilities.Terraria.Utilities.FloatRange
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Newtonsoft.Json;

#nullable disable
namespace Terraria.Utilities.Terraria.Utilities;

public struct FloatRange(float minimum, float maximum)
{
  [JsonProperty("Min")]
  public readonly float Minimum = minimum;
  [JsonProperty("Max")]
  public readonly float Maximum = maximum;

  public bool Contains(float f)
  {
    return (double) this.Minimum <= (double) f && (double) f <= (double) this.Maximum;
  }

  public float Lerp(float amount) => MathHelper.Lerp(this.Minimum, this.Maximum, amount);

  public static FloatRange operator *(FloatRange range, float scale)
  {
    return new FloatRange(range.Minimum * scale, range.Maximum * scale);
  }

  public static FloatRange operator *(float scale, FloatRange range) => range * scale;

  public static FloatRange operator /(FloatRange range, float scale)
  {
    return new FloatRange(range.Minimum / scale, range.Maximum / scale);
  }

  public static FloatRange operator /(float scale, FloatRange range) => range / scale;
}
