using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

// Token: 0x02000173 RID: 371
[Token(Token = "0x2000173")]
public class GUIPageIcons
{
	// Token: 0x06000A94 RID: 2708 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A94")]
	[Address(RVA = "0xBCAB2C", Offset = "0xBCAB2C", VA = "0xBCAB2C")]
	public static void DropUIItem(Player player, Item item, int additionalVelocity = 0)
	{
	}

	// Token: 0x170000F2 RID: 242
	// (get) Token: 0x06000A95 RID: 2709 RVA: 0x000063D8 File Offset: 0x000045D8
	[Token(Token = "0x170000F2")]
	public bool UseHorizontalPages
	{
		[Token(Token = "0x6000A95")]
		[Address(RVA = "0xBCAD94", Offset = "0xBCAD94", VA = "0xBCAD94")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000F3 RID: 243
	// (get) Token: 0x06000A96 RID: 2710 RVA: 0x000063F0 File Offset: 0x000045F0
	[Token(Token = "0x170000F3")]
	public bool UsingTouchUI
	{
		[Token(Token = "0x6000A96")]
		[Address(RVA = "0xBCADB0", Offset = "0xBCADB0", VA = "0xBCADB0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000F4 RID: 244
	// (get) Token: 0x06000A97 RID: 2711 RVA: 0x00006408 File Offset: 0x00004608
	[Token(Token = "0x170000F4")]
	public bool DisplayTouchOptions
	{
		[Token(Token = "0x6000A97")]
		[Address(RVA = "0xBCAE80", Offset = "0xBCAE80", VA = "0xBCAE80")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000A98 RID: 2712 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A98")]
	[Address(RVA = "0xBCAFA8", Offset = "0xBCAFA8", VA = "0xBCAFA8")]
	public static void LoadContent(ContentManager content)
	{
	}

	// Token: 0x06000A99 RID: 2713 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A99")]
	[Address(RVA = "0xBCBF70", Offset = "0xBCBF70", VA = "0xBCBF70")]
	private static void LoadItemIcon(ContentManager content, int id)
	{
	}

	// Token: 0x06000A9A RID: 2714 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A9A")]
	[Address(RVA = "0xBCBAD4", Offset = "0xBCBAD4", VA = "0xBCBAD4")]
	private static void LoadNPCIcon(ContentManager content, int id)
	{
	}

	// Token: 0x06000A9B RID: 2715 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A9B")]
	[Address(RVA = "0xBCC26C", Offset = "0xBCC26C", VA = "0xBCC26C")]
	public Texture2D GetCategoryTexture(GUIPageIcons.Category category, bool selected)
	{
		return null;
	}

	// Token: 0x06000A9C RID: 2716 RVA: 0x00006420 File Offset: 0x00004620
	[Token(Token = "0x6000A9C")]
	[Address(RVA = "0xBCD8C4", Offset = "0xBCD8C4", VA = "0xBCD8C4")]
	public bool IsPageSelected(GUIPageIcons.Category category)
	{
		return default(bool);
	}

	// Token: 0x06000A9D RID: 2717 RVA: 0x00006438 File Offset: 0x00004638
	[Token(Token = "0x6000A9D")]
	[Address(RVA = "0xBCD944", Offset = "0xBCD944", VA = "0xBCD944")]
	public bool DrawRightPageHUD()
	{
		return default(bool);
	}

	// Token: 0x06000A9E RID: 2718 RVA: 0x00006450 File Offset: 0x00004650
	[Token(Token = "0x6000A9E")]
	[Address(RVA = "0xBCD95C", Offset = "0xBCD95C", VA = "0xBCD95C")]
	public bool CanAcceptItems(GUIPageIcons.Category category)
	{
		return default(bool);
	}

	// Token: 0x06000A9F RID: 2719 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A9F")]
	[Address(RVA = "0xBCD994", Offset = "0xBCD994", VA = "0xBCD994")]
	public void Close(bool hideChat = true)
	{
	}

	// Token: 0x06000AA0 RID: 2720 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA0")]
	[Address(RVA = "0xBC939C", Offset = "0xBC939C", VA = "0xBC939C")]
	public void OpenUI(GUIPageIcons.Category left, GUIPageIcons.Category right)
	{
	}

	// Token: 0x06000AA1 RID: 2721 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA1")]
	[Address(RVA = "0xBCDCF8", Offset = "0xBCDCF8", VA = "0xBCDCF8")]
	private void RefreshAvailableItems()
	{
	}

	// Token: 0x06000AA2 RID: 2722 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA2")]
	[Address(RVA = "0xBCE0FC", Offset = "0xBCE0FC", VA = "0xBCE0FC")]
	private void UpdatePageStates()
	{
	}

	// Token: 0x06000AA3 RID: 2723 RVA: 0x00006468 File Offset: 0x00004668
	[Token(Token = "0x6000AA3")]
	[Address(RVA = "0xBCE2B4", Offset = "0xBCE2B4", VA = "0xBCE2B4")]
	public float ExtendedScale(int index)
	{
		return 0f;
	}

	// Token: 0x06000AA4 RID: 2724 RVA: 0x00006480 File Offset: 0x00004680
	[Token(Token = "0x6000AA4")]
	[Address(RVA = "0xBCE2BC", Offset = "0xBCE2BC", VA = "0xBCE2BC")]
	public float ItemScale(int index)
	{
		return 0f;
	}

	// Token: 0x06000AA5 RID: 2725 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA5")]
	[Address(RVA = "0xBCE324", Offset = "0xBCE324", VA = "0xBCE324")]
	public void OnCategoryClosed(GUIPageIcons.Category category)
	{
	}

	// Token: 0x06000AA6 RID: 2726 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA6")]
	[Address(RVA = "0xBCEA90", Offset = "0xBCEA90", VA = "0xBCEA90")]
	public void OnCategoryOpened(GUIPageIcons.Category category)
	{
	}

	// Token: 0x06000AA7 RID: 2727 RVA: 0x00006498 File Offset: 0x00004698
	[Token(Token = "0x6000AA7")]
	[Address(RVA = "0xBCF5E4", Offset = "0xBCF5E4", VA = "0xBCF5E4")]
	public bool AnyPageSelected()
	{
		return default(bool);
	}

	// Token: 0x06000AA8 RID: 2728 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA8")]
	[Address(RVA = "0xBCF8A4", Offset = "0xBCF8A4", VA = "0xBCF8A4")]
	public void LoadDrawColor(TransactionButton_Layout layout, Color color)
	{
	}

	// Token: 0x06000AA9 RID: 2729 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA9")]
	[Address(RVA = "0xBCF8EC", Offset = "0xBCF8EC", VA = "0xBCF8EC")]
	public void OverloadDrawColor(TransactionButton_Layout layout, GUIPageIcons.Category category, bool over, bool selected, out Color restoreCol)
	{
	}

	// Token: 0x06000AAA RID: 2730 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AAA")]
	[Address(RVA = "0xBCFCC0", Offset = "0xBCFCC0", VA = "0xBCFCC0")]
	public void DrawInventoryPage()
	{
	}

	// Token: 0x170000F5 RID: 245
	// (get) Token: 0x06000AAB RID: 2731 RVA: 0x000064B0 File Offset: 0x000046B0
	[Token(Token = "0x170000F5")]
	public bool PagePopupDisplayed
	{
		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0xBCFDE8", Offset = "0xBCFDE8", VA = "0xBCFDE8")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000AAC RID: 2732 RVA: 0x000064C8 File Offset: 0x000046C8
	[Token(Token = "0x6000AAC")]
	[Address(RVA = "0xBD03D8", Offset = "0xBD03D8", VA = "0xBD03D8")]
	public bool ClickedOutOfRegion(Rectangle popupRegion, bool showDebug = false)
	{
		return default(bool);
	}

	// Token: 0x06000AAD RID: 2733 RVA: 0x000064E0 File Offset: 0x000046E0
	[Token(Token = "0x6000AAD")]
	[Address(RVA = "0xBD0928", Offset = "0xBD0928", VA = "0xBD0928")]
	public bool ReleasedOutOfRegion(Rectangle popupRegion, bool showDebug = false)
	{
		return default(bool);
	}

	// Token: 0x06000AAE RID: 2734 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AAE")]
	[Address(RVA = "0xBD0E78", Offset = "0xBD0E78", VA = "0xBD0E78")]
	public void DrawLeftMenuButton()
	{
	}

	// Token: 0x06000AAF RID: 2735 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AAF")]
	[Address(RVA = "0xBD35D4", Offset = "0xBD35D4", VA = "0xBD35D4")]
	public void ActionOpenInventory()
	{
	}

	// Token: 0x06000AB0 RID: 2736 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB0")]
	[Address(RVA = "0xBD384C", Offset = "0xBD384C", VA = "0xBD384C")]
	public void Draw()
	{
	}

	// Token: 0x06000AB1 RID: 2737 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB1")]
	[Address(RVA = "0xBD4AAC", Offset = "0xBD4AAC", VA = "0xBD4AAC")]
	public GUIPageIcons()
	{
	}

	// Token: 0x04000CA6 RID: 3238
	[Token(Token = "0x4000CA6")]
	[FieldOffset(Offset = "0x8")]
	public GUIPageIcons.PageCollapseMode PageMode;

	// Token: 0x04000CA7 RID: 3239
	[Token(Token = "0x4000CA7")]
	[FieldOffset(Offset = "0xC")]
	public GUIPageIcons.PageControlsType PageControls;

	// Token: 0x04000CA8 RID: 3240
	[Token(Token = "0x4000CA8")]
	[FieldOffset(Offset = "0x0")]
	private static Texture2D[] _categories;

	// Token: 0x04000CA9 RID: 3241
	[Token(Token = "0x4000CA9")]
	[FieldOffset(Offset = "0x4")]
	private static Texture2D[] _categoriesSelected;

	// Token: 0x04000CAA RID: 3242
	[Token(Token = "0x4000CAA")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<int, Texture2D> _npcIcons;

	// Token: 0x04000CAB RID: 3243
	[Token(Token = "0x4000CAB")]
	[FieldOffset(Offset = "0xC")]
	private static Dictionary<int, Texture2D> _npcSelectedIcons;

	// Token: 0x04000CAC RID: 3244
	[Token(Token = "0x4000CAC")]
	[FieldOffset(Offset = "0x10")]
	private static Dictionary<int, Texture2D> _npcShimmeredIcons;

	// Token: 0x04000CAD RID: 3245
	[Token(Token = "0x4000CAD")]
	[FieldOffset(Offset = "0x14")]
	private static Dictionary<int, Texture2D> _npcShimmeredSelectedIcons;

	// Token: 0x04000CAE RID: 3246
	[Token(Token = "0x4000CAE")]
	[FieldOffset(Offset = "0x18")]
	private static Dictionary<int, Texture2D> _itemIcons;

	// Token: 0x04000CAF RID: 3247
	[Token(Token = "0x4000CAF")]
	[FieldOffset(Offset = "0x1C")]
	private static Dictionary<int, Texture2D> _itemSelectedIcons;

	// Token: 0x04000CB0 RID: 3248
	[Token(Token = "0x4000CB0")]
	[FieldOffset(Offset = "0x20")]
	private static Texture2D _menuClosed;

	// Token: 0x04000CB1 RID: 3249
	[Token(Token = "0x4000CB1")]
	[FieldOffset(Offset = "0x24")]
	public static Texture2D _menuOpen;

	// Token: 0x04000CB2 RID: 3250
	[Token(Token = "0x4000CB2")]
	[FieldOffset(Offset = "0x10")]
	private GUIPageIcons.Category lastHoverLeft;

	// Token: 0x04000CB3 RID: 3251
	[Token(Token = "0x4000CB3")]
	[FieldOffset(Offset = "0x14")]
	private GUIPageIcons.Category hoverLeft;

	// Token: 0x04000CB4 RID: 3252
	[Token(Token = "0x4000CB4")]
	[FieldOffset(Offset = "0x18")]
	private float TimeSinceLeftHoverChanged;

	// Token: 0x04000CB5 RID: 3253
	[Token(Token = "0x4000CB5")]
	[FieldOffset(Offset = "0x1C")]
	private float TimeSinceLeftChanged;

	// Token: 0x04000CB6 RID: 3254
	[Token(Token = "0x4000CB6")]
	[FieldOffset(Offset = "0x20")]
	private float TimeSinceRightChanged;

	// Token: 0x04000CB7 RID: 3255
	[Token(Token = "0x4000CB7")]
	[FieldOffset(Offset = "0x24")]
	private GUIPageIcons.Category lastHoverRight;

	// Token: 0x04000CB8 RID: 3256
	[Token(Token = "0x4000CB8")]
	[FieldOffset(Offset = "0x28")]
	private GUIPageIcons.Category hoverRight;

	// Token: 0x04000CB9 RID: 3257
	[Token(Token = "0x4000CB9")]
	[FieldOffset(Offset = "0x2C")]
	private float TimeSinceRightHoverChanged;

	// Token: 0x04000CBA RID: 3258
	[Token(Token = "0x4000CBA")]
	[FieldOffset(Offset = "0x30")]
	public bool UseHorizontalInventory;

	// Token: 0x04000CBB RID: 3259
	[Token(Token = "0x4000CBB")]
	[FieldOffset(Offset = "0x31")]
	public bool UseConsoleStyle;

	// Token: 0x04000CBC RID: 3260
	[Token(Token = "0x4000CBC")]
	[FieldOffset(Offset = "0x32")]
	public bool EnableDoubleClick;

	// Token: 0x04000CBD RID: 3261
	[Token(Token = "0x4000CBD")]
	[FieldOffset(Offset = "0x33")]
	public bool UsePageLeftStyle;

	// Token: 0x04000CBE RID: 3262
	[Token(Token = "0x4000CBE")]
	[FieldOffset(Offset = "0x28")]
	private static bool dumpMissingIcons;

	// Token: 0x04000CBF RID: 3263
	[Token(Token = "0x4000CBF")]
	[FieldOffset(Offset = "0x34")]
	public bool excludeFocus;

	// Token: 0x04000CC0 RID: 3264
	[Token(Token = "0x4000CC0")]
	[FieldOffset(Offset = "0x35")]
	public bool rightUseBanner;

	// Token: 0x04000CC1 RID: 3265
	[Token(Token = "0x4000CC1")]
	[FieldOffset(Offset = "0x36")]
	public bool rightUseDuplication;

	// Token: 0x04000CC2 RID: 3266
	[Token(Token = "0x4000CC2")]
	[FieldOffset(Offset = "0x38")]
	private Vector2 pageButtonRegionSize;

	// Token: 0x04000CC3 RID: 3267
	[Token(Token = "0x4000CC3")]
	[FieldOffset(Offset = "0x40")]
	public GUIControllerItem lastActive;

	// Token: 0x02000174 RID: 372
	[Token(Token = "0x2000174")]
	public enum PageControlsType
	{
		// Token: 0x04000CC5 RID: 3269
		[Token(Token = "0x4000CC5")]
		Vertical,
		// Token: 0x04000CC6 RID: 3270
		[Token(Token = "0x4000CC6")]
		Bottom
	}

	// Token: 0x02000175 RID: 373
	[Token(Token = "0x2000175")]
	public enum PageCollapseMode
	{
		// Token: 0x04000CC8 RID: 3272
		[Token(Token = "0x4000CC8")]
		CollapsedFullClosed,
		// Token: 0x04000CC9 RID: 3273
		[Token(Token = "0x4000CC9")]
		FullClosed,
		// Token: 0x04000CCA RID: 3274
		[Token(Token = "0x4000CCA")]
		CollapsedFull,
		// Token: 0x04000CCB RID: 3275
		[Token(Token = "0x4000CCB")]
		FullOnly
	}

	// Token: 0x02000176 RID: 374
	[Token(Token = "0x2000176")]
	public enum Category
	{
		// Token: 0x04000CCD RID: 3277
		[Token(Token = "0x4000CCD")]
		Crafting,
		// Token: 0x04000CCE RID: 3278
		[Token(Token = "0x4000CCE")]
		CraftingGuide,
		// Token: 0x04000CCF RID: 3279
		[Token(Token = "0x4000CCF")]
		Inventory,
		// Token: 0x04000CD0 RID: 3280
		[Token(Token = "0x4000CD0")]
		Chest,
		// Token: 0x04000CD1 RID: 3281
		[Token(Token = "0x4000CD1")]
		Shop,
		// Token: 0x04000CD2 RID: 3282
		[Token(Token = "0x4000CD2")]
		Housing,
		// Token: 0x04000CD3 RID: 3283
		[Token(Token = "0x4000CD3")]
		Equipment,
		// Token: 0x04000CD4 RID: 3284
		[Token(Token = "0x4000CD4")]
		PVP,
		// Token: 0x04000CD5 RID: 3285
		[Token(Token = "0x4000CD5")]
		Map,
		// Token: 0x04000CD6 RID: 3286
		[Token(Token = "0x4000CD6")]
		Reforge,
		// Token: 0x04000CD7 RID: 3287
		[Token(Token = "0x4000CD7")]
		HairStylist,
		// Token: 0x04000CD8 RID: 3288
		[Token(Token = "0x4000CD8")]
		Dresser,
		// Token: 0x04000CD9 RID: 3289
		[Token(Token = "0x4000CD9")]
		GrandDesignSettings,
		// Token: 0x04000CDA RID: 3290
		[Token(Token = "0x4000CDA")]
		JourneyModeSettings,
		// Token: 0x04000CDB RID: 3291
		[Token(Token = "0x4000CDB")]
		Duplicate,
		// Token: 0x04000CDC RID: 3292
		[Token(Token = "0x4000CDC")]
		DisplayDoll,
		// Token: 0x04000CDD RID: 3293
		[Token(Token = "0x4000CDD")]
		HatRack,
		// Token: 0x04000CDE RID: 3294
		[Token(Token = "0x4000CDE")]
		Research,
		// Token: 0x04000CDF RID: 3295
		[Token(Token = "0x4000CDF")]
		None,
		// Token: 0x04000CE0 RID: 3296
		[Token(Token = "0x4000CE0")]
		Banner,
		// Token: 0x04000CE1 RID: 3297
		[Token(Token = "0x4000CE1")]
		CraftingStation,
		// Token: 0x04000CE2 RID: 3298
		[Token(Token = "0x4000CE2")]
		Count
	}
}
