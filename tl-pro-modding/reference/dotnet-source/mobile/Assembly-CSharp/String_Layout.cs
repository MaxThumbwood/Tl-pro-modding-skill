using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001DA RID: 474
[Token(Token = "0x20001DA")]
[Serializable]
public class String_Layout
{
	// Token: 0x06000D12 RID: 3346 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D12")]
	[Address(RVA = "0xC78B2C", Offset = "0xC78B2C", VA = "0xC78B2C")]
	public void Copy(String_Layout other)
	{
	}

	// Token: 0x06000D13 RID: 3347 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D13")]
	[Address(RVA = "0xC78C58", Offset = "0xC78C58", VA = "0xC78C58")]
	public SpriteFont GetFont()
	{
		return null;
	}

	// Token: 0x06000D14 RID: 3348 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D14")]
	[Address(RVA = "0xC74664", Offset = "0xC74664", VA = "0xC74664")]
	public String_Layout()
	{
	}

	// Token: 0x040012F8 RID: 4856
	[Token(Token = "0x40012F8")]
	[FieldOffset(Offset = "0x8")]
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x040012F9 RID: 4857
	[Token(Token = "0x40012F9")]
	[FieldOffset(Offset = "0xC")]
	public LayoutCalculator.AnchorType Anchor;

	// Token: 0x040012FA RID: 4858
	[Token(Token = "0x40012FA")]
	[FieldOffset(Offset = "0x10")]
	public Vector2 Location;

	// Token: 0x040012FB RID: 4859
	[Token(Token = "0x40012FB")]
	[FieldOffset(Offset = "0x18")]
	public Color Color;

	// Token: 0x040012FC RID: 4860
	[Token(Token = "0x40012FC")]
	[FieldOffset(Offset = "0x1C")]
	public LayoutCalculator.AnchorType Alignment;

	// Token: 0x040012FD RID: 4861
	[Token(Token = "0x40012FD")]
	[FieldOffset(Offset = "0x20")]
	public float Scale;

	// Token: 0x040012FE RID: 4862
	[Token(Token = "0x40012FE")]
	[FieldOffset(Offset = "0x24")]
	public String_Layout.FontType RenderFont;

	// Token: 0x040012FF RID: 4863
	[Token(Token = "0x40012FF")]
	[FieldOffset(Offset = "0x28")]
	public bool MultiLineUseAlignment;

	// Token: 0x04001300 RID: 4864
	[Token(Token = "0x4001300")]
	[FieldOffset(Offset = "0x2C")]
	public float WrapWidth;

	// Token: 0x04001301 RID: 4865
	[Token(Token = "0x4001301")]
	[FieldOffset(Offset = "0x30")]
	public int MaxLines;

	// Token: 0x04001302 RID: 4866
	[Token(Token = "0x4001302")]
	[FieldOffset(Offset = "0x34")]
	public float MultilineScale;

	// Token: 0x020001DB RID: 475
	[Token(Token = "0x20001DB")]
	public enum FontType
	{
		// Token: 0x04001304 RID: 4868
		[Token(Token = "0x4001304")]
		MouseText,
		// Token: 0x04001305 RID: 4869
		[Token(Token = "0x4001305")]
		DeathText
	}
}
