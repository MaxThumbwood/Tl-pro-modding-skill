using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x020003C2 RID: 962
	[Token(Token = "0x20003C2")]
	public static class Mouse
	{
		// Token: 0x060019AE RID: 6574 RVA: 0x0000C6D8 File Offset: 0x0000A8D8
		[Token(Token = "0x60019AE")]
		[Address(RVA = "0xE2A31C", Offset = "0xE2A31C", VA = "0xE2A31C")]
		public static MouseState GetState(GameWindow window)
		{
			return default(MouseState);
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x0000C6F0 File Offset: 0x0000A8F0
		[Token(Token = "0x60019AF")]
		[Address(RVA = "0xE2B604", Offset = "0xE2B604", VA = "0xE2B604")]
		public static MouseState GetState()
		{
			return default(MouseState);
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019B0")]
		[Address(RVA = "0xE2B6DC", Offset = "0xE2B6DC", VA = "0xE2B6DC")]
		public static void SetPosition(int x, int y)
		{
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019B1")]
		[Address(RVA = "0xE2B738", Offset = "0xE2B738", VA = "0xE2B738")]
		public static void SetCursor(MouseCursor cursor)
		{
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x0000C708 File Offset: 0x0000A908
		[Token(Token = "0x60019B2")]
		[Address(RVA = "0xE2B794", Offset = "0xE2B794", VA = "0xE2B794")]
		private static IntPtr PlatformGetWindowHandle()
		{
			return 0;
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019B3")]
		[Address(RVA = "0xE2B7E4", Offset = "0xE2B7E4", VA = "0xE2B7E4")]
		private static void PlatformSetWindowHandle(IntPtr windowHandle)
		{
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x060019B4 RID: 6580 RVA: 0x0000C720 File Offset: 0x0000A920
		// (set) Token: 0x060019B5 RID: 6581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002B7")]
		private static int scrollAccum
		{
			[Token(Token = "0x60019B4")]
			[Address(RVA = "0xE2B7E8", Offset = "0xE2B7E8", VA = "0xE2B7E8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60019B5")]
			[Address(RVA = "0xE2B850", Offset = "0xE2B850", VA = "0xE2B850")]
			set
			{
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x060019B6 RID: 6582 RVA: 0x0000C738 File Offset: 0x0000A938
		// (set) Token: 0x060019B7 RID: 6583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002B8")]
		private static float _uiX
		{
			[Token(Token = "0x60019B6")]
			[Address(RVA = "0xE2B8BC", Offset = "0xE2B8BC", VA = "0xE2B8BC")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60019B7")]
			[Address(RVA = "0xE2B924", Offset = "0xE2B924", VA = "0xE2B924")]
			set
			{
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x060019B8 RID: 6584 RVA: 0x0000C750 File Offset: 0x0000A950
		// (set) Token: 0x060019B9 RID: 6585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002B9")]
		private static float _uiY
		{
			[Token(Token = "0x60019B8")]
			[Address(RVA = "0xE2B994", Offset = "0xE2B994", VA = "0xE2B994")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60019B9")]
			[Address(RVA = "0xE2B9FC", Offset = "0xE2B9FC", VA = "0xE2B9FC")]
			set
			{
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x060019BA RID: 6586 RVA: 0x0000C768 File Offset: 0x0000A968
		// (set) Token: 0x060019BB RID: 6587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002BA")]
		private static float _X
		{
			[Token(Token = "0x60019BA")]
			[Address(RVA = "0xE2BA6C", Offset = "0xE2BA6C", VA = "0xE2BA6C")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60019BB")]
			[Address(RVA = "0xE2BAD4", Offset = "0xE2BAD4", VA = "0xE2BAD4")]
			set
			{
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x060019BC RID: 6588 RVA: 0x0000C780 File Offset: 0x0000A980
		// (set) Token: 0x060019BD RID: 6589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002BB")]
		private static float _Y
		{
			[Token(Token = "0x60019BC")]
			[Address(RVA = "0xE2BB44", Offset = "0xE2BB44", VA = "0xE2BB44")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60019BD")]
			[Address(RVA = "0xE2BBAC", Offset = "0xE2BBAC", VA = "0xE2BBAC")]
			set
			{
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x060019BE RID: 6590 RVA: 0x0000C798 File Offset: 0x0000A998
		// (set) Token: 0x060019BF RID: 6591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002BC")]
		private static float _worldScreenOffsetY
		{
			[Token(Token = "0x60019BE")]
			[Address(RVA = "0xE2BC1C", Offset = "0xE2BC1C", VA = "0xE2BC1C")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60019BF")]
			[Address(RVA = "0xE2BC84", Offset = "0xE2BC84", VA = "0xE2BC84")]
			set
			{
			}
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019C0")]
		[Address(RVA = "0xE2BCF4", Offset = "0xE2BCF4", VA = "0xE2BCF4")]
		public static void SetWorldScreenOffset(float yValue)
		{
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x060019C1 RID: 6593 RVA: 0x0000C7B0 File Offset: 0x0000A9B0
		// (set) Token: 0x060019C2 RID: 6594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002BD")]
		public static int _overloadScreenWidth
		{
			[Token(Token = "0x60019C1")]
			[Address(RVA = "0xE2BF40", Offset = "0xE2BF40", VA = "0xE2BF40")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60019C2")]
			[Address(RVA = "0xE2BFA8", Offset = "0xE2BFA8", VA = "0xE2BFA8")]
			set
			{
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x060019C3 RID: 6595 RVA: 0x0000C7C8 File Offset: 0x0000A9C8
		// (set) Token: 0x060019C4 RID: 6596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002BE")]
		public static int _overloadScreenHeight
		{
			[Token(Token = "0x60019C3")]
			[Address(RVA = "0xE2C014", Offset = "0xE2C014", VA = "0xE2C014")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60019C4")]
			[Address(RVA = "0xE2C07C", Offset = "0xE2C07C", VA = "0xE2C07C")]
			set
			{
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x060019C5 RID: 6597 RVA: 0x0000C7E0 File Offset: 0x0000A9E0
		// (set) Token: 0x060019C6 RID: 6598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002BF")]
		public static int _overloadScreenOffsetX
		{
			[Token(Token = "0x60019C5")]
			[Address(RVA = "0xE2C0E8", Offset = "0xE2C0E8", VA = "0xE2C0E8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60019C6")]
			[Address(RVA = "0xE2C150", Offset = "0xE2C150", VA = "0xE2C150")]
			set
			{
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x060019C7 RID: 6599 RVA: 0x0000C7F8 File Offset: 0x0000A9F8
		// (set) Token: 0x060019C8 RID: 6600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002C0")]
		public static int _overloadScreenOffsetY
		{
			[Token(Token = "0x60019C7")]
			[Address(RVA = "0xE2C1BC", Offset = "0xE2C1BC", VA = "0xE2C1BC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60019C8")]
			[Address(RVA = "0xE2C224", Offset = "0xE2C224", VA = "0xE2C224")]
			set
			{
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x060019C9 RID: 6601 RVA: 0x0000C810 File Offset: 0x0000AA10
		// (set) Token: 0x060019CA RID: 6602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002C1")]
		public static Mouse.OverrideState _virtualCursorOverride
		{
			[Token(Token = "0x60019C9")]
			[Address(RVA = "0xE2C290", Offset = "0xE2C290", VA = "0xE2C290")]
			get
			{
				return Mouse.OverrideState.None;
			}
			[Token(Token = "0x60019CA")]
			[Address(RVA = "0xE2C2F8", Offset = "0xE2C2F8", VA = "0xE2C2F8")]
			set
			{
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x060019CB RID: 6603 RVA: 0x0000C828 File Offset: 0x0000AA28
		// (set) Token: 0x060019CC RID: 6604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002C2")]
		public static ButtonState _virtualCursorOverrideState
		{
			[Token(Token = "0x60019CB")]
			[Address(RVA = "0xE2C364", Offset = "0xE2C364", VA = "0xE2C364")]
			get
			{
				return ButtonState.Released;
			}
			[Token(Token = "0x60019CC")]
			[Address(RVA = "0xE2C3CC", Offset = "0xE2C3CC", VA = "0xE2C3CC")]
			set
			{
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x060019CD RID: 6605 RVA: 0x0000C840 File Offset: 0x0000AA40
		// (set) Token: 0x060019CE RID: 6606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002C3")]
		public static float _virtualCursorOverrideX
		{
			[Token(Token = "0x60019CD")]
			[Address(RVA = "0xE2C438", Offset = "0xE2C438", VA = "0xE2C438")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60019CE")]
			[Address(RVA = "0xE2C4A0", Offset = "0xE2C4A0", VA = "0xE2C4A0")]
			set
			{
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x060019CF RID: 6607 RVA: 0x0000C858 File Offset: 0x0000AA58
		// (set) Token: 0x060019D0 RID: 6608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002C4")]
		public static float _virtualCursorOverrideY
		{
			[Token(Token = "0x60019CF")]
			[Address(RVA = "0xE2C510", Offset = "0xE2C510", VA = "0xE2C510")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60019D0")]
			[Address(RVA = "0xE2C578", Offset = "0xE2C578", VA = "0xE2C578")]
			set
			{
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x060019D1 RID: 6609 RVA: 0x0000C870 File Offset: 0x0000AA70
		// (set) Token: 0x060019D2 RID: 6610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002C5")]
		public static bool _overrideRMB
		{
			[Token(Token = "0x60019D1")]
			[Address(RVA = "0xE2C5E8", Offset = "0xE2C5E8", VA = "0xE2C5E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60019D2")]
			[Address(RVA = "0xE2C650", Offset = "0xE2C650", VA = "0xE2C650")]
			set
			{
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x060019D3 RID: 6611 RVA: 0x0000C888 File Offset: 0x0000AA88
		// (set) Token: 0x060019D4 RID: 6612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002C6")]
		public static ButtonState _rmbOverrideState
		{
			[Token(Token = "0x60019D3")]
			[Address(RVA = "0xE2C6BC", Offset = "0xE2C6BC", VA = "0xE2C6BC")]
			get
			{
				return ButtonState.Released;
			}
			[Token(Token = "0x60019D4")]
			[Address(RVA = "0xE2C724", Offset = "0xE2C724", VA = "0xE2C724")]
			set
			{
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x060019D5 RID: 6613 RVA: 0x0000C8A0 File Offset: 0x0000AAA0
		// (set) Token: 0x060019D6 RID: 6614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002C7")]
		private static float scrollAccumPartial
		{
			[Token(Token = "0x60019D5")]
			[Address(RVA = "0xE2C790", Offset = "0xE2C790", VA = "0xE2C790")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60019D6")]
			[Address(RVA = "0xE2C7F8", Offset = "0xE2C7F8", VA = "0xE2C7F8")]
			set
			{
			}
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019D7")]
		[Address(RVA = "0xE2C868", Offset = "0xE2C868", VA = "0xE2C868")]
		public static void SetRMBOverride(bool overrideRMB, ButtonState overrideState)
		{
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x0000C8B8 File Offset: 0x0000AAB8
		[Token(Token = "0x60019D8")]
		[Address(RVA = "0xE2C974", Offset = "0xE2C974", VA = "0xE2C974")]
		public static Mouse.OverrideState GetOverrideState()
		{
			return Mouse.OverrideState.None;
		}

		// Token: 0x060019D9 RID: 6617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019D9")]
		[Address(RVA = "0xE2CA2C", Offset = "0xE2CA2C", VA = "0xE2CA2C")]
		public static void SetVirtualCursorOverride(Mouse.OverrideState overrideMouse, ButtonState overrideState, float x, float y)
		{
		}

		// Token: 0x060019DA RID: 6618 RVA: 0x0000C8D0 File Offset: 0x0000AAD0
		[Token(Token = "0x60019DA")]
		[Address(RVA = "0xE2CD5C", Offset = "0xE2CD5C", VA = "0xE2CD5C")]
		public static Vector2 GetUICursorPosition()
		{
			return default(Vector2);
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019DB")]
		[Address(RVA = "0xE2CE80", Offset = "0xE2CE80", VA = "0xE2CE80")]
		public static void UpdateUICursorPoint()
		{
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x0000C8E8 File Offset: 0x0000AAE8
		[Token(Token = "0x60019DC")]
		[Address(RVA = "0xE2A3B0", Offset = "0xE2A3B0", VA = "0xE2A3B0")]
		private static MouseState PlatformGetState(GameWindow window)
		{
			return default(MouseState);
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019DD")]
		[Address(RVA = "0xE2D06C", Offset = "0xE2D06C", VA = "0xE2D06C")]
		private static Cursor ActiveCursor()
		{
			return null;
		}

		// Token: 0x060019DE RID: 6622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019DE")]
		[Address(RVA = "0xE2B734", Offset = "0xE2B734", VA = "0xE2B734")]
		private static void PlatformSetPosition(int x, int y)
		{
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019DF")]
		[Address(RVA = "0xE2B790", Offset = "0xE2B790", VA = "0xE2B790")]
		public static void PlatformSetCursor(MouseCursor cursor)
		{
		}

		// Token: 0x04002C93 RID: 11411
		[Token(Token = "0x4002C93")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MouseState _defaultState;

		// Token: 0x020003C3 RID: 963
		[Token(Token = "0x20003C3")]
		public enum OverrideState
		{
			// Token: 0x04002C95 RID: 11413
			[Token(Token = "0x4002C95")]
			None,
			// Token: 0x04002C96 RID: 11414
			[Token(Token = "0x4002C96")]
			Position,
			// Token: 0x04002C97 RID: 11415
			[Token(Token = "0x4002C97")]
			Click,
			// Token: 0x04002C98 RID: 11416
			[Token(Token = "0x4002C98")]
			PositionAndClick
		}
	}
}
