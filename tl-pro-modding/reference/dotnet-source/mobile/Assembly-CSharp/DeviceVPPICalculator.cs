using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000369 RID: 873
[Token(Token = "0x2000369")]
public class DeviceVPPICalculator
{
	// Token: 0x170001EA RID: 490
	// (get) Token: 0x06001576 RID: 5494 RVA: 0x000096F0 File Offset: 0x000078F0
	[Token(Token = "0x170001EA")]
	public DeviceOrientation deviceOrientation
	{
		[Token(Token = "0x6001576")]
		[Address(RVA = "0xDF8350", Offset = "0xDF8350", VA = "0xDF8350")]
		get
		{
			return DeviceOrientation.Unknown;
		}
	}

	// Token: 0x06001577 RID: 5495 RVA: 0x00009708 File Offset: 0x00007908
	[Token(Token = "0x6001577")]
	[Address(RVA = "0xDF8388", Offset = "0xDF8388", VA = "0xDF8388")]
	private float GetDeviceDPI()
	{
		return 0f;
	}

	// Token: 0x170001EB RID: 491
	// (get) Token: 0x06001578 RID: 5496 RVA: 0x00009720 File Offset: 0x00007920
	[Token(Token = "0x170001EB")]
	public Rect Viewport
	{
		[Token(Token = "0x6001578")]
		[Address(RVA = "0xDF8474", Offset = "0xDF8474", VA = "0xDF8474")]
		get
		{
			return default(Rect);
		}
	}

	// Token: 0x06001579 RID: 5497 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001579")]
	[Address(RVA = "0xDF8484", Offset = "0xDF8484", VA = "0xDF8484", Slot = "4")]
	public virtual void UpdateViewport(Rect newVeiwport)
	{
	}

	// Token: 0x0600157A RID: 5498 RVA: 0x00009738 File Offset: 0x00007938
	[Token(Token = "0x600157A")]
	[Address(RVA = "0xDF8514", Offset = "0xDF8514", VA = "0xDF8514")]
	public float GetDefaultVerticalResolution(bool safeRegion = false)
	{
		return 0f;
	}

	// Token: 0x0600157B RID: 5499 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600157B")]
	[Address(RVA = "0xDF8978", Offset = "0xDF8978", VA = "0xDF8978")]
	protected void UpdatePixelScale(bool safeRegion = false)
	{
	}

	// Token: 0x0600157C RID: 5500 RVA: 0x00009750 File Offset: 0x00007950
	[Token(Token = "0x600157C")]
	[Address(RVA = "0xDF8CF0", Offset = "0xDF8CF0", VA = "0xDF8CF0")]
	public Rect GetDefaultSafeArea()
	{
		return default(Rect);
	}

	// Token: 0x0600157D RID: 5501 RVA: 0x00009768 File Offset: 0x00007968
	[Token(Token = "0x600157D")]
	[Address(RVA = "0xDF8DCC", Offset = "0xDF8DCC", VA = "0xDF8DCC")]
	private bool IsSafeAreaValid()
	{
		return default(bool);
	}

	// Token: 0x0600157E RID: 5502 RVA: 0x00009780 File Offset: 0x00007980
	[Token(Token = "0x600157E")]
	[Address(RVA = "0xDF872C", Offset = "0xDF872C", VA = "0xDF872C")]
	public Rect GetViewportSafeRegion()
	{
		return default(Rect);
	}

	// Token: 0x0600157F RID: 5503 RVA: 0x00009798 File Offset: 0x00007998
	[Token(Token = "0x600157F")]
	[Address(RVA = "0xDF91D8", Offset = "0xDF91D8", VA = "0xDF91D8")]
	public Rect GetSafeArea()
	{
		return default(Rect);
	}

	// Token: 0x06001580 RID: 5504 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001580")]
	[Address(RVA = "0xDF9830", Offset = "0xDF9830", VA = "0xDF9830")]
	public void ResetSafeArea()
	{
	}

	// Token: 0x06001581 RID: 5505 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001581")]
	[Address(RVA = "0xDF98B8", Offset = "0xDF98B8", VA = "0xDF98B8")]
	public void SetSafeArea(Rect area)
	{
	}

	// Token: 0x06001582 RID: 5506 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001582")]
	[Address(RVA = "0xDF8BF0", Offset = "0xDF8BF0", VA = "0xDF8BF0")]
	private void UpdateForcedEmulation()
	{
	}

	// Token: 0x06001583 RID: 5507 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001583")]
	[Address(RVA = "0xDF9CEC", Offset = "0xDF9CEC", VA = "0xDF9CEC")]
	public void OverrideVerticalResolution(int verticalResolution)
	{
	}

	// Token: 0x170001EC RID: 492
	// (get) Token: 0x06001584 RID: 5508 RVA: 0x000097B0 File Offset: 0x000079B0
	// (set) Token: 0x06001585 RID: 5509 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001EC")]
	public float ZoomScale
	{
		[Token(Token = "0x6001584")]
		[Address(RVA = "0xDF9D0C", Offset = "0xDF9D0C", VA = "0xDF9D0C")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6001585")]
		[Address(RVA = "0xDF9D14", Offset = "0xDF9D14", VA = "0xDF9D14")]
		set
		{
		}
	}

	// Token: 0x06001586 RID: 5510 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001586")]
	[Address(RVA = "0xDF9D1C", Offset = "0xDF9D1C", VA = "0xDF9D1C")]
	public DeviceVPPICalculator()
	{
	}

	// Token: 0x040029CD RID: 10701
	[Token(Token = "0x40029CD")]
	[FieldOffset(Offset = "0x8")]
	private DeviceOrientation _cachedOrientation;

	// Token: 0x040029CE RID: 10702
	[Token(Token = "0x40029CE")]
	[FieldOffset(Offset = "0xC")]
	private bool DeviceDPISectup;

	// Token: 0x040029CF RID: 10703
	[Token(Token = "0x40029CF")]
	[FieldOffset(Offset = "0x10")]
	private float DeviceDPI;

	// Token: 0x040029D0 RID: 10704
	[Token(Token = "0x40029D0")]
	[FieldOffset(Offset = "0x0")]
	private static float DefaultResolution;

	// Token: 0x040029D1 RID: 10705
	[Token(Token = "0x40029D1")]
	[FieldOffset(Offset = "0x14")]
	protected Rect _viewport;

	// Token: 0x040029D2 RID: 10706
	[Token(Token = "0x40029D2")]
	[FieldOffset(Offset = "0x24")]
	public AnimationCurve PhysicalToVPPICurve;

	// Token: 0x040029D3 RID: 10707
	[Token(Token = "0x40029D3")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve PhysicalToResolution;

	// Token: 0x040029D4 RID: 10708
	[Token(Token = "0x40029D4")]
	[FieldOffset(Offset = "0x2C")]
	public float PhysicalHeight;

	// Token: 0x040029D5 RID: 10709
	[Token(Token = "0x40029D5")]
	[FieldOffset(Offset = "0x30")]
	public float VPPI;

	// Token: 0x040029D6 RID: 10710
	[Token(Token = "0x40029D6")]
	[FieldOffset(Offset = "0x34")]
	public float DPI;

	// Token: 0x040029D7 RID: 10711
	[Token(Token = "0x40029D7")]
	[FieldOffset(Offset = "0x38")]
	public float PixelScale;

	// Token: 0x040029D8 RID: 10712
	[Token(Token = "0x40029D8")]
	[FieldOffset(Offset = "0x3C")]
	public bool VPPIOverridden;

	// Token: 0x040029D9 RID: 10713
	[Token(Token = "0x40029D9")]
	[FieldOffset(Offset = "0x4")]
	public static Rect SafeArea;

	// Token: 0x040029DA RID: 10714
	[Token(Token = "0x40029DA")]
	[FieldOffset(Offset = "0x40")]
	private float _zoomScale;

	// Token: 0x040029DB RID: 10715
	[Token(Token = "0x40029DB")]
	[FieldOffset(Offset = "0x14")]
	private static float DefaultPhysicalHeight;

	// Token: 0x040029DC RID: 10716
	[Token(Token = "0x40029DC")]
	[FieldOffset(Offset = "0x44")]
	private DeviceVPPICalculator.EditorMobileEmuEntry[] MobileResolutionEntries;

	// Token: 0x040029DD RID: 10717
	[Token(Token = "0x40029DD")]
	[FieldOffset(Offset = "0x48")]
	private DeviceVPPICalculator.EditorMobileEmuEntry _forceEMUEntry;

	// Token: 0x0200036A RID: 874
	[Token(Token = "0x200036A")]
	public class EditorMobileEmuEntry
	{
		// Token: 0x06001588 RID: 5512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001588")]
		[Address(RVA = "0xDFB440", Offset = "0xDFB440", VA = "0xDFB440")]
		public EditorMobileEmuEntry(string id, int width, int height, float dpi, int allowedPlatforms = 65535)
		{
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001589")]
		[Address(RVA = "0xDFB4E0", Offset = "0xDFB4E0", VA = "0xDFB4E0")]
		public EditorMobileEmuEntry(string id, int width, int height, float dpi, Rect safeRegion, int allowedPlatforms = 65535)
		{
		}

		// Token: 0x040029DE RID: 10718
		[Token(Token = "0x40029DE")]
		[FieldOffset(Offset = "0x8")]
		public readonly string Id;

		// Token: 0x040029DF RID: 10719
		[Token(Token = "0x40029DF")]
		[FieldOffset(Offset = "0xC")]
		public readonly int Width;

		// Token: 0x040029E0 RID: 10720
		[Token(Token = "0x40029E0")]
		[FieldOffset(Offset = "0x10")]
		public readonly int Height;

		// Token: 0x040029E1 RID: 10721
		[Token(Token = "0x40029E1")]
		[FieldOffset(Offset = "0x14")]
		public readonly float DPI;

		// Token: 0x040029E2 RID: 10722
		[Token(Token = "0x40029E2")]
		[FieldOffset(Offset = "0x18")]
		public readonly Rect SafeRegion;

		// Token: 0x040029E3 RID: 10723
		[Token(Token = "0x40029E3")]
		[FieldOffset(Offset = "0x28")]
		public readonly int AllowedPlatforms;
	}
}
