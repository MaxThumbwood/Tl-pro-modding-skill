using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x0200014B RID: 331
[Token(Token = "0x200014B")]
public class GUICrafting
{
	// Token: 0x060008D6 RID: 2262 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008D6")]
	[Address(RVA = "0x628774", Offset = "0x628774", VA = "0x628774")]
	public GUICrafting()
	{
	}

	// Token: 0x060008D7 RID: 2263 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008D7")]
	[Address(RVA = "0x628ACC", Offset = "0x628ACC", VA = "0x628ACC")]
	public void SetupCraftingIcon(Tile interactableTile)
	{
	}

	// Token: 0x060008D8 RID: 2264 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008D8")]
	[Address(RVA = "0x629458", Offset = "0x629458", VA = "0x629458")]
	public void Reset()
	{
	}

	// Token: 0x170000C6 RID: 198
	// (get) Token: 0x060008D9 RID: 2265 RVA: 0x000059E8 File Offset: 0x00003BE8
	[Token(Token = "0x170000C6")]
	public bool HasFocus
	{
		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x629520", Offset = "0x629520", VA = "0x629520")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060008DA RID: 2266 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008DA")]
	[Address(RVA = "0x6296B4", Offset = "0x6296B4", VA = "0x6296B4")]
	public void DrawCraftButton()
	{
	}

	// Token: 0x170000C7 RID: 199
	// (get) Token: 0x060008DB RID: 2267 RVA: 0x00005A00 File Offset: 0x00003C00
	[Token(Token = "0x170000C7")]
	public int SelectedNumMaterials
	{
		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x62AD08", Offset = "0x62AD08", VA = "0x62AD08")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170000C8 RID: 200
	// (get) Token: 0x060008DC RID: 2268 RVA: 0x00005A18 File Offset: 0x00003C18
	[Token(Token = "0x170000C8")]
	public int CraftHoverNumMaterials
	{
		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x62AE5C", Offset = "0x62AE5C", VA = "0x62AE5C")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170000C9 RID: 201
	// (get) Token: 0x060008DD RID: 2269 RVA: 0x00005A30 File Offset: 0x00003C30
	[Token(Token = "0x170000C9")]
	public bool Collapsed
	{
		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x62AEE4", Offset = "0x62AEE4", VA = "0x62AEE4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060008DE RID: 2270 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008DE")]
	[Address(RVA = "0x62AF64", Offset = "0x62AF64", VA = "0x62AF64")]
	public void DrawExpandButton()
	{
	}

	// Token: 0x060008DF RID: 2271 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008DF")]
	[Address(RVA = "0x62AF68", Offset = "0x62AF68", VA = "0x62AF68")]
	public void DrawMaterialsGridTooltip(Vector2 position)
	{
	}

	// Token: 0x060008E0 RID: 2272 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E0")]
	[Address(RVA = "0x62B260", Offset = "0x62B260", VA = "0x62B260")]
	public void DrawMaterialsGrid()
	{
	}

	// Token: 0x060008E1 RID: 2273 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E1")]
	[Address(RVA = "0x62BACC", Offset = "0x62BACC", VA = "0x62BACC")]
	public void UpdateMaterialNavigation()
	{
	}

	// Token: 0x060008E2 RID: 2274 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E2")]
	[Address(RVA = "0x62BDD0", Offset = "0x62BDD0", VA = "0x62BDD0")]
	public void ResetFilters()
	{
	}

	// Token: 0x170000CA RID: 202
	// (get) Token: 0x060008E3 RID: 2275 RVA: 0x00005A48 File Offset: 0x00003C48
	[Token(Token = "0x170000CA")]
	private int TileFilter
	{
		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x62BE08", Offset = "0x62BE08", VA = "0x62BE08")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060008E4 RID: 2276 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E4")]
	[Address(RVA = "0x62BEF4", Offset = "0x62BEF4", VA = "0x62BEF4")]
	public void GetAltTileFilter(int tileFilter, out int altTileFilter1, out int altTileFilter2)
	{
	}

	// Token: 0x060008E5 RID: 2277 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E5")]
	[Address(RVA = "0x62BFE8", Offset = "0x62BFE8", VA = "0x62BFE8")]
	private void UpdateFilter(bool force = false)
	{
	}

	// Token: 0x060008E6 RID: 2278 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E6")]
	[Address(RVA = "0x62C5F4", Offset = "0x62C5F4", VA = "0x62C5F4")]
	public void LoadPageRegion()
	{
	}

	// Token: 0x060008E7 RID: 2279 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E7")]
	[Address(RVA = "0x62C804", Offset = "0x62C804", VA = "0x62C804")]
	public void RefreshGridNav()
	{
	}

	// Token: 0x060008E8 RID: 2280 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E8")]
	[Address(RVA = "0x62CC48", Offset = "0x62CC48", VA = "0x62CC48")]
	private void CheckAdjTileRefresh()
	{
	}

	// Token: 0x060008E9 RID: 2281 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E9")]
	[Address(RVA = "0x62CDE4", Offset = "0x62CDE4", VA = "0x62CDE4")]
	public void Draw()
	{
	}

	// Token: 0x060008EA RID: 2282 RVA: 0x00005A60 File Offset: 0x00003C60
	[Token(Token = "0x60008EA")]
	[Address(RVA = "0x62D510", Offset = "0x62D510", VA = "0x62D510")]
	public float CraftItemScaleImp(int index)
	{
		return 0f;
	}

	// Token: 0x060008EB RID: 2283 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008EB")]
	[Address(RVA = "0x62D578", Offset = "0x62D578", VA = "0x62D578")]
	private void RefocusExistingRecipeIfStillAvailable()
	{
	}

	// Token: 0x060008EC RID: 2284 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008EC")]
	[Address(RVA = "0x62A3AC", Offset = "0x62A3AC", VA = "0x62A3AC")]
	public void CraftButtonOver(GUITransactionButton.InputState state)
	{
	}

	// Token: 0x060008ED RID: 2285 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008ED")]
	[Address(RVA = "0x62D660", Offset = "0x62D660", VA = "0x62D660")]
	public void CraftItemOverImp(int index)
	{
	}

	// Token: 0x060008EE RID: 2286 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008EE")]
	[Address(RVA = "0x62E00C", Offset = "0x62E00C", VA = "0x62E00C")]
	public void CraftItemDrawImp(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x060008EF RID: 2287 RVA: 0x00005A78 File Offset: 0x00003C78
	[Token(Token = "0x60008EF")]
	[Address(RVA = "0x62EB98", Offset = "0x62EB98", VA = "0x62EB98")]
	public float MaterialItemScale(int index)
	{
		return 0f;
	}

	// Token: 0x060008F0 RID: 2288 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F0")]
	[Address(RVA = "0x62EC00", Offset = "0x62EC00", VA = "0x62EC00")]
	public void MaterialItemTooltipOver(int index)
	{
	}

	// Token: 0x060008F1 RID: 2289 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F1")]
	[Address(RVA = "0x62EC04", Offset = "0x62EC04", VA = "0x62EC04")]
	public void MaterialItemOver(int index)
	{
	}

	// Token: 0x060008F2 RID: 2290 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F2")]
	[Address(RVA = "0x62F5AC", Offset = "0x62F5AC", VA = "0x62F5AC")]
	public void MaterialItemTooltipDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x060008F3 RID: 2291 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F3")]
	[Address(RVA = "0x630114", Offset = "0x630114", VA = "0x630114")]
	public void MaterialItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x040009EA RID: 2538
	[Token(Token = "0x40009EA")]
	[FieldOffset(Offset = "0x8")]
	private GUIItemGrid.GetItemScaleHandler CraftItemScale;

	// Token: 0x040009EB RID: 2539
	[Token(Token = "0x40009EB")]
	[FieldOffset(Offset = "0xC")]
	private GUIItemGrid.CursorOver CraftItemOver;

	// Token: 0x040009EC RID: 2540
	[Token(Token = "0x40009EC")]
	[FieldOffset(Offset = "0x10")]
	private GUIItemGrid.DrawItemHandler CraftItemDraw;

	// Token: 0x040009ED RID: 2541
	[Token(Token = "0x40009ED")]
	[FieldOffset(Offset = "0x14")]
	public int CraftingStationIcon;

	// Token: 0x040009EE RID: 2542
	[Token(Token = "0x40009EE")]
	[FieldOffset(Offset = "0x18")]
	private float CraftButtonScale;

	// Token: 0x040009EF RID: 2543
	[Token(Token = "0x40009EF")]
	[FieldOffset(Offset = "0x1C")]
	private int Offset;

	// Token: 0x040009F0 RID: 2544
	[Token(Token = "0x40009F0")]
	[FieldOffset(Offset = "0x20")]
	private int LastTileFilter;

	// Token: 0x040009F1 RID: 2545
	[Token(Token = "0x40009F1")]
	[FieldOffset(Offset = "0x24")]
	private int LastId;

	// Token: 0x040009F2 RID: 2546
	[Token(Token = "0x40009F2")]
	[FieldOffset(Offset = "0x28")]
	private GUIItemFilter.CategoryFilter LastCategory;

	// Token: 0x040009F3 RID: 2547
	[Token(Token = "0x40009F3")]
	[FieldOffset(Offset = "0x2C")]
	private string LastSearch;

	// Token: 0x040009F4 RID: 2548
	[Token(Token = "0x40009F4")]
	[FieldOffset(Offset = "0x30")]
	public GUIItemFilter Filter;

	// Token: 0x040009F5 RID: 2549
	[Token(Token = "0x40009F5")]
	[FieldOffset(Offset = "0x34")]
	public List<int> FilteredItems;

	// Token: 0x040009F6 RID: 2550
	[Token(Token = "0x40009F6")]
	[FieldOffset(Offset = "0x38")]
	public float craftScrollOffset;

	// Token: 0x040009F7 RID: 2551
	[Token(Token = "0x40009F7")]
	[FieldOffset(Offset = "0x3C")]
	private float craftScrollMomentum;

	// Token: 0x040009F8 RID: 2552
	[Token(Token = "0x40009F8")]
	[FieldOffset(Offset = "0x40")]
	private int craftScrollDragging;

	// Token: 0x040009F9 RID: 2553
	[Token(Token = "0x40009F9")]
	[FieldOffset(Offset = "0x44")]
	private Vector2 craftDragOffset;

	// Token: 0x040009FA RID: 2554
	[Token(Token = "0x40009FA")]
	[FieldOffset(Offset = "0x4C")]
	private bool blockCraftOnOpenUntilButtonReleased;

	// Token: 0x040009FB RID: 2555
	[Token(Token = "0x40009FB")]
	[FieldOffset(Offset = "0x4D")]
	private bool pendingCraft;

	// Token: 0x040009FC RID: 2556
	[Token(Token = "0x40009FC")]
	[FieldOffset(Offset = "0x50")]
	public float hoverCraftDelay;

	// Token: 0x040009FD RID: 2557
	[Token(Token = "0x40009FD")]
	[FieldOffset(Offset = "0x54")]
	public GUITransactionButton.InputState lastState;

	// Token: 0x040009FE RID: 2558
	[Token(Token = "0x40009FE")]
	[FieldOffset(Offset = "0x58")]
	private float ExpandButtonScale;

	// Token: 0x040009FF RID: 2559
	[Token(Token = "0x40009FF")]
	[FieldOffset(Offset = "0x5C")]
	public bool menuTogglePressed;

	// Token: 0x04000A00 RID: 2560
	[Token(Token = "0x4000A00")]
	[FieldOffset(Offset = "0x5D")]
	public bool materialsGridActive;

	// Token: 0x04000A01 RID: 2561
	[Token(Token = "0x4000A01")]
	[FieldOffset(Offset = "0x60")]
	private DateTime NavigationTick;

	// Token: 0x04000A02 RID: 2562
	[Token(Token = "0x4000A02")]
	[FieldOffset(Offset = "0x68")]
	private GUIControllerCraftingMaterials materialController;

	// Token: 0x04000A03 RID: 2563
	[Token(Token = "0x4000A03")]
	[FieldOffset(Offset = "0x6C")]
	private int PageRegionScreenWidth;

	// Token: 0x04000A04 RID: 2564
	[Token(Token = "0x4000A04")]
	[FieldOffset(Offset = "0x70")]
	private int PageRegionScreenHeight;

	// Token: 0x04000A05 RID: 2565
	[Token(Token = "0x4000A05")]
	[FieldOffset(Offset = "0x74")]
	private Rectangle PageRegion;

	// Token: 0x04000A06 RID: 2566
	[Token(Token = "0x4000A06")]
	[FieldOffset(Offset = "0x84")]
	private DraggableItemGrid_Layout PageGrid;

	// Token: 0x04000A07 RID: 2567
	[Token(Token = "0x4000A07")]
	[FieldOffset(Offset = "0x88")]
	private int PageX;

	// Token: 0x04000A08 RID: 2568
	[Token(Token = "0x4000A08")]
	[FieldOffset(Offset = "0x8C")]
	private int PageY;

	// Token: 0x04000A09 RID: 2569
	[Token(Token = "0x4000A09")]
	[FieldOffset(Offset = "0x90")]
	private bool[] oldAdjTile;

	// Token: 0x04000A0A RID: 2570
	[Token(Token = "0x4000A0A")]
	[FieldOffset(Offset = "0x94")]
	private bool oldAdjWater;

	// Token: 0x04000A0B RID: 2571
	[Token(Token = "0x4000A0B")]
	[FieldOffset(Offset = "0x95")]
	private bool oldAdjHoney;

	// Token: 0x04000A0C RID: 2572
	[Token(Token = "0x4000A0C")]
	[FieldOffset(Offset = "0x96")]
	private bool oldAdjLava;

	// Token: 0x04000A0D RID: 2573
	[Token(Token = "0x4000A0D")]
	[FieldOffset(Offset = "0x98")]
	public Dictionary<int, int> AvailableCraftingStations;

	// Token: 0x04000A0E RID: 2574
	[Token(Token = "0x4000A0E")]
	[FieldOffset(Offset = "0x9C")]
	private int multiCraftDelay;

	// Token: 0x04000A0F RID: 2575
	[Token(Token = "0x4000A0F")]
	[FieldOffset(Offset = "0xA0")]
	private int multiCraftRecipe;

	// Token: 0x04000A10 RID: 2576
	[Token(Token = "0x4000A10")]
	[FieldOffset(Offset = "0xA4")]
	private bool wasOverItem;

	// Token: 0x04000A11 RID: 2577
	[Token(Token = "0x4000A11")]
	[FieldOffset(Offset = "0xA8")]
	private int cursorOver;

	// Token: 0x04000A12 RID: 2578
	[Token(Token = "0x4000A12")]
	[FieldOffset(Offset = "0xAC")]
	private int HoverRecipe;

	// Token: 0x04000A13 RID: 2579
	[Token(Token = "0x4000A13")]
	[FieldOffset(Offset = "0xB0")]
	public Recipe CraftHover;

	// Token: 0x04000A14 RID: 2580
	[Token(Token = "0x4000A14")]
	[FieldOffset(Offset = "0xB4")]
	private Item blankItem;

	// Token: 0x04000A15 RID: 2581
	[Token(Token = "0x4000A15")]
	[FieldOffset(Offset = "0xB8")]
	private string materialHoverItemName;

	// Token: 0x04000A16 RID: 2582
	[Token(Token = "0x4000A16")]
	[FieldOffset(Offset = "0xBC")]
	private Item materialToolTip;
}
