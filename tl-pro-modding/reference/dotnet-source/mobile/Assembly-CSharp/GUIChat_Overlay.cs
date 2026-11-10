using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x0200013E RID: 318
[Token(Token = "0x200013E")]
public class GUIChat_Overlay
{
	// Token: 0x06000853 RID: 2131 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000853")]
	[Address(RVA = "0x1E518EC", Offset = "0x1E518EC", VA = "0x1E518EC")]
	public void AddUIExcludeRegions(List<Rectangle> regions)
	{
	}

	// Token: 0x06000854 RID: 2132 RVA: 0x00005700 File Offset: 0x00003900
	[Token(Token = "0x6000854")]
	[Address(RVA = "0x1E51A98", Offset = "0x1E51A98", VA = "0x1E51A98")]
	public bool IsOver(Vector2 cursorPosition)
	{
		return default(bool);
	}

	// Token: 0x06000855 RID: 2133 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000855")]
	[Address(RVA = "0x1E51C44", Offset = "0x1E51C44", VA = "0x1E51C44")]
	private void DrawChatBox()
	{
	}

	// Token: 0x06000856 RID: 2134 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000856")]
	[Address(RVA = "0x1E530A8", Offset = "0x1E530A8", VA = "0x1E530A8")]
	public void Draw()
	{
	}

	// Token: 0x06000857 RID: 2135 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000857")]
	[Address(RVA = "0x1E5491C", Offset = "0x1E5491C", VA = "0x1E5491C")]
	public void Close()
	{
	}

	// Token: 0x06000858 RID: 2136 RVA: 0x00005718 File Offset: 0x00003918
	[Token(Token = "0x6000858")]
	[Address(RVA = "0x1E547F0", Offset = "0x1E547F0", VA = "0x1E547F0")]
	public Vector2 ChatSize(int index)
	{
		return default(Vector2);
	}

	// Token: 0x06000859 RID: 2137 RVA: 0x00005730 File Offset: 0x00003930
	[Token(Token = "0x6000859")]
	[Address(RVA = "0x1E54A70", Offset = "0x1E54A70", VA = "0x1E54A70")]
	private float ChatScale(int index)
	{
		return 0f;
	}

	// Token: 0x0600085A RID: 2138 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600085A")]
	[Address(RVA = "0x1E54A78", Offset = "0x1E54A78", VA = "0x1E54A78")]
	private void ChatOver(int index)
	{
	}

	// Token: 0x0600085B RID: 2139 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600085B")]
	[Address(RVA = "0x1E54A7C", Offset = "0x1E54A7C", VA = "0x1E54A7C")]
	private void ChatDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x0600085C RID: 2140 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600085C")]
	[Address(RVA = "0x1E4E1C0", Offset = "0x1E4E1C0", VA = "0x1E4E1C0")]
	public GUIChat_Overlay()
	{
	}

	// Token: 0x0400091D RID: 2333
	[Token(Token = "0x400091D")]
	[FieldOffset(Offset = "0x8")]
	public bool Display;

	// Token: 0x0400091E RID: 2334
	[Token(Token = "0x400091E")]
	[FieldOffset(Offset = "0x9")]
	private bool beginChatClicked;

	// Token: 0x0400091F RID: 2335
	[Token(Token = "0x400091F")]
	[FieldOffset(Offset = "0xC")]
	public float ScrollOffset;

	// Token: 0x04000920 RID: 2336
	[Token(Token = "0x4000920")]
	[FieldOffset(Offset = "0x10")]
	private float ScrollMomentum;

	// Token: 0x04000921 RID: 2337
	[Token(Token = "0x4000921")]
	[FieldOffset(Offset = "0x14")]
	private int ScrollDragging;

	// Token: 0x04000922 RID: 2338
	[Token(Token = "0x4000922")]
	[FieldOffset(Offset = "0x18")]
	private Vector2 DragOffset;

	// Token: 0x04000923 RID: 2339
	[Token(Token = "0x4000923")]
	[FieldOffset(Offset = "0x20")]
	private float BeginChatScale;

	// Token: 0x04000924 RID: 2340
	[Token(Token = "0x4000924")]
	[FieldOffset(Offset = "0x24")]
	private float PrimaryChatScale;

	// Token: 0x04000925 RID: 2341
	[Token(Token = "0x4000925")]
	[FieldOffset(Offset = "0x28")]
	private float CloseScale;

	// Token: 0x04000926 RID: 2342
	[Token(Token = "0x4000926")]
	[FieldOffset(Offset = "0x2C")]
	private float EmotesScale;

	// Token: 0x04000927 RID: 2343
	[Token(Token = "0x4000927")]
	[FieldOffset(Offset = "0x30")]
	private float TitleScale;

	// Token: 0x04000928 RID: 2344
	[Token(Token = "0x4000928")]
	[FieldOffset(Offset = "0x34")]
	public GUIInputRegionExclusive PickingInterceptor;

	// Token: 0x04000929 RID: 2345
	[Token(Token = "0x4000929")]
	[FieldOffset(Offset = "0x38")]
	public GUIContollerTransactionButtonList _controller;
}
