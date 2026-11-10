using System;
using Il2CppDummyDll;

// Token: 0x02000211 RID: 529
[Token(Token = "0x2000211")]
public class CrossplayDisabledPopup_Layout : LayoutDefinition
{
	// Token: 0x06000DE2 RID: 3554 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DE2")]
	[Address(RVA = "0xC8FD70", Offset = "0xC8FD70", VA = "0xC8FD70")]
	private void Awake()
	{
	}

	// Token: 0x06000DE3 RID: 3555 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DE3")]
	[Address(RVA = "0xC8FDC4", Offset = "0xC8FDC4", VA = "0xC8FDC4")]
	public CrossplayDisabledPopup_Layout()
	{
	}

	// Token: 0x04001697 RID: 5783
	[Token(Token = "0x4001697")]
	[FieldOffset(Offset = "0x0")]
	public static CrossplayDisabledPopup_Layout Instance;

	// Token: 0x04001698 RID: 5784
	[Token(Token = "0x4001698")]
	[FieldOffset(Offset = "0xC")]
	public StringButton_Layout Title;

	// Token: 0x04001699 RID: 5785
	[Token(Token = "0x4001699")]
	[FieldOffset(Offset = "0x10")]
	public Panel_Layout Backing;

	// Token: 0x0400169A RID: 5786
	[Token(Token = "0x400169A")]
	[FieldOffset(Offset = "0x14")]
	public Panel_Layout MenuDivider;

	// Token: 0x0400169B RID: 5787
	[Token(Token = "0x400169B")]
	[FieldOffset(Offset = "0x18")]
	public String_Layout Status;

	// Token: 0x0400169C RID: 5788
	[Token(Token = "0x400169C")]
	[FieldOffset(Offset = "0x1C")]
	public TransactionButton_Layout GotoSetting;

	// Token: 0x0400169D RID: 5789
	[Token(Token = "0x400169D")]
	[FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout Cancel;
}
