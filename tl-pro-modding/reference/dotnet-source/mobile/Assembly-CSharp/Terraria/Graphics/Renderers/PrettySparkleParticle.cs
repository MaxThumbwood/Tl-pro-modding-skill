using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x020008DE RID: 2270
	[Token(Token = "0x20008DE")]
	public class PrettySparkleParticle : ABasicParticle
	{
		// Token: 0x06004C89 RID: 19593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C89")]
		[Address(RVA = "0x6F7E70", Offset = "0x6F7E70", VA = "0x6F7E70")]
		public PrettySparkleParticle(ParticlePool pool)
		{
		}

		// Token: 0x06004C8A RID: 19594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C8A")]
		[Address(RVA = "0x6F7EC0", Offset = "0x6F7EC0", VA = "0x6F7EC0", Slot = "12")]
		public override void FetchFromPool()
		{
		}

		// Token: 0x06004C8B RID: 19595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C8B")]
		[Address(RVA = "0x6F7F9C", Offset = "0x6F7F9C", VA = "0x6F7F9C", Slot = "10")]
		public override void Update(ref ParticleRendererSettings settings)
		{
		}

		// Token: 0x06004C8C RID: 19596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C8C")]
		[Address(RVA = "0x6F8140", Offset = "0x6F8140", VA = "0x6F8140", Slot = "11")]
		public override void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
		{
		}

		// Token: 0x0400918A RID: 37258
		[Token(Token = "0x400918A")]
		[FieldOffset(Offset = "0x68")]
		public float FadeInNormalizedTime;

		// Token: 0x0400918B RID: 37259
		[Token(Token = "0x400918B")]
		[FieldOffset(Offset = "0x6C")]
		public float FadeOutNormalizedTime;

		// Token: 0x0400918C RID: 37260
		[Token(Token = "0x400918C")]
		[FieldOffset(Offset = "0x70")]
		public float TimeToLive;

		// Token: 0x0400918D RID: 37261
		[Token(Token = "0x400918D")]
		[FieldOffset(Offset = "0x74")]
		public Color ColorTint;

		// Token: 0x0400918E RID: 37262
		[Token(Token = "0x400918E")]
		[FieldOffset(Offset = "0x78")]
		public float Opacity;

		// Token: 0x0400918F RID: 37263
		[Token(Token = "0x400918F")]
		[FieldOffset(Offset = "0x7C")]
		public float AdditiveAmount;

		// Token: 0x04009190 RID: 37264
		[Token(Token = "0x4009190")]
		[FieldOffset(Offset = "0x80")]
		public float FadeInEnd;

		// Token: 0x04009191 RID: 37265
		[Token(Token = "0x4009191")]
		[FieldOffset(Offset = "0x84")]
		public float FadeOutStart;

		// Token: 0x04009192 RID: 37266
		[Token(Token = "0x4009192")]
		[FieldOffset(Offset = "0x88")]
		public float FadeOutEnd;

		// Token: 0x04009193 RID: 37267
		[Token(Token = "0x4009193")]
		[FieldOffset(Offset = "0x8C")]
		public bool DrawHorizontalAxis;

		// Token: 0x04009194 RID: 37268
		[Token(Token = "0x4009194")]
		[FieldOffset(Offset = "0x8D")]
		public bool DrawVerticalAxis;

		// Token: 0x04009195 RID: 37269
		[Token(Token = "0x4009195")]
		[FieldOffset(Offset = "0x90")]
		private float _timeSinceSpawn;
	}
}
