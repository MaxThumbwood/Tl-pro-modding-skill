using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent
{
	// Token: 0x02000966 RID: 2406
	[Token(Token = "0x2000966")]
	public static class EmergencyStacking
	{
		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06004FE3 RID: 20451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700098D")]
		private static EmergencyStacking.Group[] GroupLookup
		{
			[Token(Token = "0x6004FE3")]
			[Address(RVA = "0x757568", Offset = "0x757568", VA = "0x757568")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004FE4 RID: 20452 RVA: 0x00025380 File Offset: 0x00023580
		[Token(Token = "0x6004FE4")]
		[Address(RVA = "0x75790C", Offset = "0x75790C", VA = "0x75790C")]
		public static bool HasPendingTransferInvolving(WorldItem item)
		{
			return default(bool);
		}

		// Token: 0x06004FE5 RID: 20453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FE5")]
		[Address(RVA = "0x757AB4", Offset = "0x757AB4", VA = "0x757AB4")]
		public static void ClearPendingTransfersInvolving(WorldItem item)
		{
		}

		// Token: 0x06004FE6 RID: 20454 RVA: 0x00025398 File Offset: 0x00023598
		[Token(Token = "0x6004FE6")]
		[Address(RVA = "0x757C64", Offset = "0x757C64", VA = "0x757C64")]
		public static bool EmergencyStackItemsToMakeSpace(out int freeSlot)
		{
			return default(bool);
		}

		// Token: 0x06004FE7 RID: 20455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FE7")]
		[Address(RVA = "0x7589E0", Offset = "0x7589E0", VA = "0x7589E0")]
		public static void ProcessPendingTransfers()
		{
		}

		// Token: 0x06004FE8 RID: 20456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FE8")]
		[Address(RVA = "0x758444", Offset = "0x758444", VA = "0x758444")]
		private static void ProcessPendingTransfers(out int freeSlot)
		{
		}

		// Token: 0x06004FE9 RID: 20457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FE9")]
		[Address(RVA = "0x758A98", Offset = "0x758A98", VA = "0x758A98")]
		private static void UpdateDestinationFromPreviousTransfers(List<EmergencyStacking.Transfer> transfers, int i)
		{
		}

		// Token: 0x06004FEA RID: 20458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FEA")]
		[Address(RVA = "0x757DC0", Offset = "0x757DC0", VA = "0x757DC0")]
		private static EmergencyStacking.StackableItem[] MemoStackableItems()
		{
			return null;
		}

		// Token: 0x06004FEB RID: 20459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FEB")]
		[Address(RVA = "0x758E50", Offset = "0x758E50", VA = "0x758E50")]
		private static List<Rectangle> GetPlayerViewRects()
		{
			return null;
		}

		// Token: 0x06004FEC RID: 20460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FEC")]
		[Address(RVA = "0x758068", Offset = "0x758068", VA = "0x758068")]
		private static void FindBestTransfers(EmergencyStacking.StackableItem[] stackableItems, List<EmergencyStacking.Transfer> transfers, int limit)
		{
		}

		// Token: 0x06004FED RID: 20461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FED")]
		[Address(RVA = "0x758C1C", Offset = "0x758C1C", VA = "0x758C1C")]
		private static void DoTransfer(EmergencyStacking.Transfer t)
		{
		}

		// Token: 0x06004FEE RID: 20462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FEE")]
		[Address(RVA = "0x7587CC", Offset = "0x7587CC", VA = "0x7587CC")]
		private static void RequestOwnershipReleaseForPendingTransfers()
		{
		}

		// Token: 0x06004FEF RID: 20463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FEF")]
		[Address(RVA = "0x7594F8", Offset = "0x7594F8", VA = "0x7594F8")]
		private static void AddToOrderedList(List<EmergencyStacking.Transfer> list, int limit, EmergencyStacking.Transfer item)
		{
		}

		// Token: 0x06004FF0 RID: 20464 RVA: 0x000253B0 File Offset: 0x000235B0
		[Token(Token = "0x6004FF0")]
		[Address(RVA = "0x7590F0", Offset = "0x7590F0", VA = "0x7590F0")]
		private static bool AnyContains(List<Rectangle> rects, Point point)
		{
			return default(bool);
		}

		// Token: 0x06004FF1 RID: 20465 RVA: 0x000253C8 File Offset: 0x000235C8
		[Token(Token = "0x6004FF1")]
		[Address(RVA = "0x759388", Offset = "0x759388", VA = "0x759388")]
		private static int DistanceBetween(WorldItem a, WorldItem b)
		{
			return 0;
		}

		// Token: 0x06004FF2 RID: 20466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FF2")]
		[Address(RVA = "0x7598B0", Offset = "0x7598B0", VA = "0x7598B0")]
		private static void OnReachingMaxStack(WorldItem item)
		{
		}

		// Token: 0x040093C3 RID: 37827
		[Token(Token = "0x40093C3")]
		[FieldOffset(Offset = "0x0")]
		public static readonly List<EmergencyStacking.Group> PreservationOrder;

		// Token: 0x040093C4 RID: 37828
		[Token(Token = "0x40093C4")]
		[FieldOffset(Offset = "0x4")]
		private static readonly Point PlayerViewRectSize;

		// Token: 0x040093C5 RID: 37829
		[Token(Token = "0x40093C5")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int ItemsToStackEachTime;

		// Token: 0x040093C6 RID: 37830
		[Token(Token = "0x40093C6")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int MaxTransferDistance;

		// Token: 0x040093C7 RID: 37831
		[Token(Token = "0x40093C7")]
		[FieldOffset(Offset = "0x14")]
		private static readonly int OnScreenDistancePriorityPenalty;

		// Token: 0x040093C8 RID: 37832
		[Token(Token = "0x40093C8")]
		[FieldOffset(Offset = "0x18")]
		private static EmergencyStacking.Group[] _groupLookup;

		// Token: 0x040093C9 RID: 37833
		[Token(Token = "0x40093C9")]
		[FieldOffset(Offset = "0x1C")]
		private static readonly List<EmergencyStacking.Transfer> PendingTransfers;

		// Token: 0x040093CA RID: 37834
		[Token(Token = "0x40093CA")]
		[FieldOffset(Offset = "0x20")]
		private static readonly EmergencyStacking.StackableItem[] stackableItemsScratch;

		// Token: 0x040093CB RID: 37835
		[Token(Token = "0x40093CB")]
		[FieldOffset(Offset = "0x24")]
		private static readonly List<Rectangle> playerViewRectsScratch;

		// Token: 0x02000967 RID: 2407
		[Token(Token = "0x2000967")]
		public class Group
		{
			// Token: 0x06004FF4 RID: 20468 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004FF4")]
			[Address(RVA = "0x759E58", Offset = "0x759E58", VA = "0x759E58")]
			public Group()
			{
			}

			// Token: 0x06004FF5 RID: 20469 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004FF5")]
			[Address(RVA = "0x759F30", Offset = "0x759F30", VA = "0x759F30")]
			public Group(int type)
			{
			}

			// Token: 0x06004FF6 RID: 20470 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004FF6")]
			[Address(RVA = "0x75A1B8", Offset = "0x75A1B8", VA = "0x75A1B8")]
			public Group(Predicate<Item> condition)
			{
			}

			// Token: 0x06004FF7 RID: 20471 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004FF7")]
			[Address(RVA = "0x75A340", Offset = "0x75A340", VA = "0x75A340")]
			public EmergencyStacking.Group Add(Predicate<Item> condition)
			{
				return null;
			}

			// Token: 0x06004FF8 RID: 20472 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004FF8")]
			[Address(RVA = "0x75A018", Offset = "0x75A018", VA = "0x75A018")]
			public EmergencyStacking.Group Add(int type)
			{
				return null;
			}

			// Token: 0x06004FF9 RID: 20473 RVA: 0x000253E0 File Offset: 0x000235E0
			[Token(Token = "0x6004FF9")]
			[Address(RVA = "0x75A40C", Offset = "0x75A40C", VA = "0x75A40C")]
			public bool Contains(Item item)
			{
				return default(bool);
			}

			// Token: 0x040093CC RID: 37836
			[Token(Token = "0x40093CC")]
			[FieldOffset(Offset = "0x0")]
			public static readonly int DefaultStackDistanceStepSize;

			// Token: 0x040093CD RID: 37837
			[Token(Token = "0x40093CD")]
			[FieldOffset(Offset = "0x8")]
			public int DistanceStepSize;

			// Token: 0x040093CE RID: 37838
			[Token(Token = "0x40093CE")]
			[FieldOffset(Offset = "0xC")]
			private List<Predicate<Item>> Conditions;

			// Token: 0x040093CF RID: 37839
			[Token(Token = "0x40093CF")]
			[FieldOffset(Offset = "0x10")]
			internal int StackingPriority;

			// Token: 0x040093D0 RID: 37840
			[Token(Token = "0x40093D0")]
			[FieldOffset(Offset = "0x4")]
			public static EmergencyStacking.Group FallenStars;

			// Token: 0x040093D1 RID: 37841
			[Token(Token = "0x40093D1")]
			[FieldOffset(Offset = "0x8")]
			public static EmergencyStacking.Group CopperCoins;

			// Token: 0x040093D2 RID: 37842
			[Token(Token = "0x40093D2")]
			[FieldOffset(Offset = "0xC")]
			public static EmergencyStacking.Group SilverCoins;

			// Token: 0x040093D3 RID: 37843
			[Token(Token = "0x40093D3")]
			[FieldOffset(Offset = "0x10")]
			public static EmergencyStacking.Group Equipment;

			// Token: 0x040093D4 RID: 37844
			[Token(Token = "0x40093D4")]
			[FieldOffset(Offset = "0x14")]
			public static EmergencyStacking.Group RareCurrency;

			// Token: 0x040093D5 RID: 37845
			[Token(Token = "0x40093D5")]
			[FieldOffset(Offset = "0x18")]
			public static EmergencyStacking.Group Default;

			// Token: 0x02000968 RID: 2408
			[Token(Token = "0x2000968")]
			private sealed class <>c__DisplayClass8_0
			{
				// Token: 0x06004FFB RID: 20475 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004FFB")]
				[Address(RVA = "0x75A404", Offset = "0x75A404", VA = "0x75A404")]
				public <>c__DisplayClass8_0()
				{
				}

				// Token: 0x06004FFC RID: 20476 RVA: 0x000253F8 File Offset: 0x000235F8
				[Token(Token = "0x6004FFC")]
				[Address(RVA = "0x75A81C", Offset = "0x75A81C", VA = "0x75A81C")]
				internal bool <Add>b__0(Item item)
				{
					return default(bool);
				}

				// Token: 0x040093D6 RID: 37846
				[Token(Token = "0x40093D6")]
				[FieldOffset(Offset = "0x8")]
				public int type;
			}

			// Token: 0x02000969 RID: 2409
			[Token(Token = "0x2000969")]
			private sealed class <>c__DisplayClass9_0
			{
				// Token: 0x06004FFD RID: 20477 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004FFD")]
				[Address(RVA = "0x75A528", Offset = "0x75A528", VA = "0x75A528")]
				public <>c__DisplayClass9_0()
				{
				}

				// Token: 0x06004FFE RID: 20478 RVA: 0x00025410 File Offset: 0x00023610
				[Token(Token = "0x6004FFE")]
				[Address(RVA = "0x75A84C", Offset = "0x75A84C", VA = "0x75A84C")]
				internal bool <Contains>b__0(Predicate<Item> p)
				{
					return default(bool);
				}

				// Token: 0x040093D7 RID: 37847
				[Token(Token = "0x40093D7")]
				[FieldOffset(Offset = "0x8")]
				public Item item;
			}

			// Token: 0x0200096A RID: 2410
			[Token(Token = "0x200096A")]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x06005000 RID: 20480 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005000")]
				[Address(RVA = "0x75A8F0", Offset = "0x75A8F0", VA = "0x75A8F0")]
				public <>c()
				{
				}

				// Token: 0x06005001 RID: 20481 RVA: 0x00025428 File Offset: 0x00023628
				[Token(Token = "0x6005001")]
				[Address(RVA = "0x75A8F8", Offset = "0x75A8F8", VA = "0x75A8F8")]
				internal bool <.cctor>b__16_0(Item item)
				{
					return default(bool);
				}

				// Token: 0x06005002 RID: 20482 RVA: 0x00025440 File Offset: 0x00023640
				[Token(Token = "0x6005002")]
				[Address(RVA = "0x75A91C", Offset = "0x75A91C", VA = "0x75A91C")]
				internal bool <.cctor>b__16_1(Item item)
				{
					return default(bool);
				}

				// Token: 0x040093D8 RID: 37848
				[Token(Token = "0x40093D8")]
				[FieldOffset(Offset = "0x0")]
				public static readonly EmergencyStacking.Group.<>c <>9;
			}
		}

		// Token: 0x0200096B RID: 2411
		[Token(Token = "0x200096B")]
		private struct StackableItem
		{
			// Token: 0x06005003 RID: 20483 RVA: 0x00025458 File Offset: 0x00023658
			[Token(Token = "0x6005003")]
			[Address(RVA = "0x759314", Offset = "0x759314", VA = "0x759314")]
			public bool IsPreferredDestination(EmergencyStacking.StackableItem other)
			{
				return default(bool);
			}

			// Token: 0x040093D9 RID: 37849
			[Token(Token = "0x40093D9")]
			[FieldOffset(Offset = "0x0")]
			public int type;

			// Token: 0x040093DA RID: 37850
			[Token(Token = "0x40093DA")]
			[FieldOffset(Offset = "0x4")]
			public int age;

			// Token: 0x040093DB RID: 37851
			[Token(Token = "0x40093DB")]
			[FieldOffset(Offset = "0x8")]
			public bool isOnScreen;

			// Token: 0x040093DC RID: 37852
			[Token(Token = "0x40093DC")]
			[FieldOffset(Offset = "0xC")]
			public WorldItem item;
		}

		// Token: 0x0200096C RID: 2412
		[Token(Token = "0x200096C")]
		private struct Transfer : FileAPI
		{
			// Token: 0x06005004 RID: 20484 RVA: 0x00025470 File Offset: 0x00023670
			[Token(Token = "0x6005004")]
			[Address(RVA = "0x7594A4", Offset = "0x7594A4", VA = "0x7594A4", Slot = "4")]
			public int CompareTo(EmergencyStacking.Transfer other)
			{
				return 0;
			}

			// Token: 0x06005005 RID: 20485 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005005")]
			[Address(RVA = "0x75A924", Offset = "0x75A924", VA = "0x75A924", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x1700098E RID: 2446
			// (get) Token: 0x06005006 RID: 20486 RVA: 0x00025488 File Offset: 0x00023688
			[Token(Token = "0x1700098E")]
			public bool HasOwnership
			{
				[Token(Token = "0x6005006")]
				[Address(RVA = "0x7596A8", Offset = "0x7596A8", VA = "0x7596A8")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700098F RID: 2447
			// (get) Token: 0x06005007 RID: 20487 RVA: 0x000254A0 File Offset: 0x000236A0
			[Token(Token = "0x1700098F")]
			public int NumToTransfer
			{
				[Token(Token = "0x6005007")]
				[Address(RVA = "0x75976C", Offset = "0x75976C", VA = "0x75976C")]
				get
				{
					return 0;
				}
			}

			// Token: 0x040093DD RID: 37853
			[Token(Token = "0x40093DD")]
			[FieldOffset(Offset = "0x0")]
			public WorldItem src;

			// Token: 0x040093DE RID: 37854
			[Token(Token = "0x40093DE")]
			[FieldOffset(Offset = "0x4")]
			public WorldItem dst;

			// Token: 0x040093DF RID: 37855
			[Token(Token = "0x40093DF")]
			[FieldOffset(Offset = "0x8")]
			public int distanceOrder;

			// Token: 0x040093E0 RID: 37856
			[Token(Token = "0x40093E0")]
			[FieldOffset(Offset = "0xC")]
			public int preservationOrder;

			// Token: 0x040093E1 RID: 37857
			[Token(Token = "0x40093E1")]
			[FieldOffset(Offset = "0x10")]
			public int distance;
		}

		// Token: 0x0200096D RID: 2413
		[Token(Token = "0x200096D")]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x06005008 RID: 20488 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005008")]
			[Address(RVA = "0x75AB84", Offset = "0x75AB84", VA = "0x75AB84")]
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x06005009 RID: 20489 RVA: 0x000254B8 File Offset: 0x000236B8
			[Token(Token = "0x6005009")]
			[Address(RVA = "0x75AB8C", Offset = "0x75AB8C", VA = "0x75AB8C")]
			internal bool <get_GroupLookup>b__1(EmergencyStacking.Group g)
			{
				return default(bool);
			}

			// Token: 0x040093E2 RID: 37858
			[Token(Token = "0x40093E2")]
			[FieldOffset(Offset = "0x8")]
			public int t;
		}

		// Token: 0x0200096E RID: 2414
		[Token(Token = "0x200096E")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600500B RID: 20491 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600500B")]
			[Address(RVA = "0x75ACC4", Offset = "0x75ACC4", VA = "0x75ACC4")]
			public <>c()
			{
			}

			// Token: 0x0600500C RID: 20492 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600500C")]
			[Address(RVA = "0x75ACCC", Offset = "0x75ACCC", VA = "0x75ACCC")]
			internal EmergencyStacking.Group <get_GroupLookup>b__10_0(int t)
			{
				return null;
			}

			// Token: 0x0600500D RID: 20493 RVA: 0x000254D0 File Offset: 0x000236D0
			[Token(Token = "0x600500D")]
			[Address(RVA = "0x75AE1C", Offset = "0x75AE1C", VA = "0x75AE1C")]
			internal bool <ProcessPendingTransfers>b__16_0(EmergencyStacking.Transfer t)
			{
				return default(bool);
			}

			// Token: 0x040093E3 RID: 37859
			[Token(Token = "0x40093E3")]
			[FieldOffset(Offset = "0x0")]
			public static readonly EmergencyStacking.<>c <>9;

			// Token: 0x040093E4 RID: 37860
			[Token(Token = "0x40093E4")]
			[FieldOffset(Offset = "0x4")]
			public static Func<int, EmergencyStacking.Group> <>9__10_0;

			// Token: 0x040093E5 RID: 37861
			[Token(Token = "0x40093E5")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<EmergencyStacking.Transfer> <>9__16_0;
		}

		// Token: 0x0200096F RID: 2415
		[Token(Token = "0x200096F")]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x0600500E RID: 20494 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600500E")]
			[Address(RVA = "0x757AAC", Offset = "0x757AAC", VA = "0x757AAC")]
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x0600500F RID: 20495 RVA: 0x000254E8 File Offset: 0x000236E8
			[Token(Token = "0x600500F")]
			[Address(RVA = "0x75AE4C", Offset = "0x75AE4C", VA = "0x75AE4C")]
			internal bool <HasPendingTransferInvolving>b__0(EmergencyStacking.Transfer t)
			{
				return default(bool);
			}

			// Token: 0x040093E6 RID: 37862
			[Token(Token = "0x40093E6")]
			[FieldOffset(Offset = "0x8")]
			public WorldItem item;
		}

		// Token: 0x02000970 RID: 2416
		[Token(Token = "0x2000970")]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x06005010 RID: 20496 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005010")]
			[Address(RVA = "0x757C5C", Offset = "0x757C5C", VA = "0x757C5C")]
			public <>c__DisplayClass13_0()
			{
			}

			// Token: 0x06005011 RID: 20497 RVA: 0x00025500 File Offset: 0x00023700
			[Token(Token = "0x6005011")]
			[Address(RVA = "0x75AE70", Offset = "0x75AE70", VA = "0x75AE70")]
			internal bool <ClearPendingTransfersInvolving>b__0(EmergencyStacking.Transfer t)
			{
				return default(bool);
			}

			// Token: 0x040093E7 RID: 37863
			[Token(Token = "0x40093E7")]
			[FieldOffset(Offset = "0x8")]
			public WorldItem item;
		}
	}
}
