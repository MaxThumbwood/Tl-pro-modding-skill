using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000123 RID: 291
[Token(Token = "0x2000123")]
public static class GUIPanel
{
	// Token: 0x0600075E RID: 1886 RVA: 0x00004ED8 File Offset: 0x000030D8
	[Token(Token = "0x600075E")]
	[Address(RVA = "0x129A51C", Offset = "0x129A51C", VA = "0x129A51C")]
	public static bool IsCursorOver(Vector2 cursorUIPosition, Panel_Layout layout)
	{
		return default(bool);
	}

	// Token: 0x0600075F RID: 1887 RVA: 0x00004EF0 File Offset: 0x000030F0
	[Token(Token = "0x600075F")]
	[Address(RVA = "0x129A778", Offset = "0x129A778", VA = "0x129A778")]
	public static bool RegisterPickingRegion(Panel_Layout layout)
	{
		return default(bool);
	}

	// Token: 0x06000760 RID: 1888 RVA: 0x00004F08 File Offset: 0x00003108
	[Token(Token = "0x6000760")]
	[Address(RVA = "0x129A9D4", Offset = "0x129A9D4", VA = "0x129A9D4")]
	public static Rectangle Region(Panel_Layout layout)
	{
		return default(Rectangle);
	}

	// Token: 0x06000761 RID: 1889 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000761")]
	[Address(RVA = "0x129AC28", Offset = "0x129AC28", VA = "0x129AC28")]
	public static void DrawWedge(Panel_Layout layout, Vector2 direction, float wedgeAngle, Color col)
	{
	}

	// Token: 0x06000762 RID: 1890 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000762")]
	[Address(RVA = "0x129B238", Offset = "0x129B238", VA = "0x129B238")]
	public static void DrawImage(Panel_Layout layout, Texture2D srcTexture, Rectangle srcRegion)
	{
	}

	// Token: 0x06000763 RID: 1891 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000763")]
	[Address(RVA = "0x129B500", Offset = "0x129B500", VA = "0x129B500")]
	public static void Draw(Panel_Layout layout, bool cursorOver = false, [Optional] Color? overloadBacking, [Optional] Color? overloadBorder, [Optional] Color? overloadHighlight)
	{
	}

	// Token: 0x06000764 RID: 1892 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000764")]
	[Address(RVA = "0x129B8B8", Offset = "0x129B8B8", VA = "0x129B8B8")]
	public static void DrawAtPosition(Panel_Layout layout, Vector2 position, Vector2 size, bool cursorOver = false)
	{
	}

	// Token: 0x06000765 RID: 1893 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000765")]
	[Address(RVA = "0x129BA00", Offset = "0x129BA00", VA = "0x129BA00")]
	public static void DrawHorizontalFill(Panel_Layout layout, Rectangle backgroundFillRegion, float fillScale)
	{
	}

	// Token: 0x06000766 RID: 1894 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000766")]
	[Address(RVA = "0x1289318", Offset = "0x1289318", VA = "0x1289318")]
	public static void DrawBacking(Vector2 position, Vector2 size, Texture2D texture, Color color, [Optional] Rectangle? sourceFrame)
	{
	}

	// Token: 0x0400081B RID: 2075
	[Token(Token = "0x400081B")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool forceRescale;

	// Token: 0x0400081C RID: 2076
	[Token(Token = "0x400081C")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x1")]
	public static bool scaleEdges;

	// Token: 0x0400081D RID: 2077
	[Token(Token = "0x400081D")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static SpriteBatch overloadBatch;
}
