using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x02000A28 RID: 2600
	[Token(Token = "0x2000A28")]
	public class PersonalityProfile
	{
		// Token: 0x060053FE RID: 21502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053FE")]
		[Address(RVA = "0x80A294", Offset = "0x80A294", VA = "0x80A294")]
		public PersonalityProfile()
		{
		}

		// Token: 0x040097AB RID: 38827
		[Token(Token = "0x40097AB")]
		[FieldOffset(Offset = "0x8")]
		public List<IShopPersonalityTrait> ShopModifiers;
	}
}
