using System;
using Il2CppDummyDll;

namespace ReLogic.Content
{
	// Token: 0x02000E04 RID: 3588
	[Token(Token = "0x2000E04")]
	public interface IContentValidator
	{
		// Token: 0x0600691B RID: 26907
		[Token(Token = "0x600691B")]
		bool AssetIsValid<T>(T content, string contentPath, out IRejectionReason rejectionReason) where T : class;
	}
}
