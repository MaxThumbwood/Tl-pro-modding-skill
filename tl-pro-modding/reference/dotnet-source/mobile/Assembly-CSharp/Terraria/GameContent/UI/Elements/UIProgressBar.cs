using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D93 RID: 3475
	[Token(Token = "0x2000D93")]
	public class UIProgressBar : UIElement
	{
		// Token: 0x0600668A RID: 26250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600668A")]
		[Address(RVA = "0xB63CD0", Offset = "0xB63CD0", VA = "0xB63CD0")]
		public UIProgressBar()
		{
		}

		// Token: 0x0600668B RID: 26251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600668B")]
		[Address(RVA = "0xB63E80", Offset = "0xB63E80", VA = "0xB63E80")]
		public void SetProgress(float value)
		{
		}

		// Token: 0x0600668C RID: 26252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600668C")]
		[Address(RVA = "0xB63E9C", Offset = "0xB63E9C", VA = "0xB63E9C", Slot = "6")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x0400A3B6 RID: 41910
		[Token(Token = "0x400A3B6")]
		[FieldOffset(Offset = "0xF4")]
		private UIProgressBar.UIInnerProgressBar _progressBar;

		// Token: 0x0400A3B7 RID: 41911
		[Token(Token = "0x400A3B7")]
		[FieldOffset(Offset = "0xF8")]
		private float _visualProgress;

		// Token: 0x0400A3B8 RID: 41912
		[Token(Token = "0x400A3B8")]
		[FieldOffset(Offset = "0xFC")]
		private float _targetProgress;

		// Token: 0x02000D94 RID: 3476
		[Token(Token = "0x2000D94")]
		private class UIInnerProgressBar : UIElement
		{
			// Token: 0x0600668D RID: 26253 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600668D")]
			[Address(RVA = "0xB63F10", Offset = "0xB63F10", VA = "0xB63F10", Slot = "6")]
			protected override void DrawSelf(SpriteBatch spriteBatch)
			{
			}

			// Token: 0x0600668E RID: 26254 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600668E")]
			[Address(RVA = "0xB63E18", Offset = "0xB63E18", VA = "0xB63E18")]
			public UIInnerProgressBar()
			{
			}
		}
	}
}
