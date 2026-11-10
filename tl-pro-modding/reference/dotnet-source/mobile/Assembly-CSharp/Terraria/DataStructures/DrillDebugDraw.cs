using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures
{
	// Token: 0x02000756 RID: 1878
	[Token(Token = "0x2000756")]
	public struct DrillDebugDraw
	{
		// Token: 0x060042C6 RID: 17094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042C6")]
		[Address(RVA = "0x4F98B0", Offset = "0x4F98B0", VA = "0x4F98B0")]
		public DrillDebugDraw(Vector2 p, Color c)
		{
		}

		// Token: 0x04008A49 RID: 35401
		[Token(Token = "0x4008A49")]
		[FieldOffset(Offset = "0x0")]
		public Vector2 point;

		// Token: 0x04008A4A RID: 35402
		[Token(Token = "0x4008A4A")]
		[FieldOffset(Offset = "0x8")]
		public Color color;
	}
}
