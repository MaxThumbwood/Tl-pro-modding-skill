using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Features
{
	// Token: 0x02000B77 RID: 2935
	[Token(Token = "0x2000B77")]
	public class DungeonPillarSettings : DungeonFeatureSettings
	{
		// Token: 0x06005A14 RID: 23060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A14")]
		[Address(RVA = "0x8E607C", Offset = "0x8E607C", VA = "0x8E607C")]
		public DungeonPillarSettings()
		{
		}

		// Token: 0x04009B67 RID: 39783
		[Token(Token = "0x4009B67")]
		[FieldOffset(Offset = "0x8")]
		public DungeonGenerationStyleData Style;

		// Token: 0x04009B68 RID: 39784
		[Token(Token = "0x4009B68")]
		[FieldOffset(Offset = "0xC")]
		public PillarType PillarType;

		// Token: 0x04009B69 RID: 39785
		[Token(Token = "0x4009B69")]
		[FieldOffset(Offset = "0x10")]
		public int Width;

		// Token: 0x04009B6A RID: 39786
		[Token(Token = "0x4009B6A")]
		[FieldOffset(Offset = "0x14")]
		public int Height;

		// Token: 0x04009B6B RID: 39787
		[Token(Token = "0x4009B6B")]
		[FieldOffset(Offset = "0x18")]
		public bool Wall;

		// Token: 0x04009B6C RID: 39788
		[Token(Token = "0x4009B6C")]
		[FieldOffset(Offset = "0x1C")]
		public int OverridePaintTile;

		// Token: 0x04009B6D RID: 39789
		[Token(Token = "0x4009B6D")]
		[FieldOffset(Offset = "0x20")]
		public int OverridePaintWall;

		// Token: 0x04009B6E RID: 39790
		[Token(Token = "0x4009B6E")]
		[FieldOffset(Offset = "0x24")]
		public bool CrowningOnTop;

		// Token: 0x04009B6F RID: 39791
		[Token(Token = "0x4009B6F")]
		[FieldOffset(Offset = "0x25")]
		public bool CrowningOnBottom;

		// Token: 0x04009B70 RID: 39792
		[Token(Token = "0x4009B70")]
		[FieldOffset(Offset = "0x26")]
		public bool CrowningStopsAtPillar;

		// Token: 0x04009B71 RID: 39793
		[Token(Token = "0x4009B71")]
		[FieldOffset(Offset = "0x27")]
		public bool AlwaysPlaceEntirePillar;
	}
}
