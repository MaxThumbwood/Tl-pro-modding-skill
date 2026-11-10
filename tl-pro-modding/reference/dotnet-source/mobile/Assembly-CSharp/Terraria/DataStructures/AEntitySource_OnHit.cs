using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x020007B1 RID: 1969
	[Token(Token = "0x20007B1")]
	public abstract class AEntitySource_OnHit : FileAPI
	{
		// Token: 0x06004450 RID: 17488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004450")]
		[Address(RVA = "0x559048", Offset = "0x559048", VA = "0x559048")]
		public AEntitySource_OnHit(IEntitySourceTarget entityStriking, IEntitySourceTarget entityStruck)
		{
		}

		// Token: 0x04008BDD RID: 35805
		[Token(Token = "0x4008BDD")]
		[FieldOffset(Offset = "0x8")]
		public readonly IEntitySourceTarget EntityStriking;

		// Token: 0x04008BDE RID: 35806
		[Token(Token = "0x4008BDE")]
		[FieldOffset(Offset = "0xC")]
		public readonly IEntitySourceTarget EntityStruck;
	}
}
