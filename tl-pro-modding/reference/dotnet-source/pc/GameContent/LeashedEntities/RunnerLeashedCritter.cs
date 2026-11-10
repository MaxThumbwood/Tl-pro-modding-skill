// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.LeashedEntities.RunnerLeashedCritter
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.LeashedEntities;

public class RunnerLeashedCritter : WalkerLeashedCritter
{
  public static RunnerLeashedCritter Prototype = new RunnerLeashedCritter();

  public RunnerLeashedCritter()
  {
    this.anchorStyle = 1;
    this.walkingPace = 1.5f;
  }
}
