using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Il2CppDummyDll;
using Terraria.Net;

namespace Terraria
{
	// Token: 0x02000481 RID: 1153
	[Token(Token = "0x2000481")]
	public class Netplay
	{
		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x060025F7 RID: 9719 RVA: 0x000121E0 File Offset: 0x000103E0
		// (set) Token: 0x060025F8 RID: 9720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000567")]
		public static bool UseUPNP
		{
			[Token(Token = "0x60025F7")]
			[Address(RVA = "0x15F4C54", Offset = "0x15F4C54", VA = "0x15F4C54")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60025F8")]
			[Address(RVA = "0x15F4CBC", Offset = "0x15F4CBC", VA = "0x15F4CBC")]
			set
			{
			}
		}

		// Token: 0x1400002A RID: 42
		// (add) Token: 0x060025F9 RID: 9721 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060025FA RID: 9722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400002A")]
		public static event Action OnDisconnect
		{
			[Token(Token = "0x60025F9")]
			[Address(RVA = "0x15F4D28", Offset = "0x15F4D28", VA = "0x15F4D28")]
			add
			{
			}
			[Token(Token = "0x60025FA")]
			[Address(RVA = "0x15F4E2C", Offset = "0x15F4E2C", VA = "0x15F4E2C")]
			remove
			{
			}
		}

		// Token: 0x060025FB RID: 9723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025FB")]
		[Address(RVA = "0x15F4F30", Offset = "0x15F4F30", VA = "0x15F4F30")]
		private static string GetLocalIPAddress()
		{
			return null;
		}

		// Token: 0x060025FC RID: 9724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025FC")]
		[Address(RVA = "0x15F50F8", Offset = "0x15F50F8", VA = "0x15F50F8")]
		public static void ResetNetDiag()
		{
		}

		// Token: 0x060025FD RID: 9725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025FD")]
		[Address(RVA = "0x15F51E4", Offset = "0x15F51E4", VA = "0x15F51E4")]
		public static void ResetSections()
		{
		}

		// Token: 0x060025FE RID: 9726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025FE")]
		[Address(RVA = "0x15F5330", Offset = "0x15F5330", VA = "0x15F5330")]
		public static void AddBan(int plr)
		{
		}

		// Token: 0x060025FF RID: 9727 RVA: 0x000121F8 File Offset: 0x000103F8
		[Token(Token = "0x60025FF")]
		[Address(RVA = "0x15F55D8", Offset = "0x15F55D8", VA = "0x15F55D8")]
		public static bool IsBanned(int plr)
		{
			return default(bool);
		}

		// Token: 0x06002600 RID: 9728 RVA: 0x00012210 File Offset: 0x00010410
		[Token(Token = "0x6002600")]
		[Address(RVA = "0x15F5A88", Offset = "0x15F5A88", VA = "0x15F5A88")]
		public static int AddNewEditServerToList()
		{
			return 0;
		}

		// Token: 0x06002601 RID: 9729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002601")]
		[Address(RVA = "0x15F5C6C", Offset = "0x15F5C6C", VA = "0x15F5C6C")]
		public static void AddCurrentServerToRecentList()
		{
		}

		// Token: 0x06002602 RID: 9730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002602")]
		[Address(RVA = "0x15F62DC", Offset = "0x15F62DC", VA = "0x15F62DC")]
		public static void DeleteDedicatedServer(int index)
		{
		}

		// Token: 0x06002603 RID: 9731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002603")]
		[Address(RVA = "0x15F641C", Offset = "0x15F641C", VA = "0x15F641C")]
		public static void deleteDedicatedServer(string ip, int port)
		{
		}

		// Token: 0x06002604 RID: 9732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002604")]
		[Address(RVA = "0x15F6684", Offset = "0x15F6684", VA = "0x15F6684")]
		public static void SocialClientLoop(object threadContext)
		{
		}

		// Token: 0x06002605 RID: 9733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002605")]
		[Address(RVA = "0x15F6688", Offset = "0x15F6688", VA = "0x15F6688")]
		public static void TcpLocalClientLoop(object threadContext)
		{
		}

		// Token: 0x06002606 RID: 9734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002606")]
		[Address(RVA = "0x15F7880", Offset = "0x15F7880", VA = "0x15F7880")]
		public static void TcpClientLoop(object threadContext)
		{
		}

		// Token: 0x06002607 RID: 9735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002607")]
		[Address(RVA = "0x15F6BF8", Offset = "0x15F6BF8", VA = "0x15F6BF8")]
		private static void ClientServerLoopSetup(RemoteAddress address)
		{
		}

		// Token: 0x06002608 RID: 9736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002608")]
		[Address(RVA = "0x15F8460", Offset = "0x15F8460", VA = "0x15F8460")]
		private static void ClientLoopSetup(RemoteAddress address)
		{
		}

		// Token: 0x06002609 RID: 9737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002609")]
		[Address(RVA = "0x15F891C", Offset = "0x15F891C", VA = "0x15F891C")]
		public static void ClientUpdateFrame()
		{
		}

		// Token: 0x0600260A RID: 9738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600260A")]
		[Address(RVA = "0x15F8CD8", Offset = "0x15F8CD8", VA = "0x15F8CD8")]
		public static void ServerUpdateFrame()
		{
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x0600260B RID: 9739 RVA: 0x00012228 File Offset: 0x00010428
		[Token(Token = "0x17000568")]
		public static bool AllowPlatformCrossPlay
		{
			[Token(Token = "0x600260B")]
			[Address(RVA = "0x15F9248", Offset = "0x15F9248", VA = "0x15F9248")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x0600260C RID: 9740 RVA: 0x00012240 File Offset: 0x00010440
		[Token(Token = "0x17000569")]
		public static bool AllowPlatformCrossPlayAndNetworkAvailable
		{
			[Token(Token = "0x600260C")]
			[Address(RVA = "0x15F9324", Offset = "0x15F9324", VA = "0x15F9324")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x0600260D RID: 9741 RVA: 0x00012258 File Offset: 0x00010458
		[Token(Token = "0x1700056A")]
		public static bool AllowPlatformCrossPlayAndNetworkAvailableAndHostAllows
		{
			[Token(Token = "0x600260D")]
			[Address(RVA = "0x15F9388", Offset = "0x15F9388", VA = "0x15F9388")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600260E RID: 9742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600260E")]
		[Address(RVA = "0x15F949C", Offset = "0x15F949C", VA = "0x15F949C")]
		public static void UpdateClientNet()
		{
		}

		// Token: 0x0600260F RID: 9743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600260F")]
		[Address(RVA = "0x15F9784", Offset = "0x15F9784", VA = "0x15F9784")]
		public static void ClientLoopFrameUpdate()
		{
		}

		// Token: 0x06002610 RID: 9744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002610")]
		[Address(RVA = "0x15F6F10", Offset = "0x15F6F10", VA = "0x15F6F10")]
		private static void InnerClientLoop()
		{
		}

		// Token: 0x06002611 RID: 9745 RVA: 0x00012270 File Offset: 0x00010470
		[Token(Token = "0x6002611")]
		[Address(RVA = "0x15FA998", Offset = "0x15FA998", VA = "0x15FA998")]
		private static int FindNextOpenClientSlot()
		{
			return 0;
		}

		// Token: 0x06002612 RID: 9746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002612")]
		[Address(RVA = "0x15F9110", Offset = "0x15F9110", VA = "0x15F9110")]
		private static void OnConnectionAccepted(int clientId)
		{
		}

		// Token: 0x06002613 RID: 9747 RVA: 0x00012288 File Offset: 0x00010488
		[Token(Token = "0x6002613")]
		[Address(RVA = "0x15FA9A0", Offset = "0x15FA9A0", VA = "0x15FA9A0")]
		private static bool StartListening()
		{
			return default(bool);
		}

		// Token: 0x06002614 RID: 9748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002614")]
		[Address(RVA = "0x15FAA3C", Offset = "0x15FAA3C", VA = "0x15FAA3C")]
		private static void StopListening()
		{
		}

		// Token: 0x06002615 RID: 9749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002615")]
		[Address(RVA = "0x15FAAC8", Offset = "0x15FAAC8", VA = "0x15FAAC8")]
		public static List<IPAddress> BroadcastAdresses()
		{
			return null;
		}

		// Token: 0x06002616 RID: 9750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002616")]
		[Address(RVA = "0x15FAC54", Offset = "0x15FAC54", VA = "0x15FAC54")]
		private static void BroadcastThread()
		{
		}

		// Token: 0x06002617 RID: 9751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002617")]
		[Address(RVA = "0x15FBF6C", Offset = "0x15FBF6C", VA = "0x15FBF6C")]
		public static void StartBroadCasting()
		{
		}

		// Token: 0x06002618 RID: 9752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002618")]
		[Address(RVA = "0x15FC5E8", Offset = "0x15FC5E8", VA = "0x15FC5E8")]
		public static void StopBroadCasting()
		{
		}

		// Token: 0x06002619 RID: 9753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002619")]
		[Address(RVA = "0x15FC728", Offset = "0x15FC728", VA = "0x15FC728")]
		public static void ServerLoopUpdateFrame()
		{
		}

		// Token: 0x0600261A RID: 9754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600261A")]
		[Address(RVA = "0x15FCE04", Offset = "0x15FCE04", VA = "0x15FCE04")]
		public static void ServerLoop(object threadContext)
		{
		}

		// Token: 0x0600261B RID: 9755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600261B")]
		[Address(RVA = "0x15FE078", Offset = "0x15FE078", VA = "0x15FE078")]
		public static void StartTcpClient(bool connectingToLocalServer)
		{
		}

		// Token: 0x0600261C RID: 9756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600261C")]
		[Address(RVA = "0x15FE28C", Offset = "0x15FE28C", VA = "0x15FE28C")]
		public static void StartServer()
		{
		}

		// Token: 0x0600261D RID: 9757 RVA: 0x000122A0 File Offset: 0x000104A0
		[Token(Token = "0x600261D")]
		[Address(RVA = "0x15FE4C0", Offset = "0x15FE4C0", VA = "0x15FE4C0")]
		public static bool SetRemoteIP(string remoteAddress)
		{
			return default(bool);
		}

		// Token: 0x0600261E RID: 9758 RVA: 0x000122B8 File Offset: 0x000104B8
		[Token(Token = "0x600261E")]
		[Address(RVA = "0x15FE524", Offset = "0x15FE524", VA = "0x15FE524")]
		public static bool SetRemoteIPOld(string remoteAddress)
		{
			return default(bool);
		}

		// Token: 0x0600261F RID: 9759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600261F")]
		[Address(RVA = "0x15FE66C", Offset = "0x15FE66C", VA = "0x15FE66C")]
		public static void Initialize()
		{
		}

		// Token: 0x06002620 RID: 9760 RVA: 0x000122D0 File Offset: 0x000104D0
		[Token(Token = "0x6002620")]
		[Address(RVA = "0x15FE888", Offset = "0x15FE888", VA = "0x15FE888")]
		public static int GetSectionX(int x)
		{
			return 0;
		}

		// Token: 0x06002621 RID: 9761 RVA: 0x000122E8 File Offset: 0x000104E8
		[Token(Token = "0x6002621")]
		[Address(RVA = "0x15FE8A0", Offset = "0x15FE8A0", VA = "0x15FE8A0")]
		public static int GetSectionY(int y)
		{
			return 0;
		}

		// Token: 0x06002622 RID: 9762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002622")]
		[Address(RVA = "0x15FE8B8", Offset = "0x15FE8B8", VA = "0x15FE8B8")]
		public Netplay()
		{
		}

		// Token: 0x040036D3 RID: 14035
		[Token(Token = "0x40036D3")]
		[FieldOffset(Offset = "0x0")]
		public static string CrossplaySessionId;

		// Token: 0x040036D4 RID: 14036
		[Token(Token = "0x40036D4")]
		[FieldOffset(Offset = "0x4")]
		public static string BanFilePath;

		// Token: 0x040036D5 RID: 14037
		[Token(Token = "0x40036D5")]
		[FieldOffset(Offset = "0x8")]
		public static string ServerPassword;

		// Token: 0x040036D6 RID: 14038
		[Token(Token = "0x40036D6")]
		[FieldOffset(Offset = "0xC")]
		public static RemoteClient[] Clients;

		// Token: 0x040036D7 RID: 14039
		[Token(Token = "0x40036D7")]
		[FieldOffset(Offset = "0x10")]
		public static RemoteConnection Connection;

		// Token: 0x040036D8 RID: 14040
		[Token(Token = "0x40036D8")]
		[FieldOffset(Offset = "0x14")]
		public static RemoteServer Server;

		// Token: 0x040036D9 RID: 14041
		[Token(Token = "0x40036D9")]
		[FieldOffset(Offset = "0x18")]
		public static IPAddress ServerIP;

		// Token: 0x040036DA RID: 14042
		[Token(Token = "0x40036DA")]
		[FieldOffset(Offset = "0x1C")]
		public static string ServerIPText;

		// Token: 0x040036DB RID: 14043
		[Token(Token = "0x40036DB")]
		[FieldOffset(Offset = "0x20")]
		public static string HostToken;

		// Token: 0x040036DC RID: 14044
		[Token(Token = "0x40036DC")]
		[FieldOffset(Offset = "0x24")]
		public static int ListenPort;

		// Token: 0x040036DD RID: 14045
		[Token(Token = "0x40036DD")]
		[FieldOffset(Offset = "0x28")]
		public static bool IsServerRunning;

		// Token: 0x040036DE RID: 14046
		[Token(Token = "0x40036DE")]
		[FieldOffset(Offset = "0x29")]
		public static bool IsListening;

		// Token: 0x040036DF RID: 14047
		[Token(Token = "0x40036DF")]
		[FieldOffset(Offset = "0x2A")]
		public static bool LostConnection;

		// Token: 0x040036E0 RID: 14048
		[Token(Token = "0x40036E0")]
		[FieldOffset(Offset = "0x2B")]
		public static bool WasKicked;

		// Token: 0x040036E1 RID: 14049
		[Token(Token = "0x40036E1")]
		[FieldOffset(Offset = "0x2C")]
		public static string KickedReason;

		// Token: 0x040036E2 RID: 14050
		[Token(Token = "0x40036E2")]
		[FieldOffset(Offset = "0x30")]
		public static bool Disconnect;

		// Token: 0x040036E3 RID: 14051
		[Token(Token = "0x40036E3")]
		[FieldOffset(Offset = "0x31")]
		public static bool SpamCheck;

		// Token: 0x040036E4 RID: 14052
		[Token(Token = "0x40036E4")]
		[FieldOffset(Offset = "0x32")]
		public static bool HasClients;

		// Token: 0x040036E5 RID: 14053
		[Token(Token = "0x40036E5")]
		[FieldOffset(Offset = "0x34")]
		public static string portForwardIP;

		// Token: 0x040036E6 RID: 14054
		[Token(Token = "0x40036E6")]
		[FieldOffset(Offset = "0x38")]
		public static int portForwardPort;

		// Token: 0x040036E7 RID: 14055
		[Token(Token = "0x40036E7")]
		[FieldOffset(Offset = "0x3C")]
		public static bool portForwardOpen;

		// Token: 0x040036E8 RID: 14056
		[Token(Token = "0x40036E8")]
		[FieldOffset(Offset = "0x40")]
		private static int oldState;

		// Token: 0x040036E9 RID: 14057
		[Token(Token = "0x40036E9")]
		[FieldOffset(Offset = "0x48")]
		public static DateTime LastClientUpdateTime;

		// Token: 0x040036EA RID: 14058
		[Token(Token = "0x40036EA")]
		[FieldOffset(Offset = "0x50")]
		public static bool clientLoopRunning;

		// Token: 0x040036EB RID: 14059
		[Token(Token = "0x40036EB")]
		[FieldOffset(Offset = "0x54")]
		private static UdpClient BroadcastClient;

		// Token: 0x040036EC RID: 14060
		[Token(Token = "0x40036EC")]
		[FieldOffset(Offset = "0x58")]
		private static ManagedThread broadcastThread;

		// Token: 0x040036ED RID: 14061
		[Token(Token = "0x40036ED")]
		public const int MaxConnections = 256;

		// Token: 0x040036EE RID: 14062
		[Token(Token = "0x40036EE")]
		public const int NetBufferSize = 32768;

		// Token: 0x040036F0 RID: 14064
		[Token(Token = "0x40036F0")]
		[FieldOffset(Offset = "0x60")]
		private static List<PlatformUser> bannedUsers;

		// Token: 0x040036F1 RID: 14065
		[Token(Token = "0x40036F1")]
		[FieldOffset(Offset = "0x64")]
		private static List<string> bannedAddress;

		// Token: 0x040036F2 RID: 14066
		[Token(Token = "0x40036F2")]
		[FieldOffset(Offset = "0x68")]
		private static List<IPAddress> BroadcastAddresses;

		// Token: 0x040036F3 RID: 14067
		[Token(Token = "0x40036F3")]
		[FieldOffset(Offset = "0x6C")]
		public static AutoResetEvent disconnectEvent;

		// Token: 0x02000482 RID: 1154
		[Token(Token = "0x2000482")]
		public struct RecentServerInformation
		{
			// Token: 0x040036F4 RID: 14068
			[Token(Token = "0x40036F4")]
			[FieldOffset(Offset = "0x0")]
			public string IP;

			// Token: 0x040036F5 RID: 14069
			[Token(Token = "0x40036F5")]
			[FieldOffset(Offset = "0x4")]
			public int Port;

			// Token: 0x040036F6 RID: 14070
			[Token(Token = "0x40036F6")]
			[FieldOffset(Offset = "0x8")]
			public string World;

			// Token: 0x040036F7 RID: 14071
			[Token(Token = "0x40036F7")]
			[FieldOffset(Offset = "0xC")]
			public short GameMode;

			// Token: 0x040036F8 RID: 14072
			[Token(Token = "0x40036F8")]
			[FieldOffset(Offset = "0xE")]
			public bool HardMode;

			// Token: 0x040036F9 RID: 14073
			[Token(Token = "0x40036F9")]
			[FieldOffset(Offset = "0xF")]
			public bool Crimson;

			// Token: 0x040036FA RID: 14074
			[Token(Token = "0x40036FA")]
			[FieldOffset(Offset = "0x10")]
			public int SizeX;

			// Token: 0x040036FB RID: 14075
			[Token(Token = "0x40036FB")]
			[FieldOffset(Offset = "0x14")]
			public bool Favorite;

			// Token: 0x040036FC RID: 14076
			[Token(Token = "0x40036FC")]
			[FieldOffset(Offset = "0x18")]
			public string Password;

			// Token: 0x040036FD RID: 14077
			[Token(Token = "0x40036FD")]
			[FieldOffset(Offset = "0x1C")]
			public bool SkyWorldSeed;
		}
	}
}
