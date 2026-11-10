using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Open.Nat
{
	// Token: 0x02000E52 RID: 3666
	[Token(Token = "0x2000E52")]
	internal class DeletePortMappingRequestMessage : RequestMessageBase
	{
		// Token: 0x06006AA0 RID: 27296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AA0")]
		[Address(RVA = "0xB9F5CC", Offset = "0xB9F5CC", VA = "0xB9F5CC")]
		public DeletePortMappingRequestMessage(Mapping mapping)
		{
		}

		// Token: 0x06006AA1 RID: 27297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AA1")]
		[Address(RVA = "0xB9F5E8", Offset = "0xB9F5E8", VA = "0xB9F5E8", Slot = "4")]
		public override IDictionary<string, object> ToXml()
		{
			return null;
		}

		// Token: 0x0400A822 RID: 43042
		[Token(Token = "0x400A822")]
		[FieldOffset(Offset = "0x8")]
		private readonly Mapping _mapping;
	}
}
