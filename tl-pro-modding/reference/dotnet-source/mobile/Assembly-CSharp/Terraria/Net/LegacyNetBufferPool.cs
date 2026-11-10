using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.Net
{
	// Token: 0x020007F1 RID: 2033
	[Token(Token = "0x20007F1")]
	public class LegacyNetBufferPool
	{
		// Token: 0x060045F6 RID: 17910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045F6")]
		[Address(RVA = "0x58940C", Offset = "0x58940C", VA = "0x58940C")]
		public static byte[] RequestBuffer(int size)
		{
			return null;
		}

		// Token: 0x060045F7 RID: 17911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045F7")]
		[Address(RVA = "0x589844", Offset = "0x589844", VA = "0x589844")]
		public static byte[] RequestBuffer(byte[] data, int offset, int size)
		{
			return null;
		}

		// Token: 0x060045F8 RID: 17912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045F8")]
		[Address(RVA = "0x5898E0", Offset = "0x5898E0", VA = "0x5898E0")]
		public static void ReturnBuffer(byte[] buffer)
		{
		}

		// Token: 0x060045F9 RID: 17913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045F9")]
		[Address(RVA = "0x589B2C", Offset = "0x589B2C", VA = "0x589B2C")]
		public static void DisplayBufferSizes()
		{
		}

		// Token: 0x060045FA RID: 17914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045FA")]
		[Address(RVA = "0x589F14", Offset = "0x589F14", VA = "0x589F14")]
		public static void PrintBufferSizes()
		{
		}

		// Token: 0x060045FB RID: 17915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045FB")]
		[Address(RVA = "0x58A2D8", Offset = "0x58A2D8", VA = "0x58A2D8")]
		public LegacyNetBufferPool()
		{
		}

		// Token: 0x04008D17 RID: 36119
		[Token(Token = "0x4008D17")]
		private const int SMALL_BUFFER_SIZE = 256;

		// Token: 0x04008D18 RID: 36120
		[Token(Token = "0x4008D18")]
		private const int MEDIUM_BUFFER_SIZE = 1024;

		// Token: 0x04008D19 RID: 36121
		[Token(Token = "0x4008D19")]
		private const int LARGE_BUFFER_SIZE = 16384;

		// Token: 0x04008D1A RID: 36122
		[Token(Token = "0x4008D1A")]
		[FieldOffset(Offset = "0x0")]
		private static object bufferLock;

		// Token: 0x04008D1B RID: 36123
		[Token(Token = "0x4008D1B")]
		[FieldOffset(Offset = "0x4")]
		private static Queue<byte[]> _smallBufferQueue;

		// Token: 0x04008D1C RID: 36124
		[Token(Token = "0x4008D1C")]
		[FieldOffset(Offset = "0x8")]
		private static Queue<byte[]> _mediumBufferQueue;

		// Token: 0x04008D1D RID: 36125
		[Token(Token = "0x4008D1D")]
		[FieldOffset(Offset = "0xC")]
		private static Queue<byte[]> _largeBufferQueue;

		// Token: 0x04008D1E RID: 36126
		[Token(Token = "0x4008D1E")]
		[FieldOffset(Offset = "0x10")]
		private static int _smallBufferCount;

		// Token: 0x04008D1F RID: 36127
		[Token(Token = "0x4008D1F")]
		[FieldOffset(Offset = "0x14")]
		private static int _mediumBufferCount;

		// Token: 0x04008D20 RID: 36128
		[Token(Token = "0x4008D20")]
		[FieldOffset(Offset = "0x18")]
		private static int _largeBufferCount;

		// Token: 0x04008D21 RID: 36129
		[Token(Token = "0x4008D21")]
		[FieldOffset(Offset = "0x1C")]
		private static int _customBufferCount;
	}
}
