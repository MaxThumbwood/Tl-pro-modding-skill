// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.LootSimulation.LootSimulator
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using ReLogic.OS;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Terraria.ID;

#nullable disable
namespace Terraria.GameContent.LootSimulation;

public class LootSimulator
{
  private List<ISimulationConditionSetter> _neededTestConditions = new List<ISimulationConditionSetter>();
  private int[] _excludedItemIds = new int[0];

  public LootSimulator()
  {
    this.FillDesiredTestConditions();
    this.FillItemExclusions();
  }

  private void FillItemExclusions()
  {
    List<int> intList = new List<int>();
    intList.AddRange(((IEnumerable<bool>) ItemID.Sets.IsAPickup).Select((state, index) => new
    {
      index = index,
      state = state
    }).Where(tuple => tuple.state).Select(tuple => tuple.index));
    intList.AddRange(((IEnumerable<bool>) ItemID.Sets.CommonCoin).Select((state, index) => new
    {
      index = index,
      state = state
    }).Where(tuple => tuple.state).Select(tuple => tuple.index));
    this._excludedItemIds = intList.ToArray();
  }

  private void FillDesiredTestConditions()
  {
    this._neededTestConditions.AddRange((IEnumerable<ISimulationConditionSetter>) new List<ISimulationConditionSetter>()
    {
      (ISimulationConditionSetter) SimulationConditionSetters.MidDay,
      (ISimulationConditionSetter) SimulationConditionSetters.MidNight,
      (ISimulationConditionSetter) SimulationConditionSetters.HardMode,
      (ISimulationConditionSetter) SimulationConditionSetters.ExpertMode,
      (ISimulationConditionSetter) SimulationConditionSetters.ExpertAndHardMode,
      (ISimulationConditionSetter) SimulationConditionSetters.WindyExpertHardmodeEndgameBloodMoonNight,
      (ISimulationConditionSetter) SimulationConditionSetters.WindyExpertHardmodeEndgameEclipseMorning,
      (ISimulationConditionSetter) SimulationConditionSetters.SlimeStaffTest,
      (ISimulationConditionSetter) SimulationConditionSetters.LuckyCoinTest
    });
  }

  public void Run()
  {
    int timesMultiplier = 10000;
    this.SetCleanSlateWorldConditions();
    string str1 = "";
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();
    for (int npcNetId = -65; npcNetId < (int) NPCID.Count; ++npcNetId)
    {
      string outputText;
      if (this.TryGettingLootFor(npcNetId, timesMultiplier, out outputText))
        str1 = $"{str1}{outputText}\n\n";
    }
    stopwatch.Stop();
    string str2 = str1 + $"\nSimulation Took {(ValueType) (float) ((double) stopwatch.ElapsedMilliseconds / 1000.0)} seconds to complete.\n";
    Platform.Get<IClipboard>().Value = str2;
  }

  private void SetCleanSlateWorldConditions()
  {
    Main.dayTime = true;
    Main.time = 27000.0;
    Main.hardMode = false;
    Main.GameMode = 0;
    NPC.downedMechBoss1 = false;
    NPC.downedMechBoss2 = false;
    NPC.downedMechBoss3 = false;
    NPC.downedMechBossAny = false;
    NPC.downedPlantBoss = false;
    Main._shouldUseWindyDayMusic = false;
    Main._shouldUseStormMusic = false;
    Main.eclipse = false;
    Main.bloodMoon = false;
  }

  private bool TryGettingLootFor(int npcNetId, int timesMultiplier, out string outputText)
  {
    SimulatorInfo info = new SimulatorInfo();
    NPC npc = new NPC();
    npc.SetDefaults(npcNetId);
    info.npcVictim = npc;
    LootSimulationItemCounter simulationItemCounter = new LootSimulationItemCounter();
    info.itemCounter = simulationItemCounter;
    foreach (ISimulationConditionSetter neededTestCondition in this._neededTestConditions)
    {
      neededTestCondition.Setup(info);
      int amount = neededTestCondition.GetTimesToRunMultiplier(info) * timesMultiplier;
      for (int index = 0; index < amount; ++index)
        npc.NPCLoot();
      simulationItemCounter.IncreaseTimesAttempted(amount, info.runningExpertMode);
      neededTestCondition.TearDown(info);
      this.SetCleanSlateWorldConditions();
    }
    simulationItemCounter.Exclude(((IEnumerable<int>) this._excludedItemIds).ToArray<int>());
    string str1 = simulationItemCounter.PrintCollectedItems(false);
    string str2 = simulationItemCounter.PrintCollectedItems(true);
    string str3 = $"FindEntryByNPCID(NPCID.{NPCID.Search.GetName(npcNetId)})";
    if (str1.Length > 0)
      str3 = $"{str3}\n.AddDropsNormalMode({str1})";
    if (str2.Length > 0)
      str3 = $"{str3}\n.AddDropsExpertMode({str2})";
    string str4 = str3 + ";";
    outputText = str4;
    return str1.Length > 0 || str2.Length > 0;
  }
}
