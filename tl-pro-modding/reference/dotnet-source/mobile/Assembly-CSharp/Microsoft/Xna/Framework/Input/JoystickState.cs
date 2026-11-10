using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x020003BB RID: 955
	[Token(Token = "0x20003BB")]
	public struct JoystickState
	{
		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06001980 RID: 6528 RVA: 0x0000C4E0 File Offset: 0x0000A6E0
		// (set) Token: 0x06001981 RID: 6529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002AF")]
		public bool IsConnected
		{
			[Token(Token = "0x6001980")]
			[Address(RVA = "0xE273C0", Offset = "0xE273C0", VA = "0xE273C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001981")]
			[Address(RVA = "0xE273C8", Offset = "0xE273C8", VA = "0xE273C8")]
			internal set
			{
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06001982 RID: 6530 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001983 RID: 6531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002B0")]
		public int[] Axes
		{
			[Token(Token = "0x6001982")]
			[Address(RVA = "0xE273D0", Offset = "0xE273D0", VA = "0xE273D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001983")]
			[Address(RVA = "0xE273D8", Offset = "0xE273D8", VA = "0xE273D8")]
			internal set
			{
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06001984 RID: 6532 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001985 RID: 6533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002B1")]
		public ButtonState[] Buttons
		{
			[Token(Token = "0x6001984")]
			[Address(RVA = "0xE273E0", Offset = "0xE273E0", VA = "0xE273E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001985")]
			[Address(RVA = "0xE273E8", Offset = "0xE273E8", VA = "0xE273E8")]
			internal set
			{
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06001986 RID: 6534 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001987 RID: 6535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002B2")]
		public JoystickHat[] Hats
		{
			[Token(Token = "0x6001986")]
			[Address(RVA = "0xE273F0", Offset = "0xE273F0", VA = "0xE273F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001987")]
			[Address(RVA = "0xE273F8", Offset = "0xE273F8", VA = "0xE273F8")]
			internal set
			{
			}
		}

		// Token: 0x06001988 RID: 6536 RVA: 0x0000C4F8 File Offset: 0x0000A6F8
		[Token(Token = "0x6001988")]
		[Address(RVA = "0xE27400", Offset = "0xE27400", VA = "0xE27400")]
		public static bool operator ==(JoystickState left, JoystickState right)
		{
			return default(bool);
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x0000C510 File Offset: 0x0000A710
		[Token(Token = "0x6001989")]
		[Address(RVA = "0xE27510", Offset = "0xE27510", VA = "0xE27510")]
		public static bool operator !=(JoystickState left, JoystickState right)
		{
			return default(bool);
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x0000C528 File Offset: 0x0000A728
		[Token(Token = "0x600198A")]
		[Address(RVA = "0xE27548", Offset = "0xE27548", VA = "0xE27548", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x0000C540 File Offset: 0x0000A740
		[Token(Token = "0x600198B")]
		[Address(RVA = "0xE275F4", Offset = "0xE275F4", VA = "0xE275F4", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600198C")]
		[Address(RVA = "0xE27728", Offset = "0xE27728", VA = "0xE27728", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04002BCD RID: 11213
		[Token(Token = "0x4002BCD")]
		[FieldOffset(Offset = "0x0")]
		private bool <IsConnected>k__BackingField;

		// Token: 0x04002BCE RID: 11214
		[Token(Token = "0x4002BCE")]
		[FieldOffset(Offset = "0x4")]
		private int[] <Axes>k__BackingField;

		// Token: 0x04002BCF RID: 11215
		[Token(Token = "0x4002BCF")]
		[FieldOffset(Offset = "0x8")]
		private ButtonState[] <Buttons>k__BackingField;

		// Token: 0x04002BD0 RID: 11216
		[Token(Token = "0x4002BD0")]
		[FieldOffset(Offset = "0xC")]
		private JoystickHat[] <Hats>k__BackingField;
	}
}
