using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x02000096 RID: 150
[Token(Token = "0x2000096")]
public class GUIControllerCraftingMaterials : FileAPI
{
	// Token: 0x060003E7 RID: 999 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E7")]
	[Address(RVA = "0xC513EC", Offset = "0xC513EC", VA = "0xC513EC", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x060003E8 RID: 1000 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E8")]
	[Address(RVA = "0xC5146C", Offset = "0xC5146C", VA = "0xC5146C")]
	private void Clamp()
	{
	}

	// Token: 0x060003E9 RID: 1001 RVA: 0x00003108 File Offset: 0x00001308
	[Token(Token = "0x60003E9")]
	[Address(RVA = "0xC51564", Offset = "0xC51564", VA = "0xC51564", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x1700007E RID: 126
	// (get) Token: 0x060003EA RID: 1002 RVA: 0x00003120 File Offset: 0x00001320
	[Token(Token = "0x1700007E")]
	public float UITextAlpha
	{
		[Token(Token = "0x60003EA")]
		[Address(RVA = "0xC5156C", Offset = "0xC5156C", VA = "0xC5156C")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x060003EB RID: 1003 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003EB")]
	[Address(RVA = "0xC51674", Offset = "0xC51674", VA = "0xC51674")]
	public void NavigateNext()
	{
	}

	// Token: 0x060003EC RID: 1004 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003EC")]
	[Address(RVA = "0xC517C8", Offset = "0xC517C8", VA = "0xC517C8")]
	public void NavigatePrevious()
	{
	}

	// Token: 0x060003ED RID: 1005 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003ED")]
	[Address(RVA = "0xC518D0", Offset = "0xC518D0", VA = "0xC518D0")]
	public void Tick()
	{
	}

	// Token: 0x060003EE RID: 1006 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003EE")]
	[Address(RVA = "0xC51948", Offset = "0xC51948", VA = "0xC51948", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x060003EF RID: 1007 RVA: 0x00003138 File Offset: 0x00001338
	[Token(Token = "0x60003EF")]
	[Address(RVA = "0xC519F4", Offset = "0xC519F4", VA = "0xC519F4")]
	public int GetSelectedItem()
	{
		return 0;
	}

	// Token: 0x060003F0 RID: 1008 RVA: 0x00003150 File Offset: 0x00001350
	[Token(Token = "0x60003F0")]
	[Address(RVA = "0xC519FC", Offset = "0xC519FC", VA = "0xC519FC", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x060003F1 RID: 1009 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F1")]
	[Address(RVA = "0xC51D58", Offset = "0xC51D58", VA = "0xC51D58")]
	public GUIControllerCraftingMaterials()
	{
	}

	// Token: 0x040005D7 RID: 1495
	[Token(Token = "0x40005D7")]
	[FieldOffset(Offset = "0x8")]
	private int selectedItem;

	// Token: 0x040005D8 RID: 1496
	[Token(Token = "0x40005D8")]
	[FieldOffset(Offset = "0x10")]
	public DateTime LastActivated;
}
