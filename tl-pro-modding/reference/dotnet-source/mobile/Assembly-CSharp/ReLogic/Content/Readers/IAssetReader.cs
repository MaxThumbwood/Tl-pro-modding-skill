using System;
using System.IO;
using Il2CppDummyDll;

namespace ReLogic.Content.Readers
{
	// Token: 0x02000E1B RID: 3611
	[Token(Token = "0x2000E1B")]
	public interface IAssetReader
	{
		// Token: 0x060069A0 RID: 27040
		[Token(Token = "0x60069A0")]
		T FromStream<T>(Stream stream) where T : class;
	}
}
