using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Telepathy
{
	// Token: 0x02000382 RID: 898
	[Token(Token = "0x2000382")]
	public class SafeQueue<T>
	{
		// Token: 0x1700021D RID: 541
		// (get) Token: 0x0600162D RID: 5677 RVA: 0x00009D98 File Offset: 0x00007F98
		[Token(Token = "0x1700021D")]
		public int Count
		{
			[Token(Token = "0x600162D")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600162E")]
		public void Enqueue(T item)
		{
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x00009DB0 File Offset: 0x00007FB0
		[Token(Token = "0x600162F")]
		public bool TryDequeue(out T result)
		{
			return default(bool);
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x00009DC8 File Offset: 0x00007FC8
		[Token(Token = "0x6001630")]
		public bool TryDequeueAll(out T[] result)
		{
			return default(bool);
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001631")]
		public void Clear()
		{
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001632")]
		public SafeQueue()
		{
		}

		// Token: 0x04002AA4 RID: 10916
		[Token(Token = "0x4002AA4")]
		[FieldOffset(Offset = "0x0")]
		private Queue<T> queue;
	}
}
