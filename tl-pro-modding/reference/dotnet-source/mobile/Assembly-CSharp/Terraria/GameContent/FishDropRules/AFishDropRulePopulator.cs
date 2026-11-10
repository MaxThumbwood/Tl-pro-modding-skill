using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.FishDropRules
{
	// Token: 0x02000AF2 RID: 2802
	[Token(Token = "0x2000AF2")]
	public abstract class AFishDropRulePopulator
	{
		// Token: 0x0600579D RID: 22429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600579D")]
		[Address(RVA = "0x850F24", Offset = "0x850F24", VA = "0x850F24")]
		public AFishDropRulePopulator(FishDropRuleList list)
		{
		}

		// Token: 0x0600579E RID: 22430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600579E")]
		[Address(RVA = "0x852EB8", Offset = "0x852EB8", VA = "0x852EB8")]
		protected void Add(FishRarityCondition tier, int chanceNominator, int chanceDenominator, int[] itemTypes, AFishingCondition[] conditions)
		{
		}

		// Token: 0x0600579F RID: 22431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600579F")]
		[Address(RVA = "0x852FD0", Offset = "0x852FD0", VA = "0x852FD0")]
		protected void Add(FishRarityCondition tier, int chanceNominator, int chanceDenominator, int itemType, AFishingCondition[] conditions)
		{
		}

		// Token: 0x060057A0 RID: 22432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057A0")]
		[Address(RVA = "0x853074", Offset = "0x853074", VA = "0x853074")]
		protected void Add(FishRarityCondition tier, int chanceDenominator, int[] itemTypes, AFishingCondition[] conditions)
		{
		}

		// Token: 0x060057A1 RID: 22433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057A1")]
		[Address(RVA = "0x8530A0", Offset = "0x8530A0", VA = "0x8530A0")]
		protected void Add(FishRarityCondition tier, int chanceDenominator, int itemType, AFishingCondition[] conditions)
		{
		}

		// Token: 0x060057A2 RID: 22434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057A2")]
		[Address(RVA = "0x853138", Offset = "0x853138", VA = "0x853138")]
		protected void AddQuestFish(FishRarityCondition tier, int chanceDenominator, int itemType, AFishingCondition[] conditions)
		{
		}

		// Token: 0x060057A3 RID: 22435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057A3")]
		[Address(RVA = "0x853384", Offset = "0x853384", VA = "0x853384")]
		protected void AddQuestFishForRemix(FishRarityCondition tier, int chanceDenominator, int itemType, AFishingCondition[] conditions)
		{
		}

		// Token: 0x060057A4 RID: 22436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057A4")]
		[Address(RVA = "0x853550", Offset = "0x853550", VA = "0x853550")]
		protected void AddWithHardmode(FishRarityCondition tier, int chanceDenominator, int itemTypeEarly, int itemTypeHard, AFishingCondition[] conditions)
		{
		}

		// Token: 0x060057A5 RID: 22437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057A5")]
		[Address(RVA = "0x8538A8", Offset = "0x8538A8", VA = "0x8538A8")]
		protected void AddStopper(AFishingCondition condition)
		{
		}

		// Token: 0x060057A6 RID: 22438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057A6")]
		[Address(RVA = "0x85306C", Offset = "0x85306C", VA = "0x85306C")]
		public int[] Group(int[] itemTypes)
		{
			return null;
		}

		// Token: 0x060057A7 RID: 22439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057A7")]
		[Address(RVA = "0x853304", Offset = "0x853304", VA = "0x853304")]
		protected AFishingCondition[] Join(AFishingCondition[] original, AFishingCondition[] additions)
		{
			return null;
		}

		// Token: 0x060057A8 RID: 22440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057A8")]
		[Address(RVA = "0x8539D8", Offset = "0x8539D8", VA = "0x8539D8")]
		protected AFishingCondition[] Join(AFishingCondition[] additions)
		{
			return null;
		}

		// Token: 0x060057A9 RID: 22441 RVA: 0x000289E0 File Offset: 0x00026BE0
		[Token(Token = "0x60057A9")]
		[Address(RVA = "0x8539E0", Offset = "0x8539E0", VA = "0x8539E0")]
		private static bool IsHardmode(bool state)
		{
			return default(bool);
		}

		// Token: 0x060057AA RID: 22442 RVA: 0x000289F8 File Offset: 0x00026BF8
		[Token(Token = "0x60057AA")]
		[Address(RVA = "0x853A54", Offset = "0x853A54", VA = "0x853A54")]
		private static bool IsOriginalOcean(FishingContext context)
		{
			return default(bool);
		}

		// Token: 0x04009901 RID: 39169
		[Token(Token = "0x4009901")]
		[FieldOffset(Offset = "0x8")]
		private FishDropRuleList _list;

		// Token: 0x04009902 RID: 39170
		[Token(Token = "0x4009902")]
		[FieldOffset(Offset = "0xC")]
		protected AFishingCondition HardMode;

		// Token: 0x04009903 RID: 39171
		[Token(Token = "0x4009903")]
		[FieldOffset(Offset = "0x10")]
		protected AFishingCondition EarlyMode;

		// Token: 0x04009904 RID: 39172
		[Token(Token = "0x4009904")]
		[FieldOffset(Offset = "0x14")]
		protected AFishingCondition InLava;

		// Token: 0x04009905 RID: 39173
		[Token(Token = "0x4009905")]
		[FieldOffset(Offset = "0x18")]
		protected AFishingCondition InHoney;

		// Token: 0x04009906 RID: 39174
		[Token(Token = "0x4009906")]
		[FieldOffset(Offset = "0x1C")]
		protected AFishingCondition Junk;

		// Token: 0x04009907 RID: 39175
		[Token(Token = "0x4009907")]
		[FieldOffset(Offset = "0x20")]
		protected AFishingCondition Crate;

		// Token: 0x04009908 RID: 39176
		[Token(Token = "0x4009908")]
		[FieldOffset(Offset = "0x24")]
		protected AFishingCondition AnyEnemies;

		// Token: 0x04009909 RID: 39177
		[Token(Token = "0x4009909")]
		[FieldOffset(Offset = "0x28")]
		protected AFishingCondition CanFishInLava;

		// Token: 0x0400990A RID: 39178
		[Token(Token = "0x400990A")]
		[FieldOffset(Offset = "0x2C")]
		protected AFishingCondition Dungeon;

		// Token: 0x0400990B RID: 39179
		[Token(Token = "0x400990B")]
		[FieldOffset(Offset = "0x30")]
		protected AFishingCondition Beach;

		// Token: 0x0400990C RID: 39180
		[Token(Token = "0x400990C")]
		[FieldOffset(Offset = "0x34")]
		protected AFishingCondition Hallow;

		// Token: 0x0400990D RID: 39181
		[Token(Token = "0x400990D")]
		[FieldOffset(Offset = "0x38")]
		protected AFishingCondition GlowingMushrooms;

		// Token: 0x0400990E RID: 39182
		[Token(Token = "0x400990E")]
		[FieldOffset(Offset = "0x3C")]
		protected AFishingCondition TrueDesert;

		// Token: 0x0400990F RID: 39183
		[Token(Token = "0x400990F")]
		[FieldOffset(Offset = "0x40")]
		protected AFishingCondition TrueSnow;

		// Token: 0x04009910 RID: 39184
		[Token(Token = "0x4009910")]
		[FieldOffset(Offset = "0x44")]
		protected AFishingCondition Remix;

		// Token: 0x04009911 RID: 39185
		[Token(Token = "0x4009911")]
		[FieldOffset(Offset = "0x48")]
		protected AFishingCondition Height1;

		// Token: 0x04009912 RID: 39186
		[Token(Token = "0x4009912")]
		[FieldOffset(Offset = "0x4C")]
		protected AFishingCondition Height1And2;

		// Token: 0x04009913 RID: 39187
		[Token(Token = "0x4009913")]
		[FieldOffset(Offset = "0x50")]
		protected AFishingCondition HeightAbove1;

		// Token: 0x04009914 RID: 39188
		[Token(Token = "0x4009914")]
		[FieldOffset(Offset = "0x54")]
		protected AFishingCondition HeightAboveAnd1;

		// Token: 0x04009915 RID: 39189
		[Token(Token = "0x4009915")]
		[FieldOffset(Offset = "0x58")]
		protected AFishingCondition HeightUnder2;

		// Token: 0x04009916 RID: 39190
		[Token(Token = "0x4009916")]
		[FieldOffset(Offset = "0x5C")]
		protected AFishingCondition HeightAbove2;

		// Token: 0x04009917 RID: 39191
		[Token(Token = "0x4009917")]
		[FieldOffset(Offset = "0x60")]
		protected AFishingCondition Height0;

		// Token: 0x04009918 RID: 39192
		[Token(Token = "0x4009918")]
		[FieldOffset(Offset = "0x64")]
		protected AFishingCondition Height2;

		// Token: 0x04009919 RID: 39193
		[Token(Token = "0x4009919")]
		[FieldOffset(Offset = "0x68")]
		protected AFishingCondition Height3;

		// Token: 0x0400991A RID: 39194
		[Token(Token = "0x400991A")]
		[FieldOffset(Offset = "0x6C")]
		protected AFishingCondition UnderRockLayer;

		// Token: 0x0400991B RID: 39195
		[Token(Token = "0x400991B")]
		[FieldOffset(Offset = "0x70")]
		protected AFishingCondition Corruption;

		// Token: 0x0400991C RID: 39196
		[Token(Token = "0x400991C")]
		[FieldOffset(Offset = "0x74")]
		protected AFishingCondition Crimson;

		// Token: 0x0400991D RID: 39197
		[Token(Token = "0x400991D")]
		[FieldOffset(Offset = "0x78")]
		protected AFishingCondition Jungle;

		// Token: 0x0400991E RID: 39198
		[Token(Token = "0x400991E")]
		[FieldOffset(Offset = "0x7C")]
		protected AFishingCondition Snow;

		// Token: 0x0400991F RID: 39199
		[Token(Token = "0x400991F")]
		[FieldOffset(Offset = "0x80")]
		protected AFishingCondition Desert;

		// Token: 0x04009920 RID: 39200
		[Token(Token = "0x4009920")]
		[FieldOffset(Offset = "0x84")]
		protected AFishingCondition RolledHallowDesert;

		// Token: 0x04009921 RID: 39201
		[Token(Token = "0x4009921")]
		[FieldOffset(Offset = "0x88")]
		protected AFishingCondition OriginalOcean;

		// Token: 0x04009922 RID: 39202
		[Token(Token = "0x4009922")]
		[FieldOffset(Offset = "0x8C")]
		protected AFishingCondition RemixOcean;

		// Token: 0x04009923 RID: 39203
		[Token(Token = "0x4009923")]
		[FieldOffset(Offset = "0x90")]
		protected AFishingCondition Ocean;

		// Token: 0x04009924 RID: 39204
		[Token(Token = "0x4009924")]
		[FieldOffset(Offset = "0x94")]
		protected AFishingCondition Water1000;

		// Token: 0x04009925 RID: 39205
		[Token(Token = "0x4009925")]
		[FieldOffset(Offset = "0x98")]
		protected AFishingCondition BloodMoon;

		// Token: 0x04009926 RID: 39206
		[Token(Token = "0x4009926")]
		[FieldOffset(Offset = "0x9C")]
		protected AFishingCondition DidNotUseCombatBook;

		// Token: 0x02000AF3 RID: 2803
		[Token(Token = "0x2000AF3")]
		private class DelegateFishingCondition : AFishingCondition
		{
			// Token: 0x060057AB RID: 22443 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60057AB")]
			[Address(RVA = "0x852E9C", Offset = "0x852E9C", VA = "0x852E9C")]
			public DelegateFishingCondition(AFishDropRulePopulator.DelegateFishingCondition.MatchCondition innerCondition)
			{
			}

			// Token: 0x060057AC RID: 22444 RVA: 0x00028A10 File Offset: 0x00026C10
			[Token(Token = "0x60057AC")]
			[Address(RVA = "0x853B0C", Offset = "0x853B0C", VA = "0x853B0C", Slot = "4")]
			public override bool Matches(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x04009927 RID: 39207
			[Token(Token = "0x4009927")]
			[FieldOffset(Offset = "0xC")]
			private AFishDropRulePopulator.DelegateFishingCondition.MatchCondition _condition;

			// Token: 0x02000AF4 RID: 2804
			// (Invoke) Token: 0x060057AE RID: 22446
			[Token(Token = "0x2000AF4")]
			public delegate bool MatchCondition(FishingContext context);
		}

		// Token: 0x02000AF5 RID: 2805
		[Token(Token = "0x2000AF5")]
		private class DelegateFishingRarityCondition : FishRarityCondition
		{
			// Token: 0x060057B1 RID: 22449 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60057B1")]
			[Address(RVA = "0x853B9C", Offset = "0x853B9C", VA = "0x853B9C")]
			public DelegateFishingRarityCondition(AFishDropRulePopulator.DelegateFishingRarityCondition.MatchCondition innerCondition)
			{
			}

			// Token: 0x060057B2 RID: 22450 RVA: 0x00028A28 File Offset: 0x00026C28
			[Token(Token = "0x60057B2")]
			[Address(RVA = "0x853BC0", Offset = "0x853BC0", VA = "0x853BC0", Slot = "4")]
			public override bool Matches(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x04009928 RID: 39208
			[Token(Token = "0x4009928")]
			[FieldOffset(Offset = "0x10")]
			private AFishDropRulePopulator.DelegateFishingRarityCondition.MatchCondition _condition;

			// Token: 0x02000AF6 RID: 2806
			// (Invoke) Token: 0x060057B4 RID: 22452
			[Token(Token = "0x2000AF6")]
			public delegate bool MatchCondition(FishingContext context);
		}

		// Token: 0x02000AF7 RID: 2807
		[Token(Token = "0x2000AF7")]
		protected class Rarity
		{
			// Token: 0x060057B7 RID: 22455 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60057B7")]
			[Address(RVA = "0x853DB4", Offset = "0x853DB4", VA = "0x853DB4")]
			public Rarity()
			{
			}

			// Token: 0x04009929 RID: 39209
			[Token(Token = "0x4009929")]
			[FieldOffset(Offset = "0x0")]
			public static FishRarityCondition Any;

			// Token: 0x0400992A RID: 39210
			[Token(Token = "0x400992A")]
			[FieldOffset(Offset = "0x4")]
			public static FishRarityCondition Legendary;

			// Token: 0x0400992B RID: 39211
			[Token(Token = "0x400992B")]
			[FieldOffset(Offset = "0x8")]
			public static FishRarityCondition VeryRare;

			// Token: 0x0400992C RID: 39212
			[Token(Token = "0x400992C")]
			[FieldOffset(Offset = "0xC")]
			public static FishRarityCondition Rare;

			// Token: 0x0400992D RID: 39213
			[Token(Token = "0x400992D")]
			[FieldOffset(Offset = "0x10")]
			public static FishRarityCondition Uncommon;

			// Token: 0x0400992E RID: 39214
			[Token(Token = "0x400992E")]
			[FieldOffset(Offset = "0x14")]
			public static FishRarityCondition Common;

			// Token: 0x0400992F RID: 39215
			[Token(Token = "0x400992F")]
			[FieldOffset(Offset = "0x18")]
			public static FishRarityCondition BombRarityOfNotLegendaryAndNotVeryRareAndUncommon;

			// Token: 0x04009930 RID: 39216
			[Token(Token = "0x4009930")]
			[FieldOffset(Offset = "0x1C")]
			public static FishRarityCondition UncommonOrCommon;

			// Token: 0x02000AF8 RID: 2808
			[Token(Token = "0x2000AF8")]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x060057BA RID: 22458 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60057BA")]
				[Address(RVA = "0x854444", Offset = "0x854444", VA = "0x854444")]
				public <>c()
				{
				}

				// Token: 0x060057BB RID: 22459 RVA: 0x00028A40 File Offset: 0x00026C40
				[Token(Token = "0x60057BB")]
				[Address(RVA = "0x85444C", Offset = "0x85444C", VA = "0x85444C")]
				internal bool <.cctor>b__9_0(FishingContext context)
				{
					return default(bool);
				}

				// Token: 0x060057BC RID: 22460 RVA: 0x00028A58 File Offset: 0x00026C58
				[Token(Token = "0x60057BC")]
				[Address(RVA = "0x854454", Offset = "0x854454", VA = "0x854454")]
				internal bool <.cctor>b__9_1(FishingContext context)
				{
					return default(bool);
				}

				// Token: 0x060057BD RID: 22461 RVA: 0x00028A70 File Offset: 0x00026C70
				[Token(Token = "0x60057BD")]
				[Address(RVA = "0x854478", Offset = "0x854478", VA = "0x854478")]
				internal bool <.cctor>b__9_2(FishingContext context)
				{
					return default(bool);
				}

				// Token: 0x060057BE RID: 22462 RVA: 0x00028A88 File Offset: 0x00026C88
				[Token(Token = "0x60057BE")]
				[Address(RVA = "0x85449C", Offset = "0x85449C", VA = "0x85449C")]
				internal bool <.cctor>b__9_3(FishingContext context)
				{
					return default(bool);
				}

				// Token: 0x060057BF RID: 22463 RVA: 0x00028AA0 File Offset: 0x00026CA0
				[Token(Token = "0x60057BF")]
				[Address(RVA = "0x8544C0", Offset = "0x8544C0", VA = "0x8544C0")]
				internal bool <.cctor>b__9_4(FishingContext context)
				{
					return default(bool);
				}

				// Token: 0x060057C0 RID: 22464 RVA: 0x00028AB8 File Offset: 0x00026CB8
				[Token(Token = "0x60057C0")]
				[Address(RVA = "0x8544E4", Offset = "0x8544E4", VA = "0x8544E4")]
				internal bool <.cctor>b__9_5(FishingContext context)
				{
					return default(bool);
				}

				// Token: 0x060057C1 RID: 22465 RVA: 0x00028AD0 File Offset: 0x00026CD0
				[Token(Token = "0x60057C1")]
				[Address(RVA = "0x854508", Offset = "0x854508", VA = "0x854508")]
				internal bool <.cctor>b__9_6(FishingContext context)
				{
					return default(bool);
				}

				// Token: 0x060057C2 RID: 22466 RVA: 0x00028AE8 File Offset: 0x00026CE8
				[Token(Token = "0x60057C2")]
				[Address(RVA = "0x854548", Offset = "0x854548", VA = "0x854548")]
				internal bool <.cctor>b__9_7(FishingContext context)
				{
					return default(bool);
				}

				// Token: 0x04009931 RID: 39217
				[Token(Token = "0x4009931")]
				[FieldOffset(Offset = "0x0")]
				public static readonly AFishDropRulePopulator.Rarity.<>c <>9;
			}
		}

		// Token: 0x02000AF9 RID: 2809
		[Token(Token = "0x2000AF9")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060057C4 RID: 22468 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60057C4")]
			[Address(RVA = "0x8545F0", Offset = "0x8545F0", VA = "0x8545F0")]
			public <>c()
			{
			}

			// Token: 0x060057C5 RID: 22469 RVA: 0x00028B00 File Offset: 0x00026D00
			[Token(Token = "0x60057C5")]
			[Address(RVA = "0x8545F8", Offset = "0x8545F8", VA = "0x8545F8")]
			internal bool <.ctor>b__1_0(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x060057C6 RID: 22470 RVA: 0x00028B18 File Offset: 0x00026D18
			[Token(Token = "0x60057C6")]
			[Address(RVA = "0x854668", Offset = "0x854668", VA = "0x854668")]
			internal bool <.ctor>b__1_1(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x060057C7 RID: 22471 RVA: 0x00028B30 File Offset: 0x00026D30
			[Token(Token = "0x60057C7")]
			[Address(RVA = "0x8546D4", Offset = "0x8546D4", VA = "0x8546D4")]
			internal bool <.ctor>b__1_2(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x060057C8 RID: 22472 RVA: 0x00028B48 File Offset: 0x00026D48
			[Token(Token = "0x60057C8")]
			[Address(RVA = "0x8546F8", Offset = "0x8546F8", VA = "0x8546F8")]
			internal bool <.ctor>b__1_3(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x060057C9 RID: 22473 RVA: 0x00028B60 File Offset: 0x00026D60
			[Token(Token = "0x60057C9")]
			[Address(RVA = "0x85471C", Offset = "0x85471C", VA = "0x85471C")]
			internal bool <.ctor>b__1_4(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x060057CA RID: 22474 RVA: 0x00028B78 File Offset: 0x00026D78
			[Token(Token = "0x60057CA")]
			[Address(RVA = "0x854740", Offset = "0x854740", VA = "0x854740")]
			internal bool <.ctor>b__1_5(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x060057CB RID: 22475 RVA: 0x00028B90 File Offset: 0x00026D90
			[Token(Token = "0x60057CB")]
			[Address(RVA = "0x854764", Offset = "0x854764", VA = "0x854764")]
			internal bool <.ctor>b__1_6(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x060057CC RID: 22476 RVA: 0x00028BA8 File Offset: 0x00026DA8
			[Token(Token = "0x60057CC")]
			[Address(RVA = "0x85478C", Offset = "0x85478C", VA = "0x85478C")]
			internal bool <.ctor>b__1_7(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x060057CD RID: 22477 RVA: 0x00028BC0 File Offset: 0x00026DC0
			[Token(Token = "0x60057CD")]
			[Address(RVA = "0x8547B0", Offset = "0x8547B0", VA = "0x8547B0")]
			internal bool <.ctor>b__1_8(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x060057CE RID: 22478 RVA: 0x00028BD8 File Offset: 0x00026DD8
			[Token(Token = "0x60057CE")]
			[Address(RVA = "0x854858", Offset = "0x854858", VA = "0x854858")]
			internal bool <.ctor>b__1_9(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x060057CF RID: 22479 RVA: 0x00028BF0 File Offset: 0x00026DF0
			[Token(Token = "0x60057CF")]
			[Address(RVA = "0x85488C", Offset = "0x85488C", VA = "0x85488C")]
			internal bool <.ctor>b__1_10(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x060057D0 RID: 22480 RVA: 0x00028C08 File Offset: 0x00026E08
			[Token(Token = "0x60057D0")]
			[Address(RVA = "0x8548C0", Offset = "0x8548C0", VA = "0x8548C0")]
			internal bool <.ctor>b__1_11(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x060057D1 RID: 22481 RVA: 0x00028C20 File Offset: 0x00026E20
			[Token(Token = "0x60057D1")]
			[Address(RVA = "0x8548F4", Offset = "0x8548F4", VA = "0x8548F4")]
			internal bool <.ctor>b__1_12(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x060057D2 RID: 22482 RVA: 0x00028C38 File Offset: 0x00026E38
			[Token(Token = "0x60057D2")]
			[Address(RVA = "0x854928", Offset = "0x854928", VA = "0x854928")]
			internal bool <.ctor>b__1_13(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x060057D3 RID: 22483 RVA: 0x00028C50 File Offset: 0x00026E50
			[Token(Token = "0x60057D3")]
			[Address(RVA = "0x85495C", Offset = "0x85495C", VA = "0x85495C")]
			internal bool <.ctor>b__1_14(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x060057D4 RID: 22484 RVA: 0x00028C68 File Offset: 0x00026E68
			[Token(Token = "0x60057D4")]
			[Address(RVA = "0x8549C0", Offset = "0x8549C0", VA = "0x8549C0")]
			internal bool <.ctor>b__1_15(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x060057D5 RID: 22485 RVA: 0x00028C80 File Offset: 0x00026E80
			[Token(Token = "0x60057D5")]
			[Address(RVA = "0x8549E8", Offset = "0x8549E8", VA = "0x8549E8")]
			internal bool <.ctor>b__1_16(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x060057D6 RID: 22486 RVA: 0x00028C98 File Offset: 0x00026E98
			[Token(Token = "0x60057D6")]
			[Address(RVA = "0x854A14", Offset = "0x854A14", VA = "0x854A14")]
			internal bool <.ctor>b__1_17(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x060057D7 RID: 22487 RVA: 0x00028CB0 File Offset: 0x00026EB0
			[Token(Token = "0x60057D7")]
			[Address(RVA = "0x854A3C", Offset = "0x854A3C", VA = "0x854A3C")]
			internal bool <.ctor>b__1_18(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x060057D8 RID: 22488 RVA: 0x00028CC8 File Offset: 0x00026EC8
			[Token(Token = "0x60057D8")]
			[Address(RVA = "0x854A64", Offset = "0x854A64", VA = "0x854A64")]
			internal bool <.ctor>b__1_19(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x060057D9 RID: 22489 RVA: 0x00028CE0 File Offset: 0x00026EE0
			[Token(Token = "0x60057D9")]
			[Address(RVA = "0x854A8C", Offset = "0x854A8C", VA = "0x854A8C")]
			internal bool <.ctor>b__1_20(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x060057DA RID: 22490 RVA: 0x00028CF8 File Offset: 0x00026EF8
			[Token(Token = "0x60057DA")]
			[Address(RVA = "0x854AB4", Offset = "0x854AB4", VA = "0x854AB4")]
			internal bool <.ctor>b__1_21(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x060057DB RID: 22491 RVA: 0x00028D10 File Offset: 0x00026F10
			[Token(Token = "0x60057DB")]
			[Address(RVA = "0x854AD8", Offset = "0x854AD8", VA = "0x854AD8")]
			internal bool <.ctor>b__1_22(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x060057DC RID: 22492 RVA: 0x00028D28 File Offset: 0x00026F28
			[Token(Token = "0x60057DC")]
			[Address(RVA = "0x854B00", Offset = "0x854B00", VA = "0x854B00")]
			internal bool <.ctor>b__1_23(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x060057DD RID: 22493 RVA: 0x00028D40 File Offset: 0x00026F40
			[Token(Token = "0x60057DD")]
			[Address(RVA = "0x854B28", Offset = "0x854B28", VA = "0x854B28")]
			internal bool <.ctor>b__1_24(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x060057DE RID: 22494 RVA: 0x00028D58 File Offset: 0x00026F58
			[Token(Token = "0x60057DE")]
			[Address(RVA = "0x854BB8", Offset = "0x854BB8", VA = "0x854BB8")]
			internal bool <.ctor>b__1_25(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x060057DF RID: 22495 RVA: 0x00028D70 File Offset: 0x00026F70
			[Token(Token = "0x60057DF")]
			[Address(RVA = "0x854BDC", Offset = "0x854BDC", VA = "0x854BDC")]
			internal bool <.ctor>b__1_26(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x060057E0 RID: 22496 RVA: 0x00028D88 File Offset: 0x00026F88
			[Token(Token = "0x60057E0")]
			[Address(RVA = "0x854C00", Offset = "0x854C00", VA = "0x854C00")]
			internal bool <.ctor>b__1_27(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x060057E1 RID: 22497 RVA: 0x00028DA0 File Offset: 0x00026FA0
			[Token(Token = "0x60057E1")]
			[Address(RVA = "0x854C24", Offset = "0x854C24", VA = "0x854C24")]
			internal bool <.ctor>b__1_28(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x060057E2 RID: 22498 RVA: 0x00028DB8 File Offset: 0x00026FB8
			[Token(Token = "0x60057E2")]
			[Address(RVA = "0x854C48", Offset = "0x854C48", VA = "0x854C48")]
			internal bool <.ctor>b__1_29(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x060057E3 RID: 22499 RVA: 0x00028DD0 File Offset: 0x00026FD0
			[Token(Token = "0x60057E3")]
			[Address(RVA = "0x854C6C", Offset = "0x854C6C", VA = "0x854C6C")]
			internal bool <.ctor>b__1_30(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x060057E4 RID: 22500 RVA: 0x00028DE8 File Offset: 0x00026FE8
			[Token(Token = "0x60057E4")]
			[Address(RVA = "0x854CB4", Offset = "0x854CB4", VA = "0x854CB4")]
			internal bool <.ctor>b__1_31(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x060057E5 RID: 22501 RVA: 0x00028E00 File Offset: 0x00027000
			[Token(Token = "0x60057E5")]
			[Address(RVA = "0x854D64", Offset = "0x854D64", VA = "0x854D64")]
			internal bool <.ctor>b__1_32(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x060057E6 RID: 22502 RVA: 0x00028E18 File Offset: 0x00027018
			[Token(Token = "0x60057E6")]
			[Address(RVA = "0x854D88", Offset = "0x854D88", VA = "0x854D88")]
			internal bool <.ctor>b__1_33(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x060057E7 RID: 22503 RVA: 0x00028E30 File Offset: 0x00027030
			[Token(Token = "0x60057E7")]
			[Address(RVA = "0x854E48", Offset = "0x854E48", VA = "0x854E48")]
			internal bool <.ctor>b__1_34(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x060057E8 RID: 22504 RVA: 0x00028E48 File Offset: 0x00027048
			[Token(Token = "0x60057E8")]
			[Address(RVA = "0x854E70", Offset = "0x854E70", VA = "0x854E70")]
			internal bool <.ctor>b__1_35(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x060057E9 RID: 22505 RVA: 0x00028E60 File Offset: 0x00027060
			[Token(Token = "0x60057E9")]
			[Address(RVA = "0x854ED4", Offset = "0x854ED4", VA = "0x854ED4")]
			internal bool <.ctor>b__1_36(FishingContext context)
			{
				return default(bool);
			}

			// Token: 0x04009932 RID: 39218
			[Token(Token = "0x4009932")]
			[FieldOffset(Offset = "0x0")]
			public static readonly AFishDropRulePopulator.<>c <>9;

			// Token: 0x04009933 RID: 39219
			[Token(Token = "0x4009933")]
			[FieldOffset(Offset = "0x4")]
			public static AFishDropRulePopulator.DelegateFishingCondition.MatchCondition <>9__1_0;

			// Token: 0x04009934 RID: 39220
			[Token(Token = "0x4009934")]
			[FieldOffset(Offset = "0x8")]
			public static AFishDropRulePopulator.DelegateFishingCondition.MatchCondition <>9__1_1;

			// Token: 0x04009935 RID: 39221
			[Token(Token = "0x4009935")]
			[FieldOffset(Offset = "0xC")]
			public static AFishDropRulePopulator.DelegateFishingCondition.MatchCondition <>9__1_2;

			// Token: 0x04009936 RID: 39222
			[Token(Token = "0x4009936")]
			[FieldOffset(Offset = "0x10")]
			public static AFishDropRulePopulator.DelegateFishingCondition.MatchCondition <>9__1_3;

			// Token: 0x04009937 RID: 39223
			[Token(Token = "0x4009937")]
			[FieldOffset(Offset = "0x14")]
			public static AFishDropRulePopulator.DelegateFishingCondition.MatchCondition <>9__1_4;

			// Token: 0x04009938 RID: 39224
			[Token(Token = "0x4009938")]
			[FieldOffset(Offset = "0x18")]
			public static AFishDropRulePopulator.DelegateFishingCondition.MatchCondition <>9__1_5;

			// Token: 0x04009939 RID: 39225
			[Token(Token = "0x4009939")]
			[FieldOffset(Offset = "0x1C")]
			public static AFishDropRulePopulator.DelegateFishingCondition.MatchCondition <>9__1_6;

			// Token: 0x0400993A RID: 39226
			[Token(Token = "0x400993A")]
			[FieldOffset(Offset = "0x20")]
			public static AFishDropRulePopulator.DelegateFishingCondition.MatchCondition <>9__1_7;

			// Token: 0x0400993B RID: 39227
			[Token(Token = "0x400993B")]
			[FieldOffset(Offset = "0x24")]
			public static AFishDropRulePopulator.DelegateFishingCondition.MatchCondition <>9__1_8;

			// Token: 0x0400993C RID: 39228
			[Token(Token = "0x400993C")]
			[FieldOffset(Offset = "0x28")]
			public static AFishDropRulePopulator.DelegateFishingCondition.MatchCondition <>9__1_9;

			// Token: 0x0400993D RID: 39229
			[Token(Token = "0x400993D")]
			[FieldOffset(Offset = "0x2C")]
			public static AFishDropRulePopulator.DelegateFishingCondition.MatchCondition <>9__1_10;

			// Token: 0x0400993E RID: 39230
			[Token(Token = "0x400993E")]
			[FieldOffset(Offset = "0x30")]
			public static AFishDropRulePopulator.DelegateFishingCondition.MatchCondition <>9__1_11;

			// Token: 0x0400993F RID: 39231
			[Token(Token = "0x400993F")]
			[FieldOffset(Offset = "0x34")]
			public static AFishDropRulePopulator.DelegateFishingCondition.MatchCondition <>9__1_12;

			// Token: 0x04009940 RID: 39232
			[Token(Token = "0x4009940")]
			[FieldOffset(Offset = "0x38")]
			public static AFishDropRulePopulator.DelegateFishingCondition.MatchCondition <>9__1_13;

			// Token: 0x04009941 RID: 39233
			[Token(Token = "0x4009941")]
			[FieldOffset(Offset = "0x3C")]
			public static AFishDropRulePopulator.DelegateFishingCondition.MatchCondition <>9__1_14;

			// Token: 0x04009942 RID: 39234
			[Token(Token = "0x4009942")]
			[FieldOffset(Offset = "0x40")]
			public static AFishDropRulePopulator.DelegateFishingCondition.MatchCondition <>9__1_15;

			// Token: 0x04009943 RID: 39235
			[Token(Token = "0x4009943")]
			[FieldOffset(Offset = "0x44")]
			public static AFishDropRulePopulator.DelegateFishingCondition.MatchCondition <>9__1_16;

			// Token: 0x04009944 RID: 39236
			[Token(Token = "0x4009944")]
			[FieldOffset(Offset = "0x48")]
			public static AFishDropRulePopulator.DelegateFishingCondition.MatchCondition <>9__1_17;

			// Token: 0x04009945 RID: 39237
			[Token(Token = "0x4009945")]
			[FieldOffset(Offset = "0x4C")]
			public static AFishDropRulePopulator.DelegateFishingCondition.MatchCondition <>9__1_18;

			// Token: 0x04009946 RID: 39238
			[Token(Token = "0x4009946")]
			[FieldOffset(Offset = "0x50")]
			public static AFishDropRulePopulator.DelegateFishingCondition.MatchCondition <>9__1_19;

			// Token: 0x04009947 RID: 39239
			[Token(Token = "0x4009947")]
			[FieldOffset(Offset = "0x54")]
			public static AFishDropRulePopulator.DelegateFishingCondition.MatchCondition <>9__1_20;

			// Token: 0x04009948 RID: 39240
			[Token(Token = "0x4009948")]
			[FieldOffset(Offset = "0x58")]
			public static AFishDropRulePopulator.DelegateFishingCondition.MatchCondition <>9__1_21;

			// Token: 0x04009949 RID: 39241
			[Token(Token = "0x4009949")]
			[FieldOffset(Offset = "0x5C")]
			public static AFishDropRulePopulator.DelegateFishingCondition.MatchCondition <>9__1_22;

			// Token: 0x0400994A RID: 39242
			[Token(Token = "0x400994A")]
			[FieldOffset(Offset = "0x60")]
			public static AFishDropRulePopulator.DelegateFishingCondition.MatchCondition <>9__1_23;

			// Token: 0x0400994B RID: 39243
			[Token(Token = "0x400994B")]
			[FieldOffset(Offset = "0x64")]
			public static AFishDropRulePopulator.DelegateFishingCondition.MatchCondition <>9__1_24;

			// Token: 0x0400994C RID: 39244
			[Token(Token = "0x400994C")]
			[FieldOffset(Offset = "0x68")]
			public static AFishDropRulePopulator.DelegateFishingCondition.MatchCondition <>9__1_25;

			// Token: 0x0400994D RID: 39245
			[Token(Token = "0x400994D")]
			[FieldOffset(Offset = "0x6C")]
			public static AFishDropRulePopulator.DelegateFishingCondition.MatchCondition <>9__1_26;

			// Token: 0x0400994E RID: 39246
			[Token(Token = "0x400994E")]
			[FieldOffset(Offset = "0x70")]
			public static AFishDropRulePopulator.DelegateFishingCondition.MatchCondition <>9__1_27;

			// Token: 0x0400994F RID: 39247
			[Token(Token = "0x400994F")]
			[FieldOffset(Offset = "0x74")]
			public static AFishDropRulePopulator.DelegateFishingCondition.MatchCondition <>9__1_28;

			// Token: 0x04009950 RID: 39248
			[Token(Token = "0x4009950")]
			[FieldOffset(Offset = "0x78")]
			public static AFishDropRulePopulator.DelegateFishingCondition.MatchCondition <>9__1_29;

			// Token: 0x04009951 RID: 39249
			[Token(Token = "0x4009951")]
			[FieldOffset(Offset = "0x7C")]
			public static AFishDropRulePopulator.DelegateFishingCondition.MatchCondition <>9__1_30;

			// Token: 0x04009952 RID: 39250
			[Token(Token = "0x4009952")]
			[FieldOffset(Offset = "0x80")]
			public static AFishDropRulePopulator.DelegateFishingCondition.MatchCondition <>9__1_31;

			// Token: 0x04009953 RID: 39251
			[Token(Token = "0x4009953")]
			[FieldOffset(Offset = "0x84")]
			public static AFishDropRulePopulator.DelegateFishingCondition.MatchCondition <>9__1_32;

			// Token: 0x04009954 RID: 39252
			[Token(Token = "0x4009954")]
			[FieldOffset(Offset = "0x88")]
			public static AFishDropRulePopulator.DelegateFishingCondition.MatchCondition <>9__1_33;

			// Token: 0x04009955 RID: 39253
			[Token(Token = "0x4009955")]
			[FieldOffset(Offset = "0x8C")]
			public static AFishDropRulePopulator.DelegateFishingCondition.MatchCondition <>9__1_34;

			// Token: 0x04009956 RID: 39254
			[Token(Token = "0x4009956")]
			[FieldOffset(Offset = "0x90")]
			public static AFishDropRulePopulator.DelegateFishingCondition.MatchCondition <>9__1_35;

			// Token: 0x04009957 RID: 39255
			[Token(Token = "0x4009957")]
			[FieldOffset(Offset = "0x94")]
			public static AFishDropRulePopulator.DelegateFishingCondition.MatchCondition <>9__1_36;
		}
	}
}
