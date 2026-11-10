using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.Physics
{
	// Token: 0x02000646 RID: 1606
	[Token(Token = "0x2000646")]
	public struct BallCollisionEvent
	{
		// Token: 0x06003E54 RID: 15956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E54")]
		[Address(RVA = "0x1E6B348", Offset = "0x1E6B348", VA = "0x1E6B348")]
		public BallCollisionEvent(float timeScale, Vector2 normal, Vector2 impactPoint, Tile tile, Entity entity)
		{
		}

		// Token: 0x040048A2 RID: 18594
		[Token(Token = "0x40048A2")]
		[FieldOffset(Offset = "0x0")]
		public readonly Vector2 Normal;

		// Token: 0x040048A3 RID: 18595
		[Token(Token = "0x40048A3")]
		[FieldOffset(Offset = "0x8")]
		public readonly Vector2 ImpactPoint;

		// Token: 0x040048A4 RID: 18596
		[Token(Token = "0x40048A4")]
		[FieldOffset(Offset = "0x10")]
		public readonly Tile Tile;

		// Token: 0x040048A5 RID: 18597
		[Token(Token = "0x40048A5")]
		[FieldOffset(Offset = "0x14")]
		public readonly Entity Entity;

		// Token: 0x040048A6 RID: 18598
		[Token(Token = "0x40048A6")]
		[FieldOffset(Offset = "0x18")]
		public readonly float TimeScale;
	}
}
