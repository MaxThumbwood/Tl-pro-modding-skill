using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Open.Nat
{
	// Token: 0x02000E54 RID: 3668
	[Token(Token = "0x2000E54")]
	internal class GetGenericPortMappingEntry : RequestMessageBase
	{
		// Token: 0x06006AA4 RID: 27300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AA4")]
		[Address(RVA = "0xB9F8A4", Offset = "0xB9F8A4", VA = "0xB9F8A4")]
		public GetGenericPortMappingEntry(int index)
		{
		}

		// Token: 0x06006AA5 RID: 27301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AA5")]
		[Address(RVA = "0xB9F8C0", Offset = "0xB9F8C0", VA = "0xB9F8C0", Slot = "4")]
		public override IDictionary<string, object> ToXml()
		{
			return null;
		}

		// Token: 0x0400A823 RID: 43043
		[Token(Token = "0x400A823")]
		[FieldOffset(Offset = "0x8")]
		private readonly int _index;
	}
}
