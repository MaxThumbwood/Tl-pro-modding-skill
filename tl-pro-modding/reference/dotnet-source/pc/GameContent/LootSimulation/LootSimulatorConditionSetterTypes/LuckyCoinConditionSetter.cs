// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.LootSimulation.LootSimulatorConditionSetterTypes.LuckyCoinConditionSetter
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.LootSimulation.LootSimulatorConditionSetterTypes;

public class LuckyCoinConditionSetter : ISimulationConditionSetter
{
  private int _timesToRun;

  public LuckyCoinConditionSetter(int timesToRunMultiplier)
  {
    this._timesToRun = timesToRunMultiplier;
  }

  public int GetTimesToRunMultiplier(SimulatorInfo info)
  {
    switch (info.npcVictim.netID)
    {
      case 216:
      case 491:
        return this._timesToRun;
      default:
        return 0;
    }
  }

  public void Setup(SimulatorInfo info)
  {
  }

  public void TearDown(SimulatorInfo info)
  {
  }
}
