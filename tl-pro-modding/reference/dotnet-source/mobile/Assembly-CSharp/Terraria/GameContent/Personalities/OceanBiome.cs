using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x02000A1D RID: 2589
	[Token(Token = "0x2000A1D")]
	public class OceanBiome : AShoppingBiome
	{
		// Token: 0x060053E8 RID: 21480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053E8")]
		[Address(RVA = "0x80C3B0", Offset = "0x80C3B0", VA = "0x80C3B0")]
		public OceanBiome()
		{
		}

		// Token: 0x060053E9 RID: 21481 RVA: 0x00026F70 File Offset: 0x00025170
		[Token(Token = "0x60053E9")]
		[Address(RVA = "0x80C6B0", Offset = "0x80C6B0", VA = "0x80C6B0", Slot = "4")]
		public override bool IsInBiome(Player player)
		{
			return default(bool);
		}
	}
}
