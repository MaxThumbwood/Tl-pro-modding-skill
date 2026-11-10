using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000A90 RID: 2704
	[Token(Token = "0x2000A90")]
	public class DropNothing : FileAPI
	{
		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x060055C4 RID: 21956 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060055C5 RID: 21957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009D9")]
		public List<IItemDropRuleChainAttempt> ChainedRules
		{
			[Token(Token = "0x60055C4")]
			[Address(RVA = "0x82D8D4", Offset = "0x82D8D4", VA = "0x82D8D4", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60055C5")]
			[Address(RVA = "0x82D8DC", Offset = "0x82D8DC", VA = "0x82D8DC")]
			private set
			{
			}
		}

		// Token: 0x060055C6 RID: 21958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055C6")]
		[Address(RVA = "0x82D8E4", Offset = "0x82D8E4", VA = "0x82D8E4")]
		public DropNothing()
		{
		}

		// Token: 0x060055C7 RID: 21959 RVA: 0x00027888 File Offset: 0x00025A88
		[Token(Token = "0x60055C7")]
		[Address(RVA = "0x82D97C", Offset = "0x82D97C", VA = "0x82D97C", Slot = "5")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		// Token: 0x060055C8 RID: 21960 RVA: 0x000278A0 File Offset: 0x00025AA0
		[Token(Token = "0x60055C8")]
		[Address(RVA = "0x82D984", Offset = "0x82D984", VA = "0x82D984", Slot = "7")]
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			return default(ItemDropAttemptResult);
		}

		// Token: 0x060055C9 RID: 21961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055C9")]
		[Address(RVA = "0x82D98C", Offset = "0x82D98C", VA = "0x82D98C", Slot = "6")]
		public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
		}

		// Token: 0x040098B8 RID: 39096
		[Token(Token = "0x40098B8")]
		[FieldOffset(Offset = "0x8")]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;
	}
}
