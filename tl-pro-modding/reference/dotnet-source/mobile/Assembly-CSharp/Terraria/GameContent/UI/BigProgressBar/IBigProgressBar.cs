using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x02000DB2 RID: 3506
	[Token(Token = "0x2000DB2")]
	internal interface IBigProgressBar
	{
		// Token: 0x0600674A RID: 26442
		[Token(Token = "0x600674A")]
		bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info);

		// Token: 0x0600674B RID: 26443
		[Token(Token = "0x600674B")]
		void Draw(ref BigProgressBarInfo info, SpriteBatch spriteBatch);
	}
}
