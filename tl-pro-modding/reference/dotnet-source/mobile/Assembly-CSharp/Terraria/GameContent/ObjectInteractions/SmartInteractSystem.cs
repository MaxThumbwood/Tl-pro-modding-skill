using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.ObjectInteractions
{
	// Token: 0x02000A33 RID: 2611
	[Token(Token = "0x2000A33")]
	public class SmartInteractSystem
	{
		// Token: 0x0600540E RID: 21518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600540E")]
		[Address(RVA = "0x80E9E4", Offset = "0x80E9E4", VA = "0x80E9E4")]
		public SmartInteractSystem()
		{
		}

		// Token: 0x0600540F RID: 21519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600540F")]
		[Address(RVA = "0x80EEE4", Offset = "0x80EEE4", VA = "0x80EEE4")]
		public void Clear()
		{
		}

		// Token: 0x06005410 RID: 21520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005410")]
		[Address(RVA = "0x80F140", Offset = "0x80F140", VA = "0x80F140")]
		public void RunQuery(SmartInteractScanSettings settings)
		{
		}

		// Token: 0x040097C1 RID: 38849
		[Token(Token = "0x40097C1")]
		[FieldOffset(Offset = "0x8")]
		private List<ISmartInteractCandidateProvider> _candidateProvidersByOrderOfPriority;

		// Token: 0x040097C2 RID: 38850
		[Token(Token = "0x40097C2")]
		[FieldOffset(Offset = "0xC")]
		private List<ISmartInteractBlockReasonProvider> _blockProviders;

		// Token: 0x040097C3 RID: 38851
		[Token(Token = "0x40097C3")]
		[FieldOffset(Offset = "0x10")]
		private List<ISmartInteractCandidate> _candidates;
	}
}
