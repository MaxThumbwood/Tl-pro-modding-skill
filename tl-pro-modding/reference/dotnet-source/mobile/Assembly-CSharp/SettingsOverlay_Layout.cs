using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x0200023E RID: 574
[Token(Token = "0x200023E")]
public class SettingsOverlay_Layout : LayoutDefinition
{
	// Token: 0x06000E31 RID: 3633 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E31")]
	[Address(RVA = "0xC92BF0", Offset = "0xC92BF0", VA = "0xC92BF0")]
	private void Awake()
	{
	}

	// Token: 0x06000E32 RID: 3634 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E32")]
	[Address(RVA = "0xC92C44", Offset = "0xC92C44", VA = "0xC92C44")]
	public SettingsOverlay_Layout()
	{
	}

	// Token: 0x0400199E RID: 6558
	[Token(Token = "0x400199E")]
	[FieldOffset(Offset = "0x0")]
	public static SettingsOverlay_Layout Instance;

	// Token: 0x0400199F RID: 6559
	[Token(Token = "0x400199F")]
	[FieldOffset(Offset = "0xC")]
	public StringButton_Layout Title;

	// Token: 0x040019A0 RID: 6560
	[Token(Token = "0x40019A0")]
	[FieldOffset(Offset = "0x10")]
	public StringButton_Layout Titlewide1;

	// Token: 0x040019A1 RID: 6561
	[Token(Token = "0x40019A1")]
	[FieldOffset(Offset = "0x14")]
	public StringButton_Layout Titlewide2;

	// Token: 0x040019A2 RID: 6562
	[Token(Token = "0x40019A2")]
	[FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	// Token: 0x040019A3 RID: 6563
	[Token(Token = "0x40019A3")]
	[FieldOffset(Offset = "0x1C")]
	public DraggableItemGrid_Layout OptionGrid;

	// Token: 0x040019A4 RID: 6564
	[Token(Token = "0x40019A4")]
	[FieldOffset(Offset = "0x20")]
	public Panel_Layout MenuDivider;

	// Token: 0x040019A5 RID: 6565
	[Token(Token = "0x40019A5")]
	[FieldOffset(Offset = "0x24")]
	public Panel_Layout MenuDivider2;

	// Token: 0x040019A6 RID: 6566
	[Token(Token = "0x40019A6")]
	[FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout Close;

	// Token: 0x040019A7 RID: 6567
	[Token(Token = "0x40019A7")]
	[FieldOffset(Offset = "0x2C")]
	public TransactionButton_Layout Home;

	// Token: 0x040019A8 RID: 6568
	[Token(Token = "0x40019A8")]
	[FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout Achievements;

	// Token: 0x040019A9 RID: 6569
	[Token(Token = "0x40019A9")]
	[FieldOffset(Offset = "0x34")]
	public TransactionButton_Layout ResetSettings;

	// Token: 0x040019AA RID: 6570
	[Token(Token = "0x40019AA")]
	[FieldOffset(Offset = "0x38")]
	public String_Layout ServerIPAddress;

	// Token: 0x040019AB RID: 6571
	[Token(Token = "0x40019AB")]
	[FieldOffset(Offset = "0x3C")]
	public SettingsOverlayOptionCategories_Layout.Category DefaultCategory;

	// Token: 0x040019AC RID: 6572
	[Token(Token = "0x40019AC")]
	[FieldOffset(Offset = "0x40")]
	public SettingsOverlayCategories_Layout Categories;

	// Token: 0x040019AD RID: 6573
	[Token(Token = "0x40019AD")]
	[FieldOffset(Offset = "0x44")]
	public SettingsOverlayOptionCategories_Layout OptionCategories;

	// Token: 0x040019AE RID: 6574
	[Token(Token = "0x40019AE")]
	[FieldOffset(Offset = "0x48")]
	public SettingsOverlayLink_Layout LinkTemplate;

	// Token: 0x040019AF RID: 6575
	[Token(Token = "0x40019AF")]
	[FieldOffset(Offset = "0x4C")]
	public SettingsOverlayListOption_Layout ListOptionTemplate;

	// Token: 0x040019B0 RID: 6576
	[Token(Token = "0x40019B0")]
	[FieldOffset(Offset = "0x50")]
	public SettingsOverlaySlider_Layout SliderTemplate;

	// Token: 0x040019B1 RID: 6577
	[Token(Token = "0x40019B1")]
	[FieldOffset(Offset = "0x54")]
	public SettingsOverlayToggle_Layout ToggleTemplate;

	// Token: 0x040019B2 RID: 6578
	[Token(Token = "0x40019B2")]
	[FieldOffset(Offset = "0x58")]
	public SettingsOverlayToggle_Layout DisabledToggleTemplate;

	// Token: 0x040019B3 RID: 6579
	[Token(Token = "0x40019B3")]
	[FieldOffset(Offset = "0x5C")]
	public SettingsOverlayCycle_Layout CycleTemplate;

	// Token: 0x040019B4 RID: 6580
	[Token(Token = "0x40019B4")]
	[FieldOffset(Offset = "0x60")]
	public SettingsOverlayPulldown_Layout PulldownTemplate;

	// Token: 0x040019B5 RID: 6581
	[Token(Token = "0x40019B5")]
	[FieldOffset(Offset = "0x64")]
	public SettingsOverlayListOption_Layout UIButtonOptionTemplate;

	// Token: 0x040019B6 RID: 6582
	[Token(Token = "0x40019B6")]
	[FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout PulldownLBOption;

	// Token: 0x040019B7 RID: 6583
	[Token(Token = "0x40019B7")]
	[FieldOffset(Offset = "0x6C")]
	public TransactionButton_Layout PulldownLTOption;

	// Token: 0x040019B8 RID: 6584
	[Token(Token = "0x40019B8")]
	[FieldOffset(Offset = "0x70")]
	public TransactionButton_Layout PulldownRBOption;

	// Token: 0x040019B9 RID: 6585
	[Token(Token = "0x40019B9")]
	[FieldOffset(Offset = "0x74")]
	public TransactionButton_Layout PulldownRTOption;

	// Token: 0x040019BA RID: 6586
	[Token(Token = "0x40019BA")]
	[FieldOffset(Offset = "0x78")]
	public TransactionButton_Layout PulldownAction1Option;

	// Token: 0x040019BB RID: 6587
	[Token(Token = "0x40019BB")]
	[FieldOffset(Offset = "0x7C")]
	public TransactionButton_Layout PulldownAction2Option;

	// Token: 0x040019BC RID: 6588
	[Token(Token = "0x40019BC")]
	[FieldOffset(Offset = "0x80")]
	public TransactionButton_Layout PulldownAction3Option;

	// Token: 0x040019BD RID: 6589
	[Token(Token = "0x40019BD")]
	[FieldOffset(Offset = "0x84")]
	public TransactionButton_Layout PulldownAction4Option;

	// Token: 0x040019BE RID: 6590
	[Token(Token = "0x40019BE")]
	[FieldOffset(Offset = "0x88")]
	public Vector2 PulldownMainButtonOffset;

	// Token: 0x040019BF RID: 6591
	[Token(Token = "0x40019BF")]
	[FieldOffset(Offset = "0x90")]
	public int PulldownButtonLineWidth;

	// Token: 0x040019C0 RID: 6592
	[Token(Token = "0x40019C0")]
	[FieldOffset(Offset = "0x94")]
	public int InGameOffset;
}
