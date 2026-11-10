using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000B6 RID: 182
[Token(Token = "0x20000B6")]
public class GUIControllerSettingsOverlay : FileAPI
{
	// Token: 0x06000484 RID: 1156 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000484")]
	[Address(RVA = "0xD685AC", Offset = "0xD685AC", VA = "0xD685AC")]
	public void SelectedSetting(int index)
	{
	}

	// Token: 0x06000485 RID: 1157 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000485")]
	[Address(RVA = "0xD685BC", Offset = "0xD685BC", VA = "0xD685BC", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x06000486 RID: 1158 RVA: 0x00003648 File Offset: 0x00001848
	[Token(Token = "0x6000486")]
	[Address(RVA = "0xD68A40", Offset = "0xD68A40", VA = "0xD68A40", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x06000487 RID: 1159 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000487")]
	[Address(RVA = "0xD685D0", Offset = "0xD685D0", VA = "0xD685D0")]
	public void UpdateScroll()
	{
	}

	// Token: 0x06000488 RID: 1160 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000488")]
	[Address(RVA = "0xD68A48", Offset = "0xD68A48", VA = "0xD68A48", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x06000489 RID: 1161 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000489")]
	[Address(RVA = "0xD68E60", Offset = "0xD68E60", VA = "0xD68E60")]
	public void ActivateOverlay(GUIPulldownSetting overlayEntry, Rectangle overlayRegion, int selectedOption, float offset)
	{
	}

	// Token: 0x0600048A RID: 1162 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600048A")]
	[Address(RVA = "0xD68E88", Offset = "0xD68E88", VA = "0xD68E88")]
	public void DeactivateOverlay()
	{
	}

	// Token: 0x0600048B RID: 1163 RVA: 0x00003660 File Offset: 0x00001860
	[Token(Token = "0x600048B")]
	[Address(RVA = "0xD68E94", Offset = "0xD68E94", VA = "0xD68E94")]
	public bool OverlayActive()
	{
		return default(bool);
	}

	// Token: 0x0600048C RID: 1164 RVA: 0x00003678 File Offset: 0x00001878
	[Token(Token = "0x600048C")]
	[Address(RVA = "0xD68EA8", Offset = "0xD68EA8", VA = "0xD68EA8", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x0600048D RID: 1165 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600048D")]
	[Address(RVA = "0xD697C4", Offset = "0xD697C4", VA = "0xD697C4")]
	public GUIControllerSettingsOverlay()
	{
	}

	// Token: 0x0400065D RID: 1629
	[Token(Token = "0x400065D")]
	[FieldOffset(Offset = "0x8")]
	public GUIPulldownSetting _overlayEntry;

	// Token: 0x0400065E RID: 1630
	[Token(Token = "0x400065E")]
	[FieldOffset(Offset = "0xC")]
	public Rectangle _overlayRegion;

	// Token: 0x0400065F RID: 1631
	[Token(Token = "0x400065F")]
	[FieldOffset(Offset = "0x1C")]
	public int _overlayIndex;

	// Token: 0x04000660 RID: 1632
	[Token(Token = "0x4000660")]
	[FieldOffset(Offset = "0x20")]
	public float _overlayOffset;

	// Token: 0x04000661 RID: 1633
	[Token(Token = "0x4000661")]
	[FieldOffset(Offset = "0x24")]
	private GUIControllerSettingsOverlay.Controls selectedControl;

	// Token: 0x04000662 RID: 1634
	[Token(Token = "0x4000662")]
	[FieldOffset(Offset = "0x28")]
	private int _selectedItem;

	// Token: 0x020000B7 RID: 183
	[Token(Token = "0x20000B7")]
	private enum Controls
	{
		// Token: 0x04000664 RID: 1636
		[Token(Token = "0x4000664")]
		PageSettings,
		// Token: 0x04000665 RID: 1637
		[Token(Token = "0x4000665")]
		PageInterface,
		// Token: 0x04000666 RID: 1638
		[Token(Token = "0x4000666")]
		PageVideo,
		// Token: 0x04000667 RID: 1639
		[Token(Token = "0x4000667")]
		PageSound,
		// Token: 0x04000668 RID: 1640
		[Token(Token = "0x4000668")]
		PageMultiplayer,
		// Token: 0x04000669 RID: 1641
		[Token(Token = "0x4000669")]
		PageControls,
		// Token: 0x0400066A RID: 1642
		[Token(Token = "0x400066A")]
		PageTouch,
		// Token: 0x0400066B RID: 1643
		[Token(Token = "0x400066B")]
		PageController,
		// Token: 0x0400066C RID: 1644
		[Token(Token = "0x400066C")]
		PageKeyboard,
		// Token: 0x0400066D RID: 1645
		[Token(Token = "0x400066D")]
		Element,
		// Token: 0x0400066E RID: 1646
		[Token(Token = "0x400066E")]
		Reset,
		// Token: 0x0400066F RID: 1647
		[Token(Token = "0x400066F")]
		Back
	}
}
