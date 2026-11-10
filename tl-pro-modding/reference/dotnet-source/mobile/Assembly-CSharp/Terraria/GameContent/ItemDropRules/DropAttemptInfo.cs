using System;
using Il2CppDummyDll;
using Terraria.Utilities;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000A7E RID: 2686
	[Token(Token = "0x2000A7E")]
	public struct DropAttemptInfo
	{
		// Token: 0x0400989A RID: 39066
		[Token(Token = "0x400989A")]
		[FieldOffset(Offset = "0x0")]
		public NPC npc;

		// Token: 0x0400989B RID: 39067
		[Token(Token = "0x400989B")]
		[FieldOffset(Offset = "0x4")]
		public Player player;

		// Token: 0x0400989C RID: 39068
		[Token(Token = "0x400989C")]
		[FieldOffset(Offset = "0x8")]
		public UnifiedRandom rng;

		// Token: 0x0400989D RID: 39069
		[Token(Token = "0x400989D")]
		[FieldOffset(Offset = "0xC")]
		public bool IsInSimulation;

		// Token: 0x0400989E RID: 39070
		[Token(Token = "0x400989E")]
		[FieldOffset(Offset = "0xD")]
		public bool IsExpertMode;

		// Token: 0x0400989F RID: 39071
		[Token(Token = "0x400989F")]
		[FieldOffset(Offset = "0xE")]
		public bool IsMasterMode;
	}
}
