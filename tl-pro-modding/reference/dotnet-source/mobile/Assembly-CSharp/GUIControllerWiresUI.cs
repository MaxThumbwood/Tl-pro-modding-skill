using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000BA RID: 186
[Token(Token = "0x20000BA")]
public class GUIControllerWiresUI : FileAPI
{
	// Token: 0x06000494 RID: 1172 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000494")]
	[Address(RVA = "0xD69C4C", Offset = "0xD69C4C", VA = "0xD69C4C", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x06000495 RID: 1173 RVA: 0x000036C0 File Offset: 0x000018C0
	[Token(Token = "0x6000495")]
	[Address(RVA = "0xD69C50", Offset = "0xD69C50", VA = "0xD69C50", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x06000496 RID: 1174 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000496")]
	[Address(RVA = "0xD69C58", Offset = "0xD69C58", VA = "0xD69C58", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x06000497 RID: 1175 RVA: 0x000036D8 File Offset: 0x000018D8
	[Token(Token = "0x6000497")]
	[Address(RVA = "0xD69D10", Offset = "0xD69D10", VA = "0xD69D10", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x06000498 RID: 1176 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000498")]
	[Address(RVA = "0xD69F4C", Offset = "0xD69F4C", VA = "0xD69F4C")]
	public GUIControllerWiresUI()
	{
	}

	// Token: 0x04000675 RID: 1653
	[Token(Token = "0x4000675")]
	[FieldOffset(Offset = "0x8")]
	private int _selectedRow;

	// Token: 0x04000676 RID: 1654
	[Token(Token = "0x4000676")]
	[FieldOffset(Offset = "0xC")]
	private int _selectedColumn;
}
