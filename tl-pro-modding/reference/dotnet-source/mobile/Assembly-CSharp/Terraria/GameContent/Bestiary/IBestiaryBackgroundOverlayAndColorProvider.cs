using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000BFF RID: 3071
	[Token(Token = "0x2000BFF")]
	public interface IBestiaryBackgroundOverlayAndColorProvider
	{
		// Token: 0x06005C73 RID: 23667
		[Token(Token = "0x6005C73")]
		Asset<Texture2D> GetBackgroundOverlayImage();

		// Token: 0x06005C74 RID: 23668
		[Token(Token = "0x6005C74")]
		Color? GetBackgroundOverlayColor();

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06005C75 RID: 23669
		[Token(Token = "0x17000A45")]
		float DisplayPriority
		{
			[Token(Token = "0x6005C75")]
			get;
		}
	}
}
