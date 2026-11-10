using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Open.Nat
{
	// Token: 0x02000E38 RID: 3640
	[Token(Token = "0x2000E38")]
	public abstract class NatDevice
	{
		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x06006A3F RID: 27199
		[Token(Token = "0x17000B74")]
		public abstract IPEndPoint HostEndPoint
		{
			[Token(Token = "0x6006A3F")]
			get;
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x06006A40 RID: 27200
		[Token(Token = "0x17000B75")]
		public abstract IPAddress LocalAddress
		{
			[Token(Token = "0x6006A40")]
			get;
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x06006A41 RID: 27201 RVA: 0x00030138 File Offset: 0x0002E338
		// (set) Token: 0x06006A42 RID: 27202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B76")]
		private protected DateTime LastSeen
		{
			[Token(Token = "0x6006A41")]
			[Address(RVA = "0xB95E04", Offset = "0xB95E04", VA = "0xB95E04")]
			protected get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6006A42")]
			[Address(RVA = "0xB95E10", Offset = "0xB95E10", VA = "0xB95E10")]
			private set
			{
			}
		}

		// Token: 0x06006A43 RID: 27203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A43")]
		[Address(RVA = "0xB95E20", Offset = "0xB95E20", VA = "0xB95E20")]
		internal void Touch()
		{
		}

		// Token: 0x06006A44 RID: 27204
		[Token(Token = "0x6006A44")]
		public abstract Task CreatePortMapAsync(Mapping mapping);

		// Token: 0x06006A45 RID: 27205
		[Token(Token = "0x6006A45")]
		public abstract Task DeletePortMapAsync(Mapping mapping);

		// Token: 0x06006A46 RID: 27206
		[Token(Token = "0x6006A46")]
		public abstract Task<IEnumerable<Mapping>> GetAllMappingsAsync();

		// Token: 0x06006A47 RID: 27207
		[Token(Token = "0x6006A47")]
		public abstract Task<IPAddress> GetExternalIPAsync();

		// Token: 0x06006A48 RID: 27208
		[Token(Token = "0x6006A48")]
		public abstract Task<Mapping> GetSpecificMappingAsync(Protocol protocol, int port);

		// Token: 0x06006A49 RID: 27209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A49")]
		[Address(RVA = "0xB95E98", Offset = "0xB95E98", VA = "0xB95E98")]
		protected void RegisterMapping(Mapping mapping)
		{
		}

		// Token: 0x06006A4A RID: 27210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A4A")]
		[Address(RVA = "0xB95F40", Offset = "0xB95F40", VA = "0xB95F40")]
		protected void UnregisterMapping(Mapping mapping)
		{
		}

		// Token: 0x06006A4B RID: 27211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A4B")]
		[Address(RVA = "0xB96070", Offset = "0xB96070", VA = "0xB96070")]
		internal void ReleaseMapping(IEnumerable<Mapping> mappings)
		{
		}

		// Token: 0x06006A4C RID: 27212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A4C")]
		[Address(RVA = "0xB96440", Offset = "0xB96440", VA = "0xB96440")]
		internal void ReleaseAll()
		{
		}

		// Token: 0x06006A4D RID: 27213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A4D")]
		[Address(RVA = "0xB96448", Offset = "0xB96448", VA = "0xB96448")]
		internal void ReleaseSessionMappings()
		{
		}

		// Token: 0x06006A4E RID: 27214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A4E")]
		[Address(RVA = "0xB96580", Offset = "0xB96580", VA = "0xB96580")]
		internal Task RenewMappings()
		{
			return null;
		}

		// Token: 0x06006A4F RID: 27215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A4F")]
		[Address(RVA = "0xB96664", Offset = "0xB96664", VA = "0xB96664")]
		private Task RenewMapping(Mapping mapping)
		{
			return null;
		}

		// Token: 0x06006A50 RID: 27216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A50")]
		[Address(RVA = "0xB96750", Offset = "0xB96750", VA = "0xB96750")]
		protected NatDevice()
		{
		}

		// Token: 0x0400A7B0 RID: 42928
		[Token(Token = "0x400A7B0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly HashSet<Mapping> _openedMapping;

		// Token: 0x0400A7B1 RID: 42929
		[Token(Token = "0x400A7B1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private DateTime <LastSeen>k__BackingField;

		// Token: 0x02000E39 RID: 3641
		[Token(Token = "0x2000E39")]
		private sealed class <>c__DisplayClass16_0
		{
			// Token: 0x06006A51 RID: 27217 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A51")]
			[Address(RVA = "0xB96068", Offset = "0xB96068", VA = "0xB96068")]
			public <>c__DisplayClass16_0()
			{
			}

			// Token: 0x06006A52 RID: 27218 RVA: 0x00030150 File Offset: 0x0002E350
			[Token(Token = "0x6006A52")]
			[Address(RVA = "0xB967E8", Offset = "0xB967E8", VA = "0xB967E8")]
			internal bool <UnregisterMapping>b__0(Mapping x)
			{
				return default(bool);
			}

			// Token: 0x0400A7B2 RID: 42930
			[Token(Token = "0x400A7B2")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Mapping mapping;
		}

		// Token: 0x02000E3A RID: 3642
		[Token(Token = "0x2000E3A")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006A54 RID: 27220 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A54")]
			[Address(RVA = "0xB96890", Offset = "0xB96890", VA = "0xB96890")]
			public <>c()
			{
			}

			// Token: 0x06006A55 RID: 27221 RVA: 0x00030168 File Offset: 0x0002E368
			[Token(Token = "0x6006A55")]
			[Address(RVA = "0xB96898", Offset = "0xB96898", VA = "0xB96898")]
			internal bool <ReleaseSessionMappings>b__19_0(Mapping m)
			{
				return default(bool);
			}

			// Token: 0x06006A56 RID: 27222 RVA: 0x00030180 File Offset: 0x0002E380
			[Token(Token = "0x6006A56")]
			[Address(RVA = "0xB968C0", Offset = "0xB968C0", VA = "0xB968C0")]
			internal bool <RenewMappings>b__20_0(Mapping x)
			{
				return default(bool);
			}

			// Token: 0x0400A7B3 RID: 42931
			[Token(Token = "0x400A7B3")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly NatDevice.<>c <>9;

			// Token: 0x0400A7B4 RID: 42932
			[Token(Token = "0x400A7B4")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static Func<Mapping, bool> <>9__19_0;

			// Token: 0x0400A7B5 RID: 42933
			[Token(Token = "0x400A7B5")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Mapping, bool> <>9__20_0;
		}

		// Token: 0x02000E3B RID: 3643
		[Token(Token = "0x2000E3B")]
		[StructLayout(3)]
		private struct <RenewMappings>d__20 : FileAPI
		{
			// Token: 0x06006A57 RID: 27223 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A57")]
			[Address(RVA = "0xB96984", Offset = "0xB96984", VA = "0xB96984", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x06006A58 RID: 27224 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A58")]
			[Address(RVA = "0xB96D70", Offset = "0xB96D70", VA = "0xB96D70", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x0400A7B6 RID: 42934
			[Token(Token = "0x400A7B6")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x0400A7B7 RID: 42935
			[Token(Token = "0x400A7B7")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400A7B8 RID: 42936
			[Token(Token = "0x400A7B8")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public NatDevice <>4__this;

			// Token: 0x0400A7B9 RID: 42937
			[Token(Token = "0x400A7B9")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private Mapping[] <>7__wrap1;

			// Token: 0x0400A7BA RID: 42938
			[Token(Token = "0x400A7BA")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private int <>7__wrap2;

			// Token: 0x0400A7BB RID: 42939
			[Token(Token = "0x400A7BB")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000E3C RID: 3644
		[Token(Token = "0x2000E3C")]
		[StructLayout(3)]
		private struct <RenewMapping>d__21 : FileAPI
		{
			// Token: 0x06006A59 RID: 27225 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A59")]
			[Address(RVA = "0xB96DE4", Offset = "0xB96DE4", VA = "0xB96DE4", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x06006A5A RID: 27226 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A5A")]
			[Address(RVA = "0xB97490", Offset = "0xB97490", VA = "0xB97490", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x0400A7BC RID: 42940
			[Token(Token = "0x400A7BC")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x0400A7BD RID: 42941
			[Token(Token = "0x400A7BD")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400A7BE RID: 42942
			[Token(Token = "0x400A7BE")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Mapping mapping;

			// Token: 0x0400A7BF RID: 42943
			[Token(Token = "0x400A7BF")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public NatDevice <>4__this;

			// Token: 0x0400A7C0 RID: 42944
			[Token(Token = "0x400A7C0")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Mapping <renewMapping>5__2;

			// Token: 0x0400A7C1 RID: 42945
			[Token(Token = "0x400A7C1")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private TaskAwaiter <>u__1;
		}
	}
}
