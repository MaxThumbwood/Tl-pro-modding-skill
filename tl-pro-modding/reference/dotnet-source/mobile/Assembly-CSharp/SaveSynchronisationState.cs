using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using Terraria;
using Terraria.IO;

// Token: 0x02000331 RID: 817
[Token(Token = "0x2000331")]
public class SaveSynchronisationState
{
	// Token: 0x0600142C RID: 5164 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600142C")]
	[Address(RVA = "0xDB557C", Offset = "0xDB557C", VA = "0xDB557C")]
	public void RefreshFromFileSystem()
	{
	}

	// Token: 0x0600142D RID: 5165 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600142D")]
	[Address(RVA = "0xDB53C8", Offset = "0xDB53C8", VA = "0xDB53C8")]
	public void ProcessMessage(SaveSynchronisationOperation.MessageId messageId, byte[] data)
	{
	}

	// Token: 0x0600142E RID: 5166 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600142E")]
	[Address(RVA = "0xDBA188", Offset = "0xDBA188", VA = "0xDBA188")]
	public void SendEmptyMessage(SaveSynchronisationOperation.MessageId id, SaveSynchronisationOperation.SendDataFunction sendDataFunction)
	{
	}

	// Token: 0x0600142F RID: 5167 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600142F")]
	[Address(RVA = "0xDB5414", Offset = "0xDB5414", VA = "0xDB5414")]
	public void ProcessMessageResponse(SaveSynchronisationOperation.MessageId messageId, SaveSynchronisationOperation.SendDataFunction sendDataFunction)
	{
	}

	// Token: 0x06001430 RID: 5168 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001430")]
	[Address(RVA = "0xDB9620", Offset = "0xDB9620", VA = "0xDB9620")]
	private void ReadPlayerFileData(byte[] data)
	{
	}

	// Token: 0x06001431 RID: 5169 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001431")]
	[Address(RVA = "0xDBA274", Offset = "0xDBA274", VA = "0xDBA274")]
	private void ReadPlayerData(BinaryReader reader, Player player)
	{
	}

	// Token: 0x06001432 RID: 5170 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001432")]
	[Address(RVA = "0xDB9BAC", Offset = "0xDB9BAC", VA = "0xDB9BAC")]
	private void ReadWorldFileData(byte[] data)
	{
	}

	// Token: 0x06001433 RID: 5171 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001433")]
	[Address(RVA = "0xDB5700", Offset = "0xDB5700", VA = "0xDB5700")]
	public void Clear()
	{
	}

	// Token: 0x06001434 RID: 5172 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001434")]
	[Address(RVA = "0xDB5C54", Offset = "0xDB5C54", VA = "0xDB5C54")]
	public SaveSynchronisationState()
	{
	}

	// Token: 0x040027DD RID: 10205
	[Token(Token = "0x40027DD")]
	[FieldOffset(Offset = "0x0")]
	private static byte[] emptyMessageData;

	// Token: 0x040027DE RID: 10206
	[Token(Token = "0x40027DE")]
	[FieldOffset(Offset = "0x8")]
	public bool IsSynchronised;

	// Token: 0x040027DF RID: 10207
	[Token(Token = "0x40027DF")]
	[FieldOffset(Offset = "0xC")]
	public List<PlayerFileData> playerFiles;

	// Token: 0x040027E0 RID: 10208
	[Token(Token = "0x40027E0")]
	[FieldOffset(Offset = "0x10")]
	public List<WorldFileData> worldFiles;
}
