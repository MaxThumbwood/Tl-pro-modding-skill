using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000CA RID: 202
[Token(Token = "0x20000CA")]
public class GUIControllerChest4Page : GUIControllerChest
{
	// Token: 0x06000500 RID: 1280 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000500")]
	[Address(RVA = "0xE5CE60", Offset = "0xE5CE60", VA = "0xE5CE60")]
	private ItemGrid_Layout GetGrid()
	{
		return null;
	}

	// Token: 0x06000501 RID: 1281 RVA: 0x00003990 File Offset: 0x00001B90
	[Token(Token = "0x6000501")]
	[Address(RVA = "0xE5CEC8", Offset = "0xE5CEC8", VA = "0xE5CEC8")]
	private float GetItemScale()
	{
		return 0f;
	}

	// Token: 0x06000502 RID: 1282 RVA: 0x000039A8 File Offset: 0x00001BA8
	[Token(Token = "0x6000502")]
	[Address(RVA = "0xE5CF30", Offset = "0xE5CF30", VA = "0xE5CF30", Slot = "14")]
	public override bool IsInMenu()
	{
		return default(bool);
	}

	// Token: 0x06000503 RID: 1283 RVA: 0x000039C0 File Offset: 0x00001BC0
	[Token(Token = "0x6000503")]
	[Address(RVA = "0xE5D168", Offset = "0xE5D168", VA = "0xE5D168")]
	private int GetMenuItemCount()
	{
		return 0;
	}

	// Token: 0x06000504 RID: 1284 RVA: 0x000039D8 File Offset: 0x00001BD8
	[Token(Token = "0x6000504")]
	[Address(RVA = "0xE5D170", Offset = "0xE5D170", VA = "0xE5D170")]
	private int GetDisplayItemCount()
	{
		return 0;
	}

	// Token: 0x17000087 RID: 135
	// (get) Token: 0x06000505 RID: 1285 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000087")]
	public GUIControllerStaticGridNavigator GridNav
	{
		[Token(Token = "0x6000505")]
		[Address(RVA = "0xE5CF58", Offset = "0xE5CF58", VA = "0xE5CF58")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000506 RID: 1286 RVA: 0x000039F0 File Offset: 0x00001BF0
	[Token(Token = "0x6000506")]
	[Address(RVA = "0xE5D178", Offset = "0xE5D178", VA = "0xE5D178", Slot = "8")]
	public override int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x06000507 RID: 1287 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000507")]
	[Address(RVA = "0xE5D1B0", Offset = "0xE5D1B0", VA = "0xE5D1B0", Slot = "9")]
	public override void Activate()
	{
	}

	// Token: 0x06000508 RID: 1288 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000508")]
	[Address(RVA = "0xE5D1EC", Offset = "0xE5D1EC", VA = "0xE5D1EC", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x06000509 RID: 1289 RVA: 0x00003A08 File Offset: 0x00001C08
	[Token(Token = "0x6000509")]
	[Address(RVA = "0xE5D2C4", Offset = "0xE5D2C4", VA = "0xE5D2C4", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x0600050A RID: 1290 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600050A")]
	[Address(RVA = "0xE5D400", Offset = "0xE5D400", VA = "0xE5D400", Slot = "12")]
	public override void NavigateInto(int column, int row)
	{
	}

	// Token: 0x0600050B RID: 1291 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600050B")]
	[Address(RVA = "0xE5D448", Offset = "0xE5D448", VA = "0xE5D448")]
	public GUIControllerChest4Page()
	{
	}

	// Token: 0x040006EA RID: 1770
	[Token(Token = "0x40006EA")]
	[FieldOffset(Offset = "0x1C")]
	private GUIControllerStaticGridNavigator _gridNav;
}
