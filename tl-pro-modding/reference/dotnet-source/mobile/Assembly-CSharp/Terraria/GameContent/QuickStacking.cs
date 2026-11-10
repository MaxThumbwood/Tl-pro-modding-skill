using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent
{
	// Token: 0x020009C3 RID: 2499
	[Token(Token = "0x20009C3")]
	public class QuickStacking
	{
		// Token: 0x0600519C RID: 20892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600519C")]
		private static void AddToListyArray<T>(ref T[] arr, ref int count, T elem)
		{
		}

		// Token: 0x0600519D RID: 20893 RVA: 0x00025F38 File Offset: 0x00024138
		[Token(Token = "0x600519D")]
		[Address(RVA = "0x77FD4C", Offset = "0x77FD4C", VA = "0x77FD4C")]
		private static int GetCategory(int type)
		{
			return 0;
		}

		// Token: 0x0600519E RID: 20894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600519E")]
		[Address(RVA = "0x77FDB4", Offset = "0x77FDB4", VA = "0x77FDB4")]
		public static void QuickStackToNearbyInventories(Player player, bool smartStack = false)
		{
		}

		// Token: 0x0600519F RID: 20895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600519F")]
		[Address(RVA = "0x77FE28", Offset = "0x77FE28", VA = "0x77FE28")]
		private static void QuickStackToNearbyBanks(Player player)
		{
		}

		// Token: 0x060051A0 RID: 20896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051A0")]
		[Address(RVA = "0x780304", Offset = "0x780304", VA = "0x780304")]
		public static void QuickStackToNearbyChests(Player player, bool smartStack = false)
		{
		}

		// Token: 0x060051A1 RID: 20897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051A1")]
		[Address(RVA = "0x781240", Offset = "0x781240", VA = "0x781240")]
		internal static void QuickStackToNearbyChests(Player player, QuickStacking.SourceInventory inventory, bool smartStack)
		{
		}

		// Token: 0x060051A2 RID: 20898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051A2")]
		[Address(RVA = "0x7815D8", Offset = "0x7815D8", VA = "0x7815D8")]
		internal static void IndicateBlockedChests(Player player, List<int> chests)
		{
		}

		// Token: 0x060051A3 RID: 20899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051A3")]
		[Address(RVA = "0x781404", Offset = "0x781404", VA = "0x781404")]
		private static void SendQuickStackToNearbyChests(Player player, QuickStacking.SourceInventory inventory, bool smartStack)
		{
		}

		// Token: 0x060051A4 RID: 20900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051A4")]
		[Address(RVA = "0x7818B8", Offset = "0x7818B8", VA = "0x7818B8")]
		internal static void WriteNetInventorySlots(BinaryWriter writer)
		{
		}

		// Token: 0x060051A5 RID: 20901 RVA: 0x00025F50 File Offset: 0x00024150
		[Token(Token = "0x60051A5")]
		[Address(RVA = "0x7819C0", Offset = "0x7819C0", VA = "0x7819C0")]
		internal static QuickStacking.SourceInventory ReadNetInventory(Player player, BinaryReader reader)
		{
			return default(QuickStacking.SourceInventory);
		}

		// Token: 0x060051A6 RID: 20902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051A6")]
		[Address(RVA = "0x781D6C", Offset = "0x781D6C", VA = "0x781D6C")]
		internal static void WriteBlockedChestList(BinaryWriter writer)
		{
		}

		// Token: 0x060051A7 RID: 20903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051A7")]
		[Address(RVA = "0x781ED0", Offset = "0x781ED0", VA = "0x781ED0")]
		internal static List<int> ReadBlockedChestList(BinaryReader reader)
		{
			return null;
		}

		// Token: 0x060051A8 RID: 20904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051A8")]
		[Address(RVA = "0x780FF0", Offset = "0x780FF0", VA = "0x780FF0")]
		private static void RestoreToPlayer(Player player, QuickStacking.SourceInventory inventory)
		{
		}

		// Token: 0x060051A9 RID: 20905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051A9")]
		[Address(RVA = "0x78206C", Offset = "0x78206C", VA = "0x78206C")]
		private static void SetSlot(Player player, int slot, Item item)
		{
		}

		// Token: 0x060051AA RID: 20906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051AA")]
		[Address(RVA = "0x7821B8", Offset = "0x7821B8", VA = "0x7821B8")]
		private static Item GetSlot(Player player, int slot)
		{
			return null;
		}

		// Token: 0x060051AB RID: 20907 RVA: 0x00025F68 File Offset: 0x00024168
		[Token(Token = "0x60051AB")]
		[Address(RVA = "0x781CBC", Offset = "0x781CBC", VA = "0x781CBC")]
		private static QuickStacking.SourceInventory GetScratchInventory(Player player)
		{
			return default(QuickStacking.SourceInventory);
		}

		// Token: 0x060051AC RID: 20908 RVA: 0x00025F80 File Offset: 0x00024180
		[Token(Token = "0x60051AC")]
		[Address(RVA = "0x7803A4", Offset = "0x7803A4", VA = "0x7803A4")]
		private static QuickStacking.SourceInventory PackQuickStackableItems(Player player, bool includeVoidBag)
		{
			return default(QuickStacking.SourceInventory);
		}

		// Token: 0x060051AD RID: 20909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051AD")]
		[Address(RVA = "0x7822A8", Offset = "0x7822A8", VA = "0x7822A8")]
		private static void AddQuickStackableItems(Player player, ref QuickStacking.SourceInventory inventory, int startSlot, int count)
		{
		}

		// Token: 0x060051AE RID: 20910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051AE")]
		[Address(RVA = "0x7805D4", Offset = "0x7805D4", VA = "0x7805D4")]
		private static void Transfer(QuickStacking.SourceInventory source, List<DestinationInventory> destinations, bool smartStack = false)
		{
		}

		// Token: 0x060051AF RID: 20911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051AF")]
		[Address(RVA = "0x78244C", Offset = "0x78244C", VA = "0x78244C")]
		private static QuickStacking.DestinationHelper GetDestHelperFromPool()
		{
			return null;
		}

		// Token: 0x060051B0 RID: 20912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051B0")]
		[Address(RVA = "0x7827CC", Offset = "0x7827CC", VA = "0x7827CC")]
		private static void BuildDestinationMetricsAndStackItems(QuickStacking.SourceInventory source, QuickStacking.DestinationHelper dest, QuickStacking.MatchingItemTypeDestinationList destinationsForItemTypes)
		{
		}

		// Token: 0x060051B1 RID: 20913 RVA: 0x00025F98 File Offset: 0x00024198
		[Token(Token = "0x60051B1")]
		[Address(RVA = "0x783288", Offset = "0x783288", VA = "0x783288")]
		private static bool TryGetBestDestinationForCategory(int category, List<QuickStacking.DestinationHelper> destinations, out QuickStacking.DestinationHelper dest)
		{
			return default(bool);
		}

		// Token: 0x060051B2 RID: 20914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051B2")]
		[Address(RVA = "0x783620", Offset = "0x783620", VA = "0x783620")]
		private static void FillStack(Item item, short numToTransfer, QuickStacking.DestinationHelper dest, int slotIndex, Vector2 srcPosition)
		{
		}

		// Token: 0x060051B3 RID: 20915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051B3")]
		[Address(RVA = "0x782ED0", Offset = "0x782ED0", VA = "0x782ED0")]
		private static void Consolidate(QuickStacking.SourceInventory source, int i)
		{
		}

		// Token: 0x060051B4 RID: 20916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051B4")]
		[Address(RVA = "0x78305C", Offset = "0x78305C", VA = "0x78305C")]
		private static void InsertIntoFreeSlot(ref Item item, QuickStacking.DestinationHelper dest, Vector2 srcPosition)
		{
		}

		// Token: 0x060051B5 RID: 20917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051B5")]
		[Address(RVA = "0x783A24", Offset = "0x783A24", VA = "0x783A24")]
		public QuickStacking()
		{
		}

		// Token: 0x04009501 RID: 38145
		[Token(Token = "0x4009501")]
		[FieldOffset(Offset = "0x0")]
		private static QuickStacking.SourceInventory netInv;

		// Token: 0x04009502 RID: 38146
		[Token(Token = "0x4009502")]
		[FieldOffset(Offset = "0x18")]
		private static Item[] inventoryItemsScratch;

		// Token: 0x04009503 RID: 38147
		[Token(Token = "0x4009503")]
		[FieldOffset(Offset = "0x1C")]
		private static int[] slotsScratch;

		// Token: 0x04009504 RID: 38148
		[Token(Token = "0x4009504")]
		[FieldOffset(Offset = "0x20")]
		private static bool[] blockedSlotsScratch;

		// Token: 0x04009505 RID: 38149
		[Token(Token = "0x4009505")]
		[FieldOffset(Offset = "0x24")]
		private static List<QuickStacking.DestinationHelper> destHelperListScratch;

		// Token: 0x04009506 RID: 38150
		[Token(Token = "0x4009506")]
		[FieldOffset(Offset = "0x28")]
		private static QuickStacking.MatchingItemTypeDestinationList matchingItemTypeScratch;

		// Token: 0x04009507 RID: 38151
		[Token(Token = "0x4009507")]
		[FieldOffset(Offset = "0x2C")]
		private static List<int> _blockedChests;

		// Token: 0x04009508 RID: 38152
		[Token(Token = "0x4009508")]
		[FieldOffset(Offset = "0x30")]
		private static QuickStacking.DestinationHelper[] destHelperPool;

		// Token: 0x04009509 RID: 38153
		[Token(Token = "0x4009509")]
		[FieldOffset(Offset = "0x34")]
		private static int nextDestHelper;

		// Token: 0x020009C4 RID: 2500
		[Token(Token = "0x20009C4")]
		private class DestinationHelper
		{
			// Token: 0x060051B7 RID: 20919 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60051B7")]
			[Address(RVA = "0x782650", Offset = "0x782650", VA = "0x782650")]
			public void Reset(DestinationInventory inventory)
			{
			}

			// Token: 0x170009A8 RID: 2472
			// (get) Token: 0x060051B8 RID: 20920 RVA: 0x00025FB0 File Offset: 0x000241B0
			[Token(Token = "0x170009A8")]
			public bool IsEmpty
			{
				[Token(Token = "0x60051B8")]
				[Address(RVA = "0x783D40", Offset = "0x783D40", VA = "0x783D40")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170009A9 RID: 2473
			// (get) Token: 0x060051B9 RID: 20921 RVA: 0x00025FC8 File Offset: 0x000241C8
			[Token(Token = "0x170009A9")]
			public bool HasFreeSlots
			{
				[Token(Token = "0x60051B9")]
				[Address(RVA = "0x78392C", Offset = "0x78392C", VA = "0x78392C")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060051BA RID: 20922 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60051BA")]
			[Address(RVA = "0x7835F4", Offset = "0x7835F4", VA = "0x7835F4")]
			public void AddCategoryScore(int category)
			{
			}

			// Token: 0x060051BB RID: 20923 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60051BB")]
			[Address(RVA = "0x78355C", Offset = "0x78355C", VA = "0x78355C")]
			public void AddFreeSlot(int i)
			{
			}

			// Token: 0x060051BC RID: 20924 RVA: 0x00025FE0 File Offset: 0x000241E0
			[Token(Token = "0x60051BC")]
			[Address(RVA = "0x783944", Offset = "0x783944", VA = "0x783944")]
			public bool TryGetCategoryScore(int category, out int score)
			{
				return default(bool);
			}

			// Token: 0x060051BD RID: 20925 RVA: 0x00025FF8 File Offset: 0x000241F8
			[Token(Token = "0x60051BD")]
			[Address(RVA = "0x7839F8", Offset = "0x7839F8", VA = "0x7839F8")]
			public int ConsumeFreeSlot()
			{
				return 0;
			}

			// Token: 0x060051BE RID: 20926 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60051BE")]
			[Address(RVA = "0x783978", Offset = "0x783978", VA = "0x783978")]
			public void SyncSlot(int slot)
			{
			}

			// Token: 0x060051BF RID: 20927 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60051BF")]
			[Address(RVA = "0x78346C", Offset = "0x78346C", VA = "0x78346C")]
			public DestinationHelper()
			{
			}

			// Token: 0x0400950A RID: 38154
			[Token(Token = "0x400950A")]
			[FieldOffset(Offset = "0x8")]
			public DestinationInventory Inventory;

			// Token: 0x0400950B RID: 38155
			[Token(Token = "0x400950B")]
			[FieldOffset(Offset = "0x20")]
			public Vector2 position;

			// Token: 0x0400950C RID: 38156
			[Token(Token = "0x400950C")]
			[FieldOffset(Offset = "0x28")]
			public bool transferBlocked;

			// Token: 0x0400950D RID: 38157
			[Token(Token = "0x400950D")]
			[FieldOffset(Offset = "0x2C")]
			private int[] freeSlots;

			// Token: 0x0400950E RID: 38158
			[Token(Token = "0x400950E")]
			[FieldOffset(Offset = "0x30")]
			private int freeSlotStart;

			// Token: 0x0400950F RID: 38159
			[Token(Token = "0x400950F")]
			[FieldOffset(Offset = "0x34")]
			private int freeSlotCount;

			// Token: 0x04009510 RID: 38160
			[Token(Token = "0x4009510")]
			[FieldOffset(Offset = "0x38")]
			private int[] categoryScores;
		}

		// Token: 0x020009C5 RID: 2501
		[Token(Token = "0x20009C5")]
		private class MatchingItemTypeDestinationList
		{
			// Token: 0x060051C0 RID: 20928 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60051C0")]
			[Address(RVA = "0x783C60", Offset = "0x783C60", VA = "0x783C60")]
			public MatchingItemTypeDestinationList()
			{
			}

			// Token: 0x060051C1 RID: 20929 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60051C1")]
			[Address(RVA = "0x7823F0", Offset = "0x7823F0", VA = "0x7823F0")]
			public void Reset()
			{
			}

			// Token: 0x060051C2 RID: 20930 RVA: 0x00026010 File Offset: 0x00024210
			[Token(Token = "0x60051C2")]
			[Address(RVA = "0x783D84", Offset = "0x783D84", VA = "0x783D84")]
			private int Tail(int type)
			{
				return 0;
			}

			// Token: 0x060051C3 RID: 20931 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60051C3")]
			[Address(RVA = "0x783840", Offset = "0x783840", VA = "0x783840")]
			internal void Add(int type, QuickStacking.DestinationHelper value)
			{
			}

			// Token: 0x060051C4 RID: 20932 RVA: 0x00026028 File Offset: 0x00024228
			[Token(Token = "0x60051C4")]
			[Address(RVA = "0x783E00", Offset = "0x783E00", VA = "0x783E00")]
			private int AddEntry(QuickStacking.DestinationHelper value)
			{
				return 0;
			}

			// Token: 0x060051C5 RID: 20933 RVA: 0x00026040 File Offset: 0x00024240
			[Token(Token = "0x60051C5")]
			[Address(RVA = "0x782E28", Offset = "0x782E28", VA = "0x782E28")]
			public bool Lookup(int type, out QuickStacking.DestinationHelper value)
			{
				return default(bool);
			}

			// Token: 0x04009511 RID: 38161
			[Token(Token = "0x4009511")]
			[FieldOffset(Offset = "0x8")]
			private QuickStacking.MatchingItemTypeDestinationList.LinkedEntry[] entries;

			// Token: 0x04009512 RID: 38162
			[Token(Token = "0x4009512")]
			[FieldOffset(Offset = "0xC")]
			private int numEntries;

			// Token: 0x04009513 RID: 38163
			[Token(Token = "0x4009513")]
			[FieldOffset(Offset = "0x10")]
			private int[] firstEntryForType;

			// Token: 0x020009C6 RID: 2502
			[Token(Token = "0x20009C6")]
			private struct LinkedEntry
			{
				// Token: 0x04009514 RID: 38164
				[Token(Token = "0x4009514")]
				[FieldOffset(Offset = "0x0")]
				public QuickStacking.DestinationHelper value;

				// Token: 0x04009515 RID: 38165
				[Token(Token = "0x4009515")]
				[FieldOffset(Offset = "0x4")]
				public int next;
			}
		}

		// Token: 0x020009C7 RID: 2503
		[Token(Token = "0x20009C7")]
		internal struct SourceInventory
		{
			// Token: 0x04009516 RID: 38166
			[Token(Token = "0x4009516")]
			[FieldOffset(Offset = "0x0")]
			public Item[] items;

			// Token: 0x04009517 RID: 38167
			[Token(Token = "0x4009517")]
			[FieldOffset(Offset = "0x4")]
			public int numItems;

			// Token: 0x04009518 RID: 38168
			[Token(Token = "0x4009518")]
			[FieldOffset(Offset = "0x8")]
			public int[] playerSlotIds;

			// Token: 0x04009519 RID: 38169
			[Token(Token = "0x4009519")]
			[FieldOffset(Offset = "0xC")]
			public bool[] transferBlocked;

			// Token: 0x0400951A RID: 38170
			[Token(Token = "0x400951A")]
			[FieldOffset(Offset = "0x10")]
			public Vector2 position;
		}
	}
}
