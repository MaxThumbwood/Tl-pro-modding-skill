using System;
using System.Net.Sockets;
using System.Threading;
using Il2CppDummyDll;

namespace Telepathy
{
	// Token: 0x0200037B RID: 891
	[Token(Token = "0x200037B")]
	public class Client : Common
	{
		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06001619 RID: 5657 RVA: 0x00009CD8 File Offset: 0x00007ED8
		[Token(Token = "0x1700021A")]
		public bool Connected
		{
			[Token(Token = "0x6001619")]
			[Address(RVA = "0xE08A94", Offset = "0xE08A94", VA = "0xE08A94")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x0600161A RID: 5658 RVA: 0x00009CF0 File Offset: 0x00007EF0
		[Token(Token = "0x1700021B")]
		public bool Connecting
		{
			[Token(Token = "0x600161A")]
			[Address(RVA = "0xE08AE0", Offset = "0xE08AE0", VA = "0xE08AE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x00009D08 File Offset: 0x00007F08
		[Token(Token = "0x600161B")]
		[Address(RVA = "0xE08B00", Offset = "0xE08B00", VA = "0xE08B00")]
		private bool GetIPV6AddressFromIPV4(string hostname, out string ipv6Address)
		{
			return default(bool);
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600161C")]
		[Address(RVA = "0xE08D3C", Offset = "0xE08D3C", VA = "0xE08D3C")]
		private void ReceiveThreadFunction(string ip, int port)
		{
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600161D")]
		[Address(RVA = "0xE09CC0", Offset = "0xE09CC0", VA = "0xE09CC0")]
		public void Connect(string ip, int port)
		{
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600161E")]
		[Address(RVA = "0xE01804", Offset = "0xE01804", VA = "0xE01804")]
		public void Disconnect()
		{
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x00009D20 File Offset: 0x00007F20
		[Token(Token = "0x600161F")]
		[Address(RVA = "0xE0A0C4", Offset = "0xE0A0C4", VA = "0xE0A0C4")]
		public bool Send(byte[] data, int length)
		{
			return default(bool);
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001620")]
		[Address(RVA = "0xE0A1F8", Offset = "0xE0A1F8", VA = "0xE0A1F8")]
		public Client()
		{
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001621")]
		[Address(RVA = "0xE0A3F0", Offset = "0xE0A3F0", VA = "0xE0A3F0")]
		private void <ReceiveThreadFunction>b__15_0()
		{
		}

		// Token: 0x04002A86 RID: 10886
		[Token(Token = "0x4002A86")]
		[FieldOffset(Offset = "0x14")]
		public NetworkClientHolder client;

		// Token: 0x04002A87 RID: 10887
		[Token(Token = "0x4002A87")]
		[FieldOffset(Offset = "0x24")]
		private TcpClient platform_Client;

		// Token: 0x04002A88 RID: 10888
		[Token(Token = "0x4002A88")]
		[FieldOffset(Offset = "0x28")]
		private ManagedThread receiveThread;

		// Token: 0x04002A89 RID: 10889
		[Token(Token = "0x4002A89")]
		[FieldOffset(Offset = "0x2C")]
		private ManagedThread sendThread;

		// Token: 0x04002A8A RID: 10890
		[Token(Token = "0x4002A8A")]
		[FieldOffset(Offset = "0x30")]
		private int _ConnectingCount;

		// Token: 0x04002A8B RID: 10891
		[Token(Token = "0x4002A8B")]
		[FieldOffset(Offset = "0x34")]
		private SafeQueue<byte[]> sendQueue;

		// Token: 0x04002A8C RID: 10892
		[Token(Token = "0x4002A8C")]
		[FieldOffset(Offset = "0x38")]
		private ManualResetEvent sendPending;

		// Token: 0x04002A8D RID: 10893
		[Token(Token = "0x4002A8D")]
		[FieldOffset(Offset = "0x3C")]
		private Client.ConnectionMode currentMode;

		// Token: 0x04002A8E RID: 10894
		[Token(Token = "0x4002A8E")]
		[FieldOffset(Offset = "0x40")]
		private object ModeLock;

		// Token: 0x0200037C RID: 892
		[Token(Token = "0x200037C")]
		private enum ConnectionMode
		{
			// Token: 0x04002A90 RID: 10896
			[Token(Token = "0x4002A90")]
			None,
			// Token: 0x04002A91 RID: 10897
			[Token(Token = "0x4002A91")]
			TCP,
			// Token: 0x04002A92 RID: 10898
			[Token(Token = "0x4002A92")]
			UDP
		}

		// Token: 0x0200037D RID: 893
		[Token(Token = "0x200037D")]
		private sealed class <>c__DisplayClass16_0
		{
			// Token: 0x06001622 RID: 5666 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001622")]
			[Address(RVA = "0xE0A0BC", Offset = "0xE0A0BC", VA = "0xE0A0BC")]
			public <>c__DisplayClass16_0()
			{
			}

			// Token: 0x06001623 RID: 5667 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001623")]
			[Address(RVA = "0xE0A820", Offset = "0xE0A820", VA = "0xE0A820")]
			internal void <Connect>b__0()
			{
			}

			// Token: 0x04002A93 RID: 10899
			[Token(Token = "0x4002A93")]
			[FieldOffset(Offset = "0x8")]
			public Client <>4__this;

			// Token: 0x04002A94 RID: 10900
			[Token(Token = "0x4002A94")]
			[FieldOffset(Offset = "0xC")]
			public string ip;

			// Token: 0x04002A95 RID: 10901
			[Token(Token = "0x4002A95")]
			[FieldOffset(Offset = "0x10")]
			public int port;
		}
	}
}
