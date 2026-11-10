using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200011E RID: 286
[Token(Token = "0x200011E")]
public static class GUIItemGrid
{
	// Token: 0x06000747 RID: 1863 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000747")]
	[Address(RVA = "0x129980C", Offset = "0x129980C", VA = "0x129980C")]
	private static void DummyDraw(ItemGrid_Layout gridLayout, int itemIndex, Vector2 position, float scale)
	{
	}

	// Token: 0x06000748 RID: 1864 RVA: 0x00004EA8 File Offset: 0x000030A8
	[Token(Token = "0x6000748")]
	[Address(RVA = "0x1295308", Offset = "0x1295308", VA = "0x1295308")]
	public static Rectangle CalculateRegion(ItemGrid_Layout gridLayout, GUIItemGrid.GetItemScaleHandler scaleHandler, Vector2 itemSize, int overloadedItemCount = -1)
	{
		return default(Rectangle);
	}

	// Token: 0x06000749 RID: 1865 RVA: 0x00004EC0 File Offset: 0x000030C0
	[Token(Token = "0x6000749")]
	[Address(RVA = "0x1299B30", Offset = "0x1299B30", VA = "0x1299B30")]
	public static Rectangle CalculateRegion(ItemGrid_Layout gridLayout, GUIItemGrid.GetItemScaleHandler scaleHandler, int overloadedItemCount = -1, [Optional] Texture2D overloadBackingTexture)
	{
		return default(Rectangle);
	}

	// Token: 0x0600074A RID: 1866 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600074A")]
	[Address(RVA = "0x1299D14", Offset = "0x1299D14", VA = "0x1299D14")]
	public static void Draw(ItemGrid_Layout gridLayout, GUIItemGrid.GetItemScaleHandler scaleHandler, GUIItemGrid.CursorOver cursorOverHandler, GUIItemGrid.DrawItemHandler drawhandler, int overloadedItemCount = -1, [Optional] Texture2D overloadBackingTexture)
	{
	}

	// Token: 0x0600074B RID: 1867 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600074B")]
	[Address(RVA = "0x12981D4", Offset = "0x12981D4", VA = "0x12981D4")]
	public static void Draw(ItemGrid_Layout gridLayout, GUIItemGrid.GetItemScaleHandler scaleHandler, GUIItemGrid.CursorOver cursorOverHandler, GUIItemGrid.DrawItemHandler drawhandler, GUIItemGrid.GetItemSizeHandler itemSizeHandler, int overloadedItemCount = -1, int reverseOrverOffset = 0, int maxRowSize = -1, int maxRowSizeLineCount = 1)
	{
	}

	// Token: 0x0600074C RID: 1868 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600074C")]
	[Address(RVA = "0x1295418", Offset = "0x1295418", VA = "0x1295418")]
	public static void Draw(ItemGrid_Layout gridLayout, GUIItemGrid.GetItemScaleHandler scaleHandler, GUIItemGrid.CursorOver cursorOverHandler, GUIItemGrid.DrawItemHandler drawhandler, Vector2 itemSize, int overloadedItemCount = -1)
	{
	}

	// Token: 0x04000814 RID: 2068
	[Token(Token = "0x4000814")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool disablePickingCallbacks;

	// Token: 0x04000815 RID: 2069
	[Token(Token = "0x4000815")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static Rectangle calculatedRegion;

	// Token: 0x04000816 RID: 2070
	[Token(Token = "0x4000816")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private static int calcBackingWidth;

	// Token: 0x04000817 RID: 2071
	[Token(Token = "0x4000817")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static int calcBackingHeight;

	// Token: 0x04000818 RID: 2072
	[Token(Token = "0x4000818")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private static bool calcRegionInitialised;

	// Token: 0x04000819 RID: 2073
	[Token(Token = "0x4000819")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static GUIItemGrid.DrawItemHandler dummyDraw;

	// Token: 0x0400081A RID: 2074
	[Token(Token = "0x400081A")]
	private const float DefaultTextureSize = 52f;

	// Token: 0x0200011F RID: 287
	// (Invoke) Token: 0x0600074F RID: 1871
	[Token(Token = "0x200011F")]
	public delegate void CursorOver(int itemIndex);

	// Token: 0x02000120 RID: 288
	// (Invoke) Token: 0x06000753 RID: 1875
	[Token(Token = "0x2000120")]
	public delegate float GetItemScaleHandler(int itemIndex);

	// Token: 0x02000121 RID: 289
	// (Invoke) Token: 0x06000757 RID: 1879
	[Token(Token = "0x2000121")]
	public delegate void DrawItemHandler(ItemGrid_Layout gridLayout, int itemIndex, Vector2 position, float scale);

	// Token: 0x02000122 RID: 290
	// (Invoke) Token: 0x0600075B RID: 1883
	[Token(Token = "0x2000122")]
	public delegate Vector2 GetItemSizeHandler(int itemIndex);
}
