using System;
using Il2CppDummyDll;
using ReLogic.Content.Sources;

namespace ReLogic.Content
{
	// Token: 0x02000E03 RID: 3587
	[Token(Token = "0x2000E03")]
	public class AssetLoader : FileAPI
	{
		// Token: 0x06006919 RID: 26905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006919")]
		[Address(RVA = "0xB8476C", Offset = "0xB8476C", VA = "0xB8476C")]
		public AssetLoader(AssetReaderCollection readers)
		{
		}

		// Token: 0x0600691A RID: 26906 RVA: 0x0002F9E8 File Offset: 0x0002DBE8
		[Token(Token = "0x600691A")]
		public bool TryLoad<T>(string assetName, IContentSource source, out T resultAsset) where T : class
		{
			return default(bool);
		}

		// Token: 0x0400A6DA RID: 42714
		[Token(Token = "0x400A6DA")]
		[FieldOffset(Offset = "0x8")]
		private readonly AssetReaderCollection _readers;
	}
}
