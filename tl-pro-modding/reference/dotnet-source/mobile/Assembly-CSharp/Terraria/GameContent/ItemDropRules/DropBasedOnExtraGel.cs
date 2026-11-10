using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000A91 RID: 2705
	[Token(Token = "0x2000A91")]
	public class DropBasedOnExtraGel : FileAPI, GUIControllerItem
	{
		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x060055CA RID: 21962 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060055CB RID: 21963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009DA")]
		public List<IItemDropRuleChainAttempt> ChainedRules
		{
			[Token(Token = "0x60055CA")]
			[Address(RVA = "0x82D9B8", Offset = "0x82D9B8", VA = "0x82D9B8", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60055CB")]
			[Address(RVA = "0x82D9C0", Offset = "0x82D9C0", VA = "0x82D9C0")]
			private set
			{
			}
		}

		// Token: 0x060055CC RID: 21964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055CC")]
		[Address(RVA = "0x82D9C8", Offset = "0x82D9C8", VA = "0x82D9C8")]
		public DropBasedOnExtraGel(IItemDropRule ruleForNormal, IItemDropRule ruleForExtraGel)
		{
		}

		// Token: 0x060055CD RID: 21965 RVA: 0x000278B8 File Offset: 0x00025AB8
		[Token(Token = "0x60055CD")]
		[Address(RVA = "0x82DA70", Offset = "0x82DA70", VA = "0x82DA70", Slot = "5")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		// Token: 0x060055CE RID: 21966 RVA: 0x000278D0 File Offset: 0x00025AD0
		[Token(Token = "0x60055CE")]
		[Address(RVA = "0x82DBB8", Offset = "0x82DBB8", VA = "0x82DBB8", Slot = "7")]
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			return default(ItemDropAttemptResult);
		}

		// Token: 0x060055CF RID: 21967 RVA: 0x000278E8 File Offset: 0x00025AE8
		[Token(Token = "0x60055CF")]
		[Address(RVA = "0x82DBC0", Offset = "0x82DBC0", VA = "0x82DBC0", Slot = "8")]
		public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info, ItemDropRuleResolveAction resolveAction)
		{
			return default(ItemDropAttemptResult);
		}

		// Token: 0x060055D0 RID: 21968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055D0")]
		[Address(RVA = "0x82DC2C", Offset = "0x82DC2C", VA = "0x82DC2C", Slot = "6")]
		public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
		}

		// Token: 0x040098B9 RID: 39097
		[Token(Token = "0x40098B9")]
		[FieldOffset(Offset = "0x8")]
		public IItemDropRule ruleForNormal;

		// Token: 0x040098BA RID: 39098
		[Token(Token = "0x40098BA")]
		[FieldOffset(Offset = "0xC")]
		public IItemDropRule ruleForExtraGel;

		// Token: 0x040098BB RID: 39099
		[Token(Token = "0x40098BB")]
		[FieldOffset(Offset = "0x10")]
		private List<IItemDropRuleChainAttempt> <ChainedRules>k__BackingField;
	}
}
