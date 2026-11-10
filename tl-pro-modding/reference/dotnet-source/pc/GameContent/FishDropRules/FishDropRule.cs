// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.FishDropRules.FishDropRule
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.FishDropRules;

public class FishDropRule
{
  public int[] PossibleItems;
  public int ChanceNumerator = 1;
  public int ChanceDenominator = 1;
  public AFishingCondition[] Conditions;
  public FishRarityCondition Rarity;

  public bool IsStopper
  {
    get
    {
      if (this.PossibleItems.Length == 0)
        return true;
      return this.Rarity.HackedIsAny && this.ChanceDenominator == this.ChanceNumerator;
    }
  }

  public bool Attempt(FishingContext context, out int resultItemType)
  {
    resultItemType = 0;
    if (!this.MeetsConditions(context, false) || context.Random.Next(this.ChanceDenominator) >= this.ChanceNumerator || !this.Rarity.Matches(context))
      return false;
    if (this.PossibleItems != null && this.PossibleItems.Length != 0)
      resultItemType = context.Random.NextFromList<int>(this.PossibleItems);
    return true;
  }

  public bool MeetsConditions(FishingContext context, bool forDisplay)
  {
    foreach (AFishingCondition condition in this.Conditions)
    {
      if (!condition.Matches(context))
        return false;
    }
    return true;
  }
}
