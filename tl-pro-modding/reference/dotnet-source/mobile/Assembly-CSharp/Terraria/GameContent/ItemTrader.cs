using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent
{
	// Token: 0x02000991 RID: 2449
	[Token(Token = "0x2000991")]
	public class ItemTrader
	{
		// Token: 0x06005093 RID: 20627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005093")]
		[Address(RVA = "0x76D2A0", Offset = "0x76D2A0", VA = "0x76D2A0")]
		public void AddOption_Interchangable(int itemType1, int itemType2)
		{
		}

		// Token: 0x06005094 RID: 20628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005094")]
		[Address(RVA = "0x76D434", Offset = "0x76D434", VA = "0x76D434")]
		public void AddOption_CyclicLoop(int[] typesInOrder)
		{
		}

		// Token: 0x06005095 RID: 20629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005095")]
		[Address(RVA = "0x76D4DC", Offset = "0x76D4DC", VA = "0x76D4DC")]
		public void AddOption_FromAny(int givingItemType, int[] takingItemTypes)
		{
		}

		// Token: 0x06005096 RID: 20630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005096")]
		[Address(RVA = "0x76D2E8", Offset = "0x76D2E8", VA = "0x76D2E8")]
		public void AddOption_OneWay(int takingItemType, int takingItemStack, int givingItemType, int givingItemStack)
		{
		}

		// Token: 0x06005097 RID: 20631 RVA: 0x00025830 File Offset: 0x00023A30
		[Token(Token = "0x6005097")]
		[Address(RVA = "0x76D54C", Offset = "0x76D54C", VA = "0x76D54C")]
		public bool TryGetTradeOption(Item item, out ItemTrader.TradeOption option)
		{
			return default(bool);
		}

		// Token: 0x06005098 RID: 20632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005098")]
		[Address(RVA = "0x76D67C", Offset = "0x76D67C", VA = "0x76D67C")]
		public static ItemTrader CreateChlorophyteExtractinator()
		{
			return null;
		}

		// Token: 0x06005099 RID: 20633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005099")]
		[Address(RVA = "0x76E050", Offset = "0x76E050", VA = "0x76E050")]
		public ItemTrader()
		{
		}

		// Token: 0x04009483 RID: 38019
		[Token(Token = "0x4009483")]
		[FieldOffset(Offset = "0x0")]
		public static ItemTrader ChlorophyteExtractinator;

		// Token: 0x04009484 RID: 38020
		[Token(Token = "0x4009484")]
		[FieldOffset(Offset = "0x8")]
		private List<ItemTrader.TradeOption> _options;

		// Token: 0x02000992 RID: 2450
		[Token(Token = "0x2000992")]
		public class TradeOption
		{
			// Token: 0x0600509B RID: 20635 RVA: 0x00025848 File Offset: 0x00023A48
			[Token(Token = "0x600509B")]
			[Address(RVA = "0x76D658", Offset = "0x76D658", VA = "0x76D658")]
			public bool WillTradeFor(int offeredItemType, int offeredItemStack)
			{
				return default(bool);
			}

			// Token: 0x0600509C RID: 20636 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600509C")]
			[Address(RVA = "0x76D544", Offset = "0x76D544", VA = "0x76D544")]
			public TradeOption()
			{
			}

			// Token: 0x04009485 RID: 38021
			[Token(Token = "0x4009485")]
			[FieldOffset(Offset = "0x8")]
			public int TakingItemType;

			// Token: 0x04009486 RID: 38022
			[Token(Token = "0x4009486")]
			[FieldOffset(Offset = "0xC")]
			public int TakingItemStack;

			// Token: 0x04009487 RID: 38023
			[Token(Token = "0x4009487")]
			[FieldOffset(Offset = "0x10")]
			public int GivingItemType;

			// Token: 0x04009488 RID: 38024
			[Token(Token = "0x4009488")]
			[FieldOffset(Offset = "0x14")]
			public int GivingItemStack;
		}
	}
}
