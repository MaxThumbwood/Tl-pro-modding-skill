using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x0200079B RID: 1947
	[Token(Token = "0x200079B")]
	public class EntitySource_ItemOpen : FileAPI
	{
		// Token: 0x0600443A RID: 17466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600443A")]
		[Address(RVA = "0x558CA8", Offset = "0x558CA8", VA = "0x558CA8")]
		public EntitySource_ItemOpen(IEntitySourceTarget entity, int itemType)
		{
		}

		// Token: 0x04008BCD RID: 35789
		[Token(Token = "0x4008BCD")]
		[FieldOffset(Offset = "0x8")]
		public readonly IEntitySourceTarget Entity;

		// Token: 0x04008BCE RID: 35790
		[Token(Token = "0x4008BCE")]
		[FieldOffset(Offset = "0xC")]
		public readonly int ItemType;
	}
}
