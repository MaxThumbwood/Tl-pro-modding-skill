using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000114 RID: 276
[Token(Token = "0x2000114")]
public static class GUIAxis
{
	// Token: 0x0600071C RID: 1820 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600071C")]
	[Address(RVA = "0x128B1A0", Offset = "0x128B1A0", VA = "0x128B1A0")]
	public static void DrawAimAndUseIcon(Axis_Layout layout, Vector2 drawCentre)
	{
	}

	// Token: 0x0600071D RID: 1821 RVA: 0x00004D58 File Offset: 0x00002F58
	[Token(Token = "0x600071D")]
	[Address(RVA = "0x128B394", Offset = "0x128B394", VA = "0x128B394")]
	public static Rectangle BackingRegion(Axis_Layout layout)
	{
		return default(Rectangle);
	}

	// Token: 0x0600071E RID: 1822 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600071E")]
	[Address(RVA = "0x128B5D8", Offset = "0x128B5D8", VA = "0x128B5D8")]
	public static void Draw(Axis_Layout layout, Texture2D icon, ref Vector2 innerScreenOffset, ref Vector2 centre, bool active, bool useAlternativeInner = false, bool disabled = false, [Optional] Action drawBackgroundIcons)
	{
	}

	// Token: 0x0600071F RID: 1823 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600071F")]
	[Address(RVA = "0x128C4F0", Offset = "0x128C4F0", VA = "0x128C4F0")]
	public static void Draw(Axis_Layout layout, Texture2D icon, Rectangle srcRect, ref Vector2 innerScreenOffset, ref Vector2 centre, bool active, bool useAlternativeInner = false, bool disabled = false, int itemType = -1)
	{
	}

	// Token: 0x06000720 RID: 1824 RVA: 0x00004D70 File Offset: 0x00002F70
	[Token(Token = "0x6000720")]
	[Address(RVA = "0x128D864", Offset = "0x128D864", VA = "0x128D864")]
	public static bool RegisterPickingRegion(Axis_Layout layout)
	{
		return default(bool);
	}

	// Token: 0x06000721 RID: 1825 RVA: 0x00004D88 File Offset: 0x00002F88
	[Token(Token = "0x6000721")]
	[Address(RVA = "0x128DBFC", Offset = "0x128DBFC", VA = "0x128DBFC")]
	public static bool IsCursorOverExpanded(Vector2 position, Axis_Layout layout, out Vector2 screenOffset, out Vector2 axis, ref Vector2 centre, bool wasActive, ref float expandedSize, bool forceCursorInside = false, bool disableAxisRebalance = false)
	{
		return default(bool);
	}

	// Token: 0x06000722 RID: 1826 RVA: 0x00004DA0 File Offset: 0x00002FA0
	[Token(Token = "0x6000722")]
	[Address(RVA = "0x128E6D4", Offset = "0x128E6D4", VA = "0x128E6D4")]
	public static bool IsCursorOver(Vector2 position, Axis_Layout layout, out Vector2 screenOffset, out Vector2 axis, ref Vector2 centre, bool wasActive, bool forceCursorInside = false, bool disableAxisRebalance = false)
	{
		return default(bool);
	}

	// Token: 0x040007D9 RID: 2009
	[Token(Token = "0x40007D9")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float GlobalScale;

	// Token: 0x040007DA RID: 2010
	[Token(Token = "0x40007DA")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static bool DrawAimAndUse;
}
