using System;
using Il2CppDummyDll;

namespace Terraria.Utilities
{
	// Token: 0x020005CE RID: 1486
	[Token(Token = "0x20005CE")]
	public struct FastRandom
	{
		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06003BA9 RID: 15273 RVA: 0x0001E108 File Offset: 0x0001C308
		// (set) Token: 0x06003BAA RID: 15274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700078E")]
		public ulong Seed
		{
			[Token(Token = "0x6003BA9")]
			[Address(RVA = "0x1E1365C", Offset = "0x1E1365C", VA = "0x1E1365C")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6003BAA")]
			[Address(RVA = "0x1E13664", Offset = "0x1E13664", VA = "0x1E13664")]
			private set
			{
			}
		}

		// Token: 0x06003BAB RID: 15275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BAB")]
		[Address(RVA = "0x1E13674", Offset = "0x1E13674", VA = "0x1E13674")]
		public FastRandom(ulong seed)
		{
		}

		// Token: 0x06003BAC RID: 15276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BAC")]
		[Address(RVA = "0x1E13684", Offset = "0x1E13684", VA = "0x1E13684")]
		public FastRandom(int seed)
		{
		}

		// Token: 0x06003BAD RID: 15277 RVA: 0x0001E120 File Offset: 0x0001C320
		[Token(Token = "0x6003BAD")]
		[Address(RVA = "0x1E13694", Offset = "0x1E13694", VA = "0x1E13694")]
		public FastRandom WithModifier(ulong modifier)
		{
			return default(FastRandom);
		}

		// Token: 0x06003BAE RID: 15278 RVA: 0x0001E138 File Offset: 0x0001C338
		[Token(Token = "0x6003BAE")]
		[Address(RVA = "0x1E136F8", Offset = "0x1E136F8", VA = "0x1E136F8")]
		public FastRandom WithModifier(int x, int y)
		{
			return default(FastRandom);
		}

		// Token: 0x06003BAF RID: 15279 RVA: 0x0001E150 File Offset: 0x0001C350
		[Token(Token = "0x6003BAF")]
		[Address(RVA = "0x1E1376C", Offset = "0x1E1376C", VA = "0x1E1376C")]
		public static FastRandom CreateWithRandomSeed()
		{
			return default(FastRandom);
		}

		// Token: 0x06003BB0 RID: 15280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BB0")]
		[Address(RVA = "0x1E137B8", Offset = "0x1E137B8", VA = "0x1E137B8")]
		public void NextSeed()
		{
		}

		// Token: 0x06003BB1 RID: 15281 RVA: 0x0001E168 File Offset: 0x0001C368
		[Token(Token = "0x6003BB1")]
		[Address(RVA = "0x1E137EC", Offset = "0x1E137EC", VA = "0x1E137EC")]
		private int NextBits(int bits)
		{
			return 0;
		}

		// Token: 0x06003BB2 RID: 15282 RVA: 0x0001E180 File Offset: 0x0001C380
		[Token(Token = "0x6003BB2")]
		[Address(RVA = "0x1E1383C", Offset = "0x1E1383C", VA = "0x1E1383C")]
		public float NextFloat()
		{
			return 0f;
		}

		// Token: 0x06003BB3 RID: 15283 RVA: 0x0001E198 File Offset: 0x0001C398
		[Token(Token = "0x6003BB3")]
		[Address(RVA = "0x1E13894", Offset = "0x1E13894", VA = "0x1E13894")]
		public double NextDouble()
		{
			return 0.0;
		}

		// Token: 0x06003BB4 RID: 15284 RVA: 0x0001E1B0 File Offset: 0x0001C3B0
		[Token(Token = "0x6003BB4")]
		[Address(RVA = "0x1E138F0", Offset = "0x1E138F0", VA = "0x1E138F0")]
		public int Next(int max)
		{
			return 0;
		}

		// Token: 0x06003BB5 RID: 15285 RVA: 0x0001E1C8 File Offset: 0x0001C3C8
		[Token(Token = "0x6003BB5")]
		[Address(RVA = "0x1E13998", Offset = "0x1E13998", VA = "0x1E13998")]
		public int Next(int min, int max)
		{
			return 0;
		}

		// Token: 0x06003BB6 RID: 15286 RVA: 0x0001E1E0 File Offset: 0x0001C3E0
		[Token(Token = "0x6003BB6")]
		[Address(RVA = "0x1E136D0", Offset = "0x1E136D0", VA = "0x1E136D0")]
		private static ulong NextSeed(ulong seed)
		{
			return 0UL;
		}

		// Token: 0x04004755 RID: 18261
		[Token(Token = "0x4004755")]
		public const ulong RANDOM_MULTIPLIER = 25214903917UL;

		// Token: 0x04004756 RID: 18262
		[Token(Token = "0x4004756")]
		public const ulong RANDOM_ADD = 11UL;

		// Token: 0x04004757 RID: 18263
		[Token(Token = "0x4004757")]
		public const ulong RANDOM_MASK = 281474976710655UL;

		// Token: 0x04004758 RID: 18264
		[Token(Token = "0x4004758")]
		[FieldOffset(Offset = "0x0")]
		private ulong <Seed>k__BackingField;
	}
}
