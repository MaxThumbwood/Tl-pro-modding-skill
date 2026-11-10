using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI
{
	// Token: 0x02000D2F RID: 3375
	[Token(Token = "0x2000D2F")]
	public class LegacyMultiplayerClosePlayersOverlay : FileAPI
	{
		// Token: 0x06006438 RID: 25656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006438")]
		[Address(RVA = "0xB1FB80", Offset = "0xB1FB80", VA = "0xB1FB80", Slot = "4")]
		public void Draw()
		{
		}

		// Token: 0x06006439 RID: 25657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006439")]
		[Address(RVA = "0xB20BEC", Offset = "0xB20BEC", VA = "0xB20BEC")]
		private static void DrawPlayerName2(SpriteBatch spriteBatch, ref Color namePlateColor, string npDist, ref Vector2 npDistPos)
		{
		}

		// Token: 0x0600643A RID: 25658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600643A")]
		[Address(RVA = "0xB20F8C", Offset = "0xB20F8C", VA = "0xB20F8C")]
		private static void DrawPlayerName(SpriteBatch spriteBatch, string namePlate, ref Vector2 namePlatePos, ref Color namePlateColor)
		{
		}

		// Token: 0x0600643B RID: 25659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600643B")]
		[Address(RVA = "0xB2131C", Offset = "0xB2131C", VA = "0xB2131C")]
		public LegacyMultiplayerClosePlayersOverlay()
		{
		}
	}
}
