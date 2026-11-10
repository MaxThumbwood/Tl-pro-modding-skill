using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x02000A2A RID: 2602
	[Token(Token = "0x2000A2A")]
	public struct HelperInfo
	{
		// Token: 0x040097AC RID: 38828
		[Token(Token = "0x40097AC")]
		[FieldOffset(Offset = "0x0")]
		public Player player;

		// Token: 0x040097AD RID: 38829
		[Token(Token = "0x40097AD")]
		[FieldOffset(Offset = "0x4")]
		public NPC npc;

		// Token: 0x040097AE RID: 38830
		[Token(Token = "0x40097AE")]
		[FieldOffset(Offset = "0x8")]
		public List<NPC> NearbyNPCs;

		// Token: 0x040097AF RID: 38831
		[Token(Token = "0x40097AF")]
		[FieldOffset(Offset = "0xC")]
		public bool[] nearbyNPCsByType;
	}
}
