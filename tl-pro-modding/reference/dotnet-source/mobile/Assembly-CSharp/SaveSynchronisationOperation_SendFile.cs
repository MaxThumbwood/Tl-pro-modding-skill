using System;
using Il2CppDummyDll;

// Token: 0x0200032F RID: 815
[Token(Token = "0x200032F")]
public class SaveSynchronisationOperation_SendFile : SaveSynchronisationOperation
{
	// Token: 0x0600141E RID: 5150 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600141E")]
	[Address(RVA = "0xDB1690", Offset = "0xDB1690", VA = "0xDB1690")]
	public SaveSynchronisationOperation_SendFile(string filenameToSend, SaveSynchronisationOperation.SendDataFunction sendOperation)
	{
	}

	// Token: 0x0600141F RID: 5151 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600141F")]
	[Address(RVA = "0xDB6CAC", Offset = "0xDB6CAC", VA = "0xDB6CAC", Slot = "4")]
	public override void Begin()
	{
	}

	// Token: 0x06001420 RID: 5152 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001420")]
	[Address(RVA = "0xDB73F0", Offset = "0xDB73F0", VA = "0xDB73F0", Slot = "5")]
	public override void ProcessMessage(SaveSynchronisationOperation.MessageId messageId, byte[] data)
	{
	}

	// Token: 0x06001421 RID: 5153 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001421")]
	[Address(RVA = "0xDB728C", Offset = "0xDB728C", VA = "0xDB728C")]
	private void SendNextChunk()
	{
	}

	// Token: 0x06001422 RID: 5154 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001422")]
	[Address(RVA = "0xDB754C", Offset = "0xDB754C", VA = "0xDB754C", Slot = "7")]
	public override string GetStatus()
	{
		return null;
	}

	// Token: 0x040027D1 RID: 10193
	[Token(Token = "0x40027D1")]
	[FieldOffset(Offset = "0x10")]
	private string filename;

	// Token: 0x040027D2 RID: 10194
	[Token(Token = "0x40027D2")]
	[FieldOffset(Offset = "0x14")]
	private byte[] fileDataToSend;

	// Token: 0x040027D3 RID: 10195
	[Token(Token = "0x40027D3")]
	[FieldOffset(Offset = "0x18")]
	private int sendOffset;

	// Token: 0x040027D4 RID: 10196
	[Token(Token = "0x40027D4")]
	[FieldOffset(Offset = "0x1C")]
	private int pendingChunks;

	// Token: 0x040027D5 RID: 10197
	[Token(Token = "0x40027D5")]
	[FieldOffset(Offset = "0x20")]
	private int mapFilesOffset;

	// Token: 0x040027D6 RID: 10198
	[Token(Token = "0x40027D6")]
	[FieldOffset(Offset = "0x24")]
	private string[] mapFiles;

	// Token: 0x040027D7 RID: 10199
	[Token(Token = "0x40027D7")]
	[FieldOffset(Offset = "0x0")]
	private static byte[] fileDataBuffer;
}
