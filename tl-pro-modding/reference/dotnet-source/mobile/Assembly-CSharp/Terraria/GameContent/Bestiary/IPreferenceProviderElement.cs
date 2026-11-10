using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000C0A RID: 3082
	[Token(Token = "0x2000C0A")]
	public interface IPreferenceProviderElement : FileAPI
	{
		// Token: 0x06005CA4 RID: 23716
		[Token(Token = "0x6005CA4")]
		IBestiaryBackgroundImagePathAndColorProvider GetPreferredProvider();

		// Token: 0x06005CA5 RID: 23717
		[Token(Token = "0x6005CA5")]
		bool Matches(IBestiaryBackgroundImagePathAndColorProvider provider);
	}
}
