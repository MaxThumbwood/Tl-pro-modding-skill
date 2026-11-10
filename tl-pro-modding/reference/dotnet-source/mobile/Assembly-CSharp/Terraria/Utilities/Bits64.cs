using System;
using Il2CppDummyDll;

namespace Terraria.Utilities
{
	// Token: 0x020005C4 RID: 1476
	[Token(Token = "0x20005C4")]
	public struct Bits64
	{
		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06003B7C RID: 15228 RVA: 0x0001DF58 File Offset: 0x0001C158
		// (set) Token: 0x06003B7D RID: 15229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000785")]
		public bool Item
		{
			[Token(Token = "0x6003B7C")]
			[Address(RVA = "0x1E112BC", Offset = "0x1E112BC", VA = "0x1E112BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003B7D")]
			[Address(RVA = "0x1E112F8", Offset = "0x1E112F8", VA = "0x1E112F8")]
			set
			{
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06003B7E RID: 15230 RVA: 0x0001DF70 File Offset: 0x0001C170
		[Token(Token = "0x17000786")]
		public bool IsEmpty
		{
			[Token(Token = "0x6003B7E")]
			[Address(RVA = "0x1E11348", Offset = "0x1E11348", VA = "0x1E11348")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003B7F RID: 15231 RVA: 0x0001DF88 File Offset: 0x0001C188
		[Token(Token = "0x6003B7F")]
		[Address(RVA = "0x1E1135C", Offset = "0x1E1135C", VA = "0x1E1135C")]
		public static implicit operator ulong(Bits64 b)
		{
			return 0UL;
		}

		// Token: 0x06003B80 RID: 15232 RVA: 0x0001DFA0 File Offset: 0x0001C1A0
		[Token(Token = "0x6003B80")]
		[Address(RVA = "0x1E11360", Offset = "0x1E11360", VA = "0x1E11360")]
		public static implicit operator Bits64(ulong v)
		{
			return default(Bits64);
		}

		// Token: 0x0400472E RID: 18222
		[Token(Token = "0x400472E")]
		[FieldOffset(Offset = "0x0")]
		private ulong v;
	}
}
