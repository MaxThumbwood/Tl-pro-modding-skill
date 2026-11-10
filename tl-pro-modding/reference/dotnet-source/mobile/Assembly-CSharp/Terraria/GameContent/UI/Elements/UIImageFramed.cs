using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D86 RID: 3462
	[Token(Token = "0x2000D86")]
	public class UIImageFramed : UIElement, FileAPI
	{
		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x0600664D RID: 26189 RVA: 0x0002E4A0 File Offset: 0x0002C6A0
		// (set) Token: 0x0600664E RID: 26190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AF2")]
		public Color Color
		{
			[Token(Token = "0x600664D")]
			[Address(RVA = "0xB5F85C", Offset = "0xB5F85C", VA = "0xB5F85C", Slot = "30")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600664E")]
			[Address(RVA = "0xB5F864", Offset = "0xB5F864", VA = "0xB5F864", Slot = "31")]
			set
			{
			}
		}

		// Token: 0x0600664F RID: 26191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600664F")]
		[Address(RVA = "0xB5F86C", Offset = "0xB5F86C", VA = "0xB5F86C")]
		public UIImageFramed(Asset<Texture2D> texture, Rectangle frame)
		{
		}

		// Token: 0x06006650 RID: 26192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006650")]
		[Address(RVA = "0xB5F9A8", Offset = "0xB5F9A8", VA = "0xB5F9A8")]
		public void SetImage(Asset<Texture2D> texture, Rectangle frame)
		{
		}

		// Token: 0x06006651 RID: 26193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006651")]
		[Address(RVA = "0xB5FA68", Offset = "0xB5FA68", VA = "0xB5FA68")]
		public void SetFrame(Rectangle frame)
		{
		}

		// Token: 0x06006652 RID: 26194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006652")]
		[Address(RVA = "0xB5FB20", Offset = "0xB5FB20", VA = "0xB5FB20")]
		public void SetFrame(int frameCountHorizontal, int frameCountVertical, int frameX, int frameY, int sizeOffsetX, int sizeOffsetY)
		{
		}

		// Token: 0x06006653 RID: 26195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006653")]
		[Address(RVA = "0xB5FCA0", Offset = "0xB5FCA0", VA = "0xB5FCA0", Slot = "6")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x0400A394 RID: 41876
		[Token(Token = "0x400A394")]
		[FieldOffset(Offset = "0xF4")]
		private Asset<Texture2D> _texture;

		// Token: 0x0400A395 RID: 41877
		[Token(Token = "0x400A395")]
		[FieldOffset(Offset = "0xF8")]
		private Rectangle _frame;

		// Token: 0x0400A396 RID: 41878
		[Token(Token = "0x400A396")]
		[FieldOffset(Offset = "0x108")]
		private Color <Color>k__BackingField;
	}
}
