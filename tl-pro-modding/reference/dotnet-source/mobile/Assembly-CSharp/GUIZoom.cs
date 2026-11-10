using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using UnityEngine;

// Token: 0x02000190 RID: 400
[Token(Token = "0x2000190")]
public class GUIZoom
{
	// Token: 0x06000BD4 RID: 3028 RVA: 0x00006CD8 File Offset: 0x00004ED8
	[Token(Token = "0x6000BD4")]
	[Address(RVA = "0xC3559C", Offset = "0xC3559C", VA = "0xC3559C")]
	public float GetDefaultWorldZoomScale()
	{
		return 0f;
	}

	// Token: 0x06000BD5 RID: 3029 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BD5")]
	[Address(RVA = "0xC35880", Offset = "0xC35880", VA = "0xC35880")]
	public void LoadDefaultZoom()
	{
	}

	// Token: 0x06000BD6 RID: 3030 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BD6")]
	[Address(RVA = "0xC35994", Offset = "0xC35994", VA = "0xC35994")]
	public GUIZoom()
	{
	}

	// Token: 0x06000BD7 RID: 3031 RVA: 0x00006CF0 File Offset: 0x00004EF0
	[Token(Token = "0x6000BD7")]
	[Address(RVA = "0xC35B54", Offset = "0xC35B54", VA = "0xC35B54")]
	private bool IsCursorOver(Microsoft.Xna.Framework.Vector2 position, out float sliderPosition)
	{
		return default(bool);
	}

	// Token: 0x06000BD8 RID: 3032 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BD8")]
	[Address(RVA = "0xC35E40", Offset = "0xC35E40", VA = "0xC35E40")]
	private void ApplyPixelZoom(float pixelScale, bool useBump = false)
	{
	}

	// Token: 0x06000BD9 RID: 3033 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BD9")]
	[Address(RVA = "0xC3680C", Offset = "0xC3680C", VA = "0xC3680C")]
	private void UpdatePixelZoom()
	{
	}

	// Token: 0x06000BDA RID: 3034 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BDA")]
	[Address(RVA = "0xC368A8", Offset = "0xC368A8", VA = "0xC368A8")]
	public void UpdateCursorDummy(global::Cursor cursor)
	{
	}

	// Token: 0x06000BDB RID: 3035 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BDB")]
	[Address(RVA = "0xC368AC", Offset = "0xC368AC", VA = "0xC368AC")]
	public void UpdateCursor(global::Cursor cursor)
	{
	}

	// Token: 0x06000BDC RID: 3036 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BDC")]
	[Address(RVA = "0xC36AFC", Offset = "0xC36AFC", VA = "0xC36AFC")]
	public void UpdatePinchZoom()
	{
	}

	// Token: 0x06000BDD RID: 3037 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BDD")]
	[Address(RVA = "0xC3753C", Offset = "0xC3753C", VA = "0xC3753C")]
	public void Draw()
	{
	}

	// Token: 0x04000E7D RID: 3709
	[Token(Token = "0x4000E7D")]
	[FieldOffset(Offset = "0x8")]
	private bool draggingSlider;

	// Token: 0x04000E7E RID: 3710
	[Token(Token = "0x4000E7E")]
	[FieldOffset(Offset = "0xC")]
	private float ZoomValue;

	// Token: 0x04000E7F RID: 3711
	[Token(Token = "0x4000E7F")]
	[FieldOffset(Offset = "0x10")]
	private CursorInputLayer _inputLayer;

	// Token: 0x04000E80 RID: 3712
	[Token(Token = "0x4000E80")]
	[FieldOffset(Offset = "0x14")]
	private CursorInputLayer _inputlayerZoomPinch;

	// Token: 0x04000E81 RID: 3713
	[Token(Token = "0x4000E81")]
	[FieldOffset(Offset = "0x18")]
	private float MaxZoomValue;

	// Token: 0x04000E82 RID: 3714
	[Token(Token = "0x4000E82")]
	[FieldOffset(Offset = "0x1C")]
	public float DefaultWorldZoomScale;

	// Token: 0x04000E83 RID: 3715
	[Token(Token = "0x4000E83")]
	[FieldOffset(Offset = "0x20")]
	private bool _pinchZoomActive;

	// Token: 0x04000E84 RID: 3716
	[Token(Token = "0x4000E84")]
	[FieldOffset(Offset = "0x24")]
	private global::Cursor _zoomCursor0;

	// Token: 0x04000E85 RID: 3717
	[Token(Token = "0x4000E85")]
	[FieldOffset(Offset = "0x28")]
	private global::Cursor _zoomCursor1;

	// Token: 0x04000E86 RID: 3718
	[Token(Token = "0x4000E86")]
	[FieldOffset(Offset = "0x2C")]
	private global::UnityEngine.Vector2 _initialPosition0;

	// Token: 0x04000E87 RID: 3719
	[Token(Token = "0x4000E87")]
	[FieldOffset(Offset = "0x34")]
	private global::UnityEngine.Vector2 _initialPosition1;

	// Token: 0x04000E88 RID: 3720
	[Token(Token = "0x4000E88")]
	[FieldOffset(Offset = "0x3C")]
	private bool _lastFrameFullScreenMap;

	// Token: 0x04000E89 RID: 3721
	[Token(Token = "0x4000E89")]
	[FieldOffset(Offset = "0x40")]
	private Microsoft.Xna.Framework.Vector2 _lastFrameGrabCentre;

	// Token: 0x04000E8A RID: 3722
	[Token(Token = "0x4000E8A")]
	[FieldOffset(Offset = "0x48")]
	private float _initialZoom;

	// Token: 0x04000E8B RID: 3723
	[Token(Token = "0x4000E8B")]
	[FieldOffset(Offset = "0x4C")]
	private bool _allowPinchBump;

	// Token: 0x04000E8C RID: 3724
	[Token(Token = "0x4000E8C")]
	[FieldOffset(Offset = "0x4D")]
	public bool PinchZoomWorldEnabled;

	// Token: 0x04000E8D RID: 3725
	[Token(Token = "0x4000E8D")]
	[FieldOffset(Offset = "0x4E")]
	public bool PinchZoomMapEnabled;
}
