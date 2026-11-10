using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using Il2CppDummyDll;

// Token: 0x02000324 RID: 804
[Token(Token = "0x2000324")]
public static class SaveSynchronisationBroadcast
{
	// Token: 0x060013E8 RID: 5096 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013E8")]
	[Address(RVA = "0xDAFBBC", Offset = "0xDAFBBC", VA = "0xDAFBBC")]
	public static List<IPAddress> BroadcastAdresses()
	{
		return null;
	}

	// Token: 0x060013E9 RID: 5097 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013E9")]
	[Address(RVA = "0xDAFD48", Offset = "0xDAFD48", VA = "0xDAFD48")]
	private static void BroadcastThread()
	{
	}

	// Token: 0x060013EA RID: 5098 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013EA")]
	[Address(RVA = "0xDB08F0", Offset = "0xDB08F0", VA = "0xDB08F0")]
	public static void StartBroadCasting()
	{
	}

	// Token: 0x060013EB RID: 5099 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013EB")]
	[Address(RVA = "0xDB0A54", Offset = "0xDB0A54", VA = "0xDB0A54")]
	public static void StopBroadCasting()
	{
	}

	// Token: 0x0400279F RID: 10143
	[Token(Token = "0x400279F")]
	[FieldOffset(Offset = "0x0")]
	private static UdpClient BroadcastClient;

	// Token: 0x040027A0 RID: 10144
	[Token(Token = "0x40027A0")]
	[FieldOffset(Offset = "0x4")]
	private static ManagedThread broadcastThread;

	// Token: 0x040027A1 RID: 10145
	[Token(Token = "0x40027A1")]
	[FieldOffset(Offset = "0x8")]
	private static List<IPAddress> BroadcastAddresses;
}
