using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000A95 RID: 2709
	[Token(Token = "0x2000A95")]
	public class MechBossSpawnersDropRule : FileAPI
	{
		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x060055E6 RID: 21990 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060055E7 RID: 21991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009DE")]
		public List<IItemDropRuleChainAttempt> ChainedRules
		{
			[Token(Token = "0x60055E6")]
			[Address(RVA = "0x82F394", Offset = "0x82F394", VA = "0x82F394", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60055E7")]
			[Address(RVA = "0x82F39C", Offset = "0x82F39C", VA = "0x82F39C")]
			private set
			{
			}
		}

		// Token: 0x060055E8 RID: 21992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055E8")]
		[Address(RVA = "0x82F3A4", Offset = "0x82F3A4", VA = "0x82F3A4")]
		public MechBossSpawnersDropRule()
		{
		}

		// Token: 0x060055E9 RID: 21993 RVA: 0x000279D8 File Offset: 0x00025BD8
		[Token(Token = "0x60055E9")]
		[Address(RVA = "0x82F488", Offset = "0x82F488", VA = "0x82F488", Slot = "5")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		// Token: 0x060055EA RID: 21994 RVA: 0x000279F0 File Offset: 0x00025BF0
		[Token(Token = "0x60055EA")]
		[Address(RVA = "0x82F5BC", Offset = "0x82F5BC", VA = "0x82F5BC", Slot = "7")]
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			return default(ItemDropAttemptResult);
		}

		// Token: 0x060055EB RID: 21995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055EB")]
		[Address(RVA = "0x82F72C", Offset = "0x82F72C", VA = "0x82F72C", Slot = "6")]
		public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
		}

		// Token: 0x040098C6 RID: 39110
		[Token(Token = "0x40098C6")]
		[FieldOffset(Offset = "0x8")]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;

		// Token: 0x040098C7 RID: 39111
		[Token(Token = "0x40098C7")]
		[FieldOffset(Offset = "0xC")]
		public Conditions.MechanicalBossesDummyCondition dummyCondition;
	}
}
