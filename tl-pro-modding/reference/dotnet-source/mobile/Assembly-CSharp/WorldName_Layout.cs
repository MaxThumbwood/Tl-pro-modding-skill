using System;
using Il2CppDummyDll;

// Token: 0x02000249 RID: 585
[Token(Token = "0x2000249")]
public class WorldName_Layout : LayoutDefinition
{
	// Token: 0x06000E45 RID: 3653 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E45")]
	[Address(RVA = "0xC9343C", Offset = "0xC9343C", VA = "0xC9343C")]
	private void Awake()
	{
	}

	// Token: 0x06000E46 RID: 3654 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E46")]
	[Address(RVA = "0xC93490", Offset = "0xC93490", VA = "0xC93490")]
	public WorldName_Layout()
	{
	}

	// Token: 0x04001A92 RID: 6802
	[Token(Token = "0x4001A92")]
	[FieldOffset(Offset = "0x0")]
	public static WorldName_Layout Instance;

	// Token: 0x04001A93 RID: 6803
	[Token(Token = "0x4001A93")]
	[FieldOffset(Offset = "0xC")]
	public String_Layout Title;

	// Token: 0x04001A94 RID: 6804
	[Token(Token = "0x4001A94")]
	[FieldOffset(Offset = "0x10")]
	public String_Layout InputWorldName;
}
