using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x0200017F RID: 383
[Token(Token = "0x200017F")]
public class GUIReturnToTouch
{
	// Token: 0x06000B28 RID: 2856 RVA: 0x000067C8 File Offset: 0x000049C8
	[Token(Token = "0x6000B28")]
	[Address(RVA = "0xBF188C", Offset = "0xBF188C", VA = "0xBF188C")]
	private bool IsOverPanel(Vector2 cursorPosition)
	{
		return default(bool);
	}

	// Token: 0x06000B29 RID: 2857 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B29")]
	[Address(RVA = "0xBF1894", Offset = "0xBF1894", VA = "0xBF1894")]
	public void Draw(bool inBatch = false)
	{
	}

	// Token: 0x17000101 RID: 257
	// (get) Token: 0x06000B2A RID: 2858 RVA: 0x000067E0 File Offset: 0x000049E0
	[Token(Token = "0x17000101")]
	public bool Visible
	{
		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0xBF28EC", Offset = "0xBF28EC", VA = "0xBF28EC")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000B2B RID: 2859 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B2B")]
	[Address(RVA = "0xBF29B0", Offset = "0xBF29B0", VA = "0xBF29B0")]
	public void DrawHUD()
	{
	}

	// Token: 0x06000B2C RID: 2860 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B2C")]
	[Address(RVA = "0xBF2E40", Offset = "0xBF2E40", VA = "0xBF2E40")]
	public GUIReturnToTouch()
	{
	}

	// Token: 0x04000D4E RID: 3406
	[Token(Token = "0x4000D4E")]
	[FieldOffset(Offset = "0x8")]
	public bool displayPopup;

	// Token: 0x04000D4F RID: 3407
	[Token(Token = "0x4000D4F")]
	[FieldOffset(Offset = "0xC")]
	private GUIInputRegionExclusive _displayBlocker;

	// Token: 0x04000D50 RID: 3408
	[Token(Token = "0x4000D50")]
	[FieldOffset(Offset = "0x10")]
	private float scale;

	// Token: 0x04000D51 RID: 3409
	[Token(Token = "0x4000D51")]
	[FieldOffset(Offset = "0x14")]
	private GUIControllerModalResponse _controller;

	// Token: 0x04000D52 RID: 3410
	[Token(Token = "0x4000D52")]
	[FieldOffset(Offset = "0x18")]
	private GUIControllerItem _previous;
}
