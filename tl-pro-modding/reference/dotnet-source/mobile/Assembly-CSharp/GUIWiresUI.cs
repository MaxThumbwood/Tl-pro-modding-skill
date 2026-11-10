using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200018E RID: 398
[Token(Token = "0x200018E")]
public class GUIWiresUI
{
	// Token: 0x06000BC1 RID: 3009 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC1")]
	[Address(RVA = "0xC3065C", Offset = "0xC3065C", VA = "0xC3065C")]
	public GUIWiresUI()
	{
	}

	// Token: 0x06000BC2 RID: 3010 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC2")]
	[Address(RVA = "0xC30850", Offset = "0xC30850", VA = "0xC30850")]
	public void PlayerMenuDisplayToggle()
	{
	}

	// Token: 0x06000BC3 RID: 3011 RVA: 0x00006C60 File Offset: 0x00004E60
	[Token(Token = "0x6000BC3")]
	[Address(RVA = "0xC30E68", Offset = "0xC30E68", VA = "0xC30E68")]
	private Vector2 ClampPositionToScreen(Vector2 position)
	{
		return default(Vector2);
	}

	// Token: 0x06000BC4 RID: 3012 RVA: 0x00006C78 File Offset: 0x00004E78
	[Token(Token = "0x6000BC4")]
	[Address(RVA = "0xC318F4", Offset = "0xC318F4", VA = "0xC318F4")]
	private float ItemScale(int index)
	{
		return 0f;
	}

	// Token: 0x06000BC5 RID: 3013 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC5")]
	[Address(RVA = "0xC318FC", Offset = "0xC318FC", VA = "0xC318FC")]
	private void ItemOver(int index)
	{
	}

	// Token: 0x06000BC6 RID: 3014 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC6")]
	[Address(RVA = "0xC31904", Offset = "0xC31904", VA = "0xC31904")]
	private void ItemDraw(ItemGrid_Layout gridLayout, int i, Vector2 position, float scale)
	{
	}

	// Token: 0x06000BC7 RID: 3015 RVA: 0x00006C90 File Offset: 0x00004E90
	[Token(Token = "0x6000BC7")]
	[Address(RVA = "0xC30C98", Offset = "0xC30C98", VA = "0xC30C98")]
	private bool CanInteract()
	{
		return default(bool);
	}

	// Token: 0x06000BC8 RID: 3016 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC8")]
	[Address(RVA = "0xC32114", Offset = "0xC32114", VA = "0xC32114")]
	public void DrawCursor()
	{
	}

	// Token: 0x06000BC9 RID: 3017 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC9")]
	[Address(RVA = "0xC32D78", Offset = "0xC32D78", VA = "0xC32D78")]
	public void DrawOverlay()
	{
	}

	// Token: 0x06000BCA RID: 3018 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BCA")]
	[Address(RVA = "0xC336C4", Offset = "0xC336C4", VA = "0xC336C4")]
	public void DrawButton()
	{
	}

	// Token: 0x06000BCB RID: 3019 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BCB")]
	[Address(RVA = "0xC336C8", Offset = "0xC336C8", VA = "0xC336C8")]
	public void DrawUseButtonItem(Vector2 position, float itemScale)
	{
	}

	// Token: 0x06000BCC RID: 3020 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BCC")]
	[Address(RVA = "0xC3219C", Offset = "0xC3219C", VA = "0xC3219C")]
	private void DrawCursorArea(SpriteBatch spriteBatch)
	{
	}

	// Token: 0x06000BCD RID: 3021 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BCD")]
	[Address(RVA = "0xC3128C", Offset = "0xC3128C", VA = "0xC3128C")]
	public void Close()
	{
	}

	// Token: 0x06000BCE RID: 3022 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BCE")]
	[Address(RVA = "0xC34438", Offset = "0xC34438", VA = "0xC34438")]
	public void AddUIExcludeRegions(List<Rectangle> regions)
	{
	}

	// Token: 0x06000BCF RID: 3023 RVA: 0x00006CA8 File Offset: 0x00004EA8
	[Token(Token = "0x6000BCF")]
	[Address(RVA = "0xC34684", Offset = "0xC34684", VA = "0xC34684")]
	public bool IsOver(Vector2 cursorPosition)
	{
		return default(bool);
	}

	// Token: 0x06000BD0 RID: 3024 RVA: 0x00006CC0 File Offset: 0x00004EC0
	[Token(Token = "0x6000BD0")]
	[Address(RVA = "0xC314D8", Offset = "0xC314D8", VA = "0xC314D8")]
	private Rectangle CalculateRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x04000E72 RID: 3698
	[Token(Token = "0x4000E72")]
	[FieldOffset(Offset = "0x8")]
	private int hoverItem;

	// Token: 0x04000E73 RID: 3699
	[Token(Token = "0x4000E73")]
	[FieldOffset(Offset = "0xC")]
	public Vector2 PopupPosition;

	// Token: 0x04000E74 RID: 3700
	[Token(Token = "0x4000E74")]
	[FieldOffset(Offset = "0x14")]
	private float[] ButtonScales;

	// Token: 0x04000E75 RID: 3701
	[Token(Token = "0x4000E75")]
	[FieldOffset(Offset = "0x18")]
	private float TimeSinceChange;

	// Token: 0x04000E76 RID: 3702
	[Token(Token = "0x4000E76")]
	[FieldOffset(Offset = "0x1C")]
	private float ToggleButtonScale;

	// Token: 0x04000E77 RID: 3703
	[Token(Token = "0x4000E77")]
	[FieldOffset(Offset = "0x20")]
	public bool DisplayOptions;

	// Token: 0x04000E78 RID: 3704
	[Token(Token = "0x4000E78")]
	[FieldOffset(Offset = "0x24")]
	public GUIControllerWiresUI _controller;

	// Token: 0x04000E79 RID: 3705
	[Token(Token = "0x4000E79")]
	[FieldOffset(Offset = "0x28")]
	public GUIInputRegionExclusive PickingInterceptor;
}
