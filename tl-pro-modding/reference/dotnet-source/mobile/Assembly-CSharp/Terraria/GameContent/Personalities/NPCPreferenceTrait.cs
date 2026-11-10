using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x02000A19 RID: 2585
	[Token(Token = "0x2000A19")]
	public class NPCPreferenceTrait : FileAPI
	{
		// Token: 0x060053DB RID: 21467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053DB")]
		[Address(RVA = "0x80A040", Offset = "0x80A040", VA = "0x80A040", Slot = "4")]
		public void ModifyShopPrice(HelperInfo info, ShopHelper shopHelperInstance)
		{
		}

		// Token: 0x060053DC RID: 21468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053DC")]
		[Address(RVA = "0x80A130", Offset = "0x80A130", VA = "0x80A130")]
		public NPCPreferenceTrait()
		{
		}

		// Token: 0x040097A5 RID: 38821
		[Token(Token = "0x40097A5")]
		[FieldOffset(Offset = "0x8")]
		public AffectionLevel Level;

		// Token: 0x040097A6 RID: 38822
		[Token(Token = "0x40097A6")]
		[FieldOffset(Offset = "0xC")]
		public int NpcId;
	}
}
