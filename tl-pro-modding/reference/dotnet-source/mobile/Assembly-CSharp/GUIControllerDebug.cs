using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x02000097 RID: 151
[Token(Token = "0x2000097")]
public class GUIControllerDebug : FileAPI
{
	// Token: 0x060003F2 RID: 1010 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F2")]
	[Address(RVA = "0xC51D60", Offset = "0xC51D60", VA = "0xC51D60", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x060003F3 RID: 1011 RVA: 0x00003168 File Offset: 0x00001368
	[Token(Token = "0x60003F3")]
	[Address(RVA = "0xC51D64", Offset = "0xC51D64", VA = "0xC51D64", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x060003F4 RID: 1012 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003F4")]
	[Address(RVA = "0xC51D6C", Offset = "0xC51D6C", VA = "0xC51D6C", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x060003F5 RID: 1013 RVA: 0x00003180 File Offset: 0x00001380
	[Token(Token = "0x60003F5")]
	[Address(RVA = "0xC51DF8", Offset = "0xC51DF8", VA = "0xC51DF8", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x060003F6 RID: 1014 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F6")]
	[Address(RVA = "0xC51EA8", Offset = "0xC51EA8", VA = "0xC51EA8")]
	public GUIControllerDebug()
	{
	}

	// Token: 0x040005D9 RID: 1497
	[Token(Token = "0x40005D9")]
	[FieldOffset(Offset = "0x8")]
	private int _selected;
}
