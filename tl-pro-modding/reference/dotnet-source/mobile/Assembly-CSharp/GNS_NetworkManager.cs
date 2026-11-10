using System;
using Il2CppDummyDll;

// Token: 0x020002FE RID: 766
[Token(Token = "0x20002FE")]
public class GNS_NetworkManager
{
	// Token: 0x060012ED RID: 4845 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012ED")]
	[Address(RVA = "0xD96B30", Offset = "0xD96B30", VA = "0xD96B30")]
	public void Startup()
	{
	}

	// Token: 0x060012EE RID: 4846 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012EE")]
	[Address(RVA = "0xD96C3C", Offset = "0xD96C3C", VA = "0xD96C3C")]
	public void Update()
	{
	}

	// Token: 0x060012EF RID: 4847 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012EF")]
	[Address(RVA = "0xD97430", Offset = "0xD97430", VA = "0xD97430")]
	public void Shutdown()
	{
	}

	// Token: 0x060012F0 RID: 4848 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012F0")]
	[Address(RVA = "0xD9752C", Offset = "0xD9752C", VA = "0xD9752C")]
	public GNS_NetworkManager()
	{
	}

	// Token: 0x04002525 RID: 9509
	[Token(Token = "0x4002525")]
	[FieldOffset(Offset = "0x8")]
	private bool started;

	// Token: 0x04002526 RID: 9510
	[Token(Token = "0x4002526")]
	[FieldOffset(Offset = "0x0")]
	public static GNS_NetworkManager Instance;

	// Token: 0x04002527 RID: 9511
	[Token(Token = "0x4002527")]
	[FieldOffset(Offset = "0x9")]
	public bool DisableTCPConnections;
}
