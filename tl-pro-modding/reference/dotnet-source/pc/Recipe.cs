// Decompiled with JetBrains decompiler
// Type: Terraria.Recipe
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Collections.Generic;
using System.Text;
using Terraria.GameContent;
using Terraria.GameContent.UI;
using Terraria.ID;
using Terraria.Map;
using Terraria.UI;

#nullable disable
namespace Terraria;

public class Recipe
{
  public static int maxRequirements = 15;
  public static int maxRecipes = 3600;
  public static int numRecipes;
  public static bool[] TileUsedInRecipes = new bool[(int) TileID.Count];
  public static List<int>[] TileCountsAs = new List<int>[(int) TileID.Count];
  private static Recipe currentRecipe = new Recipe();
  public Item createItem = new Item();
  public Item[] requiredItem = new Item[Recipe.maxRequirements];
  public int requiredTile = -1;
  public int[] acceptedGroups = new int[Recipe.maxRequirements];
  public Recipe.RequiredItemEntry[] requiredItemQuickLookup = new Recipe.RequiredItemEntry[Recipe.maxRequirements];
  public List<Item> customShimmerResults;
  public bool needHoney;
  public bool needWater;
  public bool needLava;
  public bool needTorchGodsFavor;
  public bool alchemy;
  public bool needSnowBiome;
  public bool needGraveyardBiome;
  public bool needMechdusa;
  public bool notDecraftable;
  public bool crimson;
  public bool corruption;
  private static Dictionary<int, int> _ownedItems = new Dictionary<int, int>();
  internal static List<Chest> _recipeChests = new List<Chest>();

  public bool DoesNotNeedTileOrLiquid
  {
    get => this.requiredTile < 0 && !this.needHoney && !this.needWater && !this.needLava;
  }

  public override string ToString()
  {
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.AppendLine(this.createItem.ToString());
    foreach (Item obj in this.requiredItem)
    {
      if (!obj.IsAir)
        stringBuilder.AppendLine("  " + obj.ToString());
      else
        break;
    }
    foreach (int acceptedGroup in this.acceptedGroups)
    {
      if (acceptedGroup >= 0)
        stringBuilder.AppendLine("  " + (object) RecipeGroup.recipeGroups[acceptedGroup]);
      else
        break;
    }
    return stringBuilder.ToString();
  }

  public void RequireGroup(RecipeGroup group)
  {
    for (int index = 0; index < Recipe.maxRequirements; ++index)
    {
      if (this.acceptedGroups[index] == -1)
      {
        this.acceptedGroups[index] = group.RegisteredId;
        break;
      }
    }
  }

  public bool ProcessGroupsForText(int type, out string theText)
  {
    for (int index = 0; index < Recipe.maxRequirements; ++index)
    {
      int acceptedGroup = this.acceptedGroups[index];
      if (acceptedGroup != -1)
      {
        if (RecipeGroup.recipeGroups[acceptedGroup].ValidItems.Contains(type))
        {
          theText = RecipeGroup.recipeGroups[acceptedGroup].GetText();
          return true;
        }
      }
      else
        break;
    }
    theText = "";
    return false;
  }

  public Item AddCustomShimmerResult(int itemType, int itemStack = 1)
  {
    if (this.customShimmerResults == null)
      this.customShimmerResults = new List<Item>();
    Item obj = new Item();
    obj.SetDefaults(itemType);
    obj.stack = itemStack;
    this.customShimmerResults.Add(obj);
    return obj;
  }

  public Recipe()
  {
    for (int index = 0; index < Recipe.maxRequirements; ++index)
    {
      this.requiredItem[index] = new Item();
      this.acceptedGroups[index] = -1;
    }
  }

  public void GetIngredientsForOneCraft(Player player, List<Recipe.RequiredItemEntry> ingredients)
  {
    for (int index = 0; index < Recipe.maxRequirements; ++index)
    {
      Recipe.RequiredItemEntry req = this.requiredItemQuickLookup[index];
      if (req.itemIdOrRecipeGroup == 0)
        break;
      req.stack -= this.GetIngredientCraftingDiscount(player, req);
      if (req.stack > 0)
        ingredients.Add(req);
    }
  }

  private int GetIngredientCraftingDiscount(Player player, Recipe.RequiredItemEntry req)
  {
    int craftingDiscount = 0;
    if (this.alchemy && player.alchemyTable)
    {
      for (int index = 0; index < req.stack; ++index)
      {
        if (Main.rand.Next(3) == 0)
          ++craftingDiscount;
      }
    }
    return craftingDiscount;
  }

  public static void UpdateRecipeList()
  {
    int focusRecipe = Main.focusRecipe;
    int oldRecipe = Main.availableRecipe[Main.focusRecipe];
    Recipe.ClearAvailableRecipes();
    if ((Main.guideItem.IsAir ? 0 : (Main.guideItem.Name != "" ? 1 : 0)) != 0)
    {
      Recipe.CollectGuideRecipes();
      Recipe.TryRefocusingRecipe(oldRecipe);
      Main.craftingUI.VisuallyRepositionRecipes(focusRecipe);
    }
    else
    {
      Player localPlayer = Main.LocalPlayer;
      Recipe.CollectItemsToCraftWithFrom(localPlayer);
      NewCraftingUI.RecipeFilter recipeFilterHack = CraftingUI.RecipeFilterHack;
      for (int recipeIndex = 0; recipeIndex < Recipe.maxRecipes; ++recipeIndex)
      {
        Recipe recipe = Main.recipe[recipeIndex];
        if (recipe.createItem.type != 0)
        {
          if ((recipeFilterHack == null || recipeFilterHack.Accepts(recipe)) && recipe.PlayerMeetsEnvironmentConditions(localPlayer) && Recipe.CollectedEnoughItemsToCraft(recipe))
            Recipe.AddToAvailableRecipes(recipeIndex);
        }
        else
          break;
      }
      Recipe.TryRefocusingRecipe(oldRecipe);
      Main.craftingUI.VisuallyRepositionRecipes(focusRecipe);
    }
  }

  public static void SubtractOwnedItem(Recipe.RequiredItemEntry req)
  {
    int num;
    if (!Recipe._ownedItems.TryGetValue(req.itemIdOrRecipeGroup, out num))
      return;
    Recipe._ownedItems[req.itemIdOrRecipeGroup] = Math.Max(num - req.stack, 0);
  }

  private static void AddToAvailableRecipes(int recipeIndex)
  {
    Main.availableRecipe[Main.numAvailableRecipes] = recipeIndex;
    ++Main.numAvailableRecipes;
  }

  public static bool CollectedEnoughItemsToCraft(Recipe recipe)
  {
    return Recipe.CollectedEnoughItemsToCraft(recipe.requiredItemQuickLookup);
  }

  public static bool CollectedEnoughItemsToCraft(Recipe.RequiredItemEntry[] requiredItems)
  {
    return Recipe.HowManyTimesCanRecipeBeCrafted(requiredItems) > 0;
  }

  public static int HowManyTimesCanRecipeBeCrafted(Recipe recipe)
  {
    return Recipe.HowManyTimesCanRecipeBeCrafted(recipe.requiredItemQuickLookup);
  }

  public static int HowManyTimesCanRecipeBeCrafted(Recipe.RequiredItemEntry[] requiredItems)
  {
    int val1 = int.MaxValue;
    foreach (Recipe.RequiredItemEntry requiredItem in requiredItems)
    {
      if (requiredItem.itemIdOrRecipeGroup != 0)
      {
        int num;
        if (!Recipe._ownedItems.TryGetValue(requiredItem.itemIdOrRecipeGroup, out num))
          return 0;
        val1 = Math.Min(val1, num / requiredItem.stack);
        if (val1 == 0)
          break;
      }
      else
        break;
    }
    return val1;
  }

  public static int GetAvailableItemCount(Recipe.RequiredItemEntry item)
  {
    int num;
    return !Recipe._ownedItems.TryGetValue(item.itemIdOrRecipeGroup, out num) ? 0 : num;
  }

  public bool PlayerMeetsEnvironmentConditions(Player player, List<string> missingObjects = null)
  {
    bool flag = true;
    if (this.requiredTile >= 0 && !player.adjTile[this.requiredTile])
      flag &= Recipe.AddMissing(Recipe.GetRequiredTileName(this.requiredTile), missingObjects);
    if (this.needWater && !player.adjWaterSource)
      flag &= Recipe.AddMissing(Lang.inter[53].Value, missingObjects);
    if (this.needHoney && !player.adjHoney)
      flag &= Recipe.AddMissing(Lang.inter[58].Value, missingObjects);
    if (this.needLava && !player.adjLava)
      flag &= Recipe.AddMissing(Lang.inter[56].Value, missingObjects);
    if (this.needSnowBiome && !player.ZoneSnow)
      flag &= Recipe.AddMissing(Lang.inter[123].Value, missingObjects);
    if (this.needGraveyardBiome && !player.ZoneGraveyard)
      flag &= Recipe.AddMissing(Lang.inter[124].Value, missingObjects);
    if (this.needMechdusa)
      flag &= SpecialSeedFeatures.Mechdusa;
    if (this.needTorchGodsFavor && !player.unlockedBiomeTorches)
      flag &= Recipe.AddMissing(Lang.inter[125].Value, missingObjects);
    return flag;
  }

  private static bool AddMissing(string objectName, List<string> missingObjects)
  {
    missingObjects?.Add(objectName);
    return false;
  }

  private static void CollectItemsToCraftWithFrom(Player player)
  {
    Recipe._ownedItems.Clear();
    Recipe.CollectItems(player.inventory, 58);
    Recipe.CollectItemsFromChests(player);
    Recipe.AddFakeCountsForItemGroups();
    CraftingRequests.SubtractPendingRequests();
  }

  private static void CollectItemsFromChests(Player player)
  {
    Recipe._recipeChests.Clear();
    if (player.chest != -1)
      Recipe._recipeChests.Add(player.GetCurrentContainer());
    if (player.useVoidBag() && player.chest != -5)
      Recipe._recipeChests.Add(player.bank4);
    if (Player.Settings.CraftFromNearbyChests)
    {
      foreach (PositionedChest positionedChest in NearbyChests.GetBanksInRangeOf(player))
      {
        if (!Recipe._recipeChests.Contains(positionedChest.chest))
          Recipe._recipeChests.Add(positionedChest.chest);
      }
      foreach (PositionedChest positionedChest in NearbyChests.GetChestsInRangeOf(player.position))
      {
        if (!positionedChest.chest.IsLockedOrInUse())
          Recipe._recipeChests.Add(positionedChest.chest);
      }
    }
    foreach (Chest recipeChest in Recipe._recipeChests)
      Recipe.CollectItems(recipeChest.item, recipeChest.maxItems);
  }

  private static void AddFakeCountsForItemGroups()
  {
    foreach (RecipeGroup recipeGroup in RecipeGroup.recipeGroups.Values)
    {
      int groupFakeItemId = recipeGroup.GetGroupFakeItemId();
      Recipe._ownedItems[groupFakeItemId] = recipeGroup.CountUsableItems(Recipe._ownedItems);
    }
  }

  private static void CollectItems(Item[] currentInventory, int slotCap)
  {
    for (int index = 0; index < slotCap; ++index)
    {
      Item obj = currentInventory[index];
      if (obj.stack > 0)
      {
        int stack = obj.stack;
        int num;
        if (Recipe._ownedItems.TryGetValue(obj.type, out num))
          stack += num;
        Recipe._ownedItems[obj.type] = stack;
      }
    }
  }

  public static void ConsumeOwnedItem(int type, int qty) => Recipe._ownedItems[type] -= qty;

  private static void CollectGuideRecipes()
  {
    int type = Main.guideItem.type;
    for (int index1 = 0; index1 < Recipe.maxRecipes; ++index1)
    {
      Recipe recipe = Main.recipe[index1];
      if (recipe.createItem.type == 0)
        break;
      for (int index2 = 0; index2 < Recipe.maxRequirements; ++index2)
      {
        Recipe.RequiredItemEntry requiredItemEntry = recipe.requiredItemQuickLookup[index2];
        if (requiredItemEntry.itemIdOrRecipeGroup != 0)
        {
          if (requiredItemEntry.Matches(type))
          {
            Main.availableRecipe[Main.numAvailableRecipes] = index1;
            ++Main.numAvailableRecipes;
            break;
          }
        }
        else
          break;
      }
    }
  }

  public static void ClearAvailableRecipes()
  {
    for (int index = 0; index < Recipe.maxRecipes; ++index)
      Main.availableRecipe[index] = 0;
    Main.numAvailableRecipes = 0;
  }

  private static void TryRefocusingRecipe(int oldRecipe)
  {
    for (int index = 0; index < Main.numAvailableRecipes; ++index)
    {
      if (oldRecipe == Main.availableRecipe[index])
      {
        Main.focusRecipe = index;
        break;
      }
    }
    if (Main.focusRecipe >= Main.numAvailableRecipes)
      Main.focusRecipe = Main.numAvailableRecipes - 1;
    if (Main.focusRecipe >= 0)
      return;
    Main.focusRecipe = 0;
  }

  public static void SetupRecipeGroups()
  {
    RecipeGroups.Birds = new RecipeGroup("NPCName.Bird", new int[3]
    {
      2015,
      2016,
      2017
    }).Register();
    RecipeGroups.Scorpions = new RecipeGroup("NPCName.Scorpion", new int[2]
    {
      2157,
      2156
    }).Register();
    RecipeGroups.Squirrels = new RecipeGroup("NPCName.Squirrel", new int[2]
    {
      2018,
      3563
    }).Register();
    RecipeGroups.Bugs = new RecipeGroup(Lang.misc[85].Key, new int[3]
    {
      3194,
      3192,
      3193
    }).Register();
    RecipeGroups.Ducks = new RecipeGroup(Lang.misc[86].Key, new int[2]
    {
      2123,
      2122
    }).Register();
    RecipeGroups.Butterflies = new RecipeGroup(Lang.misc[87].Key, new int[8]
    {
      1998,
      2001,
      1994,
      1995,
      1996,
      1999,
      1997,
      2000
    }).Register();
    RecipeGroups.Fireflies = new RecipeGroup(Lang.misc[88].Key, new int[2]
    {
      1992,
      2004
    }).Register();
    RecipeGroups.Snails = new RecipeGroup(Lang.misc[95].Key, new int[2]
    {
      2006,
      2007
    }).Register();
    RecipeGroups.Dragonflies = new RecipeGroup(Lang.misc[105].Key, new int[6]
    {
      4334,
      4335,
      4336,
      4338,
      4339,
      4337
    }).Register();
    RecipeGroups.Turtles = new RecipeGroup(Lang.GetNPCNameValue(616), new int[2]
    {
      4464,
      4465
    }).Register();
    RecipeGroups.Macaws = new RecipeGroup("Misc.Macaw", new int[2]
    {
      5212,
      5300
    }).Register();
    RecipeGroups.Cockatiels = new RecipeGroup("Misc.Cockatiel", new int[2]
    {
      5312,
      5313
    }).Register();
    RecipeGroups.CloudBalloons = new RecipeGroup("Misc.CloudBalloon", new int[2]
    {
      399,
      1250
    }).Register();
    RecipeGroups.BlizzardBalloons = new RecipeGroup("Misc.BlizzardBalloon", new int[2]
    {
      1163,
      1251
    }).Register();
    RecipeGroups.SandstormBalloons = new RecipeGroup("Misc.SandstormBalloon", new int[2]
    {
      983,
      1252
    }).Register();
    RecipeGroups.CritterGuides = new RecipeGroup("Misc.CritterGuides", new int[2]
    {
      4767,
      5453
    }).Register();
    RecipeGroups.NatureGuides = new RecipeGroup("Misc.NatureGuides", new int[2]
    {
      5309,
      5454
    }).Register();
    RecipeGroups.Seashells = new RecipeGroup("Misc.Seashells", new int[2]
    {
      2625,
      2626
    }).Register();
    RecipeGroups.Fruit = new RecipeGroup("Misc.Fruit", new int[19]
    {
      4009,
      4282,
      4283,
      4284,
      4285,
      4286,
      4287,
      4288,
      4289,
      4290,
      4291,
      4292,
      4293,
      4294,
      4295,
      4296,
      4297,
      5277,
      5278
    }).Register();
    RecipeGroups.Balloons = new RecipeGroup("Misc.Balloon", new int[3]
    {
      3738,
      3736,
      3737
    }).Register();
    RecipeGroups.CobaltBar = new RecipeGroup("ItemName.CobaltBar", new int[2]
    {
      381,
      1184
    }).Register();
    RecipeGroups.MythrilBar = new RecipeGroup("ItemName.MythrilBar", new int[2]
    {
      382,
      1191
    }).Register();
    RecipeGroups.AdamantiteBar = new RecipeGroup("ItemName.AdamantiteBar", new int[2]
    {
      391,
      1198
    }).Register();
    RecipeGroups.GemCritter = new RecipeGroup("Misc.GemCritter", new int[14]
    {
      4838,
      4844,
      4843,
      4841,
      4842,
      4840,
      4839,
      4831,
      4837,
      4836,
      4834,
      4835,
      4833,
      4832
    }).Register();
    RecipeGroups.MagicMirror = new RecipeGroup("ItemName.MagicMirror", new int[2]
    {
      50,
      3199
    }).Register();
    RecipeGroups.Wood = new RecipeGroup("ItemName.Wood", new int[9]
    {
      9,
      619,
      620,
      621,
      911,
      1729,
      2504,
      2503,
      5215
    }).Register();
    RecipeGroups.Stone = new RecipeGroup("ItemName.StoneBlock", new int[4]
    {
      3,
      61,
      836,
      409
    }).Register();
    RecipeGroups.Sand = new RecipeGroup("ItemName.SandBlock", new int[8]
    {
      169,
      408,
      1246,
      370,
      3272,
      3338,
      3274,
      3275
    }).Register();
    RecipeGroups.IronBar = new RecipeGroup("ItemName.IronBar", new int[2]
    {
      22,
      704
    }).Register();
    RecipeGroups.Fragment = new RecipeGroup(Lang.misc[51].Key, new int[4]
    {
      3458,
      3456,
      3457,
      3459
    }).Register();
    RecipeGroups.PressurePlate = new RecipeGroup(Lang.misc[38].Key, new int[8]
    {
      542,
      852,
      543,
      541,
      1151,
      529,
      853,
      4261
    }).Register();
    RecipeGroups.Jellyfish = new RecipeGroup("Misc.Jellyfish", new int[3]
    {
      2436,
      2437,
      2438
    }).Register();
  }

  public static void UpdateItemVariants()
  {
    for (int index = 0; index < Recipe.maxRecipes; ++index)
    {
      Recipe recipe = Main.recipe[index];
      recipe.createItem.Refresh();
      foreach (Item obj in recipe.requiredItem)
        obj.Refresh();
    }
  }

  public static void AddTileCountsAs(int tile, int equivalent)
  {
    List<int> intList = Recipe.TileCountsAs[tile];
    if (intList == null)
      Recipe.TileCountsAs[tile] = intList = new List<int>();
    intList.Add(equivalent);
  }

  private static void SetupTileInheritance()
  {
    Array.Clear((Array) Recipe.TileCountsAs, 0, Recipe.TileCountsAs.Length);
    Recipe.AddTileCountsAs(96 /*0x60*/, 215);
    Recipe.AddTileCountsAs(17, 215);
    Recipe.AddTileCountsAs(302, 17);
    Recipe.AddTileCountsAs(77, 17);
    Recipe.AddTileCountsAs(133, 77);
    Recipe.AddTileCountsAs(134, 16 /*0x10*/);
    Recipe.AddTileCountsAs(355, 13);
    Recipe.AddTileCountsAs(699, 13);
    Recipe.AddTileCountsAs(304, 86);
  }

  private static bool TileUsedInRecipeInherited(int tileType)
  {
    if (Recipe.TileUsedInRecipes[tileType])
      return true;
    List<int> tileCountsA = Recipe.TileCountsAs[tileType];
    if (tileCountsA != null)
    {
      foreach (int tileType1 in tileCountsA)
      {
        if (Recipe.TileUsedInRecipeInherited(tileType1))
          return true;
      }
    }
    return false;
  }

  private static void UpdateInheritedTilesUsedInRecipes()
  {
    for (int tileType = 0; tileType < Recipe.TileCountsAs.Length; ++tileType)
    {
      if (Recipe.TileCountsAs[tileType] != null)
        Recipe.TileUsedInRecipes[tileType] = Recipe.TileUsedInRecipeInherited(tileType);
    }
  }

  public static void SetupRecipes()
  {
    // ISSUE: The method is too long to display (67243 instructions)
  }

  private static void CreateRequiredItemQuickLookups()
  {
    for (int index1 = 0; index1 < Recipe.numRecipes; ++index1)
    {
      Recipe recipe = Main.recipe[index1];
      for (int index2 = 0; index2 < Recipe.maxRequirements; ++index2)
      {
        Item obj = recipe.requiredItem[index2];
        if (!obj.IsAir)
        {
          Recipe.RequiredItemEntry requiredItemEntry = new Recipe.RequiredItemEntry(obj.type, obj.stack);
          foreach (int acceptedGroup in recipe.acceptedGroups)
          {
            if (acceptedGroup >= 0)
            {
              RecipeGroup recipeGroup = RecipeGroup.recipeGroups[acceptedGroup];
              if (recipeGroup.ValidItems.Contains(obj.type))
                requiredItemEntry.itemIdOrRecipeGroup = recipeGroup.GetGroupFakeItemId();
            }
            else
              break;
          }
          recipe.requiredItemQuickLookup[index2] = requiredItemEntry;
        }
        else
          break;
      }
    }
  }

  private static void UpdateMaterialFieldForAllRecipes()
  {
    for (int index1 = 0; index1 < Recipe.numRecipes; ++index1)
    {
      for (int index2 = 0; Main.recipe[index1].requiredItem[index2].type > 0; ++index2)
        Main.recipe[index1].requiredItem[index2].Refresh(false);
      Main.recipe[index1].createItem.Refresh(false);
    }
  }

  public static void UpdateWhichItemsAreMaterials()
  {
    bool[] flagArray = new bool[RecipeGroup.nextRecipeGroupIndex];
    for (int index1 = 0; index1 < Recipe.numRecipes; ++index1)
    {
      Recipe recipe = Main.recipe[index1];
      for (int index2 = 0; index2 < Recipe.maxRequirements; ++index2)
      {
        Recipe.RequiredItemEntry requiredItemEntry = recipe.requiredItemQuickLookup[index2];
        if (requiredItemEntry.itemIdOrRecipeGroup != 0)
        {
          if (requiredItemEntry.IsRecipeGroup)
            flagArray[requiredItemEntry.RecipeGroup.RegisteredId] = true;
          else
            ItemID.Sets.IsAMaterial[requiredItemEntry.itemIdOrRecipeGroup] = true;
        }
        else
          break;
      }
    }
    for (int key = 0; key < RecipeGroup.nextRecipeGroupIndex; ++key)
    {
      if (flagArray[key])
      {
        foreach (int index in RecipeGroup.recipeGroups[key].Items)
          ItemID.Sets.IsAMaterial[index] = true;
      }
    }
  }

  public static void UpdateWhichItemsAreCrafted()
  {
    for (int index = 0; index < Recipe.numRecipes; ++index)
    {
      if (!Main.recipe[index].notDecraftable)
        ItemID.Sets.IsCrafted[Main.recipe[index].createItem.type] = index;
      if (Main.recipe[index].crimson)
        ItemID.Sets.IsCraftedCrimson[Main.recipe[index].createItem.type] = index;
      if (Main.recipe[index].corruption)
        ItemID.Sets.IsCraftedCorruption[Main.recipe[index].createItem.type] = index;
    }
  }

  private static void AddSolarFurniture()
  {
    Recipe.currentRecipe.createItem.SetDefaults(4229);
    Recipe.currentRecipe.createItem.stack = 10;
    Recipe.currentRecipe.SetIngredients(3, 10, 3458, 1);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4233);
    Recipe.currentRecipe.createItem.stack = 4;
    Recipe.currentRecipe.SetIngredients(4229, 1);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4145);
    Recipe.currentRecipe.SetIngredients(4229, 14);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4146);
    Recipe.currentRecipe.SetIngredients(4229, 15, 225, 5);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4147);
    Recipe.currentRecipe.SetIngredients(4229, 20, 149, 10);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4148);
    Recipe.currentRecipe.SetIngredients(4229, 16 /*0x10*/);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4149);
    Recipe.currentRecipe.SetIngredients(4229, 5, 8, 3);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4150);
    Recipe.currentRecipe.SetIngredients(4229, 4, 8, 1);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4151);
    Recipe.currentRecipe.SetIngredients(4229, 4);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4152);
    Recipe.currentRecipe.SetIngredients(4229, 4, 8, 4, 85, 1);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4153);
    Recipe.currentRecipe.SetIngredients(4229, 8, 22, 2);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.IronBar);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4154);
    Recipe.currentRecipe.SetIngredients(4229, 10, 22, 3, 170, 6);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.IronBar);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4155);
    Recipe.currentRecipe.SetIngredients(4229, 6);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4156);
    Recipe.currentRecipe.SetIngredients(8, 1, 4229, 3);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4157);
    Recipe.currentRecipe.SetIngredients(4229, 6, 8, 1);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4158);
    Recipe.currentRecipe.SetIngredients(4229, 15, 154, 4, 149, 1);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4160);
    Recipe.currentRecipe.SetIngredients(4229, 6, 206, 1);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4161);
    Recipe.currentRecipe.SetIngredients(4229, 5, 225, 2);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4162);
    Recipe.currentRecipe.SetIngredients(4229, 8);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4163);
    Recipe.currentRecipe.SetIngredients(4229, 10);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4165);
    Recipe.currentRecipe.SetIngredients(4229, 6);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
  }

  private static void AddVortexFurniture()
  {
    Recipe.currentRecipe.createItem.SetDefaults(4230);
    Recipe.currentRecipe.createItem.stack = 10;
    Recipe.currentRecipe.SetIngredients(3, 10, 3456, 1);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4234);
    Recipe.currentRecipe.createItem.stack = 4;
    Recipe.currentRecipe.SetIngredients(4230, 1);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4166);
    Recipe.currentRecipe.SetIngredients(4230, 14);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4167);
    Recipe.currentRecipe.SetIngredients(4230, 15, 225, 5);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4168);
    Recipe.currentRecipe.SetIngredients(4230, 20, 149, 10);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4169);
    Recipe.currentRecipe.SetIngredients(4230, 16 /*0x10*/);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4170);
    Recipe.currentRecipe.SetIngredients(4230, 5, 8, 3);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4171);
    Recipe.currentRecipe.SetIngredients(4230, 4, 8, 1);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4172);
    Recipe.currentRecipe.SetIngredients(4230, 4);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4173);
    Recipe.currentRecipe.SetIngredients(4230, 4, 8, 4, 85, 1);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4174);
    Recipe.currentRecipe.SetIngredients(4230, 8, 22, 2);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.IronBar);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4175);
    Recipe.currentRecipe.SetIngredients(4230, 10, 22, 3, 170, 6);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.IronBar);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4176);
    Recipe.currentRecipe.SetIngredients(4230, 6);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4177);
    Recipe.currentRecipe.SetIngredients(8, 1, 4230, 3);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4178);
    Recipe.currentRecipe.SetIngredients(4230, 6, 8, 1);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4179);
    Recipe.currentRecipe.SetIngredients(4230, 15, 154, 4, 149, 1);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4181);
    Recipe.currentRecipe.SetIngredients(4230, 6, 206, 1);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4182);
    Recipe.currentRecipe.SetIngredients(4230, 5, 225, 2);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4183);
    Recipe.currentRecipe.SetIngredients(4230, 8);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4184);
    Recipe.currentRecipe.SetIngredients(4230, 10);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4186);
    Recipe.currentRecipe.SetIngredients(4230, 6);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
  }

  private static void AddNebulaFurniture()
  {
    Recipe.currentRecipe.createItem.SetDefaults(4231);
    Recipe.currentRecipe.createItem.stack = 10;
    Recipe.currentRecipe.SetIngredients(3, 10, 3457, 1);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4235);
    Recipe.currentRecipe.createItem.stack = 4;
    Recipe.currentRecipe.SetIngredients(4231, 1);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4187);
    Recipe.currentRecipe.SetIngredients(4231, 14);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4188);
    Recipe.currentRecipe.SetIngredients(4231, 15, 225, 5);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4189);
    Recipe.currentRecipe.SetIngredients(4231, 20, 149, 10);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4190);
    Recipe.currentRecipe.SetIngredients(4231, 16 /*0x10*/);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4191);
    Recipe.currentRecipe.SetIngredients(4231, 5, 8, 3);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4192);
    Recipe.currentRecipe.SetIngredients(4231, 4, 8, 1);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4193);
    Recipe.currentRecipe.SetIngredients(4231, 4);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4194);
    Recipe.currentRecipe.SetIngredients(4231, 4, 8, 4, 85, 1);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4195);
    Recipe.currentRecipe.SetIngredients(4231, 8, 22, 2);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.IronBar);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4196);
    Recipe.currentRecipe.SetIngredients(4231, 10, 22, 3, 170, 6);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.IronBar);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4197);
    Recipe.currentRecipe.SetIngredients(4231, 6);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4198);
    Recipe.currentRecipe.SetIngredients(8, 1, 4231, 3);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4199);
    Recipe.currentRecipe.SetIngredients(4231, 6, 8, 1);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4200);
    Recipe.currentRecipe.SetIngredients(4231, 15, 154, 4, 149, 1);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4202);
    Recipe.currentRecipe.SetIngredients(4231, 6, 206, 1);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4203);
    Recipe.currentRecipe.SetIngredients(4231, 5, 225, 2);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4204);
    Recipe.currentRecipe.SetIngredients(4231, 8);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4205);
    Recipe.currentRecipe.SetIngredients(4231, 10);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4207);
    Recipe.currentRecipe.SetIngredients(4231, 6);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
  }

  private static void AddStardustFurniture()
  {
    Recipe.currentRecipe.createItem.SetDefaults(4232);
    Recipe.currentRecipe.createItem.stack = 10;
    Recipe.currentRecipe.SetIngredients(3, 10, 3459, 1);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4236);
    Recipe.currentRecipe.createItem.stack = 4;
    Recipe.currentRecipe.SetIngredients(4232, 1);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4208);
    Recipe.currentRecipe.SetIngredients(4232, 14);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4209);
    Recipe.currentRecipe.SetIngredients(4232, 15, 225, 5);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4210);
    Recipe.currentRecipe.SetIngredients(4232, 20, 149, 10);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4211);
    Recipe.currentRecipe.SetIngredients(4232, 16 /*0x10*/);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4212);
    Recipe.currentRecipe.SetIngredients(4232, 5, 8, 3);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4213);
    Recipe.currentRecipe.SetIngredients(4232, 4, 8, 1);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4214);
    Recipe.currentRecipe.SetIngredients(4232, 4);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4215);
    Recipe.currentRecipe.SetIngredients(4232, 4, 8, 4, 85, 1);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4216);
    Recipe.currentRecipe.SetIngredients(4232, 8, 22, 2);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.IronBar);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4217);
    Recipe.currentRecipe.SetIngredients(4232, 10, 22, 3, 170, 6);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.IronBar);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4218);
    Recipe.currentRecipe.SetIngredients(4232, 6);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4219);
    Recipe.currentRecipe.SetIngredients(8, 1, 4232, 3);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4220);
    Recipe.currentRecipe.SetIngredients(4232, 6, 8, 1);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4221);
    Recipe.currentRecipe.SetIngredients(4232, 15, 154, 4, 149, 1);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4223);
    Recipe.currentRecipe.SetIngredients(4232, 6, 206, 1);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4224);
    Recipe.currentRecipe.SetIngredients(4232, 5, 225, 2);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4225);
    Recipe.currentRecipe.SetIngredients(4232, 8);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4226);
    Recipe.currentRecipe.SetIngredients(4232, 10);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4228);
    Recipe.currentRecipe.SetIngredients(4232, 6);
    Recipe.currentRecipe.SetCraftingStation(412);
    Recipe.AddRecipe();
  }

  private static void AddSpiderFurniture()
  {
    Recipe.currentRecipe.createItem.SetDefaults(4139);
    Recipe.currentRecipe.createItem.stack = 10;
    Recipe.currentRecipe.SetIngredients(150, 10, 2607, 1);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4140);
    Recipe.currentRecipe.createItem.stack = 4;
    Recipe.currentRecipe.SetIngredients(4139, 1);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(3931);
    Recipe.currentRecipe.SetIngredients(4139, 14);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(3932);
    Recipe.currentRecipe.SetIngredients(4139, 15, 225, 5);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(3933);
    Recipe.currentRecipe.SetIngredients(4139, 20, 149, 10);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(3934);
    Recipe.currentRecipe.SetIngredients(4139, 16 /*0x10*/);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(3935);
    Recipe.currentRecipe.SetIngredients(4139, 5, 8, 3);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(3936);
    Recipe.currentRecipe.SetIngredients(4139, 4, 8, 1);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(3937);
    Recipe.currentRecipe.SetIngredients(4139, 4);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(3938);
    Recipe.currentRecipe.SetIngredients(4139, 4, 8, 4, 85, 1);
    Recipe.currentRecipe.SetCraftingStation(16 /*0x10*/);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(3939);
    Recipe.currentRecipe.SetIngredients(4139, 8, 22, 2);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.IronBar);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(3940);
    Recipe.currentRecipe.SetIngredients(4139, 10, 22, 3, 170, 6);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.IronBar);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(3941);
    Recipe.currentRecipe.SetIngredients(4139, 6);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(3942);
    Recipe.currentRecipe.SetIngredients(8, 1, 4139, 3);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(3943);
    Recipe.currentRecipe.SetIngredients(4139, 6, 8, 1);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(3944);
    Recipe.currentRecipe.SetIngredients(4139, 15, 154, 4, 149, 1);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(3946);
    Recipe.currentRecipe.SetIngredients(4139, 6, 206, 1);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(3947);
    Recipe.currentRecipe.SetIngredients(4139, 5, 225, 2);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(3948);
    Recipe.currentRecipe.SetIngredients(4139, 8);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(3949);
    Recipe.currentRecipe.SetIngredients(4139, 10);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4125);
    Recipe.currentRecipe.SetIngredients(4139, 6);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
  }

  private static void AddLesionFurniture()
  {
    int num = 3955;
    Recipe.currentRecipe.createItem.SetDefaults(3955);
    Recipe.currentRecipe.SetIngredients(61, 2);
    Recipe.currentRecipe.SetCraftingStation(218);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(3975);
    Recipe.currentRecipe.SetIngredients(num, 10);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.Wood);
    Recipe.currentRecipe.SetCraftingStation(499);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(3956);
    Recipe.currentRecipe.createItem.stack = 4;
    Recipe.currentRecipe.SetIngredients(3955, 1);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(3967);
    Recipe.currentRecipe.SetIngredients(num, 6);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.Wood);
    Recipe.currentRecipe.SetCraftingStation(499);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(3963);
    Recipe.currentRecipe.SetIngredients(num, 4);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.Wood);
    Recipe.currentRecipe.SetCraftingStation(499);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(3965);
    Recipe.currentRecipe.SetIngredients(num, 8, 22, 2);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.Wood);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.IronBar);
    Recipe.currentRecipe.SetCraftingStation(499);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(3974);
    Recipe.currentRecipe.SetIngredients(num, 8);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.Wood);
    Recipe.currentRecipe.SetCraftingStation(499);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(3972);
    Recipe.currentRecipe.SetIngredients(num, 6, 206, 1);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.Wood);
    Recipe.currentRecipe.SetCraftingStation(499);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(3970);
    Recipe.currentRecipe.SetIngredients(num, 6, 8, 1);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.Wood);
    Recipe.currentRecipe.SetCraftingStation(499);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(3962);
    Recipe.currentRecipe.SetIngredients(num, 4, 8, 1);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.Wood);
    Recipe.currentRecipe.SetCraftingStation(499);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(3969);
    Recipe.currentRecipe.SetIngredients(num, 3, 8, 1);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.Wood);
    Recipe.currentRecipe.SetCraftingStation(499);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(3961);
    Recipe.currentRecipe.SetIngredients(num, 5, 8, 3);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.Wood);
    Recipe.currentRecipe.SetCraftingStation(499);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(3959);
    Recipe.currentRecipe.SetIngredients(num, 15, 225, 5);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.Wood);
    Recipe.currentRecipe.SetCraftingStation(499);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(3968);
    Recipe.currentRecipe.SetIngredients(num, 16 /*0x10*/);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.Wood);
    Recipe.currentRecipe.SetCraftingStation(499);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(3960);
    Recipe.currentRecipe.SetIngredients(num, 20, 149, 10);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.Wood);
    Recipe.currentRecipe.SetCraftingStation(499);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(3966);
    Recipe.currentRecipe.SetIngredients(22, 3, 170, 6, num, 10);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.Wood);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.IronBar);
    Recipe.currentRecipe.SetCraftingStation(499);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(3973);
    Recipe.currentRecipe.SetIngredients(num, 5, 225, 2);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.Wood);
    Recipe.currentRecipe.SetCraftingStation(499);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(3971);
    Recipe.currentRecipe.SetIngredients(154, 4, num, 15, 149, 1);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.Wood);
    Recipe.currentRecipe.SetCraftingStation(499);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(3958);
    Recipe.currentRecipe.SetIngredients(num, 14);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.Wood);
    Recipe.currentRecipe.SetCraftingStation(499);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(3964);
    Recipe.currentRecipe.SetIngredients(num, 4, 8, 4, 85, 1);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.Wood);
    Recipe.currentRecipe.SetCraftingStation(499);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4126);
    Recipe.currentRecipe.SetIngredients(3955, 6);
    Recipe.currentRecipe.SetCraftingStation(499);
    Recipe.AddRecipe();
  }

  private static void AddSandstoneFurniture()
  {
    Recipe.currentRecipe.createItem.SetDefaults(4720);
    Recipe.currentRecipe.createItem.stack = 2;
    Recipe.currentRecipe.SetIngredients(4051, 1);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4298);
    Recipe.currentRecipe.SetIngredients(4051, 14);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4299);
    Recipe.currentRecipe.SetIngredients(4051, 15, 225, 5);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4300);
    Recipe.currentRecipe.SetIngredients(4051, 20, 149, 10);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4301);
    Recipe.currentRecipe.SetIngredients(4051, 16 /*0x10*/);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4302);
    Recipe.currentRecipe.SetIngredients(4051, 5, 8, 3);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4303);
    Recipe.currentRecipe.SetIngredients(4051, 4, 8, 1);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4304);
    Recipe.currentRecipe.SetIngredients(4051, 4);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4305);
    Recipe.currentRecipe.SetIngredients(4051, 4, 8, 4, 85, 1);
    Recipe.currentRecipe.SetCraftingStation(16 /*0x10*/);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4267);
    Recipe.currentRecipe.SetIngredients(4051, 8, 22, 2);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.IronBar);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4306);
    Recipe.currentRecipe.SetIngredients(4051, 10, 22, 3, 170, 6);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.IronBar);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4307);
    Recipe.currentRecipe.SetIngredients(4051, 6);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4308);
    Recipe.currentRecipe.SetIngredients(8, 1, 4051, 3);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4309);
    Recipe.currentRecipe.SetIngredients(4051, 6, 8, 1);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4310);
    Recipe.currentRecipe.SetIngredients(4051, 15, 154, 4, 149, 1);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4312);
    Recipe.currentRecipe.SetIngredients(4051, 6, 206, 1);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4313);
    Recipe.currentRecipe.SetIngredients(4051, 5, 225, 2);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4314);
    Recipe.currentRecipe.SetIngredients(4051, 8);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4315);
    Recipe.currentRecipe.SetIngredients(4051, 10);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4316);
    Recipe.currentRecipe.SetIngredients(4051, 6);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
  }

  private static void AddBambooFurniture()
  {
    Recipe.currentRecipe.createItem.SetDefaults(4566);
    Recipe.currentRecipe.SetIngredients(4564, 14);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4567);
    Recipe.currentRecipe.SetIngredients(4564, 15, 225, 5);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4568);
    Recipe.currentRecipe.SetIngredients(4564, 20, 149, 10);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4569);
    Recipe.currentRecipe.SetIngredients(4564, 16 /*0x10*/);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4570);
    Recipe.currentRecipe.SetIngredients(4564, 5, 8, 3);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4571);
    Recipe.currentRecipe.SetIngredients(4564, 4, 8, 1);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4572);
    Recipe.currentRecipe.SetIngredients(4564, 4);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4573);
    Recipe.currentRecipe.SetIngredients(4564, 4, 8, 4, 85, 1);
    Recipe.currentRecipe.SetCraftingStation(16 /*0x10*/);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4574);
    Recipe.currentRecipe.SetIngredients(4564, 8, 22, 2);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.IronBar);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4575);
    Recipe.currentRecipe.SetIngredients(4564, 10, 22, 3, 170, 6);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.IronBar);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4576);
    Recipe.currentRecipe.SetIngredients(4564, 6);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4577);
    Recipe.currentRecipe.SetIngredients(8, 1, 4564, 3);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4578);
    Recipe.currentRecipe.SetIngredients(4564, 6, 8, 1);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4579);
    Recipe.currentRecipe.SetIngredients(4564, 15, 154, 4, 149, 1);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4581);
    Recipe.currentRecipe.SetIngredients(4564, 6, 206, 1);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4582);
    Recipe.currentRecipe.SetIngredients(4564, 5, 225, 2);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4583);
    Recipe.currentRecipe.SetIngredients(4564, 8);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4584);
    Recipe.currentRecipe.SetIngredients(4564, 10);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(4586);
    Recipe.currentRecipe.SetIngredients(4564, 6);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
  }

  private static void AddCoralFurniture()
  {
    Recipe.currentRecipe.createItem.SetDefaults(5148);
    Recipe.currentRecipe.SetIngredients(5306, 14);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5149);
    Recipe.currentRecipe.SetIngredients(5306, 15, 225, 5);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5150);
    Recipe.currentRecipe.SetIngredients(5306, 20, 149, 10);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5151);
    Recipe.currentRecipe.SetIngredients(5306, 16 /*0x10*/);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5152);
    Recipe.currentRecipe.SetIngredients(5306, 5, 8, 3);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5153);
    Recipe.currentRecipe.SetIngredients(5306, 4, 8, 1);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5154);
    Recipe.currentRecipe.SetIngredients(5306, 4);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5155);
    Recipe.currentRecipe.SetIngredients(5306, 4, 8, 4, 85, 1);
    Recipe.currentRecipe.SetCraftingStation(16 /*0x10*/);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5156);
    Recipe.currentRecipe.SetIngredients(5306, 8, 22, 2);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.IronBar);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5157);
    Recipe.currentRecipe.SetIngredients(5306, 10, 22, 3, 170, 6);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.IronBar);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5158);
    Recipe.currentRecipe.SetIngredients(5306, 6);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5159);
    Recipe.currentRecipe.SetIngredients(8, 1, 5306, 3);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5160);
    Recipe.currentRecipe.SetIngredients(5306, 6, 8, 1);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5161);
    Recipe.currentRecipe.SetIngredients(5306, 15, 154, 4, 149, 1);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5163);
    Recipe.currentRecipe.SetIngredients(5306, 6, 206, 1);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5164);
    Recipe.currentRecipe.SetIngredients(5306, 5, 225, 2);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5165);
    Recipe.currentRecipe.SetIngredients(5306, 8);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5166);
    Recipe.currentRecipe.SetIngredients(5306, 10);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5168);
    Recipe.currentRecipe.SetIngredients(5306, 6);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
  }

  private static void AddBalloonFurniture()
  {
    Recipe.currentRecipe.createItem.SetDefaults(5169);
    Recipe.currentRecipe.SetIngredients(3738, 14);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.Balloons);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5170);
    Recipe.currentRecipe.SetIngredients(3738, 15, 225, 5);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.Balloons);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5171);
    Recipe.currentRecipe.SetIngredients(3738, 20, 149, 10);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.Balloons);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5172);
    Recipe.currentRecipe.SetIngredients(3738, 16 /*0x10*/);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.Balloons);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5173);
    Recipe.currentRecipe.SetIngredients(3738, 5, 8, 3);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.Balloons);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5174);
    Recipe.currentRecipe.SetIngredients(3738, 4, 8, 1);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.Balloons);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5175);
    Recipe.currentRecipe.SetIngredients(3738, 4);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.Balloons);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5176);
    Recipe.currentRecipe.SetIngredients(3738, 4, 8, 4, 85, 1);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.Balloons);
    Recipe.currentRecipe.SetCraftingStation(16 /*0x10*/);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5177);
    Recipe.currentRecipe.SetIngredients(3738, 8, 22, 2);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.Balloons);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.IronBar);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5178);
    Recipe.currentRecipe.SetIngredients(3738, 10, 22, 3, 170, 6);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.Balloons);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.IronBar);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5179);
    Recipe.currentRecipe.SetIngredients(3738, 6);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.Balloons);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5180);
    Recipe.currentRecipe.SetIngredients(8, 1, 3738, 3);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.Balloons);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5181);
    Recipe.currentRecipe.SetIngredients(3738, 6, 8, 1);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.Balloons);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5182);
    Recipe.currentRecipe.SetIngredients(3738, 15, 154, 4, 149, 1);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.Balloons);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5184);
    Recipe.currentRecipe.SetIngredients(3738, 6, 206, 1);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.Balloons);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5185);
    Recipe.currentRecipe.SetIngredients(3738, 5, 225, 2);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.Balloons);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5186);
    Recipe.currentRecipe.SetIngredients(3738, 8);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.Balloons);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5187);
    Recipe.currentRecipe.SetIngredients(3738, 10);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.Balloons);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5189);
    Recipe.currentRecipe.SetIngredients(3738, 6);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.Balloons);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
  }

  private static void AddAshWoodFurnitureArmorAndItems()
  {
    Recipe.currentRecipe.createItem.SetDefaults(5279);
    Recipe.currentRecipe.SetIngredients(5215, 20);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5280);
    Recipe.currentRecipe.SetIngredients(5215, 30);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5281);
    Recipe.currentRecipe.SetIngredients(5215, 25);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5284);
    Recipe.currentRecipe.SetIngredients(5215, 7);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5283);
    Recipe.currentRecipe.SetIngredients(5215, 8);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5282);
    Recipe.currentRecipe.SetIngredients(5215, 10);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5190);
    Recipe.currentRecipe.SetIngredients(5215, 14);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5191);
    Recipe.currentRecipe.SetIngredients(5215, 15, 225, 5);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5192);
    Recipe.currentRecipe.SetIngredients(5215, 20, 149, 10);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5193);
    Recipe.currentRecipe.SetIngredients(5215, 16 /*0x10*/);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5194);
    Recipe.currentRecipe.SetIngredients(5215, 5, 8, 3);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5195);
    Recipe.currentRecipe.SetIngredients(5215, 4, 8, 1);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5196);
    Recipe.currentRecipe.SetIngredients(5215, 4);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5197);
    Recipe.currentRecipe.SetIngredients(5215, 4, 8, 4, 85, 1);
    Recipe.currentRecipe.SetCraftingStation(16 /*0x10*/);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5198);
    Recipe.currentRecipe.SetIngredients(5215, 8, 22, 2);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.IronBar);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5199);
    Recipe.currentRecipe.SetIngredients(5215, 10, 22, 3, 170, 6);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.IronBar);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5200);
    Recipe.currentRecipe.SetIngredients(5215, 6);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5201);
    Recipe.currentRecipe.SetIngredients(8, 1, 5215, 3);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5202);
    Recipe.currentRecipe.SetIngredients(5215, 6, 8, 1);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5203);
    Recipe.currentRecipe.SetIngredients(5215, 15, 154, 4, 149, 1);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5205);
    Recipe.currentRecipe.SetIngredients(5215, 6, 206, 1);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5206);
    Recipe.currentRecipe.SetIngredients(5215, 5, 225, 2);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5207);
    Recipe.currentRecipe.SetIngredients(5215, 8);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5208);
    Recipe.currentRecipe.SetIngredients(5215, 10);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5210);
    Recipe.currentRecipe.SetIngredients(5215, 6);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
  }

  private static void AddAetheriumFurniture()
  {
    Recipe.currentRecipe.createItem.SetDefaults(5548);
    Recipe.currentRecipe.SetIngredients(5398, 14);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5549);
    Recipe.currentRecipe.SetIngredients(5398, 15, 225, 5);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5550);
    Recipe.currentRecipe.SetIngredients(5398, 20, 149, 10);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5551);
    Recipe.currentRecipe.SetIngredients(5398, 16 /*0x10*/);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5552);
    Recipe.currentRecipe.SetIngredients(5398, 5, 8, 3);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5553);
    Recipe.currentRecipe.SetIngredients(5398, 4, 8, 1);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5554);
    Recipe.currentRecipe.SetIngredients(5398, 4);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5555);
    Recipe.currentRecipe.SetIngredients(5398, 4, 8, 4, 85, 1);
    Recipe.currentRecipe.SetCraftingStation(16 /*0x10*/);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5556);
    Recipe.currentRecipe.SetIngredients(5398, 8, 22, 2);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.IronBar);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5557);
    Recipe.currentRecipe.SetIngredients(5398, 10, 22, 3, 170, 6);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.IronBar);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5558);
    Recipe.currentRecipe.SetIngredients(5398, 6);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5559);
    Recipe.currentRecipe.SetIngredients(8, 1, 5398, 3);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5560);
    Recipe.currentRecipe.SetIngredients(5398, 6, 8, 1);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5561);
    Recipe.currentRecipe.SetIngredients(5398, 15, 154, 4, 149, 1);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5563);
    Recipe.currentRecipe.SetIngredients(5398, 6, 206, 1);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5564);
    Recipe.currentRecipe.SetIngredients(5398, 5, 225, 2);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5565);
    Recipe.currentRecipe.SetIngredients(5398, 8);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5566);
    Recipe.currentRecipe.SetIngredients(5398, 10);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5568);
    Recipe.currentRecipe.SetIngredients(5398, 6);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
  }

  private static void AddFallenStarFurniture()
  {
    Recipe.currentRecipe.createItem.SetDefaults(5601);
    Recipe.currentRecipe.SetIngredients(5622, 14);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5602);
    Recipe.currentRecipe.SetIngredients(5622, 15, 225, 5);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5603);
    Recipe.currentRecipe.SetIngredients(5622, 20, 149, 10);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5604);
    Recipe.currentRecipe.SetIngredients(5622, 16 /*0x10*/);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5605);
    Recipe.currentRecipe.SetIngredients(5622, 5, 8, 3);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5606);
    Recipe.currentRecipe.SetIngredients(5622, 4, 8, 1);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5607);
    Recipe.currentRecipe.SetIngredients(5622, 4);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5608);
    Recipe.currentRecipe.SetIngredients(5622, 4, 8, 4, 85, 1);
    Recipe.currentRecipe.SetCraftingStation(16 /*0x10*/);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5609);
    Recipe.currentRecipe.SetIngredients(5622, 8, 22, 2);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.IronBar);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5610);
    Recipe.currentRecipe.SetIngredients(5622, 10, 22, 3, 170, 6);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.IronBar);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5611);
    Recipe.currentRecipe.SetIngredients(5622, 6);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5612);
    Recipe.currentRecipe.SetIngredients(8, 1, 5622, 3);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5613);
    Recipe.currentRecipe.SetIngredients(5622, 6, 8, 1);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5614);
    Recipe.currentRecipe.SetIngredients(5622, 15, 154, 4, 149, 1);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5616);
    Recipe.currentRecipe.SetIngredients(5622, 6, 206, 1);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5617);
    Recipe.currentRecipe.SetIngredients(5622, 5, 225, 2);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5618);
    Recipe.currentRecipe.SetIngredients(5622, 8);
    Recipe.currentRecipe.SetCraftingStation(18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5619);
    Recipe.currentRecipe.SetIngredients(5622, 10);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(5621);
    Recipe.currentRecipe.SetIngredients(5622, 6);
    Recipe.currentRecipe.SetCraftingStation(106);
    Recipe.AddRecipe();
  }

  private static void AddFeywoodFurniture()
  {
    Recipe.AddStandardFurnitureSetRecipes(5710, 5689, 5690, 5691, 5693, 5694, 5695, 5696, 5697, 5698, 5699, 5692, 5700, 5701, 5702, 5704, 5705, 5706, 5709, 5707, 5708, 304);
  }

  private static void AddHallowedFurniture()
  {
    Recipe.AddStandardFurnitureSetRecipes(5733, 5712, 5713, 5714, 5716, 5717, 5718, 5719, 5720, 5721, 5722, 5715, 5723, 5724, 5725, 5727, 5728, 5729, 5732, 5730, 5731);
  }

  private static void AddEasterFurniture()
  {
    Recipe.AddStandardFurnitureSetRecipes(5920, 5858, 5859, 5860, 5861, 5862, 5863, 5864, 5865, 5866, 5867, 5868, 5869, 5870, 5871, 5873, 5874, 5875, 5876, 5877, 5878);
  }

  private static void AddGothicFurniture()
  {
    Recipe.AddStandardFurnitureSetRecipes(5922, 5739, 5740, 1512, 5742, 5743, 1509, 5744, 5745, 5746, 5747, 5741, 5748, 5749, 5750, 5752, 5753, 1510, 5755, 1511, 5754, 300);
  }

  private static void AddDemoniteFurniture()
  {
    Recipe.AddStandardFurnitureSetRecipes(577, 5756, 5757, 5758, 5759, 5760, 5761, 5762, 5763, 5764, 5765, 5766, 5767, 5768, 5769, 5771, 5772, 5773, 5774, 5775, 5776);
  }

  private static void AddCrimtaneFurniture()
  {
    Recipe.AddStandardFurnitureSetRecipes(2793, 5777, 5778, 5779, 5780, 5781, 5782, 5783, 5784, 5785, 5786, 5787, 5788, 5789, 5790, 5792, 5793, 5794, 5795, 5796, 5797);
  }

  private static void AddSnowFurniture()
  {
    Recipe.AddStandardFurnitureSetRecipes(593, 5798, 5799, 5800, 5801, 5802, 5803, 5804, 5805, 5806, 5807, 5808, 5809, 5810, 5811, 5813, 5814, 5815, 5816, 5817, 5818, 306);
  }

  private static void AddFlinxFurFurniture()
  {
    Recipe.AddStandardFurnitureSetRecipes(5924, 5819, 5820, 5821, 5822, 5823, 5824, 5825, 5826, 5827, 5828, 5829, 5830, 5831, 5832, 5834, 5835, 5836, 5837, 5838, 5839);
  }

  private static void AddPineFurniture()
  {
    Recipe.AddStandardFurnitureSetRecipes(1872, 5840, 5841, 5842, 5843, 5844, 1925, 5845, 5846, 5847, 1924, 5848, 5849, 5850, 5851, 5853, 5854, 1926, 5855, 5856, 5857);
    Recipe.AddStandardFurnitureSetRecipes(5930, 5840, 5841, 5842, 5843, 5844, 1925, 5845, 5846, 5847, 1924, 5848, 5849, 5850, 5851, 5853, 5854, 1926, 5855, 5856, 5857);
  }

  private static void AddStoneFurniture()
  {
    Recipe.AddStandardFurnitureSetRecipes(129, 5879, 5880, 5881, 5882, 5883, 5884, 5885, 5886, 5887, 4415, 5888, 5889, 5890, 5891, 5892, 5893, 5894, 5895, 5896, 5897, 283);
  }

  private static void AddJellyfishFurniture()
  {
    Recipe.AddStandardFurnitureSetRecipes(5926, 5898, 5899, 5900, 5901, 5902, 5903, 5904, 5905, 5906, 5907, 5908, 5909, 5910, 5911, 5913, 5914, 5915, 5916, 5917, 5918);
  }

  private static void AddHarpyFurniture()
  {
    Recipe.AddStandardFurnitureSetRecipes(5953, 5932, 5933, 5934, 5935, 5936, 5937, 5938, 5939, 5940, 5941, 5942, 5943, 5944, 5945, 5947, 5948, 5949, 5950, 5951, 5952, 305);
  }

  private static void AddCloudFurniture()
  {
    Recipe.AddStandardFurnitureSetRecipes(751, 5955, 5956, 5957, 5958, 5959, 5960, 5961, 5962, 5963, 5964, 5965, 5966, 5967, 5968, 5969, 5970, 5971, 5972, 5973, 5974, 305);
  }

  private static void AddMoonplateFurniture()
  {
    Recipe.AddStandardFurnitureSetRecipes(5996, 5975, 5976, 5977, 5978, 5979, 5980, 5981, 5982, 5983, 5984, 5985, 5986, 5987, 5988, 5990, 5991, 5992, 5993, 5994, 5995, 305);
  }

  private static void AddLibrarianFurniture()
  {
    Recipe.AddStandardFurnitureSetRecipes(6019, 5998, 5999, 6000, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010, 6011, 6013, 6014, 6015, 6016, 6017, 6018, 101);
  }

  private static void AddSpikeFurniture()
  {
    Recipe.AddStandardFurnitureSetRecipes(6042, 6021, 6022, 6023, 6024, 6025, 6026, 6027, 6028, 6029, 6030, 6031, 6032, 6033, 6034, 6036, 6037, 6038, 6039, 6040, 6041);
  }

  private static void AddOfficeFurniture()
  {
    Recipe.AddStandardFurnitureSetRecipes(6065, 6044, 6045, 6046, 6047, 6048, 6049, 6050, 6051, 6052, 6053, 6054, 6055, 6056, 6057, 6059, 6060, 6061, 6062, 6063, 6064);
  }

  private static void AddForbiddenFurniture()
  {
    Recipe.AddStandardFurnitureSetRecipes(6088, 6067, 6068, 6069, 6070, 6071, 6072, 6073, 6074, 6075, 6076, 6077, 6078, 6079, 6080, 6082, 6083, 6084, 6085, 6086, 6087);
  }

  private static void AddWaterFurniture()
  {
    Recipe.AddStandardFurnitureSetRecipes(6109, 6090, 6091, 6092, 6093, 6094, 6095, 6096, 1298, 6097, 6098, 6099, 6100, 6101, 6102, 6104, 6105, 6106, 6107, 6108, 3678);
  }

  private static void AddBoulderFurniture()
  {
    Recipe.AddStandardFurnitureSetRecipes(6132, 6111, 6112, 6113, 6114, 6115, 6116, 6117, 6118, 6119, 6120, 6121, 6122, 6123, 6124, 6126, 6127, 6128, 6129, 6130, 6131, 283);
  }

  private static void AddStandardFurnitureSetRecipes(
    int primaryMaterial,
    int bathtub,
    int bed,
    int bookcase,
    int candelabra,
    int candle,
    int chair,
    int chandelier,
    int chest,
    int clock,
    int door,
    int dresser,
    int lamp,
    int lantern,
    int piano,
    int sink,
    int sofa,
    int table,
    int toilet,
    int workbench,
    int fake_chest,
    int overrideStation = -1)
  {
    Recipe.currentRecipe.createItem.SetDefaults(bathtub);
    Recipe.currentRecipe.SetIngredients(primaryMaterial, 14);
    Recipe.currentRecipe.SetCraftingStation(overrideStation >= 0 ? overrideStation : 106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(bed);
    Recipe.currentRecipe.SetIngredients(primaryMaterial, 15, 225, 5);
    Recipe.currentRecipe.SetCraftingStation(overrideStation >= 0 ? overrideStation : 106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(bookcase);
    Recipe.currentRecipe.SetIngredients(primaryMaterial, 20, 149, 10);
    Recipe.currentRecipe.SetCraftingStation(overrideStation >= 0 ? overrideStation : 106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(dresser);
    Recipe.currentRecipe.SetIngredients(primaryMaterial, 16 /*0x10*/);
    Recipe.currentRecipe.SetCraftingStation(overrideStation >= 0 ? overrideStation : 106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(candelabra);
    Recipe.currentRecipe.SetIngredients(primaryMaterial, 5, 8, 3);
    Recipe.currentRecipe.SetCraftingStation(overrideStation >= 0 ? overrideStation : 18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(candle);
    Recipe.currentRecipe.SetIngredients(primaryMaterial, 4, 8, 1);
    Recipe.currentRecipe.SetCraftingStation(overrideStation >= 0 ? overrideStation : 18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(chair);
    Recipe.currentRecipe.SetIngredients(primaryMaterial, 4);
    Recipe.currentRecipe.SetCraftingStation(overrideStation >= 0 ? overrideStation : 18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(chandelier);
    Recipe.currentRecipe.SetIngredients(primaryMaterial, 4, 8, 4, 85, 1);
    Recipe.currentRecipe.SetCraftingStation(overrideStation >= 0 ? overrideStation : 16 /*0x10*/);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(chest);
    Recipe.currentRecipe.SetIngredients(primaryMaterial, 8, 22, 2);
    Recipe.currentRecipe.SetCraftingStation(overrideStation >= 0 ? overrideStation : 18);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.IronBar);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(clock);
    Recipe.currentRecipe.SetIngredients(primaryMaterial, 10, 22, 3, 170, 6);
    Recipe.currentRecipe.SetCraftingStation(overrideStation >= 0 ? overrideStation : 106);
    Recipe.currentRecipe.RequireGroup(RecipeGroups.IronBar);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(door);
    Recipe.currentRecipe.SetIngredients(primaryMaterial, 6);
    Recipe.currentRecipe.SetCraftingStation(overrideStation >= 0 ? overrideStation : 18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(lamp);
    Recipe.currentRecipe.SetIngredients(8, 1, primaryMaterial, 3);
    Recipe.currentRecipe.SetCraftingStation(overrideStation >= 0 ? overrideStation : 18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(lantern);
    Recipe.currentRecipe.SetIngredients(primaryMaterial, 6, 8, 1);
    Recipe.currentRecipe.SetCraftingStation(overrideStation >= 0 ? overrideStation : 18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(piano);
    Recipe.currentRecipe.SetIngredients(primaryMaterial, 15, 154, 4, 149, 1);
    Recipe.currentRecipe.SetCraftingStation(overrideStation >= 0 ? overrideStation : 106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(sink);
    Recipe.currentRecipe.SetIngredients(primaryMaterial, 6, 206, 1);
    Recipe.currentRecipe.SetCraftingStation(overrideStation >= 0 ? overrideStation : 18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(sofa);
    Recipe.currentRecipe.SetIngredients(primaryMaterial, 5, 225, 2);
    Recipe.currentRecipe.SetCraftingStation(overrideStation >= 0 ? overrideStation : 106);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(table);
    Recipe.currentRecipe.SetIngredients(primaryMaterial, 8);
    Recipe.currentRecipe.SetCraftingStation(overrideStation >= 0 ? overrideStation : 18);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(workbench);
    Recipe.currentRecipe.SetIngredients(primaryMaterial, 10);
    if (overrideStation >= 0)
      Recipe.currentRecipe.SetCraftingStation(overrideStation);
    Recipe.AddRecipe();
    Recipe.currentRecipe.createItem.SetDefaults(toilet);
    Recipe.currentRecipe.SetIngredients(primaryMaterial, 6);
    Recipe.currentRecipe.SetCraftingStation(overrideStation >= 0 ? overrideStation : 106);
    Recipe.AddRecipe();
  }

  private static void AddCritterStatueRecipe(
    int statueItem,
    int critterItem = 0,
    RecipeGroup critterGroup = null)
  {
    Recipe.currentRecipe.createItem.SetDefaults(statueItem);
    int index1 = 0;
    Recipe.currentRecipe.requiredItem[index1].SetDefaults(3);
    Recipe.currentRecipe.requiredItem[index1].stack = 50;
    if (critterGroup != null)
    {
      critterItem = critterGroup.GetPlaceholderItemType();
      Recipe.currentRecipe.RequireGroup(critterGroup);
    }
    int index2;
    Recipe.currentRecipe.requiredItem[index2 = index1 + 1].SetDefaults(critterItem);
    Recipe.currentRecipe.requiredItem[index2].stack = 5;
    Recipe.currentRecipe.requiredTile = 283;
    Recipe.currentRecipe.needGraveyardBiome = true;
    Recipe.AddRecipe();
  }

  private static void CreateReversePlatformRecipes()
  {
    int numRecipes = Recipe.numRecipes;
    for (int index1 = 0; index1 < numRecipes; ++index1)
    {
      if (Main.recipe[index1].createItem.createTile >= 0 && TileID.Sets.Platforms[Main.recipe[index1].createItem.createTile] && Main.recipe[index1].requiredItem[1].type == 0)
      {
        Recipe.currentRecipe.createItem.SetDefaults(Main.recipe[index1].requiredItem[0].type);
        Recipe.currentRecipe.createItem.stack = Main.recipe[index1].requiredItem[0].stack;
        Recipe.currentRecipe.requiredItem[0].SetDefaults(Main.recipe[index1].createItem.type);
        Recipe.currentRecipe.requiredItem[0].stack = Main.recipe[index1].createItem.stack;
        Recipe.currentRecipe.requiredTile = Main.recipe[index1].requiredTile;
        Recipe.AddRecipe();
        Recipe recipe = Main.recipe[Recipe.numRecipes - 1];
        for (int index2 = Recipe.numRecipes - 2; index2 > index1; --index2)
          Main.recipe[index2 + 1] = Main.recipe[index2];
        Main.recipe[index1 + 1] = recipe;
        Main.recipe[index1 + 1].notDecraftable = true;
      }
    }
  }

  private static void CreateReverseWallRecipes()
  {
    int numRecipes = Recipe.numRecipes;
    for (int index1 = 0; index1 < numRecipes; ++index1)
    {
      if (Main.recipe[index1].createItem.createWall > 0 && Main.recipe[index1].requiredItem[1].type == 0 && Main.recipe[index1].requiredItem[0].createWall == -1)
      {
        Recipe.currentRecipe.createItem.SetDefaults(Main.recipe[index1].requiredItem[0].type);
        Recipe.currentRecipe.createItem.stack = Main.recipe[index1].requiredItem[0].stack;
        Recipe.currentRecipe.requiredItem[0].SetDefaults(Main.recipe[index1].createItem.type);
        Recipe.currentRecipe.requiredItem[0].stack = Main.recipe[index1].createItem.stack;
        Recipe.currentRecipe.requiredTile = Main.recipe[index1].requiredTile;
        Recipe.AddRecipe();
        Recipe recipe = Main.recipe[Recipe.numRecipes - 1];
        for (int index2 = Recipe.numRecipes - 2; index2 > index1; --index2)
          Main.recipe[index2 + 1] = Main.recipe[index2];
        Main.recipe[index1 + 1] = recipe;
        Main.recipe[index1 + 1].notDecraftable = true;
      }
    }
  }

  public void SetIngredients(params int[] ingredients)
  {
    if (ingredients.Length == 1)
      ingredients = new int[2]{ ingredients[0], 1 };
    if (ingredients.Length % 2 != 0)
      throw new Exception("Bad ingredients amount");
    for (int index1 = 0; index1 < ingredients.Length; index1 += 2)
    {
      int index2 = index1 / 2;
      this.requiredItem[index2].SetDefaults(ingredients[index1]);
      this.requiredItem[index2].stack = ingredients[index1 + 1];
    }
  }

  public void SetCraftingStation(int tileType) => this.requiredTile = tileType;

  private static void AddRecipe()
  {
    if (Recipe.currentRecipe.requiredTile == 13)
      Recipe.currentRecipe.alchemy = true;
    Main.recipe[Recipe.numRecipes] = Recipe.currentRecipe;
    if (Recipe.currentRecipe.requiredTile >= 0)
      Recipe.TileUsedInRecipes[Recipe.currentRecipe.requiredTile] = true;
    Recipe.currentRecipe = new Recipe();
    ++Recipe.numRecipes;
  }

  public static int GetRequiredTileStyle(int tileID) => tileID == 26 && WorldGen.crimson ? 1 : 0;

  public static string GetRequiredTileName(int tileId)
  {
    int requiredTileStyle = Recipe.GetRequiredTileStyle(tileId);
    return Lang.GetMapObjectName(MapHelper.TileToLookup(tileId, requiredTileStyle));
  }

  public bool ContainsIngredient(int itemType)
  {
    foreach (Recipe.RequiredItemEntry requiredItemEntry in this.requiredItemQuickLookup)
    {
      if (requiredItemEntry.itemIdOrRecipeGroup != 0)
      {
        if (requiredItemEntry.itemIdOrRecipeGroup == itemType)
          return true;
      }
      else
        break;
    }
    return false;
  }

  public struct RequiredItemEntry(int itemIdOrRecipeGroup, int stack = 1)
  {
    public int itemIdOrRecipeGroup = itemIdOrRecipeGroup;
    public int stack = stack;

    public RequiredItemEntry(RecipeGroup recipeGroup, int stack = 1)
      : this(recipeGroup.GetGroupFakeItemId(), stack)
    {
    }

    public bool IsRecipeGroup => this.itemIdOrRecipeGroup >= RecipeGroup.FakeItemIdOffset;

    public RecipeGroup RecipeGroup
    {
      get => RecipeGroup.recipeGroups[this.itemIdOrRecipeGroup - RecipeGroup.FakeItemIdOffset];
    }

    public bool Matches(int itemType)
    {
      return !this.IsRecipeGroup ? this.itemIdOrRecipeGroup == itemType : this.RecipeGroup.Contains(itemType);
    }

    public static implicit operator Recipe.RequiredItemEntry(RecipeGroup recipeGroup)
    {
      return new Recipe.RequiredItemEntry(recipeGroup);
    }

    public static implicit operator Recipe.RequiredItemEntry(int itemId)
    {
      return new Recipe.RequiredItemEntry(itemId);
    }
  }
}
