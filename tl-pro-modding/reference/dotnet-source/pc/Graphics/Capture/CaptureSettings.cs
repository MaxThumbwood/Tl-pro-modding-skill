// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.Capture.CaptureSettings
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System;

#nullable disable
namespace Terraria.Graphics.Capture;

public class CaptureSettings
{
  public Rectangle Area;
  public bool UseScaling = true;
  public string OutputName;
  public bool CaptureEntities = true;
  public CaptureBiome Biome = CaptureBiome.DefaultPurity;
  public bool CaptureMech;
  public bool CaptureBackground;
  public bool CameraSpaceEffects;

  public CaptureSettings()
  {
    DateTime localTime = DateTime.Now.ToLocalTime();
    this.OutputName = $"Capture {localTime.Year.ToString("D4")}-{localTime.Month.ToString("D2")}-{localTime.Day.ToString("D2")} {localTime.Hour.ToString("D2")}_{localTime.Minute.ToString("D2")}_{localTime.Second.ToString("D2")}";
  }
}
