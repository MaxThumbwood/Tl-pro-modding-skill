using System;
using Il2CppDummyDll;

// Token: 0x0200022D RID: 557
[Token(Token = "0x200022D")]
public class PlayerName_Layout : LayoutDefinition
{
	// Token: 0x06000E19 RID: 3609 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E19")]
	[Address(RVA = "0xC914BC", Offset = "0xC914BC", VA = "0xC914BC")]
	private void Awake()
	{
	}

	// Token: 0x06000E1A RID: 3610 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E1A")]
	[Address(RVA = "0xC91510", Offset = "0xC91510", VA = "0xC91510")]
	public PlayerName_Layout()
	{
	}

	// Token: 0x04001848 RID: 6216
	[Token(Token = "0x4001848")]
	[FieldOffset(Offset = "0x0")]
	public static PlayerName_Layout Instance;

	// Token: 0x04001849 RID: 6217
	[Token(Token = "0x4001849")]
	[FieldOffset(Offset = "0xC")]
	public String_Layout Title;

	// Token: 0x0400184A RID: 6218
	[Token(Token = "0x400184A")]
	[FieldOffset(Offset = "0x10")]
	public String_Layout InputCharacterName;
}
