// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.FishDropRules.AFishDropRulePopulator
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace Terraria.GameContent.FishDropRules;

public abstract class AFishDropRulePopulator
{
  private FishDropRuleList _list;
  protected AFishingCondition HardMode = (AFishingCondition) new AFishDropRulePopulator.DelegateFishingCondition((AFishDropRulePopulator.DelegateFishingCondition.MatchCondition) (context => AFishDropRulePopulator.IsHardmode(true)));
  protected AFishingCondition EarlyMode = (AFishingCondition) new AFishDropRulePopulator.DelegateFishingCondition((AFishDropRulePopulator.DelegateFishingCondition.MatchCondition) (context => AFishDropRulePopulator.IsHardmode(false)));
  protected AFishingCondition InLava = (AFishingCondition) new AFishDropRulePopulator.DelegateFishingCondition((AFishDropRulePopulator.DelegateFishingCondition.MatchCondition) (context => context.Fisher.inLava));
  protected AFishingCondition InHoney = (AFishingCondition) new AFishDropRulePopulator.DelegateFishingCondition((AFishDropRulePopulator.DelegateFishingCondition.MatchCondition) (context => context.Fisher.inHoney));
  protected AFishingCondition Junk = (AFishingCondition) new AFishDropRulePopulator.DelegateFishingCondition((AFishDropRulePopulator.DelegateFishingCondition.MatchCondition) (context => context.Fisher.junk));
  protected AFishingCondition Crate = (AFishingCondition) new AFishDropRulePopulator.DelegateFishingCondition((AFishDropRulePopulator.DelegateFishingCondition.MatchCondition) (context => context.Fisher.crate));
  protected AFishingCondition AnyEnemies = (AFishingCondition) new AFishDropRulePopulator.DelegateFishingCondition((AFishDropRulePopulator.DelegateFishingCondition.MatchCondition) (context => context.Fisher.rolledEnemySpawn > 0));
  protected AFishingCondition CanFishInLava = (AFishingCondition) new AFishDropRulePopulator.DelegateFishingCondition((AFishDropRulePopulator.DelegateFishingCondition.MatchCondition) (context => context.Fisher.CanFishInLava));
  protected AFishingCondition Dungeon = (AFishingCondition) new AFishDropRulePopulator.DelegateFishingCondition((AFishDropRulePopulator.DelegateFishingCondition.MatchCondition) (context => context.Player.ZoneDungeon && NPC.downedBoss3));
  protected AFishingCondition Beach = (AFishingCondition) new AFishDropRulePopulator.DelegateFishingCondition((AFishDropRulePopulator.DelegateFishingCondition.MatchCondition) (context => context.Player.ZoneBeach));
  protected AFishingCondition Hallow = (AFishingCondition) new AFishDropRulePopulator.DelegateFishingCondition((AFishDropRulePopulator.DelegateFishingCondition.MatchCondition) (context => context.Player.ZoneHallow));
  protected AFishingCondition GlowingMushrooms = (AFishingCondition) new AFishDropRulePopulator.DelegateFishingCondition((AFishDropRulePopulator.DelegateFishingCondition.MatchCondition) (context => context.Player.ZoneGlowshroom));
  protected AFishingCondition TrueDesert = (AFishingCondition) new AFishDropRulePopulator.DelegateFishingCondition((AFishDropRulePopulator.DelegateFishingCondition.MatchCondition) (context => context.Player.ZoneDesert));
  protected AFishingCondition TrueSnow = (AFishingCondition) new AFishDropRulePopulator.DelegateFishingCondition((AFishDropRulePopulator.DelegateFishingCondition.MatchCondition) (context => context.Player.ZoneSnow));
  protected AFishingCondition Remix = (AFishingCondition) new AFishDropRulePopulator.DelegateFishingCondition((AFishDropRulePopulator.DelegateFishingCondition.MatchCondition) (context => Main.remixWorld));
  protected AFishingCondition Height1 = (AFishingCondition) new AFishDropRulePopulator.DelegateFishingCondition((AFishDropRulePopulator.DelegateFishingCondition.MatchCondition) (context => context.Fisher.heightLevel == 1));
  protected AFishingCondition Height1And2 = (AFishingCondition) new AFishDropRulePopulator.DelegateFishingCondition((AFishDropRulePopulator.DelegateFishingCondition.MatchCondition) (context => context.Fisher.heightLevel == 1 || context.Fisher.heightLevel == 2));
  protected AFishingCondition HeightAbove1 = (AFishingCondition) new AFishDropRulePopulator.DelegateFishingCondition((AFishDropRulePopulator.DelegateFishingCondition.MatchCondition) (context => context.Fisher.heightLevel > 1));
  protected AFishingCondition HeightAboveAnd1 = (AFishingCondition) new AFishDropRulePopulator.DelegateFishingCondition((AFishDropRulePopulator.DelegateFishingCondition.MatchCondition) (context => context.Fisher.heightLevel >= 1));
  protected AFishingCondition HeightUnder2 = (AFishingCondition) new AFishDropRulePopulator.DelegateFishingCondition((AFishDropRulePopulator.DelegateFishingCondition.MatchCondition) (context => context.Fisher.heightLevel < 2));
  protected AFishingCondition HeightAbove2 = (AFishingCondition) new AFishDropRulePopulator.DelegateFishingCondition((AFishDropRulePopulator.DelegateFishingCondition.MatchCondition) (context => context.Fisher.heightLevel > 2));
  protected AFishingCondition Height0 = (AFishingCondition) new AFishDropRulePopulator.DelegateFishingCondition((AFishDropRulePopulator.DelegateFishingCondition.MatchCondition) (context => context.Fisher.heightLevel == 0));
  protected AFishingCondition Height2 = (AFishingCondition) new AFishDropRulePopulator.DelegateFishingCondition((AFishDropRulePopulator.DelegateFishingCondition.MatchCondition) (context => context.Fisher.heightLevel == 2));
  protected AFishingCondition Height3 = (AFishingCondition) new AFishDropRulePopulator.DelegateFishingCondition((AFishDropRulePopulator.DelegateFishingCondition.MatchCondition) (context => context.Fisher.heightLevel == 3));
  protected AFishingCondition UnderRockLayer = (AFishingCondition) new AFishDropRulePopulator.DelegateFishingCondition((AFishDropRulePopulator.DelegateFishingCondition.MatchCondition) (context => (double) context.Fisher.Y >= Main.rockLayer));
  protected AFishingCondition Corruption = (AFishingCondition) new AFishDropRulePopulator.DelegateFishingCondition((AFishDropRulePopulator.DelegateFishingCondition.MatchCondition) (context => context.RolledCorruption));
  protected AFishingCondition Crimson = (AFishingCondition) new AFishDropRulePopulator.DelegateFishingCondition((AFishDropRulePopulator.DelegateFishingCondition.MatchCondition) (context => context.RolledCrimson));
  protected AFishingCondition Jungle = (AFishingCondition) new AFishDropRulePopulator.DelegateFishingCondition((AFishDropRulePopulator.DelegateFishingCondition.MatchCondition) (context => context.RolledJungle));
  protected AFishingCondition Snow = (AFishingCondition) new AFishDropRulePopulator.DelegateFishingCondition((AFishDropRulePopulator.DelegateFishingCondition.MatchCondition) (context => context.RolledSnow));
  protected AFishingCondition Desert = (AFishingCondition) new AFishDropRulePopulator.DelegateFishingCondition((AFishDropRulePopulator.DelegateFishingCondition.MatchCondition) (context => context.RolledDesert));
  protected AFishingCondition RolledHallowDesert = (AFishingCondition) new AFishDropRulePopulator.DelegateFishingCondition((AFishDropRulePopulator.DelegateFishingCondition.MatchCondition) (context => context.RolledInfectedDesert && context.Player.ZoneHallow));
  protected AFishingCondition OriginalOcean = (AFishingCondition) new AFishDropRulePopulator.DelegateFishingCondition((AFishDropRulePopulator.DelegateFishingCondition.MatchCondition) (context => AFishDropRulePopulator.IsOriginalOcean(context)));
  protected AFishingCondition RemixOcean = (AFishingCondition) new AFishDropRulePopulator.DelegateFishingCondition((AFishDropRulePopulator.DelegateFishingCondition.MatchCondition) (context => context.RolledRemixOcean));
  protected AFishingCondition Ocean = (AFishingCondition) new AFishDropRulePopulator.DelegateFishingCondition((AFishDropRulePopulator.DelegateFishingCondition.MatchCondition) (context => context.RolledRemixOcean || AFishDropRulePopulator.IsOriginalOcean(context)));
  protected AFishingCondition Water1000 = (AFishingCondition) new AFishDropRulePopulator.DelegateFishingCondition((AFishDropRulePopulator.DelegateFishingCondition.MatchCondition) (context => context.Fisher.waterTilesCount > 1000));
  protected AFishingCondition BloodMoon = (AFishingCondition) new AFishDropRulePopulator.DelegateFishingCondition((AFishDropRulePopulator.DelegateFishingCondition.MatchCondition) (context => Main.bloodMoon));
  protected AFishingCondition DidNotUseCombatBook = (AFishingCondition) new AFishDropRulePopulator.DelegateFishingCondition((AFishDropRulePopulator.DelegateFishingCondition.MatchCondition) (context => !NPC.combatBookWasUsed));

  public AFishDropRulePopulator(FishDropRuleList list) => this._list = list;

  protected void Add(
    FishRarityCondition tier,
    int chanceNominator,
    int chanceDenominator,
    int[] itemTypes,
    params AFishingCondition[] conditions)
  {
    this._list.Add(new FishDropRule()
    {
      PossibleItems = itemTypes,
      ChanceNumerator = chanceNominator,
      ChanceDenominator = chanceDenominator,
      Rarity = tier,
      Conditions = conditions
    });
  }

  protected void Add(
    FishRarityCondition tier,
    int chanceNominator,
    int chanceDenominator,
    int itemType,
    params AFishingCondition[] conditions)
  {
    this.Add(tier, chanceNominator, chanceDenominator, this.Group(itemType), conditions);
  }

  protected void Add(
    FishRarityCondition tier,
    int chanceDenominator,
    int[] itemTypes,
    params AFishingCondition[] conditions)
  {
    this.Add(tier, 1, chanceDenominator, itemTypes, conditions);
  }

  protected void Add(
    FishRarityCondition tier,
    int chanceDenominator,
    int itemType,
    params AFishingCondition[] conditions)
  {
    this.Add(tier, 1, chanceDenominator, this.Group(itemType), conditions);
  }

  protected void AddQuestFish(
    FishRarityCondition tier,
    int chanceDenominator,
    int itemType,
    params AFishingCondition[] conditions)
  {
    FishingConditions.QuestFishCondition questFishCondition = new FishingConditions.QuestFishCondition()
    {
      CheckedType = itemType
    };
    this.Add(tier, 1, chanceDenominator, this.Group(itemType), this.Join(conditions, (AFishingCondition) questFishCondition));
  }

  protected void AddQuestFishForRemix(
    FishRarityCondition tier,
    int chanceDenominator,
    int itemType,
    params AFishingCondition[] conditions)
  {
    FishingConditions.QuestFishConditionRemix fishConditionRemix = new FishingConditions.QuestFishConditionRemix()
    {
      CheckedType = itemType
    };
    this.Add(tier, 1, chanceDenominator, this.Group(itemType), this.Join(conditions, (AFishingCondition) fishConditionRemix));
  }

  protected void AddWithHardmode(
    FishRarityCondition tier,
    int chanceDenominator,
    int itemTypeEarly,
    int itemTypeHard,
    params AFishingCondition[] conditions)
  {
    this._list.Add(new FishDropRule()
    {
      PossibleItems = new int[1]{ itemTypeEarly },
      ChanceNumerator = 1,
      ChanceDenominator = chanceDenominator,
      Rarity = tier,
      Conditions = this.Join(conditions, this.EarlyMode)
    });
    this._list.Add(new FishDropRule()
    {
      PossibleItems = new int[1]{ itemTypeHard },
      ChanceNumerator = 1,
      ChanceDenominator = chanceDenominator,
      Rarity = tier,
      Conditions = this.Join(conditions, this.HardMode)
    });
  }

  protected void AddStopper(AFishingCondition condition)
  {
    this.Add(AFishDropRulePopulator.Rarity.Any, 1, new int[0], condition);
  }

  public int[] Group(params int[] itemTypes) => itemTypes;

  protected AFishingCondition[] Join(
    AFishingCondition[] original,
    params AFishingCondition[] additions)
  {
    return ((IEnumerable<AFishingCondition>) original).Concat<AFishingCondition>((IEnumerable<AFishingCondition>) additions).ToArray<AFishingCondition>();
  }

  protected AFishingCondition[] Join(params AFishingCondition[] additions) => additions;

  private static bool IsHardmode(bool state) => Main.hardMode == state;

  private static bool IsOriginalOcean(FishingContext context)
  {
    return context.Fisher.heightLevel <= 1 && (context.Fisher.X < 380 || context.Fisher.X > Main.maxTilesX - 380) && context.Fisher.waterTilesCount > 1000;
  }

  private class DelegateFishingCondition : AFishingCondition
  {
    private AFishDropRulePopulator.DelegateFishingCondition.MatchCondition _condition;

    public DelegateFishingCondition(
      AFishDropRulePopulator.DelegateFishingCondition.MatchCondition innerCondition)
    {
      this._condition = innerCondition;
    }

    public override bool Matches(FishingContext context) => this._condition(context);

    public delegate bool MatchCondition(FishingContext context);
  }

  private class DelegateFishingRarityCondition : FishRarityCondition
  {
    private AFishDropRulePopulator.DelegateFishingRarityCondition.MatchCondition _condition;

    public DelegateFishingRarityCondition(
      AFishDropRulePopulator.DelegateFishingRarityCondition.MatchCondition innerCondition)
    {
      this._condition = innerCondition;
    }

    public override bool Matches(FishingContext context) => this._condition(context);

    public delegate bool MatchCondition(FishingContext context);
  }

  protected class Rarity
  {
    public static FishRarityCondition Any;
    public static FishRarityCondition Legendary;
    public static FishRarityCondition VeryRare;
    public static FishRarityCondition Rare;
    public static FishRarityCondition Uncommon;
    public static FishRarityCondition Common;
    public static FishRarityCondition BombRarityOfNotLegendaryAndNotVeryRareAndUncommon;
    public static FishRarityCondition UncommonOrCommon;

    static Rarity()
    {
      AFishDropRulePopulator.DelegateFishingRarityCondition fishingRarityCondition1 = new AFishDropRulePopulator.DelegateFishingRarityCondition((AFishDropRulePopulator.DelegateFishingRarityCondition.MatchCondition) (context => true));
      fishingRarityCondition1.HackedIsAny = true;
      fishingRarityCondition1.FrequencyOfAppearanceForVisuals = 1f;
      AFishDropRulePopulator.Rarity.Any = (FishRarityCondition) fishingRarityCondition1;
      AFishDropRulePopulator.DelegateFishingRarityCondition fishingRarityCondition2 = new AFishDropRulePopulator.DelegateFishingRarityCondition((AFishDropRulePopulator.DelegateFishingRarityCondition.MatchCondition) (context => context.Fisher.legendary));
      fishingRarityCondition2.FrequencyOfAppearanceForVisuals = 0.1f;
      AFishDropRulePopulator.Rarity.Legendary = (FishRarityCondition) fishingRarityCondition2;
      AFishDropRulePopulator.DelegateFishingRarityCondition fishingRarityCondition3 = new AFishDropRulePopulator.DelegateFishingRarityCondition((AFishDropRulePopulator.DelegateFishingRarityCondition.MatchCondition) (context => context.Fisher.veryrare));
      fishingRarityCondition3.FrequencyOfAppearanceForVisuals = 0.25f;
      AFishDropRulePopulator.Rarity.VeryRare = (FishRarityCondition) fishingRarityCondition3;
      AFishDropRulePopulator.DelegateFishingRarityCondition fishingRarityCondition4 = new AFishDropRulePopulator.DelegateFishingRarityCondition((AFishDropRulePopulator.DelegateFishingRarityCondition.MatchCondition) (context => context.Fisher.rare));
      fishingRarityCondition4.FrequencyOfAppearanceForVisuals = 0.4f;
      AFishDropRulePopulator.Rarity.Rare = (FishRarityCondition) fishingRarityCondition4;
      AFishDropRulePopulator.DelegateFishingRarityCondition fishingRarityCondition5 = new AFishDropRulePopulator.DelegateFishingRarityCondition((AFishDropRulePopulator.DelegateFishingRarityCondition.MatchCondition) (context => context.Fisher.uncommon));
      fishingRarityCondition5.FrequencyOfAppearanceForVisuals = 0.8f;
      AFishDropRulePopulator.Rarity.Uncommon = (FishRarityCondition) fishingRarityCondition5;
      AFishDropRulePopulator.DelegateFishingRarityCondition fishingRarityCondition6 = new AFishDropRulePopulator.DelegateFishingRarityCondition((AFishDropRulePopulator.DelegateFishingRarityCondition.MatchCondition) (context => context.Fisher.common));
      fishingRarityCondition6.FrequencyOfAppearanceForVisuals = 1f;
      AFishDropRulePopulator.Rarity.Common = (FishRarityCondition) fishingRarityCondition6;
      AFishDropRulePopulator.DelegateFishingRarityCondition fishingRarityCondition7 = new AFishDropRulePopulator.DelegateFishingRarityCondition((AFishDropRulePopulator.DelegateFishingRarityCondition.MatchCondition) (context => !context.Fisher.legendary && !context.Fisher.veryrare && context.Fisher.uncommon));
      fishingRarityCondition7.FrequencyOfAppearanceForVisuals = 0.6f;
      AFishDropRulePopulator.Rarity.BombRarityOfNotLegendaryAndNotVeryRareAndUncommon = (FishRarityCondition) fishingRarityCondition7;
      AFishDropRulePopulator.DelegateFishingRarityCondition fishingRarityCondition8 = new AFishDropRulePopulator.DelegateFishingRarityCondition((AFishDropRulePopulator.DelegateFishingRarityCondition.MatchCondition) (context => context.Fisher.uncommon || context.Fisher.common));
      fishingRarityCondition8.FrequencyOfAppearanceForVisuals = 1f;
      AFishDropRulePopulator.Rarity.UncommonOrCommon = (FishRarityCondition) fishingRarityCondition8;
    }
  }
}
