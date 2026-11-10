// Decompiled with JetBrains decompiler
// Type: Terraria.UI.StyleDimension
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.UI;

public struct StyleDimension(float pixels, float precent)
{
  public static StyleDimension Fill = new StyleDimension(0.0f, 1f);
  public static StyleDimension Empty = new StyleDimension(0.0f, 0.0f);
  public float Pixels = pixels;
  public float Precent = precent;

  public void Set(float pixels, float precent)
  {
    this.Pixels = pixels;
    this.Precent = precent;
  }

  public float GetValue(float containerSize) => this.Pixels + this.Precent * containerSize;

  public static StyleDimension FromPixels(float pixels) => new StyleDimension(pixels, 0.0f);

  public static StyleDimension FromPercent(float percent) => new StyleDimension(0.0f, percent);

  public static StyleDimension FromPixelsAndPercent(float pixels, float percent)
  {
    return new StyleDimension(pixels, percent);
  }
}
