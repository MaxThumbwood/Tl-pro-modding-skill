using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x02000106 RID: 262
[Token(Token = "0x2000106")]
public class GUIPlayerCreateController_Tabs : FileAPI
{
	// Token: 0x060006E1 RID: 1761 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006E1")]
	[Address(RVA = "0xF2A010", Offset = "0xF2A010", VA = "0xF2A010")]
	public GUIPlayerCreateController_Tabs(GUIPlayerCreateController controller)
	{
	}

	// Token: 0x060006E2 RID: 1762 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006E2")]
	[Address(RVA = "0xF2A9A8", Offset = "0xF2A9A8", VA = "0xF2A9A8", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x060006E3 RID: 1763 RVA: 0x00004A88 File Offset: 0x00002C88
	[Token(Token = "0x60006E3")]
	[Address(RVA = "0xF2C8E4", Offset = "0xF2C8E4", VA = "0xF2C8E4", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x060006E4 RID: 1764 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006E4")]
	[Address(RVA = "0xF2A0F0", Offset = "0xF2A0F0", VA = "0xF2A0F0")]
	public GUIControllerItem NavigateIntoCurrentPage(bool fromTabSwitch = false)
	{
		return null;
	}

	// Token: 0x060006E5 RID: 1765 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006E5")]
	[Address(RVA = "0xF2C9D8", Offset = "0xF2C9D8", VA = "0xF2C9D8", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x060006E6 RID: 1766 RVA: 0x00004AA0 File Offset: 0x00002CA0
	[Token(Token = "0x60006E6")]
	[Address(RVA = "0xF2CA38", Offset = "0xF2CA38", VA = "0xF2CA38", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x0400078F RID: 1935
	[Token(Token = "0x400078F")]
	[FieldOffset(Offset = "0x8")]
	private readonly GUIPlayerCreateController _controller;

	// Token: 0x04000790 RID: 1936
	[Token(Token = "0x4000790")]
	[FieldOffset(Offset = "0xC")]
	public GUIPlayerCreateMenu.ItemSelection HighlightedTab;
}
