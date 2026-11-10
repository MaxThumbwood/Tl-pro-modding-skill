using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020002C7 RID: 711
[Token(Token = "0x20002C7")]
public class GUIWorldCreateSecretSeeds
{
	// Token: 0x0600117F RID: 4479 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600117F")]
	[Address(RVA = "0xD426F0", Offset = "0xD426F0", VA = "0xD426F0")]
	public GUIWorldCreateSecretSeeds()
	{
	}

	// Token: 0x06001180 RID: 4480 RVA: 0x00008490 File Offset: 0x00006690
	[Token(Token = "0x6001180")]
	[Address(RVA = "0xD428D0", Offset = "0xD428D0", VA = "0xD428D0")]
	public Vector2 ItemSize(int index)
	{
		return default(Vector2);
	}

	// Token: 0x06001181 RID: 4481 RVA: 0x000084A8 File Offset: 0x000066A8
	[Token(Token = "0x6001181")]
	[Address(RVA = "0xD4294C", Offset = "0xD4294C", VA = "0xD4294C")]
	private float SeedEntryScale(int index)
	{
		return 0f;
	}

	// Token: 0x06001182 RID: 4482 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001182")]
	[Address(RVA = "0xD42954", Offset = "0xD42954", VA = "0xD42954")]
	private void SeedEntryOver(int index)
	{
	}

	// Token: 0x06001183 RID: 4483 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001183")]
	[Address(RVA = "0xD42958", Offset = "0xD42958", VA = "0xD42958")]
	private void SeedEntryDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x06001184 RID: 4484 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001184")]
	[Address(RVA = "0xD42FD8", Offset = "0xD42FD8", VA = "0xD42FD8")]
	public void Draw()
	{
	}

	// Token: 0x06001185 RID: 4485 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001185")]
	[Address(RVA = "0xD439C8", Offset = "0xD439C8", VA = "0xD439C8")]
	private void DrawDescription()
	{
	}

	// Token: 0x06001186 RID: 4486 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001186")]
	[Address(RVA = "0xD43830", Offset = "0xD43830", VA = "0xD43830")]
	public void Back()
	{
	}

	// Token: 0x04002236 RID: 8758
	[Token(Token = "0x4002236")]
	[FieldOffset(Offset = "0x8")]
	public bool Visible;

	// Token: 0x04002237 RID: 8759
	[Token(Token = "0x4002237")]
	[FieldOffset(Offset = "0xC")]
	public string Description;

	// Token: 0x04002238 RID: 8760
	[Token(Token = "0x4002238")]
	[FieldOffset(Offset = "0x10")]
	private GUIItemGrid.GetItemScaleHandler SeedEntryScaleDelegate;

	// Token: 0x04002239 RID: 8761
	[Token(Token = "0x4002239")]
	[FieldOffset(Offset = "0x14")]
	private GUIItemGrid.CursorOver SeedEntryOverDelegate;

	// Token: 0x0400223A RID: 8762
	[Token(Token = "0x400223A")]
	[FieldOffset(Offset = "0x18")]
	private GUIItemGrid.DrawItemHandler SeedEntryDrawDelegate;

	// Token: 0x0400223B RID: 8763
	[Token(Token = "0x400223B")]
	[FieldOffset(Offset = "0x1C")]
	private float BackScale;

	// Token: 0x0400223C RID: 8764
	[Token(Token = "0x400223C")]
	[FieldOffset(Offset = "0x20")]
	private float TitleScale;

	// Token: 0x0400223D RID: 8765
	[Token(Token = "0x400223D")]
	[FieldOffset(Offset = "0x24")]
	public float ScrollOffset;

	// Token: 0x0400223E RID: 8766
	[Token(Token = "0x400223E")]
	[FieldOffset(Offset = "0x28")]
	private float ScrollMomentum;

	// Token: 0x0400223F RID: 8767
	[Token(Token = "0x400223F")]
	[FieldOffset(Offset = "0x2C")]
	private int ScrollDragging;

	// Token: 0x04002240 RID: 8768
	[Token(Token = "0x4002240")]
	[FieldOffset(Offset = "0x30")]
	private Vector2 DragOffset;

	// Token: 0x04002241 RID: 8769
	[Token(Token = "0x4002241")]
	[FieldOffset(Offset = "0x38")]
	private GUIControllerSecretSeeds _controllerInput;

	// Token: 0x04002242 RID: 8770
	[Token(Token = "0x4002242")]
	[FieldOffset(Offset = "0x3C")]
	private GUIControllerItem _previous;
}
