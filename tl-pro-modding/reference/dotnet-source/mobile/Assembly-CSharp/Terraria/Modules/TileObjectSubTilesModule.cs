using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Terraria.ObjectData;

namespace Terraria.Modules
{
	// Token: 0x02000658 RID: 1624
	[Token(Token = "0x2000658")]
	public class TileObjectSubTilesModule
	{
		// Token: 0x06003EF8 RID: 16120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EF8")]
		[Address(RVA = "0x1E7A36C", Offset = "0x1E7A36C", VA = "0x1E7A36C")]
		public TileObjectSubTilesModule([Optional] TileObjectSubTilesModule copyFrom, [Optional] List<TileObjectData> newData)
		{
		}

		// Token: 0x0400491D RID: 18717
		[Token(Token = "0x400491D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public List<TileObjectData> data;
	}
}
