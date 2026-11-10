using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using Il2CppDummyDll;

// Token: 0x02000332 RID: 818
[Token(Token = "0x2000332")]
public static class ServerAutoFinder
{
	// Token: 0x06001436 RID: 5174 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001436")]
	[Address(RVA = "0xDBB298", Offset = "0xDBB298", VA = "0xDBB298")]
	private static void BroadcastRecieveThread()
	{
	}

	// Token: 0x06001437 RID: 5175 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001437")]
	[Address(RVA = "0xDBC844", Offset = "0xDBC844", VA = "0xDBC844")]
	private static void LookForFriendPlatformGames()
	{
	}

	// Token: 0x06001438 RID: 5176 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001438")]
	[Address(RVA = "0xDBCF14", Offset = "0xDBCF14", VA = "0xDBCF14")]
	public static void UpdateResults()
	{
	}

	// Token: 0x06001439 RID: 5177 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001439")]
	[Address(RVA = "0xDBD764", Offset = "0xDBD764", VA = "0xDBD764")]
	public static void StartSearchingLAN()
	{
	}

	// Token: 0x0600143A RID: 5178 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600143A")]
	[Address(RVA = "0xDBDAF8", Offset = "0xDBDAF8", VA = "0xDBDAF8")]
	public static void StartSearching()
	{
	}

	// Token: 0x0600143B RID: 5179 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600143B")]
	[Address(RVA = "0xDBD974", Offset = "0xDBD974", VA = "0xDBD974")]
	public static void StopSearchingLAN()
	{
	}

	// Token: 0x0600143C RID: 5180 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600143C")]
	[Address(RVA = "0xDBDC80", Offset = "0xDBDC80", VA = "0xDBDC80")]
	public static void StopSearching()
	{
	}

	// Token: 0x040027E1 RID: 10209
	[Token(Token = "0x40027E1")]
	private const SocketOptionName OnlyAllowIPv6 = SocketOptionName.IPv6Only;

	// Token: 0x040027E2 RID: 10210
	[Token(Token = "0x40027E2")]
	[FieldOffset(Offset = "0x0")]
	private static UdpClient broadcastPort;

	// Token: 0x040027E3 RID: 10211
	[Token(Token = "0x40027E3")]
	[FieldOffset(Offset = "0x4")]
	private static ManagedThread broadcastThread;

	// Token: 0x040027E4 RID: 10212
	[Token(Token = "0x40027E4")]
	[FieldOffset(Offset = "0x8")]
	private static ManagedThread platformFriendGamesThread;

	// Token: 0x040027E5 RID: 10213
	[Token(Token = "0x40027E5")]
	[FieldOffset(Offset = "0xC")]
	private static List<ServerAutoFinder.SearchServerResult> TempResults;

	// Token: 0x040027E6 RID: 10214
	[Token(Token = "0x40027E6")]
	[FieldOffset(Offset = "0x10")]
	private static List<ServerAutoFinder.SearchServerResult> FriendResults;

	// Token: 0x040027E7 RID: 10215
	[Token(Token = "0x40027E7")]
	[FieldOffset(Offset = "0x18")]
	private static DateTime LastListUpdate;

	// Token: 0x040027E8 RID: 10216
	[Token(Token = "0x40027E8")]
	[FieldOffset(Offset = "0x20")]
	public static List<ServerAutoFinder.SearchServerResult> Results;

	// Token: 0x040027E9 RID: 10217
	[Token(Token = "0x40027E9")]
	[FieldOffset(Offset = "0x24")]
	public static List<ServerAutoFinder.SearchServerResult> DisplayFriendResults;

	// Token: 0x02000333 RID: 819
	[Token(Token = "0x2000333")]
	public class SearchServerResult
	{
		// Token: 0x0600143E RID: 5182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600143E")]
		[Address(RVA = "0xDBC83C", Offset = "0xDBC83C", VA = "0xDBC83C")]
		public SearchServerResult()
		{
		}

		// Token: 0x040027EA RID: 10218
		[Token(Token = "0x40027EA")]
		[FieldOffset(Offset = "0x8")]
		public string WorldName;

		// Token: 0x040027EB RID: 10219
		[Token(Token = "0x40027EB")]
		[FieldOffset(Offset = "0xC")]
		public IPAddress ServerAddress;

		// Token: 0x040027EC RID: 10220
		[Token(Token = "0x40027EC")]
		[FieldOffset(Offset = "0x10")]
		public int ServerPort;

		// Token: 0x040027ED RID: 10221
		[Token(Token = "0x40027ED")]
		[FieldOffset(Offset = "0x18")]
		public DateTime LastRecieved;

		// Token: 0x040027EE RID: 10222
		[Token(Token = "0x40027EE")]
		[FieldOffset(Offset = "0x20")]
		public ushort WorldXSize;

		// Token: 0x040027EF RID: 10223
		[Token(Token = "0x40027EF")]
		[FieldOffset(Offset = "0x24")]
		public int NumberOfPlayers;

		// Token: 0x040027F0 RID: 10224
		[Token(Token = "0x40027F0")]
		[FieldOffset(Offset = "0x28")]
		public int MaxPlayers;

		// Token: 0x040027F1 RID: 10225
		[Token(Token = "0x40027F1")]
		[FieldOffset(Offset = "0x2C")]
		public short GameMode;

		// Token: 0x040027F2 RID: 10226
		[Token(Token = "0x40027F2")]
		[FieldOffset(Offset = "0x2E")]
		public bool Corruption;

		// Token: 0x040027F3 RID: 10227
		[Token(Token = "0x40027F3")]
		[FieldOffset(Offset = "0x2F")]
		public bool HardMode;

		// Token: 0x040027F4 RID: 10228
		[Token(Token = "0x40027F4")]
		[FieldOffset(Offset = "0x30")]
		public bool Crossplay;

		// Token: 0x040027F5 RID: 10229
		[Token(Token = "0x40027F5")]
		[FieldOffset(Offset = "0x31")]
		public bool SkyWorld;

		// Token: 0x040027F6 RID: 10230
		[Token(Token = "0x40027F6")]
		[FieldOffset(Offset = "0x34")]
		public string HostName;

		// Token: 0x040027F7 RID: 10231
		[Token(Token = "0x40027F7")]
		[FieldOffset(Offset = "0x38")]
		public MPSessionManager.MPSessionFriendSearchEntry SourceSession;
	}
}
