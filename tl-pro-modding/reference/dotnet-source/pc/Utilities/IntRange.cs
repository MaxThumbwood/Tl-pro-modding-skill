// Decompiled with JetBrains decompiler
// Type: Terraria.Utilities.IntRange
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Newtonsoft.Json;

#nullable disable
namespace Terraria.Utilities;

public struct IntRange(int minimum, int maximum)
{
  [JsonProperty("Min")]
  public readonly int Minimum = minimum;
  [JsonProperty("Max")]
  public readonly int Maximum = maximum;

  public static IntRange operator *(IntRange range, float scale)
  {
    return new IntRange((int) ((double) range.Minimum * (double) scale), (int) ((double) range.Maximum * (double) scale));
  }

  public static IntRange operator *(float scale, IntRange range) => range * scale;

  public static IntRange operator /(IntRange range, float scale)
  {
    return new IntRange((int) ((double) range.Minimum / (double) scale), (int) ((double) range.Maximum / (double) scale));
  }

  public static IntRange operator /(float scale, IntRange range) => range / scale;
}
