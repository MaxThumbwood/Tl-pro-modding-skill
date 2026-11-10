using System;
using System.IO;
using System.Net.Sockets;
using Il2CppDummyDll;

// Token: 0x02000378 RID: 888
[Token(Token = "0x2000378")]
public struct NetworkClientHolder
{
	// Token: 0x0600160E RID: 5646 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600160E")]
	[Address(RVA = "0xE08334", Offset = "0xE08334", VA = "0xE08334")]
	public void SetPlatform(TcpClient client)
	{
	}

	// Token: 0x0600160F RID: 5647 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600160F")]
	[Address(RVA = "0xE08344", Offset = "0xE08344", VA = "0xE08344")]
	public void SetTCP(TcpClient client)
	{
	}

	// Token: 0x17000219 RID: 537
	// (get) Token: 0x06001610 RID: 5648 RVA: 0x00009C78 File Offset: 0x00007E78
	[Token(Token = "0x17000219")]
	public bool Connected
	{
		[Token(Token = "0x6001610")]
		[Address(RVA = "0xE08354", Offset = "0xE08354", VA = "0xE08354")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001611 RID: 5649 RVA: 0x00009C90 File Offset: 0x00007E90
	[Token(Token = "0x6001611")]
	[Address(RVA = "0xE083A0", Offset = "0xE083A0", VA = "0xE083A0")]
	public bool TryGetIPAddress(out string address)
	{
		return default(bool);
	}

	// Token: 0x06001612 RID: 5650 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001612")]
	[Address(RVA = "0xE08548", Offset = "0xE08548", VA = "0xE08548")]
	public void Close()
	{
	}

	// Token: 0x06001613 RID: 5651 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001613")]
	[Address(RVA = "0xE0860C", Offset = "0xE0860C", VA = "0xE0860C")]
	public static void PlatformSocketShutdown(ref TcpClient client)
	{
	}

	// Token: 0x06001614 RID: 5652 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001614")]
	[Address(RVA = "0xE08634", Offset = "0xE08634", VA = "0xE08634")]
	public static void TCPSocketShutdown(ref TcpClient client)
	{
	}

	// Token: 0x06001615 RID: 5653 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001615")]
	[Address(RVA = "0xE08834", Offset = "0xE08834", VA = "0xE08834")]
	public void Shutdown()
	{
	}

	// Token: 0x06001616 RID: 5654 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001616")]
	[Address(RVA = "0xE08884", Offset = "0xE08884", VA = "0xE08884")]
	public Stream GetStream()
	{
		return null;
	}

	// Token: 0x04002A7C RID: 10876
	[Token(Token = "0x4002A7C")]
	[FieldOffset(Offset = "0x0")]
	private NetworkClientHolder.ConnectionType connection;

	// Token: 0x04002A7D RID: 10877
	[Token(Token = "0x4002A7D")]
	[FieldOffset(Offset = "0x4")]
	private TcpClient client_Platform;

	// Token: 0x04002A7E RID: 10878
	[Token(Token = "0x4002A7E")]
	[FieldOffset(Offset = "0x8")]
	private TcpClient client_TCP;

	// Token: 0x04002A7F RID: 10879
	[Token(Token = "0x4002A7F")]
	[FieldOffset(Offset = "0xC")]
	private Stream _stream;

	// Token: 0x02000379 RID: 889
	[Token(Token = "0x2000379")]
	private enum ConnectionType
	{
		// Token: 0x04002A81 RID: 10881
		[Token(Token = "0x4002A81")]
		None,
		// Token: 0x04002A82 RID: 10882
		[Token(Token = "0x4002A82")]
		Platform,
		// Token: 0x04002A83 RID: 10883
		[Token(Token = "0x4002A83")]
		TCP,
		// Token: 0x04002A84 RID: 10884
		[Token(Token = "0x4002A84")]
		Crossplay,
		// Token: 0x04002A85 RID: 10885
		[Token(Token = "0x4002A85")]
		GNS
	}
}
