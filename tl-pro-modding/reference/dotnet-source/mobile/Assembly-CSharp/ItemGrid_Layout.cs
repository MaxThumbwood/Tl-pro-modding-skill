using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020001CC RID: 460
[Token(Token = "0x20001CC")]
[Serializable]
public class ItemGrid_Layout
{
	// Token: 0x06000CF4 RID: 3316 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF4")]
	[Address(RVA = "0xC74420", Offset = "0xC74420", VA = "0xC74420")]
	public ItemGrid_Layout()
	{
	}

	// Token: 0x0400124A RID: 4682
	[Token(Token = "0x400124A")]
	[FieldOffset(Offset = "0x8")]
	public bool Horizontal;

	// Token: 0x0400124B RID: 4683
	[Token(Token = "0x400124B")]
	[FieldOffset(Offset = "0xC")]
	public ItemGrid_Layout.ReorderStyle Reorder;

	// Token: 0x0400124C RID: 4684
	[Token(Token = "0x400124C")]
	[FieldOffset(Offset = "0x10")]
	public int ItemCount;

	// Token: 0x0400124D RID: 4685
	[Token(Token = "0x400124D")]
	[FieldOffset(Offset = "0x14")]
	public int ItemLineCount;

	// Token: 0x0400124E RID: 4686
	[Token(Token = "0x400124E")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 PickingBorder;

	// Token: 0x0400124F RID: 4687
	[Token(Token = "0x400124F")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 PickingOffset;

	// Token: 0x04001250 RID: 4688
	[Token(Token = "0x4001250")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 ExtraElementSpacing;

	// Token: 0x04001251 RID: 4689
	[Token(Token = "0x4001251")]
	[FieldOffset(Offset = "0x30")]
	public ControlAnchor.ControlId FirstAnchorControl;

	// Token: 0x04001252 RID: 4690
	[Token(Token = "0x4001252")]
	[FieldOffset(Offset = "0x34")]
	public LayoutCalculator.AnchorType FirstItemAnchor;

	// Token: 0x04001253 RID: 4691
	[Token(Token = "0x4001253")]
	[FieldOffset(Offset = "0x38")]
	public Vector2 FirstItemLocation;

	// Token: 0x04001254 RID: 4692
	[Token(Token = "0x4001254")]
	[FieldOffset(Offset = "0x40")]
	public Vector2 StackCountOffset;

	// Token: 0x04001255 RID: 4693
	[Token(Token = "0x4001255")]
	[FieldOffset(Offset = "0x48")]
	public Vector2 AmmoCountOffset;

	// Token: 0x04001256 RID: 4694
	[Token(Token = "0x4001256")]
	[FieldOffset(Offset = "0x50")]
	public bool CentreAlign;

	// Token: 0x04001257 RID: 4695
	[Token(Token = "0x4001257")]
	[FieldOffset(Offset = "0x51")]
	public bool RightAlign;

	// Token: 0x020001CD RID: 461
	[Token(Token = "0x20001CD")]
	public enum ReorderStyle
	{
		// Token: 0x04001259 RID: 4697
		[Token(Token = "0x4001259")]
		None,
		// Token: 0x0400125A RID: 4698
		[Token(Token = "0x400125A")]
		ReverseAllItems,
		// Token: 0x0400125B RID: 4699
		[Token(Token = "0x400125B")]
		ReverseLine,
		// Token: 0x0400125C RID: 4700
		[Token(Token = "0x400125C")]
		ReverseColumns,
		// Token: 0x0400125D RID: 4701
		[Token(Token = "0x400125D")]
		SwapColumns
	}
}
