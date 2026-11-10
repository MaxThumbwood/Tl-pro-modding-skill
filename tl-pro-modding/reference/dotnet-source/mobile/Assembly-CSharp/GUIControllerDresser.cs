using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000D5 RID: 213
[Token(Token = "0x20000D5")]
public class GUIControllerDresser : GUIPageContentController
{
	// Token: 0x06000560 RID: 1376 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000560")]
	[Address(RVA = "0xE60E44", Offset = "0xE60E44", VA = "0xE60E44")]
	public GUIControllerDresser()
	{
	}

	// Token: 0x06000561 RID: 1377 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000561")]
	[Address(RVA = "0xE60E58", Offset = "0xE60E58", VA = "0xE60E58")]
	public void ActivateOptions(int selectedOption)
	{
	}

	// Token: 0x06000562 RID: 1378 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000562")]
	[Address(RVA = "0xE60E64", Offset = "0xE60E64", VA = "0xE60E64")]
	public void DeactivateOptions()
	{
	}

	// Token: 0x06000563 RID: 1379 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000563")]
	[Address(RVA = "0xE60E70", Offset = "0xE60E70", VA = "0xE60E70", Slot = "9")]
	public override void Activate()
	{
	}

	// Token: 0x06000564 RID: 1380 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000564")]
	[Address(RVA = "0xE60F54", Offset = "0xE60F54", VA = "0xE60F54", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x06000565 RID: 1381 RVA: 0x00003D50 File Offset: 0x00001F50
	[Token(Token = "0x6000565")]
	[Address(RVA = "0xE61304", Offset = "0xE61304", VA = "0xE61304", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x040006F8 RID: 1784
	[Token(Token = "0x40006F8")]
	[FieldOffset(Offset = "0x14")]
	public GUIControllerDresser.Controls selectedControl;

	// Token: 0x040006F9 RID: 1785
	[Token(Token = "0x40006F9")]
	[FieldOffset(Offset = "0x18")]
	public int Item;

	// Token: 0x020000D6 RID: 214
	[Token(Token = "0x20000D6")]
	public enum Controls
	{
		// Token: 0x040006FB RID: 1787
		[Token(Token = "0x40006FB")]
		Style,
		// Token: 0x040006FC RID: 1788
		[Token(Token = "0x40006FC")]
		Voice,
		// Token: 0x040006FD RID: 1789
		[Token(Token = "0x40006FD")]
		Skin,
		// Token: 0x040006FE RID: 1790
		[Token(Token = "0x40006FE")]
		Eyes,
		// Token: 0x040006FF RID: 1791
		[Token(Token = "0x40006FF")]
		Shirt,
		// Token: 0x04000700 RID: 1792
		[Token(Token = "0x4000700")]
		Undershirt,
		// Token: 0x04000701 RID: 1793
		[Token(Token = "0x4000701")]
		Pants,
		// Token: 0x04000702 RID: 1794
		[Token(Token = "0x4000702")]
		Shoes,
		// Token: 0x04000703 RID: 1795
		[Token(Token = "0x4000703")]
		Element,
		// Token: 0x04000704 RID: 1796
		[Token(Token = "0x4000704")]
		Back,
		// Token: 0x04000705 RID: 1797
		[Token(Token = "0x4000705")]
		Change
	}
}
