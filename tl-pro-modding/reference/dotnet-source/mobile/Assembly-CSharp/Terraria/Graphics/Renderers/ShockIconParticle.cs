using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x020008DC RID: 2268
	[Token(Token = "0x20008DC")]
	public class ShockIconParticle : ABasicParticle
	{
		// Token: 0x06004C81 RID: 19585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C81")]
		[Address(RVA = "0x6F6B74", Offset = "0x6F6B74", VA = "0x6F6B74")]
		public ShockIconParticle(ParticlePool pool)
		{
		}

		// Token: 0x06004C82 RID: 19586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C82")]
		[Address(RVA = "0x6F6C20", Offset = "0x6F6C20", VA = "0x6F6C20", Slot = "12")]
		public override void FetchFromPool()
		{
		}

		// Token: 0x06004C83 RID: 19587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C83")]
		[Address(RVA = "0x6F6CCC", Offset = "0x6F6CCC", VA = "0x6F6CCC", Slot = "10")]
		public override void Update(ref ParticleRendererSettings settings)
		{
		}

		// Token: 0x06004C84 RID: 19588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C84")]
		[Address(RVA = "0x6F70A0", Offset = "0x6F70A0", VA = "0x6F70A0", Slot = "11")]
		public override void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
		{
		}

		// Token: 0x04009172 RID: 37234
		[Token(Token = "0x4009172")]
		[FieldOffset(Offset = "0x68")]
		public float FadeInNormalizedTime;

		// Token: 0x04009173 RID: 37235
		[Token(Token = "0x4009173")]
		[FieldOffset(Offset = "0x6C")]
		public float FadeOutNormalizedTime;

		// Token: 0x04009174 RID: 37236
		[Token(Token = "0x4009174")]
		[FieldOffset(Offset = "0x70")]
		public float TimeToLive;

		// Token: 0x04009175 RID: 37237
		[Token(Token = "0x4009175")]
		[FieldOffset(Offset = "0x74")]
		public float Opacity;

		// Token: 0x04009176 RID: 37238
		[Token(Token = "0x4009176")]
		[FieldOffset(Offset = "0x78")]
		public float InitialScale;

		// Token: 0x04009177 RID: 37239
		[Token(Token = "0x4009177")]
		[FieldOffset(Offset = "0x7C")]
		public Color ColorTint;

		// Token: 0x04009178 RID: 37240
		[Token(Token = "0x4009178")]
		[FieldOffset(Offset = "0x80")]
		public ProjectileKey ParentProjectileKey;

		// Token: 0x04009179 RID: 37241
		[Token(Token = "0x4009179")]
		[FieldOffset(Offset = "0x84")]
		public Vector2 OffsetFromParent;

		// Token: 0x0400917A RID: 37242
		[Token(Token = "0x400917A")]
		[FieldOffset(Offset = "0x8C")]
		private Vector2 initialPosition;

		// Token: 0x0400917B RID: 37243
		[Token(Token = "0x400917B")]
		[FieldOffset(Offset = "0x94")]
		private float _timeSinceSpawn;
	}
}
