using System;
using Il2CppDummyDll;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000BF7 RID: 3063
	[Token(Token = "0x2000BF7")]
	public interface IBestiaryInfoElement
	{
		// Token: 0x06005C6D RID: 23661
		[Token(Token = "0x6005C6D")]
		UIElement ProvideUIElement(BestiaryUICollectionInfo info);
	}
}
