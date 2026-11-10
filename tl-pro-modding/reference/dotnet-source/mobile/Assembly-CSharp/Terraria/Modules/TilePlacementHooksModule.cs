using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Terraria.DataStructures;

namespace Terraria.Modules
{
	// Token: 0x02000659 RID: 1625
	[Token(Token = "0x2000659")]
	public class TilePlacementHooksModule
	{
		// Token: 0x06003EF9 RID: 16121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EF9")]
		[Address(RVA = "0x1E7A584", Offset = "0x1E7A584", VA = "0x1E7A584")]
		public TilePlacementHooksModule([Optional] TilePlacementHooksModule copyFrom)
		{
		}

		// Token: 0x0400491E RID: 18718
		[Token(Token = "0x400491E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PlacementHook check;

		// Token: 0x0400491F RID: 18719
		[Token(Token = "0x400491F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PlacementHook postPlaceEveryone;

		// Token: 0x04004920 RID: 18720
		[Token(Token = "0x4004920")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PlacementHook postPlaceMyPlayer;

		// Token: 0x04004921 RID: 18721
		[Token(Token = "0x4004921")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public PlacementHook placeOverride;

		// Token: 0x04004922 RID: 18722
		[Token(Token = "0x4004922")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GetStyleMethod getStyleMethod;
	}
}
