using System;
using System.IO;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200034C RID: 844
[Token(Token = "0x200034C")]
public class TextureAtlasEntry
{
	// Token: 0x060014E1 RID: 5345 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014E1")]
	[Address(RVA = "0xDEF400", Offset = "0xDEF400", VA = "0xDEF400")]
	public TextureAtlasEntry(int textureId)
	{
	}

	// Token: 0x060014E2 RID: 5346 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014E2")]
	[Address(RVA = "0xDF12AC", Offset = "0xDF12AC", VA = "0xDF12AC")]
	public TextureAtlasEntry(int textureId, int atlasIndex, short textureWidth, short textureHeight, short textureOffsetX, short textureOffsetY, short textureScale)
	{
	}

	// Token: 0x060014E3 RID: 5347 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014E3")]
	[Address(RVA = "0xDEFB20", Offset = "0xDEFB20", VA = "0xDEFB20")]
	public void Save(BinaryWriter writer)
	{
	}

	// Token: 0x060014E4 RID: 5348 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014E4")]
	[Address(RVA = "0xDEF134", Offset = "0xDEF134", VA = "0xDEF134")]
	public static TextureAtlasEntry Load(BinaryReader loader, short version)
	{
		return null;
	}

	// Token: 0x060014E5 RID: 5349 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014E5")]
	[Address(RVA = "0xDEF200", Offset = "0xDEF200", VA = "0xDEF200")]
	public void LoadData(BinaryReader loader, short version)
	{
	}

	// Token: 0x04002984 RID: 10628
	[Token(Token = "0x4002984")]
	[FieldOffset(Offset = "0x8")]
	public int TextureId;

	// Token: 0x04002985 RID: 10629
	[Token(Token = "0x4002985")]
	[FieldOffset(Offset = "0xC")]
	public int AtlasIndex;

	// Token: 0x04002986 RID: 10630
	[Token(Token = "0x4002986")]
	[FieldOffset(Offset = "0x10")]
	public short TextureOffsetX;

	// Token: 0x04002987 RID: 10631
	[Token(Token = "0x4002987")]
	[FieldOffset(Offset = "0x12")]
	public short TextureOffsetY;

	// Token: 0x04002988 RID: 10632
	[Token(Token = "0x4002988")]
	[FieldOffset(Offset = "0x14")]
	public short TextureWidth;

	// Token: 0x04002989 RID: 10633
	[Token(Token = "0x4002989")]
	[FieldOffset(Offset = "0x16")]
	public short TextureHeight;

	// Token: 0x0400298A RID: 10634
	[Token(Token = "0x400298A")]
	[FieldOffset(Offset = "0x18")]
	public short TileWidth;

	// Token: 0x0400298B RID: 10635
	[Token(Token = "0x400298B")]
	[FieldOffset(Offset = "0x1A")]
	public short TileHeight;

	// Token: 0x0400298C RID: 10636
	[Token(Token = "0x400298C")]
	[FieldOffset(Offset = "0x1C")]
	public bool TileTrimming;

	// Token: 0x0400298D RID: 10637
	[Token(Token = "0x400298D")]
	[FieldOffset(Offset = "0x1E")]
	public short TextureScale;

	// Token: 0x0400298E RID: 10638
	[Token(Token = "0x400298E")]
	[FieldOffset(Offset = "0x20")]
	public int TileDataOffset;

	// Token: 0x0400298F RID: 10639
	[Token(Token = "0x400298F")]
	[FieldOffset(Offset = "0x24")]
	public Texture2D AttachedTexture;

	// Token: 0x0200034D RID: 845
	[Token(Token = "0x200034D")]
	public static class TextureAtlasEntryTiles
	{
		// Token: 0x060014E6 RID: 5350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014E6")]
		[Address(RVA = "0xDF15C8", Offset = "0xDF15C8", VA = "0xDF15C8")]
		public static void Reset()
		{
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014E7")]
		[Address(RVA = "0xDF143C", Offset = "0xDF143C", VA = "0xDF143C")]
		public static void LoadTileData(BinaryReader loader, TextureAtlasEntry entry)
		{
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014E8")]
		[Address(RVA = "0xDF1308", Offset = "0xDF1308", VA = "0xDF1308")]
		public static void SaveTileData(BinaryWriter writer, TextureAtlasEntry entry)
		{
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x00009378 File Offset: 0x00007578
		[Token(Token = "0x60014E9")]
		[Address(RVA = "0xDF16D4", Offset = "0xDF16D4", VA = "0xDF16D4")]
		public static int CalculateFrameCount(TextureAtlasEntry entry)
		{
			return 0;
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x00009390 File Offset: 0x00007590
		[Token(Token = "0x60014EA")]
		[Address(RVA = "0xDF1630", Offset = "0xDF1630", VA = "0xDF1630")]
		public static int ReserveData(TextureAtlasEntry entry)
		{
			return 0;
		}

		// Token: 0x04002990 RID: 10640
		[Token(Token = "0x4002990")]
		[FieldOffset(Offset = "0x0")]
		public static short[] TileOffsetData;

		// Token: 0x04002991 RID: 10641
		[Token(Token = "0x4002991")]
		[FieldOffset(Offset = "0x4")]
		private static int TileDataOffset;
	}
}
