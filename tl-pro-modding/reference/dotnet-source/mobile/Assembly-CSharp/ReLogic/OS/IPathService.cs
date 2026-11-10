using System;
using Il2CppDummyDll;

namespace ReLogic.OS
{
	// Token: 0x02000DE9 RID: 3561
	[Token(Token = "0x2000DE9")]
	public interface IPathService
	{
		// Token: 0x06006890 RID: 26768
		[Token(Token = "0x6006890")]
		string GetStoragePath();

		// Token: 0x06006891 RID: 26769
		[Token(Token = "0x6006891")]
		string GetStoragePath(string subfolder);

		// Token: 0x06006892 RID: 26770
		[Token(Token = "0x6006892")]
		string ExpandPathVariables(string path);
	}
}
