using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x02000104 RID: 260
[Token(Token = "0x2000104")]
public class GUIPlayerCreateController_ItemColour : FileAPI
{
	// Token: 0x060006D6 RID: 1750 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006D6")]
	[Address(RVA = "0xF2A0A8", Offset = "0xF2A0A8", VA = "0xF2A0A8")]
	public GUIPlayerCreateController_ItemColour(GUIPlayerCreateController controller)
	{
	}

	// Token: 0x060006D7 RID: 1751 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006D7")]
	[Address(RVA = "0xF2C104", Offset = "0xF2C104", VA = "0xF2C104", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x060006D8 RID: 1752 RVA: 0x00004A28 File Offset: 0x00002C28
	[Token(Token = "0x60006D8")]
	[Address(RVA = "0xF2C110", Offset = "0xF2C110", VA = "0xF2C110", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x060006D9 RID: 1753 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006D9")]
	[Address(RVA = "0xF2C118", Offset = "0xF2C118", VA = "0xF2C118", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x060006DA RID: 1754 RVA: 0x00004A40 File Offset: 0x00002C40
	[Token(Token = "0x60006DA")]
	[Address(RVA = "0xF2C1FC", Offset = "0xF2C1FC", VA = "0xF2C1FC", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x0400078B RID: 1931
	[Token(Token = "0x400078B")]
	[FieldOffset(Offset = "0x8")]
	private readonly GUIPlayerCreateController _controller;

	// Token: 0x0400078C RID: 1932
	[Token(Token = "0x400078C")]
	[FieldOffset(Offset = "0xC")]
	public int selectionIndex;
}
