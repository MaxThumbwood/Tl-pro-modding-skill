using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.ObjectInteractions
{
	// Token: 0x02000A35 RID: 2613
	[Token(Token = "0x2000A35")]
	public class TileSmartInteractCandidateProvider : FileAPI
	{
		// Token: 0x06005413 RID: 21523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005413")]
		[Address(RVA = "0x80FDC0", Offset = "0x80FDC0", VA = "0x80FDC0", Slot = "4")]
		public void ClearSelfAndPrepareForCheck()
		{
		}

		// Token: 0x06005414 RID: 21524 RVA: 0x000270A8 File Offset: 0x000252A8
		[Token(Token = "0x6005414")]
		[Address(RVA = "0x80FEE4", Offset = "0x80FEE4", VA = "0x80FEE4")]
		private int JoinValue(int x, int y)
		{
			return 0;
		}

		// Token: 0x06005415 RID: 21525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005415")]
		[Address(RVA = "0x80FEEC", Offset = "0x80FEEC", VA = "0x80FEEC")]
		private void SplitValue(int value, out int x, out int y)
		{
		}

		// Token: 0x06005416 RID: 21526 RVA: 0x000270C0 File Offset: 0x000252C0
		[Token(Token = "0x6005416")]
		[Address(RVA = "0x80FF00", Offset = "0x80FF00", VA = "0x80FF00", Slot = "5")]
		public bool ProvideCandidate(SmartInteractScanSettings settings, out ISmartInteractCandidate candidate)
		{
			return default(bool);
		}

		// Token: 0x06005417 RID: 21527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005417")]
		[Address(RVA = "0x811290", Offset = "0x811290", VA = "0x811290")]
		private void FillPotentialTargetTiles(SmartInteractScanSettings settings)
		{
		}

		// Token: 0x06005418 RID: 21528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005418")]
		[Address(RVA = "0x811B90", Offset = "0x811B90", VA = "0x811B90")]
		public TileSmartInteractCandidateProvider()
		{
		}

		// Token: 0x040097C4 RID: 38852
		[Token(Token = "0x40097C4")]
		[FieldOffset(Offset = "0x8")]
		private List<int> targets;

		// Token: 0x040097C5 RID: 38853
		[Token(Token = "0x40097C5")]
		[FieldOffset(Offset = "0xC")]
		private TileSmartInteractCandidateProvider.ReusableCandidate _candidate;

		// Token: 0x040097C6 RID: 38854
		[Token(Token = "0x40097C6")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<int, bool> AddedTileObjects;

		// Token: 0x02000A36 RID: 2614
		[Token(Token = "0x2000A36")]
		public class ReusableCandidate : FileAPI
		{
			// Token: 0x06005419 RID: 21529 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005419")]
			[Address(RVA = "0x811B54", Offset = "0x811B54", VA = "0x811B54")]
			public void Reuse(bool strictSettings, float distanceFromCursor, int AimedX, int AimedY, int LX, int LY, int HX, int HY)
			{
			}

			// Token: 0x170009C6 RID: 2502
			// (get) Token: 0x0600541A RID: 21530 RVA: 0x000270D8 File Offset: 0x000252D8
			// (set) Token: 0x0600541B RID: 21531 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170009C6")]
			public float DistanceFromCursor
			{
				[Token(Token = "0x600541A")]
				[Address(RVA = "0x811CD4", Offset = "0x811CD4", VA = "0x811CD4", Slot = "4")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x600541B")]
				[Address(RVA = "0x811CDC", Offset = "0x811CDC", VA = "0x811CDC")]
				private set
				{
				}
			}

			// Token: 0x0600541C RID: 21532 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600541C")]
			[Address(RVA = "0x811CE4", Offset = "0x811CE4", VA = "0x811CE4", Slot = "5")]
			public void WinCandidacy()
			{
			}

			// Token: 0x0600541D RID: 21533 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600541D")]
			[Address(RVA = "0x811CCC", Offset = "0x811CCC", VA = "0x811CCC")]
			public ReusableCandidate()
			{
			}

			// Token: 0x040097C7 RID: 38855
			[Token(Token = "0x40097C7")]
			[FieldOffset(Offset = "0x8")]
			private bool _strictSettings;

			// Token: 0x040097C8 RID: 38856
			[Token(Token = "0x40097C8")]
			[FieldOffset(Offset = "0xC")]
			private int _aimedX;

			// Token: 0x040097C9 RID: 38857
			[Token(Token = "0x40097C9")]
			[FieldOffset(Offset = "0x10")]
			private int _aimedY;

			// Token: 0x040097CA RID: 38858
			[Token(Token = "0x40097CA")]
			[FieldOffset(Offset = "0x14")]
			private int _hx;

			// Token: 0x040097CB RID: 38859
			[Token(Token = "0x40097CB")]
			[FieldOffset(Offset = "0x18")]
			private int _hy;

			// Token: 0x040097CC RID: 38860
			[Token(Token = "0x40097CC")]
			[FieldOffset(Offset = "0x1C")]
			private int _lx;

			// Token: 0x040097CD RID: 38861
			[Token(Token = "0x40097CD")]
			[FieldOffset(Offset = "0x20")]
			private int _ly;

			// Token: 0x040097CE RID: 38862
			[Token(Token = "0x40097CE")]
			[FieldOffset(Offset = "0x24")]
			private float <DistanceFromCursor>k__BackingField;
		}
	}
}
