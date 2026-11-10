// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.ItemDropRules.DropOneByOne
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;

#nullable disable
namespace Terraria.GameContent.ItemDropRules;

public class DropOneByOne : IItemDropRule
{
  public int itemId;
  public DropOneByOne.Parameters parameters;

  public List<IItemDropRuleChainAttempt> ChainedRules { get; private set; }

  public DropOneByOne(int itemId, DropOneByOne.Parameters parameters)
  {
    this.ChainedRules = new List<IItemDropRuleChainAttempt>();
    this.parameters = parameters;
    this.itemId = itemId;
  }

  public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
  {
    if (info.player.RollLuck(this.parameters.ChanceDenominator) < this.parameters.ChanceNumerator)
    {
      int num1 = info.rng.Next(this.parameters.MinimumItemDropsCount, this.parameters.MaximumItemDropsCount + 1);
      int activePlayersCount = Main.CurrentFrameFlags.ActivePlayersCount;
      int minValue = this.parameters.MinimumStackPerChunkBase + activePlayersCount * this.parameters.BonusMinDropsPerChunkPerPlayer;
      int num2 = this.parameters.MaximumStackPerChunkBase + activePlayersCount * this.parameters.BonusMaxDropsPerChunkPerPlayer;
      for (int index = 0; index < num1; ++index)
        CommonCode.DropItemFromNPC(info.npc, this.itemId, info.rng.Next(minValue, num2 + 1), true);
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
    float personalDropRate = this.parameters.GetPersonalDropRate();
    float dropRate = personalDropRate * ratesInfo.parentDroprateChance;
    drops.Add(new DropRateInfo(this.itemId, this.parameters.MinimumItemDropsCount * (this.parameters.MinimumStackPerChunkBase + this.parameters.BonusMinDropsPerChunkPerPlayer), this.parameters.MaximumItemDropsCount * (this.parameters.MaximumStackPerChunkBase + this.parameters.BonusMaxDropsPerChunkPerPlayer), dropRate, ratesInfo.conditions));
    Chains.ReportDroprates(this.ChainedRules, personalDropRate, drops, ratesInfo);
  }

  public bool CanDrop(DropAttemptInfo info) => true;

  public struct Parameters
  {
    public int ChanceNumerator;
    public int ChanceDenominator;
    public int MinimumItemDropsCount;
    public int MaximumItemDropsCount;
    public int MinimumStackPerChunkBase;
    public int MaximumStackPerChunkBase;
    public int BonusMinDropsPerChunkPerPlayer;
    public int BonusMaxDropsPerChunkPerPlayer;

    public float GetPersonalDropRate()
    {
      return (float) this.ChanceNumerator / (float) this.ChanceDenominator;
    }
  }
}
