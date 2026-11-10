using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

// Token: 0x02000189 RID: 393
[Token(Token = "0x2000189")]
public class GUIVirtualInputController
{
	// Token: 0x06000B8D RID: 2957 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B8D")]
	[Address(RVA = "0xBFE9B0", Offset = "0xBFE9B0", VA = "0xBFE9B0")]
	public void ResetItemToggleValues()
	{
	}

	// Token: 0x1700010A RID: 266
	// (get) Token: 0x06000B8E RID: 2958 RVA: 0x00006AF8 File Offset: 0x00004CF8
	[Token(Token = "0x1700010A")]
	public ButtonControlMode ScopePanMode
	{
		[Token(Token = "0x6000B8E")]
		[Address(RVA = "0xBFE9C4", Offset = "0xBFE9C4", VA = "0xBFE9C4")]
		get
		{
			return ButtonControlMode.Hold;
		}
	}

	// Token: 0x06000B8F RID: 2959 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B8F")]
	[Address(RVA = "0xBFEA50", Offset = "0xBFEA50", VA = "0xBFEA50")]
	public GUIVirtualInputController()
	{
	}

	// Token: 0x06000B90 RID: 2960 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B90")]
	[Address(RVA = "0xBFEE74", Offset = "0xBFEE74", VA = "0xBFEE74")]
	public static void LoadContent(ContentManager content)
	{
	}

	// Token: 0x1700010B RID: 267
	// (get) Token: 0x06000B91 RID: 2961 RVA: 0x00006B10 File Offset: 0x00004D10
	[Token(Token = "0x1700010B")]
	private bool HasGrapple
	{
		[Token(Token = "0x6000B91")]
		[Address(RVA = "0xBFF024", Offset = "0xBFF024", VA = "0xBFF024")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700010C RID: 268
	// (get) Token: 0x06000B92 RID: 2962 RVA: 0x00006B28 File Offset: 0x00004D28
	[Token(Token = "0x1700010C")]
	public bool JumpTapPressed
	{
		[Token(Token = "0x6000B92")]
		[Address(RVA = "0xBFF0C8", Offset = "0xBFF0C8", VA = "0xBFF0C8")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700010D RID: 269
	// (get) Token: 0x06000B93 RID: 2963 RVA: 0x00006B40 File Offset: 0x00004D40
	[Token(Token = "0x1700010D")]
	public bool WasJumpTapPressed
	{
		[Token(Token = "0x6000B93")]
		[Address(RVA = "0xBFF0E8", Offset = "0xBFF0E8", VA = "0xBFF0E8")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000B94 RID: 2964 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B94")]
	[Address(RVA = "0xBFF1A4", Offset = "0xBFF1A4", VA = "0xBFF1A4")]
	private void UpdateMovementAxis(Vector2 rawAxis)
	{
	}

	// Token: 0x06000B95 RID: 2965 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B95")]
	[Address(RVA = "0xBFF764", Offset = "0xBFF764", VA = "0xBFF764")]
	private void UpdateFireAxis(Vector2 rawAxis)
	{
	}

	// Token: 0x06000B96 RID: 2966 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B96")]
	[Address(RVA = "0xBFF914", Offset = "0xBFF914", VA = "0xBFF914")]
	private void HideNotifications()
	{
	}

	// Token: 0x06000B97 RID: 2967 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B97")]
	[Address(RVA = "0xBFF930", Offset = "0xBFF930", VA = "0xBFF930")]
	private void AddInteractBanner(Player player, Item item)
	{
	}

	// Token: 0x06000B98 RID: 2968 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B98")]
	[Address(RVA = "0xC013C0", Offset = "0xC013C0", VA = "0xC013C0")]
	public void ResetSMCurosrNotification()
	{
	}

	// Token: 0x06000B99 RID: 2969 RVA: 0x00006B58 File Offset: 0x00004D58
	[Token(Token = "0x6000B99")]
	[Address(RVA = "0xC013E0", Offset = "0xC013E0", VA = "0xC013E0")]
	public static bool CanInteract(Player player, Item item)
	{
		return default(bool);
	}

	// Token: 0x06000B9A RID: 2970 RVA: 0x00006B70 File Offset: 0x00004D70
	[Token(Token = "0x6000B9A")]
	[Address(RVA = "0xC01D88", Offset = "0xC01D88", VA = "0xC01D88")]
	public bool IsToggleButton(VirtualControlsHardwareConfigurationMapping_Layout.ContolType type)
	{
		return default(bool);
	}

	// Token: 0x06000B9B RID: 2971 RVA: 0x00006B88 File Offset: 0x00004D88
	[Token(Token = "0x6000B9B")]
	[Address(RVA = "0xC01DC8", Offset = "0xC01DC8", VA = "0xC01DC8")]
	public Vector2 GetPressedControlPosition(VirtualControlsHardwareConfigurationMapping_Layout.ContolType controlType, out VirtualControlsHardwareConfigurationMapping_Layout slotConfiguration)
	{
		return default(Vector2);
	}

	// Token: 0x06000B9C RID: 2972 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B9C")]
	[Address(RVA = "0xC02204", Offset = "0xC02204", VA = "0xC02204")]
	private void HandleTouchCursorDown(int slot, Vector2 cursorUIPosition, Cursor cursor)
	{
	}

	// Token: 0x06000B9D RID: 2973 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B9D")]
	[Address(RVA = "0xC057F8", Offset = "0xC057F8", VA = "0xC057F8")]
	public void Update(float elapsedTime)
	{
	}

	// Token: 0x1700010E RID: 270
	// (get) Token: 0x06000B9E RID: 2974 RVA: 0x00006BA0 File Offset: 0x00004DA0
	[Token(Token = "0x1700010E")]
	public bool LeftStickAimingChecked
	{
		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0xC12864", Offset = "0xC12864", VA = "0xC12864")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000B9F RID: 2975 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B9F")]
	[Address(RVA = "0xC12950", Offset = "0xC12950", VA = "0xC12950")]
	private void HandleCursorGridSnap(bool tileBoostWholeScreen, int screenCenterX, int screenCenterY, int tB, ref float MouseX, ref float MouseY)
	{
	}

	// Token: 0x06000BA0 RID: 2976 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BA0")]
	[Address(RVA = "0xC12F80", Offset = "0xC12F80", VA = "0xC12F80")]
	private void HandleGridSnapCursorMovement(Item selectedItem, int screenCenterX, int screenCenterY, int tB, ref float MouseX, ref float MouseY)
	{
	}

	// Token: 0x06000BA1 RID: 2977 RVA: 0x00006BB8 File Offset: 0x00004DB8
	[Token(Token = "0x6000BA1")]
	[Address(RVA = "0xC13C98", Offset = "0xC13C98", VA = "0xC13C98")]
	private Vector2 FilterFireAxis(Vector2 fireAxis)
	{
		return default(Vector2);
	}

	// Token: 0x06000BA2 RID: 2978 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BA2")]
	[Address(RVA = "0xC13D10", Offset = "0xC13D10", VA = "0xC13D10")]
	public void LoadUIGrappleCursor()
	{
	}

	// Token: 0x06000BA3 RID: 2979 RVA: 0x00006BD0 File Offset: 0x00004DD0
	[Token(Token = "0x6000BA3")]
	[Address(RVA = "0xC13F80", Offset = "0xC13F80", VA = "0xC13F80")]
	public bool CursorCanSnapBack()
	{
		return default(bool);
	}

	// Token: 0x06000BA4 RID: 2980 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BA4")]
	[Address(RVA = "0xC0F3D0", Offset = "0xC0F3D0", VA = "0xC0F3D0")]
	private void UpdateCursorMovement()
	{
	}

	// Token: 0x1700010F RID: 271
	// (get) Token: 0x06000BA5 RID: 2981 RVA: 0x00006BE8 File Offset: 0x00004DE8
	[Token(Token = "0x1700010F")]
	public bool InGameUIOpen
	{
		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0xC0F1EC", Offset = "0xC0F1EC", VA = "0xC0F1EC")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000110 RID: 272
	// (get) Token: 0x06000BA6 RID: 2982 RVA: 0x00006C00 File Offset: 0x00004E00
	[Token(Token = "0x17000110")]
	private int SlotFrameFade
	{
		[Token(Token = "0x6000BA6")]
		[Address(RVA = "0xC141B4", Offset = "0xC141B4", VA = "0xC141B4")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06000BA7 RID: 2983 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BA7")]
	[Address(RVA = "0xC1421C", Offset = "0xC1421C", VA = "0xC1421C")]
	private void UpdateSlotVisible(int slot, bool visible)
	{
	}

	// Token: 0x06000BA8 RID: 2984 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BA8")]
	[Address(RVA = "0xC14370", Offset = "0xC14370", VA = "0xC14370")]
	public void UpdateControlVisibilityRegions(bool force = false)
	{
	}

	// Token: 0x06000BA9 RID: 2985 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BA9")]
	[Address(RVA = "0xC16BF0", Offset = "0xC16BF0", VA = "0xC16BF0")]
	public void SecondaryUpdateCursor(Cursor cursor)
	{
	}

	// Token: 0x06000BAA RID: 2986 RVA: 0x00006C18 File Offset: 0x00004E18
	[Token(Token = "0x6000BAA")]
	[Address(RVA = "0xC17F14", Offset = "0xC17F14", VA = "0xC17F14")]
	private bool IsOverGroupRegion(GUIPageIconGrouping group, Point mousePoint)
	{
		return default(bool);
	}

	// Token: 0x06000BAB RID: 2987 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BAB")]
	[Address(RVA = "0xC19870", Offset = "0xC19870", VA = "0xC19870")]
	public void UpdateCursor(Cursor cursor)
	{
	}

	// Token: 0x06000BAC RID: 2988 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BAC")]
	[Address(RVA = "0xC1A934", Offset = "0xC1A934", VA = "0xC1A934")]
	private void UpdateExpandedCursorGroupControl(Vector2 cursorUIPosition, Cursor cursor, int slot, VirtualControlsBinding_Layout binding, VirtualControlsHardwareConfigurationMapping_Layout slotConfig, bool expanded, ref float expandedSize)
	{
	}

	// Token: 0x06000BAD RID: 2989 RVA: 0x00006C30 File Offset: 0x00004E30
	[Token(Token = "0x6000BAD")]
	[Address(RVA = "0xC164E4", Offset = "0xC164E4", VA = "0xC164E4")]
	private bool DetermineGroupVisible(int slot, VirtualControlsBinding_Layout binding, VirtualControlsHardwareConfigurationMapping_Layout slotConfig)
	{
		return default(bool);
	}

	// Token: 0x06000BAE RID: 2990 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BAE")]
	[Address(RVA = "0xC179B8", Offset = "0xC179B8", VA = "0xC179B8")]
	private void UpdateCursorGroupControl(Vector2 cursorUIPosition, Cursor cursor, int slot, VirtualControlsBinding_Layout binding, VirtualControlsHardwareConfigurationMapping_Layout slotConfig, bool expanded, ref float expandedSize)
	{
	}

	// Token: 0x06000BAF RID: 2991 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BAF")]
	[Address(RVA = "0xC1AE74", Offset = "0xC1AE74", VA = "0xC1AE74")]
	private void UpdateCursorSecondaryButtonControl(Vector2 cursorUIPosition, Cursor cursor, int slot, VirtualControlsHardwareConfigurationMapping_Layout.ContolType action, VirtualControlsHardwareConfigurationMapping_Layout slotConfig, bool expanded, ref float expandedSize)
	{
	}

	// Token: 0x06000BB0 RID: 2992 RVA: 0x00006C48 File Offset: 0x00004E48
	[Token(Token = "0x6000BB0")]
	[Address(RVA = "0xC16850", Offset = "0xC16850", VA = "0xC16850")]
	private bool DetermineButtonVisible(int slot, VirtualControlsHardwareConfigurationMapping_Layout.ContolType action, VirtualControlsHardwareConfigurationMapping_Layout slotConfig)
	{
		return default(bool);
	}

	// Token: 0x06000BB1 RID: 2993 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB1")]
	[Address(RVA = "0xC17C78", Offset = "0xC17C78", VA = "0xC17C78")]
	private void UpdateCursorButtonControl(Vector2 cursorUIPosition, Cursor cursor, int slot, VirtualControlsHardwareConfigurationMapping_Layout.ContolType action, VirtualControlsHardwareConfigurationMapping_Layout slotConfig, bool expanded, ref float expandedSize)
	{
	}

	// Token: 0x06000BB2 RID: 2994 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB2")]
	[Address(RVA = "0xC1B0FC", Offset = "0xC1B0FC", VA = "0xC1B0FC")]
	public void Draw()
	{
	}

	// Token: 0x06000BB3 RID: 2995 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB3")]
	[Address(RVA = "0xC1C400", Offset = "0xC1C400", VA = "0xC1C400")]
	public void DrawControlStringNotifications()
	{
	}

	// Token: 0x06000BB4 RID: 2996 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB4")]
	[Address(RVA = "0xC1CD8C", Offset = "0xC1CD8C", VA = "0xC1CD8C")]
	public void InvalidateAllTouches()
	{
	}

	// Token: 0x06000BB5 RID: 2997 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB5")]
	[Address(RVA = "0xC1CF58", Offset = "0xC1CF58", VA = "0xC1CF58")]
	public void ClearGroupStates()
	{
	}

	// Token: 0x06000BB6 RID: 2998 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB6")]
	[Address(RVA = "0xC1CFF0", Offset = "0xC1CFF0", VA = "0xC1CFF0")]
	private void DrawGroupControl(VirtualControlsBinding_Layout binding, VirtualControlsHardwareConfigurationMapping_Layout slotConfig, int slot, bool fromOverlay = false)
	{
	}

	// Token: 0x06000BB7 RID: 2999 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB7")]
	[Address(RVA = "0xC1E82C", Offset = "0xC1E82C", VA = "0xC1E82C")]
	private void DrawButtonControl(VirtualControlsHardwareConfigurationMapping_Layout.ContolType action, VirtualControlsHardwareConfigurationMapping_Layout slotConfig, bool pressed, ref float scale)
	{
	}

	// Token: 0x06000BB8 RID: 3000 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB8")]
	[Address(RVA = "0xC1ECE8", Offset = "0xC1ECE8", VA = "0xC1ECE8")]
	private void DrawAxisIcons()
	{
	}

	// Token: 0x06000BB9 RID: 3001 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB9")]
	[Address(RVA = "0xC1EF6C", Offset = "0xC1EF6C", VA = "0xC1EF6C")]
	private void DrawAxisControl(VirtualControlsHardwareConfigurationMapping_Layout.ContolType action, VirtualControlsHardwareConfigurationMapping_Layout slotConfig)
	{
	}

	// Token: 0x06000BBA RID: 3002 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BBA")]
	[Address(RVA = "0xC1BB48", Offset = "0xC1BB48", VA = "0xC1BB48")]
	private void DrawControls()
	{
	}

	// Token: 0x06000BBB RID: 3003 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BBB")]
	[Address(RVA = "0xC20B54", Offset = "0xC20B54", VA = "0xC20B54")]
	public void DrawTouchOverlays()
	{
	}

	// Token: 0x06000BBC RID: 3004 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BBC")]
	[Address(RVA = "0xC1C9BC", Offset = "0xC1C9BC", VA = "0xC1C9BC")]
	private void DrawMapControls()
	{
	}

	// Token: 0x06000BBD RID: 3005 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BBD")]
	[Address(RVA = "0xC2115C", Offset = "0xC2115C", VA = "0xC2115C")]
	public void Show()
	{
	}

	// Token: 0x06000BBE RID: 3006 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BBE")]
	[Address(RVA = "0xC21168", Offset = "0xC21168", VA = "0xC21168")]
	public void Hide()
	{
	}

	// Token: 0x04000DC3 RID: 3523
	[Token(Token = "0x4000DC3")]
	[FieldOffset(Offset = "0x0")]
	private static Texture2D _directionArrow;

	// Token: 0x04000DC4 RID: 3524
	[Token(Token = "0x4000DC4")]
	[FieldOffset(Offset = "0x4")]
	private static Texture2D _jump;

	// Token: 0x04000DC5 RID: 3525
	[Token(Token = "0x4000DC5")]
	[FieldOffset(Offset = "0x8")]
	public static Texture2D _movement;

	// Token: 0x04000DC6 RID: 3526
	[Token(Token = "0x4000DC6")]
	[FieldOffset(Offset = "0xC")]
	public static Texture2D _autoFireOff;

	// Token: 0x04000DC7 RID: 3527
	[Token(Token = "0x4000DC7")]
	[FieldOffset(Offset = "0x10")]
	public static Texture2D _aimUseInnerIcon;

	// Token: 0x04000DC8 RID: 3528
	[Token(Token = "0x4000DC8")]
	[FieldOffset(Offset = "0x8")]
	public bool ControllerActive;

	// Token: 0x04000DC9 RID: 3529
	[Token(Token = "0x4000DC9")]
	[FieldOffset(Offset = "0x9")]
	public bool AutoControlEnabled;

	// Token: 0x04000DCA RID: 3530
	[Token(Token = "0x4000DCA")]
	[FieldOffset(Offset = "0xC")]
	public float AutoControlTimer;

	// Token: 0x04000DCB RID: 3531
	[Token(Token = "0x4000DCB")]
	[FieldOffset(Offset = "0x10")]
	public bool AutoSelectToggleTouch;

	// Token: 0x04000DCC RID: 3532
	[Token(Token = "0x4000DCC")]
	[FieldOffset(Offset = "0x11")]
	public bool AutoSelectToggleTouchValue;

	// Token: 0x04000DCD RID: 3533
	[Token(Token = "0x4000DCD")]
	[FieldOffset(Offset = "0x12")]
	public bool AutoSelectToggleController;

	// Token: 0x04000DCE RID: 3534
	[Token(Token = "0x4000DCE")]
	[FieldOffset(Offset = "0x13")]
	public bool AutoSelectToggleControllerValue;

	// Token: 0x04000DCF RID: 3535
	[Token(Token = "0x4000DCF")]
	[FieldOffset(Offset = "0x14")]
	public bool AutoSelectToggleKeyboard;

	// Token: 0x04000DD0 RID: 3536
	[Token(Token = "0x4000DD0")]
	[FieldOffset(Offset = "0x15")]
	public bool AutoSelectToggleKeyboardValue;

	// Token: 0x04000DD1 RID: 3537
	[Token(Token = "0x4000DD1")]
	[FieldOffset(Offset = "0x16")]
	public bool ScopePanActive;

	// Token: 0x04000DD2 RID: 3538
	[Token(Token = "0x4000DD2")]
	[FieldOffset(Offset = "0x18")]
	public ButtonControlMode ScopePanTouchMode;

	// Token: 0x04000DD3 RID: 3539
	[Token(Token = "0x4000DD3")]
	[FieldOffset(Offset = "0x1C")]
	public ButtonControlMode ScopePanControllerMode;

	// Token: 0x04000DD4 RID: 3540
	[Token(Token = "0x4000DD4")]
	[FieldOffset(Offset = "0x20")]
	public ButtonControlMode ScopePanKeyboardMode;

	// Token: 0x04000DD5 RID: 3541
	[Token(Token = "0x4000DD5")]
	[FieldOffset(Offset = "0x24")]
	public bool EnableBuildGridSnap;

	// Token: 0x04000DD6 RID: 3542
	[Token(Token = "0x4000DD6")]
	[FieldOffset(Offset = "0x25")]
	public bool AimModeFreeMovement;

	// Token: 0x04000DD7 RID: 3543
	[Token(Token = "0x4000DD7")]
	[FieldOffset(Offset = "0x26")]
	public bool UseButtonPressed;

	// Token: 0x04000DD8 RID: 3544
	[Token(Token = "0x4000DD8")]
	[FieldOffset(Offset = "0x27")]
	public bool StashCraftedItems;

	// Token: 0x04000DD9 RID: 3545
	[Token(Token = "0x4000DD9")]
	[FieldOffset(Offset = "0x28")]
	private CursorInputLayer _inputLayer;

	// Token: 0x04000DDA RID: 3546
	[Token(Token = "0x4000DDA")]
	[FieldOffset(Offset = "0x2C")]
	private CursorInputLayer _inputLayer2;

	// Token: 0x04000DDB RID: 3547
	[Token(Token = "0x4000DDB")]
	[FieldOffset(Offset = "0x30")]
	public VirtualInputController_Layout.ContolType[] Controls;

	// Token: 0x04000DDC RID: 3548
	[Token(Token = "0x4000DDC")]
	[FieldOffset(Offset = "0x34")]
	public float VirtualControlScale;

	// Token: 0x04000DDD RID: 3549
	[Token(Token = "0x4000DDD")]
	[FieldOffset(Offset = "0x38")]
	public GUIVirtualInputController.LeftStickJumpMode JumpMode;

	// Token: 0x04000DDE RID: 3550
	[Token(Token = "0x4000DDE")]
	[FieldOffset(Offset = "0x3C")]
	private float jumpYScale;

	// Token: 0x04000DDF RID: 3551
	[Token(Token = "0x4000DDF")]
	[FieldOffset(Offset = "0x40")]
	private int previousMovementLastFrame;

	// Token: 0x04000DE0 RID: 3552
	[Token(Token = "0x4000DE0")]
	[FieldOffset(Offset = "0x44")]
	private Vector2 lastFireAxisRaw;

	// Token: 0x04000DE1 RID: 3553
	[Token(Token = "0x4000DE1")]
	private const float numSteps = 1000f;

	// Token: 0x04000DE2 RID: 3554
	[Token(Token = "0x4000DE2")]
	[FieldOffset(Offset = "0x14")]
	private static Item emptyItem;

	// Token: 0x04000DE3 RID: 3555
	[Token(Token = "0x4000DE3")]
	[FieldOffset(Offset = "0x4C")]
	private bool pulseLeft;

	// Token: 0x04000DE4 RID: 3556
	[Token(Token = "0x4000DE4")]
	[FieldOffset(Offset = "0x50")]
	private int pulseLeftTime;

	// Token: 0x04000DE5 RID: 3557
	[Token(Token = "0x4000DE5")]
	[FieldOffset(Offset = "0x54")]
	private bool pulseRight;

	// Token: 0x04000DE6 RID: 3558
	[Token(Token = "0x4000DE6")]
	[FieldOffset(Offset = "0x58")]
	private int pulseRightTime;

	// Token: 0x04000DE7 RID: 3559
	[Token(Token = "0x4000DE7")]
	[FieldOffset(Offset = "0x18")]
	private static int pulseTimer;

	// Token: 0x04000DE8 RID: 3560
	[Token(Token = "0x4000DE8")]
	[FieldOffset(Offset = "0x5C")]
	private float cursorUpdateTime;

	// Token: 0x04000DE9 RID: 3561
	[Token(Token = "0x4000DE9")]
	[FieldOffset(Offset = "0x60")]
	private float LastOffsetX;

	// Token: 0x04000DEA RID: 3562
	[Token(Token = "0x4000DEA")]
	[FieldOffset(Offset = "0x64")]
	private float LastOffsetY;

	// Token: 0x04000DEB RID: 3563
	[Token(Token = "0x4000DEB")]
	[FieldOffset(Offset = "0x68")]
	private int LastFrameUpdate;

	// Token: 0x04000DEC RID: 3564
	[Token(Token = "0x4000DEC")]
	[FieldOffset(Offset = "0x6C")]
	private int LastSizeX;

	// Token: 0x04000DED RID: 3565
	[Token(Token = "0x4000DED")]
	[FieldOffset(Offset = "0x70")]
	private int LastSizeY;

	// Token: 0x04000DEE RID: 3566
	[Token(Token = "0x4000DEE")]
	[FieldOffset(Offset = "0x74")]
	private float AimScale;

	// Token: 0x04000DEF RID: 3567
	[Token(Token = "0x4000DEF")]
	[FieldOffset(Offset = "0x78")]
	private float AimAxisActiveTime;

	// Token: 0x04000DF0 RID: 3568
	[Token(Token = "0x4000DF0")]
	[FieldOffset(Offset = "0x7C")]
	private float AimAxisStartX;

	// Token: 0x04000DF1 RID: 3569
	[Token(Token = "0x4000DF1")]
	[FieldOffset(Offset = "0x80")]
	private float AimAxisStartY;

	// Token: 0x04000DF2 RID: 3570
	[Token(Token = "0x4000DF2")]
	[FieldOffset(Offset = "0x84")]
	private float AimAxisTotalX;

	// Token: 0x04000DF3 RID: 3571
	[Token(Token = "0x4000DF3")]
	[FieldOffset(Offset = "0x88")]
	private float AimAxisTotalY;

	// Token: 0x04000DF4 RID: 3572
	[Token(Token = "0x4000DF4")]
	[FieldOffset(Offset = "0x8C")]
	private bool AimAxisSnapStarted;

	// Token: 0x04000DF5 RID: 3573
	[Token(Token = "0x4000DF5")]
	[FieldOffset(Offset = "0x8D")]
	public bool LeftStickAiming;

	// Token: 0x04000DF6 RID: 3574
	[Token(Token = "0x4000DF6")]
	[FieldOffset(Offset = "0x90")]
	public float ControllerAimSensitivity;

	// Token: 0x04000DF7 RID: 3575
	[Token(Token = "0x4000DF7")]
	[FieldOffset(Offset = "0x94")]
	public float TouchAimSensitivity;

	// Token: 0x04000DF8 RID: 3576
	[Token(Token = "0x4000DF8")]
	[FieldOffset(Offset = "0x98")]
	private int InitialAimNavTick;

	// Token: 0x04000DF9 RID: 3577
	[Token(Token = "0x4000DF9")]
	[FieldOffset(Offset = "0xA0")]
	public DateTime LastAimNavTickTime;

	// Token: 0x04000DFA RID: 3578
	[Token(Token = "0x4000DFA")]
	[FieldOffset(Offset = "0xA8")]
	private Vector2 LastAimNavTickPosition;

	// Token: 0x04000DFB RID: 3579
	[Token(Token = "0x4000DFB")]
	[FieldOffset(Offset = "0xB0")]
	private Vector2 LastAimNavTickPositionStart;

	// Token: 0x04000DFC RID: 3580
	[Token(Token = "0x4000DFC")]
	[FieldOffset(Offset = "0xB8")]
	private Vector2 LastResultPosition;

	// Token: 0x04000DFD RID: 3581
	[Token(Token = "0x4000DFD")]
	[FieldOffset(Offset = "0xC0")]
	private Vector2 WorldBlendOffset;

	// Token: 0x04000DFE RID: 3582
	[Token(Token = "0x4000DFE")]
	[FieldOffset(Offset = "0xC8")]
	private bool lastGridAimMode;

	// Token: 0x04000DFF RID: 3583
	[Token(Token = "0x4000DFF")]
	[FieldOffset(Offset = "0xC9")]
	private bool movingX;

	// Token: 0x04000E00 RID: 3584
	[Token(Token = "0x4000E00")]
	[FieldOffset(Offset = "0xCA")]
	private bool movingY;

	// Token: 0x04000E01 RID: 3585
	[Token(Token = "0x4000E01")]
	[FieldOffset(Offset = "0xCC")]
	private int movingOffsetX;

	// Token: 0x04000E02 RID: 3586
	[Token(Token = "0x4000E02")]
	[FieldOffset(Offset = "0xD0")]
	private int movingOffsetY;

	// Token: 0x04000E03 RID: 3587
	[Token(Token = "0x4000E03")]
	[FieldOffset(Offset = "0xD4")]
	private int LastWorldPositionX;

	// Token: 0x04000E04 RID: 3588
	[Token(Token = "0x4000E04")]
	[FieldOffset(Offset = "0xD8")]
	private int LastWorldPositionY;

	// Token: 0x04000E05 RID: 3589
	[Token(Token = "0x4000E05")]
	[FieldOffset(Offset = "0xDC")]
	private int LastCursorPositionX;

	// Token: 0x04000E06 RID: 3590
	[Token(Token = "0x4000E06")]
	[FieldOffset(Offset = "0xE0")]
	private int LastCursorPositionY;

	// Token: 0x04000E07 RID: 3591
	[Token(Token = "0x4000E07")]
	[FieldOffset(Offset = "0xE4")]
	private int LastScreenCentreX;

	// Token: 0x04000E08 RID: 3592
	[Token(Token = "0x4000E08")]
	[FieldOffset(Offset = "0xE8")]
	private int LastScreenCentreY;

	// Token: 0x04000E09 RID: 3593
	[Token(Token = "0x4000E09")]
	[FieldOffset(Offset = "0xEC")]
	private float deadZone;

	// Token: 0x04000E0A RID: 3594
	[Token(Token = "0x4000E0A")]
	[FieldOffset(Offset = "0xF0")]
	private bool wasWorldCursorActive;

	// Token: 0x04000E0B RID: 3595
	[Token(Token = "0x4000E0B")]
	[FieldOffset(Offset = "0xF4")]
	private int lastWorldCursorPointX;

	// Token: 0x04000E0C RID: 3596
	[Token(Token = "0x4000E0C")]
	[FieldOffset(Offset = "0xF8")]
	private int lastWorldCursorPointY;

	// Token: 0x04000E0D RID: 3597
	[Token(Token = "0x4000E0D")]
	[FieldOffset(Offset = "0xFC")]
	private bool wasAiming;

	// Token: 0x04000E0E RID: 3598
	[Token(Token = "0x4000E0E")]
	[FieldOffset(Offset = "0x100")]
	private int lastAimCursorPointX;

	// Token: 0x04000E0F RID: 3599
	[Token(Token = "0x4000E0F")]
	[FieldOffset(Offset = "0x104")]
	private int lastAimCursorPointY;

	// Token: 0x04000E10 RID: 3600
	[Token(Token = "0x4000E10")]
	[FieldOffset(Offset = "0x108")]
	private int exclusionRegionFrame;

	// Token: 0x04000E11 RID: 3601
	[Token(Token = "0x4000E11")]
	[FieldOffset(Offset = "0x10C")]
	private List<Rectangle> uiExclusionRegions;

	// Token: 0x04000E12 RID: 3602
	[Token(Token = "0x4000E12")]
	[FieldOffset(Offset = "0x110")]
	private int[] slotHidden;

	// Token: 0x04000E13 RID: 3603
	[Token(Token = "0x4000E13")]
	[FieldOffset(Offset = "0x114")]
	private int lastFrameDrawn;

	// Token: 0x04000E14 RID: 3604
	[Token(Token = "0x4000E14")]
	[FieldOffset(Offset = "0x118")]
	private Dictionary<string, GUIVirtualInputController.GroupControlState> GroupStates;

	// Token: 0x04000E15 RID: 3605
	[Token(Token = "0x4000E15")]
	[FieldOffset(Offset = "0x11C")]
	private List<int> OverlayDrawGroups;

	// Token: 0x04000E16 RID: 3606
	[Token(Token = "0x4000E16")]
	[FieldOffset(Offset = "0x120")]
	private VirtualControlsAxisConfiguration_Layout movementConfig;

	// Token: 0x04000E17 RID: 3607
	[Token(Token = "0x4000E17")]
	[FieldOffset(Offset = "0x124")]
	public bool wasMovementAxisActive;

	// Token: 0x04000E18 RID: 3608
	[Token(Token = "0x4000E18")]
	[FieldOffset(Offset = "0x125")]
	public bool movementAxisActive;

	// Token: 0x04000E19 RID: 3609
	[Token(Token = "0x4000E19")]
	[FieldOffset(Offset = "0x126")]
	public bool grappleAxisActive;

	// Token: 0x04000E1A RID: 3610
	[Token(Token = "0x4000E1A")]
	[FieldOffset(Offset = "0x127")]
	public bool wasGrappleAxisActive;

	// Token: 0x04000E1B RID: 3611
	[Token(Token = "0x4000E1B")]
	[FieldOffset(Offset = "0x128")]
	public bool wasFireAxisActive;

	// Token: 0x04000E1C RID: 3612
	[Token(Token = "0x4000E1C")]
	[FieldOffset(Offset = "0x129")]
	public bool wasFireButtonFiring;

	// Token: 0x04000E1D RID: 3613
	[Token(Token = "0x4000E1D")]
	[FieldOffset(Offset = "0x12A")]
	public bool grappleFired;

	// Token: 0x04000E1E RID: 3614
	[Token(Token = "0x4000E1E")]
	[FieldOffset(Offset = "0x12B")]
	public bool fireAxisActive;

	// Token: 0x04000E1F RID: 3615
	[Token(Token = "0x4000E1F")]
	[FieldOffset(Offset = "0x12C")]
	public bool grappleAxisPressed;

	// Token: 0x04000E20 RID: 3616
	[Token(Token = "0x4000E20")]
	[FieldOffset(Offset = "0x12D")]
	public bool fireAxisFiring;

	// Token: 0x04000E21 RID: 3617
	[Token(Token = "0x4000E21")]
	[FieldOffset(Offset = "0x12E")]
	public bool fireButtonFiring;

	// Token: 0x04000E22 RID: 3618
	[Token(Token = "0x4000E22")]
	[FieldOffset(Offset = "0x12F")]
	private bool fireFromHousing;

	// Token: 0x04000E23 RID: 3619
	[Token(Token = "0x4000E23")]
	[FieldOffset(Offset = "0x130")]
	private bool anyActive;

	// Token: 0x04000E24 RID: 3620
	[Token(Token = "0x4000E24")]
	[FieldOffset(Offset = "0x134")]
	private Vector2 grappleAxis;

	// Token: 0x04000E25 RID: 3621
	[Token(Token = "0x4000E25")]
	[FieldOffset(Offset = "0x13C")]
	private Vector2 previousGrappleAxis;

	// Token: 0x04000E26 RID: 3622
	[Token(Token = "0x4000E26")]
	[FieldOffset(Offset = "0x144")]
	private Vector2 movementAxis;

	// Token: 0x04000E27 RID: 3623
	[Token(Token = "0x4000E27")]
	[FieldOffset(Offset = "0x14C")]
	private Vector2 previousMovementAxis;

	// Token: 0x04000E28 RID: 3624
	[Token(Token = "0x4000E28")]
	[FieldOffset(Offset = "0x154")]
	private Vector2 fireAxis;

	// Token: 0x04000E29 RID: 3625
	[Token(Token = "0x4000E29")]
	[FieldOffset(Offset = "0x15C")]
	private Vector2 gridSnapAxis;

	// Token: 0x04000E2A RID: 3626
	[Token(Token = "0x4000E2A")]
	[FieldOffset(Offset = "0x164")]
	private Vector2 previousGridSnapAxis;

	// Token: 0x04000E2B RID: 3627
	[Token(Token = "0x4000E2B")]
	[FieldOffset(Offset = "0x16C")]
	private bool gridSnapUp;

	// Token: 0x04000E2C RID: 3628
	[Token(Token = "0x4000E2C")]
	[FieldOffset(Offset = "0x16D")]
	private bool gridSnapDown;

	// Token: 0x04000E2D RID: 3629
	[Token(Token = "0x4000E2D")]
	[FieldOffset(Offset = "0x16E")]
	private bool gridSnapLeft;

	// Token: 0x04000E2E RID: 3630
	[Token(Token = "0x4000E2E")]
	[FieldOffset(Offset = "0x16F")]
	private bool gridSnapRight;

	// Token: 0x04000E2F RID: 3631
	[Token(Token = "0x4000E2F")]
	[FieldOffset(Offset = "0x170")]
	private Vector2 movementAxisScreenOffset;

	// Token: 0x04000E30 RID: 3632
	[Token(Token = "0x4000E30")]
	[FieldOffset(Offset = "0x178")]
	private Vector2 fireAxisScreenOffset;

	// Token: 0x04000E31 RID: 3633
	[Token(Token = "0x4000E31")]
	[FieldOffset(Offset = "0x180")]
	private Vector2 grappleAxisScreenOffset;

	// Token: 0x04000E32 RID: 3634
	[Token(Token = "0x4000E32")]
	[FieldOffset(Offset = "0x188")]
	private Vector2 previousGrappleAxisScreenOffset;

	// Token: 0x04000E33 RID: 3635
	[Token(Token = "0x4000E33")]
	[FieldOffset(Offset = "0x190")]
	private Vector2 grappleAxisCentre;

	// Token: 0x04000E34 RID: 3636
	[Token(Token = "0x4000E34")]
	[FieldOffset(Offset = "0x198")]
	private Vector2 movementAxisCentre;

	// Token: 0x04000E35 RID: 3637
	[Token(Token = "0x4000E35")]
	[FieldOffset(Offset = "0x1A0")]
	private Vector2 fireAxisCentre;

	// Token: 0x04000E36 RID: 3638
	[Token(Token = "0x4000E36")]
	[FieldOffset(Offset = "0x1C")]
	public static QuickActionButton_Layout.QuickActionControl[] QuickActionControlFromLayoutControl;

	// Token: 0x04000E37 RID: 3639
	[Token(Token = "0x4000E37")]
	[FieldOffset(Offset = "0x20")]
	public static GUIVirtualInputController.ControlType[] ButtonControlFromLayoutControl;

	// Token: 0x04000E38 RID: 3640
	[Token(Token = "0x4000E38")]
	[FieldOffset(Offset = "0x1A8")]
	public bool[] Pressed;

	// Token: 0x04000E39 RID: 3641
	[Token(Token = "0x4000E39")]
	[FieldOffset(Offset = "0x1AC")]
	public bool[] WasPressed;

	// Token: 0x04000E3A RID: 3642
	[Token(Token = "0x4000E3A")]
	[FieldOffset(Offset = "0x1B0")]
	public float[] Scale;

	// Token: 0x04000E3B RID: 3643
	[Token(Token = "0x4000E3B")]
	[FieldOffset(Offset = "0x1B4")]
	private float TimeSinceToggleSmartCursor;

	// Token: 0x04000E3C RID: 3644
	[Token(Token = "0x4000E3C")]
	[FieldOffset(Offset = "0x1B8")]
	private float TimeSinceToggleAutoFire;

	// Token: 0x04000E3D RID: 3645
	[Token(Token = "0x4000E3D")]
	[FieldOffset(Offset = "0x1BC")]
	public float TimeSinceModifyZoom;

	// Token: 0x04000E3E RID: 3646
	[Token(Token = "0x4000E3E")]
	[FieldOffset(Offset = "0x1C0")]
	private float TimeSinceCombatTargeting;

	// Token: 0x04000E3F RID: 3647
	[Token(Token = "0x4000E3F")]
	[FieldOffset(Offset = "0x1C4")]
	private float TimeSinceProfileChanged;

	// Token: 0x04000E40 RID: 3648
	[Token(Token = "0x4000E40")]
	[FieldOffset(Offset = "0x1C8")]
	public bool InventoryToggle;

	// Token: 0x04000E41 RID: 3649
	[Token(Token = "0x4000E41")]
	[FieldOffset(Offset = "0x1C9")]
	private bool Shown;

	// Token: 0x0200018A RID: 394
	[Token(Token = "0x200018A")]
	public enum LeftStickJumpMode
	{
		// Token: 0x04000E43 RID: 3651
		[Token(Token = "0x4000E43")]
		DoubleTap,
		// Token: 0x04000E44 RID: 3652
		[Token(Token = "0x4000E44")]
		SingleTap,
		// Token: 0x04000E45 RID: 3653
		[Token(Token = "0x4000E45")]
		Up,
		// Token: 0x04000E46 RID: 3654
		[Token(Token = "0x4000E46")]
		Disabled
	}

	// Token: 0x0200018B RID: 395
	[Token(Token = "0x200018B")]
	public class GroupControlState
	{
		// Token: 0x06000BC0 RID: 3008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BC0")]
		[Address(RVA = "0xC3064C", Offset = "0xC3064C", VA = "0xC3064C")]
		public GroupControlState()
		{
		}

		// Token: 0x04000E47 RID: 3655
		[Token(Token = "0x4000E47")]
		[FieldOffset(Offset = "0x8")]
		public float StateTime;

		// Token: 0x04000E48 RID: 3656
		[Token(Token = "0x4000E48")]
		[FieldOffset(Offset = "0xC")]
		public GUIVirtualInputController.GroupControlState.State CurrentState;

		// Token: 0x04000E49 RID: 3657
		[Token(Token = "0x4000E49")]
		[FieldOffset(Offset = "0x10")]
		public bool CentreClose;

		// Token: 0x04000E4A RID: 3658
		[Token(Token = "0x4000E4A")]
		[FieldOffset(Offset = "0x14")]
		public int pressedIndex;

		// Token: 0x0200018C RID: 396
		[Token(Token = "0x200018C")]
		public enum State
		{
			// Token: 0x04000E4C RID: 3660
			[Token(Token = "0x4000E4C")]
			Closed,
			// Token: 0x04000E4D RID: 3661
			[Token(Token = "0x4000E4D")]
			Opening,
			// Token: 0x04000E4E RID: 3662
			[Token(Token = "0x4000E4E")]
			Closing
		}
	}

	// Token: 0x0200018D RID: 397
	[Token(Token = "0x200018D")]
	public enum ControlType
	{
		// Token: 0x04000E50 RID: 3664
		[Token(Token = "0x4000E50")]
		Left,
		// Token: 0x04000E51 RID: 3665
		[Token(Token = "0x4000E51")]
		Right,
		// Token: 0x04000E52 RID: 3666
		[Token(Token = "0x4000E52")]
		Jump,
		// Token: 0x04000E53 RID: 3667
		[Token(Token = "0x4000E53")]
		Up,
		// Token: 0x04000E54 RID: 3668
		[Token(Token = "0x4000E54")]
		Down,
		// Token: 0x04000E55 RID: 3669
		[Token(Token = "0x4000E55")]
		Inventory,
		// Token: 0x04000E56 RID: 3670
		[Token(Token = "0x4000E56")]
		QuickHeal,
		// Token: 0x04000E57 RID: 3671
		[Token(Token = "0x4000E57")]
		QuickMana,
		// Token: 0x04000E58 RID: 3672
		[Token(Token = "0x4000E58")]
		QuickMount,
		// Token: 0x04000E59 RID: 3673
		[Token(Token = "0x4000E59")]
		QuickBuff,
		// Token: 0x04000E5A RID: 3674
		[Token(Token = "0x4000E5A")]
		Grapple,
		// Token: 0x04000E5B RID: 3675
		[Token(Token = "0x4000E5B")]
		Fire,
		// Token: 0x04000E5C RID: 3676
		[Token(Token = "0x4000E5C")]
		UseTileControl,
		// Token: 0x04000E5D RID: 3677
		[Token(Token = "0x4000E5D")]
		Interact,
		// Token: 0x04000E5E RID: 3678
		[Token(Token = "0x4000E5E")]
		ZoomIn,
		// Token: 0x04000E5F RID: 3679
		[Token(Token = "0x4000E5F")]
		ZoomOut,
		// Token: 0x04000E60 RID: 3680
		[Token(Token = "0x4000E60")]
		AutoFire,
		// Token: 0x04000E61 RID: 3681
		[Token(Token = "0x4000E61")]
		SmartCursor,
		// Token: 0x04000E62 RID: 3682
		[Token(Token = "0x4000E62")]
		InventoryToggle,
		// Token: 0x04000E63 RID: 3683
		[Token(Token = "0x4000E63")]
		AutoSelect,
		// Token: 0x04000E64 RID: 3684
		[Token(Token = "0x4000E64")]
		GrappleSelect,
		// Token: 0x04000E65 RID: 3685
		[Token(Token = "0x4000E65")]
		TargetLockOn,
		// Token: 0x04000E66 RID: 3686
		[Token(Token = "0x4000E66")]
		ProfileSwitch,
		// Token: 0x04000E67 RID: 3687
		[Token(Token = "0x4000E67")]
		UseButton,
		// Token: 0x04000E68 RID: 3688
		[Token(Token = "0x4000E68")]
		Settings,
		// Token: 0x04000E69 RID: 3689
		[Token(Token = "0x4000E69")]
		Loadout1,
		// Token: 0x04000E6A RID: 3690
		[Token(Token = "0x4000E6A")]
		Loadout2,
		// Token: 0x04000E6B RID: 3691
		[Token(Token = "0x4000E6B")]
		Loadout3,
		// Token: 0x04000E6C RID: 3692
		[Token(Token = "0x4000E6C")]
		LoadoutCycle,
		// Token: 0x04000E6D RID: 3693
		[Token(Token = "0x4000E6D")]
		InteractOnly,
		// Token: 0x04000E6E RID: 3694
		[Token(Token = "0x4000E6E")]
		ToggleFireInteract,
		// Token: 0x04000E6F RID: 3695
		[Token(Token = "0x4000E6F")]
		Dash,
		// Token: 0x04000E70 RID: 3696
		[Token(Token = "0x4000E70")]
		ArmorSetAbility,
		// Token: 0x04000E71 RID: 3697
		[Token(Token = "0x4000E71")]
		Count
	}
}
