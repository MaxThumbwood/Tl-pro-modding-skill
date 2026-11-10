using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Ambience
{
	// Token: 0x02000DC4 RID: 3524
	[Token(Token = "0x2000DC4")]
	public class AmbientSkyDrawCache
	{
		// Token: 0x0600678D RID: 26509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600678D")]
		[Address(RVA = "0xB766E0", Offset = "0xB766E0", VA = "0xB766E0")]
		public void SetUnderworldInfo(int drawIndex, float scale)
		{
		}

		// Token: 0x0600678E RID: 26510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600678E")]
		[Address(RVA = "0xB76710", Offset = "0xB76710", VA = "0xB76710")]
		public void SetOceanLineInfo(float yScreenPosition, float oceanOpacity)
		{
		}

		// Token: 0x0600678F RID: 26511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600678F")]
		[Address(RVA = "0xB7671C", Offset = "0xB7671C", VA = "0xB7671C")]
		public AmbientSkyDrawCache()
		{
		}

		// Token: 0x0400A467 RID: 42087
		[Token(Token = "0x400A467")]
		[FieldOffset(Offset = "0x0")]
		public static AmbientSkyDrawCache Instance;

		// Token: 0x0400A468 RID: 42088
		[Token(Token = "0x400A468")]
		[FieldOffset(Offset = "0x8")]
		public AmbientSkyDrawCache.UnderworldCache[] Underworld;

		// Token: 0x0400A469 RID: 42089
		[Token(Token = "0x400A469")]
		[FieldOffset(Offset = "0xC")]
		public AmbientSkyDrawCache.OceanLineCache OceanLineInfo;

		// Token: 0x02000DC5 RID: 3525
		[Token(Token = "0x2000DC5")]
		public struct UnderworldCache
		{
			// Token: 0x0400A46A RID: 42090
			[Token(Token = "0x400A46A")]
			[FieldOffset(Offset = "0x0")]
			public float Scale;
		}

		// Token: 0x02000DC6 RID: 3526
		[Token(Token = "0x2000DC6")]
		public struct OceanLineCache
		{
			// Token: 0x0400A46B RID: 42091
			[Token(Token = "0x400A46B")]
			[FieldOffset(Offset = "0x0")]
			public float YScreenPosition;

			// Token: 0x0400A46C RID: 42092
			[Token(Token = "0x400A46C")]
			[FieldOffset(Offset = "0x4")]
			public float OceanOpacity;
		}
	}
}
