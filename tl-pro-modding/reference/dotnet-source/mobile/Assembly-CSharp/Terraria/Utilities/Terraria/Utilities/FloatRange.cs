using System;
using Il2CppDummyDll;

namespace Terraria.Utilities.Terraria.Utilities
{
	// Token: 0x020005E3 RID: 1507
	[Token(Token = "0x20005E3")]
	public struct FloatRange
	{
		// Token: 0x06003C2A RID: 15402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C2A")]
		[Address(RVA = "0x1E562B8", Offset = "0x1E562B8", VA = "0x1E562B8")]
		public FloatRange(float minimum, float maximum)
		{
		}

		// Token: 0x06003C2B RID: 15403 RVA: 0x0001E630 File Offset: 0x0001C830
		[Token(Token = "0x6003C2B")]
		[Address(RVA = "0x1E562C0", Offset = "0x1E562C0", VA = "0x1E562C0")]
		public bool Contains(float f)
		{
			return default(bool);
		}

		// Token: 0x06003C2C RID: 15404 RVA: 0x0001E648 File Offset: 0x0001C848
		[Token(Token = "0x6003C2C")]
		[Address(RVA = "0x1E562F4", Offset = "0x1E562F4", VA = "0x1E562F4")]
		public float Lerp(float amount)
		{
			return 0f;
		}

		// Token: 0x06003C2D RID: 15405 RVA: 0x0001E660 File Offset: 0x0001C860
		[Token(Token = "0x6003C2D")]
		[Address(RVA = "0x1E5630C", Offset = "0x1E5630C", VA = "0x1E5630C")]
		public static FloatRange operator *(FloatRange range, float scale)
		{
			return default(FloatRange);
		}

		// Token: 0x06003C2E RID: 15406 RVA: 0x0001E678 File Offset: 0x0001C878
		[Token(Token = "0x6003C2E")]
		[Address(RVA = "0x1E5632C", Offset = "0x1E5632C", VA = "0x1E5632C")]
		public static FloatRange operator *(float scale, FloatRange range)
		{
			return default(FloatRange);
		}

		// Token: 0x06003C2F RID: 15407 RVA: 0x0001E690 File Offset: 0x0001C890
		[Token(Token = "0x6003C2F")]
		[Address(RVA = "0x1E5634C", Offset = "0x1E5634C", VA = "0x1E5634C")]
		public static FloatRange operator /(FloatRange range, float scale)
		{
			return default(FloatRange);
		}

		// Token: 0x06003C30 RID: 15408 RVA: 0x0001E6A8 File Offset: 0x0001C8A8
		[Token(Token = "0x6003C30")]
		[Address(RVA = "0x1E5636C", Offset = "0x1E5636C", VA = "0x1E5636C")]
		public static FloatRange operator /(float scale, FloatRange range)
		{
			return default(FloatRange);
		}

		// Token: 0x04004788 RID: 18312
		[Token(Token = "0x4004788")]
		[FieldOffset(Offset = "0x0")]
		public readonly float Minimum;

		// Token: 0x04004789 RID: 18313
		[Token(Token = "0x4004789")]
		[FieldOffset(Offset = "0x4")]
		public readonly float Maximum;
	}
}
