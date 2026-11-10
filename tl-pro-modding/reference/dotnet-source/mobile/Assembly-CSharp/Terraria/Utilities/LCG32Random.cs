using System;
using Il2CppDummyDll;

namespace Terraria.Utilities
{
	// Token: 0x020005D1 RID: 1489
	[Token(Token = "0x20005D1")]
	public struct LCG32Random
	{
		// Token: 0x06003BD0 RID: 15312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BD0")]
		[Address(RVA = "0x1E14F94", Offset = "0x1E14F94", VA = "0x1E14F94")]
		public LCG32Random(uint seed)
		{
		}

		// Token: 0x06003BD1 RID: 15313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BD1")]
		[Address(RVA = "0x1E14F9C", Offset = "0x1E14F9C", VA = "0x1E14F9C")]
		public void Advance()
		{
		}

		// Token: 0x06003BD2 RID: 15314 RVA: 0x0001E2A0 File Offset: 0x0001C4A0
		[Token(Token = "0x6003BD2")]
		[Address(RVA = "0x1E14FB8", Offset = "0x1E14FB8", VA = "0x1E14FB8")]
		public uint Next(uint maxValue)
		{
			return 0U;
		}

		// Token: 0x06003BD3 RID: 15315 RVA: 0x0001E2B8 File Offset: 0x0001C4B8
		[Token(Token = "0x6003BD3")]
		[Address(RVA = "0x1E14FDC", Offset = "0x1E14FDC", VA = "0x1E14FDC")]
		public int Next(int maxValue)
		{
			return 0;
		}

		// Token: 0x06003BD4 RID: 15316 RVA: 0x0001E2D0 File Offset: 0x0001C4D0
		[Token(Token = "0x6003BD4")]
		[Address(RVA = "0x1E1507C", Offset = "0x1E1507C", VA = "0x1E1507C")]
		public int Next(int minValue, int maxValue)
		{
			return 0;
		}

		// Token: 0x06003BD5 RID: 15317 RVA: 0x0001E2E8 File Offset: 0x0001C4E8
		[Token(Token = "0x6003BD5")]
		[Address(RVA = "0x1E150A8", Offset = "0x1E150A8", VA = "0x1E150A8")]
		public double NextDouble()
		{
			return 0.0;
		}

		// Token: 0x06003BD6 RID: 15318 RVA: 0x0001E300 File Offset: 0x0001C500
		[Token(Token = "0x6003BD6")]
		[Address(RVA = "0x1E150E8", Offset = "0x1E150E8", VA = "0x1E150E8")]
		public float NextFloat()
		{
			return 0f;
		}

		// Token: 0x0400475C RID: 18268
		[Token(Token = "0x400475C")]
		[FieldOffset(Offset = "0x0")]
		public uint state;
	}
}
