using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x020007B0 RID: 1968
	[Token(Token = "0x20007B0")]
	public class EntitySource_Loot : FileAPI
	{
		// Token: 0x0600444F RID: 17487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600444F")]
		[Address(RVA = "0x55902C", Offset = "0x55902C", VA = "0x55902C")]
		public EntitySource_Loot(IEntitySourceTarget entity)
		{
		}

		// Token: 0x04008BDC RID: 35804
		[Token(Token = "0x4008BDC")]
		[FieldOffset(Offset = "0x8")]
		public readonly IEntitySourceTarget Entity;
	}
}
