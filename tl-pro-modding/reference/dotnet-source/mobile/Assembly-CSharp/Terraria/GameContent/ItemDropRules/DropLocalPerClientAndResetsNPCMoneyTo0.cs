using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000A8D RID: 2701
	[Token(Token = "0x2000A8D")]
	public class DropLocalPerClientAndResetsNPCMoneyTo0 : CommonDrop
	{
		// Token: 0x060055BB RID: 21947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055BB")]
		[Address(RVA = "0x82D07C", Offset = "0x82D07C", VA = "0x82D07C")]
		public DropLocalPerClientAndResetsNPCMoneyTo0(int itemId, int chanceDenominator, int amountDroppedMinimum, int amountDroppedMaximum, IItemDropRuleCondition optionalCondition)
		{
		}

		// Token: 0x060055BC RID: 21948 RVA: 0x00027810 File Offset: 0x00025A10
		[Token(Token = "0x60055BC")]
		[Address(RVA = "0x82D144", Offset = "0x82D144", VA = "0x82D144", Slot = "8")]
		public override bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		// Token: 0x060055BD RID: 21949 RVA: 0x00027828 File Offset: 0x00025A28
		[Token(Token = "0x60055BD")]
		[Address(RVA = "0x82D230", Offset = "0x82D230", VA = "0x82D230", Slot = "9")]
		public override ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			return default(ItemDropAttemptResult);
		}

		// Token: 0x040098B5 RID: 39093
		[Token(Token = "0x40098B5")]
		[FieldOffset(Offset = "0x20")]
		public IItemDropRuleCondition condition;
	}
}
