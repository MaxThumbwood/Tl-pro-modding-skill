using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Terraria.Localization;

namespace Terraria.GameContent
{
	// Token: 0x02000950 RID: 2384
	[Token(Token = "0x2000950")]
	public class OneTimeDialogue : ConditionalDialogue
	{
		// Token: 0x06004F7D RID: 20349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F7D")]
		[Address(RVA = "0x74E4A0", Offset = "0x74E4A0", VA = "0x74E4A0")]
		public OneTimeDialogue(string key, [Optional] Predicate<NPC> condition)
		{
		}

		// Token: 0x06004F7E RID: 20350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F7E")]
		[Address(RVA = "0x74E68C", Offset = "0x74E68C", VA = "0x74E68C", Slot = "4")]
		public override string GetChatAndClearCondition(NPC npc)
		{
			return null;
		}

		// Token: 0x06004F7F RID: 20351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F7F")]
		[Address(RVA = "0x74E978", Offset = "0x74E978", VA = "0x74E978")]
		public OneTimeDialogue WithReward(int itemId, int stack = 1)
		{
			return null;
		}

		// Token: 0x06004F80 RID: 20352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F80")]
		[Address(RVA = "0x74EAF0", Offset = "0x74EAF0", VA = "0x74EAF0")]
		public OneTimeDialogue WithRewards(Item[] rewards)
		{
			return null;
		}

		// Token: 0x04009393 RID: 37779
		[Token(Token = "0x4009393")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly LocalizedText ChatText;

		// Token: 0x04009394 RID: 37780
		[Token(Token = "0x4009394")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public readonly List<Item> Rewards;

		// Token: 0x02000951 RID: 2385
		[Token(Token = "0x2000951")]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x06004F81 RID: 20353 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F81")]
			[Address(RVA = "0x74E684", Offset = "0x74E684", VA = "0x74E684")]
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x06004F82 RID: 20354 RVA: 0x00024FC0 File Offset: 0x000231C0
			[Token(Token = "0x6004F82")]
			[Address(RVA = "0x74EB60", Offset = "0x74EB60", VA = "0x74EB60")]
			internal bool <.ctor>b__0(NPC npc)
			{
				return default(bool);
			}

			// Token: 0x04009395 RID: 37781
			[Token(Token = "0x4009395")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string key;

			// Token: 0x04009396 RID: 37782
			[Token(Token = "0x4009396")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Predicate<NPC> condition;
		}
	}
}
