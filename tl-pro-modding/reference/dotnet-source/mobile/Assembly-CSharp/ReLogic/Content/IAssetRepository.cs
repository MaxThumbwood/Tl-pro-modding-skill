using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ReLogic.Content.Sources;

namespace ReLogic.Content
{
	// Token: 0x02000E13 RID: 3603
	[Token(Token = "0x2000E13")]
	public interface IAssetRepository : FileAPI
	{
		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x06006956 RID: 26966
		[Token(Token = "0x17000B4B")]
		int PendingAssets
		{
			[Token(Token = "0x6006956")]
			get;
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x06006957 RID: 26967
		[Token(Token = "0x17000B4C")]
		int TotalAssets
		{
			[Token(Token = "0x6006957")]
			get;
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x06006958 RID: 26968
		[Token(Token = "0x17000B4D")]
		int LoadedAssets
		{
			[Token(Token = "0x6006958")]
			get;
		}

		// Token: 0x06006959 RID: 26969
		[Token(Token = "0x6006959")]
		void SetSources(IEnumerable<IContentSource> sources, AssetRequestMode mode = AssetRequestMode.ImmediateLoad);

		// Token: 0x0600695A RID: 26970
		[Token(Token = "0x600695A")]
		Asset<T> Request<T>(string assetName, AssetRequestMode mode = AssetRequestMode.ImmediateLoad) where T : class;

		// Token: 0x0600695B RID: 26971
		[Token(Token = "0x600695B")]
		void TransferCompletedAssets();

		// Token: 0x0600695C RID: 26972
		[Token(Token = "0x600695C")]
		void ProcessAsyncLoad();
	}
}
