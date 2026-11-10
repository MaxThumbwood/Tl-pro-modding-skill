using System;
using System.IO;
using Il2CppDummyDll;

// Token: 0x02000337 RID: 823
[Token(Token = "0x2000337")]
public class TextureMask
{
	// Token: 0x06001442 RID: 5186 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001442")]
	[Address(RVA = "0xDBE05C", Offset = "0xDBE05C", VA = "0xDBE05C")]
	public void Save(BinaryWriter writer)
	{
	}

	// Token: 0x06001443 RID: 5187 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001443")]
	[Address(RVA = "0xDBE198", Offset = "0xDBE198", VA = "0xDBE198")]
	public void Load(BinaryReader reader)
	{
	}

	// Token: 0x06001444 RID: 5188 RVA: 0x00008FD0 File Offset: 0x000071D0
	[Token(Token = "0x6001444")]
	[Address(RVA = "0xDBE2C8", Offset = "0xDBE2C8", VA = "0xDBE2C8")]
	public bool IsSolid(int x, int y)
	{
		return default(bool);
	}

	// Token: 0x06001445 RID: 5189 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001445")]
	[Address(RVA = "0xDBE360", Offset = "0xDBE360", VA = "0xDBE360")]
	public TextureMask()
	{
	}

	// Token: 0x04002813 RID: 10259
	[Token(Token = "0x4002813")]
	private const int scale = 16;

	// Token: 0x04002814 RID: 10260
	[Token(Token = "0x4002814")]
	[FieldOffset(Offset = "0x8")]
	public int srcWidth;

	// Token: 0x04002815 RID: 10261
	[Token(Token = "0x4002815")]
	[FieldOffset(Offset = "0xC")]
	public int srcHeight;

	// Token: 0x04002816 RID: 10262
	[Token(Token = "0x4002816")]
	[FieldOffset(Offset = "0x10")]
	public int outputWidth;

	// Token: 0x04002817 RID: 10263
	[Token(Token = "0x4002817")]
	[FieldOffset(Offset = "0x14")]
	public int outputHeight;

	// Token: 0x04002818 RID: 10264
	[Token(Token = "0x4002818")]
	[FieldOffset(Offset = "0x18")]
	public bool AllMasked;

	// Token: 0x04002819 RID: 10265
	[Token(Token = "0x4002819")]
	[FieldOffset(Offset = "0x1C")]
	private byte[] Values;
}
