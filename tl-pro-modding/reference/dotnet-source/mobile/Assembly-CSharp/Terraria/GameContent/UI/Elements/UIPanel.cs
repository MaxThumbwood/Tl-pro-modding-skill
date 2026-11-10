using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D91 RID: 3473
	[Token(Token = "0x2000D91")]
	public class UIPanel : UIElement
	{
		// Token: 0x06006680 RID: 26240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006680")]
		[Address(RVA = "0xB62B40", Offset = "0xB62B40", VA = "0xB62B40")]
		public UIPanel()
		{
		}

		// Token: 0x06006681 RID: 26241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006681")]
		[Address(RVA = "0xB62E70", Offset = "0xB62E70", VA = "0xB62E70")]
		public UIPanel(Asset<Texture2D> customBackground, Asset<Texture2D> customborder, int customCornerSize = 12, int customBarSize = 4)
		{
		}

		// Token: 0x06006682 RID: 26242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006682")]
		[Address(RVA = "0xB62FC4", Offset = "0xB62FC4", VA = "0xB62FC4")]
		private void DrawPanel(SpriteBatch spriteBatch, Texture2D texture, Color color)
		{
		}

		// Token: 0x06006683 RID: 26243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006683")]
		[Address(RVA = "0xB63910", Offset = "0xB63910", VA = "0xB63910", Slot = "6")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x0400A3AD RID: 41901
		[Token(Token = "0x400A3AD")]
		[FieldOffset(Offset = "0xF4")]
		private int _cornerSize;

		// Token: 0x0400A3AE RID: 41902
		[Token(Token = "0x400A3AE")]
		[FieldOffset(Offset = "0xF8")]
		private int _barSize;

		// Token: 0x0400A3AF RID: 41903
		[Token(Token = "0x400A3AF")]
		[FieldOffset(Offset = "0xFC")]
		private Asset<Texture2D> _borderTexture;

		// Token: 0x0400A3B0 RID: 41904
		[Token(Token = "0x400A3B0")]
		[FieldOffset(Offset = "0x100")]
		private Asset<Texture2D> _backgroundTexture;

		// Token: 0x0400A3B1 RID: 41905
		[Token(Token = "0x400A3B1")]
		[FieldOffset(Offset = "0x104")]
		public Color BorderColor;

		// Token: 0x0400A3B2 RID: 41906
		[Token(Token = "0x400A3B2")]
		[FieldOffset(Offset = "0x108")]
		public Color BackgroundColor;
	}
}
