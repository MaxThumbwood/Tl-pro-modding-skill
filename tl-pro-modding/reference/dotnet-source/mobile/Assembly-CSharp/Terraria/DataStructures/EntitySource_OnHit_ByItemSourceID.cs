using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x020007B3 RID: 1971
	[Token(Token = "0x20007B3")]
	public class EntitySource_OnHit_ByItemSourceID : AEntitySource_OnHit
	{
		// Token: 0x06004452 RID: 17490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004452")]
		[Address(RVA = "0x559098", Offset = "0x559098", VA = "0x559098")]
		public EntitySource_OnHit_ByItemSourceID(IEntitySourceTarget entityStriking, IEntitySourceTarget entityStruck, int itemSourceId)
		{
		}

		// Token: 0x04008BE0 RID: 35808
		[Token(Token = "0x4008BE0")]
		[FieldOffset(Offset = "0x10")]
		public readonly int SourceId;
	}
}
