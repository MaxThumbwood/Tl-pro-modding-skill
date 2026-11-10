using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000F2 RID: 242
[Token(Token = "0x20000F2")]
public class GUIControllerDynamicGridNavigator
{
	// Token: 0x06000645 RID: 1605 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000645")]
	[Address(RVA = "0xF22230", Offset = "0xF22230", VA = "0xF22230")]
	public GUIControllerDynamicGridNavigator(GUIPageContentController controller, GUIControllerDynamicGridNavigator.GetGrid grid, GUIControllerDynamicGridNavigator.GetCollectionCount collectionCount, GUIControllerDynamicGridNavigator.GetItemScale itemScale, GUIControllerDynamicGridNavigator.GetScrollOffset getScrollOffset, GUIControllerDynamicGridNavigator.SetScrollOffset setScrollOffset, GUIControllerDynamicGridNavigator.GetCollectionCount menuItemCount, GUIControllerDynamicGridNavigator.GetCollectionCount displayItemCount)
	{
	}

	// Token: 0x17000099 RID: 153
	// (get) Token: 0x06000646 RID: 1606 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000099")]
	private DraggableItemGrid_Layout GridLayout
	{
		[Token(Token = "0x6000646")]
		[Address(RVA = "0xF2576C", Offset = "0xF2576C", VA = "0xF2576C")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700009A RID: 154
	// (get) Token: 0x06000647 RID: 1607 RVA: 0x00004608 File Offset: 0x00002808
	[Token(Token = "0x1700009A")]
	private int itemCount
	{
		[Token(Token = "0x6000647")]
		[Address(RVA = "0xF25794", Offset = "0xF25794", VA = "0xF25794")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700009B RID: 155
	// (get) Token: 0x06000648 RID: 1608 RVA: 0x00004620 File Offset: 0x00002820
	[Token(Token = "0x1700009B")]
	private float itemScale
	{
		[Token(Token = "0x6000648")]
		[Address(RVA = "0xF257BC", Offset = "0xF257BC", VA = "0xF257BC")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700009C RID: 156
	// (get) Token: 0x06000649 RID: 1609 RVA: 0x00004638 File Offset: 0x00002838
	// (set) Token: 0x0600064A RID: 1610 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700009C")]
	private float GridScrollOffset
	{
		[Token(Token = "0x6000649")]
		[Address(RVA = "0xF257E4", Offset = "0xF257E4", VA = "0xF257E4")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600064A")]
		[Address(RVA = "0xF2580C", Offset = "0xF2580C", VA = "0xF2580C")]
		set
		{
		}
	}

	// Token: 0x0600064B RID: 1611 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600064B")]
	[Address(RVA = "0xF2583C", Offset = "0xF2583C", VA = "0xF2583C")]
	public void DisableScrollUntilChange()
	{
	}

	// Token: 0x0600064C RID: 1612 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600064C")]
	[Address(RVA = "0xF25874", Offset = "0xF25874", VA = "0xF25874")]
	public void NextItem()
	{
	}

	// Token: 0x0600064D RID: 1613 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600064D")]
	[Address(RVA = "0xF25C5C", Offset = "0xF25C5C", VA = "0xF25C5C")]
	public void PreviousItem()
	{
	}

	// Token: 0x1700009D RID: 157
	// (get) Token: 0x0600064E RID: 1614 RVA: 0x00004650 File Offset: 0x00002850
	[Token(Token = "0x1700009D")]
	private int MenuItemCount
	{
		[Token(Token = "0x600064E")]
		[Address(RVA = "0xF25E08", Offset = "0xF25E08", VA = "0xF25E08")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700009E RID: 158
	// (get) Token: 0x0600064F RID: 1615 RVA: 0x00004668 File Offset: 0x00002868
	[Token(Token = "0x1700009E")]
	private int DisplayItemCount
	{
		[Token(Token = "0x600064F")]
		[Address(RVA = "0xF25E30", Offset = "0xF25E30", VA = "0xF25E30")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06000650 RID: 1616 RVA: 0x00004680 File Offset: 0x00002880
	[Token(Token = "0x6000650")]
	[Address(RVA = "0xF25E58", Offset = "0xF25E58", VA = "0xF25E58")]
	public bool isSelectedItem(int itemIndex)
	{
		return default(bool);
	}

	// Token: 0x06000651 RID: 1617 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000651")]
	[Address(RVA = "0xF222AC", Offset = "0xF222AC", VA = "0xF222AC")]
	public void Activate(int itemIndex = -1)
	{
	}

	// Token: 0x06000652 RID: 1618 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000652")]
	[Address(RVA = "0xF22E1C", Offset = "0xF22E1C", VA = "0xF22E1C")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x1700009F RID: 159
	// (get) Token: 0x06000653 RID: 1619 RVA: 0x00004698 File Offset: 0x00002898
	[Token(Token = "0x1700009F")]
	private int MaxRow_Horizontal
	{
		[Token(Token = "0x6000653")]
		[Address(RVA = "0xF25ACC", Offset = "0xF25ACC", VA = "0xF25ACC")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170000A0 RID: 160
	// (get) Token: 0x06000654 RID: 1620 RVA: 0x000046B0 File Offset: 0x000028B0
	[Token(Token = "0x170000A0")]
	private int MaxRowColumn_Horizontal
	{
		[Token(Token = "0x6000654")]
		[Address(RVA = "0xF25B78", Offset = "0xF25B78", VA = "0xF25B78")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170000A1 RID: 161
	// (get) Token: 0x06000655 RID: 1621 RVA: 0x000046C8 File Offset: 0x000028C8
	[Token(Token = "0x170000A1")]
	private int MaxRow_Vertical
	{
		[Token(Token = "0x6000655")]
		[Address(RVA = "0xF27120", Offset = "0xF27120", VA = "0xF27120")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170000A2 RID: 162
	// (get) Token: 0x06000656 RID: 1622 RVA: 0x000046E0 File Offset: 0x000028E0
	[Token(Token = "0x170000A2")]
	private int MaxRowColumn_Vertical
	{
		[Token(Token = "0x6000656")]
		[Address(RVA = "0xF271EC", Offset = "0xF271EC", VA = "0xF271EC")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170000A3 RID: 163
	// (get) Token: 0x06000657 RID: 1623 RVA: 0x000046F8 File Offset: 0x000028F8
	[Token(Token = "0x170000A3")]
	private int MenuColumn
	{
		[Token(Token = "0x6000657")]
		[Address(RVA = "0xF272C8", Offset = "0xF272C8", VA = "0xF272C8")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170000A4 RID: 164
	// (get) Token: 0x06000658 RID: 1624 RVA: 0x00004710 File Offset: 0x00002910
	[Token(Token = "0x170000A4")]
	private bool LeftSideController
	{
		[Token(Token = "0x6000658")]
		[Address(RVA = "0xF25A6C", Offset = "0xF25A6C", VA = "0xF25A6C")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000A5 RID: 165
	// (get) Token: 0x06000659 RID: 1625 RVA: 0x00004728 File Offset: 0x00002928
	[Token(Token = "0x170000A5")]
	private int MaxScrollOffset_Horizontal
	{
		[Token(Token = "0x6000659")]
		[Address(RVA = "0xF273E4", Offset = "0xF273E4", VA = "0xF273E4")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170000A6 RID: 166
	// (get) Token: 0x0600065A RID: 1626 RVA: 0x00004740 File Offset: 0x00002940
	[Token(Token = "0x170000A6")]
	private int MaxDisplayRow_Horizontal
	{
		[Token(Token = "0x600065A")]
		[Address(RVA = "0xF27508", Offset = "0xF27508", VA = "0xF27508")]
		get
		{
			return 0;
		}
	}

	// Token: 0x0600065B RID: 1627 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600065B")]
	[Address(RVA = "0xF27584", Offset = "0xF27584", VA = "0xF27584")]
	public void RefreshScrollOffset()
	{
	}

	// Token: 0x0600065C RID: 1628 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600065C")]
	[Address(RVA = "0xF25F08", Offset = "0xF25F08", VA = "0xF25F08")]
	protected void UpdateScroll()
	{
	}

	// Token: 0x170000A7 RID: 167
	// (get) Token: 0x0600065D RID: 1629 RVA: 0x00004758 File Offset: 0x00002958
	[Token(Token = "0x170000A7")]
	private bool HasMenu
	{
		[Token(Token = "0x600065D")]
		[Address(RVA = "0xF27904", Offset = "0xF27904", VA = "0xF27904")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000A8 RID: 168
	// (get) Token: 0x0600065E RID: 1630 RVA: 0x00004770 File Offset: 0x00002970
	[Token(Token = "0x170000A8")]
	public bool InMenu
	{
		[Token(Token = "0x600065E")]
		[Address(RVA = "0xF21DB8", Offset = "0xF21DB8", VA = "0xF21DB8")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600065F RID: 1631 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600065F")]
	[Address(RVA = "0xF27970", Offset = "0xF27970", VA = "0xF27970")]
	private void ClampMenu(bool preferUp = true)
	{
	}

	// Token: 0x06000660 RID: 1632 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000660")]
	[Address(RVA = "0xF27A5C", Offset = "0xF27A5C", VA = "0xF27A5C")]
	private GUIControllerItem NavigateMenuOutOfGrid()
	{
		return null;
	}

	// Token: 0x06000661 RID: 1633 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000661")]
	[Address(RVA = "0xF27AF0", Offset = "0xF27AF0", VA = "0xF27AF0")]
	private GUIControllerItem NavigateUpOutOfGrid()
	{
		return null;
	}

	// Token: 0x06000662 RID: 1634 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000662")]
	[Address(RVA = "0xF27B38", Offset = "0xF27B38", VA = "0xF27B38")]
	private GUIControllerItem NavigateDownOutOfGrid()
	{
		return null;
	}

	// Token: 0x06000663 RID: 1635 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000663")]
	[Address(RVA = "0xF27B80", Offset = "0xF27B80", VA = "0xF27B80")]
	private GUIControllerItem NavigateInnerOutOfGrid()
	{
		return null;
	}

	// Token: 0x06000664 RID: 1636 RVA: 0x00004788 File Offset: 0x00002988
	[Token(Token = "0x6000664")]
	[Address(RVA = "0xF22750", Offset = "0xF22750", VA = "0xF22750")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x06000665 RID: 1637 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000665")]
	[Address(RVA = "0xF26624", Offset = "0xF26624", VA = "0xF26624")]
	private GUIControllerItem NavigateHorizontal(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x06000666 RID: 1638 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000666")]
	[Address(RVA = "0xF26A98", Offset = "0xF26A98", VA = "0xF26A98")]
	private GUIControllerItem NavigateVertical(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x06000667 RID: 1639 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000667")]
	[Address(RVA = "0xF27D08", Offset = "0xF27D08", VA = "0xF27D08")]
	protected void ClampPosition()
	{
	}

	// Token: 0x06000668 RID: 1640 RVA: 0x000047A0 File Offset: 0x000029A0
	[Token(Token = "0x6000668")]
	[Address(RVA = "0xF23128", Offset = "0xF23128", VA = "0xF23128")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x06000669 RID: 1641 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000669")]
	[Address(RVA = "0xF236E4", Offset = "0xF236E4", VA = "0xF236E4")]
	public void NavigateInto(int column, int row)
	{
	}

	// Token: 0x04000756 RID: 1878
	[Token(Token = "0x4000756")]
	[FieldOffset(Offset = "0x8")]
	private readonly GUIControllerDynamicGridNavigator.GetGrid _grid;

	// Token: 0x04000757 RID: 1879
	[Token(Token = "0x4000757")]
	[FieldOffset(Offset = "0xC")]
	private readonly GUIControllerDynamicGridNavigator.GetCollectionCount _collectionCount;

	// Token: 0x04000758 RID: 1880
	[Token(Token = "0x4000758")]
	[FieldOffset(Offset = "0x10")]
	private readonly GUIControllerDynamicGridNavigator.GetItemScale _itemScale;

	// Token: 0x04000759 RID: 1881
	[Token(Token = "0x4000759")]
	[FieldOffset(Offset = "0x14")]
	private readonly GUIControllerDynamicGridNavigator.GetScrollOffset _getScrollOffset;

	// Token: 0x0400075A RID: 1882
	[Token(Token = "0x400075A")]
	[FieldOffset(Offset = "0x18")]
	private readonly GUIControllerDynamicGridNavigator.SetScrollOffset _setScrollOffset;

	// Token: 0x0400075B RID: 1883
	[Token(Token = "0x400075B")]
	[FieldOffset(Offset = "0x1C")]
	private readonly GUIPageContentController _controller;

	// Token: 0x0400075C RID: 1884
	[Token(Token = "0x400075C")]
	[FieldOffset(Offset = "0x20")]
	private readonly GUIControllerDynamicGridNavigator.GetCollectionCount _displayItemCount;

	// Token: 0x0400075D RID: 1885
	[Token(Token = "0x400075D")]
	[FieldOffset(Offset = "0x24")]
	private readonly GUIControllerDynamicGridNavigator.GetCollectionCount _menuItemCount;

	// Token: 0x0400075E RID: 1886
	[Token(Token = "0x400075E")]
	[FieldOffset(Offset = "0x28")]
	private bool scrollDisabledUntilChange;

	// Token: 0x0400075F RID: 1887
	[Token(Token = "0x400075F")]
	[FieldOffset(Offset = "0x2C")]
	private int itemCountAtDisableScroll;

	// Token: 0x04000760 RID: 1888
	[Token(Token = "0x4000760")]
	[FieldOffset(Offset = "0x30")]
	public int itemRow;

	// Token: 0x04000761 RID: 1889
	[Token(Token = "0x4000761")]
	[FieldOffset(Offset = "0x34")]
	public int itemColumn;

	// Token: 0x04000762 RID: 1890
	[Token(Token = "0x4000762")]
	[FieldOffset(Offset = "0x38")]
	public int menuRow;

	// Token: 0x04000763 RID: 1891
	[Token(Token = "0x4000763")]
	[FieldOffset(Offset = "0x3C")]
	private int scrollOffset;

	// Token: 0x04000764 RID: 1892
	[Token(Token = "0x4000764")]
	[FieldOffset(Offset = "0x40")]
	public int menuRowVisualOffset;

	// Token: 0x020000F3 RID: 243
	// (Invoke) Token: 0x0600066B RID: 1643
	[Token(Token = "0x20000F3")]
	public delegate DraggableItemGrid_Layout GetGrid();

	// Token: 0x020000F4 RID: 244
	// (Invoke) Token: 0x0600066F RID: 1647
	[Token(Token = "0x20000F4")]
	public delegate int GetCollectionCount();

	// Token: 0x020000F5 RID: 245
	// (Invoke) Token: 0x06000673 RID: 1651
	[Token(Token = "0x20000F5")]
	public delegate float GetItemScale();

	// Token: 0x020000F6 RID: 246
	// (Invoke) Token: 0x06000677 RID: 1655
	[Token(Token = "0x20000F6")]
	public delegate float GetScrollOffset();

	// Token: 0x020000F7 RID: 247
	// (Invoke) Token: 0x0600067B RID: 1659
	[Token(Token = "0x20000F7")]
	public delegate void SetScrollOffset(float scrollOffset);
}
