using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001CF RID: 463
[Token(Token = "0x20001CF")]
[Serializable]
public class PopoutMenu_Layout
{
	// Token: 0x06000CF7 RID: 3319 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF7")]
	[Address(RVA = "0xC74C04", Offset = "0xC74C04", VA = "0xC74C04")]
	public PopoutMenu_Layout()
	{
	}

	// Token: 0x0400126E RID: 4718
	[Token(Token = "0x400126E")]
	[FieldOffset(Offset = "0x8")]
	public QuickActionButton_Layout MenuButton;

	// Token: 0x0400126F RID: 4719
	[Token(Token = "0x400126F")]
	[FieldOffset(Offset = "0xC")]
	public PopoutMenu_Layout.ReorderStyle Reorder;

	// Token: 0x04001270 RID: 4720
	[Token(Token = "0x4001270")]
	[FieldOffset(Offset = "0x10")]
	public String_Layout ElementLayout;

	// Token: 0x04001271 RID: 4721
	[Token(Token = "0x4001271")]
	[FieldOffset(Offset = "0x14")]
	public float ElementSpacing;

	// Token: 0x04001272 RID: 4722
	[Token(Token = "0x4001272")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 BackingTLOffset;

	// Token: 0x04001273 RID: 4723
	[Token(Token = "0x4001273")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 BackingBROffset;

	// Token: 0x04001274 RID: 4724
	[Token(Token = "0x4001274")]
	[FieldOffset(Offset = "0x28")]
	public Color BackingColor;

	// Token: 0x020001D0 RID: 464
	[Token(Token = "0x20001D0")]
	public enum ReorderStyle
	{
		// Token: 0x04001276 RID: 4726
		[Token(Token = "0x4001276")]
		None,
		// Token: 0x04001277 RID: 4727
		[Token(Token = "0x4001277")]
		Reverse
	}
}
