using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

// Token: 0x0200015F RID: 351
[Token(Token = "0x200015F")]
public class GUIInventorySplitStack
{
	// Token: 0x060009D8 RID: 2520 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009D8")]
	[Address(RVA = "0x91D158", Offset = "0x91D158", VA = "0x91D158")]
	public GUIInventorySplitStack()
	{
	}

	// Token: 0x060009D9 RID: 2521 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009D9")]
	[Address(RVA = "0x923BDC", Offset = "0x923BDC", VA = "0x923BDC")]
	public static void LoadContent(ContentManager content)
	{
	}

	// Token: 0x060009DA RID: 2522 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009DA")]
	[Address(RVA = "0x923D1C", Offset = "0x923D1C", VA = "0x923D1C")]
	public void Open()
	{
	}

	// Token: 0x060009DB RID: 2523 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009DB")]
	[Address(RVA = "0x923E10", Offset = "0x923E10", VA = "0x923E10")]
	private void RefreshItemToSplit()
	{
	}

	// Token: 0x060009DC RID: 2524 RVA: 0x00006018 File Offset: 0x00004218
	[Token(Token = "0x60009DC")]
	[Address(RVA = "0x923FA0", Offset = "0x923FA0", VA = "0x923FA0")]
	public bool IsOpen()
	{
		return default(bool);
	}

	// Token: 0x060009DD RID: 2525 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009DD")]
	[Address(RVA = "0x91AA58", Offset = "0x91AA58", VA = "0x91AA58")]
	public void Close()
	{
	}

	// Token: 0x060009DE RID: 2526 RVA: 0x00006030 File Offset: 0x00004230
	[Token(Token = "0x60009DE")]
	[Address(RVA = "0x923FA8", Offset = "0x923FA8", VA = "0x923FA8")]
	public bool IsOver(Vector2 cursorPosition)
	{
		return default(bool);
	}

	// Token: 0x060009DF RID: 2527 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009DF")]
	[Address(RVA = "0x9241E0", Offset = "0x9241E0", VA = "0x9241E0")]
	public void RightClickSplit()
	{
	}

	// Token: 0x060009E0 RID: 2528 RVA: 0x00006048 File Offset: 0x00004248
	[Token(Token = "0x60009E0")]
	[Address(RVA = "0x9242E0", Offset = "0x9242E0", VA = "0x9242E0")]
	public bool WasSplit()
	{
		return default(bool);
	}

	// Token: 0x060009E1 RID: 2529 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E1")]
	[Address(RVA = "0x9244B4", Offset = "0x9244B4", VA = "0x9244B4")]
	public void Draw()
	{
	}

	// Token: 0x060009E2 RID: 2530 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E2")]
	[Address(RVA = "0x925684", Offset = "0x925684", VA = "0x925684")]
	public void DrawOverlay()
	{
	}

	// Token: 0x04000BA8 RID: 2984
	[Token(Token = "0x4000BA8")]
	[FieldOffset(Offset = "0x0")]
	public static Texture2D SplitStackIcon;

	// Token: 0x04000BA9 RID: 2985
	[Token(Token = "0x4000BA9")]
	[FieldOffset(Offset = "0x4")]
	public static Texture2D SplitStackIconOpen;

	// Token: 0x04000BAA RID: 2986
	[Token(Token = "0x4000BAA")]
	[FieldOffset(Offset = "0x8")]
	public GUIInputRegionExclusive PickingInterceptor;

	// Token: 0x04000BAB RID: 2987
	[Token(Token = "0x4000BAB")]
	[FieldOffset(Offset = "0xC")]
	private bool open;

	// Token: 0x04000BAC RID: 2988
	[Token(Token = "0x4000BAC")]
	[FieldOffset(Offset = "0x10")]
	private float splitSlider;

	// Token: 0x04000BAD RID: 2989
	[Token(Token = "0x4000BAD")]
	[FieldOffset(Offset = "0x14")]
	private GUISlider.DragState dragState;

	// Token: 0x04000BAE RID: 2990
	[Token(Token = "0x4000BAE")]
	[FieldOffset(Offset = "0x18")]
	private Item ItemToSplit;

	// Token: 0x04000BAF RID: 2991
	[Token(Token = "0x4000BAF")]
	[FieldOffset(Offset = "0x1C")]
	private Item SplitItem;

	// Token: 0x04000BB0 RID: 2992
	[Token(Token = "0x4000BB0")]
	[FieldOffset(Offset = "0x20")]
	private float splitScale;

	// Token: 0x04000BB1 RID: 2993
	[Token(Token = "0x4000BB1")]
	[FieldOffset(Offset = "0x24")]
	private float itemScale;

	// Token: 0x04000BB2 RID: 2994
	[Token(Token = "0x4000BB2")]
	[FieldOffset(Offset = "0x28")]
	private float mainScale;

	// Token: 0x04000BB3 RID: 2995
	[Token(Token = "0x4000BB3")]
	[FieldOffset(Offset = "0x30")]
	private DateTime lastSplitTime;

	// Token: 0x04000BB4 RID: 2996
	[Token(Token = "0x4000BB4")]
	[FieldOffset(Offset = "0x38")]
	private Vector2 lastSplitPosition;

	// Token: 0x04000BB5 RID: 2997
	[Token(Token = "0x4000BB5")]
	[FieldOffset(Offset = "0x40")]
	public GUITransactionButton.InputState splitButtonState;
}
