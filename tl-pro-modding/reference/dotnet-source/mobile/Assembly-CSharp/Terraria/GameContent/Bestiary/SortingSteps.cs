using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000BDF RID: 3039
	[Token(Token = "0x2000BDF")]
	public static class SortingSteps
	{
		// Token: 0x02000BE0 RID: 3040
		[Token(Token = "0x2000BE0")]
		public class ByNetId : FileAPI, GUIControllerItem, GUIControllerItem
		{
			// Token: 0x17000A3D RID: 2621
			// (get) Token: 0x06005BF1 RID: 23537 RVA: 0x0002B1D0 File Offset: 0x000293D0
			[Token(Token = "0x17000A3D")]
			public bool HiddenFromSortOptions
			{
				[Token(Token = "0x6005BF1")]
				[Address(RVA = "0x998C04", Offset = "0x998C04", VA = "0x998C04", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06005BF2 RID: 23538 RVA: 0x0002B1E8 File Offset: 0x000293E8
			[Token(Token = "0x6005BF2")]
			[Address(RVA = "0x998C0C", Offset = "0x998C0C", VA = "0x998C0C", Slot = "6")]
			public int Compare(BestiaryEntry x, BestiaryEntry y)
			{
				return 0;
			}

			// Token: 0x06005BF3 RID: 23539 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005BF3")]
			[Address(RVA = "0x998EF8", Offset = "0x998EF8", VA = "0x998EF8", Slot = "5")]
			public string GetDisplayNameKey()
			{
				return null;
			}

			// Token: 0x06005BF4 RID: 23540 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005BF4")]
			[Address(RVA = "0x998F40", Offset = "0x998F40", VA = "0x998F40")]
			public ByNetId()
			{
			}

			// Token: 0x02000BE1 RID: 3041
			[Token(Token = "0x2000BE1")]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x06005BF6 RID: 23542 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005BF6")]
				[Address(RVA = "0x998FBC", Offset = "0x998FBC", VA = "0x998FBC")]
				public <>c()
				{
				}

				// Token: 0x06005BF7 RID: 23543 RVA: 0x0002B200 File Offset: 0x00029400
				[Token(Token = "0x6005BF7")]
				[Address(RVA = "0x998FC4", Offset = "0x998FC4", VA = "0x998FC4")]
				internal bool <Compare>b__2_0(IBestiaryInfoElement element)
				{
					return default(bool);
				}

				// Token: 0x06005BF8 RID: 23544 RVA: 0x0002B218 File Offset: 0x00029418
				[Token(Token = "0x6005BF8")]
				[Address(RVA = "0x999048", Offset = "0x999048", VA = "0x999048")]
				internal bool <Compare>b__2_1(IBestiaryInfoElement element)
				{
					return default(bool);
				}

				// Token: 0x04009CDA RID: 40154
				[Token(Token = "0x4009CDA")]
				[FieldOffset(Offset = "0x0")]
				public static readonly SortingSteps.ByNetId.<>c <>9;

				// Token: 0x04009CDB RID: 40155
				[Token(Token = "0x4009CDB")]
				[FieldOffset(Offset = "0x4")]
				public static Func<IBestiaryInfoElement, bool> <>9__2_0;

				// Token: 0x04009CDC RID: 40156
				[Token(Token = "0x4009CDC")]
				[FieldOffset(Offset = "0x8")]
				public static Func<IBestiaryInfoElement, bool> <>9__2_1;
			}
		}

		// Token: 0x02000BE2 RID: 3042
		[Token(Token = "0x2000BE2")]
		public class ByUnlockState : FileAPI, GUIControllerItem, GUIControllerItem
		{
			// Token: 0x17000A3E RID: 2622
			// (get) Token: 0x06005BF9 RID: 23545 RVA: 0x0002B230 File Offset: 0x00029430
			[Token(Token = "0x17000A3E")]
			public bool HiddenFromSortOptions
			{
				[Token(Token = "0x6005BF9")]
				[Address(RVA = "0x9990CC", Offset = "0x9990CC", VA = "0x9990CC", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06005BFA RID: 23546 RVA: 0x0002B248 File Offset: 0x00029448
			[Token(Token = "0x6005BFA")]
			[Address(RVA = "0x9990D4", Offset = "0x9990D4", VA = "0x9990D4", Slot = "6")]
			public int Compare(BestiaryEntry x, BestiaryEntry y)
			{
				return 0;
			}

			// Token: 0x06005BFB RID: 23547 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005BFB")]
			[Address(RVA = "0x9993A4", Offset = "0x9993A4", VA = "0x9993A4", Slot = "5")]
			public string GetDisplayNameKey()
			{
				return null;
			}

			// Token: 0x06005BFC RID: 23548 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005BFC")]
			[Address(RVA = "0x9993EC", Offset = "0x9993EC", VA = "0x9993EC")]
			public ByUnlockState()
			{
			}
		}

		// Token: 0x02000BE3 RID: 3043
		[Token(Token = "0x2000BE3")]
		public class ByBestiarySortingId : FileAPI, GUIControllerItem, GUIControllerItem
		{
			// Token: 0x17000A3F RID: 2623
			// (get) Token: 0x06005BFD RID: 23549 RVA: 0x0002B260 File Offset: 0x00029460
			[Token(Token = "0x17000A3F")]
			public bool HiddenFromSortOptions
			{
				[Token(Token = "0x6005BFD")]
				[Address(RVA = "0x9993F4", Offset = "0x9993F4", VA = "0x9993F4", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06005BFE RID: 23550 RVA: 0x0002B278 File Offset: 0x00029478
			[Token(Token = "0x6005BFE")]
			[Address(RVA = "0x9993FC", Offset = "0x9993FC", VA = "0x9993FC", Slot = "6")]
			public int Compare(BestiaryEntry x, BestiaryEntry y)
			{
				return 0;
			}

			// Token: 0x06005BFF RID: 23551 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005BFF")]
			[Address(RVA = "0x999784", Offset = "0x999784", VA = "0x999784", Slot = "5")]
			public string GetDisplayNameKey()
			{
				return null;
			}

			// Token: 0x06005C00 RID: 23552 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005C00")]
			[Address(RVA = "0x9997CC", Offset = "0x9997CC", VA = "0x9997CC")]
			public ByBestiarySortingId()
			{
			}

			// Token: 0x02000BE4 RID: 3044
			[Token(Token = "0x2000BE4")]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x06005C02 RID: 23554 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005C02")]
				[Address(RVA = "0x999848", Offset = "0x999848", VA = "0x999848")]
				public <>c()
				{
				}

				// Token: 0x06005C03 RID: 23555 RVA: 0x0002B290 File Offset: 0x00029490
				[Token(Token = "0x6005C03")]
				[Address(RVA = "0x999850", Offset = "0x999850", VA = "0x999850")]
				internal bool <Compare>b__2_0(IBestiaryInfoElement element)
				{
					return default(bool);
				}

				// Token: 0x06005C04 RID: 23556 RVA: 0x0002B2A8 File Offset: 0x000294A8
				[Token(Token = "0x6005C04")]
				[Address(RVA = "0x9998D4", Offset = "0x9998D4", VA = "0x9998D4")]
				internal bool <Compare>b__2_1(IBestiaryInfoElement element)
				{
					return default(bool);
				}

				// Token: 0x04009CDD RID: 40157
				[Token(Token = "0x4009CDD")]
				[FieldOffset(Offset = "0x0")]
				public static readonly SortingSteps.ByBestiarySortingId.<>c <>9;

				// Token: 0x04009CDE RID: 40158
				[Token(Token = "0x4009CDE")]
				[FieldOffset(Offset = "0x4")]
				public static Func<IBestiaryInfoElement, bool> <>9__2_0;

				// Token: 0x04009CDF RID: 40159
				[Token(Token = "0x4009CDF")]
				[FieldOffset(Offset = "0x8")]
				public static Func<IBestiaryInfoElement, bool> <>9__2_1;
			}
		}

		// Token: 0x02000BE5 RID: 3045
		[Token(Token = "0x2000BE5")]
		public class ByBestiaryRarity : FileAPI, GUIControllerItem, GUIControllerItem
		{
			// Token: 0x17000A40 RID: 2624
			// (get) Token: 0x06005C05 RID: 23557 RVA: 0x0002B2C0 File Offset: 0x000294C0
			[Token(Token = "0x17000A40")]
			public bool HiddenFromSortOptions
			{
				[Token(Token = "0x6005C05")]
				[Address(RVA = "0x999958", Offset = "0x999958", VA = "0x999958", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06005C06 RID: 23558 RVA: 0x0002B2D8 File Offset: 0x000294D8
			[Token(Token = "0x6005C06")]
			[Address(RVA = "0x999960", Offset = "0x999960", VA = "0x999960", Slot = "6")]
			public int Compare(BestiaryEntry x, BestiaryEntry y)
			{
				return 0;
			}

			// Token: 0x06005C07 RID: 23559 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005C07")]
			[Address(RVA = "0x999CEC", Offset = "0x999CEC", VA = "0x999CEC", Slot = "5")]
			public string GetDisplayNameKey()
			{
				return null;
			}

			// Token: 0x06005C08 RID: 23560 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005C08")]
			[Address(RVA = "0x999D34", Offset = "0x999D34", VA = "0x999D34")]
			public ByBestiaryRarity()
			{
			}

			// Token: 0x02000BE6 RID: 3046
			[Token(Token = "0x2000BE6")]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x06005C0A RID: 23562 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005C0A")]
				[Address(RVA = "0x999DB0", Offset = "0x999DB0", VA = "0x999DB0")]
				public <>c()
				{
				}

				// Token: 0x06005C0B RID: 23563 RVA: 0x0002B2F0 File Offset: 0x000294F0
				[Token(Token = "0x6005C0B")]
				[Address(RVA = "0x999DB8", Offset = "0x999DB8", VA = "0x999DB8")]
				internal bool <Compare>b__2_0(IBestiaryInfoElement element)
				{
					return default(bool);
				}

				// Token: 0x06005C0C RID: 23564 RVA: 0x0002B308 File Offset: 0x00029508
				[Token(Token = "0x6005C0C")]
				[Address(RVA = "0x999E3C", Offset = "0x999E3C", VA = "0x999E3C")]
				internal bool <Compare>b__2_1(IBestiaryInfoElement element)
				{
					return default(bool);
				}

				// Token: 0x04009CE0 RID: 40160
				[Token(Token = "0x4009CE0")]
				[FieldOffset(Offset = "0x0")]
				public static readonly SortingSteps.ByBestiaryRarity.<>c <>9;

				// Token: 0x04009CE1 RID: 40161
				[Token(Token = "0x4009CE1")]
				[FieldOffset(Offset = "0x4")]
				public static Func<IBestiaryInfoElement, bool> <>9__2_0;

				// Token: 0x04009CE2 RID: 40162
				[Token(Token = "0x4009CE2")]
				[FieldOffset(Offset = "0x8")]
				public static Func<IBestiaryInfoElement, bool> <>9__2_1;
			}
		}

		// Token: 0x02000BE7 RID: 3047
		[Token(Token = "0x2000BE7")]
		public class Alphabetical : FileAPI, GUIControllerItem, GUIControllerItem
		{
			// Token: 0x17000A41 RID: 2625
			// (get) Token: 0x06005C0D RID: 23565 RVA: 0x0002B320 File Offset: 0x00029520
			[Token(Token = "0x17000A41")]
			public bool HiddenFromSortOptions
			{
				[Token(Token = "0x6005C0D")]
				[Address(RVA = "0x999EC0", Offset = "0x999EC0", VA = "0x999EC0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06005C0E RID: 23566 RVA: 0x0002B338 File Offset: 0x00029538
			[Token(Token = "0x6005C0E")]
			[Address(RVA = "0x999EC8", Offset = "0x999EC8", VA = "0x999EC8", Slot = "6")]
			public int Compare(BestiaryEntry x, BestiaryEntry y)
			{
				return 0;
			}

			// Token: 0x06005C0F RID: 23567 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005C0F")]
			[Address(RVA = "0x99A2CC", Offset = "0x99A2CC", VA = "0x99A2CC", Slot = "5")]
			public string GetDisplayNameKey()
			{
				return null;
			}

			// Token: 0x06005C10 RID: 23568 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005C10")]
			[Address(RVA = "0x99A314", Offset = "0x99A314", VA = "0x99A314")]
			public Alphabetical()
			{
			}

			// Token: 0x02000BE8 RID: 3048
			[Token(Token = "0x2000BE8")]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x06005C12 RID: 23570 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005C12")]
				[Address(RVA = "0x99A390", Offset = "0x99A390", VA = "0x99A390")]
				public <>c()
				{
				}

				// Token: 0x06005C13 RID: 23571 RVA: 0x0002B350 File Offset: 0x00029550
				[Token(Token = "0x6005C13")]
				[Address(RVA = "0x99A398", Offset = "0x99A398", VA = "0x99A398")]
				internal bool <Compare>b__2_0(IBestiaryInfoElement element)
				{
					return default(bool);
				}

				// Token: 0x06005C14 RID: 23572 RVA: 0x0002B368 File Offset: 0x00029568
				[Token(Token = "0x6005C14")]
				[Address(RVA = "0x99A41C", Offset = "0x99A41C", VA = "0x99A41C")]
				internal bool <Compare>b__2_1(IBestiaryInfoElement element)
				{
					return default(bool);
				}

				// Token: 0x04009CE3 RID: 40163
				[Token(Token = "0x4009CE3")]
				[FieldOffset(Offset = "0x0")]
				public static readonly SortingSteps.Alphabetical.<>c <>9;

				// Token: 0x04009CE4 RID: 40164
				[Token(Token = "0x4009CE4")]
				[FieldOffset(Offset = "0x4")]
				public static Func<IBestiaryInfoElement, bool> <>9__2_0;

				// Token: 0x04009CE5 RID: 40165
				[Token(Token = "0x4009CE5")]
				[FieldOffset(Offset = "0x8")]
				public static Func<IBestiaryInfoElement, bool> <>9__2_1;
			}
		}

		// Token: 0x02000BE9 RID: 3049
		[Token(Token = "0x2000BE9")]
		public abstract class ByStat : FileAPI, GUIControllerItem, GUIControllerItem
		{
			// Token: 0x17000A42 RID: 2626
			// (get) Token: 0x06005C15 RID: 23573 RVA: 0x0002B380 File Offset: 0x00029580
			[Token(Token = "0x17000A42")]
			public bool HiddenFromSortOptions
			{
				[Token(Token = "0x6005C15")]
				[Address(RVA = "0x99A4A0", Offset = "0x99A4A0", VA = "0x99A4A0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06005C16 RID: 23574 RVA: 0x0002B398 File Offset: 0x00029598
			[Token(Token = "0x6005C16")]
			[Address(RVA = "0x99A4A8", Offset = "0x99A4A8", VA = "0x99A4A8", Slot = "6")]
			public int Compare(BestiaryEntry x, BestiaryEntry y)
			{
				return 0;
			}

			// Token: 0x06005C17 RID: 23575
			[Token(Token = "0x6005C17")]
			public abstract int Compare(NPCStatsReportInfoElement cardX, NPCStatsReportInfoElement cardY);

			// Token: 0x06005C18 RID: 23576
			[Token(Token = "0x6005C18")]
			public abstract string GetDisplayNameKey();

			// Token: 0x06005C19 RID: 23577 RVA: 0x0002B3B0 File Offset: 0x000295B0
			[Token(Token = "0x6005C19")]
			[Address(RVA = "0x99A6CC", Offset = "0x99A6CC", VA = "0x99A6CC")]
			private bool IsAStatsCardINeed(IBestiaryInfoElement element)
			{
				return default(bool);
			}

			// Token: 0x06005C1A RID: 23578 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005C1A")]
			[Address(RVA = "0x99A750", Offset = "0x99A750", VA = "0x99A750")]
			protected ByStat()
			{
			}

			// Token: 0x06005C1B RID: 23579 RVA: 0x0002B3C8 File Offset: 0x000295C8
			[Token(Token = "0x6005C1B")]
			[Address(RVA = "0x99A758", Offset = "0x99A758", VA = "0x99A758")]
			private bool <Compare>b__2_0(IBestiaryInfoElement element)
			{
				return default(bool);
			}

			// Token: 0x06005C1C RID: 23580 RVA: 0x0002B3E0 File Offset: 0x000295E0
			[Token(Token = "0x6005C1C")]
			[Address(RVA = "0x99A7DC", Offset = "0x99A7DC", VA = "0x99A7DC")]
			private bool <Compare>b__2_1(IBestiaryInfoElement element)
			{
				return default(bool);
			}
		}

		// Token: 0x02000BEA RID: 3050
		[Token(Token = "0x2000BEA")]
		public class ByAttack : SortingSteps.ByStat
		{
			// Token: 0x06005C1D RID: 23581 RVA: 0x0002B3F8 File Offset: 0x000295F8
			[Token(Token = "0x6005C1D")]
			[Address(RVA = "0x99A860", Offset = "0x99A860", VA = "0x99A860", Slot = "7")]
			public override int Compare(NPCStatsReportInfoElement cardX, NPCStatsReportInfoElement cardY)
			{
				return 0;
			}

			// Token: 0x06005C1E RID: 23582 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005C1E")]
			[Address(RVA = "0x99A89C", Offset = "0x99A89C", VA = "0x99A89C", Slot = "8")]
			public override string GetDisplayNameKey()
			{
				return null;
			}

			// Token: 0x06005C1F RID: 23583 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005C1F")]
			[Address(RVA = "0x99A8E4", Offset = "0x99A8E4", VA = "0x99A8E4")]
			public ByAttack()
			{
			}
		}

		// Token: 0x02000BEB RID: 3051
		[Token(Token = "0x2000BEB")]
		public class ByDefense : SortingSteps.ByStat
		{
			// Token: 0x06005C20 RID: 23584 RVA: 0x0002B410 File Offset: 0x00029610
			[Token(Token = "0x6005C20")]
			[Address(RVA = "0x99A8EC", Offset = "0x99A8EC", VA = "0x99A8EC", Slot = "7")]
			public override int Compare(NPCStatsReportInfoElement cardX, NPCStatsReportInfoElement cardY)
			{
				return 0;
			}

			// Token: 0x06005C21 RID: 23585 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005C21")]
			[Address(RVA = "0x99A928", Offset = "0x99A928", VA = "0x99A928", Slot = "8")]
			public override string GetDisplayNameKey()
			{
				return null;
			}

			// Token: 0x06005C22 RID: 23586 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005C22")]
			[Address(RVA = "0x99A970", Offset = "0x99A970", VA = "0x99A970")]
			public ByDefense()
			{
			}
		}

		// Token: 0x02000BEC RID: 3052
		[Token(Token = "0x2000BEC")]
		public class ByCoins : SortingSteps.ByStat
		{
			// Token: 0x06005C23 RID: 23587 RVA: 0x0002B428 File Offset: 0x00029628
			[Token(Token = "0x6005C23")]
			[Address(RVA = "0x99A978", Offset = "0x99A978", VA = "0x99A978", Slot = "7")]
			public override int Compare(NPCStatsReportInfoElement cardX, NPCStatsReportInfoElement cardY)
			{
				return 0;
			}

			// Token: 0x06005C24 RID: 23588 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005C24")]
			[Address(RVA = "0x99A9B4", Offset = "0x99A9B4", VA = "0x99A9B4", Slot = "8")]
			public override string GetDisplayNameKey()
			{
				return null;
			}

			// Token: 0x06005C25 RID: 23589 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005C25")]
			[Address(RVA = "0x99A9FC", Offset = "0x99A9FC", VA = "0x99A9FC")]
			public ByCoins()
			{
			}
		}

		// Token: 0x02000BED RID: 3053
		[Token(Token = "0x2000BED")]
		public class ByHP : SortingSteps.ByStat
		{
			// Token: 0x06005C26 RID: 23590 RVA: 0x0002B440 File Offset: 0x00029640
			[Token(Token = "0x6005C26")]
			[Address(RVA = "0x99AA04", Offset = "0x99AA04", VA = "0x99AA04", Slot = "7")]
			public override int Compare(NPCStatsReportInfoElement cardX, NPCStatsReportInfoElement cardY)
			{
				return 0;
			}

			// Token: 0x06005C27 RID: 23591 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005C27")]
			[Address(RVA = "0x99AA40", Offset = "0x99AA40", VA = "0x99AA40", Slot = "8")]
			public override string GetDisplayNameKey()
			{
				return null;
			}

			// Token: 0x06005C28 RID: 23592 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005C28")]
			[Address(RVA = "0x99AA88", Offset = "0x99AA88", VA = "0x99AA88")]
			public ByHP()
			{
			}
		}
	}
}
