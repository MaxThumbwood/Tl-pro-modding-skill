using System;
using Il2CppDummyDll;

// Token: 0x0200021F RID: 543
[Token(Token = "0x200021F")]
public class LowDiskSpacePopup_Layout : LayoutDefinition
{
	// Token: 0x06000DFE RID: 3582 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DFE")]
	[Address(RVA = "0xC90904", Offset = "0xC90904", VA = "0xC90904")]
	private void Awake()
	{
	}

	// Token: 0x06000DFF RID: 3583 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DFF")]
	[Address(RVA = "0xC90958", Offset = "0xC90958", VA = "0xC90958")]
	public LowDiskSpacePopup_Layout()
	{
	}

	// Token: 0x04001740 RID: 5952
	[Token(Token = "0x4001740")]
	[FieldOffset(Offset = "0x0")]
	public static LowDiskSpacePopup_Layout Instance;

	// Token: 0x04001741 RID: 5953
	[Token(Token = "0x4001741")]
	[FieldOffset(Offset = "0xC")]
	public StringButton_Layout Status;

	// Token: 0x04001742 RID: 5954
	[Token(Token = "0x4001742")]
	[FieldOffset(Offset = "0x10")]
	public TransactionButton_Layout Cancel;

	// Token: 0x04001743 RID: 5955
	[Token(Token = "0x4001743")]
	[FieldOffset(Offset = "0x14")]
	public TransactionButton_Layout Continue;
}
