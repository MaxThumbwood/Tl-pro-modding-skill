// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.ItemDropRules.DropPerPlayerOnThePlayer
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.ItemDropRules;

public class DropPerPlayerOnThePlayer : CommonDrop
{
  public IItemDropRuleCondition condition;

  public DropPerPlayerOnThePlayer(
    int itemId,
    int chanceDenominator,
    int amountDroppedMinimum,
    int amountDroppedMaximum,
    IItemDropRuleCondition optionalCondition)
    : base(itemId, chanceDenominator, amountDroppedMinimum, amountDroppedMaximum)
  {
    this.condition = optionalCondition;
  }

  public override bool CanDrop(DropAttemptInfo info)
  {
    return this.condition == null || this.condition.CanDrop(info);
  }

  public override ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
  {
    CommonCode.DropItemForEachInteractingPlayerOnThePlayer(info.npc, this.itemId, info.rng, this.chanceNumerator, this.chanceDenominator, info.rng.Next(this.amountDroppedMinimum, this.amountDroppedMaximum + 1));
    return new ItemDropAttemptResult()
    {
      State = ItemDropAttemptResultState.Success
    };
  }
}
