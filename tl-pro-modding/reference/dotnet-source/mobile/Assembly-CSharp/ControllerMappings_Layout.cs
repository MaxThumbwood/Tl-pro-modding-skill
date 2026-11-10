using System;
using Il2CppDummyDll;

// Token: 0x020001C0 RID: 448
[Token(Token = "0x20001C0")]
public class ControllerMappings_Layout : LayoutDefinition
{
	// Token: 0x06000CA4 RID: 3236 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA4")]
	[Address(RVA = "0xC6C418", Offset = "0xC6C418", VA = "0xC6C418")]
	private void Awake()
	{
	}

	// Token: 0x06000CA5 RID: 3237 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA5")]
	[Address(RVA = "0xC6C46C", Offset = "0xC6C46C", VA = "0xC6C46C")]
	public ControllerMappings_Layout()
	{
	}

	// Token: 0x040011BA RID: 4538
	[Token(Token = "0x40011BA")]
	[FieldOffset(Offset = "0x0")]
	public static ControllerMappings_Layout Instance;

	// Token: 0x040011BB RID: 4539
	[Token(Token = "0x40011BB")]
	[FieldOffset(Offset = "0xC")]
	public StringButton_Layout Title;

	// Token: 0x040011BC RID: 4540
	[Token(Token = "0x40011BC")]
	[FieldOffset(Offset = "0x10")]
	public Panel_Layout Backing;

	// Token: 0x040011BD RID: 4541
	[Token(Token = "0x40011BD")]
	[FieldOffset(Offset = "0x14")]
	public Panel_Layout MenuDivider;

	// Token: 0x040011BE RID: 4542
	[Token(Token = "0x40011BE")]
	[FieldOffset(Offset = "0x18")]
	public Panel_Layout MenuDivider2;

	// Token: 0x040011BF RID: 4543
	[Token(Token = "0x40011BF")]
	[FieldOffset(Offset = "0x1C")]
	public DraggableItemGrid_Layout OptionGrid;

	// Token: 0x040011C0 RID: 4544
	[Token(Token = "0x40011C0")]
	[FieldOffset(Offset = "0x20")]
	public ControllerMappingsCategories_Layout Categories;

	// Token: 0x040011C1 RID: 4545
	[Token(Token = "0x40011C1")]
	[FieldOffset(Offset = "0x24")]
	public TransactionButton_Layout Close;

	// Token: 0x040011C2 RID: 4546
	[Token(Token = "0x40011C2")]
	[FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout ResetSettings;

	// Token: 0x040011C3 RID: 4547
	[Token(Token = "0x40011C3")]
	[FieldOffset(Offset = "0x2C")]
	public TransactionButton_Layout Clear;

	// Token: 0x040011C4 RID: 4548
	[Token(Token = "0x40011C4")]
	[FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout EditMapping;

	// Token: 0x040011C5 RID: 4549
	[Token(Token = "0x40011C5")]
	[FieldOffset(Offset = "0x34")]
	public ControllerMappingEntry_Layout PulldownTemplate;
}
