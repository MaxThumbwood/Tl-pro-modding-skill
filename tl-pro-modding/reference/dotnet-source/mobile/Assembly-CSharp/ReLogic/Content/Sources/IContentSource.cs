using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace ReLogic.Content.Sources
{
	// Token: 0x02000E17 RID: 3607
	[Token(Token = "0x2000E17")]
	public interface IContentSource
	{
		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x06006972 RID: 26994
		// (set) Token: 0x06006973 RID: 26995
		[Token(Token = "0x17000B52")]
		IContentValidator ContentValidator
		{
			[Token(Token = "0x6006972")]
			get;
			[Token(Token = "0x6006973")]
			set;
		}

		// Token: 0x06006974 RID: 26996
		[Token(Token = "0x6006974")]
		bool HasAsset(string assetName);

		// Token: 0x06006975 RID: 26997
		[Token(Token = "0x6006975")]
		string GetExtension(string assetName);

		// Token: 0x06006976 RID: 26998
		[Token(Token = "0x6006976")]
		Stream OpenStream(string assetName);

		// Token: 0x06006977 RID: 26999
		[Token(Token = "0x6006977")]
		void RejectAsset(string assetName, IRejectionReason reason);

		// Token: 0x06006978 RID: 27000
		[Token(Token = "0x6006978")]
		void ClearRejections();

		// Token: 0x06006979 RID: 27001
		[Token(Token = "0x6006979")]
		bool TryGetRejections(List<string> rejectionReasons);
	}
}
