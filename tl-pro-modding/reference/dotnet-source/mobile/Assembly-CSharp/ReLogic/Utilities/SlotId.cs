using System;
using Il2CppDummyDll;

namespace ReLogic.Utilities
{
	// Token: 0x02000DD4 RID: 3540
	[Token(Token = "0x2000DD4")]
	public struct SlotId
	{
		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x060067DE RID: 26590 RVA: 0x0002F070 File Offset: 0x0002D270
		[Token(Token = "0x17000B0D")]
		public bool IsValid
		{
			[Token(Token = "0x60067DE")]
			[Address(RVA = "0xB7B0E8", Offset = "0xB7B0E8", VA = "0xB7B0E8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x060067DF RID: 26591 RVA: 0x0002F088 File Offset: 0x0002D288
		[Token(Token = "0x17000B0E")]
		internal bool IsActive
		{
			[Token(Token = "0x60067DF")]
			[Address(RVA = "0xB7B0FC", Offset = "0xB7B0FC", VA = "0xB7B0FC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x060067E0 RID: 26592 RVA: 0x0002F0A0 File Offset: 0x0002D2A0
		[Token(Token = "0x17000B0F")]
		internal uint Index
		{
			[Token(Token = "0x60067E0")]
			[Address(RVA = "0xB7B17C", Offset = "0xB7B17C", VA = "0xB7B17C")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x060067E1 RID: 26593 RVA: 0x0002F0B8 File Offset: 0x0002D2B8
		[Token(Token = "0x17000B10")]
		internal uint Key
		{
			[Token(Token = "0x60067E1")]
			[Address(RVA = "0xB7B184", Offset = "0xB7B184", VA = "0xB7B184")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x060067E2 RID: 26594 RVA: 0x0002F0D0 File Offset: 0x0002D2D0
		[Token(Token = "0x60067E2")]
		[Address(RVA = "0xB7B198", Offset = "0xB7B198", VA = "0xB7B198")]
		internal SlotId ToInactive(uint freeHead)
		{
			return default(SlotId);
		}

		// Token: 0x060067E3 RID: 26595 RVA: 0x0002F0E8 File Offset: 0x0002D2E8
		[Token(Token = "0x60067E3")]
		[Address(RVA = "0xB7B20C", Offset = "0xB7B20C", VA = "0xB7B20C")]
		internal SlotId ToActive(uint index)
		{
			return default(SlotId);
		}

		// Token: 0x060067E4 RID: 26596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067E4")]
		[Address(RVA = "0xB7B288", Offset = "0xB7B288", VA = "0xB7B288")]
		public SlotId(uint value)
		{
		}

		// Token: 0x060067E5 RID: 26597 RVA: 0x0002F100 File Offset: 0x0002D300
		[Token(Token = "0x60067E5")]
		[Address(RVA = "0xB7B290", Offset = "0xB7B290", VA = "0xB7B290", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060067E6 RID: 26598 RVA: 0x0002F118 File Offset: 0x0002D318
		[Token(Token = "0x60067E6")]
		[Address(RVA = "0xB7B314", Offset = "0xB7B314", VA = "0xB7B314", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060067E7 RID: 26599 RVA: 0x0002F130 File Offset: 0x0002D330
		[Token(Token = "0x60067E7")]
		[Address(RVA = "0xB7B338", Offset = "0xB7B338", VA = "0xB7B338")]
		public static bool operator ==(SlotId lhs, SlotId rhs)
		{
			return default(bool);
		}

		// Token: 0x060067E8 RID: 26600 RVA: 0x0002F148 File Offset: 0x0002D348
		[Token(Token = "0x60067E8")]
		[Address(RVA = "0xB7B348", Offset = "0xB7B348", VA = "0xB7B348")]
		public static bool operator !=(SlotId lhs, SlotId rhs)
		{
			return default(bool);
		}

		// Token: 0x060067E9 RID: 26601 RVA: 0x0002F160 File Offset: 0x0002D360
		[Token(Token = "0x60067E9")]
		[Address(RVA = "0xB7B354", Offset = "0xB7B354", VA = "0xB7B354")]
		public float ToFloat()
		{
			return 0f;
		}

		// Token: 0x060067EA RID: 26602 RVA: 0x0002F178 File Offset: 0x0002D378
		[Token(Token = "0x60067EA")]
		[Address(RVA = "0xB7B35C", Offset = "0xB7B35C", VA = "0xB7B35C")]
		public static SlotId FromFloat(float value)
		{
			return default(SlotId);
		}

		// Token: 0x0400A4B9 RID: 42169
		[Token(Token = "0x400A4B9")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SlotId Invalid;

		// Token: 0x0400A4BA RID: 42170
		[Token(Token = "0x400A4BA")]
		private const uint KEY_INC = 65536U;

		// Token: 0x0400A4BB RID: 42171
		[Token(Token = "0x400A4BB")]
		private const uint INDEX_MASK = 65535U;

		// Token: 0x0400A4BC RID: 42172
		[Token(Token = "0x400A4BC")]
		private const uint ACTIVE_MASK = 2147483648U;

		// Token: 0x0400A4BD RID: 42173
		[Token(Token = "0x400A4BD")]
		private const uint KEY_MASK = 2147418112U;

		// Token: 0x0400A4BE RID: 42174
		[Token(Token = "0x400A4BE")]
		[FieldOffset(Offset = "0x0")]
		public readonly uint Value;
	}
}
