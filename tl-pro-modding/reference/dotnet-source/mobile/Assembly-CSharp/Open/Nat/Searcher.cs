using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Open.Nat
{
	// Token: 0x02000E2D RID: 3629
	[Token(Token = "0x2000E2D")]
	internal abstract class Searcher
	{
		// Token: 0x06006A00 RID: 27136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A00")]
		[Address(RVA = "0xB92F00", Offset = "0xB92F00", VA = "0xB92F00")]
		public Task<IEnumerable<NatDevice>> Search(CancellationToken cancelationToken)
		{
			return null;
		}

		// Token: 0x06006A01 RID: 27137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A01")]
		[Address(RVA = "0xB93020", Offset = "0xB93020", VA = "0xB93020")]
		private void Discover(CancellationToken cancelationToken)
		{
		}

		// Token: 0x06006A02 RID: 27138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A02")]
		[Address(RVA = "0xB93468", Offset = "0xB93468", VA = "0xB93468")]
		private void Receive(CancellationToken cancelationToken)
		{
		}

		// Token: 0x06006A03 RID: 27139
		[Token(Token = "0x6006A03")]
		protected abstract void Discover(UdpClient client, CancellationToken cancelationToken);

		// Token: 0x06006A04 RID: 27140
		[Token(Token = "0x6006A04")]
		public abstract NatDevice AnalyseReceivedResponse(IPAddress localAddress, byte[] response, IPEndPoint endpoint);

		// Token: 0x06006A05 RID: 27141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A05")]
		[Address(RVA = "0xB93C10", Offset = "0xB93C10", VA = "0xB93C10")]
		public void CloseUdpClients()
		{
		}

		// Token: 0x06006A06 RID: 27142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A06")]
		[Address(RVA = "0xB93A98", Offset = "0xB93A98", VA = "0xB93A98")]
		private void RaiseDeviceFound(NatDevice device)
		{
		}

		// Token: 0x06006A07 RID: 27143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A07")]
		[Address(RVA = "0xB93E1C", Offset = "0xB93E1C", VA = "0xB93E1C")]
		protected Searcher()
		{
		}

		// Token: 0x0400A78F RID: 42895
		[Token(Token = "0x400A78F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly List<NatDevice> _devices;

		// Token: 0x0400A790 RID: 42896
		[Token(Token = "0x400A790")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		protected List<UdpClient> UdpClients;

		// Token: 0x0400A791 RID: 42897
		[Token(Token = "0x400A791")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EventHandler<DeviceEventArgs> DeviceFound;

		// Token: 0x0400A792 RID: 42898
		[Token(Token = "0x400A792")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal DateTime NextSearch;

		// Token: 0x02000E2E RID: 3630
		[Token(Token = "0x2000E2E")]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x06006A08 RID: 27144 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A08")]
			[Address(RVA = "0xB93F00", Offset = "0xB93F00", VA = "0xB93F00")]
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x06006A09 RID: 27145 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A09")]
			[Address(RVA = "0xB93F08", Offset = "0xB93F08", VA = "0xB93F08")]
			internal void <Search>b__0(object _)
			{
			}

			// Token: 0x0400A793 RID: 42899
			[Token(Token = "0x400A793")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Searcher <>4__this;

			// Token: 0x0400A794 RID: 42900
			[Token(Token = "0x400A794")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public CancellationToken cancelationToken;
		}

		// Token: 0x02000E2F RID: 3631
		[Token(Token = "0x2000E2F")]
		[StructLayout(3)]
		private struct <Search>d__4 : FileAPI
		{
			// Token: 0x06006A0A RID: 27146 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A0A")]
			[Address(RVA = "0xB940D4", Offset = "0xB940D4", VA = "0xB940D4", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x06006A0B RID: 27147 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A0B")]
			[Address(RVA = "0xB944CC", Offset = "0xB944CC", VA = "0xB944CC", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x0400A795 RID: 42901
			[Token(Token = "0x400A795")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x0400A796 RID: 42902
			[Token(Token = "0x400A796")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder<IEnumerable<NatDevice>> <>t__builder;

			// Token: 0x0400A797 RID: 42903
			[Token(Token = "0x400A797")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Searcher <>4__this;

			// Token: 0x0400A798 RID: 42904
			[Token(Token = "0x400A798")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public CancellationToken cancelationToken;

			// Token: 0x0400A799 RID: 42905
			[Token(Token = "0x400A799")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000E30 RID: 3632
		[Token(Token = "0x2000E30")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006A0D RID: 27149 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A0D")]
			[Address(RVA = "0xB945D0", Offset = "0xB945D0", VA = "0xB945D0")]
			public <>c()
			{
			}

			// Token: 0x06006A0E RID: 27150 RVA: 0x00030018 File Offset: 0x0002E218
			[Token(Token = "0x6006A0E")]
			[Address(RVA = "0xB945D8", Offset = "0xB945D8", VA = "0xB945D8")]
			internal bool <Receive>b__6_0(UdpClient x)
			{
				return default(bool);
			}

			// Token: 0x0400A79A RID: 42906
			[Token(Token = "0x400A79A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly Searcher.<>c <>9;

			// Token: 0x0400A79B RID: 42907
			[Token(Token = "0x400A79B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static Func<UdpClient, bool> <>9__6_0;
		}
	}
}
