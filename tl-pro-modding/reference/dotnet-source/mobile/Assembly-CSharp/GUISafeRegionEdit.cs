using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002B7 RID: 695
[Token(Token = "0x20002B7")]
public class GUISafeRegionEdit
{
	// Token: 0x06001093 RID: 4243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001093")]
	[Address(RVA = "0xCFF630", Offset = "0xCFF630", VA = "0xCFF630")]
	public GUISafeRegionEdit()
	{
	}

	// Token: 0x06001094 RID: 4244 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001094")]
	[Address(RVA = "0xCFF74C", Offset = "0xCFF74C", VA = "0xCFF74C")]
	public void UpdateCursor(global::Cursor cursor)
	{
	}

	// Token: 0x06001095 RID: 4245 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001095")]
	[Address(RVA = "0xCFFB54", Offset = "0xCFFB54", VA = "0xCFFB54")]
	public void DrawBacking()
	{
	}

	// Token: 0x06001096 RID: 4246 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001096")]
	[Address(RVA = "0xD0034C", Offset = "0xD0034C", VA = "0xD0034C")]
	public void UpdateEdit()
	{
	}

	// Token: 0x06001097 RID: 4247 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001097")]
	[Address(RVA = "0xD00E90", Offset = "0xD00E90", VA = "0xD00E90")]
	public void Draw()
	{
	}

	// Token: 0x06001098 RID: 4248 RVA: 0x00008040 File Offset: 0x00006240
	[Token(Token = "0x6001098")]
	[Address(RVA = "0xD00488", Offset = "0xD00488", VA = "0xD00488")]
	private bool UpdateCursorDragging(ref Rect safeArea)
	{
		return default(bool);
	}

	// Token: 0x0400210D RID: 8461
	[Token(Token = "0x400210D")]
	[FieldOffset(Offset = "0x8")]
	private CursorInputLayer _inputLayer;

	// Token: 0x0400210E RID: 8462
	[Token(Token = "0x400210E")]
	[FieldOffset(Offset = "0xC")]
	private float leftInitialOffset;

	// Token: 0x0400210F RID: 8463
	[Token(Token = "0x400210F")]
	[FieldOffset(Offset = "0x10")]
	private float rightInitialOffset;

	// Token: 0x04002110 RID: 8464
	[Token(Token = "0x4002110")]
	[FieldOffset(Offset = "0x14")]
	private float topInitialOffset;

	// Token: 0x04002111 RID: 8465
	[Token(Token = "0x4002111")]
	[FieldOffset(Offset = "0x18")]
	private float bottomInitialOffset;

	// Token: 0x04002112 RID: 8466
	[Token(Token = "0x4002112")]
	[FieldOffset(Offset = "0x1C")]
	private float leftScale;

	// Token: 0x04002113 RID: 8467
	[Token(Token = "0x4002113")]
	[FieldOffset(Offset = "0x20")]
	private float rightScale;

	// Token: 0x04002114 RID: 8468
	[Token(Token = "0x4002114")]
	[FieldOffset(Offset = "0x24")]
	private float topScale;

	// Token: 0x04002115 RID: 8469
	[Token(Token = "0x4002115")]
	[FieldOffset(Offset = "0x28")]
	private float bottomScale;

	// Token: 0x04002116 RID: 8470
	[Token(Token = "0x4002116")]
	[FieldOffset(Offset = "0x2C")]
	private float finishScale;

	// Token: 0x04002117 RID: 8471
	[Token(Token = "0x4002117")]
	[FieldOffset(Offset = "0x30")]
	private float resetScale;

	// Token: 0x04002118 RID: 8472
	[Token(Token = "0x4002118")]
	[FieldOffset(Offset = "0x34")]
	private bool LeftPressed;

	// Token: 0x04002119 RID: 8473
	[Token(Token = "0x4002119")]
	[FieldOffset(Offset = "0x35")]
	private bool RightPressed;

	// Token: 0x0400211A RID: 8474
	[Token(Token = "0x400211A")]
	[FieldOffset(Offset = "0x36")]
	private bool TopPressed;

	// Token: 0x0400211B RID: 8475
	[Token(Token = "0x400211B")]
	[FieldOffset(Offset = "0x37")]
	private bool BottomPressed;
}
