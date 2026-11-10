using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000A99 RID: 2713
	[Token(Token = "0x2000A99")]
	public class LeadingConditionRule : FileAPI
	{
		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x060055FC RID: 22012 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060055FD RID: 22013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009E1")]
		public List<IItemDropRuleChainAttempt> ChainedRules
		{
			[Token(Token = "0x60055FC")]
			[Address(RVA = "0x8307A8", Offset = "0x8307A8", VA = "0x8307A8", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60055FD")]
			[Address(RVA = "0x8307B0", Offset = "0x8307B0", VA = "0x8307B0")]
			private set
			{
			}
		}

		// Token: 0x060055FE RID: 22014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055FE")]
		[Address(RVA = "0x8307B8", Offset = "0x8307B8", VA = "0x8307B8")]
		public LeadingConditionRule(IItemDropRuleCondition condition)
		{
		}

		// Token: 0x060055FF RID: 22015 RVA: 0x00027A80 File Offset: 0x00025C80
		[Token(Token = "0x60055FF")]
		[Address(RVA = "0x830858", Offset = "0x830858", VA = "0x830858", Slot = "5")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		// Token: 0x06005600 RID: 22016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005600")]
		[Address(RVA = "0x83093C", Offset = "0x83093C", VA = "0x83093C", Slot = "6")]
		public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
		}

		// Token: 0x06005601 RID: 22017 RVA: 0x00027A98 File Offset: 0x00025C98
		[Token(Token = "0x6005601")]
		[Address(RVA = "0x830984", Offset = "0x830984", VA = "0x830984", Slot = "7")]
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			return default(ItemDropAttemptResult);
		}

		// Token: 0x040098CB RID: 39115
		[Token(Token = "0x40098CB")]
		[FieldOffset(Offset = "0x8")]
		public IItemDropRuleCondition condition;

		// Token: 0x040098CC RID: 39116
		[Token(Token = "0x40098CC")]
		[FieldOffset(Offset = "0xC")]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;
	}
}
