using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x020008D7 RID: 2263
	[Token(Token = "0x20008D7")]
	public class FadingPlayerShaderParticle : FadingParticle
	{
		// Token: 0x06004C68 RID: 19560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C68")]
		[Address(RVA = "0x6F407C", Offset = "0x6F407C", VA = "0x6F407C")]
		public FadingPlayerShaderParticle(ParticlePool pool)
		{
		}

		// Token: 0x06004C69 RID: 19561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C69")]
		[Address(RVA = "0x6F4114", Offset = "0x6F4114", VA = "0x6F4114", Slot = "12")]
		public override void FetchFromPool()
		{
		}

		// Token: 0x06004C6A RID: 19562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C6A")]
		[Address(RVA = "0x6F4254", Offset = "0x6F4254", VA = "0x6F4254")]
		public void SetTypeInfo(float timeToLive, Player player, int shader, bool fullbright = true)
		{
		}

		// Token: 0x06004C6B RID: 19563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C6B")]
		[Address(RVA = "0x6F4278", Offset = "0x6F4278", VA = "0x6F4278", Slot = "11")]
		public override void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
		{
		}

		// Token: 0x04009151 RID: 37201
		[Token(Token = "0x4009151")]
		[FieldOffset(Offset = "0x8C")]
		private Player _player;

		// Token: 0x04009152 RID: 37202
		[Token(Token = "0x4009152")]
		[FieldOffset(Offset = "0x90")]
		private int _shader;
	}
}
