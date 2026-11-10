using System;
using System.Collections.Concurrent;
using System.Threading;
using Il2CppDummyDll;

namespace ReLogic.Threading
{
	// Token: 0x02000DDB RID: 3547
	[Token(Token = "0x2000DDB")]
	public class AsyncActionDispatcher : FileAPI
	{
		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x06006857 RID: 26711 RVA: 0x0002F700 File Offset: 0x0002D900
		[Token(Token = "0x17000B1C")]
		public int ActionsRemaining
		{
			[Token(Token = "0x6006857")]
			[Address(RVA = "0xB7D5F4", Offset = "0xB7D5F4", VA = "0xB7D5F4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x06006858 RID: 26712 RVA: 0x0002F718 File Offset: 0x0002D918
		// (set) Token: 0x06006859 RID: 26713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B1D")]
		public bool IsDisposed
		{
			[Token(Token = "0x6006858")]
			[Address(RVA = "0xB7D658", Offset = "0xB7D658", VA = "0xB7D658")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006859")]
			[Address(RVA = "0xB7D660", Offset = "0xB7D660", VA = "0xB7D660")]
			private set
			{
			}
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x0600685A RID: 26714 RVA: 0x0002F730 File Offset: 0x0002D930
		[Token(Token = "0x17000B1E")]
		public bool IsRunning
		{
			[Token(Token = "0x600685A")]
			[Address(RVA = "0xB7D668", Offset = "0xB7D668", VA = "0xB7D668")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600685B RID: 26715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600685B")]
		[Address(RVA = "0xB7D67C", Offset = "0xB7D67C", VA = "0xB7D67C")]
		public void Queue(Action action)
		{
		}

		// Token: 0x0600685C RID: 26716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600685C")]
		[Address(RVA = "0xB7D6E8", Offset = "0xB7D6E8", VA = "0xB7D6E8")]
		public void Start()
		{
		}

		// Token: 0x0600685D RID: 26717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600685D")]
		[Address(RVA = "0xB7D8B8", Offset = "0xB7D8B8", VA = "0xB7D8B8")]
		public void Stop()
		{
		}

		// Token: 0x0600685E RID: 26718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600685E")]
		[Address(RVA = "0xB7D974", Offset = "0xB7D974", VA = "0xB7D974")]
		private void LoaderThreadStart()
		{
		}

		// Token: 0x0600685F RID: 26719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600685F")]
		[Address(RVA = "0xB7DABC", Offset = "0xB7DABC", VA = "0xB7DABC", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06006860 RID: 26720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006860")]
		[Address(RVA = "0xB7DB70", Offset = "0xB7DB70", VA = "0xB7DB70", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06006861 RID: 26721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006861")]
		[Address(RVA = "0xB7DB84", Offset = "0xB7DB84", VA = "0xB7DB84")]
		public AsyncActionDispatcher()
		{
		}

		// Token: 0x0400A4D1 RID: 42193
		[Token(Token = "0x400A4D1")]
		[FieldOffset(Offset = "0x8")]
		private Thread _actionThread;

		// Token: 0x0400A4D2 RID: 42194
		[Token(Token = "0x400A4D2")]
		[FieldOffset(Offset = "0xC")]
		private readonly BlockingCollection<Action> _actionQueue;

		// Token: 0x0400A4D3 RID: 42195
		[Token(Token = "0x400A4D3")]
		[FieldOffset(Offset = "0x10")]
		private readonly CancellationTokenSource _threadCancellation;

		// Token: 0x0400A4D4 RID: 42196
		[Token(Token = "0x400A4D4")]
		[FieldOffset(Offset = "0x14")]
		private bool _isRunning;

		// Token: 0x0400A4D5 RID: 42197
		[Token(Token = "0x400A4D5")]
		[FieldOffset(Offset = "0x15")]
		private bool <IsDisposed>k__BackingField;
	}
}
