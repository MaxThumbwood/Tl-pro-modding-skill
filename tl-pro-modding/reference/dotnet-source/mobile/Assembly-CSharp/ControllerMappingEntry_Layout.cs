using System;
using Il2CppDummyDll;

// Token: 0x020001BB RID: 443
[Token(Token = "0x20001BB")]
[Serializable]
public class ControllerMappingEntry_Layout
{
	// Token: 0x06000C9E RID: 3230 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C9E")]
	[Address(RVA = "0xC68300", Offset = "0xC68300", VA = "0xC68300")]
	public ControllerMappingEntry_Layout()
	{
	}

	// Token: 0x04001121 RID: 4385
	[Token(Token = "0x4001121")]
	[FieldOffset(Offset = "0x8")]
	public TransactionButton_Layout PulldownButton;

	// Token: 0x04001122 RID: 4386
	[Token(Token = "0x4001122")]
	[FieldOffset(Offset = "0xC")]
	public String_Layout PulldownTitle;

	// Token: 0x04001123 RID: 4387
	[Token(Token = "0x4001123")]
	[FieldOffset(Offset = "0x10")]
	public Panel_Layout PulldownGreyout;

	// Token: 0x04001124 RID: 4388
	[Token(Token = "0x4001124")]
	[FieldOffset(Offset = "0x14")]
	public TransactionButton_Layout Action;

	// Token: 0x04001125 RID: 4389
	[Token(Token = "0x4001125")]
	[FieldOffset(Offset = "0x18")]
	public TransactionButton_Layout ActionMultiple;

	// Token: 0x04001126 RID: 4390
	[Token(Token = "0x4001126")]
	[FieldOffset(Offset = "0x1C")]
	public String_Layout Unbound;

	// Token: 0x04001127 RID: 4391
	[Token(Token = "0x4001127")]
	[FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout Cancel;

	// Token: 0x04001128 RID: 4392
	[Token(Token = "0x4001128")]
	[FieldOffset(Offset = "0x24")]
	public float ElementSpacing;
}
