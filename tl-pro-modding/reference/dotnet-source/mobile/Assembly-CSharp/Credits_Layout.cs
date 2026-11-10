using System;
using Il2CppDummyDll;

// Token: 0x02000210 RID: 528
[Token(Token = "0x2000210")]
public class Credits_Layout : LayoutDefinition
{
	// Token: 0x06000DE0 RID: 3552 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DE0")]
	[Address(RVA = "0xC8FCB4", Offset = "0xC8FCB4", VA = "0xC8FCB4")]
	private void Awake()
	{
	}

	// Token: 0x06000DE1 RID: 3553 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DE1")]
	[Address(RVA = "0xC8FD08", Offset = "0xC8FD08", VA = "0xC8FD08")]
	public Credits_Layout()
	{
	}

	// Token: 0x04001694 RID: 5780
	[Token(Token = "0x4001694")]
	[FieldOffset(Offset = "0x0")]
	public static Credits_Layout Instance;

	// Token: 0x04001695 RID: 5781
	[Token(Token = "0x4001695")]
	[FieldOffset(Offset = "0xC")]
	public StringButton_Layout Credits;

	// Token: 0x04001696 RID: 5782
	[Token(Token = "0x4001696")]
	[FieldOffset(Offset = "0x10")]
	public TransactionButton_Layout Back;
}
