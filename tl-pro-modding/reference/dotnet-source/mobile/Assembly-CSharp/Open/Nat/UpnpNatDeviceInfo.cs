using System;
using System.Net;
using Il2CppDummyDll;

namespace Open.Nat
{
	// Token: 0x02000E64 RID: 3684
	[Token(Token = "0x2000E64")]
	internal class UpnpNatDeviceInfo
	{
		// Token: 0x06006ADD RID: 27357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ADD")]
		[Address(RVA = "0xBA64E0", Offset = "0xBA64E0", VA = "0xBA64E0")]
		public UpnpNatDeviceInfo(IPAddress localAddress, Uri locationUri, string serviceControlUrl, string serviceType)
		{
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x06006ADE RID: 27358 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006ADF RID: 27359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B85")]
		public IPEndPoint HostEndPoint
		{
			[Token(Token = "0x6006ADE")]
			[Address(RVA = "0xBA693C", Offset = "0xBA693C", VA = "0xBA693C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006ADF")]
			[Address(RVA = "0xBA6944", Offset = "0xBA6944", VA = "0xBA6944")]
			private set
			{
			}
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x06006AE0 RID: 27360 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006AE1 RID: 27361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B86")]
		public IPAddress LocalAddress
		{
			[Token(Token = "0x6006AE0")]
			[Address(RVA = "0xBA694C", Offset = "0xBA694C", VA = "0xBA694C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006AE1")]
			[Address(RVA = "0xBA6954", Offset = "0xBA6954", VA = "0xBA6954")]
			private set
			{
			}
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x06006AE2 RID: 27362 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006AE3 RID: 27363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B87")]
		public string ServiceType
		{
			[Token(Token = "0x6006AE2")]
			[Address(RVA = "0xBA695C", Offset = "0xBA695C", VA = "0xBA695C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006AE3")]
			[Address(RVA = "0xBA6964", Offset = "0xBA6964", VA = "0xBA6964")]
			private set
			{
			}
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x06006AE4 RID: 27364 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006AE5 RID: 27365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B88")]
		public Uri ServiceControlUri
		{
			[Token(Token = "0x6006AE4")]
			[Address(RVA = "0xBA696C", Offset = "0xBA696C", VA = "0xBA696C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006AE5")]
			[Address(RVA = "0xBA6974", Offset = "0xBA6974", VA = "0xBA6974")]
			private set
			{
			}
		}

		// Token: 0x0400A870 RID: 43120
		[Token(Token = "0x400A870")]
		[FieldOffset(Offset = "0x8")]
		private IPEndPoint <HostEndPoint>k__BackingField;

		// Token: 0x0400A871 RID: 43121
		[Token(Token = "0x400A871")]
		[FieldOffset(Offset = "0xC")]
		private IPAddress <LocalAddress>k__BackingField;

		// Token: 0x0400A872 RID: 43122
		[Token(Token = "0x400A872")]
		[FieldOffset(Offset = "0x10")]
		private string <ServiceType>k__BackingField;

		// Token: 0x0400A873 RID: 43123
		[Token(Token = "0x400A873")]
		[FieldOffset(Offset = "0x14")]
		private Uri <ServiceControlUri>k__BackingField;
	}
}
