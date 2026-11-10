using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000A83 RID: 2691
	[Token(Token = "0x2000A83")]
	public enum ItemDropAttemptResultState
	{
		// Token: 0x040098A8 RID: 39080
		[Token(Token = "0x40098A8")]
		DoesntFillConditions,
		// Token: 0x040098A9 RID: 39081
		[Token(Token = "0x40098A9")]
		FailedRandomRoll,
		// Token: 0x040098AA RID: 39082
		[Token(Token = "0x40098AA")]
		Success,
		// Token: 0x040098AB RID: 39083
		[Token(Token = "0x40098AB")]
		DidNotRunCode
	}
}
