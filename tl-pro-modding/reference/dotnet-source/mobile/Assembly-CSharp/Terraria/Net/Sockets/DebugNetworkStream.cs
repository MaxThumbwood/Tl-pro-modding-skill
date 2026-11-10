using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using Il2CppDummyDll;

namespace Terraria.Net.Sockets
{
	// Token: 0x020007FE RID: 2046
	[Token(Token = "0x20007FE")]
	public class DebugNetworkStream
	{
		// Token: 0x06004629 RID: 17961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004629")]
		[Address(RVA = "0x58C118", Offset = "0x58C118", VA = "0x58C118")]
		public DebugNetworkStream(NetworkStream stream)
		{
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x0600462A RID: 17962 RVA: 0x00021468 File Offset: 0x0001F668
		[Token(Token = "0x17000867")]
		public bool DataAvailable
		{
			[Token(Token = "0x600462A")]
			[Address(RVA = "0x58C21C", Offset = "0x58C21C", VA = "0x58C21C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x0600462B RID: 17963 RVA: 0x00021480 File Offset: 0x0001F680
		[Token(Token = "0x17000868")]
		public bool HasBufferedData
		{
			[Token(Token = "0x600462B")]
			[Address(RVA = "0x58C504", Offset = "0x58C504", VA = "0x58C504")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600462C RID: 17964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600462C")]
		[Address(RVA = "0x58C64C", Offset = "0x58C64C", VA = "0x58C64C")]
		public void BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
		}

		// Token: 0x0600462D RID: 17965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600462D")]
		[Address(RVA = "0x58CACC", Offset = "0x58CACC", VA = "0x58CACC")]
		public void EndWrite(IAsyncResult result)
		{
		}

		// Token: 0x0600462E RID: 17966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600462E")]
		[Address(RVA = "0x58CB78", Offset = "0x58CB78", VA = "0x58CB78")]
		public void BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
		}

		// Token: 0x0600462F RID: 17967 RVA: 0x00021498 File Offset: 0x0001F698
		[Token(Token = "0x600462F")]
		[Address(RVA = "0x58D230", Offset = "0x58D230", VA = "0x58D230")]
		public int EndRead(IAsyncResult result)
		{
			return 0;
		}

		// Token: 0x06004630 RID: 17968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004630")]
		[Address(RVA = "0x58D2E8", Offset = "0x58D2E8", VA = "0x58D2E8")]
		public void Close()
		{
		}

		// Token: 0x06004631 RID: 17969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004631")]
		[Address(RVA = "0x58D474", Offset = "0x58D474", VA = "0x58D474")]
		private void Run()
		{
		}

		// Token: 0x06004632 RID: 17970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004632")]
		[Address(RVA = "0x58D7D8", Offset = "0x58D7D8", VA = "0x58D7D8")]
		private void BeginBufferedWrite(DebugNetworkStream.Packet packet)
		{
		}

		// Token: 0x06004633 RID: 17971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004633")]
		[Address(RVA = "0x58DB5C", Offset = "0x58DB5C", VA = "0x58DB5C")]
		private void BufferedWriteCallback(IAsyncResult result)
		{
		}

		// Token: 0x06004634 RID: 17972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004634")]
		[Address(RVA = "0x58D9E4", Offset = "0x58D9E4", VA = "0x58D9E4")]
		private void BeginBufferedRead(byte[] buffer)
		{
		}

		// Token: 0x06004635 RID: 17973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004635")]
		[Address(RVA = "0x58DC18", Offset = "0x58DC18", VA = "0x58DC18")]
		private void BufferedReadCallback(IAsyncResult result)
		{
		}

		// Token: 0x04008D3C RID: 36156
		[Token(Token = "0x4008D3C")]
		[FieldOffset(Offset = "0x0")]
		public static uint Latency;

		// Token: 0x04008D3D RID: 36157
		[Token(Token = "0x4008D3D")]
		[FieldOffset(Offset = "0x8")]
		private readonly NetworkStream _stream;

		// Token: 0x04008D3E RID: 36158
		[Token(Token = "0x4008D3E")]
		[FieldOffset(Offset = "0xC")]
		private Queue<DebugNetworkStream.Packet> _outgoingQueue;

		// Token: 0x04008D3F RID: 36159
		[Token(Token = "0x4008D3F")]
		[FieldOffset(Offset = "0x10")]
		private Queue<DebugNetworkStream.Packet> _incomingQueue;

		// Token: 0x04008D40 RID: 36160
		[Token(Token = "0x4008D40")]
		[FieldOffset(Offset = "0x14")]
		private Exception _writeException;

		// Token: 0x04008D41 RID: 36161
		[Token(Token = "0x4008D41")]
		[FieldOffset(Offset = "0x18")]
		private Exception _readException;

		// Token: 0x04008D42 RID: 36162
		[Token(Token = "0x4008D42")]
		[FieldOffset(Offset = "0x1C")]
		private DebugNetworkStream.ReadMode _readMode;

		// Token: 0x04008D43 RID: 36163
		[Token(Token = "0x4008D43")]
		[FieldOffset(Offset = "0x20")]
		private bool _closed;

		// Token: 0x04008D44 RID: 36164
		[Token(Token = "0x4008D44")]
		[FieldOffset(Offset = "0x28")]
		private long _startTicks;

		// Token: 0x04008D45 RID: 36165
		[Token(Token = "0x4008D45")]
		[FieldOffset(Offset = "0x30")]
		private BinaryWriter _logWriter;

		// Token: 0x04008D46 RID: 36166
		[Token(Token = "0x4008D46")]
		[FieldOffset(Offset = "0x34")]
		private ArraySegment<byte> _beginReadBuf;

		// Token: 0x020007FF RID: 2047
		[Token(Token = "0x20007FF")]
		private class Packet
		{
			// Token: 0x06004636 RID: 17974 RVA: 0x000214B0 File Offset: 0x0001F6B0
			[Token(Token = "0x6004636")]
			[Address(RVA = "0x58C3D8", Offset = "0x58C3D8", VA = "0x58C3D8")]
			public bool IsReady()
			{
				return default(bool);
			}

			// Token: 0x06004637 RID: 17975 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004637")]
			[Address(RVA = "0x58C94C", Offset = "0x58C94C", VA = "0x58C94C")]
			public static DebugNetworkStream.Packet CopyOfSlice(byte[] buffer, int offset, int count)
			{
				return null;
			}

			// Token: 0x06004638 RID: 17976 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004638")]
			[Address(RVA = "0x58DF40", Offset = "0x58DF40", VA = "0x58DF40")]
			public Packet()
			{
			}

			// Token: 0x04008D47 RID: 36167
			[Token(Token = "0x4008D47")]
			[FieldOffset(Offset = "0x8")]
			public DateTime BaseTimestamp;

			// Token: 0x04008D48 RID: 36168
			[Token(Token = "0x4008D48")]
			[FieldOffset(Offset = "0x10")]
			public ArraySegment<byte> Data;
		}

		// Token: 0x02000800 RID: 2048
		[Token(Token = "0x2000800")]
		private class CompletedAsyncResult : FileAPI
		{
			// Token: 0x17000869 RID: 2153
			// (get) Token: 0x06004639 RID: 17977 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600463A RID: 17978 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000869")]
			public object AsyncState
			{
				[Token(Token = "0x6004639")]
				[Address(RVA = "0x58DF48", Offset = "0x58DF48", VA = "0x58DF48", Slot = "6")]
				get
				{
					return null;
				}
				[Token(Token = "0x600463A")]
				[Address(RVA = "0x58DF50", Offset = "0x58DF50", VA = "0x58DF50")]
				set
				{
				}
			}

			// Token: 0x1700086A RID: 2154
			// (get) Token: 0x0600463B RID: 17979 RVA: 0x000214C8 File Offset: 0x0001F6C8
			// (set) Token: 0x0600463C RID: 17980 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700086A")]
			public int Read
			{
				[Token(Token = "0x600463B")]
				[Address(RVA = "0x58DF58", Offset = "0x58DF58", VA = "0x58DF58")]
				get
				{
					return 0;
				}
				[Token(Token = "0x600463C")]
				[Address(RVA = "0x58DF60", Offset = "0x58DF60", VA = "0x58DF60")]
				set
				{
				}
			}

			// Token: 0x1700086B RID: 2155
			// (get) Token: 0x0600463D RID: 17981 RVA: 0x000214E0 File Offset: 0x0001F6E0
			[Token(Token = "0x1700086B")]
			public bool IsCompleted
			{
				[Token(Token = "0x600463D")]
				[Address(RVA = "0x58DF68", Offset = "0x58DF68", VA = "0x58DF68", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700086C RID: 2156
			// (get) Token: 0x0600463E RID: 17982 RVA: 0x000214F8 File Offset: 0x0001F6F8
			[Token(Token = "0x1700086C")]
			public bool CompletedSynchronously
			{
				[Token(Token = "0x600463E")]
				[Address(RVA = "0x58DF70", Offset = "0x58DF70", VA = "0x58DF70", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700086D RID: 2157
			// (get) Token: 0x0600463F RID: 17983 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700086D")]
			public WaitHandle AsyncWaitHandle
			{
				[Token(Token = "0x600463F")]
				[Address(RVA = "0x58DF78", Offset = "0x58DF78", VA = "0x58DF78", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x06004640 RID: 17984 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004640")]
			[Address(RVA = "0x58CAC4", Offset = "0x58CAC4", VA = "0x58CAC4")]
			public CompletedAsyncResult()
			{
			}

			// Token: 0x04008D49 RID: 36169
			[Token(Token = "0x4008D49")]
			[FieldOffset(Offset = "0x8")]
			private object <AsyncState>k__BackingField;

			// Token: 0x04008D4A RID: 36170
			[Token(Token = "0x4008D4A")]
			[FieldOffset(Offset = "0xC")]
			private int <Read>k__BackingField;
		}

		// Token: 0x02000801 RID: 2049
		[Token(Token = "0x2000801")]
		private enum ReadMode
		{
			// Token: 0x04008D4C RID: 36172
			[Token(Token = "0x4008D4C")]
			None,
			// Token: 0x04008D4D RID: 36173
			[Token(Token = "0x4008D4D")]
			Direct,
			// Token: 0x04008D4E RID: 36174
			[Token(Token = "0x4008D4E")]
			Buffered
		}
	}
}
