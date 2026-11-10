using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x02000278 RID: 632
[Token(Token = "0x2000278")]
public class VirtualInputControllerControlConfiguration_Layout : LayoutDefinition
{
	// Token: 0x06000ECF RID: 3791 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ECF")]
	[Address(RVA = "0xC9E3F0", Offset = "0xC9E3F0", VA = "0xC9E3F0")]
	private void Awake()
	{
	}

	// Token: 0x06000ED0 RID: 3792 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ED0")]
	[Address(RVA = "0xC9E444", Offset = "0xC9E444", VA = "0xC9E444")]
	public VirtualInputControllerControlConfiguration_Layout()
	{
	}

	// Token: 0x04001E4B RID: 7755
	[Token(Token = "0x4001E4B")]
	[FieldOffset(Offset = "0x0")]
	public static VirtualInputControllerControlConfiguration_Layout Instance;

	// Token: 0x04001E4C RID: 7756
	[Token(Token = "0x4001E4C")]
	[FieldOffset(Offset = "0xC")]
	public float MaxAxisSize;

	// Token: 0x04001E4D RID: 7757
	[Token(Token = "0x4001E4D")]
	[FieldOffset(Offset = "0x10")]
	public float MaxButtonSize;

	// Token: 0x04001E4E RID: 7758
	[Token(Token = "0x4001E4E")]
	[FieldOffset(Offset = "0x14")]
	public float MaxGroupSize;

	// Token: 0x04001E4F RID: 7759
	[Token(Token = "0x4001E4F")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 ActionAxisOffset;

	// Token: 0x04001E50 RID: 7760
	[Token(Token = "0x4001E50")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 ActionButtonOffset;

	// Token: 0x04001E51 RID: 7761
	[Token(Token = "0x4001E51")]
	[FieldOffset(Offset = "0x28")]
	public Panel_Layout Backing;

	// Token: 0x04001E52 RID: 7762
	[Token(Token = "0x4001E52")]
	[FieldOffset(Offset = "0x2C")]
	public DraggableItemGrid_Layout OptionGrid;

	// Token: 0x04001E53 RID: 7763
	[Token(Token = "0x4001E53")]
	[FieldOffset(Offset = "0x30")]
	public SettingsOverlaySlider_Layout SliderTemplate;

	// Token: 0x04001E54 RID: 7764
	[Token(Token = "0x4001E54")]
	[FieldOffset(Offset = "0x34")]
	public TransactionButton_Layout SliderNotch;

	// Token: 0x04001E55 RID: 7765
	[Token(Token = "0x4001E55")]
	[FieldOffset(Offset = "0x38")]
	public SettingsOverlayPulldown_Layout PulldownTemplate;

	// Token: 0x04001E56 RID: 7766
	[Token(Token = "0x4001E56")]
	[FieldOffset(Offset = "0x3C")]
	public JourneySettingsToggle_Layout ToggleLayout;

	// Token: 0x04001E57 RID: 7767
	[Token(Token = "0x4001E57")]
	[FieldOffset(Offset = "0x40")]
	public JourneySettingsToggle_Layout DisabledToggleLayout;

	// Token: 0x04001E58 RID: 7768
	[Token(Token = "0x4001E58")]
	[FieldOffset(Offset = "0x44")]
	public Panel_Layout PulldownBacking;

	// Token: 0x04001E59 RID: 7769
	[Token(Token = "0x4001E59")]
	[FieldOffset(Offset = "0x48")]
	public ItemGrid_Layout PulldownOptionGrid;

	// Token: 0x04001E5A RID: 7770
	[Token(Token = "0x4001E5A")]
	[FieldOffset(Offset = "0x4C")]
	public ItemGrid_Layout PulldownOptionGridAxis;

	// Token: 0x04001E5B RID: 7771
	[Token(Token = "0x4001E5B")]
	[FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout PulldownOptionEntry;

	// Token: 0x04001E5C RID: 7772
	[Token(Token = "0x4001E5C")]
	[FieldOffset(Offset = "0x54")]
	public TransactionButton_Layout PulldownOptionTealEntry;

	// Token: 0x04001E5D RID: 7773
	[Token(Token = "0x4001E5D")]
	[FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout PulldownOptionGreenEntry;

	// Token: 0x04001E5E RID: 7774
	[Token(Token = "0x4001E5E")]
	[FieldOffset(Offset = "0x5C")]
	public TransactionButton_Layout PulldownOptionUnboundEntry;

	// Token: 0x04001E5F RID: 7775
	[Token(Token = "0x4001E5F")]
	[FieldOffset(Offset = "0x60")]
	public Vector2 PulldownAxisOffset;

	// Token: 0x04001E60 RID: 7776
	[Token(Token = "0x4001E60")]
	[FieldOffset(Offset = "0x68")]
	public Vector2 PulldownButtonOffset;

	// Token: 0x04001E61 RID: 7777
	[Token(Token = "0x4001E61")]
	[FieldOffset(Offset = "0x70")]
	public float PulldownOptionEntryIconScale;

	// Token: 0x04001E62 RID: 7778
	[Token(Token = "0x4001E62")]
	[FieldOffset(Offset = "0x74")]
	public VirtualControlsHardwareConfigurationMapping_Layout.ContolType[] ButtonControls;

	// Token: 0x04001E63 RID: 7779
	[Token(Token = "0x4001E63")]
	[FieldOffset(Offset = "0x78")]
	public VirtualControlsHardwareConfigurationMapping_Layout.ContolType[] AxisControls;

	// Token: 0x04001E64 RID: 7780
	[Token(Token = "0x4001E64")]
	[FieldOffset(Offset = "0x7C")]
	public JourneySettingsButton_Layout DeleteButtonTemplate;

	// Token: 0x04001E65 RID: 7781
	[Token(Token = "0x4001E65")]
	[FieldOffset(Offset = "0x80")]
	public String_Layout GroupButtonIndex;
}
