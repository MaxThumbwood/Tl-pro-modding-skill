using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000A8F RID: 2703
	[Token(Token = "0x2000A8F")]
	public class CommonDropWithRerolls : CommonDrop
	{
		// Token: 0x060055C1 RID: 21953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055C1")]
		[Address(RVA = "0x82D4E4", Offset = "0x82D4E4", VA = "0x82D4E4")]
		public CommonDropWithRerolls(int itemId, int chanceDenominator, int amountDroppedMinimum, int amountDroppedMaximum, int rerolls)
		{
		}

		// Token: 0x060055C2 RID: 21954 RVA: 0x00027870 File Offset: 0x00025A70
		[Token(Token = "0x60055C2")]
		[Address(RVA = "0x82D5B0", Offset = "0x82D5B0", VA = "0x82D5B0", Slot = "9")]
		public override ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
		{
			return default(ItemDropAttemptResult);
		}

		// Token: 0x060055C3 RID: 21955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055C3")]
		[Address(RVA = "0x82D69C", Offset = "0x82D69C", VA = "0x82D69C", Slot = "10")]
		public override void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
		{
		}

		// Token: 0x040098B7 RID: 39095
		[Token(Token = "0x40098B7")]
		[FieldOffset(Offset = "0x20")]
		public int timesToRoll;
	}
}
