using System;
using Il2CppDummyDll;

namespace Unity.IL2CPP.CompilerServices
{
	// Token: 0x02000E70 RID: 3696
	[Token(Token = "0x2000E70")]
	public enum Option
	{
		// Token: 0x0400A894 RID: 43156
		[Token(Token = "0x400A894")]
		NullChecks = 1,
		// Token: 0x0400A895 RID: 43157
		[Token(Token = "0x400A895")]
		ArrayBoundsChecks,
		// Token: 0x0400A896 RID: 43158
		[Token(Token = "0x400A896")]
		DivideByZeroChecks,
		// Token: 0x0400A897 RID: 43159
		[Token(Token = "0x400A897")]
		StripStaticGuards
	}
}
