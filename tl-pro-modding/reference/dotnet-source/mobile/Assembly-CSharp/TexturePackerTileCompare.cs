using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200034E RID: 846
[Token(Token = "0x200034E")]
public static class TexturePackerTileCompare
{
	// Token: 0x060014EC RID: 5356 RVA: 0x000093A8 File Offset: 0x000075A8
	[Token(Token = "0x60014EC")]
	[Address(RVA = "0xDF17EC", Offset = "0xDF17EC", VA = "0xDF17EC")]
	public static TexturePackerTileCompare.CompareResult Compare(int tileWidth, int tileHeight, Color32[] src1, Color32[] src2)
	{
		return TexturePackerTileCompare.CompareResult.NoMatch;
	}

	// Token: 0x060014ED RID: 5357 RVA: 0x000093C0 File Offset: 0x000075C0
	[Token(Token = "0x60014ED")]
	[Address(RVA = "0xDF1A7C", Offset = "0xDF1A7C", VA = "0xDF1A7C")]
	private static bool CompareIdentical(int tileWidth, int tileHeight, Color32[] src1, Color32[] src2)
	{
		return default(bool);
	}

	// Token: 0x060014EE RID: 5358 RVA: 0x000093D8 File Offset: 0x000075D8
	[Token(Token = "0x60014EE")]
	[Address(RVA = "0xDF1B5C", Offset = "0xDF1B5C", VA = "0xDF1B5C")]
	private static bool CompareXFlip(int tileWidth, int tileHeight, Color32[] src1, Color32[] src2)
	{
		return default(bool);
	}

	// Token: 0x060014EF RID: 5359 RVA: 0x000093F0 File Offset: 0x000075F0
	[Token(Token = "0x60014EF")]
	[Address(RVA = "0xDF1C3C", Offset = "0xDF1C3C", VA = "0xDF1C3C")]
	private static bool CompareYFlip(int tileWidth, int tileHeight, Color32[] src1, Color32[] src2)
	{
		return default(bool);
	}

	// Token: 0x060014F0 RID: 5360 RVA: 0x00009408 File Offset: 0x00007608
	[Token(Token = "0x60014F0")]
	[Address(RVA = "0xDF1D30", Offset = "0xDF1D30", VA = "0xDF1D30")]
	private static bool CompareXYFlip(int tileWidth, int tileHeight, Color32[] src1, Color32[] src2)
	{
		return default(bool);
	}

	// Token: 0x0200034F RID: 847
	[Token(Token = "0x200034F")]
	public enum CompareResult
	{
		// Token: 0x04002993 RID: 10643
		[Token(Token = "0x4002993")]
		NoMatch,
		// Token: 0x04002994 RID: 10644
		[Token(Token = "0x4002994")]
		Same,
		// Token: 0x04002995 RID: 10645
		[Token(Token = "0x4002995")]
		XFlip,
		// Token: 0x04002996 RID: 10646
		[Token(Token = "0x4002996")]
		YFlip,
		// Token: 0x04002997 RID: 10647
		[Token(Token = "0x4002997")]
		XYFlip
	}
}
