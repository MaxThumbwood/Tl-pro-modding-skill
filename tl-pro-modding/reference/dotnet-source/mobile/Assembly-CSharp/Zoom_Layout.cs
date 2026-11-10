using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using UnityEngine;

// Token: 0x0200027E RID: 638
[Token(Token = "0x200027E")]
public class Zoom_Layout : LayoutDefinition
{
	// Token: 0x06000ED9 RID: 3801 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ED9")]
	[Address(RVA = "0xC9E9B8", Offset = "0xC9E9B8", VA = "0xC9E9B8")]
	private void Awake()
	{
	}

	// Token: 0x06000EDA RID: 3802 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EDA")]
	[Address(RVA = "0xC9EA0C", Offset = "0xC9EA0C", VA = "0xC9EA0C")]
	public Zoom_Layout()
	{
	}

	// Token: 0x04001EC4 RID: 7876
	[Token(Token = "0x4001EC4")]
	[FieldOffset(Offset = "0x0")]
	public static Zoom_Layout Instance;

	// Token: 0x04001EC5 RID: 7877
	[Token(Token = "0x4001EC5")]
	[FieldOffset(Offset = "0xC")]
	public ControlAnchor.ControlId SliderAnchorControl;

	// Token: 0x04001EC6 RID: 7878
	[Token(Token = "0x4001EC6")]
	[FieldOffset(Offset = "0x10")]
	public LayoutCalculator.AnchorType SliderAnchor;

	// Token: 0x04001EC7 RID: 7879
	[Token(Token = "0x4001EC7")]
	[FieldOffset(Offset = "0x14")]
	public Microsoft.Xna.Framework.Vector2 SliderLocation;

	// Token: 0x04001EC8 RID: 7880
	[Token(Token = "0x4001EC8")]
	[FieldOffset(Offset = "0x1C")]
	public float SliderBackScale;

	// Token: 0x04001EC9 RID: 7881
	[Token(Token = "0x4001EC9")]
	[FieldOffset(Offset = "0x20")]
	public Microsoft.Xna.Framework.Vector2 SliderPickBorder;

	// Token: 0x04001ECA RID: 7882
	[Token(Token = "0x4001ECA")]
	[FieldOffset(Offset = "0x28")]
	public float SliderIndicatorScale;

	// Token: 0x04001ECB RID: 7883
	[Token(Token = "0x4001ECB")]
	[FieldOffset(Offset = "0x2C")]
	public float SliderEndCap;

	// Token: 0x04001ECC RID: 7884
	[Token(Token = "0x4001ECC")]
	[FieldOffset(Offset = "0x30")]
	public float SliderDefaultPosition;

	// Token: 0x04001ECD RID: 7885
	[Token(Token = "0x4001ECD")]
	[FieldOffset(Offset = "0x34")]
	public AnimationCurve SliderToPixelScale;

	// Token: 0x04001ECE RID: 7886
	[Token(Token = "0x4001ECE")]
	[FieldOffset(Offset = "0x38")]
	public float PixelWorldScaleThreshold;

	// Token: 0x04001ECF RID: 7887
	[Token(Token = "0x4001ECF")]
	[FieldOffset(Offset = "0x3C")]
	public float DefaultCursorScale;

	// Token: 0x04001ED0 RID: 7888
	[Token(Token = "0x4001ED0")]
	[FieldOffset(Offset = "0x40")]
	public bool ScaleCursorWithZoom;

	// Token: 0x04001ED1 RID: 7889
	[Token(Token = "0x4001ED1")]
	[FieldOffset(Offset = "0x44")]
	public float DefaultMagnifyCursorScale;

	// Token: 0x04001ED2 RID: 7890
	[Token(Token = "0x4001ED2")]
	[FieldOffset(Offset = "0x48")]
	public bool MagnifyScaleCursorWithZoom;

	// Token: 0x04001ED3 RID: 7891
	[Token(Token = "0x4001ED3")]
	[FieldOffset(Offset = "0x4C")]
	public float ScopeXEdgeTrigger;

	// Token: 0x04001ED4 RID: 7892
	[Token(Token = "0x4001ED4")]
	[FieldOffset(Offset = "0x50")]
	public float ScopeYEdgeTrigger;
}
