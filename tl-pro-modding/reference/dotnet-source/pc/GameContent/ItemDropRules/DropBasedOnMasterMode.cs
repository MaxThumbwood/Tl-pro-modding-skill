// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.ItemDropRules.DropBasedOnMasterMode
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;

#nullable disable
namespace Terraria.GameContent.ItemDropRules;

public class DropBasedOnMasterMode : IItemDropRule, INestedItemDropRule
{
  public IItemDropRule ruleForDefault;
  public IItemDropRule ruleForMasterMode;

  public List<IItemDropRuleChainAttempt> ChainedRules { get; private set; }

  public DropBasedOnMasterMode(IItemDropRule ruleForDefault, IItemDropRule ruleForMasterMode)
  {
    this.ruleForDefault = ruleForDefault;
    this.ruleForMasterMode = ruleForMasterMode;
    this.ChainedRules = new List<IItemDropRuleChainAttempt>();
  }

  public bool CanDrop(DropAttemptInfo info)
  {
    return info.IsMasterMode ? this.ruleForMasterMode.CanDrop(info) : this.ruleForDefault.CanDrop(info);
  }

  public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
  {
    return new ItemDropAttemptResult()
    {
      State = ItemDropAttemptResultState.DidNotRunCode
    };
  }

  public ItemDropAttemptResult TryDroppingItem(
    DropAttemptInfo info,
    ItemDropRuleResolveAction resolveAction)
  {
    return info.IsMasterMode ? resolveAction(this.ruleForMasterMode, info) : resolveAction(this.ruleForDefault, info);
  }

  public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
  {
    DropRateInfoChainFeed ratesInfo1 = ratesInfo.With(1f);
    ratesInfo1.AddCondition((IItemDropRuleCondition) new Conditions.IsMasterMode());
    this.ruleForMasterMode.ReportDroprates(drops, ratesInfo1);
    DropRateInfoChainFeed ratesInfo2 = ratesInfo.With(1f);
    ratesInfo2.AddCondition((IItemDropRuleCondition) new Conditions.NotMasterMode());
    this.ruleForDefault.ReportDroprates(drops, ratesInfo2);
    Chains.ReportDroprates(this.ChainedRules, 1f, drops, ratesInfo);
  }
}
