using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x02000A26 RID: 2598
	[Token(Token = "0x2000A26")]
	public class CorruptionBiome : AShoppingBiome
	{
		// Token: 0x060053FA RID: 21498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053FA")]
		[Address(RVA = "0x80C850", Offset = "0x80C850", VA = "0x80C850")]
		public CorruptionBiome()
		{
		}

		// Token: 0x060053FB RID: 21499 RVA: 0x00027048 File Offset: 0x00025248
		[Token(Token = "0x60053FB")]
		[Address(RVA = "0x80C8AC", Offset = "0x80C8AC", VA = "0x80C8AC", Slot = "4")]
		public override bool IsInBiome(Player player)
		{
			return default(bool);
		}
	}
}
