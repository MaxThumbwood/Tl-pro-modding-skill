using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200025C RID: 604
[Token(Token = "0x200025C")]
public class RubbleMakerUI_Layout : LayoutDefinition
{
	// Token: 0x1700017F RID: 383
	// (get) Token: 0x06000E72 RID: 3698 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700017F")]
	public static RubbleMakerUI_Layout Instance
	{
		[Token(Token = "0x6000E72")]
		[Address(RVA = "0xC94CEC", Offset = "0xC94CEC", VA = "0xC94CEC")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000E73 RID: 3699 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E73")]
	[Address(RVA = "0xC94DA0", Offset = "0xC94DA0", VA = "0xC94DA0")]
	private void Awake()
	{
	}

	// Token: 0x06000E74 RID: 3700 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E74")]
	[Address(RVA = "0xC94E28", Offset = "0xC94E28", VA = "0xC94E28")]
	public Panel_Layout GetBacking()
	{
		return null;
	}

	// Token: 0x06000E75 RID: 3701 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E75")]
	[Address(RVA = "0xC94EC8", Offset = "0xC94EC8", VA = "0xC94EC8")]
	public ItemGrid_Layout GetRubbleOptions()
	{
		return null;
	}

	// Token: 0x06000E76 RID: 3702 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E76")]
	[Address(RVA = "0xC94F68", Offset = "0xC94F68", VA = "0xC94F68")]
	public RubbleMakerUI_Layout()
	{
	}

	// Token: 0x04001C79 RID: 7289
	[Token(Token = "0x4001C79")]
	[FieldOffset(Offset = "0x0")]
	public static RubbleMakerUI_Layout InstanceNormal;

	// Token: 0x04001C7A RID: 7290
	[Token(Token = "0x4001C7A")]
	[FieldOffset(Offset = "0x4")]
	public static RubbleMakerUI_Layout Instance4Page;

	// Token: 0x04001C7B RID: 7291
	[Token(Token = "0x4001C7B")]
	[FieldOffset(Offset = "0xC")]
	public Panel_Layout Backing;

	// Token: 0x04001C7C RID: 7292
	[Token(Token = "0x4001C7C")]
	[FieldOffset(Offset = "0x10")]
	public Panel_Layout BackingNoOptions;

	// Token: 0x04001C7D RID: 7293
	[Token(Token = "0x4001C7D")]
	[FieldOffset(Offset = "0x14")]
	public ItemGrid_Layout MaterialOptions;

	// Token: 0x04001C7E RID: 7294
	[Token(Token = "0x4001C7E")]
	[FieldOffset(Offset = "0x18")]
	public ItemGrid_Layout RubbleOptions;

	// Token: 0x04001C7F RID: 7295
	[Token(Token = "0x4001C7F")]
	[FieldOffset(Offset = "0x1C")]
	public ItemGrid_Layout RubbleOptions2;

	// Token: 0x04001C80 RID: 7296
	[Token(Token = "0x4001C80")]
	[FieldOffset(Offset = "0x20")]
	public Panel_Layout MenuDivider;

	// Token: 0x04001C81 RID: 7297
	[Token(Token = "0x4001C81")]
	[FieldOffset(Offset = "0x24")]
	public bool DrawEmptySlots;

	// Token: 0x04001C82 RID: 7298
	[Token(Token = "0x4001C82")]
	[FieldOffset(Offset = "0x28")]
	public Texture_Layout DisabledBacking;

	// Token: 0x04001C83 RID: 7299
	[Token(Token = "0x4001C83")]
	[FieldOffset(Offset = "0x2C")]
	public Color DisabledBackingColor;

	// Token: 0x04001C84 RID: 7300
	[Token(Token = "0x4001C84")]
	[FieldOffset(Offset = "0x30")]
	public Texture_Layout DisabledBackingIconRubbleMaker;

	// Token: 0x04001C85 RID: 7301
	[Token(Token = "0x4001C85")]
	[FieldOffset(Offset = "0x34")]
	public Texture_Layout DisabledBackingIconGeneric;

	// Token: 0x04001C86 RID: 7302
	[Token(Token = "0x4001C86")]
	[FieldOffset(Offset = "0x38")]
	public Texture_Layout DisabledBackingIconMiteyTitey;

	// Token: 0x04001C87 RID: 7303
	[Token(Token = "0x4001C87")]
	[FieldOffset(Offset = "0x3C")]
	public Texture_Layout DisabledBackingIconPotableKiln;

	// Token: 0x04001C88 RID: 7304
	[Token(Token = "0x4001C88")]
	[FieldOffset(Offset = "0x40")]
	public Color DisabledBackingIconColor;

	// Token: 0x04001C89 RID: 7305
	[Token(Token = "0x4001C89")]
	[FieldOffset(Offset = "0x44")]
	public Vector2 TouchPanelOffset;

	// Token: 0x04001C8A RID: 7306
	[Token(Token = "0x4001C8A")]
	[FieldOffset(Offset = "0x4C")]
	public TransactionButton_Layout SizeToggle;

	// Token: 0x04001C8B RID: 7307
	[Token(Token = "0x4001C8B")]
	[FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout MaterialToggle;

	// Token: 0x04001C8C RID: 7308
	[Token(Token = "0x4001C8C")]
	[FieldOffset(Offset = "0x54")]
	public float MaterialScale;

	// Token: 0x04001C8D RID: 7309
	[Token(Token = "0x4001C8D")]
	[FieldOffset(Offset = "0x58")]
	public float HighlightedMaterialScale;

	// Token: 0x04001C8E RID: 7310
	[Token(Token = "0x4001C8E")]
	[FieldOffset(Offset = "0x5C")]
	public float RubbleScale;

	// Token: 0x04001C8F RID: 7311
	[Token(Token = "0x4001C8F")]
	[FieldOffset(Offset = "0x60")]
	public float HighlightedRubbleScale;

	// Token: 0x04001C90 RID: 7312
	[Token(Token = "0x4001C90")]
	[FieldOffset(Offset = "0x64")]
	public Vector2 SmallRubblePreviewScaleOffset;

	// Token: 0x04001C91 RID: 7313
	[Token(Token = "0x4001C91")]
	[FieldOffset(Offset = "0x6C")]
	public float SmallRubblePreviewScale;

	// Token: 0x04001C92 RID: 7314
	[Token(Token = "0x4001C92")]
	[FieldOffset(Offset = "0x70")]
	public Vector2 MediumRubblePreviewScaleOffset;

	// Token: 0x04001C93 RID: 7315
	[Token(Token = "0x4001C93")]
	[FieldOffset(Offset = "0x78")]
	public float MediumRubblePreviewScale;

	// Token: 0x04001C94 RID: 7316
	[Token(Token = "0x4001C94")]
	[FieldOffset(Offset = "0x7C")]
	public Vector2 LargeRubblePreviewScaleOffset;

	// Token: 0x04001C95 RID: 7317
	[Token(Token = "0x4001C95")]
	[FieldOffset(Offset = "0x84")]
	public float LargeRubblePreviewScale;

	// Token: 0x04001C96 RID: 7318
	[Token(Token = "0x4001C96")]
	[FieldOffset(Offset = "0x88")]
	public Vector2 PortableKilnPreviewScaleOffset;

	// Token: 0x04001C97 RID: 7319
	[Token(Token = "0x4001C97")]
	[FieldOffset(Offset = "0x90")]
	public float PortableKilnPreviewScale;

	// Token: 0x04001C98 RID: 7320
	[Token(Token = "0x4001C98")]
	[FieldOffset(Offset = "0x94")]
	public Vector2 DeadCellsDisplayJarPreviewScaleOffset;

	// Token: 0x04001C99 RID: 7321
	[Token(Token = "0x4001C99")]
	[FieldOffset(Offset = "0x9C")]
	public float DeadCellsDisplayJarPreviewScale;

	// Token: 0x04001C9A RID: 7322
	[Token(Token = "0x4001C9A")]
	[FieldOffset(Offset = "0xA0")]
	public Vector2 BookPreviewScaleOffset;

	// Token: 0x04001C9B RID: 7323
	[Token(Token = "0x4001C9B")]
	[FieldOffset(Offset = "0xA8")]
	public float BookPreviewScale;

	// Token: 0x04001C9C RID: 7324
	[Token(Token = "0x4001C9C")]
	[FieldOffset(Offset = "0xAC")]
	public Vector2 MiteyTiteyPreviewScaleOffset;

	// Token: 0x04001C9D RID: 7325
	[Token(Token = "0x4001C9D")]
	[FieldOffset(Offset = "0xB4")]
	public float MiteyTiteyPreviewScale;

	// Token: 0x04001C9E RID: 7326
	[Token(Token = "0x4001C9E")]
	[FieldOffset(Offset = "0xB8")]
	public Vector2 SandcastleBucketPreviewScaleOffset;

	// Token: 0x04001C9F RID: 7327
	[Token(Token = "0x4001C9F")]
	[FieldOffset(Offset = "0xC0")]
	public float SandcastleBucketPreviewScale;

	// Token: 0x04001CA0 RID: 7328
	[Token(Token = "0x4001CA0")]
	[FieldOffset(Offset = "0xC4")]
	public Vector2 GardenGnomePreviewScaleOffset;

	// Token: 0x04001CA1 RID: 7329
	[Token(Token = "0x4001CA1")]
	[FieldOffset(Offset = "0xCC")]
	public float GardenGnomePreviewScale;

	// Token: 0x04001CA2 RID: 7330
	[Token(Token = "0x4001CA2")]
	[FieldOffset(Offset = "0xD0")]
	public Vector2 CoralPreviewScaleOffset;

	// Token: 0x04001CA3 RID: 7331
	[Token(Token = "0x4001CA3")]
	[FieldOffset(Offset = "0xD8")]
	public float CoralPreviewScale;

	// Token: 0x04001CA4 RID: 7332
	[Token(Token = "0x4001CA4")]
	[FieldOffset(Offset = "0xDC")]
	public Vector2 CatacombPreviewScaleOffset;

	// Token: 0x04001CA5 RID: 7333
	[Token(Token = "0x4001CA5")]
	[FieldOffset(Offset = "0xE4")]
	public float CatacombPreviewScale;

	// Token: 0x04001CA6 RID: 7334
	[Token(Token = "0x4001CA6")]
	[FieldOffset(Offset = "0xE8")]
	public Vector2 SeashellPreviewScaleOffset;

	// Token: 0x04001CA7 RID: 7335
	[Token(Token = "0x4001CA7")]
	[FieldOffset(Offset = "0xF0")]
	public float SeashellPreviewScale;

	// Token: 0x04001CA8 RID: 7336
	[Token(Token = "0x4001CA8")]
	[FieldOffset(Offset = "0xF4")]
	public Vector2 LightningWhelkShellPreviewScaleOffset;

	// Token: 0x04001CA9 RID: 7337
	[Token(Token = "0x4001CA9")]
	[FieldOffset(Offset = "0xFC")]
	public float LightningWhelkShellPreviewScale;

	// Token: 0x04001CAA RID: 7338
	[Token(Token = "0x4001CAA")]
	[FieldOffset(Offset = "0x100")]
	public Vector2 TulipShellPreviewScaleOffset;

	// Token: 0x04001CAB RID: 7339
	[Token(Token = "0x4001CAB")]
	[FieldOffset(Offset = "0x108")]
	public float TulipShellPreviewScale;

	// Token: 0x04001CAC RID: 7340
	[Token(Token = "0x4001CAC")]
	[FieldOffset(Offset = "0x10C")]
	public Vector2 JunoniaShellPreviewScaleOffset;

	// Token: 0x04001CAD RID: 7341
	[Token(Token = "0x4001CAD")]
	[FieldOffset(Offset = "0x114")]
	public float JunoniaShellPreviewScale;

	// Token: 0x04001CAE RID: 7342
	[Token(Token = "0x4001CAE")]
	[FieldOffset(Offset = "0x118")]
	public Vector2 StarfishPreviewScaleOffset;

	// Token: 0x04001CAF RID: 7343
	[Token(Token = "0x4001CAF")]
	[FieldOffset(Offset = "0x120")]
	public float StarfishPreviewScale;

	// Token: 0x04001CB0 RID: 7344
	[Token(Token = "0x4001CB0")]
	[FieldOffset(Offset = "0x124")]
	public Vector2 PartyPresentPreviewScaleOffset;

	// Token: 0x04001CB1 RID: 7345
	[Token(Token = "0x4001CB1")]
	[FieldOffset(Offset = "0x12C")]
	public float PartyPresentPreviewScale;

	// Token: 0x04001CB2 RID: 7346
	[Token(Token = "0x4001CB2")]
	[FieldOffset(Offset = "0x130")]
	public Vector2 PresentPreviewScaleOffset;

	// Token: 0x04001CB3 RID: 7347
	[Token(Token = "0x4001CB3")]
	[FieldOffset(Offset = "0x138")]
	public float PresentPreviewScale;

	// Token: 0x04001CB4 RID: 7348
	[Token(Token = "0x4001CB4")]
	[FieldOffset(Offset = "0x13C")]
	public Vector2 JackOLaternPreviewScaleOffset;

	// Token: 0x04001CB5 RID: 7349
	[Token(Token = "0x4001CB5")]
	[FieldOffset(Offset = "0x144")]
	public float JackOLaternPreviewScale;

	// Token: 0x04001CB6 RID: 7350
	[Token(Token = "0x4001CB6")]
	[FieldOffset(Offset = "0x148")]
	public Vector2 LawnFlamingoPreviewScaleOffset;

	// Token: 0x04001CB7 RID: 7351
	[Token(Token = "0x4001CB7")]
	[FieldOffset(Offset = "0x150")]
	public float LawnFlamingoPreviewScale;

	// Token: 0x04001CB8 RID: 7352
	[Token(Token = "0x4001CB8")]
	[FieldOffset(Offset = "0x154")]
	public Vector2 LifeFruitPreviewScaleOffset;

	// Token: 0x04001CB9 RID: 7353
	[Token(Token = "0x4001CB9")]
	[FieldOffset(Offset = "0x15C")]
	public float LifeFruitPreviewScale;

	// Token: 0x04001CBA RID: 7354
	[Token(Token = "0x4001CBA")]
	[FieldOffset(Offset = "0x160")]
	public Vector2 AbigailsFlowerPreviewScaleOffset;

	// Token: 0x04001CBB RID: 7355
	[Token(Token = "0x4001CBB")]
	[FieldOffset(Offset = "0x168")]
	public float AbigailsFlowerPreviewScale;

	// Token: 0x04001CBC RID: 7356
	[Token(Token = "0x4001CBC")]
	[FieldOffset(Offset = "0x16C")]
	public Vector2 GlowTulipPreviewScaleOffset;

	// Token: 0x04001CBD RID: 7357
	[Token(Token = "0x4001CBD")]
	[FieldOffset(Offset = "0x174")]
	public float GlowTulipPreviewScale;

	// Token: 0x04001CBE RID: 7358
	[Token(Token = "0x4001CBE")]
	[FieldOffset(Offset = "0x178")]
	public Vector2 DigtoisePreviewScaleOffset;

	// Token: 0x04001CBF RID: 7359
	[Token(Token = "0x4001CBF")]
	[FieldOffset(Offset = "0x180")]
	public float DigtoisePreviewScale;

	// Token: 0x04001CC0 RID: 7360
	[Token(Token = "0x4001CC0")]
	[FieldOffset(Offset = "0x184")]
	public Vector2 GiantTikiPreviewScaleOffset;

	// Token: 0x04001CC1 RID: 7361
	[Token(Token = "0x4001CC1")]
	[FieldOffset(Offset = "0x18C")]
	public float GiantTikiPreviewScale;

	// Token: 0x04001CC2 RID: 7362
	[Token(Token = "0x4001CC2")]
	[FieldOffset(Offset = "0x190")]
	public Panel_Layout MaterialBacking;

	// Token: 0x04001CC3 RID: 7363
	[Token(Token = "0x4001CC3")]
	[FieldOffset(Offset = "0x194")]
	public Vector2 MaterialBackingTLOffset;

	// Token: 0x04001CC4 RID: 7364
	[Token(Token = "0x4001CC4")]
	[FieldOffset(Offset = "0x19C")]
	public Vector2 MaterialBackingBROffset;

	// Token: 0x04001CC5 RID: 7365
	[Token(Token = "0x4001CC5")]
	[FieldOffset(Offset = "0x1A4")]
	public FadeString_Layout TooltipDisplay;
}
