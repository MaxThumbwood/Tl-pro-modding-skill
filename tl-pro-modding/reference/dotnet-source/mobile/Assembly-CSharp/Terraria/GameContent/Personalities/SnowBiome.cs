using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x02000A1F RID: 2591
	[Token(Token = "0x2000A1F")]
	public class SnowBiome : AShoppingBiome
	{
		// Token: 0x060053EC RID: 21484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053EC")]
		[Address(RVA = "0x80C468", Offset = "0x80C468", VA = "0x80C468")]
		public SnowBiome()
		{
		}

		// Token: 0x060053ED RID: 21485 RVA: 0x00026FA0 File Offset: 0x000251A0
		[Token(Token = "0x60053ED")]
		[Address(RVA = "0x80C6F8", Offset = "0x80C6F8", VA = "0x80C6F8", Slot = "4")]
		public override bool IsInBiome(Player player)
		{
			return default(bool);
		}
	}
}
