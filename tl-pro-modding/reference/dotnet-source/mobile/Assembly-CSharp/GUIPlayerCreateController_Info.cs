using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x02000103 RID: 259
[Token(Token = "0x2000103")]
public class GUIPlayerCreateController_Info : FileAPI
{
	// Token: 0x060006CD RID: 1741 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006CD")]
	[Address(RVA = "0xF2A02C", Offset = "0xF2A02C", VA = "0xF2A02C")]
	public GUIPlayerCreateController_Info(GUIPlayerCreateController controller)
	{
	}

	// Token: 0x060006CE RID: 1742 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006CE")]
	[Address(RVA = "0xF2BC38", Offset = "0xF2BC38", VA = "0xF2BC38", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x060006CF RID: 1743 RVA: 0x000049F8 File Offset: 0x00002BF8
	[Token(Token = "0x60006CF")]
	[Address(RVA = "0xF2BD30", Offset = "0xF2BD30", VA = "0xF2BD30", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x060006D0 RID: 1744 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006D0")]
	[Address(RVA = "0xF2BD38", Offset = "0xF2BD38", VA = "0xF2BD38", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x060006D1 RID: 1745 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006D1")]
	[Address(RVA = "0xF2BD24", Offset = "0xF2BD24", VA = "0xF2BD24")]
	public void ActivateOptions(int selectedOption)
	{
	}

	// Token: 0x060006D2 RID: 1746 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006D2")]
	[Address(RVA = "0xF2BE58", Offset = "0xF2BE58", VA = "0xF2BE58")]
	public void DeactivateOptions()
	{
	}

	// Token: 0x060006D3 RID: 1747 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006D3")]
	[Address(RVA = "0xF2BE64", Offset = "0xF2BE64", VA = "0xF2BE64")]
	public void ActivateName()
	{
	}

	// Token: 0x060006D4 RID: 1748 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006D4")]
	[Address(RVA = "0xF2BE70", Offset = "0xF2BE70", VA = "0xF2BE70")]
	public void DeactivateName()
	{
	}

	// Token: 0x060006D5 RID: 1749 RVA: 0x00004A10 File Offset: 0x00002C10
	[Token(Token = "0x60006D5")]
	[Address(RVA = "0xF2BE7C", Offset = "0xF2BE7C", VA = "0xF2BE7C", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x04000789 RID: 1929
	[Token(Token = "0x4000789")]
	[FieldOffset(Offset = "0x8")]
	private readonly GUIPlayerCreateController _controller;

	// Token: 0x0400078A RID: 1930
	[Token(Token = "0x400078A")]
	[FieldOffset(Offset = "0xC")]
	public int element;
}
