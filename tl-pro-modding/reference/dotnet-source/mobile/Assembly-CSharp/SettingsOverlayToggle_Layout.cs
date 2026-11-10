using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200023C RID: 572
[Token(Token = "0x200023C")]
[Serializable]
public class SettingsOverlayToggle_Layout
{
	// Token: 0x06000E2F RID: 3631 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E2F")]
	[Address(RVA = "0xC8A544", Offset = "0xC8A544", VA = "0xC8A544")]
	public SettingsOverlayToggle_Layout()
	{
	}

	// Token: 0x04001988 RID: 6536
	[Token(Token = "0x4001988")]
	[FieldOffset(Offset = "0x8")]
	public TransactionButton_Layout ToggleButton;

	// Token: 0x04001989 RID: 6537
	[Token(Token = "0x4001989")]
	[FieldOffset(Offset = "0xC")]
	public Panel_Layout Option1Enabled;

	// Token: 0x0400198A RID: 6538
	[Token(Token = "0x400198A")]
	[FieldOffset(Offset = "0x10")]
	public Panel_Layout Option1Disabled;

	// Token: 0x0400198B RID: 6539
	[Token(Token = "0x400198B")]
	[FieldOffset(Offset = "0x14")]
	public String_Layout Option1Label;

	// Token: 0x0400198C RID: 6540
	[Token(Token = "0x400198C")]
	[FieldOffset(Offset = "0x18")]
	public Color Option1DisabledLabelColour;

	// Token: 0x0400198D RID: 6541
	[Token(Token = "0x400198D")]
	[FieldOffset(Offset = "0x1C")]
	public Panel_Layout Option2Enabled;

	// Token: 0x0400198E RID: 6542
	[Token(Token = "0x400198E")]
	[FieldOffset(Offset = "0x20")]
	public Panel_Layout Option2Disabled;

	// Token: 0x0400198F RID: 6543
	[Token(Token = "0x400198F")]
	[FieldOffset(Offset = "0x24")]
	public String_Layout Option2Label;

	// Token: 0x04001990 RID: 6544
	[Token(Token = "0x4001990")]
	[FieldOffset(Offset = "0x28")]
	public Color Option2DisabledLabelColour;

	// Token: 0x04001991 RID: 6545
	[Token(Token = "0x4001991")]
	[FieldOffset(Offset = "0x2C")]
	public Button_Layout RefreshingIcon;

	// Token: 0x04001992 RID: 6546
	[Token(Token = "0x4001992")]
	[FieldOffset(Offset = "0x30")]
	public float ElementSpacing;

	// Token: 0x04001993 RID: 6547
	[Token(Token = "0x4001993")]
	[FieldOffset(Offset = "0x34")]
	public bool ScaleToFit;

	// Token: 0x04001994 RID: 6548
	[Token(Token = "0x4001994")]
	[FieldOffset(Offset = "0x38")]
	public float ScaleToFit1Pad;

	// Token: 0x04001995 RID: 6549
	[Token(Token = "0x4001995")]
	[FieldOffset(Offset = "0x3C")]
	public float ScaleToFit1MaxScale;

	// Token: 0x04001996 RID: 6550
	[Token(Token = "0x4001996")]
	[FieldOffset(Offset = "0x40")]
	public float ScaleToFit1OrigTextX;

	// Token: 0x04001997 RID: 6551
	[Token(Token = "0x4001997")]
	[FieldOffset(Offset = "0x44")]
	public float ScaleToFit2Pad;

	// Token: 0x04001998 RID: 6552
	[Token(Token = "0x4001998")]
	[FieldOffset(Offset = "0x48")]
	public float ScaleToFit2MaxScale;

	// Token: 0x04001999 RID: 6553
	[Token(Token = "0x4001999")]
	[FieldOffset(Offset = "0x4C")]
	public float ScaleToFit2OrigTextX;
}
