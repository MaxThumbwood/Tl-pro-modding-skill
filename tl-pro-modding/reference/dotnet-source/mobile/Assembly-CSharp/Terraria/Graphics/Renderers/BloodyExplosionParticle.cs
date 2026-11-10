using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x020008DB RID: 2267
	[Token(Token = "0x20008DB")]
	public class BloodyExplosionParticle : ABasicParticle
	{
		// Token: 0x06004C7D RID: 19581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C7D")]
		[Address(RVA = "0x6F5D34", Offset = "0x6F5D34", VA = "0x6F5D34")]
		public BloodyExplosionParticle(ParticlePool pool)
		{
		}

		// Token: 0x06004C7E RID: 19582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C7E")]
		[Address(RVA = "0x6F5DE0", Offset = "0x6F5DE0", VA = "0x6F5DE0", Slot = "12")]
		public override void FetchFromPool()
		{
		}

		// Token: 0x06004C7F RID: 19583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C7F")]
		[Address(RVA = "0x6F5E9C", Offset = "0x6F5E9C", VA = "0x6F5E9C", Slot = "10")]
		public override void Update(ref ParticleRendererSettings settings)
		{
		}

		// Token: 0x06004C80 RID: 19584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C80")]
		[Address(RVA = "0x6F6620", Offset = "0x6F6620", VA = "0x6F6620", Slot = "11")]
		public override void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
		{
		}

		// Token: 0x04009169 RID: 37225
		[Token(Token = "0x4009169")]
		[FieldOffset(Offset = "0x68")]
		public float FadeInNormalizedTime;

		// Token: 0x0400916A RID: 37226
		[Token(Token = "0x400916A")]
		[FieldOffset(Offset = "0x6C")]
		public float FadeOutNormalizedTime;

		// Token: 0x0400916B RID: 37227
		[Token(Token = "0x400916B")]
		[FieldOffset(Offset = "0x70")]
		public float TimeToLive;

		// Token: 0x0400916C RID: 37228
		[Token(Token = "0x400916C")]
		[FieldOffset(Offset = "0x74")]
		public float Opacity;

		// Token: 0x0400916D RID: 37229
		[Token(Token = "0x400916D")]
		[FieldOffset(Offset = "0x78")]
		public float InnerOpacity;

		// Token: 0x0400916E RID: 37230
		[Token(Token = "0x400916E")]
		[FieldOffset(Offset = "0x7C")]
		public float InitialScale;

		// Token: 0x0400916F RID: 37231
		[Token(Token = "0x400916F")]
		[FieldOffset(Offset = "0x80")]
		public Color ColorTint;

		// Token: 0x04009170 RID: 37232
		[Token(Token = "0x4009170")]
		[FieldOffset(Offset = "0x84")]
		public Color LightColorTint;

		// Token: 0x04009171 RID: 37233
		[Token(Token = "0x4009171")]
		[FieldOffset(Offset = "0x88")]
		private float _timeSinceSpawn;
	}
}
