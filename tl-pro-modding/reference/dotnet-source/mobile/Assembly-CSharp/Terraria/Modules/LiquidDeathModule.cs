using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Terraria.Modules
{
	// Token: 0x02000651 RID: 1617
	[Token(Token = "0x2000651")]
	public class LiquidDeathModule
	{
		// Token: 0x06003EF1 RID: 16113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EF1")]
		[Address(RVA = "0x1E79C74", Offset = "0x1E79C74", VA = "0x1E79C74")]
		public LiquidDeathModule([Optional] LiquidDeathModule copyFrom)
		{
		}

		// Token: 0x040048FC RID: 18684
		[Token(Token = "0x40048FC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool water;

		// Token: 0x040048FD RID: 18685
		[Token(Token = "0x40048FD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		public bool lava;
	}
}
