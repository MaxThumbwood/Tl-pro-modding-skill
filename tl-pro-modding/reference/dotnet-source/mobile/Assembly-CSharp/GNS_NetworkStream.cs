using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

// Token: 0x020002FF RID: 767
[Token(Token = "0x20002FF")]
public class GNS_NetworkStream : Stream
{
	// Token: 0x060012F2 RID: 4850 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012F2")]
	[Address(RVA = "0xD975A8", Offset = "0xD975A8", VA = "0xD975A8")]
	internal GNS_NetworkStream()
	{
	}

	// Token: 0x060012F3 RID: 4851 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012F3")]
	[Address(RVA = "0xD97624", Offset = "0xD97624", VA = "0xD97624")]
	public GNS_NetworkStream(GNS_Socket GNS_Socket)
	{
	}

	// Token: 0x060012F4 RID: 4852 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012F4")]
	[Address(RVA = "0xD955F0", Offset = "0xD955F0", VA = "0xD955F0")]
	public GNS_NetworkStream(GNS_Socket GNS_Socket, bool ownsSocket)
	{
	}

	// Token: 0x060012F5 RID: 4853 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012F5")]
	[Address(RVA = "0xD977C4", Offset = "0xD977C4", VA = "0xD977C4")]
	internal GNS_NetworkStream(GNS_NetworkStream GNS_NetworkStream, bool ownsSocket)
	{
	}

	// Token: 0x060012F6 RID: 4854 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012F6")]
	[Address(RVA = "0xD978C4", Offset = "0xD978C4", VA = "0xD978C4")]
	public GNS_NetworkStream(GNS_Socket GNS_Socket, FileAccess access)
	{
	}

	// Token: 0x060012F7 RID: 4855 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012F7")]
	[Address(RVA = "0xD979B4", Offset = "0xD979B4", VA = "0xD979B4")]
	public GNS_NetworkStream(GNS_Socket GNS_Socket, FileAccess access, bool ownsSocket)
	{
	}

	// Token: 0x170001C1 RID: 449
	// (get) Token: 0x060012F8 RID: 4856 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001C1")]
	protected GNS_Socket GNS_Socket
	{
		[Token(Token = "0x60012F8")]
		[Address(RVA = "0xD97AAC", Offset = "0xD97AAC", VA = "0xD97AAC")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001C2 RID: 450
	// (get) Token: 0x060012F9 RID: 4857 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001C2")]
	internal GNS_Socket InternalSocket
	{
		[Token(Token = "0x60012F9")]
		[Address(RVA = "0xD97AB4", Offset = "0xD97AB4", VA = "0xD97AB4")]
		get
		{
			return null;
		}
	}

	// Token: 0x060012FA RID: 4858 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012FA")]
	[Address(RVA = "0xD97B54", Offset = "0xD97B54", VA = "0xD97B54")]
	internal void InternalAbortSocket()
	{
	}

	// Token: 0x060012FB RID: 4859 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012FB")]
	[Address(RVA = "0xD97C50", Offset = "0xD97C50", VA = "0xD97C50")]
	internal void ConvertToNotSocketOwner()
	{
	}

	// Token: 0x170001C3 RID: 451
	// (get) Token: 0x060012FC RID: 4860 RVA: 0x00008A48 File Offset: 0x00006C48
	// (set) Token: 0x060012FD RID: 4861 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001C3")]
	protected bool Readable
	{
		[Token(Token = "0x60012FC")]
		[Address(RVA = "0xD97CC0", Offset = "0xD97CC0", VA = "0xD97CC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60012FD")]
		[Address(RVA = "0xD97CC8", Offset = "0xD97CC8", VA = "0xD97CC8")]
		set
		{
		}
	}

	// Token: 0x170001C4 RID: 452
	// (get) Token: 0x060012FE RID: 4862 RVA: 0x00008A60 File Offset: 0x00006C60
	// (set) Token: 0x060012FF RID: 4863 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001C4")]
	protected bool Writeable
	{
		[Token(Token = "0x60012FE")]
		[Address(RVA = "0xD97CD0", Offset = "0xD97CD0", VA = "0xD97CD0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60012FF")]
		[Address(RVA = "0xD97CD8", Offset = "0xD97CD8", VA = "0xD97CD8")]
		set
		{
		}
	}

	// Token: 0x170001C5 RID: 453
	// (get) Token: 0x06001300 RID: 4864 RVA: 0x00008A78 File Offset: 0x00006C78
	[Token(Token = "0x170001C5")]
	public override bool CanRead
	{
		[Token(Token = "0x6001300")]
		[Address(RVA = "0xD97CE0", Offset = "0xD97CE0", VA = "0xD97CE0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001C6 RID: 454
	// (get) Token: 0x06001301 RID: 4865 RVA: 0x00008A90 File Offset: 0x00006C90
	[Token(Token = "0x170001C6")]
	public override bool CanSeek
	{
		[Token(Token = "0x6001301")]
		[Address(RVA = "0xD97CE8", Offset = "0xD97CE8", VA = "0xD97CE8", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001C7 RID: 455
	// (get) Token: 0x06001302 RID: 4866 RVA: 0x00008AA8 File Offset: 0x00006CA8
	[Token(Token = "0x170001C7")]
	public override bool CanWrite
	{
		[Token(Token = "0x6001302")]
		[Address(RVA = "0xD97CF0", Offset = "0xD97CF0", VA = "0xD97CF0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001C8 RID: 456
	// (get) Token: 0x06001303 RID: 4867 RVA: 0x00008AC0 File Offset: 0x00006CC0
	[Token(Token = "0x170001C8")]
	public override bool CanTimeout
	{
		[Token(Token = "0x6001303")]
		[Address(RVA = "0xD97CF8", Offset = "0xD97CF8", VA = "0xD97CF8", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001C9 RID: 457
	// (get) Token: 0x06001304 RID: 4868 RVA: 0x00008AD8 File Offset: 0x00006CD8
	// (set) Token: 0x06001305 RID: 4869 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001C9")]
	public override int ReadTimeout
	{
		[Token(Token = "0x6001304")]
		[Address(RVA = "0xD97D00", Offset = "0xD97D00", VA = "0xD97D00", Slot = "14")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001305")]
		[Address(RVA = "0xD97D08", Offset = "0xD97D08", VA = "0xD97D08", Slot = "15")]
		set
		{
		}
	}

	// Token: 0x170001CA RID: 458
	// (get) Token: 0x06001306 RID: 4870 RVA: 0x00008AF0 File Offset: 0x00006CF0
	// (set) Token: 0x06001307 RID: 4871 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001CA")]
	public override int WriteTimeout
	{
		[Token(Token = "0x6001306")]
		[Address(RVA = "0xD97D94", Offset = "0xD97D94", VA = "0xD97D94", Slot = "16")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001307")]
		[Address(RVA = "0xD97D9C", Offset = "0xD97D9C", VA = "0xD97D9C", Slot = "17")]
		set
		{
		}
	}

	// Token: 0x170001CB RID: 459
	// (get) Token: 0x06001308 RID: 4872 RVA: 0x00008B08 File Offset: 0x00006D08
	[Token(Token = "0x170001CB")]
	public virtual bool DataAvailable
	{
		[Token(Token = "0x6001308")]
		[Address(RVA = "0xD97E28", Offset = "0xD97E28", VA = "0xD97E28", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001CC RID: 460
	// (get) Token: 0x06001309 RID: 4873 RVA: 0x00008B20 File Offset: 0x00006D20
	[Token(Token = "0x170001CC")]
	public override long Length
	{
		[Token(Token = "0x6001309")]
		[Address(RVA = "0xD97F48", Offset = "0xD97F48", VA = "0xD97F48", Slot = "11")]
		get
		{
			return 0L;
		}
	}

	// Token: 0x170001CD RID: 461
	// (get) Token: 0x0600130A RID: 4874 RVA: 0x00008B38 File Offset: 0x00006D38
	// (set) Token: 0x0600130B RID: 4875 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001CD")]
	public override long Position
	{
		[Token(Token = "0x600130A")]
		[Address(RVA = "0xD97FA8", Offset = "0xD97FA8", VA = "0xD97FA8", Slot = "12")]
		get
		{
			return 0L;
		}
		[Token(Token = "0x600130B")]
		[Address(RVA = "0xD98008", Offset = "0xD98008", VA = "0xD98008", Slot = "13")]
		set
		{
		}
	}

	// Token: 0x0600130C RID: 4876 RVA: 0x00008B50 File Offset: 0x00006D50
	[Token(Token = "0x600130C")]
	[Address(RVA = "0xD98068", Offset = "0xD98068", VA = "0xD98068", Slot = "31")]
	public override long Seek(long offset, SeekOrigin origin)
	{
		return 0L;
	}

	// Token: 0x0600130D RID: 4877 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600130D")]
	[Address(RVA = "0xD97710", Offset = "0xD97710", VA = "0xD97710")]
	internal void InitNetworkStream(GNS_Socket GNS_Socket, FileAccess Access)
	{
	}

	// Token: 0x0600130E RID: 4878 RVA: 0x00008B68 File Offset: 0x00006D68
	[Token(Token = "0x600130E")]
	[Address(RVA = "0xD980C8", Offset = "0xD980C8", VA = "0xD980C8")]
	internal bool PollRead()
	{
		return default(bool);
	}

	// Token: 0x0600130F RID: 4879 RVA: 0x00008B80 File Offset: 0x00006D80
	[Token(Token = "0x600130F")]
	[Address(RVA = "0xD98150", Offset = "0xD98150", VA = "0xD98150")]
	internal bool Poll(int microSeconds, SelectMode mode)
	{
		return default(bool);
	}

	// Token: 0x06001310 RID: 4880 RVA: 0x00008B98 File Offset: 0x00006D98
	[Token(Token = "0x6001310")]
	[Address(RVA = "0xD98288", Offset = "0xD98288", VA = "0xD98288", Slot = "33")]
	public override int Read([In] [Out] byte[] buffer, int offset, int size)
	{
		return 0;
	}

	// Token: 0x06001311 RID: 4881 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001311")]
	[Address(RVA = "0xD98878", Offset = "0xD98878", VA = "0xD98878", Slot = "36")]
	public override void Write(byte[] buffer, int offset, int size)
	{
	}

	// Token: 0x06001312 RID: 4882 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001312")]
	[Address(RVA = "0xD98F6C", Offset = "0xD98F6C", VA = "0xD98F6C")]
	public void Close(int timeout)
	{
	}

	// Token: 0x06001313 RID: 4883 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001313")]
	[Address(RVA = "0xD98FE8", Offset = "0xD98FE8", VA = "0xD98FE8", Slot = "20")]
	protected override void Dispose(bool disposing)
	{
	}

	// Token: 0x06001314 RID: 4884 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001314")]
	[Address(RVA = "0xD99044", Offset = "0xD99044", VA = "0xD99044", Slot = "1")]
	protected override void Finalize()
	{
	}

	// Token: 0x170001CE RID: 462
	// (get) Token: 0x06001315 RID: 4885 RVA: 0x00008BB0 File Offset: 0x00006DB0
	[Token(Token = "0x170001CE")]
	internal bool Connected
	{
		[Token(Token = "0x6001315")]
		[Address(RVA = "0xD990E4", Offset = "0xD990E4", VA = "0xD990E4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001316 RID: 4886 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001316")]
	[Address(RVA = "0xD99120", Offset = "0xD99120", VA = "0xD99120", Slot = "40")]
	internal virtual IAsyncResult UnsafeBeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
	{
		return null;
	}

	// Token: 0x06001317 RID: 4887 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001317")]
	[Address(RVA = "0xD99180", Offset = "0xD99180", VA = "0xD99180", Slot = "21")]
	public override void Flush()
	{
	}

	// Token: 0x06001318 RID: 4888 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001318")]
	[Address(RVA = "0xD99184", Offset = "0xD99184", VA = "0xD99184", Slot = "22")]
	public override Task FlushAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	// Token: 0x06001319 RID: 4889 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001319")]
	[Address(RVA = "0xD9922C", Offset = "0xD9922C", VA = "0xD9922C", Slot = "32")]
	public override void SetLength(long value)
	{
	}

	// Token: 0x0600131A RID: 4890 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600131A")]
	[Address(RVA = "0xD9928C", Offset = "0xD9928C", VA = "0xD9928C")]
	internal void SetSocketTimeoutOption(SocketShutdown mode, int timeout, bool silent)
	{
	}

	// Token: 0x04002528 RID: 9512
	[Token(Token = "0x4002528")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private GNS_Socket m_StreamSocket;

	// Token: 0x04002529 RID: 9513
	[Token(Token = "0x4002529")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool m_Readable;

	// Token: 0x0400252A RID: 9514
	[Token(Token = "0x400252A")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	private bool m_Writeable;

	// Token: 0x0400252B RID: 9515
	[Token(Token = "0x400252B")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	private bool m_OwnsSocket;

	// Token: 0x0400252C RID: 9516
	[Token(Token = "0x400252C")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	private bool m_CleanedUp;

	// Token: 0x0400252D RID: 9517
	[Token(Token = "0x400252D")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int m_CurrentReadTimeout;

	// Token: 0x0400252E RID: 9518
	[Token(Token = "0x400252E")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int m_CurrentWriteTimeout;
}
