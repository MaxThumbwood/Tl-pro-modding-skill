using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000A86 RID: 2694
	[Token(Token = "0x2000A86")]
	public interface IItemDropRuleCondition : FileAPI
	{
		// Token: 0x060055A5 RID: 21925
		[Token(Token = "0x60055A5")]
		bool CanDrop(DropAttemptInfo info);

		// Token: 0x060055A6 RID: 21926
		[Token(Token = "0x60055A6")]
		bool CanShowItemDropInUI();
	}
}
