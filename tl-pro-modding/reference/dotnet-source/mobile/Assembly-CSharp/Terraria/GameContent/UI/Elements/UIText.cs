using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D9B RID: 3483
	[Token(Token = "0x2000D9B")]
	public class UIText : UIElement
	{
		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x060066C0 RID: 26304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AFD")]
		public string Text
		{
			[Token(Token = "0x60066C0")]
			[Address(RVA = "0xB66660", Offset = "0xB66660", VA = "0xB66660")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x060066C1 RID: 26305 RVA: 0x0002E638 File Offset: 0x0002C838
		// (set) Token: 0x060066C2 RID: 26306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AFE")]
		public float TextOriginX
		{
			[Token(Token = "0x60066C1")]
			[Address(RVA = "0xB6668C", Offset = "0xB6668C", VA = "0xB6668C")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60066C2")]
			[Address(RVA = "0xB66694", Offset = "0xB66694", VA = "0xB66694")]
			set
			{
			}
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x060066C3 RID: 26307 RVA: 0x0002E650 File Offset: 0x0002C850
		// (set) Token: 0x060066C4 RID: 26308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AFF")]
		public float TextOriginY
		{
			[Token(Token = "0x60066C3")]
			[Address(RVA = "0xB6669C", Offset = "0xB6669C", VA = "0xB6669C")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60066C4")]
			[Address(RVA = "0xB666A4", Offset = "0xB666A4", VA = "0xB666A4")]
			set
			{
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x060066C5 RID: 26309 RVA: 0x0002E668 File Offset: 0x0002C868
		// (set) Token: 0x060066C6 RID: 26310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B00")]
		public float WrappedTextBottomPadding
		{
			[Token(Token = "0x60066C5")]
			[Address(RVA = "0xB666AC", Offset = "0xB666AC", VA = "0xB666AC")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60066C6")]
			[Address(RVA = "0xB666B4", Offset = "0xB666B4", VA = "0xB666B4")]
			set
			{
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x060066C7 RID: 26311 RVA: 0x0002E680 File Offset: 0x0002C880
		// (set) Token: 0x060066C8 RID: 26312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B01")]
		public bool IsWrapped
		{
			[Token(Token = "0x60066C7")]
			[Address(RVA = "0xB666BC", Offset = "0xB666BC", VA = "0xB666BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60066C8")]
			[Address(RVA = "0xB666C4", Offset = "0xB666C4", VA = "0xB666C4")]
			set
			{
			}
		}

		// Token: 0x14000066 RID: 102
		// (add) Token: 0x060066C9 RID: 26313 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060066CA RID: 26314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000066")]
		public event Action OnInternalTextChange
		{
			[Token(Token = "0x60066C9")]
			[Address(RVA = "0xB66A0C", Offset = "0xB66A0C", VA = "0xB66A0C")]
			add
			{
			}
			[Token(Token = "0x60066CA")]
			[Address(RVA = "0xB66ABC", Offset = "0xB66ABC", VA = "0xB66ABC")]
			remove
			{
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x060066CB RID: 26315 RVA: 0x0002E698 File Offset: 0x0002C898
		// (set) Token: 0x060066CC RID: 26316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B02")]
		public Color TextColor
		{
			[Token(Token = "0x60066CB")]
			[Address(RVA = "0xB66B6C", Offset = "0xB66B6C", VA = "0xB66B6C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60066CC")]
			[Address(RVA = "0xB66B74", Offset = "0xB66B74", VA = "0xB66B74")]
			set
			{
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x060066CD RID: 26317 RVA: 0x0002E6B0 File Offset: 0x0002C8B0
		// (set) Token: 0x060066CE RID: 26318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B03")]
		public Color ShadowColor
		{
			[Token(Token = "0x60066CD")]
			[Address(RVA = "0xB66B7C", Offset = "0xB66B7C", VA = "0xB66B7C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60066CE")]
			[Address(RVA = "0xB66B84", Offset = "0xB66B84", VA = "0xB66B84")]
			set
			{
			}
		}

		// Token: 0x060066CF RID: 26319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066CF")]
		[Address(RVA = "0xB66B8C", Offset = "0xB66B8C", VA = "0xB66B8C")]
		public UIText(string text, float textScale = 1f, bool large = false)
		{
		}

		// Token: 0x060066D0 RID: 26320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066D0")]
		[Address(RVA = "0xB5E32C", Offset = "0xB5E32C", VA = "0xB5E32C")]
		public UIText(LocalizedText text, float textScale = 1f, bool large = false)
		{
		}

		// Token: 0x060066D1 RID: 26321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066D1")]
		[Address(RVA = "0xB66D54", Offset = "0xB66D54", VA = "0xB66D54", Slot = "11")]
		public override void Recalculate()
		{
		}

		// Token: 0x060066D2 RID: 26322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066D2")]
		[Address(RVA = "0xB66D84", Offset = "0xB66D84", VA = "0xB66D84")]
		public void SetText(string text)
		{
		}

		// Token: 0x060066D3 RID: 26323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066D3")]
		[Address(RVA = "0xB66DA0", Offset = "0xB66DA0", VA = "0xB66DA0")]
		public void SetText(LocalizedText text)
		{
		}

		// Token: 0x060066D4 RID: 26324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066D4")]
		[Address(RVA = "0xB66DBC", Offset = "0xB66DBC", VA = "0xB66DBC")]
		public void SetText(string text, float textScale, bool large)
		{
		}

		// Token: 0x060066D5 RID: 26325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066D5")]
		[Address(RVA = "0xB66DD0", Offset = "0xB66DD0", VA = "0xB66DD0")]
		public void SetText(LocalizedText text, float textScale, bool large)
		{
		}

		// Token: 0x060066D6 RID: 26326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066D6")]
		[Address(RVA = "0xB66DE4", Offset = "0xB66DE4", VA = "0xB66DE4", Slot = "6")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x060066D7 RID: 26327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066D7")]
		[Address(RVA = "0xB671EC", Offset = "0xB671EC", VA = "0xB671EC")]
		private void VerifyTextState()
		{
		}

		// Token: 0x060066D8 RID: 26328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066D8")]
		[Address(RVA = "0xB666EC", Offset = "0xB666EC", VA = "0xB666EC")]
		private void InternalSetText(object text, float textScale, bool large)
		{
		}

		// Token: 0x0400A3DC RID: 41948
		[Token(Token = "0x400A3DC")]
		[FieldOffset(Offset = "0xF4")]
		private object _text;

		// Token: 0x0400A3DD RID: 41949
		[Token(Token = "0x400A3DD")]
		[FieldOffset(Offset = "0xF8")]
		private float _textScale;

		// Token: 0x0400A3DE RID: 41950
		[Token(Token = "0x400A3DE")]
		[FieldOffset(Offset = "0xFC")]
		private Vector2 _textSize;

		// Token: 0x0400A3DF RID: 41951
		[Token(Token = "0x400A3DF")]
		[FieldOffset(Offset = "0x104")]
		private bool _isLarge;

		// Token: 0x0400A3E0 RID: 41952
		[Token(Token = "0x400A3E0")]
		[FieldOffset(Offset = "0x105")]
		private Color _color;

		// Token: 0x0400A3E1 RID: 41953
		[Token(Token = "0x400A3E1")]
		[FieldOffset(Offset = "0x109")]
		private Color _shadowColor;

		// Token: 0x0400A3E2 RID: 41954
		[Token(Token = "0x400A3E2")]
		[FieldOffset(Offset = "0x10D")]
		private bool _isWrapped;

		// Token: 0x0400A3E3 RID: 41955
		[Token(Token = "0x400A3E3")]
		[FieldOffset(Offset = "0x110")]
		private float <TextOriginX>k__BackingField;

		// Token: 0x0400A3E4 RID: 41956
		[Token(Token = "0x400A3E4")]
		[FieldOffset(Offset = "0x114")]
		private float <TextOriginY>k__BackingField;

		// Token: 0x0400A3E5 RID: 41957
		[Token(Token = "0x400A3E5")]
		[FieldOffset(Offset = "0x118")]
		private float <WrappedTextBottomPadding>k__BackingField;

		// Token: 0x0400A3E6 RID: 41958
		[Token(Token = "0x400A3E6")]
		[FieldOffset(Offset = "0x11C")]
		public bool DynamicallyScaleDownToWidth;

		// Token: 0x0400A3E7 RID: 41959
		[Token(Token = "0x400A3E7")]
		[FieldOffset(Offset = "0x120")]
		private string _visibleText;

		// Token: 0x0400A3E8 RID: 41960
		[Token(Token = "0x400A3E8")]
		[FieldOffset(Offset = "0x124")]
		private string _lastTextReference;
	}
}
