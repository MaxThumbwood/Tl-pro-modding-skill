using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000DA0 RID: 3488
	[Token(Token = "0x2000DA0")]
	public class UIVerticalSlider : UISliderBase
	{
		// Token: 0x060066F9 RID: 26361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066F9")]
		[Address(RVA = "0xB680FC", Offset = "0xB680FC", VA = "0xB680FC")]
		public UIVerticalSlider(Func<float> getStatus, Action<float> setStatusKeyboard, Action setStatusGamepad, Color color)
		{
		}

		// Token: 0x060066FA RID: 26362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066FA")]
		[Address(RVA = "0xB68374", Offset = "0xB68374", VA = "0xB68374", Slot = "6")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x060066FB RID: 26363 RVA: 0x0002E770 File Offset: 0x0002C970
		[Token(Token = "0x60066FB")]
		[Address(RVA = "0xB68628", Offset = "0xB68628", VA = "0xB68628")]
		private bool DrawValueBarDynamicWidth(SpriteBatch spriteBatch, out float sliderValueThatWasSet)
		{
			return default(bool);
		}

		// Token: 0x0400A402 RID: 41986
		[Token(Token = "0x400A402")]
		[FieldOffset(Offset = "0xF4")]
		public float FillPercent;

		// Token: 0x0400A403 RID: 41987
		[Token(Token = "0x400A403")]
		[FieldOffset(Offset = "0xF8")]
		public Color FilledColor;

		// Token: 0x0400A404 RID: 41988
		[Token(Token = "0x400A404")]
		[FieldOffset(Offset = "0xFC")]
		public Color EmptyColor;

		// Token: 0x0400A405 RID: 41989
		[Token(Token = "0x400A405")]
		[FieldOffset(Offset = "0x100")]
		private Func<float> _getSliderValue;

		// Token: 0x0400A406 RID: 41990
		[Token(Token = "0x400A406")]
		[FieldOffset(Offset = "0x104")]
		private Action<float> _slideKeyboardAction;

		// Token: 0x0400A407 RID: 41991
		[Token(Token = "0x400A407")]
		[FieldOffset(Offset = "0x108")]
		private Action _slideGamepadAction;

		// Token: 0x0400A408 RID: 41992
		[Token(Token = "0x400A408")]
		[FieldOffset(Offset = "0x10C")]
		private bool _isReallyMouseOvered;

		// Token: 0x0400A409 RID: 41993
		[Token(Token = "0x400A409")]
		[FieldOffset(Offset = "0x10D")]
		private bool _soundedUsage;

		// Token: 0x0400A40A RID: 41994
		[Token(Token = "0x400A40A")]
		[FieldOffset(Offset = "0x10E")]
		private bool _alreadyHovered;

		// Token: 0x02000DA1 RID: 3489
		[Token(Token = "0x2000DA1")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060066FD RID: 26365 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60066FD")]
			[Address(RVA = "0xB68F28", Offset = "0xB68F28", VA = "0xB68F28")]
			public <>c()
			{
			}

			// Token: 0x060066FE RID: 26366 RVA: 0x0002E788 File Offset: 0x0002C988
			[Token(Token = "0x60066FE")]
			[Address(RVA = "0xB68F30", Offset = "0xB68F30", VA = "0xB68F30")]
			internal float <.ctor>b__9_0()
			{
				return 0f;
			}

			// Token: 0x060066FF RID: 26367 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60066FF")]
			[Address(RVA = "0xB68F38", Offset = "0xB68F38", VA = "0xB68F38")]
			internal void <.ctor>b__9_1(float s)
			{
			}

			// Token: 0x0400A40B RID: 41995
			[Token(Token = "0x400A40B")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIVerticalSlider.<>c <>9;

			// Token: 0x0400A40C RID: 41996
			[Token(Token = "0x400A40C")]
			[FieldOffset(Offset = "0x4")]
			public static Func<float> <>9__9_0;

			// Token: 0x0400A40D RID: 41997
			[Token(Token = "0x400A40D")]
			[FieldOffset(Offset = "0x8")]
			public static Action<float> <>9__9_1;
		}
	}
}
