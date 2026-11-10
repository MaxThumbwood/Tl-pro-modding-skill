using System;
using Il2CppDummyDll;

// Token: 0x0200032E RID: 814
[Token(Token = "0x200032E")]
public class SaveSynchronisationOperation_ReceiveFile : SaveSynchronisationOperation
{
	// Token: 0x06001419 RID: 5145 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001419")]
	[Address(RVA = "0xDB267C", Offset = "0xDB267C", VA = "0xDB267C")]
	public SaveSynchronisationOperation_ReceiveFile(SaveSynchronisationOperation.SendDataFunction sendOperation)
	{
	}

	// Token: 0x0600141A RID: 5146 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600141A")]
	[Address(RVA = "0xDB5FD8", Offset = "0xDB5FD8", VA = "0xDB5FD8", Slot = "4")]
	public override void Begin()
	{
	}

	// Token: 0x0600141B RID: 5147 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600141B")]
	[Address(RVA = "0xDB5FDC", Offset = "0xDB5FDC", VA = "0xDB5FDC", Slot = "5")]
	public override void ProcessMessage(SaveSynchronisationOperation.MessageId messageId, byte[] data)
	{
	}

	// Token: 0x0600141C RID: 5148 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600141C")]
	[Address(RVA = "0xDB6980", Offset = "0xDB6980", VA = "0xDB6980")]
	private void WriteFile()
	{
	}

	// Token: 0x0600141D RID: 5149 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600141D")]
	[Address(RVA = "0xDB6BE4", Offset = "0xDB6BE4", VA = "0xDB6BE4", Slot = "7")]
	public override string GetStatus()
	{
		return null;
	}

	// Token: 0x040027CD RID: 10189
	[Token(Token = "0x40027CD")]
	[FieldOffset(Offset = "0x10")]
	private string filename;

	// Token: 0x040027CE RID: 10190
	[Token(Token = "0x40027CE")]
	[FieldOffset(Offset = "0x14")]
	private int fileOffset;

	// Token: 0x040027CF RID: 10191
	[Token(Token = "0x40027CF")]
	[FieldOffset(Offset = "0x18")]
	private int fileLength;

	// Token: 0x040027D0 RID: 10192
	[Token(Token = "0x40027D0")]
	[FieldOffset(Offset = "0x1C")]
	private byte[] fileData;
}
