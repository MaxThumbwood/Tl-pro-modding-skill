using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using ReLogic.Content.Readers;

namespace ReLogic.Content
{
	// Token: 0x02000E0A RID: 3594
	[Token(Token = "0x2000E0A")]
	public class AssetReaderCollection
	{
		// Token: 0x0600692A RID: 26922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600692A")]
		[Address(RVA = "0xB85050", Offset = "0xB85050", VA = "0xB85050")]
		public void RegisterReader(IAssetReader reader, string[] extensions)
		{
		}

		// Token: 0x0600692B RID: 26923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600692B")]
		public T Read<T>(Stream stream, string extension) where T : class
		{
			return null;
		}

		// Token: 0x0600692C RID: 26924 RVA: 0x0002FA48 File Offset: 0x0002DC48
		[Token(Token = "0x600692C")]
		[Address(RVA = "0xB85120", Offset = "0xB85120", VA = "0xB85120")]
		public bool CanReadExtension(string extension)
		{
			return default(bool);
		}

		// Token: 0x0600692D RID: 26925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600692D")]
		[Address(RVA = "0xB851A8", Offset = "0xB851A8", VA = "0xB851A8")]
		public AssetReaderCollection()
		{
		}

		// Token: 0x0400A6DC RID: 42716
		[Token(Token = "0x400A6DC")]
		[FieldOffset(Offset = "0x8")]
		private readonly Dictionary<string, IAssetReader> _readersByExtension;
	}
}
