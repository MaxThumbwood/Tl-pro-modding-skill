// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.ItemDropRules.DropBasedOnExtraGel
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;

#nullable disable
namespace Terraria.GameContent.ItemDropRules;

public class DropBasedOnExtraGel : IItemDropRule, INestedItemDropRule
{
  public IItemDropRule ruleForNormal;
  public IItemDropRule ruleForExtraGel;

  public List<IItemDropRuleChainAttempt> ChainedRules { get; private set; }

  public DropBasedOnExtraGel(IItemDropRule ruleForNormal, IItemDropRule ruleForExtraGel)
  {
    this.ruleForNormal = ruleForNormal;
    this.ruleForExtraGel = ruleForExtraGel;
    this.ChainedRules = new List<IItemDropRuleChainAttempt>();
  }

  public bool CanDrop(DropAttemptInfo info)
  {
    return SpecialSeedFeatures.ShouldDropExtraGel ? this.ruleForExtraGel.CanDrop(info) : this.ruleForNormal.CanDrop(info);
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
    return SpecialSeedFeatures.ShouldDropExtraGel ? resolveAction(this.ruleForExtraGel, info) : resolveAction(this.ruleForNormal, info);
  }

  public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
  {
    DropRateInfoChainFeed ratesInfo1 = ratesInfo.With(1f);
    ratesInfo1.AddCondition((IItemDropRuleCondition) new Conditions.DropExtraGel());
    this.ruleForExtraGel.ReportDroprates(drops, ratesInfo1);
    DropRateInfoChainFeed ratesInfo2 = ratesInfo.With(1f);
    ratesInfo2.AddCondition((IItemDropRuleCondition) new Conditions.NotDropExtraGel());
    this.ruleForNormal.ReportDroprates(drops, ratesInfo2);
    Chains.ReportDroprates(this.ChainedRules, 1f, drops, ratesInfo);
  }
}
