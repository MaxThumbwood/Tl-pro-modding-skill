using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;

namespace Terraria.UI
{
	// Token: 0x02000899 RID: 2201
	[Token(Token = "0x2000899")]
	public class UserInterface
	{
		// Token: 0x06004AD2 RID: 19154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AD2")]
		[Address(RVA = "0x63F754", Offset = "0x63F754", VA = "0x63F754")]
		public void ClearPointers()
		{
		}

		// Token: 0x06004AD3 RID: 19155 RVA: 0x00023988 File Offset: 0x00021B88
		[Token(Token = "0x6004AD3")]
		[Address(RVA = "0x63F7BC", Offset = "0x63F7BC", VA = "0x63F7BC")]
		public bool MouseCaptured()
		{
			return default(bool);
		}

		// Token: 0x06004AD4 RID: 19156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AD4")]
		[Address(RVA = "0x63F844", Offset = "0x63F844", VA = "0x63F844")]
		public void ResetLasts()
		{
		}

		// Token: 0x06004AD5 RID: 19157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AD5")]
		[Address(RVA = "0x63F92C", Offset = "0x63F92C", VA = "0x63F92C")]
		public void EscapeElements()
		{
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06004AD6 RID: 19158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000915")]
		public UIState CurrentState
		{
			[Token(Token = "0x6004AD6")]
			[Address(RVA = "0x63F930", Offset = "0x63F930", VA = "0x63F930")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004AD7 RID: 19159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AD7")]
		[Address(RVA = "0x63F938", Offset = "0x63F938", VA = "0x63F938")]
		public UserInterface()
		{
		}

		// Token: 0x06004AD8 RID: 19160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AD8")]
		[Address(RVA = "0x640150", Offset = "0x640150", VA = "0x640150")]
		public void Use()
		{
		}

		// Token: 0x06004AD9 RID: 19161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AD9")]
		[Address(RVA = "0x640230", Offset = "0x640230", VA = "0x640230")]
		private void ImmediatelyUpdateInputPointers()
		{
		}

		// Token: 0x06004ADA RID: 19162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ADA")]
		[Address(RVA = "0x6402D8", Offset = "0x6402D8", VA = "0x6402D8")]
		private void ResetState()
		{
		}

		// Token: 0x06004ADB RID: 19163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ADB")]
		[Address(RVA = "0x6404D0", Offset = "0x6404D0", VA = "0x6404D0")]
		private void GetMousePosition()
		{
		}

		// Token: 0x06004ADC RID: 19164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ADC")]
		[Address(RVA = "0x64054C", Offset = "0x64054C", VA = "0x64054C")]
		public void Update(GameTime time)
		{
		}

		// Token: 0x06004ADD RID: 19165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ADD")]
		[Address(RVA = "0x6409D8", Offset = "0x6409D8", VA = "0x6409D8")]
		private void HandleClick(UserInterface.InputPointerCache cache, GameTime time, bool isDown, UIElement mouseElement)
		{
		}

		// Token: 0x06004ADE RID: 19166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ADE")]
		[Address(RVA = "0x640D64", Offset = "0x640D64", VA = "0x640D64")]
		public void Draw(SpriteBatch spriteBatch, GameTime time)
		{
		}

		// Token: 0x06004ADF RID: 19167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ADF")]
		[Address(RVA = "0x640DD0", Offset = "0x640DD0", VA = "0x640DD0")]
		public void DrawDebugHitbox(BasicDebugDrawer drawer)
		{
		}

		// Token: 0x06004AE0 RID: 19168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AE0")]
		[Address(RVA = "0x640DD4", Offset = "0x640DD4", VA = "0x640DD4")]
		public void SetState(UIState state)
		{
		}

		// Token: 0x06004AE1 RID: 19169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AE1")]
		[Address(RVA = "0x641038", Offset = "0x641038", VA = "0x641038")]
		public void GoBack()
		{
		}

		// Token: 0x06004AE2 RID: 19170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AE2")]
		[Address(RVA = "0x640F0C", Offset = "0x640F0C", VA = "0x640F0C")]
		private void AddToHistory(UIState state)
		{
		}

		// Token: 0x06004AE3 RID: 19171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AE3")]
		[Address(RVA = "0x640214", Offset = "0x640214", VA = "0x640214")]
		public void Recalculate()
		{
		}

		// Token: 0x06004AE4 RID: 19172 RVA: 0x000239A0 File Offset: 0x00021BA0
		[Token(Token = "0x6004AE4")]
		[Address(RVA = "0x641148", Offset = "0x641148", VA = "0x641148")]
		public CalculatedStyle GetDimensions()
		{
			return default(CalculatedStyle);
		}

		// Token: 0x06004AE5 RID: 19173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AE5")]
		[Address(RVA = "0x6412CC", Offset = "0x6412CC", VA = "0x6412CC")]
		internal void RefreshState()
		{
		}

		// Token: 0x06004AE6 RID: 19174 RVA: 0x000239B8 File Offset: 0x00021BB8
		[Token(Token = "0x6004AE6")]
		[Address(RVA = "0x641334", Offset = "0x641334", VA = "0x641334")]
		public bool IsElementUnderMouse()
		{
			return default(bool);
		}

		// Token: 0x04009006 RID: 36870
		[Token(Token = "0x4009006")]
		private const double DOUBLE_CLICK_TIME = 500.0;

		// Token: 0x04009007 RID: 36871
		[Token(Token = "0x4009007")]
		private const double STATE_CHANGE_CLICK_DISABLE_TIME = 200.0;

		// Token: 0x04009008 RID: 36872
		[Token(Token = "0x4009008")]
		private const int MAX_HISTORY_SIZE = 32;

		// Token: 0x04009009 RID: 36873
		[Token(Token = "0x4009009")]
		private const int HISTORY_PRUNE_SIZE = 4;

		// Token: 0x0400900A RID: 36874
		[Token(Token = "0x400900A")]
		[FieldOffset(Offset = "0x0")]
		public static UserInterface ActiveInstance;

		// Token: 0x0400900B RID: 36875
		[Token(Token = "0x400900B")]
		[FieldOffset(Offset = "0x8")]
		private List<UIState> _history;

		// Token: 0x0400900C RID: 36876
		[Token(Token = "0x400900C")]
		[FieldOffset(Offset = "0xC")]
		private UserInterface.InputPointerCache LeftMouse;

		// Token: 0x0400900D RID: 36877
		[Token(Token = "0x400900D")]
		[FieldOffset(Offset = "0x10")]
		private UserInterface.InputPointerCache RightMouse;

		// Token: 0x0400900E RID: 36878
		[Token(Token = "0x400900E")]
		[FieldOffset(Offset = "0x14")]
		public Vector2 MousePosition;

		// Token: 0x0400900F RID: 36879
		[Token(Token = "0x400900F")]
		[FieldOffset(Offset = "0x1C")]
		private UIElement _lastElementHover;

		// Token: 0x04009010 RID: 36880
		[Token(Token = "0x4009010")]
		[FieldOffset(Offset = "0x20")]
		private double _clickDisabledTimeRemaining;

		// Token: 0x04009011 RID: 36881
		[Token(Token = "0x4009011")]
		[FieldOffset(Offset = "0x28")]
		private bool _isStateDirty;

		// Token: 0x04009012 RID: 36882
		[Token(Token = "0x4009012")]
		[FieldOffset(Offset = "0x29")]
		public bool IsVisible;

		// Token: 0x04009013 RID: 36883
		[Token(Token = "0x4009013")]
		[FieldOffset(Offset = "0x2C")]
		private UIState _currentState;

		// Token: 0x0200089A RID: 2202
		// (Invoke) Token: 0x06004AE9 RID: 19177
		[Token(Token = "0x200089A")]
		private delegate void MouseElementEvent(UIElement element, UIMouseEvent evt);

		// Token: 0x0200089B RID: 2203
		[Token(Token = "0x200089B")]
		private class InputPointerCache
		{
			// Token: 0x06004AEC RID: 19180 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004AEC")]
			[Address(RVA = "0x63F7A4", Offset = "0x63F7A4", VA = "0x63F7A4")]
			public void Clear()
			{
			}

			// Token: 0x06004AED RID: 19181 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004AED")]
			[Address(RVA = "0x63FFE4", Offset = "0x63FFE4", VA = "0x63FFE4")]
			public InputPointerCache()
			{
			}

			// Token: 0x04009014 RID: 36884
			[Token(Token = "0x4009014")]
			[FieldOffset(Offset = "0x8")]
			public double LastTimeDown;

			// Token: 0x04009015 RID: 36885
			[Token(Token = "0x4009015")]
			[FieldOffset(Offset = "0x10")]
			public bool WasDown;

			// Token: 0x04009016 RID: 36886
			[Token(Token = "0x4009016")]
			[FieldOffset(Offset = "0x14")]
			public UIElement LastDown;

			// Token: 0x04009017 RID: 36887
			[Token(Token = "0x4009017")]
			[FieldOffset(Offset = "0x18")]
			public UIElement LastClicked;

			// Token: 0x04009018 RID: 36888
			[Token(Token = "0x4009018")]
			[FieldOffset(Offset = "0x1C")]
			public UserInterface.MouseElementEvent MouseDownEvent;

			// Token: 0x04009019 RID: 36889
			[Token(Token = "0x4009019")]
			[FieldOffset(Offset = "0x20")]
			public UserInterface.MouseElementEvent MouseUpEvent;

			// Token: 0x0400901A RID: 36890
			[Token(Token = "0x400901A")]
			[FieldOffset(Offset = "0x24")]
			public UserInterface.MouseElementEvent ClickEvent;

			// Token: 0x0400901B RID: 36891
			[Token(Token = "0x400901B")]
			[FieldOffset(Offset = "0x28")]
			public UserInterface.MouseElementEvent DoubleClickEvent;
		}

		// Token: 0x0200089C RID: 2204
		[Token(Token = "0x200089C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004AEF RID: 19183 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004AEF")]
			[Address(RVA = "0x6414F8", Offset = "0x6414F8", VA = "0x6414F8")]
			public <>c()
			{
			}

			// Token: 0x06004AF0 RID: 19184 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004AF0")]
			[Address(RVA = "0x641500", Offset = "0x641500", VA = "0x641500")]
			internal void <.ctor>b__22_0(UIElement element, UIMouseEvent evt)
			{
			}

			// Token: 0x06004AF1 RID: 19185 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004AF1")]
			[Address(RVA = "0x641534", Offset = "0x641534", VA = "0x641534")]
			internal void <.ctor>b__22_1(UIElement element, UIMouseEvent evt)
			{
			}

			// Token: 0x06004AF2 RID: 19186 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004AF2")]
			[Address(RVA = "0x641568", Offset = "0x641568", VA = "0x641568")]
			internal void <.ctor>b__22_2(UIElement element, UIMouseEvent evt)
			{
			}

			// Token: 0x06004AF3 RID: 19187 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004AF3")]
			[Address(RVA = "0x64159C", Offset = "0x64159C", VA = "0x64159C")]
			internal void <.ctor>b__22_3(UIElement element, UIMouseEvent evt)
			{
			}

			// Token: 0x06004AF4 RID: 19188 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004AF4")]
			[Address(RVA = "0x6415D0", Offset = "0x6415D0", VA = "0x6415D0")]
			internal void <.ctor>b__22_4(UIElement element, UIMouseEvent evt)
			{
			}

			// Token: 0x06004AF5 RID: 19189 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004AF5")]
			[Address(RVA = "0x641604", Offset = "0x641604", VA = "0x641604")]
			internal void <.ctor>b__22_5(UIElement element, UIMouseEvent evt)
			{
			}

			// Token: 0x06004AF6 RID: 19190 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004AF6")]
			[Address(RVA = "0x641638", Offset = "0x641638", VA = "0x641638")]
			internal void <.ctor>b__22_6(UIElement element, UIMouseEvent evt)
			{
			}

			// Token: 0x06004AF7 RID: 19191 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004AF7")]
			[Address(RVA = "0x64166C", Offset = "0x64166C", VA = "0x64166C")]
			internal void <.ctor>b__22_7(UIElement element, UIMouseEvent evt)
			{
			}

			// Token: 0x0400901C RID: 36892
			[Token(Token = "0x400901C")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UserInterface.<>c <>9;

			// Token: 0x0400901D RID: 36893
			[Token(Token = "0x400901D")]
			[FieldOffset(Offset = "0x4")]
			public static UserInterface.MouseElementEvent <>9__22_0;

			// Token: 0x0400901E RID: 36894
			[Token(Token = "0x400901E")]
			[FieldOffset(Offset = "0x8")]
			public static UserInterface.MouseElementEvent <>9__22_1;

			// Token: 0x0400901F RID: 36895
			[Token(Token = "0x400901F")]
			[FieldOffset(Offset = "0xC")]
			public static UserInterface.MouseElementEvent <>9__22_2;

			// Token: 0x04009020 RID: 36896
			[Token(Token = "0x4009020")]
			[FieldOffset(Offset = "0x10")]
			public static UserInterface.MouseElementEvent <>9__22_3;

			// Token: 0x04009021 RID: 36897
			[Token(Token = "0x4009021")]
			[FieldOffset(Offset = "0x14")]
			public static UserInterface.MouseElementEvent <>9__22_4;

			// Token: 0x04009022 RID: 36898
			[Token(Token = "0x4009022")]
			[FieldOffset(Offset = "0x18")]
			public static UserInterface.MouseElementEvent <>9__22_5;

			// Token: 0x04009023 RID: 36899
			[Token(Token = "0x4009023")]
			[FieldOffset(Offset = "0x1C")]
			public static UserInterface.MouseElementEvent <>9__22_6;

			// Token: 0x04009024 RID: 36900
			[Token(Token = "0x4009024")]
			[FieldOffset(Offset = "0x20")]
			public static UserInterface.MouseElementEvent <>9__22_7;
		}
	}
}
