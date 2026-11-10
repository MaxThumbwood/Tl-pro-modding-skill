using System;
using Il2CppDummyDll;

// Token: 0x0200025D RID: 605
[Token(Token = "0x200025D")]
public class SaveDataCategory_Layout : LayoutDefinition
{
	// Token: 0x06000E77 RID: 3703 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E77")]
	[Address(RVA = "0xC95194", Offset = "0xC95194", VA = "0xC95194")]
	private void Awake()
	{
	}

	// Token: 0x06000E78 RID: 3704 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E78")]
	[Address(RVA = "0xC951E8", Offset = "0xC951E8", VA = "0xC951E8")]
	public SaveDataCategory_Layout()
	{
	}

	// Token: 0x04001CC6 RID: 7366
	[Token(Token = "0x4001CC6")]
	[FieldOffset(Offset = "0x0")]
	public static SaveDataCategory_Layout Instance;

	// Token: 0x04001CC7 RID: 7367
	[Token(Token = "0x4001CC7")]
	[FieldOffset(Offset = "0xC")]
	public Panel_Layout Backing;

	// Token: 0x04001CC8 RID: 7368
	[Token(Token = "0x4001CC8")]
	[FieldOffset(Offset = "0x10")]
	public TransactionButton_Layout LocalPlayers;

	// Token: 0x04001CC9 RID: 7369
	[Token(Token = "0x4001CC9")]
	[FieldOffset(Offset = "0x14")]
	public TransactionButton_Layout RemotePlayers;

	// Token: 0x04001CCA RID: 7370
	[Token(Token = "0x4001CCA")]
	[FieldOffset(Offset = "0x18")]
	public TransactionButton_Layout LocalWorlds;

	// Token: 0x04001CCB RID: 7371
	[Token(Token = "0x4001CCB")]
	[FieldOffset(Offset = "0x1C")]
	public TransactionButton_Layout RemoteWorlds;

	// Token: 0x04001CCC RID: 7372
	[Token(Token = "0x4001CCC")]
	[FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout Upload;

	// Token: 0x04001CCD RID: 7373
	[Token(Token = "0x4001CCD")]
	[FieldOffset(Offset = "0x24")]
	public TransactionButton_Layout Download;

	// Token: 0x04001CCE RID: 7374
	[Token(Token = "0x4001CCE")]
	[FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout UploadSettings;

	// Token: 0x04001CCF RID: 7375
	[Token(Token = "0x4001CCF")]
	[FieldOffset(Offset = "0x2C")]
	public TransactionButton_Layout DownloadSettings;
}
