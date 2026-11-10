using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D9D RID: 3485
	[Token(Token = "0x2000D9D")]
	public class UITextPanel<T> : UIPanel
	{
		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x060066E1 RID: 26337 RVA: 0x0002E6C8 File Offset: 0x0002C8C8
		[Token(Token = "0x17000B04")]
		public bool IsLarge
		{
			[Token(Token = "0x60066E1")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x060066E2 RID: 26338 RVA: 0x0002E6E0 File Offset: 0x0002C8E0
		// (set) Token: 0x060066E3 RID: 26339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B05")]
		public bool DrawPanel
		{
			[Token(Token = "0x60066E2")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60066E3")]
			set
			{
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x060066E4 RID: 26340 RVA: 0x0002E6F8 File Offset: 0x0002C8F8
		// (set) Token: 0x060066E5 RID: 26341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B06")]
		public float TextScale
		{
			[Token(Token = "0x60066E4")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60066E5")]
			set
			{
			}
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x060066E6 RID: 26342 RVA: 0x0002E710 File Offset: 0x0002C910
		[Token(Token = "0x17000B07")]
		public Vector2 TextSize
		{
			[Token(Token = "0x60066E6")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x060066E7 RID: 26343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B08")]
		public string Text
		{
			[Token(Token = "0x60066E7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x060066E8 RID: 26344 RVA: 0x0002E728 File Offset: 0x0002C928
		// (set) Token: 0x060066E9 RID: 26345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B09")]
		public Color TextColor
		{
			[Token(Token = "0x60066E8")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60066E9")]
			set
			{
			}
		}

		// Token: 0x060066EA RID: 26346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066EA")]
		public UITextPanel(T text, float textScale = 1f, bool large = false)
		{
		}

		// Token: 0x060066EB RID: 26347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066EB")]
		public override void Recalculate()
		{
		}

		// Token: 0x060066EC RID: 26348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066EC")]
		public void SetText(T text)
		{
		}

		// Token: 0x060066ED RID: 26349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066ED")]
		public virtual void SetText(T text, float textScale, bool large)
		{
		}

		// Token: 0x060066EE RID: 26350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066EE")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x060066EF RID: 26351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066EF")]
		protected void DrawText(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x0400A3EF RID: 41967
		[Token(Token = "0x400A3EF")]
		[FieldOffset(Offset = "0x0")]
		protected T _text;

		// Token: 0x0400A3F0 RID: 41968
		[Token(Token = "0x400A3F0")]
		[FieldOffset(Offset = "0x0")]
		protected float _textScale;

		// Token: 0x0400A3F1 RID: 41969
		[Token(Token = "0x400A3F1")]
		[FieldOffset(Offset = "0x0")]
		protected Vector2 _textSize;

		// Token: 0x0400A3F2 RID: 41970
		[Token(Token = "0x400A3F2")]
		[FieldOffset(Offset = "0x0")]
		protected bool _isLarge;

		// Token: 0x0400A3F3 RID: 41971
		[Token(Token = "0x400A3F3")]
		[FieldOffset(Offset = "0x0")]
		protected Color _color;

		// Token: 0x0400A3F4 RID: 41972
		[Token(Token = "0x400A3F4")]
		[FieldOffset(Offset = "0x0")]
		protected bool _drawPanel;

		// Token: 0x0400A3F5 RID: 41973
		[Token(Token = "0x400A3F5")]
		[FieldOffset(Offset = "0x0")]
		public float TextHAlign;

		// Token: 0x0400A3F6 RID: 41974
		[Token(Token = "0x400A3F6")]
		[FieldOffset(Offset = "0x0")]
		public bool HideContents;

		// Token: 0x0400A3F7 RID: 41975
		[Token(Token = "0x400A3F7")]
		[FieldOffset(Offset = "0x0")]
		private string _asterisks;
	}
}
