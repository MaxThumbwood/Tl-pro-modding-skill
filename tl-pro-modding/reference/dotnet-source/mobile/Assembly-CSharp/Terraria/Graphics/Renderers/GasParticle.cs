using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x020008DD RID: 2269
	[Token(Token = "0x20008DD")]
	public class GasParticle : ABasicParticle
	{
		// Token: 0x06004C85 RID: 19589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C85")]
		[Address(RVA = "0x6F7400", Offset = "0x6F7400", VA = "0x6F7400")]
		public GasParticle(ParticlePool pool)
		{
		}

		// Token: 0x06004C86 RID: 19590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C86")]
		[Address(RVA = "0x6F7460", Offset = "0x6F7460", VA = "0x6F7460", Slot = "12")]
		public override void FetchFromPool()
		{
		}

		// Token: 0x06004C87 RID: 19591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C87")]
		[Address(RVA = "0x6F757C", Offset = "0x6F757C", VA = "0x6F757C", Slot = "10")]
		public override void Update(ref ParticleRendererSettings settings)
		{
		}

		// Token: 0x06004C88 RID: 19592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C88")]
		[Address(RVA = "0x6F799C", Offset = "0x6F799C", VA = "0x6F799C", Slot = "11")]
		public override void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
		{
		}

		// Token: 0x0400917C RID: 37244
		[Token(Token = "0x400917C")]
		[FieldOffset(Offset = "0x68")]
		public float FadeInNormalizedTime;

		// Token: 0x0400917D RID: 37245
		[Token(Token = "0x400917D")]
		[FieldOffset(Offset = "0x6C")]
		public float FadeOutNormalizedTime;

		// Token: 0x0400917E RID: 37246
		[Token(Token = "0x400917E")]
		[FieldOffset(Offset = "0x70")]
		public float TimeToLive;

		// Token: 0x0400917F RID: 37247
		[Token(Token = "0x400917F")]
		[FieldOffset(Offset = "0x74")]
		public Color ColorTint;

		// Token: 0x04009180 RID: 37248
		[Token(Token = "0x4009180")]
		[FieldOffset(Offset = "0x78")]
		public float Opacity;

		// Token: 0x04009181 RID: 37249
		[Token(Token = "0x4009181")]
		[FieldOffset(Offset = "0x7C")]
		public float AdditiveAmount;

		// Token: 0x04009182 RID: 37250
		[Token(Token = "0x4009182")]
		[FieldOffset(Offset = "0x80")]
		public float FadeInEnd;

		// Token: 0x04009183 RID: 37251
		[Token(Token = "0x4009183")]
		[FieldOffset(Offset = "0x84")]
		public float FadeOutStart;

		// Token: 0x04009184 RID: 37252
		[Token(Token = "0x4009184")]
		[FieldOffset(Offset = "0x88")]
		public float FadeOutEnd;

		// Token: 0x04009185 RID: 37253
		[Token(Token = "0x4009185")]
		[FieldOffset(Offset = "0x8C")]
		public float SlowdownScalar;

		// Token: 0x04009186 RID: 37254
		[Token(Token = "0x4009186")]
		[FieldOffset(Offset = "0x90")]
		private float _timeSinceSpawn;

		// Token: 0x04009187 RID: 37255
		[Token(Token = "0x4009187")]
		[FieldOffset(Offset = "0x94")]
		public Color LightColorTint;

		// Token: 0x04009188 RID: 37256
		[Token(Token = "0x4009188")]
		[FieldOffset(Offset = "0x98")]
		private int _internalIndentifier;

		// Token: 0x04009189 RID: 37257
		[Token(Token = "0x4009189")]
		[FieldOffset(Offset = "0x9C")]
		public float InitialScale;
	}
}
