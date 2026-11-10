using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Features
{
	// Token: 0x02000B7B RID: 2939
	[Token(Token = "0x2000B7B")]
	public class DungeonTileClumpSettings : DungeonFeatureSettings
	{
		// Token: 0x06005A20 RID: 23072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A20")]
		[Address(RVA = "0x8EBB00", Offset = "0x8EBB00", VA = "0x8EBB00")]
		public DungeonTileClumpSettings()
		{
		}

		// Token: 0x04009B7B RID: 39803
		[Token(Token = "0x4009B7B")]
		[FieldOffset(Offset = "0x8")]
		public int RandomSeed;

		// Token: 0x04009B7C RID: 39804
		[Token(Token = "0x4009B7C")]
		[FieldOffset(Offset = "0x10")]
		public double Strength;

		// Token: 0x04009B7D RID: 39805
		[Token(Token = "0x4009B7D")]
		[FieldOffset(Offset = "0x18")]
		public int Steps;

		// Token: 0x04009B7E RID: 39806
		[Token(Token = "0x4009B7E")]
		[FieldOffset(Offset = "0x1C")]
		public ushort TileType;

		// Token: 0x04009B7F RID: 39807
		[Token(Token = "0x4009B7F")]
		[FieldOffset(Offset = "0x1E")]
		public ushort WallType;

		// Token: 0x04009B80 RID: 39808
		[Token(Token = "0x4009B80")]
		[FieldOffset(Offset = "0x20")]
		public DungeonBounds AreaToGenerateIn;

		// Token: 0x04009B81 RID: 39809
		[Token(Token = "0x4009B81")]
		[FieldOffset(Offset = "0x24")]
		public ushort? OnlyReplaceThisTileType;

		// Token: 0x04009B82 RID: 39810
		[Token(Token = "0x4009B82")]
		[FieldOffset(Offset = "0x28")]
		public ushort? OnlyReplaceThisWallType;
	}
}
