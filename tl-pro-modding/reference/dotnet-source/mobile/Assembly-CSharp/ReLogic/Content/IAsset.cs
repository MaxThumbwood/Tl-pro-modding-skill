using System;
using Il2CppDummyDll;
using ReLogic.Content.Sources;

namespace ReLogic.Content
{
	// Token: 0x02000E11 RID: 3601
	[Token(Token = "0x2000E11")]
	public interface IAsset : FileAPI
	{
		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x0600694F RID: 26959
		[Token(Token = "0x17000B46")]
		AssetState State
		{
			[Token(Token = "0x600694F")]
			get;
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x06006950 RID: 26960
		[Token(Token = "0x17000B47")]
		IContentSource Source
		{
			[Token(Token = "0x6006950")]
			get;
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x06006951 RID: 26961
		[Token(Token = "0x17000B48")]
		string Name
		{
			[Token(Token = "0x6006951")]
			get;
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x06006952 RID: 26962
		[Token(Token = "0x17000B49")]
		bool IsLoaded
		{
			[Token(Token = "0x6006952")]
			get;
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x06006953 RID: 26963
		[Token(Token = "0x17000B4A")]
		bool IsDisposed
		{
			[Token(Token = "0x6006953")]
			get;
		}

		// Token: 0x06006954 RID: 26964
		[Token(Token = "0x6006954")]
		void ActionUnityLoad();
	}
}
