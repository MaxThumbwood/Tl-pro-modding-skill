using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D7D RID: 3453
	[Token(Token = "0x2000D7D")]
	public class UIDifficultyButton : UIElement
	{
		// Token: 0x06006618 RID: 26136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006618")]
		[Address(RVA = "0xB5B1EC", Offset = "0xB5B1EC", VA = "0xB5B1EC")]
		public UIDifficultyButton(Player player, LocalizedText title, LocalizedText description, byte difficulty, Color color)
		{
		}

		// Token: 0x06006619 RID: 26137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006619")]
		[Address(RVA = "0xB5B680", Offset = "0xB5B680", VA = "0xB5B680", Slot = "6")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x0600661A RID: 26138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600661A")]
		[Address(RVA = "0xB5BA1C", Offset = "0xB5BA1C", VA = "0xB5BA1C", Slot = "15")]
		public override void LeftMouseDown(UIMouseEvent evt)
		{
		}

		// Token: 0x0600661B RID: 26139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600661B")]
		[Address(RVA = "0xB5BA84", Offset = "0xB5BA84", VA = "0xB5BA84", Slot = "23")]
		public override void MouseOver(UIMouseEvent evt)
		{
		}

		// Token: 0x0600661C RID: 26140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600661C")]
		[Address(RVA = "0xB5BAA0", Offset = "0xB5BAA0", VA = "0xB5BAA0", Slot = "24")]
		public override void MouseOut(UIMouseEvent evt)
		{
		}

		// Token: 0x0400A35D RID: 41821
		[Token(Token = "0x400A35D")]
		[FieldOffset(Offset = "0xF4")]
		private readonly Player _player;

		// Token: 0x0400A35E RID: 41822
		[Token(Token = "0x400A35E")]
		[FieldOffset(Offset = "0xF8")]
		private readonly Asset<Texture2D> _BasePanelTexture;

		// Token: 0x0400A35F RID: 41823
		[Token(Token = "0x400A35F")]
		[FieldOffset(Offset = "0xFC")]
		private readonly Asset<Texture2D> _selectedBorderTexture;

		// Token: 0x0400A360 RID: 41824
		[Token(Token = "0x400A360")]
		[FieldOffset(Offset = "0x100")]
		private readonly Asset<Texture2D> _hoveredBorderTexture;

		// Token: 0x0400A361 RID: 41825
		[Token(Token = "0x400A361")]
		[FieldOffset(Offset = "0x104")]
		private readonly byte _difficulty;

		// Token: 0x0400A362 RID: 41826
		[Token(Token = "0x400A362")]
		[FieldOffset(Offset = "0x105")]
		private readonly Color _color;

		// Token: 0x0400A363 RID: 41827
		[Token(Token = "0x400A363")]
		[FieldOffset(Offset = "0x109")]
		private bool _hovered;

		// Token: 0x0400A364 RID: 41828
		[Token(Token = "0x400A364")]
		[FieldOffset(Offset = "0x10A")]
		private bool _soundedHover;
	}
}
