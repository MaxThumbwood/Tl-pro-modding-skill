using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.FishDropRules
{
	// Token: 0x02000AF1 RID: 2801
	[Token(Token = "0x2000AF1")]
	public class FishDropRuleList
	{
		// Token: 0x06005798 RID: 22424 RVA: 0x000289C8 File Offset: 0x00026BC8
		[Token(Token = "0x6005798")]
		[Address(RVA = "0x85097C", Offset = "0x85097C", VA = "0x85097C")]
		public int TryGetItemDropType(FishingContext context)
		{
			return 0;
		}

		// Token: 0x06005799 RID: 22425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005799")]
		[Address(RVA = "0x850A6C", Offset = "0x850A6C", VA = "0x850A6C")]
		public void GetDisplayableDrops(FishingContext context, List<FishPossibilityEntry> resultTypes)
		{
		}

		// Token: 0x0600579A RID: 22426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600579A")]
		[Address(RVA = "0x850D34", Offset = "0x850D34", VA = "0x850D34")]
		public void Add(FishDropRule rule)
		{
		}

		// Token: 0x0600579B RID: 22427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600579B")]
		[Address(RVA = "0x850DF8", Offset = "0x850DF8", VA = "0x850DF8")]
		private void Validate(FishDropRule rule)
		{
		}

		// Token: 0x0600579C RID: 22428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600579C")]
		[Address(RVA = "0x850E8C", Offset = "0x850E8C", VA = "0x850E8C")]
		public FishDropRuleList()
		{
		}

		// Token: 0x04009900 RID: 39168
		[Token(Token = "0x4009900")]
		[FieldOffset(Offset = "0x8")]
		private List<FishDropRule> _rules;
	}
}
