using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000CC RID: 204
[Token(Token = "0x20000CC")]
public class GUIControllerCoins4Page : GUIControllerCoins
{
	// Token: 0x06000510 RID: 1296 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000510")]
	[Address(RVA = "0xE5D4B0", Offset = "0xE5D4B0", VA = "0xE5D4B0", Slot = "14")]
	public override void NavigateFromInventoryRow(int row)
	{
	}

	// Token: 0x06000511 RID: 1297 RVA: 0x00003A38 File Offset: 0x00001C38
	[Token(Token = "0x6000511")]
	[Address(RVA = "0xE5D4D8", Offset = "0xE5D4D8", VA = "0xE5D4D8", Slot = "8")]
	public override int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x06000512 RID: 1298 RVA: 0x00003A50 File Offset: 0x00001C50
	[Token(Token = "0x6000512")]
	[Address(RVA = "0xE5D4F4", Offset = "0xE5D4F4", VA = "0xE5D4F4", Slot = "15")]
	public override int GetInventoryRow()
	{
		return 0;
	}

	// Token: 0x06000513 RID: 1299 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000513")]
	[Address(RVA = "0xE5D500", Offset = "0xE5D500", VA = "0xE5D500", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x06000514 RID: 1300 RVA: 0x00003A68 File Offset: 0x00001C68
	[Token(Token = "0x6000514")]
	[Address(RVA = "0xE5DA04", Offset = "0xE5DA04", VA = "0xE5DA04", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x06000515 RID: 1301 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000515")]
	[Address(RVA = "0xE5DE18", Offset = "0xE5DE18", VA = "0xE5DE18")]
	public GUIControllerCoins4Page()
	{
	}
}
