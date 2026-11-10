using System;
using Il2CppDummyDll;

namespace Terraria
{
	// Token: 0x020004B0 RID: 1200
	[Token(Token = "0x20004B0")]
	public struct ShoppingSettings
	{
		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06002ED9 RID: 11993 RVA: 0x000166B0 File Offset: 0x000148B0
		[Token(Token = "0x1700061F")]
		public static ShoppingSettings NotInShop
		{
			[Token(Token = "0x6002ED9")]
			[Address(RVA = "0x188AB80", Offset = "0x188AB80", VA = "0x188AB80")]
			get
			{
				return default(ShoppingSettings);
			}
		}

		// Token: 0x04003ED4 RID: 16084
		[Token(Token = "0x4003ED4")]
		[FieldOffset(Offset = "0x0")]
		public float PriceAdjustment;

		// Token: 0x04003ED5 RID: 16085
		[Token(Token = "0x4003ED5")]
		[FieldOffset(Offset = "0x4")]
		public string HappinessReport;
	}
}
