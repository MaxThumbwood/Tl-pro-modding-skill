using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000EC RID: 236
[Token(Token = "0x20000EC")]
public class GUIControllerResearchPage4Page : GUIPageContentController
{
	// Token: 0x06000613 RID: 1555 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000613")]
	[Address(RVA = "0xF21794", Offset = "0xF21794", VA = "0xF21794")]
	public GUIControllerResearchPage4Page()
	{
	}

	// Token: 0x06000614 RID: 1556 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000614")]
	[Address(RVA = "0xF217DC", Offset = "0xF217DC", VA = "0xF217DC")]
	private DraggableItemGrid_Layout GetGrid()
	{
		return null;
	}

	// Token: 0x06000615 RID: 1557 RVA: 0x000043E0 File Offset: 0x000025E0
	[Token(Token = "0x6000615")]
	[Address(RVA = "0xF21844", Offset = "0xF21844", VA = "0xF21844")]
	private int GetCollectionCount()
	{
		return 0;
	}

	// Token: 0x06000616 RID: 1558 RVA: 0x000043F8 File Offset: 0x000025F8
	[Token(Token = "0x6000616")]
	[Address(RVA = "0xF218F0", Offset = "0xF218F0", VA = "0xF218F0")]
	private float GetItemScale()
	{
		return 0f;
	}

	// Token: 0x06000617 RID: 1559 RVA: 0x00004410 File Offset: 0x00002610
	[Token(Token = "0x6000617")]
	[Address(RVA = "0xF21958", Offset = "0xF21958", VA = "0xF21958")]
	private float GetScrollOffset()
	{
		return 0f;
	}

	// Token: 0x06000618 RID: 1560 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000618")]
	[Address(RVA = "0xF219E4", Offset = "0xF219E4", VA = "0xF219E4")]
	private void SetScrollOffset(float offset)
	{
	}

	// Token: 0x06000619 RID: 1561 RVA: 0x00004428 File Offset: 0x00002628
	[Token(Token = "0x6000619")]
	[Address(RVA = "0xF21A78", Offset = "0xF21A78", VA = "0xF21A78")]
	public bool IsInMenu()
	{
		return default(bool);
	}

	// Token: 0x0600061A RID: 1562 RVA: 0x00004440 File Offset: 0x00002640
	[Token(Token = "0x600061A")]
	[Address(RVA = "0xF21DD4", Offset = "0xF21DD4", VA = "0xF21DD4")]
	private int GetMenuItemCount()
	{
		return 0;
	}

	// Token: 0x0600061B RID: 1563 RVA: 0x00004458 File Offset: 0x00002658
	[Token(Token = "0x600061B")]
	[Address(RVA = "0xF21DDC", Offset = "0xF21DDC", VA = "0xF21DDC")]
	private int GetDisplayItemCount()
	{
		return 0;
	}

	// Token: 0x17000096 RID: 150
	// (get) Token: 0x0600061C RID: 1564 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000096")]
	public GUIControllerDynamicGridNavigator GridNav
	{
		[Token(Token = "0x600061C")]
		[Address(RVA = "0xF21AAC", Offset = "0xF21AAC", VA = "0xF21AAC")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600061D RID: 1565 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600061D")]
	[Address(RVA = "0xF22284", Offset = "0xF22284", VA = "0xF22284", Slot = "9")]
	public override void Activate()
	{
	}

	// Token: 0x0600061E RID: 1566 RVA: 0x00004470 File Offset: 0x00002670
	[Token(Token = "0x600061E")]
	[Address(RVA = "0xF2262C", Offset = "0xF2262C", VA = "0xF2262C", Slot = "8")]
	public override int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x0600061F RID: 1567 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600061F")]
	[Address(RVA = "0xF22CF0", Offset = "0xF22CF0", VA = "0xF22CF0", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x06000620 RID: 1568 RVA: 0x00004488 File Offset: 0x00002688
	[Token(Token = "0x6000620")]
	[Address(RVA = "0xF22F60", Offset = "0xF22F60", VA = "0xF22F60", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x06000621 RID: 1569 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000621")]
	[Address(RVA = "0xF236B0", Offset = "0xF236B0", VA = "0xF236B0", Slot = "12")]
	public override void NavigateInto(int column, int row)
	{
	}

	// Token: 0x06000622 RID: 1570 RVA: 0x000044A0 File Offset: 0x000026A0
	[Token(Token = "0x6000622")]
	[Address(RVA = "0xF237D4", Offset = "0xF237D4", VA = "0xF237D4", Slot = "13")]
	public override bool HasContent()
	{
		return default(bool);
	}

	// Token: 0x0400074F RID: 1871
	[Token(Token = "0x400074F")]
	[FieldOffset(Offset = "0x14")]
	private GUIControllerDynamicGridNavigator _gridNav;
}
