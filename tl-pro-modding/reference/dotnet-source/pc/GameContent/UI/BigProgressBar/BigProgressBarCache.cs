// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.BigProgressBar.BigProgressBarCache
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.UI.BigProgressBar;

public struct BigProgressBarCache
{
  public float LifeCurrent;
  public float LifeMax;
  public float ShieldCurrent;
  public float ShieldMax;

  public void SetLife(float current, float max)
  {
    this.LifeCurrent = current;
    this.LifeMax = max;
  }

  public void SetShield(float current, float max)
  {
    this.ShieldCurrent = current;
    this.ShieldMax = max;
  }
}
