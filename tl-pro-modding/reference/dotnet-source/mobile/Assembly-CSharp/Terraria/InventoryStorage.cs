using System;
using Il2CppDummyDll;

namespace Terraria
{
	// Token: 0x020004C6 RID: 1222
	[Token(Token = "0x20004C6")]
	public class InventoryStorage
	{
		// Token: 0x06002FDE RID: 12254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FDE")]
		[Address(RVA = "0x18AB89C", Offset = "0x18AB89C", VA = "0x18AB89C")]
		public InventoryStorage()
		{
		}

		// Token: 0x06002FDF RID: 12255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FDF")]
		[Address(RVA = "0x18AB9C0", Offset = "0x18AB9C0", VA = "0x18AB9C0")]
		public InventoryStorage(int chest)
		{
		}

		// Token: 0x06002FE0 RID: 12256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FE0")]
		[Address(RVA = "0x18ABA6C", Offset = "0x18ABA6C", VA = "0x18ABA6C")]
		public void SyncFromChest()
		{
		}

		// Token: 0x06002FE1 RID: 12257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FE1")]
		[Address(RVA = "0x18ABBAC", Offset = "0x18ABBAC", VA = "0x18ABBAC")]
		public void SyncToChest()
		{
		}

		// Token: 0x06002FE2 RID: 12258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FE2")]
		[Address(RVA = "0x18ABC3C", Offset = "0x18ABC3C", VA = "0x18ABC3C")]
		public static void SyncChestItemUpdateToStorage(int chestIndex, int slot)
		{
		}

		// Token: 0x06002FE3 RID: 12259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FE3")]
		[Address(RVA = "0x18ABFD0", Offset = "0x18ABFD0", VA = "0x18ABFD0")]
		public static void SendSyncChestItem(int chestIndex, int slot)
		{
		}

		// Token: 0x06002FE4 RID: 12260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FE4")]
		[Address(RVA = "0x18AC7D0", Offset = "0x18AC7D0", VA = "0x18AC7D0")]
		public void SyncToChestItem(int i)
		{
		}

		// Token: 0x06002FE5 RID: 12261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FE5")]
		[Address(RVA = "0x18ABF40", Offset = "0x18ABF40", VA = "0x18ABF40")]
		public void SyncFromChestItem(int i)
		{
		}

		// Token: 0x06002FE6 RID: 12262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FE6")]
		[Address(RVA = "0x18AC838", Offset = "0x18AC838", VA = "0x18AC838")]
		public void Resize(int newSize)
		{
		}

		// Token: 0x06002FE7 RID: 12263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FE7")]
		[Address(RVA = "0x18AC854", Offset = "0x18AC854", VA = "0x18AC854")]
		public void FillWithEmptyInstances()
		{
		}

		// Token: 0x06002FE8 RID: 12264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FE8")]
		[Address(RVA = "0x18AC938", Offset = "0x18AC938", VA = "0x18AC938")]
		public void AddItemToShop(Item newItem)
		{
		}

		// Token: 0x06002FE9 RID: 12265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FE9")]
		[Address(RVA = "0x18ACB40", Offset = "0x18ACB40", VA = "0x18ACB40")]
		public static void SetupTravelShop()
		{
		}

		// Token: 0x06002FEA RID: 12266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FEA")]
		[Address(RVA = "0x18AD0B0", Offset = "0x18AD0B0", VA = "0x18AD0B0")]
		public static void SetupTravelShop_AdjustSlotRarities(int slotItemAttempts, ref int[] rarity)
		{
		}

		// Token: 0x06002FEB RID: 12267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FEB")]
		[Address(RVA = "0x18AEB98", Offset = "0x18AEB98", VA = "0x18AEB98")]
		public static void SetupTravelShop_GetPainting(Player playerWithHighestLuck, int[] rarity, ref int it, int minimumRarity = 0)
		{
		}

		// Token: 0x06002FEC RID: 12268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FEC")]
		[Address(RVA = "0x18AE350", Offset = "0x18AE350", VA = "0x18AE350")]
		public static void SetupTravelShop_AddToShop(int itemID, ref int added, ref int count)
		{
		}

		// Token: 0x06002FED RID: 12269 RVA: 0x00017430 File Offset: 0x00015630
		[Token(Token = "0x6002FED")]
		[Address(RVA = "0x18AE20C", Offset = "0x18AE20C", VA = "0x18AE20C")]
		public static bool SetupTravelShop_CanAddItemToShop(int it)
		{
			return default(bool);
		}

		// Token: 0x06002FEE RID: 12270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FEE")]
		[Address(RVA = "0x18AD22C", Offset = "0x18AD22C", VA = "0x18AD22C")]
		public static void SetupTravelShop_GetItem(Player playerWithHighestLuck, int[] rarity, ref int it, int minimumRarity = 0)
		{
		}

		// Token: 0x06002FEF RID: 12271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FEF")]
		[Address(RVA = "0x18AF618", Offset = "0x18AF618", VA = "0x18AF618")]
		public void SetupShop(int type)
		{
		}

		// Token: 0x06002FF0 RID: 12272 RVA: 0x00017448 File Offset: 0x00015648
		[Token(Token = "0x6002FF0")]
		[Address(RVA = "0x18BD428", Offset = "0x18BD428", VA = "0x18BD428")]
		private static bool BestiaryGirl_IsFairyTorchAvailable()
		{
			return default(bool);
		}

		// Token: 0x06002FF1 RID: 12273 RVA: 0x00017460 File Offset: 0x00015660
		[Token(Token = "0x6002FF1")]
		[Address(RVA = "0x18BD4D8", Offset = "0x18BD4D8", VA = "0x18BD4D8")]
		private static bool DidDiscoverBestiaryEntry(int npcId)
		{
			return default(bool);
		}

		// Token: 0x04003F6C RID: 16236
		[Token(Token = "0x4003F6C")]
		public const int DefaultMaxItems = 40;

		// Token: 0x04003F6D RID: 16237
		[Token(Token = "0x4003F6D")]
		public const int AbsoluteMaxItemsWeCanEverReachInAChestForNow = 200;

		// Token: 0x04003F6E RID: 16238
		[Token(Token = "0x4003F6E")]
		[FieldOffset(Offset = "0x8")]
		public int maxItems;

		// Token: 0x04003F6F RID: 16239
		[Token(Token = "0x4003F6F")]
		[FieldOffset(Offset = "0xC")]
		public Item[] item;

		// Token: 0x04003F70 RID: 16240
		[Token(Token = "0x4003F70")]
		[FieldOffset(Offset = "0x10")]
		public Chest underlyingChest;

		// Token: 0x04003F71 RID: 16241
		[Token(Token = "0x4003F71")]
		[FieldOffset(Offset = "0x0")]
		private static Item[] bartenderResort;
	}
}
