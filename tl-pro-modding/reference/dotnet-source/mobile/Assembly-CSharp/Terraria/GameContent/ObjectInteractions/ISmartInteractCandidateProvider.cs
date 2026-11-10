using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.ObjectInteractions
{
	// Token: 0x02000A31 RID: 2609
	[Token(Token = "0x2000A31")]
	public interface ISmartInteractCandidateProvider
	{
		// Token: 0x0600540C RID: 21516
		[Token(Token = "0x600540C")]
		void ClearSelfAndPrepareForCheck();

		// Token: 0x0600540D RID: 21517
		[Token(Token = "0x600540D")]
		bool ProvideCandidate(SmartInteractScanSettings settings, out ISmartInteractCandidate candidate);
	}
}
