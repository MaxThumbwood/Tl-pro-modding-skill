using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001C3 RID: 451
[Token(Token = "0x20001C3")]
[Serializable]
public class AnimatedTexture_Layout
{
	// Token: 0x06000CA8 RID: 3240 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA8")]
	[Address(RVA = "0xC6C4EC", Offset = "0xC6C4EC", VA = "0xC6C4EC")]
	public AnimatedTexture_Layout()
	{
	}

	// Token: 0x040011D3 RID: 4563
	[Token(Token = "0x40011D3")]
	[FieldOffset(Offset = "0x8")]
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x040011D4 RID: 4564
	[Token(Token = "0x40011D4")]
	[FieldOffset(Offset = "0xC")]
	public LayoutCalculator.AnchorType Anchor;

	// Token: 0x040011D5 RID: 4565
	[Token(Token = "0x40011D5")]
	[FieldOffset(Offset = "0x10")]
	public Vector2 Location;

	// Token: 0x040011D6 RID: 4566
	[Token(Token = "0x40011D6")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 Size;

	// Token: 0x040011D7 RID: 4567
	[Token(Token = "0x40011D7")]
	[FieldOffset(Offset = "0x20")]
	public bool AnchorForSize;

	// Token: 0x040011D8 RID: 4568
	[Token(Token = "0x40011D8")]
	[FieldOffset(Offset = "0x24")]
	public ControlAnchor.ControlId SizeAnchorControl;

	// Token: 0x040011D9 RID: 4569
	[Token(Token = "0x40011D9")]
	[FieldOffset(Offset = "0x28")]
	public LayoutCalculator.AnchorType SizeAnchor;

	// Token: 0x040011DA RID: 4570
	[Token(Token = "0x40011DA")]
	[FieldOffset(Offset = "0x2C")]
	public Vector2 SizeLocation;

	// Token: 0x040011DB RID: 4571
	[Token(Token = "0x40011DB")]
	[FieldOffset(Offset = "0x34")]
	public Vector2 PickBorder;

	// Token: 0x040011DC RID: 4572
	[Token(Token = "0x40011DC")]
	[FieldOffset(Offset = "0x3C")]
	public Vector2 PickOffset;

	// Token: 0x040011DD RID: 4573
	[Token(Token = "0x40011DD")]
	[FieldOffset(Offset = "0x44")]
	public Color Color;

	// Token: 0x040011DE RID: 4574
	[Token(Token = "0x40011DE")]
	[FieldOffset(Offset = "0x48")]
	public Texture_Layout Texture;

	// Token: 0x040011DF RID: 4575
	[Token(Token = "0x40011DF")]
	[FieldOffset(Offset = "0x4C")]
	public int NumXFrames;

	// Token: 0x040011E0 RID: 4576
	[Token(Token = "0x40011E0")]
	[FieldOffset(Offset = "0x50")]
	public int NumYFrames;
}
