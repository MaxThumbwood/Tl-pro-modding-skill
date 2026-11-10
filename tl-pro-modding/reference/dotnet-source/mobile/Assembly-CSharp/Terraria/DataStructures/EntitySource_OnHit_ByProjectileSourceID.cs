using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x020007B2 RID: 1970
	[Token(Token = "0x20007B2")]
	public class EntitySource_OnHit_ByProjectileSourceID : AEntitySource_OnHit
	{
		// Token: 0x06004451 RID: 17489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004451")]
		[Address(RVA = "0x55906C", Offset = "0x55906C", VA = "0x55906C")]
		public EntitySource_OnHit_ByProjectileSourceID(IEntitySourceTarget entityStriking, IEntitySourceTarget entityStruck, int projectileSourceId)
		{
		}

		// Token: 0x04008BDF RID: 35807
		[Token(Token = "0x4008BDF")]
		[FieldOffset(Offset = "0x10")]
		public readonly int SourceId;
	}
}
