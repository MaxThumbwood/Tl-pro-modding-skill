using System;
using Il2CppDummyDll;
using ReLogic.Content.Sources;

namespace ReLogic.Content
{
	// Token: 0x02000E12 RID: 3602
	[Token(Token = "0x2000E12")]
	public interface IAssetLoader
	{
		// Token: 0x06006955 RID: 26965
		[Token(Token = "0x6006955")]
		bool TryLoad<T>(string assetName, IContentSource source, out T resultAsset) where T : class;
	}
}
