using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000BFD RID: 3069
	[Token(Token = "0x2000BFD")]
	public interface IBestiaryBackgroundImagePathAndColorProvider
	{
		// Token: 0x06005C70 RID: 23664
		[Token(Token = "0x6005C70")]
		Asset<Texture2D> GetBackgroundImage();

		// Token: 0x06005C71 RID: 23665
		[Token(Token = "0x6005C71")]
		Color? GetBackgroundColor();
	}
}
