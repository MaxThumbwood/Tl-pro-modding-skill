using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x020007A0 RID: 1952
	[Token(Token = "0x20007A0")]
	public class EntitySource_OverfullChest : AEntitySource_Tile
	{
		// Token: 0x0600443F RID: 17471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600443F")]
		[Address(RVA = "0x558DC0", Offset = "0x558DC0", VA = "0x558DC0")]
		public EntitySource_OverfullChest(int tileCoordsX, int tileCoordsY, Chest chest)
		{
		}

		// Token: 0x04008BD4 RID: 35796
		[Token(Token = "0x4008BD4")]
		[FieldOffset(Offset = "0x10")]
		public readonly Chest Chest;
	}
}
