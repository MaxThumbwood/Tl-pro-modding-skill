using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000A9D RID: 2717
	[Token(Token = "0x2000A9D")]
	public class OneFromOptionsDropRule : FileAPI
	{
		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x0600560F RID: 22031 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005610 RID: 22032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009E4")]
		public List<IItemDropRuleChainAttempt> ChainedRules
		{
			[Token(Token = "0x600560F")]
			[Address(RVA = "0x8311E4", Offset = "0x8311E4", VA = "0x8311E4", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005610")]
			[Address(RVA = "0x8311EC", Offset = "0x8311EC", VA = "0x8311EC")]
			private set
			{
			}
		}

		// Token: 0x06005611 RID: 22033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005611")]
		[Address(RVA = "0x8311F4", Offset = "0x8311F4", VA = "0x8311F4")]
		public OneFromOptionsDropRule(int chanceDenominator, int chanceNumerator, int[] options)
		{
		}

		// Token: 0x06005612 RID: 22034 RVA: 0x00027B28 File Offset: 0x00025D28
		[Token(Token = "0x6005612")]
		[Address(RVA = "0x8312A4", Offset = "0x8312A4", VA = "0x8312A4", Slot = "5")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		// Token: 0x06005613 RID: 22035 RVA: 0x00027B40 File Offset: 0x00025D40
		[Token(Token = "0x6005613")]
		[Address(RVA = "0x8312AC", Offset = "0x8312AC", VA = "0x8312AC", Slot = "7")]
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			return default(ItemDropAttemptResult);
		}

		// Token: 0x06005614 RID: 22036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005614")]
		[Address(RVA = "0x831364", Offset = "0x831364", VA = "0x831364", Slot = "6")]
		public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
		}

		// Token: 0x040098DC RID: 39132
		[Token(Token = "0x40098DC")]
		[FieldOffset(Offset = "0x8")]
		public int[] dropIds;

		// Token: 0x040098DD RID: 39133
		[Token(Token = "0x40098DD")]
		[FieldOffset(Offset = "0xC")]
		public int chanceDenominator;

		// Token: 0x040098DE RID: 39134
		[Token(Token = "0x40098DE")]
		[FieldOffset(Offset = "0x10")]
		public int chanceNumerator;

		// Token: 0x040098DF RID: 39135
		[Token(Token = "0x40098DF")]
		[FieldOffset(Offset = "0x14")]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;
	}
}
