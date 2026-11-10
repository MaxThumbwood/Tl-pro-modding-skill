using System;
using Il2CppDummyDll;

// Token: 0x0200016B RID: 363
[Token(Token = "0x200016B")]
public class GUIMouseItem
{
	// Token: 0x170000E5 RID: 229
	// (get) Token: 0x06000A45 RID: 2629 RVA: 0x00006210 File Offset: 0x00004410
	[Token(Token = "0x170000E5")]
	public bool HoldingItem
	{
		[Token(Token = "0x6000A45")]
		[Address(RVA = "0xBABF24", Offset = "0xBABF24", VA = "0xBABF24")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000E6 RID: 230
	// (get) Token: 0x06000A46 RID: 2630 RVA: 0x00006228 File Offset: 0x00004428
	[Token(Token = "0x170000E6")]
	public bool BeingDragged
	{
		[Token(Token = "0x6000A46")]
		[Address(RVA = "0xBABFE0", Offset = "0xBABFE0", VA = "0xBABFE0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000E7 RID: 231
	// (get) Token: 0x06000A47 RID: 2631 RVA: 0x00006240 File Offset: 0x00004440
	[Token(Token = "0x170000E7")]
	public bool IsItemDropped
	{
		[Token(Token = "0x6000A47")]
		[Address(RVA = "0xBABFE8", Offset = "0xBABFE8", VA = "0xBABFE8")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000A48 RID: 2632 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A48")]
	[Address(RVA = "0xBAC2EC", Offset = "0xBAC2EC", VA = "0xBAC2EC")]
	public void BeginDrag(bool dragging)
	{
	}

	// Token: 0x06000A49 RID: 2633 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A49")]
	[Address(RVA = "0xBAC360", Offset = "0xBAC360", VA = "0xBAC360")]
	public void DisableDrag()
	{
	}

	// Token: 0x06000A4A RID: 2634 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A4A")]
	[Address(RVA = "0xBAC3D4", Offset = "0xBAC3D4", VA = "0xBAC3D4")]
	public GUIMouseItem()
	{
	}

	// Token: 0x04000C6C RID: 3180
	[Token(Token = "0x4000C6C")]
	[FieldOffset(Offset = "0x8")]
	private int mouseDragStart;

	// Token: 0x04000C6D RID: 3181
	[Token(Token = "0x4000C6D")]
	[FieldOffset(Offset = "0xC")]
	private bool mouseItemHoldDrag;

	// Token: 0x04000C6E RID: 3182
	[Token(Token = "0x4000C6E")]
	[FieldOffset(Offset = "0xD")]
	private bool disableDrag;

	// Token: 0x04000C6F RID: 3183
	[Token(Token = "0x4000C6F")]
	[FieldOffset(Offset = "0x10")]
	private int disableDragStart;
}
