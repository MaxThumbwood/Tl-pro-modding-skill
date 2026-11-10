using System;
using Il2CppDummyDll;

// Token: 0x0200020F RID: 527
[Token(Token = "0x200020F")]
public class ConfigureTouchControlsPopup_Layout : LayoutDefinition
{
	// Token: 0x06000DDE RID: 3550 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DDE")]
	[Address(RVA = "0xC8FBF8", Offset = "0xC8FBF8", VA = "0xC8FBF8")]
	private void Awake()
	{
	}

	// Token: 0x06000DDF RID: 3551 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DDF")]
	[Address(RVA = "0xC8FC4C", Offset = "0xC8FC4C", VA = "0xC8FC4C")]
	public ConfigureTouchControlsPopup_Layout()
	{
	}

	// Token: 0x0400168C RID: 5772
	[Token(Token = "0x400168C")]
	[FieldOffset(Offset = "0x0")]
	public static ConfigureTouchControlsPopup_Layout Instance;

	// Token: 0x0400168D RID: 5773
	[Token(Token = "0x400168D")]
	[FieldOffset(Offset = "0xC")]
	public StringButton_Layout Title;

	// Token: 0x0400168E RID: 5774
	[Token(Token = "0x400168E")]
	[FieldOffset(Offset = "0x10")]
	public Panel_Layout Backing;

	// Token: 0x0400168F RID: 5775
	[Token(Token = "0x400168F")]
	[FieldOffset(Offset = "0x14")]
	public Panel_Layout MenuDivider;

	// Token: 0x04001690 RID: 5776
	[Token(Token = "0x4001690")]
	[FieldOffset(Offset = "0x18")]
	public StringButton_Layout Status;

	// Token: 0x04001691 RID: 5777
	[Token(Token = "0x4001691")]
	[FieldOffset(Offset = "0x1C")]
	public TransactionButton_Layout Edit;

	// Token: 0x04001692 RID: 5778
	[Token(Token = "0x4001692")]
	[FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout Later;

	// Token: 0x04001693 RID: 5779
	[Token(Token = "0x4001693")]
	[FieldOffset(Offset = "0x24")]
	public TransactionButton_Layout Cancel;
}
