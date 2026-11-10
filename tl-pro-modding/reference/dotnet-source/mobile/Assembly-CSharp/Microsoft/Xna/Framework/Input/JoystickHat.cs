using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x020003BA RID: 954
	[Token(Token = "0x20003BA")]
	public struct JoystickHat
	{
		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06001973 RID: 6515 RVA: 0x0000C420 File Offset: 0x0000A620
		// (set) Token: 0x06001974 RID: 6516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002AB")]
		public ButtonState Down
		{
			[Token(Token = "0x6001973")]
			[Address(RVA = "0xE2717C", Offset = "0xE2717C", VA = "0xE2717C")]
			get
			{
				return ButtonState.Released;
			}
			[Token(Token = "0x6001974")]
			[Address(RVA = "0xE27184", Offset = "0xE27184", VA = "0xE27184")]
			internal set
			{
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06001975 RID: 6517 RVA: 0x0000C438 File Offset: 0x0000A638
		// (set) Token: 0x06001976 RID: 6518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002AC")]
		public ButtonState Left
		{
			[Token(Token = "0x6001975")]
			[Address(RVA = "0xE2718C", Offset = "0xE2718C", VA = "0xE2718C")]
			get
			{
				return ButtonState.Released;
			}
			[Token(Token = "0x6001976")]
			[Address(RVA = "0xE27194", Offset = "0xE27194", VA = "0xE27194")]
			internal set
			{
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06001977 RID: 6519 RVA: 0x0000C450 File Offset: 0x0000A650
		// (set) Token: 0x06001978 RID: 6520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002AD")]
		public ButtonState Right
		{
			[Token(Token = "0x6001977")]
			[Address(RVA = "0xE2719C", Offset = "0xE2719C", VA = "0xE2719C")]
			get
			{
				return ButtonState.Released;
			}
			[Token(Token = "0x6001978")]
			[Address(RVA = "0xE271A4", Offset = "0xE271A4", VA = "0xE271A4")]
			internal set
			{
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06001979 RID: 6521 RVA: 0x0000C468 File Offset: 0x0000A668
		// (set) Token: 0x0600197A RID: 6522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002AE")]
		public ButtonState Up
		{
			[Token(Token = "0x6001979")]
			[Address(RVA = "0xE271AC", Offset = "0xE271AC", VA = "0xE271AC")]
			get
			{
				return ButtonState.Released;
			}
			[Token(Token = "0x600197A")]
			[Address(RVA = "0xE271B4", Offset = "0xE271B4", VA = "0xE271B4")]
			internal set
			{
			}
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x0000C480 File Offset: 0x0000A680
		[Token(Token = "0x600197B")]
		[Address(RVA = "0xE271BC", Offset = "0xE271BC", VA = "0xE271BC")]
		public static bool operator ==(JoystickHat left, JoystickHat right)
		{
			return default(bool);
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x0000C498 File Offset: 0x0000A698
		[Token(Token = "0x600197C")]
		[Address(RVA = "0xE271F8", Offset = "0xE271F8", VA = "0xE271F8")]
		public static bool operator !=(JoystickHat left, JoystickHat right)
		{
			return default(bool);
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x0000C4B0 File Offset: 0x0000A6B0
		[Token(Token = "0x600197D")]
		[Address(RVA = "0xE27238", Offset = "0xE27238", VA = "0xE27238", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x0000C4C8 File Offset: 0x0000A6C8
		[Token(Token = "0x600197E")]
		[Address(RVA = "0xE272F0", Offset = "0xE272F0", VA = "0xE272F0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600197F")]
		[Address(RVA = "0xE27330", Offset = "0xE27330", VA = "0xE27330", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04002BC9 RID: 11209
		[Token(Token = "0x4002BC9")]
		[FieldOffset(Offset = "0x0")]
		private ButtonState <Down>k__BackingField;

		// Token: 0x04002BCA RID: 11210
		[Token(Token = "0x4002BCA")]
		[FieldOffset(Offset = "0x4")]
		private ButtonState <Left>k__BackingField;

		// Token: 0x04002BCB RID: 11211
		[Token(Token = "0x4002BCB")]
		[FieldOffset(Offset = "0x8")]
		private ButtonState <Right>k__BackingField;

		// Token: 0x04002BCC RID: 11212
		[Token(Token = "0x4002BCC")]
		[FieldOffset(Offset = "0xC")]
		private ButtonState <Up>k__BackingField;
	}
}
