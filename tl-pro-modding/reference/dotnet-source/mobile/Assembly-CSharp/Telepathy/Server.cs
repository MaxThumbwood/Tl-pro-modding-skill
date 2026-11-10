using System;
using System.Collections.Concurrent;
using System.Net.Sockets;
using System.Threading;
using Il2CppDummyDll;

namespace Telepathy
{
	// Token: 0x02000383 RID: 899
	[Token(Token = "0x2000383")]
	public class Server : Common
	{
		// Token: 0x06001633 RID: 5683 RVA: 0x00009DE0 File Offset: 0x00007FE0
		[Token(Token = "0x6001633")]
		[Address(RVA = "0xE0AF00", Offset = "0xE0AF00", VA = "0xE0AF00")]
		private int NextConnectionId()
		{
			return 0;
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06001634 RID: 5684 RVA: 0x00009DF8 File Offset: 0x00007FF8
		[Token(Token = "0x1700021E")]
		public bool Active
		{
			[Token(Token = "0x6001634")]
			[Address(RVA = "0xE0AF98", Offset = "0xE0AF98", VA = "0xE0AF98")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001635")]
		[Address(RVA = "0xE0AFCC", Offset = "0xE0AFCC", VA = "0xE0AFCC")]
		private void AddClient_Platform(TcpClient client)
		{
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001636")]
		[Address(RVA = "0xE0B048", Offset = "0xE0B048", VA = "0xE0B048")]
		private void AddClient(string tag, NetworkClientHolder client)
		{
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001637")]
		[Address(RVA = "0xE0B554", Offset = "0xE0B554", VA = "0xE0B554")]
		private void AddClient_TCP(TcpClient client)
		{
		}

		// Token: 0x06001638 RID: 5688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001638")]
		[Address(RVA = "0xE0B5D0", Offset = "0xE0B5D0", VA = "0xE0B5D0")]
		private void Listen(int port)
		{
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001639")]
		[Address(RVA = "0xE0B784", Offset = "0xE0B784", VA = "0xE0B784")]
		private void Listen_TCP(int port)
		{
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x00009E10 File Offset: 0x00008010
		[Token(Token = "0x600163A")]
		[Address(RVA = "0xE0B934", Offset = "0xE0B934", VA = "0xE0B934")]
		public bool Start(int port)
		{
			return default(bool);
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600163B")]
		[Address(RVA = "0xE0BEDC", Offset = "0xE0BEDC", VA = "0xE0BEDC")]
		private void Cleanup()
		{
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600163C")]
		[Address(RVA = "0xE0C418", Offset = "0xE0C418", VA = "0xE0C418")]
		public void Stop()
		{
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x00009E28 File Offset: 0x00008028
		[Token(Token = "0x600163D")]
		[Address(RVA = "0xE0C51C", Offset = "0xE0C51C", VA = "0xE0C51C")]
		public bool Send(int connectionId, byte[] data, int length)
		{
			return default(bool);
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600163E")]
		[Address(RVA = "0xE0C680", Offset = "0xE0C680", VA = "0xE0C680")]
		public string GetClientAddress(int connectionId)
		{
			return null;
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x00009E40 File Offset: 0x00008040
		[Token(Token = "0x600163F")]
		[Address(RVA = "0xE0C720", Offset = "0xE0C720", VA = "0xE0C720")]
		public bool Disconnect(int connectionId)
		{
			return default(bool);
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001640")]
		[Address(RVA = "0xE0C7C8", Offset = "0xE0C7C8", VA = "0xE0C7C8")]
		public Server()
		{
		}

		// Token: 0x04002AA5 RID: 10917
		[Token(Token = "0x4002AA5")]
		[FieldOffset(Offset = "0x14")]
		private ManagedThread listenerThread;

		// Token: 0x04002AA6 RID: 10918
		[Token(Token = "0x4002AA6")]
		[FieldOffset(Offset = "0x18")]
		private ManagedThread listenerThread_TCP;

		// Token: 0x04002AA7 RID: 10919
		[Token(Token = "0x4002AA7")]
		[FieldOffset(Offset = "0x1C")]
		public TcpListener listener_Platform;

		// Token: 0x04002AA8 RID: 10920
		[Token(Token = "0x4002AA8")]
		[FieldOffset(Offset = "0x20")]
		public TcpListener listener_TCP;

		// Token: 0x04002AA9 RID: 10921
		[Token(Token = "0x4002AA9")]
		[FieldOffset(Offset = "0x24")]
		private ConcurrentDictionary<int, Server.ClientToken> clients;

		// Token: 0x04002AAA RID: 10922
		[Token(Token = "0x4002AAA")]
		[FieldOffset(Offset = "0x0")]
		private static int counter;

		// Token: 0x04002AAB RID: 10923
		[Token(Token = "0x4002AAB")]
		[FieldOffset(Offset = "0x28")]
		private object ConnectionLock;

		// Token: 0x02000384 RID: 900
		[Token(Token = "0x2000384")]
		private class ClientToken
		{
			// Token: 0x06001641 RID: 5697 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001641")]
			[Address(RVA = "0xE0B474", Offset = "0xE0B474", VA = "0xE0B474")]
			public ClientToken()
			{
			}

			// Token: 0x04002AAC RID: 10924
			[Token(Token = "0x4002AAC")]
			[FieldOffset(Offset = "0x8")]
			public NetworkClientHolder client;

			// Token: 0x04002AAD RID: 10925
			[Token(Token = "0x4002AAD")]
			[FieldOffset(Offset = "0x18")]
			public SafeQueue<byte[]> sendQueue;

			// Token: 0x04002AAE RID: 10926
			[Token(Token = "0x4002AAE")]
			[FieldOffset(Offset = "0x1C")]
			public ManualResetEvent sendPending;
		}

		// Token: 0x02000385 RID: 901
		[Token(Token = "0x2000385")]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x06001642 RID: 5698 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001642")]
			[Address(RVA = "0xE0B46C", Offset = "0xE0B46C", VA = "0xE0B46C")]
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x06001643 RID: 5699 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001643")]
			[Address(RVA = "0xE0C8D0", Offset = "0xE0C8D0", VA = "0xE0C8D0")]
			internal void <AddClient>b__0()
			{
			}

			// Token: 0x06001644 RID: 5700 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001644")]
			[Address(RVA = "0xE0CA34", Offset = "0xE0CA34", VA = "0xE0CA34")]
			internal void <AddClient>b__1()
			{
			}

			// Token: 0x04002AAF RID: 10927
			[Token(Token = "0x4002AAF")]
			[FieldOffset(Offset = "0x8")]
			public int connectionId;

			// Token: 0x04002AB0 RID: 10928
			[Token(Token = "0x4002AB0")]
			[FieldOffset(Offset = "0xC")]
			public NetworkClientHolder client;

			// Token: 0x04002AB1 RID: 10929
			[Token(Token = "0x4002AB1")]
			[FieldOffset(Offset = "0x1C")]
			public Server.ClientToken token;

			// Token: 0x04002AB2 RID: 10930
			[Token(Token = "0x4002AB2")]
			[FieldOffset(Offset = "0x20")]
			public Server <>4__this;

			// Token: 0x04002AB3 RID: 10931
			[Token(Token = "0x4002AB3")]
			[FieldOffset(Offset = "0x24")]
			public ManagedThread sendThread;
		}

		// Token: 0x02000386 RID: 902
		[Token(Token = "0x2000386")]
		private sealed class <>c__DisplayClass16_0
		{
			// Token: 0x06001645 RID: 5701 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001645")]
			[Address(RVA = "0xE0BED4", Offset = "0xE0BED4", VA = "0xE0BED4")]
			public <>c__DisplayClass16_0()
			{
			}

			// Token: 0x06001646 RID: 5702 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001646")]
			[Address(RVA = "0xE0CCEC", Offset = "0xE0CCEC", VA = "0xE0CCEC")]
			internal void <Start>b__0()
			{
			}

			// Token: 0x06001647 RID: 5703 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001647")]
			[Address(RVA = "0xE0CD0C", Offset = "0xE0CD0C", VA = "0xE0CD0C")]
			internal void <Start>b__1()
			{
			}

			// Token: 0x04002AB4 RID: 10932
			[Token(Token = "0x4002AB4")]
			[FieldOffset(Offset = "0x8")]
			public Server <>4__this;

			// Token: 0x04002AB5 RID: 10933
			[Token(Token = "0x4002AB5")]
			[FieldOffset(Offset = "0xC")]
			public int port;
		}
	}
}
