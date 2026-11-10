using System;
using Il2CppDummyDll;

// Token: 0x02000061 RID: 97
[Token(Token = "0x2000061")]
public class SimpleProfilerFrameData
{
	// Token: 0x06000201 RID: 513 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000201")]
	[Address(RVA = "0x4AD608", Offset = "0x4AD608", VA = "0x4AD608")]
	public SimpleProfilerFrameData(int size)
	{
	}

	// Token: 0x06000202 RID: 514 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000202")]
	[Address(RVA = "0x4AD9C0", Offset = "0x4AD9C0", VA = "0x4AD9C0")]
	public void Reset()
	{
	}

	// Token: 0x0400045B RID: 1115
	[Token(Token = "0x400045B")]
	[FieldOffset(Offset = "0x8")]
	public long Overheads;

	// Token: 0x0400045C RID: 1116
	[Token(Token = "0x400045C")]
	[FieldOffset(Offset = "0x10")]
	public long FrameTime;

	// Token: 0x0400045D RID: 1117
	[Token(Token = "0x400045D")]
	[FieldOffset(Offset = "0x18")]
	public readonly int[] CallCount;

	// Token: 0x0400045E RID: 1118
	[Token(Token = "0x400045E")]
	[FieldOffset(Offset = "0x1C")]
	public readonly long[] ExececutionTime;
}
