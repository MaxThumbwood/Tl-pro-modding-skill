using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Terraria.Net.Sockets
{
	// Token: 0x02000805 RID: 2053
	[Token(Token = "0x2000805")]
	public interface ISocket
	{
		// Token: 0x0600464D RID: 17997
		[Token(Token = "0x600464D")]
		void Close();

		// Token: 0x0600464E RID: 17998
		[Token(Token = "0x600464E")]
		bool IsConnected();

		// Token: 0x0600464F RID: 17999
		[Token(Token = "0x600464F")]
		void Connect(RemoteAddress address);

		// Token: 0x06004650 RID: 18000
		[Token(Token = "0x6004650")]
		void AsyncSend(byte[] data, int offset, int size, SocketSendCallback callback, [Optional] object state);

		// Token: 0x06004651 RID: 18001
		[Token(Token = "0x6004651")]
		void AsyncReceive(byte[] data, int offset, int size, SocketReceiveCallback callback, [Optional] object state);

		// Token: 0x06004652 RID: 18002
		[Token(Token = "0x6004652")]
		bool IsDataAvailable();

		// Token: 0x06004653 RID: 18003
		[Token(Token = "0x6004653")]
		bool StartListening(SocketConnectionAccepted callback);

		// Token: 0x06004654 RID: 18004
		[Token(Token = "0x6004654")]
		void StopListening();

		// Token: 0x06004655 RID: 18005
		[Token(Token = "0x6004655")]
		RemoteAddress GetRemoteAddress();
	}
}
