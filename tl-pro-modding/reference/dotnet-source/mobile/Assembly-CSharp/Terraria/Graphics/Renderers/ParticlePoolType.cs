using System;
using Il2CppDummyDll;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x020008CC RID: 2252
	[Token(Token = "0x20008CC")]
	public class ParticlePoolType<T> : ParticlePool where T : class, IPooledParticle
	{
		// Token: 0x06004C1B RID: 19483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C1B")]
		public ParticlePoolType(int initialPoolSize, ParticlePool.ParticleInstantiator instantiator)
		{
		}

		// Token: 0x06004C1C RID: 19484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C1C")]
		public T RequestParticle()
		{
			return null;
		}
	}
}
