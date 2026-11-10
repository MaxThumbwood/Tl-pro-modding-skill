using System;
using Il2CppDummyDll;

// Token: 0x020002DD RID: 733
[Token(Token = "0x20002DD")]
public class XNAUIInputLayer
{
	// Token: 0x0600122B RID: 4651 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600122B")]
	[Address(RVA = "0xD82664", Offset = "0xD82664", VA = "0xD82664")]
	public XNAUIInputLayer()
	{
	}

	// Token: 0x0600122C RID: 4652 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600122C")]
	[Address(RVA = "0xD828C4", Offset = "0xD828C4", VA = "0xD828C4")]
	public void CaptureUICrusorDrag(int dragFromAxis = -1)
	{
	}

	// Token: 0x0600122D RID: 4653 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600122D")]
	[Address(RVA = "0xD828E0", Offset = "0xD828E0", VA = "0xD828E0")]
	public void CancelUICrusorDrag()
	{
	}

	// Token: 0x0600122E RID: 4654 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600122E")]
	[Address(RVA = "0xD828EC", Offset = "0xD828EC", VA = "0xD828EC")]
	public void UpdateCursor(Cursor cursor)
	{
	}

	// Token: 0x0600122F RID: 4655 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600122F")]
	[Address(RVA = "0xD82B80", Offset = "0xD82B80", VA = "0xD82B80")]
	public void UpdateCursorSecondary(Cursor cursor)
	{
	}

	// Token: 0x06001230 RID: 4656 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001230")]
	[Address(RVA = "0xD82D5C", Offset = "0xD82D5C", VA = "0xD82D5C")]
	public void CaptureWorldCursor()
	{
	}

	// Token: 0x06001231 RID: 4657 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001231")]
	[Address(RVA = "0xD82EE0", Offset = "0xD82EE0", VA = "0xD82EE0")]
	public void WorldUpdateCursor(Cursor cursor)
	{
	}

	// Token: 0x06001232 RID: 4658 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001232")]
	[Address(RVA = "0xD82EE4", Offset = "0xD82EE4", VA = "0xD82EE4")]
	public void ResetTimeWithoutCursor()
	{
	}

	// Token: 0x06001233 RID: 4659 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001233")]
	[Address(RVA = "0xD82EF0", Offset = "0xD82EF0", VA = "0xD82EF0")]
	public void Update(float elapsedTime)
	{
	}

	// Token: 0x170001B4 RID: 436
	// (get) Token: 0x06001234 RID: 4660 RVA: 0x00008748 File Offset: 0x00006948
	[Token(Token = "0x170001B4")]
	public static float UITextAlpha
	{
		[Token(Token = "0x6001234")]
		[Address(RVA = "0xD83420", Offset = "0xD83420", VA = "0xD83420")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170001B5 RID: 437
	// (get) Token: 0x06001235 RID: 4661 RVA: 0x00008760 File Offset: 0x00006960
	[Token(Token = "0x170001B5")]
	public static float UITextAlphaAllowNavAxis
	{
		[Token(Token = "0x6001235")]
		[Address(RVA = "0xD835D4", Offset = "0xD835D4", VA = "0xD835D4")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06001236 RID: 4662 RVA: 0x00008778 File Offset: 0x00006978
	[Token(Token = "0x6001236")]
	[Address(RVA = "0xD8366C", Offset = "0xD8366C", VA = "0xD8366C")]
	public static float UITextAlphaCustom(float _timeForFullUIMouse, float _timeForUIMouseFade = 1f, float _timeDelay = 0f)
	{
		return 0f;
	}

	// Token: 0x06001237 RID: 4663 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001237")]
	[Address(RVA = "0xD8329C", Offset = "0xD8329C", VA = "0xD8329C")]
	public Cursor GetUICursor()
	{
		return null;
	}

	// Token: 0x06001238 RID: 4664 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001238")]
	[Address(RVA = "0xD82D78", Offset = "0xD82D78", VA = "0xD82D78")]
	public Cursor GetWorldCursor()
	{
		return null;
	}

	// Token: 0x04002390 RID: 9104
	[Token(Token = "0x4002390")]
	[FieldOffset(Offset = "0x0")]
	public static XNAUIInputLayer Instance;

	// Token: 0x04002391 RID: 9105
	[Token(Token = "0x4002391")]
	[FieldOffset(Offset = "0x8")]
	public CursorInputLayer _inputLayer;

	// Token: 0x04002392 RID: 9106
	[Token(Token = "0x4002392")]
	[FieldOffset(Offset = "0xC")]
	public CursorInputLayer _inputLayer2;

	// Token: 0x04002393 RID: 9107
	[Token(Token = "0x4002393")]
	[FieldOffset(Offset = "0x10")]
	public CursorInputLayer _worldInputLayer;

	// Token: 0x04002394 RID: 9108
	[Token(Token = "0x4002394")]
	[FieldOffset(Offset = "0x14")]
	public int UICrusorDraggingFromAxis;

	// Token: 0x04002395 RID: 9109
	[Token(Token = "0x4002395")]
	[FieldOffset(Offset = "0x18")]
	public bool UICrusorDragging;

	// Token: 0x04002396 RID: 9110
	[Token(Token = "0x4002396")]
	[FieldOffset(Offset = "0x19")]
	public bool HadUICursor;

	// Token: 0x04002397 RID: 9111
	[Token(Token = "0x4002397")]
	private const float TimeForUIMouseFade = 1f;

	// Token: 0x04002398 RID: 9112
	[Token(Token = "0x4002398")]
	private const float TimeForFullUIMouse = 1f;

	// Token: 0x04002399 RID: 9113
	[Token(Token = "0x4002399")]
	[FieldOffset(Offset = "0x1C")]
	public float _timeWithoutUICursor;
}
