using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI
{
	// Token: 0x02000D30 RID: 3376
	[Token(Token = "0x2000D30")]
	public class NewMultiplayerClosePlayersOverlay : FileAPI
	{
		// Token: 0x0600643C RID: 25660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600643C")]
		[Address(RVA = "0xB21324", Offset = "0xB21324", VA = "0xB21324", Slot = "4")]
		public void Draw()
		{
		}

		// Token: 0x0600643D RID: 25661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600643D")]
		[Address(RVA = "0xB22440", Offset = "0xB22440", VA = "0xB22440")]
		private static void GetDistance(int testWidth, int testHeight, Vector2 testPosition, Player localPlayer, SpriteFont font, Player player, string nameToShow, out Vector2 namePlatePos, out float namePlateDist, out Vector2 measurement)
		{
		}

		// Token: 0x0600643E RID: 25662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600643E")]
		[Address(RVA = "0xB23CF4", Offset = "0xB23CF4", VA = "0xB23CF4")]
		public NewMultiplayerClosePlayersOverlay()
		{
		}

		// Token: 0x0400A1B9 RID: 41401
		[Token(Token = "0x400A1B9")]
		[FieldOffset(Offset = "0x8")]
		private List<NewMultiplayerClosePlayersOverlay.PlayerOnScreenCache> _playerOnScreenCache;

		// Token: 0x0400A1BA RID: 41402
		[Token(Token = "0x400A1BA")]
		[FieldOffset(Offset = "0xC")]
		private List<NewMultiplayerClosePlayersOverlay.PlayerOffScreenCache> _playerOffScreenCache;

		// Token: 0x02000D31 RID: 3377
		[Token(Token = "0x2000D31")]
		private struct PlayerOnScreenCache
		{
			// Token: 0x0600643F RID: 25663 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600643F")]
			[Address(RVA = "0xB22B38", Offset = "0xB22B38", VA = "0xB22B38")]
			public PlayerOnScreenCache(string name, Vector2 pos, Color color)
			{
			}

			// Token: 0x06006440 RID: 25664 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006440")]
			[Address(RVA = "0xB22B44", Offset = "0xB22B44", VA = "0xB22B44")]
			public void DrawPlayerName_WhenPlayerIsOnScreen(SpriteBatch spriteBatch)
			{
			}

			// Token: 0x0400A1BB RID: 41403
			[Token(Token = "0x400A1BB")]
			[FieldOffset(Offset = "0x0")]
			private string _name;

			// Token: 0x0400A1BC RID: 41404
			[Token(Token = "0x400A1BC")]
			[FieldOffset(Offset = "0x4")]
			private Vector2 _pos;

			// Token: 0x0400A1BD RID: 41405
			[Token(Token = "0x400A1BD")]
			[FieldOffset(Offset = "0xC")]
			private Color _color;
		}

		// Token: 0x02000D32 RID: 3378
		[Token(Token = "0x2000D32")]
		private struct PlayerOffScreenCache
		{
			// Token: 0x06006441 RID: 25665 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006441")]
			[Address(RVA = "0xB22A50", Offset = "0xB22A50", VA = "0xB22A50")]
			public PlayerOffScreenCache(string name, Vector2 pos, Color color, Vector2 npDistPos, string npDist, Player thePlayer, Vector2 theMeasurement, bool drawScryingOrb)
			{
			}

			// Token: 0x06006442 RID: 25666 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006442")]
			[Address(RVA = "0xB22F34", Offset = "0xB22F34", VA = "0xB22F34")]
			public void DrawPlayerName(SpriteBatch spriteBatch)
			{
			}

			// Token: 0x06006443 RID: 25667 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006443")]
			[Address(RVA = "0xB238F0", Offset = "0xB238F0", VA = "0xB238F0")]
			public void DrawPlayerHead()
			{
			}

			// Token: 0x06006444 RID: 25668 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006444")]
			[Address(RVA = "0xB23750", Offset = "0xB23750", VA = "0xB23750")]
			public void DrawLifeBar()
			{
			}

			// Token: 0x06006445 RID: 25669 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006445")]
			[Address(RVA = "0xB23388", Offset = "0xB23388", VA = "0xB23388")]
			public void DrawPlayerDistance(SpriteBatch spriteBatch)
			{
			}

			// Token: 0x0400A1BE RID: 41406
			[Token(Token = "0x400A1BE")]
			[FieldOffset(Offset = "0x0")]
			private Player player;

			// Token: 0x0400A1BF RID: 41407
			[Token(Token = "0x400A1BF")]
			[FieldOffset(Offset = "0x4")]
			private string nameToShow;

			// Token: 0x0400A1C0 RID: 41408
			[Token(Token = "0x400A1C0")]
			[FieldOffset(Offset = "0x8")]
			private Vector2 namePlatePos;

			// Token: 0x0400A1C1 RID: 41409
			[Token(Token = "0x400A1C1")]
			[FieldOffset(Offset = "0x10")]
			private Color namePlateColor;

			// Token: 0x0400A1C2 RID: 41410
			[Token(Token = "0x400A1C2")]
			[FieldOffset(Offset = "0x14")]
			private Vector2 distanceDrawPosition;

			// Token: 0x0400A1C3 RID: 41411
			[Token(Token = "0x400A1C3")]
			[FieldOffset(Offset = "0x1C")]
			private string distanceString;

			// Token: 0x0400A1C4 RID: 41412
			[Token(Token = "0x400A1C4")]
			[FieldOffset(Offset = "0x20")]
			private Vector2 measurement;

			// Token: 0x0400A1C5 RID: 41413
			[Token(Token = "0x400A1C5")]
			[FieldOffset(Offset = "0x28")]
			private bool drawScryingOrb;
		}
	}
}
