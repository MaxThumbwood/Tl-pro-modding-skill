using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001A8 RID: 424
[Token(Token = "0x20001A8")]
public class BannerCrafting_Layout : PageControllerLayoutDefinition<BannerCrafting_Layout>
{
	// Token: 0x17000128 RID: 296
	// (get) Token: 0x06000C76 RID: 3190 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000128")]
	public DraggableItemGrid_Layout CraftGrid
	{
		[Token(Token = "0x6000C76")]
		[Address(RVA = "0xC665F0", Offset = "0xC665F0", VA = "0xC665F0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000129 RID: 297
	// (get) Token: 0x06000C77 RID: 3191 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000129")]
	public DraggableItemGrid_Layout DuplicateGrid
	{
		[Token(Token = "0x6000C77")]
		[Address(RVA = "0xC666E8", Offset = "0xC666E8", VA = "0xC666E8")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000C78 RID: 3192 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C78")]
	[Address(RVA = "0xC667E0", Offset = "0xC667E0", VA = "0xC667E0")]
	public BannerCrafting_Layout()
	{
	}

	// Token: 0x04000FB8 RID: 4024
	[Token(Token = "0x4000FB8")]
	[FieldOffset(Offset = "0x10")]
	public String_Layout Title;

	// Token: 0x04000FB9 RID: 4025
	[Token(Token = "0x4000FB9")]
	[FieldOffset(Offset = "0x14")]
	public float CraftItemScale;

	// Token: 0x04000FBA RID: 4026
	[Token(Token = "0x4000FBA")]
	[FieldOffset(Offset = "0x18")]
	public float CraftItemHighlightScale;

	// Token: 0x04000FBB RID: 4027
	[Token(Token = "0x4000FBB")]
	[FieldOffset(Offset = "0x1C")]
	public DraggableItemGrid_Layout CraftItemGrid;

	// Token: 0x04000FBC RID: 4028
	[Token(Token = "0x4000FBC")]
	[FieldOffset(Offset = "0x20")]
	public DraggableItemGrid_Layout HorizontalCraftItemGrid;

	// Token: 0x04000FBD RID: 4029
	[Token(Token = "0x4000FBD")]
	[FieldOffset(Offset = "0x24")]
	public DraggableItemGrid_Layout CraftItemGridCollapsed;

	// Token: 0x04000FBE RID: 4030
	[Token(Token = "0x4000FBE")]
	[FieldOffset(Offset = "0x28")]
	public DraggableItemGrid_Layout HorizontalCraftItemGridCollapsed;

	// Token: 0x04000FBF RID: 4031
	[Token(Token = "0x4000FBF")]
	[FieldOffset(Offset = "0x2C")]
	public float MaterialItemScale;

	// Token: 0x04000FC0 RID: 4032
	[Token(Token = "0x4000FC0")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 MaterialTooltipOriginOffsetLeft;

	// Token: 0x04000FC1 RID: 4033
	[Token(Token = "0x4000FC1")]
	[FieldOffset(Offset = "0x38")]
	public Vector2 MaterialTooltipOriginOffsetRight;

	// Token: 0x04000FC2 RID: 4034
	[Token(Token = "0x4000FC2")]
	[FieldOffset(Offset = "0x40")]
	public ItemGrid_Layout MaterialsGrid;

	// Token: 0x04000FC3 RID: 4035
	[Token(Token = "0x4000FC3")]
	[FieldOffset(Offset = "0x44")]
	public ItemGrid_Layout MaterialsGridController;

	// Token: 0x04000FC4 RID: 4036
	[Token(Token = "0x4000FC4")]
	[FieldOffset(Offset = "0x48")]
	public String_Layout MaterialsTitle;

	// Token: 0x04000FC5 RID: 4037
	[Token(Token = "0x4000FC5")]
	[FieldOffset(Offset = "0x4C")]
	public String_Layout NoRecipes;

	// Token: 0x04000FC6 RID: 4038
	[Token(Token = "0x4000FC6")]
	[FieldOffset(Offset = "0x50")]
	public String_Layout NoRecipesController;

	// Token: 0x04000FC7 RID: 4039
	[Token(Token = "0x4000FC7")]
	[FieldOffset(Offset = "0x54")]
	public bool ReverseScroll;

	// Token: 0x04000FC8 RID: 4040
	[Token(Token = "0x4000FC8")]
	[FieldOffset(Offset = "0x55")]
	public bool DrawEmptySlots;

	// Token: 0x04000FC9 RID: 4041
	[Token(Token = "0x4000FC9")]
	[FieldOffset(Offset = "0x58")]
	public Texture_Layout DisabledBacking;

	// Token: 0x04000FCA RID: 4042
	[Token(Token = "0x4000FCA")]
	[FieldOffset(Offset = "0x5C")]
	public Color DisabledBackingColor;

	// Token: 0x04000FCB RID: 4043
	[Token(Token = "0x4000FCB")]
	[FieldOffset(Offset = "0x60")]
	public Texture_Layout DisabledBackingIcon;

	// Token: 0x04000FCC RID: 4044
	[Token(Token = "0x4000FCC")]
	[FieldOffset(Offset = "0x64")]
	public Color DisabledBackingIconColor;

	// Token: 0x04000FCD RID: 4045
	[Token(Token = "0x4000FCD")]
	[FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout CraftButton;

	// Token: 0x04000FCE RID: 4046
	[Token(Token = "0x4000FCE")]
	[FieldOffset(Offset = "0x6C")]
	public TransactionButton_Layout DuplicationButton;

	// Token: 0x04000FCF RID: 4047
	[Token(Token = "0x4000FCF")]
	[FieldOffset(Offset = "0x70")]
	public bool DisableMaterialBackings;

	// Token: 0x04000FD0 RID: 4048
	[Token(Token = "0x4000FD0")]
	[FieldOffset(Offset = "0x74")]
	public Texture_Layout MaterialBacking;

	// Token: 0x04000FD1 RID: 4049
	[Token(Token = "0x4000FD1")]
	[FieldOffset(Offset = "0x78")]
	public Texture_Layout MaterialBackingHighlght;

	// Token: 0x04000FD2 RID: 4050
	[Token(Token = "0x4000FD2")]
	[FieldOffset(Offset = "0x7C")]
	public Color MaterialBackingColor;

	// Token: 0x04000FD3 RID: 4051
	[Token(Token = "0x4000FD3")]
	[FieldOffset(Offset = "0x80")]
	public Color MaterialBackingHighlightColor;

	// Token: 0x04000FD4 RID: 4052
	[Token(Token = "0x4000FD4")]
	[FieldOffset(Offset = "0x84")]
	public bool OverrideMaterialItemScale;

	// Token: 0x04000FD5 RID: 4053
	[Token(Token = "0x4000FD5")]
	[FieldOffset(Offset = "0x88")]
	public float OverridenMaterialItemScale;

	// Token: 0x04000FD6 RID: 4054
	[Token(Token = "0x4000FD6")]
	[FieldOffset(Offset = "0x8C")]
	public bool OverrideMaterialTextScale;

	// Token: 0x04000FD7 RID: 4055
	[Token(Token = "0x4000FD7")]
	[FieldOffset(Offset = "0x90")]
	public float OverridenMaterialTextScale;

	// Token: 0x04000FD8 RID: 4056
	[Token(Token = "0x4000FD8")]
	[FieldOffset(Offset = "0x94")]
	public Vector2 MaterialItemTextOffset;

	// Token: 0x04000FD9 RID: 4057
	[Token(Token = "0x4000FD9")]
	[FieldOffset(Offset = "0x9C")]
	public Color DisabledDuplicationBackingColor;

	// Token: 0x04000FDA RID: 4058
	[Token(Token = "0x4000FDA")]
	[FieldOffset(Offset = "0xA0")]
	public Texture_Layout DisabledDuplicationBackingIcon;

	// Token: 0x04000FDB RID: 4059
	[Token(Token = "0x4000FDB")]
	[FieldOffset(Offset = "0xA4")]
	public Color DisabledDuplicationBackingIconColor;

	// Token: 0x04000FDC RID: 4060
	[Token(Token = "0x4000FDC")]
	[FieldOffset(Offset = "0xA8")]
	public Color DuplicationBackingColor;

	// Token: 0x04000FDD RID: 4061
	[Token(Token = "0x4000FDD")]
	[FieldOffset(Offset = "0xAC")]
	public Color DuplicationBackingHighlightColor;
}
