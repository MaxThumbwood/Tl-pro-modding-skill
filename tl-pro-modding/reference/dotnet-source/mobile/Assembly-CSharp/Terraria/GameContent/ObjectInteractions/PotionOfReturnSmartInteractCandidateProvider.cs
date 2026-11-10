using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.ObjectInteractions
{
	// Token: 0x02000A3B RID: 2619
	[Token(Token = "0x2000A3B")]
	public class PotionOfReturnSmartInteractCandidateProvider : FileAPI
	{
		// Token: 0x06005430 RID: 21552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005430")]
		[Address(RVA = "0x8129E8", Offset = "0x8129E8", VA = "0x8129E8", Slot = "4")]
		public void ClearSelfAndPrepareForCheck()
		{
		}

		// Token: 0x06005431 RID: 21553 RVA: 0x00027168 File Offset: 0x00025368
		[Token(Token = "0x6005431")]
		[Address(RVA = "0x812A4C", Offset = "0x812A4C", VA = "0x812A4C", Slot = "5")]
		public bool ProvideCandidate(SmartInteractScanSettings settings, out ISmartInteractCandidate candidate)
		{
			return default(bool);
		}

		// Token: 0x06005432 RID: 21554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005432")]
		[Address(RVA = "0x812DF8", Offset = "0x812DF8", VA = "0x812DF8")]
		public PotionOfReturnSmartInteractCandidateProvider()
		{
		}

		// Token: 0x040097D6 RID: 38870
		[Token(Token = "0x40097D6")]
		[FieldOffset(Offset = "0x8")]
		private PotionOfReturnSmartInteractCandidateProvider.ReusableCandidate _candidate;

		// Token: 0x02000A3C RID: 2620
		[Token(Token = "0x2000A3C")]
		private class ReusableCandidate : FileAPI
		{
			// Token: 0x170009CA RID: 2506
			// (get) Token: 0x06005433 RID: 21555 RVA: 0x00027180 File Offset: 0x00025380
			// (set) Token: 0x06005434 RID: 21556 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170009CA")]
			public float DistanceFromCursor
			{
				[Token(Token = "0x6005433")]
				[Address(RVA = "0x812E7C", Offset = "0x812E7C", VA = "0x812E7C", Slot = "4")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6005434")]
				[Address(RVA = "0x812E84", Offset = "0x812E84", VA = "0x812E84")]
				private set
				{
				}
			}

			// Token: 0x06005435 RID: 21557 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005435")]
			[Address(RVA = "0x812E8C", Offset = "0x812E8C", VA = "0x812E8C", Slot = "5")]
			public void WinCandidacy()
			{
			}

			// Token: 0x06005436 RID: 21558 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005436")]
			[Address(RVA = "0x812DF0", Offset = "0x812DF0", VA = "0x812DF0")]
			public void Reuse(float distanceFromCursor)
			{
			}

			// Token: 0x06005437 RID: 21559 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005437")]
			[Address(RVA = "0x812E74", Offset = "0x812E74", VA = "0x812E74")]
			public ReusableCandidate()
			{
			}

			// Token: 0x040097D7 RID: 38871
			[Token(Token = "0x40097D7")]
			[FieldOffset(Offset = "0x8")]
			private float <DistanceFromCursor>k__BackingField;
		}
	}
}
