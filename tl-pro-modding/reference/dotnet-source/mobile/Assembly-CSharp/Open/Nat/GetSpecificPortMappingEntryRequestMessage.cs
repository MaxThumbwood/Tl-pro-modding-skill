using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Open.Nat
{
	// Token: 0x02000E55 RID: 3669
	[Token(Token = "0x2000E55")]
	internal class GetSpecificPortMappingEntryRequestMessage : RequestMessageBase
	{
		// Token: 0x06006AA6 RID: 27302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AA6")]
		[Address(RVA = "0xB9F9E0", Offset = "0xB9F9E0", VA = "0xB9F9E0")]
		public GetSpecificPortMappingEntryRequestMessage(Protocol protocol, int externalPort)
		{
		}

		// Token: 0x06006AA7 RID: 27303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AA7")]
		[Address(RVA = "0xB9FA04", Offset = "0xB9FA04", VA = "0xB9FA04", Slot = "4")]
		public override IDictionary<string, object> ToXml()
		{
			return null;
		}

		// Token: 0x0400A824 RID: 43044
		[Token(Token = "0x400A824")]
		[FieldOffset(Offset = "0x8")]
		private readonly int _externalPort;

		// Token: 0x0400A825 RID: 43045
		[Token(Token = "0x400A825")]
		[FieldOffset(Offset = "0xC")]
		private readonly Protocol _protocol;
	}
}
