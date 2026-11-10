using System;
using Il2CppDummyDll;

namespace Terraria.Net
{
	// Token: 0x020007FB RID: 2043
	[Token(Token = "0x20007FB")]
	public abstract class RemoteAddress
	{
		// Token: 0x0600461E RID: 17950
		[Token(Token = "0x600461E")]
		public abstract string GetIdentifier();

		// Token: 0x0600461F RID: 17951
		[Token(Token = "0x600461F")]
		public abstract string GetFriendlyName();

		// Token: 0x06004620 RID: 17952
		[Token(Token = "0x6004620")]
		public abstract bool IsLocalHost();

		// Token: 0x06004621 RID: 17953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004621")]
		[Address(RVA = "0x58B814", Offset = "0x58B814", VA = "0x58B814")]
		protected RemoteAddress()
		{
		}

		// Token: 0x04008D33 RID: 36147
		[Token(Token = "0x4008D33")]
		[FieldOffset(Offset = "0x8")]
		public AddressType Type;
	}
}
