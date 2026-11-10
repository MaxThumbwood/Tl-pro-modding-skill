using System;
using System.Net.Sockets;
using Il2CppDummyDll;

namespace Terraria.Net.Sockets
{
	// Token: 0x02000808 RID: 2056
	[Token(Token = "0x2000808")]
	public class TcpSocket : FileAPI
	{
		// Token: 0x06004666 RID: 18022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004666")]
		[Address(RVA = "0x58ED24", Offset = "0x58ED24", VA = "0x58ED24")]
		private DebugNetworkStream GetStream()
		{
			return null;
		}

		// Token: 0x06004667 RID: 18023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004667")]
		[Address(RVA = "0x58EDCC", Offset = "0x58EDCC", VA = "0x58EDCC")]
		public TcpSocket()
		{
		}

		// Token: 0x06004668 RID: 18024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004668")]
		[Address(RVA = "0x58EE6C", Offset = "0x58EE6C", VA = "0x58EE6C")]
		public TcpSocket(TcpClient tcpClient)
		{
		}

		// Token: 0x06004669 RID: 18025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004669")]
		[Address(RVA = "0x58EFB8", Offset = "0x58EFB8", VA = "0x58EFB8", Slot = "4")]
		private void Terraria.Net.Sockets.ISocket.Close()
		{
		}

		// Token: 0x0600466A RID: 18026 RVA: 0x00021558 File Offset: 0x0001F758
		[Token(Token = "0x600466A")]
		[Address(RVA = "0x58EFFC", Offset = "0x58EFFC", VA = "0x58EFFC", Slot = "5")]
		private bool Terraria.Net.Sockets.ISocket.IsConnected()
		{
			return default(bool);
		}

		// Token: 0x0600466B RID: 18027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600466B")]
		[Address(RVA = "0x58F0E0", Offset = "0x58F0E0", VA = "0x58F0E0", Slot = "6")]
		private void Terraria.Net.Sockets.ISocket.Connect(RemoteAddress address)
		{
		}

		// Token: 0x0600466C RID: 18028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600466C")]
		[Address(RVA = "0x58F1A0", Offset = "0x58F1A0", VA = "0x58F1A0")]
		private void ReadCallback(IAsyncResult result)
		{
		}

		// Token: 0x0600466D RID: 18029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600466D")]
		[Address(RVA = "0x58F580", Offset = "0x58F580", VA = "0x58F580")]
		private void SendCallback(IAsyncResult result)
		{
		}

		// Token: 0x0600466E RID: 18030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600466E")]
		[Address(RVA = "0x58F8D8", Offset = "0x58F8D8", VA = "0x58F8D8", Slot = "7")]
		private void Terraria.Net.Sockets.ISocket.AsyncSend(byte[] data, int offset, int size, SocketSendCallback callback, object state)
		{
		}

		// Token: 0x0600466F RID: 18031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600466F")]
		[Address(RVA = "0x58FA18", Offset = "0x58FA18", VA = "0x58FA18", Slot = "8")]
		private void Terraria.Net.Sockets.ISocket.AsyncReceive(byte[] data, int offset, int size, SocketReceiveCallback callback, object state)
		{
		}

		// Token: 0x06004670 RID: 18032 RVA: 0x00021570 File Offset: 0x0001F770
		[Token(Token = "0x6004670")]
		[Address(RVA = "0x58FB58", Offset = "0x58FB58", VA = "0x58FB58", Slot = "9")]
		private bool Terraria.Net.Sockets.ISocket.IsDataAvailable()
		{
			return default(bool);
		}

		// Token: 0x06004671 RID: 18033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004671")]
		[Address(RVA = "0x58FBB0", Offset = "0x58FBB0", VA = "0x58FBB0", Slot = "12")]
		private RemoteAddress Terraria.Net.Sockets.ISocket.GetRemoteAddress()
		{
			return null;
		}

		// Token: 0x06004672 RID: 18034 RVA: 0x00021588 File Offset: 0x0001F788
		[Token(Token = "0x6004672")]
		[Address(RVA = "0x58FBB8", Offset = "0x58FBB8", VA = "0x58FBB8", Slot = "10")]
		private bool Terraria.Net.Sockets.ISocket.StartListening(SocketConnectionAccepted callback)
		{
			return default(bool);
		}

		// Token: 0x06004673 RID: 18035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004673")]
		[Address(RVA = "0x58FFB0", Offset = "0x58FFB0", VA = "0x58FFB0", Slot = "11")]
		private void Terraria.Net.Sockets.ISocket.StopListening()
		{
		}

		// Token: 0x06004674 RID: 18036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004674")]
		[Address(RVA = "0x58FFBC", Offset = "0x58FFBC", VA = "0x58FFBC")]
		private void ListenLoop()
		{
		}

		// Token: 0x04008D50 RID: 36176
		[Token(Token = "0x4008D50")]
		[FieldOffset(Offset = "0x8")]
		private TcpClient _connection;

		// Token: 0x04008D51 RID: 36177
		[Token(Token = "0x4008D51")]
		[FieldOffset(Offset = "0xC")]
		private TcpListener _listener;

		// Token: 0x04008D52 RID: 36178
		[Token(Token = "0x4008D52")]
		[FieldOffset(Offset = "0x10")]
		private SocketConnectionAccepted _listenerCallback;

		// Token: 0x04008D53 RID: 36179
		[Token(Token = "0x4008D53")]
		[FieldOffset(Offset = "0x14")]
		private RemoteAddress _remoteAddress;

		// Token: 0x04008D54 RID: 36180
		[Token(Token = "0x4008D54")]
		[FieldOffset(Offset = "0x18")]
		private bool _isListening;

		// Token: 0x04008D55 RID: 36181
		[Token(Token = "0x4008D55")]
		[FieldOffset(Offset = "0x1C")]
		private DebugNetworkStream _debugStream;
	}
}
