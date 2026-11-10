using System;
using Il2CppDummyDll;

// Token: 0x02000240 RID: 576
[Token(Token = "0x2000240")]
public class StatusMenu_Layout : LayoutDefinition
{
	// Token: 0x06000E35 RID: 3637 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E35")]
	[Address(RVA = "0xC92D68", Offset = "0xC92D68", VA = "0xC92D68")]
	private void Awake()
	{
	}

	// Token: 0x06000E36 RID: 3638 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E36")]
	[Address(RVA = "0xC92DBC", Offset = "0xC92DBC", VA = "0xC92DBC")]
	public StatusMenu_Layout()
	{
	}

	// Token: 0x040019D1 RID: 6609
	[Token(Token = "0x40019D1")]
	[FieldOffset(Offset = "0x0")]
	public static StatusMenu_Layout Instance;

	// Token: 0x040019D2 RID: 6610
	[Token(Token = "0x40019D2")]
	[FieldOffset(Offset = "0xC")]
	public StringButton_Layout Status;

	// Token: 0x040019D3 RID: 6611
	[Token(Token = "0x40019D3")]
	[FieldOffset(Offset = "0x10")]
	public String_Layout GameTip;
}
