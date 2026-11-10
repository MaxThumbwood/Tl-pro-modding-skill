// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.WingStats
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.DataStructures;

public struct WingStats(
  int flyTime = 100,
  float flySpeedOverride = -1f,
  float accelerationMultiplier = 1f,
  bool hasHoldDownHoverFeatures = false,
  float hoverFlySpeedOverride = -1f,
  float hoverAccelerationMultiplier = 1f)
{
  public static readonly WingStats Default;
  public int FlyTime = flyTime;
  public float AccRunSpeedOverride = flySpeedOverride;
  public float AccRunAccelerationMult = accelerationMultiplier;
  public bool HasDownHoverStats = hasHoldDownHoverFeatures;
  public float DownHoverSpeedOverride = hoverFlySpeedOverride;
  public float DownHoverAccelerationMult = hoverAccelerationMultiplier;

  public WingStats WithSpeedBoost(float multiplier)
  {
    return new WingStats(this.FlyTime, this.AccRunSpeedOverride * multiplier, this.AccRunAccelerationMult, this.HasDownHoverStats, this.DownHoverSpeedOverride * multiplier, this.DownHoverAccelerationMult);
  }
}
