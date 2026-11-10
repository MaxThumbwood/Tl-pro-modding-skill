using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x0200079A RID: 1946
	[Token(Token = "0x200079A")]
	public class EntitySource_ItemUse : FileAPI
	{
		// Token: 0x06004439 RID: 17465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004439")]
		[Address(RVA = "0x558C84", Offset = "0x558C84", VA = "0x558C84")]
		public EntitySource_ItemUse(IEntitySourceTarget entity, Item item)
		{
		}

		// Token: 0x04008BCB RID: 35787
		[Token(Token = "0x4008BCB")]
		[FieldOffset(Offset = "0x8")]
		public readonly IEntitySourceTarget Entity;

		// Token: 0x04008BCC RID: 35788
		[Token(Token = "0x4008BCC")]
		[FieldOffset(Offset = "0xC")]
		public readonly Item Item;
	}
}
