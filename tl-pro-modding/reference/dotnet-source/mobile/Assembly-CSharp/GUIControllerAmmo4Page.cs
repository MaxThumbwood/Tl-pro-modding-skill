using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000C7 RID: 199
[Token(Token = "0x20000C7")]
public class GUIControllerAmmo4Page : GUIControllerAmmo
{
	// Token: 0x060004E5 RID: 1253 RVA: 0x00003870 File Offset: 0x00001A70
	[Token(Token = "0x60004E5")]
	[Address(RVA = "0xE5B99C", Offset = "0xE5B99C", VA = "0xE5B99C", Slot = "8")]
	public override int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x060004E6 RID: 1254 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004E6")]
	[Address(RVA = "0xE5BA6C", Offset = "0xE5BA6C", VA = "0xE5BA6C", Slot = "14")]
	public override void NavigateFromInventoryRow(int row)
	{
	}

	// Token: 0x060004E7 RID: 1255 RVA: 0x00003888 File Offset: 0x00001A88
	[Token(Token = "0x60004E7")]
	[Address(RVA = "0xE5BA7C", Offset = "0xE5BA7C", VA = "0xE5BA7C", Slot = "15")]
	public override int GetInventoryRow()
	{
		return 0;
	}

	// Token: 0x060004E8 RID: 1256 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004E8")]
	[Address(RVA = "0xE5BA84", Offset = "0xE5BA84", VA = "0xE5BA84", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x060004E9 RID: 1257 RVA: 0x000038A0 File Offset: 0x00001AA0
	[Token(Token = "0x60004E9")]
	[Address(RVA = "0xE5C014", Offset = "0xE5C014", VA = "0xE5C014", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x060004EA RID: 1258 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004EA")]
	[Address(RVA = "0xE5C57C", Offset = "0xE5C57C", VA = "0xE5C57C")]
	public GUIControllerAmmo4Page()
	{
	}
}
