// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.ItemDropRules.DropBasedOnExpertMode
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;

#nullable disable
namespace Terraria.GameContent.ItemDropRules;

public class DropBasedOnExpertMode : IItemDropRule, INestedItemDropRule
{
  public IItemDropRule ruleForNormalMode;
  public IItemDropRule ruleForExpertMode;

  public List<IItemDropRuleChainAttempt> ChainedRules { get; private set; }

  public DropBasedOnExpertMode(IItemDropRule ruleForNormalMode, IItemDropRule ruleForExpertMode)
  {
    this.ruleForNormalMode = ruleForNormalMode;
    this.ruleForExpertMode = ruleForExpertMode;
    this.ChainedRules = new List<IItemDropRuleChainAttempt>();
  }

  public bool CanDrop(DropAttemptInfo info)
  {
    return info.IsExpertMode ? this.ruleForExpertMode.CanDrop(info) : this.ruleForNormalMode.CanDrop(info);
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
    return info.IsExpertMode ? resolveAction(this.ruleForExpertMode, info) : resolveAction(this.ruleForNormalMode, info);
  }

  public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
  {
    DropRateInfoChainFeed ratesInfo1 = ratesInfo.With(1f);
    ratesInfo1.AddCondition((IItemDropRuleCondition) new Conditions.IsExpert());
    this.ruleForExpertMode.ReportDroprates(drops, ratesInfo1);
    DropRateInfoChainFeed ratesInfo2 = ratesInfo.With(1f);
    ratesInfo2.AddCondition((IItemDropRuleCondition) new Conditions.NotExpert());
    this.ruleForNormalMode.ReportDroprates(drops, ratesInfo2);
    Chains.ReportDroprates(this.ChainedRules, 1f, drops, ratesInfo);
  }
}
