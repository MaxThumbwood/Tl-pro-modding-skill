using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures
{
	// Token: 0x0200079E RID: 1950
	[Token(Token = "0x200079E")]
	public abstract class AEntitySource_Tile : FileAPI
	{
		// Token: 0x0600443D RID: 17469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600443D")]
		[Address(RVA = "0x558D1C", Offset = "0x558D1C", VA = "0x558D1C")]
		public AEntitySource_Tile(int tileCoordsX, int tileCoordsY)
		{
		}

		// Token: 0x04008BD2 RID: 35794
		[Token(Token = "0x4008BD2")]
		[FieldOffset(Offset = "0x8")]
		public readonly Point TileCoords;
	}
}
