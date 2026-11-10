using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x0200079D RID: 1949
	[Token(Token = "0x200079D")]
	public class EntitySource_Mount : FileAPI
	{
		// Token: 0x0600443C RID: 17468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600443C")]
		[Address(RVA = "0x558CF8", Offset = "0x558CF8", VA = "0x558CF8")]
		public EntitySource_Mount(IEntitySourceTarget entity, int mountId)
		{
		}

		// Token: 0x04008BD0 RID: 35792
		[Token(Token = "0x4008BD0")]
		[FieldOffset(Offset = "0x8")]
		public readonly IEntitySourceTarget Entity;

		// Token: 0x04008BD1 RID: 35793
		[Token(Token = "0x4008BD1")]
		[FieldOffset(Offset = "0xC")]
		public readonly int MountId;
	}
}
