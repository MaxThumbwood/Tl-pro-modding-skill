// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.ItemDropRules.IItemDropRuleChainAttempt
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;

#nullable disable
namespace Terraria.GameContent.ItemDropRules;

public interface IItemDropRuleChainAttempt
{
  IItemDropRule RuleToChain { get; }

  bool CanChainIntoRule(ItemDropAttemptResult parentResult);

  void ReportDroprates(
    float personalDropRate,
    List<DropRateInfo> drops,
    DropRateInfoChainFeed ratesInfo);
}
