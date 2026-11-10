using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Open.Nat
{
	// Token: 0x02000E51 RID: 3665
	[Token(Token = "0x2000E51")]
	internal class CreatePortMappingRequestMessage : RequestMessageBase
	{
		// Token: 0x06006A9E RID: 27294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A9E")]
		[Address(RVA = "0xB9F0EC", Offset = "0xB9F0EC", VA = "0xB9F0EC")]
		public CreatePortMappingRequestMessage(Mapping mapping)
		{
		}

		// Token: 0x06006A9F RID: 27295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A9F")]
		[Address(RVA = "0xB9F110", Offset = "0xB9F110", VA = "0xB9F110", Slot = "4")]
		public override IDictionary<string, object> ToXml()
		{
			return null;
		}

		// Token: 0x0400A821 RID: 43041
		[Token(Token = "0x400A821")]
		[FieldOffset(Offset = "0x8")]
		private readonly Mapping _mapping;
	}
}
