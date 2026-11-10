using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x0200017A RID: 378
[Token(Token = "0x200017A")]
public class GUIReforgePopup
{
	// Token: 0x06000AF3 RID: 2803 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AF3")]
	[Address(RVA = "0xBE48F8", Offset = "0xBE48F8", VA = "0xBE48F8")]
	private void SetupBackingSize()
	{
	}

	// Token: 0x06000AF4 RID: 2804 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AF4")]
	[Address(RVA = "0xBE4D6C", Offset = "0xBE4D6C", VA = "0xBE4D6C")]
	public void LoadRegion()
	{
	}

	// Token: 0x06000AF5 RID: 2805 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AF5")]
	[Address(RVA = "0xBE4E00", Offset = "0xBE4E00", VA = "0xBE4E00")]
	public void OpenPopup()
	{
	}

	// Token: 0x06000AF6 RID: 2806 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AF6")]
	[Address(RVA = "0xBE4F98", Offset = "0xBE4F98", VA = "0xBE4F98")]
	public void ClosePopup()
	{
	}

	// Token: 0x06000AF7 RID: 2807 RVA: 0x000066C0 File Offset: 0x000048C0
	[Token(Token = "0x6000AF7")]
	[Address(RVA = "0xBE502C", Offset = "0xBE502C", VA = "0xBE502C")]
	public bool IsOver(Vector2 cursorPosition)
	{
		return default(bool);
	}

	// Token: 0x06000AF8 RID: 2808 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AF8")]
	[Address(RVA = "0xBE7590", Offset = "0xBE7590", VA = "0xBE7590")]
	private void UpdateText()
	{
	}

	// Token: 0x06000AF9 RID: 2809 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AF9")]
	[Address(RVA = "0xBE775C", Offset = "0xBE775C", VA = "0xBE775C")]
	public void LoadPanelRegion()
	{
	}

	// Token: 0x06000AFA RID: 2810 RVA: 0x000066D8 File Offset: 0x000048D8
	[Token(Token = "0x6000AFA")]
	[Address(RVA = "0xBE77F0", Offset = "0xBE77F0", VA = "0xBE77F0")]
	public Rectangle GetRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x06000AFB RID: 2811 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AFB")]
	[Address(RVA = "0xBE7880", Offset = "0xBE7880", VA = "0xBE7880")]
	private void DrawItem()
	{
	}

	// Token: 0x06000AFC RID: 2812 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AFC")]
	[Address(RVA = "0xBE5448", Offset = "0xBE5448", VA = "0xBE5448")]
	private void UpdatePrefixes(Item reforgeItem)
	{
	}

	// Token: 0x06000AFD RID: 2813 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AFD")]
	[Address(RVA = "0xBE84EC", Offset = "0xBE84EC", VA = "0xBE84EC")]
	public void DrawPrefixes()
	{
	}

	// Token: 0x06000AFE RID: 2814 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AFE")]
	[Address(RVA = "0xBE8C28", Offset = "0xBE8C28", VA = "0xBE8C28")]
	public void Draw()
	{
	}

	// Token: 0x06000AFF RID: 2815 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AFF")]
	[Address(RVA = "0xBEAAC8", Offset = "0xBEAAC8", VA = "0xBEAAC8")]
	public GUIReforgePopup()
	{
	}

	// Token: 0x04000D13 RID: 3347
	[Token(Token = "0x4000D13")]
	[FieldOffset(Offset = "0x0")]
	private static int reforgeItemNamePos;

	// Token: 0x04000D14 RID: 3348
	[Token(Token = "0x4000D14")]
	[FieldOffset(Offset = "0x4")]
	private static int reforgeTextPos;

	// Token: 0x04000D15 RID: 3349
	[Token(Token = "0x4000D15")]
	[FieldOffset(Offset = "0x8")]
	private static int reforgeTextBackingSize;

	// Token: 0x04000D16 RID: 3350
	[Token(Token = "0x4000D16")]
	[FieldOffset(Offset = "0xC")]
	private static int defaultBackingWidth;

	// Token: 0x04000D17 RID: 3351
	[Token(Token = "0x4000D17")]
	[FieldOffset(Offset = "0x8")]
	private int OpenedFrame;

	// Token: 0x04000D18 RID: 3352
	[Token(Token = "0x4000D18")]
	[FieldOffset(Offset = "0xC")]
	public bool PopupDisplayed;

	// Token: 0x04000D19 RID: 3353
	[Token(Token = "0x4000D19")]
	[FieldOffset(Offset = "0x10")]
	private GUIInputRegionExclusive PickingInterceptor;

	// Token: 0x04000D1A RID: 3354
	[Token(Token = "0x4000D1A")]
	[FieldOffset(Offset = "0x14")]
	private float CachedLayoutSize;

	// Token: 0x04000D1B RID: 3355
	[Token(Token = "0x4000D1B")]
	[FieldOffset(Offset = "0x18")]
	private float CachedLayoutWrapSize;

	// Token: 0x04000D1C RID: 3356
	[Token(Token = "0x4000D1C")]
	[FieldOffset(Offset = "0x1C")]
	private int CachedMinTextHeight;

	// Token: 0x04000D1D RID: 3357
	[Token(Token = "0x4000D1D")]
	[FieldOffset(Offset = "0x20")]
	private Vector2 CachedTextSize;

	// Token: 0x04000D1E RID: 3358
	[Token(Token = "0x4000D1E")]
	[FieldOffset(Offset = "0x28")]
	private int CachedTextLines;

	// Token: 0x04000D1F RID: 3359
	[Token(Token = "0x4000D1F")]
	[FieldOffset(Offset = "0x2C")]
	public GUIControllerReforgePopup _controller;

	// Token: 0x04000D20 RID: 3360
	[Token(Token = "0x4000D20")]
	[FieldOffset(Offset = "0x30")]
	private int numLines;

	// Token: 0x04000D21 RID: 3361
	[Token(Token = "0x4000D21")]
	[FieldOffset(Offset = "0x34")]
	private string[] toolTipLine;

	// Token: 0x04000D22 RID: 3362
	[Token(Token = "0x4000D22")]
	[FieldOffset(Offset = "0x38")]
	private bool[] badPreFixLine;

	// Token: 0x04000D23 RID: 3363
	[Token(Token = "0x4000D23")]
	[FieldOffset(Offset = "0x3C")]
	private Item tooltipPrefixComparisonItem;

	// Token: 0x04000D24 RID: 3364
	[Token(Token = "0x4000D24")]
	[FieldOffset(Offset = "0x40")]
	private DateTime MaxReforgeTimeout;

	// Token: 0x04000D25 RID: 3365
	[Token(Token = "0x4000D25")]
	[FieldOffset(Offset = "0x48")]
	private Item MaxReforgeSelectedItem;
}
