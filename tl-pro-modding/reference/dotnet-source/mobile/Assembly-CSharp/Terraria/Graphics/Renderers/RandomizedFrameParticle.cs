using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x020008DA RID: 2266
	[Token(Token = "0x20008DA")]
	public class RandomizedFrameParticle : ABasicParticle
	{
		// Token: 0x06004C77 RID: 19575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C77")]
		[Address(RVA = "0x6F5750", Offset = "0x6F5750", VA = "0x6F5750")]
		public RandomizedFrameParticle(ParticlePool pool)
		{
		}

		// Token: 0x06004C78 RID: 19576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C78")]
		[Address(RVA = "0x6F57D4", Offset = "0x6F57D4", VA = "0x6F57D4", Slot = "12")]
		public override void FetchFromPool()
		{
		}

		// Token: 0x06004C79 RID: 19577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C79")]
		[Address(RVA = "0x6F5868", Offset = "0x6F5868", VA = "0x6F5868")]
		public void SetTypeInfo(int animationFramesAmount, int gameFramesPerAnimationFrame, float timeToLive)
		{
		}

		// Token: 0x06004C7A RID: 19578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C7A")]
		[Address(RVA = "0x6F5874", Offset = "0x6F5874", VA = "0x6F5874")]
		private void RandomizeFrame()
		{
		}

		// Token: 0x06004C7B RID: 19579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C7B")]
		[Address(RVA = "0x6F59FC", Offset = "0x6F59FC", VA = "0x6F59FC", Slot = "10")]
		public override void Update(ref ParticleRendererSettings settings)
		{
		}

		// Token: 0x06004C7C RID: 19580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C7C")]
		[Address(RVA = "0x6F5AD0", Offset = "0x6F5AD0", VA = "0x6F5AD0", Slot = "11")]
		public override void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
		{
		}

		// Token: 0x04009161 RID: 37217
		[Token(Token = "0x4009161")]
		[FieldOffset(Offset = "0x68")]
		public float FadeInNormalizedTime;

		// Token: 0x04009162 RID: 37218
		[Token(Token = "0x4009162")]
		[FieldOffset(Offset = "0x6C")]
		public float FadeOutNormalizedTime;

		// Token: 0x04009163 RID: 37219
		[Token(Token = "0x4009163")]
		[FieldOffset(Offset = "0x70")]
		public Color ColorTint;

		// Token: 0x04009164 RID: 37220
		[Token(Token = "0x4009164")]
		[FieldOffset(Offset = "0x74")]
		public int AnimationFramesAmount;

		// Token: 0x04009165 RID: 37221
		[Token(Token = "0x4009165")]
		[FieldOffset(Offset = "0x78")]
		public int GameFramesPerAnimationFrame;

		// Token: 0x04009166 RID: 37222
		[Token(Token = "0x4009166")]
		[FieldOffset(Offset = "0x7C")]
		private float _timeTolive;

		// Token: 0x04009167 RID: 37223
		[Token(Token = "0x4009167")]
		[FieldOffset(Offset = "0x80")]
		private float _timeSinceSpawn;

		// Token: 0x04009168 RID: 37224
		[Token(Token = "0x4009168")]
		[FieldOffset(Offset = "0x84")]
		private int _gameFramesCounted;
	}
}
