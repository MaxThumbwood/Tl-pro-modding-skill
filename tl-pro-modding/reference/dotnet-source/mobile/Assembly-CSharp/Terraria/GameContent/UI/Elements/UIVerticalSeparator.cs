using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D9F RID: 3487
	[Token(Token = "0x2000D9F")]
	public class UIVerticalSeparator : UIElement
	{
		// Token: 0x060066F6 RID: 26358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066F6")]
		[Address(RVA = "0xB67DF8", Offset = "0xB67DF8", VA = "0xB67DF8")]
		public UIVerticalSeparator()
		{
		}

		// Token: 0x060066F7 RID: 26359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066F7")]
		[Address(RVA = "0xB6806C", Offset = "0xB6806C", VA = "0xB6806C", Slot = "6")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x060066F8 RID: 26360 RVA: 0x0002E758 File Offset: 0x0002C958
		[Token(Token = "0x60066F8")]
		[Address(RVA = "0xB680F4", Offset = "0xB680F4", VA = "0xB680F4", Slot = "12")]
		public override bool ContainsPoint(Vector2 point)
		{
			return default(bool);
		}

		// Token: 0x0400A3FF RID: 41983
		[Token(Token = "0x400A3FF")]
		[FieldOffset(Offset = "0xF4")]
		private Asset<Texture2D> _texture;

		// Token: 0x0400A400 RID: 41984
		[Token(Token = "0x400A400")]
		[FieldOffset(Offset = "0xF8")]
		public Color Color;

		// Token: 0x0400A401 RID: 41985
		[Token(Token = "0x400A401")]
		[FieldOffset(Offset = "0xFC")]
		public int EdgeWidth;
	}
}
