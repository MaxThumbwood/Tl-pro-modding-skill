using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

// Token: 0x020002FB RID: 763
[Token(Token = "0x20002FB")]
public static class GNS_API
{
	// Token: 0x060012B2 RID: 4786
	[Token(Token = "0x60012B2")]
	[Address(RVA = "0xD92EE0", Offset = "0xD92EE0", VA = "0xD92EE0")]
	[PreserveSig]
	private static extern void GNS_Startup();

	// Token: 0x060012B3 RID: 4787
	[Token(Token = "0x60012B3")]
	[Address(RVA = "0xD92F70", Offset = "0xD92F70", VA = "0xD92F70")]
	[PreserveSig]
	private static extern void GNS_Shutdown();

	// Token: 0x060012B4 RID: 4788
	[Token(Token = "0x60012B4")]
	[Address(RVA = "0xD93000", Offset = "0xD93000", VA = "0xD93000")]
	[PreserveSig]
	private unsafe static extern uint GNS_Recieve(byte* transportBuffer, ref int resultSize, int maxTransportSize);

	// Token: 0x060012B5 RID: 4789
	[Token(Token = "0x60012B5")]
	[Address(RVA = "0xD930B0", Offset = "0xD930B0", VA = "0xD930B0")]
	[PreserveSig]
	private unsafe static extern int GNS_ConnectionEvents(uint* eventBuffer, int maxEventSize);

	// Token: 0x060012B6 RID: 4790
	[Token(Token = "0x60012B6")]
	[Address(RVA = "0xD93150", Offset = "0xD93150", VA = "0xD93150")]
	[PreserveSig]
	private static extern uint GNS_Listen(int port);

	// Token: 0x060012B7 RID: 4791
	[Token(Token = "0x60012B7")]
	[Address(RVA = "0xD931F0", Offset = "0xD931F0", VA = "0xD931F0")]
	[PreserveSig]
	private static extern void GNS_CloseListen(uint socket);

	// Token: 0x060012B8 RID: 4792
	[Token(Token = "0x60012B8")]
	[Address(RVA = "0xD93290", Offset = "0xD93290", VA = "0xD93290")]
	[PreserveSig]
	private static extern uint GNS_ConnectString(string addr);

	// Token: 0x060012B9 RID: 4793
	[Token(Token = "0x60012B9")]
	[Address(RVA = "0xD93360", Offset = "0xD93360", VA = "0xD93360")]
	[PreserveSig]
	private static extern void GNS_CloseSocket(uint socket);

	// Token: 0x060012BA RID: 4794
	[Token(Token = "0x60012BA")]
	[Address(RVA = "0xD93400", Offset = "0xD93400", VA = "0xD93400")]
	[PreserveSig]
	private unsafe static extern void GNS_SocketSend(uint socket, byte* sendBuffer, int sendAmount);

	// Token: 0x060012BB RID: 4795 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012BB")]
	[Address(RVA = "0xD934B0", Offset = "0xD934B0", VA = "0xD934B0")]
	public static void Startup()
	{
	}

	// Token: 0x060012BC RID: 4796 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012BC")]
	[Address(RVA = "0xD935A0", Offset = "0xD935A0", VA = "0xD935A0")]
	public static void Shutdown()
	{
	}

	// Token: 0x060012BD RID: 4797 RVA: 0x000088F8 File Offset: 0x00006AF8
	[Token(Token = "0x60012BD")]
	[Address(RVA = "0xD93690", Offset = "0xD93690", VA = "0xD93690")]
	public unsafe static uint Recieve(byte* transportBuffer, ref int resultSize, int maxTransportSize)
	{
		return 0U;
	}

	// Token: 0x060012BE RID: 4798 RVA: 0x00008910 File Offset: 0x00006B10
	[Token(Token = "0x60012BE")]
	[Address(RVA = "0xD937A0", Offset = "0xD937A0", VA = "0xD937A0")]
	public unsafe static int ConnectionEvents(uint* eventBuffer, int maxEventSize)
	{
		return 0;
	}

	// Token: 0x060012BF RID: 4799 RVA: 0x00008928 File Offset: 0x00006B28
	[Token(Token = "0x60012BF")]
	[Address(RVA = "0xD938A0", Offset = "0xD938A0", VA = "0xD938A0")]
	public static uint Listen(int port)
	{
		return 0U;
	}

	// Token: 0x060012C0 RID: 4800 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C0")]
	[Address(RVA = "0xD939A0", Offset = "0xD939A0", VA = "0xD939A0")]
	public static void CloseListen(uint socket)
	{
	}

	// Token: 0x060012C1 RID: 4801 RVA: 0x00008940 File Offset: 0x00006B40
	[Token(Token = "0x60012C1")]
	[Address(RVA = "0xD93A90", Offset = "0xD93A90", VA = "0xD93A90")]
	public static uint ConnectString(string addr)
	{
		return 0U;
	}

	// Token: 0x060012C2 RID: 4802 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C2")]
	[Address(RVA = "0xD93BA0", Offset = "0xD93BA0", VA = "0xD93BA0")]
	public static void CloseSocket(uint socket)
	{
	}

	// Token: 0x060012C3 RID: 4803 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C3")]
	[Address(RVA = "0xD93C90", Offset = "0xD93C90", VA = "0xD93C90")]
	public unsafe static void SocketSend(uint socket, byte* sendBuffer, int sendAmount)
	{
	}

	// Token: 0x0400251A RID: 9498
	[Token(Token = "0x400251A")]
	internal const string DllName = "GNS_Wrapper";

	// Token: 0x0400251B RID: 9499
	[Token(Token = "0x400251B")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool Started;
}
