using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200023B RID: 571
[Token(Token = "0x200023B")]
[Serializable]
public class SettingsOverlaySlider_Layout
{
	// Token: 0x06000E2E RID: 3630 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E2E")]
	[Address(RVA = "0xC8A51C", Offset = "0xC8A51C", VA = "0xC8A51C")]
	public SettingsOverlaySlider_Layout()
	{
	}

	// Token: 0x0400197F RID: 6527
	[Token(Token = "0x400197F")]
	[FieldOffset(Offset = "0x8")]
	public TransactionButton_Layout Title;

	// Token: 0x04001980 RID: 6528
	[Token(Token = "0x4001980")]
	[FieldOffset(Offset = "0xC")]
	public Slider_Layout Option;

	// Token: 0x04001981 RID: 6529
	[Token(Token = "0x4001981")]
	[FieldOffset(Offset = "0x10")]
	public Slider_Layout HueOption;

	// Token: 0x04001982 RID: 6530
	[Token(Token = "0x4001982")]
	[FieldOffset(Offset = "0x14")]
	public Slider_Layout SaturationOption;

	// Token: 0x04001983 RID: 6531
	[Token(Token = "0x4001983")]
	[FieldOffset(Offset = "0x18")]
	public Slider_Layout LightOption;

	// Token: 0x04001984 RID: 6532
	[Token(Token = "0x4001984")]
	[FieldOffset(Offset = "0x1C")]
	public String_Layout Value;

	// Token: 0x04001985 RID: 6533
	[Token(Token = "0x4001985")]
	[FieldOffset(Offset = "0x20")]
	public Color DisabledNotchColor;

	// Token: 0x04001986 RID: 6534
	[Token(Token = "0x4001986")]
	[FieldOffset(Offset = "0x24")]
	public Color DisabledValueColor;

	// Token: 0x04001987 RID: 6535
	[Token(Token = "0x4001987")]
	[FieldOffset(Offset = "0x28")]
	public float ElementSpacing;
}
