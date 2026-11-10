using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000A8E RID: 2702
	[Token(Token = "0x2000A8E")]
	public class DropPerPlayerOnThePlayer : CommonDrop
	{
		// Token: 0x060055BE RID: 21950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055BE")]
		[Address(RVA = "0x82D2C4", Offset = "0x82D2C4", VA = "0x82D2C4")]
		public DropPerPlayerOnThePlayer(int itemId, int chanceDenominator, int amountDroppedMinimum, int amountDroppedMaximum, IItemDropRuleCondition optionalCondition)
		{
		}

		// Token: 0x060055BF RID: 21951 RVA: 0x00027840 File Offset: 0x00025A40
		[Token(Token = "0x60055BF")]
		[Address(RVA = "0x82D38C", Offset = "0x82D38C", VA = "0x82D38C", Slot = "8")]
		public override bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		// Token: 0x060055C0 RID: 21952 RVA: 0x00027858 File Offset: 0x00025A58
		[Token(Token = "0x60055C0")]
		[Address(RVA = "0x82D478", Offset = "0x82D478", VA = "0x82D478", Slot = "9")]
		public override ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			return default(ItemDropAttemptResult);
		}

		// Token: 0x040098B6 RID: 39094
		[Token(Token = "0x40098B6")]
		[FieldOffset(Offset = "0x20")]
		public IItemDropRuleCondition condition;
	}
}
