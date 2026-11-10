using System;
using Il2CppDummyDll;

namespace ReLogic.Localization.IME
{
	// Token: 0x02000DFB RID: 3579
	[Token(Token = "0x2000DFB")]
	public class UnsupportedPlatformIme : PlatformIme
	{
		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x060068EC RID: 26860 RVA: 0x0002F958 File Offset: 0x0002DB58
		[Token(Token = "0x17000B36")]
		public override uint CandidateCount
		{
			[Token(Token = "0x60068EC")]
			[Address(RVA = "0xB835B8", Offset = "0xB835B8", VA = "0xB835B8", Slot = "18")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x060068ED RID: 26861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B37")]
		public override string CompositionString
		{
			[Token(Token = "0x60068ED")]
			[Address(RVA = "0xB835C0", Offset = "0xB835C0", VA = "0xB835C0", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x060068EE RID: 26862 RVA: 0x0002F970 File Offset: 0x0002DB70
		[Token(Token = "0x17000B38")]
		public override bool IsCandidateListVisible
		{
			[Token(Token = "0x60068EE")]
			[Address(RVA = "0xB83610", Offset = "0xB83610", VA = "0xB83610", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x060068EF RID: 26863 RVA: 0x0002F988 File Offset: 0x0002DB88
		[Token(Token = "0x17000B39")]
		public override uint SelectedCandidate
		{
			[Token(Token = "0x60068EF")]
			[Address(RVA = "0xB83618", Offset = "0xB83618", VA = "0xB83618", Slot = "17")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x060068F0 RID: 26864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068F0")]
		[Address(RVA = "0xB83620", Offset = "0xB83620", VA = "0xB83620", Slot = "19")]
		public override string GetCandidate(uint index)
		{
			return null;
		}

		// Token: 0x060068F1 RID: 26865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068F1")]
		[Address(RVA = "0xB83670", Offset = "0xB83670", VA = "0xB83670")]
		public UnsupportedPlatformIme()
		{
		}
	}
}
