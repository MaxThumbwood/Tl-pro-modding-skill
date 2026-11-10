using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200001E RID: 30
[Token(Token = "0x200001E")]
public class Cursor
{
	// Token: 0x06000088 RID: 136 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000088")]
	[Address(RVA = "0x499AEC", Offset = "0x499AEC", VA = "0x499AEC")]
	public Cursor()
	{
	}

	// Token: 0x040002B4 RID: 692
	[Token(Token = "0x40002B4")]
	[FieldOffset(Offset = "0x8")]
	public Vector2 Position;

	// Token: 0x040002B5 RID: 693
	[Token(Token = "0x40002B5")]
	[FieldOffset(Offset = "0x10")]
	public Vector2 OldPosition;

	// Token: 0x040002B6 RID: 694
	[Token(Token = "0x40002B6")]
	[FieldOffset(Offset = "0x18")]
	public int Id;

	// Token: 0x040002B7 RID: 695
	[Token(Token = "0x40002B7")]
	[FieldOffset(Offset = "0x1C")]
	public bool Down;

	// Token: 0x040002B8 RID: 696
	[Token(Token = "0x40002B8")]
	[FieldOffset(Offset = "0x1D")]
	public bool WasDown;

	// Token: 0x040002B9 RID: 697
	[Token(Token = "0x40002B9")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 CursorScroll;

	// Token: 0x040002BA RID: 698
	[Token(Token = "0x40002BA")]
	[FieldOffset(Offset = "0x28")]
	public bool Dead;

	// Token: 0x040002BB RID: 699
	[Token(Token = "0x40002BB")]
	[FieldOffset(Offset = "0x29")]
	public bool IgnoreForWorld;

	// Token: 0x040002BC RID: 700
	[Token(Token = "0x40002BC")]
	[FieldOffset(Offset = "0x2A")]
	public bool Ignore;

	// Token: 0x040002BD RID: 701
	[Token(Token = "0x40002BD")]
	[FieldOffset(Offset = "0x2C")]
	public CursorInputLayer InputLayer;

	// Token: 0x040002BE RID: 702
	[Token(Token = "0x40002BE")]
	[FieldOffset(Offset = "0x30")]
	public object InputLayerData;

	// Token: 0x040002BF RID: 703
	[Token(Token = "0x40002BF")]
	[FieldOffset(Offset = "0x34")]
	public object InputLayerData2;

	// Token: 0x040002C0 RID: 704
	[Token(Token = "0x40002C0")]
	[FieldOffset(Offset = "0x38")]
	public DateTime LastUpdate;
}
