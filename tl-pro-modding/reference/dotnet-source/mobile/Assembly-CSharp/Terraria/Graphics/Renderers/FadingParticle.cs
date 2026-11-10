using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x020008D8 RID: 2264
	[Token(Token = "0x20008D8")]
	public class FadingParticle : ABasicParticle
	{
		// Token: 0x06004C6C RID: 19564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C6C")]
		[Address(RVA = "0x6F22C8", Offset = "0x6F22C8", VA = "0x6F22C8")]
		public FadingParticle(ParticlePool pool)
		{
		}

		// Token: 0x06004C6D RID: 19565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C6D")]
		[Address(RVA = "0x6F41B8", Offset = "0x6F41B8", VA = "0x6F41B8", Slot = "12")]
		public override void FetchFromPool()
		{
		}

		// Token: 0x06004C6E RID: 19566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C6E")]
		[Address(RVA = "0x6F426C", Offset = "0x6F426C", VA = "0x6F426C")]
		public void SetTypeInfo(float timeToLive, bool fullbright = true)
		{
		}

		// Token: 0x06004C6F RID: 19567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C6F")]
		[Address(RVA = "0x6F4CD0", Offset = "0x6F4CD0", VA = "0x6F4CD0", Slot = "10")]
		public override void Update(ref ParticleRendererSettings settings)
		{
		}

		// Token: 0x06004C70 RID: 19568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C70")]
		[Address(RVA = "0x6F4774", Offset = "0x6F4774", VA = "0x6F4774", Slot = "11")]
		public override void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
		{
		}

		// Token: 0x04009153 RID: 37203
		[Token(Token = "0x4009153")]
		[FieldOffset(Offset = "0x68")]
		public float FadeInNormalizedTime;

		// Token: 0x04009154 RID: 37204
		[Token(Token = "0x4009154")]
		[FieldOffset(Offset = "0x6C")]
		public float FadeOutNormalizedTime;

		// Token: 0x04009155 RID: 37205
		[Token(Token = "0x4009155")]
		[FieldOffset(Offset = "0x70")]
		public Color ColorTint;

		// Token: 0x04009156 RID: 37206
		[Token(Token = "0x4009156")]
		[FieldOffset(Offset = "0x74")]
		public int Delay;

		// Token: 0x04009157 RID: 37207
		[Token(Token = "0x4009157")]
		[FieldOffset(Offset = "0x78")]
		public int PlayerWhoSpawned;

		// Token: 0x04009158 RID: 37208
		[Token(Token = "0x4009158")]
		[FieldOffset(Offset = "0x7C")]
		protected float timeTolive;

		// Token: 0x04009159 RID: 37209
		[Token(Token = "0x4009159")]
		[FieldOffset(Offset = "0x80")]
		protected float timeSinceSpawn;

		// Token: 0x0400915A RID: 37210
		[Token(Token = "0x400915A")]
		[FieldOffset(Offset = "0x84")]
		protected bool fullbright;

		// Token: 0x0400915B RID: 37211
		[Token(Token = "0x400915B")]
		[FieldOffset(Offset = "0x88")]
		public int followPlayerIndex;
	}
}
