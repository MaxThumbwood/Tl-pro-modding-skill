using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.RGB
{
	// Token: 0x02000A13 RID: 2579
	[Token(Token = "0x2000A13")]
	public static class NoiseHelper
	{
		// Token: 0x060053C5 RID: 21445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053C5")]
		[Address(RVA = "0x808948", Offset = "0x808948", VA = "0x808948")]
		private static float[] CreateStaticNoise(int length)
		{
			return null;
		}

		// Token: 0x060053C6 RID: 21446 RVA: 0x00026EC8 File Offset: 0x000250C8
		[Token(Token = "0x60053C6")]
		[Address(RVA = "0x808A5C", Offset = "0x808A5C", VA = "0x808A5C")]
		public static float GetDynamicNoise(int index, float currentTime)
		{
			return 0f;
		}

		// Token: 0x060053C7 RID: 21447 RVA: 0x00026EE0 File Offset: 0x000250E0
		[Token(Token = "0x60053C7")]
		[Address(RVA = "0x808B48", Offset = "0x808B48", VA = "0x808B48")]
		public static float GetStaticNoise(int index)
		{
			return 0f;
		}

		// Token: 0x060053C8 RID: 21448 RVA: 0x00026EF8 File Offset: 0x000250F8
		[Token(Token = "0x60053C8")]
		[Address(RVA = "0x808BC8", Offset = "0x808BC8", VA = "0x808BC8")]
		public static float GetDynamicNoise(int x, int y, float currentTime)
		{
			return 0f;
		}

		// Token: 0x060053C9 RID: 21449 RVA: 0x00026F10 File Offset: 0x00025110
		[Token(Token = "0x60053C9")]
		[Address(RVA = "0x808C48", Offset = "0x808C48", VA = "0x808C48")]
		private static float GetDynamicNoiseInternal(int x, int y, float wrappedTime)
		{
			return 0f;
		}

		// Token: 0x060053CA RID: 21450 RVA: 0x00026F28 File Offset: 0x00025128
		[Token(Token = "0x60053CA")]
		[Address(RVA = "0x808D2C", Offset = "0x808D2C", VA = "0x808D2C")]
		public static float GetStaticNoise(int x, int y)
		{
			return 0f;
		}

		// Token: 0x060053CB RID: 21451 RVA: 0x00026F40 File Offset: 0x00025140
		[Token(Token = "0x60053CB")]
		[Address(RVA = "0x808DB4", Offset = "0x808DB4", VA = "0x808DB4")]
		public static float GetDynamicNoise(Vector2 position, float currentTime)
		{
			return 0f;
		}

		// Token: 0x060053CC RID: 21452 RVA: 0x00026F58 File Offset: 0x00025158
		[Token(Token = "0x60053CC")]
		[Address(RVA = "0x809038", Offset = "0x809038", VA = "0x809038")]
		public static float GetStaticNoise(Vector2 position)
		{
			return 0f;
		}

		// Token: 0x0400978D RID: 38797
		[Token(Token = "0x400978D")]
		private const int RANDOM_SEED = 1;

		// Token: 0x0400978E RID: 38798
		[Token(Token = "0x400978E")]
		private const int NOISE_2D_SIZE = 32;

		// Token: 0x0400978F RID: 38799
		[Token(Token = "0x400978F")]
		private const int NOISE_2D_SIZE_MASK = 31;

		// Token: 0x04009790 RID: 38800
		[Token(Token = "0x4009790")]
		private const int NOISE_SIZE_MASK = 1023;

		// Token: 0x04009791 RID: 38801
		[Token(Token = "0x4009791")]
		[FieldOffset(Offset = "0x0")]
		private static readonly float[] StaticNoise;
	}
}
