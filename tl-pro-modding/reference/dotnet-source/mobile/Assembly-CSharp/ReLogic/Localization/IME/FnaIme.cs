using System;
using Il2CppDummyDll;

namespace ReLogic.Localization.IME
{
	// Token: 0x02000DF8 RID: 3576
	[Token(Token = "0x2000DF8")]
	internal class FnaIme : PlatformIme
	{
		// Token: 0x060068C7 RID: 26823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068C7")]
		[Address(RVA = "0xB82E50", Offset = "0xB82E50", VA = "0xB82E50")]
		public FnaIme()
		{
		}

		// Token: 0x060068C8 RID: 26824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068C8")]
		[Address(RVA = "0xB82F90", Offset = "0xB82F90", VA = "0xB82F90")]
		private void OnCharCallback(char key)
		{
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x060068C9 RID: 26825 RVA: 0x0002F8F8 File Offset: 0x0002DAF8
		[Token(Token = "0x17000B28")]
		public override uint CandidateCount
		{
			[Token(Token = "0x60068C9")]
			[Address(RVA = "0xB83148", Offset = "0xB83148", VA = "0xB83148", Slot = "18")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x060068CA RID: 26826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B29")]
		public override string CompositionString
		{
			[Token(Token = "0x60068CA")]
			[Address(RVA = "0xB83150", Offset = "0xB83150", VA = "0xB83150", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x060068CB RID: 26827 RVA: 0x0002F910 File Offset: 0x0002DB10
		[Token(Token = "0x17000B2A")]
		public override bool IsCandidateListVisible
		{
			[Token(Token = "0x60068CB")]
			[Address(RVA = "0xB831A0", Offset = "0xB831A0", VA = "0xB831A0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x060068CC RID: 26828 RVA: 0x0002F928 File Offset: 0x0002DB28
		[Token(Token = "0x17000B2B")]
		public override uint SelectedCandidate
		{
			[Token(Token = "0x60068CC")]
			[Address(RVA = "0xB831A8", Offset = "0xB831A8", VA = "0xB831A8", Slot = "17")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x060068CD RID: 26829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068CD")]
		[Address(RVA = "0xB831B0", Offset = "0xB831B0", VA = "0xB831B0", Slot = "19")]
		public override string GetCandidate(uint index)
		{
			return null;
		}

		// Token: 0x060068CE RID: 26830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068CE")]
		[Address(RVA = "0xB83200", Offset = "0xB83200", VA = "0xB83200", Slot = "22")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x060068CF RID: 26831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068CF")]
		[Address(RVA = "0xB8327C", Offset = "0xB8327C", VA = "0xB8327C", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x0400A514 RID: 42260
		[Token(Token = "0x400A514")]
		[FieldOffset(Offset = "0x11")]
		private bool _disposedValue;
	}
}
