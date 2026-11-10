using System;
using System.Collections.Generic;
using System.Linq;
using Il2CppDummyDll;
using Terraria.GameContent.Bestiary;

namespace Terraria.ID
{
	// Token: 0x020006CB RID: 1739
	[Token(Token = "0x20006CB")]
	public static class ContentSamples
	{
		// Token: 0x06004140 RID: 16704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004140")]
		[Address(RVA = "0x1EF9CB0", Offset = "0x1EF9CB0", VA = "0x1EF9CB0")]
		public static void Initialize()
		{
		}

		// Token: 0x06004141 RID: 16705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004141")]
		[Address(RVA = "0x1EFE698", Offset = "0x1EFE698", VA = "0x1EFE698")]
		public static void ResetItemTooltips()
		{
		}

		// Token: 0x06004142 RID: 16706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004142")]
		[Address(RVA = "0x1EFE8A0", Offset = "0x1EFE8A0", VA = "0x1EFE8A0")]
		public static void RefreshItemsOnWorldLoad()
		{
		}

		// Token: 0x06004143 RID: 16707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004143")]
		[Address(RVA = "0x1EFCA84", Offset = "0x1EFCA84", VA = "0x1EFCA84")]
		private static void FillResearchItemOverrides()
		{
		}

		// Token: 0x06004144 RID: 16708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004144")]
		[Address(RVA = "0x1EFEAA8", Offset = "0x1EFEAA8", VA = "0x1EFEAA8")]
		private static void AddItemResearchOverride(int itemTypeToUnlock, int[] itemsThatWillResearchTheItemToUnlock)
		{
		}

		// Token: 0x06004145 RID: 16709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004145")]
		[Address(RVA = "0x1EFEBD0", Offset = "0x1EFEBD0", VA = "0x1EFEBD0")]
		private static void AddItemResearchOverride_Inner(int itemTypeToSacrifice, int itemTypeToUnlock)
		{
		}

		// Token: 0x06004146 RID: 16710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004146")]
		[Address(RVA = "0x1EFEC78", Offset = "0x1EFEC78", VA = "0x1EFEC78")]
		public static void FixItemsAfterRecipesAreAdded()
		{
		}

		// Token: 0x06004147 RID: 16711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004147")]
		[Address(RVA = "0x1EFEE70", Offset = "0x1EFEE70", VA = "0x1EFEE70")]
		public static void FixItemsUsingPlayerColours()
		{
		}

		// Token: 0x06004148 RID: 16712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004148")]
		[Address(RVA = "0x1EFF2DC", Offset = "0x1EFF2DC", VA = "0x1EFF2DC")]
		public static void RebuildBestiarySortingIDsByBestiaryDatabaseContents(BestiaryDatabase database)
		{
		}

		// Token: 0x06004149 RID: 16713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004149")]
		[Address(RVA = "0x1EFF5A8", Offset = "0x1EFF5A8", VA = "0x1EFF5A8")]
		public static void RebuildItemCreativeSortingIDsAfterRecipesAreSetUp()
		{
		}

		// Token: 0x0600414A RID: 16714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600414A")]
		[Address(RVA = "0x1EFA548", Offset = "0x1EFA548", VA = "0x1EFA548")]
		private static void ModifyNPCIds()
		{
		}

		// Token: 0x0600414B RID: 16715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600414B")]
		[Address(RVA = "0x1EFF380", Offset = "0x1EFF380", VA = "0x1EFF380")]
		private static void CreateBestiarySortingIds(BestiaryDatabase database)
		{
		}

		// Token: 0x0600414C RID: 16716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600414C")]
		[Address(RVA = "0x1EFCD24", Offset = "0x1EFCD24", VA = "0x1EFCD24")]
		private static void FillNpcRarities()
		{
		}

		// Token: 0x0600414D RID: 16717 RVA: 0x0001FE78 File Offset: 0x0001E078
		[Token(Token = "0x600414D")]
		[Address(RVA = "0x1EFFFE8", Offset = "0x1EFFFE8", VA = "0x1EFFFE8")]
		private static int GetNPCBestiaryRarityStarsCount(NPC npc)
		{
			return 0;
		}

		// Token: 0x0600414E RID: 16718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600414E")]
		[Address(RVA = "0x1EFF69C", Offset = "0x1EFF69C", VA = "0x1EFF69C")]
		private static void CreateCreativeItemSortingIds()
		{
		}

		// Token: 0x04005565 RID: 21861
		[Token(Token = "0x4005565")]
		[FieldOffset(Offset = "0x0")]
		public static Dictionary<int, NPC> NpcsByNetId;

		// Token: 0x04005566 RID: 21862
		[Token(Token = "0x4005566")]
		[FieldOffset(Offset = "0x4")]
		public static Dictionary<int, Item> ItemsByType;

		// Token: 0x04005567 RID: 21863
		[Token(Token = "0x4005567")]
		[FieldOffset(Offset = "0x8")]
		public static Dictionary<string, int> ItemNetIdsByPersistentIds;

		// Token: 0x04005568 RID: 21864
		[Token(Token = "0x4005568")]
		[FieldOffset(Offset = "0xC")]
		public static Dictionary<int, string> ItemPersistentIdsByNetIds;

		// Token: 0x04005569 RID: 21865
		[Token(Token = "0x4005569")]
		[FieldOffset(Offset = "0x10")]
		public static Dictionary<int, int> CreativeResearchItemPersistentIdOverride;

		// Token: 0x0400556A RID: 21866
		[Token(Token = "0x400556A")]
		[FieldOffset(Offset = "0x14")]
		public static Dictionary<string, int> NpcNetIdsByPersistentIds;

		// Token: 0x0400556B RID: 21867
		[Token(Token = "0x400556B")]
		[FieldOffset(Offset = "0x18")]
		public static Dictionary<int, string> NpcPersistentIdsByNetIds;

		// Token: 0x0400556C RID: 21868
		[Token(Token = "0x400556C")]
		[FieldOffset(Offset = "0x1C")]
		public static Dictionary<int, int> NpcBestiarySortingId;

		// Token: 0x0400556D RID: 21869
		[Token(Token = "0x400556D")]
		[FieldOffset(Offset = "0x20")]
		public static Dictionary<int, int> NpcBestiaryRarityStars;

		// Token: 0x0400556E RID: 21870
		[Token(Token = "0x400556E")]
		[FieldOffset(Offset = "0x24")]
		public static Dictionary<int, string> NpcBestiaryCreditIdsByNpcNetIds;

		// Token: 0x0400556F RID: 21871
		[Token(Token = "0x400556F")]
		[FieldOffset(Offset = "0x28")]
		public static Dictionary<int, ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup> ItemCreativeSortingId;

		// Token: 0x020006CC RID: 1740
		[Token(Token = "0x20006CC")]
		public static class DyeShaderIDs
		{
			// Token: 0x06004150 RID: 16720 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004150")]
			[Address(RVA = "0x1F01204", Offset = "0x1F01204", VA = "0x1F01204")]
			public static void Initialize()
			{
			}

			// Token: 0x04005570 RID: 21872
			[Token(Token = "0x4005570")]
			[FieldOffset(Offset = "0x0")]
			public static int TeamDyeShaderIndex;

			// Token: 0x04005571 RID: 21873
			[Token(Token = "0x4005571")]
			[FieldOffset(Offset = "0x4")]
			public static int ColorOnlyShaderIndex;
		}

		// Token: 0x020006CD RID: 1741
		[Token(Token = "0x20006CD")]
		public static class CreativeHelper
		{
			// Token: 0x06004152 RID: 16722 RVA: 0x0001FE90 File Offset: 0x0001E090
			[Token(Token = "0x6004152")]
			[Address(RVA = "0x1F01350", Offset = "0x1F01350", VA = "0x1F01350")]
			public static ContentSamples.CreativeHelper.ItemGroup GetItemGroup(Item item, out int orderInGroup)
			{
				return (ContentSamples.CreativeHelper.ItemGroup)0;
			}

			// Token: 0x06004153 RID: 16723 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004153")]
			[Address(RVA = "0x1F001DC", Offset = "0x1F001DC", VA = "0x1F001DC")]
			public static void SetCreativeMenuOrder()
			{
			}

			// Token: 0x06004154 RID: 16724 RVA: 0x0001FEA8 File Offset: 0x0001E0A8
			[Token(Token = "0x6004154")]
			[Address(RVA = "0x1F02760", Offset = "0x1F02760", VA = "0x1F02760")]
			public static bool ShouldRemoveFromList(Item item)
			{
				return default(bool);
			}

			// Token: 0x04005572 RID: 21874
			[Token(Token = "0x4005572")]
			[FieldOffset(Offset = "0x0")]
			private static List<int> _manualEventItemsOrder;

			// Token: 0x04005573 RID: 21875
			[Token(Token = "0x4005573")]
			[FieldOffset(Offset = "0x4")]
			private static List<int> _manualBossSpawnItemsOrder;

			// Token: 0x04005574 RID: 21876
			[Token(Token = "0x4005574")]
			[FieldOffset(Offset = "0x8")]
			public static List<int> _manualCraftingStations;

			// Token: 0x04005575 RID: 21877
			[Token(Token = "0x4005575")]
			[FieldOffset(Offset = "0xC")]
			private static List<int> _manualGolfItemsOrder;

			// Token: 0x020006CE RID: 1742
			[Token(Token = "0x20006CE")]
			public enum ItemGroup
			{
				// Token: 0x04005577 RID: 21879
				[Token(Token = "0x4005577")]
				Coin = 10,
				// Token: 0x04005578 RID: 21880
				[Token(Token = "0x4005578")]
				CraftingObjects,
				// Token: 0x04005579 RID: 21881
				[Token(Token = "0x4005579")]
				Torches = 20,
				// Token: 0x0400557A RID: 21882
				[Token(Token = "0x400557A")]
				Glowsticks = 25,
				// Token: 0x0400557B RID: 21883
				[Token(Token = "0x400557B")]
				Wood = 30,
				// Token: 0x0400557C RID: 21884
				[Token(Token = "0x400557C")]
				Bombs = 40,
				// Token: 0x0400557D RID: 21885
				[Token(Token = "0x400557D")]
				LifePotions = 50,
				// Token: 0x0400557E RID: 21886
				[Token(Token = "0x400557E")]
				ManaPotions,
				// Token: 0x0400557F RID: 21887
				[Token(Token = "0x400557F")]
				BuffPotion,
				// Token: 0x04005580 RID: 21888
				[Token(Token = "0x4005580")]
				Flask,
				// Token: 0x04005581 RID: 21889
				[Token(Token = "0x4005581")]
				Food,
				// Token: 0x04005582 RID: 21890
				[Token(Token = "0x4005582")]
				Crates = 60,
				// Token: 0x04005583 RID: 21891
				[Token(Token = "0x4005583")]
				BossBags = 70,
				// Token: 0x04005584 RID: 21892
				[Token(Token = "0x4005584")]
				GoodieBags = 80,
				// Token: 0x04005585 RID: 21893
				[Token(Token = "0x4005585")]
				AlchemyPlants = 83,
				// Token: 0x04005586 RID: 21894
				[Token(Token = "0x4005586")]
				AlchemySeeds,
				// Token: 0x04005587 RID: 21895
				[Token(Token = "0x4005587")]
				DyeMaterial = 87,
				// Token: 0x04005588 RID: 21896
				[Token(Token = "0x4005588")]
				BossItem = 90,
				// Token: 0x04005589 RID: 21897
				[Token(Token = "0x4005589")]
				EventItem,
				// Token: 0x0400558A RID: 21898
				[Token(Token = "0x400558A")]
				ConsumableThatDoesNotDamage = 94,
				// Token: 0x0400558B RID: 21899
				[Token(Token = "0x400558B")]
				Solutions,
				// Token: 0x0400558C RID: 21900
				[Token(Token = "0x400558C")]
				Ammo,
				// Token: 0x0400558D RID: 21901
				[Token(Token = "0x400558D")]
				ConsumableThatDamages,
				// Token: 0x0400558E RID: 21902
				[Token(Token = "0x400558E")]
				PlaceableObjects = 100,
				// Token: 0x0400558F RID: 21903
				[Token(Token = "0x400558F")]
				Blocks = 120,
				// Token: 0x04005590 RID: 21904
				[Token(Token = "0x4005590")]
				Wands = 130,
				// Token: 0x04005591 RID: 21905
				[Token(Token = "0x4005591")]
				Rope = 140,
				// Token: 0x04005592 RID: 21906
				[Token(Token = "0x4005592")]
				Walls = 150,
				// Token: 0x04005593 RID: 21907
				[Token(Token = "0x4005593")]
				Wiring = 200,
				// Token: 0x04005594 RID: 21908
				[Token(Token = "0x4005594")]
				Pickaxe = 500,
				// Token: 0x04005595 RID: 21909
				[Token(Token = "0x4005595")]
				Axe = 510,
				// Token: 0x04005596 RID: 21910
				[Token(Token = "0x4005596")]
				Hammer = 520,
				// Token: 0x04005597 RID: 21911
				[Token(Token = "0x4005597")]
				MeleeWeapon = 530,
				// Token: 0x04005598 RID: 21912
				[Token(Token = "0x4005598")]
				RangedWeapon = 540,
				// Token: 0x04005599 RID: 21913
				[Token(Token = "0x4005599")]
				MagicWeapon = 550,
				// Token: 0x0400559A RID: 21914
				[Token(Token = "0x400559A")]
				SummonWeapon = 560,
				// Token: 0x0400559B RID: 21915
				[Token(Token = "0x400559B")]
				Headgear = 600,
				// Token: 0x0400559C RID: 21916
				[Token(Token = "0x400559C")]
				Torso = 610,
				// Token: 0x0400559D RID: 21917
				[Token(Token = "0x400559D")]
				Pants = 620,
				// Token: 0x0400559E RID: 21918
				[Token(Token = "0x400559E")]
				Accessories = 630,
				// Token: 0x0400559F RID: 21919
				[Token(Token = "0x400559F")]
				Hook = 700,
				// Token: 0x040055A0 RID: 21920
				[Token(Token = "0x40055A0")]
				Mount = 710,
				// Token: 0x040055A1 RID: 21921
				[Token(Token = "0x40055A1")]
				Minecart = 720,
				// Token: 0x040055A2 RID: 21922
				[Token(Token = "0x40055A2")]
				VanityPet = 800,
				// Token: 0x040055A3 RID: 21923
				[Token(Token = "0x40055A3")]
				LightPet = 810,
				// Token: 0x040055A4 RID: 21924
				[Token(Token = "0x40055A4")]
				Golf = 900,
				// Token: 0x040055A5 RID: 21925
				[Token(Token = "0x40055A5")]
				BossSpawners,
				// Token: 0x040055A6 RID: 21926
				[Token(Token = "0x40055A6")]
				Dye = 910,
				// Token: 0x040055A7 RID: 21927
				[Token(Token = "0x40055A7")]
				HairDye = 920,
				// Token: 0x040055A8 RID: 21928
				[Token(Token = "0x40055A8")]
				Paint = 930,
				// Token: 0x040055A9 RID: 21929
				[Token(Token = "0x40055A9")]
				FishingRods = 1000,
				// Token: 0x040055AA RID: 21930
				[Token(Token = "0x40055AA")]
				FishingQuestFish = 1010,
				// Token: 0x040055AB RID: 21931
				[Token(Token = "0x40055AB")]
				Fish = 1015,
				// Token: 0x040055AC RID: 21932
				[Token(Token = "0x40055AC")]
				FishingBait = 1020,
				// Token: 0x040055AD RID: 21933
				[Token(Token = "0x40055AD")]
				Critters = 1030,
				// Token: 0x040055AE RID: 21934
				[Token(Token = "0x40055AE")]
				Keys = 2000,
				// Token: 0x040055AF RID: 21935
				[Token(Token = "0x40055AF")]
				RemainingUseItems = 5000,
				// Token: 0x040055B0 RID: 21936
				[Token(Token = "0x40055B0")]
				Material = 10000,
				// Token: 0x040055B1 RID: 21937
				[Token(Token = "0x40055B1")]
				EverythingElse = 11000
			}

			// Token: 0x020006CF RID: 1743
			[Token(Token = "0x20006CF")]
			public struct ItemGroupAndOrderInGroup
			{
				// Token: 0x06004156 RID: 16726 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004156")]
				[Address(RVA = "0x1F05070", Offset = "0x1F05070", VA = "0x1F05070")]
				public ItemGroupAndOrderInGroup(Item item)
				{
				}

				// Token: 0x040055B2 RID: 21938
				[Token(Token = "0x40055B2")]
				[FieldOffset(Offset = "0x0")]
				public int ItemType;

				// Token: 0x040055B3 RID: 21939
				[Token(Token = "0x40055B3")]
				[FieldOffset(Offset = "0x4")]
				public ContentSamples.CreativeHelper.ItemGroup Group;

				// Token: 0x040055B4 RID: 21940
				[Token(Token = "0x40055B4")]
				[FieldOffset(Offset = "0x8")]
				public int OrderInGroup;
			}

			// Token: 0x020006D0 RID: 1744
			[Token(Token = "0x20006D0")]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x06004158 RID: 16728 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004158")]
				[Address(RVA = "0x1F0516C", Offset = "0x1F0516C", VA = "0x1F0516C")]
				public <>c()
				{
				}

				// Token: 0x06004159 RID: 16729 RVA: 0x0001FEC0 File Offset: 0x0001E0C0
				[Token(Token = "0x6004159")]
				[Address(RVA = "0x1F05174", Offset = "0x1F05174", VA = "0x1F05174")]
				internal ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup <SetCreativeMenuOrder>b__7_0(Item x)
				{
					return default(ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup);
				}

				// Token: 0x0600415A RID: 16730 RVA: 0x0001FED8 File Offset: 0x0001E0D8
				[Token(Token = "0x600415A")]
				[Address(RVA = "0x1F0520C", Offset = "0x1F0520C", VA = "0x1F0520C")]
				internal ContentSamples.CreativeHelper.ItemGroup <SetCreativeMenuOrder>b__7_1(ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup x)
				{
					return (ContentSamples.CreativeHelper.ItemGroup)0;
				}

				// Token: 0x0600415B RID: 16731 RVA: 0x0001FEF0 File Offset: 0x0001E0F0
				[Token(Token = "0x600415B")]
				[Address(RVA = "0x1F05214", Offset = "0x1F05214", VA = "0x1F05214")]
				internal int <SetCreativeMenuOrder>b__7_2(IGrouping<ContentSamples.CreativeHelper.ItemGroup, ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup> group)
				{
					return 0;
				}

				// Token: 0x0600415C RID: 16732 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600415C")]
				[Address(RVA = "0x1F052C8", Offset = "0x1F052C8", VA = "0x1F052C8")]
				internal IEnumerable<ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup> <SetCreativeMenuOrder>b__7_3(IGrouping<ContentSamples.CreativeHelper.ItemGroup, ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup> group)
				{
					return null;
				}

				// Token: 0x040055B5 RID: 21941
				[Token(Token = "0x40055B5")]
				[FieldOffset(Offset = "0x0")]
				public static readonly ContentSamples.CreativeHelper.<>c <>9;

				// Token: 0x040055B6 RID: 21942
				[Token(Token = "0x40055B6")]
				[FieldOffset(Offset = "0x4")]
				public static Func<Item, ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup> <>9__7_0;

				// Token: 0x040055B7 RID: 21943
				[Token(Token = "0x40055B7")]
				[FieldOffset(Offset = "0x8")]
				public static Func<ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup, ContentSamples.CreativeHelper.ItemGroup> <>9__7_1;

				// Token: 0x040055B8 RID: 21944
				[Token(Token = "0x40055B8")]
				[FieldOffset(Offset = "0xC")]
				public static Func<IGrouping<ContentSamples.CreativeHelper.ItemGroup, ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup>, int> <>9__7_2;

				// Token: 0x040055B9 RID: 21945
				[Token(Token = "0x40055B9")]
				[FieldOffset(Offset = "0x10")]
				public static Func<IGrouping<ContentSamples.CreativeHelper.ItemGroup, ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup>, IEnumerable<ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup>> <>9__7_3;
			}
		}

		// Token: 0x020006D1 RID: 1745
		[Token(Token = "0x20006D1")]
		public static class BestiaryHelper
		{
			// Token: 0x0600415D RID: 16733 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600415D")]
			[Address(RVA = "0x1EFF700", Offset = "0x1EFF700", VA = "0x1EFF700")]
			public static List<KeyValuePair<int, NPC>> GetSortedBestiaryEntriesList(BestiaryDatabase database)
			{
				return null;
			}

			// Token: 0x0600415E RID: 16734 RVA: 0x0001FF08 File Offset: 0x0001E108
			[Token(Token = "0x600415E")]
			[Address(RVA = "0x1F05324", Offset = "0x1F05324", VA = "0x1F05324")]
			public static int GetLowestBiomeGroupIndex(NPC npc, BestiaryDatabase database, List<IBestiaryInfoElement> commonElements)
			{
				return 0;
			}

			// Token: 0x0600415F RID: 16735 RVA: 0x0001FF20 File Offset: 0x0001E120
			[Token(Token = "0x600415F")]
			[Address(RVA = "0x1F05450", Offset = "0x1F05450", VA = "0x1F05450")]
			public static bool ShouldHideBestiaryEntry(NPC npc)
			{
				return default(bool);
			}

			// Token: 0x06004160 RID: 16736 RVA: 0x0001FF38 File Offset: 0x0001E138
			[Token(Token = "0x6004160")]
			[Address(RVA = "0x1F05550", Offset = "0x1F05550", VA = "0x1F05550")]
			public static float GetBestiaryPowerLevel(NPC npc)
			{
				return 0f;
			}

			// Token: 0x06004161 RID: 16737 RVA: 0x0001FF50 File Offset: 0x0001E150
			[Token(Token = "0x6004161")]
			[Address(RVA = "0x1F055AC", Offset = "0x1F055AC", VA = "0x1F055AC")]
			public static int GetBestiaryTownPriority(NPC npc)
			{
				return 0;
			}

			// Token: 0x06004162 RID: 16738 RVA: 0x0001FF68 File Offset: 0x0001E168
			[Token(Token = "0x6004162")]
			[Address(RVA = "0x1F05664", Offset = "0x1F05664", VA = "0x1F05664")]
			public static int GetBestiaryNormalGoldCritterPriority(NPC npc)
			{
				return 0;
			}

			// Token: 0x06004163 RID: 16739 RVA: 0x0001FF80 File Offset: 0x0001E180
			[Token(Token = "0x6004163")]
			[Address(RVA = "0x1F0571C", Offset = "0x1F0571C", VA = "0x1F0571C")]
			public static int GetBestiaryBossPriority(NPC npc)
			{
				return 0;
			}

			// Token: 0x06004164 RID: 16740 RVA: 0x0001FF98 File Offset: 0x0001E198
			[Token(Token = "0x6004164")]
			[Address(RVA = "0x1F057CC", Offset = "0x1F057CC", VA = "0x1F057CC")]
			public static int GetBestiaryStarsPriority(NPC npc)
			{
				return 0;
			}

			// Token: 0x020006D2 RID: 1746
			[Token(Token = "0x20006D2")]
			private sealed class <>c__DisplayClass0_0
			{
				// Token: 0x06004165 RID: 16741 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004165")]
				[Address(RVA = "0x1F0531C", Offset = "0x1F0531C", VA = "0x1F0531C")]
				public <>c__DisplayClass0_0()
				{
				}

				// Token: 0x06004166 RID: 16742 RVA: 0x0001FFB0 File Offset: 0x0001E1B0
				[Token(Token = "0x6004166")]
				[Address(RVA = "0x1F0587C", Offset = "0x1F0587C", VA = "0x1F0587C")]
				internal int <GetSortedBestiaryEntriesList>b__5(KeyValuePair<int, NPC> x)
				{
					return 0;
				}

				// Token: 0x040055BA RID: 21946
				[Token(Token = "0x40055BA")]
				[FieldOffset(Offset = "0x8")]
				public BestiaryDatabase database;

				// Token: 0x040055BB RID: 21947
				[Token(Token = "0x40055BB")]
				[FieldOffset(Offset = "0xC")]
				public List<IBestiaryInfoElement> commonFilters;
			}

			// Token: 0x020006D3 RID: 1747
			[Token(Token = "0x20006D3")]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x06004168 RID: 16744 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004168")]
				[Address(RVA = "0x1F05940", Offset = "0x1F05940", VA = "0x1F05940")]
				public <>c()
				{
				}

				// Token: 0x06004169 RID: 16745 RVA: 0x0001FFC8 File Offset: 0x0001E1C8
				[Token(Token = "0x6004169")]
				[Address(RVA = "0x1F05948", Offset = "0x1F05948", VA = "0x1F05948")]
				internal int <GetSortedBestiaryEntriesList>b__0_0(KeyValuePair<int, NPC> x)
				{
					return 0;
				}

				// Token: 0x0600416A RID: 16746 RVA: 0x0001FFE0 File Offset: 0x0001E1E0
				[Token(Token = "0x600416A")]
				[Address(RVA = "0x1F0598C", Offset = "0x1F0598C", VA = "0x1F0598C")]
				internal bool <GetSortedBestiaryEntriesList>b__0_1(KeyValuePair<int, NPC> x)
				{
					return default(bool);
				}

				// Token: 0x0600416B RID: 16747 RVA: 0x0001FFF8 File Offset: 0x0001E1F8
				[Token(Token = "0x600416B")]
				[Address(RVA = "0x1F059E4", Offset = "0x1F059E4", VA = "0x1F059E4")]
				internal int <GetSortedBestiaryEntriesList>b__0_2(KeyValuePair<int, NPC> x)
				{
					return 0;
				}

				// Token: 0x0600416C RID: 16748 RVA: 0x00020010 File Offset: 0x0001E210
				[Token(Token = "0x600416C")]
				[Address(RVA = "0x1F05A28", Offset = "0x1F05A28", VA = "0x1F05A28")]
				internal bool <GetSortedBestiaryEntriesList>b__0_3(KeyValuePair<int, NPC> x)
				{
					return default(bool);
				}

				// Token: 0x0600416D RID: 16749 RVA: 0x00020028 File Offset: 0x0001E228
				[Token(Token = "0x600416D")]
				[Address(RVA = "0x1F05A80", Offset = "0x1F05A80", VA = "0x1F05A80")]
				internal int <GetSortedBestiaryEntriesList>b__0_4(KeyValuePair<int, NPC> x)
				{
					return 0;
				}

				// Token: 0x0600416E RID: 16750 RVA: 0x00020040 File Offset: 0x0001E240
				[Token(Token = "0x600416E")]
				[Address(RVA = "0x1F05AC4", Offset = "0x1F05AC4", VA = "0x1F05AC4")]
				internal int <GetSortedBestiaryEntriesList>b__0_6(KeyValuePair<int, NPC> x)
				{
					return 0;
				}

				// Token: 0x0600416F RID: 16751 RVA: 0x00020058 File Offset: 0x0001E258
				[Token(Token = "0x600416F")]
				[Address(RVA = "0x1F05B20", Offset = "0x1F05B20", VA = "0x1F05B20")]
				internal float <GetSortedBestiaryEntriesList>b__0_7(KeyValuePair<int, NPC> x)
				{
					return 0f;
				}

				// Token: 0x06004170 RID: 16752 RVA: 0x00020070 File Offset: 0x0001E270
				[Token(Token = "0x6004170")]
				[Address(RVA = "0x1F05BAC", Offset = "0x1F05BAC", VA = "0x1F05BAC")]
				internal int <GetSortedBestiaryEntriesList>b__0_8(KeyValuePair<int, NPC> x)
				{
					return 0;
				}

				// Token: 0x06004171 RID: 16753 RVA: 0x00020088 File Offset: 0x0001E288
				[Token(Token = "0x6004171")]
				[Address(RVA = "0x1F05BF0", Offset = "0x1F05BF0", VA = "0x1F05BF0")]
				internal bool <GetSortedBestiaryEntriesList>b__0_9(KeyValuePair<int, NPC> x)
				{
					return default(bool);
				}

				// Token: 0x040055BC RID: 21948
				[Token(Token = "0x40055BC")]
				[FieldOffset(Offset = "0x0")]
				public static readonly ContentSamples.BestiaryHelper.<>c <>9;

				// Token: 0x040055BD RID: 21949
				[Token(Token = "0x40055BD")]
				[FieldOffset(Offset = "0x4")]
				public static Func<KeyValuePair<int, NPC>, int> <>9__0_0;

				// Token: 0x040055BE RID: 21950
				[Token(Token = "0x40055BE")]
				[FieldOffset(Offset = "0x8")]
				public static Func<KeyValuePair<int, NPC>, bool> <>9__0_1;

				// Token: 0x040055BF RID: 21951
				[Token(Token = "0x40055BF")]
				[FieldOffset(Offset = "0xC")]
				public static Func<KeyValuePair<int, NPC>, int> <>9__0_2;

				// Token: 0x040055C0 RID: 21952
				[Token(Token = "0x40055C0")]
				[FieldOffset(Offset = "0x10")]
				public static Func<KeyValuePair<int, NPC>, bool> <>9__0_3;

				// Token: 0x040055C1 RID: 21953
				[Token(Token = "0x40055C1")]
				[FieldOffset(Offset = "0x14")]
				public static Func<KeyValuePair<int, NPC>, int> <>9__0_4;

				// Token: 0x040055C2 RID: 21954
				[Token(Token = "0x40055C2")]
				[FieldOffset(Offset = "0x18")]
				public static Func<KeyValuePair<int, NPC>, int> <>9__0_6;

				// Token: 0x040055C3 RID: 21955
				[Token(Token = "0x40055C3")]
				[FieldOffset(Offset = "0x1C")]
				public static Func<KeyValuePair<int, NPC>, float> <>9__0_7;

				// Token: 0x040055C4 RID: 21956
				[Token(Token = "0x40055C4")]
				[FieldOffset(Offset = "0x20")]
				public static Func<KeyValuePair<int, NPC>, int> <>9__0_8;

				// Token: 0x040055C5 RID: 21957
				[Token(Token = "0x40055C5")]
				[FieldOffset(Offset = "0x24")]
				public static Predicate<KeyValuePair<int, NPC>> <>9__0_9;
			}
		}
	}
}
