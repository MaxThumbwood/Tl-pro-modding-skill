using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000AED RID: 2797
	[Token(Token = "0x2000AED")]
	public class ItemDropResolver
	{
		// Token: 0x0600578B RID: 22411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600578B")]
		[Address(RVA = "0x84FDDC", Offset = "0x84FDDC", VA = "0x84FDDC")]
		public ItemDropResolver(ItemDropDatabase database)
		{
		}

		// Token: 0x0600578C RID: 22412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600578C")]
		[Address(RVA = "0x84FDF8", Offset = "0x84FDF8", VA = "0x84FDF8")]
		public void TryDropping(DropAttemptInfo info)
		{
		}

		// Token: 0x0600578D RID: 22413 RVA: 0x00028968 File Offset: 0x00026B68
		[Token(Token = "0x600578D")]
		[Address(RVA = "0x84FEF4", Offset = "0x84FEF4", VA = "0x84FEF4")]
		private ItemDropAttemptResult ResolveRule(IItemDropRule rule, DropAttemptInfo info)
		{
			return default(ItemDropAttemptResult);
		}

		// Token: 0x0600578E RID: 22414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600578E")]
		[Address(RVA = "0x8501B4", Offset = "0x8501B4", VA = "0x8501B4")]
		private void ResolveRuleChains(IItemDropRule rule, DropAttemptInfo info, ItemDropAttemptResult parentResult)
		{
		}

		// Token: 0x0600578F RID: 22415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600578F")]
		[Address(RVA = "0x85040C", Offset = "0x85040C", VA = "0x85040C")]
		private void ResolveRuleChains(ref DropAttemptInfo info, ref ItemDropAttemptResult parentResult, List<IItemDropRuleChainAttempt> ruleChains)
		{
		}

		// Token: 0x040098F8 RID: 39160
		[Token(Token = "0x40098F8")]
		[FieldOffset(Offset = "0x8")]
		private ItemDropDatabase _database;
	}
}
