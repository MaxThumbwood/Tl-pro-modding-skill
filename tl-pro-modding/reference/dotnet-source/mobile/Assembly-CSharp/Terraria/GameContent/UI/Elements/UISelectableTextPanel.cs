using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D99 RID: 3481
	[Token(Token = "0x2000D99")]
	public class UISelectableTextPanel<T> : UITextPanel<T>
	{
		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x060066B5 RID: 26293 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060066B6 RID: 26294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AFB")]
		public Func<UISelectableTextPanel<T>, bool> IsSelected
		{
			[Token(Token = "0x60066B5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60066B6")]
			set
			{
			}
		}

		// Token: 0x060066B7 RID: 26295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066B7")]
		public UISelectableTextPanel(T text, float textScale = 1f, bool large = false)
		{
		}

		// Token: 0x060066B8 RID: 26296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066B8")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x0400A3D3 RID: 41939
		[Token(Token = "0x400A3D3")]
		[FieldOffset(Offset = "0x0")]
		private readonly Asset<Texture2D> _BasePanelTexture;

		// Token: 0x0400A3D4 RID: 41940
		[Token(Token = "0x400A3D4")]
		[FieldOffset(Offset = "0x0")]
		private readonly Asset<Texture2D> _hoveredBorderTexture;

		// Token: 0x0400A3D5 RID: 41941
		[Token(Token = "0x400A3D5")]
		[FieldOffset(Offset = "0x0")]
		private Func<UISelectableTextPanel<T>, bool> _isSelected;
	}
}
