using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x02000A21 RID: 2593
	[Token(Token = "0x2000A21")]
	public class JungleBiome : AShoppingBiome
	{
		// Token: 0x060053F0 RID: 21488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053F0")]
		[Address(RVA = "0x80C520", Offset = "0x80C520", VA = "0x80C520")]
		public JungleBiome()
		{
		}

		// Token: 0x060053F1 RID: 21489 RVA: 0x00026FD0 File Offset: 0x000251D0
		[Token(Token = "0x60053F1")]
		[Address(RVA = "0x80C740", Offset = "0x80C740", VA = "0x80C740", Slot = "4")]
		public override bool IsInBiome(Player player)
		{
			return default(bool);
		}
	}
}
