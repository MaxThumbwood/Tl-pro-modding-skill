using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200011B RID: 283
[Token(Token = "0x200011B")]
public static class GUIDraggableItemGrid
{
	// Token: 0x06000738 RID: 1848 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000738")]
	[Address(RVA = "0x12931A4", Offset = "0x12931A4", VA = "0x12931A4")]
	private static void SetSizeClippedDrawItemHandler(ItemGrid_Layout gridLayout, int itemIndex, Vector2 position, float scale)
	{
	}

	// Token: 0x06000739 RID: 1849 RVA: 0x00004E90 File Offset: 0x00003090
	[Token(Token = "0x6000739")]
	[Address(RVA = "0x1293B3C", Offset = "0x1293B3C", VA = "0x1293B3C")]
	public static bool LineClipCheck(ItemGrid_Layout gridLayout, Vector2 position, float scale)
	{
		return default(bool);
	}

	// Token: 0x0600073A RID: 1850 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600073A")]
	[Address(RVA = "0x129330C", Offset = "0x129330C", VA = "0x129330C")]
	private static void ClippedDrawItemHandler(ItemGrid_Layout gridLayout, int itemIndex, Vector2 position, float scale)
	{
	}

	// Token: 0x0600073B RID: 1851 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600073B")]
	[Address(RVA = "0x1293D88", Offset = "0x1293D88", VA = "0x1293D88")]
	public static void Draw(DraggableItemGrid_Layout gridLayout, GUIItemGrid.GetItemScaleHandler scaleHandler, GUIItemGrid.CursorOver cursorOverHandler, GUIItemGrid.DrawItemHandler drawhandler, int itemCount, ref float scrollOffset, ref float momentum, ref int draggingState, ref Vector2 dragPosition, [Optional] Texture2D overloadBackingTexture, bool drawMissingItems = false, bool allowMouseScroll = false, bool disableDragScroll = false)
	{
	}

	// Token: 0x0600073C RID: 1852 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600073C")]
	[Address(RVA = "0x1293EDC", Offset = "0x1293EDC", VA = "0x1293EDC")]
	public static void Draw(DraggableItemGrid_Layout gridLayout, GUIItemGrid.GetItemScaleHandler scaleHandler, GUIItemGrid.CursorOver cursorOverHandler, GUIItemGrid.DrawItemHandler drawhandler, int itemCount, ref float scrollOffset, ref float momentum, ref int draggingState, ref Vector2 dragPosition, Vector2 itemSize, bool drawMissingItems = false, bool allowMouseScroll = false, bool disableDragScroll = false)
	{
	}

	// Token: 0x0600073D RID: 1853 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600073D")]
	[Address(RVA = "0x1296FA0", Offset = "0x1296FA0", VA = "0x1296FA0")]
	public static void Draw(DraggableItemGrid_Layout gridLayout, GUIItemGrid.GetItemScaleHandler scaleHandler, GUIItemGrid.CursorOver cursorOverHandler, GUIItemGrid.DrawItemHandler drawhandler, int itemCount, ref float scrollOffset, ref float momentum, ref int draggingState, ref Vector2 dragPosition, GUIItemGrid.GetItemSizeHandler itemSizeHandler, bool drawMissingItems = false, bool allowMouseScroll = false, bool disableDragScroll = false)
	{
	}

	// Token: 0x04000809 RID: 2057
	[Token(Token = "0x4000809")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Rectangle dragRegion;

	// Token: 0x0400080A RID: 2058
	[Token(Token = "0x400080A")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static Rectangle fullRegion;

	// Token: 0x0400080B RID: 2059
	[Token(Token = "0x400080B")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static Vector2 drawOffset;

	// Token: 0x0400080C RID: 2060
	[Token(Token = "0x400080C")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static float itemWidth;

	// Token: 0x0400080D RID: 2061
	[Token(Token = "0x400080D")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private static float itemHeight;

	// Token: 0x0400080E RID: 2062
	[Token(Token = "0x400080E")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static float orgScrollOffset;

	// Token: 0x0400080F RID: 2063
	[Token(Token = "0x400080F")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private static GUIItemGrid.CursorOver _overHandler;

	// Token: 0x04000810 RID: 2064
	[Token(Token = "0x4000810")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static GUIItemGrid.DrawItemHandler _drawhandler;

	// Token: 0x04000811 RID: 2065
	[Token(Token = "0x4000811")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private static GUIItemGrid.GetItemSizeHandler _sizehandler;

	// Token: 0x04000812 RID: 2066
	[Token(Token = "0x4000812")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static GUIItemGrid.DrawItemHandler SetSizeClippedDrawItem;

	// Token: 0x04000813 RID: 2067
	[Token(Token = "0x4000813")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private static GUIItemGrid.DrawItemHandler ClippedDrawItem;

	// Token: 0x0200011C RID: 284
	// (Invoke) Token: 0x06000740 RID: 1856
	[Token(Token = "0x200011C")]
	public delegate void DrawItemClippedHandler(ItemGrid_Layout gridLayout, int itemIndex, Vector2 position, float scale, Rectangle inner, Rectangle outer);
}
