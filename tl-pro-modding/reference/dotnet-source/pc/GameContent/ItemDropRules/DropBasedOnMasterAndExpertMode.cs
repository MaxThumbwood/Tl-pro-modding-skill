// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.ItemDropRules.DropBasedOnMasterAndExpertMode
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;

#nullable disable
namespace Terraria.GameContent.ItemDropRules;

public class DropBasedOnMasterAndExpertMode : IItemDropRule, INestedItemDropRule
{
  public IItemDropRule ruleForDefault;
  public IItemDropRule ruleForExpertmode;
  public IItemDropRule ruleForMasterMode;

  public List<IItemDropRuleChainAttempt> ChainedRules { get; private set; }

  public DropBasedOnMasterAndExpertMode(
    IItemDropRule ruleForDefault,
    IItemDropRule ruleForExpertMode,
    IItemDropRule ruleForMasterMode)
  {
    this.ruleForDefault = ruleForDefault;
    this.ruleForExpertmode = ruleForExpertMode;
    this.ruleForMasterMode = ruleForMasterMode;
    this.ChainedRules = new List<IItemDropRuleChainAttempt>();
  }

  public bool CanDrop(DropAttemptInfo info)
  {
    if (info.IsMasterMode)
      return this.ruleForMasterMode.CanDrop(info);
    return info.IsExpertMode ? this.ruleForExpertmode.CanDrop(info) : this.ruleForDefault.CanDrop(info);
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
    if (info.IsMasterMode)
      return resolveAction(this.ruleForMasterMode, info);
    return info.IsExpertMode ? resolveAction(this.ruleForExpertmode, info) : resolveAction(this.ruleForDefault, info);
  }

  public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
  {
    DropRateInfoChainFeed ratesInfo1 = ratesInfo.With(1f);
    ratesInfo1.AddCondition((IItemDropRuleCondition) new Conditions.IsMasterMode());
    this.ruleForMasterMode.ReportDroprates(drops, ratesInfo1);
    DropRateInfoChainFeed ratesInfo2 = ratesInfo.With(1f);
    ratesInfo2.AddCondition((IItemDropRuleCondition) new Conditions.NotMasterMode());
    ratesInfo2.AddCondition((IItemDropRuleCondition) new Conditions.IsExpert());
    this.ruleForExpertmode.ReportDroprates(drops, ratesInfo2);
    DropRateInfoChainFeed ratesInfo3 = ratesInfo.With(1f);
    ratesInfo3.AddCondition((IItemDropRuleCondition) new Conditions.NotMasterMode());
    ratesInfo3.AddCondition((IItemDropRuleCondition) new Conditions.NotExpert());
    this.ruleForDefault.ReportDroprates(drops, ratesInfo3);
    Chains.ReportDroprates(this.ChainedRules, 1f, drops, ratesInfo);
  }
}
