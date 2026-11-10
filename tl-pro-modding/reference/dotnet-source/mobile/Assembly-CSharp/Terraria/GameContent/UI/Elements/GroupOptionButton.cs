using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D5C RID: 3420
	[Token(Token = "0x2000D5C")]
	public class GroupOptionButton<T> : UIElement, FileAPI
	{
		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x0600655A RID: 25946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ADE")]
		public T OptionValue
		{
			[Token(Token = "0x600655A")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x0600655B RID: 25947 RVA: 0x0002E1A0 File Offset: 0x0002C3A0
		[Token(Token = "0x17000ADF")]
		public bool IsSelected
		{
			[Token(Token = "0x600655B")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600655C RID: 25948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600655C")]
		public GroupOptionButton(T option, LocalizedText title, LocalizedText description, Color textColor, string iconTexturePath, float textSize = 1f, float titleAlignmentX = 0.5f, float titleWidthReduction = 10f)
		{
		}

		// Token: 0x0600655D RID: 25949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600655D")]
		public void SetText(LocalizedText text, float textSize, Color color)
		{
		}

		// Token: 0x0600655E RID: 25950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600655E")]
		public void SetTextWithoutLocalization(string text, float textSize, Color color, float hAlign, float left)
		{
		}

		// Token: 0x0600655F RID: 25951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600655F")]
		public void SetCurrentOption(T option)
		{
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x06006560 RID: 25952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AE0")]
		public Texture2D Icon
		{
			[Token(Token = "0x6006560")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006561 RID: 25953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006561")]
		public void SetIcon(string iconTexturePath)
		{
		}

		// Token: 0x06006562 RID: 25954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006562")]
		public void SetIconFrame(Rectangle region)
		{
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x06006563 RID: 25955 RVA: 0x0002E1B8 File Offset: 0x0002C3B8
		// (set) Token: 0x06006564 RID: 25956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AE1")]
		public float IconScale
		{
			[Token(Token = "0x6006563")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6006564")]
			set
			{
			}
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x06006565 RID: 25957 RVA: 0x0002E1D0 File Offset: 0x0002C3D0
		// (set) Token: 0x06006566 RID: 25958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AE2")]
		public Vector2 IconOffset
		{
			[Token(Token = "0x6006565")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6006566")]
			set
			{
			}
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x06006567 RID: 25959 RVA: 0x0002E1E8 File Offset: 0x0002C3E8
		// (set) Token: 0x06006568 RID: 25960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AE3")]
		public Color IconColor
		{
			[Token(Token = "0x6006567")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6006568")]
			set
			{
			}
		}

		// Token: 0x06006569 RID: 25961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006569")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x0600656A RID: 25962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600656A")]
		public override void LeftMouseDown(UIMouseEvent evt)
		{
		}

		// Token: 0x0600656B RID: 25963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600656B")]
		public override void MouseOver(UIMouseEvent evt)
		{
		}

		// Token: 0x0600656C RID: 25964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600656C")]
		public override void MouseOut(UIMouseEvent evt)
		{
		}

		// Token: 0x0600656D RID: 25965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600656D")]
		public void SetColor(Color color, float opacity)
		{
		}

		// Token: 0x0600656E RID: 25966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600656E")]
		public void SetColorsBasedOnSelectionState(Color pickedColor, Color unpickedColor, float opacityPicked, float opacityNotPicked)
		{
		}

		// Token: 0x0600656F RID: 25967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600656F")]
		public void SetBorderColor(Color color)
		{
		}

		// Token: 0x0400A2B4 RID: 41652
		[Token(Token = "0x400A2B4")]
		[FieldOffset(Offset = "0x0")]
		private T _currentOption;

		// Token: 0x0400A2B5 RID: 41653
		[Token(Token = "0x400A2B5")]
		[FieldOffset(Offset = "0x0")]
		private readonly Asset<Texture2D> _BasePanelTexture;

		// Token: 0x0400A2B6 RID: 41654
		[Token(Token = "0x400A2B6")]
		[FieldOffset(Offset = "0x0")]
		private readonly Asset<Texture2D> _selectedBorderTexture;

		// Token: 0x0400A2B7 RID: 41655
		[Token(Token = "0x400A2B7")]
		[FieldOffset(Offset = "0x0")]
		private readonly Asset<Texture2D> _hoveredBorderTexture;

		// Token: 0x0400A2B8 RID: 41656
		[Token(Token = "0x400A2B8")]
		[FieldOffset(Offset = "0x0")]
		private Asset<Texture2D> _iconTexture;

		// Token: 0x0400A2B9 RID: 41657
		[Token(Token = "0x400A2B9")]
		[FieldOffset(Offset = "0x0")]
		private readonly T _myOption;

		// Token: 0x0400A2BA RID: 41658
		[Token(Token = "0x400A2BA")]
		[FieldOffset(Offset = "0x0")]
		private Color _color;

		// Token: 0x0400A2BB RID: 41659
		[Token(Token = "0x400A2BB")]
		[FieldOffset(Offset = "0x0")]
		private Color _borderColor;

		// Token: 0x0400A2BC RID: 41660
		[Token(Token = "0x400A2BC")]
		[FieldOffset(Offset = "0x0")]
		public float FadeFromBlack;

		// Token: 0x0400A2BD RID: 41661
		[Token(Token = "0x400A2BD")]
		[FieldOffset(Offset = "0x0")]
		public int InnerHighlightRim;

		// Token: 0x0400A2BE RID: 41662
		[Token(Token = "0x400A2BE")]
		[FieldOffset(Offset = "0x0")]
		private float _whiteLerp;

		// Token: 0x0400A2BF RID: 41663
		[Token(Token = "0x400A2BF")]
		[FieldOffset(Offset = "0x0")]
		private float _opacity;

		// Token: 0x0400A2C0 RID: 41664
		[Token(Token = "0x400A2C0")]
		[FieldOffset(Offset = "0x0")]
		private bool _hovered;

		// Token: 0x0400A2C1 RID: 41665
		[Token(Token = "0x400A2C1")]
		[FieldOffset(Offset = "0x0")]
		private bool _soundedHover;

		// Token: 0x0400A2C2 RID: 41666
		[Token(Token = "0x400A2C2")]
		[FieldOffset(Offset = "0x0")]
		public bool ShowHighlightWhenSelected;

		// Token: 0x0400A2C3 RID: 41667
		[Token(Token = "0x400A2C3")]
		[FieldOffset(Offset = "0x0")]
		private bool _UseOverrideColors;

		// Token: 0x0400A2C4 RID: 41668
		[Token(Token = "0x400A2C4")]
		[FieldOffset(Offset = "0x0")]
		private Color _overrideUnpickedColor;

		// Token: 0x0400A2C5 RID: 41669
		[Token(Token = "0x400A2C5")]
		[FieldOffset(Offset = "0x0")]
		private Color _overridePickedColor;

		// Token: 0x0400A2C6 RID: 41670
		[Token(Token = "0x400A2C6")]
		[FieldOffset(Offset = "0x0")]
		private float _overrideOpacityPicked;

		// Token: 0x0400A2C7 RID: 41671
		[Token(Token = "0x400A2C7")]
		[FieldOffset(Offset = "0x0")]
		private float _overrideOpacityUnpicked;

		// Token: 0x0400A2C8 RID: 41672
		[Token(Token = "0x400A2C8")]
		[FieldOffset(Offset = "0x0")]
		public readonly LocalizedText Description;

		// Token: 0x0400A2C9 RID: 41673
		[Token(Token = "0x400A2C9")]
		[FieldOffset(Offset = "0x0")]
		private UIText _title;

		// Token: 0x0400A2CA RID: 41674
		[Token(Token = "0x400A2CA")]
		[FieldOffset(Offset = "0x0")]
		private float _iconScale;

		// Token: 0x0400A2CB RID: 41675
		[Token(Token = "0x400A2CB")]
		[FieldOffset(Offset = "0x0")]
		private Vector2 _iconOffset;

		// Token: 0x0400A2CC RID: 41676
		[Token(Token = "0x400A2CC")]
		[FieldOffset(Offset = "0x0")]
		private Rectangle? _iconFrame;

		// Token: 0x0400A2CD RID: 41677
		[Token(Token = "0x400A2CD")]
		[FieldOffset(Offset = "0x0")]
		private Color _iconColor;
	}
}
