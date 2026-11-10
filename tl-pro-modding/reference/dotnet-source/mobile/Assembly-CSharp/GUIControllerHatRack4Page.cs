using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000DC RID: 220
[Token(Token = "0x20000DC")]
public class GUIControllerHatRack4Page : GUIControllerHatRack
{
	// Token: 0x06000587 RID: 1415 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000587")]
	[Address(RVA = "0xE64BAC", Offset = "0xE64BAC", VA = "0xE64BAC", Slot = "9")]
	public override void Activate()
	{
	}

	// Token: 0x06000588 RID: 1416 RVA: 0x00003E58 File Offset: 0x00002058
	[Token(Token = "0x6000588")]
	[Address(RVA = "0xE64E34", Offset = "0xE64E34", VA = "0xE64E34", Slot = "8")]
	public override int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x06000589 RID: 1417 RVA: 0x00003E70 File Offset: 0x00002070
	[Token(Token = "0x6000589")]
	[Address(RVA = "0xE64F28", Offset = "0xE64F28", VA = "0xE64F28")]
	private bool IsValidPosition(int col, int row)
	{
		return default(bool);
	}

	// Token: 0x0600058A RID: 1418 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600058A")]
	[Address(RVA = "0xE64C50", Offset = "0xE64C50", VA = "0xE64C50")]
	private void MoveToValidPosition()
	{
	}

	// Token: 0x0600058B RID: 1419 RVA: 0x00003E88 File Offset: 0x00002088
	[Token(Token = "0x600058B")]
	[Address(RVA = "0xE65104", Offset = "0xE65104", VA = "0xE65104")]
	private bool MoveToValidRowInColumn(int yDir = 0)
	{
		return default(bool);
	}

	// Token: 0x0600058C RID: 1420 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600058C")]
	[Address(RVA = "0xE651A4", Offset = "0xE651A4", VA = "0xE651A4", Slot = "12")]
	public override void NavigateInto(int column, int row)
	{
	}

	// Token: 0x0600058D RID: 1421 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600058D")]
	[Address(RVA = "0xE65264", Offset = "0xE65264", VA = "0xE65264", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x0600058E RID: 1422 RVA: 0x00003EA0 File Offset: 0x000020A0
	[Token(Token = "0x600058E")]
	[Address(RVA = "0xE65680", Offset = "0xE65680", VA = "0xE65680", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x0600058F RID: 1423 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600058F")]
	[Address(RVA = "0xE659AC", Offset = "0xE659AC", VA = "0xE659AC")]
	public GUIControllerHatRack4Page()
	{
	}
}
