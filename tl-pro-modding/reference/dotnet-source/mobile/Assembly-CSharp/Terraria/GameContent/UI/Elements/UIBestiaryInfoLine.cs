using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D72 RID: 3442
	[Token(Token = "0x2000D72")]
	public class UIBestiaryInfoLine<T> : UIElement, FileAPI
	{
		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x060065D9 RID: 26073 RVA: 0x0002E338 File Offset: 0x0002C538
		// (set) Token: 0x060065DA RID: 26074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AE7")]
		public int OrderInUIList
		{
			[Token(Token = "0x60065D9")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60065DA")]
			set
			{
			}
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x060065DB RID: 26075 RVA: 0x0002E350 File Offset: 0x0002C550
		// (set) Token: 0x060065DC RID: 26076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AE8")]
		public float TextScale
		{
			[Token(Token = "0x60065DB")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60065DC")]
			set
			{
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x060065DD RID: 26077 RVA: 0x0002E368 File Offset: 0x0002C568
		[Token(Token = "0x17000AE9")]
		public Vector2 TextSize
		{
			[Token(Token = "0x60065DD")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x060065DE RID: 26078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AEA")]
		public string Text
		{
			[Token(Token = "0x60065DE")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x060065DF RID: 26079 RVA: 0x0002E380 File Offset: 0x0002C580
		// (set) Token: 0x060065E0 RID: 26080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AEB")]
		public Color TextColor
		{
			[Token(Token = "0x60065DF")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60065E0")]
			set
			{
			}
		}

		// Token: 0x060065E1 RID: 26081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065E1")]
		public UIBestiaryInfoLine(T text, float textScale = 1f)
		{
		}

		// Token: 0x060065E2 RID: 26082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065E2")]
		public override void Recalculate()
		{
		}

		// Token: 0x060065E3 RID: 26083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065E3")]
		public void SetText(T text)
		{
		}

		// Token: 0x060065E4 RID: 26084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065E4")]
		public virtual void SetText(T text, float textScale)
		{
		}

		// Token: 0x060065E5 RID: 26085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065E5")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x060065E6 RID: 26086 RVA: 0x0002E398 File Offset: 0x0002C598
		[Token(Token = "0x60065E6")]
		public override int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x0400A322 RID: 41762
		[Token(Token = "0x400A322")]
		[FieldOffset(Offset = "0x0")]
		private T _text;

		// Token: 0x0400A323 RID: 41763
		[Token(Token = "0x400A323")]
		[FieldOffset(Offset = "0x0")]
		private float _textScale;

		// Token: 0x0400A324 RID: 41764
		[Token(Token = "0x400A324")]
		[FieldOffset(Offset = "0x0")]
		private Vector2 _textSize;

		// Token: 0x0400A325 RID: 41765
		[Token(Token = "0x400A325")]
		[FieldOffset(Offset = "0x0")]
		private Color _color;

		// Token: 0x0400A326 RID: 41766
		[Token(Token = "0x400A326")]
		[FieldOffset(Offset = "0x0")]
		private int <OrderInUIList>k__BackingField;
	}
}
