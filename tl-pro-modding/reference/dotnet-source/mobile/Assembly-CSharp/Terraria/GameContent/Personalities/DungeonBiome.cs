using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x02000A25 RID: 2597
	[Token(Token = "0x2000A25")]
	public class DungeonBiome : AShoppingBiome
	{
		// Token: 0x060053F8 RID: 21496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053F8")]
		[Address(RVA = "0x80C7D0", Offset = "0x80C7D0", VA = "0x80C7D0")]
		public DungeonBiome()
		{
		}

		// Token: 0x060053F9 RID: 21497 RVA: 0x00027030 File Offset: 0x00025230
		[Token(Token = "0x60053F9")]
		[Address(RVA = "0x80C82C", Offset = "0x80C82C", VA = "0x80C82C", Slot = "4")]
		public override bool IsInBiome(Player player)
		{
			return default(bool);
		}
	}
}
