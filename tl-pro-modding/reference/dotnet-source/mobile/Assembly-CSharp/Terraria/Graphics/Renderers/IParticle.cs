using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x020008C5 RID: 2245
	[Token(Token = "0x20008C5")]
	public interface IParticle
	{
		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06004C0A RID: 19466
		[Token(Token = "0x17000935")]
		bool ShouldBeRemovedFromRenderer
		{
			[Token(Token = "0x6004C0A")]
			get;
		}

		// Token: 0x06004C0B RID: 19467
		[Token(Token = "0x6004C0B")]
		void Update(ref ParticleRendererSettings settings);

		// Token: 0x06004C0C RID: 19468
		[Token(Token = "0x6004C0C")]
		void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch);
	}
}
