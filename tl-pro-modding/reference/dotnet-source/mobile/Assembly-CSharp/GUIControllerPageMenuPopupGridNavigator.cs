using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000F8 RID: 248
[Token(Token = "0x20000F8")]
public class GUIControllerPageMenuPopupGridNavigator
{
	// Token: 0x0600067E RID: 1662 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600067E")]
	[Address(RVA = "0xF281BC", Offset = "0xF281BC", VA = "0xF281BC")]
	public GUIControllerPageMenuPopupGridNavigator(GUIPageContentController controller, GUIControllerPageMenuPopupGridNavigator.GetGrid grid, GUIControllerPageMenuPopupGridNavigator.GetCollectionCount collectionCount, GUIControllerPageMenuPopupGridNavigator.GetItemScale itemScale)
	{
	}

	// Token: 0x170000A9 RID: 169
	// (get) Token: 0x0600067F RID: 1663 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000A9")]
	private ItemGrid_Layout GridLayout
	{
		[Token(Token = "0x600067F")]
		[Address(RVA = "0xF281F0", Offset = "0xF281F0", VA = "0xF281F0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000AA RID: 170
	// (get) Token: 0x06000680 RID: 1664 RVA: 0x000047B8 File Offset: 0x000029B8
	[Token(Token = "0x170000AA")]
	private int itemCount
	{
		[Token(Token = "0x6000680")]
		[Address(RVA = "0xF28218", Offset = "0xF28218", VA = "0xF28218")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170000AB RID: 171
	// (get) Token: 0x06000681 RID: 1665 RVA: 0x000047D0 File Offset: 0x000029D0
	[Token(Token = "0x170000AB")]
	private float itemScale
	{
		[Token(Token = "0x6000681")]
		[Address(RVA = "0xF28240", Offset = "0xF28240", VA = "0xF28240")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06000682 RID: 1666 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000682")]
	[Address(RVA = "0xF28268", Offset = "0xF28268", VA = "0xF28268")]
	public void Activate(int itemIndex = -1)
	{
	}

	// Token: 0x06000683 RID: 1667 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000683")]
	[Address(RVA = "0xF28304", Offset = "0xF28304", VA = "0xF28304")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x170000AC RID: 172
	// (get) Token: 0x06000684 RID: 1668 RVA: 0x000047E8 File Offset: 0x000029E8
	[Token(Token = "0x170000AC")]
	private int MaxRow_Horizontal
	{
		[Token(Token = "0x6000684")]
		[Address(RVA = "0xF28560", Offset = "0xF28560", VA = "0xF28560")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170000AD RID: 173
	// (get) Token: 0x06000685 RID: 1669 RVA: 0x00004800 File Offset: 0x00002A00
	[Token(Token = "0x170000AD")]
	private int MaxRowColumn_Horizontal
	{
		[Token(Token = "0x6000685")]
		[Address(RVA = "0xF2860C", Offset = "0xF2860C", VA = "0xF2860C")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170000AE RID: 174
	// (get) Token: 0x06000686 RID: 1670 RVA: 0x00004818 File Offset: 0x00002A18
	[Token(Token = "0x170000AE")]
	private bool LeftSideController
	{
		[Token(Token = "0x6000686")]
		[Address(RVA = "0xF28364", Offset = "0xF28364", VA = "0xF28364")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000AF RID: 175
	// (get) Token: 0x06000687 RID: 1671 RVA: 0x00004830 File Offset: 0x00002A30
	[Token(Token = "0x170000AF")]
	private int MaxScrollOffset_Horizontal
	{
		[Token(Token = "0x6000687")]
		[Address(RVA = "0xF286C0", Offset = "0xF286C0", VA = "0xF286C0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170000B0 RID: 176
	// (get) Token: 0x06000688 RID: 1672 RVA: 0x00004848 File Offset: 0x00002A48
	[Token(Token = "0x170000B0")]
	private int MaxDisplayRow_Horizontal
	{
		[Token(Token = "0x6000688")]
		[Address(RVA = "0xF287E4", Offset = "0xF287E4", VA = "0xF287E4")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06000689 RID: 1673 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000689")]
	[Address(RVA = "0xF283A0", Offset = "0xF283A0", VA = "0xF283A0")]
	private GUIControllerItem NavigateHorizontal(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x0600068A RID: 1674 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600068A")]
	[Address(RVA = "0xF28860", Offset = "0xF28860", VA = "0xF28860")]
	protected void ClampPosition()
	{
	}

	// Token: 0x0600068B RID: 1675 RVA: 0x00004860 File Offset: 0x00002A60
	[Token(Token = "0x600068B")]
	[Address(RVA = "0xF289B0", Offset = "0xF289B0", VA = "0xF289B0")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x04000765 RID: 1893
	[Token(Token = "0x4000765")]
	[FieldOffset(Offset = "0x8")]
	private readonly GUIControllerPageMenuPopupGridNavigator.GetGrid _grid;

	// Token: 0x04000766 RID: 1894
	[Token(Token = "0x4000766")]
	[FieldOffset(Offset = "0xC")]
	private readonly GUIControllerPageMenuPopupGridNavigator.GetCollectionCount _collectionCount;

	// Token: 0x04000767 RID: 1895
	[Token(Token = "0x4000767")]
	[FieldOffset(Offset = "0x10")]
	private readonly GUIControllerPageMenuPopupGridNavigator.GetItemScale _itemScale;

	// Token: 0x04000768 RID: 1896
	[Token(Token = "0x4000768")]
	[FieldOffset(Offset = "0x14")]
	private readonly GUIPageContentController _controller;

	// Token: 0x04000769 RID: 1897
	[Token(Token = "0x4000769")]
	[FieldOffset(Offset = "0x18")]
	public int itemRow;

	// Token: 0x0400076A RID: 1898
	[Token(Token = "0x400076A")]
	[FieldOffset(Offset = "0x1C")]
	public int itemColumn;

	// Token: 0x020000F9 RID: 249
	// (Invoke) Token: 0x0600068D RID: 1677
	[Token(Token = "0x20000F9")]
	public delegate ItemGrid_Layout GetGrid();

	// Token: 0x020000FA RID: 250
	// (Invoke) Token: 0x06000691 RID: 1681
	[Token(Token = "0x20000FA")]
	public delegate int GetCollectionCount();

	// Token: 0x020000FB RID: 251
	// (Invoke) Token: 0x06000695 RID: 1685
	[Token(Token = "0x20000FB")]
	public delegate float GetItemScale();
}
