using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x0200075B RID: 1883
	[Token(Token = "0x200075B")]
	public interface ISearchFilter<T> : FileAPI
	{
		// Token: 0x060042D2 RID: 17106
		[Token(Token = "0x60042D2")]
		void SetSearch(string searchText);
	}
}
