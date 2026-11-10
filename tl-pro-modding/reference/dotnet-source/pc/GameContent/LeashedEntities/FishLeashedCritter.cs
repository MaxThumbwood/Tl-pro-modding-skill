// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.LeashedEntities.FishLeashedCritter
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.GameContent.LeashedEntities;

public class FishLeashedCritter : FlyerLeashedCritter
{
  public static FishLeashedCritter Prototype = new FishLeashedCritter();

  public FishLeashedCritter()
  {
    this.anchorStyle = 3;
    this.minWaitTime = 120;
    this.maxFlySpeed = 0.5f;
    this.acceleration = 0.015f;
    this.hoverAmplitude = 10f;
    this.hoverPeriod = 3f / 1000f;
    this.isAquatic = true;
  }

  protected override void CopyToDummy()
  {
    base.CopyToDummy();
    LeashedCritter._dummy.wet = true;
  }

  public override Vector2 GetDrawOffset() => this.GetBobbingOffset();
}
