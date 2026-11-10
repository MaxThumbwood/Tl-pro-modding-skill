// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.ItemDropRules.LeadingConditionRule
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;

#nullable disable
namespace Terraria.GameContent.ItemDropRules;

public class LeadingConditionRule : IItemDropRule
{
  public IItemDropRuleCondition condition;

  public List<IItemDropRuleChainAttempt> ChainedRules { get; private set; }

  public LeadingConditionRule(IItemDropRuleCondition condition)
  {
    this.condition = condition;
    this.ChainedRules = new List<IItemDropRuleChainAttempt>();
  }

  public bool CanDrop(DropAttemptInfo info) => this.condition.CanDrop(info);

  public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
  {
    ratesInfo.AddCondition(this.condition);
    Chains.ReportDroprates(this.ChainedRules, 1f, drops, ratesInfo);
  }

  public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
  {
    return new ItemDropAttemptResult()
    {
      State = ItemDropAttemptResultState.Success
    };
  }
}
