using System;
using Il2CppDummyDll;

namespace Terraria.ID
{
	// Token: 0x02000701 RID: 1793
	[Token(Token = "0x2000701")]
	public static class PlayerItemSlotID
	{
		// Token: 0x060041C2 RID: 16834 RVA: 0x000201D8 File Offset: 0x0001E3D8
		[Token(Token = "0x60041C2")]
		[Address(RVA = "0x1F7539C", Offset = "0x1F7539C", VA = "0x1F7539C")]
		private static int AllocateSlots(int amount, bool canNetRelay)
		{
			return 0;
		}

		// Token: 0x04007BC7 RID: 31687
		[Token(Token = "0x4007BC7")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int Inventory0;

		// Token: 0x04007BC8 RID: 31688
		[Token(Token = "0x4007BC8")]
		[FieldOffset(Offset = "0x4")]
		public static readonly int InventoryMouseItem;

		// Token: 0x04007BC9 RID: 31689
		[Token(Token = "0x4007BC9")]
		[FieldOffset(Offset = "0x8")]
		public static readonly int Armor0;

		// Token: 0x04007BCA RID: 31690
		[Token(Token = "0x4007BCA")]
		[FieldOffset(Offset = "0xC")]
		public static readonly int Dye0;

		// Token: 0x04007BCB RID: 31691
		[Token(Token = "0x4007BCB")]
		[FieldOffset(Offset = "0x10")]
		public static readonly int Misc0;

		// Token: 0x04007BCC RID: 31692
		[Token(Token = "0x4007BCC")]
		[FieldOffset(Offset = "0x14")]
		public static readonly int MiscDye0;

		// Token: 0x04007BCD RID: 31693
		[Token(Token = "0x4007BCD")]
		[FieldOffset(Offset = "0x18")]
		public static readonly int Bank1_0;

		// Token: 0x04007BCE RID: 31694
		[Token(Token = "0x4007BCE")]
		[FieldOffset(Offset = "0x1C")]
		public static readonly int Bank2_0;

		// Token: 0x04007BCF RID: 31695
		[Token(Token = "0x4007BCF")]
		[FieldOffset(Offset = "0x20")]
		public static readonly int TrashItem;

		// Token: 0x04007BD0 RID: 31696
		[Token(Token = "0x4007BD0")]
		[FieldOffset(Offset = "0x24")]
		public static readonly int Bank3_0;

		// Token: 0x04007BD1 RID: 31697
		[Token(Token = "0x4007BD1")]
		[FieldOffset(Offset = "0x28")]
		public static readonly int Bank4_0;

		// Token: 0x04007BD2 RID: 31698
		[Token(Token = "0x4007BD2")]
		[FieldOffset(Offset = "0x2C")]
		public static readonly int Loadout1_Armor_0;

		// Token: 0x04007BD3 RID: 31699
		[Token(Token = "0x4007BD3")]
		[FieldOffset(Offset = "0x30")]
		public static readonly int Loadout1_Dye_0;

		// Token: 0x04007BD4 RID: 31700
		[Token(Token = "0x4007BD4")]
		[FieldOffset(Offset = "0x34")]
		public static readonly int Loadout2_Armor_0;

		// Token: 0x04007BD5 RID: 31701
		[Token(Token = "0x4007BD5")]
		[FieldOffset(Offset = "0x38")]
		public static readonly int Loadout2_Dye_0;

		// Token: 0x04007BD6 RID: 31702
		[Token(Token = "0x4007BD6")]
		[FieldOffset(Offset = "0x3C")]
		public static readonly int Loadout3_Armor_0;

		// Token: 0x04007BD7 RID: 31703
		[Token(Token = "0x4007BD7")]
		[FieldOffset(Offset = "0x40")]
		public static readonly int Loadout3_Dye_0;

		// Token: 0x04007BD8 RID: 31704
		[Token(Token = "0x4007BD8")]
		[FieldOffset(Offset = "0x44")]
		public static readonly int Count;

		// Token: 0x04007BD9 RID: 31705
		[Token(Token = "0x4007BD9")]
		[FieldOffset(Offset = "0x48")]
		public static bool[] CanRelay;

		// Token: 0x04007BDA RID: 31706
		[Token(Token = "0x4007BDA")]
		[FieldOffset(Offset = "0x4C")]
		private static int _nextSlotId;

		// Token: 0x02000702 RID: 1794
		[Token(Token = "0x2000702")]
		public struct SlotReference
		{
			// Token: 0x060041C3 RID: 16835 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60041C3")]
			[Address(RVA = "0x1F754C0", Offset = "0x1F754C0", VA = "0x1F754C0")]
			public SlotReference(Player player, int slot)
			{
			}

			// Token: 0x17000815 RID: 2069
			// (get) Token: 0x060041C4 RID: 16836 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060041C5 RID: 16837 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000815")]
			public Item Item
			{
				[Token(Token = "0x60041C4")]
				[Address(RVA = "0x1F754C8", Offset = "0x1F754C8", VA = "0x1F754C8")]
				get
				{
					return null;
				}
				[Token(Token = "0x60041C5")]
				[Address(RVA = "0x1F75C20", Offset = "0x1F75C20", VA = "0x1F75C20")]
				set
				{
				}
			}

			// Token: 0x060041C6 RID: 16838 RVA: 0x000201F0 File Offset: 0x0001E3F0
			[Token(Token = "0x60041C6")]
			[Address(RVA = "0x1F7562C", Offset = "0x1F7562C", VA = "0x1F7562C")]
			private bool TryGetArraySlot(out Item[] arr, out int slot)
			{
				return default(bool);
			}

			// Token: 0x04007BDB RID: 31707
			[Token(Token = "0x4007BDB")]
			[FieldOffset(Offset = "0x0")]
			public readonly Player Player;

			// Token: 0x04007BDC RID: 31708
			[Token(Token = "0x4007BDC")]
			[FieldOffset(Offset = "0x4")]
			public readonly int SlotId;
		}
	}
}
