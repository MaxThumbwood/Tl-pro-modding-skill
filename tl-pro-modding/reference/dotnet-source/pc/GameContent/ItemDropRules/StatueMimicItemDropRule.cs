// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.ItemDropRules.StatueMimicItemDropRule
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;
using Terraria.ID;

#nullable disable
namespace Terraria.GameContent.ItemDropRules;

public class StatueMimicItemDropRule : IItemDropRule
{
  public List<IItemDropRuleChainAttempt> ChainedRules { get; private set; }

  public StatueMimicItemDropRule() => this.ChainedRules = new List<IItemDropRuleChainAttempt>();

  public bool CanDrop(DropAttemptInfo info)
  {
    return (double) info.npc.ai[1] > 0.0 && (double) info.npc.ai[1] < (double) ItemID.Count;
  }

  public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
  {
    Chains.ReportDroprates(this.ChainedRules, 1f, drops, ratesInfo);
  }

  public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
  {
    int itemId = WorldGen.StatueStyleToItem((int) info.npc.ai[1]);
    CommonCode.DropItemFromNPC(info.npc, itemId, 1);
    return new ItemDropAttemptResult()
    {
      State = ItemDropAttemptResultState.Success
    };
  }
}
