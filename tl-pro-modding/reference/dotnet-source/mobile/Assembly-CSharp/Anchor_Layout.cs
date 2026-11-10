using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020001C2 RID: 450
[Token(Token = "0x20001C2")]
[Serializable]
public class Anchor_Layout
{
	// Token: 0x06000CA7 RID: 3239 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA7")]
	[Address(RVA = "0xC6C4DC", Offset = "0xC6C4DC", VA = "0xC6C4DC")]
	public Anchor_Layout()
	{
	}

	// Token: 0x040011D0 RID: 4560
	[Token(Token = "0x40011D0")]
	[FieldOffset(Offset = "0x8")]
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x040011D1 RID: 4561
	[Token(Token = "0x40011D1")]
	[FieldOffset(Offset = "0xC")]
	public LayoutCalculator.AnchorType Anchor;

	// Token: 0x040011D2 RID: 4562
	[Token(Token = "0x40011D2")]
	[FieldOffset(Offset = "0x10")]
	public Vector2 Location;
}
