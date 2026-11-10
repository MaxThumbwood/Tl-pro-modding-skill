using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.ObjectInteractions
{
	// Token: 0x02000A30 RID: 2608
	[Token(Token = "0x2000A30")]
	public interface ISmartInteractBlockReasonProvider
	{
		// Token: 0x0600540B RID: 21515
		[Token(Token = "0x600540B")]
		bool ShouldBlockSmartInteract(SmartInteractScanSettings settings);
	}
}
