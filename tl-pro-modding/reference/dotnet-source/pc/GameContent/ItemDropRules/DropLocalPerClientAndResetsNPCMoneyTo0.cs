// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.ItemDropRules.DropLocalPerClientAndResetsNPCMoneyTo0
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.ItemDropRules;

public class DropLocalPerClientAndResetsNPCMoneyTo0 : CommonDrop
{
  public IItemDropRuleCondition condition;

  public DropLocalPerClientAndResetsNPCMoneyTo0(
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
    if (info.rng.Next(this.chanceDenominator) < this.chanceNumerator)
    {
      CommonCode.DropItemLocalPerClientAndSetNPCMoneyTo0(info.npc, this.itemId, info.rng.Next(this.amountDroppedMinimum, this.amountDroppedMaximum + 1));
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
}
