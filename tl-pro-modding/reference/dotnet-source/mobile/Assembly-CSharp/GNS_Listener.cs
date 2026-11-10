using System;
using System.Net;
using Il2CppDummyDll;

// Token: 0x020002FD RID: 765
[Token(Token = "0x20002FD")]
public class GNS_Listener
{
	// Token: 0x060012E1 RID: 4833 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012E1")]
	[Address(RVA = "0xD959B0", Offset = "0xD959B0", VA = "0xD959B0")]
	public GNS_Listener(IPEndPoint localEP)
	{
	}

	// Token: 0x060012E2 RID: 4834 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012E2")]
	[Address(RVA = "0xD95A2C", Offset = "0xD95A2C", VA = "0xD95A2C")]
	public GNS_Listener(IPAddress localaddr, int port)
	{
	}

	// Token: 0x060012E3 RID: 4835 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012E3")]
	[Address(RVA = "0xD96194", Offset = "0xD96194", VA = "0xD96194")]
	public GNS_Listener(int port)
	{
	}

	// Token: 0x060012E4 RID: 4836 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012E4")]
	[Address(RVA = "0xD96258", Offset = "0xD96258", VA = "0xD96258")]
	public static GNS_Listener Create(int port)
	{
		return null;
	}

	// Token: 0x170001BF RID: 447
	// (get) Token: 0x060012E5 RID: 4837 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001BF")]
	public GNS_Socket Server
	{
		[Token(Token = "0x60012E5")]
		[Address(RVA = "0xD96308", Offset = "0xD96308", VA = "0xD96308")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001C0 RID: 448
	// (get) Token: 0x060012E6 RID: 4838 RVA: 0x00008A30 File Offset: 0x00006C30
	[Token(Token = "0x170001C0")]
	protected bool Active
	{
		[Token(Token = "0x60012E6")]
		[Address(RVA = "0xD96310", Offset = "0xD96310", VA = "0xD96310")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060012E7 RID: 4839 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012E7")]
	[Address(RVA = "0xD96318", Offset = "0xD96318", VA = "0xD96318")]
	public void AllowNatTraversal(bool allowed)
	{
	}

	// Token: 0x060012E8 RID: 4840 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012E8")]
	[Address(RVA = "0xD9631C", Offset = "0xD9631C", VA = "0xD9631C")]
	public void Start()
	{
	}

	// Token: 0x060012E9 RID: 4841 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012E9")]
	[Address(RVA = "0xD96324", Offset = "0xD96324", VA = "0xD96324")]
	public void Start(int backlog)
	{
	}

	// Token: 0x060012EA RID: 4842 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012EA")]
	[Address(RVA = "0xD96650", Offset = "0xD96650", VA = "0xD96650")]
	public void Stop()
	{
	}

	// Token: 0x060012EB RID: 4843 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012EB")]
	[Address(RVA = "0xD96828", Offset = "0xD96828", VA = "0xD96828")]
	public GNS_Socket AcceptSocket()
	{
		return null;
	}

	// Token: 0x060012EC RID: 4844 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012EC")]
	[Address(RVA = "0xD9698C", Offset = "0xD9698C", VA = "0xD9698C")]
	public GNS_Client AcceptTcpClient()
	{
		return null;
	}

	// Token: 0x04002521 RID: 9505
	[Token(Token = "0x4002521")]
	[FieldOffset(Offset = "0x8")]
	private IPEndPoint m_ServerSocketEP;

	// Token: 0x04002522 RID: 9506
	[Token(Token = "0x4002522")]
	[FieldOffset(Offset = "0xC")]
	private GNS_Socket m_ServerSocket;

	// Token: 0x04002523 RID: 9507
	[Token(Token = "0x4002523")]
	[FieldOffset(Offset = "0x10")]
	private bool m_Active;

	// Token: 0x04002524 RID: 9508
	[Token(Token = "0x4002524")]
	[FieldOffset(Offset = "0x11")]
	private bool m_ExclusiveAddressUse;
}
