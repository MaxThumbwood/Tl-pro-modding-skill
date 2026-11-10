using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020002BF RID: 703
[Token(Token = "0x20002BF")]
public class GUIVirtualInputControllerEdit_ControlPanel
{
	// Token: 0x0600110A RID: 4362 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600110A")]
	[Address(RVA = "0xD2A70C", Offset = "0xD2A70C", VA = "0xD2A70C")]
	private void Init()
	{
	}

	// Token: 0x0600110B RID: 4363 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600110B")]
	[Address(RVA = "0xD2B050", Offset = "0xD2B050", VA = "0xD2B050")]
	public void CloseButtonOverlay()
	{
	}

	// Token: 0x0600110C RID: 4364 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600110C")]
	[Address(RVA = "0xD2B054", Offset = "0xD2B054", VA = "0xD2B054")]
	private static void ActivateOverlayCallback(GUIPulldownSetting overlayEntry, Rectangle overlayRegion, int selectedOption, float offset)
	{
	}

	// Token: 0x0600110D RID: 4365 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600110D")]
	[Address(RVA = "0xD2B1EC", Offset = "0xD2B1EC", VA = "0xD2B1EC")]
	private static void DeactivateOverlayCallback()
	{
	}

	// Token: 0x0600110E RID: 4366 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600110E")]
	[Address(RVA = "0xD2B2BC", Offset = "0xD2B2BC", VA = "0xD2B2BC")]
	private static void RegisterOverlayCallback(GUIPulldownSetting overlayEntry, Rectangle overlayRegion)
	{
	}

	// Token: 0x0600110F RID: 4367 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600110F")]
	[Address(RVA = "0xD2B1CC", Offset = "0xD2B1CC", VA = "0xD2B1CC")]
	private void RegisterOverlay(GUIPulldownSetting entry, Rectangle region)
	{
	}

	// Token: 0x06001110 RID: 4368 RVA: 0x00008280 File Offset: 0x00006480
	[Token(Token = "0x6001110")]
	[Address(RVA = "0xD2B37C", Offset = "0xD2B37C", VA = "0xD2B37C")]
	private Rectangle GetControlSize(VirtualControlsSlotTypeMapping_Layout.SlotType slotType, Vector2 controlPosition)
	{
		return default(Rectangle);
	}

	// Token: 0x06001111 RID: 4369 RVA: 0x00008298 File Offset: 0x00006498
	[Token(Token = "0x6001111")]
	[Address(RVA = "0xD2B4C0", Offset = "0xD2B4C0", VA = "0xD2B4C0")]
	public bool IsOverUI(Vector2 cursorUIPosition)
	{
		return default(bool);
	}

	// Token: 0x06001112 RID: 4370 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001112")]
	[Address(RVA = "0xD2B59C", Offset = "0xD2B59C", VA = "0xD2B59C")]
	public void DrawSelectedControl(int selectedControl)
	{
	}

	// Token: 0x06001113 RID: 4371 RVA: 0x000082B0 File Offset: 0x000064B0
	[Token(Token = "0x6001113")]
	[Address(RVA = "0xD2BEB0", Offset = "0xD2BEB0", VA = "0xD2BEB0")]
	private float SettingScale(int index)
	{
		return 0f;
	}

	// Token: 0x06001114 RID: 4372 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001114")]
	[Address(RVA = "0xD2BEB8", Offset = "0xD2BEB8", VA = "0xD2BEB8")]
	private void SettingOver(int index)
	{
	}

	// Token: 0x06001115 RID: 4373 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001115")]
	[Address(RVA = "0xD2BF7C", Offset = "0xD2BF7C", VA = "0xD2BF7C")]
	private void SettingDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x06001116 RID: 4374 RVA: 0x000082C8 File Offset: 0x000064C8
	[Token(Token = "0x6001116")]
	[Address(RVA = "0xD2C14C", Offset = "0xD2C14C", VA = "0xD2C14C")]
	private Vector2 SettingSize(int index)
	{
		return default(Vector2);
	}

	// Token: 0x06001117 RID: 4375 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001117")]
	[Address(RVA = "0xD2BC60", Offset = "0xD2BC60", VA = "0xD2BC60")]
	private void DrawControlBacking(int optionCount, Rectangle controlRegion, bool rightSidePanel)
	{
	}

	// Token: 0x06001118 RID: 4376 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001118")]
	[Address(RVA = "0xD2C250", Offset = "0xD2C250", VA = "0xD2C250")]
	public GUIVirtualInputControllerEdit_ControlPanel()
	{
	}

	// Token: 0x040021BC RID: 8636
	[Token(Token = "0x40021BC")]
	[FieldOffset(Offset = "0x8")]
	public bool buttonOverlayOpen;

	// Token: 0x040021BD RID: 8637
	[Token(Token = "0x40021BD")]
	[FieldOffset(Offset = "0xC")]
	private int buttonOverlayIndex;

	// Token: 0x040021BE RID: 8638
	[Token(Token = "0x40021BE")]
	[FieldOffset(Offset = "0x10")]
	private int buttonOverlayControlIndex;

	// Token: 0x040021BF RID: 8639
	[Token(Token = "0x40021BF")]
	[FieldOffset(Offset = "0x14")]
	private Rectangle cachedButtonOverlayDrawRegion;

	// Token: 0x040021C0 RID: 8640
	[Token(Token = "0x40021C0")]
	[FieldOffset(Offset = "0x24")]
	private float ScrollOffset;

	// Token: 0x040021C1 RID: 8641
	[Token(Token = "0x40021C1")]
	[FieldOffset(Offset = "0x28")]
	private float ScrollMomentum;

	// Token: 0x040021C2 RID: 8642
	[Token(Token = "0x40021C2")]
	[FieldOffset(Offset = "0x2C")]
	private int ScrollDragging;

	// Token: 0x040021C3 RID: 8643
	[Token(Token = "0x40021C3")]
	[FieldOffset(Offset = "0x30")]
	private Vector2 DragOffset;

	// Token: 0x040021C4 RID: 8644
	[Token(Token = "0x40021C4")]
	[FieldOffset(Offset = "0x38")]
	private int disableScroll;

	// Token: 0x040021C5 RID: 8645
	[Token(Token = "0x40021C5")]
	[FieldOffset(Offset = "0x3C")]
	private GUISettingEntry overlayEntry;

	// Token: 0x040021C6 RID: 8646
	[Token(Token = "0x40021C6")]
	[FieldOffset(Offset = "0x40")]
	private Rectangle overlayRegion;

	// Token: 0x040021C7 RID: 8647
	[Token(Token = "0x40021C7")]
	[FieldOffset(Offset = "0x0")]
	private static VirtualControlsBinding_Layout ActiveControl;

	// Token: 0x040021C8 RID: 8648
	[Token(Token = "0x40021C8")]
	[FieldOffset(Offset = "0x4")]
	private static VirtualControlsHardwareConfigurationMapping_Layout ActiveSlotConfig;

	// Token: 0x040021C9 RID: 8649
	[Token(Token = "0x40021C9")]
	[FieldOffset(Offset = "0x50")]
	private GUIVirtualInputControllerEdit_ControlPanel.ControlPanelSizeSlider sizeSlider;

	// Token: 0x040021CA RID: 8650
	[Token(Token = "0x40021CA")]
	[FieldOffset(Offset = "0x54")]
	private GUIVirtualInputControllerEdit_ControlPanel.ControlPanelToggleSetting multiTouchToggle;

	// Token: 0x040021CB RID: 8651
	[Token(Token = "0x40021CB")]
	[FieldOffset(Offset = "0x58")]
	private GUIVirtualInputControllerEdit_ControlPanel.ControlPanelDeleteButton deleteEntry;

	// Token: 0x040021CC RID: 8652
	[Token(Token = "0x40021CC")]
	[FieldOffset(Offset = "0x5C")]
	private List<GUISettingEntry> _AxisEntries;

	// Token: 0x040021CD RID: 8653
	[Token(Token = "0x40021CD")]
	[FieldOffset(Offset = "0x60")]
	private List<GUISettingEntry> _ButtonEntries;

	// Token: 0x040021CE RID: 8654
	[Token(Token = "0x40021CE")]
	[FieldOffset(Offset = "0x64")]
	private List<GUISettingEntry> _GroupEntries;

	// Token: 0x040021CF RID: 8655
	[Token(Token = "0x40021CF")]
	[FieldOffset(Offset = "0x68")]
	private List<GUISettingEntry> _controlEntries;

	// Token: 0x040021D0 RID: 8656
	[Token(Token = "0x40021D0")]
	[FieldOffset(Offset = "0x8")]
	private static int frameActivated;

	// Token: 0x040021D1 RID: 8657
	[Token(Token = "0x40021D1")]
	[FieldOffset(Offset = "0x6C")]
	private Rectangle cachedDrawRegion;

	// Token: 0x020002C0 RID: 704
	[Token(Token = "0x20002C0")]
	public class ControlPanelToggleSetting : GUIToggleSetting
	{
		// Token: 0x0600111A RID: 4378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600111A")]
		[Address(RVA = "0xD2C4E0", Offset = "0xD2C4E0", VA = "0xD2C4E0")]
		public ControlPanelToggleSetting()
		{
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600111B")]
		[Address(RVA = "0xD2C560", Offset = "0xD2C560", VA = "0xD2C560", Slot = "12")]
		protected override string GetOption()
		{
			return null;
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600111C")]
		[Address(RVA = "0xD2C5E0", Offset = "0xD2C5E0", VA = "0xD2C5E0", Slot = "11")]
		protected override string GetOptionOff()
		{
			return null;
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600111D")]
		[Address(RVA = "0xD2C660", Offset = "0xD2C660", VA = "0xD2C660", Slot = "10")]
		protected override string GetOptionOn()
		{
			return null;
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600111E")]
		[Address(RVA = "0xD2C6E0", Offset = "0xD2C6E0", VA = "0xD2C6E0", Slot = "14")]
		public override void Toggle()
		{
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x000082E0 File Offset: 0x000064E0
		[Token(Token = "0x600111F")]
		[Address(RVA = "0xD2C7E0", Offset = "0xD2C7E0", VA = "0xD2C7E0", Slot = "13")]
		protected override bool GetSelected()
		{
			return default(bool);
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x000082F8 File Offset: 0x000064F8
		[Token(Token = "0x6001120")]
		[Address(RVA = "0xD2C8DC", Offset = "0xD2C8DC", VA = "0xD2C8DC", Slot = "9")]
		protected override bool IsDisabled()
		{
			return default(bool);
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001121")]
		[Address(RVA = "0xD2C974", Offset = "0xD2C974", VA = "0xD2C974", Slot = "4")]
		public override void Draw()
		{
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001122")]
		[Address(RVA = "0xD2CA5C", Offset = "0xD2CA5C", VA = "0xD2CA5C", Slot = "7")]
		protected override SettingsOverlayToggle_Layout GetLayout()
		{
			return null;
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001123")]
		[Address(RVA = "0xD2CAC4", Offset = "0xD2CAC4", VA = "0xD2CAC4", Slot = "8")]
		protected override SettingsOverlayToggle_Layout GetDisabledLayout()
		{
			return null;
		}

		// Token: 0x040021D2 RID: 8658
		[Token(Token = "0x40021D2")]
		[FieldOffset(Offset = "0x18")]
		private float iconScale;
	}

	// Token: 0x020002C1 RID: 705
	[Token(Token = "0x20002C1")]
	public class ControlPanelSizeSlider : GUISliderSetting
	{
		// Token: 0x06001124 RID: 4388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001124")]
		[Address(RVA = "0xD2C43C", Offset = "0xD2C43C", VA = "0xD2C43C")]
		public ControlPanelSizeSlider()
		{
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001125")]
		[Address(RVA = "0xD2CB2C", Offset = "0xD2CB2C", VA = "0xD2CB2C")]
		public void SizeBackingHandler(Vector2 position, Vector2 size, Slider_Layout layout, bool controllerOver)
		{
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001126")]
		[Address(RVA = "0xD2CCF8", Offset = "0xD2CCF8", VA = "0xD2CCF8", Slot = "4")]
		public override void Draw()
		{
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x00008310 File Offset: 0x00006510
		[Token(Token = "0x6001127")]
		[Address(RVA = "0xD2CD00", Offset = "0xD2CD00", VA = "0xD2CD00", Slot = "9")]
		public override int GetMaxValue()
		{
			return 0;
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x00008328 File Offset: 0x00006528
		[Token(Token = "0x6001128")]
		[Address(RVA = "0xD2CF60", Offset = "0xD2CF60", VA = "0xD2CF60")]
		public static int GetSizeIndex(VirtualControlsHardwareConfigurationMapping_Layout slot, VirtualControlsBinding_Layout binding)
		{
			return 0;
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x00008340 File Offset: 0x00006540
		[Token(Token = "0x6001129")]
		[Address(RVA = "0xD2D1A0", Offset = "0xD2D1A0", VA = "0xD2D1A0", Slot = "8")]
		public override float GetValue()
		{
			return 0f;
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600112A")]
		[Address(RVA = "0xD2D48C", Offset = "0xD2D48C", VA = "0xD2D48C", Slot = "10")]
		public override void SetValue(float value)
		{
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600112B")]
		[Address(RVA = "0xD2D978", Offset = "0xD2D978", VA = "0xD2D978", Slot = "12")]
		public override string GetTitle()
		{
			return null;
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600112C")]
		[Address(RVA = "0xD2D9F8", Offset = "0xD2D9F8", VA = "0xD2D9F8", Slot = "11")]
		public override string GetStringValue()
		{
			return null;
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600112D")]
		[Address(RVA = "0xD2DA48", Offset = "0xD2DA48", VA = "0xD2DA48", Slot = "7")]
		protected override SettingsOverlaySlider_Layout GetLayout()
		{
			return null;
		}

		// Token: 0x040021D3 RID: 8659
		[Token(Token = "0x40021D3")]
		[FieldOffset(Offset = "0x0")]
		private static string[] AxisSizeStyles;

		// Token: 0x040021D4 RID: 8660
		[Token(Token = "0x40021D4")]
		[FieldOffset(Offset = "0x4")]
		private static string[] ActionButtonSizeStyles;

		// Token: 0x040021D5 RID: 8661
		[Token(Token = "0x40021D5")]
		[FieldOffset(Offset = "0x8")]
		private static string[] MetaButtonSizeStyles;

		// Token: 0x040021D6 RID: 8662
		[Token(Token = "0x40021D6")]
		[FieldOffset(Offset = "0xC")]
		private static string[] GroupSizeStyles;
	}

	// Token: 0x020002C2 RID: 706
	[Token(Token = "0x20002C2")]
	public class ControlPanelActionSetting : GUIPulldownSetting
	{
		// Token: 0x0600112F RID: 4399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600112F")]
		[Address(RVA = "0xD2AE94", Offset = "0xD2AE94", VA = "0xD2AE94")]
		public ControlPanelActionSetting(GUIVirtualInputControllerEdit_ControlPanel.ControlPanelActionSetting.ActionBindingType actionBinding)
		{
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001130")]
		[Address(RVA = "0xD2DF18", Offset = "0xD2DF18", VA = "0xD2DF18")]
		private void DrawButtonIcon(Vector2 gridItemOffset, VirtualControlsHardwareConfigurationMapping_Layout.ContolType controlType, bool noBacking = false)
		{
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001131")]
		[Address(RVA = "0xD2E8A4", Offset = "0xD2E8A4", VA = "0xD2E8A4", Slot = "4")]
		public override void Draw()
		{
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x00008358 File Offset: 0x00006558
		[Token(Token = "0x6001132")]
		[Address(RVA = "0xD2ECA8", Offset = "0xD2ECA8", VA = "0xD2ECA8", Slot = "5")]
		public override float GetElementHeight()
		{
			return 0f;
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x00008370 File Offset: 0x00006570
		[Token(Token = "0x6001133")]
		[Address(RVA = "0xD2ECB0", Offset = "0xD2ECB0", VA = "0xD2ECB0")]
		private float PulldownOptionSize(int index)
		{
			return 0f;
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001134")]
		[Address(RVA = "0xD2ECB8", Offset = "0xD2ECB8", VA = "0xD2ECB8")]
		private void PulldownOptionOver(int index)
		{
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001135")]
		[Address(RVA = "0xD2ECBC", Offset = "0xD2ECBC", VA = "0xD2ECBC")]
		private void PulldownOptionDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
		{
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001136")]
		[Address(RVA = "0xD2F9A0", Offset = "0xD2F9A0", VA = "0xD2F9A0")]
		private void SetupOptionEntrySize()
		{
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x00008388 File Offset: 0x00006588
		[Token(Token = "0x6001137")]
		[Address(RVA = "0xD2FD2C", Offset = "0xD2FD2C", VA = "0xD2FD2C")]
		private Vector2 PulldownOptionItremSize(int index)
		{
			return default(Vector2);
		}

		// Token: 0x06001138 RID: 4408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001138")]
		[Address(RVA = "0xD2EBCC", Offset = "0xD2EBCC", VA = "0xD2EBCC")]
		private void DrawGroupMappingIndex()
		{
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001139")]
		[Address(RVA = "0xD2FE70", Offset = "0xD2FE70", VA = "0xD2FE70", Slot = "6")]
		public override void DrawOverlay()
		{
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600113A")]
		[Address(RVA = "0xD31428", Offset = "0xD31428", VA = "0xD31428", Slot = "7")]
		public override SettingsOverlayPulldown_Layout GetLayout()
		{
			return null;
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600113B")]
		[Address(RVA = "0xD31490", Offset = "0xD31490", VA = "0xD31490", Slot = "13")]
		protected override string GetValue()
		{
			return null;
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600113C")]
		[Address(RVA = "0xD2F534", Offset = "0xD2F534", VA = "0xD2F534")]
		private void UpdateValue(VirtualControlsHardwareConfigurationMapping_Layout.ContolType newValue)
		{
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x000083A0 File Offset: 0x000065A0
		[Token(Token = "0x600113D")]
		[Address(RVA = "0xD2E9D4", Offset = "0xD2E9D4", VA = "0xD2E9D4")]
		private VirtualControlsHardwareConfigurationMapping_Layout.ContolType GetControlType()
		{
			return VirtualControlsHardwareConfigurationMapping_Layout.ContolType.AutoFire;
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600113E")]
		[Address(RVA = "0xD31530", Offset = "0xD31530", VA = "0xD31530", Slot = "11")]
		protected override string GetOption(int index)
		{
			return null;
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x000083B8 File Offset: 0x000065B8
		[Token(Token = "0x600113F")]
		[Address(RVA = "0xD315D0", Offset = "0xD315D0", VA = "0xD315D0", Slot = "9")]
		public override int GetNumberOfOptions()
		{
			return 0;
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x000083D0 File Offset: 0x000065D0
		[Token(Token = "0x6001140")]
		[Address(RVA = "0xD315D8", Offset = "0xD315D8", VA = "0xD315D8", Slot = "8")]
		protected override bool IsOverOptions(Vector2 cursorPosition)
		{
			return default(bool);
		}

		// Token: 0x040021D7 RID: 8663
		[Token(Token = "0x40021D7")]
		[FieldOffset(Offset = "0x3C")]
		private GUIVirtualInputControllerEdit_ControlPanel.ControlPanelActionSetting.ActionBindingType ActionBinding;

		// Token: 0x040021D8 RID: 8664
		[Token(Token = "0x40021D8")]
		[FieldOffset(Offset = "0x40")]
		private float controlScale;

		// Token: 0x040021D9 RID: 8665
		[Token(Token = "0x40021D9")]
		[FieldOffset(Offset = "0x0")]
		private static int currentLanguage;

		// Token: 0x040021DA RID: 8666
		[Token(Token = "0x40021DA")]
		[FieldOffset(Offset = "0x4")]
		private static int optionCount;

		// Token: 0x040021DB RID: 8667
		[Token(Token = "0x40021DB")]
		[FieldOffset(Offset = "0x8")]
		private static Vector2 originalSize;

		// Token: 0x040021DC RID: 8668
		[Token(Token = "0x40021DC")]
		[FieldOffset(Offset = "0x10")]
		private static Vector2 maxOptionSize;

		// Token: 0x040021DD RID: 8669
		[Token(Token = "0x40021DD")]
		[FieldOffset(Offset = "0x44")]
		private int selectedOption;

		// Token: 0x040021DE RID: 8670
		[Token(Token = "0x40021DE")]
		[FieldOffset(Offset = "0x48")]
		private VirtualControlsHardwareConfigurationMapping_Layout.ContolType[] controlOptions;

		// Token: 0x040021DF RID: 8671
		[Token(Token = "0x40021DF")]
		[FieldOffset(Offset = "0x4C")]
		private bool axisOptions;

		// Token: 0x020002C3 RID: 707
		[Token(Token = "0x20002C3")]
		public enum ActionBindingType
		{
			// Token: 0x040021E1 RID: 8673
			[Token(Token = "0x40021E1")]
			AxisBinding,
			// Token: 0x040021E2 RID: 8674
			[Token(Token = "0x40021E2")]
			ButtonBinding,
			// Token: 0x040021E3 RID: 8675
			[Token(Token = "0x40021E3")]
			GroupBinding0,
			// Token: 0x040021E4 RID: 8676
			[Token(Token = "0x40021E4")]
			GroupBinding1,
			// Token: 0x040021E5 RID: 8677
			[Token(Token = "0x40021E5")]
			GroupBinding2,
			// Token: 0x040021E6 RID: 8678
			[Token(Token = "0x40021E6")]
			GroupBinding3
		}
	}

	// Token: 0x020002C4 RID: 708
	[Token(Token = "0x20002C4")]
	public class ControlPanelDeleteButton : GUIOpenUIButtonSetting
	{
		// Token: 0x06001142 RID: 4418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001142")]
		[Address(RVA = "0xD2C4EC", Offset = "0xD2C4EC", VA = "0xD2C4EC")]
		public ControlPanelDeleteButton()
		{
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001143")]
		[Address(RVA = "0xD317C0", Offset = "0xD317C0", VA = "0xD317C0", Slot = "4")]
		public override void Draw()
		{
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001144")]
		[Address(RVA = "0xD318A8", Offset = "0xD318A8", VA = "0xD318A8", Slot = "7")]
		protected override SettingsOverlayListOption_Layout GetLayout()
		{
			return null;
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001145")]
		[Address(RVA = "0xD31910", Offset = "0xD31910", VA = "0xD31910", Slot = "9")]
		protected override string GetOption()
		{
			return null;
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001146")]
		[Address(RVA = "0xD31990", Offset = "0xD31990", VA = "0xD31990", Slot = "10")]
		protected override void OpenUI()
		{
		}

		// Token: 0x040021E7 RID: 8679
		[Token(Token = "0x40021E7")]
		[FieldOffset(Offset = "0x18")]
		private float iconScale;
	}
}
