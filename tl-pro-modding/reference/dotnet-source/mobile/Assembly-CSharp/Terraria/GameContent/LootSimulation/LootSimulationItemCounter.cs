using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.LootSimulation
{
	// Token: 0x02000A45 RID: 2629
	[Token(Token = "0x2000A45")]
	public class LootSimulationItemCounter
	{
		// Token: 0x06005463 RID: 21603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005463")]
		[Address(RVA = "0x814DF4", Offset = "0x814DF4", VA = "0x814DF4")]
		public LootSimulationItemCounter()
		{
		}

		// Token: 0x06005464 RID: 21604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005464")]
		[Address(RVA = "0x815754", Offset = "0x815754", VA = "0x815754")]
		public void AddItem(int itemId, int amount, bool expert)
		{
		}

		// Token: 0x06005465 RID: 21605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005465")]
		[Address(RVA = "0x814E8C", Offset = "0x814E8C", VA = "0x814E8C")]
		public void Exclude(int[] itemIds)
		{
		}

		// Token: 0x06005466 RID: 21606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005466")]
		[Address(RVA = "0x814E68", Offset = "0x814E68", VA = "0x814E68")]
		public void IncreaseTimesAttempted(int amount, bool expert)
		{
		}

		// Token: 0x06005467 RID: 21607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005467")]
		[Address(RVA = "0x814F10", Offset = "0x814F10", VA = "0x814F10")]
		public string PrintCollectedItems(bool expert)
		{
			return null;
		}

		// Token: 0x040097F0 RID: 38896
		[Token(Token = "0x40097F0")]
		[FieldOffset(Offset = "0x8")]
		private long[] _itemCountsObtained;

		// Token: 0x040097F1 RID: 38897
		[Token(Token = "0x40097F1")]
		[FieldOffset(Offset = "0xC")]
		private long[] _itemCountsObtainedExpert;

		// Token: 0x040097F2 RID: 38898
		[Token(Token = "0x40097F2")]
		[FieldOffset(Offset = "0x10")]
		private long _totalTimesAttempted;

		// Token: 0x040097F3 RID: 38899
		[Token(Token = "0x40097F3")]
		[FieldOffset(Offset = "0x18")]
		private long _totalTimesAttemptedExpert;

		// Token: 0x02000A46 RID: 2630
		[Token(Token = "0x2000A46")]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x06005468 RID: 21608 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005468")]
			[Address(RVA = "0x8157B8", Offset = "0x8157B8", VA = "0x8157B8")]
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x06005469 RID: 21609 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005469")]
			[Address(RVA = "0x8157C0", Offset = "0x8157C0", VA = "0x8157C0")]
			internal string <PrintCollectedItems>b__3(int itemId)
			{
				return null;
			}

			// Token: 0x040097F4 RID: 38900
			[Token(Token = "0x40097F4")]
			[FieldOffset(Offset = "0x8")]
			public long[] collectionToUse;

			// Token: 0x040097F5 RID: 38901
			[Token(Token = "0x40097F5")]
			[FieldOffset(Offset = "0x10")]
			public long totalDropsAttempted;
		}

		// Token: 0x02000A47 RID: 2631
		[Token(Token = "0x2000A47")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600546B RID: 21611 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600546B")]
			[Address(RVA = "0x815964", Offset = "0x815964", VA = "0x815964")]
			public <>c()
			{
			}

			// Token: 0x0600546C RID: 21612 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600546C")]
			[Address(RVA = "0x81596C", Offset = "0x81596C", VA = "0x81596C")]
			internal <>f__AnonymousType12<int, long> <PrintCollectedItems>b__8_0(long count, int itemId)
			{
				return null;
			}

			// Token: 0x0600546D RID: 21613 RVA: 0x000272D0 File Offset: 0x000254D0
			[Token(Token = "0x600546D")]
			[Address(RVA = "0x815A18", Offset = "0x815A18", VA = "0x815A18")]
			internal bool <PrintCollectedItems>b__8_1(<>f__AnonymousType12<int, long> entry)
			{
				return default(bool);
			}

			// Token: 0x0600546E RID: 21614 RVA: 0x000272E8 File Offset: 0x000254E8
			[Token(Token = "0x600546E")]
			[Address(RVA = "0x815A74", Offset = "0x815A74", VA = "0x815A74")]
			internal int <PrintCollectedItems>b__8_2(<>f__AnonymousType12<int, long> entry)
			{
				return 0;
			}

			// Token: 0x040097F6 RID: 38902
			[Token(Token = "0x40097F6")]
			[FieldOffset(Offset = "0x0")]
			public static readonly LootSimulationItemCounter.<>c <>9;

			// Token: 0x040097F7 RID: 38903
			[Token(Token = "0x40097F7")]
			[FieldOffset(Offset = "0x4")]
			public static Func<long, int, <>f__AnonymousType12<int, long>> <>9__8_0;

			// Token: 0x040097F8 RID: 38904
			[Token(Token = "0x40097F8")]
			[FieldOffset(Offset = "0x8")]
			public static Func<<>f__AnonymousType12<int, long>, bool> <>9__8_1;

			// Token: 0x040097F9 RID: 38905
			[Token(Token = "0x40097F9")]
			[FieldOffset(Offset = "0xC")]
			public static Func<<>f__AnonymousType12<int, long>, int> <>9__8_2;
		}
	}
}
