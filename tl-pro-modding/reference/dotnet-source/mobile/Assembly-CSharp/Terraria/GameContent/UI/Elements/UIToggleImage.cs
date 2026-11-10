using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D9E RID: 3486
	[Token(Token = "0x2000D9E")]
	public class UIToggleImage : UIElement
	{
		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x060066F0 RID: 26352 RVA: 0x0002E740 File Offset: 0x0002C940
		[Token(Token = "0x17000B0A")]
		public bool IsOn
		{
			[Token(Token = "0x60066F0")]
			[Address(RVA = "0xB6798C", Offset = "0xB6798C", VA = "0xB6798C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060066F1 RID: 26353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066F1")]
		[Address(RVA = "0xB67994", Offset = "0xB67994", VA = "0xB67994")]
		public UIToggleImage(Asset<Texture2D> texture, int width, int height, Point onTextureOffset, Point offTextureOffset)
		{
		}

		// Token: 0x060066F2 RID: 26354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066F2")]
		[Address(RVA = "0xB67BC0", Offset = "0xB67BC0", VA = "0xB67BC0", Slot = "6")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x060066F3 RID: 26355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066F3")]
		[Address(RVA = "0xB67DCC", Offset = "0xB67DCC", VA = "0xB67DCC", Slot = "17")]
		public override void LeftClick(UIMouseEvent evt)
		{
		}

		// Token: 0x060066F4 RID: 26356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066F4")]
		[Address(RVA = "0xB67DF0", Offset = "0xB67DF0", VA = "0xB67DF0")]
		public void SetState(bool value)
		{
		}

		// Token: 0x060066F5 RID: 26357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066F5")]
		[Address(RVA = "0xB67DE0", Offset = "0xB67DE0", VA = "0xB67DE0")]
		public void Toggle()
		{
		}

		// Token: 0x0400A3F8 RID: 41976
		[Token(Token = "0x400A3F8")]
		[FieldOffset(Offset = "0xF4")]
		private Asset<Texture2D> _onTexture;

		// Token: 0x0400A3F9 RID: 41977
		[Token(Token = "0x400A3F9")]
		[FieldOffset(Offset = "0xF8")]
		private Asset<Texture2D> _offTexture;

		// Token: 0x0400A3FA RID: 41978
		[Token(Token = "0x400A3FA")]
		[FieldOffset(Offset = "0xFC")]
		private int _drawWidth;

		// Token: 0x0400A3FB RID: 41979
		[Token(Token = "0x400A3FB")]
		[FieldOffset(Offset = "0x100")]
		private int _drawHeight;

		// Token: 0x0400A3FC RID: 41980
		[Token(Token = "0x400A3FC")]
		[FieldOffset(Offset = "0x104")]
		private Point _onTextureOffset;

		// Token: 0x0400A3FD RID: 41981
		[Token(Token = "0x400A3FD")]
		[FieldOffset(Offset = "0x10C")]
		private Point _offTextureOffset;

		// Token: 0x0400A3FE RID: 41982
		[Token(Token = "0x400A3FE")]
		[FieldOffset(Offset = "0x114")]
		private bool _isOn;
	}
}
