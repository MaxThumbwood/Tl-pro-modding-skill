using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures
{
	// Token: 0x0200077A RID: 1914
	[Token(Token = "0x200077A")]
	public class MultiPointHitbox
	{
		// Token: 0x06004344 RID: 17220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004344")]
		[Address(RVA = "0x4FE374", Offset = "0x4FE374", VA = "0x4FE374")]
		public MultiPointHitbox(Point pointSize, Vector2[] points)
		{
		}

		// Token: 0x06004345 RID: 17221 RVA: 0x00020628 File Offset: 0x0001E828
		[Token(Token = "0x6004345")]
		[Address(RVA = "0x4FE588", Offset = "0x4FE588", VA = "0x4FE588")]
		public bool Intersects(Rectangle targetRect)
		{
			return default(bool);
		}

		// Token: 0x04008A9D RID: 35485
		[Token(Token = "0x4008A9D")]
		[FieldOffset(Offset = "0x8")]
		public readonly Point PointSize;

		// Token: 0x04008A9E RID: 35486
		[Token(Token = "0x4008A9E")]
		[FieldOffset(Offset = "0x10")]
		public readonly Vector2[] Points;

		// Token: 0x04008A9F RID: 35487
		[Token(Token = "0x4008A9F")]
		[FieldOffset(Offset = "0x14")]
		public readonly Rectangle BoundingRect;
	}
}
