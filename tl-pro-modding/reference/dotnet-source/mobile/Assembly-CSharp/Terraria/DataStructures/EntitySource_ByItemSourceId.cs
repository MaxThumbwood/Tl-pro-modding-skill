using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x020007A6 RID: 1958
	[Token(Token = "0x20007A6")]
	public class EntitySource_ByItemSourceId : FileAPI
	{
		// Token: 0x06004445 RID: 17477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004445")]
		[Address(RVA = "0x558F70", Offset = "0x558F70", VA = "0x558F70")]
		public EntitySource_ByItemSourceId(IEntitySourceTarget entity, int itemSourceId)
		{
		}

		// Token: 0x04008BD6 RID: 35798
		[Token(Token = "0x4008BD6")]
		[FieldOffset(Offset = "0x8")]
		public readonly IEntitySourceTarget Entity;

		// Token: 0x04008BD7 RID: 35799
		[Token(Token = "0x4008BD7")]
		[FieldOffset(Offset = "0xC")]
		public readonly int SourceId;
	}
}
