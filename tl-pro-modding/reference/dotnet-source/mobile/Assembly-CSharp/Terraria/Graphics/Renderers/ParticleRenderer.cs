using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x020008C9 RID: 2249
	[Token(Token = "0x20008C9")]
	public class ParticleRenderer
	{
		// Token: 0x06004C0E RID: 19470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C0E")]
		[Address(RVA = "0x6E905C", Offset = "0x6E905C", VA = "0x6E905C")]
		public ParticleRenderer()
		{
		}

		// Token: 0x06004C0F RID: 19471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C0F")]
		[Address(RVA = "0x6E90D0", Offset = "0x6E90D0", VA = "0x6E90D0")]
		public void Add(IParticle particle)
		{
		}

		// Token: 0x06004C10 RID: 19472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C10")]
		[Address(RVA = "0x6E91C4", Offset = "0x6E91C4", VA = "0x6E91C4")]
		public void Clear()
		{
		}

		// Token: 0x06004C11 RID: 19473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C11")]
		[Address(RVA = "0x6E92E4", Offset = "0x6E92E4", VA = "0x6E92E4")]
		public void Update()
		{
		}

		// Token: 0x06004C12 RID: 19474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C12")]
		[Address(RVA = "0x6E9534", Offset = "0x6E9534", VA = "0x6E9534")]
		public void Draw(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x040090E7 RID: 37095
		[Token(Token = "0x40090E7")]
		[FieldOffset(Offset = "0x8")]
		public ParticleRendererSettings Settings;

		// Token: 0x040090E8 RID: 37096
		[Token(Token = "0x40090E8")]
		[FieldOffset(Offset = "0x10")]
		public int ParticleCount;

		// Token: 0x040090E9 RID: 37097
		[Token(Token = "0x40090E9")]
		[FieldOffset(Offset = "0x14")]
		public IParticle[] Particles;
	}
}
