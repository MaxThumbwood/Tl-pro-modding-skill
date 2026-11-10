using System;
using Il2CppDummyDll;

namespace Terraria
{
	// Token: 0x02000502 RID: 1282
	[Token(Token = "0x2000502")]
	public struct TileColorCache
	{
		// Token: 0x0600332E RID: 13102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600332E")]
		[Address(RVA = "0x1A14570", Offset = "0x1A14570", VA = "0x1A14570")]
		public void ApplyToBlock(Tile tile)
		{
		}

		// Token: 0x0600332F RID: 13103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600332F")]
		[Address(RVA = "0x1A14764", Offset = "0x1A14764", VA = "0x1A14764")]
		public void ApplyToWall(Tile tile)
		{
		}

		// Token: 0x0400430A RID: 17162
		[Token(Token = "0x400430A")]
		[FieldOffset(Offset = "0x0")]
		public byte Color;

		// Token: 0x0400430B RID: 17163
		[Token(Token = "0x400430B")]
		[FieldOffset(Offset = "0x1")]
		public bool FullBright;

		// Token: 0x0400430C RID: 17164
		[Token(Token = "0x400430C")]
		[FieldOffset(Offset = "0x2")]
		public bool Invisible;
	}
}
