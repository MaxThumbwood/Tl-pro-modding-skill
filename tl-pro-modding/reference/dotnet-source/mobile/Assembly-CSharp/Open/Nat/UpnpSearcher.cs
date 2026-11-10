using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Xml;
using Il2CppDummyDll;

namespace Open.Nat
{
	// Token: 0x02000E65 RID: 3685
	[Token(Token = "0x2000E65")]
	internal class UpnpSearcher : Searcher
	{
		// Token: 0x06006AE6 RID: 27366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AE6")]
		[Address(RVA = "0xB9A9AC", Offset = "0xB9A9AC", VA = "0xB9A9AC")]
		internal UpnpSearcher(IIPAddressesProvider ipprovider)
		{
		}

		// Token: 0x06006AE7 RID: 27367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AE7")]
		[Address(RVA = "0xBA697C", Offset = "0xBA697C", VA = "0xBA697C")]
		private List<UdpClient> CreateUdpClients()
		{
			return null;
		}

		// Token: 0x06006AE8 RID: 27368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AE8")]
		[Address(RVA = "0xBA7094", Offset = "0xBA7094", VA = "0xBA7094", Slot = "4")]
		protected override void Discover(UdpClient client, CancellationToken cancelationToken)
		{
		}

		// Token: 0x06006AE9 RID: 27369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AE9")]
		[Address(RVA = "0xBA71A8", Offset = "0xBA71A8", VA = "0xBA71A8")]
		private void Discover(UdpClient client, IPAddress address, CancellationToken cancelationToken)
		{
		}

		// Token: 0x06006AEA RID: 27370 RVA: 0x00030240 File Offset: 0x0002E440
		[Token(Token = "0x6006AEA")]
		[Address(RVA = "0xBA74AC", Offset = "0xBA74AC", VA = "0xBA74AC")]
		private bool IsValidClient(Socket socket, IPAddress address)
		{
			return default(bool);
		}

		// Token: 0x06006AEB RID: 27371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AEB")]
		[Address(RVA = "0xBA7758", Offset = "0xBA7758", VA = "0xBA7758", Slot = "5")]
		public override NatDevice AnalyseReceivedResponse(IPAddress localAddress, byte[] response, IPEndPoint endpoint)
		{
			return null;
		}

		// Token: 0x06006AEC RID: 27372 RVA: 0x00030258 File Offset: 0x0002E458
		[Token(Token = "0x6006AEC")]
		[Address(RVA = "0xBA87A0", Offset = "0xBA87A0", VA = "0xBA87A0")]
		private static bool IsValidControllerService(string serviceType)
		{
			return default(bool);
		}

		// Token: 0x06006AED RID: 27373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AED")]
		[Address(RVA = "0xBA8AFC", Offset = "0xBA8AFC", VA = "0xBA8AFC")]
		private UpnpNatDeviceInfo BuildUpnpNatDeviceInfo(IPAddress localAddress, Uri location)
		{
			return null;
		}

		// Token: 0x06006AEE RID: 27374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AEE")]
		[Address(RVA = "0xBA9D4C", Offset = "0xBA9D4C", VA = "0xBA9D4C")]
		private static XmlDocument ReadXmlResponse(WebResponse response)
		{
			return null;
		}

		// Token: 0x0400A874 RID: 43124
		[Token(Token = "0x400A874")]
		[FieldOffset(Offset = "0x20")]
		private readonly IIPAddressesProvider _ipprovider;

		// Token: 0x0400A875 RID: 43125
		[Token(Token = "0x400A875")]
		[FieldOffset(Offset = "0x24")]
		private readonly IDictionary<Uri, NatDevice> _devices;

		// Token: 0x0400A876 RID: 43126
		[Token(Token = "0x400A876")]
		[FieldOffset(Offset = "0x28")]
		private readonly Dictionary<IPAddress, DateTime> _lastFetched;

		// Token: 0x0400A877 RID: 43127
		[Token(Token = "0x400A877")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string[] ServiceTypes;

		// Token: 0x02000E66 RID: 3686
		[Token(Token = "0x2000E66")]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x06006AF0 RID: 27376 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AF0")]
			[Address(RVA = "0xBA9D44", Offset = "0xBA9D44", VA = "0xBA9D44")]
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x06006AF1 RID: 27377 RVA: 0x00030270 File Offset: 0x0002E470
			[Token(Token = "0x6006AF1")]
			[Address(RVA = "0xBAA1D8", Offset = "0xBAA1D8", VA = "0xBAA1D8")]
			internal bool <IsValidControllerService>b__1(<>f__AnonymousType4<string, string> <>h__TransparentIdentifier0)
			{
				return default(bool);
			}

			// Token: 0x0400A878 RID: 43128
			[Token(Token = "0x400A878")]
			[FieldOffset(Offset = "0x8")]
			public string serviceType;
		}

		// Token: 0x02000E67 RID: 3687
		[Token(Token = "0x2000E67")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006AF3 RID: 27379 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AF3")]
			[Address(RVA = "0xBAA300", Offset = "0xBAA300", VA = "0xBAA300")]
			public <>c()
			{
			}

			// Token: 0x06006AF4 RID: 27380 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006AF4")]
			[Address(RVA = "0xBAA308", Offset = "0xBAA308", VA = "0xBAA308")]
			internal <>f__AnonymousType4<string, string> <IsValidControllerService>b__10_0(string serviceName)
			{
				return null;
			}

			// Token: 0x06006AF5 RID: 27381 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006AF5")]
			[Address(RVA = "0xBAA3CC", Offset = "0xBAA3CC", VA = "0xBAA3CC")]
			internal <>f__AnonymousType5<string, string> <IsValidControllerService>b__10_2(<>f__AnonymousType4<string, string> <>h__TransparentIdentifier0)
			{
				return null;
			}

			// Token: 0x0400A879 RID: 43129
			[Token(Token = "0x400A879")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UpnpSearcher.<>c <>9;

			// Token: 0x0400A87A RID: 43130
			[Token(Token = "0x400A87A")]
			[FieldOffset(Offset = "0x4")]
			public static Func<string, <>f__AnonymousType4<string, string>> <>9__10_0;

			// Token: 0x0400A87B RID: 43131
			[Token(Token = "0x400A87B")]
			[FieldOffset(Offset = "0x8")]
			public static Func<<>f__AnonymousType4<string, string>, <>f__AnonymousType5<string, string>> <>9__10_2;
		}
	}
}
