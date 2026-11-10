using System;
using Il2CppDummyDll;

// Token: 0x02000217 RID: 535
[Token(Token = "0x2000217")]
public class GenericFullscreenMessage_Layout : LayoutDefinition
{
	// Token: 0x06000DEE RID: 3566 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DEE")]
	[Address(RVA = "0xC901D8", Offset = "0xC901D8", VA = "0xC901D8")]
	private void Awake()
	{
	}

	// Token: 0x06000DEF RID: 3567 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DEF")]
	[Address(RVA = "0xC9022C", Offset = "0xC9022C", VA = "0xC9022C")]
	public GenericFullscreenMessage_Layout()
	{
	}

	// Token: 0x040016D7 RID: 5847
	[Token(Token = "0x40016D7")]
	[FieldOffset(Offset = "0x0")]
	public static GenericFullscreenMessage_Layout Instance;

	// Token: 0x040016D8 RID: 5848
	[Token(Token = "0x40016D8")]
	[FieldOffset(Offset = "0xC")]
	public StringButton_Layout Status;

	// Token: 0x040016D9 RID: 5849
	[Token(Token = "0x40016D9")]
	[FieldOffset(Offset = "0x10")]
	public StringButton_Layout Status2;

	// Token: 0x040016DA RID: 5850
	[Token(Token = "0x40016DA")]
	[FieldOffset(Offset = "0x14")]
	public Button_Layout SearchingIcon;

	// Token: 0x040016DB RID: 5851
	[Token(Token = "0x40016DB")]
	[FieldOffset(Offset = "0x18")]
	public TransactionButton_Layout Back;

	// Token: 0x040016DC RID: 5852
	[Token(Token = "0x40016DC")]
	[FieldOffset(Offset = "0x1C")]
	public TransactionButton_Layout Cancel;
}
