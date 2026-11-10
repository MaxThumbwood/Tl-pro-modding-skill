using System;
using Il2CppDummyDll;

// Token: 0x02000231 RID: 561
[Token(Token = "0x2000231")]
public class ResetSettings_Layout : LayoutDefinition
{
	// Token: 0x06000E21 RID: 3617 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E21")]
	[Address(RVA = "0xC9186C", Offset = "0xC9186C", VA = "0xC9186C")]
	private void Awake()
	{
	}

	// Token: 0x06000E22 RID: 3618 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E22")]
	[Address(RVA = "0xC918C0", Offset = "0xC918C0", VA = "0xC918C0")]
	public ResetSettings_Layout()
	{
	}

	// Token: 0x04001883 RID: 6275
	[Token(Token = "0x4001883")]
	[FieldOffset(Offset = "0x0")]
	public static ResetSettings_Layout Instance;

	// Token: 0x04001884 RID: 6276
	[Token(Token = "0x4001884")]
	[FieldOffset(Offset = "0xC")]
	public StringButton_Layout Title;

	// Token: 0x04001885 RID: 6277
	[Token(Token = "0x4001885")]
	[FieldOffset(Offset = "0x10")]
	public Panel_Layout Backing;

	// Token: 0x04001886 RID: 6278
	[Token(Token = "0x4001886")]
	[FieldOffset(Offset = "0x14")]
	public Panel_Layout MenuDivider;

	// Token: 0x04001887 RID: 6279
	[Token(Token = "0x4001887")]
	[FieldOffset(Offset = "0x18")]
	public StringButton_Layout DeletePrompt;

	// Token: 0x04001888 RID: 6280
	[Token(Token = "0x4001888")]
	[FieldOffset(Offset = "0x1C")]
	public TransactionButton_Layout Yes;

	// Token: 0x04001889 RID: 6281
	[Token(Token = "0x4001889")]
	[FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout No;
}
