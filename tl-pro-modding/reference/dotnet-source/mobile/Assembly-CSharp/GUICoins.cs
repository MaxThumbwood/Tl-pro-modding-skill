using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x02000143 RID: 323
[Token(Token = "0x2000143")]
public class GUICoins
{
	// Token: 0x06000891 RID: 2193 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000891")]
	[Address(RVA = "0x4DC858", Offset = "0x4DC858", VA = "0x4DC858")]
	public GUICoins()
	{
	}

	// Token: 0x06000892 RID: 2194 RVA: 0x00005838 File Offset: 0x00003A38
	[Token(Token = "0x6000892")]
	[Address(RVA = "0x4DC9DC", Offset = "0x4DC9DC", VA = "0x4DC9DC")]
	public Rectangle GetRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x06000893 RID: 2195 RVA: 0x00005850 File Offset: 0x00003A50
	[Token(Token = "0x6000893")]
	[Address(RVA = "0x4DCAC4", Offset = "0x4DCAC4", VA = "0x4DCAC4")]
	public float ItemScale(int index)
	{
		return 0f;
	}

	// Token: 0x06000894 RID: 2196 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000894")]
	[Address(RVA = "0x4DCB3C", Offset = "0x4DCB3C", VA = "0x4DCB3C")]
	public void ItemOver(int index)
	{
	}

	// Token: 0x06000895 RID: 2197 RVA: 0x00005868 File Offset: 0x00003A68
	[Token(Token = "0x6000895")]
	[Address(RVA = "0x4DE058", Offset = "0x4DE058", VA = "0x4DE058")]
	public bool CanBeStored(Item checkItem)
	{
		return default(bool);
	}

	// Token: 0x06000896 RID: 2198 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000896")]
	[Address(RVA = "0x4DE084", Offset = "0x4DE084", VA = "0x4DE084")]
	public void ItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x06000897 RID: 2199 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000897")]
	[Address(RVA = "0x4DF2A4", Offset = "0x4DF2A4", VA = "0x4DF2A4")]
	public void Draw()
	{
	}

	// Token: 0x0400096E RID: 2414
	[Token(Token = "0x400096E")]
	[FieldOffset(Offset = "0x8")]
	private int itemOver;

	// Token: 0x0400096F RID: 2415
	[Token(Token = "0x400096F")]
	[FieldOffset(Offset = "0xC")]
	private int cursorOver;

	// Token: 0x04000970 RID: 2416
	[Token(Token = "0x4000970")]
	[FieldOffset(Offset = "0x10")]
	private int itemDragStart;

	// Token: 0x04000971 RID: 2417
	[Token(Token = "0x4000971")]
	[FieldOffset(Offset = "0x14")]
	private int lastItemClicked;

	// Token: 0x04000972 RID: 2418
	[Token(Token = "0x4000972")]
	[FieldOffset(Offset = "0x18")]
	private float doubleClickTimer;

	// Token: 0x04000973 RID: 2419
	[Token(Token = "0x4000973")]
	[FieldOffset(Offset = "0x1C")]
	private bool rightClickHeld;

	// Token: 0x04000974 RID: 2420
	[Token(Token = "0x4000974")]
	[FieldOffset(Offset = "0x20")]
	public GUIItemGrid.GetItemScaleHandler ItemScaleDelegate;

	// Token: 0x04000975 RID: 2421
	[Token(Token = "0x4000975")]
	[FieldOffset(Offset = "0x24")]
	private GUIItemGrid.CursorOver ItemOverDelegate;

	// Token: 0x04000976 RID: 2422
	[Token(Token = "0x4000976")]
	[FieldOffset(Offset = "0x28")]
	private GUIItemGrid.DrawItemHandler itemDrawDelegate;
}
