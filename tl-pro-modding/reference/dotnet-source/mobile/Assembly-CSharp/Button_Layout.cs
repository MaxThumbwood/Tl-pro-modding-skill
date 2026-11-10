using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001C6 RID: 454
[Token(Token = "0x20001C6")]
[Serializable]
public class Button_Layout
{
	// Token: 0x06000CAE RID: 3246 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CAE")]
	[Address(RVA = "0xC6D970", Offset = "0xC6D970", VA = "0xC6D970")]
	public Button_Layout()
	{
	}

	// Token: 0x040011FA RID: 4602
	[Token(Token = "0x40011FA")]
	[FieldOffset(Offset = "0x8")]
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x040011FB RID: 4603
	[Token(Token = "0x40011FB")]
	[FieldOffset(Offset = "0xC")]
	public LayoutCalculator.AnchorType Anchor;

	// Token: 0x040011FC RID: 4604
	[Token(Token = "0x40011FC")]
	[FieldOffset(Offset = "0x10")]
	public Vector2 Location;

	// Token: 0x040011FD RID: 4605
	[Token(Token = "0x40011FD")]
	[FieldOffset(Offset = "0x18")]
	public float Scale;

	// Token: 0x040011FE RID: 4606
	[Token(Token = "0x40011FE")]
	[FieldOffset(Offset = "0x1C")]
	public Vector2 PickBorder;

	// Token: 0x040011FF RID: 4607
	[Token(Token = "0x40011FF")]
	[FieldOffset(Offset = "0x24")]
	public Vector2 PickOffset;

	// Token: 0x04001200 RID: 4608
	[Token(Token = "0x4001200")]
	[FieldOffset(Offset = "0x2C")]
	public Color Color;

	// Token: 0x04001201 RID: 4609
	[Token(Token = "0x4001201")]
	[FieldOffset(Offset = "0x30")]
	public bool UseCirclePickingRegion;
}
