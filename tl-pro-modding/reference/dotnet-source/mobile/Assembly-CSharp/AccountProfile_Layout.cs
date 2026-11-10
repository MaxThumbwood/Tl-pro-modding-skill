using System;
using Il2CppDummyDll;

// Token: 0x0200020E RID: 526
[Token(Token = "0x200020E")]
public class AccountProfile_Layout : LayoutDefinition
{
	// Token: 0x06000DDC RID: 3548 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DDC")]
	[Address(RVA = "0xC8FB3C", Offset = "0xC8FB3C", VA = "0xC8FB3C")]
	private void Awake()
	{
	}

	// Token: 0x06000DDD RID: 3549 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DDD")]
	[Address(RVA = "0xC8FB90", Offset = "0xC8FB90", VA = "0xC8FB90")]
	public AccountProfile_Layout()
	{
	}

	// Token: 0x04001687 RID: 5767
	[Token(Token = "0x4001687")]
	[FieldOffset(Offset = "0x0")]
	public static AccountProfile_Layout Instance;

	// Token: 0x04001688 RID: 5768
	[Token(Token = "0x4001688")]
	[FieldOffset(Offset = "0xC")]
	public TransactionButton_Layout Profile;

	// Token: 0x04001689 RID: 5769
	[Token(Token = "0x4001689")]
	[FieldOffset(Offset = "0x10")]
	public Panel_Layout ProfileImage;

	// Token: 0x0400168A RID: 5770
	[Token(Token = "0x400168A")]
	[FieldOffset(Offset = "0x14")]
	public TransactionButton_Layout Settings;

	// Token: 0x0400168B RID: 5771
	[Token(Token = "0x400168B")]
	[FieldOffset(Offset = "0x18")]
	public Panel_Layout OnlineNotification;
}
