using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x02000798 RID: 1944
	[Token(Token = "0x2000798")]
	public class EntitySource_Parent : FileAPI
	{
		// Token: 0x06004437 RID: 17463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004437")]
		[Address(RVA = "0x558C3C", Offset = "0x558C3C", VA = "0x558C3C")]
		public EntitySource_Parent(IEntitySourceTarget entity)
		{
		}

		// Token: 0x04008BC7 RID: 35783
		[Token(Token = "0x4008BC7")]
		[FieldOffset(Offset = "0x8")]
		public readonly IEntitySourceTarget Entity;
	}
}
