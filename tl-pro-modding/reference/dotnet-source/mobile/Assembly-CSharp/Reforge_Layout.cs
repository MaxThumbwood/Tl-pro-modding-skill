using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000257 RID: 599
[Token(Token = "0x2000257")]
public class Reforge_Layout : PageControllerLayoutDefinition<Reforge_Layout>
{
	// Token: 0x1700017C RID: 380
	// (get) Token: 0x06000E67 RID: 3687 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700017C")]
	public DraggableItemGrid_Layout DisplayItemGrid
	{
		[Token(Token = "0x6000E67")]
		[Address(RVA = "0xC9440C", Offset = "0xC9440C", VA = "0xC9440C")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000E68 RID: 3688 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E68")]
	[Address(RVA = "0xC94500", Offset = "0xC94500", VA = "0xC94500")]
	public Reforge_Layout()
	{
	}

	// Token: 0x04001C00 RID: 7168
	[Token(Token = "0x4001C00")]
	[FieldOffset(Offset = "0x10")]
	public String_Layout Guide;

	// Token: 0x04001C01 RID: 7169
	[Token(Token = "0x4001C01")]
	[FieldOffset(Offset = "0x14")]
	public String_Layout Cost;

	// Token: 0x04001C02 RID: 7170
	[Token(Token = "0x4001C02")]
	[FieldOffset(Offset = "0x18")]
	public String_Layout ControllerCost;

	// Token: 0x04001C03 RID: 7171
	[Token(Token = "0x4001C03")]
	[FieldOffset(Offset = "0x1C")]
	public Panel_Layout SavingsBacking;

	// Token: 0x04001C04 RID: 7172
	[Token(Token = "0x4001C04")]
	[FieldOffset(Offset = "0x20")]
	public String_Layout Savings;

	// Token: 0x04001C05 RID: 7173
	[Token(Token = "0x4001C05")]
	[FieldOffset(Offset = "0x24")]
	public String_Layout SavingsTitle;

	// Token: 0x04001C06 RID: 7174
	[Token(Token = "0x4001C06")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 Savings1IconOffset;

	// Token: 0x04001C07 RID: 7175
	[Token(Token = "0x4001C07")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 Savings2IconOffset;

	// Token: 0x04001C08 RID: 7176
	[Token(Token = "0x4001C08")]
	[FieldOffset(Offset = "0x38")]
	public Vector2 Savings3IconOffset;

	// Token: 0x04001C09 RID: 7177
	[Token(Token = "0x4001C09")]
	[FieldOffset(Offset = "0x40")]
	public Vector2 Savings4IconOffset;

	// Token: 0x04001C0A RID: 7178
	[Token(Token = "0x4001C0A")]
	[FieldOffset(Offset = "0x48")]
	public String_Layout Title;

	// Token: 0x04001C0B RID: 7179
	[Token(Token = "0x4001C0B")]
	[FieldOffset(Offset = "0x4C")]
	public float ItemScale;

	// Token: 0x04001C0C RID: 7180
	[Token(Token = "0x4001C0C")]
	[FieldOffset(Offset = "0x50")]
	public float ItemHighlightScale;

	// Token: 0x04001C0D RID: 7181
	[Token(Token = "0x4001C0D")]
	[FieldOffset(Offset = "0x54")]
	public bool DrawEmptySlots;

	// Token: 0x04001C0E RID: 7182
	[Token(Token = "0x4001C0E")]
	[FieldOffset(Offset = "0x58")]
	public Texture_Layout DisabledBacking;

	// Token: 0x04001C0F RID: 7183
	[Token(Token = "0x4001C0F")]
	[FieldOffset(Offset = "0x5C")]
	public Color DisabledBackingColor;

	// Token: 0x04001C10 RID: 7184
	[Token(Token = "0x4001C10")]
	[FieldOffset(Offset = "0x60")]
	public Texture_Layout DisabledBackingIcon;

	// Token: 0x04001C11 RID: 7185
	[Token(Token = "0x4001C11")]
	[FieldOffset(Offset = "0x64")]
	public Color DisabledBackingIconColor;

	// Token: 0x04001C12 RID: 7186
	[Token(Token = "0x4001C12")]
	[FieldOffset(Offset = "0x68")]
	public Color SlotColor;

	// Token: 0x04001C13 RID: 7187
	[Token(Token = "0x4001C13")]
	[FieldOffset(Offset = "0x6C")]
	public Color SlotHighlightColor;

	// Token: 0x04001C14 RID: 7188
	[Token(Token = "0x4001C14")]
	[FieldOffset(Offset = "0x70")]
	public DraggableItemGrid_Layout HorizontalReforgeItemGrid;

	// Token: 0x04001C15 RID: 7189
	[Token(Token = "0x4001C15")]
	[FieldOffset(Offset = "0x74")]
	public DraggableItemGrid_Layout HorizontalReforgeItemGridCollapsed;

	// Token: 0x04001C16 RID: 7190
	[Token(Token = "0x4001C16")]
	[FieldOffset(Offset = "0x78")]
	public DraggableItemGrid_Layout ReforgeItemGrid;

	// Token: 0x04001C17 RID: 7191
	[Token(Token = "0x4001C17")]
	[FieldOffset(Offset = "0x7C")]
	public DraggableItemGrid_Layout ReforgeItemGridCollapsed;

	// Token: 0x04001C18 RID: 7192
	[Token(Token = "0x4001C18")]
	[FieldOffset(Offset = "0x80")]
	public TransactionButton_Layout ReforgeButton;
}
