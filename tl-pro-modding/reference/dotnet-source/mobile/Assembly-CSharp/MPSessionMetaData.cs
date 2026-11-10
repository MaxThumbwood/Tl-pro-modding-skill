using System;
using System.Net;
using Il2CppDummyDll;

// Token: 0x0200030C RID: 780
[Token(Token = "0x200030C")]
public class MPSessionMetaData
{
	// Token: 0x0600136D RID: 4973 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600136D")]
	[Address(RVA = "0xD92AAC", Offset = "0xD92AAC", VA = "0xD92AAC")]
	public MPSessionMetaData()
	{
	}

	// Token: 0x04002561 RID: 9569
	[Token(Token = "0x4002561")]
	[FieldOffset(Offset = "0x8")]
	public string WorldName;

	// Token: 0x04002562 RID: 9570
	[Token(Token = "0x4002562")]
	[FieldOffset(Offset = "0xC")]
	public IPAddress ServerAddress;

	// Token: 0x04002563 RID: 9571
	[Token(Token = "0x4002563")]
	[FieldOffset(Offset = "0x10")]
	public int ServerPort;

	// Token: 0x04002564 RID: 9572
	[Token(Token = "0x4002564")]
	[FieldOffset(Offset = "0x14")]
	public ushort WorldXSize;

	// Token: 0x04002565 RID: 9573
	[Token(Token = "0x4002565")]
	[FieldOffset(Offset = "0x18")]
	public int NumberOfPlayers;

	// Token: 0x04002566 RID: 9574
	[Token(Token = "0x4002566")]
	[FieldOffset(Offset = "0x1C")]
	public int MaxPlayers;

	// Token: 0x04002567 RID: 9575
	[Token(Token = "0x4002567")]
	[FieldOffset(Offset = "0x20")]
	public short GameMode;

	// Token: 0x04002568 RID: 9576
	[Token(Token = "0x4002568")]
	[FieldOffset(Offset = "0x22")]
	public bool Corruption;

	// Token: 0x04002569 RID: 9577
	[Token(Token = "0x4002569")]
	[FieldOffset(Offset = "0x23")]
	public bool HardMode;

	// Token: 0x0400256A RID: 9578
	[Token(Token = "0x400256A")]
	[FieldOffset(Offset = "0x24")]
	public bool Crossplay;

	// Token: 0x0400256B RID: 9579
	[Token(Token = "0x400256B")]
	[FieldOffset(Offset = "0x28")]
	public string HostName;

	// Token: 0x0400256C RID: 9580
	[Token(Token = "0x400256C")]
	[FieldOffset(Offset = "0x2C")]
	public bool HasRemoteIP;

	// Token: 0x0400256D RID: 9581
	[Token(Token = "0x400256D")]
	[FieldOffset(Offset = "0x30")]
	public IPAddress RemoteIP;

	// Token: 0x0400256E RID: 9582
	[Token(Token = "0x400256E")]
	[FieldOffset(Offset = "0x34")]
	public int RemotePort;

	// Token: 0x0400256F RID: 9583
	[Token(Token = "0x400256F")]
	[FieldOffset(Offset = "0x38")]
	public bool InviteOnly;

	// Token: 0x04002570 RID: 9584
	[Token(Token = "0x4002570")]
	[FieldOffset(Offset = "0x39")]
	public bool SkyWorld;
}
