using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200026B RID: 619
[Token(Token = "0x200026B")]
[Serializable]
public class VirtualControlsAxisConfiguration_Layout
{
	// Token: 0x06000E9C RID: 3740 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E9C")]
	[Address(RVA = "0xC99D5C", Offset = "0xC99D5C", VA = "0xC99D5C")]
	public void Validate()
	{
	}

	// Token: 0x06000E9D RID: 3741 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E9D")]
	[Address(RVA = "0xC99D60", Offset = "0xC99D60", VA = "0xC99D60")]
	public Axis_Layout GetStyle(VirtualControlsAxisConfiguration_Layout.Style stlyeIndex)
	{
		return null;
	}

	// Token: 0x06000E9E RID: 3742 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E9E")]
	[Address(RVA = "0xC99D84", Offset = "0xC99D84", VA = "0xC99D84")]
	public VirtualControlsAxisConfiguration_Layout()
	{
	}

	// Token: 0x04001DC9 RID: 7625
	[Token(Token = "0x4001DC9")]
	[FieldOffset(Offset = "0x0")]
	public static VirtualControlsAxisConfiguration_Layout.Style[] AxisStyles;

	// Token: 0x04001DCA RID: 7626
	[Token(Token = "0x4001DCA")]
	[FieldOffset(Offset = "0x8")]
	public string Id;

	// Token: 0x04001DCB RID: 7627
	[Token(Token = "0x4001DCB")]
	[FieldOffset(Offset = "0xC")]
	public Axis_Layout BlueLayout;

	// Token: 0x04001DCC RID: 7628
	[Token(Token = "0x4001DCC")]
	[FieldOffset(Offset = "0x10")]
	public Axis_Layout GreenLayout;

	// Token: 0x04001DCD RID: 7629
	[Token(Token = "0x4001DCD")]
	[FieldOffset(Offset = "0x14")]
	public Axis_Layout BadLayout;

	// Token: 0x04001DCE RID: 7630
	[Token(Token = "0x4001DCE")]
	[FieldOffset(Offset = "0x18")]
	public Axis_Layout ControlLayout;

	// Token: 0x04001DCF RID: 7631
	[Token(Token = "0x4001DCF")]
	[FieldOffset(Offset = "0x1C")]
	public Color DisabledIconColor;

	// Token: 0x04001DD0 RID: 7632
	[Token(Token = "0x4001DD0")]
	[FieldOffset(Offset = "0x20")]
	public Panel_Layout TopIcon;

	// Token: 0x0200026C RID: 620
	[Token(Token = "0x200026C")]
	public enum Style
	{
		// Token: 0x04001DD2 RID: 7634
		[Token(Token = "0x4001DD2")]
		Blue,
		// Token: 0x04001DD3 RID: 7635
		[Token(Token = "0x4001DD3")]
		Green,
		// Token: 0x04001DD4 RID: 7636
		[Token(Token = "0x4001DD4")]
		BadPosition
	}
}
