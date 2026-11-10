using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D59 RID: 3417
	[Token(Token = "0x2000D59")]
	public class EmoteButton : UIElement
	{
		// Token: 0x0600654E RID: 25934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600654E")]
		[Address(RVA = "0xB45D68", Offset = "0xB45D68", VA = "0xB45D68")]
		public EmoteButton(int emoteIndex)
		{
		}

		// Token: 0x0600654F RID: 25935 RVA: 0x0002E170 File Offset: 0x0002C370
		[Token(Token = "0x600654F")]
		[Address(RVA = "0xB46058", Offset = "0xB46058", VA = "0xB46058")]
		private Rectangle GetFrame()
		{
			return default(Rectangle);
		}

		// Token: 0x06006550 RID: 25936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006550")]
		[Address(RVA = "0xB46168", Offset = "0xB46168", VA = "0xB46168")]
		private void UpdateFrame()
		{
		}

		// Token: 0x06006551 RID: 25937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006551")]
		[Address(RVA = "0xB46180", Offset = "0xB46180", VA = "0xB46180", Slot = "9")]
		public override void Update(GameTime gameTime)
		{
		}

		// Token: 0x06006552 RID: 25938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006552")]
		[Address(RVA = "0xB4619C", Offset = "0xB4619C", VA = "0xB4619C", Slot = "6")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x06006553 RID: 25939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006553")]
		[Address(RVA = "0xB46808", Offset = "0xB46808", VA = "0xB46808", Slot = "23")]
		public override void MouseOver(UIMouseEvent evt)
		{
		}

		// Token: 0x06006554 RID: 25940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006554")]
		[Address(RVA = "0xB46850", Offset = "0xB46850", VA = "0xB46850", Slot = "24")]
		public override void MouseOut(UIMouseEvent evt)
		{
		}

		// Token: 0x06006555 RID: 25941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006555")]
		[Address(RVA = "0xB4686C", Offset = "0xB4686C", VA = "0xB4686C", Slot = "17")]
		public override void LeftClick(UIMouseEvent evt)
		{
		}

		// Token: 0x0400A2A9 RID: 41641
		[Token(Token = "0x400A2A9")]
		[FieldOffset(Offset = "0xF4")]
		private Asset<Texture2D> _texture;

		// Token: 0x0400A2AA RID: 41642
		[Token(Token = "0x400A2AA")]
		[FieldOffset(Offset = "0xF8")]
		private Asset<Texture2D> _textureBorder;

		// Token: 0x0400A2AB RID: 41643
		[Token(Token = "0x400A2AB")]
		[FieldOffset(Offset = "0xFC")]
		private int _emoteIndex;

		// Token: 0x0400A2AC RID: 41644
		[Token(Token = "0x400A2AC")]
		[FieldOffset(Offset = "0x100")]
		private bool _hovered;

		// Token: 0x0400A2AD RID: 41645
		[Token(Token = "0x400A2AD")]
		[FieldOffset(Offset = "0x104")]
		private int _frameCounter;
	}
}
