using System;
using Il2CppDummyDll;

// Token: 0x0200006F RID: 111
[Token(Token = "0x200006F")]
public class CachedFile
{
	// Token: 0x06000247 RID: 583 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000247")]
	[Address(RVA = "0x4B2D08", Offset = "0x4B2D08", VA = "0x4B2D08")]
	public CachedFile(string filename)
	{
	}

	// Token: 0x1700007A RID: 122
	// (get) Token: 0x06000248 RID: 584 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000249 RID: 585 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700007A")]
	public byte[] Data
	{
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x4B2D30", Offset = "0x4B2D30", VA = "0x4B2D30")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x4B2D38", Offset = "0x4B2D38", VA = "0x4B2D38")]
		set
		{
		}
	}

	// Token: 0x0400047B RID: 1147
	[Token(Token = "0x400047B")]
	[FieldOffset(Offset = "0x8")]
	public CachedFile.Modifications ModificationFlag;

	// Token: 0x0400047C RID: 1148
	[Token(Token = "0x400047C")]
	[FieldOffset(Offset = "0xC")]
	public readonly string Filename;

	// Token: 0x0400047D RID: 1149
	[Token(Token = "0x400047D")]
	[FieldOffset(Offset = "0x10")]
	public bool DontCache;

	// Token: 0x0400047E RID: 1150
	[Token(Token = "0x400047E")]
	[FieldOffset(Offset = "0x14")]
	private byte[] <Data>k__BackingField;

	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000070")]
	public enum Modifications
	{
		// Token: 0x04000480 RID: 1152
		[Token(Token = "0x4000480")]
		Delete,
		// Token: 0x04000481 RID: 1153
		[Token(Token = "0x4000481")]
		Write,
		// Token: 0x04000482 RID: 1154
		[Token(Token = "0x4000482")]
		None
	}
}
