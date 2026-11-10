using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Open.Nat
{
	// Token: 0x02000E3D RID: 3645
	[Token(Token = "0x2000E3D")]
	public class NatDiscoverer
	{
		// Token: 0x06006A5B RID: 27227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A5B")]
		[Address(RVA = "0xB97504", Offset = "0xB97504", VA = "0xB97504")]
		public Task<NatDevice> DiscoverDeviceAsync()
		{
			return null;
		}

		// Token: 0x06006A5C RID: 27228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A5C")]
		[Address(RVA = "0xB97624", Offset = "0xB97624", VA = "0xB97624")]
		public Task<NatDevice> DiscoverDeviceAsync(PortMapper portMapper, CancellationTokenSource cancellationTokenSource)
		{
			return null;
		}

		// Token: 0x06006A5D RID: 27229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A5D")]
		[Address(RVA = "0xB97748", Offset = "0xB97748", VA = "0xB97748")]
		public Task<IEnumerable<NatDevice>> DiscoverDevicesAsync(PortMapper portMapper, CancellationTokenSource cancellationTokenSource)
		{
			return null;
		}

		// Token: 0x06006A5E RID: 27230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A5E")]
		[Address(RVA = "0xB9786C", Offset = "0xB9786C", VA = "0xB9786C")]
		private Task<IEnumerable<NatDevice>> DiscoverAsync(PortMapper portMapper, bool onlyOne, CancellationTokenSource cts)
		{
			return null;
		}

		// Token: 0x06006A5F RID: 27231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A5F")]
		[Address(RVA = "0xB979A0", Offset = "0xB979A0", VA = "0xB979A0")]
		public static void ReleaseAll()
		{
		}

		// Token: 0x06006A60 RID: 27232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A60")]
		[Address(RVA = "0xB94D74", Offset = "0xB94D74", VA = "0xB94D74")]
		internal static void ReleaseSessionMappings()
		{
		}

		// Token: 0x06006A61 RID: 27233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A61")]
		[Address(RVA = "0xB97BA8", Offset = "0xB97BA8", VA = "0xB97BA8")]
		private static void RenewMappings(object state)
		{
		}

		// Token: 0x06006A62 RID: 27234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A62")]
		[Address(RVA = "0xB97D68", Offset = "0xB97D68", VA = "0xB97D68")]
		public NatDiscoverer()
		{
		}

		// Token: 0x0400A7C2 RID: 42946
		[Token(Token = "0x400A7C2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly TraceSource TraceSource;

		// Token: 0x0400A7C3 RID: 42947
		[Token(Token = "0x400A7C3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly Dictionary<string, NatDevice> Devices;

		// Token: 0x0400A7C4 RID: 42948
		[Token(Token = "0x400A7C4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Finalizer Finalizer;

		// Token: 0x0400A7C5 RID: 42949
		[Token(Token = "0x400A7C5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal static readonly Timer RenewTimer;

		// Token: 0x02000E3E RID: 3646
		[Token(Token = "0x2000E3E")]
		[StructLayout(3)]
		private struct <DiscoverDeviceAsync>d__4 : FileAPI
		{
			// Token: 0x06006A64 RID: 27236 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A64")]
			[Address(RVA = "0xB97FA0", Offset = "0xB97FA0", VA = "0xB97FA0", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x06006A65 RID: 27237 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A65")]
			[Address(RVA = "0xB982B0", Offset = "0xB982B0", VA = "0xB982B0", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x0400A7C6 RID: 42950
			[Token(Token = "0x400A7C6")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x0400A7C7 RID: 42951
			[Token(Token = "0x400A7C7")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder<NatDevice> <>t__builder;

			// Token: 0x0400A7C8 RID: 42952
			[Token(Token = "0x400A7C8")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public NatDiscoverer <>4__this;

			// Token: 0x0400A7C9 RID: 42953
			[Token(Token = "0x400A7C9")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private TaskAwaiter<NatDevice> <>u__1;
		}

		// Token: 0x02000E3F RID: 3647
		[Token(Token = "0x2000E3F")]
		[StructLayout(3)]
		private struct <DiscoverDeviceAsync>d__5 : FileAPI
		{
			// Token: 0x06006A66 RID: 27238 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A66")]
			[Address(RVA = "0xB98340", Offset = "0xB98340", VA = "0xB98340", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x06006A67 RID: 27239 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A67")]
			[Address(RVA = "0xB98DF8", Offset = "0xB98DF8", VA = "0xB98DF8", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x0400A7CA RID: 42954
			[Token(Token = "0x400A7CA")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x0400A7CB RID: 42955
			[Token(Token = "0x400A7CB")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder<NatDevice> <>t__builder;

			// Token: 0x0400A7CC RID: 42956
			[Token(Token = "0x400A7CC")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PortMapper portMapper;

			// Token: 0x0400A7CD RID: 42957
			[Token(Token = "0x400A7CD")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public CancellationTokenSource cancellationTokenSource;

			// Token: 0x0400A7CE RID: 42958
			[Token(Token = "0x400A7CE")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public NatDiscoverer <>4__this;

			// Token: 0x0400A7CF RID: 42959
			[Token(Token = "0x400A7CF")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private TaskAwaiter<IEnumerable<NatDevice>> <>u__1;
		}

		// Token: 0x02000E40 RID: 3648
		[Token(Token = "0x2000E40")]
		[StructLayout(3)]
		private struct <DiscoverDevicesAsync>d__6 : FileAPI
		{
			// Token: 0x06006A68 RID: 27240 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A68")]
			[Address(RVA = "0xB98E88", Offset = "0xB98E88", VA = "0xB98E88", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x06006A69 RID: 27241 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A69")]
			[Address(RVA = "0xB99284", Offset = "0xB99284", VA = "0xB99284", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x0400A7D0 RID: 42960
			[Token(Token = "0x400A7D0")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x0400A7D1 RID: 42961
			[Token(Token = "0x400A7D1")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder<IEnumerable<NatDevice>> <>t__builder;

			// Token: 0x0400A7D2 RID: 42962
			[Token(Token = "0x400A7D2")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PortMapper portMapper;

			// Token: 0x0400A7D3 RID: 42963
			[Token(Token = "0x400A7D3")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public CancellationTokenSource cancellationTokenSource;

			// Token: 0x0400A7D4 RID: 42964
			[Token(Token = "0x400A7D4")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public NatDiscoverer <>4__this;

			// Token: 0x0400A7D5 RID: 42965
			[Token(Token = "0x400A7D5")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private TaskAwaiter<IEnumerable<NatDevice>> <>u__1;
		}

		// Token: 0x02000E41 RID: 3649
		[Token(Token = "0x2000E41")]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x06006A6A RID: 27242 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A6A")]
			[Address(RVA = "0xB99314", Offset = "0xB99314", VA = "0xB99314")]
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x06006A6B RID: 27243 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A6B")]
			[Address(RVA = "0xB9931C", Offset = "0xB9931C", VA = "0xB9931C")]
			internal void <DiscoverAsync>b__1(object sender, DeviceEventArgs args)
			{
			}

			// Token: 0x06006A6C RID: 27244 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A6C")]
			[Address(RVA = "0xB9934C", Offset = "0xB9934C", VA = "0xB9934C")]
			internal void <DiscoverAsync>b__2(object sender, DeviceEventArgs args)
			{
			}

			// Token: 0x0400A7D6 RID: 42966
			[Token(Token = "0x400A7D6")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool onlyOne;

			// Token: 0x0400A7D7 RID: 42967
			[Token(Token = "0x400A7D7")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public CancellationTokenSource cts;
		}

		// Token: 0x02000E42 RID: 3650
		[Token(Token = "0x2000E42")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006A6E RID: 27246 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A6E")]
			[Address(RVA = "0xB993F0", Offset = "0xB993F0", VA = "0xB993F0")]
			public <>c()
			{
			}

			// Token: 0x06006A6F RID: 27247 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A6F")]
			[Address(RVA = "0xB993F8", Offset = "0xB993F8", VA = "0xB993F8")]
			internal IEnumerable<NatDevice> <DiscoverAsync>b__7_0(Task<IEnumerable<NatDevice>> x)
			{
				return null;
			}

			// Token: 0x06006A70 RID: 27248 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A70")]
			[Address(RVA = "0xB99458", Offset = "0xB99458", VA = "0xB99458")]
			internal Task <RenewMappings>b__10_0()
			{
				return null;
			}

			// Token: 0x0400A7D8 RID: 42968
			[Token(Token = "0x400A7D8")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly NatDiscoverer.<>c <>9;

			// Token: 0x0400A7D9 RID: 42969
			[Token(Token = "0x400A7D9")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static Func<Task<IEnumerable<NatDevice>>, IEnumerable<NatDevice>> <>9__7_0;

			// Token: 0x0400A7DA RID: 42970
			[Token(Token = "0x400A7DA")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Task> <>9__10_0;

			// Token: 0x02000E43 RID: 3651
			[Token(Token = "0x2000E43")]
			[StructLayout(3)]
			private struct <<RenewMappings>b__10_0>d : FileAPI
			{
				// Token: 0x06006A71 RID: 27249 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006A71")]
				[Address(RVA = "0xB99544", Offset = "0xB99544", VA = "0xB99544", Slot = "4")]
				private void MoveNext()
				{
				}

				// Token: 0x06006A72 RID: 27250 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006A72")]
				[Address(RVA = "0xB99974", Offset = "0xB99974", VA = "0xB99974", Slot = "5")]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}

				// Token: 0x0400A7DB RID: 42971
				[Token(Token = "0x400A7DB")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public int <>1__state;

				// Token: 0x0400A7DC RID: 42972
				[Token(Token = "0x400A7DC")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				public AsyncTaskMethodBuilder <>t__builder;

				// Token: 0x0400A7DD RID: 42973
				[Token(Token = "0x400A7DD")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private Dictionary<string, NatDevice>.ValueCollection.Enumerator <>7__wrap1;

				// Token: 0x0400A7DE RID: 42974
				[Token(Token = "0x400A7DE")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private TaskAwaiter <>u__1;
			}
		}

		// Token: 0x02000E44 RID: 3652
		[Token(Token = "0x2000E44")]
		[StructLayout(3)]
		private struct <DiscoverAsync>d__7 : FileAPI
		{
			// Token: 0x06006A73 RID: 27251 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A73")]
			[Address(RVA = "0xB999E8", Offset = "0xB999E8", VA = "0xB999E8", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x06006A74 RID: 27252 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A74")]
			[Address(RVA = "0xB9AADC", Offset = "0xB9AADC", VA = "0xB9AADC", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x0400A7DF RID: 42975
			[Token(Token = "0x400A7DF")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x0400A7E0 RID: 42976
			[Token(Token = "0x400A7E0")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder<IEnumerable<NatDevice>> <>t__builder;

			// Token: 0x0400A7E1 RID: 42977
			[Token(Token = "0x400A7E1")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool onlyOne;

			// Token: 0x0400A7E2 RID: 42978
			[Token(Token = "0x400A7E2")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public CancellationTokenSource cts;

			// Token: 0x0400A7E3 RID: 42979
			[Token(Token = "0x400A7E3")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PortMapper portMapper;

			// Token: 0x0400A7E4 RID: 42980
			[Token(Token = "0x400A7E4")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private List<Task<IEnumerable<NatDevice>>> <searcherTasks>5__2;

			// Token: 0x0400A7E5 RID: 42981
			[Token(Token = "0x400A7E5")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private TaskAwaiter<IEnumerable<NatDevice>[]> <>u__1;
		}
	}
}
