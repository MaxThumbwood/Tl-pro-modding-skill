using System;
using System.Collections.Concurrent;
using System.IO;
using System.Threading;
using Il2CppDummyDll;

namespace Telepathy
{
	// Token: 0x0200037E RID: 894
	[Token(Token = "0x200037E")]
	public abstract class Common
	{
		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06001624 RID: 5668 RVA: 0x00009D38 File Offset: 0x00007F38
		[Token(Token = "0x1700021C")]
		public int ReceiveQueueCount
		{
			[Token(Token = "0x6001624")]
			[Address(RVA = "0xE0A84C", Offset = "0xE0A84C", VA = "0xE0A84C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x00009D50 File Offset: 0x00007F50
		[Token(Token = "0x6001625")]
		[Address(RVA = "0xE0A8B0", Offset = "0xE0A8B0", VA = "0xE0A8B0")]
		public bool GetNextMessage(out Message message)
		{
			return default(bool);
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x00009D68 File Offset: 0x00007F68
		[Token(Token = "0x6001626")]
		[Address(RVA = "0xE0A91C", Offset = "0xE0A91C", VA = "0xE0A91C")]
		protected static bool SendMessagesBlocking(Stream stream, byte[][] messages)
		{
			return default(bool);
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x00009D80 File Offset: 0x00007F80
		[Token(Token = "0x6001627")]
		[Address(RVA = "0xE0AC28", Offset = "0xE0AC28", VA = "0xE0AC28")]
		protected static bool ReadMessageBlocking(Stream stream, int MaxMessageSize, out byte[] content)
		{
			return default(bool);
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001628")]
		[Address(RVA = "0xE099A8", Offset = "0xE099A8", VA = "0xE099A8")]
		protected static void ReceiveLoop(int connectionId, NetworkClientHolder client, ConcurrentQueue<Message> receiveQueue, int MaxMessageSize)
		{
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001629")]
		[Address(RVA = "0xE0A484", Offset = "0xE0A484", VA = "0xE0A484")]
		protected static void SendLoop(int connectionId, NetworkClientHolder client, SafeQueue<byte[]> sendQueue, ManualResetEvent sendPending)
		{
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600162A")]
		[Address(RVA = "0xE0A348", Offset = "0xE0A348", VA = "0xE0A348")]
		protected Common()
		{
		}

		// Token: 0x04002A96 RID: 10902
		[Token(Token = "0x4002A96")]
		[FieldOffset(Offset = "0x8")]
		protected ConcurrentQueue<Message> receiveQueue;

		// Token: 0x04002A97 RID: 10903
		[Token(Token = "0x4002A97")]
		[FieldOffset(Offset = "0x0")]
		public static int messageQueueSizeWarning;

		// Token: 0x04002A98 RID: 10904
		[Token(Token = "0x4002A98")]
		[FieldOffset(Offset = "0xC")]
		public bool NoDelay;

		// Token: 0x04002A99 RID: 10905
		[Token(Token = "0x4002A99")]
		public const int MaxMessageSize = 65535;

		// Token: 0x04002A9A RID: 10906
		[Token(Token = "0x4002A9A")]
		[FieldOffset(Offset = "0x10")]
		public int SendTimeout;

		// Token: 0x04002A9B RID: 10907
		[Token(Token = "0x4002A9B")]
		private static byte[] header;

		// Token: 0x04002A9C RID: 10908
		[Token(Token = "0x4002A9C")]
		private static byte[] payload;
	}
}
