using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x02000256 RID: 598
[Token(Token = "0x2000256")]
public class ReforgePopup_Layout : LayoutDefinition
{
	// Token: 0x06000E65 RID: 3685 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E65")]
	[Address(RVA = "0xC94270", Offset = "0xC94270", VA = "0xC94270")]
	private void Awake()
	{
	}

	// Token: 0x06000E66 RID: 3686 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E66")]
	[Address(RVA = "0xC942C4", Offset = "0xC942C4", VA = "0xC942C4")]
	public ReforgePopup_Layout()
	{
	}

	// Token: 0x04001BE7 RID: 7143
	[Token(Token = "0x4001BE7")]
	[FieldOffset(Offset = "0x0")]
	public static ReforgePopup_Layout Instance;

	// Token: 0x04001BE8 RID: 7144
	[Token(Token = "0x4001BE8")]
	[FieldOffset(Offset = "0xC")]
	public int BackingTextPadding;

	// Token: 0x04001BE9 RID: 7145
	[Token(Token = "0x4001BE9")]
	[FieldOffset(Offset = "0x10")]
	public int BackingTextPaddingController;

	// Token: 0x04001BEA RID: 7146
	[Token(Token = "0x4001BEA")]
	[FieldOffset(Offset = "0x14")]
	public int MinTextHeight;

	// Token: 0x04001BEB RID: 7147
	[Token(Token = "0x4001BEB")]
	[FieldOffset(Offset = "0x18")]
	public int TextBackingOffset;

	// Token: 0x04001BEC RID: 7148
	[Token(Token = "0x4001BEC")]
	[FieldOffset(Offset = "0x1C")]
	public int MaxWidthLastLineAddition;

	// Token: 0x04001BED RID: 7149
	[Token(Token = "0x4001BED")]
	[FieldOffset(Offset = "0x20")]
	public Panel_Layout Backing;

	// Token: 0x04001BEE RID: 7150
	[Token(Token = "0x4001BEE")]
	[FieldOffset(Offset = "0x24")]
	public String_Layout Text;

	// Token: 0x04001BEF RID: 7151
	[Token(Token = "0x4001BEF")]
	[FieldOffset(Offset = "0x28")]
	public Panel_Layout TextBacking;

	// Token: 0x04001BF0 RID: 7152
	[Token(Token = "0x4001BF0")]
	[FieldOffset(Offset = "0x2C")]
	public Panel_Layout MenuDivider;

	// Token: 0x04001BF1 RID: 7153
	[Token(Token = "0x4001BF1")]
	[FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout Close;

	// Token: 0x04001BF2 RID: 7154
	[Token(Token = "0x4001BF2")]
	[FieldOffset(Offset = "0x34")]
	public TransactionButton_Layout Reforge;

	// Token: 0x04001BF3 RID: 7155
	[Token(Token = "0x4001BF3")]
	[FieldOffset(Offset = "0x38")]
	public Panel_Layout SavingsBacking;

	// Token: 0x04001BF4 RID: 7156
	[Token(Token = "0x4001BF4")]
	[FieldOffset(Offset = "0x3C")]
	public String_Layout Savings;

	// Token: 0x04001BF5 RID: 7157
	[Token(Token = "0x4001BF5")]
	[FieldOffset(Offset = "0x40")]
	public String_Layout SavingsTitle;

	// Token: 0x04001BF6 RID: 7158
	[Token(Token = "0x4001BF6")]
	[FieldOffset(Offset = "0x44")]
	public Vector2 Savings1IconOffset;

	// Token: 0x04001BF7 RID: 7159
	[Token(Token = "0x4001BF7")]
	[FieldOffset(Offset = "0x4C")]
	public Vector2 Savings2IconOffset;

	// Token: 0x04001BF8 RID: 7160
	[Token(Token = "0x4001BF8")]
	[FieldOffset(Offset = "0x54")]
	public Vector2 Savings3IconOffset;

	// Token: 0x04001BF9 RID: 7161
	[Token(Token = "0x4001BF9")]
	[FieldOffset(Offset = "0x5C")]
	public Vector2 Savings4IconOffset;

	// Token: 0x04001BFA RID: 7162
	[Token(Token = "0x4001BFA")]
	[FieldOffset(Offset = "0x64")]
	public String_Layout ReforgeCost;

	// Token: 0x04001BFB RID: 7163
	[Token(Token = "0x4001BFB")]
	[FieldOffset(Offset = "0x68")]
	public String_Layout ReforgeCostController;

	// Token: 0x04001BFC RID: 7164
	[Token(Token = "0x4001BFC")]
	[FieldOffset(Offset = "0x6C")]
	public String_Layout ReforgeItemName;

	// Token: 0x04001BFD RID: 7165
	[Token(Token = "0x4001BFD")]
	[FieldOffset(Offset = "0x70")]
	public Panel_Layout ReforgeItemNameDivider;

	// Token: 0x04001BFE RID: 7166
	[Token(Token = "0x4001BFE")]
	[FieldOffset(Offset = "0x74")]
	public Panel_Layout ReforgeItem;

	// Token: 0x04001BFF RID: 7167
	[Token(Token = "0x4001BFF")]
	[FieldOffset(Offset = "0x78")]
	public Panel_Layout ReforgeItemBacking;
}
