using System;
using System.Net;
using Il2CppDummyDll;

namespace Terraria.Net
{
	// Token: 0x020007FC RID: 2044
	[Token(Token = "0x20007FC")]
	public class TcpAddress : RemoteAddress
	{
		// Token: 0x06004622 RID: 17954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004622")]
		[Address(RVA = "0x58B81C", Offset = "0x58B81C", VA = "0x58B81C")]
		public TcpAddress(IPAddress address, int port)
		{
		}

		// Token: 0x06004623 RID: 17955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004623")]
		[Address(RVA = "0x58B848", Offset = "0x58B848", VA = "0x58B848")]
		public TcpAddress(string host, int port)
		{
		}

		// Token: 0x06004624 RID: 17956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004624")]
		[Address(RVA = "0x58B874", Offset = "0x58B874", VA = "0x58B874", Slot = "4")]
		public override string GetIdentifier()
		{
			return null;
		}

		// Token: 0x06004625 RID: 17957 RVA: 0x00021438 File Offset: 0x0001F638
		[Token(Token = "0x6004625")]
		[Address(RVA = "0x58B8A0", Offset = "0x58B8A0", VA = "0x58B8A0", Slot = "6")]
		public override bool IsLocalHost()
		{
			return default(bool);
		}

		// Token: 0x06004626 RID: 17958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004626")]
		[Address(RVA = "0x58B930", Offset = "0x58B930", VA = "0x58B930", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004627 RID: 17959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004627")]
		[Address(RVA = "0x58BA64", Offset = "0x58BA64", VA = "0x58BA64", Slot = "5")]
		public override string GetFriendlyName()
		{
			return null;
		}

		// Token: 0x06004628 RID: 17960 RVA: 0x00021450 File Offset: 0x0001F650
		[Token(Token = "0x6004628")]
		[Address(RVA = "0x58BA74", Offset = "0x58BA74", VA = "0x58BA74")]
		public static bool IsLocalHost(string addressString)
		{
			return default(bool);
		}

		// Token: 0x04008D34 RID: 36148
		[Token(Token = "0x4008D34")]
		[FieldOffset(Offset = "0xC")]
		public string Host;

		// Token: 0x04008D35 RID: 36149
		[Token(Token = "0x4008D35")]
		[FieldOffset(Offset = "0x10")]
		public IPAddress Address;

		// Token: 0x04008D36 RID: 36150
		[Token(Token = "0x4008D36")]
		[FieldOffset(Offset = "0x14")]
		public int Port;
	}
}
