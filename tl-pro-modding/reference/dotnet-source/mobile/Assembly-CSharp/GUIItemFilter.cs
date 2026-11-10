using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;

// Token: 0x02000162 RID: 354
[Token(Token = "0x2000162")]
public class GUIItemFilter
{
	// Token: 0x060009F7 RID: 2551 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009F7")]
	[Address(RVA = "0xABE680", Offset = "0xABE680", VA = "0xABE680")]
	public GUIItemFilter(GUIPageIcons.Category cat)
	{
	}

	// Token: 0x060009F8 RID: 2552 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009F8")]
	[Address(RVA = "0xABE7E4", Offset = "0xABE7E4", VA = "0xABE7E4")]
	public void Reset(bool expandedOnTouch = false)
	{
	}

	// Token: 0x060009F9 RID: 2553 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009F9")]
	[Address(RVA = "0xABE944", Offset = "0xABE944", VA = "0xABE944")]
	public void SetFilterCategory(GUIItemFilter.CategoryFilter category)
	{
	}

	// Token: 0x060009FA RID: 2554 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009FA")]
	[Address(RVA = "0xABE868", Offset = "0xABE868", VA = "0xABE868")]
	public void SetSearchTerm(string term)
	{
	}

	// Token: 0x060009FB RID: 2555 RVA: 0x000060C0 File Offset: 0x000042C0
	[Token(Token = "0x60009FB")]
	[Address(RVA = "0xABC2C0", Offset = "0xABC2C0", VA = "0xABC2C0")]
	public bool Matches(int itemId, bool ignoreCategory = false)
	{
		return default(bool);
	}

	// Token: 0x060009FC RID: 2556 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009FC")]
	[Address(RVA = "0xABE94C", Offset = "0xABE94C", VA = "0xABE94C")]
	public void CloseExpandedFilter()
	{
	}

	// Token: 0x060009FD RID: 2557 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009FD")]
	[Address(RVA = "0xABE9CC", Offset = "0xABE9CC", VA = "0xABE9CC")]
	private void LoadCategoryButtonIcon(TransactionButton_Layout button)
	{
	}

	// Token: 0x060009FE RID: 2558 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009FE")]
	[Address(RVA = "0xABED3C", Offset = "0xABED3C", VA = "0xABED3C")]
	private void Close()
	{
	}

	// Token: 0x060009FF RID: 2559 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009FF")]
	[Address(RVA = "0xABEDA8", Offset = "0xABEDA8", VA = "0xABEDA8")]
	private void DrawOptions(List<GUIPageIcons.Category> options, GUIPageIconGrouping activeGroup, bool hasFocus)
	{
	}

	// Token: 0x06000A00 RID: 2560 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A00")]
	[Address(RVA = "0xAC0B20", Offset = "0xAC0B20", VA = "0xAC0B20")]
	public List<GUIPageIcons.Category> GetOptions(out GUIPageIconGrouping activeGroup)
	{
		return null;
	}

	// Token: 0x06000A01 RID: 2561 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A01")]
	[Address(RVA = "0xAC1470", Offset = "0xAC1470", VA = "0xAC1470")]
	private void AddUIExcludeRegionsForOptions(List<Rectangle> regions, List<GUIPageIcons.Category> options)
	{
	}

	// Token: 0x06000A02 RID: 2562 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A02")]
	[Address(RVA = "0xAC1AB4", Offset = "0xAC1AB4", VA = "0xAC1AB4")]
	public void AddUIExcludeRegions(List<Rectangle> regions)
	{
	}

	// Token: 0x06000A03 RID: 2563 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A03")]
	[Address(RVA = "0xAC1CD0", Offset = "0xAC1CD0", VA = "0xAC1CD0")]
	private void DrawCategoryOption(TransactionButton_Layout buttonLayout, GUIItemFilter.CategoryFilter filterEntry)
	{
	}

	// Token: 0x06000A04 RID: 2564 RVA: 0x000060D8 File Offset: 0x000042D8
	[Token(Token = "0x6000A04")]
	[Address(RVA = "0xAC1F54", Offset = "0xAC1F54", VA = "0xAC1F54")]
	public int DrawFilter()
	{
		return 0;
	}

	// Token: 0x06000A05 RID: 2565 RVA: 0x000060F0 File Offset: 0x000042F0
	[Token(Token = "0x6000A05")]
	[Address(RVA = "0xAC3BB4", Offset = "0xAC3BB4", VA = "0xAC3BB4")]
	private int DrawSearch(bool hasFocus)
	{
		return 0;
	}

	// Token: 0x06000A06 RID: 2566 RVA: 0x00006108 File Offset: 0x00004308
	[Token(Token = "0x6000A06")]
	[Address(RVA = "0xAC4B58", Offset = "0xAC4B58", VA = "0xAC4B58")]
	public bool IsOver(Vector2 cursorPosition)
	{
		return default(bool);
	}

	// Token: 0x04000BD5 RID: 3029
	[Token(Token = "0x4000BD5")]
	[FieldOffset(Offset = "0x8")]
	private GUIPageIcons.Category _cat;

	// Token: 0x04000BD6 RID: 3030
	[Token(Token = "0x4000BD6")]
	[FieldOffset(Offset = "0x0")]
	private static string[] categoryName;

	// Token: 0x04000BD7 RID: 3031
	[Token(Token = "0x4000BD7")]
	[FieldOffset(Offset = "0xC")]
	public GUIItemFilter.CategoryFilter ActiveCategory;

	// Token: 0x04000BD8 RID: 3032
	[Token(Token = "0x4000BD8")]
	[FieldOffset(Offset = "0x10")]
	public string SearchTerm;

	// Token: 0x04000BD9 RID: 3033
	[Token(Token = "0x4000BD9")]
	[FieldOffset(Offset = "0x14")]
	public bool Expanded;

	// Token: 0x04000BDA RID: 3034
	[Token(Token = "0x4000BDA")]
	[FieldOffset(Offset = "0x15")]
	public bool editingSearch;

	// Token: 0x04000BDB RID: 3035
	[Token(Token = "0x4000BDB")]
	[FieldOffset(Offset = "0x18")]
	public string editSearch;

	// Token: 0x04000BDC RID: 3036
	[Token(Token = "0x4000BDC")]
	[FieldOffset(Offset = "0x1C")]
	public string editSearchStart;

	// Token: 0x04000BDD RID: 3037
	[Token(Token = "0x4000BDD")]
	[FieldOffset(Offset = "0x20")]
	public string editDisplaySearch;

	// Token: 0x04000BDE RID: 3038
	[Token(Token = "0x4000BDE")]
	[FieldOffset(Offset = "0x4")]
	private static List<IItemEntryFilter> everythingButMisc;

	// Token: 0x04000BDF RID: 3039
	[Token(Token = "0x4000BDF")]
	[FieldOffset(Offset = "0x8")]
	private static IItemEntryFilter[] CategoryFilters;

	// Token: 0x04000BE0 RID: 3040
	[Token(Token = "0x4000BE0")]
	[FieldOffset(Offset = "0x24")]
	private ISearchFilter<Item> searchFilter;

	// Token: 0x04000BE1 RID: 3041
	[Token(Token = "0x4000BE1")]
	[FieldOffset(Offset = "0x28")]
	private bool disableReset;

	// Token: 0x04000BE2 RID: 3042
	[Token(Token = "0x4000BE2")]
	[FieldOffset(Offset = "0x29")]
	private bool miscFilterInitialised;

	// Token: 0x04000BE3 RID: 3043
	[Token(Token = "0x4000BE3")]
	[FieldOffset(Offset = "0x2C")]
	private float collapseScale;

	// Token: 0x04000BE4 RID: 3044
	[Token(Token = "0x4000BE4")]
	[FieldOffset(Offset = "0x30")]
	private float allScale;

	// Token: 0x04000BE5 RID: 3045
	[Token(Token = "0x4000BE5")]
	[FieldOffset(Offset = "0x34")]
	private float weaponScale;

	// Token: 0x04000BE6 RID: 3046
	[Token(Token = "0x4000BE6")]
	[FieldOffset(Offset = "0x38")]
	private float armorScale;

	// Token: 0x04000BE7 RID: 3047
	[Token(Token = "0x4000BE7")]
	[FieldOffset(Offset = "0x3C")]
	private float vanityScale;

	// Token: 0x04000BE8 RID: 3048
	[Token(Token = "0x4000BE8")]
	[FieldOffset(Offset = "0x40")]
	private float buildingBlockScale;

	// Token: 0x04000BE9 RID: 3049
	[Token(Token = "0x4000BE9")]
	[FieldOffset(Offset = "0x44")]
	private float furnitureScale;

	// Token: 0x04000BEA RID: 3050
	[Token(Token = "0x4000BEA")]
	[FieldOffset(Offset = "0x48")]
	private float gameplayItemsScale;

	// Token: 0x04000BEB RID: 3051
	[Token(Token = "0x4000BEB")]
	[FieldOffset(Offset = "0x4C")]
	private float accessoriesScale;

	// Token: 0x04000BEC RID: 3052
	[Token(Token = "0x4000BEC")]
	[FieldOffset(Offset = "0x50")]
	private float equipmentScale;

	// Token: 0x04000BED RID: 3053
	[Token(Token = "0x4000BED")]
	[FieldOffset(Offset = "0x54")]
	private float consumablesScale;

	// Token: 0x04000BEE RID: 3054
	[Token(Token = "0x4000BEE")]
	[FieldOffset(Offset = "0x58")]
	private float toolsScale;

	// Token: 0x04000BEF RID: 3055
	[Token(Token = "0x4000BEF")]
	[FieldOffset(Offset = "0x5C")]
	private float materialsScale;

	// Token: 0x04000BF0 RID: 3056
	[Token(Token = "0x4000BF0")]
	[FieldOffset(Offset = "0x60")]
	public GUIControllerItemFilter _controller;

	// Token: 0x04000BF1 RID: 3057
	[Token(Token = "0x4000BF1")]
	[FieldOffset(Offset = "0x64")]
	private GUIControllerItem previousNavigationItem;

	// Token: 0x04000BF2 RID: 3058
	[Token(Token = "0x4000BF2")]
	[FieldOffset(Offset = "0x68")]
	private GUIInputRegionExclusive pickingInterceptor;

	// Token: 0x04000BF3 RID: 3059
	[Token(Token = "0x4000BF3")]
	[FieldOffset(Offset = "0x6C")]
	private List<GUIPageIcons.Category> options;

	// Token: 0x04000BF4 RID: 3060
	[Token(Token = "0x4000BF4")]
	[FieldOffset(Offset = "0xC")]
	private static float BeginSearchScale;

	// Token: 0x02000163 RID: 355
	[Token(Token = "0x2000163")]
	public enum CategoryFilter
	{
		// Token: 0x04000BF6 RID: 3062
		[Token(Token = "0x4000BF6")]
		All,
		// Token: 0x04000BF7 RID: 3063
		[Token(Token = "0x4000BF7")]
		Weapon,
		// Token: 0x04000BF8 RID: 3064
		[Token(Token = "0x4000BF8")]
		Armor,
		// Token: 0x04000BF9 RID: 3065
		[Token(Token = "0x4000BF9")]
		Vanity,
		// Token: 0x04000BFA RID: 3066
		[Token(Token = "0x4000BFA")]
		BuildingBlock,
		// Token: 0x04000BFB RID: 3067
		[Token(Token = "0x4000BFB")]
		Furniture,
		// Token: 0x04000BFC RID: 3068
		[Token(Token = "0x4000BFC")]
		Accessories,
		// Token: 0x04000BFD RID: 3069
		[Token(Token = "0x4000BFD")]
		Equipment,
		// Token: 0x04000BFE RID: 3070
		[Token(Token = "0x4000BFE")]
		Consumables,
		// Token: 0x04000BFF RID: 3071
		[Token(Token = "0x4000BFF")]
		Tools,
		// Token: 0x04000C00 RID: 3072
		[Token(Token = "0x4000C00")]
		Materials,
		// Token: 0x04000C01 RID: 3073
		[Token(Token = "0x4000C01")]
		GameplayItems,
		// Token: 0x04000C02 RID: 3074
		[Token(Token = "0x4000C02")]
		Count
	}
}
