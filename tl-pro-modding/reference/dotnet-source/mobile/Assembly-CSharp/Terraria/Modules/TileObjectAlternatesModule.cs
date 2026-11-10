using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Terraria.ObjectData;

namespace Terraria.Modules
{
	// Token: 0x02000653 RID: 1619
	[Token(Token = "0x2000653")]
	public class TileObjectAlternatesModule
	{
		// Token: 0x06003EF3 RID: 16115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EF3")]
		[Address(RVA = "0x1E79CDC", Offset = "0x1E79CDC", VA = "0x1E79CDC")]
		public TileObjectAlternatesModule([Optional] TileObjectAlternatesModule copyFrom)
		{
		}

		// Token: 0x04004900 RID: 18688
		[Token(Token = "0x4004900")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public List<TileObjectData> data;
	}
}
