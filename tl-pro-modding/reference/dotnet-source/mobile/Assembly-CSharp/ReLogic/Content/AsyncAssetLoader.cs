using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ReLogic.Content
{
	// Token: 0x02000E10 RID: 3600
	[Token(Token = "0x2000E10")]
	public class AsyncAssetLoader
	{
		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x06006949 RID: 26953 RVA: 0x0002FAF0 File Offset: 0x0002DCF0
		// (set) Token: 0x0600694A RID: 26954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B44")]
		public int Remaining
		{
			[Token(Token = "0x6006949")]
			[Address(RVA = "0xB869D0", Offset = "0xB869D0", VA = "0xB869D0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600694A")]
			[Address(RVA = "0xB869D8", Offset = "0xB869D8", VA = "0xB869D8")]
			private set
			{
			}
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x0600694B RID: 26955 RVA: 0x0002FB08 File Offset: 0x0002DD08
		[Token(Token = "0x17000B45")]
		internal int AssetsReadyForTransfer
		{
			[Token(Token = "0x600694B")]
			[Address(RVA = "0xB869E0", Offset = "0xB869E0", VA = "0xB869E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600694C RID: 26956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600694C")]
		[Address(RVA = "0xB86A68", Offset = "0xB86A68", VA = "0xB86A68")]
		public AsyncAssetLoader(AssetReaderCollection readers)
		{
		}

		// Token: 0x0600694D RID: 26957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600694D")]
		[Address(RVA = "0xB86B98", Offset = "0xB86B98", VA = "0xB86B98")]
		public AsyncAssetLoader(AssetReaderCollection readers, int maxCreationsPerTransfer)
		{
		}

		// Token: 0x0600694E RID: 26958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600694E")]
		[Address(RVA = "0xB85AD0", Offset = "0xB85AD0", VA = "0xB85AD0")]
		public void TransferCompleted()
		{
		}

		// Token: 0x0400A6F2 RID: 42738
		[Token(Token = "0x400A6F2")]
		[FieldOffset(Offset = "0x8")]
		private int <Remaining>k__BackingField;

		// Token: 0x0400A6F3 RID: 42739
		[Token(Token = "0x400A6F3")]
		[FieldOffset(Offset = "0xC")]
		private readonly AssetReaderCollection _readers;

		// Token: 0x0400A6F4 RID: 42740
		[Token(Token = "0x400A6F4")]
		[FieldOffset(Offset = "0x10")]
		private readonly ConcurrentQueue<Action> _pendingCallbacks;

		// Token: 0x0400A6F5 RID: 42741
		[Token(Token = "0x400A6F5")]
		[FieldOffset(Offset = "0x14")]
		private readonly ConcurrentQueue<Action> _pendingDelayedCallbacks;

		// Token: 0x0400A6F6 RID: 42742
		[Token(Token = "0x400A6F6")]
		[FieldOffset(Offset = "0x18")]
		private readonly HashSet<Type> _delayedLoadTypes;

		// Token: 0x0400A6F7 RID: 42743
		[Token(Token = "0x400A6F7")]
		[FieldOffset(Offset = "0x1C")]
		private readonly int _maxCreationsPerTransfer;
	}
}
