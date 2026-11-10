using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Terraria.GameContent;

namespace Terraria
{
	// Token: 0x020004F5 RID: 1269
	[Token(Token = "0x20004F5")]
	public class Recipe
	{
		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x060031A0 RID: 12704 RVA: 0x00017FA0 File Offset: 0x000161A0
		[Token(Token = "0x17000698")]
		public bool DoesNotNeedTileOrLiquid
		{
			[Token(Token = "0x60031A0")]
			[Address(RVA = "0x19BC06C", Offset = "0x19BC06C", VA = "0x19BC06C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060031A1 RID: 12705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031A1")]
		[Address(RVA = "0x19BC0A0", Offset = "0x19BC0A0", VA = "0x19BC0A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060031A2 RID: 12706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031A2")]
		[Address(RVA = "0x19BC370", Offset = "0x19BC370", VA = "0x19BC370")]
		public void RequireGroup(RecipeGroup group)
		{
		}

		// Token: 0x060031A3 RID: 12707 RVA: 0x00017FB8 File Offset: 0x000161B8
		[Token(Token = "0x60031A3")]
		[Address(RVA = "0x19BC3DC", Offset = "0x19BC3DC", VA = "0x19BC3DC")]
		public bool ProcessGroupsForText(int type, out string theText)
		{
			return default(bool);
		}

		// Token: 0x060031A4 RID: 12708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031A4")]
		[Address(RVA = "0x19BC5B8", Offset = "0x19BC5B8", VA = "0x19BC5B8")]
		public Item AddCustomShimmerResult(int itemType, int itemStack = 1)
		{
			return null;
		}

		// Token: 0x060031A5 RID: 12709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031A5")]
		[Address(RVA = "0x19BC770", Offset = "0x19BC770", VA = "0x19BC770")]
		public Recipe()
		{
		}

		// Token: 0x060031A6 RID: 12710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031A6")]
		[Address(RVA = "0x19BC918", Offset = "0x19BC918", VA = "0x19BC918")]
		public void GetIngredientsForOneCraft(Player player, List<Recipe.RequiredItemEntry> ingredients)
		{
		}

		// Token: 0x060031A7 RID: 12711 RVA: 0x00017FD0 File Offset: 0x000161D0
		[Token(Token = "0x60031A7")]
		[Address(RVA = "0x19BCA34", Offset = "0x19BCA34", VA = "0x19BCA34")]
		private int GetIngredientCraftingDiscount(Player player, Recipe.RequiredItemEntry req)
		{
			return 0;
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x060031A8 RID: 12712 RVA: 0x00017FE8 File Offset: 0x000161E8
		// (set) Token: 0x060031A9 RID: 12713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000699")]
		private static bool _hasDelayedFindRecipes
		{
			[Token(Token = "0x60031A8")]
			[Address(RVA = "0x19BCB10", Offset = "0x19BCB10", VA = "0x19BCB10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60031A9")]
			[Address(RVA = "0x19BCB78", Offset = "0x19BCB78", VA = "0x19BCB78")]
			set
			{
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x060031AA RID: 12714 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060031AB RID: 12715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700069A")]
		internal static List<DestinationInventory> _inRangeSources
		{
			[Token(Token = "0x60031AA")]
			[Address(RVA = "0x19BCBE4", Offset = "0x19BCBE4", VA = "0x19BCBE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60031AB")]
			[Address(RVA = "0x19BCC4C", Offset = "0x19BCC4C", VA = "0x19BCC4C")]
			set
			{
			}
		}

		// Token: 0x060031AC RID: 12716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031AC")]
		[Address(RVA = "0x19BCCB8", Offset = "0x19BCCB8", VA = "0x19BCCB8")]
		public static void GetThroughDelayedFindRecipes()
		{
		}

		// Token: 0x060031AD RID: 12717 RVA: 0x00018000 File Offset: 0x00016200
		[Token(Token = "0x60031AD")]
		[Address(RVA = "0x19BDD50", Offset = "0x19BDD50", VA = "0x19BDD50")]
		public static bool IsChestSource(Chest chest)
		{
			return default(bool);
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x060031AE RID: 12718 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060031AF RID: 12719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700069B")]
		private static Dictionary<int, int> _ownedItems
		{
			[Token(Token = "0x60031AE")]
			[Address(RVA = "0x19BDF00", Offset = "0x19BDF00", VA = "0x19BDF00")]
			get
			{
				return null;
			}
			[Token(Token = "0x60031AF")]
			[Address(RVA = "0x19BDF68", Offset = "0x19BDF68", VA = "0x19BDF68")]
			set
			{
			}
		}

		// Token: 0x060031B0 RID: 12720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031B0")]
		[Address(RVA = "0x19BDA14", Offset = "0x19BDA14", VA = "0x19BDA14")]
		public static void FindRecipes(bool canDelayCheck = true)
		{
		}

		// Token: 0x060031B1 RID: 12721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031B1")]
		[Address(RVA = "0x19BE700", Offset = "0x19BE700", VA = "0x19BE700")]
		public static void SubtractOwnedItem(Recipe.RequiredItemEntry req)
		{
		}

		// Token: 0x060031B2 RID: 12722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031B2")]
		[Address(RVA = "0x19BE490", Offset = "0x19BE490", VA = "0x19BE490")]
		private static void AddToAvailableRecipes(int recipeIndex)
		{
		}

		// Token: 0x060031B3 RID: 12723 RVA: 0x00018018 File Offset: 0x00016218
		[Token(Token = "0x60031B3")]
		[Address(RVA = "0x19BE3C8", Offset = "0x19BE3C8", VA = "0x19BE3C8")]
		public static bool CollectedEnoughItemsToCraft(Recipe recipe)
		{
			return default(bool);
		}

		// Token: 0x060031B4 RID: 12724 RVA: 0x00018030 File Offset: 0x00016230
		[Token(Token = "0x60031B4")]
		[Address(RVA = "0x19BE8E4", Offset = "0x19BE8E4", VA = "0x19BE8E4")]
		public static bool CollectedEnoughItemsToCraft(Recipe.RequiredItemEntry[] requiredItems)
		{
			return default(bool);
		}

		// Token: 0x060031B5 RID: 12725 RVA: 0x00018048 File Offset: 0x00016248
		[Token(Token = "0x60031B5")]
		[Address(RVA = "0x19BEB20", Offset = "0x19BEB20", VA = "0x19BEB20")]
		public static int HowManyTimesCanRecipeBeCrafted(Recipe recipe)
		{
			return 0;
		}

		// Token: 0x060031B6 RID: 12726 RVA: 0x00018060 File Offset: 0x00016260
		[Token(Token = "0x60031B6")]
		[Address(RVA = "0x19BE958", Offset = "0x19BE958", VA = "0x19BE958")]
		public static int HowManyTimesCanRecipeBeCrafted(Recipe.RequiredItemEntry[] requiredItems)
		{
			return 0;
		}

		// Token: 0x060031B7 RID: 12727 RVA: 0x00018078 File Offset: 0x00016278
		[Token(Token = "0x60031B7")]
		[Address(RVA = "0x19BEB94", Offset = "0x19BEB94", VA = "0x19BEB94")]
		public static int GetAvailableItemCount(Recipe.RequiredItemEntry item)
		{
			return 0;
		}

		// Token: 0x060031B8 RID: 12728 RVA: 0x00018090 File Offset: 0x00016290
		[Token(Token = "0x60031B8")]
		[Address(RVA = "0x19BE23C", Offset = "0x19BE23C", VA = "0x19BE23C")]
		private static bool PlayerMeetsEnvironmentConditions(Player player, Recipe tempRec)
		{
			return default(bool);
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x060031B9 RID: 12729 RVA: 0x000180A8 File Offset: 0x000162A8
		// (set) Token: 0x060031BA RID: 12730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700069C")]
		public static int CraftingFilterX
		{
			[Token(Token = "0x60031B9")]
			[Address(RVA = "0x19BECA0", Offset = "0x19BECA0", VA = "0x19BECA0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60031BA")]
			[Address(RVA = "0x19BED08", Offset = "0x19BED08", VA = "0x19BED08")]
			set
			{
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x060031BB RID: 12731 RVA: 0x000180C0 File Offset: 0x000162C0
		// (set) Token: 0x060031BC RID: 12732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700069D")]
		public static int CraftingFilterY
		{
			[Token(Token = "0x60031BB")]
			[Address(RVA = "0x19BED74", Offset = "0x19BED74", VA = "0x19BED74")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60031BC")]
			[Address(RVA = "0x19BEDDC", Offset = "0x19BEDDC", VA = "0x19BEDDC")]
			set
			{
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x060031BD RID: 12733 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060031BE RID: 12734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700069E")]
		public static List<int> AllowedRequiredTileIdsForFilter
		{
			[Token(Token = "0x60031BD")]
			[Address(RVA = "0x19BEE48", Offset = "0x19BEE48", VA = "0x19BEE48")]
			get
			{
				return null;
			}
			[Token(Token = "0x60031BE")]
			[Address(RVA = "0x19BEEB0", Offset = "0x19BEEB0", VA = "0x19BEEB0")]
			set
			{
			}
		}

		// Token: 0x060031BF RID: 12735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031BF")]
		[Address(RVA = "0x19BEF1C", Offset = "0x19BEF1C", VA = "0x19BEF1C")]
		public static void SetCraftingFilter(int x, int y, int byTileId)
		{
		}

		// Token: 0x060031C0 RID: 12736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031C0")]
		[Address(RVA = "0x19BF0FC", Offset = "0x19BF0FC", VA = "0x19BF0FC")]
		public static void ClearCraftingFilter()
		{
		}

		// Token: 0x060031C1 RID: 12737 RVA: 0x000180D8 File Offset: 0x000162D8
		[Token(Token = "0x60031C1")]
		[Address(RVA = "0x19BE1DC", Offset = "0x19BE1DC", VA = "0x19BE1DC")]
		private static bool PlayerMeetsTileRequirements(Player player, Recipe tempRec)
		{
			return default(bool);
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x060031C2 RID: 12738 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060031C3 RID: 12739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700069F")]
		internal static List<DestinationInventory> _recipeSources
		{
			[Token(Token = "0x60031C2")]
			[Address(RVA = "0x19BD9AC", Offset = "0x19BD9AC", VA = "0x19BD9AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60031C3")]
			[Address(RVA = "0x19BF27C", Offset = "0x19BF27C", VA = "0x19BF27C")]
			set
			{
			}
		}

		// Token: 0x060031C4 RID: 12740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031C4")]
		[Address(RVA = "0x19BE098", Offset = "0x19BE098", VA = "0x19BE098")]
		private static void CollectItemsToCraftWithFrom(Player player)
		{
		}

		// Token: 0x060031C5 RID: 12741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031C5")]
		[Address(RVA = "0x19BD0A0", Offset = "0x19BD0A0", VA = "0x19BD0A0")]
		public static void BuildPlayerChestSourceList(Player player, List<DestinationInventory> outputList)
		{
		}

		// Token: 0x060031C6 RID: 12742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031C6")]
		[Address(RVA = "0x19BF4E0", Offset = "0x19BF4E0", VA = "0x19BF4E0")]
		private static void CollectItemsFromChests(Player player)
		{
		}

		// Token: 0x060031C7 RID: 12743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031C7")]
		[Address(RVA = "0x19BF6D0", Offset = "0x19BF6D0", VA = "0x19BF6D0")]
		private static void AddFakeCountsForItemGroups()
		{
		}

		// Token: 0x060031C8 RID: 12744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031C8")]
		[Address(RVA = "0x19BFA08", Offset = "0x19BFA08", VA = "0x19BFA08")]
		private static void CollectItems(ChestItem[] currentInventory, int slotCap)
		{
		}

		// Token: 0x060031C9 RID: 12745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031C9")]
		[Address(RVA = "0x19BF2E8", Offset = "0x19BF2E8", VA = "0x19BF2E8")]
		private static void CollectItems(Item[] currentInventory, int slotCap)
		{
		}

		// Token: 0x060031CA RID: 12746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031CA")]
		[Address(RVA = "0x19BFBEC", Offset = "0x19BFBEC", VA = "0x19BFBEC")]
		public static void ConsumeOwnedItem(int type, int qty)
		{
		}

		// Token: 0x060031CB RID: 12747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031CB")]
		[Address(RVA = "0x19BFD38", Offset = "0x19BFD38", VA = "0x19BFD38")]
		private static void CollectGuideRecipes()
		{
		}

		// Token: 0x060031CC RID: 12748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031CC")]
		[Address(RVA = "0x19BDFD4", Offset = "0x19BDFD4", VA = "0x19BDFD4")]
		public static void ClearAvailableRecipes()
		{
		}

		// Token: 0x060031CD RID: 12749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031CD")]
		[Address(RVA = "0x19BE52C", Offset = "0x19BE52C", VA = "0x19BE52C")]
		private static void TryRefocusingRecipe(int oldRecipe)
		{
		}

		// Token: 0x060031CE RID: 12750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031CE")]
		[Address(RVA = "0x19BFEE4", Offset = "0x19BFEE4", VA = "0x19BFEE4")]
		public static void SetupRecipeGroups()
		{
		}

		// Token: 0x060031CF RID: 12751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031CF")]
		[Address(RVA = "0x19C19F4", Offset = "0x19C19F4", VA = "0x19C19F4")]
		public static void RefreshMechMaterial(Item[] items, int count)
		{
		}

		// Token: 0x060031D0 RID: 12752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031D0")]
		[Address(RVA = "0x19C1AE0", Offset = "0x19C1AE0", VA = "0x19C1AE0")]
		public static void UpdateItemVariants()
		{
		}

		// Token: 0x060031D1 RID: 12753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031D1")]
		[Address(RVA = "0x1905C48", Offset = "0x1905C48", VA = "0x1905C48")]
		public static void SetupRecipes()
		{
		}

		// Token: 0x060031D2 RID: 12754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031D2")]
		[Address(RVA = "0x19C1F20", Offset = "0x19C1F20", VA = "0x19C1F20")]
		private static void CreateRequiredItemQuickLookups()
		{
		}

		// Token: 0x060031D3 RID: 12755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031D3")]
		[Address(RVA = "0x19C2228", Offset = "0x19C2228", VA = "0x19C2228")]
		private static void UpdateMaterialFieldForAllRecipes()
		{
		}

		// Token: 0x060031D4 RID: 12756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031D4")]
		[Address(RVA = "0x19C23CC", Offset = "0x19C23CC", VA = "0x19C23CC")]
		public static void UpdateWhichItemsAreMaterials()
		{
		}

		// Token: 0x060031D5 RID: 12757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031D5")]
		[Address(RVA = "0x19C23D0", Offset = "0x19C23D0", VA = "0x19C23D0")]
		public static void UpdateWhichItemsAreCrafted()
		{
		}

		// Token: 0x060031D6 RID: 12758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031D6")]
		[Address(RVA = "0x19C26F8", Offset = "0x19C26F8", VA = "0x19C26F8")]
		private static void AddSolarFurniture()
		{
		}

		// Token: 0x060031D7 RID: 12759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031D7")]
		[Address(RVA = "0x19C3D7C", Offset = "0x19C3D7C", VA = "0x19C3D7C")]
		private static void AddVortexFurniture()
		{
		}

		// Token: 0x060031D8 RID: 12760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031D8")]
		[Address(RVA = "0x19C4F44", Offset = "0x19C4F44", VA = "0x19C4F44")]
		private static void AddNebulaFurniture()
		{
		}

		// Token: 0x060031D9 RID: 12761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031D9")]
		[Address(RVA = "0x19C610C", Offset = "0x19C610C", VA = "0x19C610C")]
		private static void AddStardustFurniture()
		{
		}

		// Token: 0x060031DA RID: 12762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031DA")]
		[Address(RVA = "0x19C72D4", Offset = "0x19C72D4", VA = "0x19C72D4")]
		private static void AddSpiderFurniture()
		{
		}

		// Token: 0x060031DB RID: 12763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031DB")]
		[Address(RVA = "0x19C847C", Offset = "0x19C847C", VA = "0x19C847C")]
		private static void AddLesionFurniture()
		{
		}

		// Token: 0x060031DC RID: 12764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031DC")]
		[Address(RVA = "0x19C9F70", Offset = "0x19C9F70", VA = "0x19C9F70")]
		private static void AddSandstoneFurniture()
		{
		}

		// Token: 0x060031DD RID: 12765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031DD")]
		[Address(RVA = "0x19CB028", Offset = "0x19CB028", VA = "0x19CB028")]
		private static void AddBambooFurniture()
		{
		}

		// Token: 0x060031DE RID: 12766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031DE")]
		[Address(RVA = "0x19CBFEC", Offset = "0x19CBFEC", VA = "0x19CBFEC")]
		private static void AddCoralFurniture()
		{
		}

		// Token: 0x060031DF RID: 12767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031DF")]
		[Address(RVA = "0x19CCFB0", Offset = "0x19CCFB0", VA = "0x19CCFB0")]
		private static void AddBalloonFurniture()
		{
		}

		// Token: 0x060031E0 RID: 12768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031E0")]
		[Address(RVA = "0x19CE85C", Offset = "0x19CE85C", VA = "0x19CE85C")]
		private static void AddAshWoodFurnitureArmorAndItems()
		{
		}

		// Token: 0x060031E1 RID: 12769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031E1")]
		[Address(RVA = "0x19CFCB8", Offset = "0x19CFCB8", VA = "0x19CFCB8")]
		private static void AddAetheriumFurniture()
		{
		}

		// Token: 0x060031E2 RID: 12770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031E2")]
		[Address(RVA = "0x19D0C7C", Offset = "0x19D0C7C", VA = "0x19D0C7C")]
		private static void AddFallenStarFurniture()
		{
		}

		// Token: 0x060031E3 RID: 12771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031E3")]
		[Address(RVA = "0x19D1C40", Offset = "0x19D1C40", VA = "0x19D1C40")]
		private static void AddFeywoodFurniture()
		{
		}

		// Token: 0x060031E4 RID: 12772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031E4")]
		[Address(RVA = "0x19D30A4", Offset = "0x19D30A4", VA = "0x19D30A4")]
		private static void AddHallowedFurniture()
		{
		}

		// Token: 0x060031E5 RID: 12773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031E5")]
		[Address(RVA = "0x19D3198", Offset = "0x19D3198", VA = "0x19D3198")]
		private static void AddEasterFurniture()
		{
		}

		// Token: 0x060031E6 RID: 12774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031E6")]
		[Address(RVA = "0x19D328C", Offset = "0x19D328C", VA = "0x19D328C")]
		private static void AddGothicFurniture()
		{
		}

		// Token: 0x060031E7 RID: 12775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031E7")]
		[Address(RVA = "0x19D3380", Offset = "0x19D3380", VA = "0x19D3380")]
		private static void AddDemoniteFurniture()
		{
		}

		// Token: 0x060031E8 RID: 12776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031E8")]
		[Address(RVA = "0x19D3474", Offset = "0x19D3474", VA = "0x19D3474")]
		private static void AddCrimtaneFurniture()
		{
		}

		// Token: 0x060031E9 RID: 12777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031E9")]
		[Address(RVA = "0x19D3568", Offset = "0x19D3568", VA = "0x19D3568")]
		private static void AddSnowFurniture()
		{
		}

		// Token: 0x060031EA RID: 12778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031EA")]
		[Address(RVA = "0x19D365C", Offset = "0x19D365C", VA = "0x19D365C")]
		private static void AddFlinxFurFurniture()
		{
		}

		// Token: 0x060031EB RID: 12779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031EB")]
		[Address(RVA = "0x19D3750", Offset = "0x19D3750", VA = "0x19D3750")]
		private static void AddPineFurniture()
		{
		}

		// Token: 0x060031EC RID: 12780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031EC")]
		[Address(RVA = "0x19D38C8", Offset = "0x19D38C8", VA = "0x19D38C8")]
		private static void AddStoneFurniture()
		{
		}

		// Token: 0x060031ED RID: 12781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031ED")]
		[Address(RVA = "0x19D39BC", Offset = "0x19D39BC", VA = "0x19D39BC")]
		private static void AddJellyfishFurniture()
		{
		}

		// Token: 0x060031EE RID: 12782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031EE")]
		[Address(RVA = "0x19D3AB0", Offset = "0x19D3AB0", VA = "0x19D3AB0")]
		private static void AddHarpyFurniture()
		{
		}

		// Token: 0x060031EF RID: 12783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031EF")]
		[Address(RVA = "0x19D3BA4", Offset = "0x19D3BA4", VA = "0x19D3BA4")]
		private static void AddCloudFurniture()
		{
		}

		// Token: 0x060031F0 RID: 12784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031F0")]
		[Address(RVA = "0x19D3C98", Offset = "0x19D3C98", VA = "0x19D3C98")]
		private static void AddMoonplateFurniture()
		{
		}

		// Token: 0x060031F1 RID: 12785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031F1")]
		[Address(RVA = "0x19D3D8C", Offset = "0x19D3D8C", VA = "0x19D3D8C")]
		private static void AddLibrarianFurniture()
		{
		}

		// Token: 0x060031F2 RID: 12786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031F2")]
		[Address(RVA = "0x19D3E80", Offset = "0x19D3E80", VA = "0x19D3E80")]
		private static void AddSpikeFurniture()
		{
		}

		// Token: 0x060031F3 RID: 12787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031F3")]
		[Address(RVA = "0x19D3F74", Offset = "0x19D3F74", VA = "0x19D3F74")]
		private static void AddOfficeFurniture()
		{
		}

		// Token: 0x060031F4 RID: 12788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031F4")]
		[Address(RVA = "0x19D4068", Offset = "0x19D4068", VA = "0x19D4068")]
		private static void AddForbiddenFurniture()
		{
		}

		// Token: 0x060031F5 RID: 12789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031F5")]
		[Address(RVA = "0x19D415C", Offset = "0x19D415C", VA = "0x19D415C")]
		private static void AddWaterFurniture()
		{
		}

		// Token: 0x060031F6 RID: 12790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031F6")]
		[Address(RVA = "0x19D4250", Offset = "0x19D4250", VA = "0x19D4250")]
		private static void AddBoulderFurniture()
		{
		}

		// Token: 0x060031F7 RID: 12791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031F7")]
		[Address(RVA = "0x19D1D34", Offset = "0x19D1D34", VA = "0x19D1D34")]
		private static void AddStandardFurnitureSetRecipes(int primaryMaterial, int bathtub, int bed, int bookcase, int candelabra, int candle, int chair, int chandelier, int chest, int clock, int door, int dresser, int lamp, int lantern, int piano, int sink, int sofa, int table, int toilet, int workbench, int fake_chest, int overrideStation = -1)
		{
		}

		// Token: 0x060031F8 RID: 12792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031F8")]
		[Address(RVA = "0x19D4344", Offset = "0x19D4344", VA = "0x19D4344")]
		private static void AddCritterStatueRecipe(int statueItem, int critterItem = 0, [Optional] RecipeGroup critterGroup)
		{
		}

		// Token: 0x060031F9 RID: 12793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031F9")]
		[Address(RVA = "0x19D45F0", Offset = "0x19D45F0", VA = "0x19D45F0")]
		private static void CreateReversePlatformRecipes()
		{
		}

		// Token: 0x060031FA RID: 12794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031FA")]
		[Address(RVA = "0x19D4BF4", Offset = "0x19D4BF4", VA = "0x19D4BF4")]
		private static void CreateReverseWallRecipes()
		{
		}

		// Token: 0x060031FB RID: 12795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031FB")]
		[Address(RVA = "0x19C38C0", Offset = "0x19C38C0", VA = "0x19C38C0")]
		public void SetIngredients(int[] ingredients)
		{
		}

		// Token: 0x060031FC RID: 12796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031FC")]
		[Address(RVA = "0x19D51B0", Offset = "0x19D51B0", VA = "0x19D51B0")]
		public void SetCraftingStation(int tileType)
		{
		}

		// Token: 0x060031FD RID: 12797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031FD")]
		[Address(RVA = "0x19C3A68", Offset = "0x19C3A68", VA = "0x19C3A68")]
		private static void AddRecipe()
		{
		}

		// Token: 0x060031FE RID: 12798 RVA: 0x000180F0 File Offset: 0x000162F0
		[Token(Token = "0x60031FE")]
		[Address(RVA = "0x19D51B8", Offset = "0x19D51B8", VA = "0x19D51B8")]
		public static int GetRequiredTileStyle(int tileID)
		{
			return 0;
		}

		// Token: 0x060031FF RID: 12799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031FF")]
		[Address(RVA = "0x19D5238", Offset = "0x19D5238", VA = "0x19D5238")]
		public static string GetRequiredTileName(int tileId)
		{
			return null;
		}

		// Token: 0x06003200 RID: 12800 RVA: 0x00018108 File Offset: 0x00016308
		[Token(Token = "0x6003200")]
		[Address(RVA = "0x19D537C", Offset = "0x19D537C", VA = "0x19D537C")]
		public bool ContainsIngredient(int itemType)
		{
			return default(bool);
		}

		// Token: 0x0400424E RID: 16974
		[Token(Token = "0x400424E")]
		public const int maxRequirements = 15;

		// Token: 0x0400424F RID: 16975
		[Token(Token = "0x400424F")]
		public const int maxRecipes = 3700;

		// Token: 0x04004250 RID: 16976
		[Token(Token = "0x4004250")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int numRecipes;

		// Token: 0x04004251 RID: 16977
		[Token(Token = "0x4004251")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static bool[] TileIdUsedInRecipes;

		// Token: 0x04004252 RID: 16978
		[Token(Token = "0x4004252")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Recipe currentRecipe;

		// Token: 0x04004253 RID: 16979
		[Token(Token = "0x4004253")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Item createItem;

		// Token: 0x04004254 RID: 16980
		[Token(Token = "0x4004254")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Item[] requiredItem;

		// Token: 0x04004255 RID: 16981
		[Token(Token = "0x4004255")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int requiredTile;

		// Token: 0x04004256 RID: 16982
		[Token(Token = "0x4004256")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int[] acceptedGroups;

		// Token: 0x04004257 RID: 16983
		[Token(Token = "0x4004257")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Recipe.RequiredItemEntry[] requiredItemQuickLookup;

		// Token: 0x04004258 RID: 16984
		[Token(Token = "0x4004258")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public List<Item> customShimmerResults;

		// Token: 0x04004259 RID: 16985
		[Token(Token = "0x4004259")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool needHoney;

		// Token: 0x0400425A RID: 16986
		[Token(Token = "0x400425A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool needWater;

		// Token: 0x0400425B RID: 16987
		[Token(Token = "0x400425B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool needLava;

		// Token: 0x0400425C RID: 16988
		[Token(Token = "0x400425C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		public bool needTorchGodsFavor;

		// Token: 0x0400425D RID: 16989
		[Token(Token = "0x400425D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool alchemy;

		// Token: 0x0400425E RID: 16990
		[Token(Token = "0x400425E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool needSnowBiome;

		// Token: 0x0400425F RID: 16991
		[Token(Token = "0x400425F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool needGraveyardBiome;

		// Token: 0x04004260 RID: 16992
		[Token(Token = "0x4004260")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x27")]
		public bool needMechdusa;

		// Token: 0x04004261 RID: 16993
		[Token(Token = "0x4004261")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool notDecraftable;

		// Token: 0x04004262 RID: 16994
		[Token(Token = "0x4004262")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool crimson;

		// Token: 0x04004263 RID: 16995
		[Token(Token = "0x4004263")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool corruption;

		// Token: 0x04004264 RID: 16996
		[Token(Token = "0x4004264")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static Item defaultRecipeItem;

		// Token: 0x04004265 RID: 16997
		[Token(Token = "0x4004265")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static bool cachedMechMats;

		// Token: 0x020004F6 RID: 1270
		[Token(Token = "0x20004F6")]
		public struct RequiredItemEntry
		{
			// Token: 0x06003202 RID: 12802 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003202")]
			[Address(RVA = "0x19FF070", Offset = "0x19FF070", VA = "0x19FF070")]
			public RequiredItemEntry(RecipeGroup recipeGroup, int stack = 1)
			{
			}

			// Token: 0x06003203 RID: 12803 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003203")]
			[Address(RVA = "0x19FF0F8", Offset = "0x19FF0F8", VA = "0x19FF0F8")]
			public RequiredItemEntry(int itemIdOrRecipeGroup, int stack = 1)
			{
			}

			// Token: 0x170006A0 RID: 1696
			// (get) Token: 0x06003204 RID: 12804 RVA: 0x00018120 File Offset: 0x00016320
			[Token(Token = "0x170006A0")]
			public bool IsRecipeGroup
			{
				[Token(Token = "0x6003204")]
				[Address(RVA = "0x19FF100", Offset = "0x19FF100", VA = "0x19FF100")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170006A1 RID: 1697
			// (get) Token: 0x06003205 RID: 12805 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006A1")]
			public RecipeGroup RecipeGroup
			{
				[Token(Token = "0x6003205")]
				[Address(RVA = "0x19FF178", Offset = "0x19FF178", VA = "0x19FF178")]
				get
				{
					return null;
				}
			}

			// Token: 0x06003206 RID: 12806 RVA: 0x00018138 File Offset: 0x00016338
			[Token(Token = "0x6003206")]
			[Address(RVA = "0x19FF220", Offset = "0x19FF220", VA = "0x19FF220")]
			public bool Matches(int itemType)
			{
				return default(bool);
			}

			// Token: 0x06003207 RID: 12807 RVA: 0x00018150 File Offset: 0x00016350
			[Token(Token = "0x6003207")]
			[Address(RVA = "0x19FF3A0", Offset = "0x19FF3A0", VA = "0x19FF3A0")]
			public static implicit operator Recipe.RequiredItemEntry(RecipeGroup recipeGroup)
			{
				return default(Recipe.RequiredItemEntry);
			}

			// Token: 0x06003208 RID: 12808 RVA: 0x00018168 File Offset: 0x00016368
			[Token(Token = "0x6003208")]
			[Address(RVA = "0x19FF434", Offset = "0x19FF434", VA = "0x19FF434")]
			public static implicit operator Recipe.RequiredItemEntry(int itemId)
			{
				return default(Recipe.RequiredItemEntry);
			}

			// Token: 0x04004266 RID: 16998
			[Token(Token = "0x4004266")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int itemIdOrRecipeGroup;

			// Token: 0x04004267 RID: 16999
			[Token(Token = "0x4004267")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int stack;
		}
	}
}
