using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Open.Nat
{
	// Token: 0x02000E46 RID: 3654
	[Token(Token = "0x2000E46")]
	internal sealed class PmpNatDevice : NatDevice
	{
		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x06006A75 RID: 27253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B77")]
		public override IPEndPoint HostEndPoint
		{
			[Token(Token = "0x6006A75")]
			[Address(RVA = "0xB9AB6C", Offset = "0xB9AB6C", VA = "0xB9AB6C", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x06006A76 RID: 27254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B78")]
		public override IPAddress LocalAddress
		{
			[Token(Token = "0x6006A76")]
			[Address(RVA = "0xB9AB74", Offset = "0xB9AB74", VA = "0xB9AB74", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006A77 RID: 27255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A77")]
		[Address(RVA = "0xB9AB7C", Offset = "0xB9AB7C", VA = "0xB9AB7C")]
		internal PmpNatDevice(IPAddress hostEndPointAddress, IPAddress localAddress, IPAddress publicAddress)
		{
		}

		// Token: 0x06006A78 RID: 27256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A78")]
		[Address(RVA = "0xB9AC90", Offset = "0xB9AC90", VA = "0xB9AC90", Slot = "6")]
		public override Task CreatePortMapAsync(Mapping mapping)
		{
			return null;
		}

		// Token: 0x06006A79 RID: 27257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A79")]
		[Address(RVA = "0xB9AD80", Offset = "0xB9AD80", VA = "0xB9AD80", Slot = "7")]
		public override Task DeletePortMapAsync(Mapping mapping)
		{
			return null;
		}

		// Token: 0x06006A7A RID: 27258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A7A")]
		[Address(RVA = "0xB9AE70", Offset = "0xB9AE70", VA = "0xB9AE70", Slot = "8")]
		public override Task<IEnumerable<Mapping>> GetAllMappingsAsync()
		{
			return null;
		}

		// Token: 0x06006A7B RID: 27259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A7B")]
		[Address(RVA = "0xB9AEBC", Offset = "0xB9AEBC", VA = "0xB9AEBC", Slot = "9")]
		public override Task<IPAddress> GetExternalIPAsync()
		{
			return null;
		}

		// Token: 0x06006A7C RID: 27260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A7C")]
		[Address(RVA = "0xB9B02C", Offset = "0xB9B02C", VA = "0xB9B02C", Slot = "10")]
		public override Task<Mapping> GetSpecificMappingAsync(Protocol protocol, int port)
		{
			return null;
		}

		// Token: 0x06006A7D RID: 27261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A7D")]
		[Address(RVA = "0xB9B08C", Offset = "0xB9B08C", VA = "0xB9B08C")]
		private Task<Mapping> InternalCreatePortMapAsync(Mapping mapping, bool create)
		{
			return null;
		}

		// Token: 0x06006A7E RID: 27262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A7E")]
		[Address(RVA = "0xB9B1BC", Offset = "0xB9B1BC", VA = "0xB9B1BC")]
		private void CreatePortMapListen(UdpClient udpClient, Mapping mapping)
		{
		}

		// Token: 0x06006A7F RID: 27263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A7F")]
		[Address(RVA = "0xB9B5D8", Offset = "0xB9B5D8", VA = "0xB9B5D8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006A80 RID: 27264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A80")]
		[Address(RVA = "0xB9B6A4", Offset = "0xB9B6A4", VA = "0xB9B6A4")]
		private IPAddress <GetExternalIPAsync>b__11_0()
		{
			return null;
		}

		// Token: 0x0400A7F7 RID: 42999
		[Token(Token = "0x400A7F7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IPEndPoint _hostEndPoint;

		// Token: 0x0400A7F8 RID: 43000
		[Token(Token = "0x400A7F8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private readonly IPAddress _localAddress;

		// Token: 0x0400A7F9 RID: 43001
		[Token(Token = "0x400A7F9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly IPAddress _publicAddress;

		// Token: 0x02000E47 RID: 3655
		[Token(Token = "0x2000E47")]
		[StructLayout(3)]
		private struct <CreatePortMapAsync>d__8 : FileAPI
		{
			// Token: 0x06006A81 RID: 27265 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A81")]
			[Address(RVA = "0xB9B6AC", Offset = "0xB9B6AC", VA = "0xB9B6AC", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x06006A82 RID: 27266 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A82")]
			[Address(RVA = "0xB9B9EC", Offset = "0xB9B9EC", VA = "0xB9B9EC", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x0400A7FA RID: 43002
			[Token(Token = "0x400A7FA")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x0400A7FB RID: 43003
			[Token(Token = "0x400A7FB")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400A7FC RID: 43004
			[Token(Token = "0x400A7FC")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PmpNatDevice <>4__this;

			// Token: 0x0400A7FD RID: 43005
			[Token(Token = "0x400A7FD")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Mapping mapping;

			// Token: 0x0400A7FE RID: 43006
			[Token(Token = "0x400A7FE")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private TaskAwaiter<Mapping> <>u__1;
		}

		// Token: 0x02000E48 RID: 3656
		[Token(Token = "0x2000E48")]
		[StructLayout(3)]
		private struct <DeletePortMapAsync>d__9 : FileAPI
		{
			// Token: 0x06006A83 RID: 27267 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A83")]
			[Address(RVA = "0xB9BA60", Offset = "0xB9BA60", VA = "0xB9BA60", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x06006A84 RID: 27268 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A84")]
			[Address(RVA = "0xB9BDA0", Offset = "0xB9BDA0", VA = "0xB9BDA0", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x0400A7FF RID: 43007
			[Token(Token = "0x400A7FF")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x0400A800 RID: 43008
			[Token(Token = "0x400A800")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400A801 RID: 43009
			[Token(Token = "0x400A801")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PmpNatDevice <>4__this;

			// Token: 0x0400A802 RID: 43010
			[Token(Token = "0x400A802")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Mapping mapping;

			// Token: 0x0400A803 RID: 43011
			[Token(Token = "0x400A803")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private TaskAwaiter<Mapping> <>u__1;
		}

		// Token: 0x02000E49 RID: 3657
		[Token(Token = "0x2000E49")]
		[StructLayout(3)]
		private struct <InternalCreatePortMapAsync>d__13 : FileAPI
		{
			// Token: 0x06006A85 RID: 27269 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A85")]
			[Address(RVA = "0xB9BE14", Offset = "0xB9BE14", VA = "0xB9BE14", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x06006A86 RID: 27270 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A86")]
			[Address(RVA = "0xB9CAA0", Offset = "0xB9CAA0", VA = "0xB9CAA0", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x0400A804 RID: 43012
			[Token(Token = "0x400A804")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x0400A805 RID: 43013
			[Token(Token = "0x400A805")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder<Mapping> <>t__builder;

			// Token: 0x0400A806 RID: 43014
			[Token(Token = "0x400A806")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Mapping mapping;

			// Token: 0x0400A807 RID: 43015
			[Token(Token = "0x400A807")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool create;

			// Token: 0x0400A808 RID: 43016
			[Token(Token = "0x400A808")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PmpNatDevice <>4__this;

			// Token: 0x0400A809 RID: 43017
			[Token(Token = "0x400A809")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private byte[] <buffer>5__2;

			// Token: 0x0400A80A RID: 43018
			[Token(Token = "0x400A80A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <attempt>5__3;

			// Token: 0x0400A80B RID: 43019
			[Token(Token = "0x400A80B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private int <delay>5__4;

			// Token: 0x0400A80C RID: 43020
			[Token(Token = "0x400A80C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UdpClient <udpClient>5__5;

			// Token: 0x0400A80D RID: 43021
			[Token(Token = "0x400A80D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private TaskAwaiter<int> <>u__1;
		}
	}
}
