using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.FishDropRules
{
	// Token: 0x02000AFF RID: 2815
	[Token(Token = "0x2000AFF")]
	public class FishingConditions
	{
		// Token: 0x06005804 RID: 22532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005804")]
		[Address(RVA = "0x85C438", Offset = "0x85C438", VA = "0x85C438")]
		public FishingConditions()
		{
		}

		// Token: 0x02000B00 RID: 2816
		[Token(Token = "0x2000B00")]
		public class QuestFishCondition : AFishingCondition
		{
			// Token: 0x06005805 RID: 22533 RVA: 0x00028E78 File Offset: 0x00027078
			[Token(Token = "0x6005805")]
			[Address(RVA = "0x85C440", Offset = "0x85C440", VA = "0x85C440", Slot = "4")]
			public override bool Matches(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x06005806 RID: 22534 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005806")]
			[Address(RVA = "0x8532FC", Offset = "0x8532FC", VA = "0x8532FC")]
			public QuestFishCondition()
			{
			}

			// Token: 0x04009967 RID: 39271
			[Token(Token = "0x4009967")]
			[FieldOffset(Offset = "0xC")]
			public int CheckedType;
		}

		// Token: 0x02000B01 RID: 2817
		[Token(Token = "0x2000B01")]
		public class QuestFishConditionRemix : AFishingCondition
		{
			// Token: 0x06005807 RID: 22535 RVA: 0x00028E90 File Offset: 0x00027090
			[Token(Token = "0x6005807")]
			[Address(RVA = "0x85C470", Offset = "0x85C470", VA = "0x85C470", Slot = "4")]
			public override bool Matches(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x06005808 RID: 22536 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005808")]
			[Address(RVA = "0x853548", Offset = "0x853548", VA = "0x853548")]
			public QuestFishConditionRemix()
			{
			}

			// Token: 0x04009968 RID: 39272
			[Token(Token = "0x4009968")]
			[FieldOffset(Offset = "0xC")]
			public int CheckedType;
		}
	}
}
