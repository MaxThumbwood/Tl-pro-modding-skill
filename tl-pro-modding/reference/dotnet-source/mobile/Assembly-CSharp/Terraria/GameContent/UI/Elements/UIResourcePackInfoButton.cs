using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.IO;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D95 RID: 3477
	[Token(Token = "0x2000D95")]
	public class UIResourcePackInfoButton<T> : UITextPanel<T>
	{
		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x0600668F RID: 26255 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006690 RID: 26256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AF5")]
		public ResourcePack ResourcePack
		{
			[Token(Token = "0x600668F")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006690")]
			set
			{
			}
		}

		// Token: 0x06006691 RID: 26257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006691")]
		public UIResourcePackInfoButton(T text, float textScale = 1f, bool large = false)
		{
		}

		// Token: 0x06006692 RID: 26258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006692")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x0400A3B9 RID: 41913
		[Token(Token = "0x400A3B9")]
		[FieldOffset(Offset = "0x0")]
		private readonly Asset<Texture2D> _BasePanelTexture;

		// Token: 0x0400A3BA RID: 41914
		[Token(Token = "0x400A3BA")]
		[FieldOffset(Offset = "0x0")]
		private readonly Asset<Texture2D> _hoveredBorderTexture;

		// Token: 0x0400A3BB RID: 41915
		[Token(Token = "0x400A3BB")]
		[FieldOffset(Offset = "0x0")]
		private ResourcePack _resourcePack;
	}
}
