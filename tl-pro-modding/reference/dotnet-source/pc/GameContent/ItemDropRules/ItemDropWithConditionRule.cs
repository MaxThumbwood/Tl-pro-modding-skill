// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.ItemDropRules.ItemDropWithConditionRule
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;

#nullable disable
namespace Terraria.GameContent.ItemDropRules;

public class ItemDropWithConditionRule : CommonDrop
{
  public IItemDropRuleCondition condition;

  public ItemDropWithConditionRule(
    int itemId,
    int chanceDenominator,
    int amountDroppedMinimum,
    int amountDroppedMaximum,
    IItemDropRuleCondition condition,
    int chanceNumerator = 1)
    : base(itemId, chanceDenominator, amountDroppedMinimum, amountDroppedMaximum, chanceNumerator)
  {
    this.condition = condition;
  }

  public override bool CanDrop(DropAttemptInfo info) => this.condition.CanDrop(info);

  public override void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
  {
    DropRateInfoChainFeed ratesInfo1 = ratesInfo.With(1f);
    ratesInfo1.AddCondition(this.condition);
    float personalDropRate = (float) this.chanceNumerator / (float) this.chanceDenominator;
    float dropRate = personalDropRate * ratesInfo1.parentDroprateChance;
    drops.Add(new DropRateInfo(this.itemId, this.amountDroppedMinimum, this.amountDroppedMaximum, dropRate, ratesInfo1.conditions));
    Chains.ReportDroprates(this.ChainedRules, personalDropRate, drops, ratesInfo1);
  }
}
