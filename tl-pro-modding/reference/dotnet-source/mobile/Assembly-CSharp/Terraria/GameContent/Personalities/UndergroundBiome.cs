using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x02000A22 RID: 2594
	[Token(Token = "0x2000A22")]
	public class UndergroundBiome : AShoppingBiome
	{
		// Token: 0x060053F2 RID: 21490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053F2")]
		[Address(RVA = "0x80C57C", Offset = "0x80C57C", VA = "0x80C57C")]
		public UndergroundBiome()
		{
		}

		// Token: 0x060053F3 RID: 21491 RVA: 0x00026FE8 File Offset: 0x000251E8
		[Token(Token = "0x60053F3")]
		[Address(RVA = "0x80C764", Offset = "0x80C764", VA = "0x80C764", Slot = "4")]
		public override bool IsInBiome(Player player)
		{
			return default(bool);
		}
	}
}
