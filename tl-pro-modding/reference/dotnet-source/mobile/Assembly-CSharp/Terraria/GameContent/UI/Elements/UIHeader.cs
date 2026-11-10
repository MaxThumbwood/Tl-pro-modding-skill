using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D81 RID: 3457
	[Token(Token = "0x2000D81")]
	public class UIHeader : UIElement
	{
		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x06006631 RID: 26161 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006632 RID: 26162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AF0")]
		public string Text
		{
			[Token(Token = "0x6006631")]
			[Address(RVA = "0xB5D144", Offset = "0xB5D144", VA = "0xB5D144")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006632")]
			[Address(RVA = "0xB5D14C", Offset = "0xB5D14C", VA = "0xB5D14C")]
			set
			{
			}
		}

		// Token: 0x06006633 RID: 26163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006633")]
		[Address(RVA = "0xB5D280", Offset = "0xB5D280", VA = "0xB5D280")]
		public UIHeader()
		{
		}

		// Token: 0x06006634 RID: 26164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006634")]
		[Address(RVA = "0xB5D310", Offset = "0xB5D310", VA = "0xB5D310")]
		public UIHeader(string text)
		{
		}

		// Token: 0x06006635 RID: 26165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006635")]
		[Address(RVA = "0xB5D388", Offset = "0xB5D388", VA = "0xB5D388", Slot = "6")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x0400A375 RID: 41845
		[Token(Token = "0x400A375")]
		[FieldOffset(Offset = "0xF4")]
		private string _text;
	}
}
