using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D88 RID: 3464
	[Token(Token = "0x2000D88")]
	public class UIItemIcon : UIElement
	{
		// Token: 0x06006656 RID: 26198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006656")]
		[Address(RVA = "0xB5FD9C", Offset = "0xB5FD9C", VA = "0xB5FD9C")]
		public UIItemIcon(Item item, bool blackedOut)
		{
		}

		// Token: 0x06006657 RID: 26199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006657")]
		[Address(RVA = "0xB5FE70", Offset = "0xB5FE70", VA = "0xB5FE70", Slot = "6")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x0400A397 RID: 41879
		[Token(Token = "0x400A397")]
		[FieldOffset(Offset = "0xF4")]
		private Item _item;

		// Token: 0x0400A398 RID: 41880
		[Token(Token = "0x400A398")]
		[FieldOffset(Offset = "0xF8")]
		private bool _blackedOut;
	}
}
