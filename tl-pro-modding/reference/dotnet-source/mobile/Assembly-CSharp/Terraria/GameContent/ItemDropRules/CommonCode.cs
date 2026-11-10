using System;
using Il2CppDummyDll;
using Terraria.Utilities;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000A88 RID: 2696
	[Token(Token = "0x2000A88")]
	public static class CommonCode
	{
		// Token: 0x060055A8 RID: 21928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055A8")]
		[Address(RVA = "0x82B450", Offset = "0x82B450", VA = "0x82B450")]
		public static void DropItemFromNPC(NPC npc, int itemId, int stack, bool scattered = false)
		{
		}

		// Token: 0x060055A9 RID: 21929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055A9")]
		[Address(RVA = "0x82B9D8", Offset = "0x82B9D8", VA = "0x82B9D8")]
		public static void DropItemFromNPCForEachPlayer(NPC npc, int itemId, int stack, bool interactionRequired)
		{
		}

		// Token: 0x060055AA RID: 21930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055AA")]
		[Address(RVA = "0x82BDEC", Offset = "0x82BDEC", VA = "0x82BDEC")]
		public static void DropItemFromNPCForEachPlayerChance(NPC npc, int itemId, int stack, UnifiedRandom rng, int chanceNumerator, int chanceDenominator, bool interactionRequired)
		{
		}

		// Token: 0x060055AB RID: 21931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055AB")]
		[Address(RVA = "0x82C1C8", Offset = "0x82C1C8", VA = "0x82C1C8")]
		public static void DropItemLocalPerClientAndSetNPCMoneyTo0(NPC npc, int itemId, int stack, bool interactionRequired = true)
		{
		}

		// Token: 0x060055AC RID: 21932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055AC")]
		[Address(RVA = "0x82C4A4", Offset = "0x82C4A4", VA = "0x82C4A4")]
		public static void DropItemForEachInteractingPlayerOnThePlayer(NPC npc, int itemId, UnifiedRandom rng, int chanceNumerator, int chanceDenominator, int stack = 1, bool interactionRequired = true)
		{
		}

		// Token: 0x060055AD RID: 21933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055AD")]
		[Address(RVA = "0x82B6B0", Offset = "0x82B6B0", VA = "0x82B6B0")]
		public static void ModifyItemDropFromNPC(NPC npc, int itemIndex)
		{
		}

		// Token: 0x02000A89 RID: 2697
		[Token(Token = "0x2000A89")]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x060055AE RID: 21934 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60055AE")]
			[Address(RVA = "0x82C49C", Offset = "0x82C49C", VA = "0x82C49C")]
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x060055AF RID: 21935 RVA: 0x00027798 File Offset: 0x00025998
			[Token(Token = "0x60055AF")]
			[Address(RVA = "0x82C714", Offset = "0x82C714", VA = "0x82C714")]
			internal bool <DropItemLocalPerClientAndSetNPCMoneyTo0>b__0(Player p)
			{
				return default(bool);
			}

			// Token: 0x040098AD RID: 39085
			[Token(Token = "0x40098AD")]
			[FieldOffset(Offset = "0x8")]
			public NPC npc;

			// Token: 0x040098AE RID: 39086
			[Token(Token = "0x40098AE")]
			[FieldOffset(Offset = "0xC")]
			public bool interactionRequired;
		}
	}
}
