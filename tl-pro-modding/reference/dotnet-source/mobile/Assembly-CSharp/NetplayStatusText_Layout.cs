using System;
using Il2CppDummyDll;

// Token: 0x0200024C RID: 588
[Token(Token = "0x200024C")]
public class NetplayStatusText_Layout : LayoutDefinition
{
	// Token: 0x06000E4C RID: 3660 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E4C")]
	[Address(RVA = "0xC937F0", Offset = "0xC937F0", VA = "0xC937F0")]
	private void Awake()
	{
	}

	// Token: 0x06000E4D RID: 3661 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E4D")]
	[Address(RVA = "0xC93844", Offset = "0xC93844", VA = "0xC93844")]
	public NetplayStatusText_Layout()
	{
	}

	// Token: 0x04001ACC RID: 6860
	[Token(Token = "0x4001ACC")]
	[FieldOffset(Offset = "0x0")]
	public static NetplayStatusText_Layout Instance;

	// Token: 0x04001ACD RID: 6861
	[Token(Token = "0x4001ACD")]
	[FieldOffset(Offset = "0xC")]
	public String_Layout StatusText;

	// Token: 0x04001ACE RID: 6862
	[Token(Token = "0x4001ACE")]
	[FieldOffset(Offset = "0x10")]
	public string TestString;
}
