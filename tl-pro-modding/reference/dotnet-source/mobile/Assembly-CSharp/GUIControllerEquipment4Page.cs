using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000D8 RID: 216
[Token(Token = "0x20000D8")]
public class GUIControllerEquipment4Page : GUIControllerEquipment
{
	// Token: 0x0600056A RID: 1386 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600056A")]
	[Address(RVA = "0xE61964", Offset = "0xE61964", VA = "0xE61964")]
	private ItemGrid_Layout GetInfoGrid()
	{
		return null;
	}

	// Token: 0x0600056B RID: 1387 RVA: 0x00003D68 File Offset: 0x00001F68
	[Token(Token = "0x600056B")]
	[Address(RVA = "0xE619CC", Offset = "0xE619CC", VA = "0xE619CC")]
	private int GetInfoCollectionCount()
	{
		return 0;
	}

	// Token: 0x0600056C RID: 1388 RVA: 0x00003D80 File Offset: 0x00001F80
	[Token(Token = "0x600056C")]
	[Address(RVA = "0xE61A58", Offset = "0xE61A58", VA = "0xE61A58")]
	private float GetInfoItemScale()
	{
		return 0f;
	}

	// Token: 0x0600056D RID: 1389 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600056D")]
	[Address(RVA = "0xE61AC0", Offset = "0xE61AC0", VA = "0xE61AC0")]
	private ItemGrid_Layout GetLoadoutGrid()
	{
		return null;
	}

	// Token: 0x0600056E RID: 1390 RVA: 0x00003D98 File Offset: 0x00001F98
	[Token(Token = "0x600056E")]
	[Address(RVA = "0xE61B28", Offset = "0xE61B28", VA = "0xE61B28")]
	private int GetLoadoutCollectionCount()
	{
		return 0;
	}

	// Token: 0x0600056F RID: 1391 RVA: 0x00003DB0 File Offset: 0x00001FB0
	[Token(Token = "0x600056F")]
	[Address(RVA = "0xE61B30", Offset = "0xE61B30", VA = "0xE61B30")]
	private float GetLoadoutItemScale()
	{
		return 0f;
	}

	// Token: 0x1700008B RID: 139
	// (get) Token: 0x06000570 RID: 1392 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700008B")]
	private GUIControllerPageMenuPopupGridNavigator AccessoryNav
	{
		[Token(Token = "0x6000570")]
		[Address(RVA = "0xE61B98", Offset = "0xE61B98", VA = "0xE61B98")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700008C RID: 140
	// (get) Token: 0x06000571 RID: 1393 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700008C")]
	private GUIControllerPageMenuPopupGridNavigator LoadoutNav
	{
		[Token(Token = "0x6000571")]
		[Address(RVA = "0xE61D5C", Offset = "0xE61D5C", VA = "0xE61D5C")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000572 RID: 1394 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000572")]
	[Address(RVA = "0xE61F20", Offset = "0xE61F20", VA = "0xE61F20", Slot = "9")]
	public override void Activate()
	{
	}

	// Token: 0x06000573 RID: 1395 RVA: 0x00003DC8 File Offset: 0x00001FC8
	[Token(Token = "0x6000573")]
	[Address(RVA = "0xE62248", Offset = "0xE62248", VA = "0xE62248", Slot = "8")]
	public override int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x06000574 RID: 1396 RVA: 0x00003DE0 File Offset: 0x00001FE0
	[Token(Token = "0x6000574")]
	[Address(RVA = "0xE62410", Offset = "0xE62410", VA = "0xE62410")]
	private bool IsValidPosition(int col, int row)
	{
		return default(bool);
	}

	// Token: 0x06000575 RID: 1397 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000575")]
	[Address(RVA = "0xE62044", Offset = "0xE62044", VA = "0xE62044")]
	private void MoveToValidPosition()
	{
	}

	// Token: 0x06000576 RID: 1398 RVA: 0x00003DF8 File Offset: 0x00001FF8
	[Token(Token = "0x6000576")]
	[Address(RVA = "0xE62A3C", Offset = "0xE62A3C", VA = "0xE62A3C")]
	private bool MoveToValidRowInColumn(int yDir = 0)
	{
		return default(bool);
	}

	// Token: 0x06000577 RID: 1399 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000577")]
	[Address(RVA = "0xE62B24", Offset = "0xE62B24", VA = "0xE62B24", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x06000578 RID: 1400 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000578")]
	[Address(RVA = "0xE634D8", Offset = "0xE634D8", VA = "0xE634D8")]
	private void ClampMenu(bool preferUp = true)
	{
	}

	// Token: 0x06000579 RID: 1401 RVA: 0x00003E10 File Offset: 0x00002010
	[Token(Token = "0x6000579")]
	[Address(RVA = "0xE635B0", Offset = "0xE635B0", VA = "0xE635B0", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x0600057A RID: 1402 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600057A")]
	[Address(RVA = "0xE639F0", Offset = "0xE639F0", VA = "0xE639F0")]
	private void ClampExtraAccessories()
	{
	}

	// Token: 0x0600057B RID: 1403 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600057B")]
	[Address(RVA = "0xE63AFC", Offset = "0xE63AFC", VA = "0xE63AFC", Slot = "12")]
	public override void NavigateInto(int column, int row)
	{
	}

	// Token: 0x0600057C RID: 1404 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600057C")]
	[Address(RVA = "0xE63C50", Offset = "0xE63C50", VA = "0xE63C50")]
	public GUIControllerEquipment4Page()
	{
	}

	// Token: 0x0400070A RID: 1802
	[Token(Token = "0x400070A")]
	[FieldOffset(Offset = "0x20")]
	private GUIControllerPageMenuPopupGridNavigator _accessoryNav;

	// Token: 0x0400070B RID: 1803
	[Token(Token = "0x400070B")]
	[FieldOffset(Offset = "0x24")]
	private GUIControllerPageMenuPopupGridNavigator _loadoutNav;
}
