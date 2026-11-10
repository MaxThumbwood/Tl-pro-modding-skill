using System;
using Il2CppDummyDll;

namespace Terraria.Testing.Cloning
{
	// Token: 0x020005F6 RID: 1526
	// (Invoke) Token: 0x06003C97 RID: 15511
	[Token(Token = "0x20005F6")]
	public delegate void CloneClassChildren<T>(T clone, DeepCloneContext ctx) where T : class;
}
