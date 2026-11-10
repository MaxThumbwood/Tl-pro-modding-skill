using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x020008C6 RID: 2246
	[Token(Token = "0x20008C6")]
	public struct ParticleRepelDetails
	{
		// Token: 0x040090E3 RID: 37091
		[Token(Token = "0x40090E3")]
		[FieldOffset(Offset = "0x0")]
		public Vector2 SourcePosition;

		// Token: 0x040090E4 RID: 37092
		[Token(Token = "0x40090E4")]
		[FieldOffset(Offset = "0x8")]
		public float Radius;

		// Token: 0x040090E5 RID: 37093
		[Token(Token = "0x40090E5")]
		[FieldOffset(Offset = "0xC")]
		public bool IsInWater;
	}
}
