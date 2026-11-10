using System;
using Il2CppDummyDll;
using Terraria.GameContent.UI.Elements;

namespace Terraria.GameContent.Creative
{
	// Token: 0x02000CFD RID: 3325
	[Token(Token = "0x2000CFD")]
	public interface IPowerSubcategoryElement
	{
		// Token: 0x06006243 RID: 25155
		[Token(Token = "0x6006243")]
		GroupOptionButton<int> GetOptionButton(CreativePowerUIElementRequestInfo info, int optionIndex, int currentOptionIndex);
	}
}
