using System;
using System.IO;
using Il2CppDummyDll;
using Terraria;
using Terraria.IO;

// Token: 0x02000342 RID: 834
[Token(Token = "0x2000342")]
internal class Player_OldConsole
{
	// Token: 0x0600146D RID: 5229 RVA: 0x00009018 File Offset: 0x00007218
	[Token(Token = "0x600146D")]
	[Address(RVA = "0xDC42FC", Offset = "0xDC42FC", VA = "0xDC42FC")]
	private static short ReadItemID(BinaryReader fileIO, int playerFileVersion)
	{
		return 0;
	}

	// Token: 0x0600146E RID: 5230 RVA: 0x00009030 File Offset: 0x00007230
	[Token(Token = "0x600146E")]
	[Address(RVA = "0xDC4348", Offset = "0xDC4348", VA = "0xDC4348")]
	public static bool LoadPlayer(string playerPath, PlayerFileData playerData)
	{
		return default(bool);
	}

	// Token: 0x0600146F RID: 5231 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600146F")]
	[Address(RVA = "0xDC8D28", Offset = "0xDC8D28", VA = "0xDC8D28")]
	private static void GivePlayerCoins(Player player, int value)
	{
	}

	// Token: 0x06001470 RID: 5232 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001470")]
	[Address(RVA = "0xDC9514", Offset = "0xDC9514", VA = "0xDC9514")]
	public Player_OldConsole()
	{
	}

	// Token: 0x04002929 RID: 10537
	[Token(Token = "0x4002929")]
	private const int PlayerFileVersion_GUID = 1000;

	// Token: 0x0400292A RID: 10538
	[Token(Token = "0x400292A")]
	private const int PlayerFileVersion_1_3_1 = 1001;

	// Token: 0x0400292B RID: 10539
	[Token(Token = "0x400292B")]
	private const int PlayerFileVersion_1_3_4 = 1002;

	// Token: 0x0400292C RID: 10540
	[Token(Token = "0x400292C")]
	private const int PlayerFileVersion_RemapENGINEItems = 1003;

	// Token: 0x0400292D RID: 10541
	[Token(Token = "0x400292D")]
	private const int PlayerFileVersion_RememberDPadShortcut = 1004;

	// Token: 0x0400292E RID: 10542
	[Token(Token = "0x400292E")]
	[FieldOffset(Offset = "0x0")]
	public static byte[] EncryptionKey;
}
