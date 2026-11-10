// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.ShimmerTransforms
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using Terraria.Enums;
using Terraria.ID;

#nullable disable
namespace Terraria.GameContent;

public static class ShimmerTransforms
{
  public static int GetDecraftingRecipeIndex(int type)
  {
    int num = ItemID.Sets.IsCrafted[type];
    if (num < 0)
      return -1;
    if (WorldGen.crimson && ItemID.Sets.IsCraftedCrimson[type] >= 0)
      return ItemID.Sets.IsCraftedCrimson[type];
    return !WorldGen.crimson && ItemID.Sets.IsCraftedCorruption[type] >= 0 ? ItemID.Sets.IsCraftedCorruption[type] : num;
  }

  public static bool IsItemTransformLocked(int type)
  {
    return !NPC.downedMoonlord && ItemID.Sets.ShimmerPostMoonlord[type];
  }

  public static bool IsItemDecraftLocked(int type)
  {
    return ShimmerTransforms.IsRecipeIndexDecraftLocked(ShimmerTransforms.GetDecraftingRecipeIndex(type));
  }

  public static bool IsRecipeIndexDecraftLocked(int recipeIndex)
  {
    return recipeIndex >= 0 && (!NPC.downedBoss3 && ShimmerTransforms.RecipeSets.PostSkeletron[recipeIndex] || !NPC.downedGolemBoss && ShimmerTransforms.RecipeSets.PostGolem[recipeIndex]);
  }

  public static bool IsItemDecraftableAndIsDecraftUnlocked(Item item)
  {
    if (item == null)
      return false;
    int decraftingRecipeIndex = ShimmerTransforms.GetDecraftingRecipeIndex(item.GetShimmerEquivalentType(true));
    return !ShimmerTransforms.IsRecipeIndexDecraftLocked(decraftingRecipeIndex) && decraftingRecipeIndex >= 0 && item.stack / Main.recipe[decraftingRecipeIndex].createItem.stack > 0;
  }

  public static void UpdateRecipeSets()
  {
    ShimmerTransforms.RecipeSets.PostSkeletron = Utils.MapArray<Recipe, bool>(Main.recipe, (Func<Recipe, bool>) (r => r.ContainsIngredient(154)));
    ShimmerTransforms.RecipeSets.PostGolem = Utils.MapArray<Recipe, bool>(Main.recipe, (Func<Recipe, bool>) (r => r.ContainsIngredient(1101)));
  }

  public static int GetTransformToItem(int type)
  {
    int transformToItem = ItemID.Sets.ShimmerTransformToItem[type];
    if (transformToItem > 0)
      return transformToItem;
    if (ContentSamples.ItemsByType[type].createTile == 139)
    {
      switch (ContentSamples.ItemsByType[type].placeStyle)
      {
        case 89:
          return 5579;
        case 90:
          return 5538;
        case 96 /*0x60*/:
          return 5639;
        case 97:
          return 5638;
        default:
          return 576;
      }
    }
    else
      return type == 3461 ? ShimmerTransforms.GetLunarBrickTransformFromMoonPhase(Main.GetMoonPhase()) : 0;
  }

  private static int GetLunarBrickTransformFromMoonPhase(MoonPhase moonPhase)
  {
    switch (moonPhase)
    {
      case MoonPhase.Full:
        return 5408;
      case MoonPhase.ThreeQuartersAtLeft:
        return 5401;
      case MoonPhase.HalfAtLeft:
        return 5403;
      case MoonPhase.QuarterAtLeft:
        return 5402;
      case MoonPhase.QuarterAtRight:
        return 5407;
      case MoonPhase.HalfAtRight:
        return 5405;
      case MoonPhase.ThreeQuartersAtRight:
        return 5404;
      default:
        return 5406;
    }
  }

  public static class RecipeSets
  {
    public static bool[] PostSkeletron;
    public static bool[] PostGolem;
  }
}
