// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.ItemDropRules.CommonDropScalingWithOnlyBadLuck
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.ItemDropRules;

public class CommonDropScalingWithOnlyBadLuck : CommonDrop
{
  public CommonDropScalingWithOnlyBadLuck(
    int itemId,
    int chanceDenominator,
    int amountDroppedMinimum = 1,
    int amountDroppedMaximum = 1,
    int chanceNumerator = 1)
    : base(itemId, chanceDenominator, amountDroppedMinimum, amountDroppedMaximum, chanceNumerator)
  {
  }

  public CommonDropScalingWithOnlyBadLuck(
    int itemId,
    int chanceDenominator,
    int amountDroppedMinimum,
    int amountDroppedMaximum)
    : base(itemId, chanceDenominator, amountDroppedMinimum, amountDroppedMaximum)
  {
  }

  public override ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
  {
    if (info.player.RollOnlyBadLuck(this.chanceDenominator) < this.chanceNumerator)
    {
      CommonCode.DropItemFromNPC(info.npc, this.itemId, info.rng.Next(this.amountDroppedMinimum, this.amountDroppedMaximum + 1));
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
