using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x02000167 RID: 359
[Token(Token = "0x2000167")]
public class GUIMana
{
	// Token: 0x06000A1F RID: 2591 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A1F")]
	[Address(RVA = "0xACA228", Offset = "0xACA228", VA = "0xACA228")]
	public GUIMana()
	{
	}

	// Token: 0x170000DD RID: 221
	// (get) Token: 0x06000A20 RID: 2592 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000DD")]
	public ItemGrid_Layout ManaGrid
	{
		[Token(Token = "0x6000A20")]
		[Address(RVA = "0xACA51C", Offset = "0xACA51C", VA = "0xACA51C")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000DE RID: 222
	// (get) Token: 0x06000A21 RID: 2593 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000DE")]
	public String_Layout ManaTitle
	{
		[Token(Token = "0x6000A21")]
		[Address(RVA = "0xACA614", Offset = "0xACA614", VA = "0xACA614")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000DF RID: 223
	// (get) Token: 0x06000A22 RID: 2594 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000DF")]
	public String_Layout ManaValue
	{
		[Token(Token = "0x6000A22")]
		[Address(RVA = "0xACA800", Offset = "0xACA800", VA = "0xACA800")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000A23 RID: 2595 RVA: 0x00006168 File Offset: 0x00004368
	[Token(Token = "0x6000A23")]
	[Address(RVA = "0xACA9EC", Offset = "0xACA9EC", VA = "0xACA9EC")]
	public Rectangle GetManaRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x06000A24 RID: 2596 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A24")]
	[Address(RVA = "0xACAC48", Offset = "0xACAC48", VA = "0xACAC48")]
	private void AdjustForTouchReturn(ItemGrid_Layout grid)
	{
	}

	// Token: 0x06000A25 RID: 2597 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A25")]
	[Address(RVA = "0xACAD60", Offset = "0xACAD60", VA = "0xACAD60")]
	private void RestoreForTouchButton(ItemGrid_Layout grid)
	{
	}

	// Token: 0x06000A26 RID: 2598 RVA: 0x00006180 File Offset: 0x00004380
	[Token(Token = "0x6000A26")]
	[Address(RVA = "0xACAE78", Offset = "0xACAE78", VA = "0xACAE78")]
	private float StarScale(int index)
	{
		return 0f;
	}

	// Token: 0x06000A27 RID: 2599 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A27")]
	[Address(RVA = "0xACAEE0", Offset = "0xACAEE0", VA = "0xACAEE0")]
	private void StarOver(int index)
	{
	}

	// Token: 0x06000A28 RID: 2600 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A28")]
	[Address(RVA = "0xACB1E0", Offset = "0xACB1E0", VA = "0xACB1E0")]
	private void StarDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x06000A29 RID: 2601 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A29")]
	[Address(RVA = "0xACC618", Offset = "0xACC618", VA = "0xACC618")]
	public void Draw()
	{
	}

	// Token: 0x04000C21 RID: 3105
	[Token(Token = "0x4000C21")]
	[FieldOffset(Offset = "0x8")]
	private int starMana;

	// Token: 0x04000C22 RID: 3106
	[Token(Token = "0x4000C22")]
	[FieldOffset(Offset = "0xC")]
	private int starCount;

	// Token: 0x04000C23 RID: 3107
	[Token(Token = "0x4000C23")]
	[FieldOffset(Offset = "0x10")]
	private int lastStarCount;

	// Token: 0x04000C24 RID: 3108
	[Token(Token = "0x4000C24")]
	[FieldOffset(Offset = "0x14")]
	private CachedGridLayoutSettings LayoutCache;

	// Token: 0x04000C25 RID: 3109
	[Token(Token = "0x4000C25")]
	[FieldOffset(Offset = "0x18")]
	private Rectangle StarsRegion;

	// Token: 0x04000C26 RID: 3110
	[Token(Token = "0x4000C26")]
	[FieldOffset(Offset = "0x28")]
	private Vector2 lastAnchorPoint;

	// Token: 0x04000C27 RID: 3111
	[Token(Token = "0x4000C27")]
	[FieldOffset(Offset = "0x30")]
	private Vector2 manaBackingSingleOffset;

	// Token: 0x04000C28 RID: 3112
	[Token(Token = "0x4000C28")]
	[FieldOffset(Offset = "0x38")]
	private Vector2 manaBackingTopOffset;

	// Token: 0x04000C29 RID: 3113
	[Token(Token = "0x4000C29")]
	[FieldOffset(Offset = "0x40")]
	private Vector2 manaBackingBottomOffset;

	// Token: 0x04000C2A RID: 3114
	[Token(Token = "0x4000C2A")]
	[FieldOffset(Offset = "0x48")]
	private Vector2 manaBackingMidOffset;

	// Token: 0x04000C2B RID: 3115
	[Token(Token = "0x4000C2B")]
	[FieldOffset(Offset = "0x50")]
	private Vector2 manaBackingLeftBarOffset;

	// Token: 0x04000C2C RID: 3116
	[Token(Token = "0x4000C2C")]
	[FieldOffset(Offset = "0x58")]
	private Vector2 manaBackingMidBarOffset;

	// Token: 0x04000C2D RID: 3117
	[Token(Token = "0x4000C2D")]
	[FieldOffset(Offset = "0x60")]
	private Vector2 manaBackingRightBarOffset;

	// Token: 0x04000C2E RID: 3118
	[Token(Token = "0x4000C2E")]
	[FieldOffset(Offset = "0x68")]
	private GUIItemGrid.CursorOver starOver;

	// Token: 0x04000C2F RID: 3119
	[Token(Token = "0x4000C2F")]
	[FieldOffset(Offset = "0x6C")]
	private GUIItemGrid.GetItemScaleHandler starScale;

	// Token: 0x04000C30 RID: 3120
	[Token(Token = "0x4000C30")]
	[FieldOffset(Offset = "0x70")]
	private GUIItemGrid.DrawItemHandler starDraw;

	// Token: 0x04000C31 RID: 3121
	[Token(Token = "0x4000C31")]
	[FieldOffset(Offset = "0x74")]
	private float TimeSinceChange;

	// Token: 0x04000C32 RID: 3122
	[Token(Token = "0x4000C32")]
	[FieldOffset(Offset = "0x78")]
	private int LastValue;
}
