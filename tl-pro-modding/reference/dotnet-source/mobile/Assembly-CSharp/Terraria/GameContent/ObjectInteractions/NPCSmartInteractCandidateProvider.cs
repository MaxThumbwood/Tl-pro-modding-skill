using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.ObjectInteractions
{
	// Token: 0x02000A37 RID: 2615
	[Token(Token = "0x2000A37")]
	public class NPCSmartInteractCandidateProvider : FileAPI
	{
		// Token: 0x0600541E RID: 21534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600541E")]
		[Address(RVA = "0x811E04", Offset = "0x811E04", VA = "0x811E04", Slot = "4")]
		public void ClearSelfAndPrepareForCheck()
		{
		}

		// Token: 0x0600541F RID: 21535 RVA: 0x000270F0 File Offset: 0x000252F0
		[Token(Token = "0x600541F")]
		[Address(RVA = "0x811E68", Offset = "0x811E68", VA = "0x811E68", Slot = "5")]
		public bool ProvideCandidate(SmartInteractScanSettings settings, out ISmartInteractCandidate candidate)
		{
			return default(bool);
		}

		// Token: 0x06005420 RID: 21536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005420")]
		[Address(RVA = "0x812370", Offset = "0x812370", VA = "0x812370")]
		public NPCSmartInteractCandidateProvider()
		{
		}

		// Token: 0x040097CF RID: 38863
		[Token(Token = "0x40097CF")]
		[FieldOffset(Offset = "0x8")]
		private NPCSmartInteractCandidateProvider.ReusableCandidate _candidate;

		// Token: 0x02000A38 RID: 2616
		[Token(Token = "0x2000A38")]
		public class ReusableCandidate : FileAPI
		{
			// Token: 0x170009C7 RID: 2503
			// (get) Token: 0x06005421 RID: 21537 RVA: 0x00027108 File Offset: 0x00025308
			// (set) Token: 0x06005422 RID: 21538 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170009C7")]
			public float DistanceFromCursor
			{
				[Token(Token = "0x6005421")]
				[Address(RVA = "0x8123F4", Offset = "0x8123F4", VA = "0x8123F4", Slot = "4")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6005422")]
				[Address(RVA = "0x8123FC", Offset = "0x8123FC", VA = "0x8123FC")]
				private set
				{
				}
			}

			// Token: 0x170009C8 RID: 2504
			// (get) Token: 0x06005423 RID: 21539 RVA: 0x00027120 File Offset: 0x00025320
			// (set) Token: 0x06005424 RID: 21540 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170009C8")]
			public float CentreDistance
			{
				[Token(Token = "0x6005423")]
				[Address(RVA = "0x812404", Offset = "0x812404", VA = "0x812404")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6005424")]
				[Address(RVA = "0x81240C", Offset = "0x81240C", VA = "0x81240C")]
				private set
				{
				}
			}

			// Token: 0x06005425 RID: 21541 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005425")]
			[Address(RVA = "0x812414", Offset = "0x812414", VA = "0x812414", Slot = "5")]
			public void WinCandidacy()
			{
			}

			// Token: 0x06005426 RID: 21542 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005426")]
			[Address(RVA = "0x812360", Offset = "0x812360", VA = "0x812360")]
			public void Reuse(int npcIndex, float npcDistanceFromCursor, float centreDistanceFromCursor)
			{
			}

			// Token: 0x06005427 RID: 21543 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005427")]
			[Address(RVA = "0x8123EC", Offset = "0x8123EC", VA = "0x8123EC")]
			public ReusableCandidate()
			{
			}

			// Token: 0x040097D0 RID: 38864
			[Token(Token = "0x40097D0")]
			[FieldOffset(Offset = "0x8")]
			private float <DistanceFromCursor>k__BackingField;

			// Token: 0x040097D1 RID: 38865
			[Token(Token = "0x40097D1")]
			[FieldOffset(Offset = "0xC")]
			private float <CentreDistance>k__BackingField;

			// Token: 0x040097D2 RID: 38866
			[Token(Token = "0x40097D2")]
			[FieldOffset(Offset = "0x10")]
			private int _npcIndexToTarget;
		}
	}
}
