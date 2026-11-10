using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000BD RID: 189
[Token(Token = "0x20000BD")]
public class GUIKeyboardMappingOverlay : FileAPI
{
	// Token: 0x0600049F RID: 1183 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600049F")]
	[Address(RVA = "0xD6A9EC", Offset = "0xD6A9EC", VA = "0xD6A9EC", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x060004A0 RID: 1184 RVA: 0x00003720 File Offset: 0x00001920
	[Token(Token = "0x60004A0")]
	[Address(RVA = "0xD6ADD4", Offset = "0xD6ADD4", VA = "0xD6ADD4", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x060004A1 RID: 1185 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A1")]
	[Address(RVA = "0xD6A9F8", Offset = "0xD6A9F8", VA = "0xD6A9F8")]
	private void UpdateScroll()
	{
	}

	// Token: 0x060004A2 RID: 1186 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004A2")]
	[Address(RVA = "0xD6ADDC", Offset = "0xD6ADDC", VA = "0xD6ADDC", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x060004A3 RID: 1187 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A3")]
	[Address(RVA = "0xD6B0F0", Offset = "0xD6B0F0", VA = "0xD6B0F0")]
	public void ActivateOverlay(GUIKeyboardMappingEntry overlayEntry, Rectangle overlayRegion)
	{
	}

	// Token: 0x060004A4 RID: 1188 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A4")]
	[Address(RVA = "0xD6B108", Offset = "0xD6B108", VA = "0xD6B108")]
	public void DeactivateOverlay()
	{
	}

	// Token: 0x060004A5 RID: 1189 RVA: 0x00003738 File Offset: 0x00001938
	[Token(Token = "0x60004A5")]
	[Address(RVA = "0xD6B114", Offset = "0xD6B114", VA = "0xD6B114", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x060004A6 RID: 1190 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A6")]
	[Address(RVA = "0xD6B774", Offset = "0xD6B774", VA = "0xD6B774")]
	public GUIKeyboardMappingOverlay()
	{
	}

	// Token: 0x04000680 RID: 1664
	[Token(Token = "0x4000680")]
	[FieldOffset(Offset = "0x8")]
	public GUIKeyboardMappingEntry _overlayEntry;

	// Token: 0x04000681 RID: 1665
	[Token(Token = "0x4000681")]
	[FieldOffset(Offset = "0xC")]
	public Rectangle _overlayRegion;

	// Token: 0x04000682 RID: 1666
	[Token(Token = "0x4000682")]
	[FieldOffset(Offset = "0x1C")]
	public int _overlayIndex;

	// Token: 0x04000683 RID: 1667
	[Token(Token = "0x4000683")]
	[FieldOffset(Offset = "0x20")]
	public float _overlayOffset;

	// Token: 0x04000684 RID: 1668
	[Token(Token = "0x4000684")]
	[FieldOffset(Offset = "0x24")]
	public GUIKeyboardMappingOverlay.Controls selectedControl;

	// Token: 0x04000685 RID: 1669
	[Token(Token = "0x4000685")]
	[FieldOffset(Offset = "0x28")]
	public int _selectedItem;

	// Token: 0x020000BE RID: 190
	[Token(Token = "0x20000BE")]
	public enum Controls
	{
		// Token: 0x04000687 RID: 1671
		[Token(Token = "0x4000687")]
		PageGeneral,
		// Token: 0x04000688 RID: 1672
		[Token(Token = "0x4000688")]
		PageExplore,
		// Token: 0x04000689 RID: 1673
		[Token(Token = "0x4000689")]
		PageFight,
		// Token: 0x0400068A RID: 1674
		[Token(Token = "0x400068A")]
		PageMisc,
		// Token: 0x0400068B RID: 1675
		[Token(Token = "0x400068B")]
		PageMap,
		// Token: 0x0400068C RID: 1676
		[Token(Token = "0x400068C")]
		Element,
		// Token: 0x0400068D RID: 1677
		[Token(Token = "0x400068D")]
		Reset,
		// Token: 0x0400068E RID: 1678
		[Token(Token = "0x400068E")]
		Default,
		// Token: 0x0400068F RID: 1679
		[Token(Token = "0x400068F")]
		Back
	}
}
