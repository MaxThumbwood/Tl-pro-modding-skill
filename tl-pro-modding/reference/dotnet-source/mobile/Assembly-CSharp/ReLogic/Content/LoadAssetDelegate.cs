using System;
using Il2CppDummyDll;

namespace ReLogic.Content
{
	// Token: 0x02000E15 RID: 3605
	// (Invoke) Token: 0x06006964 RID: 26980
	[Token(Token = "0x2000E15")]
	public delegate void LoadAssetDelegate<T>(bool loadedSuccessfully, T theAsset) where T : class;
}
