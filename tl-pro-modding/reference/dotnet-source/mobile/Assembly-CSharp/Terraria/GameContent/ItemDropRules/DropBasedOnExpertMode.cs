using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000A92 RID: 2706
	[Token(Token = "0x2000A92")]
	public class DropBasedOnExpertMode : FileAPI, GUIControllerItem
	{
		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x060055D1 RID: 21969 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060055D2 RID: 21970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009DB")]
		public List<IItemDropRuleChainAttempt> ChainedRules
		{
			[Token(Token = "0x60055D1")]
			[Address(RVA = "0x82DF9C", Offset = "0x82DF9C", VA = "0x82DF9C", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60055D2")]
			[Address(RVA = "0x82DFA4", Offset = "0x82DFA4", VA = "0x82DFA4")]
			private set
			{
			}
		}

		// Token: 0x060055D3 RID: 21971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055D3")]
		[Address(RVA = "0x82DFAC", Offset = "0x82DFAC", VA = "0x82DFAC")]
		public DropBasedOnExpertMode(IItemDropRule ruleForNormalMode, IItemDropRule ruleForExpertMode)
		{
		}

		// Token: 0x060055D4 RID: 21972 RVA: 0x00027900 File Offset: 0x00025B00
		[Token(Token = "0x60055D4")]
		[Address(RVA = "0x82E054", Offset = "0x82E054", VA = "0x82E054", Slot = "5")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		// Token: 0x060055D5 RID: 21973 RVA: 0x00027918 File Offset: 0x00025B18
		[Token(Token = "0x60055D5")]
		[Address(RVA = "0x82E19C", Offset = "0x82E19C", VA = "0x82E19C", Slot = "7")]
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			return default(ItemDropAttemptResult);
		}

		// Token: 0x060055D6 RID: 21974 RVA: 0x00027930 File Offset: 0x00025B30
		[Token(Token = "0x60055D6")]
		[Address(RVA = "0x82E1A4", Offset = "0x82E1A4", VA = "0x82E1A4", Slot = "8")]
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info, ItemDropRuleResolveAction resolveAction)
		{
			return default(ItemDropAttemptResult);
		}

		// Token: 0x060055D7 RID: 21975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055D7")]
		[Address(RVA = "0x82E204", Offset = "0x82E204", VA = "0x82E204", Slot = "6")]
		public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
		}

		// Token: 0x040098BC RID: 39100
		[Token(Token = "0x40098BC")]
		[FieldOffset(Offset = "0x8")]
		public IItemDropRule ruleForNormalMode;

		// Token: 0x040098BD RID: 39101
		[Token(Token = "0x40098BD")]
		[FieldOffset(Offset = "0xC")]
		public IItemDropRule ruleForExpertMode;

		// Token: 0x040098BE RID: 39102
		[Token(Token = "0x40098BE")]
		[FieldOffset(Offset = "0x10")]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;
	}
}
