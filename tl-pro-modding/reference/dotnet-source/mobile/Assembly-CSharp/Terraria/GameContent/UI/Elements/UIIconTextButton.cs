using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D83 RID: 3459
	[Token(Token = "0x2000D83")]
	public class UIIconTextButton : UIElement
	{
		// Token: 0x06006639 RID: 26169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006639")]
		[Address(RVA = "0xB5DC00", Offset = "0xB5DC00", VA = "0xB5DC00")]
		public UIIconTextButton(LocalizedText title, Color textColor, string iconTexturePath, float textSize = 1f, float titleAlignmentX = 0.5f, float titleWidthReduction = 10f)
		{
		}

		// Token: 0x0600663A RID: 26170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600663A")]
		[Address(RVA = "0xB5E094", Offset = "0xB5E094", VA = "0xB5E094")]
		public void SetText(LocalizedText text, float textSize, Color color)
		{
		}

		// Token: 0x0600663B RID: 26171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600663B")]
		[Address(RVA = "0xB5E4F4", Offset = "0xB5E4F4", VA = "0xB5E4F4", Slot = "6")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x0600663C RID: 26172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600663C")]
		[Address(RVA = "0xB5E818", Offset = "0xB5E818", VA = "0xB5E818", Slot = "15")]
		public override void LeftMouseDown(UIMouseEvent evt)
		{
		}

		// Token: 0x0600663D RID: 26173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600663D")]
		[Address(RVA = "0xB5E868", Offset = "0xB5E868", VA = "0xB5E868", Slot = "23")]
		public override void MouseOver(UIMouseEvent evt)
		{
		}

		// Token: 0x0600663E RID: 26174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600663E")]
		[Address(RVA = "0xB5E94C", Offset = "0xB5E94C", VA = "0xB5E94C", Slot = "24")]
		public override void MouseOut(UIMouseEvent evt)
		{
		}

		// Token: 0x0600663F RID: 26175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600663F")]
		[Address(RVA = "0xB5E088", Offset = "0xB5E088", VA = "0xB5E088")]
		public void SetColor(Color color, float opacity)
		{
		}

		// Token: 0x06006640 RID: 26176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006640")]
		[Address(RVA = "0xB5EA2C", Offset = "0xB5EA2C", VA = "0xB5EA2C")]
		public void SetHoverColor(Color color)
		{
		}

		// Token: 0x0400A379 RID: 41849
		[Token(Token = "0x400A379")]
		[FieldOffset(Offset = "0xF4")]
		private readonly Asset<Texture2D> _BasePanelTexture;

		// Token: 0x0400A37A RID: 41850
		[Token(Token = "0x400A37A")]
		[FieldOffset(Offset = "0xF8")]
		private readonly Asset<Texture2D> _hoveredTexture;

		// Token: 0x0400A37B RID: 41851
		[Token(Token = "0x400A37B")]
		[FieldOffset(Offset = "0xFC")]
		private readonly Asset<Texture2D> _iconTexture;

		// Token: 0x0400A37C RID: 41852
		[Token(Token = "0x400A37C")]
		[FieldOffset(Offset = "0x100")]
		private Color _color;

		// Token: 0x0400A37D RID: 41853
		[Token(Token = "0x400A37D")]
		[FieldOffset(Offset = "0x104")]
		private Color _hoverColor;

		// Token: 0x0400A37E RID: 41854
		[Token(Token = "0x400A37E")]
		[FieldOffset(Offset = "0x108")]
		public float FadeFromBlack;

		// Token: 0x0400A37F RID: 41855
		[Token(Token = "0x400A37F")]
		[FieldOffset(Offset = "0x10C")]
		private float _whiteLerp;

		// Token: 0x0400A380 RID: 41856
		[Token(Token = "0x400A380")]
		[FieldOffset(Offset = "0x110")]
		private float _opacity;

		// Token: 0x0400A381 RID: 41857
		[Token(Token = "0x400A381")]
		[FieldOffset(Offset = "0x114")]
		private bool _hovered;

		// Token: 0x0400A382 RID: 41858
		[Token(Token = "0x400A382")]
		[FieldOffset(Offset = "0x115")]
		private bool _soundedHover;

		// Token: 0x0400A383 RID: 41859
		[Token(Token = "0x400A383")]
		[FieldOffset(Offset = "0x118")]
		private UIText _title;
	}
}
