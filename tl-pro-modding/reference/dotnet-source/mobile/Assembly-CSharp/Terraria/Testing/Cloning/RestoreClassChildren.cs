using System;
using Il2CppDummyDll;

namespace Terraria.Testing.Cloning
{
	// Token: 0x020005F8 RID: 1528
	// (Invoke) Token: 0x06003C9F RID: 15519
	[Token(Token = "0x20005F8")]
	public delegate void RestoreClassChildren<T>(T clone, T current, DeepCloneContext ctx) where T : class;
}
