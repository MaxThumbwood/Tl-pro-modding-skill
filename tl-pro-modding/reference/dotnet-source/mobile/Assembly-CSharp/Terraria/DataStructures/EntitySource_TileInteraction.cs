using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x0200079F RID: 1951
	[Token(Token = "0x200079F")]
	public class EntitySource_TileInteraction : AEntitySource_Tile
	{
		// Token: 0x0600443E RID: 17470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600443E")]
		[Address(RVA = "0x558D6C", Offset = "0x558D6C", VA = "0x558D6C")]
		public EntitySource_TileInteraction(IEntitySourceTarget entity, int tileCoordsX, int tileCoordsY)
		{
		}

		// Token: 0x04008BD3 RID: 35795
		[Token(Token = "0x4008BD3")]
		[FieldOffset(Offset = "0x10")]
		public readonly IEntitySourceTarget Entity;
	}
}
