using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures
{
	// Token: 0x02000775 RID: 1909
	[Token(Token = "0x2000775")]
	public struct LineSegment
	{
		// Token: 0x06004332 RID: 17202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004332")]
		[Address(RVA = "0x4FD54C", Offset = "0x4FD54C", VA = "0x4FD54C")]
		public LineSegment(Vector2 start, Vector2 end)
		{
		}

		// Token: 0x04008A94 RID: 35476
		[Token(Token = "0x4008A94")]
		[FieldOffset(Offset = "0x0")]
		public Vector2 Start;

		// Token: 0x04008A95 RID: 35477
		[Token(Token = "0x4008A95")]
		[FieldOffset(Offset = "0x8")]
		public Vector2 End;
	}
}
