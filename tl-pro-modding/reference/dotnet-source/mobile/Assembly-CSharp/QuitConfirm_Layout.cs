using System;
using Il2CppDummyDll;

// Token: 0x02000230 RID: 560
[Token(Token = "0x2000230")]
public class QuitConfirm_Layout : LayoutDefinition
{
	// Token: 0x06000E1F RID: 3615 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E1F")]
	[Address(RVA = "0xC917B0", Offset = "0xC917B0", VA = "0xC917B0")]
	private void Awake()
	{
	}

	// Token: 0x06000E20 RID: 3616 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E20")]
	[Address(RVA = "0xC91804", Offset = "0xC91804", VA = "0xC91804")]
	public QuitConfirm_Layout()
	{
	}

	// Token: 0x0400187C RID: 6268
	[Token(Token = "0x400187C")]
	[FieldOffset(Offset = "0x0")]
	public static QuitConfirm_Layout Instance;

	// Token: 0x0400187D RID: 6269
	[Token(Token = "0x400187D")]
	[FieldOffset(Offset = "0xC")]
	public StringButton_Layout Title;

	// Token: 0x0400187E RID: 6270
	[Token(Token = "0x400187E")]
	[FieldOffset(Offset = "0x10")]
	public Panel_Layout Backing;

	// Token: 0x0400187F RID: 6271
	[Token(Token = "0x400187F")]
	[FieldOffset(Offset = "0x14")]
	public Panel_Layout MenuDivider;

	// Token: 0x04001880 RID: 6272
	[Token(Token = "0x4001880")]
	[FieldOffset(Offset = "0x18")]
	public StringButton_Layout Status;

	// Token: 0x04001881 RID: 6273
	[Token(Token = "0x4001881")]
	[FieldOffset(Offset = "0x1C")]
	public TransactionButton_Layout Quit;

	// Token: 0x04001882 RID: 6274
	[Token(Token = "0x4001882")]
	[FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout Back;
}
