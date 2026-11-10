using System;
using Il2CppDummyDll;

// Token: 0x02000254 RID: 596
[Token(Token = "0x2000254")]
public class PurchaseChecker_Layout : LayoutDefinition
{
	// Token: 0x06000E5E RID: 3678 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E5E")]
	[Address(RVA = "0xC93D94", Offset = "0xC93D94", VA = "0xC93D94")]
	private void Awake()
	{
	}

	// Token: 0x06000E5F RID: 3679 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E5F")]
	[Address(RVA = "0xC93DE8", Offset = "0xC93DE8", VA = "0xC93DE8")]
	public PurchaseChecker_Layout()
	{
	}

	// Token: 0x04001BA8 RID: 7080
	[Token(Token = "0x4001BA8")]
	[FieldOffset(Offset = "0x0")]
	public static PurchaseChecker_Layout Instance;

	// Token: 0x04001BA9 RID: 7081
	[Token(Token = "0x4001BA9")]
	[FieldOffset(Offset = "0xC")]
	public String_Layout Information;

	// Token: 0x04001BAA RID: 7082
	[Token(Token = "0x4001BAA")]
	[FieldOffset(Offset = "0x10")]
	public TransactionButton_Layout Retry;

	// Token: 0x04001BAB RID: 7083
	[Token(Token = "0x4001BAB")]
	[FieldOffset(Offset = "0x14")]
	public TransactionButton_Layout Store;

	// Token: 0x04001BAC RID: 7084
	[Token(Token = "0x4001BAC")]
	[FieldOffset(Offset = "0x18")]
	public Button_Layout SearchingIcon;
}
