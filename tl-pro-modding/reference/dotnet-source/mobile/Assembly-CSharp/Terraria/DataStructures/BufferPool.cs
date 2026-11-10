using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x0200074D RID: 1869
	[Token(Token = "0x200074D")]
	public static class BufferPool
	{
		// Token: 0x06004298 RID: 17048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004298")]
		[Address(RVA = "0x4F7660", Offset = "0x4F7660", VA = "0x4F7660")]
		public static CachedBuffer Request(int size)
		{
			return null;
		}

		// Token: 0x06004299 RID: 17049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004299")]
		[Address(RVA = "0x4F7E7C", Offset = "0x4F7E7C", VA = "0x4F7E7C")]
		public static CachedBuffer Request(byte[] data, int offset, int size)
		{
			return null;
		}

		// Token: 0x0600429A RID: 17050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600429A")]
		[Address(RVA = "0x4F7F24", Offset = "0x4F7F24", VA = "0x4F7F24")]
		public static void Recycle(CachedBuffer buffer)
		{
		}

		// Token: 0x0600429B RID: 17051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600429B")]
		[Address(RVA = "0x4F8200", Offset = "0x4F8200", VA = "0x4F8200")]
		public static void PrintBufferSizes()
		{
		}

		// Token: 0x04008A18 RID: 35352
		[Token(Token = "0x4008A18")]
		private const int SMALL_BUFFER_SIZE = 32;

		// Token: 0x04008A19 RID: 35353
		[Token(Token = "0x4008A19")]
		private const int MEDIUM_BUFFER_SIZE = 256;

		// Token: 0x04008A1A RID: 35354
		[Token(Token = "0x4008A1A")]
		private const int LARGE_BUFFER_SIZE = 16384;

		// Token: 0x04008A1B RID: 35355
		[Token(Token = "0x4008A1B")]
		private const int HUGE_BUFFER_SIZE = 65536;

		// Token: 0x04008A1C RID: 35356
		[Token(Token = "0x4008A1C")]
		[FieldOffset(Offset = "0x0")]
		private static object bufferLock;

		// Token: 0x04008A1D RID: 35357
		[Token(Token = "0x4008A1D")]
		[FieldOffset(Offset = "0x4")]
		private static Queue<CachedBuffer> SmallBufferQueue;

		// Token: 0x04008A1E RID: 35358
		[Token(Token = "0x4008A1E")]
		[FieldOffset(Offset = "0x8")]
		private static Queue<CachedBuffer> MediumBufferQueue;

		// Token: 0x04008A1F RID: 35359
		[Token(Token = "0x4008A1F")]
		[FieldOffset(Offset = "0xC")]
		private static Queue<CachedBuffer> LargeBufferQueue;

		// Token: 0x04008A20 RID: 35360
		[Token(Token = "0x4008A20")]
		[FieldOffset(Offset = "0x10")]
		private static Queue<CachedBuffer> HugeBufferQueue;
	}
}
