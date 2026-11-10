using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001CE RID: 462
[Token(Token = "0x20001CE")]
[Serializable]
public class Panel_Layout
{
	// Token: 0x06000CF5 RID: 3317 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF5")]
	[Address(RVA = "0xC7473C", Offset = "0xC7473C", VA = "0xC7473C")]
	public void Copy(Panel_Layout other)
	{
	}

	// Token: 0x06000CF6 RID: 3318 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF6")]
	[Address(RVA = "0xC74994", Offset = "0xC74994", VA = "0xC74994")]
	public Panel_Layout()
	{
	}

	// Token: 0x0400125E RID: 4702
	[Token(Token = "0x400125E")]
	[FieldOffset(Offset = "0x8")]
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x0400125F RID: 4703
	[Token(Token = "0x400125F")]
	[FieldOffset(Offset = "0xC")]
	public LayoutCalculator.AnchorType Anchor;

	// Token: 0x04001260 RID: 4704
	[Token(Token = "0x4001260")]
	[FieldOffset(Offset = "0x10")]
	public Vector2 Location;

	// Token: 0x04001261 RID: 4705
	[Token(Token = "0x4001261")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 Size;

	// Token: 0x04001262 RID: 4706
	[Token(Token = "0x4001262")]
	[FieldOffset(Offset = "0x20")]
	public bool AnchorForSize;

	// Token: 0x04001263 RID: 4707
	[Token(Token = "0x4001263")]
	[FieldOffset(Offset = "0x24")]
	public ControlAnchor.ControlId SizeAnchorControl;

	// Token: 0x04001264 RID: 4708
	[Token(Token = "0x4001264")]
	[FieldOffset(Offset = "0x28")]
	public LayoutCalculator.AnchorType SizeAnchor;

	// Token: 0x04001265 RID: 4709
	[Token(Token = "0x4001265")]
	[FieldOffset(Offset = "0x2C")]
	public Vector2 SizeLocation;

	// Token: 0x04001266 RID: 4710
	[Token(Token = "0x4001266")]
	[FieldOffset(Offset = "0x34")]
	public Vector2 PickBorder;

	// Token: 0x04001267 RID: 4711
	[Token(Token = "0x4001267")]
	[FieldOffset(Offset = "0x3C")]
	public Vector2 PickOffset;

	// Token: 0x04001268 RID: 4712
	[Token(Token = "0x4001268")]
	[FieldOffset(Offset = "0x44")]
	public Color BackingColor;

	// Token: 0x04001269 RID: 4713
	[Token(Token = "0x4001269")]
	[FieldOffset(Offset = "0x48")]
	public Color BorderColor;

	// Token: 0x0400126A RID: 4714
	[Token(Token = "0x400126A")]
	[FieldOffset(Offset = "0x4C")]
	public Color HighlightColor;

	// Token: 0x0400126B RID: 4715
	[Token(Token = "0x400126B")]
	[FieldOffset(Offset = "0x50")]
	public Texture_Layout Backing;

	// Token: 0x0400126C RID: 4716
	[Token(Token = "0x400126C")]
	[FieldOffset(Offset = "0x54")]
	public Texture_Layout Border;

	// Token: 0x0400126D RID: 4717
	[Token(Token = "0x400126D")]
	[FieldOffset(Offset = "0x58")]
	public Texture_Layout CursorHighlight;
}
