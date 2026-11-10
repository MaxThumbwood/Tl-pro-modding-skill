using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000D1 RID: 209
[Token(Token = "0x20000D1")]
public class GUIControllerCraftingGuidePopup : FileAPI
{
	// Token: 0x06000542 RID: 1346 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000542")]
	[Address(RVA = "0xE5EE78", Offset = "0xE5EE78", VA = "0xE5EE78")]
	private DraggableItemGrid_Layout GetGrid()
	{
		return null;
	}

	// Token: 0x06000543 RID: 1347 RVA: 0x00003C30 File Offset: 0x00001E30
	[Token(Token = "0x6000543")]
	[Address(RVA = "0xE5EF40", Offset = "0xE5EF40", VA = "0xE5EF40")]
	private int GetCollectionCount()
	{
		return 0;
	}

	// Token: 0x06000544 RID: 1348 RVA: 0x00003C48 File Offset: 0x00001E48
	[Token(Token = "0x6000544")]
	[Address(RVA = "0xE5F024", Offset = "0xE5F024", VA = "0xE5F024")]
	private float GetItemScale()
	{
		return 0f;
	}

	// Token: 0x06000545 RID: 1349 RVA: 0x00003C60 File Offset: 0x00001E60
	[Token(Token = "0x6000545")]
	[Address(RVA = "0xE5F0EC", Offset = "0xE5F0EC", VA = "0xE5F0EC")]
	private float GetScrollOffset()
	{
		return 0f;
	}

	// Token: 0x06000546 RID: 1350 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000546")]
	[Address(RVA = "0xE5F1BC", Offset = "0xE5F1BC", VA = "0xE5F1BC")]
	private void SetScrollOffset(float offset)
	{
	}

	// Token: 0x06000547 RID: 1351 RVA: 0x00003C78 File Offset: 0x00001E78
	[Token(Token = "0x6000547")]
	[Address(RVA = "0xE5F2A0", Offset = "0xE5F2A0", VA = "0xE5F2A0")]
	public bool IsInMenu()
	{
		return default(bool);
	}

	// Token: 0x06000548 RID: 1352 RVA: 0x00003C90 File Offset: 0x00001E90
	[Token(Token = "0x6000548")]
	[Address(RVA = "0xE5F5F8", Offset = "0xE5F5F8", VA = "0xE5F5F8")]
	private int GetMenuItemCount()
	{
		return 0;
	}

	// Token: 0x06000549 RID: 1353 RVA: 0x00003CA8 File Offset: 0x00001EA8
	[Token(Token = "0x6000549")]
	[Address(RVA = "0xE5F600", Offset = "0xE5F600", VA = "0xE5F600")]
	private int GetDisplayItemCount()
	{
		return 0;
	}

	// Token: 0x1700008A RID: 138
	// (get) Token: 0x0600054A RID: 1354 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700008A")]
	public GUIControllerDynamicGridNavigator GridNav
	{
		[Token(Token = "0x600054A")]
		[Address(RVA = "0xE5F2C8", Offset = "0xE5F2C8", VA = "0xE5F2C8")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600054B RID: 1355 RVA: 0x00003CC0 File Offset: 0x00001EC0
	[Token(Token = "0x600054B")]
	[Address(RVA = "0xE5F608", Offset = "0xE5F608", VA = "0xE5F608", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x0600054C RID: 1356 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600054C")]
	[Address(RVA = "0xE5F6BC", Offset = "0xE5F6BC", VA = "0xE5F6BC", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x0600054D RID: 1357 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600054D")]
	[Address(RVA = "0xE5F6E8", Offset = "0xE5F6E8", VA = "0xE5F6E8")]
	public void RefreshScrollOffset()
	{
	}

	// Token: 0x0600054E RID: 1358 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600054E")]
	[Address(RVA = "0xE5F79C", Offset = "0xE5F79C", VA = "0xE5F79C")]
	protected void UpdateScroll()
	{
	}

	// Token: 0x0600054F RID: 1359 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600054F")]
	[Address(RVA = "0xE5F7A0", Offset = "0xE5F7A0", VA = "0xE5F7A0", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x06000550 RID: 1360 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000550")]
	[Address(RVA = "0xE5F924", Offset = "0xE5F924", VA = "0xE5F924")]
	protected void ClampPosition()
	{
	}

	// Token: 0x06000551 RID: 1361 RVA: 0x00003CD8 File Offset: 0x00001ED8
	[Token(Token = "0x6000551")]
	[Address(RVA = "0xE5F928", Offset = "0xE5F928", VA = "0xE5F928", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x06000552 RID: 1362 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000552")]
	[Address(RVA = "0xE5FB9C", Offset = "0xE5FB9C", VA = "0xE5FB9C")]
	public void NavigateInto(int column, int row)
	{
	}

	// Token: 0x06000553 RID: 1363 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000553")]
	[Address(RVA = "0xE5FC60", Offset = "0xE5FC60", VA = "0xE5FC60")]
	public GUIControllerCraftingGuidePopup()
	{
	}

	// Token: 0x040006F1 RID: 1777
	[Token(Token = "0x40006F1")]
	[FieldOffset(Offset = "0x8")]
	public GUIControllerCraftingGuidePopup.Controls selectedControl;

	// Token: 0x040006F2 RID: 1778
	[Token(Token = "0x40006F2")]
	[FieldOffset(Offset = "0xC")]
	private GUIControllerDynamicGridNavigator _gridNav;

	// Token: 0x020000D2 RID: 210
	[Token(Token = "0x20000D2")]
	public enum Controls
	{
		// Token: 0x040006F4 RID: 1780
		[Token(Token = "0x40006F4")]
		Element,
		// Token: 0x040006F5 RID: 1781
		[Token(Token = "0x40006F5")]
		Back
	}
}
