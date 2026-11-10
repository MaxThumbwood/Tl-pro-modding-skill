using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000115 RID: 277
[Token(Token = "0x2000115")]
public static class GUIButton
{
	// Token: 0x170000BB RID: 187
	// (get) Token: 0x06000724 RID: 1828 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000BB")]
	public static SpriteBatch sb
	{
		[Token(Token = "0x6000724")]
		[Address(RVA = "0x128F154", Offset = "0x128F154", VA = "0x128F154")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000725 RID: 1829 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000725")]
	[Address(RVA = "0x128F228", Offset = "0x128F228", VA = "0x128F228")]
	public static void Draw(Button_Layout layout, Texture2D texture, [Optional] Color? overrideColor, [Optional] float? overrideScale)
	{
	}

	// Token: 0x06000726 RID: 1830 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000726")]
	[Address(RVA = "0x128F67C", Offset = "0x128F67C", VA = "0x128F67C")]
	public static void DrawAtPosition(Button_Layout layout, Vector2 position, Texture2D texture, [Optional] Color? overrideColor, [Optional] float? overrideScale)
	{
	}

	// Token: 0x06000727 RID: 1831 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000727")]
	[Address(RVA = "0x128FA6C", Offset = "0x128FA6C", VA = "0x128FA6C")]
	public static void DrawAtPosition(Button_Layout layout, Vector2 position, Rectangle srcRect, Texture2D texture, [Optional] Color? overrideColor, [Optional] float? overrideScale)
	{
	}

	// Token: 0x06000728 RID: 1832 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000728")]
	[Address(RVA = "0x128FE84", Offset = "0x128FE84", VA = "0x128FE84")]
	public static void Draw(Button_Layout layout, Rectangle srcRect, Texture2D texture, [Optional] Color? overrideColor, [Optional] float? overrideScale)
	{
	}

	// Token: 0x06000729 RID: 1833 RVA: 0x00004DB8 File Offset: 0x00002FB8
	[Token(Token = "0x6000729")]
	[Address(RVA = "0x1290324", Offset = "0x1290324", VA = "0x1290324")]
	public static Rectangle GetRegionWithoutPicking(Button_Layout layout, Texture2D texture)
	{
		return default(Rectangle);
	}

	// Token: 0x0600072A RID: 1834 RVA: 0x00004DD0 File Offset: 0x00002FD0
	[Token(Token = "0x600072A")]
	[Address(RVA = "0x12905BC", Offset = "0x12905BC", VA = "0x12905BC")]
	public static Rectangle GetRegion(Button_Layout layout, Texture2D texture)
	{
		return default(Rectangle);
	}

	// Token: 0x0600072B RID: 1835 RVA: 0x00004DE8 File Offset: 0x00002FE8
	[Token(Token = "0x600072B")]
	[Address(RVA = "0x12908A0", Offset = "0x12908A0", VA = "0x12908A0")]
	public static Rectangle GetRegion(Button_Layout layout, Texture2D texture, Rectangle textureRegion)
	{
		return default(Rectangle);
	}

	// Token: 0x0600072C RID: 1836 RVA: 0x00004E00 File Offset: 0x00003000
	[Token(Token = "0x600072C")]
	[Address(RVA = "0x1290B90", Offset = "0x1290B90", VA = "0x1290B90")]
	public static bool RegisterPickingRegion(Button_Layout layout, Texture2D texture, Rectangle textureRegion)
	{
		return default(bool);
	}

	// Token: 0x0600072D RID: 1837 RVA: 0x00004E18 File Offset: 0x00003018
	[Token(Token = "0x600072D")]
	[Address(RVA = "0x1291028", Offset = "0x1291028", VA = "0x1291028")]
	public static bool RegisterPickingRegion(Button_Layout layout, Texture2D texture)
	{
		return default(bool);
	}

	// Token: 0x0600072E RID: 1838 RVA: 0x00004E30 File Offset: 0x00003030
	[Token(Token = "0x600072E")]
	[Address(RVA = "0x12914C0", Offset = "0x12914C0", VA = "0x12914C0")]
	public static bool IsCursorOverAtPosition(Vector2 position, Button_Layout layout, Vector2 controlPosition, Texture2D texture)
	{
		return default(bool);
	}

	// Token: 0x0600072F RID: 1839 RVA: 0x00004E48 File Offset: 0x00003048
	[Token(Token = "0x600072F")]
	[Address(RVA = "0x12917D0", Offset = "0x12917D0", VA = "0x12917D0")]
	public static bool IsCursorOverExpanded(Vector2 position, Button_Layout layout, Texture2D texture, ref float expanded)
	{
		return default(bool);
	}

	// Token: 0x06000730 RID: 1840 RVA: 0x00004E60 File Offset: 0x00003060
	[Token(Token = "0x6000730")]
	[Address(RVA = "0x1291C9C", Offset = "0x1291C9C", VA = "0x1291C9C")]
	public static bool IsCursorOver(Vector2 position, Button_Layout layout, Texture2D texture)
	{
		return default(bool);
	}

	// Token: 0x040007DB RID: 2011
	[Token(Token = "0x40007DB")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float GlobalScale;

	// Token: 0x040007DC RID: 2012
	[Token(Token = "0x40007DC")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static SpriteBatch overloadedSpriteBatch;
}
