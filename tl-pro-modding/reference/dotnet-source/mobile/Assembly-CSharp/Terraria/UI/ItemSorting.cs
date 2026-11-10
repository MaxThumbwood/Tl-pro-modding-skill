using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.UI
{
	// Token: 0x02000847 RID: 2119
	[Token(Token = "0x2000847")]
	public class ItemSorting
	{
		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x0600492C RID: 18732 RVA: 0x00022D10 File Offset: 0x00020F10
		[Token(Token = "0x1700090D")]
		public static int LayerCount
		{
			[Token(Token = "0x600492C")]
			[Address(RVA = "0x5FB7F0", Offset = "0x5FB7F0", VA = "0x5FB7F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600492D RID: 18733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600492D")]
		[Address(RVA = "0x5FB854", Offset = "0x5FB854", VA = "0x5FB854")]
		public static void SetupWhiteLists()
		{
		}

		// Token: 0x0600492E RID: 18734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600492E")]
		[Address(RVA = "0x5FD990", Offset = "0x5FD990", VA = "0x5FD990")]
		private static void AddSortingPrioritiesBasedOnPlayerDamage(List<ItemSorting.ItemSortingLayer> list)
		{
		}

		// Token: 0x0600492F RID: 18735 RVA: 0x00022D28 File Offset: 0x00020F28
		[Token(Token = "0x600492F")]
		[Address(RVA = "0x5FE0A8", Offset = "0x5FE0A8", VA = "0x5FE0A8")]
		private static int Descending(ItemSorting.DamageTypeSortingLayerEntry x, ItemSorting.DamageTypeSortingLayerEntry y)
		{
			return 0;
		}

		// Token: 0x06004930 RID: 18736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004930")]
		[Address(RVA = "0x5FE10C", Offset = "0x5FE10C", VA = "0x5FE10C")]
		private static void SetupSortingPriorities()
		{
		}

		// Token: 0x06004931 RID: 18737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004931")]
		[Address(RVA = "0x5FFB34", Offset = "0x5FFB34", VA = "0x5FFB34")]
		private static void BuildIndexSortTable()
		{
		}

		// Token: 0x06004932 RID: 18738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004932")]
		[Address(RVA = "0x5FFCB4", Offset = "0x5FFCB4", VA = "0x5FFCB4")]
		private static void Sort(bool withFeedback, Item[] inv, int[] ignoreSlots)
		{
		}

		// Token: 0x06004933 RID: 18739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004933")]
		[Address(RVA = "0x601088", Offset = "0x601088", VA = "0x601088")]
		public static string GetSortingLayer(int itemType)
		{
			return null;
		}

		// Token: 0x06004934 RID: 18740 RVA: 0x00022D40 File Offset: 0x00020F40
		[Token(Token = "0x6004934")]
		[Address(RVA = "0x6012D4", Offset = "0x6012D4", VA = "0x6012D4")]
		public static int GetSortingLayerIndex(int itemType)
		{
			return 0;
		}

		// Token: 0x06004935 RID: 18741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004935")]
		[Address(RVA = "0x601350", Offset = "0x601350", VA = "0x601350")]
		public static void SortInventory()
		{
		}

		// Token: 0x06004936 RID: 18742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004936")]
		[Address(RVA = "0x601B94", Offset = "0x601B94", VA = "0x601B94")]
		public static void SortChest()
		{
		}

		// Token: 0x06004937 RID: 18743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004937")]
		[Address(RVA = "0x60217C", Offset = "0x60217C", VA = "0x60217C")]
		public static void SortInventory(Chest chest, bool withSync, bool withFeedback)
		{
		}

		// Token: 0x06004938 RID: 18744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004938")]
		[Address(RVA = "0x60258C", Offset = "0x60258C", VA = "0x60258C")]
		private static void Sort(bool withFeedback, ChestItem[] inv, int maxCount, int[] ignoreSlots)
		{
		}

		// Token: 0x06004939 RID: 18745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004939")]
		[Address(RVA = "0x601CB0", Offset = "0x601CB0", VA = "0x601CB0")]
		public static void SortInventory(InventoryStorage chest, bool withSync, bool withFeedback)
		{
		}

		// Token: 0x0600493A RID: 18746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600493A")]
		[Address(RVA = "0x601B34", Offset = "0x601B34", VA = "0x601B34")]
		public static void SortAmmo()
		{
		}

		// Token: 0x0600493B RID: 18747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600493B")]
		[Address(RVA = "0x603CCC", Offset = "0x603CCC", VA = "0x603CCC")]
		public static void FillAmmoFromInventory()
		{
		}

		// Token: 0x0600493C RID: 18748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600493C")]
		[Address(RVA = "0x6039B0", Offset = "0x6039B0", VA = "0x6039B0")]
		public static void ClearAmmoSlotSpaces()
		{
		}

		// Token: 0x0600493D RID: 18749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600493D")]
		[Address(RVA = "0x601570", Offset = "0x601570", VA = "0x601570")]
		private static void SortCoins()
		{
		}

		// Token: 0x0600493E RID: 18750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600493E")]
		[Address(RVA = "0x604494", Offset = "0x604494", VA = "0x604494")]
		private static void RefillItemStack(Item[] inv, Item itemToRefill, int loopStartIndex, int loopEndIndex)
		{
		}

		// Token: 0x0600493F RID: 18751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600493F")]
		[Address(RVA = "0x6045B0", Offset = "0x6045B0", VA = "0x6045B0")]
		private static void TrySlidingUp(Item[] inv, int slot, int minimumIndex)
		{
		}

		// Token: 0x06004940 RID: 18752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004940")]
		[Address(RVA = "0x604698", Offset = "0x604698", VA = "0x604698")]
		public ItemSorting()
		{
		}

		// Token: 0x04008F2A RID: 36650
		[Token(Token = "0x4008F2A")]
		[FieldOffset(Offset = "0x0")]
		private static List<ItemSorting.ItemSortingLayer> _layerList;

		// Token: 0x04008F2B RID: 36651
		[Token(Token = "0x4008F2B")]
		[FieldOffset(Offset = "0x4")]
		private static Dictionary<string, List<int>> _layerWhiteLists;

		// Token: 0x04008F2C RID: 36652
		[Token(Token = "0x4008F2C")]
		[FieldOffset(Offset = "0x8")]
		private static int[] _layerIndexForItemType;

		// Token: 0x04008F2D RID: 36653
		[Token(Token = "0x4008F2D")]
		[FieldOffset(Offset = "0xC")]
		private static int _layerCount;

		// Token: 0x04008F2E RID: 36654
		[Token(Token = "0x4008F2E")]
		[FieldOffset(Offset = "0x10")]
		private static List<ItemSorting.DamageTypeSortingLayerEntry> _damageRankings;

		// Token: 0x04008F2F RID: 36655
		[Token(Token = "0x4008F2F")]
		[FieldOffset(Offset = "0x14")]
		private static readonly List<int> _sort_itemsToSort;

		// Token: 0x04008F30 RID: 36656
		[Token(Token = "0x4008F30")]
		[FieldOffset(Offset = "0x18")]
		private static readonly List<int> _sort_sortedItemIndexes;

		// Token: 0x04008F31 RID: 36657
		[Token(Token = "0x4008F31")]
		[FieldOffset(Offset = "0x1C")]
		private static readonly List<int> _sort_counts;

		// Token: 0x04008F32 RID: 36658
		[Token(Token = "0x4008F32")]
		[FieldOffset(Offset = "0x20")]
		private static readonly List<Item> _sort_itemsCache;

		// Token: 0x04008F33 RID: 36659
		[Token(Token = "0x4008F33")]
		[FieldOffset(Offset = "0x24")]
		private static readonly List<int> _sort_availableSortingSlots;

		// Token: 0x04008F34 RID: 36660
		[Token(Token = "0x4008F34")]
		[FieldOffset(Offset = "0x28")]
		private static ItemSorting.MemoryStamp[] _sortInventory_preStamps;

		// Token: 0x04008F35 RID: 36661
		[Token(Token = "0x4008F35")]
		[FieldOffset(Offset = "0x2C")]
		private static ItemSorting.MemoryStamp[] _sortInventory_postStamps;

		// Token: 0x04008F36 RID: 36662
		[Token(Token = "0x4008F36")]
		[FieldOffset(Offset = "0x30")]
		private static Item[] sortingTemp;

		// Token: 0x04008F37 RID: 36663
		[Token(Token = "0x4008F37")]
		[FieldOffset(Offset = "0x34")]
		private static readonly List<int> _fillAmmoFromInventory_acceptedAmmoTypes;

		// Token: 0x04008F38 RID: 36664
		[Token(Token = "0x4008F38")]
		[FieldOffset(Offset = "0x38")]
		private static readonly List<int> _fillAmmoFromInventory_emptyAmmoSlots;

		// Token: 0x02000848 RID: 2120
		[Token(Token = "0x2000848")]
		private class ItemSortingLayer
		{
			// Token: 0x06004942 RID: 18754 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004942")]
			[Address(RVA = "0x604A5C", Offset = "0x604A5C", VA = "0x604A5C")]
			public ItemSortingLayer(string name, Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>> method)
			{
			}

			// Token: 0x06004943 RID: 18755 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004943")]
			[Address(RVA = "0x604A80", Offset = "0x604A80", VA = "0x604A80")]
			public void Validate(ref List<int> indexesSortable, Item[] inv)
			{
			}

			// Token: 0x06004944 RID: 18756 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004944")]
			[Address(RVA = "0x604C58", Offset = "0x604C58", VA = "0x604C58", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04008F39 RID: 36665
			[Token(Token = "0x4008F39")]
			[FieldOffset(Offset = "0x8")]
			public readonly string Name;

			// Token: 0x04008F3A RID: 36666
			[Token(Token = "0x4008F3A")]
			[FieldOffset(Offset = "0xC")]
			public readonly Func<ItemSorting.ItemSortingLayer, Item[], List<int>, List<int>> SortingMethod;

			// Token: 0x02000849 RID: 2121
			[Token(Token = "0x2000849")]
			private sealed class <>c__DisplayClass3_0
			{
				// Token: 0x06004945 RID: 18757 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004945")]
				[Address(RVA = "0x604C50", Offset = "0x604C50", VA = "0x604C50")]
				public <>c__DisplayClass3_0()
				{
				}

				// Token: 0x06004946 RID: 18758 RVA: 0x00022D58 File Offset: 0x00020F58
				[Token(Token = "0x6004946")]
				[Address(RVA = "0x604C60", Offset = "0x604C60", VA = "0x604C60")]
				internal bool <Validate>b__0(int i)
				{
					return default(bool);
				}

				// Token: 0x04008F3B RID: 36667
				[Token(Token = "0x4008F3B")]
				[FieldOffset(Offset = "0x8")]
				public List<int> list;

				// Token: 0x04008F3C RID: 36668
				[Token(Token = "0x4008F3C")]
				[FieldOffset(Offset = "0xC")]
				public Item[] inv;
			}
		}

		// Token: 0x0200084A RID: 2122
		[Token(Token = "0x200084A")]
		private class ItemSortingLayers
		{
			// Token: 0x06004947 RID: 18759 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004947")]
			[Address(RVA = "0x604CF4", Offset = "0x604CF4", VA = "0x604CF4")]
			private static void SortIndicesStable(List<int> list, Comparison<int> comparison)
			{
			}

			// Token: 0x06004948 RID: 18760 RVA: 0x00022D70 File Offset: 0x00020F70
			[Token(Token = "0x6004948")]
			[Address(RVA = "0x604E20", Offset = "0x604E20", VA = "0x604E20")]
			public static int CompareWithPrioritySet(int[] prioritySet, int typeOne, int typeTwo)
			{
				return 0;
			}

			// Token: 0x06004949 RID: 18761 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004949")]
			[Address(RVA = "0x604EB0", Offset = "0x604EB0", VA = "0x604EB0")]
			public ItemSortingLayers()
			{
			}

			// Token: 0x04008F3D RID: 36669
			[Token(Token = "0x4008F3D")]
			[FieldOffset(Offset = "0x0")]
			public static ItemSorting.ItemSortingLayer WeaponsMelee;

			// Token: 0x04008F3E RID: 36670
			[Token(Token = "0x4008F3E")]
			[FieldOffset(Offset = "0x4")]
			public static ItemSorting.ItemSortingLayer WeaponsRanged;

			// Token: 0x04008F3F RID: 36671
			[Token(Token = "0x4008F3F")]
			[FieldOffset(Offset = "0x8")]
			public static ItemSorting.ItemSortingLayer WeaponsMagic;

			// Token: 0x04008F40 RID: 36672
			[Token(Token = "0x4008F40")]
			[FieldOffset(Offset = "0xC")]
			public static ItemSorting.ItemSortingLayer WeaponsMinions;

			// Token: 0x04008F41 RID: 36673
			[Token(Token = "0x4008F41")]
			[FieldOffset(Offset = "0x10")]
			public static ItemSorting.ItemSortingLayer WeaponsAssorted;

			// Token: 0x04008F42 RID: 36674
			[Token(Token = "0x4008F42")]
			[FieldOffset(Offset = "0x14")]
			public static ItemSorting.ItemSortingLayer WeaponsAmmo;

			// Token: 0x04008F43 RID: 36675
			[Token(Token = "0x4008F43")]
			[FieldOffset(Offset = "0x18")]
			public static ItemSorting.ItemSortingLayer ToolsPicksaws;

			// Token: 0x04008F44 RID: 36676
			[Token(Token = "0x4008F44")]
			[FieldOffset(Offset = "0x1C")]
			public static ItemSorting.ItemSortingLayer ToolsHamaxes;

			// Token: 0x04008F45 RID: 36677
			[Token(Token = "0x4008F45")]
			[FieldOffset(Offset = "0x20")]
			public static ItemSorting.ItemSortingLayer ToolsPickaxes;

			// Token: 0x04008F46 RID: 36678
			[Token(Token = "0x4008F46")]
			[FieldOffset(Offset = "0x24")]
			public static ItemSorting.ItemSortingLayer ToolsAxes;

			// Token: 0x04008F47 RID: 36679
			[Token(Token = "0x4008F47")]
			[FieldOffset(Offset = "0x28")]
			public static ItemSorting.ItemSortingLayer ToolsHammers;

			// Token: 0x04008F48 RID: 36680
			[Token(Token = "0x4008F48")]
			[FieldOffset(Offset = "0x2C")]
			public static ItemSorting.ItemSortingLayer ToolsTerraforming;

			// Token: 0x04008F49 RID: 36681
			[Token(Token = "0x4008F49")]
			[FieldOffset(Offset = "0x30")]
			public static ItemSorting.ItemSortingLayer ToolsFishing;

			// Token: 0x04008F4A RID: 36682
			[Token(Token = "0x4008F4A")]
			[FieldOffset(Offset = "0x34")]
			public static ItemSorting.ItemSortingLayer ToolsGolf;

			// Token: 0x04008F4B RID: 36683
			[Token(Token = "0x4008F4B")]
			[FieldOffset(Offset = "0x38")]
			public static ItemSorting.ItemSortingLayer ToolsInstruments;

			// Token: 0x04008F4C RID: 36684
			[Token(Token = "0x4008F4C")]
			[FieldOffset(Offset = "0x3C")]
			public static ItemSorting.ItemSortingLayer ToolsKeys;

			// Token: 0x04008F4D RID: 36685
			[Token(Token = "0x4008F4D")]
			[FieldOffset(Offset = "0x40")]
			public static ItemSorting.ItemSortingLayer ToolsKites;

			// Token: 0x04008F4E RID: 36686
			[Token(Token = "0x4008F4E")]
			[FieldOffset(Offset = "0x44")]
			public static ItemSorting.ItemSortingLayer ToolsAmmoLeftovers;

			// Token: 0x04008F4F RID: 36687
			[Token(Token = "0x4008F4F")]
			[FieldOffset(Offset = "0x48")]
			public static ItemSorting.ItemSortingLayer ToolsMisc;

			// Token: 0x04008F50 RID: 36688
			[Token(Token = "0x4008F50")]
			[FieldOffset(Offset = "0x4C")]
			public static ItemSorting.ItemSortingLayer ArmorCombat;

			// Token: 0x04008F51 RID: 36689
			[Token(Token = "0x4008F51")]
			[FieldOffset(Offset = "0x50")]
			public static ItemSorting.ItemSortingLayer ArmorVanity;

			// Token: 0x04008F52 RID: 36690
			[Token(Token = "0x4008F52")]
			[FieldOffset(Offset = "0x54")]
			public static ItemSorting.ItemSortingLayer ArmorAccessories;

			// Token: 0x04008F53 RID: 36691
			[Token(Token = "0x4008F53")]
			[FieldOffset(Offset = "0x58")]
			public static ItemSorting.ItemSortingLayer EquipGrapple;

			// Token: 0x04008F54 RID: 36692
			[Token(Token = "0x4008F54")]
			[FieldOffset(Offset = "0x5C")]
			public static ItemSorting.ItemSortingLayer EquipMount;

			// Token: 0x04008F55 RID: 36693
			[Token(Token = "0x4008F55")]
			[FieldOffset(Offset = "0x60")]
			public static ItemSorting.ItemSortingLayer EquipCart;

			// Token: 0x04008F56 RID: 36694
			[Token(Token = "0x4008F56")]
			[FieldOffset(Offset = "0x64")]
			public static ItemSorting.ItemSortingLayer EquipLightPet;

			// Token: 0x04008F57 RID: 36695
			[Token(Token = "0x4008F57")]
			[FieldOffset(Offset = "0x68")]
			public static ItemSorting.ItemSortingLayer EquipVanityPet;

			// Token: 0x04008F58 RID: 36696
			[Token(Token = "0x4008F58")]
			[FieldOffset(Offset = "0x6C")]
			public static ItemSorting.ItemSortingLayer PotionsLife;

			// Token: 0x04008F59 RID: 36697
			[Token(Token = "0x4008F59")]
			[FieldOffset(Offset = "0x70")]
			public static ItemSorting.ItemSortingLayer PotionsJustTheMushroom;

			// Token: 0x04008F5A RID: 36698
			[Token(Token = "0x4008F5A")]
			[FieldOffset(Offset = "0x74")]
			public static ItemSorting.ItemSortingLayer PotionsMana;

			// Token: 0x04008F5B RID: 36699
			[Token(Token = "0x4008F5B")]
			[FieldOffset(Offset = "0x78")]
			public static ItemSorting.ItemSortingLayer PotionsElixirs;

			// Token: 0x04008F5C RID: 36700
			[Token(Token = "0x4008F5C")]
			[FieldOffset(Offset = "0x7C")]
			public static ItemSorting.ItemSortingLayer PotionsBuffs;

			// Token: 0x04008F5D RID: 36701
			[Token(Token = "0x4008F5D")]
			[FieldOffset(Offset = "0x80")]
			public static ItemSorting.ItemSortingLayer PotionsFood;

			// Token: 0x04008F5E RID: 36702
			[Token(Token = "0x4008F5E")]
			[FieldOffset(Offset = "0x84")]
			public static ItemSorting.ItemSortingLayer PotionsDyes;

			// Token: 0x04008F5F RID: 36703
			[Token(Token = "0x4008F5F")]
			[FieldOffset(Offset = "0x88")]
			public static ItemSorting.ItemSortingLayer PotionsHairDyes;

			// Token: 0x04008F60 RID: 36704
			[Token(Token = "0x4008F60")]
			[FieldOffset(Offset = "0x8C")]
			public static ItemSorting.ItemSortingLayer MiscValuables;

			// Token: 0x04008F61 RID: 36705
			[Token(Token = "0x4008F61")]
			[FieldOffset(Offset = "0x90")]
			public static ItemSorting.ItemSortingLayer MiscWiring;

			// Token: 0x04008F62 RID: 36706
			[Token(Token = "0x4008F62")]
			[FieldOffset(Offset = "0x94")]
			public static ItemSorting.ItemSortingLayer MiscMaterials;

			// Token: 0x04008F63 RID: 36707
			[Token(Token = "0x4008F63")]
			[FieldOffset(Offset = "0x98")]
			public static ItemSorting.ItemSortingLayer MiscJustTheGlowingMushroom;

			// Token: 0x04008F64 RID: 36708
			[Token(Token = "0x4008F64")]
			[FieldOffset(Offset = "0x9C")]
			public static ItemSorting.ItemSortingLayer MiscExtractinator;

			// Token: 0x04008F65 RID: 36709
			[Token(Token = "0x4008F65")]
			[FieldOffset(Offset = "0xA0")]
			public static ItemSorting.ItemSortingLayer MiscPainting;

			// Token: 0x04008F66 RID: 36710
			[Token(Token = "0x4008F66")]
			[FieldOffset(Offset = "0xA4")]
			public static ItemSorting.ItemSortingLayer MiscRopes;

			// Token: 0x04008F67 RID: 36711
			[Token(Token = "0x4008F67")]
			[FieldOffset(Offset = "0xA8")]
			public static ItemSorting.ItemSortingLayer MiscHerbsAndSeeds;

			// Token: 0x04008F68 RID: 36712
			[Token(Token = "0x4008F68")]
			[FieldOffset(Offset = "0xAC")]
			public static ItemSorting.ItemSortingLayer MiscGems;

			// Token: 0x04008F69 RID: 36713
			[Token(Token = "0x4008F69")]
			[FieldOffset(Offset = "0xB0")]
			public static ItemSorting.ItemSortingLayer MiscAcorns;

			// Token: 0x04008F6A RID: 36714
			[Token(Token = "0x4008F6A")]
			[FieldOffset(Offset = "0xB4")]
			public static ItemSorting.ItemSortingLayer MiscBossBags;

			// Token: 0x04008F6B RID: 36715
			[Token(Token = "0x4008F6B")]
			[FieldOffset(Offset = "0xB8")]
			public static ItemSorting.ItemSortingLayer MiscCritters;

			// Token: 0x04008F6C RID: 36716
			[Token(Token = "0x4008F6C")]
			[FieldOffset(Offset = "0xBC")]
			public static ItemSorting.ItemSortingLayer LastMaterials;

			// Token: 0x04008F6D RID: 36717
			[Token(Token = "0x4008F6D")]
			[FieldOffset(Offset = "0xC0")]
			public static ItemSorting.ItemSortingLayer LastTilesImportant;

			// Token: 0x04008F6E RID: 36718
			[Token(Token = "0x4008F6E")]
			[FieldOffset(Offset = "0xC4")]
			public static ItemSorting.ItemSortingLayer LastTilesCommon;

			// Token: 0x04008F6F RID: 36719
			[Token(Token = "0x4008F6F")]
			[FieldOffset(Offset = "0xC8")]
			public static ItemSorting.ItemSortingLayer LastNotTrash;

			// Token: 0x04008F70 RID: 36720
			[Token(Token = "0x4008F70")]
			[FieldOffset(Offset = "0xCC")]
			public static ItemSorting.ItemSortingLayer LastTrash;

			// Token: 0x0200084B RID: 2123
			[Token(Token = "0x200084B")]
			private sealed class <>c__DisplayClass0_0
			{
				// Token: 0x0600494B RID: 18763 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600494B")]
				[Address(RVA = "0x604E18", Offset = "0x604E18", VA = "0x604E18")]
				public <>c__DisplayClass0_0()
				{
				}

				// Token: 0x0600494C RID: 18764 RVA: 0x00022D88 File Offset: 0x00020F88
				[Token(Token = "0x600494C")]
				[Address(RVA = "0x60725C", Offset = "0x60725C", VA = "0x60725C")]
				internal int <SortIndicesStable>b__0(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F71 RID: 36721
				[Token(Token = "0x4008F71")]
				[FieldOffset(Offset = "0x8")]
				public Comparison<int> comparison;
			}

			// Token: 0x0200084C RID: 2124
			[Token(Token = "0x200084C")]
			private sealed class <>c__DisplayClass55_0
			{
				// Token: 0x0600494D RID: 18765 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600494D")]
				[Address(RVA = "0x6072C0", Offset = "0x6072C0", VA = "0x6072C0")]
				public <>c__DisplayClass55_0()
				{
				}

				// Token: 0x0600494E RID: 18766 RVA: 0x00022DA0 File Offset: 0x00020FA0
				[Token(Token = "0x600494E")]
				[Address(RVA = "0x6072C8", Offset = "0x6072C8", VA = "0x6072C8")]
				internal bool <.cctor>b__52(int i)
				{
					return default(bool);
				}

				// Token: 0x0600494F RID: 18767 RVA: 0x00022DB8 File Offset: 0x00020FB8
				[Token(Token = "0x600494F")]
				[Address(RVA = "0x60743C", Offset = "0x60743C", VA = "0x60743C")]
				internal int <.cctor>b__53(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F72 RID: 36722
				[Token(Token = "0x4008F72")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x0200084D RID: 2125
			[Token(Token = "0x200084D")]
			private sealed class <>c__DisplayClass55_1
			{
				// Token: 0x06004950 RID: 18768 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004950")]
				[Address(RVA = "0x607558", Offset = "0x607558", VA = "0x607558")]
				public <>c__DisplayClass55_1()
				{
				}

				// Token: 0x06004951 RID: 18769 RVA: 0x00022DD0 File Offset: 0x00020FD0
				[Token(Token = "0x6004951")]
				[Address(RVA = "0x607560", Offset = "0x607560", VA = "0x607560")]
				internal bool <.cctor>b__54(int i)
				{
					return default(bool);
				}

				// Token: 0x06004952 RID: 18770 RVA: 0x00022DE8 File Offset: 0x00020FE8
				[Token(Token = "0x6004952")]
				[Address(RVA = "0x607710", Offset = "0x607710", VA = "0x607710")]
				internal int <.cctor>b__55(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F73 RID: 36723
				[Token(Token = "0x4008F73")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x0200084E RID: 2126
			[Token(Token = "0x200084E")]
			private sealed class <>c__DisplayClass55_2
			{
				// Token: 0x06004953 RID: 18771 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004953")]
				[Address(RVA = "0x607970", Offset = "0x607970", VA = "0x607970")]
				public <>c__DisplayClass55_2()
				{
				}

				// Token: 0x06004954 RID: 18772 RVA: 0x00022E00 File Offset: 0x00021000
				[Token(Token = "0x6004954")]
				[Address(RVA = "0x607978", Offset = "0x607978", VA = "0x607978")]
				internal bool <.cctor>b__56(int i)
				{
					return default(bool);
				}

				// Token: 0x06004955 RID: 18773 RVA: 0x00022E18 File Offset: 0x00021018
				[Token(Token = "0x6004955")]
				[Address(RVA = "0x607A58", Offset = "0x607A58", VA = "0x607A58")]
				internal int <.cctor>b__57(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F74 RID: 36724
				[Token(Token = "0x4008F74")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x0200084F RID: 2127
			[Token(Token = "0x200084F")]
			private sealed class <>c__DisplayClass55_3
			{
				// Token: 0x06004956 RID: 18774 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004956")]
				[Address(RVA = "0x607B74", Offset = "0x607B74", VA = "0x607B74")]
				public <>c__DisplayClass55_3()
				{
				}

				// Token: 0x06004957 RID: 18775 RVA: 0x00022E30 File Offset: 0x00021030
				[Token(Token = "0x6004957")]
				[Address(RVA = "0x607B7C", Offset = "0x607B7C", VA = "0x607B7C")]
				internal bool <.cctor>b__58(int i)
				{
					return default(bool);
				}

				// Token: 0x06004958 RID: 18776 RVA: 0x00022E48 File Offset: 0x00021048
				[Token(Token = "0x6004958")]
				[Address(RVA = "0x607C2C", Offset = "0x607C2C", VA = "0x607C2C")]
				internal int <.cctor>b__59(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F75 RID: 36725
				[Token(Token = "0x4008F75")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x02000850 RID: 2128
			[Token(Token = "0x2000850")]
			private sealed class <>c__DisplayClass55_4
			{
				// Token: 0x06004959 RID: 18777 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004959")]
				[Address(RVA = "0x607D48", Offset = "0x607D48", VA = "0x607D48")]
				public <>c__DisplayClass55_4()
				{
				}

				// Token: 0x0600495A RID: 18778 RVA: 0x00022E60 File Offset: 0x00021060
				[Token(Token = "0x600495A")]
				[Address(RVA = "0x607D50", Offset = "0x607D50", VA = "0x607D50")]
				internal bool <.cctor>b__60(int i)
				{
					return default(bool);
				}

				// Token: 0x0600495B RID: 18779 RVA: 0x00022E78 File Offset: 0x00021078
				[Token(Token = "0x600495B")]
				[Address(RVA = "0x607E60", Offset = "0x607E60", VA = "0x607E60")]
				internal int <.cctor>b__61(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F76 RID: 36726
				[Token(Token = "0x4008F76")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x02000851 RID: 2129
			[Token(Token = "0x2000851")]
			private sealed class <>c__DisplayClass55_5
			{
				// Token: 0x0600495C RID: 18780 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600495C")]
				[Address(RVA = "0x607F7C", Offset = "0x607F7C", VA = "0x607F7C")]
				public <>c__DisplayClass55_5()
				{
				}

				// Token: 0x0600495D RID: 18781 RVA: 0x00022E90 File Offset: 0x00021090
				[Token(Token = "0x600495D")]
				[Address(RVA = "0x607F84", Offset = "0x607F84", VA = "0x607F84")]
				internal bool <.cctor>b__62(int i)
				{
					return default(bool);
				}

				// Token: 0x0600495E RID: 18782 RVA: 0x00022EA8 File Offset: 0x000210A8
				[Token(Token = "0x600495E")]
				[Address(RVA = "0x608000", Offset = "0x608000", VA = "0x608000")]
				internal int <.cctor>b__63(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F77 RID: 36727
				[Token(Token = "0x4008F77")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x02000852 RID: 2130
			[Token(Token = "0x2000852")]
			private sealed class <>c__DisplayClass55_6
			{
				// Token: 0x0600495F RID: 18783 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600495F")]
				[Address(RVA = "0x60811C", Offset = "0x60811C", VA = "0x60811C")]
				public <>c__DisplayClass55_6()
				{
				}

				// Token: 0x06004960 RID: 18784 RVA: 0x00022EC0 File Offset: 0x000210C0
				[Token(Token = "0x6004960")]
				[Address(RVA = "0x608124", Offset = "0x608124", VA = "0x608124")]
				internal bool <.cctor>b__64(int i)
				{
					return default(bool);
				}

				// Token: 0x06004961 RID: 18785 RVA: 0x00022ED8 File Offset: 0x000210D8
				[Token(Token = "0x6004961")]
				[Address(RVA = "0x6081A0", Offset = "0x6081A0", VA = "0x6081A0")]
				internal int <.cctor>b__65(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F78 RID: 36728
				[Token(Token = "0x4008F78")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x02000853 RID: 2131
			[Token(Token = "0x2000853")]
			private sealed class <>c__DisplayClass55_7
			{
				// Token: 0x06004962 RID: 18786 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004962")]
				[Address(RVA = "0x608210", Offset = "0x608210", VA = "0x608210")]
				public <>c__DisplayClass55_7()
				{
				}

				// Token: 0x06004963 RID: 18787 RVA: 0x00022EF0 File Offset: 0x000210F0
				[Token(Token = "0x6004963")]
				[Address(RVA = "0x608218", Offset = "0x608218", VA = "0x608218")]
				internal bool <.cctor>b__66(int i)
				{
					return default(bool);
				}

				// Token: 0x06004964 RID: 18788 RVA: 0x00022F08 File Offset: 0x00021108
				[Token(Token = "0x6004964")]
				[Address(RVA = "0x608294", Offset = "0x608294", VA = "0x608294")]
				internal int <.cctor>b__67(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F79 RID: 36729
				[Token(Token = "0x4008F79")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x02000854 RID: 2132
			[Token(Token = "0x2000854")]
			private sealed class <>c__DisplayClass55_8
			{
				// Token: 0x06004965 RID: 18789 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004965")]
				[Address(RVA = "0x608304", Offset = "0x608304", VA = "0x608304")]
				public <>c__DisplayClass55_8()
				{
				}

				// Token: 0x06004966 RID: 18790 RVA: 0x00022F20 File Offset: 0x00021120
				[Token(Token = "0x6004966")]
				[Address(RVA = "0x60830C", Offset = "0x60830C", VA = "0x60830C")]
				internal bool <.cctor>b__68(int i)
				{
					return default(bool);
				}

				// Token: 0x06004967 RID: 18791 RVA: 0x00022F38 File Offset: 0x00021138
				[Token(Token = "0x6004967")]
				[Address(RVA = "0x60834C", Offset = "0x60834C", VA = "0x60834C")]
				internal int <.cctor>b__69(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F7A RID: 36730
				[Token(Token = "0x4008F7A")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x02000855 RID: 2133
			[Token(Token = "0x2000855")]
			private sealed class <>c__DisplayClass55_9
			{
				// Token: 0x06004968 RID: 18792 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004968")]
				[Address(RVA = "0x6083BC", Offset = "0x6083BC", VA = "0x6083BC")]
				public <>c__DisplayClass55_9()
				{
				}

				// Token: 0x06004969 RID: 18793 RVA: 0x00022F50 File Offset: 0x00021150
				[Token(Token = "0x6004969")]
				[Address(RVA = "0x6083C4", Offset = "0x6083C4", VA = "0x6083C4")]
				internal bool <.cctor>b__70(int i)
				{
					return default(bool);
				}

				// Token: 0x0600496A RID: 18794 RVA: 0x00022F68 File Offset: 0x00021168
				[Token(Token = "0x600496A")]
				[Address(RVA = "0x608404", Offset = "0x608404", VA = "0x608404")]
				internal int <.cctor>b__71(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F7B RID: 36731
				[Token(Token = "0x4008F7B")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x02000856 RID: 2134
			[Token(Token = "0x2000856")]
			private sealed class <>c__DisplayClass55_10
			{
				// Token: 0x0600496B RID: 18795 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600496B")]
				[Address(RVA = "0x608474", Offset = "0x608474", VA = "0x608474")]
				public <>c__DisplayClass55_10()
				{
				}

				// Token: 0x0600496C RID: 18796 RVA: 0x00022F80 File Offset: 0x00021180
				[Token(Token = "0x600496C")]
				[Address(RVA = "0x60847C", Offset = "0x60847C", VA = "0x60847C")]
				internal bool <.cctor>b__72(int i)
				{
					return default(bool);
				}

				// Token: 0x0600496D RID: 18797 RVA: 0x00022F98 File Offset: 0x00021198
				[Token(Token = "0x600496D")]
				[Address(RVA = "0x6084BC", Offset = "0x6084BC", VA = "0x6084BC")]
				internal int <.cctor>b__73(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F7C RID: 36732
				[Token(Token = "0x4008F7C")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x02000857 RID: 2135
			[Token(Token = "0x2000857")]
			private sealed class <>c__DisplayClass55_11
			{
				// Token: 0x0600496E RID: 18798 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600496E")]
				[Address(RVA = "0x60852C", Offset = "0x60852C", VA = "0x60852C")]
				public <>c__DisplayClass55_11()
				{
				}

				// Token: 0x0600496F RID: 18799 RVA: 0x00022FB0 File Offset: 0x000211B0
				[Token(Token = "0x600496F")]
				[Address(RVA = "0x608534", Offset = "0x608534", VA = "0x608534")]
				internal bool <.cctor>b__74(int i)
				{
					return default(bool);
				}

				// Token: 0x06004970 RID: 18800 RVA: 0x00022FC8 File Offset: 0x000211C8
				[Token(Token = "0x6004970")]
				[Address(RVA = "0x608620", Offset = "0x608620", VA = "0x608620")]
				internal int <.cctor>b__75(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F7D RID: 36733
				[Token(Token = "0x4008F7D")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x02000858 RID: 2136
			[Token(Token = "0x2000858")]
			private sealed class <>c__DisplayClass55_12
			{
				// Token: 0x06004971 RID: 18801 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004971")]
				[Address(RVA = "0x608784", Offset = "0x608784", VA = "0x608784")]
				public <>c__DisplayClass55_12()
				{
				}

				// Token: 0x06004972 RID: 18802 RVA: 0x00022FE0 File Offset: 0x000211E0
				[Token(Token = "0x6004972")]
				[Address(RVA = "0x60878C", Offset = "0x60878C", VA = "0x60878C")]
				internal bool <.cctor>b__76(int i)
				{
					return default(bool);
				}

				// Token: 0x06004973 RID: 18803 RVA: 0x00022FF8 File Offset: 0x000211F8
				[Token(Token = "0x6004973")]
				[Address(RVA = "0x6089E4", Offset = "0x6089E4", VA = "0x6089E4")]
				internal int <.cctor>b__77(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F7E RID: 36734
				[Token(Token = "0x4008F7E")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x02000859 RID: 2137
			[Token(Token = "0x2000859")]
			private sealed class <>c__DisplayClass55_13
			{
				// Token: 0x06004974 RID: 18804 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004974")]
				[Address(RVA = "0x608FAC", Offset = "0x608FAC", VA = "0x608FAC")]
				public <>c__DisplayClass55_13()
				{
				}

				// Token: 0x06004975 RID: 18805 RVA: 0x00023010 File Offset: 0x00021210
				[Token(Token = "0x6004975")]
				[Address(RVA = "0x608FB4", Offset = "0x608FB4", VA = "0x608FB4")]
				internal bool <.cctor>b__78(int i)
				{
					return default(bool);
				}

				// Token: 0x06004976 RID: 18806 RVA: 0x00023028 File Offset: 0x00021228
				[Token(Token = "0x6004976")]
				[Address(RVA = "0x6090A0", Offset = "0x6090A0", VA = "0x6090A0")]
				internal int <.cctor>b__79(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F7F RID: 36735
				[Token(Token = "0x4008F7F")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x0200085A RID: 2138
			[Token(Token = "0x200085A")]
			private sealed class <>c__DisplayClass55_14
			{
				// Token: 0x06004977 RID: 18807 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004977")]
				[Address(RVA = "0x609294", Offset = "0x609294", VA = "0x609294")]
				public <>c__DisplayClass55_14()
				{
				}

				// Token: 0x06004978 RID: 18808 RVA: 0x00023040 File Offset: 0x00021240
				[Token(Token = "0x6004978")]
				[Address(RVA = "0x60929C", Offset = "0x60929C", VA = "0x60929C")]
				internal bool <.cctor>b__80(int i)
				{
					return default(bool);
				}

				// Token: 0x06004979 RID: 18809 RVA: 0x00023058 File Offset: 0x00021258
				[Token(Token = "0x6004979")]
				[Address(RVA = "0x609388", Offset = "0x609388", VA = "0x609388")]
				internal int <.cctor>b__81(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F80 RID: 36736
				[Token(Token = "0x4008F80")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x0200085B RID: 2139
			[Token(Token = "0x200085B")]
			private sealed class <>c__DisplayClass55_15
			{
				// Token: 0x0600497A RID: 18810 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600497A")]
				[Address(RVA = "0x60957C", Offset = "0x60957C", VA = "0x60957C")]
				public <>c__DisplayClass55_15()
				{
				}

				// Token: 0x0600497B RID: 18811 RVA: 0x00023070 File Offset: 0x00021270
				[Token(Token = "0x600497B")]
				[Address(RVA = "0x609584", Offset = "0x609584", VA = "0x609584")]
				internal bool <.cctor>b__82(int i)
				{
					return default(bool);
				}

				// Token: 0x0600497C RID: 18812 RVA: 0x00023088 File Offset: 0x00021288
				[Token(Token = "0x600497C")]
				[Address(RVA = "0x609670", Offset = "0x609670", VA = "0x609670")]
				internal int <.cctor>b__83(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F81 RID: 36737
				[Token(Token = "0x4008F81")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x0200085C RID: 2140
			[Token(Token = "0x200085C")]
			private sealed class <>c__DisplayClass55_16
			{
				// Token: 0x0600497D RID: 18813 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600497D")]
				[Address(RVA = "0x609864", Offset = "0x609864", VA = "0x609864")]
				public <>c__DisplayClass55_16()
				{
				}

				// Token: 0x0600497E RID: 18814 RVA: 0x000230A0 File Offset: 0x000212A0
				[Token(Token = "0x600497E")]
				[Address(RVA = "0x60986C", Offset = "0x60986C", VA = "0x60986C")]
				internal bool <.cctor>b__84(int i)
				{
					return default(bool);
				}

				// Token: 0x0600497F RID: 18815 RVA: 0x000230B8 File Offset: 0x000212B8
				[Token(Token = "0x600497F")]
				[Address(RVA = "0x609958", Offset = "0x609958", VA = "0x609958")]
				internal int <.cctor>b__85(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F82 RID: 36738
				[Token(Token = "0x4008F82")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x0200085D RID: 2141
			[Token(Token = "0x200085D")]
			private sealed class <>c__DisplayClass55_17
			{
				// Token: 0x06004980 RID: 18816 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004980")]
				[Address(RVA = "0x609B4C", Offset = "0x609B4C", VA = "0x609B4C")]
				public <>c__DisplayClass55_17()
				{
				}

				// Token: 0x06004981 RID: 18817 RVA: 0x000230D0 File Offset: 0x000212D0
				[Token(Token = "0x6004981")]
				[Address(RVA = "0x609B54", Offset = "0x609B54", VA = "0x609B54")]
				internal bool <.cctor>b__86(int i)
				{
					return default(bool);
				}

				// Token: 0x06004982 RID: 18818 RVA: 0x000230E8 File Offset: 0x000212E8
				[Token(Token = "0x6004982")]
				[Address(RVA = "0x609D10", Offset = "0x609D10", VA = "0x609D10")]
				internal int <.cctor>b__87(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F83 RID: 36739
				[Token(Token = "0x4008F83")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x0200085E RID: 2142
			[Token(Token = "0x200085E")]
			private sealed class <>c__DisplayClass55_18
			{
				// Token: 0x06004983 RID: 18819 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004983")]
				[Address(RVA = "0x609E2C", Offset = "0x609E2C", VA = "0x609E2C")]
				public <>c__DisplayClass55_18()
				{
				}

				// Token: 0x06004984 RID: 18820 RVA: 0x00023100 File Offset: 0x00021300
				[Token(Token = "0x6004984")]
				[Address(RVA = "0x609E34", Offset = "0x609E34", VA = "0x609E34")]
				internal bool <.cctor>b__88(int i)
				{
					return default(bool);
				}

				// Token: 0x06004985 RID: 18821 RVA: 0x00023118 File Offset: 0x00021318
				[Token(Token = "0x6004985")]
				[Address(RVA = "0x609F20", Offset = "0x609F20", VA = "0x609F20")]
				internal int <.cctor>b__89(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F84 RID: 36740
				[Token(Token = "0x4008F84")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x0200085F RID: 2143
			[Token(Token = "0x200085F")]
			private sealed class <>c__DisplayClass55_19
			{
				// Token: 0x06004986 RID: 18822 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004986")]
				[Address(RVA = "0x60A114", Offset = "0x60A114", VA = "0x60A114")]
				public <>c__DisplayClass55_19()
				{
				}

				// Token: 0x06004987 RID: 18823 RVA: 0x00023130 File Offset: 0x00021330
				[Token(Token = "0x6004987")]
				[Address(RVA = "0x60A11C", Offset = "0x60A11C", VA = "0x60A11C")]
				internal bool <.cctor>b__90(int i)
				{
					return default(bool);
				}

				// Token: 0x06004988 RID: 18824 RVA: 0x00023148 File Offset: 0x00021348
				[Token(Token = "0x6004988")]
				[Address(RVA = "0x60A1F4", Offset = "0x60A1F4", VA = "0x60A1F4")]
				internal int <.cctor>b__91(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F85 RID: 36741
				[Token(Token = "0x4008F85")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x02000860 RID: 2144
			[Token(Token = "0x2000860")]
			private sealed class <>c__DisplayClass55_20
			{
				// Token: 0x06004989 RID: 18825 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004989")]
				[Address(RVA = "0x60A374", Offset = "0x60A374", VA = "0x60A374")]
				public <>c__DisplayClass55_20()
				{
				}

				// Token: 0x0600498A RID: 18826 RVA: 0x00023160 File Offset: 0x00021360
				[Token(Token = "0x600498A")]
				[Address(RVA = "0x60A37C", Offset = "0x60A37C", VA = "0x60A37C")]
				internal bool <.cctor>b__92(int i)
				{
					return default(bool);
				}

				// Token: 0x0600498B RID: 18827 RVA: 0x00023178 File Offset: 0x00021378
				[Token(Token = "0x600498B")]
				[Address(RVA = "0x60A454", Offset = "0x60A454", VA = "0x60A454")]
				internal int <.cctor>b__93(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F86 RID: 36742
				[Token(Token = "0x4008F86")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x02000861 RID: 2145
			[Token(Token = "0x2000861")]
			private sealed class <>c__DisplayClass55_21
			{
				// Token: 0x0600498C RID: 18828 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600498C")]
				[Address(RVA = "0x60A558", Offset = "0x60A558", VA = "0x60A558")]
				public <>c__DisplayClass55_21()
				{
				}

				// Token: 0x0600498D RID: 18829 RVA: 0x00023190 File Offset: 0x00021390
				[Token(Token = "0x600498D")]
				[Address(RVA = "0x60A560", Offset = "0x60A560", VA = "0x60A560")]
				internal bool <.cctor>b__94(int i)
				{
					return default(bool);
				}

				// Token: 0x0600498E RID: 18830 RVA: 0x000231A8 File Offset: 0x000213A8
				[Token(Token = "0x600498E")]
				[Address(RVA = "0x60A59C", Offset = "0x60A59C", VA = "0x60A59C")]
				internal int <.cctor>b__95(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F87 RID: 36743
				[Token(Token = "0x4008F87")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x02000862 RID: 2146
			[Token(Token = "0x2000862")]
			private sealed class <>c__DisplayClass55_22
			{
				// Token: 0x0600498F RID: 18831 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600498F")]
				[Address(RVA = "0x60A7E0", Offset = "0x60A7E0", VA = "0x60A7E0")]
				public <>c__DisplayClass55_22()
				{
				}

				// Token: 0x06004990 RID: 18832 RVA: 0x000231C0 File Offset: 0x000213C0
				[Token(Token = "0x6004990")]
				[Address(RVA = "0x60A7E8", Offset = "0x60A7E8", VA = "0x60A7E8")]
				internal bool <.cctor>b__96(int i)
				{
					return default(bool);
				}

				// Token: 0x06004991 RID: 18833 RVA: 0x000231D8 File Offset: 0x000213D8
				[Token(Token = "0x6004991")]
				[Address(RVA = "0x60A890", Offset = "0x60A890", VA = "0x60A890")]
				internal int <.cctor>b__97(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F88 RID: 36744
				[Token(Token = "0x4008F88")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x02000863 RID: 2147
			[Token(Token = "0x2000863")]
			private sealed class <>c__DisplayClass55_23
			{
				// Token: 0x06004992 RID: 18834 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004992")]
				[Address(RVA = "0x60A994", Offset = "0x60A994", VA = "0x60A994")]
				public <>c__DisplayClass55_23()
				{
				}

				// Token: 0x06004993 RID: 18835 RVA: 0x000231F0 File Offset: 0x000213F0
				[Token(Token = "0x6004993")]
				[Address(RVA = "0x60A99C", Offset = "0x60A99C", VA = "0x60A99C")]
				internal bool <.cctor>b__98(int i)
				{
					return default(bool);
				}

				// Token: 0x06004994 RID: 18836 RVA: 0x00023208 File Offset: 0x00021408
				[Token(Token = "0x6004994")]
				[Address(RVA = "0x60AA84", Offset = "0x60AA84", VA = "0x60AA84")]
				internal int <.cctor>b__99(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F89 RID: 36745
				[Token(Token = "0x4008F89")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x02000864 RID: 2148
			[Token(Token = "0x2000864")]
			private sealed class <>c__DisplayClass55_24
			{
				// Token: 0x06004995 RID: 18837 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004995")]
				[Address(RVA = "0x60AB88", Offset = "0x60AB88", VA = "0x60AB88")]
				public <>c__DisplayClass55_24()
				{
				}

				// Token: 0x06004996 RID: 18838 RVA: 0x00023220 File Offset: 0x00021420
				[Token(Token = "0x6004996")]
				[Address(RVA = "0x60AB90", Offset = "0x60AB90", VA = "0x60AB90")]
				internal bool <.cctor>b__100(int i)
				{
					return default(bool);
				}

				// Token: 0x06004997 RID: 18839 RVA: 0x00023238 File Offset: 0x00021438
				[Token(Token = "0x6004997")]
				[Address(RVA = "0x60AC78", Offset = "0x60AC78", VA = "0x60AC78")]
				internal int <.cctor>b__101(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F8A RID: 36746
				[Token(Token = "0x4008F8A")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x02000865 RID: 2149
			[Token(Token = "0x2000865")]
			private sealed class <>c__DisplayClass55_25
			{
				// Token: 0x06004998 RID: 18840 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004998")]
				[Address(RVA = "0x60AD7C", Offset = "0x60AD7C", VA = "0x60AD7C")]
				public <>c__DisplayClass55_25()
				{
				}

				// Token: 0x06004999 RID: 18841 RVA: 0x00023250 File Offset: 0x00021450
				[Token(Token = "0x6004999")]
				[Address(RVA = "0x60AD84", Offset = "0x60AD84", VA = "0x60AD84")]
				internal bool <.cctor>b__102(int i)
				{
					return default(bool);
				}

				// Token: 0x0600499A RID: 18842 RVA: 0x00023268 File Offset: 0x00021468
				[Token(Token = "0x600499A")]
				[Address(RVA = "0x60AE6C", Offset = "0x60AE6C", VA = "0x60AE6C")]
				internal int <.cctor>b__103(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F8B RID: 36747
				[Token(Token = "0x4008F8B")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x02000866 RID: 2150
			[Token(Token = "0x2000866")]
			private sealed class <>c__DisplayClass55_26
			{
				// Token: 0x0600499B RID: 18843 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600499B")]
				[Address(RVA = "0x60AF70", Offset = "0x60AF70", VA = "0x60AF70")]
				public <>c__DisplayClass55_26()
				{
				}

				// Token: 0x0600499C RID: 18844 RVA: 0x00023280 File Offset: 0x00021480
				[Token(Token = "0x600499C")]
				[Address(RVA = "0x60AF78", Offset = "0x60AF78", VA = "0x60AF78")]
				internal bool <.cctor>b__104(int i)
				{
					return default(bool);
				}

				// Token: 0x0600499D RID: 18845 RVA: 0x00023298 File Offset: 0x00021498
				[Token(Token = "0x600499D")]
				[Address(RVA = "0x60B060", Offset = "0x60B060", VA = "0x60B060")]
				internal int <.cctor>b__105(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F8C RID: 36748
				[Token(Token = "0x4008F8C")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x02000867 RID: 2151
			[Token(Token = "0x2000867")]
			private sealed class <>c__DisplayClass55_27
			{
				// Token: 0x0600499E RID: 18846 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600499E")]
				[Address(RVA = "0x60B164", Offset = "0x60B164", VA = "0x60B164")]
				public <>c__DisplayClass55_27()
				{
				}

				// Token: 0x0600499F RID: 18847 RVA: 0x000232B0 File Offset: 0x000214B0
				[Token(Token = "0x600499F")]
				[Address(RVA = "0x60B16C", Offset = "0x60B16C", VA = "0x60B16C")]
				internal bool <.cctor>b__106(int i)
				{
					return default(bool);
				}

				// Token: 0x060049A0 RID: 18848 RVA: 0x000232C8 File Offset: 0x000214C8
				[Token(Token = "0x60049A0")]
				[Address(RVA = "0x60B24C", Offset = "0x60B24C", VA = "0x60B24C")]
				internal int <.cctor>b__107(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F8D RID: 36749
				[Token(Token = "0x4008F8D")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x02000868 RID: 2152
			[Token(Token = "0x2000868")]
			private sealed class <>c__DisplayClass55_28
			{
				// Token: 0x060049A1 RID: 18849 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60049A1")]
				[Address(RVA = "0x60B324", Offset = "0x60B324", VA = "0x60B324")]
				public <>c__DisplayClass55_28()
				{
				}

				// Token: 0x060049A2 RID: 18850 RVA: 0x000232E0 File Offset: 0x000214E0
				[Token(Token = "0x60049A2")]
				[Address(RVA = "0x60B32C", Offset = "0x60B32C", VA = "0x60B32C")]
				internal bool <.cctor>b__108(int i)
				{
					return default(bool);
				}

				// Token: 0x060049A3 RID: 18851 RVA: 0x000232F8 File Offset: 0x000214F8
				[Token(Token = "0x60049A3")]
				[Address(RVA = "0x60B36C", Offset = "0x60B36C", VA = "0x60B36C")]
				internal int <.cctor>b__109(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F8E RID: 36750
				[Token(Token = "0x4008F8E")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x02000869 RID: 2153
			[Token(Token = "0x2000869")]
			private sealed class <>c__DisplayClass55_29
			{
				// Token: 0x060049A4 RID: 18852 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60049A4")]
				[Address(RVA = "0x60B3DC", Offset = "0x60B3DC", VA = "0x60B3DC")]
				public <>c__DisplayClass55_29()
				{
				}

				// Token: 0x060049A5 RID: 18853 RVA: 0x00023310 File Offset: 0x00021510
				[Token(Token = "0x60049A5")]
				[Address(RVA = "0x60B3E4", Offset = "0x60B3E4", VA = "0x60B3E4")]
				internal bool <.cctor>b__110(int i)
				{
					return default(bool);
				}

				// Token: 0x060049A6 RID: 18854 RVA: 0x00023328 File Offset: 0x00021528
				[Token(Token = "0x60049A6")]
				[Address(RVA = "0x60B498", Offset = "0x60B498", VA = "0x60B498")]
				internal int <.cctor>b__111(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F8F RID: 36751
				[Token(Token = "0x4008F8F")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x0200086A RID: 2154
			[Token(Token = "0x200086A")]
			private sealed class <>c__DisplayClass55_30
			{
				// Token: 0x060049A7 RID: 18855 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60049A7")]
				[Address(RVA = "0x60B570", Offset = "0x60B570", VA = "0x60B570")]
				public <>c__DisplayClass55_30()
				{
				}

				// Token: 0x060049A8 RID: 18856 RVA: 0x00023340 File Offset: 0x00021540
				[Token(Token = "0x60049A8")]
				[Address(RVA = "0x60B578", Offset = "0x60B578", VA = "0x60B578")]
				internal bool <.cctor>b__112(int i)
				{
					return default(bool);
				}

				// Token: 0x060049A9 RID: 18857 RVA: 0x00023358 File Offset: 0x00021558
				[Token(Token = "0x60049A9")]
				[Address(RVA = "0x60B624", Offset = "0x60B624", VA = "0x60B624")]
				internal int <.cctor>b__113(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F90 RID: 36752
				[Token(Token = "0x4008F90")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x0200086B RID: 2155
			[Token(Token = "0x200086B")]
			private sealed class <>c__DisplayClass55_31
			{
				// Token: 0x060049AA RID: 18858 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60049AA")]
				[Address(RVA = "0x60B6FC", Offset = "0x60B6FC", VA = "0x60B6FC")]
				public <>c__DisplayClass55_31()
				{
				}

				// Token: 0x060049AB RID: 18859 RVA: 0x00023370 File Offset: 0x00021570
				[Token(Token = "0x60049AB")]
				[Address(RVA = "0x60B704", Offset = "0x60B704", VA = "0x60B704")]
				internal bool <.cctor>b__114(int i)
				{
					return default(bool);
				}

				// Token: 0x060049AC RID: 18860 RVA: 0x00023388 File Offset: 0x00021588
				[Token(Token = "0x60049AC")]
				[Address(RVA = "0x60B92C", Offset = "0x60B92C", VA = "0x60B92C")]
				internal int <.cctor>b__115(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F91 RID: 36753
				[Token(Token = "0x4008F91")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x0200086C RID: 2156
			[Token(Token = "0x200086C")]
			private sealed class <>c__DisplayClass55_32
			{
				// Token: 0x060049AD RID: 18861 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60049AD")]
				[Address(RVA = "0x60BBD8", Offset = "0x60BBD8", VA = "0x60BBD8")]
				public <>c__DisplayClass55_32()
				{
				}

				// Token: 0x060049AE RID: 18862 RVA: 0x000233A0 File Offset: 0x000215A0
				[Token(Token = "0x60049AE")]
				[Address(RVA = "0x60BBE0", Offset = "0x60BBE0", VA = "0x60BBE0")]
				internal bool <.cctor>b__116(int i)
				{
					return default(bool);
				}

				// Token: 0x060049AF RID: 18863 RVA: 0x000233B8 File Offset: 0x000215B8
				[Token(Token = "0x60049AF")]
				[Address(RVA = "0x60BD5C", Offset = "0x60BD5C", VA = "0x60BD5C")]
				internal int <.cctor>b__117(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F92 RID: 36754
				[Token(Token = "0x4008F92")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x0200086D RID: 2157
			[Token(Token = "0x200086D")]
			private sealed class <>c__DisplayClass55_33
			{
				// Token: 0x060049B0 RID: 18864 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60049B0")]
				[Address(RVA = "0x60C014", Offset = "0x60C014", VA = "0x60C014")]
				public <>c__DisplayClass55_33()
				{
				}

				// Token: 0x060049B1 RID: 18865 RVA: 0x000233D0 File Offset: 0x000215D0
				[Token(Token = "0x60049B1")]
				[Address(RVA = "0x60C01C", Offset = "0x60C01C", VA = "0x60C01C")]
				internal bool <.cctor>b__118(int i)
				{
					return default(bool);
				}

				// Token: 0x060049B2 RID: 18866 RVA: 0x000233E8 File Offset: 0x000215E8
				[Token(Token = "0x60049B2")]
				[Address(RVA = "0x60C13C", Offset = "0x60C13C", VA = "0x60C13C")]
				internal int <.cctor>b__119(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F93 RID: 36755
				[Token(Token = "0x4008F93")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x0200086E RID: 2158
			[Token(Token = "0x200086E")]
			private sealed class <>c__DisplayClass55_34
			{
				// Token: 0x060049B3 RID: 18867 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60049B3")]
				[Address(RVA = "0x60C3E4", Offset = "0x60C3E4", VA = "0x60C3E4")]
				public <>c__DisplayClass55_34()
				{
				}

				// Token: 0x060049B4 RID: 18868 RVA: 0x00023400 File Offset: 0x00021600
				[Token(Token = "0x60049B4")]
				[Address(RVA = "0x60C3EC", Offset = "0x60C3EC", VA = "0x60C3EC")]
				internal bool <.cctor>b__120(int i)
				{
					return default(bool);
				}

				// Token: 0x060049B5 RID: 18869 RVA: 0x00023418 File Offset: 0x00021618
				[Token(Token = "0x60049B5")]
				[Address(RVA = "0x60C42C", Offset = "0x60C42C", VA = "0x60C42C")]
				internal int <.cctor>b__121(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F94 RID: 36756
				[Token(Token = "0x4008F94")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x0200086F RID: 2159
			[Token(Token = "0x200086F")]
			private sealed class <>c__DisplayClass55_35
			{
				// Token: 0x060049B6 RID: 18870 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60049B6")]
				[Address(RVA = "0x60C594", Offset = "0x60C594", VA = "0x60C594")]
				public <>c__DisplayClass55_35()
				{
				}

				// Token: 0x060049B7 RID: 18871 RVA: 0x00023430 File Offset: 0x00021630
				[Token(Token = "0x60049B7")]
				[Address(RVA = "0x60C59C", Offset = "0x60C59C", VA = "0x60C59C")]
				internal bool <.cctor>b__122(int i)
				{
					return default(bool);
				}

				// Token: 0x060049B8 RID: 18872 RVA: 0x00023448 File Offset: 0x00021648
				[Token(Token = "0x60049B8")]
				[Address(RVA = "0x60C688", Offset = "0x60C688", VA = "0x60C688")]
				internal int <.cctor>b__123(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F95 RID: 36757
				[Token(Token = "0x4008F95")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x02000870 RID: 2160
			[Token(Token = "0x2000870")]
			private sealed class <>c__DisplayClass55_36
			{
				// Token: 0x060049B9 RID: 18873 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60049B9")]
				[Address(RVA = "0x60C7EC", Offset = "0x60C7EC", VA = "0x60C7EC")]
				public <>c__DisplayClass55_36()
				{
				}

				// Token: 0x060049BA RID: 18874 RVA: 0x00023460 File Offset: 0x00021660
				[Token(Token = "0x60049BA")]
				[Address(RVA = "0x60C7F4", Offset = "0x60C7F4", VA = "0x60C7F4")]
				internal bool <.cctor>b__124(int i)
				{
					return default(bool);
				}

				// Token: 0x060049BB RID: 18875 RVA: 0x00023478 File Offset: 0x00021678
				[Token(Token = "0x60049BB")]
				[Address(RVA = "0x60C90C", Offset = "0x60C90C", VA = "0x60C90C")]
				internal int <.cctor>b__125(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F96 RID: 36758
				[Token(Token = "0x4008F96")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x02000871 RID: 2161
			[Token(Token = "0x2000871")]
			private sealed class <>c__DisplayClass55_37
			{
				// Token: 0x060049BC RID: 18876 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60049BC")]
				[Address(RVA = "0x60CB64", Offset = "0x60CB64", VA = "0x60CB64")]
				public <>c__DisplayClass55_37()
				{
				}

				// Token: 0x060049BD RID: 18877 RVA: 0x00023490 File Offset: 0x00021690
				[Token(Token = "0x60049BD")]
				[Address(RVA = "0x60CB6C", Offset = "0x60CB6C", VA = "0x60CB6C")]
				internal bool <.cctor>b__126(int i)
				{
					return default(bool);
				}

				// Token: 0x060049BE RID: 18878 RVA: 0x000234A8 File Offset: 0x000216A8
				[Token(Token = "0x60049BE")]
				[Address(RVA = "0x60CC58", Offset = "0x60CC58", VA = "0x60CC58")]
				internal int <.cctor>b__127(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F97 RID: 36759
				[Token(Token = "0x4008F97")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x02000872 RID: 2162
			[Token(Token = "0x2000872")]
			private sealed class <>c__DisplayClass55_38
			{
				// Token: 0x060049BF RID: 18879 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60049BF")]
				[Address(RVA = "0x60CDBC", Offset = "0x60CDBC", VA = "0x60CDBC")]
				public <>c__DisplayClass55_38()
				{
				}

				// Token: 0x060049C0 RID: 18880 RVA: 0x000234C0 File Offset: 0x000216C0
				[Token(Token = "0x60049C0")]
				[Address(RVA = "0x60CDC4", Offset = "0x60CDC4", VA = "0x60CDC4")]
				internal bool <.cctor>b__128(int i)
				{
					return default(bool);
				}

				// Token: 0x060049C1 RID: 18881 RVA: 0x000234D8 File Offset: 0x000216D8
				[Token(Token = "0x60049C1")]
				[Address(RVA = "0x60CE04", Offset = "0x60CE04", VA = "0x60CE04")]
				internal int <.cctor>b__129(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F98 RID: 36760
				[Token(Token = "0x4008F98")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x02000873 RID: 2163
			[Token(Token = "0x2000873")]
			private sealed class <>c__DisplayClass55_39
			{
				// Token: 0x060049C2 RID: 18882 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60049C2")]
				[Address(RVA = "0x60CE74", Offset = "0x60CE74", VA = "0x60CE74")]
				public <>c__DisplayClass55_39()
				{
				}

				// Token: 0x060049C3 RID: 18883 RVA: 0x000234F0 File Offset: 0x000216F0
				[Token(Token = "0x60049C3")]
				[Address(RVA = "0x60CE7C", Offset = "0x60CE7C", VA = "0x60CE7C")]
				internal bool <.cctor>b__130(int i)
				{
					return default(bool);
				}

				// Token: 0x060049C4 RID: 18884 RVA: 0x00023508 File Offset: 0x00021708
				[Token(Token = "0x60049C4")]
				[Address(RVA = "0x60CF68", Offset = "0x60CF68", VA = "0x60CF68")]
				internal int <.cctor>b__131(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F99 RID: 36761
				[Token(Token = "0x4008F99")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x02000874 RID: 2164
			[Token(Token = "0x2000874")]
			private sealed class <>c__DisplayClass55_40
			{
				// Token: 0x060049C5 RID: 18885 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60049C5")]
				[Address(RVA = "0x60D0CC", Offset = "0x60D0CC", VA = "0x60D0CC")]
				public <>c__DisplayClass55_40()
				{
				}

				// Token: 0x060049C6 RID: 18886 RVA: 0x00023520 File Offset: 0x00021720
				[Token(Token = "0x60049C6")]
				[Address(RVA = "0x60D0D4", Offset = "0x60D0D4", VA = "0x60D0D4")]
				internal bool <.cctor>b__132(int i)
				{
					return default(bool);
				}

				// Token: 0x060049C7 RID: 18887 RVA: 0x00023538 File Offset: 0x00021738
				[Token(Token = "0x60049C7")]
				[Address(RVA = "0x60D1EC", Offset = "0x60D1EC", VA = "0x60D1EC")]
				internal int <.cctor>b__133(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F9A RID: 36762
				[Token(Token = "0x4008F9A")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x02000875 RID: 2165
			[Token(Token = "0x2000875")]
			private sealed class <>c__DisplayClass55_41
			{
				// Token: 0x060049C8 RID: 18888 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60049C8")]
				[Address(RVA = "0x60D418", Offset = "0x60D418", VA = "0x60D418")]
				public <>c__DisplayClass55_41()
				{
				}

				// Token: 0x060049C9 RID: 18889 RVA: 0x00023550 File Offset: 0x00021750
				[Token(Token = "0x60049C9")]
				[Address(RVA = "0x60D420", Offset = "0x60D420", VA = "0x60D420")]
				internal bool <.cctor>b__134(int i)
				{
					return default(bool);
				}

				// Token: 0x060049CA RID: 18890 RVA: 0x00023568 File Offset: 0x00021768
				[Token(Token = "0x60049CA")]
				[Address(RVA = "0x60D50C", Offset = "0x60D50C", VA = "0x60D50C")]
				internal int <.cctor>b__135(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F9B RID: 36763
				[Token(Token = "0x4008F9B")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x02000876 RID: 2166
			[Token(Token = "0x2000876")]
			private sealed class <>c__DisplayClass55_42
			{
				// Token: 0x060049CB RID: 18891 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60049CB")]
				[Address(RVA = "0x60D670", Offset = "0x60D670", VA = "0x60D670")]
				public <>c__DisplayClass55_42()
				{
				}

				// Token: 0x060049CC RID: 18892 RVA: 0x00023580 File Offset: 0x00021780
				[Token(Token = "0x60049CC")]
				[Address(RVA = "0x60D678", Offset = "0x60D678", VA = "0x60D678")]
				internal bool <.cctor>b__136(int i)
				{
					return default(bool);
				}

				// Token: 0x060049CD RID: 18893 RVA: 0x00023598 File Offset: 0x00021798
				[Token(Token = "0x60049CD")]
				[Address(RVA = "0x60D764", Offset = "0x60D764", VA = "0x60D764")]
				internal int <.cctor>b__137(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F9C RID: 36764
				[Token(Token = "0x4008F9C")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x02000877 RID: 2167
			[Token(Token = "0x2000877")]
			private sealed class <>c__DisplayClass55_43
			{
				// Token: 0x060049CE RID: 18894 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60049CE")]
				[Address(RVA = "0x60D8C8", Offset = "0x60D8C8", VA = "0x60D8C8")]
				public <>c__DisplayClass55_43()
				{
				}

				// Token: 0x060049CF RID: 18895 RVA: 0x000235B0 File Offset: 0x000217B0
				[Token(Token = "0x60049CF")]
				[Address(RVA = "0x60D8D0", Offset = "0x60D8D0", VA = "0x60D8D0")]
				internal bool <.cctor>b__138(int i)
				{
					return default(bool);
				}

				// Token: 0x060049D0 RID: 18896 RVA: 0x000235C8 File Offset: 0x000217C8
				[Token(Token = "0x60049D0")]
				[Address(RVA = "0x60D9BC", Offset = "0x60D9BC", VA = "0x60D9BC")]
				internal int <.cctor>b__139(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F9D RID: 36765
				[Token(Token = "0x4008F9D")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x02000878 RID: 2168
			[Token(Token = "0x2000878")]
			private sealed class <>c__DisplayClass55_44
			{
				// Token: 0x060049D1 RID: 18897 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60049D1")]
				[Address(RVA = "0x60DB20", Offset = "0x60DB20", VA = "0x60DB20")]
				public <>c__DisplayClass55_44()
				{
				}

				// Token: 0x060049D2 RID: 18898 RVA: 0x000235E0 File Offset: 0x000217E0
				[Token(Token = "0x60049D2")]
				[Address(RVA = "0x60DB28", Offset = "0x60DB28", VA = "0x60DB28")]
				internal bool <.cctor>b__140(int i)
				{
					return default(bool);
				}

				// Token: 0x060049D3 RID: 18899 RVA: 0x000235F8 File Offset: 0x000217F8
				[Token(Token = "0x60049D3")]
				[Address(RVA = "0x60DC14", Offset = "0x60DC14", VA = "0x60DC14")]
				internal int <.cctor>b__141(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F9E RID: 36766
				[Token(Token = "0x4008F9E")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x02000879 RID: 2169
			[Token(Token = "0x2000879")]
			private sealed class <>c__DisplayClass55_45
			{
				// Token: 0x060049D4 RID: 18900 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60049D4")]
				[Address(RVA = "0x60DD78", Offset = "0x60DD78", VA = "0x60DD78")]
				public <>c__DisplayClass55_45()
				{
				}

				// Token: 0x060049D5 RID: 18901 RVA: 0x00023610 File Offset: 0x00021810
				[Token(Token = "0x60049D5")]
				[Address(RVA = "0x60DD80", Offset = "0x60DD80", VA = "0x60DD80")]
				internal bool <.cctor>b__142(int i)
				{
					return default(bool);
				}

				// Token: 0x060049D6 RID: 18902 RVA: 0x00023628 File Offset: 0x00021828
				[Token(Token = "0x60049D6")]
				[Address(RVA = "0x60DE6C", Offset = "0x60DE6C", VA = "0x60DE6C")]
				internal int <.cctor>b__143(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008F9F RID: 36767
				[Token(Token = "0x4008F9F")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x0200087A RID: 2170
			[Token(Token = "0x200087A")]
			private sealed class <>c__DisplayClass55_46
			{
				// Token: 0x060049D7 RID: 18903 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60049D7")]
				[Address(RVA = "0x60E060", Offset = "0x60E060", VA = "0x60E060")]
				public <>c__DisplayClass55_46()
				{
				}

				// Token: 0x060049D8 RID: 18904 RVA: 0x00023640 File Offset: 0x00021840
				[Token(Token = "0x60049D8")]
				[Address(RVA = "0x60E068", Offset = "0x60E068", VA = "0x60E068")]
				internal bool <.cctor>b__144(int i)
				{
					return default(bool);
				}

				// Token: 0x060049D9 RID: 18905 RVA: 0x00023658 File Offset: 0x00021858
				[Token(Token = "0x60049D9")]
				[Address(RVA = "0x60E0A8", Offset = "0x60E0A8", VA = "0x60E0A8")]
				internal int <.cctor>b__145(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008FA0 RID: 36768
				[Token(Token = "0x4008FA0")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x0200087B RID: 2171
			[Token(Token = "0x200087B")]
			private sealed class <>c__DisplayClass55_47
			{
				// Token: 0x060049DA RID: 18906 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60049DA")]
				[Address(RVA = "0x60E180", Offset = "0x60E180", VA = "0x60E180")]
				public <>c__DisplayClass55_47()
				{
				}

				// Token: 0x060049DB RID: 18907 RVA: 0x00023670 File Offset: 0x00021870
				[Token(Token = "0x60049DB")]
				[Address(RVA = "0x60E188", Offset = "0x60E188", VA = "0x60E188")]
				internal bool <.cctor>b__146(int i)
				{
					return default(bool);
				}

				// Token: 0x060049DC RID: 18908 RVA: 0x00023688 File Offset: 0x00021888
				[Token(Token = "0x60049DC")]
				[Address(RVA = "0x60E23C", Offset = "0x60E23C", VA = "0x60E23C")]
				internal int <.cctor>b__147(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008FA1 RID: 36769
				[Token(Token = "0x4008FA1")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x0200087C RID: 2172
			[Token(Token = "0x200087C")]
			private sealed class <>c__DisplayClass55_48
			{
				// Token: 0x060049DD RID: 18909 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60049DD")]
				[Address(RVA = "0x60E3A4", Offset = "0x60E3A4", VA = "0x60E3A4")]
				public <>c__DisplayClass55_48()
				{
				}

				// Token: 0x060049DE RID: 18910 RVA: 0x000236A0 File Offset: 0x000218A0
				[Token(Token = "0x60049DE")]
				[Address(RVA = "0x60E3AC", Offset = "0x60E3AC", VA = "0x60E3AC")]
				internal bool <.cctor>b__148(int i)
				{
					return default(bool);
				}

				// Token: 0x060049DF RID: 18911 RVA: 0x000236B8 File Offset: 0x000218B8
				[Token(Token = "0x60049DF")]
				[Address(RVA = "0x60E494", Offset = "0x60E494", VA = "0x60E494")]
				internal int <.cctor>b__149(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008FA2 RID: 36770
				[Token(Token = "0x4008FA2")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x0200087D RID: 2173
			[Token(Token = "0x200087D")]
			private sealed class <>c__DisplayClass55_49
			{
				// Token: 0x060049E0 RID: 18912 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60049E0")]
				[Address(RVA = "0x60E588", Offset = "0x60E588", VA = "0x60E588")]
				public <>c__DisplayClass55_49()
				{
				}

				// Token: 0x060049E1 RID: 18913 RVA: 0x000236D0 File Offset: 0x000218D0
				[Token(Token = "0x60049E1")]
				[Address(RVA = "0x60E590", Offset = "0x60E590", VA = "0x60E590")]
				internal bool <.cctor>b__150(int i)
				{
					return default(bool);
				}

				// Token: 0x060049E2 RID: 18914 RVA: 0x000236E8 File Offset: 0x000218E8
				[Token(Token = "0x60049E2")]
				[Address(RVA = "0x60E608", Offset = "0x60E608", VA = "0x60E608")]
				internal int <.cctor>b__151(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008FA3 RID: 36771
				[Token(Token = "0x4008FA3")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x0200087E RID: 2174
			[Token(Token = "0x200087E")]
			private sealed class <>c__DisplayClass55_50
			{
				// Token: 0x060049E3 RID: 18915 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60049E3")]
				[Address(RVA = "0x60E6FC", Offset = "0x60E6FC", VA = "0x60E6FC")]
				public <>c__DisplayClass55_50()
				{
				}

				// Token: 0x060049E4 RID: 18916 RVA: 0x00023700 File Offset: 0x00021900
				[Token(Token = "0x60049E4")]
				[Address(RVA = "0x60E704", Offset = "0x60E704", VA = "0x60E704")]
				internal bool <.cctor>b__152(int i)
				{
					return default(bool);
				}

				// Token: 0x060049E5 RID: 18917 RVA: 0x00023718 File Offset: 0x00021918
				[Token(Token = "0x60049E5")]
				[Address(RVA = "0x60E748", Offset = "0x60E748", VA = "0x60E748")]
				internal int <.cctor>b__153(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008FA4 RID: 36772
				[Token(Token = "0x4008FA4")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x0200087F RID: 2175
			[Token(Token = "0x200087F")]
			private sealed class <>c__DisplayClass55_51
			{
				// Token: 0x060049E6 RID: 18918 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60049E6")]
				[Address(RVA = "0x60E8CC", Offset = "0x60E8CC", VA = "0x60E8CC")]
				public <>c__DisplayClass55_51()
				{
				}

				// Token: 0x060049E7 RID: 18919 RVA: 0x00023730 File Offset: 0x00021930
				[Token(Token = "0x60049E7")]
				[Address(RVA = "0x60E8D4", Offset = "0x60E8D4", VA = "0x60E8D4")]
				internal int <.cctor>b__154(int x, int y)
				{
					return 0;
				}

				// Token: 0x04008FA5 RID: 36773
				[Token(Token = "0x4008FA5")]
				[FieldOffset(Offset = "0x8")]
				public Item[] inv;
			}

			// Token: 0x02000880 RID: 2176
			[Token(Token = "0x2000880")]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x060049E9 RID: 18921 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60049E9")]
				[Address(RVA = "0x60EA20", Offset = "0x60EA20", VA = "0x60EA20")]
				public <>c()
				{
				}

				// Token: 0x060049EA RID: 18922 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60049EA")]
				[Address(RVA = "0x60EA28", Offset = "0x60EA28", VA = "0x60EA28")]
				internal List<int> <.cctor>b__55_0(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x060049EB RID: 18923 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60049EB")]
				[Address(RVA = "0x60EDD0", Offset = "0x60EDD0", VA = "0x60EDD0")]
				internal List<int> <.cctor>b__55_1(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x060049EC RID: 18924 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60049EC")]
				[Address(RVA = "0x60F178", Offset = "0x60F178", VA = "0x60F178")]
				internal List<int> <.cctor>b__55_2(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x060049ED RID: 18925 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60049ED")]
				[Address(RVA = "0x60F520", Offset = "0x60F520", VA = "0x60F520")]
				internal List<int> <.cctor>b__55_3(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x060049EE RID: 18926 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60049EE")]
				[Address(RVA = "0x60F8C8", Offset = "0x60F8C8", VA = "0x60F8C8")]
				internal List<int> <.cctor>b__55_4(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x060049EF RID: 18927 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60049EF")]
				[Address(RVA = "0x60FC70", Offset = "0x60FC70", VA = "0x60FC70")]
				internal List<int> <.cctor>b__55_5(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x060049F0 RID: 18928 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60049F0")]
				[Address(RVA = "0x610018", Offset = "0x610018", VA = "0x610018")]
				internal List<int> <.cctor>b__55_6(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x060049F1 RID: 18929 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60049F1")]
				[Address(RVA = "0x6103C0", Offset = "0x6103C0", VA = "0x6103C0")]
				internal List<int> <.cctor>b__55_7(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x060049F2 RID: 18930 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60049F2")]
				[Address(RVA = "0x610768", Offset = "0x610768", VA = "0x610768")]
				internal List<int> <.cctor>b__55_8(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x060049F3 RID: 18931 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60049F3")]
				[Address(RVA = "0x610B10", Offset = "0x610B10", VA = "0x610B10")]
				internal List<int> <.cctor>b__55_9(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x060049F4 RID: 18932 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60049F4")]
				[Address(RVA = "0x610EB8", Offset = "0x610EB8", VA = "0x610EB8")]
				internal List<int> <.cctor>b__55_10(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x060049F5 RID: 18933 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60049F5")]
				[Address(RVA = "0x611260", Offset = "0x611260", VA = "0x611260")]
				internal List<int> <.cctor>b__55_11(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x060049F6 RID: 18934 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60049F6")]
				[Address(RVA = "0x611608", Offset = "0x611608", VA = "0x611608")]
				internal List<int> <.cctor>b__55_12(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x060049F7 RID: 18935 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60049F7")]
				[Address(RVA = "0x6119B0", Offset = "0x6119B0", VA = "0x6119B0")]
				internal List<int> <.cctor>b__55_13(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x060049F8 RID: 18936 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60049F8")]
				[Address(RVA = "0x611D58", Offset = "0x611D58", VA = "0x611D58")]
				internal List<int> <.cctor>b__55_14(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x060049F9 RID: 18937 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60049F9")]
				[Address(RVA = "0x612100", Offset = "0x612100", VA = "0x612100")]
				internal List<int> <.cctor>b__55_15(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x060049FA RID: 18938 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60049FA")]
				[Address(RVA = "0x6124A8", Offset = "0x6124A8", VA = "0x6124A8")]
				internal List<int> <.cctor>b__55_16(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x060049FB RID: 18939 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60049FB")]
				[Address(RVA = "0x612850", Offset = "0x612850", VA = "0x612850")]
				internal List<int> <.cctor>b__55_17(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x060049FC RID: 18940 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60049FC")]
				[Address(RVA = "0x612BF8", Offset = "0x612BF8", VA = "0x612BF8")]
				internal List<int> <.cctor>b__55_18(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x060049FD RID: 18941 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60049FD")]
				[Address(RVA = "0x612FA0", Offset = "0x612FA0", VA = "0x612FA0")]
				internal List<int> <.cctor>b__55_19(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x060049FE RID: 18942 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60049FE")]
				[Address(RVA = "0x613348", Offset = "0x613348", VA = "0x613348")]
				internal List<int> <.cctor>b__55_20(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x060049FF RID: 18943 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60049FF")]
				[Address(RVA = "0x6136F0", Offset = "0x6136F0", VA = "0x6136F0")]
				internal List<int> <.cctor>b__55_21(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06004A00 RID: 18944 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004A00")]
				[Address(RVA = "0x613A98", Offset = "0x613A98", VA = "0x613A98")]
				internal List<int> <.cctor>b__55_22(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06004A01 RID: 18945 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004A01")]
				[Address(RVA = "0x613E40", Offset = "0x613E40", VA = "0x613E40")]
				internal List<int> <.cctor>b__55_23(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06004A02 RID: 18946 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004A02")]
				[Address(RVA = "0x6141E8", Offset = "0x6141E8", VA = "0x6141E8")]
				internal List<int> <.cctor>b__55_24(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06004A03 RID: 18947 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004A03")]
				[Address(RVA = "0x614590", Offset = "0x614590", VA = "0x614590")]
				internal List<int> <.cctor>b__55_25(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06004A04 RID: 18948 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004A04")]
				[Address(RVA = "0x614938", Offset = "0x614938", VA = "0x614938")]
				internal List<int> <.cctor>b__55_26(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06004A05 RID: 18949 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004A05")]
				[Address(RVA = "0x614CE0", Offset = "0x614CE0", VA = "0x614CE0")]
				internal List<int> <.cctor>b__55_27(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06004A06 RID: 18950 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004A06")]
				[Address(RVA = "0x615088", Offset = "0x615088", VA = "0x615088")]
				internal List<int> <.cctor>b__55_28(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06004A07 RID: 18951 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004A07")]
				[Address(RVA = "0x615430", Offset = "0x615430", VA = "0x615430")]
				internal List<int> <.cctor>b__55_29(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06004A08 RID: 18952 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004A08")]
				[Address(RVA = "0x6157D8", Offset = "0x6157D8", VA = "0x6157D8")]
				internal List<int> <.cctor>b__55_30(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06004A09 RID: 18953 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004A09")]
				[Address(RVA = "0x615B80", Offset = "0x615B80", VA = "0x615B80")]
				internal List<int> <.cctor>b__55_31(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06004A0A RID: 18954 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004A0A")]
				[Address(RVA = "0x615F28", Offset = "0x615F28", VA = "0x615F28")]
				internal List<int> <.cctor>b__55_32(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06004A0B RID: 18955 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004A0B")]
				[Address(RVA = "0x6162D0", Offset = "0x6162D0", VA = "0x6162D0")]
				internal List<int> <.cctor>b__55_33(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06004A0C RID: 18956 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004A0C")]
				[Address(RVA = "0x616678", Offset = "0x616678", VA = "0x616678")]
				internal List<int> <.cctor>b__55_34(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06004A0D RID: 18957 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004A0D")]
				[Address(RVA = "0x616A20", Offset = "0x616A20", VA = "0x616A20")]
				internal List<int> <.cctor>b__55_35(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06004A0E RID: 18958 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004A0E")]
				[Address(RVA = "0x616DC8", Offset = "0x616DC8", VA = "0x616DC8")]
				internal List<int> <.cctor>b__55_36(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06004A0F RID: 18959 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004A0F")]
				[Address(RVA = "0x617170", Offset = "0x617170", VA = "0x617170")]
				internal List<int> <.cctor>b__55_37(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06004A10 RID: 18960 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004A10")]
				[Address(RVA = "0x617518", Offset = "0x617518", VA = "0x617518")]
				internal List<int> <.cctor>b__55_38(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06004A11 RID: 18961 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004A11")]
				[Address(RVA = "0x6178C0", Offset = "0x6178C0", VA = "0x6178C0")]
				internal List<int> <.cctor>b__55_39(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06004A12 RID: 18962 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004A12")]
				[Address(RVA = "0x617C68", Offset = "0x617C68", VA = "0x617C68")]
				internal List<int> <.cctor>b__55_40(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06004A13 RID: 18963 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004A13")]
				[Address(RVA = "0x618010", Offset = "0x618010", VA = "0x618010")]
				internal List<int> <.cctor>b__55_41(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06004A14 RID: 18964 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004A14")]
				[Address(RVA = "0x6183B8", Offset = "0x6183B8", VA = "0x6183B8")]
				internal List<int> <.cctor>b__55_42(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06004A15 RID: 18965 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004A15")]
				[Address(RVA = "0x618760", Offset = "0x618760", VA = "0x618760")]
				internal List<int> <.cctor>b__55_43(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06004A16 RID: 18966 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004A16")]
				[Address(RVA = "0x618B08", Offset = "0x618B08", VA = "0x618B08")]
				internal List<int> <.cctor>b__55_44(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06004A17 RID: 18967 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004A17")]
				[Address(RVA = "0x618EB0", Offset = "0x618EB0", VA = "0x618EB0")]
				internal List<int> <.cctor>b__55_45(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06004A18 RID: 18968 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004A18")]
				[Address(RVA = "0x619258", Offset = "0x619258", VA = "0x619258")]
				internal List<int> <.cctor>b__55_46(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06004A19 RID: 18969 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004A19")]
				[Address(RVA = "0x619600", Offset = "0x619600", VA = "0x619600")]
				internal List<int> <.cctor>b__55_47(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06004A1A RID: 18970 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004A1A")]
				[Address(RVA = "0x6199A8", Offset = "0x6199A8", VA = "0x6199A8")]
				internal List<int> <.cctor>b__55_48(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06004A1B RID: 18971 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004A1B")]
				[Address(RVA = "0x619D50", Offset = "0x619D50", VA = "0x619D50")]
				internal List<int> <.cctor>b__55_49(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06004A1C RID: 18972 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004A1C")]
				[Address(RVA = "0x61A0F8", Offset = "0x61A0F8", VA = "0x61A0F8")]
				internal List<int> <.cctor>b__55_50(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x06004A1D RID: 18973 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004A1D")]
				[Address(RVA = "0x61A4A0", Offset = "0x61A4A0", VA = "0x61A4A0")]
				internal List<int> <.cctor>b__55_51(ItemSorting.ItemSortingLayer layer, Item[] inv, List<int> itemsToSort)
				{
					return null;
				}

				// Token: 0x04008FA6 RID: 36774
				[Token(Token = "0x4008FA6")]
				[FieldOffset(Offset = "0x0")]
				public static readonly ItemSorting.ItemSortingLayers.<>c <>9;
			}
		}

		// Token: 0x02000881 RID: 2177
		[Token(Token = "0x2000881")]
		private struct DamageTypeSortingLayerEntry
		{
			// Token: 0x06004A1E RID: 18974 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004A1E")]
			[Address(RVA = "0x5FE0A0", Offset = "0x5FE0A0", VA = "0x5FE0A0")]
			public DamageTypeSortingLayerEntry(float multiplier, ItemSorting.ItemSortingLayer layer, int index)
			{
			}

			// Token: 0x04008FA7 RID: 36775
			[Token(Token = "0x4008FA7")]
			[FieldOffset(Offset = "0x0")]
			public float Multiplier;

			// Token: 0x04008FA8 RID: 36776
			[Token(Token = "0x4008FA8")]
			[FieldOffset(Offset = "0x4")]
			public ItemSorting.ItemSortingLayer Layer;

			// Token: 0x04008FA9 RID: 36777
			[Token(Token = "0x4008FA9")]
			[FieldOffset(Offset = "0x8")]
			public int Index;
		}

		// Token: 0x02000882 RID: 2178
		[Token(Token = "0x2000882")]
		private struct MemoryStamp
		{
			// Token: 0x06004A1F RID: 18975 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004A1F")]
			[Address(RVA = "0x61A7F4", Offset = "0x61A7F4", VA = "0x61A7F4")]
			public MemoryStamp(int itemType, int stack, int prefix)
			{
			}

			// Token: 0x06004A20 RID: 18976 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004A20")]
			[Address(RVA = "0x603958", Offset = "0x603958", VA = "0x603958")]
			public MemoryStamp(Item item)
			{
			}

			// Token: 0x06004A21 RID: 18977 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004A21")]
			[Address(RVA = "0x602570", Offset = "0x602570", VA = "0x602570")]
			public MemoryStamp(ref ChestItem item)
			{
			}

			// Token: 0x06004A22 RID: 18978 RVA: 0x00023748 File Offset: 0x00021948
			[Token(Token = "0x6004A22")]
			[Address(RVA = "0x61A7FC", Offset = "0x61A7FC", VA = "0x61A7FC", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			// Token: 0x06004A23 RID: 18979 RVA: 0x00023760 File Offset: 0x00021960
			[Token(Token = "0x6004A23")]
			[Address(RVA = "0x61A8A4", Offset = "0x61A8A4", VA = "0x61A8A4")]
			public bool Equals(ItemSorting.MemoryStamp other)
			{
				return default(bool);
			}

			// Token: 0x06004A24 RID: 18980 RVA: 0x00023778 File Offset: 0x00021978
			[Token(Token = "0x6004A24")]
			[Address(RVA = "0x61A8D4", Offset = "0x61A8D4", VA = "0x61A8D4", Slot = "2")]
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x06004A25 RID: 18981 RVA: 0x00023790 File Offset: 0x00021990
			[Token(Token = "0x6004A25")]
			[Address(RVA = "0x61A8F4", Offset = "0x61A8F4", VA = "0x61A8F4")]
			public static bool operator ==(ItemSorting.MemoryStamp left, ItemSorting.MemoryStamp right)
			{
				return default(bool);
			}

			// Token: 0x06004A26 RID: 18982 RVA: 0x000237A8 File Offset: 0x000219A8
			[Token(Token = "0x6004A26")]
			[Address(RVA = "0x60392C", Offset = "0x60392C", VA = "0x60392C")]
			public static bool operator !=(ItemSorting.MemoryStamp left, ItemSorting.MemoryStamp right)
			{
				return default(bool);
			}

			// Token: 0x04008FAA RID: 36778
			[Token(Token = "0x4008FAA")]
			[FieldOffset(Offset = "0x0")]
			public int ItemType;

			// Token: 0x04008FAB RID: 36779
			[Token(Token = "0x4008FAB")]
			[FieldOffset(Offset = "0x4")]
			public int Stack;

			// Token: 0x04008FAC RID: 36780
			[Token(Token = "0x4008FAC")]
			[FieldOffset(Offset = "0x8")]
			public int Prefix;
		}
	}
}
