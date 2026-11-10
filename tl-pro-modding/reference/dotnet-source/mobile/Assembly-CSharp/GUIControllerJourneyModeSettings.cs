using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000A1 RID: 161
[Token(Token = "0x20000A1")]
public class GUIControllerJourneyModeSettings : FileAPI
{
	// Token: 0x0600041B RID: 1051 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600041B")]
	[Address(RVA = "0xD5C7B0", Offset = "0xD5C7B0", VA = "0xD5C7B0")]
	public void SelectedSetting(int index)
	{
	}

	// Token: 0x0600041C RID: 1052 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600041C")]
	[Address(RVA = "0xD5C7C0", Offset = "0xD5C7C0", VA = "0xD5C7C0", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x0600041D RID: 1053 RVA: 0x000032E8 File Offset: 0x000014E8
	[Token(Token = "0x600041D")]
	[Address(RVA = "0xD5CC3C", Offset = "0xD5CC3C", VA = "0xD5CC3C", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x0600041E RID: 1054 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600041E")]
	[Address(RVA = "0xD5C7CC", Offset = "0xD5C7CC", VA = "0xD5C7CC")]
	private void UpdateScroll()
	{
	}

	// Token: 0x0600041F RID: 1055 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600041F")]
	[Address(RVA = "0xD5CC44", Offset = "0xD5CC44", VA = "0xD5CC44", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x06000420 RID: 1056 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000420")]
	[Address(RVA = "0xD5CEF4", Offset = "0xD5CEF4", VA = "0xD5CEF4")]
	public void ActivateOverlay(GUIPulldownSetting overlayEntry, Rectangle overlayRegion, int selectedOption, float offset)
	{
	}

	// Token: 0x06000421 RID: 1057 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000421")]
	[Address(RVA = "0xD5CF1C", Offset = "0xD5CF1C", VA = "0xD5CF1C")]
	public void DeactivateOverlay()
	{
	}

	// Token: 0x06000422 RID: 1058 RVA: 0x00003300 File Offset: 0x00001500
	[Token(Token = "0x6000422")]
	[Address(RVA = "0xD5CF28", Offset = "0xD5CF28", VA = "0xD5CF28")]
	public bool OverlayActive()
	{
		return default(bool);
	}

	// Token: 0x06000423 RID: 1059 RVA: 0x00003318 File Offset: 0x00001518
	[Token(Token = "0x6000423")]
	[Address(RVA = "0xD5CF38", Offset = "0xD5CF38", VA = "0xD5CF38", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x06000424 RID: 1060 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000424")]
	[Address(RVA = "0xD5D4D4", Offset = "0xD5D4D4", VA = "0xD5D4D4")]
	public GUIControllerJourneyModeSettings()
	{
	}

	// Token: 0x040005FC RID: 1532
	[Token(Token = "0x40005FC")]
	[FieldOffset(Offset = "0x8")]
	public GUIPulldownSetting _overlayEntry;

	// Token: 0x040005FD RID: 1533
	[Token(Token = "0x40005FD")]
	[FieldOffset(Offset = "0xC")]
	public Rectangle _overlayRegion;

	// Token: 0x040005FE RID: 1534
	[Token(Token = "0x40005FE")]
	[FieldOffset(Offset = "0x1C")]
	public int _overlayIndex;

	// Token: 0x040005FF RID: 1535
	[Token(Token = "0x40005FF")]
	[FieldOffset(Offset = "0x20")]
	public float _overlayOffset;

	// Token: 0x04000600 RID: 1536
	[Token(Token = "0x4000600")]
	[FieldOffset(Offset = "0x24")]
	public GUIControllerJourneyModeSettings.Controls selectedControl;

	// Token: 0x04000601 RID: 1537
	[Token(Token = "0x4000601")]
	[FieldOffset(Offset = "0x28")]
	private int _selectedItem;

	// Token: 0x020000A2 RID: 162
	[Token(Token = "0x20000A2")]
	public enum Controls
	{
		// Token: 0x04000603 RID: 1539
		[Token(Token = "0x4000603")]
		Time,
		// Token: 0x04000604 RID: 1540
		[Token(Token = "0x4000604")]
		Weather,
		// Token: 0x04000605 RID: 1541
		[Token(Token = "0x4000605")]
		Power,
		// Token: 0x04000606 RID: 1542
		[Token(Token = "0x4000606")]
		Element,
		// Token: 0x04000607 RID: 1543
		[Token(Token = "0x4000607")]
		Back
	}
}
