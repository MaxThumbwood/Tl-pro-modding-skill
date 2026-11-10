using System;
using Il2CppDummyDll;

namespace Terraria.Net
{
	// Token: 0x020007FD RID: 2045
	[Token(Token = "0x20007FD")]
	public enum ServerMode : byte
	{
		// Token: 0x04008D38 RID: 36152
		[Token(Token = "0x4008D38")]
		None,
		// Token: 0x04008D39 RID: 36153
		[Token(Token = "0x4008D39")]
		Lobby,
		// Token: 0x04008D3A RID: 36154
		[Token(Token = "0x4008D3A")]
		FriendsCanJoin,
		// Token: 0x04008D3B RID: 36155
		[Token(Token = "0x4008D3B")]
		FriendsOfFriends = 4
	}
}
