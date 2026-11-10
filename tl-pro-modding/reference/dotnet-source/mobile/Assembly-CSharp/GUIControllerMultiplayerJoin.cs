using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020000A6 RID: 166
[Token(Token = "0x20000A6")]
public class GUIControllerMultiplayerJoin : FileAPI
{
	// Token: 0x06000431 RID: 1073 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000431")]
	[Address(RVA = "0xD5DA04", Offset = "0xD5DA04", VA = "0xD5DA04", Slot = "4")]
	public void Activate()
	{
	}

	// Token: 0x06000432 RID: 1074 RVA: 0x00003390 File Offset: 0x00001590
	[Token(Token = "0x6000432")]
	[Address(RVA = "0xD5DA10", Offset = "0xD5DA10", VA = "0xD5DA10", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return 0;
	}

	// Token: 0x06000433 RID: 1075 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000433")]
	[Address(RVA = "0xD5DA18", Offset = "0xD5DA18", VA = "0xD5DA18", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	// Token: 0x06000434 RID: 1076 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000434")]
	[Address(RVA = "0xD5DC18", Offset = "0xD5DC18", VA = "0xD5DC18")]
	public void ActivateServerIP()
	{
	}

	// Token: 0x06000435 RID: 1077 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000435")]
	[Address(RVA = "0xD5DC24", Offset = "0xD5DC24", VA = "0xD5DC24")]
	public void DeactivateServerIP()
	{
	}

	// Token: 0x06000436 RID: 1078 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000436")]
	[Address(RVA = "0xD5DC30", Offset = "0xD5DC30", VA = "0xD5DC30")]
	public void ActivateServerPort()
	{
	}

	// Token: 0x06000437 RID: 1079 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000437")]
	[Address(RVA = "0xD5DC3C", Offset = "0xD5DC3C", VA = "0xD5DC3C")]
	public void DeactivateServerPort()
	{
	}

	// Token: 0x06000438 RID: 1080 RVA: 0x000033A8 File Offset: 0x000015A8
	[Token(Token = "0x6000438")]
	[Address(RVA = "0xD5DC48", Offset = "0xD5DC48", VA = "0xD5DC48", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	// Token: 0x06000439 RID: 1081 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000439")]
	[Address(RVA = "0xD5DEB8", Offset = "0xD5DEB8", VA = "0xD5DEB8")]
	public GUIControllerMultiplayerJoin()
	{
	}

	// Token: 0x0400060E RID: 1550
	[Token(Token = "0x400060E")]
	[FieldOffset(Offset = "0x8")]
	private bool serverIPActive;

	// Token: 0x0400060F RID: 1551
	[Token(Token = "0x400060F")]
	[FieldOffset(Offset = "0x9")]
	private bool serverPortActive;

	// Token: 0x04000610 RID: 1552
	[Token(Token = "0x4000610")]
	[FieldOffset(Offset = "0xC")]
	public GUIControllerMultiplayerJoin.SelectedItem selectionIndex;

	// Token: 0x020000A7 RID: 167
	[Token(Token = "0x20000A7")]
	public enum SelectedItem
	{
		// Token: 0x04000612 RID: 1554
		[Token(Token = "0x4000612")]
		IPButton,
		// Token: 0x04000613 RID: 1555
		[Token(Token = "0x4000613")]
		PortButton,
		// Token: 0x04000614 RID: 1556
		[Token(Token = "0x4000614")]
		PasswordButton,
		// Token: 0x04000615 RID: 1557
		[Token(Token = "0x4000615")]
		Remember,
		// Token: 0x04000616 RID: 1558
		[Token(Token = "0x4000616")]
		Join,
		// Token: 0x04000617 RID: 1559
		[Token(Token = "0x4000617")]
		Back
	}
}
