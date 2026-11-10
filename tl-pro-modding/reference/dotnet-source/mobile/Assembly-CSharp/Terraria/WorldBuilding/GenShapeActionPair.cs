using System;
using Il2CppDummyDll;

namespace Terraria.WorldBuilding
{
	// Token: 0x020005A5 RID: 1445
	[Token(Token = "0x20005A5")]
	public struct GenShapeActionPair
	{
		// Token: 0x06003AD7 RID: 15063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AD7")]
		[Address(RVA = "0x1E078AC", Offset = "0x1E078AC", VA = "0x1E078AC")]
		public GenShapeActionPair(GenShape shape, GenAction action)
		{
		}

		// Token: 0x04004648 RID: 17992
		[Token(Token = "0x4004648")]
		[FieldOffset(Offset = "0x0")]
		public readonly GenShape Shape;

		// Token: 0x04004649 RID: 17993
		[Token(Token = "0x4004649")]
		[FieldOffset(Offset = "0x4")]
		public readonly GenAction Action;
	}
}
