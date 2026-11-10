using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.Drawing
{
	// Token: 0x02000CAA RID: 3242
	[Token(Token = "0x2000CAA")]
	public interface INatureRenderer
	{
		// Token: 0x06006043 RID: 24643
		[Token(Token = "0x6006043")]
		void Begin();

		// Token: 0x06006044 RID: 24644
		[Token(Token = "0x6006044")]
		void DrawNature(Texture2D texture, ref Vector2 position, ref Rectangle sourceRectangle, Color color, float rotation, ref Vector2 origin, SpriteEffects effects, SideFlags seams = SideFlags.None);

		// Token: 0x06006045 RID: 24645
		[Token(Token = "0x6006045")]
		void DrawAfterAllObjects();
	}
}
