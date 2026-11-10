using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000372 RID: 882
[Token(Token = "0x2000372")]
[Serializable]
public class XNAUICameraSettings : DeviceVPPICalculator
{
	// Token: 0x060015B0 RID: 5552 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015B0")]
	[Address(RVA = "0xDFE7B4", Offset = "0xDFE7B4", VA = "0xDFE7B4")]
	public XNAUICameraSettings()
	{
	}

	// Token: 0x060015B1 RID: 5553 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015B1")]
	[Address(RVA = "0xDFE848", Offset = "0xDFE848", VA = "0xDFE848")]
	public XNAUICameraSettings(Camera camera, XNAUICameraSettings defaultSettings)
	{
	}

	// Token: 0x060015B2 RID: 5554 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015B2")]
	[Address(RVA = "0xDFE968", Offset = "0xDFE968", VA = "0xDFE968", Slot = "4")]
	public override void UpdateViewport(Rect newVeiwport)
	{
	}

	// Token: 0x060015B3 RID: 5555 RVA: 0x00009840 File Offset: 0x00007A40
	[Token(Token = "0x60015B3")]
	[Address(RVA = "0xDFE9C0", Offset = "0xDFE9C0", VA = "0xDFE9C0")]
	private static bool RectRoughlyEqual(Rect a, Rect b)
	{
		return default(bool);
	}

	// Token: 0x170001FB RID: 507
	// (get) Token: 0x060015B4 RID: 5556 RVA: 0x00009858 File Offset: 0x00007A58
	[Token(Token = "0x170001FB")]
	private bool ScreenResolutionSettingsDirty
	{
		[Token(Token = "0x60015B4")]
		[Address(RVA = "0xDFEB24", Offset = "0xDFEB24", VA = "0xDFEB24")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060015B5 RID: 5557 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015B5")]
	[Address(RVA = "0xDFF0AC", Offset = "0xDFF0AC", VA = "0xDFF0AC")]
	public void RecalculateVirtualScreen()
	{
	}

	// Token: 0x060015B6 RID: 5558 RVA: 0x00009870 File Offset: 0x00007A70
	[Token(Token = "0x60015B6")]
	[Address(RVA = "0xDFF23C", Offset = "0xDFF23C", VA = "0xDFF23C")]
	public float GetMinResolution()
	{
		return 0f;
	}

	// Token: 0x060015B7 RID: 5559 RVA: 0x00009888 File Offset: 0x00007A88
	[Token(Token = "0x60015B7")]
	[Address(RVA = "0xDFF354", Offset = "0xDFF354", VA = "0xDFF354")]
	public float GetMaxResolution()
	{
		return 0f;
	}

	// Token: 0x170001FC RID: 508
	// (get) Token: 0x060015B8 RID: 5560 RVA: 0x000098A0 File Offset: 0x00007AA0
	[Token(Token = "0x170001FC")]
	private int NativeWidth
	{
		[Token(Token = "0x60015B8")]
		[Address(RVA = "0xDFED14", Offset = "0xDFED14", VA = "0xDFED14")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170001FD RID: 509
	// (get) Token: 0x060015B9 RID: 5561 RVA: 0x000098B8 File Offset: 0x00007AB8
	[Token(Token = "0x170001FD")]
	private int NativeHeight
	{
		[Token(Token = "0x60015B9")]
		[Address(RVA = "0xDFEDB4", Offset = "0xDFEDB4", VA = "0xDFEDB4")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060015BA RID: 5562 RVA: 0x000098D0 File Offset: 0x00007AD0
	[Token(Token = "0x60015BA")]
	[Address(RVA = "0xDFEE54", Offset = "0xDFEE54", VA = "0xDFEE54")]
	private new Rect GetViewportSafeRegion()
	{
		return default(Rect);
	}

	// Token: 0x060015BB RID: 5563 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015BB")]
	[Address(RVA = "0xDFF40C", Offset = "0xDFF40C", VA = "0xDFF40C")]
	private void SetupZoomScale(ref Rect safeRegion)
	{
	}

	// Token: 0x060015BC RID: 5564 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015BC")]
	[Address(RVA = "0xDFF720", Offset = "0xDFF720", VA = "0xDFF720")]
	public void ApplyCamera()
	{
	}

	// Token: 0x04002A16 RID: 10774
	[Token(Token = "0x4002A16")]
	[FieldOffset(Offset = "0x4C")]
	public Camera Camera;

	// Token: 0x04002A17 RID: 10775
	[Token(Token = "0x4002A17")]
	[FieldOffset(Offset = "0x50")]
	private Vector2 _lastScreenResolution;

	// Token: 0x04002A18 RID: 10776
	[Token(Token = "0x4002A18")]
	[FieldOffset(Offset = "0x58")]
	private bool _lastVPPIOverridden;

	// Token: 0x04002A19 RID: 10777
	[Token(Token = "0x4002A19")]
	[FieldOffset(Offset = "0x5C")]
	private float _lastVPPI;

	// Token: 0x04002A1A RID: 10778
	[Token(Token = "0x4002A1A")]
	[FieldOffset(Offset = "0x60")]
	private float _lastZoomScale;

	// Token: 0x04002A1B RID: 10779
	[Token(Token = "0x4002A1B")]
	[FieldOffset(Offset = "0x64")]
	private Rect _lastSafeRegion;

	// Token: 0x04002A1C RID: 10780
	[Token(Token = "0x4002A1C")]
	[FieldOffset(Offset = "0x74")]
	public int _cameraWidth;

	// Token: 0x04002A1D RID: 10781
	[Token(Token = "0x4002A1D")]
	[FieldOffset(Offset = "0x78")]
	public int _cameraHeight;

	// Token: 0x04002A1E RID: 10782
	[Token(Token = "0x4002A1E")]
	[FieldOffset(Offset = "0x7C")]
	private Rect _cameraSafeRegion;

	// Token: 0x04002A1F RID: 10783
	[Token(Token = "0x4002A1F")]
	[FieldOffset(Offset = "0x8C")]
	public float _safeRegionMinX;

	// Token: 0x04002A20 RID: 10784
	[Token(Token = "0x4002A20")]
	[FieldOffset(Offset = "0x90")]
	public float _safeRegionMinY;

	// Token: 0x04002A21 RID: 10785
	[Token(Token = "0x4002A21")]
	[FieldOffset(Offset = "0x94")]
	public int realVirtualScreenWidth;

	// Token: 0x04002A22 RID: 10786
	[Token(Token = "0x4002A22")]
	[FieldOffset(Offset = "0x98")]
	public int realVirtualScreenHeight;

	// Token: 0x04002A23 RID: 10787
	[Token(Token = "0x4002A23")]
	[FieldOffset(Offset = "0x9C")]
	public int realVirtualScreenOffsetX;

	// Token: 0x04002A24 RID: 10788
	[Token(Token = "0x4002A24")]
	[FieldOffset(Offset = "0xA0")]
	public int realVirtualScreenOffsetY;

	// Token: 0x04002A25 RID: 10789
	[Token(Token = "0x4002A25")]
	[FieldOffset(Offset = "0xA4")]
	private bool fixingUp;
}
