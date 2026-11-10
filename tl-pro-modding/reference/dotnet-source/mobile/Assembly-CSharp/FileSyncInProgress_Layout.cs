using System;
using Il2CppDummyDll;

// Token: 0x02000216 RID: 534
[Token(Token = "0x2000216")]
public class FileSyncInProgress_Layout : LayoutDefinition
{
	// Token: 0x06000DEC RID: 3564 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DEC")]
	[Address(RVA = "0xC9011C", Offset = "0xC9011C", VA = "0xC9011C")]
	private void Awake()
	{
	}

	// Token: 0x06000DED RID: 3565 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DED")]
	[Address(RVA = "0xC90170", Offset = "0xC90170", VA = "0xC90170")]
	public FileSyncInProgress_Layout()
	{
	}

	// Token: 0x040016D2 RID: 5842
	[Token(Token = "0x40016D2")]
	[FieldOffset(Offset = "0x0")]
	public static FileSyncInProgress_Layout Instance;

	// Token: 0x040016D3 RID: 5843
	[Token(Token = "0x40016D3")]
	[FieldOffset(Offset = "0xC")]
	public Panel_Layout Greyout;

	// Token: 0x040016D4 RID: 5844
	[Token(Token = "0x40016D4")]
	[FieldOffset(Offset = "0x10")]
	public Panel_Layout Backing;

	// Token: 0x040016D5 RID: 5845
	[Token(Token = "0x40016D5")]
	[FieldOffset(Offset = "0x14")]
	public StringButton_Layout Status;

	// Token: 0x040016D6 RID: 5846
	[Token(Token = "0x40016D6")]
	[FieldOffset(Offset = "0x18")]
	public Button_Layout SearchingIcon;
}
