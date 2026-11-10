using System;
using Il2CppDummyDll;

namespace Terraria.Enums
{
	// Token: 0x0200073B RID: 1851
	[Token(Token = "0x200073B")]
	public enum TownNPCRoomCheckFailureReason
	{
		// Token: 0x040089D3 RID: 35283
		[Token(Token = "0x40089D3")]
		None,
		// Token: 0x040089D4 RID: 35284
		[Token(Token = "0x40089D4")]
		TooCloseToWorldEdge,
		// Token: 0x040089D5 RID: 35285
		[Token(Token = "0x40089D5")]
		RoomIsTooBig,
		// Token: 0x040089D6 RID: 35286
		[Token(Token = "0x40089D6")]
		RoomIsTooSmall,
		// Token: 0x040089D7 RID: 35287
		[Token(Token = "0x40089D7")]
		HoleInWallIsTooBig,
		// Token: 0x040089D8 RID: 35288
		[Token(Token = "0x40089D8")]
		RoomCheckStartedInASolidTile,
		// Token: 0x040089D9 RID: 35289
		[Token(Token = "0x40089D9")]
		TooManyUnsafeWalls
	}
}
