using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D96 RID: 3478
	[Token(Token = "0x2000D96")]
	public class UIScrollbar : UIElement
	{
		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x06006693 RID: 26259 RVA: 0x0002E560 File Offset: 0x0002C760
		// (set) Token: 0x06006694 RID: 26260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AF6")]
		public float ViewPosition
		{
			[Token(Token = "0x6006693")]
			[Address(RVA = "0xB64110", Offset = "0xB64110", VA = "0xB64110")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6006694")]
			[Address(RVA = "0xB61900", Offset = "0xB61900", VA = "0xB61900")]
			set
			{
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x06006695 RID: 26261 RVA: 0x0002E578 File Offset: 0x0002C778
		[Token(Token = "0x17000AF7")]
		public bool CanScroll
		{
			[Token(Token = "0x6006695")]
			[Address(RVA = "0xB64118", Offset = "0xB64118", VA = "0xB64118")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006696 RID: 26262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006696")]
		[Address(RVA = "0xB64134", Offset = "0xB64134", VA = "0xB64134")]
		public void GoToBottom()
		{
		}

		// Token: 0x06006697 RID: 26263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006697")]
		[Address(RVA = "0xB64164", Offset = "0xB64164", VA = "0xB64164")]
		public UIScrollbar(UIScrollbar.ColorTheme theme = UIScrollbar.ColorTheme.Blue)
		{
		}

		// Token: 0x06006698 RID: 26264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006698")]
		[Address(RVA = "0xB61FA8", Offset = "0xB61FA8", VA = "0xB61FA8")]
		public void SetView(float viewSize, float maxViewSize)
		{
		}

		// Token: 0x06006699 RID: 26265 RVA: 0x0002E590 File Offset: 0x0002C790
		[Token(Token = "0x6006699")]
		[Address(RVA = "0xB64450", Offset = "0xB64450", VA = "0xB64450")]
		public float GetValue()
		{
			return 0f;
		}

		// Token: 0x0600669A RID: 26266 RVA: 0x0002E5A8 File Offset: 0x0002C7A8
		[Token(Token = "0x600669A")]
		[Address(RVA = "0xB64458", Offset = "0xB64458", VA = "0xB64458")]
		private Rectangle GetHandleRectangle()
		{
			return default(Rectangle);
		}

		// Token: 0x0600669B RID: 26267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600669B")]
		[Address(RVA = "0xB6451C", Offset = "0xB6451C", VA = "0xB6451C")]
		private void DrawBar(SpriteBatch spriteBatch, Texture2D texture, Rectangle dimensions, Color color)
		{
		}

		// Token: 0x0600669C RID: 26268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600669C")]
		[Address(RVA = "0xB6482C", Offset = "0xB6482C", VA = "0xB6482C", Slot = "6")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x0600669D RID: 26269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600669D")]
		[Address(RVA = "0xB64C2C", Offset = "0xB64C2C", VA = "0xB64C2C", Slot = "15")]
		public override void LeftMouseDown(UIMouseEvent evt)
		{
		}

		// Token: 0x0600669E RID: 26270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600669E")]
		[Address(RVA = "0xB64EA8", Offset = "0xB64EA8", VA = "0xB64EA8", Slot = "16")]
		public override void LeftMouseUp(UIMouseEvent evt)
		{
		}

		// Token: 0x0400A3BC RID: 41916
		[Token(Token = "0x400A3BC")]
		[FieldOffset(Offset = "0xF4")]
		private float _viewPosition;

		// Token: 0x0400A3BD RID: 41917
		[Token(Token = "0x400A3BD")]
		[FieldOffset(Offset = "0xF8")]
		private float _viewSize;

		// Token: 0x0400A3BE RID: 41918
		[Token(Token = "0x400A3BE")]
		[FieldOffset(Offset = "0xFC")]
		private float _maxViewSize;

		// Token: 0x0400A3BF RID: 41919
		[Token(Token = "0x400A3BF")]
		[FieldOffset(Offset = "0x100")]
		private bool _isDragging;

		// Token: 0x0400A3C0 RID: 41920
		[Token(Token = "0x400A3C0")]
		[FieldOffset(Offset = "0x101")]
		private bool _isHoveringOverHandle;

		// Token: 0x0400A3C1 RID: 41921
		[Token(Token = "0x400A3C1")]
		[FieldOffset(Offset = "0x104")]
		private float _dragYOffset;

		// Token: 0x0400A3C2 RID: 41922
		[Token(Token = "0x400A3C2")]
		[FieldOffset(Offset = "0x108")]
		public bool AutoHide;

		// Token: 0x0400A3C3 RID: 41923
		[Token(Token = "0x400A3C3")]
		[FieldOffset(Offset = "0x10C")]
		private Asset<Texture2D> _texture;

		// Token: 0x0400A3C4 RID: 41924
		[Token(Token = "0x400A3C4")]
		[FieldOffset(Offset = "0x110")]
		private Asset<Texture2D> _innerTexture;

		// Token: 0x0400A3C5 RID: 41925
		[Token(Token = "0x400A3C5")]
		[FieldOffset(Offset = "0x114")]
		private UIScrollbar.ColorTheme _theme;

		// Token: 0x02000D97 RID: 3479
		[Token(Token = "0x2000D97")]
		public enum ColorTheme
		{
			// Token: 0x0400A3C7 RID: 41927
			[Token(Token = "0x400A3C7")]
			Blue,
			// Token: 0x0400A3C8 RID: 41928
			[Token(Token = "0x400A3C8")]
			Cyan
		}
	}
}
