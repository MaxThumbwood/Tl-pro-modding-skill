using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.FishDropRules
{
	// Token: 0x02000AEF RID: 2799
	[Token(Token = "0x2000AEF")]
	public class FishDropRule
	{
		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06005794 RID: 22420 RVA: 0x00028980 File Offset: 0x00026B80
		[Token(Token = "0x170009EA")]
		public bool IsStopper
		{
			[Token(Token = "0x6005794")]
			[Address(RVA = "0x8506E0", Offset = "0x8506E0", VA = "0x8506E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005795 RID: 22421 RVA: 0x00028998 File Offset: 0x00026B98
		[Token(Token = "0x6005795")]
		[Address(RVA = "0x850748", Offset = "0x850748", VA = "0x850748")]
		public bool Attempt(FishingContext context, out int resultItemType)
		{
			return default(bool);
		}

		// Token: 0x06005796 RID: 22422 RVA: 0x000289B0 File Offset: 0x00026BB0
		[Token(Token = "0x6005796")]
		[Address(RVA = "0x8508E8", Offset = "0x8508E8", VA = "0x8508E8")]
		public bool MeetsConditions(FishingContext context, bool forDisplay)
		{
			return default(bool);
		}

		// Token: 0x06005797 RID: 22423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005797")]
		[Address(RVA = "0x850968", Offset = "0x850968", VA = "0x850968")]
		public FishDropRule()
		{
		}

		// Token: 0x040098F9 RID: 39161
		[Token(Token = "0x40098F9")]
		[FieldOffset(Offset = "0x8")]
		public int[] PossibleItems;

		// Token: 0x040098FA RID: 39162
		[Token(Token = "0x40098FA")]
		[FieldOffset(Offset = "0xC")]
		public int ChanceNumerator;

		// Token: 0x040098FB RID: 39163
		[Token(Token = "0x40098FB")]
		[FieldOffset(Offset = "0x10")]
		public int ChanceDenominator;

		// Token: 0x040098FC RID: 39164
		[Token(Token = "0x40098FC")]
		[FieldOffset(Offset = "0x14")]
		public AFishingCondition[] Conditions;

		// Token: 0x040098FD RID: 39165
		[Token(Token = "0x40098FD")]
		[FieldOffset(Offset = "0x18")]
		public FishRarityCondition Rarity;
	}
}
