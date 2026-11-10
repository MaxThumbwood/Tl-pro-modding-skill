using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000A8B RID: 2699
	[Token(Token = "0x2000A8B")]
	public class CommonDropNotScalingWithLuck : CommonDrop
	{
		// Token: 0x060055B6 RID: 21942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055B6")]
		[Address(RVA = "0x82CD10", Offset = "0x82CD10", VA = "0x82CD10")]
		public CommonDropNotScalingWithLuck(int itemId, int chanceDenominator, int amountDroppedMinimum, int amountDroppedMaximum)
		{
		}

		// Token: 0x060055B7 RID: 21943 RVA: 0x000277E0 File Offset: 0x000259E0
		[Token(Token = "0x60055B7")]
		[Address(RVA = "0x82CDD0", Offset = "0x82CDD0", VA = "0x82CDD0", Slot = "9")]
		public override ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			return default(ItemDropAttemptResult);
		}
	}
}
