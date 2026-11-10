using System;
using Il2CppDummyDll;

namespace Open.Nat
{
	// Token: 0x02000E45 RID: 3653
	[Token(Token = "0x2000E45")]
	internal static class PmpConstants
	{
		// Token: 0x0400A7E6 RID: 42982
		[Token(Token = "0x400A7E6")]
		public const byte Version = 0;

		// Token: 0x0400A7E7 RID: 42983
		[Token(Token = "0x400A7E7")]
		public const byte OperationExternalAddressRequest = 0;

		// Token: 0x0400A7E8 RID: 42984
		[Token(Token = "0x400A7E8")]
		public const byte OperationCodeUdp = 1;

		// Token: 0x0400A7E9 RID: 42985
		[Token(Token = "0x400A7E9")]
		public const byte OperationCodeTcp = 2;

		// Token: 0x0400A7EA RID: 42986
		[Token(Token = "0x400A7EA")]
		public const byte ServerNoop = 128;

		// Token: 0x0400A7EB RID: 42987
		[Token(Token = "0x400A7EB")]
		public const int ClientPort = 5350;

		// Token: 0x0400A7EC RID: 42988
		[Token(Token = "0x400A7EC")]
		public const int ServerPort = 5351;

		// Token: 0x0400A7ED RID: 42989
		[Token(Token = "0x400A7ED")]
		public const int RetryDelay = 250;

		// Token: 0x0400A7EE RID: 42990
		[Token(Token = "0x400A7EE")]
		public const int RetryAttempts = 9;

		// Token: 0x0400A7EF RID: 42991
		[Token(Token = "0x400A7EF")]
		public const int RecommendedLeaseTime = 3600;

		// Token: 0x0400A7F0 RID: 42992
		[Token(Token = "0x400A7F0")]
		public const int DefaultLeaseTime = 3600;

		// Token: 0x0400A7F1 RID: 42993
		[Token(Token = "0x400A7F1")]
		public const short ResultCodeSuccess = 0;

		// Token: 0x0400A7F2 RID: 42994
		[Token(Token = "0x400A7F2")]
		public const short ResultCodeUnsupportedVersion = 1;

		// Token: 0x0400A7F3 RID: 42995
		[Token(Token = "0x400A7F3")]
		public const short ResultCodeNotAuthorized = 2;

		// Token: 0x0400A7F4 RID: 42996
		[Token(Token = "0x400A7F4")]
		public const short ResultCodeNetworkFailure = 3;

		// Token: 0x0400A7F5 RID: 42997
		[Token(Token = "0x400A7F5")]
		public const short ResultCodeOutOfResources = 4;

		// Token: 0x0400A7F6 RID: 42998
		[Token(Token = "0x400A7F6")]
		public const short ResultCodeUnsupportedOperationCode = 5;
	}
}
