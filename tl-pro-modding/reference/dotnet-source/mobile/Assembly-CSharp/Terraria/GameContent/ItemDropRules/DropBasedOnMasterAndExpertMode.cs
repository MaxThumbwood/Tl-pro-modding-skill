using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000A94 RID: 2708
	[Token(Token = "0x2000A94")]
	public class DropBasedOnMasterAndExpertMode : FileAPI, GUIControllerItem
	{
		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x060055DF RID: 21983 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060055E0 RID: 21984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009DD")]
		public List<IItemDropRuleChainAttempt> ChainedRules
		{
			[Token(Token = "0x60055DF")]
			[Address(RVA = "0x82EB4C", Offset = "0x82EB4C", VA = "0x82EB4C", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60055E0")]
			[Address(RVA = "0x82EB54", Offset = "0x82EB54", VA = "0x82EB54")]
			private set
			{
			}
		}

		// Token: 0x060055E1 RID: 21985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055E1")]
		[Address(RVA = "0x82EB5C", Offset = "0x82EB5C", VA = "0x82EB5C")]
		public DropBasedOnMasterAndExpertMode(IItemDropRule ruleForDefault, IItemDropRule ruleForExpertMode, IItemDropRule ruleForMasterMode)
		{
		}

		// Token: 0x060055E2 RID: 21986 RVA: 0x00027990 File Offset: 0x00025B90
		[Token(Token = "0x60055E2")]
		[Address(RVA = "0x82EC0C", Offset = "0x82EC0C", VA = "0x82EC0C", Slot = "5")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		// Token: 0x060055E3 RID: 21987 RVA: 0x000279A8 File Offset: 0x00025BA8
		[Token(Token = "0x60055E3")]
		[Address(RVA = "0x82EDA8", Offset = "0x82EDA8", VA = "0x82EDA8", Slot = "7")]
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			return default(ItemDropAttemptResult);
		}

		// Token: 0x060055E4 RID: 21988 RVA: 0x000279C0 File Offset: 0x00025BC0
		[Token(Token = "0x60055E4")]
		[Address(RVA = "0x82EDB0", Offset = "0x82EDB0", VA = "0x82EDB0", Slot = "8")]
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info, ItemDropRuleResolveAction resolveAction)
		{
			return default(ItemDropAttemptResult);
		}

		// Token: 0x060055E5 RID: 21989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055E5")]
		[Address(RVA = "0x82EE28", Offset = "0x82EE28", VA = "0x82EE28", Slot = "6")]
		public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
		}

		// Token: 0x040098C2 RID: 39106
		[Token(Token = "0x40098C2")]
		[FieldOffset(Offset = "0x8")]
		public IItemDropRule ruleForDefault;

		// Token: 0x040098C3 RID: 39107
		[Token(Token = "0x40098C3")]
		[FieldOffset(Offset = "0xC")]
		public IItemDropRule ruleForExpertmode;

		// Token: 0x040098C4 RID: 39108
		[Token(Token = "0x40098C4")]
		[FieldOffset(Offset = "0x10")]
		public IItemDropRule ruleForMasterMode;

		// Token: 0x040098C5 RID: 39109
		[Token(Token = "0x40098C5")]
		[FieldOffset(Offset = "0x14")]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;
	}
}
