using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020001CA RID: 458
[Token(Token = "0x20001CA")]
[Serializable]
public class DraggableItemGrid_Layout : ItemGrid_Layout
{
	// Token: 0x06000CF2 RID: 3314 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF2")]
	[Address(RVA = "0xC74360", Offset = "0xC74360", VA = "0xC74360")]
	public DraggableItemGrid_Layout()
	{
	}

	// Token: 0x04001239 RID: 4665
	[Token(Token = "0x4001239")]
	[FieldOffset(Offset = "0x54")]
	public float MomentumScale;

	// Token: 0x0400123A RID: 4666
	[Token(Token = "0x400123A")]
	[FieldOffset(Offset = "0x58")]
	public float MomentumDampen;

	// Token: 0x0400123B RID: 4667
	[Token(Token = "0x400123B")]
	[FieldOffset(Offset = "0x5C")]
	public float MomentumExtraDampenOutOfBounds;

	// Token: 0x0400123C RID: 4668
	[Token(Token = "0x400123C")]
	[FieldOffset(Offset = "0x60")]
	public float OutOfBoundsOffsetLerpScale;

	// Token: 0x0400123D RID: 4669
	[Token(Token = "0x400123D")]
	[FieldOffset(Offset = "0x64")]
	public int AlphaFalloff;

	// Token: 0x0400123E RID: 4670
	[Token(Token = "0x400123E")]
	[FieldOffset(Offset = "0x68")]
	public bool DragHorizontal;

	// Token: 0x0400123F RID: 4671
	[Token(Token = "0x400123F")]
	[FieldOffset(Offset = "0x6C")]
	public float DragThreshold;

	// Token: 0x04001240 RID: 4672
	[Token(Token = "0x4001240")]
	[FieldOffset(Offset = "0x70")]
	public bool EnableDragUnderLimit;

	// Token: 0x04001241 RID: 4673
	[Token(Token = "0x4001241")]
	[FieldOffset(Offset = "0x74")]
	public Vector2 MaxDragRegion;

	// Token: 0x04001242 RID: 4674
	[Token(Token = "0x4001242")]
	[FieldOffset(Offset = "0x7C")]
	public bool ExplicitDragRegionSize;

	// Token: 0x04001243 RID: 4675
	[Token(Token = "0x4001243")]
	[FieldOffset(Offset = "0x80")]
	public ControlAnchor.ControlId DragRegionEndAnchorControl;

	// Token: 0x04001244 RID: 4676
	[Token(Token = "0x4001244")]
	[FieldOffset(Offset = "0x84")]
	public LayoutCalculator.AnchorType DragRegionEndItemAnchor;

	// Token: 0x04001245 RID: 4677
	[Token(Token = "0x4001245")]
	[FieldOffset(Offset = "0x88")]
	public Vector2 DragRegionEndItemLocation;

	// Token: 0x04001246 RID: 4678
	[Token(Token = "0x4001246")]
	[FieldOffset(Offset = "0x90")]
	public int DragRegionTopOffset;

	// Token: 0x04001247 RID: 4679
	[Token(Token = "0x4001247")]
	[FieldOffset(Offset = "0x94")]
	public int DragRegionBottomOffset;
}
