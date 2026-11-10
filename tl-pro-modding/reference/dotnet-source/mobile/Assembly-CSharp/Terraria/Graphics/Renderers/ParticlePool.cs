using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x020008CA RID: 2250
	[Token(Token = "0x20008CA")]
	public class ParticlePool
	{
		// Token: 0x06004C13 RID: 19475 RVA: 0x00023FE8 File Offset: 0x000221E8
		[Token(Token = "0x6004C13")]
		[Address(RVA = "0x6E9688", Offset = "0x6E9688", VA = "0x6E9688")]
		public int CountParticlesInUse()
		{
			return 0;
		}

		// Token: 0x06004C14 RID: 19476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C14")]
		[Address(RVA = "0x6E9690", Offset = "0x6E9690", VA = "0x6E9690")]
		public ParticlePool(int initialPoolSize, ParticlePool.ParticleInstantiator instantiator)
		{
		}

		// Token: 0x06004C15 RID: 19477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C15")]
		public T RequestParticle<T>() where T : class, IPooledParticle
		{
			return null;
		}

		// Token: 0x06004C16 RID: 19478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C16")]
		public void ReleaseParticle<T>(T particle) where T : class, IPooledParticle
		{
		}

		// Token: 0x040090EA RID: 37098
		[Token(Token = "0x40090EA")]
		[FieldOffset(Offset = "0x8")]
		private ParticlePool.ParticleInstantiator _instantiator;

		// Token: 0x040090EB RID: 37099
		[Token(Token = "0x40090EB")]
		[FieldOffset(Offset = "0xC")]
		private List<IPooledParticle> _availableParticles;

		// Token: 0x040090EC RID: 37100
		[Token(Token = "0x40090EC")]
		[FieldOffset(Offset = "0x10")]
		private int activeParticleCount;

		// Token: 0x020008CB RID: 2251
		// (Invoke) Token: 0x06004C18 RID: 19480
		[Token(Token = "0x20008CB")]
		public delegate IPooledParticle ParticleInstantiator(ParticlePool pool);
	}
}
