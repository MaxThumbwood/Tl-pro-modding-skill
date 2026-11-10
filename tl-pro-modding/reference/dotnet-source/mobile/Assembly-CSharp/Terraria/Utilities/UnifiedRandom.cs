using System;
using Il2CppDummyDll;

namespace Terraria.Utilities
{
	// Token: 0x020005E1 RID: 1505
	[Token(Token = "0x20005E1")]
	[Serializable]
	public class UnifiedRandom
	{
		// Token: 0x06003C11 RID: 15377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C11")]
		[Address(RVA = "0x1E557FC", Offset = "0x1E557FC", VA = "0x1E557FC")]
		public UnifiedRandom()
		{
		}

		// Token: 0x06003C12 RID: 15378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C12")]
		[Address(RVA = "0x1E55878", Offset = "0x1E55878", VA = "0x1E55878")]
		public UnifiedRandom(int Seed)
		{
		}

		// Token: 0x06003C13 RID: 15379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C13")]
		[Address(RVA = "0x1E558EC", Offset = "0x1E558EC", VA = "0x1E558EC")]
		public void SetSeed(int Seed)
		{
		}

		// Token: 0x06003C14 RID: 15380 RVA: 0x0001E558 File Offset: 0x0001C758
		[Token(Token = "0x6003C14")]
		[Address(RVA = "0x1E55B50", Offset = "0x1E55B50", VA = "0x1E55B50")]
		protected double Sample()
		{
			return 0.0;
		}

		// Token: 0x06003C15 RID: 15381 RVA: 0x0001E570 File Offset: 0x0001C770
		[Token(Token = "0x6003C15")]
		[Address(RVA = "0x1E55BD8", Offset = "0x1E55BD8", VA = "0x1E55BD8")]
		private int InternalSample()
		{
			return 0;
		}

		// Token: 0x06003C16 RID: 15382 RVA: 0x0001E588 File Offset: 0x0001C788
		[Token(Token = "0x6003C16")]
		[Address(RVA = "0x1E55C40", Offset = "0x1E55C40", VA = "0x1E55C40")]
		public int Peek()
		{
			return 0;
		}

		// Token: 0x06003C17 RID: 15383 RVA: 0x0001E5A0 File Offset: 0x0001C7A0
		[Token(Token = "0x6003C17")]
		[Address(RVA = "0x1E55CA0", Offset = "0x1E55CA0", VA = "0x1E55CA0")]
		public int Next()
		{
			return 0;
		}

		// Token: 0x06003C18 RID: 15384 RVA: 0x0001E5B8 File Offset: 0x0001C7B8
		[Token(Token = "0x6003C18")]
		[Address(RVA = "0x1E55D08", Offset = "0x1E55D08", VA = "0x1E55D08")]
		private double GetSampleForLargeRange()
		{
			return 0.0;
		}

		// Token: 0x06003C19 RID: 15385 RVA: 0x0001E5D0 File Offset: 0x0001C7D0
		[Token(Token = "0x6003C19")]
		[Address(RVA = "0x1E55DE0", Offset = "0x1E55DE0", VA = "0x1E55DE0")]
		public int Next(int minValue, int maxValue)
		{
			return 0;
		}

		// Token: 0x06003C1A RID: 15386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C1A")]
		[Address(RVA = "0x1E55F00", Offset = "0x1E55F00", VA = "0x1E55F00")]
		public void Next2(int minX, int maxX, int minY, int maxY, out int x, out int y)
		{
		}

		// Token: 0x06003C1B RID: 15387 RVA: 0x0001E5E8 File Offset: 0x0001C7E8
		[Token(Token = "0x6003C1B")]
		[Address(RVA = "0x1E56038", Offset = "0x1E56038", VA = "0x1E56038")]
		public int NextI(int minValue, int maxValue)
		{
			return 0;
		}

		// Token: 0x06003C1C RID: 15388 RVA: 0x0001E600 File Offset: 0x0001C800
		[Token(Token = "0x6003C1C")]
		[Address(RVA = "0x1E560E8", Offset = "0x1E560E8", VA = "0x1E560E8")]
		public int Next(int maxValue)
		{
			return 0;
		}

		// Token: 0x06003C1D RID: 15389 RVA: 0x0001E618 File Offset: 0x0001C818
		[Token(Token = "0x6003C1D")]
		[Address(RVA = "0x1E56190", Offset = "0x1E56190", VA = "0x1E56190")]
		public double NextDouble()
		{
			return 0.0;
		}

		// Token: 0x06003C1E RID: 15390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C1E")]
		[Address(RVA = "0x1E56218", Offset = "0x1E56218", VA = "0x1E56218")]
		public void NextBytes(byte[] buffer)
		{
		}

		// Token: 0x0400477E RID: 18302
		[Token(Token = "0x400477E")]
		private const int MBIG = 2147483647;

		// Token: 0x0400477F RID: 18303
		[Token(Token = "0x400477F")]
		private const int MSEED = 161803398;

		// Token: 0x04004780 RID: 18304
		[Token(Token = "0x4004780")]
		private const int MZ = 0;

		// Token: 0x04004781 RID: 18305
		[Token(Token = "0x4004781")]
		[FieldOffset(Offset = "0x8")]
		private uint inext;

		// Token: 0x04004782 RID: 18306
		[Token(Token = "0x4004782")]
		[FieldOffset(Offset = "0xC")]
		private int[] SeedArray;

		// Token: 0x04004783 RID: 18307
		[Token(Token = "0x4004783")]
		[FieldOffset(Offset = "0x10")]
		public bool debug;
	}
}
