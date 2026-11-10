using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000BD7 RID: 3031
	[Token(Token = "0x2000BD7")]
	public interface IBestiaryEntryFilter : FileAPI
	{
		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06005BD0 RID: 23504
		[Token(Token = "0x17000A36")]
		bool? ForcedDisplay
		{
			[Token(Token = "0x6005BD0")]
			get;
		}
	}
}
