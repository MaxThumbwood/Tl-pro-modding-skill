using System;
using System.Net.Sockets;
using Il2CppDummyDll;

// Token: 0x020002F7 RID: 759
[Token(Token = "0x20002F7")]
public static class BackgroundSuspensionCheck
{
	// Token: 0x06001296 RID: 4758 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001296")]
	[Address(RVA = "0xD91A70", Offset = "0xD91A70", VA = "0xD91A70")]
	private static void NotifyNetworkDisconnection(object data)
	{
	}

	// Token: 0x06001297 RID: 4759 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001297")]
	[Address(RVA = "0xD91E38", Offset = "0xD91E38", VA = "0xD91E38")]
	private static void BroadcastRecieveThread()
	{
	}

	// Token: 0x06001298 RID: 4760 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001298")]
	[Address(RVA = "0xD92270", Offset = "0xD92270", VA = "0xD92270")]
	public static void StartChecking()
	{
	}

	// Token: 0x06001299 RID: 4761 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001299")]
	[Address(RVA = "0xD923A8", Offset = "0xD923A8", VA = "0xD923A8")]
	public static void StopChecking()
	{
	}

	// Token: 0x0400250D RID: 9485
	[Token(Token = "0x400250D")]
	private const SocketOptionName OnlyAllowIPv6 = SocketOptionName.IPv6Only;

	// Token: 0x0400250E RID: 9486
	[Token(Token = "0x400250E")]
	[FieldOffset(Offset = "0x0")]
	private static UdpClient broadcastPort;

	// Token: 0x0400250F RID: 9487
	[Token(Token = "0x400250F")]
	[FieldOffset(Offset = "0x4")]
	private static ManagedThread broadcastThread;
}
