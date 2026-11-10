using System;
using Il2CppDummyDll;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x020008C7 RID: 2247
	[Token(Token = "0x20008C7")]
	public interface IParticleRepel : FileAPI
	{
		// Token: 0x06004C0D RID: 19469
		[Token(Token = "0x6004C0D")]
		void BeRepelled(ref ParticleRepelDetails details);
	}
}
