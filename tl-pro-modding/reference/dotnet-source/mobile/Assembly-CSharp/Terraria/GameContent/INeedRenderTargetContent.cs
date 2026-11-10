using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent
{
	// Token: 0x0200097D RID: 2429
	[Token(Token = "0x200097D")]
	public interface INeedRenderTargetContent
	{
		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06005048 RID: 20552
		[Token(Token = "0x17000991")]
		bool IsReady
		{
			[Token(Token = "0x6005048")]
			get;
		}

		// Token: 0x06005049 RID: 20553
		[Token(Token = "0x6005049")]
		void PrepareRenderTarget(GraphicsDevice device, SpriteBatch spriteBatch);

		// Token: 0x0600504A RID: 20554
		[Token(Token = "0x600504A")]
		void Reset();
	}
}
