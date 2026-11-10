using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x02000799 RID: 1945
	[Token(Token = "0x2000799")]
	public class EntitySource_Buff : FileAPI
	{
		// Token: 0x06004438 RID: 17464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004438")]
		[Address(RVA = "0x558C58", Offset = "0x558C58", VA = "0x558C58")]
		public EntitySource_Buff(IEntitySourceTarget entity, int buffId, int buffIndex)
		{
		}

		// Token: 0x04008BC8 RID: 35784
		[Token(Token = "0x4008BC8")]
		[FieldOffset(Offset = "0x8")]
		public readonly IEntitySourceTarget Entity;

		// Token: 0x04008BC9 RID: 35785
		[Token(Token = "0x4008BC9")]
		[FieldOffset(Offset = "0xC")]
		public readonly int BuffId;

		// Token: 0x04008BCA RID: 35786
		[Token(Token = "0x4008BCA")]
		[FieldOffset(Offset = "0x10")]
		public readonly int BuffIndex;
	}
}
