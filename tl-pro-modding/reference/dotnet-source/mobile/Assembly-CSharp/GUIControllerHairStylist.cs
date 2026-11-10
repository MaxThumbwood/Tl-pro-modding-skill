using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000D9 RID: 217
[Token(Token = "0x20000D9")]
public class GUIControllerHairStylist : FileAPI
{
	// Token: 0x0600057D RID: 1405 RVA: 0x00003E28 File Offset: 0x00002028
	[Token(Token = "0x600057D")]
	[Address(RVA = "0xE63C5C", Offset = "0xE63C5C", VA = "0xE63C5C", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x0600057E RID: 1406 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600057E")]
	[Address(RVA = "0xE63C64", Offset = "0xE63C64", VA = "0xE63C64", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x0600057F RID: 1407 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600057F")]
	[Address(RVA = "0xE63E3C", Offset = "0xE63E3C", VA = "0xE63E3C")]
	private void UpdateScroll()
	{
	}

	// Token: 0x06000580 RID: 1408 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000580")]
	[Address(RVA = "0xE64248", Offset = "0xE64248", VA = "0xE64248", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x06000581 RID: 1409 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000581")]
	[Address(RVA = "0xE64594", Offset = "0xE64594", VA = "0xE64594")]
	private void ClampPosition()
	{
	}

	// Token: 0x06000582 RID: 1410 RVA: 0x00003E40 File Offset: 0x00002040
	[Token(Token = "0x6000582")]
	[Address(RVA = "0xE64598", Offset = "0xE64598", VA = "0xE64598", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x06000583 RID: 1411 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000583")]
	[Address(RVA = "0xE64B84", Offset = "0xE64B84", VA = "0xE64B84")]
	public GUIControllerHairStylist()
	{
	}

	// Token: 0x0400070C RID: 1804
	[Token(Token = "0x400070C")]
	[FieldOffset(Offset = "0x8")]
	public GUIControllerHairStylist.Controls selectedControl;

	// Token: 0x0400070D RID: 1805
	[Token(Token = "0x400070D")]
	[FieldOffset(Offset = "0xC")]
	public int itemRow;

	// Token: 0x0400070E RID: 1806
	[Token(Token = "0x400070E")]
	[FieldOffset(Offset = "0x10")]
	public int itemColumn;

	// Token: 0x0400070F RID: 1807
	[Token(Token = "0x400070F")]
	[FieldOffset(Offset = "0x14")]
	public int scrollOffset;

	// Token: 0x04000710 RID: 1808
	[Token(Token = "0x4000710")]
	[FieldOffset(Offset = "0x18")]
	public int itemSlider;

	// Token: 0x04000711 RID: 1809
	[Token(Token = "0x4000711")]
	[FieldOffset(Offset = "0x1C")]
	public int maxRowIndex;

	// Token: 0x04000712 RID: 1810
	[Token(Token = "0x4000712")]
	[FieldOffset(Offset = "0x20")]
	public int maxRowColumn;

	// Token: 0x020000DA RID: 218
	[Token(Token = "0x20000DA")]
	public enum Controls
	{
		// Token: 0x04000714 RID: 1812
		[Token(Token = "0x4000714")]
		Style,
		// Token: 0x04000715 RID: 1813
		[Token(Token = "0x4000715")]
		Colour,
		// Token: 0x04000716 RID: 1814
		[Token(Token = "0x4000716")]
		Element,
		// Token: 0x04000717 RID: 1815
		[Token(Token = "0x4000717")]
		Back,
		// Token: 0x04000718 RID: 1816
		[Token(Token = "0x4000718")]
		Buy
	}
}
