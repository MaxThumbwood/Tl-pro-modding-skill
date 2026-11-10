using System;
using Il2CppDummyDll;

namespace Terraria.UI
{
	// Token: 0x02000846 RID: 2118
	[Token(Token = "0x2000846")]
	public interface IPipsUI
	{
		// Token: 0x0600492A RID: 18730
		[Token(Token = "0x600492A")]
		void NavigatePipsList(int yOffset);

		// Token: 0x0600492B RID: 18731
		[Token(Token = "0x600492B")]
		void NavigatePipsGrid(int xOffset, int yOffset);
	}
}
