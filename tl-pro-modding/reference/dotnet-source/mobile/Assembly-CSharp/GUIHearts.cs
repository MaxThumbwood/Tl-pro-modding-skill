using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x02000159 RID: 345
[Token(Token = "0x2000159")]
public class GUIHearts
{
	// Token: 0x06000998 RID: 2456 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000998")]
	[Address(RVA = "0x90C9B0", Offset = "0x90C9B0", VA = "0x90C9B0")]
	public GUIHearts()
	{
	}

	// Token: 0x170000D2 RID: 210
	// (get) Token: 0x06000999 RID: 2457 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000D2")]
	public ItemGrid_Layout HeartsGrid
	{
		[Token(Token = "0x6000999")]
		[Address(RVA = "0x90CCAC", Offset = "0x90CCAC", VA = "0x90CCAC")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600099A RID: 2458 RVA: 0x00005EF8 File Offset: 0x000040F8
	[Token(Token = "0x600099A")]
	[Address(RVA = "0x90CD50", Offset = "0x90CD50", VA = "0x90CD50")]
	public Rectangle GetHeartsRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x0600099B RID: 2459 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600099B")]
	[Address(RVA = "0x90D294", Offset = "0x90D294", VA = "0x90D294")]
	private void DrawLifeString()
	{
	}

	// Token: 0x0600099C RID: 2460 RVA: 0x00005F10 File Offset: 0x00004110
	[Token(Token = "0x600099C")]
	[Address(RVA = "0x90D90C", Offset = "0x90D90C", VA = "0x90D90C")]
	private float HeartScale(int index)
	{
		return 0f;
	}

	// Token: 0x0600099D RID: 2461 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600099D")]
	[Address(RVA = "0x90D974", Offset = "0x90D974", VA = "0x90D974")]
	private void HeartOver(int index)
	{
	}

	// Token: 0x0600099E RID: 2462 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600099E")]
	[Address(RVA = "0x90DC78", Offset = "0x90DC78", VA = "0x90DC78")]
	private void HeartDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x0600099F RID: 2463 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600099F")]
	[Address(RVA = "0x90D094", Offset = "0x90D094", VA = "0x90D094")]
	private void AdjustForTouchReturn(ItemGrid_Layout grid)
	{
	}

	// Token: 0x060009A0 RID: 2464 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A0")]
	[Address(RVA = "0x90D194", Offset = "0x90D194", VA = "0x90D194")]
	private void RestoreForTouchButton(ItemGrid_Layout grid)
	{
	}

	// Token: 0x060009A1 RID: 2465 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A1")]
	[Address(RVA = "0x90EDA8", Offset = "0x90EDA8", VA = "0x90EDA8")]
	public void Draw()
	{
	}

	// Token: 0x04000AB1 RID: 2737
	[Token(Token = "0x4000AB1")]
	[FieldOffset(Offset = "0x8")]
	public GUIHearts.ResourceSet ActiveSet;

	// Token: 0x04000AB2 RID: 2738
	[Token(Token = "0x4000AB2")]
	[FieldOffset(Offset = "0xC")]
	private float heartLife;

	// Token: 0x04000AB3 RID: 2739
	[Token(Token = "0x4000AB3")]
	[FieldOffset(Offset = "0x10")]
	private int heartCountOriginal;

	// Token: 0x04000AB4 RID: 2740
	[Token(Token = "0x4000AB4")]
	[FieldOffset(Offset = "0x14")]
	private int heartCount;

	// Token: 0x04000AB5 RID: 2741
	[Token(Token = "0x4000AB5")]
	[FieldOffset(Offset = "0x18")]
	private int fruitHearts;

	// Token: 0x04000AB6 RID: 2742
	[Token(Token = "0x4000AB6")]
	[FieldOffset(Offset = "0x1C")]
	private int lastHeartCount;

	// Token: 0x04000AB7 RID: 2743
	[Token(Token = "0x4000AB7")]
	[FieldOffset(Offset = "0x20")]
	private CachedGridLayoutSettings LayoutCache;

	// Token: 0x04000AB8 RID: 2744
	[Token(Token = "0x4000AB8")]
	[FieldOffset(Offset = "0x24")]
	private Vector2 lastAnchorPoint;

	// Token: 0x04000AB9 RID: 2745
	[Token(Token = "0x4000AB9")]
	[FieldOffset(Offset = "0x2C")]
	private Rectangle HeartsRegion;

	// Token: 0x04000ABA RID: 2746
	[Token(Token = "0x4000ABA")]
	[FieldOffset(Offset = "0x3C")]
	private Vector2 heartBackingSingleOffset;

	// Token: 0x04000ABB RID: 2747
	[Token(Token = "0x4000ABB")]
	[FieldOffset(Offset = "0x44")]
	private Vector2 heartBackingLeftOffset;

	// Token: 0x04000ABC RID: 2748
	[Token(Token = "0x4000ABC")]
	[FieldOffset(Offset = "0x4C")]
	private Vector2 heartBackingRightOffset;

	// Token: 0x04000ABD RID: 2749
	[Token(Token = "0x4000ABD")]
	[FieldOffset(Offset = "0x54")]
	private Vector2 heartBackingRightFancyOffset;

	// Token: 0x04000ABE RID: 2750
	[Token(Token = "0x4000ABE")]
	[FieldOffset(Offset = "0x5C")]
	private Vector2 heartBackingMidOffset;

	// Token: 0x04000ABF RID: 2751
	[Token(Token = "0x4000ABF")]
	[FieldOffset(Offset = "0x64")]
	private Vector2 heartBackingLeftBarOffset;

	// Token: 0x04000AC0 RID: 2752
	[Token(Token = "0x4000AC0")]
	[FieldOffset(Offset = "0x6C")]
	private Vector2 heartBackingMidBarOffset;

	// Token: 0x04000AC1 RID: 2753
	[Token(Token = "0x4000AC1")]
	[FieldOffset(Offset = "0x74")]
	private Vector2 heartBackingRightBarOffset;

	// Token: 0x04000AC2 RID: 2754
	[Token(Token = "0x4000AC2")]
	[FieldOffset(Offset = "0x7C")]
	private float TimeSinceChange;

	// Token: 0x04000AC3 RID: 2755
	[Token(Token = "0x4000AC3")]
	[FieldOffset(Offset = "0x80")]
	private int LastValue;

	// Token: 0x04000AC4 RID: 2756
	[Token(Token = "0x4000AC4")]
	[FieldOffset(Offset = "0x84")]
	private GUIItemGrid.GetItemScaleHandler heartScale;

	// Token: 0x04000AC5 RID: 2757
	[Token(Token = "0x4000AC5")]
	[FieldOffset(Offset = "0x88")]
	private GUIItemGrid.CursorOver heartOver;

	// Token: 0x04000AC6 RID: 2758
	[Token(Token = "0x4000AC6")]
	[FieldOffset(Offset = "0x8C")]
	private GUIItemGrid.DrawItemHandler heartDraw;

	// Token: 0x0200015A RID: 346
	[Token(Token = "0x200015A")]
	public enum ResourceSet
	{
		// Token: 0x04000AC8 RID: 2760
		[Token(Token = "0x4000AC8")]
		Default,
		// Token: 0x04000AC9 RID: 2761
		[Token(Token = "0x4000AC9")]
		New,
		// Token: 0x04000ACA RID: 2762
		[Token(Token = "0x4000ACA")]
		HorizontalBars
	}
}
