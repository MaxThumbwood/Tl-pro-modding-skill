using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x0200079C RID: 1948
	[Token(Token = "0x200079C")]
	public class EntitySource_ItemUse_WithAmmo : EntitySource_ItemUse
	{
		// Token: 0x0600443B RID: 17467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600443B")]
		[Address(RVA = "0x558CCC", Offset = "0x558CCC", VA = "0x558CCC")]
		public EntitySource_ItemUse_WithAmmo(IEntitySourceTarget entity, Item item, int ammoItemIdUsed)
		{
		}

		// Token: 0x04008BCF RID: 35791
		[Token(Token = "0x4008BCF")]
		[FieldOffset(Offset = "0x10")]
		public readonly int AmmoItemIdUsed;
	}
}
