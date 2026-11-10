using System;
using Il2CppDummyDll;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x020008CD RID: 2253
	[Token(Token = "0x20008CD")]
	public interface IPooledParticle : FileAPI
	{
		// Token: 0x06004C1D RID: 19485
		[Token(Token = "0x6004C1D")]
		void RestInPool();

		// Token: 0x06004C1E RID: 19486
		[Token(Token = "0x6004C1E")]
		void FetchFromPool();
	}
}
