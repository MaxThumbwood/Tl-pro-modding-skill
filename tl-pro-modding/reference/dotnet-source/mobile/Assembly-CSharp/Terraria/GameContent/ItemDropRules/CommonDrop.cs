using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000A8A RID: 2698
	[Token(Token = "0x2000A8A")]
	public class CommonDrop : FileAPI
	{
		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x060055B0 RID: 21936 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060055B1 RID: 21937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009D8")]
		public List<IItemDropRuleChainAttempt> ChainedRules
		{
			[Token(Token = "0x60055B0")]
			[Address(RVA = "0x82C770", Offset = "0x82C770", VA = "0x82C770", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60055B1")]
			[Address(RVA = "0x82C778", Offset = "0x82C778", VA = "0x82C778")]
			private set
			{
			}
		}

		// Token: 0x060055B2 RID: 21938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055B2")]
		[Address(RVA = "0x82C780", Offset = "0x82C780", VA = "0x82C780")]
		public CommonDrop(int itemId, int chanceDenominator, int amountDroppedMinimum = 1, int amountDroppedMaximum = 1, int chanceNumerator = 1)
		{
		}

		// Token: 0x060055B3 RID: 21939 RVA: 0x000277B0 File Offset: 0x000259B0
		[Token(Token = "0x60055B3")]
		[Address(RVA = "0x82C840", Offset = "0x82C840", VA = "0x82C840", Slot = "8")]
		public virtual bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		// Token: 0x060055B4 RID: 21940 RVA: 0x000277C8 File Offset: 0x000259C8
		[Token(Token = "0x60055B4")]
		[Address(RVA = "0x82C848", Offset = "0x82C848", VA = "0x82C848", Slot = "9")]
		public virtual ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			return default(ItemDropAttemptResult);
		}

		// Token: 0x060055B5 RID: 21941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055B5")]
		[Address(RVA = "0x82C8E0", Offset = "0x82C8E0", VA = "0x82C8E0", Slot = "10")]
		public virtual void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
		}

		// Token: 0x040098AF RID: 39087
		[Token(Token = "0x40098AF")]
		[FieldOffset(Offset = "0x8")]
		public int itemId;

		// Token: 0x040098B0 RID: 39088
		[Token(Token = "0x40098B0")]
		[FieldOffset(Offset = "0xC")]
		public int chanceDenominator;

		// Token: 0x040098B1 RID: 39089
		[Token(Token = "0x40098B1")]
		[FieldOffset(Offset = "0x10")]
		public int amountDroppedMinimum;

		// Token: 0x040098B2 RID: 39090
		[Token(Token = "0x40098B2")]
		[FieldOffset(Offset = "0x14")]
		public int amountDroppedMaximum;

		// Token: 0x040098B3 RID: 39091
		[Token(Token = "0x40098B3")]
		[FieldOffset(Offset = "0x18")]
		public int chanceNumerator;

		// Token: 0x040098B4 RID: 39092
		[Token(Token = "0x40098B4")]
		[FieldOffset(Offset = "0x1C")]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;
	}
}
