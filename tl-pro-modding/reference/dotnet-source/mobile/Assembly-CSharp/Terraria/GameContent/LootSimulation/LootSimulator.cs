using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameContent.LootSimulation
{
	// Token: 0x02000A42 RID: 2626
	[Token(Token = "0x2000A42")]
	public class LootSimulator
	{
		// Token: 0x06005451 RID: 21585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005451")]
		[Address(RVA = "0x813660", Offset = "0x813660", VA = "0x813660")]
		public LootSimulator()
		{
		}

		// Token: 0x06005452 RID: 21586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005452")]
		[Address(RVA = "0x813C2C", Offset = "0x813C2C", VA = "0x813C2C")]
		private void FillItemExclusions()
		{
		}

		// Token: 0x06005453 RID: 21587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005453")]
		[Address(RVA = "0x813734", Offset = "0x813734", VA = "0x813734")]
		private void FillDesiredTestConditions()
		{
		}

		// Token: 0x06005454 RID: 21588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005454")]
		[Address(RVA = "0x8142C4", Offset = "0x8142C4", VA = "0x8142C4")]
		public void Run()
		{
		}

		// Token: 0x06005455 RID: 21589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005455")]
		[Address(RVA = "0x8144A8", Offset = "0x8144A8", VA = "0x8144A8")]
		private void SetCleanSlateWorldConditions()
		{
		}

		// Token: 0x06005456 RID: 21590 RVA: 0x00027258 File Offset: 0x00025458
		[Token(Token = "0x6005456")]
		[Address(RVA = "0x81458C", Offset = "0x81458C", VA = "0x81458C")]
		private bool TryGettingLootFor(int npcNetId, int timesMultiplier, out string outputText)
		{
			return default(bool);
		}

		// Token: 0x040097E0 RID: 38880
		[Token(Token = "0x40097E0")]
		[FieldOffset(Offset = "0x8")]
		private List<ISimulationConditionSetter> _neededTestConditions;

		// Token: 0x040097E1 RID: 38881
		[Token(Token = "0x40097E1")]
		[FieldOffset(Offset = "0xC")]
		private int[] _excludedItemIds;

		// Token: 0x02000A43 RID: 2627
		[Token(Token = "0x2000A43")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005458 RID: 21592 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005458")]
			[Address(RVA = "0x8153E8", Offset = "0x8153E8", VA = "0x8153E8")]
			public <>c()
			{
			}

			// Token: 0x06005459 RID: 21593 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005459")]
			[Address(RVA = "0x8153F0", Offset = "0x8153F0", VA = "0x8153F0")]
			internal <>f__AnonymousType11<int, bool> <FillItemExclusions>b__3_0(bool state, int index)
			{
				return null;
			}

			// Token: 0x0600545A RID: 21594 RVA: 0x00027270 File Offset: 0x00025470
			[Token(Token = "0x600545A")]
			[Address(RVA = "0x815488", Offset = "0x815488", VA = "0x815488")]
			internal bool <FillItemExclusions>b__3_1(<>f__AnonymousType11<int, bool> tuple)
			{
				return default(bool);
			}

			// Token: 0x0600545B RID: 21595 RVA: 0x00027288 File Offset: 0x00025488
			[Token(Token = "0x600545B")]
			[Address(RVA = "0x8154E4", Offset = "0x8154E4", VA = "0x8154E4")]
			internal int <FillItemExclusions>b__3_2(<>f__AnonymousType11<int, bool> tuple)
			{
				return 0;
			}

			// Token: 0x0600545C RID: 21596 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600545C")]
			[Address(RVA = "0x815540", Offset = "0x815540", VA = "0x815540")]
			internal <>f__AnonymousType11<int, bool> <FillItemExclusions>b__3_3(bool state, int index)
			{
				return null;
			}

			// Token: 0x0600545D RID: 21597 RVA: 0x000272A0 File Offset: 0x000254A0
			[Token(Token = "0x600545D")]
			[Address(RVA = "0x8155D8", Offset = "0x8155D8", VA = "0x8155D8")]
			internal bool <FillItemExclusions>b__3_4(<>f__AnonymousType11<int, bool> tuple)
			{
				return default(bool);
			}

			// Token: 0x0600545E RID: 21598 RVA: 0x000272B8 File Offset: 0x000254B8
			[Token(Token = "0x600545E")]
			[Address(RVA = "0x815634", Offset = "0x815634", VA = "0x815634")]
			internal int <FillItemExclusions>b__3_5(<>f__AnonymousType11<int, bool> tuple)
			{
				return 0;
			}

			// Token: 0x040097E2 RID: 38882
			[Token(Token = "0x40097E2")]
			[FieldOffset(Offset = "0x0")]
			public static readonly LootSimulator.<>c <>9;

			// Token: 0x040097E3 RID: 38883
			[Token(Token = "0x40097E3")]
			[FieldOffset(Offset = "0x4")]
			public static Func<bool, int, <>f__AnonymousType11<int, bool>> <>9__3_0;

			// Token: 0x040097E4 RID: 38884
			[Token(Token = "0x40097E4")]
			[FieldOffset(Offset = "0x8")]
			public static Func<<>f__AnonymousType11<int, bool>, bool> <>9__3_1;

			// Token: 0x040097E5 RID: 38885
			[Token(Token = "0x40097E5")]
			[FieldOffset(Offset = "0xC")]
			public static Func<<>f__AnonymousType11<int, bool>, int> <>9__3_2;

			// Token: 0x040097E6 RID: 38886
			[Token(Token = "0x40097E6")]
			[FieldOffset(Offset = "0x10")]
			public static Func<bool, int, <>f__AnonymousType11<int, bool>> <>9__3_3;

			// Token: 0x040097E7 RID: 38887
			[Token(Token = "0x40097E7")]
			[FieldOffset(Offset = "0x14")]
			public static Func<<>f__AnonymousType11<int, bool>, bool> <>9__3_4;

			// Token: 0x040097E8 RID: 38888
			[Token(Token = "0x40097E8")]
			[FieldOffset(Offset = "0x18")]
			public static Func<<>f__AnonymousType11<int, bool>, int> <>9__3_5;
		}
	}
}
