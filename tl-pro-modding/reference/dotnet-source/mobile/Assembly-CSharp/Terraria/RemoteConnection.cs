using System;
using Il2CppDummyDll;
using Telepathy;

namespace Terraria
{
	// Token: 0x020004E5 RID: 1253
	[Token(Token = "0x20004E5")]
	public class RemoteConnection
	{
		// Token: 0x06003161 RID: 12641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003161")]
		[Address(RVA = "0x19F9968", Offset = "0x19F9968", VA = "0x19F9968")]
		public RemoteConnection()
		{
		}

		// Token: 0x040041EC RID: 16876
		[Token(Token = "0x40041EC")]
		[FieldOffset(Offset = "0x8")]
		public Client Client;

		// Token: 0x040041ED RID: 16877
		[Token(Token = "0x40041ED")]
		[FieldOffset(Offset = "0xC")]
		public bool IsActive;

		// Token: 0x040041EE RID: 16878
		[Token(Token = "0x40041EE")]
		[FieldOffset(Offset = "0x10")]
		public int State;

		// Token: 0x040041EF RID: 16879
		[Token(Token = "0x40041EF")]
		[FieldOffset(Offset = "0x14")]
		public int TimeOutTimer;

		// Token: 0x040041F0 RID: 16880
		[Token(Token = "0x40041F0")]
		[FieldOffset(Offset = "0x18")]
		public string StatusText;

		// Token: 0x040041F1 RID: 16881
		[Token(Token = "0x40041F1")]
		[FieldOffset(Offset = "0x1C")]
		public int StatusCount;

		// Token: 0x040041F2 RID: 16882
		[Token(Token = "0x40041F2")]
		[FieldOffset(Offset = "0x20")]
		public int StatusMax;
	}
}
