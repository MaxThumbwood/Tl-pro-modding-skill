// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.ItemDropRules.MechBossSpawnersDropRule
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;

#nullable disable
namespace Terraria.GameContent.ItemDropRules;

public class MechBossSpawnersDropRule : IItemDropRule
{
  public Conditions.MechanicalBossesDummyCondition dummyCondition = new Conditions.MechanicalBossesDummyCondition();

  public List<IItemDropRuleChainAttempt> ChainedRules { get; private set; }

  public MechBossSpawnersDropRule() => this.ChainedRules = new List<IItemDropRuleChainAttempt>();

  public bool CanDrop(DropAttemptInfo info)
  {
    return (double) info.npc.value > 0.0 && Main.hardMode && (!NPC.downedMechBoss1 || !NPC.downedMechBoss2 || !NPC.downedMechBoss3) && !info.IsInSimulation;
  }

  public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
  {
    if (!NPC.downedMechBoss1 && info.player.RollLuck(2500) == 0)
    {
      CommonCode.DropItemFromNPC(info.npc, 556, 1);
      return new ItemDropAttemptResult()
      {
        State = ItemDropAttemptResultState.Success
      };
    }
    if (!NPC.downedMechBoss2 && info.player.RollLuck(2500) == 0)
    {
      CommonCode.DropItemFromNPC(info.npc, 544, 1);
      return new ItemDropAttemptResult()
      {
        State = ItemDropAttemptResultState.Success
      };
    }
    if (!NPC.downedMechBoss3 && info.player.RollLuck(2500) == 0)
    {
      CommonCode.DropItemFromNPC(info.npc, 557, 1);
      return new ItemDropAttemptResult()
      {
        State = ItemDropAttemptResultState.Success
      };
    }
    return new ItemDropAttemptResult()
    {
      State = ItemDropAttemptResultState.FailedRandomRoll
    };
  }

  public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
  {
    ratesInfo.AddCondition((IItemDropRuleCondition) this.dummyCondition);
    float personalDropRate = 0.0004f;
    float dropRate = personalDropRate * ratesInfo.parentDroprateChance;
    drops.Add(new DropRateInfo(556, 1, 1, dropRate, ratesInfo.conditions));
    drops.Add(new DropRateInfo(544, 1, 1, dropRate, ratesInfo.conditions));
    drops.Add(new DropRateInfo(557, 1, 1, dropRate, ratesInfo.conditions));
    Chains.ReportDroprates(this.ChainedRules, personalDropRate, drops, ratesInfo);
  }
}
