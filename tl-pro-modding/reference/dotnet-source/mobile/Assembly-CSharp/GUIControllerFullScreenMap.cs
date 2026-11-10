using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x0200009A RID: 154
[Token(Token = "0x200009A")]
public class GUIControllerFullScreenMap : FileAPI
{
	// Token: 0x060003FF RID: 1023 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003FF")]
	[Address(RVA = "0xC52C88", Offset = "0xC52C88", VA = "0xC52C88", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x06000400 RID: 1024 RVA: 0x000031F8 File Offset: 0x000013F8
	[Token(Token = "0x6000400")]
	[Address(RVA = "0xC52C8C", Offset = "0xC52C8C", VA = "0xC52C8C", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x06000401 RID: 1025 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000401")]
	[Address(RVA = "0xC52C94", Offset = "0xC52C94", VA = "0xC52C94", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x06000402 RID: 1026 RVA: 0x00003210 File Offset: 0x00001410
	[Token(Token = "0x6000402")]
	[Address(RVA = "0xC52C98", Offset = "0xC52C98", VA = "0xC52C98", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x06000403 RID: 1027 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000403")]
	[Address(RVA = "0xC52D60", Offset = "0xC52D60", VA = "0xC52D60")]
	public GUIControllerFullScreenMap()
	{
	}
}
