// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.ItemDropRules.DropRateInfo
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;

#nullable disable
namespace Terraria.GameContent.ItemDropRules;

public struct DropRateInfo
{
  public int itemId;
  public int stackMin;
  public int stackMax;
  public float dropRate;
  public List<IItemDropRuleCondition> conditions;

  public DropRateInfo(
    int itemId,
    int stackMin,
    int stackMax,
    float dropRate,
    List<IItemDropRuleCondition> conditions = null)
  {
    this.itemId = itemId;
    this.stackMin = stackMin;
    this.stackMax = stackMax;
    this.dropRate = dropRate;
    this.conditions = (List<IItemDropRuleCondition>) null;
    if (conditions == null || conditions.Count <= 0)
      return;
    this.conditions = new List<IItemDropRuleCondition>((IEnumerable<IItemDropRuleCondition>) conditions);
  }

  public void AddCondition(IItemDropRuleCondition condition)
  {
    if (this.conditions == null)
      this.conditions = new List<IItemDropRuleCondition>();
    this.conditions.Add(condition);
  }
}
