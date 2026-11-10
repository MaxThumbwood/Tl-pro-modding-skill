using System;
using Controller;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

// Token: 0x0200012E RID: 302
[Token(Token = "0x200012E")]
public static class GUITransactionButton
{
	// Token: 0x060007AE RID: 1966 RVA: 0x00005250 File Offset: 0x00003450
	[Token(Token = "0x60007AE")]
	[Address(RVA = "0x19D6388", Offset = "0x19D6388", VA = "0x19D6388")]
	public static Rectangle GetRegion(TransactionButton_Layout layout)
	{
		return default(Rectangle);
	}

	// Token: 0x060007AF RID: 1967 RVA: 0x00005268 File Offset: 0x00003468
	[Token(Token = "0x60007AF")]
	[Address(RVA = "0x19D65C8", Offset = "0x19D65C8", VA = "0x19D65C8")]
	public static Rectangle GetPickRegion(TransactionButton_Layout layout)
	{
		return default(Rectangle);
	}

	// Token: 0x060007B0 RID: 1968 RVA: 0x00005280 File Offset: 0x00003480
	[Token(Token = "0x60007B0")]
	[Address(RVA = "0x19D68E0", Offset = "0x19D68E0", VA = "0x19D68E0")]
	public static Rectangle GetVisualRegion(TransactionButton_Layout layout)
	{
		return default(Rectangle);
	}

	// Token: 0x060007B1 RID: 1969 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B1")]
	[Address(RVA = "0x19D6B20", Offset = "0x19D6B20", VA = "0x19D6B20")]
	private static void DrawBacking(TransactionButton_Layout layout, Texture2D backing, Texture2D additionalBacking, Color backingColour, Color additionalbackingColour, Texture2D border, Color borderColour, float scale, bool over)
	{
	}

	// Token: 0x060007B2 RID: 1970 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B2")]
	[Address(RVA = "0x19D783C", Offset = "0x19D783C", VA = "0x19D783C")]
	private static void DrawControlIcon(TransactionButton_Layout layout, Texture2D backing, Color iconColour, float scale, bool hasControllerFocus)
	{
	}

	// Token: 0x060007B3 RID: 1971 RVA: 0x00005298 File Offset: 0x00003498
	[Token(Token = "0x60007B3")]
	[Address(RVA = "0x19D7B88", Offset = "0x19D7B88", VA = "0x19D7B88")]
	public static GUITransactionButton.InputState DrawWithBanner(TransactionButton_Layout layout, ControllerActionButton action, GUITransactionButton.DrawItemHandler itemHandler, Vector2 itemSize, string label, bool disabled, ref float scale, bool forcePressed = false, bool hasControllerFocus = false, bool forceOver = false, bool disablePressedState = false, bool drawWhenControllerConnected = false)
	{
		return GUITransactionButton.InputState.Clicked;
	}

	// Token: 0x060007B4 RID: 1972 RVA: 0x000052B0 File Offset: 0x000034B0
	[Token(Token = "0x60007B4")]
	[Address(RVA = "0x19D8424", Offset = "0x19D8424", VA = "0x19D8424")]
	public static GUITransactionButton.InputState Draw(TransactionButton_Layout layout, GUITransactionButton.DrawItemHandler itemHandler, Vector2 itemSize, string label, bool disabled, ref float scale, bool forcePressed = false, bool hasControllerFocus = false, bool forceOver = false, bool disablePressedState = false)
	{
		return GUITransactionButton.InputState.Clicked;
	}

	// Token: 0x060007B5 RID: 1973 RVA: 0x000052C8 File Offset: 0x000034C8
	[Token(Token = "0x60007B5")]
	[Address(RVA = "0x19D66C4", Offset = "0x19D66C4", VA = "0x19D66C4")]
	public static Rectangle GetOverloadedPickingRegion(TransactionButton_Layout layout, float scale)
	{
		return default(Rectangle);
	}

	// Token: 0x060007B6 RID: 1974 RVA: 0x000052E0 File Offset: 0x000034E0
	[Token(Token = "0x60007B6")]
	[Address(RVA = "0x19D9608", Offset = "0x19D9608", VA = "0x19D9608")]
	public static Rectangle LoadButtonRegion(TransactionButton_Layout layout, float scale)
	{
		return default(Rectangle);
	}

	// Token: 0x060007B7 RID: 1975 RVA: 0x000052F8 File Offset: 0x000034F8
	[Token(Token = "0x60007B7")]
	[Address(RVA = "0x19D9C0C", Offset = "0x19D9C0C", VA = "0x19D9C0C")]
	public static GUITransactionButton.InputState DrawWithBanner(TransactionButton_Layout layout, ControllerActionButton action, Item item, string label, bool disabled, ref float scale, bool forcedPressed = false, bool hasControllerFocus = true, bool forceOver = false, bool disablePressedState = false, bool drawWhenControllerConnected = false, bool addTouchBanner = false)
	{
		return GUITransactionButton.InputState.Clicked;
	}

	// Token: 0x060007B8 RID: 1976 RVA: 0x00005310 File Offset: 0x00003510
	[Token(Token = "0x60007B8")]
	[Address(RVA = "0x19D9EA8", Offset = "0x19D9EA8", VA = "0x19D9EA8")]
	public static GUITransactionButton.InputState Draw(TransactionButton_Layout layout, Item item, string label, bool disabled, ref float scale, bool forcedPressed = false, bool hasControllerFocus = false, bool forceOver = false, bool disablePressedState = false)
	{
		return GUITransactionButton.InputState.Clicked;
	}

	// Token: 0x060007B9 RID: 1977 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007B9")]
	[Address(RVA = "0x19DBFF0", Offset = "0x19DBFF0", VA = "0x19DBFF0")]
	private static void DrawItem(TransactionButton_Layout layout, Texture2D backing, Texture2D itemTexture, Color itemColour, float scale)
	{
	}

	// Token: 0x060007BA RID: 1978 RVA: 0x00005328 File Offset: 0x00003528
	[Token(Token = "0x60007BA")]
	[Address(RVA = "0x19D7D20", Offset = "0x19D7D20", VA = "0x19D7D20")]
	private static GUITransactionButton.InputState HandleControllerAction(TransactionButton_Layout layout, ControllerActionButton action, string label, bool disabled, bool disablePressedState, bool hasControllerFocus)
	{
		return GUITransactionButton.InputState.Clicked;
	}

	// Token: 0x060007BB RID: 1979 RVA: 0x00005340 File Offset: 0x00003540
	[Token(Token = "0x60007BB")]
	[Address(RVA = "0x19DC2BC", Offset = "0x19DC2BC", VA = "0x19DC2BC")]
	public static GUITransactionButton.InputState DrawWithBanner(TransactionButton_Layout layout, ControllerActionButton action, Texture2D itemTexture, string label, bool disabled, ref float scale, Color? overloadedItemColour, bool forcedPressed = false, bool hasControllerFocus = false, bool forceOver = false, bool disablePressedState = false, bool drawWhenControllerConnected = false)
	{
		return GUITransactionButton.InputState.Clicked;
	}

	// Token: 0x060007BC RID: 1980 RVA: 0x00005358 File Offset: 0x00003558
	[Token(Token = "0x60007BC")]
	[Address(RVA = "0x19DC628", Offset = "0x19DC628", VA = "0x19DC628")]
	public static GUITransactionButton.InputState Draw(TransactionButton_Layout layout, Texture2D itemTexture, string label, bool disabled, ref float scale, Color? overloadedItemColour, bool forcedPressed = false, bool hasControllerFocus = false, bool forceOver = false, bool disablePressedState = false)
	{
		return GUITransactionButton.InputState.Clicked;
	}

	// Token: 0x060007BD RID: 1981 RVA: 0x00005370 File Offset: 0x00003570
	[Token(Token = "0x60007BD")]
	[Address(RVA = "0x19DC768", Offset = "0x19DC768", VA = "0x19DC768")]
	public static GUITransactionButton.InputState DrawWithBanner(TransactionButton_Layout layout, ControllerActionButton action, Texture2D itemTexture, Rectangle srcRect, string label, bool disabled, ref float scale, Color? overloadedItemColour, bool forcedPressed = false, bool hasControllerFocus = false, bool forceOver = false, bool disablePressedState = false, bool drawWhenControllerConnected = false, bool addTouchBanner = false)
	{
		return GUITransactionButton.InputState.Clicked;
	}

	// Token: 0x060007BE RID: 1982 RVA: 0x00005388 File Offset: 0x00003588
	[Token(Token = "0x60007BE")]
	[Address(RVA = "0x19DC7F4", Offset = "0x19DC7F4", VA = "0x19DC7F4")]
	public static GUITransactionButton.InputState DrawWithBanner(TransactionButton_Layout layout, ControllerActionButton action, Texture2D itemTexture, Rectangle srcRect, Texture2D itemTextureHighlight, Rectangle srcRectHighlight, string label, bool disabled, ref float scale, Color? overloadedItemColour, bool forcedPressed = false, bool hasControllerFocus = false, bool forceOver = false, bool disablePressedState = false, bool drawWhenControllerConnected = false, bool addTouchBanner = false)
	{
		return GUITransactionButton.InputState.Clicked;
	}

	// Token: 0x060007BF RID: 1983 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007BF")]
	[Address(RVA = "0x19D9840", Offset = "0x19D9840", VA = "0x19D9840")]
	private static void DrawLabel(TransactionButton_Layout layout, string label, Color labelColour, bool over)
	{
	}

	// Token: 0x060007C0 RID: 1984 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C0")]
	[Address(RVA = "0x19DE178", Offset = "0x19DE178", VA = "0x19DE178")]
	private static void ScaleLabelToFit(TransactionButton_Layout layout, string text)
	{
	}

	// Token: 0x060007C1 RID: 1985 RVA: 0x000053A0 File Offset: 0x000035A0
	[Token(Token = "0x60007C1")]
	[Address(RVA = "0x19DC5AC", Offset = "0x19DC5AC", VA = "0x19DC5AC")]
	public static GUITransactionButton.InputState Draw(TransactionButton_Layout layout, Texture2D itemTexture, Rectangle srcRect, string label, bool disabled, ref float scale, Color? overloadedItemColour, bool forcedPressed = false, bool hasControllerFocus = false, bool forceOver = false, bool disablePressedState = false)
	{
		return GUITransactionButton.InputState.Clicked;
	}

	// Token: 0x060007C2 RID: 1986 RVA: 0x000053B8 File Offset: 0x000035B8
	[Token(Token = "0x60007C2")]
	[Address(RVA = "0x19DCB3C", Offset = "0x19DCB3C", VA = "0x19DCB3C")]
	public static GUITransactionButton.InputState Draw(TransactionButton_Layout layout, Texture2D itemTexture, Rectangle srcRect, Texture2D itemTextureHighlight, Rectangle srcRectHighlight, string label, bool disabled, ref float scale, Color? overloadedItemColour, bool forcedPressed = false, bool hasControllerFocus = false, bool forceOver = false, bool disablePressedState = false)
	{
		return GUITransactionButton.InputState.Clicked;
	}

	// Token: 0x04000857 RID: 2135
	[Token(Token = "0x4000857")]
	[FieldOffset(Offset = "0x0")]
	public static bool UseToolBanner;

	// Token: 0x04000858 RID: 2136
	[Token(Token = "0x4000858")]
	[FieldOffset(Offset = "0x1")]
	public static bool UseOverloadBanner;

	// Token: 0x04000859 RID: 2137
	[Token(Token = "0x4000859")]
	[FieldOffset(Offset = "0x2")]
	public static bool disableControllerInput;

	// Token: 0x0400085A RID: 2138
	[Token(Token = "0x400085A")]
	[FieldOffset(Offset = "0x3")]
	public static bool UseSecondaryLayerForIcons;

	// Token: 0x0400085B RID: 2139
	[Token(Token = "0x400085B")]
	[FieldOffset(Offset = "0x4")]
	public static bool HideOptionalStates;

	// Token: 0x0200012F RID: 303
	// (Invoke) Token: 0x060007C4 RID: 1988
	[Token(Token = "0x200012F")]
	public delegate void DrawItemHandler(Vector2 position, float itemScale);

	// Token: 0x02000130 RID: 304
	[Token(Token = "0x2000130")]
	public enum InputState
	{
		// Token: 0x0400085D RID: 2141
		[Token(Token = "0x400085D")]
		Clicked,
		// Token: 0x0400085E RID: 2142
		[Token(Token = "0x400085E")]
		Over,
		// Token: 0x0400085F RID: 2143
		[Token(Token = "0x400085F")]
		Down,
		// Token: 0x04000860 RID: 2144
		[Token(Token = "0x4000860")]
		None
	}
}
