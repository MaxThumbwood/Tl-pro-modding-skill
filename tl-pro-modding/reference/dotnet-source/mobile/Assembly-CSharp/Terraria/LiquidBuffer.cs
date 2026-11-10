using System;
using Il2CppDummyDll;

namespace Terraria
{
	// Token: 0x020004D2 RID: 1234
	[Token(Token = "0x20004D2")]
	public struct LiquidBuffer
	{
		// Token: 0x060030B5 RID: 12469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030B5")]
		[Address(RVA = "0x19EDEB0", Offset = "0x19EDEB0", VA = "0x19EDEB0")]
		public static void AddBuffer(int x, int y)
		{
		}

		// Token: 0x060030B6 RID: 12470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030B6")]
		[Address(RVA = "0x19EDF48", Offset = "0x19EDF48", VA = "0x19EDF48")]
		public static void DelBuffer(int l)
		{
		}

		// Token: 0x04004120 RID: 16672
		[Token(Token = "0x4004120")]
		[FieldOffset(Offset = "0x0")]
		public static int numLiquidBuffer;

		// Token: 0x04004121 RID: 16673
		[Token(Token = "0x4004121")]
		[FieldOffset(Offset = "0x0")]
		public int x;

		// Token: 0x04004122 RID: 16674
		[Token(Token = "0x4004122")]
		[FieldOffset(Offset = "0x4")]
		public int y;
	}
}
