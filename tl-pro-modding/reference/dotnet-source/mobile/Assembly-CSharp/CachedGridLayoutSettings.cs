using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020001AF RID: 431
[Token(Token = "0x20001AF")]
public class CachedGridLayoutSettings
{
	// Token: 0x06000C88 RID: 3208 RVA: 0x00007128 File Offset: 0x00005328
	[Token(Token = "0x6000C88")]
	[Address(RVA = "0xC67304", Offset = "0xC67304", VA = "0xC67304")]
	public bool Dirty(ItemGrid_Layout layout)
	{
		return default(bool);
	}

	// Token: 0x06000C89 RID: 3209 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C89")]
	[Address(RVA = "0xC67588", Offset = "0xC67588", VA = "0xC67588")]
	public void Cache(ItemGrid_Layout layout)
	{
	}

	// Token: 0x06000C8A RID: 3210 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C8A")]
	[Address(RVA = "0xC67764", Offset = "0xC67764", VA = "0xC67764")]
	public CachedGridLayoutSettings()
	{
	}

	// Token: 0x0400106E RID: 4206
	[Token(Token = "0x400106E")]
	[FieldOffset(Offset = "0x8")]
	public bool Horizontal;

	// Token: 0x0400106F RID: 4207
	[Token(Token = "0x400106F")]
	[FieldOffset(Offset = "0xC")]
	public ItemGrid_Layout.ReorderStyle Reorder;

	// Token: 0x04001070 RID: 4208
	[Token(Token = "0x4001070")]
	[FieldOffset(Offset = "0x10")]
	public int ItemCount;

	// Token: 0x04001071 RID: 4209
	[Token(Token = "0x4001071")]
	[FieldOffset(Offset = "0x14")]
	public int ItemLineCount;

	// Token: 0x04001072 RID: 4210
	[Token(Token = "0x4001072")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 PickingBorder;

	// Token: 0x04001073 RID: 4211
	[Token(Token = "0x4001073")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 PickingOffset;

	// Token: 0x04001074 RID: 4212
	[Token(Token = "0x4001074")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 ExtraElementSpacing;

	// Token: 0x04001075 RID: 4213
	[Token(Token = "0x4001075")]
	[FieldOffset(Offset = "0x30")]
	public ControlAnchor.ControlId FirstAnchorControl;

	// Token: 0x04001076 RID: 4214
	[Token(Token = "0x4001076")]
	[FieldOffset(Offset = "0x34")]
	public LayoutCalculator.AnchorType FirstItemAnchor;

	// Token: 0x04001077 RID: 4215
	[Token(Token = "0x4001077")]
	[FieldOffset(Offset = "0x38")]
	public Vector2 FirstItemLocation;

	// Token: 0x04001078 RID: 4216
	[Token(Token = "0x4001078")]
	[FieldOffset(Offset = "0x40")]
	public int ScreenWidth;

	// Token: 0x04001079 RID: 4217
	[Token(Token = "0x4001079")]
	[FieldOffset(Offset = "0x44")]
	public int ScreenHeight;
}
