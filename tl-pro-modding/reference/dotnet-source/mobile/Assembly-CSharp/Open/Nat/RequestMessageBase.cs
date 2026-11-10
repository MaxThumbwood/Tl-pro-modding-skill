using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Open.Nat
{
	// Token: 0x02000E58 RID: 3672
	[Token(Token = "0x2000E58")]
	internal abstract class RequestMessageBase
	{
		// Token: 0x06006ABC RID: 27324
		[Token(Token = "0x6006ABC")]
		public abstract IDictionary<string, object> ToXml();

		// Token: 0x06006ABD RID: 27325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ABD")]
		[Address(RVA = "0xB9F108", Offset = "0xB9F108", VA = "0xB9F108")]
		protected RequestMessageBase()
		{
		}
	}
}
