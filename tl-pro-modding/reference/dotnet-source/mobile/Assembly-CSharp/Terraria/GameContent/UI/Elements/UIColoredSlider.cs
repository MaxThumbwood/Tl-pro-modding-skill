using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Localization;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D77 RID: 3447
	[Token(Token = "0x2000D77")]
	public class UIColoredSlider : UISliderBase
	{
		// Token: 0x060065FF RID: 26111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065FF")]
		[Address(RVA = "0xB58314", Offset = "0xB58314", VA = "0xB58314")]
		public UIColoredSlider(LocalizedText textKey, Func<float> getStatus, Action<float> setStatusKeyboard, Action setStatusGamepad, Func<float, Color> blipColorFunction, Color color)
		{
		}

		// Token: 0x06006600 RID: 26112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006600")]
		[Address(RVA = "0xB5863C", Offset = "0xB5863C", VA = "0xB5863C", Slot = "6")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x06006601 RID: 26113 RVA: 0x0002E3E0 File Offset: 0x0002C5E0
		[Token(Token = "0x6006601")]
		[Address(RVA = "0xB58C20", Offset = "0xB58C20", VA = "0xB58C20")]
		private float DrawValueBar(SpriteBatch sb, Vector2 drawPosition, float drawScale, float sliderPosition, int lockMode, out bool wasInBar, Func<float, Color> blipColorFunc)
		{
			return 0f;
		}

		// Token: 0x0400A342 RID: 41794
		[Token(Token = "0x400A342")]
		[FieldOffset(Offset = "0xF1")]
		private Color _color;

		// Token: 0x0400A343 RID: 41795
		[Token(Token = "0x400A343")]
		[FieldOffset(Offset = "0xF8")]
		private LocalizedText _textKey;

		// Token: 0x0400A344 RID: 41796
		[Token(Token = "0x400A344")]
		[FieldOffset(Offset = "0xFC")]
		private Func<float> _getStatusTextAct;

		// Token: 0x0400A345 RID: 41797
		[Token(Token = "0x400A345")]
		[FieldOffset(Offset = "0x100")]
		private Action<float> _slideKeyboardAction;

		// Token: 0x0400A346 RID: 41798
		[Token(Token = "0x400A346")]
		[FieldOffset(Offset = "0x104")]
		private Func<float, Color> _blipFunc;

		// Token: 0x0400A347 RID: 41799
		[Token(Token = "0x400A347")]
		[FieldOffset(Offset = "0x108")]
		private Action _slideGamepadAction;

		// Token: 0x0400A348 RID: 41800
		[Token(Token = "0x400A348")]
		private const bool BOTHER_WITH_TEXT = false;

		// Token: 0x0400A349 RID: 41801
		[Token(Token = "0x400A349")]
		[FieldOffset(Offset = "0x10C")]
		private bool _isReallyMouseOvered;

		// Token: 0x0400A34A RID: 41802
		[Token(Token = "0x400A34A")]
		[FieldOffset(Offset = "0x10D")]
		private bool _alreadyHovered;

		// Token: 0x0400A34B RID: 41803
		[Token(Token = "0x400A34B")]
		[FieldOffset(Offset = "0x10E")]
		private bool _soundedUsage;

		// Token: 0x02000D78 RID: 3448
		[Token(Token = "0x2000D78")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006603 RID: 26115 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006603")]
			[Address(RVA = "0xB59528", Offset = "0xB59528", VA = "0xB59528")]
			public <>c()
			{
			}

			// Token: 0x06006604 RID: 26116 RVA: 0x0002E3F8 File Offset: 0x0002C5F8
			[Token(Token = "0x6006604")]
			[Address(RVA = "0xB59530", Offset = "0xB59530", VA = "0xB59530")]
			internal float <.ctor>b__10_0()
			{
				return 0f;
			}

			// Token: 0x06006605 RID: 26117 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006605")]
			[Address(RVA = "0xB59538", Offset = "0xB59538", VA = "0xB59538")]
			internal void <.ctor>b__10_1(float s)
			{
			}

			// Token: 0x06006606 RID: 26118 RVA: 0x0002E410 File Offset: 0x0002C610
			[Token(Token = "0x6006606")]
			[Address(RVA = "0xB5953C", Offset = "0xB5953C", VA = "0xB5953C")]
			internal Color <.ctor>b__10_2(float s)
			{
				return default(Color);
			}

			// Token: 0x0400A34C RID: 41804
			[Token(Token = "0x400A34C")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIColoredSlider.<>c <>9;

			// Token: 0x0400A34D RID: 41805
			[Token(Token = "0x400A34D")]
			[FieldOffset(Offset = "0x4")]
			public static Func<float> <>9__10_0;

			// Token: 0x0400A34E RID: 41806
			[Token(Token = "0x400A34E")]
			[FieldOffset(Offset = "0x8")]
			public static Action<float> <>9__10_1;

			// Token: 0x0400A34F RID: 41807
			[Token(Token = "0x400A34F")]
			[FieldOffset(Offset = "0xC")]
			public static Func<float, Color> <>9__10_2;
		}
	}
}
