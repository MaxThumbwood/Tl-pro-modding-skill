using System;
using Il2CppDummyDll;

namespace Terraria.Net.Sockets
{
	// Token: 0x02000806 RID: 2054
	[Token(Token = "0x2000806")]
	public class SocialSocket : FileAPI
	{
		// Token: 0x06004656 RID: 18006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004656")]
		[Address(RVA = "0x58E514", Offset = "0x58E514", VA = "0x58E514")]
		public SocialSocket()
		{
		}

		// Token: 0x06004657 RID: 18007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004657")]
		[Address(RVA = "0x58E51C", Offset = "0x58E51C", VA = "0x58E51C")]
		public SocialSocket(RemoteAddress remoteAddress)
		{
		}

		// Token: 0x06004658 RID: 18008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004658")]
		[Address(RVA = "0x58E538", Offset = "0x58E538", VA = "0x58E538", Slot = "4")]
		private void Terraria.Net.Sockets.ISocket.Close()
		{
		}

		// Token: 0x06004659 RID: 18009 RVA: 0x00021510 File Offset: 0x0001F710
		[Token(Token = "0x6004659")]
		[Address(RVA = "0x58E5C4", Offset = "0x58E5C4", VA = "0x58E5C4", Slot = "5")]
		private bool Terraria.Net.Sockets.ISocket.IsConnected()
		{
			return default(bool);
		}

		// Token: 0x0600465A RID: 18010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600465A")]
		[Address(RVA = "0x58E640", Offset = "0x58E640", VA = "0x58E640", Slot = "6")]
		private void Terraria.Net.Sockets.ISocket.Connect(RemoteAddress address)
		{
		}

		// Token: 0x0600465B RID: 18011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600465B")]
		[Address(RVA = "0x58E6C0", Offset = "0x58E6C0", VA = "0x58E6C0", Slot = "7")]
		private void Terraria.Net.Sockets.ISocket.AsyncSend(byte[] data, int offset, int size, SocketSendCallback callback, object state)
		{
		}

		// Token: 0x0600465C RID: 18012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600465C")]
		[Address(RVA = "0x58E78C", Offset = "0x58E78C", VA = "0x58E78C")]
		private void ReadCallback(byte[] data, int offset, int size, SocketReceiveCallback callback, object state)
		{
		}

		// Token: 0x0600465D RID: 18013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600465D")]
		[Address(RVA = "0x58E878", Offset = "0x58E878", VA = "0x58E878", Slot = "8")]
		private void Terraria.Net.Sockets.ISocket.AsyncReceive(byte[] data, int offset, int size, SocketReceiveCallback callback, object state)
		{
		}

		// Token: 0x0600465E RID: 18014 RVA: 0x00021528 File Offset: 0x0001F728
		[Token(Token = "0x600465E")]
		[Address(RVA = "0x58EB78", Offset = "0x58EB78", VA = "0x58EB78", Slot = "9")]
		private bool Terraria.Net.Sockets.ISocket.IsDataAvailable()
		{
			return default(bool);
		}

		// Token: 0x0600465F RID: 18015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600465F")]
		[Address(RVA = "0x58EBF4", Offset = "0x58EBF4", VA = "0x58EBF4", Slot = "12")]
		private RemoteAddress Terraria.Net.Sockets.ISocket.GetRemoteAddress()
		{
			return null;
		}

		// Token: 0x06004660 RID: 18016 RVA: 0x00021540 File Offset: 0x0001F740
		[Token(Token = "0x6004660")]
		[Address(RVA = "0x58EBFC", Offset = "0x58EBFC", VA = "0x58EBFC", Slot = "10")]
		private bool Terraria.Net.Sockets.ISocket.StartListening(SocketConnectionAccepted callback)
		{
			return default(bool);
		}

		// Token: 0x06004661 RID: 18017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004661")]
		[Address(RVA = "0x58EC74", Offset = "0x58EC74", VA = "0x58EC74", Slot = "11")]
		private void Terraria.Net.Sockets.ISocket.StopListening()
		{
		}

		// Token: 0x04008D4F RID: 36175
		[Token(Token = "0x4008D4F")]
		[FieldOffset(Offset = "0x8")]
		private RemoteAddress _remoteAddress;

		// Token: 0x02000807 RID: 2055
		// (Invoke) Token: 0x06004663 RID: 18019
		[Token(Token = "0x2000807")]
		private delegate void InternalReadCallback(byte[] data, int offset, int size, SocketReceiveCallback callback, object state);
	}
}
