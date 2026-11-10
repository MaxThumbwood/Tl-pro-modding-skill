using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.UI.ResourceSets
{
	// Token: 0x02000D4D RID: 3405
	[Token(Token = "0x2000D4D")]
	public interface IPlayerResourcesDisplaySet : FileAPI
	{
		// Token: 0x06006509 RID: 25865
		[Token(Token = "0x6006509")]
		void Draw();

		// Token: 0x0600650A RID: 25866
		[Token(Token = "0x600650A")]
		void TryToHover();
	}
}
