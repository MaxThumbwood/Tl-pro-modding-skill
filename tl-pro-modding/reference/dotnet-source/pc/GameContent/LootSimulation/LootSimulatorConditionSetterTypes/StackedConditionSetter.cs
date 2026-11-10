// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.LootSimulation.LootSimulatorConditionSetterTypes.StackedConditionSetter
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.LootSimulation.LootSimulatorConditionSetterTypes;

public class StackedConditionSetter : ISimulationConditionSetter
{
  private ISimulationConditionSetter[] _setters;

  public StackedConditionSetter(params ISimulationConditionSetter[] setters)
  {
    this._setters = setters;
  }

  public void Setup(SimulatorInfo info)
  {
    for (int index = 0; index < this._setters.Length; ++index)
      this._setters[index].Setup(info);
  }

  public void TearDown(SimulatorInfo info)
  {
    for (int index = 0; index < this._setters.Length; ++index)
      this._setters[index].TearDown(info);
  }

  public int GetTimesToRunMultiplier(SimulatorInfo info) => 1;
}
