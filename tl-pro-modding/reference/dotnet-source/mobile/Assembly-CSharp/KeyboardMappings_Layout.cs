using System;
using Il2CppDummyDll;

// Token: 0x02000207 RID: 519
[Token(Token = "0x2000207")]
public class KeyboardMappings_Layout : LayoutDefinition
{
	// Token: 0x06000DAA RID: 3498 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DAA")]
	[Address(RVA = "0xC8C0E4", Offset = "0xC8C0E4", VA = "0xC8C0E4")]
	private void Awake()
	{
	}

	// Token: 0x06000DAB RID: 3499 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DAB")]
	[Address(RVA = "0xC8C138", Offset = "0xC8C138", VA = "0xC8C138")]
	public KeyboardMappings_Layout()
	{
	}

	// Token: 0x04001634 RID: 5684
	[Token(Token = "0x4001634")]
	[FieldOffset(Offset = "0x0")]
	public static KeyboardMappings_Layout Instance;

	// Token: 0x04001635 RID: 5685
	[Token(Token = "0x4001635")]
	[FieldOffset(Offset = "0xC")]
	public StringButton_Layout Title;

	// Token: 0x04001636 RID: 5686
	[Token(Token = "0x4001636")]
	[FieldOffset(Offset = "0x10")]
	public Panel_Layout Backing;

	// Token: 0x04001637 RID: 5687
	[Token(Token = "0x4001637")]
	[FieldOffset(Offset = "0x14")]
	public Panel_Layout MenuDivider;

	// Token: 0x04001638 RID: 5688
	[Token(Token = "0x4001638")]
	[FieldOffset(Offset = "0x18")]
	public Panel_Layout MenuDivider2;

	// Token: 0x04001639 RID: 5689
	[Token(Token = "0x4001639")]
	[FieldOffset(Offset = "0x1C")]
	public DraggableItemGrid_Layout OptionGrid;

	// Token: 0x0400163A RID: 5690
	[Token(Token = "0x400163A")]
	[FieldOffset(Offset = "0x20")]
	public KeyboardMappingsCategories_Layout Categories;

	// Token: 0x0400163B RID: 5691
	[Token(Token = "0x400163B")]
	[FieldOffset(Offset = "0x24")]
	public TransactionButton_Layout Close;

	// Token: 0x0400163C RID: 5692
	[Token(Token = "0x400163C")]
	[FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout ResetSettings;

	// Token: 0x0400163D RID: 5693
	[Token(Token = "0x400163D")]
	[FieldOffset(Offset = "0x2C")]
	public TransactionButton_Layout Clear;

	// Token: 0x0400163E RID: 5694
	[Token(Token = "0x400163E")]
	[FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout EditMapping;

	// Token: 0x0400163F RID: 5695
	[Token(Token = "0x400163F")]
	[FieldOffset(Offset = "0x34")]
	public TransactionButton_Layout Defaults;

	// Token: 0x04001640 RID: 5696
	[Token(Token = "0x4001640")]
	[FieldOffset(Offset = "0x38")]
	public ControllerMappingEntry_Layout PulldownTemplate;
}
