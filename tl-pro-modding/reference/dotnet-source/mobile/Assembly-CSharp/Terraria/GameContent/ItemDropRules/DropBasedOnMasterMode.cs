using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000A93 RID: 2707
	[Token(Token = "0x2000A93")]
	public class DropBasedOnMasterMode : FileAPI, GUIControllerItem
	{
		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x060055D8 RID: 21976 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060055D9 RID: 21977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009DC")]
		public List<IItemDropRuleChainAttempt> ChainedRules
		{
			[Token(Token = "0x60055D8")]
			[Address(RVA = "0x82E574", Offset = "0x82E574", VA = "0x82E574", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60055D9")]
			[Address(RVA = "0x82E57C", Offset = "0x82E57C", VA = "0x82E57C")]
			private set
			{
			}
		}

		// Token: 0x060055DA RID: 21978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055DA")]
		[Address(RVA = "0x82E584", Offset = "0x82E584", VA = "0x82E584")]
		public DropBasedOnMasterMode(IItemDropRule ruleForDefault, IItemDropRule ruleForMasterMode)
		{
		}

		// Token: 0x060055DB RID: 21979 RVA: 0x00027948 File Offset: 0x00025B48
		[Token(Token = "0x60055DB")]
		[Address(RVA = "0x82E62C", Offset = "0x82E62C", VA = "0x82E62C", Slot = "5")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		// Token: 0x060055DC RID: 21980 RVA: 0x00027960 File Offset: 0x00025B60
		[Token(Token = "0x60055DC")]
		[Address(RVA = "0x82E774", Offset = "0x82E774", VA = "0x82E774", Slot = "7")]
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			return default(ItemDropAttemptResult);
		}

		// Token: 0x060055DD RID: 21981 RVA: 0x00027978 File Offset: 0x00025B78
		[Token(Token = "0x60055DD")]
		[Address(RVA = "0x82E77C", Offset = "0x82E77C", VA = "0x82E77C", Slot = "8")]
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info, ItemDropRuleResolveAction resolveAction)
		{
			return default(ItemDropAttemptResult);
		}

		// Token: 0x060055DE RID: 21982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055DE")]
		[Address(RVA = "0x82E7DC", Offset = "0x82E7DC", VA = "0x82E7DC", Slot = "6")]
		public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
		}

		// Token: 0x040098BF RID: 39103
		[Token(Token = "0x40098BF")]
		[FieldOffset(Offset = "0x8")]
		public IItemDropRule ruleForDefault;

		// Token: 0x040098C0 RID: 39104
		[Token(Token = "0x40098C0")]
		[FieldOffset(Offset = "0xC")]
		public IItemDropRule ruleForMasterMode;

		// Token: 0x040098C1 RID: 39105
		[Token(Token = "0x40098C1")]
		[FieldOffset(Offset = "0x10")]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;
	}
}
