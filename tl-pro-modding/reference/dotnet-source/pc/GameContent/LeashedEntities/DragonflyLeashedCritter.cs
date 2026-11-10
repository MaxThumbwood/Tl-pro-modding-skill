// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.LeashedEntities.DragonflyLeashedCritter
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.LeashedEntities;

public class DragonflyLeashedCritter : FlyerLeashedCritter
{
  public static DragonflyLeashedCritter Prototype = new DragonflyLeashedCritter();

  public DragonflyLeashedCritter()
  {
    this.minWaitTime = 10;
    this.maxFlySpeed = 2.5f;
    this.acceleration = 0.4f;
    this.brakeDuration = 10;
  }
}
