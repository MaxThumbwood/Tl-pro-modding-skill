using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Il2CppDummyDll;

namespace Open.Nat
{
	// Token: 0x02000E4A RID: 3658
	[Token(Token = "0x2000E4A")]
	internal class PmpSearcher : Searcher
	{
		// Token: 0x06006A87 RID: 27271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A87")]
		[Address(RVA = "0xB9AAB4", Offset = "0xB9AAB4", VA = "0xB9AAB4")]
		internal PmpSearcher(IIPAddressesProvider ipprovider)
		{
		}

		// Token: 0x06006A88 RID: 27272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A88")]
		[Address(RVA = "0xB9CB30", Offset = "0xB9CB30", VA = "0xB9CB30")]
		private void CreateSocketsAndAddGateways()
		{
		}

		// Token: 0x06006A89 RID: 27273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A89")]
		[Address(RVA = "0xB9D6C0", Offset = "0xB9D6C0", VA = "0xB9D6C0", Slot = "4")]
		protected override void Discover(UdpClient client, CancellationToken cancelationToken)
		{
		}

		// Token: 0x06006A8A RID: 27274 RVA: 0x00030198 File Offset: 0x0002E398
		[Token(Token = "0x6006A8A")]
		[Address(RVA = "0xB9DC0C", Offset = "0xB9DC0C", VA = "0xB9DC0C")]
		private bool IsSearchAddress(IPAddress address)
		{
			return default(bool);
		}

		// Token: 0x06006A8B RID: 27275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A8B")]
		[Address(RVA = "0xB9DE68", Offset = "0xB9DE68", VA = "0xB9DE68", Slot = "5")]
		public override NatDevice AnalyseReceivedResponse(IPAddress localAddress, byte[] response, IPEndPoint endpoint)
		{
			return null;
		}

		// Token: 0x0400A80E RID: 43022
		[Token(Token = "0x400A80E")]
		[FieldOffset(Offset = "0x20")]
		private readonly IIPAddressesProvider _ipprovider;

		// Token: 0x0400A80F RID: 43023
		[Token(Token = "0x400A80F")]
		[FieldOffset(Offset = "0x24")]
		private Dictionary<UdpClient, IEnumerable<IPEndPoint>> _gatewayLists;

		// Token: 0x0400A810 RID: 43024
		[Token(Token = "0x400A810")]
		[FieldOffset(Offset = "0x28")]
		private int _timeout;

		// Token: 0x02000E4B RID: 3659
		[Token(Token = "0x2000E4B")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006A8D RID: 27277 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A8D")]
			[Address(RVA = "0xB9E1D8", Offset = "0xB9E1D8", VA = "0xB9E1D8")]
			public <>c()
			{
			}

			// Token: 0x06006A8E RID: 27278 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A8E")]
			[Address(RVA = "0xB9E1E0", Offset = "0xB9E1E0", VA = "0xB9E1E0")]
			internal IPEndPoint <CreateSocketsAndAddGateways>b__4_0(IPAddress ip)
			{
				return null;
			}

			// Token: 0x06006A8F RID: 27279 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A8F")]
			[Address(RVA = "0xB9E258", Offset = "0xB9E258", VA = "0xB9E258")]
			internal IPEndPoint <CreateSocketsAndAddGateways>b__4_1(IPAddress ip)
			{
				return null;
			}

			// Token: 0x06006A90 RID: 27280 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A90")]
			[Address(RVA = "0xB9E2D0", Offset = "0xB9E2D0", VA = "0xB9E2D0")]
			internal IEnumerable<IPEndPoint> <IsSearchAddress>b__6_0(IEnumerable<IPEndPoint> x)
			{
				return null;
			}

			// Token: 0x0400A811 RID: 43025
			[Token(Token = "0x400A811")]
			[FieldOffset(Offset = "0x0")]
			public static readonly PmpSearcher.<>c <>9;

			// Token: 0x0400A812 RID: 43026
			[Token(Token = "0x400A812")]
			[FieldOffset(Offset = "0x4")]
			public static Func<IPAddress, IPEndPoint> <>9__4_0;

			// Token: 0x0400A813 RID: 43027
			[Token(Token = "0x400A813")]
			[FieldOffset(Offset = "0x8")]
			public static Func<IPAddress, IPEndPoint> <>9__4_1;

			// Token: 0x0400A814 RID: 43028
			[Token(Token = "0x400A814")]
			[FieldOffset(Offset = "0xC")]
			public static Func<IEnumerable<IPEndPoint>, IEnumerable<IPEndPoint>> <>9__6_0;
		}

		// Token: 0x02000E4C RID: 3660
		[Token(Token = "0x2000E4C")]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x06006A91 RID: 27281 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A91")]
			[Address(RVA = "0xB9DE60", Offset = "0xB9DE60", VA = "0xB9DE60")]
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x06006A92 RID: 27282 RVA: 0x000301B0 File Offset: 0x0002E3B0
			[Token(Token = "0x6006A92")]
			[Address(RVA = "0xB9E2D8", Offset = "0xB9E2D8", VA = "0xB9E2D8")]
			internal bool <IsSearchAddress>b__1(IPEndPoint x)
			{
				return default(bool);
			}

			// Token: 0x0400A815 RID: 43029
			[Token(Token = "0x400A815")]
			[FieldOffset(Offset = "0x8")]
			public IPAddress address;
		}
	}
}
