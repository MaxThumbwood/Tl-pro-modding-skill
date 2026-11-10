// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.FishDropRules.GameContentFishDropPopulator
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.FishDropRules;

public class GameContentFishDropPopulator(FishDropRuleList list) : AFishDropRulePopulator(list)
{
  public void Populate()
  {
    this.AddStopper(this.AnyEnemies);
    this.LavaDrops();
    this.HoneyDrops();
    this.JunkDrops();
    this.CrateDrops();
    this.RareDrops();
    this.RemixDrops();
    this.DungeonDrops();
    this.CorruptionDrops();
    this.CrimsonDrops();
    this.HallowedDrops();
    this.GlowingMushroomsDrops();
    this.SnowDrops();
    this.JungleDrops();
    this.OceanDrops();
    this.DesertDrops();
    this.FloatingIslandDrops();
    this.SurfaceDrops();
  }

  private void RemixDrops()
  {
    this.AddQuestFishForRemix(AFishDropRulePopulator.Rarity.Uncommon, 1, 2461);
    this.AddQuestFishForRemix(AFishDropRulePopulator.Rarity.Uncommon, 1, 2458);
    this.AddQuestFishForRemix(AFishDropRulePopulator.Rarity.Uncommon, 1, 2459);
    this.AddQuestFishForRemix(AFishDropRulePopulator.Rarity.Uncommon, 1, 2479);
    this.AddQuestFishForRemix(AFishDropRulePopulator.Rarity.Uncommon, 1, 2456);
    this.AddQuestFishForRemix(AFishDropRulePopulator.Rarity.Uncommon, 1, 2474);
    this.AddQuestFishForRemix(AFishDropRulePopulator.Rarity.Uncommon, 1, 2478);
    this.AddQuestFishForRemix(AFishDropRulePopulator.Rarity.Uncommon, 1, 2450);
    this.AddQuestFishForRemix(AFishDropRulePopulator.Rarity.Uncommon, 1, 2464);
    this.AddQuestFishForRemix(AFishDropRulePopulator.Rarity.Uncommon, 1, 2469);
  }

  private void SurfaceDrops()
  {
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2455, this.Height1And2);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2479, this.Height1);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2456, this.Height1);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2474, this.Height1);
    this.Add(AFishDropRulePopulator.Rarity.Rare, 10, 2437, this.HeightAbove1, this.HardMode);
    this.Add(AFishDropRulePopulator.Rarity.Rare, 9, 2436, this.HeightAbove1, this.HardMode);
    this.Add(AFishDropRulePopulator.Rarity.Rare, 5, 2436, this.HeightAbove1, this.EarlyMode);
    this.Add(AFishDropRulePopulator.Rarity.Legendary, 2, 3, 2308, this.HeightAbove1);
    this.Add(AFishDropRulePopulator.Rarity.VeryRare, 2, 2320, this.HeightAbove1);
    this.Add(AFishDropRulePopulator.Rarity.Rare, 1, 2321, this.HeightAbove1);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2478, this.HeightAbove1);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2450, this.HeightAbove1);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2464, this.HeightAbove1);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2469, this.HeightAbove1);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2462, this.HeightAbove2);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2482, this.HeightAbove2);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2472, this.HeightAbove2);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2460, this.HeightAbove2);
    this.Add(AFishDropRulePopulator.Rarity.Uncommon, 3, 4, 2303 /*0x08FF*/, this.HeightAbove1);
    this.Add(AFishDropRulePopulator.Rarity.UncommonOrCommon, 4, this.Group(2303 /*0x08FF*/, 2309, 2309, 2309), this.HeightAbove1);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2487);
    this.Add(AFishDropRulePopulator.Rarity.Common, 1, 2298, this.Water1000);
    this.Add(AFishDropRulePopulator.Rarity.Any, 1, 2290);
  }

  private void FloatingIslandDrops()
  {
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2461, this.HeightUnder2);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2453, this.Height0);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2473, this.Height0);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2476, this.Height0);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2458, this.HeightUnder2);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2459, this.HeightUnder2);
    this.Add(AFishDropRulePopulator.Rarity.Uncommon, 1, 2304 /*0x0900*/, this.Height0);
  }

  private void DesertDrops()
  {
    AFishingCondition desert = this.Desert;
    this.Add(AFishDropRulePopulator.Rarity.Legendary, 3, 5490, desert);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 4393, desert);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 4394, desert);
    this.Add(AFishDropRulePopulator.Rarity.Uncommon, 1, 4410, desert);
    this.Add(AFishDropRulePopulator.Rarity.Any, 3, 4402, desert);
    this.Add(AFishDropRulePopulator.Rarity.Any, 1, 4401, desert);
  }

  private void OceanDrops()
  {
    AFishingCondition ocean = this.Ocean;
    this.Add(AFishDropRulePopulator.Rarity.VeryRare, 2, 2341, ocean);
    this.Add(AFishDropRulePopulator.Rarity.VeryRare, 1, 2342, ocean);
    this.Add(AFishDropRulePopulator.Rarity.Rare, 5, 2438, ocean);
    this.Add(AFishDropRulePopulator.Rarity.Rare, 3, 2332, ocean);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2480, ocean);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2481, ocean);
    this.Add(AFishDropRulePopulator.Rarity.Uncommon, 1, 2316, ocean);
    this.Add(AFishDropRulePopulator.Rarity.Common, 2, 2301, ocean);
    this.Add(AFishDropRulePopulator.Rarity.Common, 1, 2300, ocean);
    this.Add(AFishDropRulePopulator.Rarity.Any, 1, 2297, ocean);
    this.AddStopper(ocean);
  }

  private void JungleDrops()
  {
    AFishingCondition jungle = this.Jungle;
    this.Add(AFishDropRulePopulator.Rarity.Legendary, 2, 3, 5634, jungle);
    this.Add(AFishDropRulePopulator.Rarity.Legendary, 2, 5463, jungle, this.HardMode);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2452, jungle, this.Height1);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2483, jungle, this.Height1);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2488, jungle, this.Height1);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2486, jungle, this.HeightAboveAnd1);
    this.Add(AFishDropRulePopulator.Rarity.Uncommon, 1, 2311, jungle, this.HeightAbove1);
    this.Add(AFishDropRulePopulator.Rarity.Uncommon, 1, 2313, jungle);
    this.Add(AFishDropRulePopulator.Rarity.Common, 1, 2302, jungle);
  }

  private void SnowDrops()
  {
    AFishingCondition snow = this.Snow;
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2467, snow, this.HeightUnder2);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2470, snow, this.Height1);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2484, snow, this.HeightAbove1);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2466, snow, this.HeightAbove1);
    this.Add(AFishDropRulePopulator.Rarity.Common, 12, 3197, snow);
    this.Add(AFishDropRulePopulator.Rarity.Uncommon, 6, 3197, snow);
    this.Add(AFishDropRulePopulator.Rarity.Uncommon, 1, 2306, snow);
    this.Add(AFishDropRulePopulator.Rarity.Common, 1, 2299, snow);
    this.Add(AFishDropRulePopulator.Rarity.Any, 3, 2309, snow, this.HeightAbove1);
  }

  private void GlowingMushroomsDrops()
  {
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2475, this.GlowingMushrooms);
  }

  private void HallowedDrops()
  {
    AFishingCondition rolledHallowDesert = this.RolledHallowDesert;
    this.Add(AFishDropRulePopulator.Rarity.Legendary, 1, 5490, rolledHallowDesert);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 4393, rolledHallowDesert);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 4394, rolledHallowDesert);
    this.Add(AFishDropRulePopulator.Rarity.Uncommon, 1, 4410, rolledHallowDesert);
    this.Add(AFishDropRulePopulator.Rarity.Any, 3, 4402, rolledHallowDesert);
    this.Add(AFishDropRulePopulator.Rarity.Any, 1, 4401, rolledHallowDesert);
    AFishingCondition hallow = this.Hallow;
    this.Add(AFishDropRulePopulator.Rarity.Legendary, 2, 3, 2429, this.TrueSnow, hallow, this.HardMode, this.Height3);
    this.Add(AFishDropRulePopulator.Rarity.Legendary, 2, 3209, hallow, this.HardMode);
    this.Add(AFishDropRulePopulator.Rarity.Legendary, 2, 3, 5274, hallow, this.HardMode);
    this.Add(AFishDropRulePopulator.Rarity.VeryRare, 1, 2317, hallow, this.HeightAbove1);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2465, hallow, this.HeightAbove1);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2468, hallow, this.HeightUnder2);
    this.Add(AFishDropRulePopulator.Rarity.Rare, 1, 2310, hallow);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2471, hallow);
    this.Add(AFishDropRulePopulator.Rarity.Uncommon, 1, 2307, hallow);
  }

  private void CrimsonDrops()
  {
    AFishingCondition crimson = this.Crimson;
    this.Add(AFishDropRulePopulator.Rarity.Legendary, 2, 3, 2429, this.TrueSnow, crimson, this.HardMode, this.Height3);
    this.Add(AFishDropRulePopulator.Rarity.Legendary, 2, 3211, crimson, this.HardMode);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2477, crimson);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2463, crimson);
    this.Add(AFishDropRulePopulator.Rarity.Uncommon, 1, 2319, crimson);
    this.Add(AFishDropRulePopulator.Rarity.Common, 1, 2305, crimson);
  }

  private void CorruptionDrops()
  {
    AFishingCondition corruption = this.Corruption;
    this.Add(AFishDropRulePopulator.Rarity.Legendary, 2, 3, 2429, this.TrueSnow, corruption, this.HardMode, this.Height3);
    this.Add(AFishDropRulePopulator.Rarity.Legendary, 2, 3210, corruption, this.HardMode);
    this.Add(AFishDropRulePopulator.Rarity.Rare, 1, 2330, corruption);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2454, corruption);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2485, corruption);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2457, corruption);
    this.Add(AFishDropRulePopulator.Rarity.Uncommon, 1, 2318, corruption);
  }

  private void DungeonDrops()
  {
    this.Add(AFishDropRulePopulator.Rarity.VeryRare, 12, 3000, this.Dungeon);
    this.Add(AFishDropRulePopulator.Rarity.VeryRare, 12, 2999, this.Dungeon);
  }

  private void RareDrops()
  {
    this.Add(AFishDropRulePopulator.Rarity.Legendary, 2, 4382, this.BloodMoon, this.DidNotUseCombatBook);
    this.Add(AFishDropRulePopulator.Rarity.Legendary, 2, 5240, this.BloodMoon);
    this.Add(AFishDropRulePopulator.Rarity.Legendary, 5, 2423);
    this.Add(AFishDropRulePopulator.Rarity.Legendary, 5, 3225);
    this.Add(AFishDropRulePopulator.Rarity.Legendary, 10, 2420);
    this.Add(AFishDropRulePopulator.Rarity.BombRarityOfNotLegendaryAndNotVeryRareAndUncommon, 5, 3196);
  }

  private void CrateDrops()
  {
    this.AddWithHardmode(AFishDropRulePopulator.Rarity.Rare, 1, 3205, 3984, this.Crate, this.Dungeon);
    this.AddWithHardmode(AFishDropRulePopulator.Rarity.Rare, 1, 5002, 5003, this.Crate, this.Beach);
    this.AddWithHardmode(AFishDropRulePopulator.Rarity.Rare, 1, 3203, 3982, this.Crate, this.Corruption);
    this.AddWithHardmode(AFishDropRulePopulator.Rarity.Rare, 1, 3204, 3983, this.Crate, this.Crimson);
    this.AddWithHardmode(AFishDropRulePopulator.Rarity.Rare, 1, 3207, 3986, this.Crate, this.Hallow);
    this.AddWithHardmode(AFishDropRulePopulator.Rarity.Rare, 1, 3208, 3987, this.Crate, this.Jungle);
    this.AddWithHardmode(AFishDropRulePopulator.Rarity.Rare, 1, 4405, 4406, this.Crate, this.Snow);
    this.AddWithHardmode(AFishDropRulePopulator.Rarity.Rare, 1, 4407, 4408, this.Crate, this.TrueDesert);
    this.AddWithHardmode(AFishDropRulePopulator.Rarity.Rare, 1, 3206, 3985, this.Crate, this.Height0);
    this.AddWithHardmode(AFishDropRulePopulator.Rarity.Rare, 1, 5002, 5003, this.Crate, this.Remix, this.Height1, this.UnderRockLayer);
    this.AddWithHardmode(AFishDropRulePopulator.Rarity.Legendary, 1, 2336, 3981, this.Crate);
    this.AddWithHardmode(AFishDropRulePopulator.Rarity.VeryRare, 1, 2336, 3981, this.Crate);
    this.AddWithHardmode(AFishDropRulePopulator.Rarity.Rare, 1, 2335, 3980, this.Crate);
    this.AddWithHardmode(AFishDropRulePopulator.Rarity.Uncommon, 1, 2335, 3980, this.Crate);
    this.AddWithHardmode(AFishDropRulePopulator.Rarity.Any, 1, 2334, 3979, this.Crate);
    this.AddStopper(this.Crate);
  }

  private void JunkDrops()
  {
    this.Add(AFishDropRulePopulator.Rarity.Any, 8, 5275, this.Junk);
    this.Add(AFishDropRulePopulator.Rarity.Any, 1, this.Group(2337, 2338, 2339), this.Junk);
    this.AddStopper(this.Junk);
  }

  private void HoneyDrops()
  {
    this.Add(AFishDropRulePopulator.Rarity.Rare, 1, 2314, this.InHoney);
    this.Add(AFishDropRulePopulator.Rarity.Uncommon, 2, 2314, this.InHoney);
    this.AddQuestFish(AFishDropRulePopulator.Rarity.Uncommon, 1, 2451, this.InHoney);
    this.AddStopper(this.InHoney);
  }

  private void LavaDrops()
  {
    AFishingCondition[] original = this.Join(this.InLava, this.CanFishInLava);
    this.AddWithHardmode(AFishDropRulePopulator.Rarity.Any, 6, 4877, 4878, this.Join(original, this.Crate));
    this.Add(AFishDropRulePopulator.Rarity.Legendary, 3, this.Group(4819, 4820, 4872, 2331), this.Join(original, this.HardMode));
    this.Add(AFishDropRulePopulator.Rarity.Legendary, 3, this.Group(4819, 4820, 4872), this.Join(original, this.EarlyMode));
    this.Add(AFishDropRulePopulator.Rarity.VeryRare, 1, 2312, original);
    this.Add(AFishDropRulePopulator.Rarity.Rare, 1, 2315, original);
    this.AddStopper(this.InLava);
  }
}
