using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x020008D9 RID: 2265
	[Token(Token = "0x20008D9")]
	public class FlameParticle : ABasicParticle
	{
		// Token: 0x06004C71 RID: 19569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C71")]
		[Address(RVA = "0x6F4D98", Offset = "0x6F4D98", VA = "0x6F4D98")]
		public FlameParticle(ParticlePool pool)
		{
		}

		// Token: 0x06004C72 RID: 19570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C72")]
		[Address(RVA = "0x6F4DA4", Offset = "0x6F4DA4", VA = "0x6F4DA4", Slot = "12")]
		public override void FetchFromPool()
		{
		}

		// Token: 0x06004C73 RID: 19571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C73")]
		[Address(RVA = "0x6F4DC8", Offset = "0x6F4DC8", VA = "0x6F4DC8", Slot = "9")]
		public override void SetBasicInfo(Asset<Texture2D> textureAsset, Rectangle? frame, Vector2 initialVelocity, Vector2 initialLocalPosition)
		{
		}

		// Token: 0x06004C74 RID: 19572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C74")]
		[Address(RVA = "0x6F4E70", Offset = "0x6F4E70", VA = "0x6F4E70")]
		public void SetTypeInfo(float timeToLive, int indexOfPlayerWhoSpawnedIt, int packedShaderIndex)
		{
		}

		// Token: 0x06004C75 RID: 19573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C75")]
		[Address(RVA = "0x6F4E80", Offset = "0x6F4E80", VA = "0x6F4E80", Slot = "10")]
		public override void Update(ref ParticleRendererSettings settings)
		{
		}

		// Token: 0x06004C76 RID: 19574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C76")]
		[Address(RVA = "0x6F4F34", Offset = "0x6F4F34", VA = "0x6F4F34", Slot = "11")]
		public override void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
		{
		}

		// Token: 0x0400915C RID: 37212
		[Token(Token = "0x400915C")]
		[FieldOffset(Offset = "0x68")]
		public float FadeOutNormalizedTime;

		// Token: 0x0400915D RID: 37213
		[Token(Token = "0x400915D")]
		[FieldOffset(Offset = "0x6C")]
		private float _timeTolive;

		// Token: 0x0400915E RID: 37214
		[Token(Token = "0x400915E")]
		[FieldOffset(Offset = "0x70")]
		private float _timeSinceSpawn;

		// Token: 0x0400915F RID: 37215
		[Token(Token = "0x400915F")]
		[FieldOffset(Offset = "0x74")]
		private int _indexOfPlayerWhoSpawnedThis;

		// Token: 0x04009160 RID: 37216
		[Token(Token = "0x4009160")]
		[FieldOffset(Offset = "0x78")]
		private int _packedShaderIndex;
	}
}
