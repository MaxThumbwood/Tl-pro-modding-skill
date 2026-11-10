using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000FC RID: 252
[Token(Token = "0x20000FC")]
public class GUIControllerStaticGridNavigator
{
	// Token: 0x06000698 RID: 1688 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000698")]
	[Address(RVA = "0xF23F28", Offset = "0xF23F28", VA = "0xF23F28")]
	public GUIControllerStaticGridNavigator(GUIPageContentController controller, GUIControllerStaticGridNavigator.GetGrid grid, GUIControllerStaticGridNavigator.GetItemScale itemScale, GUIControllerStaticGridNavigator.GetCollectionCount menuItemCount, GUIControllerStaticGridNavigator.GetCollectionCount displayItemCount)
	{
	}

	// Token: 0x170000B1 RID: 177
	// (get) Token: 0x06000699 RID: 1689 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000B1")]
	private ItemGrid_Layout GridLayout
	{
		[Token(Token = "0x6000699")]
		[Address(RVA = "0xF2919C", Offset = "0xF2919C", VA = "0xF2919C")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000B2 RID: 178
	// (get) Token: 0x0600069A RID: 1690 RVA: 0x00004878 File Offset: 0x00002A78
	[Token(Token = "0x170000B2")]
	private float itemScale
	{
		[Token(Token = "0x600069A")]
		[Address(RVA = "0xF291C4", Offset = "0xF291C4", VA = "0xF291C4")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170000B3 RID: 179
	// (get) Token: 0x0600069B RID: 1691 RVA: 0x00004890 File Offset: 0x00002A90
	[Token(Token = "0x170000B3")]
	private int MenuItemCount
	{
		[Token(Token = "0x600069B")]
		[Address(RVA = "0xF291EC", Offset = "0xF291EC", VA = "0xF291EC")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170000B4 RID: 180
	// (get) Token: 0x0600069C RID: 1692 RVA: 0x000048A8 File Offset: 0x00002AA8
	[Token(Token = "0x170000B4")]
	private int DisplayItemCount
	{
		[Token(Token = "0x600069C")]
		[Address(RVA = "0xF29214", Offset = "0xF29214", VA = "0xF29214")]
		get
		{
			return 0;
		}
	}

	// Token: 0x0600069D RID: 1693 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600069D")]
	[Address(RVA = "0xF23FE8", Offset = "0xF23FE8", VA = "0xF23FE8")]
	public void Activate(int itemIndex = -1)
	{
	}

	// Token: 0x0600069E RID: 1694 RVA: 0x000048C0 File Offset: 0x00002AC0
	[Token(Token = "0x600069E")]
	[Address(RVA = "0xF241C8", Offset = "0xF241C8", VA = "0xF241C8")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x0600069F RID: 1695 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600069F")]
	[Address(RVA = "0xF240EC", Offset = "0xF240EC", VA = "0xF240EC")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x170000B5 RID: 181
	// (get) Token: 0x060006A0 RID: 1696 RVA: 0x000048D8 File Offset: 0x00002AD8
	[Token(Token = "0x170000B5")]
	private int MenuColumn
	{
		[Token(Token = "0x60006A0")]
		[Address(RVA = "0xF29310", Offset = "0xF29310", VA = "0xF29310")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170000B6 RID: 182
	// (get) Token: 0x060006A1 RID: 1697 RVA: 0x000048F0 File Offset: 0x00002AF0
	[Token(Token = "0x170000B6")]
	private bool LeftSideController
	{
		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xF292A8", Offset = "0xF292A8", VA = "0xF292A8")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000B7 RID: 183
	// (get) Token: 0x060006A2 RID: 1698 RVA: 0x00004908 File Offset: 0x00002B08
	[Token(Token = "0x170000B7")]
	private bool HasMenu
	{
		[Token(Token = "0x60006A2")]
		[Address(RVA = "0xF2923C", Offset = "0xF2923C", VA = "0xF2923C")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000B8 RID: 184
	// (get) Token: 0x060006A3 RID: 1699 RVA: 0x00004920 File Offset: 0x00002B20
	[Token(Token = "0x170000B8")]
	public bool InMenu
	{
		[Token(Token = "0x60006A3")]
		[Address(RVA = "0xF23C38", Offset = "0xF23C38", VA = "0xF23C38")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060006A4 RID: 1700 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006A4")]
	[Address(RVA = "0xF29690", Offset = "0xF29690", VA = "0xF29690")]
	private void ClampMenu(bool preferUp = true)
	{
	}

	// Token: 0x060006A5 RID: 1701 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006A5")]
	[Address(RVA = "0xF2977C", Offset = "0xF2977C", VA = "0xF2977C")]
	private GUIControllerItem NavigateMenuOutOfGrid()
	{
		return null;
	}

	// Token: 0x060006A6 RID: 1702 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006A6")]
	[Address(RVA = "0xF29830", Offset = "0xF29830", VA = "0xF29830")]
	private GUIControllerItem NavigateUpOutOfGrid()
	{
		return null;
	}

	// Token: 0x060006A7 RID: 1703 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006A7")]
	[Address(RVA = "0xF29880", Offset = "0xF29880", VA = "0xF29880")]
	private GUIControllerItem NavigateDownOutOfGrid()
	{
		return null;
	}

	// Token: 0x060006A8 RID: 1704 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006A8")]
	[Address(RVA = "0xF298D0", Offset = "0xF298D0", VA = "0xF298D0")]
	private GUIControllerItem NavigateInnerOutOfGrid()
	{
		return null;
	}

	// Token: 0x060006A9 RID: 1705 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006A9")]
	[Address(RVA = "0xF29354", Offset = "0xF29354", VA = "0xF29354")]
	private GUIControllerItem NavigateHorizontal(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x060006AA RID: 1706 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006AA")]
	[Address(RVA = "0xF29AB4", Offset = "0xF29AB4", VA = "0xF29AB4")]
	protected void ClampPosition()
	{
	}

	// Token: 0x060006AB RID: 1707 RVA: 0x00004938 File Offset: 0x00002B38
	[Token(Token = "0x60006AB")]
	[Address(RVA = "0xF2458C", Offset = "0xF2458C", VA = "0xF2458C")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x060006AC RID: 1708 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006AC")]
	[Address(RVA = "0xF24A9C", Offset = "0xF24A9C", VA = "0xF24A9C")]
	public void NavigateInto(int column, int row)
	{
	}

	// Token: 0x0400076B RID: 1899
	[Token(Token = "0x400076B")]
	[FieldOffset(Offset = "0x8")]
	private readonly GUIControllerStaticGridNavigator.GetGrid _grid;

	// Token: 0x0400076C RID: 1900
	[Token(Token = "0x400076C")]
	[FieldOffset(Offset = "0xC")]
	private readonly GUIControllerStaticGridNavigator.GetItemScale _itemScale;

	// Token: 0x0400076D RID: 1901
	[Token(Token = "0x400076D")]
	[FieldOffset(Offset = "0x10")]
	private readonly GUIPageContentController _controller;

	// Token: 0x0400076E RID: 1902
	[Token(Token = "0x400076E")]
	[FieldOffset(Offset = "0x14")]
	private readonly GUIControllerStaticGridNavigator.GetCollectionCount _displayItemCount;

	// Token: 0x0400076F RID: 1903
	[Token(Token = "0x400076F")]
	[FieldOffset(Offset = "0x18")]
	private readonly GUIControllerStaticGridNavigator.GetCollectionCount _menuItemCount;

	// Token: 0x04000770 RID: 1904
	[Token(Token = "0x4000770")]
	[FieldOffset(Offset = "0x1C")]
	public int itemRow;

	// Token: 0x04000771 RID: 1905
	[Token(Token = "0x4000771")]
	[FieldOffset(Offset = "0x20")]
	public int itemColumn;

	// Token: 0x04000772 RID: 1906
	[Token(Token = "0x4000772")]
	[FieldOffset(Offset = "0x24")]
	public int menuRow;

	// Token: 0x020000FD RID: 253
	// (Invoke) Token: 0x060006AE RID: 1710
	[Token(Token = "0x20000FD")]
	public delegate ItemGrid_Layout GetGrid();

	// Token: 0x020000FE RID: 254
	// (Invoke) Token: 0x060006B2 RID: 1714
	[Token(Token = "0x20000FE")]
	public delegate int GetCollectionCount();

	// Token: 0x020000FF RID: 255
	// (Invoke) Token: 0x060006B6 RID: 1718
	[Token(Token = "0x20000FF")]
	public delegate float GetItemScale();
}
