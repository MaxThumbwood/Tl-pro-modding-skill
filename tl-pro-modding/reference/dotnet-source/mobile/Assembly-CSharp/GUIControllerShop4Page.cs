using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000EE RID: 238
[Token(Token = "0x20000EE")]
public class GUIControllerShop4Page : GUIControllerShop
{
	// Token: 0x06000625 RID: 1573 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000625")]
	[Address(RVA = "0xF238A0", Offset = "0xF238A0", VA = "0xF238A0")]
	private ItemGrid_Layout GetGrid()
	{
		return null;
	}

	// Token: 0x06000626 RID: 1574 RVA: 0x000044D0 File Offset: 0x000026D0
	[Token(Token = "0x6000626")]
	[Address(RVA = "0xF23974", Offset = "0xF23974", VA = "0xF23974")]
	private float GetItemScale()
	{
		return 0f;
	}

	// Token: 0x06000627 RID: 1575 RVA: 0x000044E8 File Offset: 0x000026E8
	[Token(Token = "0x6000627")]
	[Address(RVA = "0xF239DC", Offset = "0xF239DC", VA = "0xF239DC", Slot = "14")]
	public override bool IsInMenu()
	{
		return default(bool);
	}

	// Token: 0x06000628 RID: 1576 RVA: 0x00004500 File Offset: 0x00002700
	[Token(Token = "0x6000628")]
	[Address(RVA = "0xF23C84", Offset = "0xF23C84", VA = "0xF23C84")]
	private int GetMenuItemCount()
	{
		return 0;
	}

	// Token: 0x06000629 RID: 1577 RVA: 0x00004518 File Offset: 0x00002718
	[Token(Token = "0x6000629")]
	[Address(RVA = "0xF23C8C", Offset = "0xF23C8C", VA = "0xF23C8C")]
	private int GetDisplayItemCount()
	{
		return 0;
	}

	// Token: 0x17000097 RID: 151
	// (get) Token: 0x0600062A RID: 1578 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000097")]
	public GUIControllerStaticGridNavigator GridNav
	{
		[Token(Token = "0x600062A")]
		[Address(RVA = "0xF23A3C", Offset = "0xF23A3C", VA = "0xF23A3C")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600062B RID: 1579 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600062B")]
	[Address(RVA = "0xF23F64", Offset = "0xF23F64", VA = "0xF23F64", Slot = "9")]
	public override void Activate()
	{
	}

	// Token: 0x0600062C RID: 1580 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600062C")]
	[Address(RVA = "0xF24080", Offset = "0xF24080", VA = "0xF24080", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x0600062D RID: 1581 RVA: 0x00004530 File Offset: 0x00002730
	[Token(Token = "0x600062D")]
	[Address(RVA = "0xF2416C", Offset = "0xF2416C", VA = "0xF2416C", Slot = "8")]
	public override int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x0600062E RID: 1582 RVA: 0x00004548 File Offset: 0x00002748
	[Token(Token = "0x600062E")]
	[Address(RVA = "0xF24510", Offset = "0xF24510", VA = "0xF24510", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x0600062F RID: 1583 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600062F")]
	[Address(RVA = "0xF24A30", Offset = "0xF24A30", VA = "0xF24A30", Slot = "12")]
	public override void NavigateInto(int column, int row)
	{
	}

	// Token: 0x06000630 RID: 1584 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000630")]
	[Address(RVA = "0xF24BA4", Offset = "0xF24BA4", VA = "0xF24BA4")]
	public GUIControllerShop4Page()
	{
	}

	// Token: 0x04000752 RID: 1874
	[Token(Token = "0x4000752")]
	[FieldOffset(Offset = "0x1C")]
	private GUIControllerStaticGridNavigator _gridNav;
}
