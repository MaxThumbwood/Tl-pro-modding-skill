using System;
using Il2CppDummyDll;

namespace Terraria.UI
{
	// Token: 0x0200088C RID: 2188
	[Token(Token = "0x200088C")]
	public struct StyleDimension
	{
		// Token: 0x06004A64 RID: 19044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A64")]
		[Address(RVA = "0x61C918", Offset = "0x61C918", VA = "0x61C918")]
		public StyleDimension(float pixels, float precent)
		{
		}

		// Token: 0x06004A65 RID: 19045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A65")]
		[Address(RVA = "0x61C920", Offset = "0x61C920", VA = "0x61C920")]
		public void Set(float pixels, float precent)
		{
		}

		// Token: 0x06004A66 RID: 19046 RVA: 0x00023820 File Offset: 0x00021A20
		[Token(Token = "0x6004A66")]
		[Address(RVA = "0x61C928", Offset = "0x61C928", VA = "0x61C928")]
		public float GetValue(float containerSize)
		{
			return 0f;
		}

		// Token: 0x06004A67 RID: 19047 RVA: 0x00023838 File Offset: 0x00021A38
		[Token(Token = "0x6004A67")]
		[Address(RVA = "0x61C940", Offset = "0x61C940", VA = "0x61C940")]
		public static StyleDimension FromPixels(float pixels)
		{
			return default(StyleDimension);
		}

		// Token: 0x06004A68 RID: 19048 RVA: 0x00023850 File Offset: 0x00021A50
		[Token(Token = "0x6004A68")]
		[Address(RVA = "0x61C94C", Offset = "0x61C94C", VA = "0x61C94C")]
		public static StyleDimension FromPercent(float percent)
		{
			return default(StyleDimension);
		}

		// Token: 0x06004A69 RID: 19049 RVA: 0x00023868 File Offset: 0x00021A68
		[Token(Token = "0x6004A69")]
		[Address(RVA = "0x61C95C", Offset = "0x61C95C", VA = "0x61C95C")]
		public static StyleDimension FromPixelsAndPercent(float pixels, float percent)
		{
			return default(StyleDimension);
		}

		// Token: 0x04008FC9 RID: 36809
		[Token(Token = "0x4008FC9")]
		[FieldOffset(Offset = "0x0")]
		public static StyleDimension Fill;

		// Token: 0x04008FCA RID: 36810
		[Token(Token = "0x4008FCA")]
		[FieldOffset(Offset = "0x8")]
		public static StyleDimension Empty;

		// Token: 0x04008FCB RID: 36811
		[Token(Token = "0x4008FCB")]
		[FieldOffset(Offset = "0x0")]
		public float Pixels;

		// Token: 0x04008FCC RID: 36812
		[Token(Token = "0x4008FCC")]
		[FieldOffset(Offset = "0x4")]
		public float Precent;
	}
}
