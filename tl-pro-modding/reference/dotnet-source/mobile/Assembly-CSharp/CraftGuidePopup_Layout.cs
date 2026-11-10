using System;
using Il2CppDummyDll;

// Token: 0x020001E7 RID: 487
[Token(Token = "0x20001E7")]
public class CraftGuidePopup_Layout : LayoutDefinition
{
	// Token: 0x06000D37 RID: 3383 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D37")]
	[Address(RVA = "0xC7B448", Offset = "0xC7B448", VA = "0xC7B448")]
	private void Awake()
	{
	}

	// Token: 0x06000D38 RID: 3384 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D38")]
	[Address(RVA = "0xC7B49C", Offset = "0xC7B49C", VA = "0xC7B49C")]
	public CraftGuidePopup_Layout()
	{
	}

	// Token: 0x040013E3 RID: 5091
	[Token(Token = "0x40013E3")]
	[FieldOffset(Offset = "0x0")]
	public static CraftGuidePopup_Layout Instance;

	// Token: 0x040013E4 RID: 5092
	[Token(Token = "0x40013E4")]
	[FieldOffset(Offset = "0xC")]
	public Panel_Layout Backing;

	// Token: 0x040013E5 RID: 5093
	[Token(Token = "0x40013E5")]
	[FieldOffset(Offset = "0x10")]
	public Panel_Layout GridBacking;

	// Token: 0x040013E6 RID: 5094
	[Token(Token = "0x40013E6")]
	[FieldOffset(Offset = "0x14")]
	public DraggableItemGrid_Layout CraftItems;

	// Token: 0x040013E7 RID: 5095
	[Token(Token = "0x40013E7")]
	[FieldOffset(Offset = "0x18")]
	public float CraftItemScale;

	// Token: 0x040013E8 RID: 5096
	[Token(Token = "0x40013E8")]
	[FieldOffset(Offset = "0x1C")]
	public Panel_Layout MenuDivider;

	// Token: 0x040013E9 RID: 5097
	[Token(Token = "0x40013E9")]
	[FieldOffset(Offset = "0x20")]
	public Panel_Layout MenuDivider2;

	// Token: 0x040013EA RID: 5098
	[Token(Token = "0x40013EA")]
	[FieldOffset(Offset = "0x24")]
	public String_Layout ItemName;

	// Token: 0x040013EB RID: 5099
	[Token(Token = "0x40013EB")]
	[FieldOffset(Offset = "0x28")]
	public Panel_Layout ItemNameDivider;

	// Token: 0x040013EC RID: 5100
	[Token(Token = "0x40013EC")]
	[FieldOffset(Offset = "0x2C")]
	public Panel_Layout Item;

	// Token: 0x040013ED RID: 5101
	[Token(Token = "0x40013ED")]
	[FieldOffset(Offset = "0x30")]
	public Panel_Layout ItemBacking;

	// Token: 0x040013EE RID: 5102
	[Token(Token = "0x40013EE")]
	[FieldOffset(Offset = "0x34")]
	public TransactionButton_Layout Close;

	// Token: 0x040013EF RID: 5103
	[Token(Token = "0x40013EF")]
	[FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout Back;

	// Token: 0x040013F0 RID: 5104
	[Token(Token = "0x40013F0")]
	[FieldOffset(Offset = "0x3C")]
	public DraggableItemGrid_Layout MaterialsGrid;

	// Token: 0x040013F1 RID: 5105
	[Token(Token = "0x40013F1")]
	[FieldOffset(Offset = "0x40")]
	public float MaterialItemScale;

	// Token: 0x040013F2 RID: 5106
	[Token(Token = "0x40013F2")]
	[FieldOffset(Offset = "0x44")]
	public String_Layout RequiredObjects;

	// Token: 0x040013F3 RID: 5107
	[Token(Token = "0x40013F3")]
	[FieldOffset(Offset = "0x48")]
	public String_Layout Required1;

	// Token: 0x040013F4 RID: 5108
	[Token(Token = "0x40013F4")]
	[FieldOffset(Offset = "0x4C")]
	public String_Layout Required2;

	// Token: 0x040013F5 RID: 5109
	[Token(Token = "0x40013F5")]
	[FieldOffset(Offset = "0x50")]
	public String_Layout Text;

	// Token: 0x040013F6 RID: 5110
	[Token(Token = "0x40013F6")]
	[FieldOffset(Offset = "0x54")]
	public Panel_Layout TextBacking;

	// Token: 0x040013F7 RID: 5111
	[Token(Token = "0x40013F7")]
	[FieldOffset(Offset = "0x58")]
	public int MinTextHeight;

	// Token: 0x040013F8 RID: 5112
	[Token(Token = "0x40013F8")]
	[FieldOffset(Offset = "0x5C")]
	public int TextBackingOffset;

	// Token: 0x040013F9 RID: 5113
	[Token(Token = "0x40013F9")]
	[FieldOffset(Offset = "0x60")]
	public int BackingTextPadding;

	// Token: 0x040013FA RID: 5114
	[Token(Token = "0x40013FA")]
	[FieldOffset(Offset = "0x64")]
	public int BackingTextPaddingController;

	// Token: 0x040013FB RID: 5115
	[Token(Token = "0x40013FB")]
	[FieldOffset(Offset = "0x68")]
	public int ExtraMaterialLineOffset;

	// Token: 0x040013FC RID: 5116
	[Token(Token = "0x40013FC")]
	[FieldOffset(Offset = "0x6C")]
	public int ControllerMaterialLineOffset;

	// Token: 0x040013FD RID: 5117
	[Token(Token = "0x40013FD")]
	[FieldOffset(Offset = "0x70")]
	public int CraftItemOffset;
}
