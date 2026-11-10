using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D82 RID: 3458
	[Token(Token = "0x2000D82")]
	public class UIHorizontalSeparator : UIElement
	{
		// Token: 0x06006636 RID: 26166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006636")]
		[Address(RVA = "0xB5D834", Offset = "0xB5D834", VA = "0xB5D834")]
		public UIHorizontalSeparator(int EdgeWidth = 2, bool highlightSideUp = true)
		{
		}

		// Token: 0x06006637 RID: 26167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006637")]
		[Address(RVA = "0xB5DB10", Offset = "0xB5DB10", VA = "0xB5DB10", Slot = "6")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x06006638 RID: 26168 RVA: 0x0002E488 File Offset: 0x0002C688
		[Token(Token = "0x6006638")]
		[Address(RVA = "0xB5DBF8", Offset = "0xB5DBF8", VA = "0xB5DBF8", Slot = "12")]
		public override bool ContainsPoint(Vector2 point)
		{
			return default(bool);
		}

		// Token: 0x0400A376 RID: 41846
		[Token(Token = "0x400A376")]
		[FieldOffset(Offset = "0xF4")]
		private Asset<Texture2D> _texture;

		// Token: 0x0400A377 RID: 41847
		[Token(Token = "0x400A377")]
		[FieldOffset(Offset = "0xF8")]
		public Color Color;

		// Token: 0x0400A378 RID: 41848
		[Token(Token = "0x400A378")]
		[FieldOffset(Offset = "0xFC")]
		public int EdgeWidth;
	}
}
