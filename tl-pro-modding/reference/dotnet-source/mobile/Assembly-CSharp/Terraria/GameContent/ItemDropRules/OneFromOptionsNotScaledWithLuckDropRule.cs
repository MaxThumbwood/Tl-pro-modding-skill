using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000A9C RID: 2716
	[Token(Token = "0x2000A9C")]
	public class OneFromOptionsNotScaledWithLuckDropRule : FileAPI
	{
		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06005609 RID: 22025 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600560A RID: 22026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009E3")]
		public List<IItemDropRuleChainAttempt> ChainedRules
		{
			[Token(Token = "0x6005609")]
			[Address(RVA = "0x830DFC", Offset = "0x830DFC", VA = "0x830DFC", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600560A")]
			[Address(RVA = "0x830E04", Offset = "0x830E04", VA = "0x830E04")]
			private set
			{
			}
		}

		// Token: 0x0600560B RID: 22027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600560B")]
		[Address(RVA = "0x830E0C", Offset = "0x830E0C", VA = "0x830E0C")]
		public OneFromOptionsNotScaledWithLuckDropRule(int chanceDenominator, int chanceNumerator, int[] options)
		{
		}

		// Token: 0x0600560C RID: 22028 RVA: 0x00027AF8 File Offset: 0x00025CF8
		[Token(Token = "0x600560C")]
		[Address(RVA = "0x830EBC", Offset = "0x830EBC", VA = "0x830EBC", Slot = "5")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		// Token: 0x0600560D RID: 22029 RVA: 0x00027B10 File Offset: 0x00025D10
		[Token(Token = "0x600560D")]
		[Address(RVA = "0x830EC4", Offset = "0x830EC4", VA = "0x830EC4", Slot = "7")]
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			return default(ItemDropAttemptResult);
		}

		// Token: 0x0600560E RID: 22030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600560E")]
		[Address(RVA = "0x830F78", Offset = "0x830F78", VA = "0x830F78", Slot = "6")]
		public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
		}

		// Token: 0x040098D8 RID: 39128
		[Token(Token = "0x40098D8")]
		[FieldOffset(Offset = "0x8")]
		public int[] dropIds;

		// Token: 0x040098D9 RID: 39129
		[Token(Token = "0x40098D9")]
		[FieldOffset(Offset = "0xC")]
		public int chanceDenominator;

		// Token: 0x040098DA RID: 39130
		[Token(Token = "0x40098DA")]
		[FieldOffset(Offset = "0x10")]
		public int chanceNumerator;

		// Token: 0x040098DB RID: 39131
		[Token(Token = "0x40098DB")]
		[FieldOffset(Offset = "0x14")]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;
	}
}
