using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.Drawing
{
	// Token: 0x02000CAB RID: 3243
	[Token(Token = "0x2000CAB")]
	public class OriginalNatureRenderer : FileAPI
	{
		// Token: 0x06006046 RID: 24646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006046")]
		[Address(RVA = "0xA9B7D4", Offset = "0xA9B7D4", VA = "0xA9B7D4", Slot = "4")]
		public void Begin()
		{
		}

		// Token: 0x06006047 RID: 24647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006047")]
		[Address(RVA = "0xA9B7D8", Offset = "0xA9B7D8", VA = "0xA9B7D8", Slot = "5")]
		public void DrawNature(Texture2D texture, ref Vector2 position, ref Rectangle sourceRectangle, Color color, float rotation, ref Vector2 origin, SpriteEffects effects, SideFlags seams = SideFlags.None)
		{
		}

		// Token: 0x06006048 RID: 24648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006048")]
		[Address(RVA = "0xA9B8B8", Offset = "0xA9B8B8", VA = "0xA9B8B8", Slot = "6")]
		public void DrawAfterAllObjects()
		{
		}

		// Token: 0x06006049 RID: 24649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006049")]
		[Address(RVA = "0xA9B8BC", Offset = "0xA9B8BC", VA = "0xA9B8BC")]
		public OriginalNatureRenderer()
		{
		}
	}
}
