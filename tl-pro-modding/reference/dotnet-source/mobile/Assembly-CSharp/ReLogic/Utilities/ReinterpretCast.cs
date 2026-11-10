using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace ReLogic.Utilities
{
	// Token: 0x02000DD1 RID: 3537
	[Token(Token = "0x2000DD1")]
	public static class ReinterpretCast
	{
		// Token: 0x060067D6 RID: 26582 RVA: 0x0002F010 File Offset: 0x0002D210
		[Token(Token = "0x60067D6")]
		[Address(RVA = "0xB7B0B8", Offset = "0xB7B0B8", VA = "0xB7B0B8")]
		public static float UIntAsFloat(uint value)
		{
			return 0f;
		}

		// Token: 0x060067D7 RID: 26583 RVA: 0x0002F028 File Offset: 0x0002D228
		[Token(Token = "0x60067D7")]
		[Address(RVA = "0xB7B0C4", Offset = "0xB7B0C4", VA = "0xB7B0C4")]
		public static float IntAsFloat(int value)
		{
			return 0f;
		}

		// Token: 0x060067D8 RID: 26584 RVA: 0x0002F040 File Offset: 0x0002D240
		[Token(Token = "0x60067D8")]
		[Address(RVA = "0xB7B0D0", Offset = "0xB7B0D0", VA = "0xB7B0D0")]
		public static uint FloatAsUInt(float value)
		{
			return 0U;
		}

		// Token: 0x060067D9 RID: 26585 RVA: 0x0002F058 File Offset: 0x0002D258
		[Token(Token = "0x60067D9")]
		[Address(RVA = "0xB7B0DC", Offset = "0xB7B0DC", VA = "0xB7B0DC")]
		public static int FloatAsInt(float value)
		{
			return 0;
		}

		// Token: 0x02000DD2 RID: 3538
		[Token(Token = "0x2000DD2")]
		[StructLayout(2)]
		private struct IntFloat
		{
			// Token: 0x060067DA RID: 26586 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067DA")]
			[Address(RVA = "0xB7B0C8", Offset = "0xB7B0C8", VA = "0xB7B0C8")]
			public IntFloat(int value)
			{
			}

			// Token: 0x060067DB RID: 26587 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067DB")]
			[Address(RVA = "0xB7B0E0", Offset = "0xB7B0E0", VA = "0xB7B0E0")]
			public IntFloat(float value)
			{
			}

			// Token: 0x0400A4B5 RID: 42165
			[Token(Token = "0x400A4B5")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public readonly int IntValue;

			// Token: 0x0400A4B6 RID: 42166
			[Token(Token = "0x400A4B6")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public readonly float FloatValue;
		}

		// Token: 0x02000DD3 RID: 3539
		[Token(Token = "0x2000DD3")]
		[StructLayout(2)]
		private struct UIntFloat
		{
			// Token: 0x060067DC RID: 26588 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067DC")]
			[Address(RVA = "0xB7B0BC", Offset = "0xB7B0BC", VA = "0xB7B0BC")]
			public UIntFloat(uint value)
			{
			}

			// Token: 0x060067DD RID: 26589 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067DD")]
			[Address(RVA = "0xB7B0D4", Offset = "0xB7B0D4", VA = "0xB7B0D4")]
			public UIntFloat(float value)
			{
			}

			// Token: 0x0400A4B7 RID: 42167
			[Token(Token = "0x400A4B7")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public readonly uint UIntValue;

			// Token: 0x0400A4B8 RID: 42168
			[Token(Token = "0x400A4B8")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public readonly float FloatValue;
		}
	}
}
