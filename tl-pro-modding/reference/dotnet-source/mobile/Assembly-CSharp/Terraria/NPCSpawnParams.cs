using System;
using Il2CppDummyDll;

namespace Terraria
{
	// Token: 0x020004E7 RID: 1255
	[Token(Token = "0x20004E7")]
	public struct NPCSpawnParams
	{
		// Token: 0x06003163 RID: 12643 RVA: 0x00017E68 File Offset: 0x00016068
		[Token(Token = "0x6003163")]
		[Address(RVA = "0x19F9A60", Offset = "0x19F9A60", VA = "0x19F9A60")]
		public NPCSpawnParams WithScale(float scaleOverride)
		{
			return default(NPCSpawnParams);
		}

		// Token: 0x040041FA RID: 16890
		[Token(Token = "0x40041FA")]
		[FieldOffset(Offset = "0x0")]
		public float? sizeScaleOverride;

		// Token: 0x040041FB RID: 16891
		[Token(Token = "0x40041FB")]
		[FieldOffset(Offset = "0x8")]
		public int? playerCountForMultiplayerDifficultyOverride;

		// Token: 0x040041FC RID: 16892
		[Token(Token = "0x40041FC")]
		[FieldOffset(Offset = "0x10")]
		public float? difficultyOverride;
	}
}
