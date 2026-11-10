using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D79 RID: 3449
	[Token(Token = "0x2000D79")]
	public class UIColoredSliderSimple : UIElement
	{
		// Token: 0x06006607 RID: 26119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006607")]
		[Address(RVA = "0xB595B4", Offset = "0xB595B4", VA = "0xB595B4", Slot = "6")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x06006608 RID: 26120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006608")]
		[Address(RVA = "0xB595B8", Offset = "0xB595B8", VA = "0xB595B8")]
		private void DrawValueBarDynamicWidth(SpriteBatch sb)
		{
		}

		// Token: 0x06006609 RID: 26121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006609")]
		[Address(RVA = "0xB59974", Offset = "0xB59974", VA = "0xB59974")]
		public UIColoredSliderSimple()
		{
		}

		// Token: 0x0400A350 RID: 41808
		[Token(Token = "0x400A350")]
		[FieldOffset(Offset = "0xF4")]
		public float FillPercent;

		// Token: 0x0400A351 RID: 41809
		[Token(Token = "0x400A351")]
		[FieldOffset(Offset = "0xF8")]
		public Color FilledColor;

		// Token: 0x0400A352 RID: 41810
		[Token(Token = "0x400A352")]
		[FieldOffset(Offset = "0xFC")]
		public Color EmptyColor;
	}
}
