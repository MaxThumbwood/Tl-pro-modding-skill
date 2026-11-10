using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x0200075E RID: 1886
	[Token(Token = "0x200075E")]
	public class FlowerPacketInfo
	{
		// Token: 0x060042E0 RID: 17120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042E0")]
		[Address(RVA = "0x4F9B98", Offset = "0x4F9B98", VA = "0x4F9B98")]
		public FlowerPacketInfo()
		{
		}

		// Token: 0x04008A5A RID: 35418
		[Token(Token = "0x4008A5A")]
		[FieldOffset(Offset = "0x8")]
		public List<int> stylesOnPurity;

		// Token: 0x04008A5B RID: 35419
		[Token(Token = "0x4008A5B")]
		[FieldOffset(Offset = "0xC")]
		public List<int> stylesOnCorruption;

		// Token: 0x04008A5C RID: 35420
		[Token(Token = "0x4008A5C")]
		[FieldOffset(Offset = "0x10")]
		public List<int> stylesOnCrimson;

		// Token: 0x04008A5D RID: 35421
		[Token(Token = "0x4008A5D")]
		[FieldOffset(Offset = "0x14")]
		public List<int> stylesOnHallow;
	}
}
