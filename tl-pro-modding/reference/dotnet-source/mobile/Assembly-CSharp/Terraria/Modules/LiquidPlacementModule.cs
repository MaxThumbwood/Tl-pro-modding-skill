using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Terraria.Enums;

namespace Terraria.Modules
{
	// Token: 0x02000652 RID: 1618
	[Token(Token = "0x2000652")]
	public class LiquidPlacementModule
	{
		// Token: 0x06003EF2 RID: 16114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EF2")]
		[Address(RVA = "0x1E79CA8", Offset = "0x1E79CA8", VA = "0x1E79CA8")]
		public LiquidPlacementModule([Optional] LiquidPlacementModule copyFrom)
		{
		}

		// Token: 0x040048FE RID: 18686
		[Token(Token = "0x40048FE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public LiquidPlacement water;

		// Token: 0x040048FF RID: 18687
		[Token(Token = "0x40048FF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public LiquidPlacement lava;
	}
}
