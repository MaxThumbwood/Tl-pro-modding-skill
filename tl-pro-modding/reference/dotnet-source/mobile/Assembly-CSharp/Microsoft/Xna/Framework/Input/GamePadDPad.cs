using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x020003B1 RID: 945
	[Token(Token = "0x20003B1")]
	public struct GamePadDPad
	{
		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06001915 RID: 6421 RVA: 0x0000BEC8 File Offset: 0x0000A0C8
		// (set) Token: 0x06001916 RID: 6422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000294")]
		public ButtonState Down
		{
			[Token(Token = "0x6001915")]
			[Address(RVA = "0xE23E0C", Offset = "0xE23E0C", VA = "0xE23E0C")]
			get
			{
				return ButtonState.Released;
			}
			[Token(Token = "0x6001916")]
			[Address(RVA = "0xE23E14", Offset = "0xE23E14", VA = "0xE23E14")]
			private set
			{
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06001917 RID: 6423 RVA: 0x0000BEE0 File Offset: 0x0000A0E0
		// (set) Token: 0x06001918 RID: 6424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000295")]
		public ButtonState Left
		{
			[Token(Token = "0x6001917")]
			[Address(RVA = "0xE23E1C", Offset = "0xE23E1C", VA = "0xE23E1C")]
			get
			{
				return ButtonState.Released;
			}
			[Token(Token = "0x6001918")]
			[Address(RVA = "0xE23E24", Offset = "0xE23E24", VA = "0xE23E24")]
			private set
			{
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06001919 RID: 6425 RVA: 0x0000BEF8 File Offset: 0x0000A0F8
		// (set) Token: 0x0600191A RID: 6426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000296")]
		public ButtonState Right
		{
			[Token(Token = "0x6001919")]
			[Address(RVA = "0xE23E2C", Offset = "0xE23E2C", VA = "0xE23E2C")]
			get
			{
				return ButtonState.Released;
			}
			[Token(Token = "0x600191A")]
			[Address(RVA = "0xE23E34", Offset = "0xE23E34", VA = "0xE23E34")]
			private set
			{
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x0600191B RID: 6427 RVA: 0x0000BF10 File Offset: 0x0000A110
		// (set) Token: 0x0600191C RID: 6428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000297")]
		public ButtonState Up
		{
			[Token(Token = "0x600191B")]
			[Address(RVA = "0xE23E3C", Offset = "0xE23E3C", VA = "0xE23E3C")]
			get
			{
				return ButtonState.Released;
			}
			[Token(Token = "0x600191C")]
			[Address(RVA = "0xE23E44", Offset = "0xE23E44", VA = "0xE23E44")]
			private set
			{
			}
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600191D")]
		[Address(RVA = "0xE23E4C", Offset = "0xE23E4C", VA = "0xE23E4C")]
		public GamePadDPad(ButtonState upValue, ButtonState downValue, ButtonState leftValue, ButtonState rightValue)
		{
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600191E")]
		[Address(RVA = "0xE23E5C", Offset = "0xE23E5C", VA = "0xE23E5C")]
		internal GamePadDPad(Buttons buttons)
		{
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x0000BF28 File Offset: 0x0000A128
		[Token(Token = "0x600191F")]
		[Address(RVA = "0xE23E98", Offset = "0xE23E98", VA = "0xE23E98")]
		public static bool operator ==(GamePadDPad left, GamePadDPad right)
		{
			return default(bool);
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x0000BF40 File Offset: 0x0000A140
		[Token(Token = "0x6001920")]
		[Address(RVA = "0xE23ED4", Offset = "0xE23ED4", VA = "0xE23ED4")]
		public static bool operator !=(GamePadDPad left, GamePadDPad right)
		{
			return default(bool);
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x0000BF58 File Offset: 0x0000A158
		[Token(Token = "0x6001921")]
		[Address(RVA = "0xE23F14", Offset = "0xE23F14", VA = "0xE23F14", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x0000BF70 File Offset: 0x0000A170
		[Token(Token = "0x6001922")]
		[Address(RVA = "0xE23FCC", Offset = "0xE23FCC", VA = "0xE23FCC", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001923")]
		[Address(RVA = "0xE23FF8", Offset = "0xE23FF8", VA = "0xE23FF8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04002BA2 RID: 11170
		[Token(Token = "0x4002BA2")]
		[FieldOffset(Offset = "0x0")]
		private ButtonState <Down>k__BackingField;

		// Token: 0x04002BA3 RID: 11171
		[Token(Token = "0x4002BA3")]
		[FieldOffset(Offset = "0x4")]
		private ButtonState <Left>k__BackingField;

		// Token: 0x04002BA4 RID: 11172
		[Token(Token = "0x4002BA4")]
		[FieldOffset(Offset = "0x8")]
		private ButtonState <Right>k__BackingField;

		// Token: 0x04002BA5 RID: 11173
		[Token(Token = "0x4002BA5")]
		[FieldOffset(Offset = "0xC")]
		private ButtonState <Up>k__BackingField;
	}
}
