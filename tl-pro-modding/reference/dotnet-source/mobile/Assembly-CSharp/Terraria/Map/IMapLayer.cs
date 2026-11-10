using System;
using Il2CppDummyDll;

namespace Terraria.Map
{
	// Token: 0x0200080F RID: 2063
	[Token(Token = "0x200080F")]
	public interface IMapLayer
	{
		// Token: 0x0600469F RID: 18079
		[Token(Token = "0x600469F")]
		void Draw(ref MapOverlayDrawContext context, ref string text);
	}
}
