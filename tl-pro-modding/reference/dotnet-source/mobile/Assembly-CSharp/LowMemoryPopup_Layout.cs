using System;
using Il2CppDummyDll;

// Token: 0x02000220 RID: 544
[Token(Token = "0x2000220")]
public class LowMemoryPopup_Layout : LayoutDefinition
{
	// Token: 0x06000E00 RID: 3584 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E00")]
	[Address(RVA = "0xC909C0", Offset = "0xC909C0", VA = "0xC909C0")]
	private void Awake()
	{
	}

	// Token: 0x06000E01 RID: 3585 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E01")]
	[Address(RVA = "0xC90A14", Offset = "0xC90A14", VA = "0xC90A14")]
	public LowMemoryPopup_Layout()
	{
	}

	// Token: 0x04001744 RID: 5956
	[Token(Token = "0x4001744")]
	[FieldOffset(Offset = "0x0")]
	public static LowMemoryPopup_Layout Instance;

	// Token: 0x04001745 RID: 5957
	[Token(Token = "0x4001745")]
	[FieldOffset(Offset = "0xC")]
	public StringButton_Layout Status;

	// Token: 0x04001746 RID: 5958
	[Token(Token = "0x4001746")]
	[FieldOffset(Offset = "0x10")]
	public TransactionButton_Layout Cancel;

	// Token: 0x04001747 RID: 5959
	[Token(Token = "0x4001747")]
	[FieldOffset(Offset = "0x14")]
	public TransactionButton_Layout Continue;
}
