using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Terraria.Modules
{
	// Token: 0x02000650 RID: 1616
	[Token(Token = "0x2000650")]
	public class AnchorTypesModule
	{
		// Token: 0x06003EF0 RID: 16112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EF0")]
		[Address(RVA = "0x1E79AA0", Offset = "0x1E79AA0", VA = "0x1E79AA0")]
		public AnchorTypesModule([Optional] AnchorTypesModule copyFrom)
		{
		}

		// Token: 0x040048F8 RID: 18680
		[Token(Token = "0x40048F8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int[] tileValid;

		// Token: 0x040048F9 RID: 18681
		[Token(Token = "0x40048F9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int[] tileInvalid;

		// Token: 0x040048FA RID: 18682
		[Token(Token = "0x40048FA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int[] tileAlternates;

		// Token: 0x040048FB RID: 18683
		[Token(Token = "0x40048FB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int[] wallValid;
	}
}
