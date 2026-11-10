using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x02000149 RID: 329
[Token(Token = "0x2000149")]
public class GUICraftGuide
{
	// Token: 0x060008B4 RID: 2228 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008B4")]
	[Address(RVA = "0x6215A0", Offset = "0x6215A0", VA = "0x6215A0")]
	public void LoadPageRegion()
	{
	}

	// Token: 0x170000C2 RID: 194
	// (get) Token: 0x060008B5 RID: 2229 RVA: 0x00005928 File Offset: 0x00003B28
	[Token(Token = "0x170000C2")]
	public bool Collapsed
	{
		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x6216DC", Offset = "0x6216DC", VA = "0x6216DC")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060008B6 RID: 2230 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008B6")]
	[Address(RVA = "0x62175C", Offset = "0x62175C", VA = "0x62175C")]
	public void Reset()
	{
	}

	// Token: 0x170000C3 RID: 195
	// (get) Token: 0x060008B7 RID: 2231 RVA: 0x00005940 File Offset: 0x00003B40
	[Token(Token = "0x170000C3")]
	public bool HasFocus
	{
		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x621824", Offset = "0x621824", VA = "0x621824")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060008B8 RID: 2232 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008B8")]
	[Address(RVA = "0x621954", Offset = "0x621954", VA = "0x621954")]
	private Item GetItem(int materialIndex)
	{
		return null;
	}

	// Token: 0x170000C4 RID: 196
	// (get) Token: 0x060008B9 RID: 2233 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000C4")]
	public Item guideItem
	{
		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x621AC0", Offset = "0x621AC0", VA = "0x621AC0")]
		get
		{
			return null;
		}
	}

	// Token: 0x060008BA RID: 2234 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008BA")]
	[Address(RVA = "0x621AC8", Offset = "0x621AC8", VA = "0x621AC8")]
	private void RefreshItems()
	{
	}

	// Token: 0x060008BB RID: 2235 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008BB")]
	[Address(RVA = "0x621E40", Offset = "0x621E40", VA = "0x621E40")]
	public void DrawGuideList()
	{
	}

	// Token: 0x060008BC RID: 2236 RVA: 0x00005958 File Offset: 0x00003B58
	[Token(Token = "0x60008BC")]
	[Address(RVA = "0x622670", Offset = "0x622670", VA = "0x622670")]
	public float GuideItemScale(int index)
	{
		return 0f;
	}

	// Token: 0x060008BD RID: 2237 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008BD")]
	[Address(RVA = "0x6226D8", Offset = "0x6226D8", VA = "0x6226D8")]
	public void GuideItemOver(int index)
	{
	}

	// Token: 0x060008BE RID: 2238 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008BE")]
	[Address(RVA = "0x622D60", Offset = "0x622D60", VA = "0x622D60")]
	public void GuideItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x060008BF RID: 2239 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008BF")]
	[Address(RVA = "0x6233F4", Offset = "0x6233F4", VA = "0x6233F4")]
	public void Draw()
	{
	}

	// Token: 0x060008C0 RID: 2240 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008C0")]
	[Address(RVA = "0x623A8C", Offset = "0x623A8C", VA = "0x623A8C")]
	public GUICraftGuide()
	{
	}

	// Token: 0x040009B9 RID: 2489
	[Token(Token = "0x40009B9")]
	[FieldOffset(Offset = "0x8")]
	public float craftScrollOffset;

	// Token: 0x040009BA RID: 2490
	[Token(Token = "0x40009BA")]
	[FieldOffset(Offset = "0xC")]
	private float craftScrollMomentum;

	// Token: 0x040009BB RID: 2491
	[Token(Token = "0x40009BB")]
	[FieldOffset(Offset = "0x10")]
	private int craftScrollDragging;

	// Token: 0x040009BC RID: 2492
	[Token(Token = "0x40009BC")]
	[FieldOffset(Offset = "0x14")]
	private Vector2 craftDragOffset;

	// Token: 0x040009BD RID: 2493
	[Token(Token = "0x40009BD")]
	[FieldOffset(Offset = "0x1C")]
	private int cursorOver;

	// Token: 0x040009BE RID: 2494
	[Token(Token = "0x40009BE")]
	[FieldOffset(Offset = "0x20")]
	public bool menuTogglePressed;

	// Token: 0x040009BF RID: 2495
	[Token(Token = "0x40009BF")]
	[FieldOffset(Offset = "0x21")]
	public bool materialsGridActive;

	// Token: 0x040009C0 RID: 2496
	[Token(Token = "0x40009C0")]
	[FieldOffset(Offset = "0x28")]
	private DateTime NavigationTick;

	// Token: 0x040009C1 RID: 2497
	[Token(Token = "0x40009C1")]
	[FieldOffset(Offset = "0x30")]
	private GUIControllerCraftingMaterials materialController;

	// Token: 0x040009C2 RID: 2498
	[Token(Token = "0x40009C2")]
	[FieldOffset(Offset = "0x34")]
	private List<string> _requiredObjecsForCraftingText;

	// Token: 0x040009C3 RID: 2499
	[Token(Token = "0x40009C3")]
	[FieldOffset(Offset = "0x38")]
	public List<int> _materialItems;

	// Token: 0x040009C4 RID: 2500
	[Token(Token = "0x40009C4")]
	[FieldOffset(Offset = "0x3C")]
	private Item _defaultItem;

	// Token: 0x040009C5 RID: 2501
	[Token(Token = "0x40009C5")]
	[FieldOffset(Offset = "0x40")]
	private int _selectedItem;
}
