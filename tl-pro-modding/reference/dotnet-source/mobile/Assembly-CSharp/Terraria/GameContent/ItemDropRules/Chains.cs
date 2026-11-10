using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000AA0 RID: 2720
	[Token(Token = "0x2000AA0")]
	public static class Chains
	{
		// Token: 0x06005622 RID: 22050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005622")]
		[Address(RVA = "0x82CAE4", Offset = "0x82CAE4", VA = "0x82CAE4")]
		public static void ReportDroprates(List<IItemDropRuleChainAttempt> ChainedRules, float personalDropRate, List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
		}

		// Token: 0x06005623 RID: 22051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005623")]
		[Address(RVA = "0x831F48", Offset = "0x831F48", VA = "0x831F48")]
		public static IItemDropRule OnFailedRoll(IItemDropRule rule, IItemDropRule ruleToChain, bool hideLootReport = false)
		{
			return null;
		}

		// Token: 0x06005624 RID: 22052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005624")]
		[Address(RVA = "0x832104", Offset = "0x832104", VA = "0x832104")]
		public static IItemDropRule OnSuccess(IItemDropRule rule, IItemDropRule ruleToChain, bool hideLootReport = false)
		{
			return null;
		}

		// Token: 0x06005625 RID: 22053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005625")]
		[Address(RVA = "0x8322C0", Offset = "0x8322C0", VA = "0x8322C0")]
		public static IItemDropRule OnFailedConditions(IItemDropRule rule, IItemDropRule ruleToChain, bool hideLootReport = false)
		{
			return null;
		}

		// Token: 0x02000AA1 RID: 2721
		[Token(Token = "0x2000AA1")]
		public class TryIfFailedRandomRoll : FileAPI
		{
			// Token: 0x170009E7 RID: 2535
			// (get) Token: 0x06005626 RID: 22054 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06005627 RID: 22055 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170009E7")]
			public IItemDropRule RuleToChain
			{
				[Token(Token = "0x6005626")]
				[Address(RVA = "0x83247C", Offset = "0x83247C", VA = "0x83247C", Slot = "4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6005627")]
				[Address(RVA = "0x832484", Offset = "0x832484", VA = "0x832484")]
				private set
				{
				}
			}

			// Token: 0x06005628 RID: 22056 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005628")]
			[Address(RVA = "0x8320E0", Offset = "0x8320E0", VA = "0x8320E0")]
			public TryIfFailedRandomRoll(IItemDropRule rule, bool hideLootReport = false)
			{
			}

			// Token: 0x06005629 RID: 22057 RVA: 0x00027BD0 File Offset: 0x00025DD0
			[Token(Token = "0x6005629")]
			[Address(RVA = "0x83248C", Offset = "0x83248C", VA = "0x83248C", Slot = "5")]
			public bool CanChainIntoRule(ItemDropAttemptResult parentResult)
			{
				return default(bool);
			}

			// Token: 0x0600562A RID: 22058 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600562A")]
			[Address(RVA = "0x83249C", Offset = "0x83249C", VA = "0x83249C", Slot = "6")]
			public void ReportDroprates(float personalDropRate, List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
			{
			}

			// Token: 0x040098E7 RID: 39143
			[Token(Token = "0x40098E7")]
			[FieldOffset(Offset = "0x8")]
			private IItemDropRule <RuleToChain>k__BackingField;

			// Token: 0x040098E8 RID: 39144
			[Token(Token = "0x40098E8")]
			[FieldOffset(Offset = "0xC")]
			public bool hideLootReport;
		}

		// Token: 0x02000AA2 RID: 2722
		[Token(Token = "0x2000AA2")]
		public class TryIfSucceeded : FileAPI
		{
			// Token: 0x170009E8 RID: 2536
			// (get) Token: 0x0600562B RID: 22059 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600562C RID: 22060 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170009E8")]
			public IItemDropRule RuleToChain
			{
				[Token(Token = "0x600562B")]
				[Address(RVA = "0x832638", Offset = "0x832638", VA = "0x832638", Slot = "4")]
				get
				{
					return null;
				}
				[Token(Token = "0x600562C")]
				[Address(RVA = "0x832640", Offset = "0x832640", VA = "0x832640")]
				private set
				{
				}
			}

			// Token: 0x0600562D RID: 22061 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600562D")]
			[Address(RVA = "0x83229C", Offset = "0x83229C", VA = "0x83229C")]
			public TryIfSucceeded(IItemDropRule rule, bool hideLootReport = false)
			{
			}

			// Token: 0x0600562E RID: 22062 RVA: 0x00027BE8 File Offset: 0x00025DE8
			[Token(Token = "0x600562E")]
			[Address(RVA = "0x832648", Offset = "0x832648", VA = "0x832648", Slot = "5")]
			public bool CanChainIntoRule(ItemDropAttemptResult parentResult)
			{
				return default(bool);
			}

			// Token: 0x0600562F RID: 22063 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600562F")]
			[Address(RVA = "0x832658", Offset = "0x832658", VA = "0x832658", Slot = "6")]
			public void ReportDroprates(float personalDropRate, List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
			{
			}

			// Token: 0x040098E9 RID: 39145
			[Token(Token = "0x40098E9")]
			[FieldOffset(Offset = "0x8")]
			private IItemDropRule <RuleToChain>k__BackingField;

			// Token: 0x040098EA RID: 39146
			[Token(Token = "0x40098EA")]
			[FieldOffset(Offset = "0xC")]
			public bool hideLootReport;
		}

		// Token: 0x02000AA3 RID: 2723
		[Token(Token = "0x2000AA3")]
		public class TryIfDoesntFillConditions : FileAPI
		{
			// Token: 0x170009E9 RID: 2537
			// (get) Token: 0x06005630 RID: 22064 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06005631 RID: 22065 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170009E9")]
			public IItemDropRule RuleToChain
			{
				[Token(Token = "0x6005630")]
				[Address(RVA = "0x8327EC", Offset = "0x8327EC", VA = "0x8327EC", Slot = "4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6005631")]
				[Address(RVA = "0x8327F4", Offset = "0x8327F4", VA = "0x8327F4")]
				private set
				{
				}
			}

			// Token: 0x06005632 RID: 22066 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005632")]
			[Address(RVA = "0x832458", Offset = "0x832458", VA = "0x832458")]
			public TryIfDoesntFillConditions(IItemDropRule rule, bool hideLootReport = false)
			{
			}

			// Token: 0x06005633 RID: 22067 RVA: 0x00027C00 File Offset: 0x00025E00
			[Token(Token = "0x6005633")]
			[Address(RVA = "0x8327FC", Offset = "0x8327FC", VA = "0x8327FC", Slot = "5")]
			public bool CanChainIntoRule(ItemDropAttemptResult parentResult)
			{
				return default(bool);
			}

			// Token: 0x06005634 RID: 22068 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005634")]
			[Address(RVA = "0x832808", Offset = "0x832808", VA = "0x832808", Slot = "6")]
			public void ReportDroprates(float personalDropRate, List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
			{
			}

			// Token: 0x040098EB RID: 39147
			[Token(Token = "0x40098EB")]
			[FieldOffset(Offset = "0x8")]
			private IItemDropRule <RuleToChain>k__BackingField;

			// Token: 0x040098EC RID: 39148
			[Token(Token = "0x40098EC")]
			[FieldOffset(Offset = "0xC")]
			public bool hideLootReport;
		}
	}
}
