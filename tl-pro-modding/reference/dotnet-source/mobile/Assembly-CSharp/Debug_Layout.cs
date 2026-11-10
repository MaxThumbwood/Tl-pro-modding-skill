using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001EA RID: 490
[Token(Token = "0x20001EA")]
public class Debug_Layout : LayoutDefinition
{
	// Token: 0x06000D3F RID: 3391 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D3F")]
	[Address(RVA = "0xC7BEE0", Offset = "0xC7BEE0", VA = "0xC7BEE0")]
	private void Awake()
	{
	}

	// Token: 0x06000D40 RID: 3392 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D40")]
	[Address(RVA = "0xC7BF34", Offset = "0xC7BF34", VA = "0xC7BF34")]
	public Debug_Layout()
	{
	}

	// Token: 0x04001451 RID: 5201
	[Token(Token = "0x4001451")]
	[FieldOffset(Offset = "0x0")]
	public static Debug_Layout Instance;

	// Token: 0x04001452 RID: 5202
	[Token(Token = "0x4001452")]
	[FieldOffset(Offset = "0xC")]
	public LayoutCalculator.AnchorType DebugAnchor;

	// Token: 0x04001453 RID: 5203
	[Token(Token = "0x4001453")]
	[FieldOffset(Offset = "0x10")]
	public Vector2 DebugIconLocation;

	// Token: 0x04001454 RID: 5204
	[Token(Token = "0x4001454")]
	[FieldOffset(Offset = "0x18")]
	public float DebugIconScale;

	// Token: 0x04001455 RID: 5205
	[Token(Token = "0x4001455")]
	[FieldOffset(Offset = "0x1C")]
	public Vector2 DebugIconPickBorder;

	// Token: 0x04001456 RID: 5206
	[Token(Token = "0x4001456")]
	[FieldOffset(Offset = "0x24")]
	public Color DebugIconColor;

	// Token: 0x04001457 RID: 5207
	[Token(Token = "0x4001457")]
	[FieldOffset(Offset = "0x28")]
	public Panel_Layout Backing;

	// Token: 0x04001458 RID: 5208
	[Token(Token = "0x4001458")]
	[FieldOffset(Offset = "0x2C")]
	public TransactionButton_Layout Text;

	// Token: 0x04001459 RID: 5209
	[Token(Token = "0x4001459")]
	[FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout Send;

	// Token: 0x0400145A RID: 5210
	[Token(Token = "0x400145A")]
	[FieldOffset(Offset = "0x34")]
	public TransactionButton_Layout Close;
}
