using System;
using Il2CppDummyDll;

// Token: 0x02000191 RID: 401
[Token(Token = "0x2000191")]
public struct GUIInputRegion
{
	// Token: 0x06000BDE RID: 3038 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BDE")]
	[Address(RVA = "0xC544E4", Offset = "0xC544E4", VA = "0xC544E4")]
	public void Set(int x0, int x1, int y0, int y1)
	{
	}

	// Token: 0x06000BDF RID: 3039 RVA: 0x00006D08 File Offset: 0x00004F08
	[Token(Token = "0x6000BDF")]
	[Address(RVA = "0xC544F0", Offset = "0xC544F0", VA = "0xC544F0")]
	public bool Over(int x, int y)
	{
		return default(bool);
	}

	// Token: 0x06000BE0 RID: 3040 RVA: 0x00006D20 File Offset: 0x00004F20
	[Token(Token = "0x6000BE0")]
	[Address(RVA = "0xC54530", Offset = "0xC54530", VA = "0xC54530")]
	public bool OverExpanded(int x, int y, float expanded)
	{
		return default(bool);
	}

	// Token: 0x04000E8E RID: 3726
	[Token(Token = "0x4000E8E")]
	[FieldOffset(Offset = "0x0")]
	public int xMin;

	// Token: 0x04000E8F RID: 3727
	[Token(Token = "0x4000E8F")]
	[FieldOffset(Offset = "0x4")]
	public int xMax;

	// Token: 0x04000E90 RID: 3728
	[Token(Token = "0x4000E90")]
	[FieldOffset(Offset = "0x8")]
	public int yMin;

	// Token: 0x04000E91 RID: 3729
	[Token(Token = "0x4000E91")]
	[FieldOffset(Offset = "0xC")]
	public int yMax;
}
