using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001D1 RID: 465
[Token(Token = "0x20001D1")]
[Serializable]
public class ProgressBar_Layout
{
	// Token: 0x06000CF8 RID: 3320 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF8")]
	[Address(RVA = "0xC74CE4", Offset = "0xC74CE4", VA = "0xC74CE4")]
	public ProgressBar_Layout()
	{
	}

	// Token: 0x06000CF9 RID: 3321 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF9")]
	[Address(RVA = "0xC74ED0", Offset = "0xC74ED0", VA = "0xC74ED0")]
	public ProgressBar_Layout(string backingTexture)
	{
	}

	// Token: 0x04001278 RID: 4728
	[Token(Token = "0x4001278")]
	[FieldOffset(Offset = "0x8")]
	public Texture_Layout Backing;

	// Token: 0x04001279 RID: 4729
	[Token(Token = "0x4001279")]
	[FieldOffset(Offset = "0xC")]
	public float BackingScale;

	// Token: 0x0400127A RID: 4730
	[Token(Token = "0x400127A")]
	[FieldOffset(Offset = "0x10")]
	private bool Vertical;

	// Token: 0x0400127B RID: 4731
	[Token(Token = "0x400127B")]
	[FieldOffset(Offset = "0x14")]
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x0400127C RID: 4732
	[Token(Token = "0x400127C")]
	[FieldOffset(Offset = "0x18")]
	public LayoutCalculator.AnchorType Anchor;

	// Token: 0x0400127D RID: 4733
	[Token(Token = "0x400127D")]
	[FieldOffset(Offset = "0x1C")]
	public Vector2 Location;

	// Token: 0x0400127E RID: 4734
	[Token(Token = "0x400127E")]
	[FieldOffset(Offset = "0x24")]
	public Vector2 FillingSize;

	// Token: 0x0400127F RID: 4735
	[Token(Token = "0x400127F")]
	[FieldOffset(Offset = "0x2C")]
	public Vector2 FillingLocation;

	// Token: 0x04001280 RID: 4736
	[Token(Token = "0x4001280")]
	[FieldOffset(Offset = "0x34")]
	public Color FillingColor;

	// Token: 0x04001281 RID: 4737
	[Token(Token = "0x4001281")]
	[FieldOffset(Offset = "0x38")]
	public Color FillingColorEmpty;
}
