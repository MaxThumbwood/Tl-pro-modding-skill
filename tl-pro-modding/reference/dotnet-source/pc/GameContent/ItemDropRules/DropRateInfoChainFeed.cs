// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.ItemDropRules.DropRateInfoChainFeed
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;

#nullable disable
namespace Terraria.GameContent.ItemDropRules;

public struct DropRateInfoChainFeed(float droprate)
{
  public float parentDroprateChance = droprate;
  public List<IItemDropRuleCondition> conditions = (List<IItemDropRuleCondition>) null;

  public void AddCondition(IItemDropRuleCondition condition)
  {
    if (this.conditions == null)
      this.conditions = new List<IItemDropRuleCondition>();
    this.conditions.Add(condition);
  }

  public DropRateInfoChainFeed With(float multiplier)
  {
    DropRateInfoChainFeed rateInfoChainFeed = new DropRateInfoChainFeed(this.parentDroprateChance * multiplier);
    if (this.conditions != null)
      rateInfoChainFeed.conditions = new List<IItemDropRuleCondition>((IEnumerable<IItemDropRuleCondition>) this.conditions);
    return rateInfoChainFeed;
  }
}
