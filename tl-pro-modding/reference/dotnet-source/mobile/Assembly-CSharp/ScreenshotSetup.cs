using System;
using Controller;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200036D RID: 877
[Token(Token = "0x200036D")]
[Serializable]
public class ScreenshotSetup
{
	// Token: 0x170001F4 RID: 500
	// (get) Token: 0x060015A1 RID: 5537 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001F4")]
	public RenderTexture RenderTexture
	{
		[Token(Token = "0x60015A1")]
		[Address(RVA = "0xDFDB0C", Offset = "0xDFDB0C", VA = "0xDFDB0C")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001F5 RID: 501
	// (get) Token: 0x060015A2 RID: 5538 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001F5")]
	public Texture2D SaveTexture
	{
		[Token(Token = "0x60015A2")]
		[Address(RVA = "0xDFDC7C", Offset = "0xDFDC7C", VA = "0xDFDC7C")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001F6 RID: 502
	// (get) Token: 0x060015A3 RID: 5539 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001F6")]
	public DeviceVPPICalculator.EditorMobileEmuEntry EmulationEntry
	{
		[Token(Token = "0x60015A3")]
		[Address(RVA = "0xDFDDEC", Offset = "0xDFDDEC", VA = "0xDFDDEC")]
		get
		{
			return null;
		}
	}

	// Token: 0x060015A4 RID: 5540 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015A4")]
	[Address(RVA = "0xDFE02C", Offset = "0xDFE02C", VA = "0xDFE02C")]
	public ScreenshotSetup()
	{
	}

	// Token: 0x040029F5 RID: 10741
	[Token(Token = "0x40029F5")]
	[FieldOffset(Offset = "0x8")]
	private RenderTexture _renderTexture;

	// Token: 0x040029F6 RID: 10742
	[Token(Token = "0x40029F6")]
	[FieldOffset(Offset = "0xC")]
	private Texture2D _tex;

	// Token: 0x040029F7 RID: 10743
	[Token(Token = "0x40029F7")]
	[FieldOffset(Offset = "0x10")]
	private DeviceVPPICalculator.EditorMobileEmuEntry _emulationEntry;

	// Token: 0x040029F8 RID: 10744
	[Token(Token = "0x40029F8")]
	[FieldOffset(Offset = "0x14")]
	public string Id;

	// Token: 0x040029F9 RID: 10745
	[Token(Token = "0x40029F9")]
	[FieldOffset(Offset = "0x18")]
	public ScreenshotSetup.UIStyle Style;

	// Token: 0x040029FA RID: 10746
	[Token(Token = "0x40029FA")]
	[FieldOffset(Offset = "0x1C")]
	public ControllerDevice.ControlScheme ControlScheme;

	// Token: 0x040029FB RID: 10747
	[Token(Token = "0x40029FB")]
	[FieldOffset(Offset = "0x20")]
	public ScreenshotSetup.UIProfileScheme UIProfile;

	// Token: 0x040029FC RID: 10748
	[Token(Token = "0x40029FC")]
	[FieldOffset(Offset = "0x24")]
	public int Width;

	// Token: 0x040029FD RID: 10749
	[Token(Token = "0x40029FD")]
	[FieldOffset(Offset = "0x28")]
	public int Height;

	// Token: 0x040029FE RID: 10750
	[Token(Token = "0x40029FE")]
	[FieldOffset(Offset = "0x2C")]
	public int DPI;

	// Token: 0x040029FF RID: 10751
	[Token(Token = "0x40029FF")]
	[FieldOffset(Offset = "0x30")]
	public Rect SafeRegion;

	// Token: 0x04002A00 RID: 10752
	[Token(Token = "0x4002A00")]
	[FieldOffset(Offset = "0x40")]
	public string OutputPath;

	// Token: 0x04002A01 RID: 10753
	[Token(Token = "0x4002A01")]
	[FieldOffset(Offset = "0x44")]
	public string OutputFileStart;

	// Token: 0x0200036E RID: 878
	[Token(Token = "0x200036E")]
	public enum UIStyle
	{
		// Token: 0x04002A03 RID: 10755
		[Token(Token = "0x4002A03")]
		VirtualControls,
		// Token: 0x04002A04 RID: 10756
		[Token(Token = "0x4002A04")]
		Controller,
		// Token: 0x04002A05 RID: 10757
		[Token(Token = "0x4002A05")]
		None
	}

	// Token: 0x0200036F RID: 879
	[Token(Token = "0x200036F")]
	public enum UIProfileScheme
	{
		// Token: 0x04002A07 RID: 10759
		[Token(Token = "0x4002A07")]
		Classic,
		// Token: 0x04002A08 RID: 10760
		[Token(Token = "0x4002A08")]
		Compact,
		// Token: 0x04002A09 RID: 10761
		[Token(Token = "0x4002A09")]
		TwoPage
	}
}
