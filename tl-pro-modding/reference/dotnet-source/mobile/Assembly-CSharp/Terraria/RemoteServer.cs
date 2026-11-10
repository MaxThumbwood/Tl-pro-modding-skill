using System;
using Il2CppDummyDll;
using Telepathy;

namespace Terraria
{
	// Token: 0x020004E6 RID: 1254
	[Token(Token = "0x20004E6")]
	public class RemoteServer
	{
		// Token: 0x06003162 RID: 12642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003162")]
		[Address(RVA = "0x19F99E4", Offset = "0x19F99E4", VA = "0x19F99E4")]
		public RemoteServer()
		{
		}

		// Token: 0x040041F3 RID: 16883
		[Token(Token = "0x40041F3")]
		[FieldOffset(Offset = "0x8")]
		public Server Client;

		// Token: 0x040041F4 RID: 16884
		[Token(Token = "0x40041F4")]
		[FieldOffset(Offset = "0xC")]
		public bool IsActive;

		// Token: 0x040041F5 RID: 16885
		[Token(Token = "0x40041F5")]
		[FieldOffset(Offset = "0x10")]
		public int State;

		// Token: 0x040041F6 RID: 16886
		[Token(Token = "0x40041F6")]
		[FieldOffset(Offset = "0x14")]
		public int TimeOutTimer;

		// Token: 0x040041F7 RID: 16887
		[Token(Token = "0x40041F7")]
		[FieldOffset(Offset = "0x18")]
		public string StatusText;

		// Token: 0x040041F8 RID: 16888
		[Token(Token = "0x40041F8")]
		[FieldOffset(Offset = "0x1C")]
		public int StatusCount;

		// Token: 0x040041F9 RID: 16889
		[Token(Token = "0x40041F9")]
		[FieldOffset(Offset = "0x20")]
		public int StatusMax;
	}
}
