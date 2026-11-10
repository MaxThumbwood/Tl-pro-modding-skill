using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001E8 RID: 488
[Token(Token = "0x20001E8")]
public class CraftGuide_Layout : PageControllerLayoutDefinition<CraftGuide_Layout>
{
	// Token: 0x17000157 RID: 343
	// (get) Token: 0x06000D39 RID: 3385 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000157")]
	public DraggableItemGrid_Layout DisplayGrid
	{
		[Token(Token = "0x6000D39")]
		[Address(RVA = "0xC7B504", Offset = "0xC7B504", VA = "0xC7B504")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000D3A RID: 3386 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D3A")]
	[Address(RVA = "0xC7B5FC", Offset = "0xC7B5FC", VA = "0xC7B5FC")]
	public CraftGuide_Layout()
	{
	}

	// Token: 0x040013FE RID: 5118
	[Token(Token = "0x40013FE")]
	[FieldOffset(Offset = "0x10")]
	public String_Layout Title;

	// Token: 0x040013FF RID: 5119
	[Token(Token = "0x40013FF")]
	[FieldOffset(Offset = "0x14")]
	public float CraftItemScale;

	// Token: 0x04001400 RID: 5120
	[Token(Token = "0x4001400")]
	[FieldOffset(Offset = "0x18")]
	public float CraftItemHighlightScale;

	// Token: 0x04001401 RID: 5121
	[Token(Token = "0x4001401")]
	[FieldOffset(Offset = "0x1C")]
	public DraggableItemGrid_Layout CraftItemGrid;

	// Token: 0x04001402 RID: 5122
	[Token(Token = "0x4001402")]
	[FieldOffset(Offset = "0x20")]
	public DraggableItemGrid_Layout CraftItemGridCollapsed;

	// Token: 0x04001403 RID: 5123
	[Token(Token = "0x4001403")]
	[FieldOffset(Offset = "0x24")]
	public DraggableItemGrid_Layout HorizontalCraftItemGrid;

	// Token: 0x04001404 RID: 5124
	[Token(Token = "0x4001404")]
	[FieldOffset(Offset = "0x28")]
	public DraggableItemGrid_Layout HorizontalCraftItemGridCollapsed;

	// Token: 0x04001405 RID: 5125
	[Token(Token = "0x4001405")]
	[FieldOffset(Offset = "0x2C")]
	public Button_Layout SelectedCraftItem;

	// Token: 0x04001406 RID: 5126
	[Token(Token = "0x4001406")]
	[FieldOffset(Offset = "0x30")]
	public float MaterialItemScale;

	// Token: 0x04001407 RID: 5127
	[Token(Token = "0x4001407")]
	[FieldOffset(Offset = "0x34")]
	public ItemGrid_Layout MaterialsGrid;

	// Token: 0x04001408 RID: 5128
	[Token(Token = "0x4001408")]
	[FieldOffset(Offset = "0x38")]
	public ItemGrid_Layout MaterialsGridController;

	// Token: 0x04001409 RID: 5129
	[Token(Token = "0x4001409")]
	[FieldOffset(Offset = "0x3C")]
	public String_Layout CraftItemName;

	// Token: 0x0400140A RID: 5130
	[Token(Token = "0x400140A")]
	[FieldOffset(Offset = "0x40")]
	public String_Layout CraftItemName2;

	// Token: 0x0400140B RID: 5131
	[Token(Token = "0x400140B")]
	[FieldOffset(Offset = "0x44")]
	public String_Layout CraftItemNameController;

	// Token: 0x0400140C RID: 5132
	[Token(Token = "0x400140C")]
	[FieldOffset(Offset = "0x48")]
	public String_Layout CraftItemName2Controller;

	// Token: 0x0400140D RID: 5133
	[Token(Token = "0x400140D")]
	[FieldOffset(Offset = "0x4C")]
	public String_Layout MaterialsTitle;

	// Token: 0x0400140E RID: 5134
	[Token(Token = "0x400140E")]
	[FieldOffset(Offset = "0x50")]
	public String_Layout RequiredObjects;

	// Token: 0x0400140F RID: 5135
	[Token(Token = "0x400140F")]
	[FieldOffset(Offset = "0x54")]
	public String_Layout Required1;

	// Token: 0x04001410 RID: 5136
	[Token(Token = "0x4001410")]
	[FieldOffset(Offset = "0x58")]
	public String_Layout Required2;

	// Token: 0x04001411 RID: 5137
	[Token(Token = "0x4001411")]
	[FieldOffset(Offset = "0x5C")]
	public String_Layout RequiredObjectsController;

	// Token: 0x04001412 RID: 5138
	[Token(Token = "0x4001412")]
	[FieldOffset(Offset = "0x60")]
	public String_Layout Required1Controller;

	// Token: 0x04001413 RID: 5139
	[Token(Token = "0x4001413")]
	[FieldOffset(Offset = "0x64")]
	public String_Layout Required2Controller;

	// Token: 0x04001414 RID: 5140
	[Token(Token = "0x4001414")]
	[FieldOffset(Offset = "0x68")]
	public bool ReverseScroll;

	// Token: 0x04001415 RID: 5141
	[Token(Token = "0x4001415")]
	[FieldOffset(Offset = "0x69")]
	public bool DrawEmptySlots;

	// Token: 0x04001416 RID: 5142
	[Token(Token = "0x4001416")]
	[FieldOffset(Offset = "0x6C")]
	public Texture_Layout DisabledBacking;

	// Token: 0x04001417 RID: 5143
	[Token(Token = "0x4001417")]
	[FieldOffset(Offset = "0x70")]
	public Color DisabledBackingColor;

	// Token: 0x04001418 RID: 5144
	[Token(Token = "0x4001418")]
	[FieldOffset(Offset = "0x74")]
	public Texture_Layout DisabledBackingIcon;

	// Token: 0x04001419 RID: 5145
	[Token(Token = "0x4001419")]
	[FieldOffset(Offset = "0x78")]
	public Color DisabledBackingIconColor;

	// Token: 0x0400141A RID: 5146
	[Token(Token = "0x400141A")]
	[FieldOffset(Offset = "0x7C")]
	public TransactionButton_Layout GuideButton;
}
