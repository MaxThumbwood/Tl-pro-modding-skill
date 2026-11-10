using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000A80 RID: 2688
	[Token(Token = "0x2000A80")]
	public struct DropRateInfoChainFeed
	{
		// Token: 0x0600559A RID: 21914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600559A")]
		[Address(RVA = "0x82B25C", Offset = "0x82B25C", VA = "0x82B25C")]
		public void AddCondition(IItemDropRuleCondition condition)
		{
		}

		// Token: 0x0600559B RID: 21915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600559B")]
		[Address(RVA = "0x82B384", Offset = "0x82B384", VA = "0x82B384")]
		public DropRateInfoChainFeed(float droprate)
		{
		}

		// Token: 0x0600559C RID: 21916 RVA: 0x00027780 File Offset: 0x00025980
		[Token(Token = "0x600559C")]
		[Address(RVA = "0x82B390", Offset = "0x82B390", VA = "0x82B390")]
		public DropRateInfoChainFeed With(float multiplier)
		{
			return default(DropRateInfoChainFeed);
		}

		// Token: 0x040098A5 RID: 39077
		[Token(Token = "0x40098A5")]
		[FieldOffset(Offset = "0x0")]
		public float parentDroprateChance;

		// Token: 0x040098A6 RID: 39078
		[Token(Token = "0x40098A6")]
		[FieldOffset(Offset = "0x4")]
		public List<IItemDropRuleCondition> conditions;
	}
}
