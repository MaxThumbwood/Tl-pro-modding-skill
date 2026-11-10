using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000BDE RID: 3038
	[Token(Token = "0x2000BDE")]
	public interface IBestiarySortStep : FileAPI, GUIControllerItem
	{
		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x06005BF0 RID: 23536
		[Token(Token = "0x17000A3C")]
		bool HiddenFromSortOptions
		{
			[Token(Token = "0x6005BF0")]
			get;
		}
	}
}
