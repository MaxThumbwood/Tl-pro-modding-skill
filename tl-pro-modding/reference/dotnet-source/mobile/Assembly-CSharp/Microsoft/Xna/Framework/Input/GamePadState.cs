using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x020003B2 RID: 946
	[Token(Token = "0x20003B2")]
	public struct GamePadState
	{
		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06001924 RID: 6436 RVA: 0x0000BF88 File Offset: 0x0000A188
		// (set) Token: 0x06001925 RID: 6437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000298")]
		public bool IsConnected
		{
			[Token(Token = "0x6001924")]
			[Address(RVA = "0xE24088", Offset = "0xE24088", VA = "0xE24088")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001925")]
			[Address(RVA = "0xE24090", Offset = "0xE24090", VA = "0xE24090")]
			internal set
			{
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06001926 RID: 6438 RVA: 0x0000BFA0 File Offset: 0x0000A1A0
		// (set) Token: 0x06001927 RID: 6439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000299")]
		public int PacketNumber
		{
			[Token(Token = "0x6001926")]
			[Address(RVA = "0xE24098", Offset = "0xE24098", VA = "0xE24098")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001927")]
			[Address(RVA = "0xE240A0", Offset = "0xE240A0", VA = "0xE240A0")]
			internal set
			{
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06001928 RID: 6440 RVA: 0x0000BFB8 File Offset: 0x0000A1B8
		// (set) Token: 0x06001929 RID: 6441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700029A")]
		public GamePadButtons Buttons
		{
			[Token(Token = "0x6001928")]
			[Address(RVA = "0xE240A8", Offset = "0xE240A8", VA = "0xE240A8")]
			get
			{
				return default(GamePadButtons);
			}
			[Token(Token = "0x6001929")]
			[Address(RVA = "0xE240B0", Offset = "0xE240B0", VA = "0xE240B0")]
			internal set
			{
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x0600192A RID: 6442 RVA: 0x0000BFD0 File Offset: 0x0000A1D0
		// (set) Token: 0x0600192B RID: 6443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700029B")]
		public GamePadDPad DPad
		{
			[Token(Token = "0x600192A")]
			[Address(RVA = "0xE240B8", Offset = "0xE240B8", VA = "0xE240B8")]
			get
			{
				return default(GamePadDPad);
			}
			[Token(Token = "0x600192B")]
			[Address(RVA = "0xE240C8", Offset = "0xE240C8", VA = "0xE240C8")]
			internal set
			{
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x0600192C RID: 6444 RVA: 0x0000BFE8 File Offset: 0x0000A1E8
		// (set) Token: 0x0600192D RID: 6445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700029C")]
		public GamePadThumbSticks ThumbSticks
		{
			[Token(Token = "0x600192C")]
			[Address(RVA = "0xE240D8", Offset = "0xE240D8", VA = "0xE240D8")]
			get
			{
				return default(GamePadThumbSticks);
			}
			[Token(Token = "0x600192D")]
			[Address(RVA = "0xE240F0", Offset = "0xE240F0", VA = "0xE240F0")]
			internal set
			{
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x0600192E RID: 6446 RVA: 0x0000C000 File Offset: 0x0000A200
		// (set) Token: 0x0600192F RID: 6447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700029D")]
		public GamePadTriggers Triggers
		{
			[Token(Token = "0x600192E")]
			[Address(RVA = "0xE24108", Offset = "0xE24108", VA = "0xE24108")]
			get
			{
				return default(GamePadTriggers);
			}
			[Token(Token = "0x600192F")]
			[Address(RVA = "0xE2411C", Offset = "0xE2411C", VA = "0xE2411C")]
			internal set
			{
			}
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001930")]
		[Address(RVA = "0xE24128", Offset = "0xE24128", VA = "0xE24128")]
		public GamePadState(GamePadThumbSticks thumbSticks, GamePadTriggers triggers, GamePadButtons buttons, GamePadDPad dPad)
		{
		}

		// Token: 0x06001931 RID: 6449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001931")]
		[Address(RVA = "0xE2422C", Offset = "0xE2422C", VA = "0xE2422C")]
		public GamePadState(Vector2 leftThumbStick, Vector2 rightThumbStick, float leftTrigger, float rightTrigger, Buttons buttons)
		{
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x0000C018 File Offset: 0x0000A218
		[Token(Token = "0x6001932")]
		[Address(RVA = "0xE24470", Offset = "0xE24470", VA = "0xE24470")]
		private Buttons GetVirtualButtons()
		{
			return (Buttons)0;
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x0000C030 File Offset: 0x0000A230
		[Token(Token = "0x6001933")]
		[Address(RVA = "0xE24568", Offset = "0xE24568", VA = "0xE24568")]
		public bool IsButtonDown(Buttons button)
		{
			return default(bool);
		}

		// Token: 0x06001934 RID: 6452 RVA: 0x0000C048 File Offset: 0x0000A248
		[Token(Token = "0x6001934")]
		[Address(RVA = "0xE245E0", Offset = "0xE245E0", VA = "0xE245E0")]
		public bool IsButtonUp(Buttons button)
		{
			return default(bool);
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x0000C060 File Offset: 0x0000A260
		[Token(Token = "0x6001935")]
		[Address(RVA = "0xE24654", Offset = "0xE24654", VA = "0xE24654")]
		public static bool operator ==(GamePadState left, GamePadState right)
		{
			return default(bool);
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x0000C078 File Offset: 0x0000A278
		[Token(Token = "0x6001936")]
		[Address(RVA = "0xE24964", Offset = "0xE24964", VA = "0xE24964")]
		public static bool operator !=(GamePadState left, GamePadState right)
		{
			return default(bool);
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x0000C090 File Offset: 0x0000A290
		[Token(Token = "0x6001937")]
		[Address(RVA = "0xE24AD4", Offset = "0xE24AD4", VA = "0xE24AD4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x0000C0A8 File Offset: 0x0000A2A8
		[Token(Token = "0x6001938")]
		[Address(RVA = "0xE24CB4", Offset = "0xE24CB4", VA = "0xE24CB4", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001939")]
		[Address(RVA = "0xE24F4C", Offset = "0xE24F4C", VA = "0xE24F4C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04002BA6 RID: 11174
		[Token(Token = "0x4002BA6")]
		[FieldOffset(Offset = "0x0")]
		public static readonly GamePadState Default;

		// Token: 0x04002BA7 RID: 11175
		[Token(Token = "0x4002BA7")]
		[FieldOffset(Offset = "0x0")]
		private bool <IsConnected>k__BackingField;

		// Token: 0x04002BA8 RID: 11176
		[Token(Token = "0x4002BA8")]
		[FieldOffset(Offset = "0x4")]
		private int <PacketNumber>k__BackingField;

		// Token: 0x04002BA9 RID: 11177
		[Token(Token = "0x4002BA9")]
		[FieldOffset(Offset = "0x8")]
		private GamePadButtons <Buttons>k__BackingField;

		// Token: 0x04002BAA RID: 11178
		[Token(Token = "0x4002BAA")]
		[FieldOffset(Offset = "0xC")]
		private GamePadDPad <DPad>k__BackingField;

		// Token: 0x04002BAB RID: 11179
		[Token(Token = "0x4002BAB")]
		[FieldOffset(Offset = "0x1C")]
		private GamePadThumbSticks <ThumbSticks>k__BackingField;

		// Token: 0x04002BAC RID: 11180
		[Token(Token = "0x4002BAC")]
		[FieldOffset(Offset = "0x30")]
		private GamePadTriggers <Triggers>k__BackingField;
	}
}
