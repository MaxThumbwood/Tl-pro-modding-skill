using System;
using Il2CppDummyDll;

namespace ReLogic.Localization.IME
{
	// Token: 0x02000DF9 RID: 3577
	[Token(Token = "0x2000DF9")]
	public interface IImeService
	{
		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x060068D0 RID: 26832
		[Token(Token = "0x17000B2C")]
		string CompositionString
		{
			[Token(Token = "0x60068D0")]
			get;
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x060068D1 RID: 26833
		[Token(Token = "0x17000B2D")]
		bool IsCandidateListVisible
		{
			[Token(Token = "0x60068D1")]
			get;
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x060068D2 RID: 26834
		[Token(Token = "0x17000B2E")]
		uint SelectedCandidate
		{
			[Token(Token = "0x60068D2")]
			get;
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x060068D3 RID: 26835
		[Token(Token = "0x17000B2F")]
		uint CandidateCount
		{
			[Token(Token = "0x60068D3")]
			get;
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x060068D4 RID: 26836
		[Token(Token = "0x17000B30")]
		bool IsEnabled
		{
			[Token(Token = "0x60068D4")]
			get;
		}

		// Token: 0x060068D5 RID: 26837
		[Token(Token = "0x60068D5")]
		string GetCandidate(uint index);

		// Token: 0x060068D6 RID: 26838
		[Token(Token = "0x60068D6")]
		void Enable();

		// Token: 0x060068D7 RID: 26839
		[Token(Token = "0x60068D7")]
		void Disable();

		// Token: 0x060068D8 RID: 26840
		[Token(Token = "0x60068D8")]
		void AddKeyListener(Action<char> listener);

		// Token: 0x060068D9 RID: 26841
		[Token(Token = "0x60068D9")]
		void RemoveKeyListener(Action<char> listener);
	}
}
