using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x0200009B RID: 155
[Token(Token = "0x200009B")]
public class GUIControllerGenericPopup : FileAPI
{
	// Token: 0x06000404 RID: 1028 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000404")]
	[Address(RVA = "0xC52D68", Offset = "0xC52D68", VA = "0xC52D68", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x06000405 RID: 1029 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000405")]
	[Address(RVA = "0xC52DF4", Offset = "0xC52DF4", VA = "0xC52DF4", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x06000406 RID: 1030 RVA: 0x00003228 File Offset: 0x00001428
	[Token(Token = "0x6000406")]
	[Address(RVA = "0xC52F4C", Offset = "0xC52F4C", VA = "0xC52F4C", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x06000407 RID: 1031 RVA: 0x00003240 File Offset: 0x00001440
	[Token(Token = "0x6000407")]
	[Address(RVA = "0xC53064", Offset = "0xC53064", VA = "0xC53064", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x06000408 RID: 1032 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000408")]
	[Address(RVA = "0xC5306C", Offset = "0xC5306C", VA = "0xC5306C")]
	public GUIControllerGenericPopup()
	{
	}

	// Token: 0x040005E8 RID: 1512
	[Token(Token = "0x40005E8")]
	[FieldOffset(Offset = "0x8")]
	public int selectedControl;
}
