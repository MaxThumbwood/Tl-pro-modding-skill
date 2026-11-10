using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000377 RID: 887
[Token(Token = "0x2000377")]
[Serializable]
public class XNAWorldCameraSettings : DeviceVPPICalculator
{
	// Token: 0x06001602 RID: 5634 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001602")]
	[Address(RVA = "0xE07910", Offset = "0xE07910", VA = "0xE07910")]
	public XNAWorldCameraSettings()
	{
	}

	// Token: 0x06001603 RID: 5635 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001603")]
	[Address(RVA = "0xE07984", Offset = "0xE07984", VA = "0xE07984")]
	public XNAWorldCameraSettings(Camera camera, XNAWorldCameraSettings defaultSettings)
	{
	}

	// Token: 0x06001604 RID: 5636 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001604")]
	[Address(RVA = "0xE07A9C", Offset = "0xE07A9C", VA = "0xE07A9C", Slot = "4")]
	public override void UpdateViewport(Rect newVeiwport)
	{
	}

	// Token: 0x17000212 RID: 530
	// (get) Token: 0x06001605 RID: 5637 RVA: 0x00009BD0 File Offset: 0x00007DD0
	[Token(Token = "0x17000212")]
	private bool ScreenResolutionSettingsDirty
	{
		[Token(Token = "0x6001605")]
		[Address(RVA = "0xE0804C", Offset = "0xE0804C", VA = "0xE0804C")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001606 RID: 5638 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001606")]
	[Address(RVA = "0xE07B7C", Offset = "0xE07B7C", VA = "0xE07B7C")]
	private void RecalculateVirtualScreen()
	{
	}

	// Token: 0x17000213 RID: 531
	// (get) Token: 0x06001607 RID: 5639 RVA: 0x00009BE8 File Offset: 0x00007DE8
	[Token(Token = "0x17000213")]
	public float MaxPixelScale
	{
		[Token(Token = "0x6001607")]
		[Address(RVA = "0xE07CE0", Offset = "0xE07CE0", VA = "0xE07CE0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000214 RID: 532
	// (get) Token: 0x06001608 RID: 5640 RVA: 0x00009C00 File Offset: 0x00007E00
	[Token(Token = "0x17000214")]
	public float MinPixelScale
	{
		[Token(Token = "0x6001608")]
		[Address(RVA = "0xE07F20", Offset = "0xE07F20", VA = "0xE07F20")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000215 RID: 533
	// (get) Token: 0x06001609 RID: 5641 RVA: 0x00009C18 File Offset: 0x00007E18
	[Token(Token = "0x17000215")]
	public int MaxWorldWidth
	{
		[Token(Token = "0x6001609")]
		[Address(RVA = "0xDFBBB8", Offset = "0xDFBBB8", VA = "0xDFBBB8")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000216 RID: 534
	// (get) Token: 0x0600160A RID: 5642 RVA: 0x00009C30 File Offset: 0x00007E30
	[Token(Token = "0x17000216")]
	public int MaxWorldHeight
	{
		[Token(Token = "0x600160A")]
		[Address(RVA = "0xDFBC98", Offset = "0xDFBC98", VA = "0xDFBC98")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000217 RID: 535
	// (get) Token: 0x0600160B RID: 5643 RVA: 0x00009C48 File Offset: 0x00007E48
	[Token(Token = "0x17000217")]
	public int NativeWidth
	{
		[Token(Token = "0x600160B")]
		[Address(RVA = "0xE081F4", Offset = "0xE081F4", VA = "0xE081F4")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000218 RID: 536
	// (get) Token: 0x0600160C RID: 5644 RVA: 0x00009C60 File Offset: 0x00007E60
	[Token(Token = "0x17000218")]
	public int NativeHeight
	{
		[Token(Token = "0x600160C")]
		[Address(RVA = "0xE08294", Offset = "0xE08294", VA = "0xE08294")]
		get
		{
			return 0;
		}
	}

	// Token: 0x0600160D RID: 5645 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600160D")]
	[Address(RVA = "0xE008B4", Offset = "0xE008B4", VA = "0xE008B4")]
	public void ApplyCamera()
	{
	}

	// Token: 0x04002A6A RID: 10858
	[Token(Token = "0x4002A6A")]
	[FieldOffset(Offset = "0x4C")]
	public Camera MagnifyCamera;

	// Token: 0x04002A6B RID: 10859
	[Token(Token = "0x4002A6B")]
	[FieldOffset(Offset = "0x50")]
	public bool MagnifyActive;

	// Token: 0x04002A6C RID: 10860
	[Token(Token = "0x4002A6C")]
	[FieldOffset(Offset = "0x54")]
	public Vector2 MagnifySrcRegionOffset;

	// Token: 0x04002A6D RID: 10861
	[Token(Token = "0x4002A6D")]
	[FieldOffset(Offset = "0x5C")]
	public Vector2 MagnifySrcRegionSize;

	// Token: 0x04002A6E RID: 10862
	[Token(Token = "0x4002A6E")]
	[FieldOffset(Offset = "0x64")]
	public Vector2 MagnifyDstRegionOffset;

	// Token: 0x04002A6F RID: 10863
	[Token(Token = "0x4002A6F")]
	[FieldOffset(Offset = "0x6C")]
	public Vector2 MagnifyDstRegionSize;

	// Token: 0x04002A70 RID: 10864
	[Token(Token = "0x4002A70")]
	[FieldOffset(Offset = "0x74")]
	public Camera Camera;

	// Token: 0x04002A71 RID: 10865
	[Token(Token = "0x4002A71")]
	[FieldOffset(Offset = "0x78")]
	public AnimationCurve UIScreenWorldOffset;

	// Token: 0x04002A72 RID: 10866
	[Token(Token = "0x4002A72")]
	[FieldOffset(Offset = "0x7C")]
	private Vector2 _lastScreenResolution;

	// Token: 0x04002A73 RID: 10867
	[Token(Token = "0x4002A73")]
	[FieldOffset(Offset = "0x84")]
	private bool _lastVPPIOverridden;

	// Token: 0x04002A74 RID: 10868
	[Token(Token = "0x4002A74")]
	[FieldOffset(Offset = "0x88")]
	private float _lastVPPI;

	// Token: 0x04002A75 RID: 10869
	[Token(Token = "0x4002A75")]
	[FieldOffset(Offset = "0x8C")]
	private float _lastZoomScale;

	// Token: 0x04002A76 RID: 10870
	[Token(Token = "0x4002A76")]
	[FieldOffset(Offset = "0x90")]
	private bool _wasInMenus;

	// Token: 0x04002A77 RID: 10871
	[Token(Token = "0x4002A77")]
	[FieldOffset(Offset = "0x94")]
	public int _cameraWidth;

	// Token: 0x04002A78 RID: 10872
	[Token(Token = "0x4002A78")]
	[FieldOffset(Offset = "0x98")]
	public int _cameraHeight;

	// Token: 0x04002A79 RID: 10873
	[Token(Token = "0x4002A79")]
	[FieldOffset(Offset = "0x9C")]
	public Vector2 HorizontalSplitScreenResolution;

	// Token: 0x04002A7A RID: 10874
	[Token(Token = "0x4002A7A")]
	[FieldOffset(Offset = "0xA4")]
	public Vector2 VertialSplitScreenResolution;

	// Token: 0x04002A7B RID: 10875
	[Token(Token = "0x4002A7B")]
	[FieldOffset(Offset = "0xAC")]
	public Vector2 QuaterSplitScreenResolution;
}
