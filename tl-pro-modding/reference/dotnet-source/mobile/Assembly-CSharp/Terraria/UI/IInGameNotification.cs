using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.UI
{
	// Token: 0x02000841 RID: 2113
	[Token(Token = "0x2000841")]
	public interface IInGameNotification
	{
		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x0600490B RID: 18699
		[Token(Token = "0x17000903")]
		object CreationObject
		{
			[Token(Token = "0x600490B")]
			get;
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x0600490C RID: 18700
		[Token(Token = "0x17000904")]
		bool ShouldBeRemoved
		{
			[Token(Token = "0x600490C")]
			get;
		}

		// Token: 0x0600490D RID: 18701
		[Token(Token = "0x600490D")]
		void Update();

		// Token: 0x0600490E RID: 18702
		[Token(Token = "0x600490E")]
		void DrawInGame(SpriteBatch spriteBatch, Vector2 bottomAnchorPosition);

		// Token: 0x0600490F RID: 18703
		[Token(Token = "0x600490F")]
		void PushAnchor(ref Vector2 positionAnchorBottom);

		// Token: 0x06004910 RID: 18704
		[Token(Token = "0x6004910")]
		void DrawInNotificationsArea(SpriteBatch spriteBatch, Rectangle area, ref int gamepadPointLocalIndexTouse);
	}
}
