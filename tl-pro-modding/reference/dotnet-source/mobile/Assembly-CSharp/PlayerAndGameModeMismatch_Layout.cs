using System;
using Il2CppDummyDll;

// Token: 0x0200022B RID: 555
[Token(Token = "0x200022B")]
public class PlayerAndGameModeMismatch_Layout : LayoutDefinition
{
	// Token: 0x06000E15 RID: 3605 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E15")]
	[Address(RVA = "0xC911F0", Offset = "0xC911F0", VA = "0xC911F0")]
	private void Awake()
	{
	}

	// Token: 0x06000E16 RID: 3606 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E16")]
	[Address(RVA = "0xC91244", Offset = "0xC91244", VA = "0xC91244")]
	public PlayerAndGameModeMismatch_Layout()
	{
	}

	// Token: 0x040017FD RID: 6141
	[Token(Token = "0x40017FD")]
	[FieldOffset(Offset = "0x0")]
	public static PlayerAndGameModeMismatch_Layout Instance;

	// Token: 0x040017FE RID: 6142
	[Token(Token = "0x40017FE")]
	[FieldOffset(Offset = "0xC")]
	public StringButton_Layout Title;

	// Token: 0x040017FF RID: 6143
	[Token(Token = "0x40017FF")]
	[FieldOffset(Offset = "0x10")]
	public Panel_Layout Backing;

	// Token: 0x04001800 RID: 6144
	[Token(Token = "0x4001800")]
	[FieldOffset(Offset = "0x14")]
	public Panel_Layout MenuDivider;

	// Token: 0x04001801 RID: 6145
	[Token(Token = "0x4001801")]
	[FieldOffset(Offset = "0x18")]
	public StringButton_Layout Status;

	// Token: 0x04001802 RID: 6146
	[Token(Token = "0x4001802")]
	[FieldOffset(Offset = "0x1C")]
	public TransactionButton_Layout Back;

	// Token: 0x04001803 RID: 6147
	[Token(Token = "0x4001803")]
	[FieldOffset(Offset = "0x20")]
	public String_Layout GameTip;
}
