using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x020007AD RID: 1965
	[Token(Token = "0x20007AD")]
	public class EntitySource_DropAsItem : FileAPI
	{
		// Token: 0x0600444C RID: 17484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600444C")]
		[Address(RVA = "0x558FD8", Offset = "0x558FD8", VA = "0x558FD8")]
		public EntitySource_DropAsItem(IEntitySourceTarget entity)
		{
		}

		// Token: 0x04008BD9 RID: 35801
		[Token(Token = "0x4008BD9")]
		[FieldOffset(Offset = "0x8")]
		public readonly IEntitySourceTarget Entity;
	}
}
