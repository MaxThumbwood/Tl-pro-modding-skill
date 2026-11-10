using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x0200013C RID: 316
[Token(Token = "0x200013C")]
public class GUIChat_Mini
{
	// Token: 0x06000845 RID: 2117 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000845")]
	[Address(RVA = "0x1E4E1D0", Offset = "0x1E4E1D0", VA = "0x1E4E1D0")]
	public void Close()
	{
	}

	// Token: 0x06000846 RID: 2118 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000846")]
	[Address(RVA = "0x1E4E268", Offset = "0x1E4E268", VA = "0x1E4E268")]
	public void AddUIExcludeRegions(List<Rectangle> regions)
	{
	}

	// Token: 0x06000847 RID: 2119 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000847")]
	[Address(RVA = "0x1E4E414", Offset = "0x1E4E414", VA = "0x1E4E414")]
	public void Draw()
	{
	}

	// Token: 0x06000848 RID: 2120 RVA: 0x000056A0 File Offset: 0x000038A0
	[Token(Token = "0x6000848")]
	[Address(RVA = "0x1E50680", Offset = "0x1E50680", VA = "0x1E50680")]
	public Vector2 ChatSize(int index)
	{
		return default(Vector2);
	}

	// Token: 0x06000849 RID: 2121 RVA: 0x000056B8 File Offset: 0x000038B8
	[Token(Token = "0x6000849")]
	[Address(RVA = "0x1E507AC", Offset = "0x1E507AC", VA = "0x1E507AC")]
	private float ChatScale(int index)
	{
		return 0f;
	}

	// Token: 0x0600084A RID: 2122 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600084A")]
	[Address(RVA = "0x1E507B4", Offset = "0x1E507B4", VA = "0x1E507B4")]
	private void ChatOver(int index)
	{
	}

	// Token: 0x0600084B RID: 2123 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600084B")]
	[Address(RVA = "0x1E507B8", Offset = "0x1E507B8", VA = "0x1E507B8")]
	private void ChatDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x0600084C RID: 2124 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600084C")]
	[Address(RVA = "0x1E4E1C8", Offset = "0x1E4E1C8", VA = "0x1E4E1C8")]
	public GUIChat_Mini()
	{
	}

	// Token: 0x04000914 RID: 2324
	[Token(Token = "0x4000914")]
	[FieldOffset(Offset = "0x8")]
	public bool Display;

	// Token: 0x04000915 RID: 2325
	[Token(Token = "0x4000915")]
	[FieldOffset(Offset = "0x9")]
	private bool beginChatClicked;

	// Token: 0x04000916 RID: 2326
	[Token(Token = "0x4000916")]
	[FieldOffset(Offset = "0xC")]
	public float ScrollOffset;

	// Token: 0x04000917 RID: 2327
	[Token(Token = "0x4000917")]
	[FieldOffset(Offset = "0x10")]
	private float ScrollMomentum;

	// Token: 0x04000918 RID: 2328
	[Token(Token = "0x4000918")]
	[FieldOffset(Offset = "0x14")]
	private int ScrollDragging;

	// Token: 0x04000919 RID: 2329
	[Token(Token = "0x4000919")]
	[FieldOffset(Offset = "0x18")]
	private Vector2 DragOffset;

	// Token: 0x0400091A RID: 2330
	[Token(Token = "0x400091A")]
	[FieldOffset(Offset = "0x20")]
	private float BeginChatScale;

	// Token: 0x0400091B RID: 2331
	[Token(Token = "0x400091B")]
	[FieldOffset(Offset = "0x24")]
	private float PrimaryChatScale;

	// Token: 0x0400091C RID: 2332
	[Token(Token = "0x400091C")]
	[FieldOffset(Offset = "0x28")]
	private float EmotesScale;
}
