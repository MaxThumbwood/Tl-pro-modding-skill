using System;
using System.Collections.Generic;
using System.Net;
using Il2CppDummyDll;

namespace Open.Nat
{
	// Token: 0x02000E6B RID: 3691
	[Token(Token = "0x2000E6B")]
	internal interface IIPAddressesProvider
	{
		// Token: 0x06006B04 RID: 27396
		[Token(Token = "0x6006B04")]
		IEnumerable<IPAddress> DnsAddresses();

		// Token: 0x06006B05 RID: 27397
		[Token(Token = "0x6006B05")]
		IEnumerable<IPAddress> GatewayAddresses();

		// Token: 0x06006B06 RID: 27398
		[Token(Token = "0x6006B06")]
		IEnumerable<IPAddress> UnicastAddresses();
	}
}
