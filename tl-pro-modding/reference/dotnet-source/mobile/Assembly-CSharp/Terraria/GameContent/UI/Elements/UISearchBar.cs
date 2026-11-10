using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D98 RID: 3480
	[Token(Token = "0x2000D98")]
	public class UISearchBar : UIElement
	{
		// Token: 0x14000062 RID: 98
		// (add) Token: 0x0600669F RID: 26271 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060066A0 RID: 26272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000062")]
		public event Action<string> OnContentsChanged
		{
			[Token(Token = "0x600669F")]
			[Address(RVA = "0xB64EC4", Offset = "0xB64EC4", VA = "0xB64EC4")]
			add
			{
			}
			[Token(Token = "0x60066A0")]
			[Address(RVA = "0xB64F8C", Offset = "0xB64F8C", VA = "0xB64F8C")]
			remove
			{
			}
		}

		// Token: 0x14000063 RID: 99
		// (add) Token: 0x060066A1 RID: 26273 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060066A2 RID: 26274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000063")]
		public event Action OnStartTakingInput
		{
			[Token(Token = "0x60066A1")]
			[Address(RVA = "0xB65054", Offset = "0xB65054", VA = "0xB65054")]
			add
			{
			}
			[Token(Token = "0x60066A2")]
			[Address(RVA = "0xB65104", Offset = "0xB65104", VA = "0xB65104")]
			remove
			{
			}
		}

		// Token: 0x14000064 RID: 100
		// (add) Token: 0x060066A3 RID: 26275 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060066A4 RID: 26276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000064")]
		public event Action OnEndTakingInput
		{
			[Token(Token = "0x60066A3")]
			[Address(RVA = "0xB651B4", Offset = "0xB651B4", VA = "0xB651B4")]
			add
			{
			}
			[Token(Token = "0x60066A4")]
			[Address(RVA = "0xB65264", Offset = "0xB65264", VA = "0xB65264")]
			remove
			{
			}
		}

		// Token: 0x14000065 RID: 101
		// (add) Token: 0x060066A5 RID: 26277 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060066A6 RID: 26278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000065")]
		public event Action OnNeedingVirtualKeyboard
		{
			[Token(Token = "0x60066A5")]
			[Address(RVA = "0xB65314", Offset = "0xB65314", VA = "0xB65314")]
			add
			{
			}
			[Token(Token = "0x60066A6")]
			[Address(RVA = "0xB653C4", Offset = "0xB653C4", VA = "0xB653C4")]
			remove
			{
			}
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x060066A7 RID: 26279 RVA: 0x0002E5C0 File Offset: 0x0002C7C0
		[Token(Token = "0x17000AF8")]
		public bool HasContents
		{
			[Token(Token = "0x60066A7")]
			[Address(RVA = "0xB65474", Offset = "0xB65474", VA = "0xB65474")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x060066A8 RID: 26280 RVA: 0x0002E5D8 File Offset: 0x0002C7D8
		// (set) Token: 0x060066A9 RID: 26281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AF9")]
		public bool IsWritingText
		{
			[Token(Token = "0x60066A8")]
			[Address(RVA = "0xB6548C", Offset = "0xB6548C", VA = "0xB6548C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60066A9")]
			[Address(RVA = "0xB65494", Offset = "0xB65494", VA = "0xB65494")]
			private set
			{
			}
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x060066AA RID: 26282 RVA: 0x0002E5F0 File Offset: 0x0002C7F0
		// (set) Token: 0x060066AB RID: 26283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AFA")]
		public int MaxInputLength
		{
			[Token(Token = "0x60066AA")]
			[Address(RVA = "0xB6549C", Offset = "0xB6549C", VA = "0xB6549C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60066AB")]
			[Address(RVA = "0xB654A4", Offset = "0xB654A4", VA = "0xB654A4")]
			set
			{
			}
		}

		// Token: 0x060066AC RID: 26284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066AC")]
		[Address(RVA = "0xB654D0", Offset = "0xB654D0", VA = "0xB654D0")]
		public UISearchBar(LocalizedText emptyContentText, float scale)
		{
		}

		// Token: 0x060066AD RID: 26285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066AD")]
		[Address(RVA = "0xB6579C", Offset = "0xB6579C", VA = "0xB6579C")]
		public void SetContents(string contents, bool forced = false)
		{
		}

		// Token: 0x060066AE RID: 26286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066AE")]
		[Address(RVA = "0xB65994", Offset = "0xB65994", VA = "0xB65994")]
		public void TrimDisplayIfOverElementDimensions(int padding)
		{
		}

		// Token: 0x060066AF RID: 26287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066AF")]
		[Address(RVA = "0xB65EB4", Offset = "0xB65EB4", VA = "0xB65EB4", Slot = "23")]
		public override void MouseOver(UIMouseEvent evt)
		{
		}

		// Token: 0x060066B0 RID: 26288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066B0")]
		[Address(RVA = "0xB65EF0", Offset = "0xB65EF0", VA = "0xB65EF0", Slot = "9")]
		public override void Update(GameTime gameTime)
		{
		}

		// Token: 0x060066B1 RID: 26289 RVA: 0x0002E608 File Offset: 0x0002C808
		[Token(Token = "0x60066B1")]
		[Address(RVA = "0xB65FEC", Offset = "0xB65FEC", VA = "0xB65FEC")]
		private bool NeedsVirtualkeyboard()
		{
			return default(bool);
		}

		// Token: 0x060066B2 RID: 26290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066B2")]
		[Address(RVA = "0xB65FF4", Offset = "0xB65FF4", VA = "0xB65FF4", Slot = "6")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x060066B3 RID: 26291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066B3")]
		[Address(RVA = "0xB66308", Offset = "0xB66308", VA = "0xB66308")]
		public void ToggleTakingText()
		{
		}

		// Token: 0x060066B4 RID: 26292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066B4")]
		[Address(RVA = "0xB663B8", Offset = "0xB663B8", VA = "0xB663B8", Slot = "27")]
		public override void OnDeactivate()
		{
		}

		// Token: 0x0400A3C9 RID: 41929
		[Token(Token = "0x400A3C9")]
		[FieldOffset(Offset = "0xF4")]
		private readonly LocalizedText _textToShowWhenEmpty;

		// Token: 0x0400A3CA RID: 41930
		[Token(Token = "0x400A3CA")]
		[FieldOffset(Offset = "0xF8")]
		private UITextBox _text;

		// Token: 0x0400A3CB RID: 41931
		[Token(Token = "0x400A3CB")]
		[FieldOffset(Offset = "0xFC")]
		private string actualContents;

		// Token: 0x0400A3CC RID: 41932
		[Token(Token = "0x400A3CC")]
		[FieldOffset(Offset = "0x100")]
		private float _textScale;

		// Token: 0x0400A3D1 RID: 41937
		[Token(Token = "0x400A3D1")]
		[FieldOffset(Offset = "0x114")]
		private bool <IsWritingText>k__BackingField;

		// Token: 0x0400A3D2 RID: 41938
		[Token(Token = "0x400A3D2")]
		[FieldOffset(Offset = "0x118")]
		private int _maxInputLength;
	}
}
