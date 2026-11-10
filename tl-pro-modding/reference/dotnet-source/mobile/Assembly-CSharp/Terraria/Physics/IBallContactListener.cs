using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.Physics
{
	// Token: 0x0200064C RID: 1612
	[Token(Token = "0x200064C")]
	public interface IBallContactListener
	{
		// Token: 0x06003E60 RID: 15968
		[Token(Token = "0x6003E60")]
		void OnCollision(PhysicsProperties properties, ref Vector2 position, ref Vector2 velocity, ref BallCollisionEvent collision);

		// Token: 0x06003E61 RID: 15969
		[Token(Token = "0x6003E61")]
		void OnPassThrough(PhysicsProperties properties, ref Vector2 position, ref Vector2 velocity, ref float angularVelocity, ref BallPassThroughEvent passThrough);
	}
}
