// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.FlexibleTileWand
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;
using Terraria.Utilities;

#nullable disable
namespace Terraria.GameContent;

public class FlexibleTileWand
{
  public static FlexibleTileWand RubblePlacementSmall = FlexibleTileWand.CreateRubblePlacerSmall();
  public static FlexibleTileWand RubblePlacementMedium = FlexibleTileWand.CreateRubblePlacerMedium();
  public static FlexibleTileWand RubblePlacementLarge = FlexibleTileWand.CreateRubblePlacerLarge();
  public static FlexibleTileWand MiteyTitey = FlexibleTileWand.CreateMiteyTitey();
  public static FlexibleTileWand SandCastleBucket = FlexibleTileWand.CreateSingleTileWand(169, 552, 0, 1, 2, 3).WithoutAmmoIcon();
  public static FlexibleTileWand GardenGnome = FlexibleTileWand.CreateSingleTileWand(4609, 567, 0, 1, 2, 3, 4).WithoutAmmoIcon().WithoutAmmoConsumption();
  public static FlexibleTileWand Coral = FlexibleTileWand.CreateSingleTileWand(275, 81, 0, 1, 2, 3, 4, 5).WithoutAmmoIcon().WithoutAmmoConsumption();
  public static FlexibleTileWand Seashell = FlexibleTileWand.CreateSingleTileWand(2625, 324, 0, 1, 2).WithoutAmmoIcon().WithoutAmmoConsumption();
  public static FlexibleTileWand Starfish = FlexibleTileWand.CreateSingleTileWand(2626, 324, 3, 4, 5).WithoutAmmoIcon().WithoutAmmoConsumption();
  public static FlexibleTileWand LightningWhelkShell = FlexibleTileWand.CreateSingleTileWand(4072, 324, 6, 7, 8).WithoutAmmoIcon().WithoutAmmoConsumption();
  public static FlexibleTileWand TulipShell = FlexibleTileWand.CreateSingleTileWand(4073, 324, 9, 10, 11).WithoutAmmoIcon().WithoutAmmoConsumption();
  public static FlexibleTileWand JunoniaShell = FlexibleTileWand.CreateSingleTileWand(4071, 324, 12, 13, 14).WithoutAmmoIcon().WithoutAmmoConsumption();
  public static FlexibleTileWand JackoLantern = FlexibleTileWand.CreateSingleTileWand(1813, 35, 0, 1, 2, 3, 4, 5, 6, 7, 8).WithoutAmmoIcon().WithoutAmmoConsumption();
  public static FlexibleTileWand Catacomb = FlexibleTileWand.CreateSingleTileWand(1417, 241, 0, 1, 2, 3, 4, 5, 6, 7, 8).WithoutAmmoIcon().WithoutAmmoConsumption();
  public static FlexibleTileWand Present = FlexibleTileWand.CreateSingleTileWand(1869, 36, 0, 1, 2, 3, 4, 5, 6, 7).WithoutAmmoIcon().WithoutAmmoConsumption();
  public static FlexibleTileWand PartyPresent = FlexibleTileWand.CreateSingleTileWand(3749, 457, 0, 1, 2, 3, 4).WithoutAmmoIcon().WithoutAmmoConsumption();
  public static FlexibleTileWand Book = FlexibleTileWand.CreateSingleTileWand(149, 50, 0, 1, 2, 3, 4).WithoutAmmoIcon().WithoutAmmoConsumption();
  public static FlexibleTileWand LawnFlamingo = FlexibleTileWand.CreateSingleTileWand(4420, 545, 0, 1).WithoutAmmoIcon().WithoutAmmoConsumption();
  public static FlexibleTileWand PortableKiln = FlexibleTileWand.CreatePortableKiln();
  public static FlexibleTileWand DeadCellsDisplayJar = FlexibleTileWand.CreateSingleTileWand(5472, 698, 1, 2, 0).WithoutAmmoIcon().WithoutAmmoConsumption();
  private UnifiedRandom _random = new UnifiedRandom();
  private Dictionary<int, FlexibleTileWand.OptionBucket> _options = new Dictionary<int, FlexibleTileWand.OptionBucket>();
  public bool ConsumesAmmoItem = true;
  public bool ShowsHoverAmmoIcon = true;
  public bool CanConsumeFavorites = true;

  public FlexibleTileWand WithoutAmmoIcon()
  {
    this.ShowsHoverAmmoIcon = false;
    return this;
  }

  public FlexibleTileWand WithoutAmmoConsumption()
  {
    this.ConsumesAmmoItem = false;
    return this;
  }

  public FlexibleTileWand WithConsumingFavorites()
  {
    this.CanConsumeFavorites = true;
    return this;
  }

  public void AddVariation(int itemType, int tileIdToPlace, int tileStyleToPlace)
  {
    FlexibleTileWand.OptionBucket optionBucket;
    if (!this._options.TryGetValue(itemType, out optionBucket))
      optionBucket = this._options[itemType] = new FlexibleTileWand.OptionBucket(itemType);
    optionBucket.Options.Add(new FlexibleTileWand.PlacementOption()
    {
      TileIdToPlace = tileIdToPlace,
      TileStyleToPlace = tileStyleToPlace
    });
  }

  public void AddVariations(int itemType, int tileIdToPlace, params int[] stylesToPlace)
  {
    for (int index = 0; index < stylesToPlace.Length; ++index)
    {
      int tileStyleToPlace = stylesToPlace[index];
      this.AddVariation(itemType, tileIdToPlace, tileStyleToPlace);
    }
  }

  public void AddVariationsWithOffset(
    int itemType,
    int tileIdToPlace,
    int offset,
    params int[] stylesToPlace)
  {
    for (int index = 0; index < stylesToPlace.Length; ++index)
    {
      int tileStyleToPlace = offset + stylesToPlace[index];
      this.AddVariation(itemType, tileIdToPlace, tileStyleToPlace);
    }
  }

  public void AddVariations_ByRow(
    int itemType,
    int tileIdToPlace,
    int variationsPerRow,
    params int[] rows)
  {
    for (int index1 = 0; index1 < rows.Length; ++index1)
    {
      for (int index2 = 0; index2 < variationsPerRow; ++index2)
      {
        int tileStyleToPlace = rows[index1] * variationsPerRow + index2;
        this.AddVariation(itemType, tileIdToPlace, tileStyleToPlace);
      }
    }
  }

  public bool TryGetPlacementOption(
    Player player,
    int randomSeed,
    int selectCycleOffset,
    out FlexibleTileWand.PlacementOption option,
    out Item itemToConsume)
  {
    option = (FlexibleTileWand.PlacementOption) null;
    itemToConsume = (Item) null;
    Item[] inventory = player.inventory;
    int num = 1;
    for (int index = 0; index < 58 + num; ++index)
    {
      if (index < 50 || index >= 54)
      {
        Item obj = inventory[index];
        FlexibleTileWand.OptionBucket optionBucket;
        if (!obj.IsAir && (this.CanConsumeFavorites || !obj.favorited) && this._options.TryGetValue(obj.type, out optionBucket))
        {
          this._random.SetSeed(randomSeed);
          option = optionBucket.GetOptionWithCycling(selectCycleOffset);
          itemToConsume = obj;
          return true;
        }
      }
    }
    return false;
  }

  public static FlexibleTileWand CreateRubblePlacerLarge()
  {
    FlexibleTileWand rubblePlacerLarge = new FlexibleTileWand();
    int tileIdToPlace1 = 647;
    rubblePlacerLarge.AddVariations(154, tileIdToPlace1, 0, 1, 2, 3, 4, 5, 6);
    rubblePlacerLarge.AddVariations(3, tileIdToPlace1, 7, 8, 9, 10, 11, 12, 13, 14, 15);
    rubblePlacerLarge.AddVariations(71, tileIdToPlace1, 16 /*0x10*/, 17);
    rubblePlacerLarge.AddVariations(72, tileIdToPlace1, 18, 19);
    rubblePlacerLarge.AddVariations(73, tileIdToPlace1, 20, 21);
    rubblePlacerLarge.AddVariations(9, tileIdToPlace1, 22, 23, 24, 25);
    rubblePlacerLarge.AddVariations(593, tileIdToPlace1, 26, 27, 28, 29, 30, 31 /*0x1F*/);
    rubblePlacerLarge.AddVariations(183, tileIdToPlace1, 32 /*0x20*/, 33, 34);
    int tileIdToPlace2 = 648;
    rubblePlacerLarge.AddVariations(195, tileIdToPlace2, 0, 1, 2);
    rubblePlacerLarge.AddVariations(195, tileIdToPlace2, 3, 4, 5);
    rubblePlacerLarge.AddVariations(174, tileIdToPlace2, 6, 7, 8);
    rubblePlacerLarge.AddVariation(4144, 706, 0);
    rubblePlacerLarge.AddVariations(150, tileIdToPlace2, 9, 10, 11, 12, 13);
    rubblePlacerLarge.AddVariations(3, tileIdToPlace2, 14, 15, 16 /*0x10*/);
    rubblePlacerLarge.AddVariations(989, tileIdToPlace2, 17);
    rubblePlacerLarge.AddVariations(1101, tileIdToPlace2, 18, 19, 20);
    rubblePlacerLarge.AddVariations(9, tileIdToPlace2, 21, 22);
    rubblePlacerLarge.AddVariations(9, tileIdToPlace2, 23, 24, 25, 26, 27, 28);
    rubblePlacerLarge.AddVariations(3271, tileIdToPlace2, 29, 30, 31 /*0x1F*/, 32 /*0x20*/, 33, 34);
    rubblePlacerLarge.AddVariations(3086, tileIdToPlace2, 35, 36, 37, 38, 39, 40);
    rubblePlacerLarge.AddVariations(3081, tileIdToPlace2, 41, 42, 43, 44, 45, 46);
    rubblePlacerLarge.AddVariations(62, tileIdToPlace2, 47, 48 /*0x30*/, 49);
    rubblePlacerLarge.AddVariations(62, tileIdToPlace2, 50, 51);
    rubblePlacerLarge.AddVariations(154, tileIdToPlace2, 52, 53, 54);
    int tileIdToPlace3 = 651;
    rubblePlacerLarge.AddVariations(195, tileIdToPlace3, 0, 1, 2);
    rubblePlacerLarge.AddVariations(62, tileIdToPlace3, 3, 4, 5);
    rubblePlacerLarge.AddVariations(331, tileIdToPlace3, 6, 7, 8);
    rubblePlacerLarge.AddVariation(501, 704, 0);
    int tileIdToPlace4 = 705;
    rubblePlacerLarge.AddVariations(276, tileIdToPlace4, 0, 1, 2, 3, 4, 5, 6, 7, 8);
    rubblePlacerLarge.AddVariations(369, tileIdToPlace4, 9, 10, 11, 12, 13, 14, 15, 16 /*0x10*/, 17);
    rubblePlacerLarge.AddVariations(2171, tileIdToPlace4, 18, 19, 20, 21, 22, 23, 24, 25, 26);
    rubblePlacerLarge.AddVariations(59, tileIdToPlace4, 27, 28, 29, 30, 31 /*0x1F*/, 32 /*0x20*/, 33, 34, 35);
    return rubblePlacerLarge;
  }

  public static FlexibleTileWand CreateRubblePlacerMedium()
  {
    FlexibleTileWand rubblePlacerMedium = new FlexibleTileWand();
    ushort tileIdToPlace1 = 652;
    rubblePlacerMedium.AddVariations(195, (int) tileIdToPlace1, 0, 1, 2);
    rubblePlacerMedium.AddVariations(62, (int) tileIdToPlace1, 3, 4, 5);
    rubblePlacerMedium.AddVariations(331, (int) tileIdToPlace1, 6, 7, 8, 9, 10, 11);
    ushort tileIdToPlace2 = 649;
    rubblePlacerMedium.AddVariations(3, (int) tileIdToPlace2, 0, 1, 2, 3, 4, 5);
    rubblePlacerMedium.AddVariations(154, (int) tileIdToPlace2, 6, 7, 8, 9, 10);
    rubblePlacerMedium.AddVariations(154, (int) tileIdToPlace2, 11, 12, 13, 14, 15);
    rubblePlacerMedium.AddVariations(71, (int) tileIdToPlace2, 16 /*0x10*/);
    rubblePlacerMedium.AddVariations(72, (int) tileIdToPlace2, 17);
    rubblePlacerMedium.AddVariations(73, (int) tileIdToPlace2, 18);
    rubblePlacerMedium.AddVariations(181, (int) tileIdToPlace2, 19);
    rubblePlacerMedium.AddVariations(180, (int) tileIdToPlace2, 20);
    rubblePlacerMedium.AddVariations(177, (int) tileIdToPlace2, 21);
    rubblePlacerMedium.AddVariations(179, (int) tileIdToPlace2, 22);
    rubblePlacerMedium.AddVariations(178, (int) tileIdToPlace2, 23);
    rubblePlacerMedium.AddVariations(182, (int) tileIdToPlace2, 24);
    rubblePlacerMedium.AddVariations(593, (int) tileIdToPlace2, 25, 26, 27, 28, 29, 30);
    rubblePlacerMedium.AddVariations(9, (int) tileIdToPlace2, 31 /*0x1F*/, 32 /*0x20*/, 33);
    rubblePlacerMedium.AddVariations(150, (int) tileIdToPlace2, 34, 35, 36, 37);
    rubblePlacerMedium.AddVariations(3, (int) tileIdToPlace2, 38, 39, 40);
    rubblePlacerMedium.AddVariations(3271, (int) tileIdToPlace2, 41, 42, 43, 44, 45, 46);
    rubblePlacerMedium.AddVariations(3086, (int) tileIdToPlace2, 47, 48 /*0x30*/, 49, 50, 51, 52);
    rubblePlacerMedium.AddVariations(3081, (int) tileIdToPlace2, 53, 54, 55, 56, 57, 58);
    rubblePlacerMedium.AddVariations(62, (int) tileIdToPlace2, 59, 60, 61);
    rubblePlacerMedium.AddVariations(169, (int) tileIdToPlace2, 62, 63 /*0x3F*/, 65, 66, 67);
    rubblePlacerMedium.AddVariations(276, (int) tileIdToPlace2, 64 /*0x40*/);
    rubblePlacerMedium.AddVariations(1291, 702, 0, 1, 2);
    return rubblePlacerMedium;
  }

  public static FlexibleTileWand CreateRubblePlacerSmall()
  {
    FlexibleTileWand rubblePlacerSmall = new FlexibleTileWand();
    ushort tileIdToPlace = 650;
    rubblePlacerSmall.AddVariations(3, (int) tileIdToPlace, 0, 1, 2, 3, 4, 5);
    rubblePlacerSmall.AddVariations(2, (int) tileIdToPlace, 6, 7, 8, 9, 10, 11);
    rubblePlacerSmall.AddVariations(154, (int) tileIdToPlace, 12, 13, 14, 15, 16 /*0x10*/, 17, 18, 19);
    rubblePlacerSmall.AddVariations(154, (int) tileIdToPlace, 20, 21, 22, 23, 24, 25, 26, 27);
    rubblePlacerSmall.AddVariations(9, (int) tileIdToPlace, 28, 29, 30, 31 /*0x1F*/, 32 /*0x20*/);
    rubblePlacerSmall.AddVariations(9, (int) tileIdToPlace, 33, 34, 35);
    rubblePlacerSmall.AddVariations(593, (int) tileIdToPlace, 36, 37, 38, 39, 40, 41);
    rubblePlacerSmall.AddVariations(664, (int) tileIdToPlace, 42, 43, 44, 45, 46, 47);
    rubblePlacerSmall.AddVariations(150, (int) tileIdToPlace, 48 /*0x30*/, 49, 50, 51, 52, 53);
    rubblePlacerSmall.AddVariations(3271, (int) tileIdToPlace, 54, 55, 56, 57, 58, 59);
    rubblePlacerSmall.AddVariations(3086, (int) tileIdToPlace, 60, 61, 62, 63 /*0x3F*/, 64 /*0x40*/, 65);
    rubblePlacerSmall.AddVariations(3081, (int) tileIdToPlace, 66, 67, 68, 69, 70, 71);
    rubblePlacerSmall.AddVariations(62, (int) tileIdToPlace, 72);
    rubblePlacerSmall.AddVariations(169, (int) tileIdToPlace, 73, 74, 76, 78, 79, 80 /*0x50*/, 81);
    rubblePlacerSmall.AddVariations(276, (int) tileIdToPlace, 75, 77);
    rubblePlacerSmall.AddVariation(5114, 700, 0);
    rubblePlacerSmall.AddVariation(5333, 701, 0);
    rubblePlacerSmall.AddVariations(208 /*0xD0*/, 703, 6, 7);
    rubblePlacerSmall.AddVariations(331, 703, 8);
    rubblePlacerSmall.AddVariations(223, 703, 9);
    rubblePlacerSmall.AddVariation(165, 707, 5);
    return rubblePlacerSmall;
  }

  public static FlexibleTileWand CreateSingleTileWand(
    int itemIdToConsume,
    int TileTypeToplace,
    params int[] stylesToPlace)
  {
    FlexibleTileWand singleTileWand = new FlexibleTileWand();
    singleTileWand.AddVariations(itemIdToConsume, TileTypeToplace, stylesToPlace);
    return singleTileWand;
  }

  public static FlexibleTileWand CreateMiteyTitey()
  {
    FlexibleTileWand miteyTitey = new FlexibleTileWand();
    ushort tileIdToPlace1 = 693;
    miteyTitey.AddVariations(664, (int) tileIdToPlace1, 0, 1, 2);
    miteyTitey.AddVariations(3, (int) tileIdToPlace1, 3, 4, 5);
    miteyTitey.AddVariations(1124, (int) tileIdToPlace1, 9, 10, 11);
    miteyTitey.AddVariations(409, (int) tileIdToPlace1, 12, 13, 14);
    miteyTitey.AddVariations(61, (int) tileIdToPlace1, 15, 16 /*0x10*/, 17);
    miteyTitey.AddVariations(836, (int) tileIdToPlace1, 18, 19, 20);
    miteyTitey.AddVariations(3271, (int) tileIdToPlace1, 21, 22, 23);
    miteyTitey.AddVariations(3086, (int) tileIdToPlace1, 24, 25, 26);
    miteyTitey.AddVariations(3081, (int) tileIdToPlace1, 27, 28, 29);
    miteyTitey.AddVariations(834, (int) tileIdToPlace1, 30, 31 /*0x1F*/, 32 /*0x20*/);
    miteyTitey.AddVariations(833, (int) tileIdToPlace1, 33, 34, 35);
    miteyTitey.AddVariations(835, (int) tileIdToPlace1, 36, 37, 38);
    int offset = 39;
    miteyTitey.AddVariationsWithOffset(3, (int) tileIdToPlace1, offset, 3, 4, 5);
    miteyTitey.AddVariationsWithOffset(1124, (int) tileIdToPlace1, offset, 9, 10, 11);
    miteyTitey.AddVariationsWithOffset(409, (int) tileIdToPlace1, offset, 12, 13, 14);
    miteyTitey.AddVariationsWithOffset(61, (int) tileIdToPlace1, offset, 15, 16 /*0x10*/, 17);
    miteyTitey.AddVariationsWithOffset(836, (int) tileIdToPlace1, offset, 18, 19, 20);
    miteyTitey.AddVariationsWithOffset(3271, (int) tileIdToPlace1, offset, 21, 22, 23);
    miteyTitey.AddVariationsWithOffset(3086, (int) tileIdToPlace1, offset, 24, 25, 26);
    miteyTitey.AddVariationsWithOffset(3081, (int) tileIdToPlace1, offset, 27, 28, 29);
    ushort tileIdToPlace2 = 694;
    miteyTitey.AddVariations(664, (int) tileIdToPlace2, 0, 1, 2);
    miteyTitey.AddVariations(3, (int) tileIdToPlace2, 3, 4, 5);
    miteyTitey.AddVariations(150, (int) tileIdToPlace2, 6, 7, 8);
    miteyTitey.AddVariations(409, (int) tileIdToPlace2, 12, 13, 14);
    miteyTitey.AddVariations(61, (int) tileIdToPlace2, 15, 16 /*0x10*/, 17);
    miteyTitey.AddVariations(836, (int) tileIdToPlace2, 18, 19, 20);
    miteyTitey.AddVariations(3271, (int) tileIdToPlace2, 21, 22, 23);
    miteyTitey.AddVariations(3086, (int) tileIdToPlace2, 24, 25, 26);
    miteyTitey.AddVariations(3081, (int) tileIdToPlace2, 27, 28, 29);
    miteyTitey.AddVariations(834, (int) tileIdToPlace2, 30, 31 /*0x1F*/, 32 /*0x20*/);
    miteyTitey.AddVariations(833, (int) tileIdToPlace2, 33, 34, 35);
    miteyTitey.AddVariations(835, (int) tileIdToPlace2, 36, 37, 38);
    miteyTitey.AddVariationsWithOffset(3, (int) tileIdToPlace2, offset, 3, 4, 5);
    miteyTitey.AddVariationsWithOffset(409, (int) tileIdToPlace2, offset, 12, 13, 14);
    miteyTitey.AddVariationsWithOffset(61, (int) tileIdToPlace2, offset, 15, 16 /*0x10*/, 17);
    miteyTitey.AddVariationsWithOffset(836, (int) tileIdToPlace2, offset, 18, 19, 20);
    miteyTitey.AddVariationsWithOffset(3271, (int) tileIdToPlace2, offset, 21, 22, 23);
    miteyTitey.AddVariationsWithOffset(3086, (int) tileIdToPlace2, offset, 24, 25, 26);
    miteyTitey.AddVariationsWithOffset(3081, (int) tileIdToPlace2, offset, 27, 28, 29);
    return miteyTitey;
  }

  public static FlexibleTileWand CreatePortableKiln()
  {
    FlexibleTileWand portableKiln = new FlexibleTileWand();
    int variationsPerRow = 3;
    int tileIdToPlace = 653;
    portableKiln.AddVariations_ByRow(133, tileIdToPlace, variationsPerRow, 0, 1, 2, 3);
    portableKiln.AddVariations_ByRow(664, tileIdToPlace, variationsPerRow, 4, 5, 6);
    portableKiln.AddVariations_ByRow(4564, tileIdToPlace, variationsPerRow, 7, 8, 9);
    portableKiln.AddVariations_ByRow(154, tileIdToPlace, variationsPerRow, 10, 11, 12);
    portableKiln.AddVariations_ByRow(173, tileIdToPlace, variationsPerRow, 13, 14, 15);
    portableKiln.AddVariations_ByRow(61, tileIdToPlace, variationsPerRow, 16 /*0x10*/, 17, 18);
    portableKiln.AddVariations_ByRow(150, tileIdToPlace, variationsPerRow, 19, 20, 21);
    portableKiln.AddVariations_ByRow(836, tileIdToPlace, variationsPerRow, 22, 23, 24);
    portableKiln.AddVariations_ByRow(3272, tileIdToPlace, variationsPerRow, 25, 26, 27);
    portableKiln.AddVariations_ByRow(1101, tileIdToPlace, variationsPerRow, 28, 29, 30);
    portableKiln.AddVariations_ByRow(3081, tileIdToPlace, variationsPerRow, 31 /*0x1F*/, 32 /*0x20*/, 33);
    portableKiln.AddVariations_ByRow(3271, tileIdToPlace, variationsPerRow, 34, 35, 36);
    return portableKiln;
  }

  private class OptionBucket
  {
    public int ItemTypeToConsume;
    public List<FlexibleTileWand.PlacementOption> Options;

    public OptionBucket(int itemTypeToConsume)
    {
      this.ItemTypeToConsume = itemTypeToConsume;
      this.Options = new List<FlexibleTileWand.PlacementOption>();
    }

    public FlexibleTileWand.PlacementOption GetRandomOption(UnifiedRandom random)
    {
      return this.Options[random.Next(this.Options.Count)];
    }

    public FlexibleTileWand.PlacementOption GetOptionWithCycling(int cycleOffset)
    {
      int count = this.Options.Count;
      return this.Options[(cycleOffset % count + count) % count];
    }
  }

  public class PlacementOption
  {
    public int TileIdToPlace;
    public int TileStyleToPlace;
  }
}
