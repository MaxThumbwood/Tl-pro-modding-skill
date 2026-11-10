// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.LeashedEntities.BirdLeashedCritter
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.LeashedEntities;

public class BirdLeashedCritter : FlyerLeashedCritter
{
  public static BirdLeashedCritter Prototype = new BirdLeashedCritter();

  public BirdLeashedCritter()
  {
    this.anchorStyle = 2;
    this.minWaitTime = 120;
    this.maxWaitTime = 420;
    this.maxFlySpeed = 1.2f;
    this.acceleration = 0.1f;
    this.rotationScalar = 0.25f;
    this.brakeDuration = 10;
    this.hoverAmplitude = 3f;
    this.hoverPeriod = 0.005f;
  }
}
