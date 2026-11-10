using System;
using Il2CppDummyDll;

// Token: 0x02000221 RID: 545
[Token(Token = "0x2000221")]
public class LowMemorySettings_Layout : LayoutDefinition
{
	// Token: 0x06000E02 RID: 3586 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E02")]
	[Address(RVA = "0xC90A7C", Offset = "0xC90A7C", VA = "0xC90A7C")]
	private void Awake()
	{
	}

	// Token: 0x06000E03 RID: 3587 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E03")]
	[Address(RVA = "0xC90AD0", Offset = "0xC90AD0", VA = "0xC90AD0")]
	public LowMemorySettings_Layout()
	{
	}

	// Token: 0x04001748 RID: 5960
	[Token(Token = "0x4001748")]
	[FieldOffset(Offset = "0x0")]
	public static LowMemorySettings_Layout Instance;

	// Token: 0x04001749 RID: 5961
	[Token(Token = "0x4001749")]
	[FieldOffset(Offset = "0xC")]
	public StringButton_Layout Status;

	// Token: 0x0400174A RID: 5962
	[Token(Token = "0x400174A")]
	[FieldOffset(Offset = "0x10")]
	public TransactionButton_Layout Cancel;

	// Token: 0x0400174B RID: 5963
	[Token(Token = "0x400174B")]
	[FieldOffset(Offset = "0x14")]
	public TransactionButton_Layout Continue;
}
