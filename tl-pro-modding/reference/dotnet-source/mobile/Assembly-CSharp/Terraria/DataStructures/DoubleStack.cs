using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x02000750 RID: 1872
	[Token(Token = "0x2000750")]
	public class DoubleStack<T1>
	{
		// Token: 0x060042A8 RID: 17064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042A8")]
		public DoubleStack(int segmentSize = 1024, int initialSize = 0)
		{
		}

		// Token: 0x060042A9 RID: 17065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042A9")]
		public void PushFront(T1 front)
		{
		}

		// Token: 0x060042AA RID: 17066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042AA")]
		public T1 PopFront()
		{
			return null;
		}

		// Token: 0x060042AB RID: 17067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042AB")]
		public T1 PeekFront()
		{
			return null;
		}

		// Token: 0x060042AC RID: 17068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042AC")]
		public void PushBack(T1 back)
		{
		}

		// Token: 0x060042AD RID: 17069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042AD")]
		public T1 PopBack()
		{
			return null;
		}

		// Token: 0x060042AE RID: 17070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042AE")]
		public T1 PeekBack()
		{
			return null;
		}

		// Token: 0x060042AF RID: 17071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042AF")]
		public void Clear(bool quickClear = false)
		{
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x060042B0 RID: 17072 RVA: 0x00020478 File Offset: 0x0001E678
		[Token(Token = "0x1700081F")]
		public int Count
		{
			[Token(Token = "0x60042B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04008A2A RID: 35370
		[Token(Token = "0x4008A2A")]
		[FieldOffset(Offset = "0x0")]
		private T1[][] _segmentList;

		// Token: 0x04008A2B RID: 35371
		[Token(Token = "0x4008A2B")]
		[FieldOffset(Offset = "0x0")]
		private readonly int _segmentSize;

		// Token: 0x04008A2C RID: 35372
		[Token(Token = "0x4008A2C")]
		[FieldOffset(Offset = "0x0")]
		private int _segmentCount;

		// Token: 0x04008A2D RID: 35373
		[Token(Token = "0x4008A2D")]
		[FieldOffset(Offset = "0x0")]
		private readonly int _segmentShiftPosition;

		// Token: 0x04008A2E RID: 35374
		[Token(Token = "0x4008A2E")]
		[FieldOffset(Offset = "0x0")]
		private int _start;

		// Token: 0x04008A2F RID: 35375
		[Token(Token = "0x4008A2F")]
		[FieldOffset(Offset = "0x0")]
		private int _end;

		// Token: 0x04008A30 RID: 35376
		[Token(Token = "0x4008A30")]
		[FieldOffset(Offset = "0x0")]
		private int _size;

		// Token: 0x04008A31 RID: 35377
		[Token(Token = "0x4008A31")]
		[FieldOffset(Offset = "0x0")]
		private int _last;
	}
}
