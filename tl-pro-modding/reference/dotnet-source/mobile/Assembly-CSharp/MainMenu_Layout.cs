using System;
using Il2CppDummyDll;

// Token: 0x02000222 RID: 546
[Token(Token = "0x2000222")]
public class MainMenu_Layout : LayoutDefinition
{
	// Token: 0x06000E04 RID: 3588 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E04")]
	[Address(RVA = "0xC90B38", Offset = "0xC90B38", VA = "0xC90B38")]
	private void Awake()
	{
	}

	// Token: 0x06000E05 RID: 3589 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E05")]
	[Address(RVA = "0xC90B8C", Offset = "0xC90B8C", VA = "0xC90B8C")]
	public MainMenu_Layout()
	{
	}

	// Token: 0x0400174C RID: 5964
	[Token(Token = "0x400174C")]
	[FieldOffset(Offset = "0x0")]
	public static MainMenu_Layout Instance;

	// Token: 0x0400174D RID: 5965
	[Token(Token = "0x400174D")]
	[FieldOffset(Offset = "0xC")]
	public Panel_Layout Backing;

	// Token: 0x0400174E RID: 5966
	[Token(Token = "0x400174E")]
	[FieldOffset(Offset = "0x10")]
	public TransactionButton_Layout Singleplayer;

	// Token: 0x0400174F RID: 5967
	[Token(Token = "0x400174F")]
	[FieldOffset(Offset = "0x14")]
	public TransactionButton_Layout Multiplayer;

	// Token: 0x04001750 RID: 5968
	[Token(Token = "0x4001750")]
	[FieldOffset(Offset = "0x18")]
	public TransactionButton_Layout Achievements;

	// Token: 0x04001751 RID: 5969
	[Token(Token = "0x4001751")]
	[FieldOffset(Offset = "0x1C")]
	public TransactionButton_Layout Settings;

	// Token: 0x04001752 RID: 5970
	[Token(Token = "0x4001752")]
	[FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout Tutorial;

	// Token: 0x04001753 RID: 5971
	[Token(Token = "0x4001753")]
	[FieldOffset(Offset = "0x24")]
	public TransactionButton_Layout Credits;

	// Token: 0x04001754 RID: 5972
	[Token(Token = "0x4001754")]
	[FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout PurchaseFullGame;

	// Token: 0x04001755 RID: 5973
	[Token(Token = "0x4001755")]
	[FieldOffset(Offset = "0x2C")]
	public TransactionButton_Layout ExitGame;

	// Token: 0x04001756 RID: 5974
	[Token(Token = "0x4001756")]
	[FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout PlayerProfile;

	// Token: 0x04001757 RID: 5975
	[Token(Token = "0x4001757")]
	[FieldOffset(Offset = "0x34")]
	public String_Layout VersionNumber;

	// Token: 0x04001758 RID: 5976
	[Token(Token = "0x4001758")]
	[FieldOffset(Offset = "0x38")]
	public string VersionNumberText;

	// Token: 0x04001759 RID: 5977
	[Token(Token = "0x4001759")]
	[FieldOffset(Offset = "0x3C")]
	public String_Layout Copyright;

	// Token: 0x0400175A RID: 5978
	[Token(Token = "0x400175A")]
	[FieldOffset(Offset = "0x40")]
	public string CopyrightText;
}
