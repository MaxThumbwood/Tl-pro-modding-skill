// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.ItemDropRules.OneFromRulesRule
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;

#nullable disable
namespace Terraria.GameContent.ItemDropRules;

public class OneFromRulesRule : IItemDropRule, INestedItemDropRule
{
  public IItemDropRule[] options;
  public int chanceDenominator;

  public List<IItemDropRuleChainAttempt> ChainedRules { get; private set; }

  public OneFromRulesRule(int chanceDenominator, params IItemDropRule[] options)
  {
    this.chanceDenominator = chanceDenominator;
    this.options = options;
    this.ChainedRules = new List<IItemDropRuleChainAttempt>();
  }

  public bool CanDrop(DropAttemptInfo info) => true;

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
    if (info.rng.Next(this.chanceDenominator) == 0)
    {
      int index = info.rng.Next(this.options.Length);
      ItemDropAttemptResult dropAttemptResult = resolveAction(this.options[index], info);
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
    float personalDropRate = 1f / (float) this.chanceDenominator;
    float multiplier = 1f / (float) this.options.Length * personalDropRate;
    for (int index = 0; index < this.options.Length; ++index)
      this.options[index].ReportDroprates(drops, ratesInfo.With(multiplier));
    Chains.ReportDroprates(this.ChainedRules, personalDropRate, drops, ratesInfo);
  }
}
