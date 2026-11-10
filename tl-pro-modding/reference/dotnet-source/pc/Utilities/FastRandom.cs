// Decompiled with JetBrains decompiler
// Type: Terraria.Utilities.FastRandom
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;

#nullable disable
namespace Terraria.Utilities;

public struct FastRandom
{
  private const ulong RANDOM_MULTIPLIER = 25214903917;
  private const ulong RANDOM_ADD = 11;
  private const ulong RANDOM_MASK = 281474976710655 /*0xFFFFFFFFFFFF*/;

  public ulong Seed { get; private set; }

  public FastRandom(ulong seed)
    : this()
  {
    this.Seed = seed;
  }

  public FastRandom(int seed)
    : this()
  {
    this.Seed = (ulong) seed;
  }

  public FastRandom WithModifier(ulong modifier)
  {
    return new FastRandom(FastRandom.NextSeed(modifier) ^ this.Seed);
  }

  public FastRandom WithModifier(int x, int y)
  {
    return this.WithModifier((ulong) ((long) x + 2654435769L + ((long) y << 6)) + ((ulong) y >> 2));
  }

  public static FastRandom CreateWithRandomSeed()
  {
    return new FastRandom((ulong) Guid.NewGuid().GetHashCode());
  }

  public void NextSeed() => this.Seed = FastRandom.NextSeed(this.Seed);

  private int NextBits(int bits)
  {
    this.Seed = FastRandom.NextSeed(this.Seed);
    return (int) (this.Seed >> 48 /*0x30*/ - bits);
  }

  public float NextFloat() => (float) this.NextBits(24) * 5.96046448E-08f;

  public double NextDouble() => (double) this.NextBits(32 /*0x20*/) * 4.6566128730773926E-10;

  public int Next(int max)
  {
    if ((max & -max) == max)
      return (int) ((long) max * (long) this.NextBits(31 /*0x1F*/) >> 31 /*0x1F*/);
    int num1;
    int num2;
    do
    {
      num1 = this.NextBits(31 /*0x1F*/);
      num2 = num1 % max;
    }
    while (num1 - num2 + (max - 1) < 0);
    return num2;
  }

  public int Next(int min, int max) => this.Next(max - min) + min;

  private static ulong NextSeed(ulong seed)
  {
    return (ulong) ((long) seed * 25214903917L + 11L & 281474976710655L /*0xFFFFFFFFFFFF*/);
  }
}
