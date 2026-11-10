using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D8C RID: 3468
	[Token(Token = "0x2000D8C")]
	public class UIKeybindingToggleListItem : UIElement
	{
		// Token: 0x06006660 RID: 26208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006660")]
		[Address(RVA = "0xB60998", Offset = "0xB60998", VA = "0xB60998")]
		public UIKeybindingToggleListItem(Func<string> getText, Func<bool> getStatus, Color color)
		{
		}

		// Token: 0x06006661 RID: 26209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006661")]
		[Address(RVA = "0xB60CC8", Offset = "0xB60CC8", VA = "0xB60CC8", Slot = "6")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x0400A3A0 RID: 41888
		[Token(Token = "0x400A3A0")]
		[FieldOffset(Offset = "0xF1")]
		private Color _color;

		// Token: 0x0400A3A1 RID: 41889
		[Token(Token = "0x400A3A1")]
		[FieldOffset(Offset = "0xF8")]
		private Func<string> _TextDisplayFunction;

		// Token: 0x0400A3A2 RID: 41890
		[Token(Token = "0x400A3A2")]
		[FieldOffset(Offset = "0xFC")]
		private Func<bool> _IsOnFunction;

		// Token: 0x0400A3A3 RID: 41891
		[Token(Token = "0x400A3A3")]
		[FieldOffset(Offset = "0x100")]
		private Asset<Texture2D> _toggleTexture;

		// Token: 0x02000D8D RID: 3469
		[Token(Token = "0x2000D8D")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006663 RID: 26211 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006663")]
			[Address(RVA = "0xB61480", Offset = "0xB61480", VA = "0xB61480")]
			public <>c()
			{
			}

			// Token: 0x06006664 RID: 26212 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006664")]
			[Address(RVA = "0xB61488", Offset = "0xB61488", VA = "0xB61488")]
			internal string <.ctor>b__4_0()
			{
				return null;
			}

			// Token: 0x06006665 RID: 26213 RVA: 0x0002E4B8 File Offset: 0x0002C6B8
			[Token(Token = "0x6006665")]
			[Address(RVA = "0xB614D0", Offset = "0xB614D0", VA = "0xB614D0")]
			internal bool <.ctor>b__4_1()
			{
				return default(bool);
			}

			// Token: 0x0400A3A4 RID: 41892
			[Token(Token = "0x400A3A4")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIKeybindingToggleListItem.<>c <>9;

			// Token: 0x0400A3A5 RID: 41893
			[Token(Token = "0x400A3A5")]
			[FieldOffset(Offset = "0x4")]
			public static Func<string> <>9__4_0;

			// Token: 0x0400A3A6 RID: 41894
			[Token(Token = "0x400A3A6")]
			[FieldOffset(Offset = "0x8")]
			public static Func<bool> <>9__4_1;
		}
	}
}
