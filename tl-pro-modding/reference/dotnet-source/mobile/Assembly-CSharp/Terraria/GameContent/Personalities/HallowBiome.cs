using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x02000A23 RID: 2595
	[Token(Token = "0x2000A23")]
	public class HallowBiome : AShoppingBiome
	{
		// Token: 0x060053F4 RID: 21492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053F4")]
		[Address(RVA = "0x80C5D8", Offset = "0x80C5D8", VA = "0x80C5D8")]
		public HallowBiome()
		{
		}

		// Token: 0x060053F5 RID: 21493 RVA: 0x00027000 File Offset: 0x00025200
		[Token(Token = "0x60053F5")]
		[Address(RVA = "0x80C788", Offset = "0x80C788", VA = "0x80C788", Slot = "4")]
		public override bool IsInBiome(Player player)
		{
			return default(bool);
		}
	}
}
