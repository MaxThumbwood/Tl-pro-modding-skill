using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001C9 RID: 457
[Token(Token = "0x20001C9")]
[Serializable]
public class DPad_Layout
{
	// Token: 0x06000CF1 RID: 3313 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF1")]
	[Address(RVA = "0xC7417C", Offset = "0xC7417C", VA = "0xC7417C")]
	public DPad_Layout()
	{
	}

	// Token: 0x0400122E RID: 4654
	[Token(Token = "0x400122E")]
	[FieldOffset(Offset = "0x8")]
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x0400122F RID: 4655
	[Token(Token = "0x400122F")]
	[FieldOffset(Offset = "0xC")]
	public LayoutCalculator.AnchorType Anchor;

	// Token: 0x04001230 RID: 4656
	[Token(Token = "0x4001230")]
	[FieldOffset(Offset = "0x10")]
	public Vector2 CentreLocation;

	// Token: 0x04001231 RID: 4657
	[Token(Token = "0x4001231")]
	[FieldOffset(Offset = "0x18")]
	public float Scale;

	// Token: 0x04001232 RID: 4658
	[Token(Token = "0x4001232")]
	[FieldOffset(Offset = "0x1C")]
	public Vector2 LeftOffset;

	// Token: 0x04001233 RID: 4659
	[Token(Token = "0x4001233")]
	[FieldOffset(Offset = "0x24")]
	public Vector2 RightOffset;

	// Token: 0x04001234 RID: 4660
	[Token(Token = "0x4001234")]
	[FieldOffset(Offset = "0x2C")]
	public Vector2 TopOffset;

	// Token: 0x04001235 RID: 4661
	[Token(Token = "0x4001235")]
	[FieldOffset(Offset = "0x34")]
	public Vector2 BottomOffset;

	// Token: 0x04001236 RID: 4662
	[Token(Token = "0x4001236")]
	[FieldOffset(Offset = "0x3C")]
	public Color Color;

	// Token: 0x04001237 RID: 4663
	[Token(Token = "0x4001237")]
	[FieldOffset(Offset = "0x40")]
	public Vector2 PickSize;

	// Token: 0x04001238 RID: 4664
	[Token(Token = "0x4001238")]
	[FieldOffset(Offset = "0x48")]
	public Vector2 DeadZone;
}
