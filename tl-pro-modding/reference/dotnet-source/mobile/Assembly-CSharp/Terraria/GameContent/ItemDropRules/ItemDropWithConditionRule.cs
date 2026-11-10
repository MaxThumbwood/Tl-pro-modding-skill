using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000A98 RID: 2712
	[Token(Token = "0x2000A98")]
	public class ItemDropWithConditionRule : CommonDrop
	{
		// Token: 0x060055F9 RID: 22009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055F9")]
		[Address(RVA = "0x830348", Offset = "0x830348", VA = "0x830348")]
		public ItemDropWithConditionRule(int itemId, int chanceDenominator, int amountDroppedMinimum, int amountDroppedMaximum, IItemDropRuleCondition condition, int chanceNumerator = 1)
		{
		}

		// Token: 0x060055FA RID: 22010 RVA: 0x00027A68 File Offset: 0x00025C68
		[Token(Token = "0x60055FA")]
		[Address(RVA = "0x830410", Offset = "0x830410", VA = "0x830410", Slot = "8")]
		public override bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		// Token: 0x060055FB RID: 22011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055FB")]
		[Address(RVA = "0x8304F4", Offset = "0x8304F4", VA = "0x8304F4", Slot = "10")]
		public override void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
		}

		// Token: 0x040098CA RID: 39114
		[Token(Token = "0x40098CA")]
		[FieldOffset(Offset = "0x20")]
		public IItemDropRuleCondition condition;
	}
}
