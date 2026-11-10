using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using Il2CppDummyDll;

// Token: 0x02000326 RID: 806
[Token(Token = "0x2000326")]
public static class SaveSynchronisationFinder
{
	// Token: 0x060013F4 RID: 5108 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013F4")]
	[Address(RVA = "0xDB2780", Offset = "0xDB2780", VA = "0xDB2780")]
	private static void BroadcastRecieveThread()
	{
	}

	// Token: 0x060013F5 RID: 5109 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013F5")]
	[Address(RVA = "0xDB3648", Offset = "0xDB3648", VA = "0xDB3648")]
	public static void UpdateResults()
	{
	}

	// Token: 0x060013F6 RID: 5110 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013F6")]
	[Address(RVA = "0xDB3C54", Offset = "0xDB3C54", VA = "0xDB3C54")]
	public static void StartSearching()
	{
	}

	// Token: 0x060013F7 RID: 5111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013F7")]
	[Address(RVA = "0xDB3E10", Offset = "0xDB3E10", VA = "0xDB3E10")]
	public static void StopSearching()
	{
	}

	// Token: 0x040027A4 RID: 10148
	[Token(Token = "0x40027A4")]
	[FieldOffset(Offset = "0x0")]
	private static List<SaveSynchronisationFinder.SearchServerResult> TempResults;

	// Token: 0x040027A5 RID: 10149
	[Token(Token = "0x40027A5")]
	[FieldOffset(Offset = "0x8")]
	private static DateTime LastListUpdate;

	// Token: 0x040027A6 RID: 10150
	[Token(Token = "0x40027A6")]
	[FieldOffset(Offset = "0x10")]
	public static List<SaveSynchronisationFinder.SearchServerResult> Results;

	// Token: 0x040027A7 RID: 10151
	[Token(Token = "0x40027A7")]
	private const SocketOptionName OnlyAllowIPv6 = SocketOptionName.IPv6Only;

	// Token: 0x040027A8 RID: 10152
	[Token(Token = "0x40027A8")]
	[FieldOffset(Offset = "0x14")]
	private static UdpClient broadcastPort;

	// Token: 0x040027A9 RID: 10153
	[Token(Token = "0x40027A9")]
	[FieldOffset(Offset = "0x18")]
	private static ManagedThread broadcastThread;

	// Token: 0x02000327 RID: 807
	[Token(Token = "0x2000327")]
	public class SearchServerResult
	{
		// Token: 0x060013F9 RID: 5113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013F9")]
		[Address(RVA = "0xDB3640", Offset = "0xDB3640", VA = "0xDB3640")]
		public SearchServerResult()
		{
		}

		// Token: 0x040027AA RID: 10154
		[Token(Token = "0x40027AA")]
		[FieldOffset(Offset = "0x8")]
		public IPAddress ServerAddress;

		// Token: 0x040027AB RID: 10155
		[Token(Token = "0x40027AB")]
		[FieldOffset(Offset = "0xC")]
		public string HostName;

		// Token: 0x040027AC RID: 10156
		[Token(Token = "0x40027AC")]
		[FieldOffset(Offset = "0x10")]
		public DrPlatform.DrPlatformType Platform;

		// Token: 0x040027AD RID: 10157
		[Token(Token = "0x40027AD")]
		[FieldOffset(Offset = "0x14")]
		public int PlayerFileCount;

		// Token: 0x040027AE RID: 10158
		[Token(Token = "0x40027AE")]
		[FieldOffset(Offset = "0x18")]
		public int WorldFileCount;

		// Token: 0x040027AF RID: 10159
		[Token(Token = "0x40027AF")]
		[FieldOffset(Offset = "0x20")]
		public DateTime LastRecieved;
	}
}
