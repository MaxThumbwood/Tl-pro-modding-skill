using System;
using Il2CppDummyDll;

namespace Terraria.Utilities
{
	// Token: 0x020005D0 RID: 1488
	[Token(Token = "0x20005D0")]
	public struct IntRange
	{
		// Token: 0x06003BCB RID: 15307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BCB")]
		[Address(RVA = "0x1E14E2C", Offset = "0x1E14E2C", VA = "0x1E14E2C")]
		public IntRange(int minimum, int maximum)
		{
		}

		// Token: 0x06003BCC RID: 15308 RVA: 0x0001E240 File Offset: 0x0001C440
		[Token(Token = "0x6003BCC")]
		[Address(RVA = "0x1E14E34", Offset = "0x1E14E34", VA = "0x1E14E34")]
		public static IntRange operator *(IntRange range, float scale)
		{
			return default(IntRange);
		}

		// Token: 0x06003BCD RID: 15309 RVA: 0x0001E258 File Offset: 0x0001C458
		[Token(Token = "0x6003BCD")]
		[Address(RVA = "0x1E14E8C", Offset = "0x1E14E8C", VA = "0x1E14E8C")]
		public static IntRange operator *(float scale, IntRange range)
		{
			return default(IntRange);
		}

		// Token: 0x06003BCE RID: 15310 RVA: 0x0001E270 File Offset: 0x0001C470
		[Token(Token = "0x6003BCE")]
		[Address(RVA = "0x1E14EE4", Offset = "0x1E14EE4", VA = "0x1E14EE4")]
		public static IntRange operator /(IntRange range, float scale)
		{
			return default(IntRange);
		}

		// Token: 0x06003BCF RID: 15311 RVA: 0x0001E288 File Offset: 0x0001C488
		[Token(Token = "0x6003BCF")]
		[Address(RVA = "0x1E14F3C", Offset = "0x1E14F3C", VA = "0x1E14F3C")]
		public static IntRange operator /(float scale, IntRange range)
		{
			return default(IntRange);
		}

		// Token: 0x0400475A RID: 18266
		[Token(Token = "0x400475A")]
		[FieldOffset(Offset = "0x0")]
		public readonly int Minimum;

		// Token: 0x0400475B RID: 18267
		[Token(Token = "0x400475B")]
		[FieldOffset(Offset = "0x4")]
		public readonly int Maximum;
	}
}
