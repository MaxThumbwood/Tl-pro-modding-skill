using System;
using System.Diagnostics;
using Il2CppDummyDll;
using Terraria.Net;
using Terraria.Net.Sockets;

namespace Terraria.Social.Base
{
	// Token: 0x02000633 RID: 1587
	[Token(Token = "0x2000633")]
	public abstract class NetSocialModule : FileAPI
	{
		// Token: 0x06003DC6 RID: 15814
		[Token(Token = "0x6003DC6")]
		public abstract void Initialize();

		// Token: 0x06003DC7 RID: 15815
		[Token(Token = "0x6003DC7")]
		public abstract void Shutdown();

		// Token: 0x06003DC8 RID: 15816
		[Token(Token = "0x6003DC8")]
		public abstract void Close(RemoteAddress address);

		// Token: 0x06003DC9 RID: 15817
		[Token(Token = "0x6003DC9")]
		public abstract bool IsConnected(RemoteAddress address);

		// Token: 0x06003DCA RID: 15818
		[Token(Token = "0x6003DCA")]
		public abstract void Connect(RemoteAddress address);

		// Token: 0x06003DCB RID: 15819
		[Token(Token = "0x6003DCB")]
		public abstract bool Send(RemoteAddress address, byte[] data, int length);

		// Token: 0x06003DCC RID: 15820
		[Token(Token = "0x6003DCC")]
		public abstract int Receive(RemoteAddress address, byte[] data, int offset, int length);

		// Token: 0x06003DCD RID: 15821
		[Token(Token = "0x6003DCD")]
		public abstract bool IsDataAvailable(RemoteAddress address);

		// Token: 0x06003DCE RID: 15822
		[Token(Token = "0x6003DCE")]
		public abstract void LaunchLocalServer(Process process, ServerMode mode);

		// Token: 0x06003DCF RID: 15823
		[Token(Token = "0x6003DCF")]
		public abstract bool CanInvite();

		// Token: 0x06003DD0 RID: 15824
		[Token(Token = "0x6003DD0")]
		public abstract void OpenInviteInterface();

		// Token: 0x06003DD1 RID: 15825
		[Token(Token = "0x6003DD1")]
		public abstract void CancelJoin();

		// Token: 0x06003DD2 RID: 15826
		[Token(Token = "0x6003DD2")]
		public abstract bool StartListening(SocketConnectionAccepted callback);

		// Token: 0x06003DD3 RID: 15827
		[Token(Token = "0x6003DD3")]
		public abstract void StopListening();

		// Token: 0x06003DD4 RID: 15828
		[Token(Token = "0x6003DD4")]
		public abstract ulong GetLobbyId();

		// Token: 0x06003DD5 RID: 15829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DD5")]
		[Address(RVA = "0x1E68018", Offset = "0x1E68018", VA = "0x1E68018")]
		protected NetSocialModule()
		{
		}
	}
}
