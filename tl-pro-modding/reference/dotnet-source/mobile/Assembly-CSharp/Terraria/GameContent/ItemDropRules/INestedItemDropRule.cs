using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000A82 RID: 2690
	[Token(Token = "0x2000A82")]
	public interface INestedItemDropRule
	{
		// Token: 0x060055A1 RID: 21921
		[Token(Token = "0x60055A1")]
		ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info, ItemDropRuleResolveAction resolveAction);
	}
}
