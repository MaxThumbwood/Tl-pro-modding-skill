using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001D7 RID: 471
[Token(Token = "0x20001D7")]
[Serializable]
public class Stretched_Layout
{
	// Token: 0x06000D0F RID: 3343 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D0F")]
	[Address(RVA = "0xC78540", Offset = "0xC78540", VA = "0xC78540")]
	public Stretched_Layout()
	{
	}

	// Token: 0x040012CE RID: 4814
	[Token(Token = "0x40012CE")]
	[FieldOffset(Offset = "0x8")]
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x040012CF RID: 4815
	[Token(Token = "0x40012CF")]
	[FieldOffset(Offset = "0xC")]
	public LayoutCalculator.AnchorType Anchor;

	// Token: 0x040012D0 RID: 4816
	[Token(Token = "0x40012D0")]
	[FieldOffset(Offset = "0x10")]
	public Vector2 Location;

	// Token: 0x040012D1 RID: 4817
	[Token(Token = "0x40012D1")]
	[FieldOffset(Offset = "0x18")]
	public Color Color;

	// Token: 0x040012D2 RID: 4818
	[Token(Token = "0x40012D2")]
	[FieldOffset(Offset = "0x1C")]
	public float Size;

	// Token: 0x040012D3 RID: 4819
	[Token(Token = "0x40012D3")]
	[FieldOffset(Offset = "0x20")]
	public float Scale;

	// Token: 0x040012D4 RID: 4820
	[Token(Token = "0x40012D4")]
	[FieldOffset(Offset = "0x24")]
	public bool Vertical;

	// Token: 0x040012D5 RID: 4821
	[Token(Token = "0x40012D5")]
	[FieldOffset(Offset = "0x28")]
	public Texture_Layout Backing;
}
