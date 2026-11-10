using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000E3 RID: 227
[Token(Token = "0x20000E3")]
public class GUIControllerItemFilter : GUIPageContentController
{
	// Token: 0x060005D2 RID: 1490 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005D2")]
	[Address(RVA = "0xE68B50", Offset = "0xE68B50", VA = "0xE68B50")]
	private ItemGrid_Layout GetInfoGrid()
	{
		return null;
	}

	// Token: 0x060005D3 RID: 1491 RVA: 0x00004110 File Offset: 0x00002310
	[Token(Token = "0x60005D3")]
	[Address(RVA = "0xE68BB8", Offset = "0xE68BB8", VA = "0xE68BB8")]
	private int GetInfoCollectionCount()
	{
		return 0;
	}

	// Token: 0x060005D4 RID: 1492 RVA: 0x00004128 File Offset: 0x00002328
	[Token(Token = "0x60005D4")]
	[Address(RVA = "0xE68BC0", Offset = "0xE68BC0", VA = "0xE68BC0")]
	private float GetInfoItemScale()
	{
		return 0f;
	}

	// Token: 0x17000092 RID: 146
	// (get) Token: 0x060005D5 RID: 1493 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000092")]
	private GUIControllerPageMenuPopupGridNavigator AccessoryNav
	{
		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xE68C28", Offset = "0xE68C28", VA = "0xE68C28")]
		get
		{
			return null;
		}
	}

	// Token: 0x060005D6 RID: 1494 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005D6")]
	[Address(RVA = "0xE68DEC", Offset = "0xE68DEC", VA = "0xE68DEC")]
	public GUIControllerItemFilter(GUIPageIcons.Category cat)
	{
	}

	// Token: 0x060005D7 RID: 1495 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005D7")]
	[Address(RVA = "0xE68DF4", Offset = "0xE68DF4", VA = "0xE68DF4", Slot = "9")]
	public override void Activate()
	{
	}

	// Token: 0x060005D8 RID: 1496 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005D8")]
	[Address(RVA = "0xE68E20", Offset = "0xE68E20", VA = "0xE68E20")]
	public void NavigateInto(Vector2 source, Vector2 navigationVector)
	{
	}

	// Token: 0x060005D9 RID: 1497 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005D9")]
	[Address(RVA = "0xE68E24", Offset = "0xE68E24", VA = "0xE68E24", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x060005DA RID: 1498 RVA: 0x00004140 File Offset: 0x00002340
	[Token(Token = "0x60005DA")]
	[Address(RVA = "0xE68E70", Offset = "0xE68E70", VA = "0xE68E70", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x04000727 RID: 1831
	[Token(Token = "0x4000727")]
	[FieldOffset(Offset = "0x14")]
	private GUIControllerPageMenuPopupGridNavigator _accessoryNav;

	// Token: 0x04000728 RID: 1832
	[Token(Token = "0x4000728")]
	[FieldOffset(Offset = "0x18")]
	private int selectedRow;

	// Token: 0x04000729 RID: 1833
	[Token(Token = "0x4000729")]
	[FieldOffset(Offset = "0x1C")]
	private int selectedColumn;

	// Token: 0x0400072A RID: 1834
	[Token(Token = "0x400072A")]
	[FieldOffset(Offset = "0x20")]
	private bool selectedSearch;
}
