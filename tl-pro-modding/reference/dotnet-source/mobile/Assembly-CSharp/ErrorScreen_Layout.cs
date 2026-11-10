using System;
using Il2CppDummyDll;

// Token: 0x02000215 RID: 533
[Token(Token = "0x2000215")]
public class ErrorScreen_Layout : LayoutDefinition
{
	// Token: 0x06000DEA RID: 3562 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DEA")]
	[Address(RVA = "0xC90060", Offset = "0xC90060", VA = "0xC90060")]
	private void Awake()
	{
	}

	// Token: 0x06000DEB RID: 3563 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DEB")]
	[Address(RVA = "0xC900B4", Offset = "0xC900B4", VA = "0xC900B4")]
	public ErrorScreen_Layout()
	{
	}

	// Token: 0x040016CF RID: 5839
	[Token(Token = "0x40016CF")]
	[FieldOffset(Offset = "0x0")]
	public static ErrorScreen_Layout Instance;

	// Token: 0x040016D0 RID: 5840
	[Token(Token = "0x40016D0")]
	[FieldOffset(Offset = "0xC")]
	public StringButton_Layout Status;

	// Token: 0x040016D1 RID: 5841
	[Token(Token = "0x40016D1")]
	[FieldOffset(Offset = "0x10")]
	public TransactionButton_Layout Back;
}
