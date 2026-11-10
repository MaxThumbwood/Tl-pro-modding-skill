using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000A81 RID: 2689
	[Token(Token = "0x2000A81")]
	public interface IItemDropRule
	{
		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x0600559D RID: 21917
		[Token(Token = "0x170009D6")]
		List<IItemDropRuleChainAttempt> ChainedRules
		{
			[Token(Token = "0x600559D")]
			get;
		}

		// Token: 0x0600559E RID: 21918
		[Token(Token = "0x600559E")]
		bool CanDrop(DropAttemptInfo info);

		// Token: 0x0600559F RID: 21919
		[Token(Token = "0x600559F")]
		void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo);

		// Token: 0x060055A0 RID: 21920
		[Token(Token = "0x60055A0")]
		ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info);
	}
}
