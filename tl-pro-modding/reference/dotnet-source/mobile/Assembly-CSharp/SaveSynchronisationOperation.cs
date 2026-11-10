using System;
using System.IO;
using Il2CppDummyDll;

// Token: 0x0200032B RID: 811
[Token(Token = "0x200032B")]
public class SaveSynchronisationOperation
{
	// Token: 0x0600140C RID: 5132 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600140C")]
	[Address(RVA = "0xDB5D4C", Offset = "0xDB5D4C", VA = "0xDB5D4C")]
	public SaveSynchronisationOperation(SaveSynchronisationOperation.SendDataFunction sendOperation)
	{
	}

	// Token: 0x0600140D RID: 5133 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600140D")]
	[Address(RVA = "0xDB5D68", Offset = "0xDB5D68", VA = "0xDB5D68", Slot = "4")]
	public virtual void Begin()
	{
	}

	// Token: 0x0600140E RID: 5134 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600140E")]
	[Address(RVA = "0xDB5D6C", Offset = "0xDB5D6C", VA = "0xDB5D6C")]
	public void SendEmptyMessage(SaveSynchronisationOperation.MessageId id)
	{
	}

	// Token: 0x0600140F RID: 5135 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600140F")]
	[Address(RVA = "0xDB12F0", Offset = "0xDB12F0", VA = "0xDB12F0")]
	public static void WriteMessageHeader(BinaryWriter packet, SaveSynchronisationOperation.MessageId id)
	{
	}

	// Token: 0x06001410 RID: 5136 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001410")]
	[Address(RVA = "0xDB1348", Offset = "0xDB1348", VA = "0xDB1348")]
	public static void WriteMessageLength(BinaryWriter packet)
	{
	}

	// Token: 0x06001411 RID: 5137 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001411")]
	[Address(RVA = "0xDB5E5C", Offset = "0xDB5E5C", VA = "0xDB5E5C", Slot = "5")]
	public virtual void ProcessMessage(SaveSynchronisationOperation.MessageId messageId, byte[] data)
	{
	}

	// Token: 0x06001412 RID: 5138 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001412")]
	[Address(RVA = "0xDB5E60", Offset = "0xDB5E60", VA = "0xDB5E60", Slot = "6")]
	public virtual void Cancel()
	{
	}

	// Token: 0x06001413 RID: 5139 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001413")]
	[Address(RVA = "0xDB5E64", Offset = "0xDB5E64", VA = "0xDB5E64", Slot = "7")]
	public virtual string GetStatus()
	{
		return null;
	}

	// Token: 0x040027C0 RID: 10176
	[Token(Token = "0x40027C0")]
	[FieldOffset(Offset = "0x8")]
	protected readonly SaveSynchronisationOperation.SendDataFunction SendData;

	// Token: 0x040027C1 RID: 10177
	[Token(Token = "0x40027C1")]
	[FieldOffset(Offset = "0x0")]
	private static byte[] emptyMessageData;

	// Token: 0x040027C2 RID: 10178
	[Token(Token = "0x40027C2")]
	[FieldOffset(Offset = "0xC")]
	public bool IsComplete;

	// Token: 0x0200032C RID: 812
	[Token(Token = "0x200032C")]
	public enum MessageId
	{
		// Token: 0x040027C4 RID: 10180
		[Token(Token = "0x40027C4")]
		BeginFileList,
		// Token: 0x040027C5 RID: 10181
		[Token(Token = "0x40027C5")]
		PlayerFileEntry,
		// Token: 0x040027C6 RID: 10182
		[Token(Token = "0x40027C6")]
		WorldFileEntry,
		// Token: 0x040027C7 RID: 10183
		[Token(Token = "0x40027C7")]
		FileEntryReceived,
		// Token: 0x040027C8 RID: 10184
		[Token(Token = "0x40027C8")]
		EndFileList,
		// Token: 0x040027C9 RID: 10185
		[Token(Token = "0x40027C9")]
		RequestFileData,
		// Token: 0x040027CA RID: 10186
		[Token(Token = "0x40027CA")]
		BeginFileData,
		// Token: 0x040027CB RID: 10187
		[Token(Token = "0x40027CB")]
		FileData,
		// Token: 0x040027CC RID: 10188
		[Token(Token = "0x40027CC")]
		FileDataRecieved
	}

	// Token: 0x0200032D RID: 813
	// (Invoke) Token: 0x06001416 RID: 5142
	[Token(Token = "0x200032D")]
	public delegate void SendDataFunction(byte[] messageData, int length);
}
