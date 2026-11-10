using System;
using Il2CppDummyDll;

namespace Terraria.Testing.Cloning
{
	// Token: 0x020005F9 RID: 1529
	// (Invoke) Token: 0x06003CA3 RID: 15523
	[Token(Token = "0x20005F9")]
	public delegate void RestoreStructChildren<T>(ref T clone, ref T current, DeepCloneContext ctx) where T : struct;
}
