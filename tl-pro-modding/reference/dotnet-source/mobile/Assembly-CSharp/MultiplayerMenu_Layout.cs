using System;
using Il2CppDummyDll;

// Token: 0x02000228 RID: 552
[Token(Token = "0x2000228")]
public class MultiplayerMenu_Layout : LayoutDefinition
{
	// Token: 0x06000E0F RID: 3599 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E0F")]
	[Address(RVA = "0xC90FBC", Offset = "0xC90FBC", VA = "0xC90FBC")]
	private void Awake()
	{
	}

	// Token: 0x06000E10 RID: 3600 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E10")]
	[Address(RVA = "0xC91010", Offset = "0xC91010", VA = "0xC91010")]
	public MultiplayerMenu_Layout()
	{
	}

	// Token: 0x040017E7 RID: 6119
	[Token(Token = "0x40017E7")]
	[FieldOffset(Offset = "0x0")]
	public static MultiplayerMenu_Layout Instance;

	// Token: 0x040017E8 RID: 6120
	[Token(Token = "0x40017E8")]
	[FieldOffset(Offset = "0xC")]
	public StringButton_Layout Join;

	// Token: 0x040017E9 RID: 6121
	[Token(Token = "0x40017E9")]
	[FieldOffset(Offset = "0x10")]
	public StringButton_Layout HostAndPlay;

	// Token: 0x040017EA RID: 6122
	[Token(Token = "0x40017EA")]
	[FieldOffset(Offset = "0x14")]
	public StringButton_Layout Back;
}
