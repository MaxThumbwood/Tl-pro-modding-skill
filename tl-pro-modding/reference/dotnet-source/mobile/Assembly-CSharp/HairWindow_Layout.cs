using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001F1 RID: 497
[Token(Token = "0x20001F1")]
public class HairWindow_Layout : LayoutDefinition
{
	// Token: 0x06000D52 RID: 3410 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D52")]
	[Address(RVA = "0xC7CE54", Offset = "0xC7CE54", VA = "0xC7CE54")]
	private void Awake()
	{
	}

	// Token: 0x06000D53 RID: 3411 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D53")]
	[Address(RVA = "0xC7CEA8", Offset = "0xC7CEA8", VA = "0xC7CEA8")]
	public HairWindow_Layout()
	{
	}

	// Token: 0x040014F6 RID: 5366
	[Token(Token = "0x40014F6")]
	[FieldOffset(Offset = "0x0")]
	public static HairWindow_Layout Instance;

	// Token: 0x040014F7 RID: 5367
	[Token(Token = "0x40014F7")]
	[FieldOffset(Offset = "0xC")]
	public Panel_Layout Backing;

	// Token: 0x040014F8 RID: 5368
	[Token(Token = "0x40014F8")]
	[FieldOffset(Offset = "0x10")]
	public StringButton_Layout Title;

	// Token: 0x040014F9 RID: 5369
	[Token(Token = "0x40014F9")]
	[FieldOffset(Offset = "0x14")]
	public DraggableItemGrid_Layout HairGrid;

	// Token: 0x040014FA RID: 5370
	[Token(Token = "0x40014FA")]
	[FieldOffset(Offset = "0x18")]
	public Panel_Layout CharacterBacking;

	// Token: 0x040014FB RID: 5371
	[Token(Token = "0x40014FB")]
	[FieldOffset(Offset = "0x1C")]
	public Panel_Layout CharacterPosition;

	// Token: 0x040014FC RID: 5372
	[Token(Token = "0x40014FC")]
	[FieldOffset(Offset = "0x20")]
	public bool SlidersExclusive;

	// Token: 0x040014FD RID: 5373
	[Token(Token = "0x40014FD")]
	[FieldOffset(Offset = "0x24")]
	public Panel_Layout MenuDivider;

	// Token: 0x040014FE RID: 5374
	[Token(Token = "0x40014FE")]
	[FieldOffset(Offset = "0x28")]
	public Panel_Layout MenuDivider2;

	// Token: 0x040014FF RID: 5375
	[Token(Token = "0x40014FF")]
	[FieldOffset(Offset = "0x2C")]
	public Texture_Layout SlidersIcon;

	// Token: 0x04001500 RID: 5376
	[Token(Token = "0x4001500")]
	[FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout ColourButton;

	// Token: 0x04001501 RID: 5377
	[Token(Token = "0x4001501")]
	[FieldOffset(Offset = "0x34")]
	public TransactionButton_Layout HairStyleButton;

	// Token: 0x04001502 RID: 5378
	[Token(Token = "0x4001502")]
	[FieldOffset(Offset = "0x38")]
	public Panel_Layout SlidersBacking;

	// Token: 0x04001503 RID: 5379
	[Token(Token = "0x4001503")]
	[FieldOffset(Offset = "0x3C")]
	public TransactionButton_Layout LightnessBacking;

	// Token: 0x04001504 RID: 5380
	[Token(Token = "0x4001504")]
	[FieldOffset(Offset = "0x40")]
	public Slider_Layout Lightness;

	// Token: 0x04001505 RID: 5381
	[Token(Token = "0x4001505")]
	[FieldOffset(Offset = "0x44")]
	public TransactionButton_Layout SaturationBacking;

	// Token: 0x04001506 RID: 5382
	[Token(Token = "0x4001506")]
	[FieldOffset(Offset = "0x48")]
	public Slider_Layout Saturation;

	// Token: 0x04001507 RID: 5383
	[Token(Token = "0x4001507")]
	[FieldOffset(Offset = "0x4C")]
	public TransactionButton_Layout HueBacking;

	// Token: 0x04001508 RID: 5384
	[Token(Token = "0x4001508")]
	[FieldOffset(Offset = "0x50")]
	public Slider_Layout Hue;

	// Token: 0x04001509 RID: 5385
	[Token(Token = "0x4001509")]
	[FieldOffset(Offset = "0x54")]
	public TransactionButton_Layout ColourValue;

	// Token: 0x0400150A RID: 5386
	[Token(Token = "0x400150A")]
	[FieldOffset(Offset = "0x58")]
	public float HairScale;

	// Token: 0x0400150B RID: 5387
	[Token(Token = "0x400150B")]
	[FieldOffset(Offset = "0x5C")]
	public float HairHighlightScale;

	// Token: 0x0400150C RID: 5388
	[Token(Token = "0x400150C")]
	[FieldOffset(Offset = "0x60")]
	public Panel_Layout SavingsBacking;

	// Token: 0x0400150D RID: 5389
	[Token(Token = "0x400150D")]
	[FieldOffset(Offset = "0x64")]
	public String_Layout Savings;

	// Token: 0x0400150E RID: 5390
	[Token(Token = "0x400150E")]
	[FieldOffset(Offset = "0x68")]
	public String_Layout Cost;

	// Token: 0x0400150F RID: 5391
	[Token(Token = "0x400150F")]
	[FieldOffset(Offset = "0x6C")]
	public String_Layout ControllerCost;

	// Token: 0x04001510 RID: 5392
	[Token(Token = "0x4001510")]
	[FieldOffset(Offset = "0x70")]
	public String_Layout SavingsTitle;

	// Token: 0x04001511 RID: 5393
	[Token(Token = "0x4001511")]
	[FieldOffset(Offset = "0x74")]
	public Vector2 Savings1IconOffset;

	// Token: 0x04001512 RID: 5394
	[Token(Token = "0x4001512")]
	[FieldOffset(Offset = "0x7C")]
	public Vector2 Savings2IconOffset;

	// Token: 0x04001513 RID: 5395
	[Token(Token = "0x4001513")]
	[FieldOffset(Offset = "0x84")]
	public Vector2 Savings3IconOffset;

	// Token: 0x04001514 RID: 5396
	[Token(Token = "0x4001514")]
	[FieldOffset(Offset = "0x8C")]
	public Vector2 Savings4IconOffset;

	// Token: 0x04001515 RID: 5397
	[Token(Token = "0x4001515")]
	[FieldOffset(Offset = "0x94")]
	public TransactionButton_Layout Close;

	// Token: 0x04001516 RID: 5398
	[Token(Token = "0x4001516")]
	[FieldOffset(Offset = "0x98")]
	public TransactionButton_Layout ActionButton;

	// Token: 0x04001517 RID: 5399
	[Token(Token = "0x4001517")]
	[FieldOffset(Offset = "0x9C")]
	public bool DrawEmptySlots;

	// Token: 0x04001518 RID: 5400
	[Token(Token = "0x4001518")]
	[FieldOffset(Offset = "0xA0")]
	public Texture_Layout DisabledBacking;

	// Token: 0x04001519 RID: 5401
	[Token(Token = "0x4001519")]
	[FieldOffset(Offset = "0xA4")]
	public Color DisabledBackingColor;

	// Token: 0x0400151A RID: 5402
	[Token(Token = "0x400151A")]
	[FieldOffset(Offset = "0xA8")]
	public Texture_Layout DisabledBackingIcon;

	// Token: 0x0400151B RID: 5403
	[Token(Token = "0x400151B")]
	[FieldOffset(Offset = "0xAC")]
	public Color DisabledBackingIconColor;
}
