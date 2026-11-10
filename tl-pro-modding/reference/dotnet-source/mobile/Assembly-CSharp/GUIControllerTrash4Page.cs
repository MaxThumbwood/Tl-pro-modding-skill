using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000F0 RID: 240
[Token(Token = "0x20000F0")]
public class GUIControllerTrash4Page : GUIControllerTrash
{
	// Token: 0x06000635 RID: 1589 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000635")]
	[Address(RVA = "0xF24FE4", Offset = "0xF24FE4", VA = "0xF24FE4", Slot = "9")]
	public override void Activate()
	{
	}

	// Token: 0x06000636 RID: 1590 RVA: 0x00004578 File Offset: 0x00002778
	[Token(Token = "0x6000636")]
	[Address(RVA = "0xF24FE8", Offset = "0xF24FE8", VA = "0xF24FE8", Slot = "8")]
	public override int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x06000637 RID: 1591 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000637")]
	[Address(RVA = "0xF24FF0", Offset = "0xF24FF0", VA = "0xF24FF0", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x06000638 RID: 1592 RVA: 0x00004590 File Offset: 0x00002790
	[Token(Token = "0x6000638")]
	[Address(RVA = "0xF2539C", Offset = "0xF2539C", VA = "0xF2539C", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x06000639 RID: 1593 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000639")]
	[Address(RVA = "0xF256A8", Offset = "0xF256A8", VA = "0xF256A8")]
	public GUIControllerTrash4Page()
	{
	}
}
