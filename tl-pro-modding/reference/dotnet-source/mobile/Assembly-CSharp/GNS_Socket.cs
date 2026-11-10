using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Il2CppDummyDll;
using Terraria.Net.Sockets;

// Token: 0x02000300 RID: 768
[Token(Token = "0x2000300")]
public class GNS_Socket
{
	// Token: 0x0600131B RID: 4891 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600131B")]
	[Address(RVA = "0xD95B5C", Offset = "0xD95B5C", VA = "0xD95B5C")]
	public GNS_Socket()
	{
	}

	// Token: 0x0600131C RID: 4892 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600131C")]
	[Address(RVA = "0xD94AF4", Offset = "0xD94AF4", VA = "0xD94AF4")]
	public GNS_Socket(AddressFamily addressFamily, SocketType stream, ProtocolType protocol)
	{
	}

	// Token: 0x170001CF RID: 463
	// (get) Token: 0x0600131D RID: 4893 RVA: 0x00008BC8 File Offset: 0x00006DC8
	// (set) Token: 0x0600131E RID: 4894 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001CF")]
	public int Id
	{
		[Token(Token = "0x600131D")]
		[Address(RVA = "0xD99298", Offset = "0xD99298", VA = "0xD99298")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600131E")]
		[Address(RVA = "0xD992A0", Offset = "0xD992A0", VA = "0xD992A0")]
		private set
		{
		}
	}

	// Token: 0x170001D0 RID: 464
	// (get) Token: 0x0600131F RID: 4895 RVA: 0x00008BE0 File Offset: 0x00006DE0
	// (set) Token: 0x06001320 RID: 4896 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001D0")]
	public bool Connected
	{
		[Token(Token = "0x600131F")]
		[Address(RVA = "0xD992A8", Offset = "0xD992A8", VA = "0xD992A8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001320")]
		[Address(RVA = "0xD992B0", Offset = "0xD992B0", VA = "0xD992B0")]
		private set
		{
		}
	}

	// Token: 0x170001D1 RID: 465
	// (get) Token: 0x06001321 RID: 4897 RVA: 0x00008BF8 File Offset: 0x00006DF8
	[Token(Token = "0x170001D1")]
	public bool IsDataAvailable
	{
		[Token(Token = "0x6001321")]
		[Address(RVA = "0xD97F34", Offset = "0xD97F34", VA = "0xD97F34")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001D2 RID: 466
	// (get) Token: 0x06001322 RID: 4898 RVA: 0x00008C10 File Offset: 0x00006E10
	[Token(Token = "0x170001D2")]
	public int Available
	{
		[Token(Token = "0x6001322")]
		[Address(RVA = "0xD992B8", Offset = "0xD992B8", VA = "0xD992B8")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06001323 RID: 4899 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001323")]
	[Address(RVA = "0xD94630", Offset = "0xD94630", VA = "0xD94630")]
	public void Close()
	{
	}

	// Token: 0x06001324 RID: 4900 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001324")]
	[Address(RVA = "0xD992C0", Offset = "0xD992C0", VA = "0xD992C0")]
	private void SetupBuffers()
	{
	}

	// Token: 0x06001325 RID: 4901 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001325")]
	[Address(RVA = "0xD99374", Offset = "0xD99374", VA = "0xD99374")]
	private static void StartSocketUpdate()
	{
	}

	// Token: 0x06001326 RID: 4902 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001326")]
	[Address(RVA = "0xD95130", Offset = "0xD95130", VA = "0xD95130")]
	public void Connect(IPAddress address, int port)
	{
	}

	// Token: 0x06001327 RID: 4903 RVA: 0x00008C28 File Offset: 0x00006E28
	[Token(Token = "0x6001327")]
	[Address(RVA = "0xD98C90", Offset = "0xD98C90", VA = "0xD98C90")]
	public int Send(byte[] buffer, int offset, int size)
	{
		return 0;
	}

	// Token: 0x06001328 RID: 4904 RVA: 0x00008C40 File Offset: 0x00006E40
	[Token(Token = "0x6001328")]
	[Address(RVA = "0xD98698", Offset = "0xD98698", VA = "0xD98698")]
	public int Receive(byte[] buffer, int offset, int size)
	{
		return 0;
	}

	// Token: 0x06001329 RID: 4905 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001329")]
	[Address(RVA = "0xD96914", Offset = "0xD96914", VA = "0xD96914")]
	public GNS_Socket Accept()
	{
		return null;
	}

	// Token: 0x0600132A RID: 4906 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600132A")]
	[Address(RVA = "0xD96490", Offset = "0xD96490", VA = "0xD96490")]
	public void StartListening(IPEndPoint endPoint)
	{
	}

	// Token: 0x0600132B RID: 4907 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600132B")]
	[Address(RVA = "0xD966A0", Offset = "0xD966A0", VA = "0xD966A0")]
	public void StopListening()
	{
	}

	// Token: 0x0600132C RID: 4908 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600132C")]
	[Address(RVA = "0xD96CC0", Offset = "0xD96CC0", VA = "0xD96CC0")]
	public static void Update()
	{
	}

	// Token: 0x0600132D RID: 4909 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600132D")]
	[Address(RVA = "0xD99378", Offset = "0xD99378", VA = "0xD99378")]
	private static void ProcessConnectionEvent(uint connectionEvent, uint connectionHandle)
	{
	}

	// Token: 0x0400252F RID: 9519
	[Token(Token = "0x400252F")]
	private const int Num1kBuffers = 512;

	// Token: 0x04002530 RID: 9520
	[Token(Token = "0x4002530")]
	private const int NumTransmitBuffers = 512;

	// Token: 0x04002531 RID: 9521
	[Token(Token = "0x4002531")]
	[FieldOffset(Offset = "0x8")]
	private BlockingCollection<GNS_Socket.DataEntry> Data;

	// Token: 0x04002532 RID: 9522
	[Token(Token = "0x4002532")]
	[FieldOffset(Offset = "0xC")]
	private BlockingCollection<GNS_Socket.DataEntry> AvailableBuffers;

	// Token: 0x04002533 RID: 9523
	[Token(Token = "0x4002533")]
	private const int TransportBufferSize = 65536;

	// Token: 0x04002534 RID: 9524
	[Token(Token = "0x4002534")]
	[FieldOffset(Offset = "0x0")]
	private static readonly byte[] TransportBuffer;

	// Token: 0x04002535 RID: 9525
	[Token(Token = "0x4002535")]
	[FieldOffset(Offset = "0x4")]
	private static GNS_Socket ListenSocket;

	// Token: 0x04002536 RID: 9526
	[Token(Token = "0x4002536")]
	private const int MaximumReceiveBufferSize = 524288;

	// Token: 0x04002537 RID: 9527
	[Token(Token = "0x4002537")]
	[FieldOffset(Offset = "0x10")]
	private int <Id>k__BackingField;

	// Token: 0x04002538 RID: 9528
	[Token(Token = "0x4002538")]
	[FieldOffset(Offset = "0x14")]
	private bool <Connected>k__BackingField;

	// Token: 0x04002539 RID: 9529
	[Token(Token = "0x4002539")]
	[FieldOffset(Offset = "0x18")]
	private byte[] ReceiveBuffer;

	// Token: 0x0400253A RID: 9530
	[Token(Token = "0x400253A")]
	[FieldOffset(Offset = "0x1C")]
	private int ReceiveBufferSize;

	// Token: 0x0400253B RID: 9531
	[Token(Token = "0x400253B")]
	[FieldOffset(Offset = "0x20")]
	private Action<ISocket> OnConnection;

	// Token: 0x0400253C RID: 9532
	[Token(Token = "0x400253C")]
	[FieldOffset(Offset = "0x24")]
	private uint ConnectionHandle;

	// Token: 0x0400253D RID: 9533
	[Token(Token = "0x400253D")]
	[FieldOffset(Offset = "0x28")]
	private uint ListenPortHandle;

	// Token: 0x0400253E RID: 9534
	[Token(Token = "0x400253E")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<uint, GNS_Socket> Connections;

	// Token: 0x0400253F RID: 9535
	[Token(Token = "0x400253F")]
	[FieldOffset(Offset = "0x2C")]
	private GNS_Socket.DataEntry currentEntry;

	// Token: 0x04002540 RID: 9536
	[Token(Token = "0x4002540")]
	[FieldOffset(Offset = "0x34")]
	private int currentEntryOffset;

	// Token: 0x04002541 RID: 9537
	[Token(Token = "0x4002541")]
	[FieldOffset(Offset = "0x38")]
	private ManualResetEvent ConnectionFinished;

	// Token: 0x04002542 RID: 9538
	[Token(Token = "0x4002542")]
	private const int SendBufferSize = 1024;

	// Token: 0x04002543 RID: 9539
	[Token(Token = "0x4002543")]
	[FieldOffset(Offset = "0x3C")]
	private List<byte[]> SendBuffers;

	// Token: 0x04002544 RID: 9540
	[Token(Token = "0x4002544")]
	[FieldOffset(Offset = "0xC")]
	private static bool bufferFull;

	// Token: 0x04002545 RID: 9541
	[Token(Token = "0x4002545")]
	[FieldOffset(Offset = "0x40")]
	private GNS_Socket AcceptedSocket;

	// Token: 0x04002546 RID: 9542
	[Token(Token = "0x4002546")]
	[FieldOffset(Offset = "0x44")]
	private ManualResetEvent AcceptPending;

	// Token: 0x04002547 RID: 9543
	[Token(Token = "0x4002547")]
	[FieldOffset(Offset = "0x48")]
	private ManualResetEvent AcceptRecieved;

	// Token: 0x04002548 RID: 9544
	[Token(Token = "0x4002548")]
	[FieldOffset(Offset = "0x10")]
	public static object TransportLock;

	// Token: 0x04002549 RID: 9545
	[Token(Token = "0x4002549")]
	[FieldOffset(Offset = "0x14")]
	private static uint[] ConnectionEventBuffer;

	// Token: 0x02000301 RID: 769
	[Token(Token = "0x2000301")]
	public struct DataEntry
	{
		// Token: 0x0600132F RID: 4911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600132F")]
		[Address(RVA = "0xD99290", Offset = "0xD99290", VA = "0xD99290")]
		public DataEntry(int indexOffset, int length)
		{
		}

		// Token: 0x0400254A RID: 9546
		[Token(Token = "0x400254A")]
		[FieldOffset(Offset = "0x0")]
		public int dataIndexOffset;

		// Token: 0x0400254B RID: 9547
		[Token(Token = "0x400254B")]
		[FieldOffset(Offset = "0x4")]
		public int dataLength;
	}
}
