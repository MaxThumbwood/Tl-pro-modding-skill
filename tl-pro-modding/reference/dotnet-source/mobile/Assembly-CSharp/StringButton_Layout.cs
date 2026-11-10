using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001D8 RID: 472
[Token(Token = "0x20001D8")]
[Serializable]
public class StringButton_Layout
{
	// Token: 0x06000D10 RID: 3344 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D10")]
	[Address(RVA = "0xC78664", Offset = "0xC78664", VA = "0xC78664")]
	public SpriteFont GetFont()
	{
		return null;
	}

	// Token: 0x06000D11 RID: 3345 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D11")]
	[Address(RVA = "0xC786F0", Offset = "0xC786F0", VA = "0xC786F0")]
	public StringButton_Layout()
	{
	}

	// Token: 0x040012D6 RID: 4822
	[Token(Token = "0x40012D6")]
	[FieldOffset(Offset = "0x8")]
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x040012D7 RID: 4823
	[Token(Token = "0x40012D7")]
	[FieldOffset(Offset = "0xC")]
	public LayoutCalculator.AnchorType Anchor;

	// Token: 0x040012D8 RID: 4824
	[Token(Token = "0x40012D8")]
	[FieldOffset(Offset = "0x10")]
	public Vector2 Location;

	// Token: 0x040012D9 RID: 4825
	[Token(Token = "0x40012D9")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 Size;

	// Token: 0x040012DA RID: 4826
	[Token(Token = "0x40012DA")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 PickBorder;

	// Token: 0x040012DB RID: 4827
	[Token(Token = "0x40012DB")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 PickOffset;

	// Token: 0x040012DC RID: 4828
	[Token(Token = "0x40012DC")]
	[FieldOffset(Offset = "0x30")]
	public int TextInset;

	// Token: 0x040012DD RID: 4829
	[Token(Token = "0x40012DD")]
	[FieldOffset(Offset = "0x34")]
	public Color BackingColor;

	// Token: 0x040012DE RID: 4830
	[Token(Token = "0x40012DE")]
	[FieldOffset(Offset = "0x38")]
	public Color DisabledBackingColour;

	// Token: 0x040012DF RID: 4831
	[Token(Token = "0x40012DF")]
	[FieldOffset(Offset = "0x3C")]
	public Color PressedBackingColour;

	// Token: 0x040012E0 RID: 4832
	[Token(Token = "0x40012E0")]
	[FieldOffset(Offset = "0x40")]
	public Color BorderColor;

	// Token: 0x040012E1 RID: 4833
	[Token(Token = "0x40012E1")]
	[FieldOffset(Offset = "0x44")]
	public Color DisabledBorderColour;

	// Token: 0x040012E2 RID: 4834
	[Token(Token = "0x40012E2")]
	[FieldOffset(Offset = "0x48")]
	public Color PressedBorderColour;

	// Token: 0x040012E3 RID: 4835
	[Token(Token = "0x40012E3")]
	[FieldOffset(Offset = "0x4C")]
	public Color TextColour;

	// Token: 0x040012E4 RID: 4836
	[Token(Token = "0x40012E4")]
	[FieldOffset(Offset = "0x50")]
	public Color DisabledTextColour;

	// Token: 0x040012E5 RID: 4837
	[Token(Token = "0x40012E5")]
	[FieldOffset(Offset = "0x54")]
	public Color PressedTextColour;

	// Token: 0x040012E6 RID: 4838
	[Token(Token = "0x40012E6")]
	[FieldOffset(Offset = "0x58")]
	public float Scale;

	// Token: 0x040012E7 RID: 4839
	[Token(Token = "0x40012E7")]
	[FieldOffset(Offset = "0x5C")]
	public float DisabledScale;

	// Token: 0x040012E8 RID: 4840
	[Token(Token = "0x40012E8")]
	[FieldOffset(Offset = "0x60")]
	public float PressedScale;

	// Token: 0x040012E9 RID: 4841
	[Token(Token = "0x40012E9")]
	[FieldOffset(Offset = "0x64")]
	public float ScaleSpeed;

	// Token: 0x040012EA RID: 4842
	[Token(Token = "0x40012EA")]
	[FieldOffset(Offset = "0x68")]
	public Texture_Layout BackingDisabled;

	// Token: 0x040012EB RID: 4843
	[Token(Token = "0x40012EB")]
	[FieldOffset(Offset = "0x6C")]
	public Texture_Layout BorderDisabled;

	// Token: 0x040012EC RID: 4844
	[Token(Token = "0x40012EC")]
	[FieldOffset(Offset = "0x70")]
	public Texture_Layout BackingNormal;

	// Token: 0x040012ED RID: 4845
	[Token(Token = "0x40012ED")]
	[FieldOffset(Offset = "0x74")]
	public Texture_Layout BorderNormal;

	// Token: 0x040012EE RID: 4846
	[Token(Token = "0x40012EE")]
	[FieldOffset(Offset = "0x78")]
	public Texture_Layout BackingPressed;

	// Token: 0x040012EF RID: 4847
	[Token(Token = "0x40012EF")]
	[FieldOffset(Offset = "0x7C")]
	public Texture_Layout BorderPressed;

	// Token: 0x040012F0 RID: 4848
	[Token(Token = "0x40012F0")]
	[FieldOffset(Offset = "0x80")]
	public Texture_Layout BackingHighlightPressed;

	// Token: 0x040012F1 RID: 4849
	[Token(Token = "0x40012F1")]
	[FieldOffset(Offset = "0x84")]
	public Vector2 HighlightSize;

	// Token: 0x040012F2 RID: 4850
	[Token(Token = "0x40012F2")]
	[FieldOffset(Offset = "0x8C")]
	public Color HighlightColour;

	// Token: 0x040012F3 RID: 4851
	[Token(Token = "0x40012F3")]
	[FieldOffset(Offset = "0x90")]
	public Texture_Layout OverBackingHighlight;

	// Token: 0x040012F4 RID: 4852
	[Token(Token = "0x40012F4")]
	[FieldOffset(Offset = "0x94")]
	public StringButton_Layout.FontType RenderFont;

	// Token: 0x020001D9 RID: 473
	[Token(Token = "0x20001D9")]
	public enum FontType
	{
		// Token: 0x040012F6 RID: 4854
		[Token(Token = "0x40012F6")]
		MouseText,
		// Token: 0x040012F7 RID: 4855
		[Token(Token = "0x40012F7")]
		DeathText
	}
}
