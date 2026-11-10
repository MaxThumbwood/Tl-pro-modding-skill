using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x02000405 RID: 1029
	[Token(Token = "0x2000405")]
	public static class QuickMath
	{
		// Token: 0x06001C46 RID: 7238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C46")]
		[Address(RVA = "0xE8567C", Offset = "0xE8567C", VA = "0xE8567C")]
		public static void Setup()
		{
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x0000D548 File Offset: 0x0000B748
		[Token(Token = "0x6001C47")]
		[Address(RVA = "0xE85770", Offset = "0xE85770", VA = "0xE85770")]
		public static float Sin(float x)
		{
			return 0f;
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x0000D560 File Offset: 0x0000B760
		[Token(Token = "0x6001C48")]
		[Address(RVA = "0xE85810", Offset = "0xE85810", VA = "0xE85810")]
		public static float Cos(float x)
		{
			return 0f;
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C49")]
		[Address(RVA = "0xE858B4", Offset = "0xE858B4", VA = "0xE858B4")]
		public static void SinCos(float x, out float sin, out float cos)
		{
		}

		// Token: 0x04002FE8 RID: 12264
		[Token(Token = "0x4002FE8")]
		private const int TableSize = 4096;

		// Token: 0x04002FE9 RID: 12265
		[Token(Token = "0x4002FE9")]
		private const float IndexScale = 651.8986f;

		// Token: 0x04002FEA RID: 12266
		[Token(Token = "0x4002FEA")]
		private const float ValueScale = 0.0015339808f;

		// Token: 0x04002FEB RID: 12267
		[Token(Token = "0x4002FEB")]
		[FieldOffset(Offset = "0x0")]
		private static float[] SinLookup;
	}
}
