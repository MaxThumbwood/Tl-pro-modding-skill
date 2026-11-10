using System;
using System.IO;
using Il2CppDummyDll;
using Terraria;
using Terraria.IO;

// Token: 0x02000344 RID: 836
[Token(Token = "0x2000344")]
internal class Player_OldSwitch
{
	// Token: 0x0600148A RID: 5258 RVA: 0x000090F0 File Offset: 0x000072F0
	[Token(Token = "0x600148A")]
	[Address(RVA = "0xDD8D7C", Offset = "0xDD8D7C", VA = "0xDD8D7C")]
	private static short ReadItemID(BinaryReader fileIO, int playerFileVersion)
	{
		return 0;
	}

	// Token: 0x0600148B RID: 5259 RVA: 0x00009108 File Offset: 0x00007308
	[Token(Token = "0x600148B")]
	[Address(RVA = "0xDD8DAC", Offset = "0xDD8DAC", VA = "0xDD8DAC")]
	public static bool LoadPlayer(string playerPath, PlayerFileData playerData)
	{
		return default(bool);
	}

	// Token: 0x0600148C RID: 5260 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600148C")]
	[Address(RVA = "0xDDCE78", Offset = "0xDDCE78", VA = "0xDDCE78")]
	private static void GivePlayerCoins(Player player, int value)
	{
	}

	// Token: 0x0600148D RID: 5261 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600148D")]
	[Address(RVA = "0xDDD664", Offset = "0xDDD664", VA = "0xDDD664")]
	public Player_OldSwitch()
	{
	}

	// Token: 0x0400293B RID: 10555
	[Token(Token = "0x400293B")]
	private const int PlayerFileVersion_GUID = 1000;

	// Token: 0x0400293C RID: 10556
	[Token(Token = "0x400293C")]
	private const int PlayerFileVersion_1_3_1 = 1001;

	// Token: 0x0400293D RID: 10557
	[Token(Token = "0x400293D")]
	private const int PlayerFileVersion_1_3_4 = 1002;

	// Token: 0x0400293E RID: 10558
	[Token(Token = "0x400293E")]
	private const int PlayerFileVersion_RemapENGINEItems = 1003;

	// Token: 0x0400293F RID: 10559
	[Token(Token = "0x400293F")]
	private const int PlayerFileVersion_RememberDPadShortcut = 1004;

	// Token: 0x04002940 RID: 10560
	[Token(Token = "0x4002940")]
	[FieldOffset(Offset = "0x0")]
	public static byte[] EncryptionKey;
}
