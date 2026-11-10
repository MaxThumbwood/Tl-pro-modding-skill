using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x0200017E RID: 382
[Token(Token = "0x200017E")]
public class GUIResearchPage
{
	// Token: 0x06000B1B RID: 2843 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B1B")]
	[Address(RVA = "0xBEF854", Offset = "0xBEF854", VA = "0xBEF854")]
	public void LoadPageRegion()
	{
	}

	// Token: 0x170000FE RID: 254
	// (get) Token: 0x06000B1C RID: 2844 RVA: 0x00006768 File Offset: 0x00004968
	[Token(Token = "0x170000FE")]
	public bool Collapsed
	{
		[Token(Token = "0x6000B1C")]
		[Address(RVA = "0xBEF990", Offset = "0xBEF990", VA = "0xBEF990")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000B1D RID: 2845 RVA: 0x00006780 File Offset: 0x00004980
	[Token(Token = "0x6000B1D")]
	[Address(RVA = "0xBEFA10", Offset = "0xBEFA10", VA = "0xBEFA10")]
	public int ReforgeCost()
	{
		return 0;
	}

	// Token: 0x06000B1E RID: 2846 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B1E")]
	[Address(RVA = "0xBEFA18", Offset = "0xBEFA18", VA = "0xBEFA18")]
	public void Reset()
	{
	}

	// Token: 0x06000B1F RID: 2847 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B1F")]
	[Address(RVA = "0xBEFADC", Offset = "0xBEFADC", VA = "0xBEFADC")]
	private void RefreshItems()
	{
	}

	// Token: 0x170000FF RID: 255
	// (get) Token: 0x06000B20 RID: 2848 RVA: 0x00006798 File Offset: 0x00004998
	[Token(Token = "0x170000FF")]
	public bool HasFocus
	{
		[Token(Token = "0x6000B20")]
		[Address(RVA = "0xBEFD60", Offset = "0xBEFD60", VA = "0xBEFD60")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000B21 RID: 2849 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B21")]
	[Address(RVA = "0xBEFF10", Offset = "0xBEFF10", VA = "0xBEFF10")]
	public void DrawResearch()
	{
	}

	// Token: 0x06000B22 RID: 2850 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B22")]
	[Address(RVA = "0xBF0704", Offset = "0xBF0704", VA = "0xBF0704")]
	public void Draw()
	{
	}

	// Token: 0x17000100 RID: 256
	// (get) Token: 0x06000B23 RID: 2851 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000100")]
	public Item ResearchItem
	{
		[Token(Token = "0x6000B23")]
		[Address(RVA = "0xBF05D4", Offset = "0xBF05D4", VA = "0xBF05D4")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000B24 RID: 2852 RVA: 0x000067B0 File Offset: 0x000049B0
	[Token(Token = "0x6000B24")]
	[Address(RVA = "0xBF0C38", Offset = "0xBF0C38", VA = "0xBF0C38")]
	public float ResearchItemScale(int index)
	{
		return 0f;
	}

	// Token: 0x06000B25 RID: 2853 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B25")]
	[Address(RVA = "0xBF0CA0", Offset = "0xBF0CA0", VA = "0xBF0CA0")]
	public void ResearchItemOver(int index)
	{
	}

	// Token: 0x06000B26 RID: 2854 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B26")]
	[Address(RVA = "0xBF1088", Offset = "0xBF1088", VA = "0xBF1088")]
	public void ResearchItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x06000B27 RID: 2855 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B27")]
	[Address(RVA = "0xBF1798", Offset = "0xBF1798", VA = "0xBF1798")]
	public GUIResearchPage()
	{
	}

	// Token: 0x04000D43 RID: 3395
	[Token(Token = "0x4000D43")]
	[FieldOffset(Offset = "0x8")]
	private float researchScale;

	// Token: 0x04000D44 RID: 3396
	[Token(Token = "0x4000D44")]
	[FieldOffset(Offset = "0xC")]
	private int refCost;

	// Token: 0x04000D45 RID: 3397
	[Token(Token = "0x4000D45")]
	[FieldOffset(Offset = "0x10")]
	public List<int> _researchItems;

	// Token: 0x04000D46 RID: 3398
	[Token(Token = "0x4000D46")]
	[FieldOffset(Offset = "0x14")]
	private Item _defaultItem;

	// Token: 0x04000D47 RID: 3399
	[Token(Token = "0x4000D47")]
	[FieldOffset(Offset = "0x18")]
	public int _selectedItem;

	// Token: 0x04000D48 RID: 3400
	[Token(Token = "0x4000D48")]
	[FieldOffset(Offset = "0x1C")]
	public float scrollOffset;

	// Token: 0x04000D49 RID: 3401
	[Token(Token = "0x4000D49")]
	[FieldOffset(Offset = "0x20")]
	private float scrollMomentum;

	// Token: 0x04000D4A RID: 3402
	[Token(Token = "0x4000D4A")]
	[FieldOffset(Offset = "0x24")]
	private int scrollDragging;

	// Token: 0x04000D4B RID: 3403
	[Token(Token = "0x4000D4B")]
	[FieldOffset(Offset = "0x28")]
	private Vector2 dragOffset;

	// Token: 0x04000D4C RID: 3404
	[Token(Token = "0x4000D4C")]
	[FieldOffset(Offset = "0x30")]
	private int cursorOver;

	// Token: 0x04000D4D RID: 3405
	[Token(Token = "0x4000D4D")]
	[FieldOffset(Offset = "0x34")]
	private float reforgeActionScale;
}
