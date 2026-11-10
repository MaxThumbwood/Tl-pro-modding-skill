using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000A8 RID: 168
[Token(Token = "0x20000A8")]
public class GUIControllerMultiplayerLobby : FileAPI
{
	// Token: 0x0600043A RID: 1082 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600043A")]
	[Address(RVA = "0xD5DEC0", Offset = "0xD5DEC0", VA = "0xD5DEC0", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x0600043B RID: 1083 RVA: 0x000033C0 File Offset: 0x000015C0
	[Token(Token = "0x600043B")]
	[Address(RVA = "0xD5F4B4", Offset = "0xD5F4B4", VA = "0xD5F4B4", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x0600043C RID: 1084 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600043C")]
	[Address(RVA = "0xD5E244", Offset = "0xD5E244", VA = "0xD5E244")]
	private void UpdateScroll()
	{
	}

	// Token: 0x0600043D RID: 1085 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600043D")]
	[Address(RVA = "0xD5F4BC", Offset = "0xD5F4BC", VA = "0xD5F4BC")]
	private void ClampServerControls()
	{
	}

	// Token: 0x0600043E RID: 1086 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600043E")]
	[Address(RVA = "0xD5F774", Offset = "0xD5F774", VA = "0xD5F774", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x0600043F RID: 1087 RVA: 0x000033D8 File Offset: 0x000015D8
	[Token(Token = "0x600043F")]
	[Address(RVA = "0xD60550", Offset = "0xD60550", VA = "0xD60550", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x06000440 RID: 1088 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000440")]
	[Address(RVA = "0xD60C38", Offset = "0xD60C38", VA = "0xD60C38")]
	public GUIControllerMultiplayerLobby()
	{
	}

	// Token: 0x04000618 RID: 1560
	[Token(Token = "0x4000618")]
	[FieldOffset(Offset = "0x8")]
	public int selectedControl;

	// Token: 0x04000619 RID: 1561
	[Token(Token = "0x4000619")]
	[FieldOffset(Offset = "0xC")]
	public int _selectedItem;

	// Token: 0x020000A9 RID: 169
	[Token(Token = "0x20000A9")]
	public enum Controls
	{
		// Token: 0x0400061B RID: 1563
		[Token(Token = "0x400061B")]
		Host,
		// Token: 0x0400061C RID: 1564
		[Token(Token = "0x400061C")]
		Join,
		// Token: 0x0400061D RID: 1565
		[Token(Token = "0x400061D")]
		Delete,
		// Token: 0x0400061E RID: 1566
		[Token(Token = "0x400061E")]
		Favourite,
		// Token: 0x0400061F RID: 1567
		[Token(Token = "0x400061F")]
		Rename,
		// Token: 0x04000620 RID: 1568
		[Token(Token = "0x4000620")]
		Seed,
		// Token: 0x04000621 RID: 1569
		[Token(Token = "0x4000621")]
		Play,
		// Token: 0x04000622 RID: 1570
		[Token(Token = "0x4000622")]
		Back,
		// Token: 0x04000623 RID: 1571
		[Token(Token = "0x4000623")]
		New,
		// Token: 0x04000624 RID: 1572
		[Token(Token = "0x4000624")]
		Friend1,
		// Token: 0x04000625 RID: 1573
		[Token(Token = "0x4000625")]
		Friend2,
		// Token: 0x04000626 RID: 1574
		[Token(Token = "0x4000626")]
		Friend3,
		// Token: 0x04000627 RID: 1575
		[Token(Token = "0x4000627")]
		Friend4,
		// Token: 0x04000628 RID: 1576
		[Token(Token = "0x4000628")]
		Friend5
	}
}
