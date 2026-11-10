using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace ReLogic.Content
{
	// Token: 0x02000E08 RID: 3592
	[Token(Token = "0x2000E08")]
	[Serializable]
	public class AssetLoadException : Exception
	{
		// Token: 0x06006924 RID: 26916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006924")]
		[Address(RVA = "0xB84CE8", Offset = "0xB84CE8", VA = "0xB84CE8")]
		private AssetLoadException(string text, Exception innerException)
		{
		}

		// Token: 0x06006925 RID: 26917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006925")]
		[Address(RVA = "0xB84D60", Offset = "0xB84D60", VA = "0xB84D60")]
		public static AssetLoadException FromMissingAsset(string assetName, [Optional] Exception innerException)
		{
			return null;
		}

		// Token: 0x06006926 RID: 26918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006926")]
		public static AssetLoadException FromInvalidReader<TReaderType, TAssetType>()
		{
			return null;
		}

		// Token: 0x06006927 RID: 26919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006927")]
		[Address(RVA = "0xB84E5C", Offset = "0xB84E5C", VA = "0xB84E5C")]
		public static AssetLoadException FromMissingReader(string extension)
		{
			return null;
		}
	}
}
