// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.FishDropRules.FishDropRuleList
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Collections.Generic;

#nullable disable
namespace Terraria.GameContent.FishDropRules;

public class FishDropRuleList
{
  private List<FishDropRule> _rules = new List<FishDropRule>();

  public int TryGetItemDropType(FishingContext context)
  {
    int resultItemType = 0;
    for (int index = 0; index < this._rules.Count; ++index)
    {
      if (this._rules[index].Attempt(context, out resultItemType))
        return resultItemType;
    }
    return 0;
  }

  public void GetDisplayableDrops(FishingContext context, List<FishPossibilityEntry> resultTypes)
  {
    for (int index = 0; index < this._rules.Count; ++index)
    {
      FishDropRule rule = this._rules[index];
      if (rule.MeetsConditions(context, true))
      {
        int num = 0;
        if (rule.PossibleItems.Length != 0)
          num = context.Random.NextFromList<int>(rule.PossibleItems);
        resultTypes.Add(new FishPossibilityEntry()
        {
          ItemType = num,
          Frequency = rule.Rarity.FrequencyOfAppearanceForVisuals
        });
        if (rule.IsStopper)
          break;
      }
    }
  }

  public void Add(FishDropRule rule)
  {
    this.Validate(rule);
    this._rules.Add(rule);
  }

  private void Validate(FishDropRule rule)
  {
    if (rule.ChanceDenominator <= 0)
      throw new ArgumentOutOfRangeException("FishDropRule.ChanceDenominator", "Chance Denominator must be positive non-zero number");
  }
}
