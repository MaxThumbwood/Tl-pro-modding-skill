using System;
using System.Net;
using System.Xml;
using Il2CppDummyDll;

namespace Open.Nat
{
	// Token: 0x02000E56 RID: 3670
	[Token(Token = "0x2000E56")]
	internal class GetExternalIPAddressResponseMessage : ResponseMessageBase
	{
		// Token: 0x06006AA8 RID: 27304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AA8")]
		[Address(RVA = "0xB9FC10", Offset = "0xB9FC10", VA = "0xB9FC10")]
		public GetExternalIPAddressResponseMessage(XmlDocument response, string serviceType)
		{
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x06006AA9 RID: 27305 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006AAA RID: 27306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B7A")]
		public IPAddress ExternalIPAddress
		{
			[Token(Token = "0x6006AA9")]
			[Address(RVA = "0xBA0060", Offset = "0xBA0060", VA = "0xBA0060")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006AAA")]
			[Address(RVA = "0xBA0068", Offset = "0xBA0068", VA = "0xBA0068")]
			private set
			{
			}
		}

		// Token: 0x0400A826 RID: 43046
		[Token(Token = "0x400A826")]
		[FieldOffset(Offset = "0x14")]
		private IPAddress <ExternalIPAddress>k__BackingField;
	}
}
