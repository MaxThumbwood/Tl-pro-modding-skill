using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000AEE RID: 2798
	// (Invoke) Token: 0x06005791 RID: 22417
	[Token(Token = "0x2000AEE")]
	public delegate ItemDropAttemptResult ItemDropRuleResolveAction(IItemDropRule rule, DropAttemptInfo info);
}
