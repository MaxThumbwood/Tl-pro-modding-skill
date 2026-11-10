using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000A7F RID: 2687
	[Token(Token = "0x2000A7F")]
	public struct DropRateInfo
	{
		// Token: 0x06005598 RID: 21912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005598")]
		[Address(RVA = "0x82B050", Offset = "0x82B050", VA = "0x82B050")]
		public DropRateInfo(int itemId, int stackMin, int stackMax, float dropRate, [Optional] List<IItemDropRuleCondition> conditions)
		{
		}

		// Token: 0x06005599 RID: 21913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005599")]
		[Address(RVA = "0x82B134", Offset = "0x82B134", VA = "0x82B134")]
		public void AddCondition(IItemDropRuleCondition condition)
		{
		}

		// Token: 0x040098A0 RID: 39072
		[Token(Token = "0x40098A0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int itemId;

		// Token: 0x040098A1 RID: 39073
		[Token(Token = "0x40098A1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int stackMin;

		// Token: 0x040098A2 RID: 39074
		[Token(Token = "0x40098A2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int stackMax;

		// Token: 0x040098A3 RID: 39075
		[Token(Token = "0x40098A3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float dropRate;

		// Token: 0x040098A4 RID: 39076
		[Token(Token = "0x40098A4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<IItemDropRuleCondition> conditions;
	}
}
