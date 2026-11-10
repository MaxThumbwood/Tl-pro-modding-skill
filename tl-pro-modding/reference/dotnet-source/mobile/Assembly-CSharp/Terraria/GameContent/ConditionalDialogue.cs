using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Terraria.GameContent
{
	// Token: 0x0200094A RID: 2378
	[Token(Token = "0x200094A")]
	public abstract class ConditionalDialogue
	{
		// Token: 0x06004F65 RID: 20325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F65")]
		[Address(RVA = "0x74CDC0", Offset = "0x74CDC0", VA = "0x74CDC0")]
		private static void Register(int npcType, ConditionalDialogue dialogue)
		{
		}

		// Token: 0x06004F66 RID: 20326 RVA: 0x00024F48 File Offset: 0x00023148
		[Token(Token = "0x6004F66")]
		[Address(RVA = "0x74CF90", Offset = "0x74CF90", VA = "0x74CF90")]
		public static bool TryGetPendingDialogue(NPC npc, out ConditionalDialogue dialogue)
		{
			return default(bool);
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06004F67 RID: 20327 RVA: 0x00024F60 File Offset: 0x00023160
		// (set) Token: 0x06004F68 RID: 20328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000985")]
		public bool ShowIndicator
		{
			[Token(Token = "0x6004F67")]
			[Address(RVA = "0x74D1E4", Offset = "0x74D1E4", VA = "0x74D1E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004F68")]
			[Address(RVA = "0x74D1EC", Offset = "0x74D1EC", VA = "0x74D1EC")]
			private set
			{
			}
		}

		// Token: 0x06004F69 RID: 20329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F69")]
		[Address(RVA = "0x74D1F4", Offset = "0x74D1F4", VA = "0x74D1F4")]
		public ConditionalDialogue([Optional] Predicate<NPC> condition)
		{
		}

		// Token: 0x06004F6A RID: 20330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F6A")]
		[Address(RVA = "0x74D31C", Offset = "0x74D31C", VA = "0x74D31C")]
		public void HideIndicator()
		{
		}

		// Token: 0x06004F6B RID: 20331
		[Token(Token = "0x6004F6B")]
		public abstract string GetChatAndClearCondition(NPC npc);

		// Token: 0x06004F6C RID: 20332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F6C")]
		[Address(RVA = "0x74D328", Offset = "0x74D328", VA = "0x74D328")]
		public void Register(int npcType)
		{
		}

		// Token: 0x06004F6D RID: 20333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F6D")]
		[Address(RVA = "0x74D394", Offset = "0x74D394", VA = "0x74D394")]
		internal static void Init()
		{
		}

		// Token: 0x06004F6E RID: 20334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F6E")]
		[Address(RVA = "0x74D59C", Offset = "0x74D59C", VA = "0x74D59C")]
		public static Predicate<NPC> CreateInventoryCondition(RecipeGroup item, int stack)
		{
			return null;
		}

		// Token: 0x06004F6F RID: 20335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F6F")]
		[Address(RVA = "0x74D66C", Offset = "0x74D66C", VA = "0x74D66C")]
		public static Predicate<NPC> CreateInventoryCondition(Recipe.RequiredItemEntry[] requiredItems)
		{
			return null;
		}

		// Token: 0x04009386 RID: 37766
		[Token(Token = "0x4009386")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<ConditionalDialogue>[] _registry;

		// Token: 0x04009387 RID: 37767
		[Token(Token = "0x4009387")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private bool <ShowIndicator>k__BackingField;

		// Token: 0x04009388 RID: 37768
		[Token(Token = "0x4009388")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public readonly Predicate<NPC> ConditionsMet;

		// Token: 0x0200094B RID: 2379
		[Token(Token = "0x200094B")]
		public static class ItemGroups
		{
			// Token: 0x06004F71 RID: 20337 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F71")]
			[Address(RVA = "0x74D7D8", Offset = "0x74D7D8", VA = "0x74D7D8")]
			internal static void PostSetupContent()
			{
			}

			// Token: 0x04009389 RID: 37769
			[Token(Token = "0x4009389")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static RecipeGroup Ore;

			// Token: 0x0400938A RID: 37770
			[Token(Token = "0x400938A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static RecipeGroup Bars;

			// Token: 0x0400938B RID: 37771
			[Token(Token = "0x400938B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static RecipeGroup Anvils;

			// Token: 0x0400938C RID: 37772
			[Token(Token = "0x400938C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public static RecipeGroup Whips;

			// Token: 0x0400938D RID: 37773
			[Token(Token = "0x400938D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static RecipeGroup Mounts;
		}

		// Token: 0x0200094C RID: 2380
		[Token(Token = "0x200094C")]
		private class FreeCakeDialogue : ConditionalDialogue
		{
			// Token: 0x06004F73 RID: 20339 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F73")]
			[Address(RVA = "0x74D464", Offset = "0x74D464", VA = "0x74D464")]
			public FreeCakeDialogue()
			{
			}

			// Token: 0x06004F74 RID: 20340 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004F74")]
			[Address(RVA = "0x74DFE0", Offset = "0x74DFE0", VA = "0x74DFE0", Slot = "4")]
			public override string GetChatAndClearCondition(NPC npc)
			{
				return null;
			}

			// Token: 0x0200094D RID: 2381
			[Token(Token = "0x200094D")]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x06004F76 RID: 20342 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004F76")]
				[Address(RVA = "0x74E344", Offset = "0x74E344", VA = "0x74E344")]
				public <>c()
				{
				}

				// Token: 0x06004F77 RID: 20343 RVA: 0x00024F78 File Offset: 0x00023178
				[Token(Token = "0x6004F77")]
				[Address(RVA = "0x74E34C", Offset = "0x74E34C", VA = "0x74E34C")]
				internal bool <.ctor>b__0_0(NPC _)
				{
					return default(bool);
				}

				// Token: 0x0400938E RID: 37774
				[Token(Token = "0x400938E")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public static readonly ConditionalDialogue.FreeCakeDialogue.<>c <>9;

				// Token: 0x0400938F RID: 37775
				[Token(Token = "0x400938F")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				public static Predicate<NPC> <>9__0_0;
			}
		}

		// Token: 0x0200094E RID: 2382
		[Token(Token = "0x200094E")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004F79 RID: 20345 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F79")]
			[Address(RVA = "0x74E424", Offset = "0x74E424", VA = "0x74E424")]
			public <>c()
			{
			}

			// Token: 0x06004F7A RID: 20346 RVA: 0x00024F90 File Offset: 0x00023190
			[Token(Token = "0x6004F7A")]
			[Address(RVA = "0x74E42C", Offset = "0x74E42C", VA = "0x74E42C")]
			internal bool <.ctor>b__9_0(NPC _)
			{
				return default(bool);
			}

			// Token: 0x04009390 RID: 37776
			[Token(Token = "0x4009390")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly ConditionalDialogue.<>c <>9;

			// Token: 0x04009391 RID: 37777
			[Token(Token = "0x4009391")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static Predicate<NPC> <>9__9_0;
		}

		// Token: 0x0200094F RID: 2383
		[Token(Token = "0x200094F")]
		private sealed class <>c__DisplayClass15_0
		{
			// Token: 0x06004F7B RID: 20347 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F7B")]
			[Address(RVA = "0x74D758", Offset = "0x74D758", VA = "0x74D758")]
			public <>c__DisplayClass15_0()
			{
			}

			// Token: 0x06004F7C RID: 20348 RVA: 0x00024FA8 File Offset: 0x000231A8
			[Token(Token = "0x6004F7C")]
			[Address(RVA = "0x74E434", Offset = "0x74E434", VA = "0x74E434")]
			internal bool <CreateInventoryCondition>b__0(NPC _)
			{
				return default(bool);
			}

			// Token: 0x04009392 RID: 37778
			[Token(Token = "0x4009392")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Recipe.RequiredItemEntry[] requiredItems;
		}
	}
}
