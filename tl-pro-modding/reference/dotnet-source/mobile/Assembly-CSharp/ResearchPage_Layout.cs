using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000258 RID: 600
[Token(Token = "0x2000258")]
public class ResearchPage_Layout : PageControllerLayoutDefinition<ResearchPage_Layout>
{
	// Token: 0x1700017D RID: 381
	// (get) Token: 0x06000E69 RID: 3689 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700017D")]
	public DraggableItemGrid_Layout DisplayItemGrid
	{
		[Token(Token = "0x6000E69")]
		[Address(RVA = "0xC94784", Offset = "0xC94784", VA = "0xC94784")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000E6A RID: 3690 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E6A")]
	[Address(RVA = "0xC94878", Offset = "0xC94878", VA = "0xC94878")]
	public ResearchPage_Layout()
	{
	}

	// Token: 0x04001C19 RID: 7193
	[Token(Token = "0x4001C19")]
	[FieldOffset(Offset = "0x10")]
	public String_Layout Title;

	// Token: 0x04001C1A RID: 7194
	[Token(Token = "0x4001C1A")]
	[FieldOffset(Offset = "0x14")]
	public float ItemScale;

	// Token: 0x04001C1B RID: 7195
	[Token(Token = "0x4001C1B")]
	[FieldOffset(Offset = "0x18")]
	public float ItemHighlightScale;

	// Token: 0x04001C1C RID: 7196
	[Token(Token = "0x4001C1C")]
	[FieldOffset(Offset = "0x1C")]
	public bool DrawEmptySlots;

	// Token: 0x04001C1D RID: 7197
	[Token(Token = "0x4001C1D")]
	[FieldOffset(Offset = "0x20")]
	public Texture_Layout DisabledBacking;

	// Token: 0x04001C1E RID: 7198
	[Token(Token = "0x4001C1E")]
	[FieldOffset(Offset = "0x24")]
	public Color DisabledBackingColor;

	// Token: 0x04001C1F RID: 7199
	[Token(Token = "0x4001C1F")]
	[FieldOffset(Offset = "0x28")]
	public Texture_Layout DisabledBackingIcon;

	// Token: 0x04001C20 RID: 7200
	[Token(Token = "0x4001C20")]
	[FieldOffset(Offset = "0x2C")]
	public Color DisabledBackingIconColor;

	// Token: 0x04001C21 RID: 7201
	[Token(Token = "0x4001C21")]
	[FieldOffset(Offset = "0x30")]
	public DraggableItemGrid_Layout ResearchItemGrid;

	// Token: 0x04001C22 RID: 7202
	[Token(Token = "0x4001C22")]
	[FieldOffset(Offset = "0x34")]
	public DraggableItemGrid_Layout ResearchItemGridCollapsed;

	// Token: 0x04001C23 RID: 7203
	[Token(Token = "0x4001C23")]
	[FieldOffset(Offset = "0x38")]
	public DraggableItemGrid_Layout ResearchItemGrid_Horizontal;

	// Token: 0x04001C24 RID: 7204
	[Token(Token = "0x4001C24")]
	[FieldOffset(Offset = "0x3C")]
	public DraggableItemGrid_Layout ResearchItemGridCollapsed_Horizontal;

	// Token: 0x04001C25 RID: 7205
	[Token(Token = "0x4001C25")]
	[FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout ResearchButton;
}
