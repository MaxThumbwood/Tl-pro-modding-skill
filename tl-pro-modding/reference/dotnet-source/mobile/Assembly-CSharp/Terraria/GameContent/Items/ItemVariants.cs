using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.Items
{
	// Token: 0x02000A6A RID: 2666
	[Token(Token = "0x2000A6A")]
	public static class ItemVariants
	{
		// Token: 0x0600551E RID: 21790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600551E")]
		[Address(RVA = "0x82469C", Offset = "0x82469C", VA = "0x82469C")]
		public static IEnumerable<ItemVariants.VariantEntry> GetVariants(int itemId)
		{
			return null;
		}

		// Token: 0x0600551F RID: 21791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600551F")]
		[Address(RVA = "0x824810", Offset = "0x824810", VA = "0x824810")]
		private static ItemVariants.VariantEntry GetEntry(int itemId, ItemVariant variant)
		{
			return null;
		}

		// Token: 0x06005520 RID: 21792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005520")]
		[Address(RVA = "0x82496C", Offset = "0x82496C", VA = "0x82496C")]
		public static void AddVariant(int itemId, ItemVariant variant, ItemVariantCondition[] conditions)
		{
		}

		// Token: 0x06005521 RID: 21793 RVA: 0x000274F8 File Offset: 0x000256F8
		[Token(Token = "0x6005521")]
		[Address(RVA = "0x824D94", Offset = "0x824D94", VA = "0x824D94")]
		public static bool HasVariant(int itemId, ItemVariant variant)
		{
			return default(bool);
		}

		// Token: 0x06005522 RID: 21794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005522")]
		[Address(RVA = "0x824E08", Offset = "0x824E08", VA = "0x824E08")]
		public static ItemVariant SelectVariant(int itemId)
		{
			return null;
		}

		// Token: 0x04009873 RID: 39027
		[Token(Token = "0x4009873")]
		[FieldOffset(Offset = "0x0")]
		private static List<ItemVariants.VariantEntry>[] _variants;

		// Token: 0x04009874 RID: 39028
		[Token(Token = "0x4009874")]
		[FieldOffset(Offset = "0x4")]
		public static ItemVariant StrongerVariant;

		// Token: 0x04009875 RID: 39029
		[Token(Token = "0x4009875")]
		[FieldOffset(Offset = "0x8")]
		public static ItemVariant WeakerVariant;

		// Token: 0x04009876 RID: 39030
		[Token(Token = "0x4009876")]
		[FieldOffset(Offset = "0xC")]
		public static ItemVariant RebalancedVariant;

		// Token: 0x04009877 RID: 39031
		[Token(Token = "0x4009877")]
		[FieldOffset(Offset = "0x10")]
		public static ItemVariant EnabledVariant;

		// Token: 0x04009878 RID: 39032
		[Token(Token = "0x4009878")]
		[FieldOffset(Offset = "0x14")]
		public static ItemVariant DisabledBossSummonVariant;

		// Token: 0x04009879 RID: 39033
		[Token(Token = "0x4009879")]
		[FieldOffset(Offset = "0x18")]
		public static ItemVariantCondition RemixWorld;

		// Token: 0x0400987A RID: 39034
		[Token(Token = "0x400987A")]
		[FieldOffset(Offset = "0x1C")]
		public static ItemVariantCondition GetGoodWorld;

		// Token: 0x0400987B RID: 39035
		[Token(Token = "0x400987B")]
		[FieldOffset(Offset = "0x20")]
		public static ItemVariantCondition MechdusaWorld;

		// Token: 0x0400987C RID: 39036
		[Token(Token = "0x400987C")]
		[FieldOffset(Offset = "0x24")]
		public static ItemVariantCondition SkyblockWorld;

		// Token: 0x02000A6B RID: 2667
		[Token(Token = "0x2000A6B")]
		public class VariantEntry
		{
			// Token: 0x170009D3 RID: 2515
			// (get) Token: 0x06005524 RID: 21796 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009D3")]
			public IEnumerable<ItemVariantCondition> Conditions
			{
				[Token(Token = "0x6005524")]
				[Address(RVA = "0x82671C", Offset = "0x82671C", VA = "0x82671C")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005525 RID: 21797 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005525")]
			[Address(RVA = "0x824C88", Offset = "0x824C88", VA = "0x824C88")]
			public VariantEntry(ItemVariant variant)
			{
			}

			// Token: 0x06005526 RID: 21798 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005526")]
			[Address(RVA = "0x824D28", Offset = "0x824D28", VA = "0x824D28")]
			internal void AddConditions(IEnumerable<ItemVariantCondition> conditions)
			{
			}

			// Token: 0x06005527 RID: 21799 RVA: 0x00027510 File Offset: 0x00025710
			[Token(Token = "0x6005527")]
			[Address(RVA = "0x8250A8", Offset = "0x8250A8", VA = "0x8250A8")]
			public bool AnyConditionMet()
			{
				return default(bool);
			}

			// Token: 0x0400987D RID: 39037
			[Token(Token = "0x400987D")]
			[FieldOffset(Offset = "0x8")]
			public readonly ItemVariant Variant;

			// Token: 0x0400987E RID: 39038
			[Token(Token = "0x400987E")]
			[FieldOffset(Offset = "0xC")]
			private readonly List<ItemVariantCondition> _conditions;

			// Token: 0x02000A6C RID: 2668
			[Token(Token = "0x2000A6C")]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x06005529 RID: 21801 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005529")]
				[Address(RVA = "0x826798", Offset = "0x826798", VA = "0x826798")]
				public <>c()
				{
				}

				// Token: 0x0600552A RID: 21802 RVA: 0x00027528 File Offset: 0x00025728
				[Token(Token = "0x600552A")]
				[Address(RVA = "0x8267A0", Offset = "0x8267A0", VA = "0x8267A0")]
				internal bool <AnyConditionMet>b__6_0(ItemVariantCondition c)
				{
					return default(bool);
				}

				// Token: 0x0400987F RID: 39039
				[Token(Token = "0x400987F")]
				[FieldOffset(Offset = "0x0")]
				public static readonly ItemVariants.VariantEntry.<>c <>9;

				// Token: 0x04009880 RID: 39040
				[Token(Token = "0x4009880")]
				[FieldOffset(Offset = "0x4")]
				public static Func<ItemVariantCondition, bool> <>9__6_0;
			}
		}

		// Token: 0x02000A6D RID: 2669
		[Token(Token = "0x2000A6D")]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x0600552B RID: 21803 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600552B")]
			[Address(RVA = "0x824964", Offset = "0x824964", VA = "0x824964")]
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x0600552C RID: 21804 RVA: 0x00027540 File Offset: 0x00025740
			[Token(Token = "0x600552C")]
			[Address(RVA = "0x8267D8", Offset = "0x8267D8", VA = "0x8267D8")]
			internal bool <GetEntry>b__0(ItemVariants.VariantEntry v)
			{
				return default(bool);
			}

			// Token: 0x04009881 RID: 39041
			[Token(Token = "0x4009881")]
			[FieldOffset(Offset = "0x8")]
			public ItemVariant variant;
		}

		// Token: 0x02000A6E RID: 2670
		[Token(Token = "0x2000A6E")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600552E RID: 21806 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600552E")]
			[Address(RVA = "0x82687C", Offset = "0x82687C", VA = "0x82687C")]
			public <>c()
			{
			}

			// Token: 0x0600552F RID: 21807 RVA: 0x00027558 File Offset: 0x00025758
			[Token(Token = "0x600552F")]
			[Address(RVA = "0x826884", Offset = "0x826884", VA = "0x826884")]
			internal bool <.cctor>b__16_0()
			{
				return default(bool);
			}

			// Token: 0x06005530 RID: 21808 RVA: 0x00027570 File Offset: 0x00025770
			[Token(Token = "0x6005530")]
			[Address(RVA = "0x8268E8", Offset = "0x8268E8", VA = "0x8268E8")]
			internal bool <.cctor>b__16_1()
			{
				return default(bool);
			}

			// Token: 0x06005531 RID: 21809 RVA: 0x00027588 File Offset: 0x00025788
			[Token(Token = "0x6005531")]
			[Address(RVA = "0x82694C", Offset = "0x82694C", VA = "0x82694C")]
			internal bool <.cctor>b__16_2()
			{
				return default(bool);
			}

			// Token: 0x06005532 RID: 21810 RVA: 0x000275A0 File Offset: 0x000257A0
			[Token(Token = "0x6005532")]
			[Address(RVA = "0x826954", Offset = "0x826954", VA = "0x826954")]
			internal bool <.cctor>b__16_3()
			{
				return default(bool);
			}

			// Token: 0x04009882 RID: 39042
			[Token(Token = "0x4009882")]
			[FieldOffset(Offset = "0x0")]
			public static readonly ItemVariants.<>c <>9;
		}
	}
}
