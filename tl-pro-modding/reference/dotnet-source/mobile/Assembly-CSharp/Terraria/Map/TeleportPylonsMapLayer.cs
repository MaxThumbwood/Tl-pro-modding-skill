using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent;

namespace Terraria.Map
{
	// Token: 0x0200081A RID: 2074
	[Token(Token = "0x200081A")]
	public class TeleportPylonsMapLayer : FileAPI
	{
		// Token: 0x060046C9 RID: 18121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046C9")]
		[Address(RVA = "0x5A2B18", Offset = "0x5A2B18", VA = "0x5A2B18")]
		public static void DrawLine(SpriteBatch spriteBatch, Vector2 start, Vector2 end, Color col, float width)
		{
		}

		// Token: 0x060046CA RID: 18122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046CA")]
		[Address(RVA = "0x5A2F14", Offset = "0x5A2F14", VA = "0x5A2F14", Slot = "4")]
		public void Draw(ref MapOverlayDrawContext context, ref string text)
		{
		}

		// Token: 0x060046CB RID: 18123 RVA: 0x000218A0 File Offset: 0x0001FAA0
		[Token(Token = "0x60046CB")]
		[Address(RVA = "0x5A3CA4", Offset = "0x5A3CA4", VA = "0x5A3CA4")]
		public static bool IsRevealed(TeleportPylonInfo info)
		{
			return default(bool);
		}

		// Token: 0x060046CC RID: 18124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046CC")]
		[Address(RVA = "0x5A3DC4", Offset = "0x5A3DC4", VA = "0x5A3DC4")]
		public TeleportPylonsMapLayer()
		{
		}

		// Token: 0x04008DAB RID: 36267
		[Token(Token = "0x4008DAB")]
		public const int BorderSize = 10;
	}
}
