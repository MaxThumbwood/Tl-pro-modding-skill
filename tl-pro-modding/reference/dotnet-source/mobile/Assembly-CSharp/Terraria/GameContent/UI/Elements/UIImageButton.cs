using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D85 RID: 3461
	[Token(Token = "0x2000D85")]
	public class UIImageButton : UIElement
	{
		// Token: 0x06006646 RID: 26182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006646")]
		[Address(RVA = "0xB5F1C8", Offset = "0xB5F1C8", VA = "0xB5F1C8")]
		public UIImageButton(Asset<Texture2D> texture, [Optional] Rectangle? frame)
		{
		}

		// Token: 0x06006647 RID: 26183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006647")]
		[Address(RVA = "0xB5F450", Offset = "0xB5F450", VA = "0xB5F450")]
		public void SetHoverImage(Asset<Texture2D> texture, [Optional] Rectangle? frame)
		{
		}

		// Token: 0x06006648 RID: 26184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006648")]
		[Address(RVA = "0xB5F47C", Offset = "0xB5F47C", VA = "0xB5F47C")]
		public void SetImage(Asset<Texture2D> texture, [Optional] Rectangle? frame)
		{
		}

		// Token: 0x06006649 RID: 26185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006649")]
		[Address(RVA = "0xB5F634", Offset = "0xB5F634", VA = "0xB5F634", Slot = "6")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x0600664A RID: 26186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600664A")]
		[Address(RVA = "0xB5F7D8", Offset = "0xB5F7D8", VA = "0xB5F7D8", Slot = "23")]
		public override void MouseOver(UIMouseEvent evt)
		{
		}

		// Token: 0x0600664B RID: 26187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600664B")]
		[Address(RVA = "0xB5F814", Offset = "0xB5F814", VA = "0xB5F814", Slot = "24")]
		public override void MouseOut(UIMouseEvent evt)
		{
		}

		// Token: 0x0600664C RID: 26188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600664C")]
		[Address(RVA = "0xB5F81C", Offset = "0xB5F81C", VA = "0xB5F81C")]
		public void SetVisibility(float whenActive, float whenInactive)
		{
		}

		// Token: 0x0400A38C RID: 41868
		[Token(Token = "0x400A38C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Asset<Texture2D> _texture;

		// Token: 0x0400A38D RID: 41869
		[Token(Token = "0x400A38D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		protected float _visibilityActive;

		// Token: 0x0400A38E RID: 41870
		[Token(Token = "0x400A38E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		protected float _visibilityInactive;

		// Token: 0x0400A38F RID: 41871
		[Token(Token = "0x400A38F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Asset<Texture2D> _borderTexture;

		// Token: 0x0400A390 RID: 41872
		[Token(Token = "0x400A390")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Rectangle? _frame;

		// Token: 0x0400A391 RID: 41873
		[Token(Token = "0x400A391")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Rectangle? _borderFrame;

		// Token: 0x0400A392 RID: 41874
		[Token(Token = "0x400A392")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		public Color Color;

		// Token: 0x0400A393 RID: 41875
		[Token(Token = "0x400A393")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public Color BorderColor;
	}
}
