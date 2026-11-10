using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001D6 RID: 470
[Token(Token = "0x20001D6")]
[Serializable]
public class Slider_Layout
{
	// Token: 0x06000D0D RID: 3341 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D0D")]
	[Address(RVA = "0xC781BC", Offset = "0xC781BC", VA = "0xC781BC")]
	public Slider_Layout()
	{
	}

	// Token: 0x06000D0E RID: 3342 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D0E")]
	[Address(RVA = "0xC78340", Offset = "0xC78340", VA = "0xC78340")]
	public Slider_Layout(string backingTexture, string notchTexture)
	{
	}

	// Token: 0x040012BE RID: 4798
	[Token(Token = "0x40012BE")]
	[FieldOffset(Offset = "0x8")]
	public Texture_Layout Backing;

	// Token: 0x040012BF RID: 4799
	[Token(Token = "0x40012BF")]
	[FieldOffset(Offset = "0xC")]
	public Color BackingColour;

	// Token: 0x040012C0 RID: 4800
	[Token(Token = "0x40012C0")]
	[FieldOffset(Offset = "0x10")]
	public Texture_Layout Notch;

	// Token: 0x040012C1 RID: 4801
	[Token(Token = "0x40012C1")]
	[FieldOffset(Offset = "0x14")]
	public Color NotchColour;

	// Token: 0x040012C2 RID: 4802
	[Token(Token = "0x40012C2")]
	[FieldOffset(Offset = "0x18")]
	public Texture_Layout BackingHighlight;

	// Token: 0x040012C3 RID: 4803
	[Token(Token = "0x40012C3")]
	[FieldOffset(Offset = "0x1C")]
	public Color BackingHighlightColour;

	// Token: 0x040012C4 RID: 4804
	[Token(Token = "0x40012C4")]
	[FieldOffset(Offset = "0x20")]
	public Texture_Layout NotchHighlight;

	// Token: 0x040012C5 RID: 4805
	[Token(Token = "0x40012C5")]
	[FieldOffset(Offset = "0x24")]
	public Color NotchHighlightColour;

	// Token: 0x040012C6 RID: 4806
	[Token(Token = "0x40012C6")]
	[FieldOffset(Offset = "0x28")]
	public float SliderEndCap;

	// Token: 0x040012C7 RID: 4807
	[Token(Token = "0x40012C7")]
	[FieldOffset(Offset = "0x2C")]
	public float BackingScale;

	// Token: 0x040012C8 RID: 4808
	[Token(Token = "0x40012C8")]
	[FieldOffset(Offset = "0x30")]
	public float NotchScale;

	// Token: 0x040012C9 RID: 4809
	[Token(Token = "0x40012C9")]
	[FieldOffset(Offset = "0x34")]
	public Vector2 PickBorder;

	// Token: 0x040012CA RID: 4810
	[Token(Token = "0x40012CA")]
	[FieldOffset(Offset = "0x3C")]
	public bool Vertical;

	// Token: 0x040012CB RID: 4811
	[Token(Token = "0x40012CB")]
	[FieldOffset(Offset = "0x40")]
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x040012CC RID: 4812
	[Token(Token = "0x40012CC")]
	[FieldOffset(Offset = "0x44")]
	public LayoutCalculator.AnchorType Anchor;

	// Token: 0x040012CD RID: 4813
	[Token(Token = "0x40012CD")]
	[FieldOffset(Offset = "0x48")]
	public Vector2 Location;
}
