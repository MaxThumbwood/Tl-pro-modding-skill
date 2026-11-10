using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001EE RID: 494
[Token(Token = "0x20001EE")]
public class Equipment_Layout : PageControllerLayoutDefinition<Equipment_Layout>
{
	// Token: 0x1700015B RID: 347
	// (get) Token: 0x06000D46 RID: 3398 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700015B")]
	public Button_Layout DisplaySetBonus
	{
		[Token(Token = "0x6000D46")]
		[Address(RVA = "0xC7C250", Offset = "0xC7C250", VA = "0xC7C250")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700015C RID: 348
	// (get) Token: 0x06000D47 RID: 3399 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700015C")]
	public String_Layout DisplaySetBonusText
	{
		[Token(Token = "0x6000D47")]
		[Address(RVA = "0xC7C2F0", Offset = "0xC7C2F0", VA = "0xC7C2F0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700015D RID: 349
	// (get) Token: 0x06000D48 RID: 3400 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700015D")]
	public TransactionButton_Layout InfoToggleCollapsed
	{
		[Token(Token = "0x6000D48")]
		[Address(RVA = "0xC7C390", Offset = "0xC7C390", VA = "0xC7C390")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700015E RID: 350
	// (get) Token: 0x06000D49 RID: 3401 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700015E")]
	public TransactionButton_Layout InfoToggleExpanded
	{
		[Token(Token = "0x6000D49")]
		[Address(RVA = "0xC7C44C", Offset = "0xC7C44C", VA = "0xC7C44C")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700015F RID: 351
	// (get) Token: 0x06000D4A RID: 3402 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700015F")]
	public TransactionButton_Layout LoadoutToggle
	{
		[Token(Token = "0x6000D4A")]
		[Address(RVA = "0xC7C508", Offset = "0xC7C508", VA = "0xC7C508")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000160 RID: 352
	// (get) Token: 0x06000D4B RID: 3403 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000160")]
	public ItemGrid_Layout DisplayInfoAccessories
	{
		[Token(Token = "0x6000D4B")]
		[Address(RVA = "0xC7C5A8", Offset = "0xC7C5A8", VA = "0xC7C5A8")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000161 RID: 353
	// (get) Token: 0x06000D4C RID: 3404 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000161")]
	public ItemGrid_Layout DisplayLoadouts
	{
		[Token(Token = "0x6000D4C")]
		[Address(RVA = "0xC7C648", Offset = "0xC7C648", VA = "0xC7C648")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000D4D RID: 3405 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D4D")]
	[Address(RVA = "0xC7C6E8", Offset = "0xC7C6E8", VA = "0xC7C6E8")]
	public Equipment_Layout()
	{
	}

	// Token: 0x04001488 RID: 5256
	[Token(Token = "0x4001488")]
	[FieldOffset(Offset = "0x10")]
	public float AmourScale;

	// Token: 0x04001489 RID: 5257
	[Token(Token = "0x4001489")]
	[FieldOffset(Offset = "0x14")]
	public float ArmourHighlightScale;

	// Token: 0x0400148A RID: 5258
	[Token(Token = "0x400148A")]
	[FieldOffset(Offset = "0x18")]
	public ItemGrid_Layout ArmourDye;

	// Token: 0x0400148B RID: 5259
	[Token(Token = "0x400148B")]
	[FieldOffset(Offset = "0x1C")]
	public ItemGrid_Layout ArmourVanity;

	// Token: 0x0400148C RID: 5260
	[Token(Token = "0x400148C")]
	[FieldOffset(Offset = "0x20")]
	public ItemGrid_Layout Armor;

	// Token: 0x0400148D RID: 5261
	[Token(Token = "0x400148D")]
	[FieldOffset(Offset = "0x24")]
	public Vector2 ArmorCollapsePosition;

	// Token: 0x0400148E RID: 5262
	[Token(Token = "0x400148E")]
	[FieldOffset(Offset = "0x2C")]
	public float AccessoryScale;

	// Token: 0x0400148F RID: 5263
	[Token(Token = "0x400148F")]
	[FieldOffset(Offset = "0x30")]
	public float AccessoryHighlightScale;

	// Token: 0x04001490 RID: 5264
	[Token(Token = "0x4001490")]
	[FieldOffset(Offset = "0x34")]
	public ItemGrid_Layout AccessoryDye;

	// Token: 0x04001491 RID: 5265
	[Token(Token = "0x4001491")]
	[FieldOffset(Offset = "0x38")]
	public ItemGrid_Layout AccessoryVanity;

	// Token: 0x04001492 RID: 5266
	[Token(Token = "0x4001492")]
	[FieldOffset(Offset = "0x3C")]
	public ItemGrid_Layout Accessory;

	// Token: 0x04001493 RID: 5267
	[Token(Token = "0x4001493")]
	[FieldOffset(Offset = "0x40")]
	public Vector2 AccessoryCollapsePosition;

	// Token: 0x04001494 RID: 5268
	[Token(Token = "0x4001494")]
	[FieldOffset(Offset = "0x48")]
	public ItemGrid_Layout AccessoryExtra;

	// Token: 0x04001495 RID: 5269
	[Token(Token = "0x4001495")]
	[FieldOffset(Offset = "0x4C")]
	public ItemGrid_Layout AccessoryVanityExtra;

	// Token: 0x04001496 RID: 5270
	[Token(Token = "0x4001496")]
	[FieldOffset(Offset = "0x50")]
	public ItemGrid_Layout AccessoryDyeExtra;

	// Token: 0x04001497 RID: 5271
	[Token(Token = "0x4001497")]
	[FieldOffset(Offset = "0x54")]
	public Vector2 AccessoryExtraCollapsePosition;

	// Token: 0x04001498 RID: 5272
	[Token(Token = "0x4001498")]
	[FieldOffset(Offset = "0x5C")]
	public float QuickSlotScale;

	// Token: 0x04001499 RID: 5273
	[Token(Token = "0x4001499")]
	[FieldOffset(Offset = "0x60")]
	public float QuickHighlightScale;

	// Token: 0x0400149A RID: 5274
	[Token(Token = "0x400149A")]
	[FieldOffset(Offset = "0x64")]
	public ItemGrid_Layout QuickSlotDye;

	// Token: 0x0400149B RID: 5275
	[Token(Token = "0x400149B")]
	[FieldOffset(Offset = "0x68")]
	public ItemGrid_Layout QuickSlot;

	// Token: 0x0400149C RID: 5276
	[Token(Token = "0x400149C")]
	[FieldOffset(Offset = "0x6C")]
	public Vector2 QuickSlotCollapsePosition;

	// Token: 0x0400149D RID: 5277
	[Token(Token = "0x400149D")]
	[FieldOffset(Offset = "0x74")]
	public String_Layout Title;

	// Token: 0x0400149E RID: 5278
	[Token(Token = "0x400149E")]
	[FieldOffset(Offset = "0x78")]
	public String_Layout ArmourTitle;

	// Token: 0x0400149F RID: 5279
	[Token(Token = "0x400149F")]
	[FieldOffset(Offset = "0x7C")]
	public String_Layout AccessoryTitle;

	// Token: 0x040014A0 RID: 5280
	[Token(Token = "0x40014A0")]
	[FieldOffset(Offset = "0x80")]
	public String_Layout QuickSlotTitle;

	// Token: 0x040014A1 RID: 5281
	[Token(Token = "0x40014A1")]
	[FieldOffset(Offset = "0x84")]
	public Button_Layout SetBonus;

	// Token: 0x040014A2 RID: 5282
	[Token(Token = "0x40014A2")]
	[FieldOffset(Offset = "0x88")]
	public String_Layout SetBonusText;

	// Token: 0x040014A3 RID: 5283
	[Token(Token = "0x40014A3")]
	[FieldOffset(Offset = "0x8C")]
	public Button_Layout SetBonus_Horizontal;

	// Token: 0x040014A4 RID: 5284
	[Token(Token = "0x40014A4")]
	[FieldOffset(Offset = "0x90")]
	public String_Layout SetBonusText_Horizontal;

	// Token: 0x040014A5 RID: 5285
	[Token(Token = "0x40014A5")]
	[FieldOffset(Offset = "0x94")]
	public TransactionButton_Layout UnequipButton;

	// Token: 0x040014A6 RID: 5286
	[Token(Token = "0x40014A6")]
	[FieldOffset(Offset = "0x98")]
	public TransactionButton_Layout SwitchButton;

	// Token: 0x040014A7 RID: 5287
	[Token(Token = "0x40014A7")]
	[FieldOffset(Offset = "0x9C")]
	public TransactionButton_Layout HideShowButton;

	// Token: 0x040014A8 RID: 5288
	[Token(Token = "0x40014A8")]
	[FieldOffset(Offset = "0xA0")]
	public TransactionButton_Layout ShareButton;

	// Token: 0x040014A9 RID: 5289
	[Token(Token = "0x40014A9")]
	[FieldOffset(Offset = "0xA4")]
	public HideShowIcons HideShowIcons;

	// Token: 0x040014AA RID: 5290
	[Token(Token = "0x40014AA")]
	[FieldOffset(Offset = "0xA8")]
	public TransactionButton_Layout ExpandButton;

	// Token: 0x040014AB RID: 5291
	[Token(Token = "0x40014AB")]
	[FieldOffset(Offset = "0xAC")]
	public TransactionButton_Layout CollapseButton;

	// Token: 0x040014AC RID: 5292
	[Token(Token = "0x40014AC")]
	[FieldOffset(Offset = "0xB0")]
	public Vector2 VisibilityOffset;

	// Token: 0x040014AD RID: 5293
	[Token(Token = "0x40014AD")]
	[FieldOffset(Offset = "0xB8")]
	public Color VisibilityColour;

	// Token: 0x040014AE RID: 5294
	[Token(Token = "0x40014AE")]
	[FieldOffset(Offset = "0xBC")]
	public Vector2 MinecartOffset;

	// Token: 0x040014AF RID: 5295
	[Token(Token = "0x40014AF")]
	[FieldOffset(Offset = "0xC4")]
	public Color MinecartColour;

	// Token: 0x040014B0 RID: 5296
	[Token(Token = "0x40014B0")]
	[FieldOffset(Offset = "0xC8")]
	public TransactionButton_Layout InfoToggleControllerButtonCollapsed;

	// Token: 0x040014B1 RID: 5297
	[Token(Token = "0x40014B1")]
	[FieldOffset(Offset = "0xCC")]
	public TransactionButton_Layout InfoToggleControllerButtonExpanded;

	// Token: 0x040014B2 RID: 5298
	[Token(Token = "0x40014B2")]
	[FieldOffset(Offset = "0xD0")]
	public TransactionButton_Layout InfoToggleButtonCollapsed;

	// Token: 0x040014B3 RID: 5299
	[Token(Token = "0x40014B3")]
	[FieldOffset(Offset = "0xD4")]
	public TransactionButton_Layout InfoToggleButtonExpanded;

	// Token: 0x040014B4 RID: 5300
	[Token(Token = "0x40014B4")]
	[FieldOffset(Offset = "0xD8")]
	public TransactionButton_Layout InfoToggleButtonCollapsed_Horizontal;

	// Token: 0x040014B5 RID: 5301
	[Token(Token = "0x40014B5")]
	[FieldOffset(Offset = "0xDC")]
	public TransactionButton_Layout InfoToggleButtonExpanded_Horizontal;

	// Token: 0x040014B6 RID: 5302
	[Token(Token = "0x40014B6")]
	[FieldOffset(Offset = "0xE0")]
	public Panel_Layout InfoAccessoriesBacking;

	// Token: 0x040014B7 RID: 5303
	[Token(Token = "0x40014B7")]
	[FieldOffset(Offset = "0xE4")]
	public Vector2 InfoAccessoriesBackingTLOffset;

	// Token: 0x040014B8 RID: 5304
	[Token(Token = "0x40014B8")]
	[FieldOffset(Offset = "0xEC")]
	public Vector2 InfoAccessoriesBackingBROffset;

	// Token: 0x040014B9 RID: 5305
	[Token(Token = "0x40014B9")]
	[FieldOffset(Offset = "0xF4")]
	public ItemGrid_Layout InfoAccessories;

	// Token: 0x040014BA RID: 5306
	[Token(Token = "0x40014BA")]
	[FieldOffset(Offset = "0xF8")]
	public ItemGrid_Layout InfoAccessories_Horizontal;

	// Token: 0x040014BB RID: 5307
	[Token(Token = "0x40014BB")]
	[FieldOffset(Offset = "0xFC")]
	public TransactionButton_Layout LoadoutToggleButton;

	// Token: 0x040014BC RID: 5308
	[Token(Token = "0x40014BC")]
	[FieldOffset(Offset = "0x100")]
	public TransactionButton_Layout LoadoutToggleButton_Horizontal;

	// Token: 0x040014BD RID: 5309
	[Token(Token = "0x40014BD")]
	[FieldOffset(Offset = "0x104")]
	public float InfoAccessoriesScale;

	// Token: 0x040014BE RID: 5310
	[Token(Token = "0x40014BE")]
	[FieldOffset(Offset = "0x108")]
	public Color InfoAccNormal;

	// Token: 0x040014BF RID: 5311
	[Token(Token = "0x40014BF")]
	[FieldOffset(Offset = "0x10C")]
	public Color InfoAccDisabled;

	// Token: 0x040014C0 RID: 5312
	[Token(Token = "0x40014C0")]
	[FieldOffset(Offset = "0x110")]
	public Color InfoAccBackingColour;

	// Token: 0x040014C1 RID: 5313
	[Token(Token = "0x40014C1")]
	[FieldOffset(Offset = "0x114")]
	public Color InfoAccBackingHighlightColour;

	// Token: 0x040014C2 RID: 5314
	[Token(Token = "0x40014C2")]
	[FieldOffset(Offset = "0x118")]
	public Color InfoAccVisColour;

	// Token: 0x040014C3 RID: 5315
	[Token(Token = "0x40014C3")]
	[FieldOffset(Offset = "0x11C")]
	public float InfoAccVisScale;

	// Token: 0x040014C4 RID: 5316
	[Token(Token = "0x40014C4")]
	[FieldOffset(Offset = "0x120")]
	public Texture_Layout InfoAccBackingTexture;

	// Token: 0x040014C5 RID: 5317
	[Token(Token = "0x40014C5")]
	[FieldOffset(Offset = "0x124")]
	public Vector2 InfoAccVisOffset;

	// Token: 0x040014C6 RID: 5318
	[Token(Token = "0x40014C6")]
	[FieldOffset(Offset = "0x12C")]
	public float InfoAccessoriesIconScale;

	// Token: 0x040014C7 RID: 5319
	[Token(Token = "0x40014C7")]
	[FieldOffset(Offset = "0x130")]
	public ItemGrid_Layout Loadouts;

	// Token: 0x040014C8 RID: 5320
	[Token(Token = "0x40014C8")]
	[FieldOffset(Offset = "0x134")]
	public ItemGrid_Layout Loadouts_Horizontal;

	// Token: 0x040014C9 RID: 5321
	[Token(Token = "0x40014C9")]
	[FieldOffset(Offset = "0x138")]
	public Panel_Layout LoadoutBacking;

	// Token: 0x040014CA RID: 5322
	[Token(Token = "0x40014CA")]
	[FieldOffset(Offset = "0x13C")]
	public Vector2 LoadoutBackingTLOffset;

	// Token: 0x040014CB RID: 5323
	[Token(Token = "0x40014CB")]
	[FieldOffset(Offset = "0x144")]
	public Vector2 LoadoutBackingBROffset;

	// Token: 0x040014CC RID: 5324
	[Token(Token = "0x40014CC")]
	[FieldOffset(Offset = "0x14C")]
	public float LoadoutScale;

	// Token: 0x040014CD RID: 5325
	[Token(Token = "0x40014CD")]
	[FieldOffset(Offset = "0x150")]
	public Color LoadoutBackingColour;

	// Token: 0x040014CE RID: 5326
	[Token(Token = "0x40014CE")]
	[FieldOffset(Offset = "0x154")]
	public Color LoadoutBackingHighlightColour;

	// Token: 0x040014CF RID: 5327
	[Token(Token = "0x40014CF")]
	[FieldOffset(Offset = "0x158")]
	public Texture_Layout LoadoutBackingTexture;

	// Token: 0x040014D0 RID: 5328
	[Token(Token = "0x40014D0")]
	[FieldOffset(Offset = "0x15C")]
	public float LoadoutIconScale;

	// Token: 0x040014D1 RID: 5329
	[Token(Token = "0x40014D1")]
	[FieldOffset(Offset = "0x160")]
	public Color ExtraDyeBackingColour;

	// Token: 0x040014D2 RID: 5330
	[Token(Token = "0x40014D2")]
	[FieldOffset(Offset = "0x164")]
	public Color ExtraVanityAccBackingColour;

	// Token: 0x040014D3 RID: 5331
	[Token(Token = "0x40014D3")]
	[FieldOffset(Offset = "0x168")]
	public Color ExtraAccBackingColour;

	// Token: 0x040014D4 RID: 5332
	[Token(Token = "0x40014D4")]
	[FieldOffset(Offset = "0x16C")]
	public Texture_Layout DisabledAccessoryBacking;

	// Token: 0x040014D5 RID: 5333
	[Token(Token = "0x40014D5")]
	[FieldOffset(Offset = "0x170")]
	public Color DisabledAccessoryBackingColor;

	// Token: 0x040014D6 RID: 5334
	[Token(Token = "0x40014D6")]
	[FieldOffset(Offset = "0x174")]
	public Color DisabledAccessoryBackingIconColor;

	// Token: 0x040014D7 RID: 5335
	[Token(Token = "0x40014D7")]
	[FieldOffset(Offset = "0x178")]
	public Texture_Layout DisabledVanityAccessoryBacking;

	// Token: 0x040014D8 RID: 5336
	[Token(Token = "0x40014D8")]
	[FieldOffset(Offset = "0x17C")]
	public Color DisabledVanityAccessoryBackingColor;

	// Token: 0x040014D9 RID: 5337
	[Token(Token = "0x40014D9")]
	[FieldOffset(Offset = "0x180")]
	public Color DisabledVanityAccessoryBackingIconColor;

	// Token: 0x040014DA RID: 5338
	[Token(Token = "0x40014DA")]
	[FieldOffset(Offset = "0x184")]
	public Texture_Layout DisabledDyeAccessoryBacking;

	// Token: 0x040014DB RID: 5339
	[Token(Token = "0x40014DB")]
	[FieldOffset(Offset = "0x188")]
	public Color DisabledDyeAccessoryBackingColor;

	// Token: 0x040014DC RID: 5340
	[Token(Token = "0x40014DC")]
	[FieldOffset(Offset = "0x18C")]
	public Color DisabledDyeAccessoryBackingIconColor;
}
