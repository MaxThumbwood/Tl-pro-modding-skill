using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x020003C5 RID: 965
	[Token(Token = "0x20003C5")]
	public struct MouseState
	{
		// Token: 0x06001A00 RID: 6656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A00")]
		[Address(RVA = "0xE2D034", Offset = "0xE2D034", VA = "0xE2D034")]
		public MouseState(int x, int y, int scrollWheel, ButtonState leftButton, ButtonState middleButton, ButtonState rightButton, ButtonState xButton1, ButtonState xButton2)
		{
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A01")]
		[Address(RVA = "0xE2E380", Offset = "0xE2E380", VA = "0xE2E380")]
		public MouseState(int x, int y, int scrollWheel, ButtonState leftButton, ButtonState middleButton, ButtonState rightButton, ButtonState xButton1, ButtonState xButton2, int horizontalScrollWheel)
		{
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x0000C918 File Offset: 0x0000AB18
		[Token(Token = "0x6001A02")]
		[Address(RVA = "0xE2E3B8", Offset = "0xE2E3B8", VA = "0xE2E3B8")]
		public static bool operator ==(MouseState left, MouseState right)
		{
			return default(bool);
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x0000C930 File Offset: 0x0000AB30
		[Token(Token = "0x6001A03")]
		[Address(RVA = "0xE2E43C", Offset = "0xE2E43C", VA = "0xE2E43C")]
		public static bool operator !=(MouseState left, MouseState right)
		{
			return default(bool);
		}

		// Token: 0x06001A04 RID: 6660 RVA: 0x0000C948 File Offset: 0x0000AB48
		[Token(Token = "0x6001A04")]
		[Address(RVA = "0xE2E4C0", Offset = "0xE2E4C0", VA = "0xE2E4C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x0000C960 File Offset: 0x0000AB60
		[Token(Token = "0x6001A05")]
		[Address(RVA = "0xE2E5D0", Offset = "0xE2E5D0", VA = "0xE2E5D0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06001A06 RID: 6662 RVA: 0x0000C978 File Offset: 0x0000AB78
		// (set) Token: 0x06001A07 RID: 6663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002D5")]
		public int X
		{
			[Token(Token = "0x6001A06")]
			[Address(RVA = "0xE2E638", Offset = "0xE2E638", VA = "0xE2E638")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001A07")]
			[Address(RVA = "0xE2E640", Offset = "0xE2E640", VA = "0xE2E640")]
			internal set
			{
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06001A08 RID: 6664 RVA: 0x0000C990 File Offset: 0x0000AB90
		// (set) Token: 0x06001A09 RID: 6665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002D6")]
		public int Y
		{
			[Token(Token = "0x6001A08")]
			[Address(RVA = "0xE2E648", Offset = "0xE2E648", VA = "0xE2E648")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001A09")]
			[Address(RVA = "0xE2E650", Offset = "0xE2E650", VA = "0xE2E650")]
			internal set
			{
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06001A0A RID: 6666 RVA: 0x0000C9A8 File Offset: 0x0000ABA8
		[Token(Token = "0x170002D7")]
		public Point Position
		{
			[Token(Token = "0x6001A0A")]
			[Address(RVA = "0xE2E658", Offset = "0xE2E658", VA = "0xE2E658")]
			get
			{
				return default(Point);
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06001A0B RID: 6667 RVA: 0x0000C9C0 File Offset: 0x0000ABC0
		// (set) Token: 0x06001A0C RID: 6668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002D8")]
		public ButtonState LeftButton
		{
			[Token(Token = "0x6001A0B")]
			[Address(RVA = "0xE2E680", Offset = "0xE2E680", VA = "0xE2E680")]
			get
			{
				return ButtonState.Released;
			}
			[Token(Token = "0x6001A0C")]
			[Address(RVA = "0xE2E688", Offset = "0xE2E688", VA = "0xE2E688")]
			internal set
			{
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06001A0D RID: 6669 RVA: 0x0000C9D8 File Offset: 0x0000ABD8
		// (set) Token: 0x06001A0E RID: 6670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002D9")]
		public ButtonState MiddleButton
		{
			[Token(Token = "0x6001A0D")]
			[Address(RVA = "0xE2E690", Offset = "0xE2E690", VA = "0xE2E690")]
			get
			{
				return ButtonState.Released;
			}
			[Token(Token = "0x6001A0E")]
			[Address(RVA = "0xE2E698", Offset = "0xE2E698", VA = "0xE2E698")]
			internal set
			{
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06001A0F RID: 6671 RVA: 0x0000C9F0 File Offset: 0x0000ABF0
		// (set) Token: 0x06001A10 RID: 6672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002DA")]
		public ButtonState RightButton
		{
			[Token(Token = "0x6001A0F")]
			[Address(RVA = "0xE2E6A0", Offset = "0xE2E6A0", VA = "0xE2E6A0")]
			get
			{
				return ButtonState.Released;
			}
			[Token(Token = "0x6001A10")]
			[Address(RVA = "0xE2E6A8", Offset = "0xE2E6A8", VA = "0xE2E6A8")]
			internal set
			{
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06001A11 RID: 6673 RVA: 0x0000CA08 File Offset: 0x0000AC08
		// (set) Token: 0x06001A12 RID: 6674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002DB")]
		public int ScrollWheelValue
		{
			[Token(Token = "0x6001A11")]
			[Address(RVA = "0xE2E6B0", Offset = "0xE2E6B0", VA = "0xE2E6B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001A12")]
			[Address(RVA = "0xE2E6B8", Offset = "0xE2E6B8", VA = "0xE2E6B8")]
			internal set
			{
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06001A13 RID: 6675 RVA: 0x0000CA20 File Offset: 0x0000AC20
		// (set) Token: 0x06001A14 RID: 6676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002DC")]
		public int HorizontalScrollWheelValue
		{
			[Token(Token = "0x6001A13")]
			[Address(RVA = "0xE2E6C0", Offset = "0xE2E6C0", VA = "0xE2E6C0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001A14")]
			[Address(RVA = "0xE2E6C8", Offset = "0xE2E6C8", VA = "0xE2E6C8")]
			internal set
			{
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06001A15 RID: 6677 RVA: 0x0000CA38 File Offset: 0x0000AC38
		// (set) Token: 0x06001A16 RID: 6678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002DD")]
		public ButtonState XButton1
		{
			[Token(Token = "0x6001A15")]
			[Address(RVA = "0xE2E6D0", Offset = "0xE2E6D0", VA = "0xE2E6D0")]
			get
			{
				return ButtonState.Released;
			}
			[Token(Token = "0x6001A16")]
			[Address(RVA = "0xE2E6D8", Offset = "0xE2E6D8", VA = "0xE2E6D8")]
			internal set
			{
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06001A17 RID: 6679 RVA: 0x0000CA50 File Offset: 0x0000AC50
		// (set) Token: 0x06001A18 RID: 6680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002DE")]
		public ButtonState XButton2
		{
			[Token(Token = "0x6001A17")]
			[Address(RVA = "0xE2E6E0", Offset = "0xE2E6E0", VA = "0xE2E6E0")]
			get
			{
				return ButtonState.Released;
			}
			[Token(Token = "0x6001A18")]
			[Address(RVA = "0xE2E6E8", Offset = "0xE2E6E8", VA = "0xE2E6E8")]
			internal set
			{
			}
		}

		// Token: 0x04002CA6 RID: 11430
		[Token(Token = "0x4002CA6")]
		[FieldOffset(Offset = "0x0")]
		private int _x;

		// Token: 0x04002CA7 RID: 11431
		[Token(Token = "0x4002CA7")]
		[FieldOffset(Offset = "0x4")]
		private int _y;

		// Token: 0x04002CA8 RID: 11432
		[Token(Token = "0x4002CA8")]
		[FieldOffset(Offset = "0x8")]
		private int _scrollWheelValue;

		// Token: 0x04002CA9 RID: 11433
		[Token(Token = "0x4002CA9")]
		[FieldOffset(Offset = "0xC")]
		private ButtonState _leftButton;

		// Token: 0x04002CAA RID: 11434
		[Token(Token = "0x4002CAA")]
		[FieldOffset(Offset = "0x10")]
		private ButtonState _rightButton;

		// Token: 0x04002CAB RID: 11435
		[Token(Token = "0x4002CAB")]
		[FieldOffset(Offset = "0x14")]
		private ButtonState _middleButton;

		// Token: 0x04002CAC RID: 11436
		[Token(Token = "0x4002CAC")]
		[FieldOffset(Offset = "0x18")]
		private ButtonState _xButton1;

		// Token: 0x04002CAD RID: 11437
		[Token(Token = "0x4002CAD")]
		[FieldOffset(Offset = "0x1C")]
		private ButtonState _xButton2;

		// Token: 0x04002CAE RID: 11438
		[Token(Token = "0x4002CAE")]
		[FieldOffset(Offset = "0x20")]
		private int _horizontalScrollWheelValue;
	}
}
