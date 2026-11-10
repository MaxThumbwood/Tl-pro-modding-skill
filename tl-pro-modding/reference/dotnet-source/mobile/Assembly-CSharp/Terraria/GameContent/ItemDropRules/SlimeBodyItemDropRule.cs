using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000A97 RID: 2711
	[Token(Token = "0x2000A97")]
	public class SlimeBodyItemDropRule : FileAPI
	{
		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x060055F2 RID: 22002 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060055F3 RID: 22003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009E0")]
		public List<IItemDropRuleChainAttempt> ChainedRules
		{
			[Token(Token = "0x60055F2")]
			[Address(RVA = "0x82FDA8", Offset = "0x82FDA8", VA = "0x82FDA8", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60055F3")]
			[Address(RVA = "0x82FDB0", Offset = "0x82FDB0", VA = "0x82FDB0")]
			private set
			{
			}
		}

		// Token: 0x060055F4 RID: 22004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055F4")]
		[Address(RVA = "0x82FDB8", Offset = "0x82FDB8", VA = "0x82FDB8")]
		public SlimeBodyItemDropRule()
		{
		}

		// Token: 0x060055F5 RID: 22005 RVA: 0x00027A38 File Offset: 0x00025C38
		[Token(Token = "0x60055F5")]
		[Address(RVA = "0x82FE50", Offset = "0x82FE50", VA = "0x82FE50", Slot = "5")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		// Token: 0x060055F6 RID: 22006 RVA: 0x00027A50 File Offset: 0x00025C50
		[Token(Token = "0x60055F6")]
		[Address(RVA = "0x82FF50", Offset = "0x82FF50", VA = "0x82FF50", Slot = "7")]
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			return default(ItemDropAttemptResult);
		}

		// Token: 0x060055F7 RID: 22007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055F7")]
		[Address(RVA = "0x830000", Offset = "0x830000", VA = "0x830000")]
		public void GetDropInfo(int itemId, out int amountDroppedMinimum, out int amountDroppedMaximum)
		{
		}

		// Token: 0x060055F8 RID: 22008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055F8")]
		[Address(RVA = "0x83031C", Offset = "0x83031C", VA = "0x83031C", Slot = "6")]
		public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
		}

		// Token: 0x040098C9 RID: 39113
		[Token(Token = "0x40098C9")]
		[FieldOffset(Offset = "0x8")]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;
	}
}
