// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.FishDropRules.FishingConditions
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.FishDropRules;

public class FishingConditions
{
  public class QuestFishCondition : AFishingCondition
  {
    public int CheckedType;

    public override bool Matches(FishingContext context)
    {
      return context.Fisher.questFish == this.CheckedType;
    }
  }

  public class QuestFishConditionRemix : AFishingCondition
  {
    public int CheckedType;

    public override bool Matches(FishingContext context)
    {
      return context.Fisher.questFish == this.CheckedType && Main.remixWorld;
    }
  }
}
