using System;
using Il2CppDummyDll;

namespace Terraria.Testing.Cloning
{
	// Token: 0x020005F7 RID: 1527
	// (Invoke) Token: 0x06003C9B RID: 15515
	[Token(Token = "0x20005F7")]
	public delegate void CloneStructChildren<T>(ref T clone, DeepCloneContext ctx) where T : struct;
}
