using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x020007AC RID: 1964
	[Token(Token = "0x20007AC")]
	public class EntitySource_BossSpawn : FileAPI
	{
		// Token: 0x0600444B RID: 17483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600444B")]
		[Address(RVA = "0x558FBC", Offset = "0x558FBC", VA = "0x558FBC")]
		public EntitySource_BossSpawn(IEntitySourceTarget entity)
		{
		}

		// Token: 0x04008BD8 RID: 35800
		[Token(Token = "0x4008BD8")]
		[FieldOffset(Offset = "0x8")]
		public readonly IEntitySourceTarget Entity;
	}
}
