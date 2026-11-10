using System;
using Il2CppDummyDll;

// Token: 0x02000261 RID: 609
[Token(Token = "0x2000261")]
public class SaveSyncStatus_Layout : LayoutDefinition
{
	// Token: 0x06000E7F RID: 3711 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E7F")]
	[Address(RVA = "0xC95484", Offset = "0xC95484", VA = "0xC95484")]
	private void Awake()
	{
	}

	// Token: 0x06000E80 RID: 3712 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E80")]
	[Address(RVA = "0xC954D8", Offset = "0xC954D8", VA = "0xC954D8")]
	public SaveSyncStatus_Layout()
	{
	}

	// Token: 0x04001D2F RID: 7471
	[Token(Token = "0x4001D2F")]
	[FieldOffset(Offset = "0x0")]
	public static SaveSyncStatus_Layout Instance;

	// Token: 0x04001D30 RID: 7472
	[Token(Token = "0x4001D30")]
	[FieldOffset(Offset = "0xC")]
	public StringButton_Layout Status;

	// Token: 0x04001D31 RID: 7473
	[Token(Token = "0x4001D31")]
	[FieldOffset(Offset = "0x10")]
	public TransactionButton_Layout Cancel;
}
