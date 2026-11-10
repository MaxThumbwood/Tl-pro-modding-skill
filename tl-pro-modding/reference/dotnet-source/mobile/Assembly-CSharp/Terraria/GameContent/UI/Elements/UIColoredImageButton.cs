using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D75 RID: 3445
	[Token(Token = "0x2000D75")]
	public class UIColoredImageButton : UIElement
	{
		// Token: 0x060065F2 RID: 26098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065F2")]
		[Address(RVA = "0xB5744C", Offset = "0xB5744C", VA = "0xB5744C")]
		public UIColoredImageButton(Asset<Texture2D> texture, bool isSmall = false)
		{
		}

		// Token: 0x060065F3 RID: 26099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065F3")]
		[Address(RVA = "0xB57960", Offset = "0xB57960", VA = "0xB57960")]
		public void SetImage(Asset<Texture2D> texture)
		{
		}

		// Token: 0x060065F4 RID: 26100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065F4")]
		[Address(RVA = "0xB57A4C", Offset = "0xB57A4C", VA = "0xB57A4C")]
		public void SetImageWithoutSettingSize(Asset<Texture2D> texture)
		{
		}

		// Token: 0x060065F5 RID: 26101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065F5")]
		[Address(RVA = "0xB57A54", Offset = "0xB57A54", VA = "0xB57A54", Slot = "6")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x060065F6 RID: 26102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065F6")]
		[Address(RVA = "0xB58120", Offset = "0xB58120", VA = "0xB58120", Slot = "23")]
		public override void MouseOver(UIMouseEvent evt)
		{
		}

		// Token: 0x060065F7 RID: 26103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065F7")]
		[Address(RVA = "0xB58168", Offset = "0xB58168", VA = "0xB58168")]
		public void SetVisibility(float whenActive, float whenInactive)
		{
		}

		// Token: 0x060065F8 RID: 26104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065F8")]
		[Address(RVA = "0xB581A8", Offset = "0xB581A8", VA = "0xB581A8")]
		public void SetColor(Color color)
		{
		}

		// Token: 0x060065F9 RID: 26105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065F9")]
		[Address(RVA = "0xB581B0", Offset = "0xB581B0", VA = "0xB581B0")]
		public void SetMiddleTexture(Asset<Texture2D> texAsset)
		{
		}

		// Token: 0x060065FA RID: 26106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065FA")]
		[Address(RVA = "0xB581B8", Offset = "0xB581B8", VA = "0xB581B8")]
		public void SetSelected(bool selected)
		{
		}

		// Token: 0x060065FB RID: 26107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065FB")]
		[Address(RVA = "0xB581C0", Offset = "0xB581C0", VA = "0xB581C0", Slot = "24")]
		public override void MouseOut(UIMouseEvent evt)
		{
		}

		// Token: 0x0400A333 RID: 41779
		[Token(Token = "0x400A333")]
		[FieldOffset(Offset = "0xF4")]
		private Asset<Texture2D> _backPanelTexture;

		// Token: 0x0400A334 RID: 41780
		[Token(Token = "0x400A334")]
		[FieldOffset(Offset = "0xF8")]
		private Asset<Texture2D> _texture;

		// Token: 0x0400A335 RID: 41781
		[Token(Token = "0x400A335")]
		[FieldOffset(Offset = "0xFC")]
		private Asset<Texture2D> _middleTexture;

		// Token: 0x0400A336 RID: 41782
		[Token(Token = "0x400A336")]
		[FieldOffset(Offset = "0x100")]
		private Asset<Texture2D> _backPanelHighlightTexture;

		// Token: 0x0400A337 RID: 41783
		[Token(Token = "0x400A337")]
		[FieldOffset(Offset = "0x104")]
		private Asset<Texture2D> _backPanelBorderTexture;

		// Token: 0x0400A338 RID: 41784
		[Token(Token = "0x400A338")]
		[FieldOffset(Offset = "0x108")]
		private Color _color;

		// Token: 0x0400A339 RID: 41785
		[Token(Token = "0x400A339")]
		[FieldOffset(Offset = "0x10C")]
		private float _visibilityActive;

		// Token: 0x0400A33A RID: 41786
		[Token(Token = "0x400A33A")]
		[FieldOffset(Offset = "0x110")]
		private float _visibilityInactive;

		// Token: 0x0400A33B RID: 41787
		[Token(Token = "0x400A33B")]
		[FieldOffset(Offset = "0x114")]
		private bool _selected;

		// Token: 0x0400A33C RID: 41788
		[Token(Token = "0x400A33C")]
		[FieldOffset(Offset = "0x115")]
		private bool _hovered;
	}
}
