using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000A8C RID: 2700
	[Token(Token = "0x2000A8C")]
	public class CommonDropScalingWithOnlyBadLuck : CommonDrop
	{
		// Token: 0x060055B8 RID: 21944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055B8")]
		[Address(RVA = "0x82CE64", Offset = "0x82CE64", VA = "0x82CE64")]
		public CommonDropScalingWithOnlyBadLuck(int itemId, int chanceDenominator, int amountDroppedMinimum = 1, int amountDroppedMaximum = 1, int chanceNumerator = 1)
		{
		}

		// Token: 0x060055B9 RID: 21945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055B9")]
		[Address(RVA = "0x82CF24", Offset = "0x82CF24", VA = "0x82CF24")]
		public CommonDropScalingWithOnlyBadLuck(int itemId, int chanceDenominator, int amountDroppedMinimum, int amountDroppedMaximum)
		{
		}

		// Token: 0x060055BA RID: 21946 RVA: 0x000277F8 File Offset: 0x000259F8
		[Token(Token = "0x60055BA")]
		[Address(RVA = "0x82CFE4", Offset = "0x82CFE4", VA = "0x82CFE4", Slot = "9")]
		public override ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			return default(ItemDropAttemptResult);
		}
	}
}
