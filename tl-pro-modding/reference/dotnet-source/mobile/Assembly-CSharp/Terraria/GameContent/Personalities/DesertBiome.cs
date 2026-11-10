using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x02000A20 RID: 2592
	[Token(Token = "0x2000A20")]
	public class DesertBiome : AShoppingBiome
	{
		// Token: 0x060053EE RID: 21486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053EE")]
		[Address(RVA = "0x80C4C4", Offset = "0x80C4C4", VA = "0x80C4C4")]
		public DesertBiome()
		{
		}

		// Token: 0x060053EF RID: 21487 RVA: 0x00026FB8 File Offset: 0x000251B8
		[Token(Token = "0x60053EF")]
		[Address(RVA = "0x80C71C", Offset = "0x80C71C", VA = "0x80C71C", Slot = "4")]
		public override bool IsInBiome(Player player)
		{
			return default(bool);
		}
	}
}
