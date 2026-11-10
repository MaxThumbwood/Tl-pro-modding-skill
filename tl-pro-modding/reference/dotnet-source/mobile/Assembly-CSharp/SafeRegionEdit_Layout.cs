using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000232 RID: 562
[Token(Token = "0x2000232")]
public class SafeRegionEdit_Layout : LayoutDefinition
{
	// Token: 0x06000E23 RID: 3619 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E23")]
	[Address(RVA = "0xC91928", Offset = "0xC91928", VA = "0xC91928")]
	private void Awake()
	{
	}

	// Token: 0x06000E24 RID: 3620 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E24")]
	[Address(RVA = "0xC9197C", Offset = "0xC9197C", VA = "0xC9197C")]
	public SafeRegionEdit_Layout()
	{
	}

	// Token: 0x0400188A RID: 6282
	[Token(Token = "0x400188A")]
	[FieldOffset(Offset = "0x0")]
	public static SafeRegionEdit_Layout Instance;

	// Token: 0x0400188B RID: 6283
	[Token(Token = "0x400188B")]
	[FieldOffset(Offset = "0xC")]
	public float ButtonEdgeInset;

	// Token: 0x0400188C RID: 6284
	[Token(Token = "0x400188C")]
	[FieldOffset(Offset = "0x10")]
	public float MaxEdgeMovementScale;

	// Token: 0x0400188D RID: 6285
	[Token(Token = "0x400188D")]
	[FieldOffset(Offset = "0x14")]
	public float ControllerDragSpeed;

	// Token: 0x0400188E RID: 6286
	[Token(Token = "0x400188E")]
	[FieldOffset(Offset = "0x18")]
	public Color DefaultLinkColor;

	// Token: 0x0400188F RID: 6287
	[Token(Token = "0x400188F")]
	[FieldOffset(Offset = "0x1C")]
	public Color DraggingLinkColor;

	// Token: 0x04001890 RID: 6288
	[Token(Token = "0x4001890")]
	[FieldOffset(Offset = "0x20")]
	public Panel_Layout ScreenBacking;

	// Token: 0x04001891 RID: 6289
	[Token(Token = "0x4001891")]
	[FieldOffset(Offset = "0x24")]
	public Panel_Layout ScreenEdge;

	// Token: 0x04001892 RID: 6290
	[Token(Token = "0x4001892")]
	[FieldOffset(Offset = "0x28")]
	public Panel_Layout ScreenEdgeTop;

	// Token: 0x04001893 RID: 6291
	[Token(Token = "0x4001893")]
	[FieldOffset(Offset = "0x2C")]
	public Panel_Layout ScreenEdgeLeft;

	// Token: 0x04001894 RID: 6292
	[Token(Token = "0x4001894")]
	[FieldOffset(Offset = "0x30")]
	public Panel_Layout ScreenEdgeRight;

	// Token: 0x04001895 RID: 6293
	[Token(Token = "0x4001895")]
	[FieldOffset(Offset = "0x34")]
	public Panel_Layout ScreenEdgeBottom;

	// Token: 0x04001896 RID: 6294
	[Token(Token = "0x4001896")]
	[FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout Left;

	// Token: 0x04001897 RID: 6295
	[Token(Token = "0x4001897")]
	[FieldOffset(Offset = "0x3C")]
	public Panel_Layout LeftLink;

	// Token: 0x04001898 RID: 6296
	[Token(Token = "0x4001898")]
	[FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout Right;

	// Token: 0x04001899 RID: 6297
	[Token(Token = "0x4001899")]
	[FieldOffset(Offset = "0x44")]
	public Panel_Layout RightLink;

	// Token: 0x0400189A RID: 6298
	[Token(Token = "0x400189A")]
	[FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout Top;

	// Token: 0x0400189B RID: 6299
	[Token(Token = "0x400189B")]
	[FieldOffset(Offset = "0x4C")]
	public Panel_Layout TopLink;

	// Token: 0x0400189C RID: 6300
	[Token(Token = "0x400189C")]
	[FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout Bottom;

	// Token: 0x0400189D RID: 6301
	[Token(Token = "0x400189D")]
	[FieldOffset(Offset = "0x54")]
	public Panel_Layout BottomLink;

	// Token: 0x0400189E RID: 6302
	[Token(Token = "0x400189E")]
	[FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout Finish;

	// Token: 0x0400189F RID: 6303
	[Token(Token = "0x400189F")]
	[FieldOffset(Offset = "0x5C")]
	public TransactionButton_Layout Reset;
}
