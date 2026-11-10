using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000A96 RID: 2710
	[Token(Token = "0x2000A96")]
	public class StatueMimicItemDropRule : FileAPI
	{
		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x060055EC RID: 21996 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060055ED RID: 21997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009DF")]
		public List<IItemDropRuleChainAttempt> ChainedRules
		{
			[Token(Token = "0x60055EC")]
			[Address(RVA = "0x82FB98", Offset = "0x82FB98", VA = "0x82FB98", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60055ED")]
			[Address(RVA = "0x82FBA0", Offset = "0x82FBA0", VA = "0x82FBA0")]
			private set
			{
			}
		}

		// Token: 0x060055EE RID: 21998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055EE")]
		[Address(RVA = "0x82FBA8", Offset = "0x82FBA8", VA = "0x82FBA8")]
		public StatueMimicItemDropRule()
		{
		}

		// Token: 0x060055EF RID: 21999 RVA: 0x00027A08 File Offset: 0x00025C08
		[Token(Token = "0x60055EF")]
		[Address(RVA = "0x82FC40", Offset = "0x82FC40", VA = "0x82FC40", Slot = "5")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		// Token: 0x060055F0 RID: 22000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055F0")]
		[Address(RVA = "0x82FCB4", Offset = "0x82FCB4", VA = "0x82FCB4", Slot = "6")]
		public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
		}

		// Token: 0x060055F1 RID: 22001 RVA: 0x00027A20 File Offset: 0x00025C20
		[Token(Token = "0x60055F1")]
		[Address(RVA = "0x82FCE0", Offset = "0x82FCE0", VA = "0x82FCE0", Slot = "7")]
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			return default(ItemDropAttemptResult);
		}

		// Token: 0x040098C8 RID: 39112
		[Token(Token = "0x40098C8")]
		[FieldOffset(Offset = "0x8")]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;
	}
}
