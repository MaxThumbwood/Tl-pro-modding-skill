using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using Il2CppDummyDll;

namespace Open.Nat
{
	// Token: 0x02000E2C RID: 3628
	[Token(Token = "0x2000E2C")]
	internal interface ISearcher
	{
		// Token: 0x060069FD RID: 27133
		[Token(Token = "0x60069FD")]
		void Search(CancellationToken cancellationToken);

		// Token: 0x060069FE RID: 27134
		[Token(Token = "0x60069FE")]
		IEnumerable<NatDevice> Receive();

		// Token: 0x060069FF RID: 27135
		[Token(Token = "0x60069FF")]
		NatDevice AnalyseReceivedResponse(IPAddress localAddress, byte[] response, IPEndPoint endpoint);
	}
}
