using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.ObjectInteractions
{
	// Token: 0x02000A39 RID: 2617
	[Token(Token = "0x2000A39")]
	public class ProjectileSmartInteractCandidateProvider : FileAPI
	{
		// Token: 0x06005428 RID: 21544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005428")]
		[Address(RVA = "0x8124CC", Offset = "0x8124CC", VA = "0x8124CC", Slot = "4")]
		public void ClearSelfAndPrepareForCheck()
		{
		}

		// Token: 0x06005429 RID: 21545 RVA: 0x00027138 File Offset: 0x00025338
		[Token(Token = "0x6005429")]
		[Address(RVA = "0x812530", Offset = "0x812530", VA = "0x812530", Slot = "5")]
		public bool ProvideCandidate(SmartInteractScanSettings settings, out ISmartInteractCandidate candidate)
		{
			return default(bool);
		}

		// Token: 0x0600542A RID: 21546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600542A")]
		[Address(RVA = "0x8128DC", Offset = "0x8128DC", VA = "0x8128DC")]
		public ProjectileSmartInteractCandidateProvider()
		{
		}

		// Token: 0x040097D3 RID: 38867
		[Token(Token = "0x40097D3")]
		[FieldOffset(Offset = "0x8")]
		private ProjectileSmartInteractCandidateProvider.ReusableCandidate _candidate;

		// Token: 0x02000A3A RID: 2618
		[Token(Token = "0x2000A3A")]
		private class ReusableCandidate : FileAPI
		{
			// Token: 0x170009C9 RID: 2505
			// (get) Token: 0x0600542B RID: 21547 RVA: 0x00027150 File Offset: 0x00025350
			// (set) Token: 0x0600542C RID: 21548 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170009C9")]
			public float DistanceFromCursor
			{
				[Token(Token = "0x600542B")]
				[Address(RVA = "0x812960", Offset = "0x812960", VA = "0x812960", Slot = "4")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x600542C")]
				[Address(RVA = "0x812968", Offset = "0x812968", VA = "0x812968")]
				private set
				{
				}
			}

			// Token: 0x0600542D RID: 21549 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600542D")]
			[Address(RVA = "0x812970", Offset = "0x812970", VA = "0x812970", Slot = "5")]
			public void WinCandidacy()
			{
			}

			// Token: 0x0600542E RID: 21550 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600542E")]
			[Address(RVA = "0x8128D0", Offset = "0x8128D0", VA = "0x8128D0")]
			public void Reuse(int projectileIndex, float projectileDistanceFromCursor)
			{
			}

			// Token: 0x0600542F RID: 21551 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600542F")]
			[Address(RVA = "0x812958", Offset = "0x812958", VA = "0x812958")]
			public ReusableCandidate()
			{
			}

			// Token: 0x040097D4 RID: 38868
			[Token(Token = "0x40097D4")]
			[FieldOffset(Offset = "0x8")]
			private float <DistanceFromCursor>k__BackingField;

			// Token: 0x040097D5 RID: 38869
			[Token(Token = "0x40097D5")]
			[FieldOffset(Offset = "0xC")]
			private int _projectileIndexToTarget;
		}
	}
}
