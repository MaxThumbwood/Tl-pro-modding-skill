using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x020008DF RID: 2271
	[Token(Token = "0x20008DF")]
	public interface IPlayerRenderer
	{
		// Token: 0x06004C8D RID: 19597
		[Token(Token = "0x6004C8D")]
		void DrawPlayers(Camera camera, List<Player> players);

		// Token: 0x06004C8E RID: 19598
		[Token(Token = "0x6004C8E")]
		void DrawPlayerHead(Camera camera, Player drawPlayer, Vector2 position, float alpha = 1f, float scale = 1f, [Optional] Color borderColor);

		// Token: 0x06004C8F RID: 19599
		[Token(Token = "0x6004C8F")]
		void DrawPlayer(Camera camera, Player drawPlayer, Vector2 position, float rotation, Vector2 rotationOrigin, float shadow = 0f, float scale = 1f, [Optional] Vector2[] positionalOffsets);

		// Token: 0x06004C90 RID: 19600
		[Token(Token = "0x6004C90")]
		void PrepareDrawForFrame(Player drawPlayer);
	}
}
