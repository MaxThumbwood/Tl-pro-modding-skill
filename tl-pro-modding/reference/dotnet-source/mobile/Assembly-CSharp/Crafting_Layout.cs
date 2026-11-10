using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001E9 RID: 489
[Token(Token = "0x20001E9")]
public class Crafting_Layout : PageControllerLayoutDefinition<Crafting_Layout>
{
	// Token: 0x17000158 RID: 344
	// (get) Token: 0x06000D3B RID: 3387 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000158")]
	public DraggableItemGrid_Layout CraftGrid
	{
		[Token(Token = "0x6000D3B")]
		[Address(RVA = "0xC7B774", Offset = "0xC7B774", VA = "0xC7B774")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000159 RID: 345
	// (get) Token: 0x06000D3C RID: 3388 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000159")]
	public DraggableItemGrid_Layout BannerGrid
	{
		[Token(Token = "0x6000D3C")]
		[Address(RVA = "0xC7B86C", Offset = "0xC7B86C", VA = "0xC7B86C")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700015A RID: 346
	// (get) Token: 0x06000D3D RID: 3389 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700015A")]
	public DraggableItemGrid_Layout DuplicateGrid
	{
		[Token(Token = "0x6000D3D")]
		[Address(RVA = "0xC7B964", Offset = "0xC7B964", VA = "0xC7B964")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000D3E RID: 3390 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D3E")]
	[Address(RVA = "0xC7BA5C", Offset = "0xC7BA5C", VA = "0xC7BA5C")]
	public Crafting_Layout()
	{
	}

	// Token: 0x0400141B RID: 5147
	[Token(Token = "0x400141B")]
	[FieldOffset(Offset = "0x10")]
	public String_Layout Title;

	// Token: 0x0400141C RID: 5148
	[Token(Token = "0x400141C")]
	[FieldOffset(Offset = "0x14")]
	public float CraftItemScale;

	// Token: 0x0400141D RID: 5149
	[Token(Token = "0x400141D")]
	[FieldOffset(Offset = "0x18")]
	public float CraftItemHighlightScale;

	// Token: 0x0400141E RID: 5150
	[Token(Token = "0x400141E")]
	[FieldOffset(Offset = "0x1C")]
	public DraggableItemGrid_Layout CraftItemGrid;

	// Token: 0x0400141F RID: 5151
	[Token(Token = "0x400141F")]
	[FieldOffset(Offset = "0x20")]
	public DraggableItemGrid_Layout HorizontalCraftItemGrid;

	// Token: 0x04001420 RID: 5152
	[Token(Token = "0x4001420")]
	[FieldOffset(Offset = "0x24")]
	public DraggableItemGrid_Layout CraftItemGridCollapsed;

	// Token: 0x04001421 RID: 5153
	[Token(Token = "0x4001421")]
	[FieldOffset(Offset = "0x28")]
	public DraggableItemGrid_Layout HorizontalCraftItemGridCollapsed;

	// Token: 0x04001422 RID: 5154
	[Token(Token = "0x4001422")]
	[FieldOffset(Offset = "0x2C")]
	public float MaterialItemScale;

	// Token: 0x04001423 RID: 5155
	[Token(Token = "0x4001423")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 MaterialTooltipOriginOffsetLeft;

	// Token: 0x04001424 RID: 5156
	[Token(Token = "0x4001424")]
	[FieldOffset(Offset = "0x38")]
	public Vector2 MaterialTooltipOriginOffsetRight;

	// Token: 0x04001425 RID: 5157
	[Token(Token = "0x4001425")]
	[FieldOffset(Offset = "0x40")]
	public ItemGrid_Layout MaterialsGrid;

	// Token: 0x04001426 RID: 5158
	[Token(Token = "0x4001426")]
	[FieldOffset(Offset = "0x44")]
	public ItemGrid_Layout MaterialsGridController;

	// Token: 0x04001427 RID: 5159
	[Token(Token = "0x4001427")]
	[FieldOffset(Offset = "0x48")]
	public String_Layout MaterialsTitle;

	// Token: 0x04001428 RID: 5160
	[Token(Token = "0x4001428")]
	[FieldOffset(Offset = "0x4C")]
	public String_Layout NoRecipes;

	// Token: 0x04001429 RID: 5161
	[Token(Token = "0x4001429")]
	[FieldOffset(Offset = "0x50")]
	public String_Layout NoRecipesController;

	// Token: 0x0400142A RID: 5162
	[Token(Token = "0x400142A")]
	[FieldOffset(Offset = "0x54")]
	public bool ReverseScroll;

	// Token: 0x0400142B RID: 5163
	[Token(Token = "0x400142B")]
	[FieldOffset(Offset = "0x55")]
	public bool DrawEmptySlots;

	// Token: 0x0400142C RID: 5164
	[Token(Token = "0x400142C")]
	[FieldOffset(Offset = "0x58")]
	public Texture_Layout DisabledBacking;

	// Token: 0x0400142D RID: 5165
	[Token(Token = "0x400142D")]
	[FieldOffset(Offset = "0x5C")]
	public Color DisabledBackingColor;

	// Token: 0x0400142E RID: 5166
	[Token(Token = "0x400142E")]
	[FieldOffset(Offset = "0x60")]
	public Texture_Layout DisabledBackingIcon;

	// Token: 0x0400142F RID: 5167
	[Token(Token = "0x400142F")]
	[FieldOffset(Offset = "0x64")]
	public Color DisabledBackingIconColor;

	// Token: 0x04001430 RID: 5168
	[Token(Token = "0x4001430")]
	[FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout CraftButton;

	// Token: 0x04001431 RID: 5169
	[Token(Token = "0x4001431")]
	[FieldOffset(Offset = "0x6C")]
	public TransactionButton_Layout CraftingStationCraftButton;

	// Token: 0x04001432 RID: 5170
	[Token(Token = "0x4001432")]
	[FieldOffset(Offset = "0x70")]
	public TransactionButton_Layout DuplicationButton;

	// Token: 0x04001433 RID: 5171
	[Token(Token = "0x4001433")]
	[FieldOffset(Offset = "0x74")]
	public bool DisableMaterialBackings;

	// Token: 0x04001434 RID: 5172
	[Token(Token = "0x4001434")]
	[FieldOffset(Offset = "0x78")]
	public Texture_Layout MaterialBacking;

	// Token: 0x04001435 RID: 5173
	[Token(Token = "0x4001435")]
	[FieldOffset(Offset = "0x7C")]
	public Texture_Layout MaterialBackingHighlght;

	// Token: 0x04001436 RID: 5174
	[Token(Token = "0x4001436")]
	[FieldOffset(Offset = "0x80")]
	public Color MaterialBackingColor;

	// Token: 0x04001437 RID: 5175
	[Token(Token = "0x4001437")]
	[FieldOffset(Offset = "0x84")]
	public Color MaterialBackingHighlightColor;

	// Token: 0x04001438 RID: 5176
	[Token(Token = "0x4001438")]
	[FieldOffset(Offset = "0x88")]
	public bool OverrideMaterialItemScale;

	// Token: 0x04001439 RID: 5177
	[Token(Token = "0x4001439")]
	[FieldOffset(Offset = "0x8C")]
	public float OverridenMaterialItemScale;

	// Token: 0x0400143A RID: 5178
	[Token(Token = "0x400143A")]
	[FieldOffset(Offset = "0x90")]
	public bool OverrideMaterialTextScale;

	// Token: 0x0400143B RID: 5179
	[Token(Token = "0x400143B")]
	[FieldOffset(Offset = "0x94")]
	public float OverridenMaterialTextScale;

	// Token: 0x0400143C RID: 5180
	[Token(Token = "0x400143C")]
	[FieldOffset(Offset = "0x98")]
	public Vector2 MaterialItemTextOffset;

	// Token: 0x0400143D RID: 5181
	[Token(Token = "0x400143D")]
	[FieldOffset(Offset = "0xA0")]
	public Vector2 AvailableItemTextOffset;

	// Token: 0x0400143E RID: 5182
	[Token(Token = "0x400143E")]
	[FieldOffset(Offset = "0xA8")]
	public float MaterialTooltipBackingExtra;

	// Token: 0x0400143F RID: 5183
	[Token(Token = "0x400143F")]
	[FieldOffset(Offset = "0xAC")]
	public Texture_Layout TooltipMaterialBacking;

	// Token: 0x04001440 RID: 5184
	[Token(Token = "0x4001440")]
	[FieldOffset(Offset = "0xB0")]
	public Color TooltipMaterialBackingColor;

	// Token: 0x04001441 RID: 5185
	[Token(Token = "0x4001441")]
	[FieldOffset(Offset = "0xB4")]
	public Color DisabledDuplicationBackingColor;

	// Token: 0x04001442 RID: 5186
	[Token(Token = "0x4001442")]
	[FieldOffset(Offset = "0xB8")]
	public Texture_Layout DisabledDuplicationBackingIcon;

	// Token: 0x04001443 RID: 5187
	[Token(Token = "0x4001443")]
	[FieldOffset(Offset = "0xBC")]
	public Color DisabledDuplicationBackingIconColor;

	// Token: 0x04001444 RID: 5188
	[Token(Token = "0x4001444")]
	[FieldOffset(Offset = "0xC0")]
	public Color DuplicationBackingColor;

	// Token: 0x04001445 RID: 5189
	[Token(Token = "0x4001445")]
	[FieldOffset(Offset = "0xC4")]
	public Color DuplicationBackingHighlightColor;

	// Token: 0x04001446 RID: 5190
	[Token(Token = "0x4001446")]
	[FieldOffset(Offset = "0xC8")]
	public Texture_Layout DisabledBannerBacking;

	// Token: 0x04001447 RID: 5191
	[Token(Token = "0x4001447")]
	[FieldOffset(Offset = "0xCC")]
	public Color DisabledBannerBackingColor;

	// Token: 0x04001448 RID: 5192
	[Token(Token = "0x4001448")]
	[FieldOffset(Offset = "0xD0")]
	public Texture_Layout DisabledBannerBackingIcon;

	// Token: 0x04001449 RID: 5193
	[Token(Token = "0x4001449")]
	[FieldOffset(Offset = "0xD4")]
	public Color DisabledBannerBackingIconColor;

	// Token: 0x0400144A RID: 5194
	[Token(Token = "0x400144A")]
	[FieldOffset(Offset = "0xD8")]
	public TransactionButton_Layout BannerButton;

	// Token: 0x0400144B RID: 5195
	[Token(Token = "0x400144B")]
	[FieldOffset(Offset = "0xDC")]
	public Color CraftingStationBackingColor;

	// Token: 0x0400144C RID: 5196
	[Token(Token = "0x400144C")]
	[FieldOffset(Offset = "0xE0")]
	public Color CraftingStationBackingHighlightColor;

	// Token: 0x0400144D RID: 5197
	[Token(Token = "0x400144D")]
	[FieldOffset(Offset = "0xE4")]
	public Color CraftingStationDisabledBackingColor;

	// Token: 0x0400144E RID: 5198
	[Token(Token = "0x400144E")]
	[FieldOffset(Offset = "0xE8")]
	public Color CraftingStationDisabledBackingIconColor;

	// Token: 0x0400144F RID: 5199
	[Token(Token = "0x400144F")]
	[FieldOffset(Offset = "0xEC")]
	public Texture_Layout CraftingStationDisabledBacking;

	// Token: 0x04001450 RID: 5200
	[Token(Token = "0x4001450")]
	[FieldOffset(Offset = "0xF0")]
	public Texture_Layout CraftingStationDisabledBackingIcon;
}
