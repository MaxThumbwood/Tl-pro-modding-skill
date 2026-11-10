using System;
using System.Net;
using Il2CppDummyDll;

namespace Open.Nat
{
	// Token: 0x02000E6F RID: 3695
	[Token(Token = "0x2000E6F")]
	internal static class WellKnownConstants
	{
		// Token: 0x0400A88F RID: 43151
		[Token(Token = "0x400A88F")]
		[FieldOffset(Offset = "0x0")]
		public static IPAddress IPv4MulticastAddress;

		// Token: 0x0400A890 RID: 43152
		[Token(Token = "0x400A890")]
		[FieldOffset(Offset = "0x4")]
		public static IPAddress IPv6LinkLocalMulticastAddress;

		// Token: 0x0400A891 RID: 43153
		[Token(Token = "0x400A891")]
		[FieldOffset(Offset = "0x8")]
		public static IPAddress IPv6LinkSiteMulticastAddress;

		// Token: 0x0400A892 RID: 43154
		[Token(Token = "0x400A892")]
		[FieldOffset(Offset = "0xC")]
		public static IPEndPoint NatPmpEndPoint;
	}
}
