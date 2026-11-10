// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.ColorSlidersSet
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.DataStructures;

public class ColorSlidersSet
{
  public float Hue;
  public float Saturation;
  public float Luminance;
  public float Alpha = 1f;

  public void SetHSL(Color color)
  {
    Vector3 hsl = Main.rgbToHsl(color);
    this.Hue = hsl.X;
    this.Saturation = hsl.Y;
    this.Luminance = hsl.Z;
  }

  public void SetHSL(Vector3 vector)
  {
    this.Hue = vector.X;
    this.Saturation = vector.Y;
    this.Luminance = vector.Z;
  }

  public Color GetColor()
  {
    return Main.hslToRgb(this.Hue, this.Saturation, this.Luminance) with
    {
      A = (byte) ((double) this.Alpha * (double) byte.MaxValue)
    };
  }

  public Vector3 GetHSLVector() => new Vector3(this.Hue, this.Saturation, this.Luminance);

  public void ApplyToMainLegacyBars()
  {
    Main.hBar = this.Hue;
    Main.sBar = this.Saturation;
    Main.lBar = this.Luminance;
    Main.aBar = this.Alpha;
  }
}
