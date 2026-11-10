using System;
using Il2CppDummyDll;

// Token: 0x02000303 RID: 771
[Token(Token = "0x2000303")]
public class GNS_Tester
{
	// Token: 0x06001332 RID: 4914 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001332")]
	[Address(RVA = "0xD99B40", Offset = "0xD99B40", VA = "0xD99B40")]
	public void StartTest()
	{
	}

	// Token: 0x06001333 RID: 4915 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001333")]
	[Address(RVA = "0xD99F78", Offset = "0xD99F78", VA = "0xD99F78")]
	public void Update()
	{
	}

	// Token: 0x06001334 RID: 4916 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001334")]
	[Address(RVA = "0xD99FDC", Offset = "0xD99FDC", VA = "0xD99FDC")]
	private void ConnectThread()
	{
	}

	// Token: 0x06001335 RID: 4917 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001335")]
	[Address(RVA = "0xD9A308", Offset = "0xD9A308", VA = "0xD9A308")]
	private void ListenThread()
	{
	}

	// Token: 0x06001336 RID: 4918 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001336")]
	[Address(RVA = "0xD9A550", Offset = "0xD9A550", VA = "0xD9A550")]
	protected void RemoteSockectSend()
	{
	}

	// Token: 0x06001337 RID: 4919 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001337")]
	[Address(RVA = "0xD9A980", Offset = "0xD9A980", VA = "0xD9A980")]
	private void RemoteSockectRecv()
	{
	}

	// Token: 0x06001338 RID: 4920 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001338")]
	[Address(RVA = "0xD9ADB8", Offset = "0xD9ADB8", VA = "0xD9ADB8")]
	protected void ClientSockectSend()
	{
	}

	// Token: 0x06001339 RID: 4921 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001339")]
	[Address(RVA = "0xD9B1E8", Offset = "0xD9B1E8", VA = "0xD9B1E8")]
	private void ClientSockectRecv()
	{
	}

	// Token: 0x0600133A RID: 4922 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600133A")]
	[Address(RVA = "0xD9B620", Offset = "0xD9B620", VA = "0xD9B620")]
	public GNS_Tester()
	{
	}

	// Token: 0x0400254C RID: 9548
	[Token(Token = "0x400254C")]
	[FieldOffset(Offset = "0x8")]
	public GNS_Listener Listener;

	// Token: 0x0400254D RID: 9549
	[Token(Token = "0x400254D")]
	[FieldOffset(Offset = "0xC")]
	public GNS_Client Client;

	// Token: 0x0400254E RID: 9550
	[Token(Token = "0x400254E")]
	[FieldOffset(Offset = "0x10")]
	public GNS_Client RemoteClient;
}
