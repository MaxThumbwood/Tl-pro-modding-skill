// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.RGB.NoiseHelper
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;
using Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent.RGB;

public static class NoiseHelper
{
  private const int RANDOM_SEED = 1;
  private const int NOISE_2D_SIZE = 32 /*0x20*/;
  private const int NOISE_2D_SIZE_MASK = 31 /*0x1F*/;
  private const int NOISE_SIZE_MASK = 1023 /*0x03FF*/;
  private static readonly float[] StaticNoise = NoiseHelper.CreateStaticNoise(1024 /*0x0400*/);

  private static float[] CreateStaticNoise(int length)
  {
    UnifiedRandom r = new UnifiedRandom(1);
    float[] staticNoise = new float[length];
    for (int index = 0; index < staticNoise.Length; ++index)
      staticNoise[index] = r.NextFloat();
    return staticNoise;
  }

  public static float GetDynamicNoise(int index, float currentTime)
  {
    return Math.Abs(Math.Abs(NoiseHelper.StaticNoise[index & 1023 /*0x03FF*/] - currentTime % 1f) - 0.5f) * 2f;
  }

  public static float GetStaticNoise(int index) => NoiseHelper.StaticNoise[index & 1023 /*0x03FF*/];

  public static float GetDynamicNoise(int x, int y, float currentTime)
  {
    return NoiseHelper.GetDynamicNoiseInternal(x, y, currentTime % 1f);
  }

  private static float GetDynamicNoiseInternal(int x, int y, float wrappedTime)
  {
    x &= 31 /*0x1F*/;
    y &= 31 /*0x1F*/;
    return Math.Abs(Math.Abs(NoiseHelper.StaticNoise[y * 32 /*0x20*/ + x] - wrappedTime) - 0.5f) * 2f;
  }

  public static float GetStaticNoise(int x, int y)
  {
    x &= 31 /*0x1F*/;
    y &= 31 /*0x1F*/;
    return NoiseHelper.StaticNoise[y * 32 /*0x20*/ + x];
  }

  public static float GetDynamicNoise(Vector2 position, float currentTime)
  {
    position *= 10f;
    currentTime %= 1f;
    Vector2 vector2_1 = new Vector2((float) Math.Floor((double) position.X), (float) Math.Floor((double) position.Y));
    Point point = new Point((int) vector2_1.X, (int) vector2_1.Y);
    Vector2 vector2_2 = new Vector2(position.X - vector2_1.X, position.Y - vector2_1.Y);
    return MathHelper.Lerp(MathHelper.Lerp(NoiseHelper.GetDynamicNoiseInternal(point.X, point.Y, currentTime), NoiseHelper.GetDynamicNoiseInternal(point.X, point.Y + 1, currentTime), vector2_2.Y), MathHelper.Lerp(NoiseHelper.GetDynamicNoiseInternal(point.X + 1, point.Y, currentTime), NoiseHelper.GetDynamicNoiseInternal(point.X + 1, point.Y + 1, currentTime), vector2_2.Y), vector2_2.X);
  }

  public static float GetStaticNoise(Vector2 position)
  {
    position *= 10f;
    Vector2 vector2_1 = new Vector2((float) Math.Floor((double) position.X), (float) Math.Floor((double) position.Y));
    Point point = new Point((int) vector2_1.X, (int) vector2_1.Y);
    Vector2 vector2_2 = new Vector2(position.X - vector2_1.X, position.Y - vector2_1.Y);
    return MathHelper.Lerp(MathHelper.Lerp(NoiseHelper.GetStaticNoise(point.X, point.Y), NoiseHelper.GetStaticNoise(point.X, point.Y + 1), vector2_2.Y), MathHelper.Lerp(NoiseHelper.GetStaticNoise(point.X + 1, point.Y), NoiseHelper.GetStaticNoise(point.X + 1, point.Y + 1), vector2_2.Y), vector2_2.X);
  }
}
