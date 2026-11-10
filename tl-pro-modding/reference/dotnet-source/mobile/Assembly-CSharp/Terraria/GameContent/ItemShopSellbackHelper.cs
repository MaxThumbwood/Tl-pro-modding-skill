using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent
{
	// Token: 0x0200098C RID: 2444
	[Token(Token = "0x200098C")]
	public class ItemShopSellbackHelper
	{
		// Token: 0x06005086 RID: 20614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005086")]
		[Address(RVA = "0x76CA18", Offset = "0x76CA18", VA = "0x76CA18")]
		public void Add(Item item)
		{
		}

		// Token: 0x06005087 RID: 20615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005087")]
		[Address(RVA = "0x76CCF0", Offset = "0x76CCF0", VA = "0x76CCF0")]
		public void Clear()
		{
		}

		// Token: 0x06005088 RID: 20616 RVA: 0x000257A0 File Offset: 0x000239A0
		[Token(Token = "0x6005088")]
		[Address(RVA = "0x76CD70", Offset = "0x76CD70", VA = "0x76CD70")]
		public int GetAmount(Item item)
		{
			return 0;
		}

		// Token: 0x06005089 RID: 20617 RVA: 0x000257B8 File Offset: 0x000239B8
		[Token(Token = "0x6005089")]
		[Address(RVA = "0x76CEB0", Offset = "0x76CEB0", VA = "0x76CEB0")]
		public int Remove(Item item)
		{
			return 0;
		}

		// Token: 0x0600508A RID: 20618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600508A")]
		[Address(RVA = "0x76D064", Offset = "0x76D064", VA = "0x76D064")]
		public ItemShopSellbackHelper()
		{
		}

		// Token: 0x0400947C RID: 38012
		[Token(Token = "0x400947C")]
		[FieldOffset(Offset = "0x8")]
		private List<ItemShopSellbackHelper.ItemMemo> _memos;

		// Token: 0x0200098D RID: 2445
		[Token(Token = "0x200098D")]
		private class ItemMemo
		{
			// Token: 0x0600508B RID: 20619 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600508B")]
			[Address(RVA = "0x76CC90", Offset = "0x76CC90", VA = "0x76CC90")]
			public ItemMemo(Item item)
			{
			}

			// Token: 0x0600508C RID: 20620 RVA: 0x000257D0 File Offset: 0x000239D0
			[Token(Token = "0x600508C")]
			[Address(RVA = "0x76D0FC", Offset = "0x76D0FC", VA = "0x76D0FC")]
			public bool Matches(Item item)
			{
				return default(bool);
			}

			// Token: 0x0400947D RID: 38013
			[Token(Token = "0x400947D")]
			[FieldOffset(Offset = "0x8")]
			public readonly int type;

			// Token: 0x0400947E RID: 38014
			[Token(Token = "0x400947E")]
			[FieldOffset(Offset = "0xC")]
			public readonly int prefix;

			// Token: 0x0400947F RID: 38015
			[Token(Token = "0x400947F")]
			[FieldOffset(Offset = "0x10")]
			public int stack;
		}

		// Token: 0x0200098E RID: 2446
		[Token(Token = "0x200098E")]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x0600508D RID: 20621 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600508D")]
			[Address(RVA = "0x76CC88", Offset = "0x76CC88", VA = "0x76CC88")]
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x0600508E RID: 20622 RVA: 0x000257E8 File Offset: 0x000239E8
			[Token(Token = "0x600508E")]
			[Address(RVA = "0x76D15C", Offset = "0x76D15C", VA = "0x76D15C")]
			internal bool <Add>b__0(ItemShopSellbackHelper.ItemMemo x)
			{
				return default(bool);
			}

			// Token: 0x04009480 RID: 38016
			[Token(Token = "0x4009480")]
			[FieldOffset(Offset = "0x8")]
			public Item item;
		}

		// Token: 0x0200098F RID: 2447
		[Token(Token = "0x200098F")]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x0600508F RID: 20623 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600508F")]
			[Address(RVA = "0x76CEA8", Offset = "0x76CEA8", VA = "0x76CEA8")]
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x06005090 RID: 20624 RVA: 0x00025800 File Offset: 0x00023A00
			[Token(Token = "0x6005090")]
			[Address(RVA = "0x76D1C8", Offset = "0x76D1C8", VA = "0x76D1C8")]
			internal bool <GetAmount>b__0(ItemShopSellbackHelper.ItemMemo x)
			{
				return default(bool);
			}

			// Token: 0x04009481 RID: 38017
			[Token(Token = "0x4009481")]
			[FieldOffset(Offset = "0x8")]
			public Item item;
		}

		// Token: 0x02000990 RID: 2448
		[Token(Token = "0x2000990")]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06005091 RID: 20625 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005091")]
			[Address(RVA = "0x76D05C", Offset = "0x76D05C", VA = "0x76D05C")]
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x06005092 RID: 20626 RVA: 0x00025818 File Offset: 0x00023A18
			[Token(Token = "0x6005092")]
			[Address(RVA = "0x76D234", Offset = "0x76D234", VA = "0x76D234")]
			internal bool <Remove>b__0(ItemShopSellbackHelper.ItemMemo x)
			{
				return default(bool);
			}

			// Token: 0x04009482 RID: 38018
			[Token(Token = "0x4009482")]
			[FieldOffset(Offset = "0x8")]
			public Item item;
		}
	}
}
