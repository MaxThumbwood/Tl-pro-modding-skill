using System;
using Il2CppDummyDll;
using ReLogic.Content.Sources;

namespace ReLogic.Content
{
	// Token: 0x02000E14 RID: 3604
	[Token(Token = "0x2000E14")]
	public interface IAsyncAssetLoader : FileAPI
	{
		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x0600695D RID: 26973
		[Token(Token = "0x17000B4E")]
		bool IsRunning
		{
			[Token(Token = "0x600695D")]
			get;
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x0600695E RID: 26974
		[Token(Token = "0x17000B4F")]
		int Remaining
		{
			[Token(Token = "0x600695E")]
			get;
		}

		// Token: 0x0600695F RID: 26975
		[Token(Token = "0x600695F")]
		void Start();

		// Token: 0x06006960 RID: 26976
		[Token(Token = "0x6006960")]
		void Stop();

		// Token: 0x06006961 RID: 26977
		[Token(Token = "0x6006961")]
		void Load<T>(string assetName, IContentSource source, LoadAssetDelegate<T> callback) where T : class;

		// Token: 0x06006962 RID: 26978
		[Token(Token = "0x6006962")]
		void TransferCompleted();
	}
}
