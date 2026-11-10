using System;
using Il2CppDummyDll;

// Token: 0x02000229 RID: 553
[Token(Token = "0x2000229")]
public class NetPlayStatusMenu_Layout : LayoutDefinition
{
	// Token: 0x06000E11 RID: 3601 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E11")]
	[Address(RVA = "0xC91078", Offset = "0xC91078", VA = "0xC91078")]
	private void Awake()
	{
	}

	// Token: 0x06000E12 RID: 3602 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E12")]
	[Address(RVA = "0xC910CC", Offset = "0xC910CC", VA = "0xC910CC")]
	public NetPlayStatusMenu_Layout()
	{
	}

	// Token: 0x040017EB RID: 6123
	[Token(Token = "0x40017EB")]
	[FieldOffset(Offset = "0x0")]
	public static NetPlayStatusMenu_Layout Instance;

	// Token: 0x040017EC RID: 6124
	[Token(Token = "0x40017EC")]
	[FieldOffset(Offset = "0xC")]
	public StringButton_Layout Status;

	// Token: 0x040017ED RID: 6125
	[Token(Token = "0x40017ED")]
	[FieldOffset(Offset = "0x10")]
	public StringButton_Layout ServerStatus;

	// Token: 0x040017EE RID: 6126
	[Token(Token = "0x40017EE")]
	[FieldOffset(Offset = "0x14")]
	public Button_Layout SearchingIcon;

	// Token: 0x040017EF RID: 6127
	[Token(Token = "0x40017EF")]
	[FieldOffset(Offset = "0x18")]
	public TransactionButton_Layout Cancel;
}
