using System;
using System.Text;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

// Token: 0x0200012C RID: 300
[Token(Token = "0x200012C")]
public static class GUIString
{
	// Token: 0x06000799 RID: 1945 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000799")]
	[Address(RVA = "0x1683868", Offset = "0x1683868", VA = "0x1683868")]
	public static void Draw(String_Layout layout, TextSnippet[] textSnippets, out int snippetSelected, float maxWidth = -1f, int maxLines = 100)
	{
	}

	// Token: 0x0600079A RID: 1946 RVA: 0x00005178 File Offset: 0x00003378
	[Token(Token = "0x600079A")]
	[Address(RVA = "0x1683B84", Offset = "0x1683B84", VA = "0x1683B84")]
	public static bool CanWrapAfter(char c)
	{
		return default(bool);
	}

	// Token: 0x0600079B RID: 1947 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600079B")]
	[Address(RVA = "0x1683BE4", Offset = "0x1683BE4", VA = "0x1683BE4")]
	public static string ApplyMultiLineAlignment(String_Layout layout, string value, out int lineCount)
	{
		return null;
	}

	// Token: 0x0600079C RID: 1948 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600079C")]
	[Address(RVA = "0x1684728", Offset = "0x1684728", VA = "0x1684728")]
	public static void Draw(String_Layout layout, string value, Color overloadedColour, bool multilineAlignmentApplied = false)
	{
	}

	// Token: 0x0600079D RID: 1949 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600079D")]
	[Address(RVA = "0x16852E0", Offset = "0x16852E0", VA = "0x16852E0")]
	public static void Draw(String_Layout layout, StringBuilder value, Color overloadedColour)
	{
	}

	// Token: 0x0600079E RID: 1950 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600079E")]
	[Address(RVA = "0x168552C", Offset = "0x168552C", VA = "0x168552C")]
	public static void DrawWithPanelBacking(String_Layout layout, StringBuilder value, Vector2 tlOffset, Vector2 brOffset, Panel_Layout backing)
	{
	}

	// Token: 0x0600079F RID: 1951 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600079F")]
	[Address(RVA = "0x168579C", Offset = "0x168579C", VA = "0x168579C")]
	public static void Draw(String_Layout layout, string value)
	{
	}

	// Token: 0x060007A0 RID: 1952 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007A0")]
	[Address(RVA = "0x1685828", Offset = "0x1685828", VA = "0x1685828")]
	public static void Draw(String_Layout layout, StringBuilder value)
	{
	}

	// Token: 0x060007A1 RID: 1953 RVA: 0x00005190 File Offset: 0x00003390
	[Token(Token = "0x60007A1")]
	[Address(RVA = "0x16858A8", Offset = "0x16858A8", VA = "0x16858A8")]
	public static Vector2 CalculateStringPosition(String_Layout layout, string value)
	{
		return default(Vector2);
	}

	// Token: 0x060007A2 RID: 1954 RVA: 0x000051A8 File Offset: 0x000033A8
	[Token(Token = "0x60007A2")]
	[Address(RVA = "0x1685B68", Offset = "0x1685B68", VA = "0x1685B68")]
	public static Rectangle GetRegion(String_Layout layout, string value)
	{
		return default(Rectangle);
	}

	// Token: 0x060007A3 RID: 1955 RVA: 0x000051C0 File Offset: 0x000033C0
	[Token(Token = "0x60007A3")]
	[Address(RVA = "0x1685F34", Offset = "0x1685F34", VA = "0x1685F34")]
	public static Rectangle GetRegion(StringButton_Layout layout, string value)
	{
		return default(Rectangle);
	}

	// Token: 0x060007A4 RID: 1956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007A4")]
	[Address(RVA = "0x1686158", Offset = "0x1686158", VA = "0x1686158")]
	public static void DrawWithShadow(String_Layout layout, string value, Vector2 position, Color overloadedColour)
	{
	}

	// Token: 0x060007A5 RID: 1957 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007A5")]
	[Address(RVA = "0x168629C", Offset = "0x168629C", VA = "0x168629C")]
	public static void DrawWithShadow(String_Layout layout, string value, Vector2 stringPosition)
	{
	}

	// Token: 0x060007A6 RID: 1958 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007A6")]
	[Address(RVA = "0x1686334", Offset = "0x1686334", VA = "0x1686334")]
	public static void DrawWithShadow(String_Layout layout, string value)
	{
	}

	// Token: 0x060007A7 RID: 1959 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007A7")]
	[Address(RVA = "0x16863DC", Offset = "0x16863DC", VA = "0x16863DC")]
	public static void DrawWithShadow(String_Layout layout, string value, bool calculatePosition, Color overloadedColour)
	{
	}

	// Token: 0x060007A8 RID: 1960 RVA: 0x000051D8 File Offset: 0x000033D8
	[Token(Token = "0x60007A8")]
	[Address(RVA = "0x1686534", Offset = "0x1686534", VA = "0x1686534")]
	public static bool DrawButton(String_Layout layout, string value, Color overloadedColour)
	{
		return default(bool);
	}

	// Token: 0x060007A9 RID: 1961 RVA: 0x000051F0 File Offset: 0x000033F0
	[Token(Token = "0x60007A9")]
	[Address(RVA = "0x168711C", Offset = "0x168711C", VA = "0x168711C")]
	public static bool DrawButton(String_Layout layout, string value)
	{
		return default(bool);
	}

	// Token: 0x04000856 RID: 2134
	[Token(Token = "0x4000856")]
	[FieldOffset(Offset = "0x0")]
	public static int MaxLastLineWidthInsertExraLine;
}
