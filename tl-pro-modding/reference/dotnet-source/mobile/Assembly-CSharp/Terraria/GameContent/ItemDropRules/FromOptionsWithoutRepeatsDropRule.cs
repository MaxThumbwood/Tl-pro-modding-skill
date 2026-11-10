using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000A9E RID: 2718
	[Token(Token = "0x2000A9E")]
	public class FromOptionsWithoutRepeatsDropRule : FileAPI
	{
		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06005615 RID: 22037 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005616 RID: 22038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009E5")]
		public List<IItemDropRuleChainAttempt> ChainedRules
		{
			[Token(Token = "0x6005615")]
			[Address(RVA = "0x8315D0", Offset = "0x8315D0", VA = "0x8315D0", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005616")]
			[Address(RVA = "0x8315D8", Offset = "0x8315D8", VA = "0x8315D8")]
			private set
			{
			}
		}

		// Token: 0x06005617 RID: 22039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005617")]
		[Address(RVA = "0x8315E0", Offset = "0x8315E0", VA = "0x8315E0")]
		public FromOptionsWithoutRepeatsDropRule(int dropCount, int[] options)
		{
		}

		// Token: 0x06005618 RID: 22040 RVA: 0x00027B58 File Offset: 0x00025D58
		[Token(Token = "0x6005618")]
		[Address(RVA = "0x8316E8", Offset = "0x8316E8", VA = "0x8316E8", Slot = "5")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		// Token: 0x06005619 RID: 22041 RVA: 0x00027B70 File Offset: 0x00025D70
		[Token(Token = "0x6005619")]
		[Address(RVA = "0x8316F0", Offset = "0x8316F0", VA = "0x8316F0", Slot = "7")]
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			return default(ItemDropAttemptResult);
		}

		// Token: 0x0600561A RID: 22042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600561A")]
		[Address(RVA = "0x8318BC", Offset = "0x8318BC", VA = "0x8318BC", Slot = "6")]
		public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
		}

		// Token: 0x040098E0 RID: 39136
		[Token(Token = "0x40098E0")]
		[FieldOffset(Offset = "0x8")]
		public int[] dropIds;

		// Token: 0x040098E1 RID: 39137
		[Token(Token = "0x40098E1")]
		[FieldOffset(Offset = "0xC")]
		public int dropCount;

		// Token: 0x040098E2 RID: 39138
		[Token(Token = "0x40098E2")]
		[FieldOffset(Offset = "0x10")]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;

		// Token: 0x040098E3 RID: 39139
		[Token(Token = "0x40098E3")]
		[FieldOffset(Offset = "0x14")]
		private List<int> _temporaryAvailableItems;
	}
}
