using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000A9F RID: 2719
	[Token(Token = "0x2000A9F")]
	public class OneFromRulesRule : FileAPI, GUIControllerItem
	{
		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x0600561B RID: 22043 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600561C RID: 22044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009E6")]
		public List<IItemDropRuleChainAttempt> ChainedRules
		{
			[Token(Token = "0x600561B")]
			[Address(RVA = "0x831B70", Offset = "0x831B70", VA = "0x831B70", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600561C")]
			[Address(RVA = "0x831B78", Offset = "0x831B78", VA = "0x831B78")]
			private set
			{
			}
		}

		// Token: 0x0600561D RID: 22045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600561D")]
		[Address(RVA = "0x831B80", Offset = "0x831B80", VA = "0x831B80")]
		public OneFromRulesRule(int chanceDenominator, IItemDropRule[] options)
		{
		}

		// Token: 0x0600561E RID: 22046 RVA: 0x00027B88 File Offset: 0x00025D88
		[Token(Token = "0x600561E")]
		[Address(RVA = "0x831C28", Offset = "0x831C28", VA = "0x831C28", Slot = "5")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		// Token: 0x0600561F RID: 22047 RVA: 0x00027BA0 File Offset: 0x00025DA0
		[Token(Token = "0x600561F")]
		[Address(RVA = "0x831C30", Offset = "0x831C30", VA = "0x831C30", Slot = "7")]
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			return default(ItemDropAttemptResult);
		}

		// Token: 0x06005620 RID: 22048 RVA: 0x00027BB8 File Offset: 0x00025DB8
		[Token(Token = "0x6005620")]
		[Address(RVA = "0x831C38", Offset = "0x831C38", VA = "0x831C38", Slot = "8")]
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info, ItemDropRuleResolveAction resolveAction)
		{
			return default(ItemDropAttemptResult);
		}

		// Token: 0x06005621 RID: 22049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005621")]
		[Address(RVA = "0x831D20", Offset = "0x831D20", VA = "0x831D20", Slot = "6")]
		public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
		}

		// Token: 0x040098E4 RID: 39140
		[Token(Token = "0x40098E4")]
		[FieldOffset(Offset = "0x8")]
		public IItemDropRule[] options;

		// Token: 0x040098E5 RID: 39141
		[Token(Token = "0x40098E5")]
		[FieldOffset(Offset = "0xC")]
		public int chanceDenominator;

		// Token: 0x040098E6 RID: 39142
		[Token(Token = "0x40098E6")]
		[FieldOffset(Offset = "0x10")]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;
	}
}
