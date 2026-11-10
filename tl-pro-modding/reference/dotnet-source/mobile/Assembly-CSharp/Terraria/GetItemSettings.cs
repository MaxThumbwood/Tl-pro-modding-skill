using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Terraria
{
	// Token: 0x020004E9 RID: 1257
	[Token(Token = "0x20004E9")]
	public struct GetItemSettings
	{
		// Token: 0x06003166 RID: 12646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003166")]
		[Address(RVA = "0x19FA670", Offset = "0x19FA670", VA = "0x19FA670")]
		public GetItemSettings(bool LongText = false, bool NoText = false, bool CanGoIntoVoidVault = false, bool NoSound = false, [Optional] Action<Item> StepAfterHandlingSlotNormally, bool NoCoinMerge = false)
		{
		}

		// Token: 0x06003167 RID: 12647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003167")]
		[Address(RVA = "0x19FA69C", Offset = "0x19FA69C", VA = "0x19FA69C")]
		public void HandlePostAction(Item item)
		{
		}

		// Token: 0x06003168 RID: 12648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003168")]
		[Address(RVA = "0x19FA6B8", Offset = "0x19FA6B8", VA = "0x19FA6B8")]
		private static void MakeNewAndShiny(Item item)
		{
		}

		// Token: 0x04004206 RID: 16902
		[Token(Token = "0x4004206")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static GetItemSettings GiftRecieved;

		// Token: 0x04004207 RID: 16903
		[Token(Token = "0x4004207")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static GetItemSettings LootAllFromBank;

		// Token: 0x04004208 RID: 16904
		[Token(Token = "0x4004208")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static GetItemSettings LootAllFromChest;

		// Token: 0x04004209 RID: 16905
		[Token(Token = "0x4004209")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static GetItemSettings PickupItemFromWorld;

		// Token: 0x0400420A RID: 16906
		[Token(Token = "0x400420A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static GetItemSettings QuickTransferFromSlot;

		// Token: 0x0400420B RID: 16907
		[Token(Token = "0x400420B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static GetItemSettings ReturnItemFromSlot;

		// Token: 0x0400420C RID: 16908
		[Token(Token = "0x400420C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static GetItemSettings ReturnItemShowAsNew;

		// Token: 0x0400420D RID: 16909
		[Token(Token = "0x400420D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public static GetItemSettings InventoryEntityToPlayerInventorySettings;

		// Token: 0x0400420E RID: 16910
		[Token(Token = "0x400420E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static GetItemSettings NPCEntityToPlayerInventorySettings;

		// Token: 0x0400420F RID: 16911
		[Token(Token = "0x400420F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public static GetItemSettings LootAllSettings;

		// Token: 0x04004210 RID: 16912
		[Token(Token = "0x4004210")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static GetItemSettings LootAllSettingsRegularChest;

		// Token: 0x04004211 RID: 16913
		[Token(Token = "0x4004211")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public static GetItemSettings GetItemInDropItemCheck;

		// Token: 0x04004212 RID: 16914
		[Token(Token = "0x4004212")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public static GetItemSettings InventoryUIToInventorySettings;

		// Token: 0x04004213 RID: 16915
		[Token(Token = "0x4004213")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public static GetItemSettings InventoryUIToInventorySettingsShowAsNew;

		// Token: 0x04004214 RID: 16916
		[Token(Token = "0x4004214")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public static GetItemSettings ItemCreatedFromItemUsage;

		// Token: 0x04004215 RID: 16917
		[Token(Token = "0x4004215")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public static GetItemSettings RefundConsumedItem;

		// Token: 0x04004216 RID: 16918
		[Token(Token = "0x4004216")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public static GetItemSettings ReturnItemShowAsNewNoCoinMerge;

		// Token: 0x04004217 RID: 16919
		[Token(Token = "0x4004217")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly bool LongText;

		// Token: 0x04004218 RID: 16920
		[Token(Token = "0x4004218")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public readonly bool NoText;

		// Token: 0x04004219 RID: 16921
		[Token(Token = "0x4004219")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public readonly bool CanGoIntoVoidVault;

		// Token: 0x0400421A RID: 16922
		[Token(Token = "0x400421A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		public readonly bool NoSound;

		// Token: 0x0400421B RID: 16923
		[Token(Token = "0x400421B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public bool NoCoinMerge;

		// Token: 0x0400421C RID: 16924
		[Token(Token = "0x400421C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly Action<Item> StepAfterHandlingSlotNormally;
	}
}
