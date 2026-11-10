using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x02000DB3 RID: 3507
	[Token(Token = "0x2000DB3")]
	public class BigProgressBarHelper
	{
		// Token: 0x0600674C RID: 26444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600674C")]
		[Address(RVA = "0xB70754", Offset = "0xB70754", VA = "0xB70754")]
		public static void DrawBareBonesBar(SpriteBatch spriteBatch, float lifePercent)
		{
		}

		// Token: 0x0600674D RID: 26445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600674D")]
		[Address(RVA = "0xB70C94", Offset = "0xB70C94", VA = "0xB70C94")]
		public static void DrawFancyBar(SpriteBatch spriteBatch, float lifeAmount, float lifeMax, Texture2D barIconTexture, Rectangle barIconFrame)
		{
		}

		// Token: 0x0600674E RID: 26446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600674E")]
		[Address(RVA = "0xB7190C", Offset = "0xB7190C", VA = "0xB7190C")]
		private static void DrawHealthText(SpriteBatch spriteBatch, Rectangle area, float current, float max)
		{
		}

		// Token: 0x0600674F RID: 26447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600674F")]
		[Address(RVA = "0xB71D38", Offset = "0xB71D38", VA = "0xB71D38")]
		public static void DrawFancyBar(SpriteBatch spriteBatch, float lifeAmount, float lifeMax, Texture2D barIconTexture, Rectangle barIconFrame, float shieldCurrent, float shieldMax)
		{
		}

		// Token: 0x06006750 RID: 26448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006750")]
		[Address(RVA = "0xB72DD8", Offset = "0xB72DD8", VA = "0xB72DD8")]
		public BigProgressBarHelper()
		{
		}

		// Token: 0x0400A449 RID: 42057
		[Token(Token = "0x400A449")]
		private const string _bossBarTexturePath = "Images/UI/UI_BossBar";
	}
}
