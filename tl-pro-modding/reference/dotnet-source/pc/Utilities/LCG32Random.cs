// Decompiled with JetBrains decompiler
// Type: Terraria.Utilities.LCG32Random
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;

#nullable disable
namespace Terraria.Utilities;

public struct LCG32Random(uint seed)
{
  public uint state = seed;

  public void Advance() => this.state = (uint) ((int) this.state * -1856014347 + 1);

  public uint Next(uint maxValue)
  {
    this.Advance();
    return (uint) ((ulong) this.state * (ulong) maxValue >> 32 /*0x20*/);
  }

  public int Next(int maxValue)
  {
    if (maxValue < 0)
      throw new ArgumentOutOfRangeException(nameof (maxValue), "maxValue must be positive.");
    return (int) this.Next((uint) maxValue);
  }

  public int Next(int minValue, int maxValue)
  {
    return minValue + (int) this.Next((uint) (maxValue - minValue));
  }

  public double NextDouble()
  {
    this.Advance();
    return (double) this.state / 4294967296.0;
  }

  public float NextFloat() => (float) this.NextDouble();
}
