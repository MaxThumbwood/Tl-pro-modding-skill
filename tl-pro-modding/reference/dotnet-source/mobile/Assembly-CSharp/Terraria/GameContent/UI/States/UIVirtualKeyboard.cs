using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.GameContent.UI.Elements;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.States
{
	// Token: 0x02000D42 RID: 3394
	[Token(Token = "0x2000D42")]
	public class UIVirtualKeyboard : UIState
	{
		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06006495 RID: 25749 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006496 RID: 25750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ACE")]
		public string Text
		{
			[Token(Token = "0x6006495")]
			[Address(RVA = "0xB33AA4", Offset = "0xB33AA4", VA = "0xB33AA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006496")]
			[Address(RVA = "0xB33B08", Offset = "0xB33B08", VA = "0xB33B08")]
			set
			{
			}
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06006497 RID: 25751 RVA: 0x0002E020 File Offset: 0x0002C220
		// (set) Token: 0x06006498 RID: 25752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ACF")]
		public bool HideContents
		{
			[Token(Token = "0x6006497")]
			[Address(RVA = "0xB33DB4", Offset = "0xB33DB4", VA = "0xB33DB4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006498")]
			[Address(RVA = "0xB33DD8", Offset = "0xB33DD8", VA = "0xB33DD8")]
			set
			{
			}
		}

		// Token: 0x06006499 RID: 25753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006499")]
		[Address(RVA = "0xB33E00", Offset = "0xB33E00", VA = "0xB33E00")]
		public UIVirtualKeyboard(string labelText, string startingText, UIVirtualKeyboard.KeyboardSubmitEvent submitAction, Action cancelAction, int inputMode = 0, bool allowEmpty = false, int maxLength = 20)
		{
		}

		// Token: 0x0600649A RID: 25754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600649A")]
		[Address(RVA = "0xB36B74", Offset = "0xB36B74", VA = "0xB36B74")]
		public void SetMaxInputLength(int length)
		{
		}

		// Token: 0x0600649B RID: 25755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600649B")]
		[Address(RVA = "0xB36488", Offset = "0xB36488", VA = "0xB36488")]
		private void BuildSpaceBarArea(UIPanel mainPanel)
		{
		}

		// Token: 0x0600649C RID: 25756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600649C")]
		[Address(RVA = "0xB36C88", Offset = "0xB36C88", VA = "0xB36C88")]
		private void PressSpace()
		{
		}

		// Token: 0x0600649D RID: 25757 RVA: 0x0002E038 File Offset: 0x0002C238
		[Token(Token = "0x600649D")]
		[Address(RVA = "0xB36BA4", Offset = "0xB36BA4", VA = "0xB36BA4")]
		private bool CanRestore()
		{
			return default(bool);
		}

		// Token: 0x0600649E RID: 25758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600649E")]
		[Address(RVA = "0xB36DE4", Offset = "0xB36DE4", VA = "0xB36DE4")]
		private void TypeText(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x0600649F RID: 25759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600649F")]
		[Address(RVA = "0xB36774", Offset = "0xB36774", VA = "0xB36774")]
		public void SetKeyState(UIVirtualKeyboard.KeyState keyState)
		{
		}

		// Token: 0x060064A0 RID: 25760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064A0")]
		[Address(RVA = "0xB33B7C", Offset = "0xB33B7C", VA = "0xB33B7C")]
		private void ValidateText()
		{
		}

		// Token: 0x060064A1 RID: 25761 RVA: 0x0002E050 File Offset: 0x0002C250
		[Token(Token = "0x60064A1")]
		[Address(RVA = "0xB370D0", Offset = "0xB370D0", VA = "0xB370D0")]
		private bool TextIsValidForSubmit()
		{
			return default(bool);
		}

		// Token: 0x060064A2 RID: 25762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064A2")]
		private void StyleKey<T>(UITextPanel<T> button, bool external = false)
		{
		}

		// Token: 0x060064A3 RID: 25763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064A3")]
		[Address(RVA = "0xB36214", Offset = "0xB36214", VA = "0xB36214")]
		private UITextPanel<object> CreateKeyboardButton(object text, int x, int y, int width = 1, bool style = true)
		{
			return null;
		}

		// Token: 0x060064A4 RID: 25764 RVA: 0x0002E068 File Offset: 0x0002C268
		[Token(Token = "0x60064A4")]
		[Address(RVA = "0xB37200", Offset = "0xB37200", VA = "0xB37200")]
		private bool ShouldShowKeyboard()
		{
			return default(bool);
		}

		// Token: 0x060064A5 RID: 25765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064A5")]
		[Address(RVA = "0xB37208", Offset = "0xB37208", VA = "0xB37208", Slot = "6")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x060064A6 RID: 25766 RVA: 0x0002E080 File Offset: 0x0002C280
		[Token(Token = "0x60064A6")]
		[Address(RVA = "0xB37F48", Offset = "0xB37F48", VA = "0xB37F48")]
		private bool TryEscapingMenu()
		{
			return default(bool);
		}

		// Token: 0x060064A7 RID: 25767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064A7")]
		[Address(RVA = "0xB36A74", Offset = "0xB36A74", VA = "0xB36A74")]
		private void UpdateOffsetDown()
		{
		}

		// Token: 0x060064A8 RID: 25768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064A8")]
		[Address(RVA = "0xB383AC", Offset = "0xB383AC", VA = "0xB383AC", Slot = "26")]
		public override void OnActivate()
		{
		}

		// Token: 0x060064A9 RID: 25769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064A9")]
		[Address(RVA = "0xB383B0", Offset = "0xB383B0", VA = "0xB383B0", Slot = "27")]
		public override void OnDeactivate()
		{
		}

		// Token: 0x060064AA RID: 25770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064AA")]
		[Address(RVA = "0xB38428", Offset = "0xB38428", VA = "0xB38428")]
		public static void CycleSymbols()
		{
		}

		// Token: 0x060064AB RID: 25771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064AB")]
		[Address(RVA = "0xB3858C", Offset = "0xB3858C", VA = "0xB3858C")]
		public static void BackSpace()
		{
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x060064AC RID: 25772 RVA: 0x0002E098 File Offset: 0x0002C298
		[Token(Token = "0x17000AD0")]
		public static bool CanSubmit
		{
			[Token(Token = "0x60064AC")]
			[Address(RVA = "0xB37E00", Offset = "0xB37E00", VA = "0xB37E00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060064AD RID: 25773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064AD")]
		[Address(RVA = "0xB37EA8", Offset = "0xB37EA8", VA = "0xB37EA8")]
		public static void Submit()
		{
		}

		// Token: 0x060064AE RID: 25774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064AE")]
		[Address(RVA = "0xB38698", Offset = "0xB38698", VA = "0xB38698")]
		private void InternalSubmit()
		{
		}

		// Token: 0x060064AF RID: 25775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064AF")]
		[Address(RVA = "0xB382C0", Offset = "0xB382C0", VA = "0xB382C0")]
		public static void Cancel()
		{
		}

		// Token: 0x060064B0 RID: 25776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064B0")]
		[Address(RVA = "0xB38784", Offset = "0xB38784", VA = "0xB38784")]
		public static void Write(string text)
		{
		}

		// Token: 0x060064B1 RID: 25777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064B1")]
		[Address(RVA = "0xB38A1C", Offset = "0xB38A1C", VA = "0xB38A1C")]
		public static void CursorLeft()
		{
		}

		// Token: 0x060064B2 RID: 25778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064B2")]
		[Address(RVA = "0xB38B04", Offset = "0xB38B04", VA = "0xB38B04")]
		public static void CursorRight()
		{
		}

		// Token: 0x060064B3 RID: 25779 RVA: 0x0002E0B0 File Offset: 0x0002C2B0
		[Token(Token = "0x60064B3")]
		[Address(RVA = "0xB38BEC", Offset = "0xB38BEC", VA = "0xB38BEC")]
		public static bool CanDisplay(int keyboardContext)
		{
			return default(bool);
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x060064B4 RID: 25780 RVA: 0x0002E0C8 File Offset: 0x0002C2C8
		[Token(Token = "0x17000AD1")]
		public static int KeyboardContext
		{
			[Token(Token = "0x60064B4")]
			[Address(RVA = "0xB38C6C", Offset = "0xB38C6C", VA = "0xB38C6C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060064B5 RID: 25781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064B5")]
		[Address(RVA = "0xB38D0C", Offset = "0xB38D0C", VA = "0xB38D0C")]
		public static void CacheCanceledInput(int cacheMode)
		{
		}

		// Token: 0x060064B6 RID: 25782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064B6")]
		[Address(RVA = "0xB38DB8", Offset = "0xB38DB8", VA = "0xB38DB8")]
		private void RestoreCanceledInput(int cacheMode)
		{
		}

		// Token: 0x060064B7 RID: 25783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064B7")]
		[Address(RVA = "0xB38084", Offset = "0xB38084", VA = "0xB38084")]
		private void CopyTextToSign()
		{
		}

		// Token: 0x060064B8 RID: 25784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064B8")]
		[Address(RVA = "0xB381EC", Offset = "0xB381EC", VA = "0xB381EC")]
		private void CopyTextToChest()
		{
		}

		// Token: 0x060064B9 RID: 25785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064B9")]
		[Address(RVA = "0xB38F14", Offset = "0xB38F14", VA = "0xB38F14")]
		private void FadedMouseOver(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x060064BA RID: 25786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064BA")]
		[Address(RVA = "0xB390E4", Offset = "0xB390E4", VA = "0xB390E4")]
		private void FadedMouseOut(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x060064BC RID: 25788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064BC")]
		[Address(RVA = "0xB39318", Offset = "0xB39318", VA = "0xB39318")]
		private void <.ctor>b__49_0(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x060064BD RID: 25789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064BD")]
		[Address(RVA = "0xB39388", Offset = "0xB39388", VA = "0xB39388")]
		private void <.ctor>b__49_1(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x060064BE RID: 25790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064BE")]
		[Address(RVA = "0xB39488", Offset = "0xB39488", VA = "0xB39488")]
		private void <.ctor>b__49_2(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x060064BF RID: 25791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064BF")]
		[Address(RVA = "0xB394EC", Offset = "0xB394EC", VA = "0xB394EC")]
		private void <.ctor>b__49_3(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x060064C0 RID: 25792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064C0")]
		[Address(RVA = "0xB3955C", Offset = "0xB3955C", VA = "0xB3955C")]
		private void <.ctor>b__49_4(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x060064C1 RID: 25793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064C1")]
		[Address(RVA = "0xB3965C", Offset = "0xB3965C", VA = "0xB3965C")]
		private void <.ctor>b__49_5(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x060064C2 RID: 25794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064C2")]
		[Address(RVA = "0xB396BC", Offset = "0xB396BC", VA = "0xB396BC")]
		private void <.ctor>b__49_6(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x060064C3 RID: 25795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064C3")]
		[Address(RVA = "0xB396C0", Offset = "0xB396C0", VA = "0xB396C0")]
		private void <.ctor>b__49_7(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x060064C4 RID: 25796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064C4")]
		[Address(RVA = "0xB396C4", Offset = "0xB396C4", VA = "0xB396C4")]
		private void <.ctor>b__49_9(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x060064C5 RID: 25797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064C5")]
		[Address(RVA = "0xB39720", Offset = "0xB39720", VA = "0xB39720")]
		private void <.ctor>b__49_12(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x060064C6 RID: 25798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064C6")]
		[Address(RVA = "0xB39724", Offset = "0xB39724", VA = "0xB39724")]
		private void <.ctor>b__49_13(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x060064C7 RID: 25799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064C7")]
		[Address(RVA = "0xB39728", Offset = "0xB39728", VA = "0xB39728")]
		private void <.ctor>b__49_14(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x060064C8 RID: 25800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064C8")]
		[Address(RVA = "0xB39814", Offset = "0xB39814", VA = "0xB39814")]
		private void <.ctor>b__49_17(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x060064C9 RID: 25801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064C9")]
		[Address(RVA = "0xB39870", Offset = "0xB39870", VA = "0xB39870")]
		private void <.ctor>b__49_18(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		// Token: 0x0400A20D RID: 41485
		[Token(Token = "0x400A20D")]
		[FieldOffset(Offset = "0x0")]
		private static UIVirtualKeyboard _currentInstance;

		// Token: 0x0400A20E RID: 41486
		[Token(Token = "0x400A20E")]
		[FieldOffset(Offset = "0x4")]
		private static string _cancelCacheSign;

		// Token: 0x0400A20F RID: 41487
		[Token(Token = "0x400A20F")]
		[FieldOffset(Offset = "0x8")]
		private static string _cancelCacheChest;

		// Token: 0x0400A210 RID: 41488
		[Token(Token = "0x400A210")]
		private const string DEFAULT_KEYS = "1234567890qwertyuiopasdfghjkl'zxcvbnm,.?";

		// Token: 0x0400A211 RID: 41489
		[Token(Token = "0x400A211")]
		private const string SHIFT_KEYS = "1234567890QWERTYUIOPASDFGHJKL'ZXCVBNM,.?";

		// Token: 0x0400A212 RID: 41490
		[Token(Token = "0x400A212")]
		private const string SYMBOL_KEYS = "1234567890!@#$%^&*()-_+=/\\{}[]<>;:\"`|~£¥";

		// Token: 0x0400A213 RID: 41491
		[Token(Token = "0x400A213")]
		private const float KEY_SPACING = 4f;

		// Token: 0x0400A214 RID: 41492
		[Token(Token = "0x400A214")]
		private const float KEY_WIDTH = 48f;

		// Token: 0x0400A215 RID: 41493
		[Token(Token = "0x400A215")]
		private const float KEY_HEIGHT = 37f;

		// Token: 0x0400A216 RID: 41494
		[Token(Token = "0x400A216")]
		[FieldOffset(Offset = "0xF4")]
		private UITextPanel<object>[] _keyList;

		// Token: 0x0400A217 RID: 41495
		[Token(Token = "0x400A217")]
		[FieldOffset(Offset = "0xF8")]
		private UITextPanel<object> _shiftButton;

		// Token: 0x0400A218 RID: 41496
		[Token(Token = "0x400A218")]
		[FieldOffset(Offset = "0xFC")]
		private UITextPanel<object> _symbolButton;

		// Token: 0x0400A219 RID: 41497
		[Token(Token = "0x400A219")]
		[FieldOffset(Offset = "0x100")]
		private UITextBox _textBox;

		// Token: 0x0400A21A RID: 41498
		[Token(Token = "0x400A21A")]
		[FieldOffset(Offset = "0x104")]
		private UITextPanel<LocalizedText> _submitButton;

		// Token: 0x0400A21B RID: 41499
		[Token(Token = "0x400A21B")]
		[FieldOffset(Offset = "0x108")]
		private UITextPanel<LocalizedText> _cancelButton;

		// Token: 0x0400A21C RID: 41500
		[Token(Token = "0x400A21C")]
		[FieldOffset(Offset = "0x10C")]
		private UIText _label;

		// Token: 0x0400A21D RID: 41501
		[Token(Token = "0x400A21D")]
		[FieldOffset(Offset = "0x110")]
		private UITextPanel<object> _enterButton;

		// Token: 0x0400A21E RID: 41502
		[Token(Token = "0x400A21E")]
		[FieldOffset(Offset = "0x114")]
		private UITextPanel<object> _spacebarButton;

		// Token: 0x0400A21F RID: 41503
		[Token(Token = "0x400A21F")]
		[FieldOffset(Offset = "0x118")]
		private UITextPanel<object> _restoreButton;

		// Token: 0x0400A220 RID: 41504
		[Token(Token = "0x400A220")]
		[FieldOffset(Offset = "0x11C")]
		private Asset<Texture2D> _textureShift;

		// Token: 0x0400A221 RID: 41505
		[Token(Token = "0x400A221")]
		[FieldOffset(Offset = "0x120")]
		private Asset<Texture2D> _textureBackspace;

		// Token: 0x0400A222 RID: 41506
		[Token(Token = "0x400A222")]
		[FieldOffset(Offset = "0x124")]
		private Color _internalBorderColor;

		// Token: 0x0400A223 RID: 41507
		[Token(Token = "0x400A223")]
		[FieldOffset(Offset = "0x128")]
		private Color _internalBorderColorSelected;

		// Token: 0x0400A224 RID: 41508
		[Token(Token = "0x400A224")]
		[FieldOffset(Offset = "0x12C")]
		private UITextPanel<LocalizedText> _submitButton2;

		// Token: 0x0400A225 RID: 41509
		[Token(Token = "0x400A225")]
		[FieldOffset(Offset = "0x130")]
		private UITextPanel<LocalizedText> _cancelButton2;

		// Token: 0x0400A226 RID: 41510
		[Token(Token = "0x400A226")]
		[FieldOffset(Offset = "0x134")]
		private UIElement outerLayer1;

		// Token: 0x0400A227 RID: 41511
		[Token(Token = "0x400A227")]
		[FieldOffset(Offset = "0x138")]
		private UIElement outerLayer2;

		// Token: 0x0400A228 RID: 41512
		[Token(Token = "0x400A228")]
		[FieldOffset(Offset = "0x13C")]
		private bool _allowEmpty;

		// Token: 0x0400A229 RID: 41513
		[Token(Token = "0x400A229")]
		[FieldOffset(Offset = "0x140")]
		private UIVirtualKeyboard.KeyState _keyState;

		// Token: 0x0400A22A RID: 41514
		[Token(Token = "0x400A22A")]
		[FieldOffset(Offset = "0x144")]
		private UIVirtualKeyboard.KeyboardSubmitEvent _submitAction;

		// Token: 0x0400A22B RID: 41515
		[Token(Token = "0x400A22B")]
		[FieldOffset(Offset = "0x148")]
		private Action _cancelAction;

		// Token: 0x0400A22C RID: 41516
		[Token(Token = "0x400A22C")]
		[FieldOffset(Offset = "0x14C")]
		private int _lastOffsetDown;

		// Token: 0x0400A22D RID: 41517
		[Token(Token = "0x400A22D")]
		[FieldOffset(Offset = "0xC")]
		public static int OffsetDown;

		// Token: 0x0400A22E RID: 41518
		[Token(Token = "0x400A22E")]
		[FieldOffset(Offset = "0x10")]
		public static bool ShouldHideText;

		// Token: 0x0400A22F RID: 41519
		[Token(Token = "0x400A22F")]
		[FieldOffset(Offset = "0x150")]
		private int _keyboardContext;

		// Token: 0x0400A230 RID: 41520
		[Token(Token = "0x400A230")]
		[FieldOffset(Offset = "0x154")]
		private bool _editingSign;

		// Token: 0x0400A231 RID: 41521
		[Token(Token = "0x400A231")]
		[FieldOffset(Offset = "0x155")]
		private bool _editingChest;

		// Token: 0x0400A232 RID: 41522
		[Token(Token = "0x400A232")]
		[FieldOffset(Offset = "0x158")]
		private float _textBoxHeight;

		// Token: 0x0400A233 RID: 41523
		[Token(Token = "0x400A233")]
		[FieldOffset(Offset = "0x15C")]
		private float _labelHeight;

		// Token: 0x0400A234 RID: 41524
		[Token(Token = "0x400A234")]
		[FieldOffset(Offset = "0x160")]
		public Func<string, bool> CustomTextValidationForUpdate;

		// Token: 0x0400A235 RID: 41525
		[Token(Token = "0x400A235")]
		[FieldOffset(Offset = "0x164")]
		public Func<string, bool> CustomTextValidationForSubmit;

		// Token: 0x0400A236 RID: 41526
		[Token(Token = "0x400A236")]
		[FieldOffset(Offset = "0x168")]
		private bool _canSubmit;

		// Token: 0x02000D43 RID: 3395
		// (Invoke) Token: 0x060064CB RID: 25803
		[Token(Token = "0x2000D43")]
		public delegate void KeyboardSubmitEvent(string text);

		// Token: 0x02000D44 RID: 3396
		[Token(Token = "0x2000D44")]
		public enum KeyState
		{
			// Token: 0x0400A238 RID: 41528
			[Token(Token = "0x400A238")]
			Default,
			// Token: 0x0400A239 RID: 41529
			[Token(Token = "0x400A239")]
			Symbol,
			// Token: 0x0400A23A RID: 41530
			[Token(Token = "0x400A23A")]
			Shift
		}

		// Token: 0x02000D45 RID: 3397
		[Token(Token = "0x2000D45")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060064CF RID: 25807 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60064CF")]
			[Address(RVA = "0xB39A6C", Offset = "0xB39A6C", VA = "0xB39A6C")]
			public <>c()
			{
			}

			// Token: 0x060064D0 RID: 25808 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60064D0")]
			[Address(RVA = "0xB39A74", Offset = "0xB39A74", VA = "0xB39A74")]
			internal void <.ctor>b__49_8(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x060064D1 RID: 25809 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60064D1")]
			[Address(RVA = "0xB39AD8", Offset = "0xB39AD8", VA = "0xB39AD8")]
			internal void <.ctor>b__49_10(UIMouseEvent a, UIElement b)
			{
			}

			// Token: 0x060064D2 RID: 25810 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60064D2")]
			[Address(RVA = "0xB39C60", Offset = "0xB39C60", VA = "0xB39C60")]
			internal void <.ctor>b__49_11(UIMouseEvent a, UIElement b)
			{
			}

			// Token: 0x060064D3 RID: 25811 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60064D3")]
			[Address(RVA = "0xB39DE8", Offset = "0xB39DE8", VA = "0xB39DE8")]
			internal void <.ctor>b__49_15(UIMouseEvent a, UIElement b)
			{
			}

			// Token: 0x060064D4 RID: 25812 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60064D4")]
			[Address(RVA = "0xB39F70", Offset = "0xB39F70", VA = "0xB39F70")]
			internal void <.ctor>b__49_16(UIMouseEvent a, UIElement b)
			{
			}

			// Token: 0x0400A23B RID: 41531
			[Token(Token = "0x400A23B")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIVirtualKeyboard.<>c <>9;

			// Token: 0x0400A23C RID: 41532
			[Token(Token = "0x400A23C")]
			[FieldOffset(Offset = "0x4")]
			public static UIElement.MouseEvent <>9__49_8;

			// Token: 0x0400A23D RID: 41533
			[Token(Token = "0x400A23D")]
			[FieldOffset(Offset = "0x8")]
			public static UIElement.MouseEvent <>9__49_10;

			// Token: 0x0400A23E RID: 41534
			[Token(Token = "0x400A23E")]
			[FieldOffset(Offset = "0xC")]
			public static UIElement.MouseEvent <>9__49_11;

			// Token: 0x0400A23F RID: 41535
			[Token(Token = "0x400A23F")]
			[FieldOffset(Offset = "0x10")]
			public static UIElement.MouseEvent <>9__49_15;

			// Token: 0x0400A240 RID: 41536
			[Token(Token = "0x400A240")]
			[FieldOffset(Offset = "0x14")]
			public static UIElement.MouseEvent <>9__49_16;
		}

		// Token: 0x02000D46 RID: 3398
		[Token(Token = "0x2000D46")]
		private sealed class <>c__DisplayClass51_0
		{
			// Token: 0x060064D5 RID: 25813 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60064D5")]
			[Address(RVA = "0xB36B9C", Offset = "0xB36B9C", VA = "0xB36B9C")]
			public <>c__DisplayClass51_0()
			{
			}

			// Token: 0x060064D6 RID: 25814 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60064D6")]
			[Address(RVA = "0xB3A0F8", Offset = "0xB3A0F8", VA = "0xB3A0F8")]
			internal void <BuildSpaceBarArea>b__0()
			{
			}

			// Token: 0x060064D7 RID: 25815 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60064D7")]
			[Address(RVA = "0xB3A470", Offset = "0xB3A470", VA = "0xB3A470")]
			internal void <BuildSpaceBarArea>b__1(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x060064D8 RID: 25816 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60064D8")]
			[Address(RVA = "0xB3A490", Offset = "0xB3A490", VA = "0xB3A490")]
			internal void <BuildSpaceBarArea>b__2(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x0400A241 RID: 41537
			[Token(Token = "0x400A241")]
			[FieldOffset(Offset = "0x8")]
			public UIVirtualKeyboard <>4__this;

			// Token: 0x0400A242 RID: 41538
			[Token(Token = "0x400A242")]
			[FieldOffset(Offset = "0xC")]
			public UIPanel mainPanel;

			// Token: 0x0400A243 RID: 41539
			[Token(Token = "0x400A243")]
			[FieldOffset(Offset = "0x10")]
			public Action createTheseTwo;

			// Token: 0x0400A244 RID: 41540
			[Token(Token = "0x400A244")]
			[FieldOffset(Offset = "0x14")]
			public UIElement.MouseEvent <>9__1;

			// Token: 0x0400A245 RID: 41541
			[Token(Token = "0x400A245")]
			[FieldOffset(Offset = "0x18")]
			public UIElement.MouseEvent <>9__2;
		}

		// Token: 0x02000D47 RID: 3399
		[Token(Token = "0x2000D47")]
		private sealed class <>c__DisplayClass51_1
		{
			// Token: 0x060064D9 RID: 25817 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60064D9")]
			[Address(RVA = "0xB36C80", Offset = "0xB36C80", VA = "0xB36C80")]
			public <>c__DisplayClass51_1()
			{
			}

			// Token: 0x060064DA RID: 25818 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60064DA")]
			[Address(RVA = "0xB3A550", Offset = "0xB3A550", VA = "0xB3A550")]
			internal void <BuildSpaceBarArea>b__3(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x0400A246 RID: 41542
			[Token(Token = "0x400A246")]
			[FieldOffset(Offset = "0x8")]
			public UITextPanel<object> restoreBar;

			// Token: 0x0400A247 RID: 41543
			[Token(Token = "0x400A247")]
			[FieldOffset(Offset = "0xC")]
			public UIVirtualKeyboard.<>c__DisplayClass51_0 CS$<>8__locals1;
		}

		// Token: 0x02000D48 RID: 3400
		[Token(Token = "0x2000D48")]
		private sealed class <>c__DisplayClass59_0<T>
		{
			// Token: 0x060064DB RID: 25819 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60064DB")]
			public <>c__DisplayClass59_0()
			{
			}

			// Token: 0x060064DC RID: 25820 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60064DC")]
			internal void <StyleKey>b__0(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x060064DD RID: 25821 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60064DD")]
			internal void <StyleKey>b__1(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x0400A248 RID: 41544
			[Token(Token = "0x400A248")]
			[FieldOffset(Offset = "0x0")]
			public bool external;

			// Token: 0x0400A249 RID: 41545
			[Token(Token = "0x400A249")]
			[FieldOffset(Offset = "0x0")]
			public UIVirtualKeyboard <>4__this;
		}
	}
}
