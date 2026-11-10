using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000E0 RID: 224
[Token(Token = "0x20000E0")]
public class GUIControllerInventory4Page : GUIControllerInventory
{
	// Token: 0x060005B0 RID: 1456 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005B0")]
	[Address(RVA = "0xE67318", Offset = "0xE67318", VA = "0xE67318")]
	private ItemGrid_Layout GetInfoGrid()
	{
		return null;
	}

	// Token: 0x060005B1 RID: 1457 RVA: 0x00003FD8 File Offset: 0x000021D8
	[Token(Token = "0x60005B1")]
	[Address(RVA = "0xE67344", Offset = "0xE67344", VA = "0xE67344")]
	private int GetInfoCollectionCount()
	{
		return 0;
	}

	// Token: 0x060005B2 RID: 1458 RVA: 0x00003FF0 File Offset: 0x000021F0
	[Token(Token = "0x60005B2")]
	[Address(RVA = "0xE673D0", Offset = "0xE673D0", VA = "0xE673D0")]
	private float GetInfoItemScale()
	{
		return 0f;
	}

	// Token: 0x060005B3 RID: 1459 RVA: 0x00004008 File Offset: 0x00002208
	[Token(Token = "0x60005B3")]
	[Address(RVA = "0xE673D8", Offset = "0xE673D8", VA = "0xE673D8", Slot = "8")]
	public override int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x17000090 RID: 144
	// (get) Token: 0x060005B4 RID: 1460 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000090")]
	private GUIControllerPageMenuPopupGridNavigator BuilderToolNav
	{
		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xE67414", Offset = "0xE67414", VA = "0xE67414")]
		get
		{
			return null;
		}
	}

	// Token: 0x060005B5 RID: 1461 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B5")]
	[Address(RVA = "0xE675D8", Offset = "0xE675D8", VA = "0xE675D8", Slot = "9")]
	public override void Activate()
	{
	}

	// Token: 0x060005B6 RID: 1462 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B6")]
	[Address(RVA = "0xE67714", Offset = "0xE67714", VA = "0xE67714", Slot = "14")]
	public override void NavigateToItem(int item)
	{
	}

	// Token: 0x060005B7 RID: 1463 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005B7")]
	[Address(RVA = "0xE67820", Offset = "0xE67820", VA = "0xE67820", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x060005B8 RID: 1464 RVA: 0x00004020 File Offset: 0x00002220
	[Token(Token = "0x60005B8")]
	[Address(RVA = "0xE67D10", Offset = "0xE67D10", VA = "0xE67D10", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x060005B9 RID: 1465 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B9")]
	[Address(RVA = "0xE682D4", Offset = "0xE682D4", VA = "0xE682D4")]
	public GUIControllerInventory4Page()
	{
	}

	// Token: 0x04000722 RID: 1826
	[Token(Token = "0x4000722")]
	[FieldOffset(Offset = "0x24")]
	private GUIControllerPageMenuPopupGridNavigator _accessoryNav;
}
