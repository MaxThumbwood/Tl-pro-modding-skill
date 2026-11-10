using System;
using System.IO;
using Il2CppDummyDll;
using Terraria;
using Terraria.IO;

// Token: 0x02000330 RID: 816
[Token(Token = "0x2000330")]
public class SaveSynchronisationOperation_SendFileList : SaveSynchronisationOperation
{
	// Token: 0x06001424 RID: 5156 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001424")]
	[Address(RVA = "0xDB2560", Offset = "0xDB2560", VA = "0xDB2560")]
	public SaveSynchronisationOperation_SendFileList(SaveSynchronisationOperation.SendDataFunction sendOperation)
	{
	}

	// Token: 0x06001425 RID: 5157 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001425")]
	[Address(RVA = "0xDB76A0", Offset = "0xDB76A0", VA = "0xDB76A0", Slot = "4")]
	public override void Begin()
	{
	}

	// Token: 0x06001426 RID: 5158 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001426")]
	[Address(RVA = "0xDB792C", Offset = "0xDB792C", VA = "0xDB792C")]
	private void SendPlayerFile(PlayerFileData playerFileData)
	{
	}

	// Token: 0x06001427 RID: 5159 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001427")]
	[Address(RVA = "0xDB7F00", Offset = "0xDB7F00", VA = "0xDB7F00")]
	private void WritePlayerData(BinaryWriter writer, Player player)
	{
	}

	// Token: 0x06001428 RID: 5160 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001428")]
	[Address(RVA = "0xDB8D1C", Offset = "0xDB8D1C", VA = "0xDB8D1C")]
	private void SendWorldFile(WorldFileData worldFileData)
	{
	}

	// Token: 0x06001429 RID: 5161 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001429")]
	[Address(RVA = "0xDB76D4", Offset = "0xDB76D4", VA = "0xDB76D4")]
	private void SendNextFile()
	{
	}

	// Token: 0x0600142A RID: 5162 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600142A")]
	[Address(RVA = "0xDB93AC", Offset = "0xDB93AC", VA = "0xDB93AC", Slot = "5")]
	public override void ProcessMessage(SaveSynchronisationOperation.MessageId messageId, byte[] data)
	{
	}

	// Token: 0x0600142B RID: 5163 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600142B")]
	[Address(RVA = "0xDB93E4", Offset = "0xDB93E4", VA = "0xDB93E4", Slot = "7")]
	public override string GetStatus()
	{
		return null;
	}

	// Token: 0x040027D8 RID: 10200
	[Token(Token = "0x40027D8")]
	[FieldOffset(Offset = "0x10")]
	private int fileCountPending;

	// Token: 0x040027D9 RID: 10201
	[Token(Token = "0x40027D9")]
	[FieldOffset(Offset = "0x14")]
	private int fileOffset;

	// Token: 0x040027DA RID: 10202
	[Token(Token = "0x40027DA")]
	[FieldOffset(Offset = "0x18")]
	private bool sentPlayers;

	// Token: 0x040027DB RID: 10203
	[Token(Token = "0x40027DB")]
	[FieldOffset(Offset = "0x19")]
	private bool sentWorlds;

	// Token: 0x040027DC RID: 10204
	[Token(Token = "0x40027DC")]
	[FieldOffset(Offset = "0x1A")]
	private bool sentEndList;
}
