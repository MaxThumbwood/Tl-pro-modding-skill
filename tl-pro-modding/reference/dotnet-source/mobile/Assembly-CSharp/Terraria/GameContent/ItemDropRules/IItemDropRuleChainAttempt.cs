using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000A85 RID: 2693
	[Token(Token = "0x2000A85")]
	public interface IItemDropRuleChainAttempt
	{
		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x060055A2 RID: 21922
		[Token(Token = "0x170009D7")]
		IItemDropRule RuleToChain
		{
			[Token(Token = "0x60055A2")]
			get;
		}

		// Token: 0x060055A3 RID: 21923
		[Token(Token = "0x60055A3")]
		bool CanChainIntoRule(ItemDropAttemptResult parentResult);

		// Token: 0x060055A4 RID: 21924
		[Token(Token = "0x60055A4")]
		void ReportDroprates(float personalDropRate, List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo);
	}
}
