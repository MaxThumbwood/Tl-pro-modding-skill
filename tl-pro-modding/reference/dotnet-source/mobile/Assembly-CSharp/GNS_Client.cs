using System;
using System.Net;
using System.Net.Sockets;
using Il2CppDummyDll;

// Token: 0x020002FC RID: 764
[Token(Token = "0x20002FC")]
public class GNS_Client : FileAPI
{
	// Token: 0x060012C4 RID: 4804 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C4")]
	[Address(RVA = "0xD93D8C", Offset = "0xD93D8C", VA = "0xD93D8C")]
	public GNS_Client(IPEndPoint localEP, bool p2pPort)
	{
	}

	// Token: 0x060012C5 RID: 4805 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C5")]
	[Address(RVA = "0xD93E40", Offset = "0xD93E40", VA = "0xD93E40")]
	public GNS_Client(bool p2pPort)
	{
	}

	// Token: 0x060012C6 RID: 4806 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C6")]
	[Address(RVA = "0xD93E68", Offset = "0xD93E68", VA = "0xD93E68")]
	public GNS_Client(AddressFamily family, bool p2pPort)
	{
	}

	// Token: 0x060012C7 RID: 4807 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C7")]
	[Address(RVA = "0xD93F00", Offset = "0xD93F00", VA = "0xD93F00")]
	public GNS_Client(string hostname, int port)
	{
	}

	// Token: 0x060012C8 RID: 4808 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C8")]
	[Address(RVA = "0xD94A5C", Offset = "0xD94A5C", VA = "0xD94A5C")]
	internal GNS_Client(GNS_Socket acceptedSocket)
	{
	}

	// Token: 0x170001B6 RID: 438
	// (get) Token: 0x060012C9 RID: 4809 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060012CA RID: 4810 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001B6")]
	public GNS_Socket Client
	{
		[Token(Token = "0x60012C9")]
		[Address(RVA = "0xD94A8C", Offset = "0xD94A8C", VA = "0xD94A8C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60012CA")]
		[Address(RVA = "0xD94A94", Offset = "0xD94A94", VA = "0xD94A94")]
		set
		{
		}
	}

	// Token: 0x170001B7 RID: 439
	// (get) Token: 0x060012CB RID: 4811 RVA: 0x00008958 File Offset: 0x00006B58
	// (set) Token: 0x060012CC RID: 4812 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001B7")]
	protected bool Active
	{
		[Token(Token = "0x60012CB")]
		[Address(RVA = "0xD94A9C", Offset = "0xD94A9C", VA = "0xD94A9C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60012CC")]
		[Address(RVA = "0xD94AA4", Offset = "0xD94AA4", VA = "0xD94AA4")]
		set
		{
		}
	}

	// Token: 0x170001B8 RID: 440
	// (get) Token: 0x060012CD RID: 4813 RVA: 0x00008970 File Offset: 0x00006B70
	[Token(Token = "0x170001B8")]
	public int Available
	{
		[Token(Token = "0x60012CD")]
		[Address(RVA = "0xD94AAC", Offset = "0xD94AAC", VA = "0xD94AAC")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170001B9 RID: 441
	// (get) Token: 0x060012CE RID: 4814 RVA: 0x00008988 File Offset: 0x00006B88
	[Token(Token = "0x170001B9")]
	public bool Connected
	{
		[Token(Token = "0x60012CE")]
		[Address(RVA = "0xD94AD0", Offset = "0xD94AD0", VA = "0xD94AD0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060012CF RID: 4815 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012CF")]
	[Address(RVA = "0xD94050", Offset = "0xD94050", VA = "0xD94050")]
	public void Connect(string hostname, int port)
	{
	}

	// Token: 0x060012D0 RID: 4816 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012D0")]
	[Address(RVA = "0xD95464", Offset = "0xD95464", VA = "0xD95464")]
	public GNS_NetworkStream GetStream()
	{
		return null;
	}

	// Token: 0x060012D1 RID: 4817 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012D1")]
	[Address(RVA = "0xD956E4", Offset = "0xD956E4", VA = "0xD956E4")]
	public void Close()
	{
	}

	// Token: 0x060012D2 RID: 4818 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012D2")]
	[Address(RVA = "0xD9578C", Offset = "0xD9578C", VA = "0xD9578C", Slot = "5")]
	protected virtual void Dispose(bool disposing)
	{
	}

	// Token: 0x060012D3 RID: 4819 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012D3")]
	[Address(RVA = "0xD958B8", Offset = "0xD958B8", VA = "0xD958B8", Slot = "4")]
	public void Dispose()
	{
	}

	// Token: 0x060012D4 RID: 4820 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012D4")]
	[Address(RVA = "0xD958CC", Offset = "0xD958CC", VA = "0xD958CC", Slot = "1")]
	protected override void Finalize()
	{
	}

	// Token: 0x170001BA RID: 442
	// (get) Token: 0x060012D5 RID: 4821 RVA: 0x000089A0 File Offset: 0x00006BA0
	// (set) Token: 0x060012D6 RID: 4822 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001BA")]
	public int ReceiveBufferSize
	{
		[Token(Token = "0x60012D5")]
		[Address(RVA = "0xD9596C", Offset = "0xD9596C", VA = "0xD9596C")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60012D6")]
		[Address(RVA = "0xD9597C", Offset = "0xD9597C", VA = "0xD9597C")]
		set
		{
		}
	}

	// Token: 0x170001BB RID: 443
	// (get) Token: 0x060012D7 RID: 4823 RVA: 0x000089B8 File Offset: 0x00006BB8
	// (set) Token: 0x060012D8 RID: 4824 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001BB")]
	public int SendBufferSize
	{
		[Token(Token = "0x60012D7")]
		[Address(RVA = "0xD95980", Offset = "0xD95980", VA = "0xD95980")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60012D8")]
		[Address(RVA = "0xD95988", Offset = "0xD95988", VA = "0xD95988")]
		set
		{
		}
	}

	// Token: 0x170001BC RID: 444
	// (get) Token: 0x060012D9 RID: 4825 RVA: 0x000089D0 File Offset: 0x00006BD0
	// (set) Token: 0x060012DA RID: 4826 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001BC")]
	public int ReceiveTimeout
	{
		[Token(Token = "0x60012D9")]
		[Address(RVA = "0xD9598C", Offset = "0xD9598C", VA = "0xD9598C")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60012DA")]
		[Address(RVA = "0xD95994", Offset = "0xD95994", VA = "0xD95994")]
		set
		{
		}
	}

	// Token: 0x170001BD RID: 445
	// (get) Token: 0x060012DB RID: 4827 RVA: 0x000089E8 File Offset: 0x00006BE8
	// (set) Token: 0x060012DC RID: 4828 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001BD")]
	public int SendTimeout
	{
		[Token(Token = "0x60012DB")]
		[Address(RVA = "0xD95998", Offset = "0xD95998", VA = "0xD95998")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60012DC")]
		[Address(RVA = "0xD959A0", Offset = "0xD959A0", VA = "0xD959A0")]
		set
		{
		}
	}

	// Token: 0x170001BE RID: 446
	// (get) Token: 0x060012DD RID: 4829 RVA: 0x00008A00 File Offset: 0x00006C00
	// (set) Token: 0x060012DE RID: 4830 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001BE")]
	public bool NoDelay
	{
		[Token(Token = "0x60012DD")]
		[Address(RVA = "0xD959A4", Offset = "0xD959A4", VA = "0xD959A4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60012DE")]
		[Address(RVA = "0xD959AC", Offset = "0xD959AC", VA = "0xD959AC")]
		set
		{
		}
	}

	// Token: 0x060012DF RID: 4831 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012DF")]
	[Address(RVA = "0xD93E34", Offset = "0xD93E34", VA = "0xD93E34")]
	private void initialize(bool p2pPort)
	{
	}

	// Token: 0x060012E0 RID: 4832 RVA: 0x00008A18 File Offset: 0x00006C18
	[Token(Token = "0x60012E0")]
	[Address(RVA = "0xD95974", Offset = "0xD95974", VA = "0xD95974")]
	private int numericOption(SocketOptionLevel optionLevel, SocketOptionName optionName)
	{
		return 0;
	}

	// Token: 0x0400251C RID: 9500
	[Token(Token = "0x400251C")]
	[FieldOffset(Offset = "0x8")]
	private GNS_Socket m_ClientSocket;

	// Token: 0x0400251D RID: 9501
	[Token(Token = "0x400251D")]
	[FieldOffset(Offset = "0xC")]
	private bool m_Active;

	// Token: 0x0400251E RID: 9502
	[Token(Token = "0x400251E")]
	[FieldOffset(Offset = "0x10")]
	private GNS_NetworkStream m_DataStream;

	// Token: 0x0400251F RID: 9503
	[Token(Token = "0x400251F")]
	[FieldOffset(Offset = "0x14")]
	private AddressFamily m_Family;

	// Token: 0x04002520 RID: 9504
	[Token(Token = "0x4002520")]
	[FieldOffset(Offset = "0x18")]
	private bool m_CleanedUp;
}
