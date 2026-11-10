using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D8A RID: 3466
	[Token(Token = "0x2000D8A")]
	public class UIKeybindingSimpleListItem : UIElement
	{
		// Token: 0x0600665B RID: 26203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600665B")]
		[Address(RVA = "0xB60340", Offset = "0xB60340", VA = "0xB60340")]
		public UIKeybindingSimpleListItem(Func<string> getText, Color color)
		{
		}

		// Token: 0x0600665C RID: 26204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600665C")]
		[Address(RVA = "0xB60498", Offset = "0xB60498", VA = "0xB60498", Slot = "6")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x0400A39C RID: 41884
		[Token(Token = "0x400A39C")]
		[FieldOffset(Offset = "0xF1")]
		private Color _color;

		// Token: 0x0400A39D RID: 41885
		[Token(Token = "0x400A39D")]
		[FieldOffset(Offset = "0xF8")]
		private Func<string> _GetTextFunction;

		// Token: 0x02000D8B RID: 3467
		[Token(Token = "0x2000D8B")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600665E RID: 26206 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600665E")]
			[Address(RVA = "0xB60948", Offset = "0xB60948", VA = "0xB60948")]
			public <>c()
			{
			}

			// Token: 0x0600665F RID: 26207 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600665F")]
			[Address(RVA = "0xB60950", Offset = "0xB60950", VA = "0xB60950")]
			internal string <.ctor>b__2_0()
			{
				return null;
			}

			// Token: 0x0400A39E RID: 41886
			[Token(Token = "0x400A39E")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIKeybindingSimpleListItem.<>c <>9;

			// Token: 0x0400A39F RID: 41887
			[Token(Token = "0x400A39F")]
			[FieldOffset(Offset = "0x4")]
			public static Func<string> <>9__2_0;
		}
	}
}
