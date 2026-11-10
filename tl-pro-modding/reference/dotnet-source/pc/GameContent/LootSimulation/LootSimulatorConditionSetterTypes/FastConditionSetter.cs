// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.LootSimulation.LootSimulatorConditionSetterTypes.FastConditionSetter
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;

#nullable disable
namespace Terraria.GameContent.LootSimulation.LootSimulatorConditionSetterTypes;

public class FastConditionSetter : ISimulationConditionSetter
{
  private Action<SimulatorInfo> _setup;
  private Action<SimulatorInfo> _tearDown;

  public FastConditionSetter(Action<SimulatorInfo> setup, Action<SimulatorInfo> tearDown)
  {
    this._setup = setup;
    this._tearDown = tearDown;
  }

  public void Setup(SimulatorInfo info)
  {
    if (this._setup == null)
      return;
    this._setup(info);
  }

  public void TearDown(SimulatorInfo info)
  {
    if (this._tearDown == null)
      return;
    this._tearDown(info);
  }

  public int GetTimesToRunMultiplier(SimulatorInfo info) => 1;
}
