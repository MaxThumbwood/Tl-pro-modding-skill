using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Xml;
using Il2CppDummyDll;

namespace Open.Nat
{
	// Token: 0x02000E5E RID: 3678
	[Token(Token = "0x2000E5E")]
	internal sealed class UpnpNatDevice : NatDevice
	{
		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x06006ACA RID: 27338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B83")]
		public override IPEndPoint HostEndPoint
		{
			[Token(Token = "0x6006ACA")]
			[Address(RVA = "0xBA2C40", Offset = "0xBA2C40", VA = "0xBA2C40", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x06006ACB RID: 27339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B84")]
		public override IPAddress LocalAddress
		{
			[Token(Token = "0x6006ACB")]
			[Address(RVA = "0xBA2C64", Offset = "0xBA2C64", VA = "0xBA2C64", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006ACC RID: 27340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ACC")]
		[Address(RVA = "0xBA2C88", Offset = "0xBA2C88", VA = "0xBA2C88")]
		internal UpnpNatDevice(UpnpNatDeviceInfo deviceInfo)
		{
		}

		// Token: 0x06006ACD RID: 27341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006ACD")]
		[Address(RVA = "0xBA2E28", Offset = "0xBA2E28", VA = "0xBA2E28", Slot = "9")]
		public override Task<IPAddress> GetExternalIPAsync()
		{
			return null;
		}

		// Token: 0x06006ACE RID: 27342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006ACE")]
		[Address(RVA = "0xBA2F48", Offset = "0xBA2F48", VA = "0xBA2F48", Slot = "6")]
		public override Task CreatePortMapAsync(Mapping mapping)
		{
			return null;
		}

		// Token: 0x06006ACF RID: 27343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006ACF")]
		[Address(RVA = "0xBA3044", Offset = "0xBA3044", VA = "0xBA3044", Slot = "7")]
		public override Task DeletePortMapAsync(Mapping mapping)
		{
			return null;
		}

		// Token: 0x06006AD0 RID: 27344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AD0")]
		[Address(RVA = "0xBA3134", Offset = "0xBA3134", VA = "0xBA3134", Slot = "8")]
		public override Task<IEnumerable<Mapping>> GetAllMappingsAsync()
		{
			return null;
		}

		// Token: 0x06006AD1 RID: 27345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AD1")]
		[Address(RVA = "0xBA3248", Offset = "0xBA3248", VA = "0xBA3248", Slot = "10")]
		public override Task<Mapping> GetSpecificMappingAsync(Protocol protocol, int publicPort)
		{
			return null;
		}

		// Token: 0x06006AD2 RID: 27346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AD2")]
		[Address(RVA = "0xBA336C", Offset = "0xBA336C", VA = "0xBA336C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400A852 RID: 43090
		[Token(Token = "0x400A852")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal readonly UpnpNatDeviceInfo DeviceInfo;

		// Token: 0x0400A853 RID: 43091
		[Token(Token = "0x400A853")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private readonly SoapClient _soapClient;

		// Token: 0x02000E5F RID: 3679
		[Token(Token = "0x2000E5F")]
		[StructLayout(3)]
		private struct <GetExternalIPAsync>d__7 : FileAPI
		{
			// Token: 0x06006AD3 RID: 27347 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AD3")]
			[Address(RVA = "0xBA3540", Offset = "0xBA3540", VA = "0xBA3540", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x06006AD4 RID: 27348 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AD4")]
			[Address(RVA = "0xBA3A54", Offset = "0xBA3A54", VA = "0xBA3A54", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x0400A854 RID: 43092
			[Token(Token = "0x400A854")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x0400A855 RID: 43093
			[Token(Token = "0x400A855")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder<IPAddress> <>t__builder;

			// Token: 0x0400A856 RID: 43094
			[Token(Token = "0x400A856")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UpnpNatDevice <>4__this;

			// Token: 0x0400A857 RID: 43095
			[Token(Token = "0x400A857")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private TaskAwaiter<XmlDocument> <>u__1;
		}

		// Token: 0x02000E60 RID: 3680
		[Token(Token = "0x2000E60")]
		[StructLayout(3)]
		private struct <CreatePortMapAsync>d__8 : FileAPI
		{
			// Token: 0x06006AD5 RID: 27349 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AD5")]
			[Address(RVA = "0xBA3AE4", Offset = "0xBA3AE4", VA = "0xBA3AE4", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x06006AD6 RID: 27350 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AD6")]
			[Address(RVA = "0xBA4750", Offset = "0xBA4750", VA = "0xBA4750", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x0400A858 RID: 43096
			[Token(Token = "0x400A858")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x0400A859 RID: 43097
			[Token(Token = "0x400A859")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400A85A RID: 43098
			[Token(Token = "0x400A85A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Mapping mapping;

			// Token: 0x0400A85B RID: 43099
			[Token(Token = "0x400A85B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public UpnpNatDevice <>4__this;

			// Token: 0x0400A85C RID: 43100
			[Token(Token = "0x400A85C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private bool <retry>5__2;

			// Token: 0x0400A85D RID: 43101
			[Token(Token = "0x400A85D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private TaskAwaiter<XmlDocument> <>u__1;

			// Token: 0x0400A85E RID: 43102
			[Token(Token = "0x400A85E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private TaskAwaiter <>u__2;
		}

		// Token: 0x02000E61 RID: 3681
		[Token(Token = "0x2000E61")]
		[StructLayout(3)]
		private struct <DeletePortMapAsync>d__9 : FileAPI
		{
			// Token: 0x06006AD7 RID: 27351 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AD7")]
			[Address(RVA = "0xBA47C4", Offset = "0xBA47C4", VA = "0xBA47C4", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x06006AD8 RID: 27352 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AD8")]
			[Address(RVA = "0xBA4E38", Offset = "0xBA4E38", VA = "0xBA4E38", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x0400A85F RID: 43103
			[Token(Token = "0x400A85F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x0400A860 RID: 43104
			[Token(Token = "0x400A860")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400A861 RID: 43105
			[Token(Token = "0x400A861")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Mapping mapping;

			// Token: 0x0400A862 RID: 43106
			[Token(Token = "0x400A862")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public UpnpNatDevice <>4__this;

			// Token: 0x0400A863 RID: 43107
			[Token(Token = "0x400A863")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private TaskAwaiter<XmlDocument> <>u__1;
		}

		// Token: 0x02000E62 RID: 3682
		[Token(Token = "0x2000E62")]
		[StructLayout(3)]
		private struct <GetAllMappingsAsync>d__10 : FileAPI
		{
			// Token: 0x06006AD9 RID: 27353 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AD9")]
			[Address(RVA = "0xBA4EAC", Offset = "0xBA4EAC", VA = "0xBA4EAC", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x06006ADA RID: 27354 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006ADA")]
			[Address(RVA = "0xBA589C", Offset = "0xBA589C", VA = "0xBA589C", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x0400A864 RID: 43108
			[Token(Token = "0x400A864")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x0400A865 RID: 43109
			[Token(Token = "0x400A865")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder<IEnumerable<Mapping>> <>t__builder;

			// Token: 0x0400A866 RID: 43110
			[Token(Token = "0x400A866")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UpnpNatDevice <>4__this;

			// Token: 0x0400A867 RID: 43111
			[Token(Token = "0x400A867")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private int <index>5__2;

			// Token: 0x0400A868 RID: 43112
			[Token(Token = "0x400A868")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private List<Mapping> <mappings>5__3;

			// Token: 0x0400A869 RID: 43113
			[Token(Token = "0x400A869")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private TaskAwaiter<XmlDocument> <>u__1;
		}

		// Token: 0x02000E63 RID: 3683
		[Token(Token = "0x2000E63")]
		[StructLayout(3)]
		private struct <GetSpecificMappingAsync>d__11 : FileAPI
		{
			// Token: 0x06006ADB RID: 27355 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006ADB")]
			[Address(RVA = "0xBA592C", Offset = "0xBA592C", VA = "0xBA592C", Slot = "4")]
			private void MoveNext()
			{
			}

			// Token: 0x06006ADC RID: 27356 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006ADC")]
			[Address(RVA = "0xBA6450", Offset = "0xBA6450", VA = "0xBA6450", Slot = "5")]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x0400A86A RID: 43114
			[Token(Token = "0x400A86A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x0400A86B RID: 43115
			[Token(Token = "0x400A86B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder<Mapping> <>t__builder;

			// Token: 0x0400A86C RID: 43116
			[Token(Token = "0x400A86C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Protocol protocol;

			// Token: 0x0400A86D RID: 43117
			[Token(Token = "0x400A86D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int publicPort;

			// Token: 0x0400A86E RID: 43118
			[Token(Token = "0x400A86E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UpnpNatDevice <>4__this;

			// Token: 0x0400A86F RID: 43119
			[Token(Token = "0x400A86F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private TaskAwaiter<XmlDocument> <>u__1;
		}
	}
}
