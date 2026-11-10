using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.ObjectInteractions
{
	// Token: 0x02000A2F RID: 2607
	[Token(Token = "0x2000A2F")]
	public interface ISmartInteractCandidate
	{
		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06005409 RID: 21513
		[Token(Token = "0x170009C5")]
		float DistanceFromCursor
		{
			[Token(Token = "0x6005409")]
			get;
		}

		// Token: 0x0600540A RID: 21514
		[Token(Token = "0x600540A")]
		void WinCandidacy();
	}
}
